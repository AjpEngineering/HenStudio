#region HEADER
//#####################################################################################################################
//#################################  I T H D i a g r a m P o i n t R e p o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  ITHDiagramPointRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.Pinch.Plots
//  INTERFACE: ITHDiagramPointRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the THDiagramPoint Profile sub table.
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
    #region public interface ITHDiagramPointRepo
    /// <summary>
    /// THDiagramPoint Repo Interface
    /// </summary>
    public interface ITHDiagramPointRepo
    {
        #region METHODS
        IList<THDiagramPointDto> GetTHDiagramPoints();
        IList<THDiagramPointDto> GetTHDiagramPointsByTHDiagramId(Guid thDiagramId);
        THDiagramPointDto GetTHDiagramPointById(Guid thDiagramPointId);
        THDiagramPointDto GetTHDiagramPointByPointSequence(Guid thDiagramId, int pointSequence);
        Guid AddTHDiagramPoint(THDiagramPointDto thDiagramPointDto);
        void UpdateTHDiagramPoint(THDiagramPointDto thDiagramPointDto);
        void DeleteTHDiagramPoint(Guid thDiagramPointId);
        #endregion      // METHODS
    }
    #endregion      // public interface ITHDiagramPointRepo
}
#endregion      // namespace HenModel.RepoInterfaces.Pinch.Plots

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
