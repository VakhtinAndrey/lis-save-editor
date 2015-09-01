using System.Collections.Generic;

namespace LifeIsStrangeSaveEditor.Win
{
    #region Enums
    public enum EWhatIfFactLevel
    {
        EWIFL_None,
        EWIFL_Layer,
        EWIFL_Episode,
        EWIFL_Game,
        EWIFL_MAX
    };

    public enum EOnlineSaveStatus
    {
        EOSS_Empty,
        EOSS_PendingReading,
        EOSS_Reading,
        EOSS_ReadComplete,
        EOSS_ReadFailed,
        EOSS_PendingWriting,
        EOSS_Writing,
        EOSS_WriteComplete,
        EOSS_WriteFailed,
        EOSS_WrongVersion,
        EOSS_FileCorrupted,
        EOSS_NoFile,
        EOSS_NotEnoughSpace,
        EOSS_MAX
    }

    public enum EDNEOptionsId
    {
        EDNEI_Gamma,
        EDNEI_ScreenRatio,
        EDNEI_Volume,
        EDNEI_MusicVolume,
        EDNEI_VoicesVolume,
        EDNEI_SFX_Volume,
        EDNEI_Subtitle,
        EDNEI_InvertXAxis,
        EDNEI_InvertYAxis,
        EDNEI_Vibration,
        EDNEI_AudioLanguage,
        EDNEI_Sensitivity,
        EDNEI_MAX
    }

    public enum EDNEAchievementType
    {
        EDNEAT_DirectUnlock,
        EDNEAT_Counters,
        EDNEAT_MAX
    }

    public enum EPlaystationGrade
    {
        EPG_Gold,
        EPG_Silver,
        EPG_Bronze,
        EPG_Platinum,
        EPG_MAX
    }

    public enum EPlayerBoundaryType
    {
        PLAYERBOUNDARYTYPE_EPISODE,
        PLAYERBOUNDARYTYPE_CONTEXT,
        PLAYERBOUNDARYTYPE_OBJECTIVE,
        PLAYERBOUNDARYTYPE_CHECKPOINT,
        PLAYERBOUNDARYTYPE_PUZZLE,
        PLAYERBOUNDARYTYPE_MAX
    };

    public enum BoundaryStatType
    {
        Rewinds,
        Hints
    }

    public enum ActiveFactsFilter
    {
        Interactions,
        Internal,
        Tutorials,
        Diary,
        Collectibles,
        Sms,
        Choices
    }

    public enum ECheckpointSystemOperation
    {
        ECSO_UpdateCheckpoint,
        ECSO_UpdateAndSaveCheckpoint,
        ECSO_LoadCheckpoint,
        ECSO_MAX
    };
    #endregion

    #region Built-in properties
    public class BaseProperty
    {
        public int NameIdx { get; set; }

        public int TypeIdx { get; set; }

        public int PropertySize { get; set; }

        public int ArrayIdx { get; set; }
    }

    public class IntProperty
    {
        public int Value { get; set; }
    }

    /// <summary>
    /// Enum
    /// </summary>
    public class BoolProperty
    {
        public bool Value { get; set; } // byte
    }

    public class ByteProperty
    {
        public int EnumNameIdx { get; set; }

        public int EnumValueNameIdx { get; set; }
    }

    public class FloatProperty
    {
        public float Value { get; set; }
    }

    public class NameProperty
    {
        public int NameIndex { get; set; }

        public string Name; // Non-existing field, helper

        public override string ToString()
        {
            return string.Format("NameProperty: {0} [{1}]", Name, NameIndex);
        }
    }

    public class StrProperty
    {
        public int Size { get; set; }

        public string Value { get; set; }
    }

    public class ArrayProperty
    {
        public int NumElements { get; set; }
    }

    public class Vector
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }

    public class Rotator
    {
        public int Pitch { get; set; }
        public int Yaw { get; set; }
        public int Roll { get; set; }
    }
    #endregion

    public class SaveFile
    {
        public SaveFile()
        {
            Header = new FileHeader();
            SaveDataHeader = new SaveDataHeader();
            SaveData = new WhatIfSaveData();
            NameTable = new NameTable();
        }

        public FileHeader Header;

        public SaveDataHeader SaveDataHeader;

        public WhatIfSaveData SaveData;

        public NameTable NameTable;
    }

    public class FileHeader
    {
        public int UnkInt1;

        public int FileSize;
    }

    public class SaveDataHeader
    {
        public int HeaderSize;

        public int SaveDataSize;

        public int UnkInt2;
    }

    public class NameTable
    {
        public NameTable()
        {
            Names = new List<string>();
        }

        public List<string> Names;
    }

    public class WhatIfSaveData : DNESaveData
    {
        public WhatIfSaveData()
        {
            AlreadySeenLastDiaryPages = new int[6] {-1, -1, -1, -1, -1, -1};
            NbPlaythrough = new int[5];
            PercentageCompleted = new float[6];
        }

        public Vector CheckpointLocation;
        public Rotator CheckpointRotation;
        public string CheckPointID;
        public List<LevelInfos> CheckpointLevelRecords;
        public PlayerProgress PlayerProgress;
        public List<Achievement> Achievements;
        public List<NameProperty> VisibleLevels; // NameProperty
        public int? CurrentEpisode;
        public List<SubLevelStartState> SLevelStartStates;
        public List<string> CheckpointReached;
        public bool? bStartNewGame;
        public bool? bGameStarted;
        public bool? bNeedToSwitchToNextEpisode;
        public int? LastSubLevelPlayedIndex;
        public List<NameProperty> AlreadySeenCollectibles; // NameProperty
        public List<NameProperty> AlreadySeenCharacters; // NameProperty
        public int[] AlreadySeenLastDiaryPages; // [6]
        public float? fTotalGameTimePauseExcluded;
        public int[] NbPlaythrough; // [5]
        public int? NbEpisodeCompletedSum;
        public int? NbInteractionDoneSum;
        public int? NbChoiceMadeSum;
        public float[] PercentageCompleted; // [5]
    }

    public class LevelInfos
    {
        public NameProperty LevelName; // NameProperty
        public bool? bShouldBeLoaded;
        public bool? bShouldBeVisible;
    }

    public class DNESaveTime
    {
        public int? SecondsSinceMidnight;
        public int? Day;
        public int? Month;
        public int? Year;
    }

    public class SubLevelStartState
    {
        public string SubLevelTitle;
        public PlayerProgress PlayerProgress;
    };

    public class PlayerProgress
    {
        public PlayerProgress()
        {
            MaxReachedContextName = new string[5];
            fEpisodePlayTimePauseExcluded = new float[5];
            fEpisodePlayTimePauseIncluded = new float[5];
            EpisodeBoundaryStats = new SEpisodeBoundaryStats[5];
        }

        public List<ActiveFactLevel> ActiveFacts;
        public List<int> ActiveTutorials;
        public List<FileSelect> FileSelects;
        public List<ObjectInInventory> InventoryObjects;
        public NameProperty CurrentObjectiveID; // NameProperty
        public string[] MaxReachedContextName; // [5]
        public List<NameProperty> CollectibleFoundFactNames; // NameProperty
        public float[] fEpisodePlayTimePauseExcluded; // [5]
        public float[] fEpisodePlayTimePauseIncluded; // [5]
        public int? CurrentDay;
        public bool? DiaryAlreadySeen;
        public int? LastDiaryDaySeen;
        public int? LastDiaryPageSeen;
        public SEpisodeBoundaryStats[] EpisodeBoundaryStats; // [5]
    }

    public class ActiveFactLevel
    {
        public NameProperty FactName; // NameProperty
        public int? FactLevel;
    }

    public class Achievement
    {
        public int? Id;
        public EDNEAchievementType? Type;
        public bool? bHidden;
        public EPlaystationGrade? PlaystationGrade;
        public int? XboxGamerscore;
        public string Title;
        public string Description;
        public string HowTo;
        public int? CountersLimit;
        public bool? bResetCountersWhenPlayerDie;
        public int? CurrentCountersValue;
    }

    public class FileSelect
    {
        public NameProperty ObjectName; // NameProperty
        public string TextureKey;
        public List<int> Pages;
    }

    public class ObjectInInventory
    {
        public NameProperty ObjectName; // NameProperty
        public int? ObjectInstanceCount;
    }

    public class SEpisodeBoundaryStats
    {
        public SEpisodeBoundaryStats()
        {
            BoundaryStats = new SBoundaryStats[5];
        }

        public SBoundaryStats[] BoundaryStats; //sizeof(EPlayerBoundaryType) = 5
    }

    public class SBoundaryStats
    {
        public int? NbRewinds;
        public int? NbHints;
    }

    public abstract class DNESaveData
    {
        public string SaveId;
        public string SaveFileName;
        public string SaveDetails;
        public string FriendlyName;
        public DNESaveTime SaveTime;
        public EOnlineSaveStatus? Status;
        public bool? bIsOwned;
        public int? SlotNumber;
        public int? RequiredFreeSpace;
    }

    public class DebugFact
    {
        public string Name;

        public EWhatIfFactLevel Level;
    }

    public class IA_CheckpointSystem
    {
        public ECheckpointSystemOperation Operation;

        public string CheckPointID;

        //public Actor SpawnPoint;

        public List<string> LevelsOverride;

        public bool bKeepLevelsStates;

        public List<string> VisibleLevels;

        public List<DebugFact> DebugFactToActivate;

        public List<string> DebugInventoryObjectToAdd;

        public List<DebugFact> DebugFactToChoose;

        //public ChildList ChildSeqs;
    }

    public class SubLevelInfo
    {
        public string Name;

        public string Description;
    }

    public class FactChoice
    {
        public NameProperty FactName;
        public bool bDeactivateFact;
        public List<NameProperty> DebugFactToActivate;
        public List<NameProperty> DebugFactToDeactivate;
        public List<NameProperty> DebugInventoryObjectToAdd;
        public List<NameProperty> DebugInventoryObjectToRemove;
    }

    public class FactList
    {
        public List<FactChoice> Choices;
    }

    public class SubEpisodeDescription
    {
        public NameProperty SubEpisodeName;
        public string SubEpisodeTitle;
        public string TexturePath;
        public string InsertionCheckPointId;
        public List<FactList> FactChoiceList;
        public List<NameProperty> DebugFactToActivate;
        public List<NameProperty> DebugFactToDeactivate;
        public List<NameProperty> DebugInventoryObjectToAdd;
        public List<NameProperty> DebugInventoryObjectToRemove;
        public List<NameProperty> LevelsToRemoveAtStartup;
        public List<NameProperty> Collectibles;
    }

    public class EpisodeChoiceResult
    {
        public NameProperty Id;
        public string Description;
        public NameProperty Fact;
        public bool FactActivated;
    }

    public class EpisodeChoiceEntry
    {
        public string PictureTexture;
        public NameProperty ActivationFact;
        public List<EpisodeChoiceResult> ChoiceResults;
    }

    public class EpisodeDescription
    {
        public NameProperty EpisodeName;
        public string EpisodeTitle;
        //public EpisodeDispositionData DispositionData;
        public List<SubEpisodeDescription> SubEpisodes;
        public List<EpisodeChoiceEntry> MajorChoices;
        public List<EpisodeChoiceEntry> MinorChoices;
        public List<string> NextEpisodeTeaserImages;
    }
}
