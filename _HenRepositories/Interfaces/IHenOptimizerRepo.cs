#region HEADER
//#####################################################################################################################
//####################################  I H e n O p t i m i z e r R e p o . c s  ######################################
//#####################################################################################################################
//  FILENAME:  IHenOptimizerRepo.cs
//  NAMESPACE: HenRepositories.Interfaces
//  INTERFACE: IHenOptimizerRepo
//  COMPONENT: _HenRepositories.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the HenOptimizer Project sub table.
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
    #region public interface IHenOptimizerRepo
    /// <summary>
    /// HenOptimizer Repo Interface
    /// </summary>
    public interface IHenOptimizerRepo
    {
        #region METHODS
        IList<HenOptimizerDto> GetHenOptimizers();
        IList<HenOptimizerDto> GetHenOptimizersByProjectId(Guid projectId);
        HenOptimizerDto GetHenOptimizerById(Guid henOptimizerId);
        HenOptimizerDto GetHenOptimizerByName(Guid projectId, string name);
        Guid AddHenOptimizer(HenOptimizerDto henOptimizerDto);
        void UpdateHenOptimizer(HenOptimizerDto henOptimizerDto);
        void DeleteHenOptimizer(Guid henOptimizerId);
        #endregion      // METHODS
    }
    #endregion      // public interface IHenOptimizerRepo
}
#endregion      // namespace HenRepositories.Interfaces

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
