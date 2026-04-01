#region HEADER
//#####################################################################################################################
//###############################  I G r i d D i a g r a m P o i n t I D R e p o . c s  ###############################
//#####################################################################################################################
//  FILENAME:  IGridDiagramPointIDRepo.cs
//  NAMESPACE: HenRepositories.Interfaces
//  INTERFACE: IGridDiagramPointIDRepo
//  COMPONENT: _HenRepositories.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the GridDiagramPointID Hen sub table.
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
    #region public interface IGridDiagramPointIDRepo
    /// <summary>
    /// GridDiagramPointID Repo Interface
    /// </summary>
    public interface IGridDiagramPointIDRepo
    {
        #region METHODS
        IList<GridDiagramPointIDDto> GetGridDiagramPointIDs();
        IList<GridDiagramPointIDDto> GetGridDiagramPointIDsByGridDiagramId(Guid gridDiagramId);
        GridDiagramPointIDDto GetGridDiagramPointIDById(Guid gridDiagramPointId);
        GridDiagramPointIDDto GetGridDiagramPointIDByPointSequence(Guid gridDiagramId, int pointSequence);
        Guid AddGridDiagramPointID(GridDiagramPointIDDto gridDiagramPointIdDto);
        void UpdateGridDiagramPointID(GridDiagramPointIDDto gridDiagramPointIdDto);
        void DeleteGridDiagramPointID(Guid gridDiagramPointId);
        #endregion      // METHODS
    }
    #endregion      // public interface IGridDiagramPointIDRepo
}
#endregion      // namespace HenRepositories.Interfaces

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
