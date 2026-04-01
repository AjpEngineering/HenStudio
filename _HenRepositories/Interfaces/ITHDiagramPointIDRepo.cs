#region HEADER
//#####################################################################################################################
//###############################  I T H D i a g r a m P o i n t I D R e p o . c s  ###################################
//#####################################################################################################################
//  FILENAME:  ITHDiagramPointIDRepo.cs
//  NAMESPACE: HenRepositories.Interfaces
//  INTERFACE: ITHDiagramPointIDRepo
//  COMPONENT: _HenRepositories.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the THDiagramPointID Profile sub table.
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
using HenRepositories.Dto;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenRepositories.Interfaces
namespace HenRepositories.Interfaces
{
    #region public interface ITHDiagramPointIDRepo
    /// <summary>
    /// THDiagramPointID Repo Interface
    /// </summary>
    public interface ITHDiagramPointIDRepo
    {
        #region METHODS
        IList<THDiagramPointIDDto> GetTHDiagramPointIDs();
        IList<THDiagramPointIDDto> GetTHDiagramPointIDsByTHDiagramId(Guid thDiagramId);
        THDiagramPointIDDto GetTHDiagramPointIDById(Guid thDiagramPointId);
        THDiagramPointIDDto GetTHDiagramPointIDByPointSequence(Guid thDiagramId, int pointSequence);
        Guid AddTHDiagramPointID(THDiagramPointIDDto thDiagramPointIdDto);
        void UpdateTHDiagramPointID(THDiagramPointIDDto thDiagramPointIdDto);
        void DeleteTHDiagramPointID(Guid thDiagramPointId);
        #endregion      // METHODS
    }
    #endregion      // public interface ITHDiagramPointIDRepo
}
#endregion      // namespace HenRepositories.Interfaces

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
