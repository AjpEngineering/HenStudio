#region HEADER
//#####################################################################################################################
//######################################  P r o j e c t P a n e l D a t a . c s  ########################################
//#####################################################################################################################
//  FILENAME:  ProjectPanelData.cs
//  NAMESPACE: HenStudio.Data.Project
//  CLASS(S):  ProjectPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Project Panel Data object - data needed for Project Panel.
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
using HenModel.Dto.Project;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Project
namespace HenStudio.Data.Project
{
    #region public class ProjectPanelData
    public class ProjectPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project";
        const string CLASS = "ProjectPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public Guid Id { get; set; }
        public ProjectDto ProjectDtoObj { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Initializes a new instance of the ProjectPanelData class with default values for all properties.
        /// </summary>
        /// <remarks>All string properties are initialized to empty strings, date properties are set to
        /// the current date and time, and the ProjectDtoObj property is initialized with a new ProjectDto instance.
        /// This constructor ensures that the object is in a valid default state upon creation.</remarks>
        public ProjectPanelData()
        {
            Id = new Guid();
            ProjectDtoObj = new ProjectDto();
        }
        #endregion  // CTOR

    }
    #endregion      // public class ProjectPanelData
}
#endregion  // namespace HenStudio.Data.Project

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
