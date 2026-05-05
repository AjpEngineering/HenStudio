#region HEADER
//#####################################################################################################################
//#######################################  P r o j e c t U n i t s D t o . c s  #######################################
//#####################################################################################################################
//  FILENAME:  ProjectUnitsDto.cs
//  NAMESPACE: HenModel.Dto.Project.DefaultParameters.ProjectUnits
//  CLASS(S):  ProjectUnitsDto
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the Project Units top-level table.
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
using System;
#endregion      // REFERENCES

#region namespace HenModel.Dto.Project.DefaultParameters.ProjectUnits
namespace HenModel.Dto.Project.DefaultParameters.ProjectUnits
{
    #region public class ProjectUnitsDto
    /// <summary>
    /// Project Units DTO Class
    /// </summary>
    public class ProjectUnitsDto
    {
        #region PROPERTIES
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public string DefaultSystemUnits { get; set; }
        public string DefaultMagnitudeUnits { get; set; }
        public string DefaultTemperatureUnits { get; set; }
        public string DefaultPressureUnits { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class ProjectUnitsDto
}
#endregion      // namespace HenModel.Dto.Project.DefaultParameters.ProjectUnits

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
