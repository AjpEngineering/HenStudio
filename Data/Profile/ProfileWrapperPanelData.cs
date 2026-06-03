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

using HenModel.Dto.Profile;
using HenModel.Dto.Profile.Streams;

using HenModel.Dto.Project;
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

using HenViewModel.Profile;
using HenViewModel.Profile.Streams;

using HenViewModel.Project;
using HenViewModel.Project.DefaultParameters.ProjectUnits;

using HenStudio.Data.Profile;
using HenStudio.Data.Profile.Streams;

using HenStudio.Data.Project;
using HenStudio.Data.Project.DefaultParameters.ProjectUnits;
#endregion  // HEN STUDIO REFERENCES

using System;
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

        //#region VIEW MODEL Objects
        //public ProjectViewModel ProjectViewModelObj { get; set; }
        //public ProjectUnitsViewModel ProjectUnitsViewModelObj { get; set; }

        //public ProfileViewModel ProfileViewModelObj { get; set; }
        //public ProcessStreamViewModel ProcessStreamViewModelObj { get; set; }
        //public UtilityStreamViewModel UtilityStreamViewModelObj { get; set; }
        //#endregion  //  VIEW MODEL Objects

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
        /// </summary>
        private void InitializeWrapperData()
        {
            ProfileWrapperDtoObj = new ProfileWrapperDto();
            //----------------------------------------------------------------
            //--- Initialize Id Objects to Avoid Null Reference Exceptions ---
            //----------------------------------------------------------------
            ProfileWrapperDtoObj.ProjectId = Guid.Empty; 
            ProfileWrapperDtoObj.ProfileId = Guid.Empty; 
            //-----------------------------------------------------------------------
            //--- Initialize PanelData Objects to Avoid Null Reference Exceptions ---
            //-----------------------------------------------------------------------
            ProjectPanelDataObj = new ProjectPanelData();
            ProjectUnitsPanelDataObj = new ProjectUnitsPanelData();

            ProfilePanelDataObj = new ProfilePanelData();
            ProcessStreamPanelDataObj = new ProcessStreamPanelData();
            UtilityStreamPanelDataObj = new UtilityStreamPanelData();
            ////-----------------------------------------------------------------------
            ////--- Initialize ViewModel Objects to Avoid Null Reference Exceptions ---
            ////-----------------------------------------------------------------------
            //ProjectViewModelObj = new ProjectViewModel();
            //ProjectUnitsViewModelObj = new ProjectUnitsViewModel();

            //ProfileViewModelObj = new ProfileViewModel();
            //ProcessStreamViewModelObj = new ProcessStreamViewModel();
            //UtilityStreamViewModelObj = new UtilityStreamViewModel();
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

        #region CreateProfileWrapperData(Guid projectId) ... CREATE ... ADD ALL PROFILE DATA
        /// <summary>
        /// Add (CREATE) the Profile Wrapper Data for a Given Project ID.
        /// Wrapper contains Profile Data, Process Stream Data, and Utility Stream Data for a Given Project ID.
        /// </summary>
        /// <param name="projectId">The ID of the project for which to create the profile wrapper data.</param>
        /// <returns>The ID of the profile for which the profile wrapper data was created.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the provided project ID is null.</exception>
        /// <exception cref="ArgumentNullException">Thrown when the add returned profile ID is null.</exception>
        public Guid CreateProfileWrapperData(Guid projectId)
        {
            Guid profileId = Guid.Empty;
            //---------------------------------------------------------------------------------
            //--- Null Guard on User Supplied Project ID to Avoid Null Reference Exceptions ---
            //---------------------------------------------------------------------------------   
            if (projectId == null) throw new ArgumentNullException(
                                         nameof(projectId), "Project ID cannot be null.");
            else ProfileWrapperDtoObj.ProjectId = projectId;
            //--------------------------------------------------------------
            //--- Add Profile Data to DB using PanelData Object          ---
            //--- Returns Profile ID for Foreign Key Relationships in DB ---
            //--------------------------------------------------------------
            profileId = ProfilePanelDataObj.CreateProfileData();

            if (profileId == null) throw new ArgumentNullException(
                             nameof(profileId), "Profile ID is null for ADD Profile Panel data.");

            ProfileWrapperDtoObj.ProfileId = profileId;
            ProfilePanelDataObj.ProfileDtoObj.Id = profileId;
            ProfilePanelDataObj.ProfileDtoObj.ProjectId = projectId;

            //-------------------------------------------------------------------
            //--- Add Process Stream Panel data to DB using PanelData Object  ---
            //--- Returns Profile ID for Foreign Key Relationships in DB      ---
            //--- NOTE: ViewModel Return DTO Objects, and PanelData           ---
            //--- Objects. VIEW objects populate the WRAPPER DTO list Object. ---
            //------------------------------------------------------------------
            ProcessStreamPanelDataObj.ProjectId = projectId;
            profileId = ProcessStreamPanelDataObj.CreateProcessStreamsData();

            if (profileId == null) throw new ArgumentNullException(
                             nameof(profileId), "Profile ID is null for ADD Process Stream Panel data.");

            ProfileWrapperDtoObj.ProfileId = profileId;
            ProfilePanelDataObj.ProfileDtoObj.Id = profileId;
            ProfilePanelDataObj.ProfileDtoObj.ProjectId = projectId;

            //-------------------------------------------------------------------
            //--- Add Utility Stream Panel data to DB using PanelData Object  ---
            //--- Returns Profile ID for Foreign Key Relationships in DB      ---
            //--- NOTE: ViewModel Return DTO Objects, and PanelData           ---
            //--- Objects. VIEW objects populate the WRAPPER DTO list Object. ---
            //------------------------------------------------------------------
            UtilityStreamPanelDataObj.ProjectId = projectId;
            profileId = UtilityStreamPanelDataObj.CreateUtilityStreamsData();

            if (profileId == null) throw new ArgumentNullException(
                             nameof(profileId), "Profile ID is null for ADD Utility Stream Panel data.");

            ProfileWrapperDtoObj.ProfileId = profileId;
            ProfilePanelDataObj.ProfileDtoObj.Id = profileId;
            ProfilePanelDataObj.ProfileDtoObj.ProjectId = projectId;

            return profileId;
        }
        #endregion  // CreateProfileWrapperData(Guid projectId) ... CREATE ... ADD ALL PROFILE DATA

        #region ReadProfileWrapperData(Guid projectId, Guid profileId) ... READ ... GET ALL PROFILE DATA
        /// <summary>
        /// Retrieve (READ) the Profile Wrapper Data for a Given Project & Profile IDs. 
        /// This method will be used to Populate the Profile Wrapper Data Object 
        /// with Data from the DB.
        /// </summary>
        /// <param name="projectId">The ID of the project-related data to READ.</param>
        /// <param name="profileId">The ID of the profile-related data to READ.</param>
        /// <exception cref="ArgumentNullException">Thrown when the provided project ID is null.</exception>
        /// <exception cref="ArgumentNullException">Thrown when the provided profile ID is null.</exception>
        public void ReadProfileWrapperData(Guid projectId, Guid profileId)
        {
            //-----------------------------------------------------
            //--- Null Guard on User Supplied IDs to Avoid Null ---
            //--- References in ViewModel Invocations           ---
            //-----------------------------------------------------   
            if (projectId == null) throw new ArgumentNullException(
                                         nameof(projectId), "Project ID cannot be null.");
            else ProjectId = projectId;
            if (profileId == null) throw new ArgumentNullException(
                                         nameof(profileId), "Profile ID cannot be null.");
            else ProfileId = profileId;
            //----------------------------------------------------------
            //--- READ Project Data from DB using Project ViewModels ---
            //--- READ Profile Data from DB using Profile ViewModels ---
            //--- NOTE: ViewModel Return DTO Objects, and PanelData  ---
            //--- Objects are Populated using the DTO Objects        ---
            //----------------------------------------------------------
            ProjectPanelDataObj.ProjectId = ProjectId;
            ProjectPanelDataObj.ProjectDtoObj = ProjectViewModelObj.GetProjectById(projectId);
            
            ProjectUnitsPanelDataObj.ProjectId = ProjectId;
            ProjectUnitsPanelDataObj.ProjectUnitsDtoObj = ProjectUnitsViewModelObj.GetProjectUnitsByProjectId(projectId);

            ProfilePanelDataObj.ProjectId = ProjectId;
            ProfilePanelDataObj.ProfileId = ProfileId;
            ProfilePanelDataObj.ProfileDtoObj = ProfileViewModelObj.GetProfileById(profileId);

            ProcessStreamPanelDataObj.ProjectId = ProjectId;
            ProcessStreamPanelDataObj.ProfileId = ProfileId;
            ProcessStreamPanelDataObj.ProcessStreamDtoList = ProcessStreamViewModelObj.GetProcessStreamsByProfileId(profileId);

            UtilityStreamPanelDataObj.ProjectId = ProjectId;
            UtilityStreamPanelDataObj.ProfileId = ProfileId;
            UtilityStreamPanelDataObj.UtilityStreamDtoList = UtilityStreamViewModelObj.GetUtilityStreamsByProfileId(profileId);
        }
        #endregion  // ReadProfileWrapperData(Guid projectId, Guid profileId) ... READ ... GET ALL PROFILE DATA

        #region UpdateProfileWrapperData(Guid projectId, Guid profileId) ... UPDATE ... UPDATE ALL PROFILE DATA
        /// <summary>
        /// Scrap Screen data and Populate the Profile PanelData Objects
        /// then use this method to UPDATE ALL the Profile Wrapper Data for a Given Project & Profile IDs.
        /// </summary>
        /// <param name="projectId">The ID of the project-related data to UPDATE.</param>
        /// <param name="profileId">The ID of the profile-related data to UPDATE.</param>
        /// <exception cref="ArgumentNullException">Thrown when the provided project ID is null.</exception>
        /// <exception cref="ArgumentNullException">Thrown when the provided profile ID is null.</exception>
        public void UpdateProfileWrapperData(Guid projectId, Guid profileId)
        {
            //-----------------------------------------------------
            //--- Null Guard on User Supplied IDs to Avoid Null ---
            //--- References in ViewModel Invocations           ---
            //-----------------------------------------------------   
            if (projectId == null) throw new ArgumentNullException(
                                         nameof(projectId), "Project ID cannot be null.");
            else ProjectId = projectId;
            if (profileId == null) throw new ArgumentNullException(
                                         nameof(profileId), "Profile ID cannot be null.");
            else ProfileId = profileId;
            //----------------------------------------------------------
            //--- UPDATE Profile Data from DB using Profile ViewModels ---
            //--- NOTE: ViewModel Return DTO Objects, and PanelData  ---
            //--- Objects are Populated using the DTO Objects        ---
            //----------------------------------------------------------
            ProfilePanelDataObj.ProjectId = ProjectId;
            ProfilePanelDataObj.ProfileId = ProfileId;
            ProfileViewModelObj.UpdateProfile(ProfilePanelDataObj.ProfileDtoObj);

            ProcessStreamPanelDataObj.ProjectId = ProjectId;
            ProcessStreamPanelDataObj.ProfileId = ProfileId;
            ProcessStreamViewModelObj.UpdateProcessStreams(ProcessStreamPanelDataObj.ProcessStreamDtoList);

            UtilityStreamPanelDataObj.ProjectId = ProjectId;
            UtilityStreamPanelDataObj.ProfileId = ProfileId;
            UtilityStreamViewModelObj.UpdateUtilityStreams(UtilityStreamPanelDataObj.UtilityStreamDtoList);
        }
        #endregion  // UpdateProfileWrapperData(Guid projectId) ... UPDATE ... UPDATE ALL PROFILE DATA

        #region DeleteProfileWrapperData(Guid profileId) ... DELETE ... DELETE ALL PROFILE DATA
        /// <summary>
        /// Use the specified Profile ID and ViewModel object 
        /// to DELETE ALL the Profile Subpanel data in the HENSTUDIO DB.
        /// Cascading Delete is Controlled in SQL, so Deleting the Profile 
        /// will also Delete the Process Stream and Utility Stream data 
        /// for the Given Profile ID.
        /// </summary>
        /// <param name="profileId">The ID of the profile-related data to DELETE.</param>
        public void DeleteProfileWrapperData(Guid profileId)
        {
            //------------------------------------------------------------
            //--- Null Guard on User Supplied Profile ID to Avoid Null ---
            //--- References in ViewModel Invocations                  ---
            //------------------------------------------------------------   
            if (profileId == null) throw new ArgumentNullException(
                                         nameof(profileId), "Profile ID cannot be null.");
            else ProfileId = profileId;
            //----------------------------------------------------
            //--- Use ViewModel to DELETE Data from DB         ---
            //--- NOTE: Cascading Delete is controlled in SQL. ---
            //----------------------------------------------------
            ProfileViewModelObj.DeleteProfile(ProfileId);
        }
        #endregion  // DeleteProfileWrapperData(Guid profileId) ... DELETE ... DELETE ALL PROFILE DATA

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
                 nameof(profileId), "Profile ID is null for READ Profile Panel data.");

            if (string.IsNullOrEmpty(newName)) throw new ArgumentException(
                 nameof(newName), "New profile name is null or empty for RENAME Profile Panel data.");

            //------------------------------------------------
            //--- Update Project Wrapper  Panel Project ID ---
            //------------------------------------------------
            ProfileWrapperDtoObj.ProfileId = profileId;

            //--------------------------------------------
            //--- Return the Profile DTO updated in DB ---
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
