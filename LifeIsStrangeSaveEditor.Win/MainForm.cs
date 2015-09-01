using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LifeIsStrangeSaveEditor.Win
{
    public partial class MainForm : Form
    {
        private string _saveFilePath;
        public string SaveFilePath
        {
            get { return _saveFilePath; }
            set
            {
                _saveFilePath = value;
                tbSaveFilePath.Text = _saveFilePath;
            }
        }

        public SaveFile SaveFile { get; set; }

        public MainForm()
        {
            InitializeComponent();

            this.Text = string.Format("Life is Strange Save Editor v{0}", AppHelper.GetApplicationVersionShortStr());

            tpReachedCheckpoints.Tag = tpReachedCheckpoints.Text;
            tpAlreadySeenCollectibles.Tag = tpAlreadySeenCollectibles.Text;
            tpAlreadySeenCharacters.Tag = tpAlreadySeenCharacters.Text;
            tpCheckpointLevelRecords.Tag = tpCheckpointLevelRecords.Text;
            tpAchievements.Tag = tpAchievements.Text;
            tpVisibleLevels.Tag = tpVisibleLevels.Text;
            tpLevelStartStates.Tag = tpLevelStartStates.Text;
            tpPlayerProgressActiveFacts.Tag = tpPlayerProgressActiveFacts.Text;
            tpPlayerProgressActiveTutorials.Tag = tpPlayerProgressActiveTutorials.Text;
            tpPlayerProgressFileSelects.Tag = tpPlayerProgressFileSelects.Text;
            tpPlayerProgressInventoryObjects.Tag = tpPlayerProgressInventoryObjects.Text;
            tpPlayerProgressCollectibleFoundFactNames.Tag = tpPlayerProgressCollectibleFoundFactNames.Text;

            var checkpoints = CheckpointsInfo.Checkpoints.Select(c => c.CheckPointID).Distinct().ToArray();
            cbCheckPointID.Items.AddRange(checkpoints);

            nudRequiredFreeSpace.Minimum = int.MinValue;
            nudRequiredFreeSpace.Maximum = int.MaxValue;
            nudTotalGameTimePauseExcluded.Maximum = decimal.MaxValue;
            nudNbInteractionDoneSum.Maximum = int.MaxValue;
            nudNbChoiceMadeSum.Maximum = int.MaxValue;

            nudEpisodePlayTimePauseExcluded0.Maximum = decimal.MaxValue;
            nudEpisodePlayTimePauseExcluded1.Maximum = decimal.MaxValue;
            nudEpisodePlayTimePauseExcluded2.Maximum = decimal.MaxValue;
            nudEpisodePlayTimePauseExcluded3.Maximum = decimal.MaxValue;
            nudEpisodePlayTimePauseExcluded4.Maximum = decimal.MaxValue;

            nudEpisodePlayTimePauseIncluded0.Maximum = decimal.MaxValue;
            nudEpisodePlayTimePauseIncluded1.Maximum = decimal.MaxValue;
            nudEpisodePlayTimePauseIncluded2.Maximum = decimal.MaxValue;
            nudEpisodePlayTimePauseIncluded3.Maximum = decimal.MaxValue;
            nudEpisodePlayTimePauseIncluded4.Maximum = decimal.MaxValue;

            nudBoundaryStats00Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats01Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats02Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats03Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats04Rewinds.Maximum = int.MaxValue;

            nudBoundaryStats10Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats11Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats12Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats13Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats14Rewinds.Maximum = int.MaxValue;

            nudBoundaryStats20Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats21Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats22Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats23Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats24Rewinds.Maximum = int.MaxValue;

            nudBoundaryStats30Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats31Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats32Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats33Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats34Rewinds.Maximum = int.MaxValue;

            nudBoundaryStats40Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats41Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats42Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats43Rewinds.Maximum = int.MaxValue;
            nudBoundaryStats44Rewinds.Maximum = int.MaxValue;

            nudBoundaryStats00Hints.Maximum = int.MaxValue;
            nudBoundaryStats01Hints.Maximum = int.MaxValue;
            nudBoundaryStats02Hints.Maximum = int.MaxValue;
            nudBoundaryStats03Hints.Maximum = int.MaxValue;
            nudBoundaryStats04Hints.Maximum = int.MaxValue;

            nudBoundaryStats10Hints.Maximum = int.MaxValue;
            nudBoundaryStats11Hints.Maximum = int.MaxValue;
            nudBoundaryStats12Hints.Maximum = int.MaxValue;
            nudBoundaryStats13Hints.Maximum = int.MaxValue;
            nudBoundaryStats14Hints.Maximum = int.MaxValue;

            nudBoundaryStats20Hints.Maximum = int.MaxValue;
            nudBoundaryStats21Hints.Maximum = int.MaxValue;
            nudBoundaryStats22Hints.Maximum = int.MaxValue;
            nudBoundaryStats23Hints.Maximum = int.MaxValue;
            nudBoundaryStats24Hints.Maximum = int.MaxValue;

            nudBoundaryStats30Hints.Maximum = int.MaxValue;
            nudBoundaryStats31Hints.Maximum = int.MaxValue;
            nudBoundaryStats32Hints.Maximum = int.MaxValue;
            nudBoundaryStats33Hints.Maximum = int.MaxValue;
            nudBoundaryStats34Hints.Maximum = int.MaxValue;

            nudBoundaryStats40Hints.Maximum = int.MaxValue;
            nudBoundaryStats41Hints.Maximum = int.MaxValue;
            nudBoundaryStats42Hints.Maximum = int.MaxValue;
            nudBoundaryStats43Hints.Maximum = int.MaxValue;
            nudBoundaryStats44Hints.Maximum = int.MaxValue;

            nudLastDiaryPageSeen.Maximum = int.MaxValue;
        }

        private void SezializeSaveFile(Stream stream, SaveFile save)
        {
            var saveDataStream = new MemoryStream();
            var nameTableStream = new MemoryStream();

            var newSave = new SaveFile
            {
                Header =
                {
                    UnkInt1 = save.Header.UnkInt1
                },
                SaveDataHeader =
                {
                    HeaderSize = save.SaveDataHeader.HeaderSize,
                    UnkInt2 = save.SaveDataHeader.UnkInt2
                }
            };

            newSave.SaveData = FillSaveData();

            saveDataStream.SerializeObject(newSave.SaveData, newSave.NameTable.Names);

            nameTableStream.WriteInt32(newSave.NameTable.Names.Count);
            for (var i = 0; i < newSave.NameTable.Names.Count; i++)
            {
                nameTableStream.WriteString(newSave.NameTable.Names[i]);
            }

            newSave.SaveDataHeader.SaveDataSize = (int) saveDataStream.Length + 12; // 12 = SaveDataHeader size
            newSave.Header.FileSize = (int) saveDataStream.Length + 12 + (int) nameTableStream.Length;

            stream.Seek(0, SeekOrigin.Begin);

            // File header
            stream.WriteInt32(newSave.Header.UnkInt1);
            stream.WriteInt32(newSave.Header.FileSize);

            // Save data header
            stream.WriteInt32(newSave.SaveDataHeader.HeaderSize);
            stream.WriteInt32(newSave.SaveDataHeader.SaveDataSize);
            stream.WriteInt32(newSave.SaveDataHeader.UnkInt2);

            // Save data
            saveDataStream.WriteTo(stream);
            //stream.WriteInt32(255);

            // Name table
            nameTableStream.WriteTo(stream);
        }

        private SaveFile DeserializeSaveFile(Stream stream)
        {
            var save = new SaveFile();

            // File header
            stream.Seek(0, SeekOrigin.Begin);
            save.Header = new FileHeader
            {
                UnkInt1 = stream.ReadInt32(),
                FileSize = stream.ReadInt32()
            };

            // Save data header
            save.SaveDataHeader = new SaveDataHeader
            {
                HeaderSize = stream.ReadInt32(),
                SaveDataSize = stream.ReadInt32(),
                UnkInt2 = stream.ReadInt32()
            };

            // Name table
            stream.Seek(save.SaveDataHeader.SaveDataSize + 8, SeekOrigin.Begin);
            var count = stream.ReadInt32();
            save.NameTable = new NameTable();
            for (var i = 0; i < count; i++)
            {
                save.NameTable.Names.Add(stream.ReadString());
            }

            // Save data
            stream.Seek(20, SeekOrigin.Begin);
            save.SaveData = new WhatIfSaveData();
            var saveDataStream = new byte[save.SaveDataHeader.SaveDataSize - 12];
            stream.Read(saveDataStream, 0, save.SaveDataHeader.SaveDataSize - 12);
            var ms = new MemoryStream(saveDataStream);
            ms.Seek(0, SeekOrigin.Begin);
            ms.DeserializeObject(save.SaveData, save.NameTable.Names);

            return save;
        }

        private WhatIfSaveData FillSaveData()
        {
            var now = DateTime.Now;
            var today = new TimeSpan(now.Hour, now.Minute, now.Second);

            var saveData = new WhatIfSaveData
            {
                SaveId = GetNullableFromTextBox(tbSaveId),
                SaveFileName = GetNullableFromTextBox(tbSaveFileName),
                SaveDetails = GetNullableFromTextBox(tbSaveDetails),
                FriendlyName = GetNullableFromTextBox(tbFriendlyName),
                SaveTime = new DNESaveTime
                {
                    Year = now.Year,
                    Month = now.Month,
                    Day = now.Day,
                    SecondsSinceMidnight = (int) today.TotalSeconds
                },
                Status = EOnlineSaveStatus.EOSS_Writing,
                bIsOwned = GetNullableFromCheckbox(cbIsOwned),
                SlotNumber = (int) nudSlotNumber.Value,

                CheckPointID = GetNullableFromComboBox(cbCheckPointID),
                CheckpointLocation = new Vector
                {
                    X = float.Parse(tbCheckpointLocationX.Text, CultureInfo.InvariantCulture),
                    Y = float.Parse(tbCheckpointLocationY.Text, CultureInfo.InvariantCulture),
                    Z = float.Parse(tbCheckpointLocationZ.Text, CultureInfo.InvariantCulture)
                },
                CheckpointRotation = new Rotator
                {
                    Pitch = int.Parse(tbCheckpointRotationPitch.Text),
                    Yaw = int.Parse(tbCheckpointRotationYaw.Text),
                    Roll = int.Parse(tbCheckpointRotationRoll.Text)
                },
                CurrentEpisode = (int) nudCurrentEpisode.Value,
                bStartNewGame = GetNullableFromCheckbox(cbStartNewGame),
                bGameStarted = GetNullableFromCheckbox(cbGameStarted),
                bNeedToSwitchToNextEpisode = GetNullableFromCheckbox(cbNeedToSwitchToNextEpisode),
                LastSubLevelPlayedIndex = (int) nudLastSubLevelPlayedIndex.Value,
                AlreadySeenLastDiaryPages = new[]
                {
                    (int) nudAlreadySeenLastDiaryPages0.Value,
                    (int) nudAlreadySeenLastDiaryPages1.Value,
                    (int) nudAlreadySeenLastDiaryPages2.Value,
                    (int) nudAlreadySeenLastDiaryPages3.Value,
                    (int) nudAlreadySeenLastDiaryPages4.Value,
                    (int) nudAlreadySeenLastDiaryPages5.Value,
                },
                fTotalGameTimePauseExcluded = (float) nudTotalGameTimePauseExcluded.Value,
                NbEpisodeCompletedSum = (int) nudNbEpisodeCompletedSum.Value,
                NbInteractionDoneSum = (int) nudNbInteractionDoneSum.Value,
                NbChoiceMadeSum = (int) nudNbChoiceMadeSum.Value,
                NbPlaythrough = new[]
                {
                    cbNbPlaythrough0.Checked ? 1 : 0,
                    cbNbPlaythrough1.Checked ? 1 : 0,
                    cbNbPlaythrough2.Checked ? 1 : 0,
                    cbNbPlaythrough3.Checked ? 1 : 0,
                    cbNbPlaythrough4.Checked ? 1 : 0,
                },
                PercentageCompleted = new[]
                {
                    (float) nudPercentageCompleted0.Value,
                    (float) nudPercentageCompleted1.Value,
                    (float) nudPercentageCompleted2.Value,
                    (float) nudPercentageCompleted3.Value,
                    (float) nudPercentageCompleted4.Value,
                },

                CheckpointReached = SaveFile.SaveData.CheckpointReached,

                AlreadySeenCollectibles = dgvAlreadySeenCollectibles.Rows.OfType<DataGridViewRow>()
                    .DropLast()
                    .Select(r => new NameProperty
                    {
                        Name = r.Cells[0].Value.ToString()
                    }).ToList(),

                AlreadySeenCharacters = SaveFile.SaveData.AlreadySeenCharacters,

                CheckpointLevelRecords = dgvCheckpointLevelRecords.Rows.OfType<DataGridViewRow>()
                    .DropLast()
                    .Select(r => new LevelInfos
                    {
                        LevelName = new NameProperty {Name = r.Cells[0].Value.ToString()},
                        bShouldBeLoaded = (bool) r.Cells[1].Value,
                        bShouldBeVisible = (bool) r.Cells[2].Value,
                    }).ToList(),

                Achievements = SaveFile.SaveData.Achievements,
                VisibleLevels = dgvVisibleLevels.Rows.OfType<DataGridViewRow>()
                    .DropLast()
                    .Select(r => new NameProperty
                    {
                        Name = r.Cells[0].Value.ToString()
                    }).ToList(),

                PlayerProgress = new PlayerProgress
                {
                    CurrentObjectiveID = string.IsNullOrEmpty(tbCurrentObjectiveID.Text)
                        ? new NameProperty {Name = tbCurrentObjectiveID.Text}
                        : null,
                    CurrentDay = (int) nudCurrentDay.Value,
                    DiaryAlreadySeen = GetNullableFromCheckbox(cbDiaryAlreadySeen),
                    LastDiaryDaySeen = (int) nudLastDiaryDaySeen.Value,
                    LastDiaryPageSeen = (int) nudLastDiaryPageSeen.Value,
                    MaxReachedContextName = new[]
                    {
                        GetNullableFromTextBox(tbMaxReachedContextName0),
                        GetNullableFromTextBox(tbMaxReachedContextName1),
                        GetNullableFromTextBox(tbMaxReachedContextName2),
                        GetNullableFromTextBox(tbMaxReachedContextName3),
                        GetNullableFromTextBox(tbMaxReachedContextName4)
                    },
                    fEpisodePlayTimePauseExcluded = new[]
                    {
                        (float) nudEpisodePlayTimePauseExcluded0.Value,
                        (float) nudEpisodePlayTimePauseExcluded1.Value,
                        (float) nudEpisodePlayTimePauseExcluded2.Value,
                        (float) nudEpisodePlayTimePauseExcluded3.Value,
                        (float) nudEpisodePlayTimePauseExcluded4.Value,
                    },
                    fEpisodePlayTimePauseIncluded = new[]
                    {
                        (float) nudEpisodePlayTimePauseIncluded0.Value,
                        (float) nudEpisodePlayTimePauseIncluded1.Value,
                        (float) nudEpisodePlayTimePauseIncluded2.Value,
                        (float) nudEpisodePlayTimePauseIncluded3.Value,
                        (float) nudEpisodePlayTimePauseIncluded4.Value,
                    },

                    ActiveFacts = dgvActiveFacts.Rows.OfType<DataGridViewRow>()
                        .DropLast()
                        .Select(r => new ActiveFactLevel
                        {
                            FactName = new NameProperty {Name = r.Cells[2].Value.ToString()},
                            FactLevel = int.Parse(r.Cells[3].Value.ToString())
                        }).ToList(),

                    ActiveTutorials = dgvActiveTutorials.Rows.OfType<DataGridViewRow>()
                        .DropLast()
                        .Select(r => int.Parse(r.Cells[0].Value.ToString())).ToList(),

                    FileSelects = dgvFileSelects.Rows.OfType<DataGridViewRow>()
                        .DropLast()
                        .Select(r => new FileSelect
                        {
                            ObjectName = new NameProperty {Name = r.Cells[0].Value.ToString()},
                            TextureKey = r.Cells[1].Value.ToString(),
                            Pages = r.Cells[2].Value.ToString().Split(';').Select(int.Parse).ToList()
                        }).ToList(),

                    InventoryObjects = dgvInventoryObjects.Rows.OfType<DataGridViewRow>()
                        .DropLast()
                        .Select(r => new ObjectInInventory
                        {
                            ObjectName = new NameProperty {Name = r.Cells[0].Value.ToString()},
                            ObjectInstanceCount = int.Parse(r.Cells[1].Value.ToString())
                        }).ToList(),

                    CollectibleFoundFactNames = dgvCollectibleFoundFactNames.Rows.OfType<DataGridViewRow>()
                        .DropLast()
                        .Select(r => new NameProperty
                        {
                            Name = r.Cells[0].Value.ToString()
                        }).ToList(),

                    EpisodeBoundaryStats = SaveFile.SaveData.PlayerProgress.EpisodeBoundaryStats
                }
            };

            saveData.SLevelStartStates = dgvSubLevelStartStates.Rows.OfType<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(r => new SubLevelStartState
                {
                    SubLevelTitle = r.Cells["colSubLevelStartStatesSubLevelName"].Value.ToString(),
                    PlayerProgress = (PlayerProgress) r.Tag
                }).ToList();

            return saveData;
        }

        private void LoadFile()
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                using (var fs = File.OpenRead(SaveFilePath))
                {
                    SaveFile = DeserializeSaveFile(fs);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error while reading file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
                return;
            }

            tcSaveData.SuspendLayout();

            tpReachedCheckpoints.Text = GetCaptionWithCountForTab(tpReachedCheckpoints.Tag.ToString(), SaveFile.SaveData.CheckpointReached);
            tpAlreadySeenCollectibles.Text = GetCaptionWithCountForTab(tpAlreadySeenCollectibles.Tag.ToString(), SaveFile.SaveData.AlreadySeenCollectibles);
            tpAlreadySeenCharacters.Text = GetCaptionWithCountForTab(tpAlreadySeenCharacters.Tag.ToString(), SaveFile.SaveData.AlreadySeenCharacters);
            tpCheckpointLevelRecords.Text = GetCaptionWithCountForTab(tpCheckpointLevelRecords.Tag.ToString(), SaveFile.SaveData.CheckpointLevelRecords);
            tpAchievements.Text = GetCaptionWithCountForTab(tpAchievements.Tag.ToString(), SaveFile.SaveData.Achievements);
            tpVisibleLevels.Text = GetCaptionWithCountForTab(tpVisibleLevels.Tag.ToString(), SaveFile.SaveData.VisibleLevels);
            tpLevelStartStates.Text = GetCaptionWithCountForTab(tpLevelStartStates.Tag.ToString(), SaveFile.SaveData.SLevelStartStates);
            if (SaveFile.SaveData.PlayerProgress != null)
            {
                tpPlayerProgressActiveFacts.Text =
                    GetCaptionWithCountForTab(tpPlayerProgressActiveFacts.Tag.ToString(), SaveFile.SaveData.PlayerProgress.ActiveFacts);
                tpPlayerProgressActiveTutorials.Text =
                    GetCaptionWithCountForTab(tpPlayerProgressActiveTutorials.Tag.ToString(), SaveFile.SaveData.PlayerProgress.ActiveTutorials);
                tpPlayerProgressFileSelects.Text =
                    GetCaptionWithCountForTab(tpPlayerProgressFileSelects.Tag.ToString(), SaveFile.SaveData.PlayerProgress.FileSelects);
                tpPlayerProgressInventoryObjects.Text =
                    GetCaptionWithCountForTab(tpPlayerProgressInventoryObjects.Tag.ToString(), SaveFile.SaveData.PlayerProgress.InventoryObjects);
                tpPlayerProgressCollectibleFoundFactNames.Text =
                    GetCaptionWithCountForTab(tpPlayerProgressCollectibleFoundFactNames.Tag.ToString(), SaveFile.SaveData.PlayerProgress.CollectibleFoundFactNames);
            }
            else
            {
                tpPlayerProgressActiveFacts.Text =
                    GetCaptionWithCountForTab(tpPlayerProgressActiveFacts.Tag.ToString(), null);
                tpPlayerProgressActiveTutorials.Text =
                    GetCaptionWithCountForTab(tpPlayerProgressActiveTutorials.Tag.ToString(), null);
                tpPlayerProgressFileSelects.Text =
                    GetCaptionWithCountForTab(tpPlayerProgressFileSelects.Tag.ToString(), null);
                tpPlayerProgressInventoryObjects.Text =
                    GetCaptionWithCountForTab(tpPlayerProgressInventoryObjects.Tag.ToString(), null);
                tpPlayerProgressCollectibleFoundFactNames.Text =
                    GetCaptionWithCountForTab(tpPlayerProgressCollectibleFoundFactNames.Tag.ToString(), null);
            }

            tbSaveId.Text = SaveFile.SaveData.SaveId;
            tbSaveFileName.Text = SaveFile.SaveData.SaveFileName;
            tbSaveDetails.Text = SaveFile.SaveData.SaveDetails;
            tbFriendlyName.Text = SaveFile.SaveData.FriendlyName;
            if (SaveFile.SaveData.SaveTime != null)
            {
                var date = new DateTime(
                    SaveFile.SaveData.SaveTime.Year ?? 1,
                    SaveFile.SaveData.SaveTime.Month ?? 1,
                    SaveFile.SaveData.SaveTime.Day ?? 1);
                var dateTime = date.AddSeconds(SaveFile.SaveData.SaveTime.SecondsSinceMidnight ?? 0);
                lblSaveTimeValue.Text = dateTime.ToString("G");
            }
            else
            {
                lblSaveTimeValue.Text = "NOT SET";
            }

            lblStatusValue.Text = SaveFile.SaveData.Status.ToString();

            if (SaveFile.SaveData.bIsOwned != null)
                cbIsOwned.CheckState = SaveFile.SaveData.bIsOwned.Value ? CheckState.Checked : CheckState.Unchecked;
            else
                cbIsOwned.CheckState = CheckState.Indeterminate;

            nudSlotNumber.Value = SaveFile.SaveData.SlotNumber ?? 0;

            nudRequiredFreeSpace.Value = SaveFile.SaveData.RequiredFreeSpace ?? 0;

            if (SaveFile.SaveData.CheckpointLocation != null)
            {
                tbCheckpointLocationX.Text = SaveFile.SaveData.CheckpointLocation.X.ToString(CultureInfo.InvariantCulture);
                tbCheckpointLocationY.Text = SaveFile.SaveData.CheckpointLocation.Y.ToString(CultureInfo.InvariantCulture);
                tbCheckpointLocationZ.Text = SaveFile.SaveData.CheckpointLocation.Z.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                tbCheckpointLocationX.Text = string.Empty;
                tbCheckpointLocationY.Text = string.Empty;
                tbCheckpointLocationZ.Text = string.Empty;
            }

            if (SaveFile.SaveData.CheckpointRotation != null)
            {
                tbCheckpointRotationPitch.Text = SaveFile.SaveData.CheckpointRotation.Pitch.ToString();
                tbCheckpointRotationYaw.Text = SaveFile.SaveData.CheckpointRotation.Yaw.ToString();
                tbCheckpointRotationRoll.Text = SaveFile.SaveData.CheckpointRotation.Roll.ToString();
            }
            else
            {
                tbCheckpointRotationPitch.Text = string.Empty;
                tbCheckpointRotationYaw.Text = string.Empty;
                tbCheckpointRotationRoll.Text = string.Empty;
            }

            cbCheckPointID.Text = SaveFile.SaveData.CheckPointID;

            nudCurrentEpisode.Value = SaveFile.SaveData.CurrentEpisode ?? 0;

            if (SaveFile.SaveData.bStartNewGame != null)
                cbStartNewGame.CheckState = SaveFile.SaveData.bStartNewGame.Value ? CheckState.Checked : CheckState.Unchecked;
            else
                cbStartNewGame.CheckState = CheckState.Indeterminate;

            if (SaveFile.SaveData.bGameStarted != null)
                cbGameStarted.CheckState = SaveFile.SaveData.bGameStarted.Value ? CheckState.Checked : CheckState.Unchecked;
            else
                cbGameStarted.CheckState = CheckState.Indeterminate;

            if (SaveFile.SaveData.bNeedToSwitchToNextEpisode != null)
                cbNeedToSwitchToNextEpisode.CheckState = SaveFile.SaveData.bNeedToSwitchToNextEpisode.Value ? CheckState.Checked : CheckState.Unchecked;
            else
                cbNeedToSwitchToNextEpisode.CheckState = CheckState.Indeterminate;

            nudLastSubLevelPlayedIndex.Value = SaveFile.SaveData.LastSubLevelPlayedIndex ?? 0;

            nudAlreadySeenLastDiaryPages0.Value = SaveFile.SaveData.AlreadySeenLastDiaryPages[0];
            nudAlreadySeenLastDiaryPages1.Value = SaveFile.SaveData.AlreadySeenLastDiaryPages[1];
            nudAlreadySeenLastDiaryPages2.Value = SaveFile.SaveData.AlreadySeenLastDiaryPages[2];
            nudAlreadySeenLastDiaryPages3.Value = SaveFile.SaveData.AlreadySeenLastDiaryPages[3];
            nudAlreadySeenLastDiaryPages4.Value = SaveFile.SaveData.AlreadySeenLastDiaryPages[4];
            nudAlreadySeenLastDiaryPages5.Value = SaveFile.SaveData.AlreadySeenLastDiaryPages[5];

            nudTotalGameTimePauseExcluded.Value = (decimal?) SaveFile.SaveData.fTotalGameTimePauseExcluded ?? 0;

            cbNbPlaythrough0.Checked = SaveFile.SaveData.NbPlaythrough[0] > 0;
            cbNbPlaythrough1.Checked = SaveFile.SaveData.NbPlaythrough[1] > 0;
            cbNbPlaythrough2.Checked = SaveFile.SaveData.NbPlaythrough[2] > 0;
            cbNbPlaythrough3.Checked = SaveFile.SaveData.NbPlaythrough[3] > 0;
            cbNbPlaythrough4.Checked = SaveFile.SaveData.NbPlaythrough[4] > 0;

            nudNbEpisodeCompletedSum.Value = SaveFile.SaveData.NbEpisodeCompletedSum ?? 0;
            nudNbInteractionDoneSum.Value = SaveFile.SaveData.NbInteractionDoneSum ?? 0;
            nudNbChoiceMadeSum.Value = SaveFile.SaveData.NbChoiceMadeSum ?? 0;

            nudPercentageCompleted0.Value = (decimal) SaveFile.SaveData.PercentageCompleted[0];
            nudPercentageCompleted1.Value = (decimal) SaveFile.SaveData.PercentageCompleted[1];
            nudPercentageCompleted2.Value = (decimal) SaveFile.SaveData.PercentageCompleted[2];
            nudPercentageCompleted3.Value = (decimal) SaveFile.SaveData.PercentageCompleted[3];
            nudPercentageCompleted4.Value = (decimal) SaveFile.SaveData.PercentageCompleted[4];

            dgvAlreadySeenCollectibles.Rows.Clear();
            if (SaveFile.SaveData.AlreadySeenCollectibles != null)
            {
                foreach (var collectible in SaveFile.SaveData.AlreadySeenCollectibles.Select(c => c.Name).ToList())
                {
                    dgvAlreadySeenCollectibles.Rows.Add(collectible);
                }
            }

            dgvAlreadySeenCharacters.Rows.Clear();
            if (SaveFile.SaveData.AlreadySeenCharacters != null)
            {
                foreach (var character in SaveFile.SaveData.AlreadySeenCharacters.Select(c => c.Name).ToList())
                {
                    dgvAlreadySeenCharacters.Rows.Add(character);
                }
            }

            dgvCheckpointReached.Rows.Clear();
            if (SaveFile.SaveData.CheckpointReached != null)
            {
                foreach (var checkpoint in SaveFile.SaveData.CheckpointReached)
                {
                    dgvCheckpointReached.Rows.Add(checkpoint);
                }
            }

            dgvCheckpointLevelRecords.Rows.Clear();
            if (SaveFile.SaveData.CheckpointLevelRecords != null)
            {
                foreach (var record in SaveFile.SaveData.CheckpointLevelRecords)
                {
                    dgvCheckpointLevelRecords.Rows.Add(record.LevelName.Name, record.bShouldBeLoaded, record.bShouldBeVisible);
                }
            }

            dgvAchievements.Rows.Clear();
            if (SaveFile.SaveData.Achievements != null)
            {
                foreach (var achievement in SaveFile.SaveData.Achievements)
                {
                    dgvAchievements.Rows.Add(
                        achievement.Id,
                        achievement.Type,
                        achievement.bHidden,
                        achievement.PlaystationGrade,
                        achievement.XboxGamerscore,
                        achievement.Title,
                        achievement.Description,
                        achievement.HowTo,
                        achievement.CountersLimit,
                        achievement.bResetCountersWhenPlayerDie,
                        achievement.CurrentCountersValue);
                }
            }

            dgvVisibleLevels.Rows.Clear();
            if (SaveFile.SaveData.VisibleLevels != null)
            {
                foreach (var level in SaveFile.SaveData.VisibleLevels.Select(c => c.Name).ToList())
                {
                    dgvVisibleLevels.Rows.Add(level);
                }
            }

            if (SaveFile.SaveData.PlayerProgress == null)
            {
                tcPlayerProgress.Visible = false;
            }
            else
            {
                tcPlayerProgress.Visible = true;

                tbCurrentObjectiveID.Text = SaveFile.SaveData.PlayerProgress.CurrentObjectiveID != null
                    ? SaveFile.SaveData.PlayerProgress.CurrentObjectiveID.Name
                    : string.Empty;

                nudCurrentDay.Value = SaveFile.SaveData.PlayerProgress.CurrentDay ?? 0;

                if (SaveFile.SaveData.PlayerProgress.DiaryAlreadySeen != null)
                    cbDiaryAlreadySeen.CheckState = SaveFile.SaveData.PlayerProgress.DiaryAlreadySeen.Value ? CheckState.Checked : CheckState.Unchecked;
                else
                    cbDiaryAlreadySeen.CheckState = CheckState.Indeterminate;

                nudLastDiaryDaySeen.Value = SaveFile.SaveData.PlayerProgress.LastDiaryDaySeen ?? 0;

                nudLastDiaryPageSeen.Value = SaveFile.SaveData.PlayerProgress.LastDiaryPageSeen ?? 0;

                tbMaxReachedContextName0.Text = SaveFile.SaveData.PlayerProgress.MaxReachedContextName[0];
                tbMaxReachedContextName1.Text = SaveFile.SaveData.PlayerProgress.MaxReachedContextName[1];
                tbMaxReachedContextName2.Text = SaveFile.SaveData.PlayerProgress.MaxReachedContextName[2];
                tbMaxReachedContextName3.Text = SaveFile.SaveData.PlayerProgress.MaxReachedContextName[3];
                tbMaxReachedContextName4.Text = SaveFile.SaveData.PlayerProgress.MaxReachedContextName[4];

                nudEpisodePlayTimePauseExcluded0.Value = (decimal) SaveFile.SaveData.PlayerProgress.fEpisodePlayTimePauseExcluded[0];
                nudEpisodePlayTimePauseExcluded1.Value = (decimal) SaveFile.SaveData.PlayerProgress.fEpisodePlayTimePauseExcluded[1];
                nudEpisodePlayTimePauseExcluded2.Value = (decimal) SaveFile.SaveData.PlayerProgress.fEpisodePlayTimePauseExcluded[2];
                nudEpisodePlayTimePauseExcluded3.Value = (decimal) SaveFile.SaveData.PlayerProgress.fEpisodePlayTimePauseExcluded[3];
                nudEpisodePlayTimePauseExcluded4.Value = (decimal) SaveFile.SaveData.PlayerProgress.fEpisodePlayTimePauseExcluded[4];

                nudEpisodePlayTimePauseIncluded0.Value = (decimal) SaveFile.SaveData.PlayerProgress.fEpisodePlayTimePauseIncluded[0];
                nudEpisodePlayTimePauseIncluded1.Value = (decimal) SaveFile.SaveData.PlayerProgress.fEpisodePlayTimePauseIncluded[1];
                nudEpisodePlayTimePauseIncluded2.Value = (decimal) SaveFile.SaveData.PlayerProgress.fEpisodePlayTimePauseIncluded[2];
                nudEpisodePlayTimePauseIncluded3.Value = (decimal) SaveFile.SaveData.PlayerProgress.fEpisodePlayTimePauseIncluded[3];
                nudEpisodePlayTimePauseIncluded4.Value = (decimal) SaveFile.SaveData.PlayerProgress.fEpisodePlayTimePauseIncluded[4];

                dgvActiveTutorials.Rows.Clear();
                if (SaveFile.SaveData.PlayerProgress.ActiveTutorials != null)
                {
                    foreach (var tutorial in SaveFile.SaveData.PlayerProgress.ActiveTutorials)
                    {
                        dgvActiveTutorials.Rows.Add(tutorial.ToString());
                    }
                }

                cbActiveFactsFilterInteractions.Checked = true;
                cbActiveFactsFilterInternal.Checked = true;
                cbActiveFactsFilterTutorials.Checked = true;
                cbActiveFactsFilterDiary.Checked = true;
                cbActiveFactsFilterCollectibles.Checked = true;
                dgvActiveFacts.Rows.Clear();
                if (SaveFile.SaveData.PlayerProgress.ActiveFacts != null)
                {
                    foreach (var fact in SaveFile.SaveData.PlayerProgress.ActiveFacts)
                    {
                        dgvActiveFacts.Rows.Add(fact.FactLevel > 0, (EWhatIfFactLevel) Math.Abs(fact.FactLevel.Value), fact.FactName.Name, fact.FactLevel);
                    }
                }

                dgvFileSelects.Rows.Clear();
                if (SaveFile.SaveData.PlayerProgress.FileSelects != null)
                {
                    foreach (var file in SaveFile.SaveData.PlayerProgress.FileSelects)
                    {
                        dgvFileSelects.Rows.Add(file.ObjectName.Name, file.TextureKey, string.Join(";", file.Pages));
                    }
                }

                dgvInventoryObjects.Rows.Clear();
                if (SaveFile.SaveData.PlayerProgress.InventoryObjects != null)
                {
                    foreach (var obj in SaveFile.SaveData.PlayerProgress.InventoryObjects)
                    {
                        dgvInventoryObjects.Rows.Add(obj.ObjectName.Name, obj.ObjectInstanceCount);
                    }
                }

                dgvCollectibleFoundFactNames.Rows.Clear();
                if (SaveFile.SaveData.PlayerProgress.CollectibleFoundFactNames != null)
                {
                    foreach (var name in SaveFile.SaveData.PlayerProgress.CollectibleFoundFactNames)
                    {
                        dgvCollectibleFoundFactNames.Rows.Add(name.Name);
                    }
                }

                var playerProgress = SaveFile.SaveData.PlayerProgress;
                nudBoundaryStats00Rewinds.Value = GetBoundaryStat(playerProgress, 0, 0, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats01Rewinds.Value = GetBoundaryStat(playerProgress, 0, 1, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats02Rewinds.Value = GetBoundaryStat(playerProgress, 0, 2, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats03Rewinds.Value = GetBoundaryStat(playerProgress, 0, 3, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats04Rewinds.Value = GetBoundaryStat(playerProgress, 0, 4, BoundaryStatType.Rewinds) ?? 0;

                nudBoundaryStats10Rewinds.Value = GetBoundaryStat(playerProgress, 1, 0, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats11Rewinds.Value = GetBoundaryStat(playerProgress, 1, 1, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats12Rewinds.Value = GetBoundaryStat(playerProgress, 1, 2, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats13Rewinds.Value = GetBoundaryStat(playerProgress, 1, 3, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats14Rewinds.Value = GetBoundaryStat(playerProgress, 1, 4, BoundaryStatType.Rewinds) ?? 0;

                nudBoundaryStats20Rewinds.Value = GetBoundaryStat(playerProgress, 2, 0, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats21Rewinds.Value = GetBoundaryStat(playerProgress, 2, 1, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats22Rewinds.Value = GetBoundaryStat(playerProgress, 2, 2, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats23Rewinds.Value = GetBoundaryStat(playerProgress, 2, 3, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats24Rewinds.Value = GetBoundaryStat(playerProgress, 2, 4, BoundaryStatType.Rewinds) ?? 0;

                nudBoundaryStats30Rewinds.Value = GetBoundaryStat(playerProgress, 3, 0, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats31Rewinds.Value = GetBoundaryStat(playerProgress, 3, 1, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats32Rewinds.Value = GetBoundaryStat(playerProgress, 3, 2, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats33Rewinds.Value = GetBoundaryStat(playerProgress, 3, 3, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats34Rewinds.Value = GetBoundaryStat(playerProgress, 3, 4, BoundaryStatType.Rewinds) ?? 0;

                nudBoundaryStats40Rewinds.Value = GetBoundaryStat(playerProgress, 4, 0, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats41Rewinds.Value = GetBoundaryStat(playerProgress, 4, 1, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats42Rewinds.Value = GetBoundaryStat(playerProgress, 4, 2, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats43Rewinds.Value = GetBoundaryStat(playerProgress, 4, 3, BoundaryStatType.Rewinds) ?? 0;
                nudBoundaryStats44Rewinds.Value = GetBoundaryStat(playerProgress, 4, 4, BoundaryStatType.Rewinds) ?? 0;

                nudBoundaryStats00Hints.Value = GetBoundaryStat(playerProgress, 0, 0, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats01Hints.Value = GetBoundaryStat(playerProgress, 0, 1, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats02Hints.Value = GetBoundaryStat(playerProgress, 0, 2, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats03Hints.Value = GetBoundaryStat(playerProgress, 0, 3, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats04Hints.Value = GetBoundaryStat(playerProgress, 0, 4, BoundaryStatType.Hints) ?? 0;

                nudBoundaryStats10Hints.Value = GetBoundaryStat(playerProgress, 1, 0, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats11Hints.Value = GetBoundaryStat(playerProgress, 1, 1, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats12Hints.Value = GetBoundaryStat(playerProgress, 1, 2, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats13Hints.Value = GetBoundaryStat(playerProgress, 1, 3, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats14Hints.Value = GetBoundaryStat(playerProgress, 1, 4, BoundaryStatType.Hints) ?? 0;

                nudBoundaryStats20Hints.Value = GetBoundaryStat(playerProgress, 2, 0, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats21Hints.Value = GetBoundaryStat(playerProgress, 2, 1, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats22Hints.Value = GetBoundaryStat(playerProgress, 2, 2, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats23Hints.Value = GetBoundaryStat(playerProgress, 2, 3, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats24Hints.Value = GetBoundaryStat(playerProgress, 2, 4, BoundaryStatType.Hints) ?? 0;

                nudBoundaryStats30Hints.Value = GetBoundaryStat(playerProgress, 3, 0, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats31Hints.Value = GetBoundaryStat(playerProgress, 3, 1, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats32Hints.Value = GetBoundaryStat(playerProgress, 3, 2, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats33Hints.Value = GetBoundaryStat(playerProgress, 3, 3, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats34Hints.Value = GetBoundaryStat(playerProgress, 3, 4, BoundaryStatType.Hints) ?? 0;

                nudBoundaryStats40Hints.Value = GetBoundaryStat(playerProgress, 4, 0, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats41Hints.Value = GetBoundaryStat(playerProgress, 4, 1, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats42Hints.Value = GetBoundaryStat(playerProgress, 4, 2, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats43Hints.Value = GetBoundaryStat(playerProgress, 4, 3, BoundaryStatType.Hints) ?? 0;
                nudBoundaryStats44Hints.Value = GetBoundaryStat(playerProgress, 4, 4, BoundaryStatType.Hints) ?? 0;

                Cursor = Cursors.Default;
            }

            dgvSubLevelStartStates.Rows.Clear();
            if (SaveFile.SaveData.SLevelStartStates != null)
            {
                foreach (var state in SaveFile.SaveData.SLevelStartStates)
                {
                    var sli = SubLevelsInfo.SubLevels.FirstOrDefault(l => l.Name == state.SubLevelTitle);
                    var index = dgvSubLevelStartStates.Rows.Add(state.SubLevelTitle, sli == null ? string.Empty : sli.Description);
                    dgvSubLevelStartStates.Rows[index].Tag = state.PlayerProgress;
                }
            }

            tcSaveData.ResumeLayout(true);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (ofdSaveFile.ShowDialog() == DialogResult.OK)
            {
                SaveFilePath = ofdSaveFile.FileName;
                
                LoadFile();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SaveFilePath)) return;

            if (MessageBox.Show(string.Format("Overwrite file?{0}{1}", Environment.NewLine, SaveFilePath), "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            Cursor = Cursors.WaitCursor;

            var ms = new MemoryStream();
            SezializeSaveFile(ms, SaveFile);

            using (var fs = File.Create(SaveFilePath))
            {
                ms.WriteTo(fs);
            }

            Cursor = Cursors.Default;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SaveFilePath))
                LoadFile();
        }

        private void TimeNUDValueChanged(object sender, EventArgs e)
        {
            var lblName = ((sender as Control).Name).Substring(3);
            (sender as Control).Parent.Controls[string.Format("lbl{0}Formatted", lblName)].Text =
                string.Format("= {0}", FloatToTimeSpan((float) ((NumericUpDown) sender).Value).ToString("g"));
        }

        private static TimeSpan FloatToTimeSpan(float value)
        {
            return TimeSpan.FromMilliseconds(value * 1000);
        }

        private string GetCaptionWithCountForTab(string caption, IList list)
        {
            return string.Format("{0} [{1}]", caption, list == null ? "-" : list.Count.ToString());
        }

        private string GetNullableFromTextBox(TextBox textBox)
        {
            return string.IsNullOrEmpty(textBox.Text) ? null : textBox.Text;
        }

        private string GetNullableFromComboBox(ComboBox comboBox)
        {
            return string.IsNullOrEmpty(comboBox.Text) ? null : comboBox.Text;
        }

        private bool? GetNullableFromCheckbox(CheckBox checkBox)
        {
            return checkBox.CheckState != CheckState.Indeterminate
                ? checkBox.CheckState == CheckState.Checked
                : (bool?) null;
        }

        private int? GetBoundaryStat(PlayerProgress playerProgress, int epNum, int boundaryType, BoundaryStatType statType)
        {
            if (playerProgress.EpisodeBoundaryStats[epNum] == null)
                return null;
            if (playerProgress.EpisodeBoundaryStats[epNum].BoundaryStats[boundaryType] == null)
                return null;
            return statType == BoundaryStatType.Rewinds
                ? playerProgress.EpisodeBoundaryStats[epNum].BoundaryStats[boundaryType].NbRewinds
                : playerProgress.EpisodeBoundaryStats[epNum].BoundaryStats[boundaryType].NbHints;
        }

        private void FilterActiveFacts(ActiveFactsFilter filter, bool show)
        {
            var rows = dgvActiveFacts.Rows.OfType<DataGridViewRow>().DropLast().ToList();
            switch (filter)
            {
                case ActiveFactsFilter.Interactions:
                    rows = rows.Where(r => r.Cells["colActiveFactsName"].Value.ToString().EndsWith("_Triggered")).ToList();
                    break;
                case ActiveFactsFilter.Internal:
                    rows = rows.Where(r => r.Cells["colActiveFactsName"].Value.ToString().StartsWith("Internal_")).ToList();
                    break;
                case ActiveFactsFilter.Tutorials:
                    rows = rows.Where(r => r.Cells["colActiveFactsName"].Value.ToString().StartsWith("NOTIFY_Tuto")).ToList();
                    break;
                case ActiveFactsFilter.Diary:
                    rows = rows.Where(r => r.Cells["colActiveFactsName"].Value.ToString().StartsWith("Diary_")).ToList();
                    break;
                case ActiveFactsFilter.Collectibles:
                    rows = rows.Where(r => r.Cells["colActiveFactsName"].Value.ToString().EndsWith("_Collectible")).ToList();
                    break;
                case ActiveFactsFilter.Sms:
                    rows = rows.Where(r => r.Cells["colActiveFactsName"].Value.ToString().Contains("_SMS_")).ToList();
                    break;
                    case ActiveFactsFilter.Choices:
                    /*var choices = EpisodesInfo.Episodes
                        .SelectMany(e => e.MajorChoices
                            .SelectMany(c => c.ChoiceResults
                                .Select(r => new
                                {
                                    name = r.Id.Name,
                                    fact = r.Fact.Name
                                })))
                        .ToList();*/
                    var choices = EpisodesInfo.Episodes
                        .SelectMany(e => e.MajorChoices
                            .SelectMany(c => c.ChoiceResults
                                .Select(r => r.Fact.Name))).ToList();
                    rows = rows.Where(r => choices.Contains(r.Cells["colActiveFactsName"].Value.ToString())).ToList();
                    break;
            }
            Cursor = Cursors.WaitCursor;
            dgvActiveFacts.SuspendLayout();
            dgvActiveFacts.Columns.OfType<DataGridViewColumn>().ToList().ForEach(c => c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None);
            rows.ForEach(r => r.Visible = show);
            dgvActiveFacts.Columns.OfType<DataGridViewColumn>().ToList().ForEach(c => c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells);
            lblActiveFactsShownCount.Text = string.Format("Shown: {0}", dgvActiveFacts.Rows.OfType<DataGridViewRow>().Count(r => r.Visible) - 1);
            dgvActiveFacts.ResumeLayout(true);
            Cursor = Cursors.Default;
        }

        private void cbActiveFactsFilterInteractions_CheckedChanged(object sender, EventArgs e)
        {
            FilterActiveFacts(ActiveFactsFilter.Interactions, cbActiveFactsFilterInteractions.Checked);
        }

        private void cbActiveFactsFilterInternal_CheckedChanged(object sender, EventArgs e)
        {
            FilterActiveFacts(ActiveFactsFilter.Internal, cbActiveFactsFilterInternal.Checked);
        }

        private void cbActiveFactsFilterTutorials_CheckedChanged(object sender, EventArgs e)
        {
            FilterActiveFacts(ActiveFactsFilter.Tutorials, cbActiveFactsFilterTutorials.Checked);
        }

        private void cbActiveFactsFilterDiary_CheckedChanged(object sender, EventArgs e)
        {
            FilterActiveFacts(ActiveFactsFilter.Diary, cbActiveFactsFilterDiary.Checked);
        }

        private void cbActiveFactsFilterCollectibles_CheckedChanged(object sender, EventArgs e)
        {
            FilterActiveFacts(ActiveFactsFilter.Collectibles, cbActiveFactsFilterCollectibles.Checked);
        }

        private void cbActiveFactsFilterSms_CheckedChanged(object sender, EventArgs e)
        {
            FilterActiveFacts(ActiveFactsFilter.Sms, cbActiveFactsFilterSms.Checked);
        }

        private void cbActiveFactsFilterChoices_CheckedChanged(object sender, EventArgs e)
        {
            FilterActiveFacts(ActiveFactsFilter.Choices, cbActiveFactsFilterChoices.Checked);
        }

        private void dgvSubLevelStartStates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView) sender;
            if (e.ColumnIndex == grid.Columns["colSubLevelStartStatesEdit"].Index && e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count-1)
            {
                var progress = (PlayerProgress) grid.Rows[e.RowIndex].Tag;
                var form = new PlayerProgressEditForm(progress, grid.Rows[e.RowIndex].Cells["colSubLevelStartStatesSubLevelName"].Value.ToString());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    grid.Rows[e.RowIndex].Tag = form.PlayerProgress;
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            (new AboutForm()).ShowDialog();
        }

        private void dgvSubLevelStartStates_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Tag = null;
        }
    }
}
