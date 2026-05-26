#region HEADER
//#####################################################################################################################
//################################  P r o j e c t U n i t s P a n e l D a t a . c s  ##################################
//#####################################################################################################################
//  FILENAME:  ProjectUnitsPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.DefaultParameters.ProjectUnits
//  CLASS(S):  ProjectUnitsPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Project Units Panel Data object - data needed for Project Units Panel.
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
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Project.DefaultParameters.ProjectUnits
namespace HenStudio.Data.Project.DefaultParameters.ProjectUnits
{
    #region public class ProjectUnitsPanelData
    public class ProjectUnitsPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.DefaultParameters.ProjectUnits";
        const string CLASS = "ProjectUnitsPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public ProjectUnitsDto ProjectUnitsDtoObj { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for ProjectUnitsPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public ProjectUnitsPanelData()
        {
            Id = new Guid();
            ProjectId = new Guid();
            ProjectUnitsDtoObj = new ProjectUnitsDto();
        }
        #endregion  // CTOR

    }
    #endregion      // public class ProjectUnitsPanelData
}
#endregion  // namespace HenStudio.Data.Project.DefaultParameters.ProjectUnits

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
