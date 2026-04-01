#region HEADER
//################################  I H e n O p t i m i z e r G r e e d y R e p o . c s  ##############################
//#####################################################################################################################
//  FILENAME:  IHenOptimizerGreedyRepo.cs
//  NAMESPACE: HenRepositories.Interfaces
//  INTERFACE: IHenOptimizerGreedyRepo
//  COMPONENT: _HenRepositories.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the HenOptimizerGreedy Project sub table.
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
    #region public interface IHenOptimizerGreedyRepo
    /// <summary>
    /// HenOptimizerGreedy Repo Interface
    /// </summary>
    public interface IHenOptimizerGreedyRepo
    {
        #region METHODS
        IList<HenOptimizerGreedyDto> GetHenOptimizerGreedys();
        HenOptimizerGreedyDto GetHenOptimizerGreedyByHenOptimizerId(Guid henOptimizerId);
        Guid AddHenOptimizerGreedy(HenOptimizerGreedyDto henOptimizerGreedyDto);
        void UpdateHenOptimizerGreedy(HenOptimizerGreedyDto henOptimizerGreedyDto);
        void DeleteHenOptimizerGreedy(Guid henOptimizerId);
        #endregion      // METHODS
    }
    #endregion      // public interface IHenOptimizerGreedyRepo
}
#endregion      // namespace HenRepositories.Interfaces

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
