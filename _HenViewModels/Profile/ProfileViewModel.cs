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
using HenModel.RepoImplementations.Profile;
using HenModel.Dto.Profile;

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

        #region GetProfiles()
        /// <summary>
        /// Retrieves a list of all Profiles.
        /// </summary>
        /// <returns>A list of <see cref="ProfileDto"/> objects representing the available profiles, or an empty list if no profiles found.</returns>
        public IList<ProfileDto> GetProfiles()
        {
            try
            {
                return ProfileRepoObj.GetProfiles();
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetProfiles()

        #region GetProfilesByProjectId(Guid projectId)
        /// <summary>
        /// Retrieves a list of all Profiles associated with the specified project identifier.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project whose profiles are to be retrieved.</param>
        /// <returns>A list of <see cref="ProfileDto"/> objects representing the matching profiles, or an empty list if no profiles found.</returns>
        public IList<ProfileDto> GetProfilesByProjectId(Guid projectId)
        {
            try
            {
                return ProfileRepoObj.GetProfilesByProjectId(projectId);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetProfilesByProjectId(Guid projectId)

        #region GetProfileById(Guid profileId)
        /// <summary>
        /// Retrieves the Profile Dto associated with the specified unique identifier.
        /// </summary>
        /// <param name="profileId">The unique identifier of the Profile to retrieve.</param>
        /// <returns>A <see cref="ProfileDto"/> representing the Profile with the specified identifier. Returns null if no Profile is found.</returns>
        public ProfileDto GetProfileById(Guid profileId)
        {
            try
            {
                return ProfileRepoObj.GetProfileById(profileId);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetProfileById(Guid profileId)

        #region GetProfileByName(Guid projectId, string profileName)
        /// <summary>
        /// Retrieves a Profile by its project identifier and name and returns its details as a data transfer object.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project that owns the profile.</param>
        /// <param name="profileName">The name of the profile to retrieve. Cannot be null or empty.</param>
        /// <returns>A <see cref="ProfileDto"/> containing the profile's details if found; otherwise, null.</returns>
        public ProfileDto GetProfileByName(Guid projectId, string profileName)
        {
            try
            {
                return ProfileRepoObj.GetProfileByName(projectId, profileName);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetProfileByName(Guid projectId, string profileName)

        #region AddProfile(ProfileDto profileDto)
        /// <summary>
        /// Adds a new profile to the database using the specified profile data transfer object.
        /// </summary>
        /// <param name="profileDto">The profile data to add. Cannot be null.</param>
        /// <returns>A GUID representing the unique identifier of the newly added profile.</returns>
        public Guid AddProfile(ProfileDto profileDto)
        {
            Guid profileId = new Guid();
            try
            {
                profileId = ProfileRepoObj.AddProfile(profileDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
            }
            return profileId;
        }
        #endregion  // AddProfile(ProfileDto profileDto)

        #region UpdateProfile(ProfileDto profileDto)
        /// <summary>
        /// Updates an existing profile in the database using the specified profile data transfer object.
        /// </summary>
        /// <param name="profileDto">The profile data transfer object containing updated profile information. Cannot be null.</param>
        public void UpdateProfile(ProfileDto profileDto)
        {
            try
            {
                ProfileRepoObj.UpdateProfile(profileDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
            }
        }
        #endregion  // UpdateProfile(ProfileDto profileDto)

        #region DeleteProfile(Guid profileId)
        /// <summary>
        /// Deletes the profile with the specified unique identifier.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile to delete.</param>
        public void DeleteProfile(Guid profileId)
        {
            try
            {
                ProfileRepoObj.DeleteProfile(profileId);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
            }
        }
        #endregion  // DeleteProfile(Guid profileId)

    }
    #endregion      // public class ProfileViewModel
}
#endregion      // namespace HenViewModel.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
