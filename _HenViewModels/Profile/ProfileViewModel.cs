#region HEADER
//#####################################################################################################################
//######################################  P r o f i l e V i e w M o d e l . c s  ######################################
//#####################################################################################################################
//  FILENAME:  ProfileViewModel.cs
//  NAMESPACE: HenViewModel.Profile
//  CLASS(S):  ProfileViewModel
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the Profile top-level DTO.
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
using HenGlobal;

using HenModel.Connection;
using HenModel.Dto.Profile;
using HenModel.Dto.Project;
using HenModel.Dto.Project.CostParameters;
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;
using HenModel.RepoImplementations.Profile;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenViewModel.Profile
namespace HenViewModel.Profile
{
    #region public class ProfileViewModel
    /// <summary>
    /// Profile view model class.
    /// </summary>
    public class ProfileViewModel : ViewModelBase
    {
        #region PROPERTIES
        public ProfileRepo ProfileRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public ProfileViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var profileRepoObj = new ProfileRepo(connFactoryObj);

            ProfileRepoObj = profileRepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // CTOR

        #region PRIVATE DTO CONVERSION METHODS

        #region ConvertToExternalDto(ProfileDto internalDto)
        /// <summary>
        /// Converts a Profile DTO from INTERNAL units to EXTERNAL units.
        /// </summary>
        /// <param name="internalDto">The Profile DTO in INTERNAL units.</param>
        /// <returns>A <see cref="ProfileDto"/> DTO in EXTERNAL units.</returns>
        private ProfileDto ConvertToExternalDto(ProfileDto internalDto)
        {
            //-------------------------- Null DTO Guard ----------------------------
            //--- If the user provided DTO is null,                              ---
            //--- Then return null to indicate that there is nothing to convert. ---
            //--- This prevents potential null reference exceptions when trying  ---
            //--- to access properties of a null object.                         ---
            //----------------------------------------------------------------------
            if (internalDto == null)
            {
                return null;
            }
            //------------------------------ Create EXTERNAL DTO -----------------------------------
            //--- Create a new DTO object to hold the converted values in EXTERNAL units.        ---
            //--- This object will be populated with the converted values from the INTERNAL DTO. ---
            //--------------------------------------------------------------------------------------
            ProfileDto externalDto = new ProfileDto();
            //---------------------------------------------------------
            //--- Convert INTERNAL DTO Fields to EXTERNAL DTO Units ---
            //---------------------------------------------------------
            externalDto.Id = internalDto.Id;
            externalDto.ProjectId = internalDto.ProjectId;

            externalDto.Name        = internalDto.Name;
            externalDto.Description = internalDto.Description;
            //--------------------------------------------------
            //--- Return the EXTERNAL DTO in EXTERNAL units. ---
            //--------------------------------------------------
            return externalDto;
        }
        #endregion  // ConvertToExternalDto(ProfileDto internalDto)

        #region ConvertToInternalDto(ProfileDto externalDto)
        /// <summary>
        /// Converts a Profile DTO from EXTERNAL units to INTERNAL units.
        /// </summary>
        /// <param name="externalDto">The Profile DTO in EXTERNAL units.</param>
        /// <returns>A <see cref="ProfileDto"/> DTO in INTERNAL units.</returns>
        private ProfileDto ConvertToInternalDto(ProfileDto externalDto)
        {
            //-------------------------- Null DTO Guard ----------------------------
            //--- If the user provided DTO is null,                              ---
            //--- Then return null to indicate that there is nothing to convert. ---
            //--- This prevents potential null reference exceptions when trying  ---
            //--- to access properties of a null object.                         ---
            //----------------------------------------------------------------------
            if (externalDto == null)
            {
                return null;
            }
            //------------------------------ Create INTERNAL DTO -----------------------------------
            //--- Create a new DTO object to hold the converted values in INTERNAL units.        ---
            //--- This object will be populated with the converted values from the EXTERNAL DTO. ---
            //--------------------------------------------------------------------------------------
            ProfileDto internalDto = new ProfileDto();
            //-------------------------------------------------
            //--- Convert EXTERNAL Fields to INTERNAL Units ---
            //-------------------------------------------------
            internalDto.Id = externalDto.Id;
            internalDto.ProjectId = externalDto.ProjectId;

            internalDto.Name = externalDto.Name;
            internalDto.Description = externalDto.Description;
            //--------------------------------------------------
            //--- Return the INTERNAL DTO in INTERNAL units. ---
            //--------------------------------------------------
            return internalDto;
        }
        #endregion  // ConvertToInternalDto(CostMetadataDto externalDto)

        #endregion  // PRIVATE DTO CONVERSION METHODS

        #region PROFILE CRUD METHODS

        #region AddProfile(ProfileDto profileDto) ... CREATE
        /// <summary>
        /// Adds (CREATE)a new profile to the database using the specified profile data transfer object.
        /// </summary>
        /// <param name="externalProfileDto">The profile data to add. Cannot be null.</param>
        /// <returns>A GUID representing the unique identifier of the newly added profile.</returns>
        public Guid AddProfile(ProfileDto externalProfileDto)
        {
            Guid profileId = new Guid();
            try
            {
                //----------------------------------------------------------------
                //--- Profile Dto [INTERNAL Units] to be Added to the Database ---
                //----------------------------------------------------------------
                ProfileDto internalProfileDto = new ProfileDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalProfileDto = ConvertToInternalDto(externalProfileDto);
                //------------------------------------------------------------------------------
                //--- Add INTERNAL Profile Dto to the Database using the ProfileRepo Object  ---
                //--- Returns the Profile ID (PK) from the Profile Table database addition   ---
                //------------------------------------------------------------------------------
                profileId = ProfileRepoObj.AddProfile(internalProfileDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
            }
            //---------------------------------------------------------------------------------------------
            //--- Return the Profile ID (PK) from the Profile Table database addition                   ---
            //--- This ID can be used by the caller for reference or further operations.                ---
            //--- If the addition was successful, this will be the new profile's unique identifier.     ---
            //--- If an error occurred during the addition, this will return an empty GUID (all zeros). ---
            //---------------------------------------------------------------------------------------------
            return profileId;
        }
        #endregion  // AddProfile(ProfileDto profileDto) ... CREATE

        #region GetProfiles() ... READ
        /// <summary>
        /// Retrieves (READ) a list of all Profiles.
        /// </summary>
        /// <returns>A list of <see cref="ProfileDto"/> objects representing the available profiles, 
        /// or an empty list if no profiles found.</returns>
        public IList<ProfileDto> GetProfiles()
        {
            //---------------------------------------------------------------
            //--- List to Hold Profiles to be Returned to the Caller      ---
            //--- This List will Contain Profile Dtos with EXTERNAL Units ---
            //---------------------------------------------------------------
            List<ProfileDto> externalProfiles = new List<ProfileDto>();
            try
            {
                //-----------------------------------------------------------------------------
                //--- Use ProfileRepo Object to Retrieve List of Profiles from the Database ---
                //--- Retrieved List of Profile Dtos [INTERNAL Units] from the Database     ---
                //-----------------------------------------------------------------------------
                foreach (ProfileDto internalProfile in ProfileRepoObj.GetProfiles())
                {
                    ProfileDto externalProfile = new ProfileDto();
                    //-------------------------------------------------
                    //--- Convert INTERNAL Fields to EXTERNAL Units ---
                    //-------------------------------------------------
                    externalProfile = ConvertToExternalDto(internalProfile);
                    //-------------------------------------------------------------------------------------------
                    //--- Add the EXTERNAL Profile Dto to the List of Profiles to be Returned to the Caller   ---
                    //--- This List will contain all Profiles in EXTERNAL units, which is the expected format ---
                    //--- for the caller.                                                                     ---
                    //-------------------------------------------------------------------------------------------
                    externalProfiles.Add(externalProfile);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
                return null;
            }
            //------------------------------------------------------
            //--- Returns the List of Profiles in EXTERNAL Units ---
            //------------------------------------------------------
            return externalProfiles;
        }
        #endregion  // GetProfiles() ... READ

        #region GetProfilesByProjectId(Guid projectId) ... READ
        /// <summary>
        /// Retrieves (READ) a list of all Profiles associated with the specified project identifier.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project whose profiles are to be retrieved.</param>
        /// <returns>A list of <see cref="ProfileDto"/> objects representing the matching profiles, 
        /// or an empty list if no profiles found.
        /// </returns>
        public IList<ProfileDto> GetProfilesByProjectId(Guid projectId)
        {
            //---------------------- Guard against empty or null projectId ------------------------
            //--- If the provided projectId is empty, return null to indicate that there is no  ---
            //--- valid profiles to retrieve.                                                   ---
            //--- This prevents unnecessary database calls and potential errors when trying to  ---
            //--- retrieve profiles with an invalid identifier.                                 ---
            //--- An empty projectId is not valid for retrieval, so we return null to indicate  ---
            //---that the profiles cannot be found.                                             ---
            //-------------------------------------------------------------------------------------
            if (projectId == Guid.Empty)
            {
                return null; // Return null if the projectId is empty
            }
            //---------------------------------------------------------------
            //--- List to Hold Projects to be Returned to the Caller      ---
            //--- This List will Contain Profile Dtos with EXTERNAL Units ---
            //---------------------------------------------------------------
            List<ProfileDto> externalProfiles = new List<ProfileDto>();
            try
            {
                //-----------------------------------------------------------------------------
                //--- Use ProfileRepo Object to Retrieve List of Profiles from the Database ---
                //--- Retrieved List of Profile Dtos [INTERNAL Units] from the Database     ---
                //-----------------------------------------------------------------------------
                foreach (ProfileDto internalProfileDto in ProfileRepoObj.GetProfilesByProjectId(projectId))
                {
                    //-------------------------------------------------
                    //--- Convert INTERNAL Fields to EXTERNAL Units ---
                    //-------------------------------------------------
                    ProfileDto externalProfileDto = ConvertToExternalDto(internalProfileDto);
                    //---------------------------------------------------------------------------
                    //---Add EXTERNAL Profile DTO to the List of Profiles Matching Project ID ---
                    //---------------------------------------------------------------------------
                    externalProfiles.Add(externalProfileDto);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project: {ex.Message}");
                return null; // Return null if an error occurs
            }
            //-------------------------------------------------------------------------
            //--- Return the List of Profiles Matching the Project ID to the Caller ---
            //--- This List will contain Profile Dtos in EXTERNAL units, which is   ---
            //--  the expected format for the caller.                               ---
            //--- If no profiles are found for the given projectId,                 ---
            //--- this will return an empty list.                                   ---
            //--- If an error occurs during retrieval, this will return null.       ---
            //-------------------------------------------------------------------------
            return externalProfiles;
        }
        #endregion  // GetProfilesByProjectId(Guid projectId) ... READ

        #region GetProfileById(Guid profileId) ... READ
        /// <summary>
        /// Retrieves (READ) the Profile Dto associated with the specified unique identifier.
        /// </summary>
        /// <param name="profileId">The unique identifier of the Profile to retrieve.</param>
        /// <returns>A <see cref="ProfileDto"/> representing the Profile with the specified identifier. Returns null if no Profile is found.</returns>
        public ProfileDto GetProfileById(Guid profileId)
        {
            //---------------------- Guard against empty or null profileId ------------------------
            //--- If the provided profileId is empty, return null to indicate that there is no  ---
            //--- valid profiles to retrieve.                                                   ---
            //--- This prevents unnecessary database calls and potential errors when trying to  ---
            //--- retrieve profiles with an invalid identifier.                                 ---
            //--- An empty profileId is not valid for retrieval, so we return null to indicate  ---
            //---that the profiles cannot be found.                                             ---
            //-------------------------------------------------------------------------------------
            if (profileId == Guid.Empty)
            {
                return null; // Return null if the profileId is empty
            }
            //----------------------------------------------------
            //--- Profile Dto to be Returned to the Caller     ---
            //--- This Profile Dto will Contain EXTERNAL Units ---
            //----------------------------------------------------
            ProfileDto externalProfileDto = new ProfileDto();
            try
            {
                //-----------------------------------------------------------
                //--- Retrieve Profile Dto from the Database              ---
                //--- The retrieved Profile Dto is in INTERNAL Units,     ---
                //--- database access performed by the ProfileRepo Object ---
                //-----------------------------------------------------------
                ProfileDto internalProfileDto = ProfileRepoObj.GetProfileById(profileId);
                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalProfileDto = ConvertToExternalDto(internalProfileDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
                return null;
            }
            //-------------------------------------------------------------------------------
            //--- Return the Profile Dto in EXTERNAL Units to the Caller                  ---
            //--- This Profile Dto will contain the profile information in the expected   ---
            //--- format for the caller.                                                  ---
            //--- If no profile is found with the given profileId, this will return null. ---
            //--- If an error occurs during retrieval, this will return null.             ---
            //-------------------------------------------------------------------------------
            return externalProfileDto;
        }
        #endregion  // GetProfileById(Guid profileId) ... READ

        #region GetProfileByName(Guid projectId, string profileName) ... READ
        /// <summary>
        /// Retrieves (READ) the Profile Dto associated with the specified project identifier and profile name.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project that owns the profile.</param>
        /// <param name="profileName">The name of the profile to retrieve. Cannot be null or empty.</param>
        /// <returns>A <see cref="ProfileDto"/> representing the Profile with the specified project identifier and name. 
        /// Returns null if no Profile is found.</returns>
        public ProfileDto GetProfileByName(Guid projectId, string profileName)
        {
            //----------------------------------------------------
            //--- Profile Dto to be Returned to the Caller     ---
            //--- This Profile Dto will Contain EXTERNAL Units ---
            //----------------------------------------------------
            ProfileDto externalProfileDto = new ProfileDto();
            try
            {
                //-----------------------------------------------------------
                //--- Retrieve Profile Dto from the Database              ---
                //--- The retrieved Profile Dto is in INTERNAL Units,     ---
                //--- database access performed by the ProfileRepo Object ---
                //-----------------------------------------------------------
                ProfileDto internalProfileDto = 
                        ProfileRepoObj.GetProfileByName(projectId, profileName);
                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalProfileDto = ConvertToExternalDto(internalProfileDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
                return null;
            }
            //-------------------------------------------------------------------------------
            //--- Return the Profile Dto in EXTERNAL Units to the Caller                  ---
            //--- This Profile Dto will contain the profile information in the expected   ---
            //--- format for the caller.                                                  ---
            //--- If no profile is found with the given profileId, this will return null. ---
            //--- If an error occurs during retrieval, this will return null.             ---
            //-------------------------------------------------------------------------------
            return externalProfileDto;
        }
        #endregion  // GetProfileByName(Guid projectId, string profileName) ... READ

        #region UpdateProfile(ProfileDto profileDto) ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing profile in the database using the 
        /// specified profile data transfer object.
        /// </summary>
        /// <param name="externalProfileDto">The profile data transfer object 
        /// containing updated profile information in EXTERNAL Units. Cannot be null.
        /// </param>
        public void UpdateProfile(ProfileDto externalProfileDto)
        {
            try
            {
                //----------------------------------------------------------------
                //--- Profile Dto [INTERNAL Units] to be Added to the Database ---
                //----------------------------------------------------------------
                ProfileDto internalProfileDto = new ProfileDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalProfileDto = ConvertToInternalDto(externalProfileDto);
                //--------------------------------------------------------------------------------
                //--- UPDATE INTERNAL Profile Dto to the Database using the ProfileRepo Object ---
                //--------------------------------------------------------------------------------
                ProfileRepoObj.UpdateProfile(internalProfileDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
            }
        }
        #endregion  // UpdateProfile(ProfileDto profileDto) ... UPDATE

        #region DeleteProfile(Guid profileId)
        /// <summary>
        /// Deletes the profile with the specified unique identifier.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile to delete.</param>
        public void DeleteProfile(Guid profileId)
        {
            try
            {
                //---------------------------------------------------------------------
                //--- DELETE Profile from the Database using the ProfileRepo Object ---
                //---------------------------------------------------------------------
                ProfileRepoObj.DeleteProfile(profileId);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error deleting profile: {ex.Message}");
            }
        }
        #endregion  // DeleteProfile(Guid profileId)

        #endregion  // PROFILE CRUD METHODS

    }
    #endregion      // public class ProfileViewModel
}
#endregion      // namespace HenViewModel.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
