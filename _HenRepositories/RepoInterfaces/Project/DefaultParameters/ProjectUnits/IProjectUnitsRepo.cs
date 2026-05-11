#region HEADER
//#####################################################################################################################
//#######################################  I P r o j e c t U n i t s R e p o . c s  ###################################
//#####################################################################################################################
//  FILENAME:  IProjectUnitsRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.Project.DefaultParameters.ProjectUnits
//  INTERFACE: IProjectUnitsRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repository interface for the Project Units table.
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

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoInterfaces.Project.DefaultParameters.ProjectUnits
namespace HenModel.RepoInterfaces.Project.DefaultParameters.ProjectUnits
{
    #region public interface IProjectUnitsRepo
    /// <summary>
    /// Project Units Repo Interface
    /// </summary>
    public interface IProjectUnitsRepo
    {
        #region METHODS
        Guid AddProjectUnits(ProjectUnitsDto projectUnitsDto);
        ProjectUnitsDto GetProjectUnitsById(Guid projectUnitsId);
        ProjectUnitsDto GetProjectUnitsByProjectId(Guid projectId);
        void UpdateProjectUnits(ProjectUnitsDto projectUnitsDto);
        void DeleteProjectUnits(Guid projectUnitsId);
        #endregion      // METHODS
    }
    #endregion      // public interface IProjectUnitsRepo
}
#endregion      // namespace HenModel.RepoInterfaces.Project.DefaultParameters.ProjectUnits

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
