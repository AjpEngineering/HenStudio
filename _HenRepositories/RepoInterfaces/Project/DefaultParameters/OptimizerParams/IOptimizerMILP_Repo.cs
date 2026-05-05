#region HEADER
//##################################  I O p t i m i z e r M I L P _ R e p o . c s  ###############################
//#####################################################################################################################
//  FILENAME:  IOptimizerMILP_Repo.cs
//  NAMESPACE: HenModel.RepoInterfaces.Project.DefaultParameters.OptimizerParams
//  INTERFACE: IOptimizerMILP_Repo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the Optimizer MILP Project sub table.
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
    #region public interface IOptimizerMILP_Repo
    /// <summary>
    /// Optimizer MILP Repo Interface
    /// </summary>
    public interface IOptimizerMILP_Repo
    {
        #region METHODS
        IList<OptimizerMILP_Dto> GetHenOptimizerMILPs();
        OptimizerMILP_Dto GetHenOptimizerMILPByHenOptimizerId(Guid henOptimizerId);
        Guid AddHenOptimizerMILP(OptimizerMILP_Dto henOptimizerMilpDto);
        void UpdateHenOptimizerMILP(OptimizerMILP_Dto henOptimizerMilpDto);
        void DeleteHenOptimizerMILP(Guid henOptimizerId);
        #endregion      // METHODS
    }
    #endregion      // public interface IOptimizerMILP_Repo
}
#endregion      // namespace HenModel.RepoInterfaces.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
