#region HEADER
//#####################################################################################################################
//########################################  I T H D i a g r a m R e p o . c s  ########################################
//#####################################################################################################################
//  FILENAME:  ITHDiagramRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.Pinch.Plots
//  INTERFACE: ITHDiagramRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the THDiagram Profile sub table.
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
using HenModel.Dto.Pinch.Plots;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoInterfaces.Pinch.Plots
namespace HenModel.RepoInterfaces.Pinch.Plots
{
    #region public interface ITHDiagramRepo
    /// <summary>
    /// THDiagram Repo Interface
    /// </summary>
    public interface ITHDiagramRepo
    {
        #region METHODS
        IList<THDiagramDto> GetTHDiagrams();
        IList<THDiagramDto> GetTHDiagramsByProfileId(Guid profileId);
        THDiagramDto GetTHDiagramById(Guid thDiagramId);
        THDiagramDto GetTHDiagramByTitle(Guid profileId, string title);
        Guid AddTHDiagram(THDiagramDto thDiagramDto);
        void UpdateTHDiagram(THDiagramDto thDiagramDto);
        void DeleteTHDiagram(Guid thDiagramId);
        #endregion      // METHODS
    }
    #endregion      // public interface ITHDiagramRepo
}
#endregion      // namespace HenModel.RepoInterfaces.Pinch.Plots

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
