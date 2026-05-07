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
using HenModel.Dto.Profile;

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
    public class ProfilePanelData : IProfilePanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Profile";
        const string CLASS = "ProfilePanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public ProfileDto ProfileDtoObj { get; set; }
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Initializes a new instance of the ProfilePanelData class with default values for all properties.
        /// </summary>
        /// <remarks>All string properties are initialized to empty strings, date properties are set to
        /// the current date and time, and the ProfileDtoObj property is initialized with a new ProfileDto instance.
        /// This constructor ensures that the object is in a valid default state upon creation.</remarks>
        public ProfilePanelData()
        {
            ProfileDtoObj = new ProfileDto();
            Id = new Guid();
            ProjectId = new Guid();
            Name = string.Empty; 
            Description = string.Empty;
        }
        #endregion  // CTOR

        #region STRING CONVERSION METHODS

        #region GetId()
        /// <summary>
        /// Gets the unique identifier of the project as a string.
        /// </summary>
        /// <returns>A string representation of the project's unique identifier.</returns>
        public string GetId()
        { 
            return Id.ToString(); 
        }
    #endregion  // GetId()

        #region GetProjectId()
        /// <summary>
        /// Gets the unique identifier of the project as a string.
        /// </summary>
        /// <returns>A string representation of the project's unique identifier.</returns>
        public string GetProjectId()
        {
            return ProjectId.ToString();
        }
        #endregion  // GetProjectId()

        #endregion  // STRING CONVERSION METHODS

        #region IMPLEMENTATION of IProfilePanelData METHODS

        #region ConvertToPanelData(ProfileDto profileDto)
        /// <summary>
        /// Creates a new ProfilePanelData instance by copying values from the specified ProfileDto object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from ProfileDto to
        /// ProfilePanelData. All relevant fields are transferred directly. If profileDto is null, a
        /// NullReferenceException may occur.</remarks>
        /// <param name="profileDto">The ProfileDto object containing the source values to copy. Cannot be null.</param>
        /// <returns>A ProfilePanelData instance populated with values from the provided ProfileDto object.</returns>
        public ProfilePanelData ConvertToPanelData(ProfileDto profileDto)
        {
            ProfileDtoObj = profileDto;
            this.Id = profileDto.Id;
            this.ProjectId = profileDto.ProjectId;
            this.Name = profileDto.Name;
            this.Description = profileDto.Description;
            return this;
        }
        #endregion  // ConvertToPanelData(ProfileDto profileDto)

        #region ConvertFromPanelData()
        /// <summary>
        /// Creates a new ProfileDto instance by copying values from the current ProfilePanelData object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from ProfilePanelData to
        /// ProfileDto. All relevant fields are transferred directly.</remarks>
        /// NullReferenceException may occur.</remarks>
        /// <returns>A ProfileDto instance populated with values from the provided ProfilePanelData object.</returns>
        public ProfileDto ConvertFromPanelData()
        {
            ProfileDtoObj = new ProfileDto();
            ProfileDtoObj.Id = this.Id;
            ProfileDtoObj.ProjectId = this.ProjectId;
            ProfileDtoObj.Name = this.Name;
            ProfileDtoObj.Description = this.Description;
            return ProfileDtoObj;
        }
        #endregion  // ConvertFromPanelData()   

        #endregion  // IMPLEMENTATION of IProfilePanelData
    }
    #endregion      // public class ProfilePanelData
}
#endregion  // namespace HenStudio.Data.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
