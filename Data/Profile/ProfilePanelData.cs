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
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

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
        public Guid ProjectId { get; set; } // Project Unique Identifier
        public Guid ProfileId { get; set; } // Profile Unique Identifier

        public ProfileDto ProfileDtoObj { get; set; }           // Profile DTO Object ......... EXTERN Units
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
            ProjectId = new Guid(); // Project Unique Identifier
            ProfileId = new Guid(); // Profile Unique Identifier

            ProfileDtoObj = new ProfileDto(); // Profile DTO Object ........... EXTERN Units
        }
        #endregion  // CTOR

    }
    #endregion      // public class ProfilePanelData
}
#endregion  // namespace HenStudio.Data.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
