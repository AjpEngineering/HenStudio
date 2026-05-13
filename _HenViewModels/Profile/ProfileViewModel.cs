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
                internalProfileDto.Id         = externalProfileDto.Id;
                internalProfileDto.ProjectId  = externalProfileDto.ProjectId;

                internalProfileDto.Name        = externalProfileDto.Name;
                internalProfileDto.Description = externalProfileDto.Description;
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
                    externalProfile.Id         = internalProfile.Id;
                    externalProfile.ProjectId  = internalProfile.ProjectId;

                    externalProfile.Name        = internalProfile.Name;
                    externalProfile.Description = internalProfile.Description;

                    externalProfiles.Add(externalProfile);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
                return null;
            }

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
                foreach (ProfileDto internalProfile in ProfileRepoObj.GetProfiles())
                {
                    ProfileDto externalProfile = new ProfileDto();
                    //-------------------------------------------------
                    //--- Convert INTERNAL Fields to EXTERNAL Units ---
                    //-------------------------------------------------
                    externalProfile.Id         = internalProfile.Id;
                    externalProfile.ProjectId  = internalProfile.ProjectId;

                    externalProfile.Name        = internalProfile.Name;
                    externalProfile.Description = internalProfile.Description;

                    externalProfiles.Add(externalProfile);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project: {ex.Message}");
                return null; // Return null if an error occurs
            }
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
            //----------------------------------------------------
            //--- Profile Dto to be Returned to the Caller     ---
            //--- This Profile Dto will Contain EXTERNAL Units ---
            //----------------------------------------------------
            ProfileDto externalProfile = new ProfileDto();
            try
            {
                //-----------------------------------------------------------
                //--- Retrieve Profile Dto from the Database              ---
                //--- The retrieved Profile Dto is in INTERNAL Units,     ---
                //--- database access performed by the ProfileRepo Object ---
                //-----------------------------------------------------------
                ProfileDto internalProfile = ProfileRepoObj.GetProfileById(profileId);

                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalProfile.Id          = internalProfile.Id;
                externalProfile.ProjectId   = internalProfile.ProjectId;

                externalProfile.Name        = internalProfile.Name;
                externalProfile.Description = internalProfile.Description;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
                return null;
            }

            return externalProfile;
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
            ProfileDto externalProfile = new ProfileDto();
            try
            {
                //-----------------------------------------------------------
                //--- Retrieve Profile Dto from the Database              ---
                //--- The retrieved Profile Dto is in INTERNAL Units,     ---
                //--- database access performed by the ProfileRepo Object ---
                //-----------------------------------------------------------
                ProfileDto internalProfile = ProfileRepoObj.GetProfileByName(projectId, profileName);

                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalProfile.Id          = internalProfile.Id;
                externalProfile.ProjectId   = internalProfile.ProjectId;

                externalProfile.Name        = internalProfile.Name;
                externalProfile.Description = internalProfile.Description;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
                return null;
            }

            return externalProfile;
        }
        #endregion  // GetProfileByName(Guid projectId, string profileName) ... READ

        #region UpdateProfile(ProfileDto profileDto) ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing profile in the database using the 
        /// specified profile data transfer object.
        /// </summary>
        /// <param name="externalProfileDto">The profile data transfer object 
        /// containing updated profile information. Cannot be null.
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
                internalProfileDto.Id          = externalProfileDto.Id;
                internalProfileDto.ProjectId   = externalProfileDto.ProjectId;

                internalProfileDto.Name        = externalProfileDto.Name;
                internalProfileDto.Description = externalProfileDto.Description;
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
