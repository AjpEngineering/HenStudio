#region HEADER
//#####################################################################################################################
//######################################  H e n O p t i m i z e r R e p o . c s  ######################################
//#####################################################################################################################
//  FILENAME:  HenOptimizerRepo.cs
//  NAMESPACE: HenPersistence.Repos
//  CLASS(S):  HenOptimizerRepo
//  COMPONENT: _HenPersistence.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the HenOptimizer Project sub table.
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
using HenPersistence.Interfaces;
using HenRepositories.Dto;
using HenRepositories.Interfaces;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenPersistence.Repos
namespace HenPersistence.Repos
{
    #region public class HenOptimizerRepo
    /// <summary>
    /// HenOptimizer Repo Class
    /// </summary>
    public class HenOptimizerRepo : IHenOptimizerRepo
    {
        #region PRIVATE FIELDS
        private readonly IDbConnectionFactory _connectionFactory;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public HenOptimizerRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS
        public IList<HenOptimizerDto> GetHenOptimizers()
        {
            throw new NotImplementedException();
        }

        public IList<HenOptimizerDto> GetHenOptimizersByProjectId(Guid projectId)
        {
            throw new NotImplementedException();
        }

        public HenOptimizerDto GetHenOptimizerById(Guid henOptimizerId)
        {
            throw new NotImplementedException();
        }

        public HenOptimizerDto GetHenOptimizerByName(Guid projectId, string name)
        {
            throw new NotImplementedException();
        }

        public Guid AddHenOptimizer(HenOptimizerDto henOptimizerDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateHenOptimizer(HenOptimizerDto henOptimizerDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteHenOptimizer(Guid henOptimizerId)
        {
            throw new NotImplementedException();
        }
        #endregion      // METHODS
    }
    #endregion      // public class HenOptimizerRepo
}
#endregion      // namespace HenPersistence.Repos

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
