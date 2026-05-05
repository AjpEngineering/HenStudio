#region HEADER
//#####################################################################################################################
//############################################  I P r o j e c t R e p o . c s  ########################################
//#####################################################################################################################
//  FILENAME:  IProjectRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.Project
//  INTERFACE: IProjectRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repository interface for the Project top-level table.
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
using HenModel.Dto.Project;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoInterfaces.Project
namespace HenModel.RepoInterfaces.Project
{
    #region public interface IProjectRepo
    /// <summary>
    /// Project Repo Interface
    /// </summary>
    public interface IProjectRepo
    {
        #region METHODS
        IList<ProjectDto> GetProjects();
        ProjectDto GetProjectById(Guid projectId);
        ProjectDto GetProjectByName(string projectName);
        Guid AddProject(ProjectDto projectDto);
        void UpdateProject(ProjectDto projectDto);
        void DeleteProject(Guid projectId);
        #endregion      // METHODS
    }
    #endregion      // public interface IProjectRepo
}
#endregion      // namespace HenModel.RepoInterfaces.Project

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
