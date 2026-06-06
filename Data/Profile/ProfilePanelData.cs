#region HEADER
//#####################################################################################################################
//#####################################  P r o f i l e P a n e l D a t a . c s  #######################################
//#####################################################################################################################
//  FILENAME:  ProfilePanelData.cs
//  NAMESPACE: HenStudio.Data.Profile
//  CLASS(S):  ProfilePanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Profile Panel Data object - data needed for Profile Panel.
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
//    01/01/26 .. pg .. Version 4.0
//#####################################################################################################################
//#####################################################################################################################
//#####################################################################################################################
#endregion      // HEADER

#region REFERENCES
using HenModel.Dto.Hen.Plots;
using HenModel.Dto.Profile;
using HenModel.Dto.Project;
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

using HenViewModel.Profile;
using HenViewModel.Profile.Streams;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Profile
namespace HenStudio.Data.Profile
{
    #region public class ProfilePanelData
    public class ProfilePanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Profile";
        const string CLASS = "ProfilePanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public Guid ProjectId { get; set; } 
        public Guid ProfileId { get; set; } 

        public ProfileDto ProfileDtoObj { get; set; }  // Profile DTO Object ... EXTERN Units

        #region VIEW MODEL Object
        public ProfileViewModel ProfileViewModelObj { get; set; }
        #endregion  // VIEW MODEL Objects

        #endregion  // PROPERTIES

        #region INITIALIZE PANEL DATA
        /// <summary>
        /// Initializes the properties of the ProfilePanelData object to their default values.
        /// </summary>
        private void InitializePanelData()
        {
            ProjectId = new Guid(); // Project Unique Identifier
            ProfileId = new Guid(); // Profile Unique Identifier
            ProfileDtoObj = new ProfileDto(); // Profile DTO Object ... EXTERN Units
            ProfileViewModelObj = new ProfileViewModel(); // ViewModel Object
        }
        #endregion  // INITIALIZE PANEL DATA

        #region CTOR
        /// <summary>
        /// Default Constructor for ProfilePanelData Class. 
        /// Initializes the properties of the ProfilePanelData object to their 
        /// default values by calling the InitializePanelData method.
        /// </summary>
        public ProfilePanelData()
        {
            InitializePanelData();
        }
        #endregion  // CTOR

        #region CRUD METHODS

        #region CREATE PROFILE DATA METHOD
        /// <summary>
        /// Creates a new profile using the provided ProfileDto object and returns the
        /// ID of the newly created profile.
        /// </summary>
        /// <param name="profileDtoObj">The ProfileDto object containing the profile data.</param>
        /// <returns>The ID of the newly created profile.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the profileDtoObj is null.</exception>
        public Guid CreateProfileData(ProfileDto profileDtoObj)
        {
            if (profileDtoObj == null) throw new ArgumentNullException(
                            nameof(profileDtoObj),
                            "ProfileDtoObj is null for Create Profile Panel data.");            
            //-------------------------------------------------------------------------------------
            //--- Add Profile data and get Profile ID associated with the newly created profile ---
            //-------------------------------------------------------------------------------------
            ProfileId = ProfileViewModelObj.AddProfile(profileDtoObj);

            if (ProfileId == null) throw new ArgumentNullException(
                             nameof(ProfileId),
                             "Profile ID is null for Create Profile Panel data.");
            //------------------------------------------------------------------------------
            //--- Assign the returned Profile ID to the ProfileId property and return it ---
            //------------------------------------------------------------------------------
            ProfileDtoObj = profileDtoObj;
            ProfileDtoObj.Id = ProfileId;
            return ProfileId;
        }
        #endregion  // CREATE PROFILE DATA METHOD

        #region READ PROFILE DATA METHOD
        /// <summary>
        /// Reads the profile data for the specified profile ID 
        /// and populates the ProfileDtoObj property with the retrieved data.
        /// </summary>
        /// <param name="profileId">The ID of the profile to read.</param>
        /// <returns>Profile DTO object</returns>
        /// <exception cref="ArgumentNullException">Thrown when the profile ID is null.</exception>
        public ProfileDto ReadProfileData(Guid profileId)
        {
            if (profileId == null) throw new ArgumentNullException(
                             nameof(profileId), 
                             "Profile ID is null for READ Profile Panel data.");
            //------------------------------------------------------------
            //--- Get Profile data for the specified profile ID and    ---     
            //--- assign it to the ProfileDtoObj property              ---
            //--- Also assign the profile ID to the ProfileId property ---
            //------------------------------------------------------------
            ProfileId = profileId;
            ProfileDtoObj = ProfileViewModelObj.GetProfileById(profileId);

            if (ProfileDtoObj == null) throw new ArgumentNullException(
                                 nameof(ProfileDtoObj), 
                                 "Profile DTO is null for READ Profile Panel data.");
            //----------------------------------------------------------------
            //--- Assign the returned Profile ID to the ProfileId property ---
            //----------------------------------------------------------------
            ProfileDtoObj.Id = ProfileId;
            //--------------------------
            //--- Return Profile DTO ---
            //--------------------------
            return ProfileDtoObj;
        }
        #endregion  // READ PROFILE DATA METHOD

        #region UPDATE PROFILE DATA METHOD
        /// <summary>
        /// Updates the profile data using the provided ProfileDto object 
        /// and returns the updated ProfileDto object.
        /// </summary>
        /// <param name="profileDtoObj">The ProfileDto object containing 
        /// the updated profile data.</param>
        /// <returns>The updated ProfileDto object.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the profile DTO or its ID is null.</exception>
        public ProfileDto UpdateProfileData(ProfileDto profileDtoObj)
        {
            if (profileDtoObj == null) throw new ArgumentNullException(
                                 nameof(profileDtoObj),
                                 "Profile DTO is null for UPDATE Profile Panel data.");


            if (profileDtoObj.Id == null) throw new ArgumentNullException(
                                    nameof(profileDtoObj),
                                    "Profile DTO ID is null for UPDATE Profile Panel data.");

            //-----------------------------------------------------------
            //--- Update the ProfileId property with the ID from the  ---
            //--- provided Profile DTO object                         ---
            //-----------------------------------------------------------
            ProfileId = profileDtoObj.Id;
            ProfileDtoObj = profileDtoObj;
            //-----------------------------------------------------------
            //--- Update the profile data in the database using the   ---
            //--- ProfileViewModelObj's UpdateProfile method          ---
            //-----------------------------------------------------------
            ProfileViewModelObj.UpdateProfile(profileDtoObj);
            //---------------------------------------------
            //--- Return the updated Profile DTO object ---
            //---------------------------------------------
            return ProfileDtoObj;
        }
        #endregion  // UPDATE PROFILE DATA METHOD

        #region DELETE PROFILE DATA METHOD
        /// <summary>
        /// Deletes the profile data for the specified profile ID.
        /// The DeleteProfile method is expected to handle the 
        /// deletion of the profile data from the database 
        /// [CASCADE DELETE].
        /// </summary>
        /// <param name="profileId">The ID of the profile to delete.</param>
        /// <exception cref="ArgumentNullException">Thrown when the profile ID is null.</exception>
        public void DeleteProfileData(Guid profileId)
        {
            if (profileId == null) throw new ArgumentNullException(
                             nameof(profileId), 
                             "Profile ID is null for DELETE Profile Panel data.");
            //------------------------------------------------------
            //--- Delete the profile data in the database using  ---
            //--- the ProfileViewModelObj's DeleteProfile method ---
            //--- Also assign the profile ID to the ProfileId    ---
            //--- property for reference                         ---
            //------------------------------------------------------
            ProfileId = profileId;
            ProfileViewModelObj.DeleteProfile(profileId);
        }
        #endregion  // DELETE PROFILE DATA METHOD

        #endregion  // CRUD METHODS

        #region RENAME PROFILE METHOD
        /// <summary>
        /// Rename Profile Name and Description 
        /// data values in the Profile table in the DB
        /// </summary>
        /// <param name="profileId">Profile ID of profile to update</param>
        /// <param name="newName">New Profile Name</param>
        /// <param name="newDescription">New Profile Description</param>
        /// <returns>Profile DTO object containing new Name and Description</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public ProfileDto RenameProfile(Guid profileId,
                                        string newName,
                                        string newDescription)
        {
            if (profileId == null) throw new ArgumentNullException(
                 nameof(profileId), "Profile ID is null for READ Profile Panel data.");

            if (string.IsNullOrEmpty(newName)) throw new ArgumentException(
                 nameof(newName), "New profile name is null or empty for RENAME Profile Panel data.");
            //--------------------------------
            //--- Get Existing Profile DTO ---
            //--------------------------------
            ProfileDto existingProfileDto = ProfileViewModelObj.GetProfileById(profileId);

            if (existingProfileDto == null) throw new ArgumentNullException(
                             nameof(existingProfileDto),
                             "Profile DTO is null for RENAME [UPDATE] Profile Panel data.");
            //---------------------------------------
            //--- Update Profile Panel Profile ID ---
            //---------------------------------------
            ProfileId = profileId;
            //---------------------------------------------------------
            //--- Update Profile DTO with new name, and description ---
            //---------------------------------------------------------
            ProfileDtoObj = existingProfileDto;
            ProfileDtoObj.Id = profileId;
            ProfileDtoObj.Name = newName;
            ProfileDtoObj.Description = newDescription;
            //--------------------------------------------------------
            //--- Update DB with new profile name, and description ---
            //--------------------------------------------------------
            ProfileViewModelObj.UpdateProfile(ProfileDtoObj);
            return ProfileDtoObj;
        }
        #endregion  // RENAME PROFILE METHOD
    }
    #endregion      // public class ProfilePanelData
}
#endregion  // namespace HenStudio.Data.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
