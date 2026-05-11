#region HEADER
//#####################################################################################################################
//##################################  I O p t i m i z e r G e n e t i c R e p o . c s  ################################
//#####################################################################################################################
//  FILENAME:  IOptimizerGeneticRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.Project.DefaultParameters.OptimizerParams
//  INTERFACE: IOptimizerGeneticRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the Optimizer Genetic Parameters object.
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
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoInterfaces.Project.DefaultParameters.OptimizerParams
namespace HenModel.RepoInterfaces.Project.DefaultParameters.OptimizerParams
{
    #region public interface IOptimizerGeneticRepo
    /// <summary>
    /// HenOptimizerGenetic Repo Interface
    /// </summary>
    public interface IOptimizerGeneticRepo
    {
        #region METHODS
        Guid AddOptimizerGenetic(OptimizerGeneticDto optimizerGeneticDto);
        IList<OptimizerGeneticDto> GetOptimizerGenetics();
        OptimizerGeneticDto GetOptimizerGeneticById(Guid optimizerGeneticId);
        OptimizerGeneticDto GetOptimizerGeneticByOptimizerParamsId(Guid optimizerParamsId);
        void UpdateOptimizerGenetic(OptimizerGeneticDto optimizerGeneticDto);
        void DeleteOptimizerGenetic(Guid optimizerGeneticId);
        #endregion      // METHODS
    }
    #endregion      // public interface IOptimizerGeneticRepo
}
#endregion      // namespace HenModel.RepoInterfaces.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
