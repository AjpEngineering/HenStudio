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

using HenStudio.Data.Project;
using HenStudio.Data.Project.DefaultParameters.ProjectUnits;
using HenStudio.Data.Profile;
using HenStudio.Data.Profile.Streams;
#endregion  // HEN STUDIO REFERENCES

using System;
using System.Collections.Generic;
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
        #region PROPERTIES

        #region ProfileWrapperDto OBJECT
        //-------------------------------------------------
        //--- ProfileWrapperPanelData Object contains   ---
        //--- all the IDs, and DTO Objects, for the     ---
        //--- Profile Wrapper Panel. [INTRA-VIEW LAYER] ---
        //-------------------------------------------------
        ProfileWrapperDto ProfileWrapperDtoObj { get; set; }
        #endregion  // ProfileWrapperDto OBJECT

        #region SUB-PanelData OBJECTS
        public ProjectPanelData ProjectPanelDataObj { get; set; }
        public ProjectUnitsPanelData ProjectUnitsPanelDataObj { get; set; }

        public ProfilePanelData ProfilePanelDataObj { get; set; }
        public ProcessStreamPanelData ProcessStreamPanelDataObj { get; set; }
        public UtilityStreamPanelData UtilityStreamPanelDataObj { get; set; }
        #endregion  // SUB-PanelData OBJECTS

        #region HenProjectUnits OBJECT
        //------------------------------------------------------------------------
        //--- HenProjectUnits Holds PROJECT Units Data (INTERNAL & EXTERNAL)   ---
        //------------------------------------------------------------------------
        //--- Object contains methods to retrieve the following PROJECT UNITS: ---
        //--- SystemUnits, MagnitudeUnits, AreaUnits, TemperatureUnits,        ---
        //--- PressureUnits, HeatFlowRateUnits, HeatCapacityFlowRateUnits,     ---
        //--- Overall HeatTransferCoefficientUnits                             ---
        //------------------------------------------------------------------------
        public HenProjectUnits HenProjectUnitsObj { get; set; }
        #endregion  // HenProjectUnits OBJECT

        #endregion      // PROPERTIES

        #region InitializeWrapperData()
        /// <summary>
        /// Initialize the Profile Wrapper Data Object with Default Values 
        /// to Avoid Null Reference Exceptions.
        /// NOTE: ProfileWrapperPanelData Object contains all the IDs, 
        /// and DTO Objects, for the Profile Wrapper Panel. [INTRA-VIEW LAYER]
        /// </summary>
        private void InitializeWrapperData()
        {
            //------------------------------------------------------
            //--- Initialize ProfileWrapperDtoObj Property to    ---
            //--- Avoid Null Reference Exceptions                ---
            //------------------------------------------------------
            ProfileWrapperDtoObj = new ProfileWrapperDto();
            //-----------------------------------------------------------------------
            //--- Initialize PanelData Objects to Avoid Null Reference Exceptions ---
            //-----------------------------------------------------------------------
            ProjectPanelDataObj = new ProjectPanelData();
            ProjectUnitsPanelDataObj = new ProjectUnitsPanelData();

            ProfilePanelDataObj = new ProfilePanelData();
            ProcessStreamPanelDataObj = new ProcessStreamPanelData();
            UtilityStreamPanelDataObj = new UtilityStreamPanelData();
            //----------------------------------------------------------------------------
            //--- Initialize HenProjectUnits Object to Avoid Null Reference Exceptions ---
            //----------------------------------------------------------------------------
            //--- Object contains methods to retrieve the following PROJECT UNITS:     ---
            //--- SystemUnits, MagnitudeUnits, AreaUnits, TemperatureUnits,            ---
            //--- PressureUnits, HeatFlowRateUnits, HeatCapacityFlowRateUnits,         ---
            //--- Overall HeatTransferCoefficientUnits                                 ---
            //----------------------------------------------------------------------------
            HenProjectUnitsObj = new HenProjectUnits();
        }
        #endregion  // InitializeWrapperData()

        #region Default CTOR
        /// <summary>
        /// Default Constructor for ProfileWrapperData Class
        /// </summary>
        public ProfileWrapperPanelData()
        {
            //-----------------------------------------------------------
            // --- Initialize the Profile Wrapper Data Object with    ---
            // --- Default Values to Avoid Null Reference Exceptions. ---
            //-----------------------------------------------------------
            InitializeWrapperData();
        }
        #endregion  // Default CTOR

        #region Parameterized CTOR
        /// <summary>
        /// Parameterized Constructor for ProfileWrapperPanelData Class
        /// </summary>
        public ProfileWrapperPanelData(Guid projectId, Guid profileId)
        {
            try
            {
                //-----------------------------------------------------------
                // --- Initialize the Profile Wrapper Data Object with    ---
                // --- Default Values to Avoid Null Reference Exceptions. ---
                //-----------------------------------------------------------
                InitializeWrapperData();
                //--------------------------------------------------------------------------
                //--- Null Guard on User Supplied Ids to Avoid Null Reference Exceptions ---
                //--------------------------------------------------------------------------   
                if (projectId == null) throw new ArgumentNullException(
                                             nameof(projectId), "Project ID cannot be null.");
                else ProfileWrapperDtoObj.ProjectId = projectId;

                if (profileId == null) throw new ArgumentNullException(
                                             nameof(profileId), "Profile ID cannot be null.");
                else ProfileWrapperDtoObj.ProfileId = profileId;
                //---------------------------------------------
                //--- Assign PanelData Object Id Properties ---
                //---------------------------------------------
                ProjectPanelDataObj.ProjectId = ProfileWrapperDtoObj.ProjectId;

                ProjectUnitsPanelDataObj.ProjectId = ProfileWrapperDtoObj.ProjectId;

                ProfilePanelDataObj.ProjectId = ProfileWrapperDtoObj.ProjectId;
                ProfilePanelDataObj.ProfileId = ProfileWrapperDtoObj.ProfileId;

                ProcessStreamPanelDataObj.ProjectId = ProfileWrapperDtoObj.ProjectId;
                ProcessStreamPanelDataObj.ProfileId = ProfileWrapperDtoObj.ProfileId;

                UtilityStreamPanelDataObj.ProjectId = ProfileWrapperDtoObj.ProjectId;
                UtilityStreamPanelDataObj.ProfileId = ProfileWrapperDtoObj.ProfileId;
                //--------------------------------------------------
                //--- Initialize Property HenProjectUnits Object ---
                //--------------------------------------------------
                ProjectUnitsPanelDataObj.ReadProjectUnitsData(projectId);
                ProjectUnitsDto projectUnitsDtoObj = ProjectUnitsPanelDataObj.ProjectUnitsDtoObj;

                if (projectUnitsDtoObj == null)
                    throw new Exception("Project Units DTO Object is null for Project ID: " + projectId);

                HenProjectUnitsObj = new HenProjectUnits(projectUnitsDtoObj.DefaultSystemUnits,
                                                         projectUnitsDtoObj.DefaultMagnitudeUnits,
                                                         projectUnitsDtoObj.DefaultTemperatureUnits,
                                                         projectUnitsDtoObj.DefaultPressureUnits);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error null ID: {ex.Message}");
            }
        }
        #endregion  // Parameterized CTOR

        #region CRUD Methods

        #region --> CREATE ... CreateProfileWrapperData(Guid projectId, ProfileWrapperDto profileWrapperDtoObj)
        /// <summary>
        /// Add (CREATE) the Profile Data to the DB.  Client VIEW Objects populate the Wrapper DTO.
        /// The WRAPPER DTO contains all the DTOs for the SubPanel Data objects and lists
        /// This Wrapper DTO contains the following SubPanel DTOs,
        ///   + Profile DTO, 
        ///   + Process Stream DTO, 
        ///   + Utility Stream DTO 
        /// Wrapper DTO Data is for a given Project ID.
        /// </summary>
        /// <param name="projectId">The ID of the project for which to create ALL the profile wrapper data.</param>
        /// <param name="profileWrapperDtoObj">The ProfileWrapperDto object.</param>
        /// <returns>The ID of the profile for which the profile wrapper data was created.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the provided project ID is null.</exception>
        /// <exception cref="ArgumentNullException">Thrown when the provided Profile Wrapper DTO is null.</exception>
        public Guid CreateProfileWrapperData(Guid projectId, 
                                             ProfileWrapperDto profileWrapperDtoObj)
        {
            if (projectId == null) throw new ArgumentNullException(
                             nameof(projectId), 
                             "Project ID cannot be null.");

            if (profileWrapperDtoObj == null) throw new ArgumentNullException(
                              nameof(profileWrapperDtoObj),
                              "Profile Wrapper DTO can not be null");

            Guid profileId = Guid.Empty; // Initialize Profile ID
            //----------------------------------------------------------------------------
            //--- Get DTO Data for Adding to DB ... VIEW Objects populatle WRAPPER DTO ---
            //----------------------------------------------------------------------------
            ProfileWrapperDtoObj = profileWrapperDtoObj;
            ProfileDto profileDtoObj = ProfileWrapperDtoObj.ProfileDtoObj;
            List<ProcessStreamDto> processStreamList = ProfileWrapperDtoObj.ProcessStreamDtoList;
            List<UtilityStreamDto> utilityStreamList = ProfileWrapperDtoObj.UtilityStreamDtoList;

            //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            //-------------------------- PROFILE DATA --------------------------
            //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

            if (profileDtoObj == null) throw new ArgumentNullException(
                             nameof(profileDtoObj),
                             "Profile DTO Object cannot be null.");
            //--------------------------------------------------------------
            //--- Add Profile Data to DB using PanelData Object          ---
            //--- Returns Profile ID for Foreign Key Relationships in DB ---
            //--------------------------------------------------------------
            profileId = ProfilePanelDataObj.CreateProfileData(ProfileWrapperDtoObj.ProfileDtoObj);

            if (profileId == null) throw new ArgumentNullException(
                             nameof(profileId), "Profile ID is null for ADD Profile Panel data.");

            //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            //---------------------- PROCESS STREAM DATA -----------------------
            //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

            if (processStreamList == null) throw new ArgumentNullException(
                            nameof(processStreamList),
                            "Process Stream DTO List cannot be null.");
            //-------------------------------------------------------------------
            //--- Add Process Stream Panel data to DB using PanelData Object  ---
            //--- Returns Profile ID for Foreign Key Relationships in DB      ---
            //-------------------------------------------------------------------
            ProcessStreamPanelDataObj.ProjectId = projectId;
            profileId = ProcessStreamPanelDataObj.CreateProcessStreamsData();

            if (profileId == null) throw new ArgumentNullException(
                             nameof(profileId), "Profile ID is null for ADD Process Stream Panel data.");

            //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            //---------------------- UTILITY STREAM DATA -----------------------
            //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

            if (utilityStreamList == null) throw new ArgumentNullException(
                            nameof(utilityStreamList),
                            "Utility Stream DTO List cannot be null.");
            //-------------------------------------------------------------------
            //--- Add Utility Stream Panel data to DB using PanelData Object  ---
            //--- Returns Profile ID for Foreign Key Relationships in DB      ---
            //-------------------------------------------------------------------
            UtilityStreamPanelDataObj.ProjectId = projectId;
            profileId = UtilityStreamPanelDataObj.CreateUtilityStreamsData();

            if (profileId == null) throw new ArgumentNullException(
                             nameof(profileId), "Profile ID is null for ADD Utility Stream Panel data.");
            //-----------------------------------------------
            //--- Assign projectId to all Profile Objects ---
            //-----------------------------------------------
            ProfileWrapperDtoObj.ProjectId = projectId;
            
            ProjectPanelDataObj.ProjectId = projectId;
            ProfilePanelDataObj.ProfileDtoObj.ProjectId = projectId;

            ProjectUnitsPanelDataObj.ProjectId = projectId;
            ProjectUnitsPanelDataObj.ProjectUnitsDtoObj.ProjectId = projectId;

            ProfilePanelDataObj.ProjectId = projectId;
            ProfilePanelDataObj.ProfileDtoObj.ProjectId = projectId;

            ProcessStreamPanelDataObj.ProjectId = projectId;
            UtilityStreamPanelDataObj.ProjectId = projectId;
            //-----------------------------------------------
            //--- Assign profileId to all Profile Objects ---
            //-----------------------------------------------
            ProfileWrapperDtoObj.ProfileId = profileId;

            ProfilePanelDataObj.ProfileId = profileId;
            ProfilePanelDataObj.ProfileDtoObj.Id = profileId;

            ProcessStreamPanelDataObj.ProfileId = profileId;
            UtilityStreamPanelDataObj.ProfileId = profileId;
            //-------------------------
            //--- Return Profile ID ---
            //-------------------------
            return profileId;
        }
        #endregion  // --> CREATE ... CreateProfileWrapperData(Guid projectId, ProfileWrapperDto profileWrapperDtoObj)

        #region --> READ ..... ReadProfileWrapperData(Guid projectId, Guid profileId)
        /// <summary>
        /// Retrieve (READ) the Profile Wrapper Data for a Given Project & Profile IDs. 
        /// This method will be used to Populate the Profile Wrapper Data Object 
        /// with Data from the DB.
        /// </summary>
        /// <param name="projectId">The ID of the project-related data to READ.</param>
        /// <param name="profileId">The ID of the profile-related data to READ.</param>
        /// <exception cref="ArgumentNullException">Thrown when the provided project ID is null.</exception>
        /// <exception cref="ArgumentNullException">Thrown when the provided profile ID is null.</exception>
        public ProfileWrapperDto ReadProfileWrapperData(Guid projectId, 
                                                        Guid profileId)
        {
            if (projectId == null) throw new ArgumentNullException(
                             nameof(projectId), 
                             "Project ID cannot be null.");

            if (profileId == null) throw new ArgumentNullException(
                             nameof(profileId), 
                             "Profile ID cannot be null.");
            //--------------------------
            //--- Assign Wrapper Ids ---
            //--------------------------
            ProfileWrapperDtoObj.ProjectId = projectId;
            ProfileWrapperDtoObj.ProfileId = profileId;
            //----------------------------------------------------------
            //--- READ Project Data from DB using Project ViewModels ---
            //----------------------------------------------------------
            ProjectPanelDataObj.ProjectId = projectId;
            ProjectPanelDataObj.ReadProjectData(projectId);

            ProjectUnitsPanelDataObj.ProjectId = projectId;
            ProjectUnitsPanelDataObj.ReadProjectUnitsData(projectId);
            //--------------------------------------------------------
            //--- READ Profile Data from DB using PanelData Object ---
            //--- Results are assign to WRAPPER DTO objects        ---
            //--------------------------------------------------------
            ProfilePanelDataObj.ProjectId = projectId;
            ProfilePanelDataObj.ProfileId = profileId;
            ProfileWrapperDtoObj.ProfileDtoObj = ProfilePanelDataObj.ReadProfileData(profileId);

            ProcessStreamPanelDataObj.ProjectId = projectId;
            ProcessStreamPanelDataObj.ProfileId = profileId;
            ProfileWrapperDtoObj.ProcessStreamDtoList = 
                                 ProcessStreamPanelDataObj.ReadProcessStreamData(profileId);

            UtilityStreamPanelDataObj.ProjectId = projectId;
            UtilityStreamPanelDataObj.ProfileId = profileId;
            ProfileWrapperDtoObj.UtilityStreamDtoList =
                                 UtilityStreamPanelDataObj.ReadUtilityStreamData(profileId);
            //---------------------------------
            //--- Results in WRAPPER Object ---
            //---------------------------------
            return ProfileWrapperDtoObj;
        }
        #endregion  // --> READ ..... ReadProfileWrapperData(Guid projectId, Guid profileId) 

        #region --> UPDATE ... UpdateProfileWrapperData(Guid projectId, Guid profileId, ProfileWrapperDto ProfileWrapperDtoObj)
        /// <summary>
        /// Scrap Screen data and Populate the Profile Wrapper Object
        /// then use this method to UPDATE ALL the Profile Wrapper Data for a Given Project & Profile IDs.
        /// </summary>
        /// <param name="projectId">The ID of the project-related data to UPDATE.</param>
        /// <param name="profileId">The ID of the profile-related data to UPDATE.</param>
        /// <param name="profileWrapperDtoObj">The Profile Wrapper data to UPDATE.</param>
        /// <exception cref="ArgumentNullException">Thrown when the provided project ID is null.</exception>
        /// <exception cref="ArgumentNullException">Thrown when the provided profile ID is null.</exception>
        /// <returns>ProfileWapperDto UPDATE data </returns>
        public ProfileWrapperDto UpdateProfileWrapperData(Guid projectId, 
                                                          Guid profileId, 
                                                          ProfileWrapperDto profileWrapperDtoObj)
        {
            if (projectId == null) throw new ArgumentNullException(
                             nameof(projectId), 
                             "Project ID cannot be null.");

            if (profileId == null) throw new ArgumentNullException(
                             nameof(profileId), 
                             "Profile ID cannot be null.");

            if (profileWrapperDtoObj == null) throw new ArgumentNullException(
                             nameof(profileWrapperDtoObj), 
                             "Profile Wrapper DTO cannot be null.");
            //-------------------------------------------------------------------------------
            //--- Get DTO Data for Updating the DB ... VIEW Objects Populatle WRAPPER DTO ---
            //-------------------------------------------------------------------------------
            ProfileWrapperDtoObj = profileWrapperDtoObj;
            ProfileWrapperDtoObj.ProjectId = projectId;
            ProfileWrapperDtoObj.ProfileId = profileId;

            ProfileDto profileDtoObj = ProfileWrapperDtoObj.ProfileDtoObj;
            List<ProcessStreamDto> processStreamList = ProfileWrapperDtoObj.ProcessStreamDtoList;
            List<UtilityStreamDto> utilityStreamList = ProfileWrapperDtoObj.UtilityStreamDtoList;
            //------------------------------------------
            //--- Assign Project & ProjectUnits Data ---
            //------------------------------------------
            ProjectPanelDataObj.ProjectId = projectId;

            ProjectUnitsPanelDataObj.ProjectId = projectId;
            ProjectUnitsPanelDataObj.ProjectUnitsDtoObj.ProjectId = projectId;
            //---------------------------------------------------------
            //--- UPDATE Profile Data in DB using PanelData Objects ---
            //---------------------------------------------------------
            ProfilePanelDataObj.ProjectId = projectId;
            ProfilePanelDataObj.ProfileId = profileId;
            ProfilePanelDataObj.ProfileDtoObj.ProjectId = projectId;
            ProfilePanelDataObj.ProfileDtoObj.Id = profileId;
            ProfilePanelDataObj.UpdateProfileData(profileDtoObj);
            //----------------------------------------------------------------
            //--- UPDATE Process Stream Data in DB using PanelData Objects ---
            //----------------------------------------------------------------
            ProcessStreamPanelDataObj.ProjectId = projectId;
            ProcessStreamPanelDataObj.ProfileId = profileId;
            ProcessStreamPanelDataObj.UpdateProcessStreamData(processStreamList);
            //----------------------------------------------------------------
            //--- UPDATE Utility Stream Data in DB using PanelData Objects ---
            //----------------------------------------------------------------
            UtilityStreamPanelDataObj.ProjectId = projectId;
            UtilityStreamPanelDataObj.ProfileId = profileId;
            UtilityStreamPanelDataObj.UpdateUtilityStreamData(utilityStreamList);
            //-----------------------------------------
            //--- Return Profile Wrapper Dto Object ---
            //-----------------------------------------
            return ProfileWrapperDtoObj;
        }
        #endregion  // --> UPDATE ... UpdateProfileWrapperData(Guid projectId, Guid profileId, ProfileWrapperDto ProfileWrapperDtoObj)

        #region --> DELETE ... DeleteProfileWrapperData(Guid projectId, Guid profileId)
        /// <summary>
        /// Use the specified Profile ID and ViewModel object 
        /// to DELETE ALL the Profile Subpanel data in the HENSTUDIO DB.
        /// Cascading Delete is Controlled in SQL, so Deleting the Profile 
        /// will also Delete the Process Stream and Utility Stream data 
        /// for the Given Profile ID.
        /// </summary>
        /// <param name="projectId">The Project ID of the profile-related data to DELETE.</param>
        /// <param name="profileId">The Profile ID of the profile-related data to DELETE.</param>
        public void DeleteProfileWrapperData(Guid projectId, Guid profileId)
        {
            if (projectId == null) throw new ArgumentNullException(
                             nameof(projectId),
                             "Project ID cannot be null.");

            if (profileId == null) throw new ArgumentNullException(
                             nameof(profileId),
                             "Profile ID cannot be null.");
            //----------------------------------------------
            //--- Assign Wrapper Project and Profile IDs ---
            //----------------------------------------------
            ProfileWrapperDtoObj.ProjectId = projectId;
            ProfileWrapperDtoObj.ProfileId = profileId;
            //----------------------------------------------------
            //--- Use PanelData to DELETE Data from DB         ---
            //--- NOTE: Cascading Delete is controlled in SQL. ---
            //----------------------------------------------------
            ProfilePanelDataObj.DeleteProfileData(profileId);
        }
        #endregion  // --> DELETE ... DeleteProfileWrapperData(Guid projectId, Guid profileId)

        #endregion  // CRUD Methods

        #region RENAME PROFILE METHOD
        /// <summary>
        /// Use the specified Profile ID and the new profile name and 
        /// description to RENAME the profile in the HENSTUDIO DB.
        /// </summary>
        /// <param name="profileId">Profile ID of profile to rename</param>
        /// <param name="newName">New Name</param>
        /// <param name="newDescription">New Description</param>
        /// <returns>Profile DTO of renamed Profile</returns>
        /// <exception cref="ArgumentNullException">Check for null profile id</exception>
        /// <exception cref="ArgumentException">Check for empty name</exception>
        public ProfileDto RenameProfile(Guid profileId,
                                        string newName,
                                        string newDescription)
        {
            if (profileId == null) throw new ArgumentNullException(
                             nameof(profileId), 
                             "Profile ID is null for READ Profile Panel data.");

            if (string.IsNullOrEmpty(newName)) throw new ArgumentException(
                             nameof(newName), 
                             "New profile name is null or empty for RENAME Profile Panel data.");
            //------------------------------------------------
            //--- Update Project Wrapper  Panel Project ID ---
            //------------------------------------------------
            ProfileWrapperDtoObj.ProfileId = profileId;
            //--------------------------------------------
            //--- Return the Profile DTO Updated in DB ---
            //--------------------------------------------
            return ProfilePanelDataObj.RenameProfile(profileId,
                                                     newName,
                                                     newDescription);
        }
        #endregion  // RENAME PROFILE METHOD
    }
    #endregion      // public class ProfileWrapperDto
}
#endregion      // namespace HenStudio.Data.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
