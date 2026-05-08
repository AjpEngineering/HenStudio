#region HEADER
//###################################  O p t i m i z e r M I L P _ R e p o . c s  ################################
//#####################################################################################################################
//  FILENAME:  OptimizerMILP_Repo.cs
//  NAMESPACE: HenModel.RepoImplementations.Project.DefaultParameters.OptimizerParams
//  CLASS(S):  OptimizerMILP_Repo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the Optimizer MILP Project sub table.
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
using HenModel.Connection;
using HenModel.Connection.Interface;

using HenModel.RepoInterfaces.Project.DefaultParameters.OptimizerParams;
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoImplementations.Project.DefaultParameters.OptimizerParams
namespace HenModel.RepoImplementations.Project.DefaultParameters.OptimizerParams
{
    #region public class OptimizerMILP_Repo
    /// <summary>
    /// Optimizer MILP Repo Class
    /// </summary>
    public class OptimizerMILP_Repo : IOptimizerMILP_Repo
    {
        #region PRIVATE FIELDS
        private readonly IDbConnectionFactory _connectionFactory;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public OptimizerMILP_Repo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS
        public IList<OptimizerMILP_Dto> GetOptimizerMILPs()
        {
            throw new NotImplementedException();
        }

        public OptimizerMILP_Dto GetOptimizerMILPByOptimizerId(Guid optimizerId)
        {
            throw new NotImplementedException();
        }

        public Guid AddOptimizerMILP(OptimizerMILP_Dto optimizerMilpDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateOptimizerMILP(OptimizerMILP_Dto optimizerMilpDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteOptimizerMILP(Guid optimizerMilpId)
        {
            throw new NotImplementedException();
        }
        #endregion      // METHODS
    }
    #endregion      // public class HenOptimizerMILPRepo
}
#endregion      // namespace HenModel.RepoImplementations.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
