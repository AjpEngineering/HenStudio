#region HEADER
//#####################################################################################################################
//###############################  P r o f i l e W r a p p e r V i e w M o d e l . c s  ###############################
//#####################################################################################################################
//  FILENAME:  ProfileWrapperViewModel.cs
//  NAMESPACE: HenViewModel.Profile
//  CLASS(S):  ProfileWrapperViewModel
//  COMPONENT: HenModel.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the Data class for the Profile Wrapper View Model Object.
//=====================================================================================================================
//  AUTHOR:
//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//                                                                                                                   !!
//                              A        JJJJJJJJ  PPPPPPP         EEEEEEE  NN     NN   GGGGGG                       !!
//                             AAA          JJ     PP    PP        EE       NNN    NN  GG    GG                      !!
//                            AA AA         JJ     PP    PP        EE       NNNN   NN  GG                            !!
//                           AA   AA        JJ     PPPPPP          EEEEEEE  NN NN  NN  GG   GGGG                     !!
//                          AAAAAAAA   JJ   JJ     PP              EE       NN  NN NN  GG    GG                      !!
//                         AA      AA  JJ   JJ     PP              EE       NN    NNN  GG    GG                      !!
//                        AA        AA  JJJJJJ     PP              EEEEEEE  NN     NN   GGGGGG                       !!
//                                                                                                                   !!
//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//    (c)Copyright 2026 AJP Engineering
//    All rights reserved.
//=====================================================================================================================
//  HISTORY:
//    01/01/26 .. AJP Engineering .. Version 1.0
//#####################################################################################################################
//#####################################################################################################################
//#####################################################################################################################
#endregion      // HEADER

#region REFERENCES

#region HEN STUDIO REFERENCES

using HenGlobal;

using HenModel.Connection;

using HenModel.Dto.Profile;
using HenModel.Dto.Profile.Streams;

using HenModel.Dto.Profile;
using HenModel.Dto.Profile.Streams;

using HenViewModel.Profile;
using HenViewModel.Profile.Streams;
#endregion  // HEN STUDIO REFERENCES

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Linq;
#endregion      // REFERENCES

#region namespace HenViewModel.Profile
namespace HenViewModel.Profile
{
    #region public class ProfileWrapperViewModel
    /// <summary>
    /// Profile Wrapper View Model Class
    /// </summary>
    public class ProfileWrapperViewModel : ViewModelBase
    {
        #region CONSTANTS
        const string NAMESPACE = "HenViewModel.Profile";
        const string CLASS = "ProfileWrapperViewModel";
        #endregion  // CONSTANTS

        #region PROPERTIES

        #region PROJECT Database Name
        string ProjectDbName { get; set; } = string.Empty;
        #endregion  // PROJECT Database Name

        #region ProfileWrapperDto OBJECT
        //-----------------------------------------------------------------------------
        //--- ProfileWrapperDto Object contains all the IDs, and DTO Objects, ---
        //--- for the Profile Wrapper Panel. [INTRA-VIEW LAYER]                     ---
        //-----------------------------------------------------------------------------
        //--- Project panel data is passed between Controls and this Wrapper Dto.   ---
        //-----------------------------------------------------------------------------
        ProfileWrapperDto ProfileWrapperDtoObj { get; set; } = new ProfileWrapperDto();
        #endregion  // ProfileWrapperDto OBJECT

        #region SUB-Panel ViewModel OBJECTS
        //----------------------------------------------- Profile Sub-Panel ---
        public ProfileViewModel ProfileViewModelObj { get; set; }

        //------------------------------- Profile Process Streams Sub-Panel ---
        public ProcessStreamViewModel ProcessStreamViewModelObj { get; set; }

        //------------------------------- Profile Utility Streams Sub-Panel ---
        public UtilityStreamViewModel UtilityStreamViewModelObj { get; set; }

        #endregion  // SUB-Panel ViewModel OBJECTS

        #endregion      // PROPERTIES

        #region Parameterized CTOR
        /// <summary>
        /// Parameterized Constructor for ProfileWrapperViewModel Class
        /// </summary>
        /// <param name="strProjectDbNameOnly">Project Db Name... NO ".db" extension</param>
        public ProfileWrapperViewModel(string strProjectDbNameOnly)
        {
            #region PROJECT Database Name
            if (strProjectDbNameOnly == string.Empty) throw new ArgumentNullException(
                           nameof(strProjectDbNameOnly),
                           "Project DB Name can not be empty");

            //---------------------------------------------------
            //--- Add File Extension ".db" to Project Db Name ---
            //---------------------------------------------------
            ProjectDbName = string.Format("{0].db", strProjectDbNameOnly);
            #endregion  // PROJECT Database Name

            #region PROJECT Database Connection
            //-----------------------------------------------------------------------------------------
            //--- Configure PROJECT database connection options
            //-----------------------------------------------------------------------------------------
            SQLiteConnectionOptions options = new SQLiteConnectionOptions
            {
                DbType = DatabaseType.PROJECT,
                DatabasePath = ProjectDbName
            };

            //-----------------------------------------------------------------------------------------
            //--- Create the SQLite connection factory using APPLICATION options
            //-----------------------------------------------------------------------------------------
            SQLiteConnectionFactory connFactoryObj = new SQLiteConnectionFactory(options);
            #endregion  // PROJECT Database Connection

            #region Initialize PROFILE-level ViewModel Objects
            //----------------------------------------------- Profile Sub-Panel ---
            ProfileViewModelObj = new ProfileViewModel(connFactoryObj);

            //------------------------------ Profile Process Streams Sub-Panels ---
            ProcessStreamViewModelObj = new ProcessStreamViewModel(connFactoryObj);

            //------------------------------ Profile Utility Streams Sub-Panels ---
            UtilityStreamViewModelObj = new UtilityStreamViewModel(connFactoryObj);

            #endregion  // Initialize PROFILE-level ViewModel Objects

        }
        #endregion  // Parameterized CTOR

        #region CRUD METHODS

        #region --> CREATE ... CreateProfileWrapperData(ProfileWrapperDto projecteWrapperDtoObj)
        /// <summary>
        /// Add (CREATE) the Profile data contained in the WRAPPER DTO to the SQLite PROJECT DB
        /// using Sub-Panel ViewModel to Sub-Panel Repo interfaces
        /// Returns Profile Id associated with added data
        /// </summary>
        /// <returns>Profile WRAPPER DTO Object including all PK and FK IDs.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ProfileWrapperDto CreateProfileWrapperData(ProfileWrapperDto profileWrapperDtoObj)
        {
            string strMethod = "CreateProfileWrapperData";

            if (profileWrapperDtoObj == null) throw new ArgumentNullException(
                                         nameof(profileWrapperDtoObj),
                                         "Profile Wrapper DTO can not be null");

            if (profileWrapperDtoObj.ProjectDbName == string.Empty) throw new ArgumentNullException(
                                         nameof(profileWrapperDtoObj.ProjectDbName),
                                         "Project DB Name can not be empty");

            if (profileWrapperDtoObj.ProjectId == -1) throw new ArgumentNullException(
                                         nameof(profileWrapperDtoObj.ProjectId),
                                         "Project ID can not be -1");

            //-----------------------------
            //--- Initialize Profile ID ---
            //-----------------------------
            int projectId = -1; // Project ID (FK)
            int profileId = -1; // Profile ViewModel AddProfile() return value [PROFILE PANEL]
            try
            {
                projectId = profileWrapperDtoObj.ProjectId;     // Project ID (FK)
                ProfileWrapperDtoObj = profileWrapperDtoObj;    // Assign Profile WRAPPER Property
                ProfileWrapperDtoObj.ProjectId = projectId;     // Assign Profile WRAPPER Project ID

                #region TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=- BEGIN TRANSACTION -=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** BEGIN TRANSACTION FOR CREATE PROFILE WRAPPER ***.

                #region PROFILE PANEL DATA
                if (ProfileWrapperDtoObj.ProfileDtoObj == null) throw new ArgumentNullException(
                                     nameof(ProfileWrapperDtoObj.ProfileDtoObj),
                                     "Profile DTO Object cannot be null.");

                //---------------------------------------------------------------
                //--- Add Profile Data to DB using ViewModel Object           ---
                //--- Returns Profile ID for Foreign Key Relationships in DB  ---
                //--- NOTE: Profile ID used for all the other Profile WRAPPER ---
                //---       Sub-Panel ViewModel Object Add() methods as FK    ---
                //---------------------------------------------------------------
                ProfileDto externalProfileDto = ProfileWrapperDtoObj.ProfileDtoObj;
                profileId = ProfileViewModelObj.AddProfile(externalProfileDto);     // ADD Data

                if (profileId == -1) throw new ArgumentNullException(
                                           nameof(profileId),
                                           "Profile ID is -1 for ADD Profile ViewModel.");

                ProfileWrapperDtoObj.ProfileId = profileId;               // Assign Profile WRAPPER Profile ID
                externalProfileDto.Id = projectId;                        // Assign Profile DTO Project ID (PK)
                ProfileWrapperDtoObj.ProfileDtoObj = externalProfileDto;  // Assign WRAPPER Profile DTO
                #endregion  // PROJECT PANEL DATA

                #region PROFILE STREAMS SUB-PANELS

                #region PROCESS PROCESS STREAMS DATA
                if (ProfileWrapperDtoObj.ProcessStreamDtoList == null) throw new ArgumentNullException(
                                         nameof(ProfileWrapperDtoObj.ProcessStreamDtoList),
                                         "Process Stream DTO List cannot be null.");

                //-----------------------------------------------------------------
                //--- Add Process Stream List Data to DB using ViewModel Object ---
                //--- Returns (ProcessStreams) Profile ID                       ---
                //-----------------------------------------------------------------
                List<ProcessStreamDto> externalProcessStreamDtoList = ProfileWrapperDtoObj.ProcessStreamDtoList;
                int processStreamsProfileId = ProcessStreamViewModelObj.AddProcessStreams(externalProcessStreamDtoList);

                ProfileWrapperDtoObj.ProcessStreamDtoList = externalProcessStreamDtoList;  // Assign Profile WRAPPER Process Stream DTO List
                #endregion  // PROCESS PROCESS STREAMS DATA

                #region UTILITY STREAMS DATA
                if (ProfileWrapperDtoObj.UtilityStreamDtoList == null) throw new ArgumentNullException(
                                         nameof(ProfileWrapperDtoObj.UtilityStreamDtoList),
                                         "Utility Stream DTO List cannot be null.");

                //-----------------------------------------------------------------
                //--- Add Utility Stream List Data to DB using ViewModel Object ---
                //--- Returns (UtilityStreams) Profile ID                       ---
                //-----------------------------------------------------------------
                List<UtilityStreamDto> externalUtilityStreamDtoList = ProfileWrapperDtoObj.UtilityStreamDtoList;
                int utilityStreamsProfileId = UtilityStreamViewModelObj.AddUtilityStreams(externalUtilityStreamDtoList);

                ProfileWrapperDtoObj.UtilityStreamDtoList = externalUtilityStreamDtoList;  // Assign Profile WRAPPER Utility Stream DTO List
                #endregion  // UTILITY STREAMS DATA

                #endregion  // PROFILE STREAMS SUB-PANELS

                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-= END TRANSACTION =-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** END TRANSACTION FOR CREATE PROFILE WRAPPER ***.

                #endregion  // TRANSACTION
            }
            catch (Exception ex)
            {
                #region ROLL-BACK TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=- ROLL-BACK TRANSACTION -=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** ROLL-BACK TRANSACTION FOR CREATE PROFILE WRAPPER ***.

                #endregion  // ROLL-BACK TRANSACTION

                //---------------------
                //--- Log Exception ---
                //---------------------
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, "EXCEPTION ENCOUNTERED: CREATE TRANSACTION ROLLED BACK!");
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            //-----------------------------------------
            //--- Return Profile WRAPPER DTO Object ---
            //-----------------------------------------
            return ProfileWrapperDtoObj;
        }
        #endregion  // --> CREATE ... CreateProfileWrapperData(ProjectWrapperDto projecteWrapperDtoObj)

        #region --> READ ..... ReadProfileWrapperData(int profileId)
        /// <summary>
        /// Read (GET) the Profile Wrapper Data using the specified Profile ID
        /// using Sub-Panel ViewModel to Sub-Panel Repo interfaces.
        /// </summary>
        /// <param name="profileId">The ID of the project-related data to READ.</param>
        /// <returns>Profile WRAPPER DTO object</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ProfileWrapperDto ReadProfileWrapperData(int profileId)
        {
            string strMethod = "ReadProfileWrapperData";

            if (profileId == -1) throw new ArgumentNullException(
                                       nameof(profileId),
                                      "Profile ID cannot be -1.");
            //---------------------------------------------
            //--- Initialize Profile WRAPPER DTO Object ---
            //---------------------------------------------
            ProfileWrapperDtoObj = new ProfileWrapperDto();
            try
            {
                #region TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=- BEGIN TRANSACTION -=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** BEGIN TRANSACTION FOR READ PROFILE WRAPPER ***.

                #region PROFILE PANEL DATA
                //--------------------------------------------------------
                //--- READ Profile Data from DB using ViewModel Object ---
                //--- NOTE: ViewModel Object returns Profile DTO       ---
                //--------------------------------------------------------
                ProfileWrapperDtoObj.ProfileDtoObj = ProfileViewModelObj.GetProfileById(profileId);

                if (ProfileWrapperDtoObj.ProfileDtoObj == null) throw new ArgumentNullException(
                                  nameof(ProfileWrapperDtoObj.ProfileDtoObj),
                                 "Profile DTO cannot be null.");
                #endregion  // PROFILE PANEL DATA

                #region PROFILE STREAMS PANELS DATA

                #region PROCESS STREAMS PANEL DATA
                //---------------------------------------------------------------------
                //--- READ Process Streams List Data from DB using ViewModel Object ---
                //--- NOTE: ViewModel Object returns Process Streams DTO List       ---
                //---------------------------------------------------------------------
                ProfileWrapperDtoObj.ProcessStreamDtoList =
                                     ProcessStreamViewModelObj.GetProcessStreamsByProfileId(profileId);

                if (ProfileWrapperDtoObj.ProcessStreamDtoList == null) throw new ArgumentNullException(
                                nameof(ProfileWrapperDtoObj.ProcessStreamDtoList),
                               "Process Streams DTO List cannot be null.");
                #endregion  // PROCESS STREAMS PANEL DATA

                #region UTILITY STREAMS PANEL DATA
                //---------------------------------------------------------------------
                //--- READ Utility Streams List Data from DB using ViewModel Object ---
                //--- NOTE: ViewModel Object returns Utility Streams DTO List       ---
                //---------------------------------------------------------------------
                ProfileWrapperDtoObj.UtilityStreamDtoList =
                                     UtilityStreamViewModelObj.GetUtilityStreamsByProfileId(profileId);

                if (ProfileWrapperDtoObj.UtilityStreamDtoList == null) throw new ArgumentNullException(
                                nameof(ProfileWrapperDtoObj.UtilityStreamDtoList),
                               "Utility Streams DTO List cannot be null.");
                #endregion  // UTILITY STREAMS PANEL DATA

                #endregion  // PROFILE STREAMS PANELS DATA

                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-= END TRANSACTION =-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** END TRANSACTION FOR READ PROFILE WRAPPER ***.

                #endregion  // TRANSACTION
            }
            catch (Exception ex)
            {
                #region ROLL-BACK TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=- ROLL-BACK TRANSACTION -=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** ROLL-BACK TRANSACTION FOR READ PROFILE WRAPPER ***.

                #endregion  // ROLL-BACK TRANSACTION

                //---------------------
                //--- Log Exception ---
                //---------------------
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, "EXCEPTION ENCOUNTERED: READ TRANSACTION ROLLED BACK!");
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            //-----------------------------------------------
            //--- Assign Project Id to ProjectWRAPPER DTO ---
            //--- Return Populated Project WRAPPER DTO    ---
            //-----------------------------------------------
            ProfileWrapperDtoObj.ProfileId = profileId;
            return ProfileWrapperDtoObj;
        }
        #endregion  // --> READ ..... ReadProfileWrapperData(int profileId)

        #region --> UPDATE ... UpdateProfileWrapperData(ProfileWrapperDto profileWrapperDtoObj)
        /// <summary>
        /// Use the specified Profile Wrapper DTO to Modify (UPDATE) ALL Profile
        /// data using Sub-Panel ViewModel to Sub-Panel Repo interfaces.
        /// NOTE: The Profile ID used in assigned in the WRAPPER DTO
        /// </summary>
        /// <param name="profileWrapperDtoObj">Profile WRAPPER DTO object containing data to update.</param>
        public void UpdateProfileWrapperData(ProfileWrapperDto profileWrapperDtoObj)
        {
            string strMethod = "UpdateProfileWrapperData";
            int nProfileId = -1;    // Initialize Profile Id

            if (profileWrapperDtoObj == null) throw new ArgumentNullException(
                             nameof(profileWrapperDtoObj),
                             "Profile WRAPPER DTO cannot be null.");

            ProfileWrapperDtoObj = profileWrapperDtoObj;
            try
            {
                #region TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=- BEGIN TRANSACTION -=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** BEGIN TRANSACTION FOR UPDATE PROFILE WRAPPER ***.

                #region PROFILE PANEL DATA
                //----------------------------------------------------------------
                //--- Ensure Valid Profile DTO & ID found in the               ---
                //--- Profile WRAPPER DTO Object supplied in method invocation ---
                //----------------------------------------------------------------
                if (ProfileWrapperDtoObj.ProfileDtoObj == null) throw new ArgumentNullException(
                                  nameof(ProfileWrapperDtoObj.ProfileDtoObj),
                                 "Profile DTO Object cannot be null.");

                if (ProfileWrapperDtoObj.ProfileId == -1) throw new ArgumentNullException(
                                 nameof(ProfileWrapperDtoObj.ProfileId),
                                 "Profile ID cannot be -1.");
                //--------------------------------------------------
                //--- Update Profile Data using ViewModel Object ---
                //--- Returns void                               ---
                //--------------------------------------------------
                ProfileViewModelObj.UpdateProfile(ProfileWrapperDtoObj.ProfileDtoObj);
                #endregion  // PROFILE PANEL DATA

                #region PROFILE STREAMS PANEL DATA

                #region PROCESS STREAMS DATA
                //----------------------------------------------------------------
                //--- Ensure Valid ProcessStrream DTO & ID found in the        ---
                //--- Profile WRAPPER DTO Object supplied in method invocation ---
                //----------------------------------------------------------------
                if (ProfileWrapperDtoObj.ProcessStreamDtoList == null) throw new ArgumentNullException(
                                  nameof(ProfileWrapperDtoObj.ProcessStreamDtoList),
                                 "Process Stream DTO List cannot be null.");

                //-------------------------------------------------------------
                //--- Update Process Stream DTO List using ViewModel Object ---
                //--- Returns void                                          ---
                //-------------------------------------------------------------
                ProcessStreamViewModelObj.UpdateProcessStreams(
                                 ProfileWrapperDtoObj.ProcessStreamDtoList);
                #endregion  // PROCESS STREAMS DATA

                #region UTILITY STREAMS DATA
                //----------------------------------------------------------------
                //--- Ensure Valid UtilityStrream DTO & ID found in the        ---
                //--- Profile WRAPPER DTO Object supplied in method invocation ---
                //----------------------------------------------------------------
                if (ProfileWrapperDtoObj.UtilityStreamDtoList == null) throw new ArgumentNullException(
                                  nameof(ProfileWrapperDtoObj.UtilityStreamDtoList),
                                 "Utility Stream DTO List cannot be null.");

                //-------------------------------------------------------------
                //--- Update Utility Stream DTO List using ViewModel Object ---
                //--- Returns void                                          ---
                //-------------------------------------------------------------
                UtilityStreamViewModelObj.UpdateUtilityStreams(
                                 ProfileWrapperDtoObj.UtilityStreamDtoList);
                #endregion  // UTILITY STREAMS DATA

                #endregion  // PROFILE STREAMS PANEL DATA

                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-= END TRANSACTION =-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** END TRANSACTION FOR UPDATE PROFILE WRAPPER ***.

                #endregion  // TRANSACTION
            }
            catch (Exception ex)
            {
                #region ROLL-BACK TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=- ROLL-BACK TRANSACTION -=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** ROLL-BACK TRANSACTION FOR UPDATE PROFILE WRAPPER ***.

                #endregion  // ROLL-BACK TRANSACTION

                //---------------------
                //--- Log Exception ---
                //---------------------
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, "EXCEPTION ENCOUNTERED: UPDATE TRANSACTION ROLLED BACK!");
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
        }
        #endregion  // --> UPDATE ... UpdateProfileWrapperData(ProfileWrapperDto profileWrapperDtoObj)

        #region --> DELETE ... DeleteProfileWrapperData(int profileId)
        /// <summary>
        /// Use the specified Profile ID to DELETE ALL the Project WRAPPER Data.
        /// Cascading Delete is Controlled in SQLite.
        /// </summary>
        /// <param name="projectId">The ID of the profile-related data to DELETE.</param>
        public void DeleteProfileWrapperData(int profileId)
        {
            string strMethod = "DeleteProfileWrapperData";

            if (profileId == -1) throw new ArgumentNullException(
                                       nameof(profileId),
                                       "Profile ID cannot be -1.");

            try
            {
                ProfileWrapperDtoObj.ProfileId = profileId;

                #region TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=- BEGIN TRANSACTION -=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** BEGIN TRANSACTION FOR DELETE PROFILE WRAPPER ***.

                //------------------------------------------------------
                //--- Use Profile ID to DELETE Data from DB          ---
                //--- NOTE: Cascading Delete is controlled in SQLite ---
                //------------------------------------------------------
                ProfileViewModelObj.DeleteProfile(profileId);

                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-= END TRANSACTION =-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** END TRANSACTION FOR DELETE PROFILE WRAPPER ***.

                #endregion  // TRANSACTION
            }
            catch (Exception ex)
            {
                #region ROLL-BACK TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=- ROLL-BACK TRANSACTION -=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** ROLL-BACK TRANSACTION FOR DELETE PROFILE WRAPPER ***.

                #endregion  // ROLL-BACK TRANSACTION

                //---------------------
                //--- Log Exception ---
                //---------------------
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, "EXCEPTION ENCOUNTERED: DELETE TRANSACTION ROLLED BACK!");
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
        }
        #endregion  // --> DELETE ... DeleteProfileWrapperData(int profileId)

        #endregion  // CRUD METHODS
    }
    #endregion      // public class ProfileWrapperViewModel
}
#endregion      // namespace HenViewModel.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
