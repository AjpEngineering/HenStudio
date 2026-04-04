#region HEADER
//#####################################################################################################################
//###################################  T H D i a g r a m P o i n t R e p o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  THDiagramPointRepo.cs
//  NAMESPACE: HenPersistence.Repos
//  CLASS(S):  THDiagramPointRepo
//  COMPONENT: _HenPersistence.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the THDiagramPoint Profile sub table.
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
    #region public class THDiagramPointRepo
    /// <summary>
    /// THDiagramPoint Repo Class
    /// </summary>
    public class THDiagramPointRepo : ITHDiagramPointRepo
    {
        #region PRIVATE FIELDS
        private readonly IDbConnectionFactory _connectionFactory;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public THDiagramPointRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS
        public IList<THDiagramPointDto> GetTHDiagramPoints()
        {
            throw new NotImplementedException();
        }

        public IList<THDiagramPointDto> GetTHDiagramPointsByTHDiagramId(Guid thDiagramId)
        {
            throw new NotImplementedException();
        }

        public THDiagramPointDto GetTHDiagramPointById(Guid thDiagramPointId)
        {
            throw new NotImplementedException();
        }

        public THDiagramPointDto GetTHDiagramPointByPointSequence(Guid thDiagramId, int pointSequence)
        {
            throw new NotImplementedException();
        }

        public Guid AddTHDiagramPoint(THDiagramPointDto thDiagramPointDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateTHDiagramPoint(THDiagramPointDto thDiagramPointDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteTHDiagramPoint(Guid thDiagramPointId)
        {
            throw new NotImplementedException();
        }
        #endregion      // METHODS
    }
    #endregion      // public class THDiagramPointRepo
}
#endregion      // namespace HenPersistence.Repos

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
