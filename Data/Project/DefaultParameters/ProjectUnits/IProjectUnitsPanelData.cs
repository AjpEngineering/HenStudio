#region HEADER
//#####################################################################################################################
//##################################  I P r o j e c t U n i t s P a n e l D a t a . c s  ##############################
//#####################################################################################################################
//  FILENAME:  IProjectUnitsPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.DefaultParameters.ProjectUnits
//  INTERFACE: IProjectUnitsPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the Project Units Panel interface for the Project units parameters.
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
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;
using HenStudio.Data.Project.DefaultParameters.ProjectUnits;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenStudio.Data.Project.DefaultParameters.ProjectUnits
namespace HenStudio.Data.Project.DefaultParameters.ProjectUnits
{
    #region public interface IProjectUnitsPanelData
    /// <summary>
    /// Project Units Panel Interface
    /// </summary>
    public interface IProjectUnitsPanelData
    {
        #region METHODS
        ProjectUnitsPanelData ConvertToPanelData(ProjectUnitsDto projectUnitsDto);
        ProjectUnitsDto ConvertFromPanelData();
        #endregion      // METHODS
    }
    #endregion      // public interface IProjectUnitsPanelData
}
#endregion      // namespace HenStudio.Data.Project.DefaultParameters.ProjectUnits
//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
