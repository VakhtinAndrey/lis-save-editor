using System.Collections.Generic;

namespace LifeIsStrangeSaveEditor.Win
{
    public class CheckpointsInfo
    {
        // Source: E1_1A.upk (IA_CheckpointSystem class)
        /* 
         * x2
         * E1_3B_CP02_VictoriaPuzzle
         * E1_5A_CP03_DavidHome
         * E3_3A_CP02_PoolOn
         * E3_3A_CP03_GuardEnters
         */
        public static List<IA_CheckpointSystem> Checkpoints = new List<IA_CheckpointSystem>
        {
            #region E1_1A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_1A_CP01_Insertion",
            },

            #endregion
            
            #region E1_2A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_2A_CP02_LeavingClassRoom",
                LevelsOverride = new List<string>
                {
                    "e1_2a_amb",
                    "e1_2a_fx",
                    "e1_2a_fxc",
                    "e1_2a_backgroundc",
                    "e1_2a_sd",
                    "e1_2a_artclass_grc",
                    "e1_2a_artclass_gr2",
                    "e1_2a_corridor_grc",
                    "e1_2a_corridor_gr2",
                    "e1_2a_corridor_ld",
                    "e1_2a_toilets_grc",
                    "e1_2a_toilets_ld",
                    "e1_2a_sciclass_grc",
                },
                VisibleLevels = new List<string>
                {
                    "e1_2a_artclass_grc",
                    "e1_2a_artclass_gr2",
                    "e1_2a_corridor_grc",
                    "e1_2a_corridor_gr2",
                    "e1_2a_corridor_ld",
                },
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_2A_ArtClass_CHJefferson_Phase02_Ended",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_2A_CP04_LeavingClassRoom2ndTime",
                LevelsOverride = new List<string>
                {
                    "e1_2a_amb",
                    "e1_2a_fx",
                    "e1_2a_fxc",
                    "e1_2a_backgroundc",
                    "e1_2a_sd",
                    "e1_2a_artclass_grc",
                    "e1_2a_artclass_gr2",
                    "e1_2a_corridor_grc",
                    "e1_2a_corridor_gr2",
                    "e1_2a_corridor_ld",
                    "e1_2a_toilets_grc",
                    "e1_2a_toilets_ld",
                    "e1_2a_sciclass_grc",
                },
                VisibleLevels = new List<string>
                {
                    "e1_2a_artclass_grc",
                    "e1_2a_artclass_gr2",
                    "e1_2a_corridor_grc",
                    "e1_2a_corridor_gr2",
                    "e1_2a_corridor_ld",
                },
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_2A_ArtClass_CHJefferson_Phase02_Ended",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_2A_REWINDED",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_2A_Toilets_LD_Is2ndToilets",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_2A_CP05_ToiletsPuzzle",
                LevelsOverride = new List<string>
                {
                    "e1_2a_amb",
                    "e1_2a_fx",
                    "e1_2a_fxc",
                    "e1_2a_backgroundc",
                    "e1_2a_sd",
                    "e1_2a_artclass_grc",
                    "e1_2a_artclass_gr2",
                    "e1_2a_corridor_grc",
                    "e1_2a_corridor_gr2",
                    "e1_2a_corridor_ld",
                    "e1_2a_toilets_grc",
                    "e1_2a_toilets_ld",
                    "e1_2a_sciclass_grc",
                },
                VisibleLevels = new List<string>
                {
                    "e1_2a_corridor_grc",
                    "e1_2a_corridor_gr2",
                    "e1_2a_corridor_ld",
                    "e1_2a_toilets_grc",
                    "e1_2a_toilets_ld",
                },
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_2A_REWINDED",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_2A_Toilets_LD_SafeChloe",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_2A_Toilets_LD_Is2ndToilets",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_2A_CP03_ArtClass",
                LevelsOverride = new List<string>
                {
                    "e1_2a_amb",
                    "e1_2a_fx",
                    "e1_2a_fxc",
                    "e1_2a_backgroundc",
                    "e1_2a_sd",
                    "e1_2a_artclass_grc",
                    "e1_2a_artclass_gr2",
                    "e1_2a_artclass_ld",
                    "e1_2a_corridor_grc",
                    "e1_2a_corridor_gr2",
                    "e1_2a_corridor_ld",
                    "e1_2a_toilets_grc",
                    "e1_2a_sciclass_grc",
                },
                VisibleLevels = new List<string>
                {
                    "e1_2a_artclass_grc",
                    "e1_2a_artclass_gr2",
                    "e1_2a_artclass_ld",
                },
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_2A_REWINDED",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "ZONE_DejaVu",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_2A_Toilets_LD_Is2ndToilets",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_2A_CP01_Insertion",
                LevelsOverride = new List<string>
                {
                    "e1_2a_amb",
                    "e1_2a_fx",
                    "e1_2a_fxc",
                    "e1_2a_backgroundc",
                    "e1_2a_sd",
                    "e1_2a_artclass_grc",
                    "e1_2a_artclass_gr2",
                    "e1_2a_artclass_ld",
                    "e1_2a_corridor_grc",
                    "e1_2a_corridor_gr2",
                    "e1_2a_corridor_ld",
                    "e1_2a_toilets_grc",
                    "e1_2a_sciclass_grc",
                },
                VisibleLevels = new List<string>
                {
                    "e1_2a_artclass_grc",
                    "e1_2a_artclass_gr2",
                    "e1_2a_artclass_ld",
                },
            },

            #endregion
            
            #region E1_3A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_3A_CP01_Insertion",
                LevelsOverride = new List<string>
                {
                    "e1_3a_amb",
                    "e1_3a_fx",
                    "e1_3a_fxc",
                    "e1_3a_backgroundc",
                    "e1_3a_sd",
                    "e1_3a_campusa_grc",
                    "e1_3a_campusa_gr2",
                    "e1_3a_campusa_ld",
                    "e1_3a_campusa_ld2",
                },
                VisibleLevels = new List<string>
                {
                    "e1_3a_campusa_grc",
                    "e1_3a_campusa_gr2",
                    "e1_3a_campusa_ld",
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_3A_CP02_BackToCampusA",
                LevelsOverride = new List<string>
                {
                    "e1_3a_amb",
                    "e1_3a_fx",
                    "e1_3a_fxc",
                    "e1_3a_backgroundc",
                    "e1_3a_sd",
                    "e1_3a_campusa_grc",
                    "e1_3a_campusa_ld3",
                },
                VisibleLevels = new List<string>
                {
                    "e1_3a_campusa_grc",
                    "e1_3a_campusa_ld3",
                },
            },

            #endregion

            #region E1_3B
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_3B_CP02_VictoriaPuzzle",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_3B_Puzzle_Resolved",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_3B_CampusB_LD_BucketWeightened",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_3B_CampusB_LD_PipePressureBoosted",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_3B_CampusB_LD_VictoriaStained",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_3B_CP03_Insertion",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_3B_CP02_VictoriaPuzzle",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_3B_Puzzle_Resolved",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_3B_CampusB_LD_BucketWeightened",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_3B_CampusB_LD_PipePressureBoosted",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_3B_CampusB_LD_VictoriaStained",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_3B_CP01_Insertion",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },

            #endregion

            #region E1_3C
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_3C_CP02_JulietLockDoor",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "E1_3C_MaxRoom_DanaNote_Look01_Triggered",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_3C_MaxRoom_MaxRoomDoor_Interact02_Triggered",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "Debug_Checkpoint_MaxDoor",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "Debug_JournalCP02",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_3C_CP03_JulietUnlockDoor",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "E1_3C_MaxRoom_DanaNote_Look01_Triggered",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_3C_MaxRoom_MaxRoomDoor_Interact02_Triggered",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "UnlockVictoriaDoor",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "Debug_Checkpoint_MaxDoor",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "Debug_Checkpoint",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "Mail_read",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_3C_CP01_Insertion",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Debug_JournalCP01",
                        Level = EWhatIfFactLevel.EWIFL_Game
                    },
                },
            },

            #endregion

            #region E1_3D
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_3D_CP01_Insertion",
                LevelsOverride = new List<string>
                {
                    "e1_3d_amb",
                    "e1_3d_fx",
                    "e1_3d_fxc",
                    "e1_3d_backgroundc",
                    "e1_3d_sd",
                    "e1_3d_campuspark_grc",
                    "e1_3d_campuspark_gr2",
                    "e1_3d_campuspark_ld",
                },
                VisibleLevels = new List<string>
                {
                    "e1_3d_campuspark_grc",
                    "e1_3d_campuspark_gr2",
                    "e1_3d_campuspark_ld",
                },
            },

            #endregion

            #region E1_4A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_4A_CP01_Insertion",
            },

            #endregion

            #region E1_5A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_5A_CP03_DavidHome",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_5A_ChloeRoom_LD_HideUnderBedAvailable",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_5A_ChloeRoom_LD_WindowInteract01",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_5A_ChloeRoom_LD_TriedToRepairDone",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_5A_ChloeRoom_LD_SearchingTools",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_5A_ChloeRoom_LD_SearchingTools",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_5A_CP03_DavidHome",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_5A_ChloeRoom_LD_SearchingTools",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_5A_ChloeRoom_LD_HideUnderBedAvailable",
                        Level = EWhatIfFactLevel.EWIFL_Layer
                    },
                    new DebugFact
                    {
                        Name = "E1_5A_ChloeRoom_LD_WindowInteract01",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_5A_ChloeRoom_LD_TriedToRepairDone",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_5A_ChloeRoom_LD_SearchingTools",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_5A_CP02_Insertion",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_5A_ChloeRoom_LD_SearchingTools",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_5A_ChloeRoom_LD_CDwasPlayed",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E1_5A_ChloeRoom_LD_TriedToRepairDone",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
                DebugInventoryObjectToAdd = new List<string>
                {
                    "E1_5B_Garage_PizzaBox",
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_5A_CP01_Insertion",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },

            #endregion

            #region E1_5B
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_5B_CP01_Insertion",
            },

            #endregion

            #region E1_6A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_6A_CP01_Insertion",
            },

            #endregion

            #region E1_6B
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E1_6B_CP01_Insertion",
            },

            #endregion

            #region E2_1A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_1A_CP01_Insertion",
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_1A_CP02_AfterShower",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "E2_1A_ShowerDone",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E2_1A_ShowerStuff",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "Kate_stop_Max",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E2_1A_Corridor_LD_DialJulietBrooke_Available",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E2_1A_GP_ON",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E2_Debug_CP02",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_1A_CP03_WithBookAndClothes",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "E2_1A_ShowerDone",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E2_1A_ShowerStuff",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "Kate_stop_Max",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E2_1A_KateBook",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E2_1A_MaxDressedUp",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E2_1A_Corridor_LD_DialJulietBrooke_Available",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E2_1A_GP_ON",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                    new DebugFact
                    {
                        Name = "E2_Debug_CP03",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },

            #endregion

            #region E2_1B
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_1B_CP01_Insertion",
                LevelsOverride = new List<string>
                {
                    "e2_1b_amb",
                    "e2_1b_fx",
                    "e2_1b_fxc",
                    "e2_1b_backgroundc",
                    "e2_1b_sd",
                    "e2_1b_campusb_grc",
                    "e2_1b_campusb_ld",
                    "e2_1b_campusb_gr2",
                },
                VisibleLevels = new List<string>
                {
                    "e2_1b_campusb_grc",
                    "e2_1b_campusb_ld",
                    "e2_1b_campusb_gr2",
                },
            },

            #endregion

            #region E2_1C
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_1C_CP01_Insertion",
                LevelsOverride = new List<string>
                {
                    "e2_1c_amb",
                    "e2_1d_fx",
                    "e2_1c_fxc",
                    "e2_1c_backgroundc",
                    "e2_1c_sd",
                    "e2_1c_campusa_grc",
                    "e2_1c_campusa_ld",
                    "e2_1c_campusa_gr2",
                },
                VisibleLevels = new List<string>
                {
                    "e2_1c_campusa_grc",
                    "e2_1c_campusa_ld",
                    "e2_1c_campusa_gr2",
                },
            },

            #endregion

            #region E2_1D
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_1D_CP01_Insertion",
            },

            #endregion

            #region E2_2A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_2A_CP01_Insertion",
                VisibleLevels = new List<string>
                {
                    "e2_2a_diner_ld",
                    "e2_2a_dinerpark_ld",
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_2A_CP02_Sitting",
                VisibleLevels = new List<string>
                {
                    "e2_2a_diner_ld",
                    "e2_2a_dinerpark_ld",
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_2A_CP03_AfterDivination",
                VisibleLevels = new List<string>
                {
                    "e2_2a_diner_ld",
                    "e2_2a_dinerpark_ld",
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_2A_CP04_AfterPrediction",
                VisibleLevels = new List<string>
                {
                    "e2_2a_diner_ld",
                    "e2_2a_dinerpark_ld",
                },
            },

            #endregion

            #region E2_3A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_3A_CP02_AllBottles",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "E2_3A_Junkyard_LD_PossessAllBottles",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
                DebugInventoryObjectToAdd = new List<string>
                {
                    "E2_3A_Junkyard_Bottle01",
                    "E2_3A_Junkyard_Bottle02",
                    "E2_3A_Junkyard_Bottle03",
                    "E2_3A_Junkyard_Bottle04",
                    "E2_3A_Junkyard_Bottle05",
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_3A_CP03_AfterShooting",
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_3A_CP01_Insertion",
            },

            #endregion

            #region E2_3B
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_3B_CP02_ChloeIsStuck",
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_3B_CP01_Insertion",
            },

            #endregion

            #region E2_4A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_4A_CP01_Insertion",
            },

            #endregion

            #region E2_4B
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_4B_CP01_Insertion",
                LevelsOverride = new List<string>
                {
                    "e2_4b_amb",
                    "e2_4b_fx",
                    "e2_4b_fxc",
                    "e2_4b_backgroundc",
                    "e2_4b_sd",
                    "e2_4b_artclass_grc",
                    "e2_4b_artclass_gr2",
                    "e2_4b_artclass_ld",
                    "e2_4b_corridor_grc",
                    "e2_4b_corridor_gr2",
                    "e2_4b_corridor_ld",
                    "e2_4b_sciclass_grc",
                    "e2_4b_sciclass_ld",
                    "e2_4b_sciclass_gr2",
                },
                VisibleLevels = new List<string>
                {
                    "e2_4b_corridor_grc",
                    "e2_4b_corridor_gr2",
                    "e2_4b_corridor_ld",
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_4B_CP02_Sitting",
                LevelsOverride = new List<string>
                {
                    "e2_4b_amb",
                    "e2_4b_fx",
                    "e2_4b_fxc",
                    "e2_4b_backgroundc",
                    "e2_4b_sd",
                    "e2_4b_artclass_grc",
                    "e2_4b_artclass_gr2",
                    "e2_4b_artclass_ld",
                    "e2_4b_corridor_grc",
                    "e2_4b_corridor_gr2",
                    "e2_4b_sciclass_grc",
                    "e2_4b_sciclass_gr2",
                },
                VisibleLevels = new List<string>
                {
                    "e2_4b_artclass_grc",
                    "e2_4b_artclass_gr2",
                    "e2_4b_artclass_ld",
                },
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "E2_4B_ArtClass_CHNathan_Speak01_Triggered",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },

            #endregion

            #region E2_4C
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_4C_CP02_OnTheRoof",
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_4C_CP01_Insertion",
            },

            #endregion

            #region E2_5A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_5A_CP01_Insertion",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },

            #endregion

            #region E2_6A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E2_6A_CP01_Insertion",
            },

            #endregion

            #region E3_1A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_1A_CP01_Insertion",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "E3_Debug_CP01",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },

            #endregion

            #region E3_1B
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_1B_CP01_Insertion",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "E3Debug_E3_1B_CP01",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },

            #endregion

            #region E3_1C
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_1C_CP01_Insertion",
            },

            #endregion

            #region E3_2A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_2A_CP01_Insertion",
                LevelsOverride = new List<string>
                {
                    "e3_2a_amb",
                    "e3_2a_fx",
                    "e3_2a_fxc",
                    "e3_2a_backgroundc",
                    "e3_2a_sd",
                    "e3_2a_artclass_grc",
                    "e3_2a_artclass_ld",
                    "e3_2a_corridor_grc",
                    "e3_2a_corridor_ld",
                    "e3_2a_prinoffice_grc",
                    "e3_2a_prinoffice_ld",
                    "e3_2a_sciclass_grc",
                    "e3_2a_sciclass_ld",
                },
                VisibleLevels = new List<string>
                {
                    "e3_2a_amb",
                    "e3_2a_fx",
                    "e3_2a_fxc",
                    "e3_2a_backgroundc",
                    "e3_2a_sd",
                    "e3_2a_artclass_grc",
                    "e3_2a_artclass_ld",
                    "e3_2a_corridor_grc",
                    "e3_2a_corridor_ld",
                    "e3_2a_prinoffice_grc",
                    "e3_2a_prinoffice_ld",
                    "e3_2a_sciclass_grc",
                    "e3_2a_sciclass_ld",
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_2A_CP02_IngredientsHunt",
                LevelsOverride = new List<string>
                {
                    "e3_2a_amb",
                    "e3_2a_fx",
                    "e3_2a_fxc",
                    "e3_2a_backgroundc",
                    "e3_2a_sd",
                    "e3_2a_artclass_grc",
                    "e3_2a_artclass_ld",
                    "e3_2a_corridor_grc",
                    "e3_2a_corridor_ld",
                    "e3_2a_prinoffice_grc",
                    "e3_2a_prinoffice_ld",
                    "e3_2a_sciclass_grc",
                    "e3_2a_sciclass_ld",
                },
                VisibleLevels = new List<string>
                {
                    "e3_2a_amb",
                    "e3_2a_fx",
                    "e3_2a_fxc",
                    "e3_2a_backgroundc",
                    "e3_2a_sd",
                    "e3_2a_artclass_grc",
                    "e3_2a_artclass_ld",
                    "e3_2a_corridor_grc",
                    "e3_2a_corridor_ld",
                    "e3_2a_prinoffice_grc",
                    "e3_2a_prinoffice_ld",
                    "e3_2a_sciclass_grc",
                    "e3_2a_sciclass_ld",
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_2A_CP03_BombReady",
                LevelsOverride = new List<string>
                {
                    "e3_2a_amb",
                    "e3_2a_fx",
                    "e3_2a_fxc",
                    "e3_2a_backgroundc",
                    "e3_2a_sd",
                    "e3_2a_artclass_grc",
                    "e3_2a_artclass_ld",
                    "e3_2a_corridor_grc",
                    "e3_2a_corridor_ld",
                    "e3_2a_prinoffice_grc",
                    "e3_2a_prinoffice_ld",
                    "e3_2a_sciclass_grc",
                    "e3_2a_sciclass_ld",
                },
                VisibleLevels = new List<string>
                {
                    "e3_2a_amb",
                    "e3_2a_fx",
                    "e3_2a_fxc",
                    "e3_2a_backgroundc",
                    "e3_2a_sd",
                    "e3_2a_artclass_grc",
                    "e3_2a_artclass_ld",
                    "e3_2a_corridor_grc",
                    "e3_2a_corridor_ld",
                    "e3_2a_prinoffice_grc",
                    "e3_2a_prinoffice_ld",
                    "e3_2a_sciclass_grc",
                    "e3_2a_sciclass_ld",
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_2A_CP04_InsidePrinOffice",
                LevelsOverride = new List<string>
                {
                    "e3_2a_amb",
                    "e3_2a_fx",
                    "e3_2a_fxc",
                    "e3_2a_backgroundc",
                    "e3_2a_sd",
                    "e3_2a_artclass_grc",
                    "e3_2a_artclass_ld",
                    "e3_2a_corridor_grc",
                    "e3_2a_corridor_ld",
                    "e3_2a_prinoffice_grc",
                    "e3_2a_prinoffice_ld",
                    "e3_2a_sciclass_grc",
                    "e3_2a_sciclass_ld",
                },
                VisibleLevels = new List<string>
                {
                    "e3_2a_amb",
                    "e3_2a_fx",
                    "e3_2a_fxc",
                    "e3_2a_backgroundc",
                    "e3_2a_sd",
                    "e3_2a_artclass_grc",
                    "e3_2a_artclass_ld",
                    "e3_2a_corridor_grc",
                    "e3_2a_corridor_ld",
                    "e3_2a_prinoffice_grc",
                    "e3_2a_prinoffice_ld",
                    "e3_2a_sciclass_grc",
                    "e3_2a_sciclass_ld",
                },
            },

            #endregion

            #region E3_3A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_3A_CP02_PoolOn",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_3A_CP03_GuardEnters",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_3A_CP03_GuardEnters",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_3A_CP02_PoolOn",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_3A_CP01_Insertion",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "Interactions_PolaroidBasic",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },

            #endregion

            #region E3_3B
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_3B_CP01_Insertion",
            },

            #endregion

            #region E3_3C
            #endregion

            #region E3_5A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_5A_CP02_Dressed",
                DebugFactToActivate = new List<DebugFact>
                {
                    new DebugFact
                    {
                        Name = "E2_4B_ArtClass_CHNathan_Speak01_Triggered",
                        Level = EWhatIfFactLevel.EWIFL_Episode
                    },
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_5A_CP01_Insertion",
            },

            #endregion

            #region E3_5B
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_5B_CP01_Insertion",
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_5B_CP02_Cooking",
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_5B_CP03_GarageEnter",
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_5B_CP04_GarageLeave",
            },

            #endregion

            #region E3_6A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_6A_CP01_Insertion",
            },

            #endregion

            #region E3_6B
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_6B_CP02_AfterKeys",
                VisibleLevels = new List<string>
                {
                    "e3_6b_diner_ld",
                    "e3_6b_dinerpark_ld",
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_6B_CP03_InsideRV",
                VisibleLevels = new List<string>
                {
                    "e3_6b_insiderv_ld",
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_6B_CP01_Insertion",
                VisibleLevels = new List<string>
                {
                    "e3_6b_diner_ld",
                    "e3_6b_dinerpark_ld",
                },
            },

            #endregion

            #region E3_7A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_7A_CP01_Insertion",
                LevelsOverride = new List<string>
                {
                    "e3_7a_amb",
                    "e3_7a_fx",
                    "e3_7a_fxc",
                    "e3_7a_backgroundc",
                    "e3_7a_sd",
                    "e3_7a_campusa_grc",
                    "e3_7a_campusa_gr2",
                    "e3_7a_campusa_ld",
                },
                VisibleLevels = new List<string>
                {
                    "e3_7a_campusa_grc",
                    "e3_7a_campusa_gr2",
                    "e3_7a_campusa_ld",
                },
            },

            #endregion

            #region E3_7B
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_7B_CP01_Insertion",
                VisibleLevels = new List<string>
                {
                    "e3_7b_maxroom_grc",
                    "e3_7b_maxroom_ld",
                },
            },

            #endregion

            #region E3_7D
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_7D_CP01_Insertion",
                VisibleLevels = new List<string>
                {
                    "e3_7d_campusa_grc",
                    "e3_7d_campusa_gr2",
                    "e3_7d_campusa_ld",
                },
            },

            #endregion

            #region E3_8A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E3_8A_CP01_Insertion",
                VisibleLevels = new List<string>
                {
                    "e3_8a_livingroom_grc",
                    "e3_8a_livingroom_gr2",
                    "e3_8a_livingroom_ld",
                },
            },

            #endregion

            #region E4_1A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_1A_CP01_Insertion",
            },

            #endregion

            #region E4_2A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_2A_CP01_Insertion",
            },

            #endregion

            #region E4_2B
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_2B_CP02_FromUpstairs",
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_2B_CP01_Insertion",
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_2B_CP03_GiveMedicine",
            },

            #endregion

            #region E4_2C
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_2C_CP01_Insertion",
            },

            #endregion

            #region E4_2D
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_2D_CP01_Insertion",
            },

            #endregion

            #region E4_3A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_3A_CP01_Insertion",
            },

            #endregion

            #region E4_3B
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_3B_CP01_Insertion",
            },

            #endregion

            #region E4_3C
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_3C_CP01_Insertion",
            },

            #endregion

            #region E4_3E
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_3E_CP01_Insertion",
            },

            #endregion

            #region E4_4A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_4A_CP01_Insertion",
            },

            #endregion

            #region E4_5A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_5A_CP02_InRoom",
                LevelsOverride = new List<string>
                {
                    "e4_5a_amb",
                    "e4_5a_fx",
                    "e4_5a_fxc",
                    "e4_5a_backgroundc",
                    "e4_5a_sd",
                    "e4_5a_corridor_grc",
                    "e4_5a_corridor_ld",
                    "e4_5a_nathanroom_grc",
                    "e4_5a_nathanroom_ld",
                },
                VisibleLevels = new List<string>
                {
                    "e4_5a_amb",
                    "e4_5a_fx",
                    "e4_5a_fxc",
                    "e4_5a_backgroundc",
                    "e4_5a_sd",
                    "e4_5a_corridor_grc",
                    "e4_5a_corridor_ld",
                    "e4_5a_nathanroom_grc",
                    "e4_5a_nathanroom_ld",
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_5A_CP03_ToChloe",
                LevelsOverride = new List<string>
                {
                    "e4_5a_amb",
                    "e4_5a_fx",
                    "e4_5a_fxc",
                    "e4_5a_backgroundc",
                    "e4_5a_sd",
                    "e4_5a_corridor_grc",
                    "e4_5a_corridor_ld",
                    "e4_5a_nathanroom_grc",
                    "e4_5a_nathanroom_ld",
                },
                VisibleLevels = new List<string>
                {
                    "e4_5a_amb",
                    "e4_5a_fx",
                    "e4_5a_fxc",
                    "e4_5a_backgroundc",
                    "e4_5a_sd",
                    "e4_5a_corridor_grc",
                    "e4_5a_corridor_ld",
                    "e4_5a_nathanroom_grc",
                    "e4_5a_nathanroom_ld",
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_5A_CP01_Insertion",
                LevelsOverride = new List<string>
                {
                    "e4_5a_amb",
                    "e4_5a_fx",
                    "e4_5a_fxc",
                    "e4_5a_backgroundc",
                    "e4_5a_sd",
                    "e4_5a_corridor_grc",
                    "e4_5a_corridor_ld",
                    "e4_5a_nathanroom_grc",
                    "e4_5a_nathanroom_ld",
                },
                VisibleLevels = new List<string>
                {
                    "e4_5a_amb",
                    "e4_5a_fx",
                    "e4_5a_fxc",
                    "e4_5a_backgroundc",
                    "e4_5a_sd",
                    "e4_5a_corridor_grc",
                    "e4_5a_corridor_ld",
                    "e4_5a_nathanroom_grc",
                    "e4_5a_nathanroom_ld",
                },
            },

            #endregion

            #region E4_5B
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_5B_CP01_Insertion",
                LevelsOverride = new List<string>
                {
                    "e4_5b_amb",
                    "e4_5b_fx",
                    "e4_5b_fxc",
                    "e4_5b_backgroundc",
                    "e4_5b_sd",
                    "e4_5b_campusb_grc",
                    "e4_5b_campusb_gr2",
                    "e4_5b_campusb_ld",
                },
                VisibleLevels = new List<string>
                {
                    "e4_5b_campusb_grc",
                    "e4_5b_campusb_gr2",
                    "e4_5b_campusb_ld",
                },
            },

            #endregion

            #region E4_5C
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_5C_CP01_Insertion",
                LevelsOverride = new List<string>
                {
                    "e4_5c_amb",
                    "e4_5c_backgroundc",
                    "e4_5c_fx",
                    "e4_5c_fxc",
                    "e4_5c_campusa_gr2",
                    "e4_5c_campusa_grc",
                    "e4_5c_campusa_ld",
                },
                VisibleLevels = new List<string>
                {
                    "e4_5c_amb",
                    "e4_5c_backgroundc",
                    "e4_5c_fx",
                    "e4_5c_fxc",
                    "e4_5c_campusa_gr2",
                    "e4_5c_campusa_grc",
                    "e4_5c_campusa_ld",
                },
            },

            #endregion

            #region E4_6A
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_6A_CP01_Insertion",
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_6A_CP02_InsideFarm",
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_6A_CP03_FindingDarkRoom",
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_6A_CP04_EnterDarkRoom",
            },

            #endregion

            #region E4_7B
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_7B_CP01_Insertion",
            },

            #endregion

            #region E4_8B
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_8B_CP01_Insertion",
                LevelsOverride = new List<string>
                {
                    "e4_8b_amb",
                    "e4_8b_fx",
                    "e4_8b_fxc",
                    "e4_8b_sd",
                    "e4_8b_swimpool_grc",
                    "e4_8b_swimpool_gr2",
                    "e4_8b_swimpool_ld",
                    "e4_8b_cloakroom_ld",
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_8B_CP02_LeaveCloakRoom",
                LevelsOverride = new List<string>
                {
                    "e4_8b_amb",
                    "e4_8b_fx",
                    "e4_8b_fxc",
                    "e4_8b_sd",
                    "e4_8b_swimpool_grc",
                    "e4_8b_swimpool_gr2",
                    "e4_8b_swimpool_ld",
                    "e4_8b_pool_ld",
                    "e4_8b_cloakroom_ld",
                },
                VisibleLevels = new List<string>
                {
                    "e4_8b_amb",
                    "e4_8b_fx",
                    "e4_8b_fxc",
                    "e4_8b_sd",
                    "e4_8b_swimpool_grc",
                    "e4_8b_swimpool_gr2",
                    "e4_8b_swimpool_ld",
                    "e4_8b_cloakroom_ld",
                    "e4_8b_pool_ld",
                },
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_8B_CP03_EnterVIP",
                LevelsOverride = new List<string>
                {
                    "e4_8b_amb",
                    "e4_8b_fx",
                    "e4_8b_fxc",
                    "e4_8b_sd",
                    "e4_8b_swimpool_grc",
                    "e4_8b_swimpool_gr2",
                    "e4_8b_swimpool_ld",
                    "e4_8b_vip_ld",
                    "e4_8b_pool_ld",
                },
                VisibleLevels = new List<string>
                {
                    "e4_8b_amb",
                    "e4_8b_fx",
                    "e4_8b_fxc",
                    "e4_8b_sd",
                    "e4_8b_swimpool_grc",
                    "e4_8b_swimpool_gr2",
                    "e4_8b_swimpool_ld",
                    "e4_8b_vip_ld",
                    "e4_8b_pool_ld",
                },
            },

            #endregion

            #region E4_8C
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_8C_CP02_Extraction",
            },
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_8C_CP01_Insertion",
            },

            #endregion

            #region E4_9B
            new IA_CheckpointSystem
            {
                Operation = ECheckpointSystemOperation.ECSO_UpdateAndSaveCheckpoint,
                CheckPointID = "E4_9B_CP01_Insertion",
                LevelsOverride = new List<string>
                {
                    "e4_9b_junkyard_grc",
                    "e4_9b_junkyard_ld",
                    "e4_9b_amb",
                    "e4_9b_fx",
                    "e4_9b_fxc",
                    "e4_9b_backgroundc",
                    "e4_9b_sd",
                    "e4_9b_junkyard_gr2",
                },
            },

            #endregion


        };
    }
}
