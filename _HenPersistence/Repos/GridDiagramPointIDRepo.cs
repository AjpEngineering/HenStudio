#region HEADER
//#####################################################################################################################
//###############################  G r i d D i a g r a m P o i n t I D R e p o . c s  #################################
//#####################################################################################################################
//  FILENAME:  GridDiagramPointIDRepo.cs
//  NAMESPACE: HenPersistence.Repos
//  CLASS(S):  GridDiagramPointIDRepo
//  COMPONENT: _HenPersistence.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the GridDiagramPointID Hen sub table.
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
using HenRepositories.Interfaces;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenPersistence.Repos
namespace HenPersistence.Repos
{
    #region public class GridDiagramPointIDRepo
    /// <summary>
    /// GridDiagramPointID Repo Class
    /// </summary>
    public class GridDiagramPointIDRepo : IGridDiagramPointIDRepo
    {
        #region METHODS
        public IList<GridDiagramPointIDDto> GetGridDiagramPointIDs()
        {
            throw new NotImplementedException();
        }

        public IList<GridDiagramPointIDDto> GetGridDiagramPointIDsByGridDiagramId(Guid gridDiagramId)
        {
            throw new NotImplementedException();
        }

        public GridDiagramPointIDDto GetGridDiagramPointIDById(Guid gridDiagramPointId)
        {
            throw new NotImplementedException();
        }

        public GridDiagramPointIDDto GetGridDiagramPointIDByPointSequence(Guid gridDiagramId, int pointSequence)
        {
            throw new NotImplementedException();
        }

        public Guid AddGridDiagramPointID(GridDiagramPointIDDto gridDiagramPointIdDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateGridDiagramPointID(GridDiagramPointIDDto gridDiagramPointIdDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteGridDiagramPointID(Guid gridDiagramPointId)
        {
            throw new NotImplementedException();
        }
        #endregion      // METHODS
    }
    #endregion      // public class GridDiagramPointIDRepo
}
#endregion      // namespace HenPersistence.Repos

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
