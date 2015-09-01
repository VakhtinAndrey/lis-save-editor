using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LifeIsStrangeSaveEditor.Win
{
    public static class StreamExtensions
    {
        #region Read extensions
        public static int ReadInt32(this Stream stream)
        {
            var buffer = new byte[4];
            stream.Read(buffer, 0, 4);
            return BitConverter.ToInt32(buffer, 0);
        }

        public static float ReadFloat(this Stream stream)
        {
            var buffer = new byte[4];
            stream.Read(buffer, 0, 4);
            return BitConverter.ToSingle(buffer, 0);
        }

        public static bool ReadBool(this Stream stream)
        {
            return Convert.ToBoolean(stream.ReadByte());
        }

        public static string ReadString(this Stream stream)
        {
            var length = stream.ReadInt32();
            return stream.ReadString(length);
        }

        public static string ReadString(this Stream stream, int length)
        {
            var buffer = new byte[length > 0 ? length : -length*2];
            stream.Read(buffer, 0, buffer.Length);
            return length > 0
                ? Encoding.ASCII.GetString(buffer).TrimEnd('\0')
                : Encoding.Unicode.GetString(buffer).TrimEnd('\0');
        }

        public static BaseProperty ReadBaseProperty(this Stream stream)
        {
            return new BaseProperty
            {
                NameIdx = stream.ReadInt32(),
                TypeIdx = stream.ReadInt32(),
                PropertySize = stream.ReadInt32(),
                ArrayIdx = stream.ReadInt32()
            };
        }

        public static NameProperty ReadNameProperty(this Stream stream, List<string> names)
        {
            var nameIdx = stream.ReadInt32();
            return new NameProperty
            {
                NameIndex = nameIdx,
                Name = names[nameIdx]
            };
        }
        #endregion

        #region Write extensions
        public static void WriteInt32(this Stream stream, int value)
        {
            stream.Write(BitConverter.GetBytes(value), 0, 4);
        }

        public static void WriteBool(this Stream stream, bool value)
        {
            stream.Write(BitConverter.GetBytes(value), 0, 1);
        }

        public static void WriteFloat(this Stream stream, float value)
        {
            stream.Write(BitConverter.GetBytes(value), 0, 4);
        }

        public static void WriteUnicodeString(this Stream stream, string value)
        {
            var bytes = Encoding.Unicode.GetBytes(value);
            stream.Write(BitConverter.GetBytes(-(bytes.Length/2 + 1)), 0, 4);
            stream.Write(bytes, 0, bytes.Length);
            stream.WriteByte(0); // null-terminator
            stream.WriteByte(0); // null-terminator
        }

        public static void WriteString(this Stream stream, string value)
        {
            var bytes = Encoding.ASCII.GetBytes(value);
            stream.Write(BitConverter.GetBytes(bytes.Length + 1), 0, 4);
            stream.Write(bytes, 0, bytes.Length);
            stream.WriteByte(0); // null-terminator
        }

        public static void WriteBaseProperty(this Stream stream, BaseProperty value)
        {
            stream.WriteInt32(value.NameIdx);
            stream.WriteInt32(value.TypeIdx);
            stream.WriteInt32(value.PropertySize);
            stream.WriteInt32(value.ArrayIdx);
        }
        #endregion

        public static void DeserializeObject(this Stream stream, object obj, List<string> nameTable)
        {
            while (stream.Position < stream.Length)
            {
                stream.ReadAndMapProperty(obj, nameTable);
            }
        }

        public static void ReadAndMapProperty(this Stream stream, object obj, List<string> nameTable)
        {
            var baseProperty = stream.ReadBaseProperty();

            var pi = obj.GetType().GetField(nameTable[baseProperty.NameIdx], BindingFlags.Public | BindingFlags.Instance);
            if (pi == null) return;

            var fieldType = pi.FieldType.IsGenericType && pi.FieldType.GetGenericTypeDefinition() == typeof (Nullable<>)
                ? Nullable.GetUnderlyingType(pi.FieldType)
                : pi.FieldType;
            object value = null;

            switch (nameTable[baseProperty.TypeIdx])
            {
                case "IntProperty":
                    value = stream.ReadInt32();
                    break;
                case "BoolProperty":
                    value = stream.ReadBool();
                    break;
                case "ByteProperty":
                    stream.ReadInt32(); // EnumNameIdx
                    var enumValueNameIdx = stream.ReadInt32();
                    value = Enum.Parse(fieldType, nameTable[enumValueNameIdx]);
                    break;
                case "FloatProperty":
                    value = stream.ReadFloat();
                    break;
                case "NameProperty":
                    value = stream.ReadNameProperty(nameTable);
                    break;
                case "StrProperty":
                    value = stream.ReadString();
                    break;
                case "ArrayProperty":
                    // У массивов NumElements входит в PropertySize
                    var numElements = stream.ReadInt32();
                    // Если элементов нет, то следом идет сразу следующее свойство, массив не заканчивается ничем, нет даже None
                    if (numElements == 0) return;

                    value = Activator.CreateInstance(fieldType);

                    var elementType = fieldType.GetGenericArguments()[0];
                    for (var i = 0; i < numElements; i++)
                    {
                        if (elementType == typeof (int)) // array<int>
                        {
                            (value as IList).Add(stream.ReadInt32());
                        }
                        else if (elementType == typeof (string)) // array<string>
                        {
                            (value as IList).Add(stream.ReadString());
                        }
                        else if (elementType == typeof (NameProperty)) // array<name>
                        {
                            (value as IList).Add(stream.ReadNameProperty(nameTable));
                        }
                        else
                        {
                            var element = Activator.CreateInstance(elementType);
                            var nameIdx = stream.ReadInt32();
                            while (nameTable[nameIdx] != "None")
                            {
                                stream.Seek(-4, SeekOrigin.Current);
                                stream.ReadAndMapProperty(element, nameTable);
                                nameIdx = stream.ReadInt32();
                            }
                            (value as IList).Add(element);
                        }
                    }
                    break;
                case "StructProperty":
                    // У структур StructNameIdx не входит в PropertySize
                    var structNameIdx = stream.ReadInt32();
                    switch (nameTable[structNameIdx])
                    {
                        case "Vector":
                            value = new Vector
                            {
                                X = stream.ReadFloat(),
                                Y = stream.ReadFloat(),
                                Z = stream.ReadFloat()
                            };
                            break;
                        case "Rotator":
                            value = new Rotator
                            {
                                Pitch = stream.ReadInt32(),
                                Yaw = stream.ReadInt32(),
                                Roll = stream.ReadInt32()
                            };
                            break;
                        case "Transform":
                            stream.Seek(baseProperty.PropertySize, SeekOrigin.Current);
                            break;
                        default:
                            // На случай SEpisodeBoundaryStats[]
                            value = Activator.CreateInstance(fieldType.IsArray ? fieldType.GetElementType() : fieldType);
                            var nameIdx = stream.ReadInt32();
                            // None в конце всех структур, кроме стандартных Vector, Rotator, Transform
                            while (nameTable[nameIdx] != "None")
                            {
                                stream.Seek(-4, SeekOrigin.Current);
                                stream.ReadAndMapProperty(value, nameTable);
                                nameIdx = stream.ReadInt32();
                            }
                            break;
                    }
                    break;
            }
            if (fieldType.IsArray)
            {
                var array = (Array) pi.GetValue(obj);
                array.SetValue(value, baseProperty.ArrayIdx);
                pi.SetValue(obj, array);
            }
            else
            {
                pi.SetValue(obj, value);
            }
        }

        public static void SerializeObject(this Stream stream, object obj, List<string> nameTable)
        {
            var fields = obj.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);
            foreach (var field in fields.Where(f => f.GetValue(obj) != null))
            {
                var fieldType = field.FieldType.IsGenericType && field.FieldType.GetGenericTypeDefinition() == typeof (Nullable<>)
                    ? Nullable.GetUnderlyingType(field.FieldType)
                    : field.FieldType;

                stream.WriteProperty(field.Name, fieldType, field.GetValue(obj), nameTable);
            }
            stream.WriteInt32(AddToNameTable(nameTable, "None"));
        }

        public static void WriteProperty(this Stream stream, string fieldName, Type fieldType, 
            object fieldValue, List<string> nameTable, int? arrayIndex = null)
        {
            if (fieldType.IsArray)
            {
                var array = (Array)fieldValue;
                for (var i = 0; i < array.Length; i++)
                {
                    var value = array.GetValue(i);
                    if (value != null)
                        stream.WriteProperty(fieldName, fieldType.GetElementType(), array.GetValue(i), nameTable, i);
                }
                return;
            }

            var fieldBodyStream = new MemoryStream();

            var baseProperty = new BaseProperty
            {
                NameIdx = AddToNameTable(nameTable, fieldName),
                ArrayIdx = arrayIndex ?? 0
            };

            if (fieldType == typeof (int))
            {
                baseProperty.TypeIdx = AddToNameTable(nameTable, "IntProperty");
                var value = (int) fieldValue;
                fieldBodyStream.WriteInt32(value);
            }
            else if (fieldType == typeof (bool))
            {
                baseProperty.TypeIdx = AddToNameTable(nameTable, "BoolProperty");
                var value = (bool) fieldValue;
                fieldBodyStream.WriteBool(value);
            }
            else if (fieldType.IsEnum)
            {
                baseProperty.TypeIdx = AddToNameTable(nameTable, "ByteProperty");
                var value1 = AddToNameTable(nameTable, fieldType.Name); // Enum type name
                var value2 = AddToNameTable(nameTable, fieldValue.ToString()); // Enum value
                fieldBodyStream.WriteInt32(value1);
                fieldBodyStream.WriteInt32(value2);
            }
            else if (fieldType == typeof (float))
            {
                baseProperty.TypeIdx = AddToNameTable(nameTable, "FloatProperty");
                var value = (float) fieldValue;
                fieldBodyStream.WriteFloat(value);
            }
            else if (fieldType == typeof (NameProperty))
            {
                baseProperty.TypeIdx = AddToNameTable(nameTable, "NameProperty");
                var nameProp = (NameProperty) fieldValue;
                var value = AddToNameTable(nameTable, nameProp.Name);
                fieldBodyStream.WriteInt32(value);
            }
            else if (fieldType == typeof (string))
            {
                baseProperty.TypeIdx = AddToNameTable(nameTable, "StrProperty");
                var value = (string) fieldValue;
                switch (fieldName)
                {
                    case "SaveDetails":
                    case "FriendlyName":
                        fieldBodyStream.WriteUnicodeString(value);
                        break;
                    default:
                        fieldBodyStream.WriteString(value);
                        break;
                }
                //fieldBodyStream.WriteUnicodeString(value); // Save every string as unicode
            }
            else if (fieldType.IsGenericType && (fieldType.GetGenericTypeDefinition() == typeof(List<>)))
            {
                baseProperty.TypeIdx = AddToNameTable(nameTable, "ArrayProperty");
                var list = fieldValue as IList;
                var elementType = fieldType.GetGenericArguments()[0];
                fieldBodyStream.WriteInt32(list.Count); // numElements
                for (var i = 0; i < list.Count; i++)
                {
                    if (elementType == typeof (int))
                    {
                        fieldBodyStream.WriteInt32((int) list[i]);
                    }
                    else if (elementType == typeof (string))
                    {
                        fieldBodyStream.WriteString((string) list[i]);
                    }
                    else if (elementType == typeof (NameProperty))
                    {
                        var value = AddToNameTable(nameTable, ((NameProperty) list[i]).Name);
                        fieldBodyStream.WriteInt32(value);
                    }
                    else
                    {
                        fieldBodyStream.SerializeObject(list[i], nameTable);
                    }
                }
            }
            else if (!fieldType.IsGenericType && !fieldType.IsValueType && !fieldType.IsPrimitive && fieldType.IsClass)
            {
                baseProperty.TypeIdx = AddToNameTable(nameTable, "StructProperty");

                fieldBodyStream.WriteInt32(AddToNameTable(nameTable, fieldType.Name)); // StructNameIdx

                if (fieldType == typeof (Vector))
                {
                    var value = (Vector) fieldValue;
                    fieldBodyStream.WriteFloat(value.X);
                    fieldBodyStream.WriteFloat(value.Y);
                    fieldBodyStream.WriteFloat(value.Z);
                }
                else if (fieldType == typeof (Rotator))
                {
                    var value = (Rotator) fieldValue;
                    fieldBodyStream.WriteInt32(value.Pitch);
                    fieldBodyStream.WriteInt32(value.Yaw);
                    fieldBodyStream.WriteInt32(value.Roll);
                }
                else
                {
                    fieldBodyStream.SerializeObject(fieldValue, nameTable);
                }
            }

            baseProperty.PropertySize = (int) fieldBodyStream.Length;
            stream.WriteBaseProperty(baseProperty);
            fieldBodyStream.WriteTo(stream);
        }

        private static int AddToNameTable(IList<string> nameTable, string name)
        {
            if (nameTable.All(n => n != name))
                nameTable.Add(name);
            return nameTable.IndexOf(name);
        }
    }
}
