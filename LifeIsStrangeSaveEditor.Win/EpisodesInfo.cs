using System.Collections.Generic;

namespace LifeIsStrangeSaveEditor.Win
{
    public class EpisodesInfo
    {
        // Source: GP_Episode_E1_SF.upk - GP_Episode_E5_SF.upk (EpisodeDefinition class)
        public static List<EpisodeDescription> Episodes = new List<EpisodeDescription>
        {
            #region Episode 1
            new EpisodeDescription
            {
                EpisodeName = new NameProperty {Name = "Episode1"},
                EpisodeTitle = "$GT_Menus_Journal_Episode1",
                SubEpisodes = new List<SubEpisodeDescription>
                {
                    #region Sub Episode 1
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "E1_1A"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode1Sub1",
                        InsertionCheckPointId = "E1_1A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 2
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "E1_2A"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode1Sub2",
                        InsertionCheckPointId = "E1_2A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                            new NameProperty {Name = "E1_1A"},
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                            new NameProperty {Name = "e1_2a_toilets_ld"},
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 3
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "E1_3A"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode1Sub3",
                        InsertionCheckPointId = "E1_3A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_2A_DenounceNathan"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_2A_ProtectNathan"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                            new NameProperty {Name = "E1_2A"},
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                            new NameProperty {Name = "e1_3a_campusa_ld3"},
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 4
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "E1_3B"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode1Sub4",
                        InsertionCheckPointId = "E1_3B_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3A_MIN_Petition"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3A_MIN_Petition"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3A_MIN_DanielDraw"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3A_MIN_DanielDraw"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                            new NameProperty {Name = "E1_3A"},
                            new NameProperty {Name = "NOTIFY_Tuto06"},
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                            new NameProperty {Name = "E1_3B_CampusB_Squirrel_Collectible"},
                        },
                    },

                    #endregion

                    #region Sub Episode 5
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "E1_3C"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode1Sub5",
                        InsertionCheckPointId = "E1_3C_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3B_Victoria_Picture"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3B_Victoria_No_Picture"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 6
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "E1_3B"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode1Sub6",
                        TexturePath = "E1_3B2",
                        InsertionCheckPointId = "E1_3B_CP03_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3C_MIN_VicPhoto"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3C_MIN_VicPhoto"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3C_MIN_Pregnancy"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3C_MIN_Pregnancy"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3C_MIN_Pregnancy_DIAL"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3C_MIN_Pregnancy_DIAL"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3C_MIN_Pregnancy_TAKEN"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3C_MIN_Pregnancy_TAKEN"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3C_MIN_WateredPlant"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3C_MIN_WateredPlant"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3C_MIN_KateSlate"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3C_MIN_KateSlate"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                            new NameProperty {Name = "E1_3C_Puzzle_Resolved"},
                            new NameProperty {Name = "E1_3C"},
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                            new NameProperty {Name = "E1_3A"},
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                            new NameProperty {Name = "E1_3C_DanaRoom_USBKey"},
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                            new NameProperty {Name = "E1_3B_CampusB_BrokenWindow_Collectible"},
                        },
                    },

                    #endregion

                    #region Sub Episode 7
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "E1_3D"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode1Sub7",
                        InsertionCheckPointId = "E1_3D_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3B_DavidKate_No_Picture"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3B_DavidKate_Picture"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3B_MIN_SaveAlyssa"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3B_MIN_SaveAlyssa"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                            new NameProperty {Name = "E1_3A"},
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 8
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "E1_4A"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode1Sub8",
                        InsertionCheckPointId = "E1_4A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3D_MIN_DirtyRV"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_3D_MIN_DirtyRV"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                            new NameProperty {Name = "E1_3D"},
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                            new NameProperty {Name = "e1_4a_chousefront_grc"},
                            new NameProperty {Name = "e1_4a_chousefront_ld"},
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 9
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "E1_5A"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode1Sub9",
                        InsertionCheckPointId = "E1_5A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 10
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "E1_5B"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode1Sub10",
                        InsertionCheckPointId = "E1_5B_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_5A_MIN_SaveBird"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_5A_MIN_SaveBird"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                            new NameProperty {Name = "E1_5A_ChloeRoom_LD_SearchingTools"},
                            new NameProperty {Name = "E1_5A_ChloeRoom_LD_Folk_CD_Acquired"},
                            new NameProperty {Name = "E1_5A_ChloeRoom_LD_CDwasPlayed"},
                            new NameProperty {Name = "E1_5A_reveal"},
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 11
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "E1_5A"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode1Sub11",
                        TexturePath = "E1_5A2",
                        InsertionCheckPointId = "E1_5A_CP02_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_5B_Garage_File"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_5B_Garage_File"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_5B_MIN_Files"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_5B_MIN_Files"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_5B_MIN_ReadFiles"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_5B_MIN_ReadFiles"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_5B_MIN_Files_INTERACT"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_5B_MIN_Files_INTERACT"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_5B_MIN_LookTV"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_5B_MIN_LookTV"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                            new NameProperty {Name = "E1_5A_ChloeRoom_LD_SearchingTools"},
                            new NameProperty {Name = "E1_5B_Garage_LD_Tools"},
                            new NameProperty {Name = "E1_5A_ChloeRoom_LD_Folk_CD_Acquired"},
                            new NameProperty {Name = "E1_5A_ChloeRoom_LD_CDwasPlayed"},
                            new NameProperty {Name = "E1_5A_reveal"},
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 12
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "E1_6A"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode1Sub12",
                        InsertionCheckPointId = "E1_6A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_5A_Intervene"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_5A_StayHidden"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_5A_TaketheBlame"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E1_5A_BlameChloe"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 13
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "E1_6B"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode1Sub13",
                        InsertionCheckPointId = "E1_6B_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                },
                MajorChoices = new List<EpisodeChoiceEntry>
                {
                    #region Major Choice 1
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E1.TX_MajorChoice_Nathan'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DenounceNathan"},
                                Description = "$GT_Menus_MajChoice_E1_2A_0",
                                Fact = new NameProperty {Name = "E1_2A_DenounceNathan"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "ProtectNathan"},
                                Description = "$GT_Menus_MajChoice_E1_2A_1",
                                Fact = new NameProperty {Name = "E1_2A_ProtectNathan"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                    #region Major Choice 2
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E1.TX_MajorChoice_Victoria'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "VictoriaPicture"},
                                Description = "$GT_Menus_MajChoice_E1_3B_0",
                                Fact = new NameProperty {Name = "E1_3B_Victoria_Picture"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "VictoriaNoPicture"},
                                Description = "$GT_Menus_MajChoice_E1_3B_1",
                                Fact = new NameProperty {Name = "E1_3B_Victoria_No_Picture"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                    #region Major Choice 3
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E1.TX_MajorChoice_Kate'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DavidKatePicture"},
                                Description = "$GT_Menus_MajChoice_E1_3B_2",
                                Fact = new NameProperty {Name = "E1_3B_DavidKate_Picture"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DavidKateIntervene"},
                                Description = "$GT_Menus_MajChoice_E1_3B_3",
                                Fact = new NameProperty {Name = "E1_3B_DavidKate_No_Picture"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                    #region Major Choice 4
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E1.TX_MajorChoice_David'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "OutofClosetTakeBlame"},
                                Description = "$GT_Menus_MajChoice_E1_5A_0",
                                Fact = new NameProperty {Name = "E1_5A_TaketheBlame"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "OutOfClosetBlameChloe"},
                                Description = "$GT_Menus_MajChoice_E1_5A_1",
                                Fact = new NameProperty {Name = "E1_5A_BlameChloe"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "InClosetStayHidden"},
                                Description = "$GT_Menus_MajChoice_E1_5A_2",
                                Fact = new NameProperty {Name = "E1_5A_StayHidden"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "InClosetIntervene"},
                                Description = "$GT_Menus_MajChoice_E1_5A_3",
                                Fact = new NameProperty {Name = "E1_5A_Intervene"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                },
                MinorChoices = new List<EpisodeChoiceEntry>
                {
                    #region Minor Choice 1
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E1.TX_Min_Daniel'",
                        ActivationFact = new NameProperty {Name = "E1_3A_MIN_DanielDraw_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DanielDrawsMax"},
                                Description = "$GT_Menus_MinChoice_E1_3A_0",
                                Fact = new NameProperty {Name = "E1_3A_MIN_DanielDraw"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DanielDoesntDrawMax"},
                                Description = "$GT_Menus_MinChoice_E1_3A_1",
                                Fact = new NameProperty {Name = "E1_3A_MIN_DanielDraw"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 2
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E1.TX_Min_Grant'",
                        ActivationFact = new NameProperty {Name = "E1_3A_MIN_Petition_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "MaxSignsPetition"},
                                Description = "$GT_Menus_MinChoice_E1_3A_2",
                                Fact = new NameProperty {Name = "E1_3A_MIN_Petition"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "MaxDoesntSignPetition"},
                                Description = "$GT_Menus_MinChoice_E1_3A_3",
                                Fact = new NameProperty {Name = "E1_3A_MIN_Petition"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 3
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E1.TX_Min_Alyssa'",
                        ActivationFact = new NameProperty {Name = "E1_3B_MIN_SaveAlyssa_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "SaveAlyssa"},
                                Description = "$GT_Menus_MinChoice_E1_3B_0",
                                Fact = new NameProperty {Name = "E1_3B_MIN_SaveAlyssa"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DontSaveAlyssa"},
                                Description = "$GT_Menus_MinChoice_E1_3B_1",
                                Fact = new NameProperty {Name = "E1_3B_MIN_SaveAlyssa"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 4
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E1.TX_Min_Slate'",
                        ActivationFact = new NameProperty {Name = "E1_3C_MIN_KateSlate_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DrawSlate"},
                                Description = "$GT_Menus_MinChoice_E1_3C_0",
                                Fact = new NameProperty {Name = "E1_3C_MIN_KateSlate"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DidntDrawSlate"},
                                Description = "$GT_Menus_MinChoice_E1_3C_1",
                                Fact = new NameProperty {Name = "E1_3C_MIN_KateSlate"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 5
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E1.TX_Min_Lisa'",
                        ActivationFact = new NameProperty {Name = "E1_3C_MIN_WateredPlant_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "PlantWatered"},
                                Description = "$GT_Menus_MinChoice_E1_3C_2",
                                Fact = new NameProperty {Name = "E1_3C_MIN_WateredPlant"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "PlantDontWatered"},
                                Description = "$GT_Menus_MinChoice_E1_3C_3",
                                Fact = new NameProperty {Name = "E1_3C_MIN_WateredPlant"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 6
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E1.TX_Min_Pregnancy'",
                        ActivationFact = new NameProperty {Name = "E1_3C_MIN_Pregnancy_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "PregnancyTouched"},
                                Description = "$GT_Menus_MinChoice_E1_3C_4",
                                Fact = new NameProperty {Name = "E1_3C_MIN_Pregnancy"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "PregnancyNotTouched"},
                                Description = "$GT_Menus_MinChoice_E1_3C_5",
                                Fact = new NameProperty {Name = "E1_3C_MIN_Pregnancy"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 7
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E1.TX_Min_Victoria'",
                        ActivationFact = new NameProperty {Name = "E1_3C_MIN_VicPhoto_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "VicPhotosTouched"},
                                Description = "$GT_Menus_MinChoice_E1_3C_6",
                                Fact = new NameProperty {Name = "E1_3C_MIN_VicPhoto"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "VicPhotosNotTouched"},
                                Description = "$GT_Menus_MinChoice_E1_3C_7",
                                Fact = new NameProperty {Name = "E1_3C_MIN_VicPhoto"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 8
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E1.TX_Min_Dirty'",
                        ActivationFact = new NameProperty {Name = "E1_3D_MIN_DirtyRV_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "MaxWriteOnRV"},
                                Description = "$GT_Menus_MinChoice_E1_3D_0",
                                Fact = new NameProperty {Name = "E1_3D_MIN_DirtyRV"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "MaxDoesntWriteOnRV"},
                                Description = "$GT_Menus_MinChoice_E1_3D_1",
                                Fact = new NameProperty {Name = "E1_3D_MIN_DirtyRV"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 9
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E1.TX_Min_Bird'",
                        ActivationFact = new NameProperty {Name = "E1_5A_MIN_SaveBird_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "BirdSaved"},
                                Description = "$GT_Menus_MinChoice_E1_5A_0",
                                Fact = new NameProperty {Name = "E1_5A_MIN_SaveBird"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "BirdDead"},
                                Description = "$GT_Menus_MinChoice_E1_5A_1",
                                Fact = new NameProperty {Name = "E1_5A_MIN_SaveBird"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 10
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E1.TX_Min_snowglob'",
                        ActivationFact = new NameProperty {Name = "E1_5A_MIN_SnowGlobe_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "SnowGlobe"},
                                Description = "$GT_Menus_MinChoice_E1_5A_2",
                                Fact = new NameProperty {Name = "E1_5A_MIN_SnowGlobe"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DontSnowGlobe"},
                                Description = "$GT_Menus_MinChoice_E1_5A_3",
                                Fact = new NameProperty {Name = "E1_5A_MIN_SnowGlobe"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 11
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E1.TX_Min_TV'",
                        ActivationFact = new NameProperty {Name = "E1_5B_MIN_Files_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "Files"},
                                Description = "$GT_Menus_MinChoice_E1_5B_0",
                                Fact = new NameProperty {Name = "E1_5B_MIN_Files"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DontFiles"},
                                Description = "$GT_Menus_MinChoice_E1_5B_1",
                                Fact = new NameProperty {Name = "E1_5B_MIN_Files"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 12
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E1.TX_Min_Files'",
                        ActivationFact = new NameProperty {Name = "E1_5B_MIN_ReadFiles_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "ReadFiles"},
                                Description = "$GT_Menus_MinChoice_E1_5B_2",
                                Fact = new NameProperty {Name = "E1_5B_MIN_ReadFiles"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DontReadFiles"},
                                Description = "$GT_Menus_MinChoice_E1_5B_3",
                                Fact = new NameProperty {Name = "E1_5B_MIN_ReadFiles"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                },
                NextEpisodeTeaserImages = new List<string>
                {
                    "TX_Teaser_E1.Teaser1",
                },
            },

            #endregion

            #region Episode 2
            new EpisodeDescription
            {
                EpisodeName = new NameProperty {Name = "Episode2"},
                EpisodeTitle = "$GT_Menus_Journal_Episode2",
                SubEpisodes = new List<SubEpisodeDescription>
                {
                    #region Sub Episode 1
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e2_1a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode2Sub1",
                        InsertionCheckPointId = "E2_1A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 2
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e2_1b"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode2Sub2",
                        InsertionCheckPointId = "E2_1B_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_1A_MIN_WateredPlant"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_1A_MIN_WateredPlant"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_1A_MIN_SaveAlyssa"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_1A_MIN_SaveAlyssa"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_1A_MIN_EraseKateLink"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_1A_MIN_EraseKateLink"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_1A_Believe_Kate"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_1A_Dont_Believe_Kate"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_1A_SistersPhoto"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_1A_SistersPhoto"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_1A_FatherLetter"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_1A_FatherLetter"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 3
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e2_1c"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode2Sub3",
                        InsertionCheckPointId = "E2_1C_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_1B_MIN_TaylorMom"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_1B_MIN_TaylorMom"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_1B_MIN_WarrenApe"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_1B_MIN_WarrenApe"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 4
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e2_1d"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode2Sub4",
                        InsertionCheckPointId = "E2_1D_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 5
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e2_2a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode2Sub5",
                        InsertionCheckPointId = "E2_2A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 6
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e2_3a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode2Sub6",
                        InsertionCheckPointId = "E2_3A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_2A_Answer_Phone_Kate"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_2A_Dont_Answer_Phone_Kate"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 7
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e2_3b"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode2Sub7",
                        InsertionCheckPointId = "E2_3B_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_3A_ShootFrank"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_3A_NoShootFrank"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_3A_MIN_RachelWasHere"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_3A_MIN_RachelWasHere"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 8
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e2_4a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode2Sub8",
                        InsertionCheckPointId = "E2_4A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_3B_MIN_TamperedRails"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_3B_MIN_TamperedRails"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 9
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e2_4b"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode2Sub9",
                        InsertionCheckPointId = "E2_4B_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 10
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e2_4c"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode2Sub10",
                        InsertionCheckPointId = "E2_4C_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_4B_MIN_FreeParty"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_4B_MIN_FreeParty"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_4B_MIN_WarrenChemistry"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_4B_MIN_WarrenChemistry"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_4B_MIN_JeffBlameDavid"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_4B_MIN_JeffBlameDavid"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 11
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e2_5a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode2Sub11",
                        InsertionCheckPointId = "E2_5A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_4C_KateIsAlive"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_4C_KateIsDead"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 12
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e2_6a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode2Sub12",
                        InsertionCheckPointId = "E2_6A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_5A_BlameDavid"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_5A_BlameNathan"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E2_5A_BlameJefferson"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                },
                MajorChoices = new List<EpisodeChoiceEntry>
                {
                    #region Major Choice 1
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E2.TX_MajChoice_E2_1A_Kate'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "TellKatePolice"},
                                Description = "$GT_Menus_MajChoice_E2_1A_0",
                                Fact = new NameProperty {Name = "E2_1A_Believe_Kate"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "TellKateProof"},
                                Description = "$GT_Menus_MajChoice_E2_1A_1",
                                Fact = new NameProperty {Name = "E2_1A_Dont_Believe_Kate"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                    #region Major Choice 2
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E2.TX_MajChoice_E2_2A_Phone'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "AnswerKate"},
                                Description = "$GT_Menus_MajChoice_E2_2A_0",
                                Fact = new NameProperty {Name = "E2_2A_Answer_Phone_Kate"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DontAnswerKate"},
                                Description = "$GT_Menus_MajChoice_E2_2A_1",
                                Fact = new NameProperty {Name = "E2_2A_Dont_Answer_Phone_Kate"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                    #region Major Choice 3
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E2.TX_MajChoice_E2_3A_Gun'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "ShootFrank"},
                                Description = "$GT_Menus_MajChoice_E2_3A_0",
                                Fact = new NameProperty {Name = "E2_3A_ShootFrank"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DontShootFrank"},
                                Description = "$GT_Menus_MajChoice_E2_3A_1",
                                Fact = new NameProperty {Name = "E2_3A_NoShootFrank"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                    #region Major Choice 4
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E2.TX_MajChoice_E2_4C_Kate'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "KateDead"},
                                Description = "$GT_Menus_MajChoice_E2_4C_0",
                                Fact = new NameProperty {Name = "E2_4C_KateIsDead"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "KateAlive"},
                                Description = "$GT_Menus_MajChoice_E2_4C_1",
                                Fact = new NameProperty {Name = "E2_4C_KateIsAlive"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                    #region Major Choice 5
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E2.TX_MajChoice_E2_5A_Denounce'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "BlameDavid"},
                                Description = "$GT_Menus_MajChoice_E2_5A_0",
                                Fact = new NameProperty {Name = "E2_5A_BlameDavid"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "BlameNathan"},
                                Description = "$GT_Menus_MajChoice_E2_5A_1",
                                Fact = new NameProperty {Name = "E2_5A_BlameNathan"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "BlameJefferson"},
                                Description = "$GT_Menus_MajChoice_E2_5A_2",
                                Fact = new NameProperty {Name = "E2_5A_BlameJefferson"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                },
                MinorChoices = new List<EpisodeChoiceEntry>
                {
                    #region Minor Choice 1
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E2.TX_MinChoice_E2_1A_Plant'",
                        ActivationFact = new NameProperty {Name = "E2_1A_MIN_WateredPlant_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "PlantWatered_EP02"},
                                Description = "$GT_Menus_MinChoice_E2_1A_0",
                                Fact = new NameProperty {Name = "E2_1A_MIN_WateredPlant"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "PlantNotWatered"},
                                Description = "$GT_Menus_MinChoice_E2_1A_1",
                                Fact = new NameProperty {Name = "E2_1A_MIN_WateredPlant"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 2
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E2.TX_MinChoice_E2_1A_Alyssa'",
                        ActivationFact = new NameProperty {Name = "E2_1A_MIN_SaveAlyssa_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "AlyssaSaved"},
                                Description = "$GT_Menus_MinChoice_E2_1A_2",
                                Fact = new NameProperty {Name = "E2_1A_MIN_SaveAlyssa"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "AlyssaHurt"},
                                Description = "$GT_Menus_MinChoice_E2_1A_3",
                                Fact = new NameProperty {Name = "E2_1A_MIN_SaveAlyssa"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 3
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E2.TX_MinChoice_E2_1A_KateLink'",
                        ActivationFact = new NameProperty {Name = "E2_1A_MIN_EraseKateLink_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "MaxEraseLink"},
                                Description = "$GT_Menus_MinChoice_E2_1A_4",
                                Fact = new NameProperty {Name = "E2_1A_MIN_EraseKateLink"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "MaxDidntEraseLink"},
                                Description = "$GT_Menus_MinChoice_E2_1A_5",
                                Fact = new NameProperty {Name = "E2_1A_MIN_EraseKateLink"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 4
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E2.TX_MinChoice_E2_1B_Taylor'",
                        ActivationFact = new NameProperty {Name = "E2_1B_MIN_TaylorMom_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "FriendlyWithTaylor"},
                                Description = "$GT_Menus_MinChoice_E2_1B_2",
                                Fact = new NameProperty {Name = "E2_1B_MIN_TaylorMom"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "NotFriendlyWithTaylor"},
                                Description = "$GT_Menus_MinChoice_E2_1B_3",
                                Fact = new NameProperty {Name = "E2_1B_MIN_TaylorMom"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 5
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E2.TX_MinChoice_E2_1B_WarrenApe'",
                        ActivationFact = new NameProperty {Name = "E2_1B_MIN_WarrenApe_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "AcceptedWarrenInvitation"},
                                Description = "$GT_Menus_MinChoice_E2_1B_0",
                                Fact = new NameProperty {Name = "E2_1B_MIN_WarrenApe"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "RejectedWarrenInvitation"},
                                Description = "$GT_Menus_MinChoice_E2_1B_1",
                                Fact = new NameProperty {Name = "E2_1B_MIN_WarrenApe"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 6
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E2.TX_MinChoice_E2_3A_WasHere'",
                        ActivationFact = new NameProperty {Name = "E2_3A_MIN_RachelWasHere_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "RachelWasHereWritten"},
                                Description = "$GT_Menus_MinChoice_E2_3A_0",
                                Fact = new NameProperty {Name = "E2_3A_MIN_RachelWasHere"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "RachelWasHereNotWritten"},
                                Description = "$GT_Menus_MinChoice_E2_3A_1",
                                Fact = new NameProperty {Name = "E2_3A_MIN_RachelWasHere"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 7
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E2.TX_MinChoice_E2_3B_Tampered'",
                        ActivationFact = new NameProperty {Name = "E2_3B_MIN_TamperedRails_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "TamperedRails"},
                                Description = "$GT_Menus_MinChoice_E2_3B_0",
                                Fact = new NameProperty {Name = "E2_3B_MIN_TamperedRails"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DidntTamperedRails"},
                                Description = "$GT_Menus_MinChoice_E2_3B_1",
                                Fact = new NameProperty {Name = "E2_3B_MIN_TamperedRails"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 8
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E2.TX_MinChoice_E2_4B_Courtney'",
                        ActivationFact = new NameProperty {Name = "E2_4B_MIN_FreeParty_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "FreePartyInvitation"},
                                Description = "$GT_Menus_MinChoice_E2_4B_4",
                                Fact = new NameProperty {Name = "E2_4B_MIN_FreeParty"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "FreePartyNoInvitation"},
                                Description = "$GT_Menus_MinChoice_E2_4B_5",
                                Fact = new NameProperty {Name = "E2_4B_MIN_FreeParty"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 9
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E2.TX_MinChoice_E2_4B_Warren'",
                        ActivationFact = new NameProperty {Name = "E2_4B_MIN_WarrenChemistry_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "HelpedWarrenChemistry"},
                                Description = "$GT_Menus_MinChoice_E2_4B_0",
                                Fact = new NameProperty {Name = "E2_4B_MIN_WarrenChemistry"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DidntHelpedWarrenChemistry"},
                                Description = "$GT_Menus_MinChoice_E2_4B_1",
                                Fact = new NameProperty {Name = "E2_4B_MIN_WarrenChemistry"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 10
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E2.TX_MinChoice_E2_4B_Jefferson'",
                        ActivationFact = new NameProperty {Name = "E2_4B_MIN_JeffBlameDavid_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "TellOnDavidToJefferson"},
                                Description = "$GT_Menus_MinChoice_E2_4B_2",
                                Fact = new NameProperty {Name = "E2_4B_MIN_JeffBlameDavid"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DontTellOnDavidToJefferson"},
                                Description = "$GT_Menus_MinChoice_E2_4B_3",
                                Fact = new NameProperty {Name = "E2_4B_MIN_JeffBlameDavid"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                },
                NextEpisodeTeaserImages = new List<string>
                {
                    "TX_Teaser_E2.Teaser1",
                },
            },

            #endregion

            #region Episode 3
            new EpisodeDescription
            {
                EpisodeName = new NameProperty {Name = "Episode3"},
                EpisodeTitle = "$GT_Menus_Journal_Episode3",
                SubEpisodes = new List<SubEpisodeDescription>
                {
                    #region Sub Episode 1
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e3_1a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode3Sub1",
                        TexturePath = "Texture2D'TX_SubContextPreview_E3.E3_1A-Dormitories'",
                        InsertionCheckPointId = "E3_1A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 2
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e3_1b"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode3Sub2",
                        TexturePath = "Texture2D'TX_SubContextPreview_E3.E3_1B-CampusB'",
                        InsertionCheckPointId = "E3_1B_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 3
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e3_1c"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode3Sub3",
                        TexturePath = "Texture2D'TX_SubContextPreview_E3.E3_1C-CampusA'",
                        InsertionCheckPointId = "E3_1C_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 4
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e3_2a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode3Sub4",
                        TexturePath = "Texture2D'TX_SubContextPreview_E3.E3_2A-HighSchool'",
                        InsertionCheckPointId = "E3_2A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 5
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e3_3a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode3Sub5",
                        TexturePath = "Texture2D'TX_SubContextPreview_E3.E3_3A-SwimmingPool'",
                        InsertionCheckPointId = "E3_3A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_2A_Take_Money"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_2A_Dont_Take_Money"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_2A_MIN_WarrenExam"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_2A_MIN_WarrenExam"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 6
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e3_3b"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode3Sub6",
                        TexturePath = "Texture2D'TX_SubContextPreview_E3.E3_3B-Parking'",
                        InsertionCheckPointId = "E3_3B_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_3A_MIN_AddVortex"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_3A_MIN_AddVortex"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_3A_MIN_EraseVortex"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_3A_MIN_EraseVortex"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 7
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e3_5a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode3Sub8",
                        TexturePath = "Texture2D'TX_SubContextPreview_E3.E3_5A-ChloeHouseUp'",
                        InsertionCheckPointId = "E3_5A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 8
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e3_5b"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode3Sub9",
                        TexturePath = "Texture2D'TX_SubContextPreview_E3.E3_5B-ChloeHouseDown'",
                        InsertionCheckPointId = "E3_5B_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_5A_KissChloe"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_5A_DontKissChloe"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 9
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e3_6b"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode3Sub10",
                        TexturePath = "Texture2D'TX_SubContextPreview_E3.E3_6B-Diner'",
                        InsertionCheckPointId = "E3_6B_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_5B_SupportDavid"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_5B_BlameDavid"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_5B_MIN_AnswerMachine"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_5B_MIN_AnswerMachine"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 10
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e3_6a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode3Sub11",
                        TexturePath = "Texture2D'TX_SubContextPreview_E3.E3_6A-ChloeTruck'",
                        InsertionCheckPointId = "E3_6A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_6B_HarmDog"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_6B_NoHarmDog"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_6B_MaxGiveGun"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_6B_MaxHideGun"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_6B_MIN_WarnAlyssa"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_6B_MIN_WarnAlyssa"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_6B_MIN_WarnedHomeless"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_6B_MIN_WarnedHomeless"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 11
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e3_7a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode3Sub12",
                        TexturePath = "Texture2D'TX_SubContextPreview_E3.E3_7A-MainCampusANoon'",
                        InsertionCheckPointId = "E3_7A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 12
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e3_7b"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode3Sub13",
                        TexturePath = "Texture2D'TX_SubContextPreview_E3.E3_7B-MaxRoom'",
                        InsertionCheckPointId = "E3_7B_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 13
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e3_8a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode3Sub14",
                        TexturePath = "Texture2D'TX_SubContextPreview_E3.E3_8A-ChloeHouseFocus'",
                        InsertionCheckPointId = "E3_8A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 14
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e3_7d"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode3Sub15",
                        TexturePath = "Texture2D'TX_SubContextPreview_E3.E3_7D-AlternativeMainCampusA'",
                        InsertionCheckPointId = "E3_7D_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_8A_MIN_PictureCollectible"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_8A_MIN_PictureCollectible"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_8A_MIN_Message"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E3_8A_MIN_Message"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                },
                MajorChoices = new List<EpisodeChoiceEntry>
                {
                    #region Major Choice 1
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E3.TX_MajChoice_E3_2A_Money'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "TakeMoney"},
                                Description = "$GT_Menus_MajChoice_E3_2A_0",
                                Fact = new NameProperty {Name = "E3_2A_Take_Money"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "LeaveMoney"},
                                Description = "$GT_Menus_MajChoice_E3_2A_1",
                                Fact = new NameProperty {Name = "E3_2A_Dont_Take_Money"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                    #region Major Choice 2
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E3.TX_MajChoice_E3_5A_KissChloe'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "KissChloe"},
                                Description = "$GT_Menus_MajChoice_E3_5A_0",
                                Fact = new NameProperty {Name = "E3_5A_KissChloe"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DontKissChloe"},
                                Description = "$GT_Menus_MajChoice_E3_5A_1",
                                Fact = new NameProperty {Name = "E3_5A_DontKissChloe"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                    #region Major Choice 3
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E3.TX_MajChoice_E3_5B_BlameDavid'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "SupportDavid"},
                                Description = "$GT_Menus_MajChoice_E3_5B_0",
                                Fact = new NameProperty {Name = "E3_5B_SupportDavid"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "BlameDavid"},
                                Description = "$GT_Menus_MajChoice_E3_5B_1",
                                Fact = new NameProperty {Name = "E3_5B_BlameDavid"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                    #region Major Choice 4
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E3.TX_MajChoice_E3_6B_Dog'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "HarmDog"},
                                Description = "$GT_Menus_MajChoice_E3_6B_0",
                                Fact = new NameProperty {Name = "E3_6B_HarmDog"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "NoHarmDog"},
                                Description = "$GT_Menus_MajChoice_E3_6B_1",
                                Fact = new NameProperty {Name = "E3_6B_NoHarmDog"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                    #region Major Choice 5
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E3.TX_MajChoice_E3_6B_Gun'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "HaveAGun"},
                                Description = "$GT_Menus_MajChoice_E3_6B_2",
                                Fact = new NameProperty {Name = "GUN_HaveAGun"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DontHaveAGun"},
                                Description = "$GT_Menus_MajChoice_E3_6B_3",
                                Fact = new NameProperty {Name = "GUN_DontHaveAGun"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                },
                MinorChoices = new List<EpisodeChoiceEntry>
                {
                    #region Minor Choice 1
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E3.TX_MinChoice_E3_1A_Plant'",
                        ActivationFact = new NameProperty {Name = "E3_1A_MIN_WateredPlant_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "PlantAlive"},
                                Description = "$GT_Menus_MinChoice_E3_1A_0",
                                Fact = new NameProperty {Name = "LISA_PlantIsAlive"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "PlantDead"},
                                Description = "$GT_Menus_MinChoice_E3_1A_1",
                                Fact = new NameProperty {Name = "LISA_PlantIsDead"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 2
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E3.TX_MinChoice_E3_2A_WarrenExam'",
                        ActivationFact = new NameProperty {Name = "E3_2A_MIN_WarrenExam_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "WarrenExamHelped"},
                                Description = "$GT_Menus_MinChoice_E3_2A_0",
                                Fact = new NameProperty {Name = "E3_2A_MIN_WarrenExam"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "WarrenExamNoHelp"},
                                Description = "$GT_Menus_MinChoice_E3_2A_1",
                                Fact = new NameProperty {Name = "E3_2A_MIN_WarrenExam"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 3
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E3.TX_MinChoice_E3_3A_AddNames'",
                        ActivationFact = new NameProperty {Name = "E3_3A_MIN_AddVortex_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "AddedNameToVortex"},
                                Description = "$GT_Menus_MinChoice_E3_3A_0",
                                Fact = new NameProperty {Name = "PARTY_MaxHasEntry"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DidntAddNameToVortex"},
                                Description = "$GT_Menus_MinChoice_E3_3A_1",
                                Fact = new NameProperty {Name = "PARTY_MaxNoEntry"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 4
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E3.TX_MinChoice_E3_3A_EraseNames'",
                        ActivationFact = new NameProperty {Name = "E3_3A_MIN_EraseVortex_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "ErasedVortexList"},
                                Description = "$GT_Menus_MinChoice_E3_3A_2",
                                Fact = new NameProperty {Name = "E3_3A_MIN_EraseVortex"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DidntEraseVortexList"},
                                Description = "$GT_Menus_MinChoice_E3_3A_3",
                                Fact = new NameProperty {Name = "E3_3A_MIN_EraseVortex"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 5
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E3.TX_MinChoice_E3_5B_EraseMessage'",
                        ActivationFact = new NameProperty {Name = "E3_5B_MIN_AnswerMachine_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "EraseAnswerMessage"},
                                Description = "$GT_Menus_MinChoice_E3_5B_0",
                                Fact = new NameProperty {Name = "E3_5B_MIN_AnswerMachine"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DidntEraseAnswerMessage"},
                                Description = "$GT_Menus_MinChoice_E3_5B_1",
                                Fact = new NameProperty {Name = "E3_5B_MIN_AnswerMachine"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 6
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E3.TX_MinChoice_E3_6B_WarnAlyssa'",
                        ActivationFact = new NameProperty {Name = "E3_6B_MIN_WarnAlyssa_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "WarnAlyssa_EP03"},
                                Description = "$GT_Menus_MinChoice_E3_6B_0",
                                Fact = new NameProperty {Name = "E3_6B_MIN_WarnAlyssa"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DidntWarnAlyssa_EP03"},
                                Description = "$GT_Menus_MinChoice_E3_6B_1",
                                Fact = new NameProperty {Name = "E3_6B_MIN_WarnAlyssa"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 7
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E3.TX_MinChoice_E3_6B_WarnHomeLess1'",
                        ActivationFact = new NameProperty {Name = "E3_6B_MIN_WarnedHomeless_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "WarnedHomeless"},
                                Description = "$GT_Menus_MinChoice_E3_6B_2",
                                Fact = new NameProperty {Name = "E3_6B_MIN_WarnedHomeless"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DidntWarnedHomeless"},
                                Description = "$GT_Menus_MinChoice_E3_6B_3",
                                Fact = new NameProperty {Name = "E3_6B_MIN_WarnedHomeless"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 8
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E3.TX_MinChoice_E3_8A_TakePhoto'",
                        ActivationFact = new NameProperty {Name = "E3_8A_MIN_PictureCollectible_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "TookPhoto"},
                                Description = "$GT_Menus_MinChoice_E3_8A_2",
                                Fact = new NameProperty {Name = "E3_8A_MIN_PictureCollectible"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DidntTookPhoto"},
                                Description = "$GT_Menus_MinChoice_E3_8A_3",
                                Fact = new NameProperty {Name = "E3_8A_MIN_PictureCollectible"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 9
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E3.TX_MinChoice_E3_8A_WriteNote'",
                        ActivationFact = new NameProperty {Name = "E3_8A_MIN_Message_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "WroteMessageInPast"},
                                Description = "$GT_Menus_MinChoice_E3_8A_0",
                                Fact = new NameProperty {Name = "E3_8A_MIN_Message"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DidntWriteMessageInPast"},
                                Description = "$GT_Menus_MinChoice_E3_8A_1",
                                Fact = new NameProperty {Name = "E3_8A_MIN_Message"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                },
                NextEpisodeTeaserImages = new List<string>
                {
                    "TX_Teaser_E3.Teaser1",
                },
            },

            #endregion

            #region Episode 4
            new EpisodeDescription
            {
                EpisodeName = new NameProperty {Name = "Episode4"},
                EpisodeTitle = "$GT_Menus_Journal_Episode4",
                SubEpisodes = new List<SubEpisodeDescription>
                {
                    #region Sub Episode 1
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_1a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub1",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_1A_Beach'",
                        InsertionCheckPointId = "E4_1A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 2
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_2d"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub2",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_2D_ChloeUpWheel'",
                        InsertionCheckPointId = "E4_2D_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 3
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_2b"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub3",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_2B_ChloeDownWheel'",
                        InsertionCheckPointId = "E4_2B_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 4
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_2a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub4",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_2A_ChloeUpWheel'",
                        InsertionCheckPointId = "E4_2A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 5
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_2b"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub5",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_2B_ChloeDownWheelWithMedicine'",
                        InsertionCheckPointId = "E4_2B_CP02_FromUpstairs",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                            new NameProperty {Name = "E4_2A_Got_Medicine"},
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 6
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_2c"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub6",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_2C_ChloeDownPola'",
                        InsertionCheckPointId = "E4_2C_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_2B_Give_Medicine"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_2B_Dont_Give_Medicine"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 7
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_3a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub7",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_3A_ChloeUp'",
                        InsertionCheckPointId = "E4_3A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 8
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_3b"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub8",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_3B_ChloeDown'",
                        InsertionCheckPointId = "E4_3B_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_3A_MIN_SaveBird"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_3A_MIN_SaveBird"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 9
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_3e"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub9",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_3E_Hospital'",
                        InsertionCheckPointId = "E4_3E_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_3B_MIN_BirdNest"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_3B_MIN_BirdNest"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_3B_MIN_PadlockCode"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_3B_MIN_PadlockCode"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 10
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_5b"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub10",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_5B_CampusB'",
                        InsertionCheckPointId = "E4_5B_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_3E_MIN_KateHint"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_3E_MIN_KateHint"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 11
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_5a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub11",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_5A_Dormitory'",
                        InsertionCheckPointId = "E4_5A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_5B_MIN_DanielVortex"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_5B_MIN_DanielVortex"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 12
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_5c"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub12",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_5C_CampusA'",
                        InsertionCheckPointId = "E4_5C_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_5A_LetNathanGetBeat"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_5A_PreventNathanFromBeat"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_5A_MIN_CuteMsgWarren"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_5A_MIN_CuteMsgWarren"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_5A_MIN_NathanDoor"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_5A_MIN_NathanDoor"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 13
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_4a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub13",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_4A_Beach'",
                        InsertionCheckPointId = "E4_4A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 14
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_3c"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub14",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_3C_ChloeUp'",
                        InsertionCheckPointId = "E4_3C_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_4A_FrankAlive_Friend"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_4A_FrankAlive_Foe"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_4A_FrankDead"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 15
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_6a"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub15",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_6A_DarkRoom'",
                        InsertionCheckPointId = "E4_6A_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_3C_MIN_PINCode"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_3C_MIN_PINCode"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 16
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_7b"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub16",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_7B_Junkyard'",
                        InsertionCheckPointId = "E4_7B_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 17
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_8c"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub17",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_8C_Parking1'",
                        InsertionCheckPointId = "E4_8C_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 18
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_8b"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub18",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_8B_SwimmingPool'",
                        InsertionCheckPointId = "E4_8B_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                            new NameProperty {Name = "e4_8b_pool_ld"},
                            new NameProperty {Name = "e4_8b_mentoilets_ld"},
                            new NameProperty {Name = "e4_8b_vip_ld"},
                            new NameProperty {Name = "e4_8b_swimpool_shootbink"},
                            new NameProperty {Name = "e4_8b_extraction_ld"},
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                    #region Sub Episode 19
                    new SubEpisodeDescription
                    {
                        SubEpisodeName = new NameProperty {Name = "e4_9b"},
                        SubEpisodeTitle = "$GT_Menus_Journal_Episode4Sub19",
                        TexturePath = "Texture2D'TX_SubContextPreview_E4.E4_9B_Junkyard'",
                        InsertionCheckPointId = "E4_9B_CP01_Insertion",
                        FactChoiceList = new List<FactList>
                        {
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_8B_MIN_SaveAlyssa"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_8B_MIN_SaveAlyssa"},
                                        bDeactivateFact = false,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                            new FactList
                            {
                                Choices = new List<FactChoice>
                                {
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_8B_WarnVictoria_Foe"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_8B_WarnVictoria_Friend"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                    new FactChoice
                                    {
                                        FactName = new NameProperty {Name = "E4_8B_DontWarnVictoria"},
                                        bDeactivateFact = true,
                                        DebugFactToActivate = new List<NameProperty>
                                        {
                                        },
                                        DebugFactToDeactivate = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToAdd = new List<NameProperty>
                                        {
                                        },
                                        DebugInventoryObjectToRemove = new List<NameProperty>
                                        {
                                        },
                                    },
                                },
                            },
                        },
                        DebugFactToActivate = new List<NameProperty>
                        {
                        },
                        DebugFactToDeactivate = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToAdd = new List<NameProperty>
                        {
                        },
                        DebugInventoryObjectToRemove = new List<NameProperty>
                        {
                        },
                        LevelsToRemoveAtStartup = new List<NameProperty>
                        {
                        },
                        Collectibles = new List<NameProperty>
                        {
                        },
                    },

                    #endregion

                },
                MajorChoices = new List<EpisodeChoiceEntry>
                {
                    #region Major Choice 1
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E4.TX_MajChoice_E4_2B_KillChloe'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "GiveMedicine"},
                                Description = "$GT_Menus_MajChoice_E4_2B_0",
                                Fact = new NameProperty {Name = "E4_2B_Give_Medicine"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DontGiveMedicine"},
                                Description = "$GT_Menus_MajChoice_E4_2B_1",
                                Fact = new NameProperty {Name = "E4_2B_Dont_Give_Medicine"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                    #region Major Choice 2
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E4.TX_MajChoice_E4_5A_WarrenBeatNathan'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "LetNathanGetBeat"},
                                Description = "$GT_Menus_MajChoice_E4_5A_0",
                                Fact = new NameProperty {Name = "E4_5A_LetNathanGetBeat"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "PreventNathanFromBeat"},
                                Description = "$GT_Menus_MajChoice_E4_5A_1",
                                Fact = new NameProperty {Name = "E4_5A_PreventNathanFromBeat"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                    #region Major Choice 3
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E4.TX_MinChoice_Empty'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                        },
                    },

                    #endregion

                    #region Major Choice 4
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E4.TX_MajChoice_E4_4A_KillFrank'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "FrankDead"},
                                Description = "$GT_Menus_MajChoice_E4_4A_0",
                                Fact = new NameProperty {Name = "E4_4A_FrankDead"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "FrankHurt"},
                                Description = "$GT_Menus_MajChoice_E4_4A_1",
                                Fact = new NameProperty {Name = "E4_4A_FrankAlive_Foe"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "FrankFriend"},
                                Description = "$GT_Menus_MajChoice_E4_4A_2",
                                Fact = new NameProperty {Name = "E4_4A_FrankAlive_Friend"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                    #region Major Choice 5
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MajorChoice_E4.TX_MajChoice_E4_8B_WarnVictoria'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "WarnVictoria_Friend"},
                                Description = "$GT_Menus_MajChoice_E4_8B_0",
                                Fact = new NameProperty {Name = "E4_8B_WarnVictoria_Friend"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "WarnVictoria_Foe"},
                                Description = "$GT_Menus_MajChoice_E4_8B_1",
                                Fact = new NameProperty {Name = "E4_8B_WarnVictoria_Foe"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DontWarnVictoria"},
                                Description = "$GT_Menus_MajChoice_E4_8B_2",
                                Fact = new NameProperty {Name = "E4_8B_DontWarnVictoria"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                },
                MinorChoices = new List<EpisodeChoiceEntry>
                {
                    #region Minor Choice 1
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E4.TX_MinChoice_E4_3A_SaveBird'",
                        ActivationFact = new NameProperty {Name = "E4_3A_MIN_SaveBird_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "SaveBird"},
                                Description = "$GT_Menus_MinChoice_E4_3A_0",
                                Fact = new NameProperty {Name = "E4_3A_MIN_SaveBird"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DontSaveBird"},
                                Description = "$GT_Menus_MinChoice_E4_3A_1",
                                Fact = new NameProperty {Name = "E4_3A_MIN_SaveBird"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 2
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E4.TX_MinChoice_E4_3B_BirdNest'",
                        ActivationFact = new NameProperty {Name = "E4_3B_MIN_BirdNest_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "Didin'tProtectTheNest"},
                                Description = "$GT_Menus_MinChoice_E4_3B_0",
                                Fact = new NameProperty {Name = "E4_3B_MIN_BirdNest"},
                                FactActivated = true,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "ProtectTheNest"},
                                Description = "$GT_Menus_MinChoice_E4_3B_1",
                                Fact = new NameProperty {Name = "E4_3B_MIN_BirdNest"},
                                FactActivated = false,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 3
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E4.TX_MinChoice_E4_3B_Code'",
                        ActivationFact = new NameProperty {Name = "E4_3B_MIN_PadlockCode_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "FoundPadlockCode"},
                                Description = "$GT_Menus_MinChoice_E4_3B_2",
                                Fact = new NameProperty {Name = "E4_3B_MIN_PadlockCode"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "Didn'tFoundPadlockCode"},
                                Description = "$GT_Menus_MinChoice_E4_3B_3",
                                Fact = new NameProperty {Name = "E4_3B_MIN_PadlockCode"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 4
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E4.TX_MinChoice_E4_3E_KateHint'",
                        ActivationFact = new NameProperty {Name = "E4_3E_MIN_KateHint_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "KateGaveHint"},
                                Description = "$GT_Menus_MinChoice_E4_3E_0",
                                Fact = new NameProperty {Name = "E4_3E_MIN_KateHint"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "KateDidntGiveHint"},
                                Description = "$GT_Menus_MinChoice_E4_3E_1",
                                Fact = new NameProperty {Name = "E4_3E_MIN_KateHint"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 5
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E4.TX_MinChoice_Empty'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                        },
                    },

                    #endregion

                    #region Minor Choice 6
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E4.TX_MinChoice_Empty'",
                        ActivationFact = new NameProperty {Name = "None"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                        },
                    },

                    #endregion

                    #region Minor Choice 7
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E4.TX_MinChoice_E4_5B_DanielVortex'",
                        ActivationFact = new NameProperty {Name = "E4_5B_MIN_DanielVortex_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DanielGoVortex"},
                                Description = "$GT_Menus_MinChoice_E4_5B_0",
                                Fact = new NameProperty {Name = "E4_5B_MIN_DanielVortex"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DanielDontGoVortex"},
                                Description = "$GT_Menus_MinChoice_E4_5B_1",
                                Fact = new NameProperty {Name = "E4_5B_MIN_DanielVortex"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 8
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E4.TX_MinChoice_E4_5A_CuteMsgWarren'",
                        ActivationFact = new NameProperty {Name = "E4_5A_MIN_CuteMsgWarren_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "CuteMessageWritten"},
                                Description = "$GT_Menus_MinChoice_E4_5A_0",
                                Fact = new NameProperty {Name = "E4_5A_MIN_CuteMsgWarren"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "CuteMessageNotWritten"},
                                Description = "$GT_Menus_MinChoice_E4_5A_1",
                                Fact = new NameProperty {Name = "E4_5A_MIN_CuteMsgWarren"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 9
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E4.TX_MinChoice_E4_3C_PINCode'",
                        ActivationFact = new NameProperty {Name = "E4_3C_MIN_PINCode_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "FoundPINCode"},
                                Description = "$GT_Menus_MinChoice_E4_3C_0",
                                Fact = new NameProperty {Name = "E4_3C_MIN_PINCode"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DidntFindPINCode"},
                                Description = "$GT_Menus_MinChoice_E4_3C_1",
                                Fact = new NameProperty {Name = "E4_3C_MIN_PINCode"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                    #region Minor Choice 10
                    new EpisodeChoiceEntry
                    {
                        PictureTexture = "Texture2D'TX_MinorChoice_E4.TX_MinChoice_E4_8B_SaveAlyssa'",
                        ActivationFact = new NameProperty {Name = "E4_8B_MIN_SaveAlyssa_START"},
                        ChoiceResults = new List<EpisodeChoiceResult>
                        {
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "HelpedAlyssa"},
                                Description = "$GT_Menus_MinChoice_E4_8B_0",
                                Fact = new NameProperty {Name = "E4_8B_MIN_SaveAlyssa"},
                                FactActivated = false,
                            },
                            new EpisodeChoiceResult
                            {
                                Id = new NameProperty {Name = "DidntHelpAlyssa"},
                                Description = "$GT_Menus_MinChoice_E4_8B_1",
                                Fact = new NameProperty {Name = "E4_8B_MIN_SaveAlyssa"},
                                FactActivated = true,
                            },
                        },
                    },

                    #endregion

                },
                NextEpisodeTeaserImages = new List<string>
                {
                    "Texture2D'TX_Teaser_E4.Fin_episode_4'",
                },
            },

            #endregion


        };
    }
}
