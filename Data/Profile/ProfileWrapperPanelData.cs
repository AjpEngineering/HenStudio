#region HEADER
//#####################################################################################################################
//###############################  P r o f i l e W r a p p e r P a n e l D a t a . c s  ###############################
//#####################################################################################################################
//  FILENAME:  ProfileWrapperPanelData.cs
//  NAMESPACE: HenStudio.Data.Profile
//  CLASS(S):  ProfileWrapperPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the Data class for the Profile Wrapper Panel Data Object.
//    It provides methods to update all the Profile Wrapper Data for a given Project & Profile IDs.
//    The wrapper includes, the following PROFILE PanelData objects,
//      - ProfilePanelData
//      - ProcessStreamPanelData
//      - UtilityStreamPanelData
//    The wrapper also includes PROJECT PanelData objects,
//      - ProjectPanelData
//      - ProjectUnitsPanelData.
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

using HenModel.Dto.Project;
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;
using HenModel.Dto.Profile;
using HenModel.Dto.Profile.Streams;

using HenStudio.Data.Profile;
#endregion  // HEN STUDIO REFERENCES

using System;
using System.Collections.Generic;

using HenViewModel.Project;
using HenViewModel.Profile;
#endregion      // REFERENCES

#region HenStudio.Data.Profile
namespace HenStudio.Data.Profile
{
    #region public class ProfileWrapperDto
    /// <summary>
    /// Profile Wrapper Data Class
    /// </summary>
    public class ProfileWrapperPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Profile";
        const string CLASS = "ProfileWrapperPanelData";
        #endregion  // CONSTANTS

        #region PROPERTIES

        #region ProfileWrapperDto OBJECT
        //-------------------------------------------------
        //--- ProfileWrapperPanelData Object contains   ---
        //--- all the IDs, and DTO Objects, for the     ---
        //--- Profile Wrapper Panel. [INTRA-VIEW LAYER] ---
        //-------------------------------------------------
        ProfileWrapperDto ProfileWrapperDtoObj { get; set; }
        #endregion  // ProfileWrapperDto OBJECT

        #region Profile Wrapper ViewModel OBJECT
        ProfileWrapperViewModel ProfileWrapperViewModelObj { get; set; }
        #endregion  // Profile Wrapper ViewModel OBJECT

        #endregion      // PROPERTIES

        #region Parameterized CTOR
        /// <summary>
        /// Parameterized Constructor for ProfileWrapperPanelData Class
        /// </summary>
        /// <param name="strProjectDbNameOnly">Project Db Name... NO ".db" extension</param>
        public ProfileWrapperPanelData(string strProjectDbNameOnly)
        {
            try
            {
                if (strProjectDbNameOnly == string.Empty) throw new ArgumentNullException(
                   nameof(strProjectDbNameOnly),
                   "Project DB Name can not be empty");

                ProfileWrapperDtoObj = new ProfileWrapperDto();
                ProfileWrapperViewModelObj = new ProfileWrapperViewModel(strProjectDbNameOnly);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error null ID: {ex.Message}");
            }
        }
        #endregion  // Parameterized CTOR

        #region CRUD Methods

        #region --> CREATE ... AddProfileWrapperData(ProfileWrapperDto profileWrapperDtoObj)
        /// <summary>
        /// Add (CREATE) the Profile data contained in the WRAPPER DTO to the SQLite PROJECT DB
        /// Returns Profile WRAPPER DTO object; contains Profile Id associated with added data
        /// ---------------------------------------------------------------------------------------
        /// -------------------------------------- USE CASE ---------------------------------------
        /// ---------------------------------------------------------------------------------------
        ///   1. User scrapes Control contents and assigns the DTO objects in WRAPPER DTO
        ///   2. User assigns Project Database name in WRAPPER DTO
        ///   3. User invokes this method, passing in the fully populated WRAPPER DTO object
        ///   4. Method invokes Wrapper ViewModel passing in the WRAPPER DTO object
        ///   5. Wrapper ViewModel ADDs all the Profile Data, and returns the unique Profile Id
        ///   6. Method ensures Profile Id is assigned to WRAPPER DTO
        ///   7. Method returns the WRAPPER DTO object
        /// ---------------------------------------------------------------------------------------
        /// </summary>
        /// <returns>Profile WRAPPER DTO object containing the newly created Profile-related data,
        /// also include Project DB Name, Project and Profile Ids, on success; null otherwise.</returns>
        /// <exception cref="ArgumentNullException">Check for Null Project Wrapper Dto Object</exception>
        public ProfileWrapperDto AddProfileWrapperData(ProfileWrapperDto profileWrapperDtoObj)
        {
            string strMethod = "AddProfileWrapperData";

            if (profileWrapperDtoObj == null) throw new ArgumentNullException(
                                        nameof(profileWrapperDtoObj),
                                        "Profile Wrapper DTO can not be null");

            if (profileWrapperDtoObj.ProjectDbName == string.Empty) throw new ArgumentNullException(
                                       nameof(profileWrapperDtoObj.ProjectDbName),
                                       "Project DB Name can not be empty");
            try
            {
                //-------------------------------------------------------------------
                //--- Profile Wrapper ViewModel CreateProfileWrapperData() Method ---
                //------------------------------------------------------------------- 
                ProfileWrapperDtoObj = ProfileWrapperViewModelObj.CreateProfileWrapperData(
                                       profileWrapperDtoObj);
            }
            catch (Exception ex)
            {
                //---------------------
                //--- Log Exception ---
                //---------------------
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            //-----------------------------------------------------------------
            //--- Return Profile Wrapper DTO Object ... contains Profile ID ---
            //-----------------------------------------------------------------
            return ProfileWrapperDtoObj;
        }
        #endregion  // --> CREATE ... AddProfileWrapperData(ProfileWrapperDto profileWrapperDtoObj)

        #region --> READ ..... GetProfileWrapperData(int profileId)
        /// <summary>
        /// Get (READ) the Profile data associated with the user supplied Profile Id
        /// Returns a populated Profile WRAPPER DTO object.
        /// ---------------------------------------------------------------------------------------
        /// -------------------------------------- USE CASE ---------------------------------------
        /// ---------------------------------------------------------------------------------------
        ///   1. User invokes this method, passing in the Profile Id
        ///   2  Method ensures Profile Id is assigned to Profile WRAPPER DTO object Property
        ///   2. Method invokes Wrapper ViewModel passing in the Profile Id
        ///   3. Wrapper ViewModel GETs all the Profile Data and populates the Profile WRAPPER DTO
        ///   4. Method assigns the Profile WRAPPER DTO property with the DTO returned
        ///   5. Method returns the WRAPPER DTO object
        /// ---------------------------------------------------------------------------------------
        /// </summary>
        /// <param name="profileId">Unique Profile Id</param>
        /// <returns>Profile WRAPPER DTO object containing the newly created Profile-related data,
        /// also include Project DB Name and Profile Id, on success; null otherwise.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ProfileWrapperDto GetProfileWrapperData(int profileId)
        {
            string strMethod = "GetProfileWrapperData";

            if (profileId == -1) throw new ArgumentNullException(
                                       nameof(profileId),
                                       "Profile ID cannot be -1.");
            try
            {
                //---------------------------------
                //--- Assign WRAPPER Profile ID ---
                //---------------------------------
                ProfileWrapperDtoObj.ProfileId = profileId;

                //-----------------------------------------------------------------
                //--- Profile Wrapper ViewModel ReadProfileWrapperData() Method ---
                //----------------------------------------------------------------- 
                ProfileWrapperDtoObj = ProfileWrapperViewModelObj.ReadProfileWrapperData(profileId);
            }
            catch (Exception ex)
            {
                //---------------------
                //--- Log Exception ---
                //---------------------
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            //--------------------------------------------
            //--- Return Populated Profile WRAPPER DTO ---
            //--------------------------------------------
            return ProfileWrapperDtoObj;
        }
        #endregion  // --> READ ..... GetProfileWrapperData(int profileId)

        #region --> UPDATE ... ModifyProfileWrapperData(ProfileWrapperDto profileWrapperDtoObj)
        /// <summary>
        /// Modify (UPDATE) the Profile data associated with the user supplied Profile Id
        /// Returns a populated Profile WRAPPER DTO object.
        /// NOTE: The Profile ID used is assigned in the Profile WRAPPER DTO Object
        /// ---------------------------------------------------------------------------------------
        /// -------------------------------------- USE CASE ---------------------------------------
        /// ---------------------------------------------------------------------------------------
        ///   1. User scrapes the Controls, assigns Profile Data to Profile WRAPPER DTO Object
        ///   2. User invokes this method, passing in the populated Profile WRAPPER DTO Object
        ///   3. Method assigns the Profile WRAPPER DTO Property
        ///   4. Method invokes Wrapper ViewModel passing in the Profile WRAPPER DTO Object
        ///   5. Wrapper ViewModel MODIFIES all the Profile Data 
        ///   6. Method returns void
        /// ---------------------------------------------------------------------------------------
        /// </summary>
        /// <param name="profileWrapperDtoObj">Profile WRAPPER DTO object containing data to update.</param>
        /// <returns>Profile WRAPPER DTO including data updated</returns>
        public void ModifyProfileWrapperData(ProfileWrapperDto profileWrapperDtoObj)
        {
            string strMethod = "ModifyProfileWrapperData";

            if (profileWrapperDtoObj == null) throw new ArgumentNullException(
                                        nameof(profileWrapperDtoObj),
                                        "Project Wrapper DTO cannot be null.");

            if (profileWrapperDtoObj.ProfileId == -1) throw new ArgumentNullException(
                                        nameof(profileWrapperDtoObj.ProfileId),
                                        "Profile ID cannot be -1.");
            try
            {
                //--------------------------------------------------
                //--- Assign Profile WRAPPER DTO Object Property ---
                //--------------------------------------------------
                ProfileWrapperDtoObj = profileWrapperDtoObj;

                //-------------------------------------------------------------------
                //--- Profile Wrapper ViewModel UpdateProfileWrapperData() Method ---
                //-------------------------------------------------------------------
                ProfileWrapperViewModelObj.UpdateProfileWrapperData(profileWrapperDtoObj);
            }
            catch (Exception ex)
            {
                //---------------------
                //--- Log Exception ---
                //---------------------
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
        }
        #endregion  // --> UPDATE ... ModifyProfileWrapperData(ProfileWrapperDto profileWrapperDtoObj)

        #region --> DELETE ... DeleteProfileWrapperData(Guid projectId, Guid profileId)
        /// <summary>
        /// Delete (DELETE) the Profile data associated with the user supplied Profile Id
        /// Returns void.
        /// ---------------------------------------------------------------------------------------
        /// -------------------------------------- USE CASE ---------------------------------------
        /// ---------------------------------------------------------------------------------------
        ///   1. User invokes this method, passing in the Profile Id
        ///   2. Method assigns the Profile Id in the Profile WRAPPER DTO Property
        ///   3. Method invokes Wrapper ViewModel passing in the Profile Id
        ///   4. Wrapper ViewModel DELETES all the Profile Data associated with the Profile Id 
        ///   5. Method returns void
        /// ---------------------------------------------------------------------------------------
        /// NOTE: Cascading Delete is Controlled in SQL.
        /// </summary>
        /// <param name="profileId">The ID of the project-related data to DELETE.</param>
        public void DeleteProfileWrapperData(int profileId)
        {
            string strMethod = "DeleteProfileWrapperData";

            if (profileId == -1) throw new ArgumentNullException(
                                       nameof(profileId),
                                       "Profile ID cannot be -1.");
            try
            {
                //--------------------------------------------------------------------
                //--- Assign Profile Id in the Profile WRAPPER DTO Object Property ---
                //--------------------------------------------------------------------
                ProfileWrapperDtoObj.ProfileId = profileId;

                //-------------------------------------------------------------------
                //--- Profile Wrapper ViewModel DeleteProfileWrapperData() Method ---
                //-------------------------------------------------------------------
                ProfileWrapperViewModelObj.DeleteProfileWrapperData(profileId);
            }
            catch (Exception ex)
            {
                //---------------------
                //--- Log Exception ---
                //---------------------
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
        }
        #endregion  // --> DELETE ... DeleteProfileWrapperData(Guid projectId, Guid profileId)

        #endregion  // CRUD Methods
    }
    #endregion      // public class ProfileWrapperDto
}
#endregion      // namespace HenStudio.Data.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
