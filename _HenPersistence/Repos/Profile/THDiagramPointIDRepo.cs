#region HEADER
//#####################################################################################################################
//#################################  T H D i a g r a m P o i n t I D R e p o . c s  ##################################
//#####################################################################################################################
//  FILENAME:  THDiagramPointIDRepo.cs
//  NAMESPACE: HenPersistence.Repos
//  CLASS(S):  THDiagramPointIDRepo
//  COMPONENT: _HenPersistence.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the THDiagramPointID Profile sub table.
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
    #region public class THDiagramPointIDRepo
    /// <summary>
    /// THDiagramPointID Repo Class
    /// </summary>
    public class THDiagramPointIDRepo : ITHDiagramPointIDRepo
    {
        #region PRIVATE FIELDS
        private readonly IDbConnectionFactory _connectionFactory;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public THDiagramPointIDRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS
        public IList<THDiagramPointIDDto> GetTHDiagramPointIDs()
        {
            throw new NotImplementedException();
        }

        public IList<THDiagramPointIDDto> GetTHDiagramPointIDsByTHDiagramId(Guid thDiagramId)
        {
            throw new NotImplementedException();
        }

        public THDiagramPointIDDto GetTHDiagramPointIDById(Guid thDiagramPointId)
        {
            throw new NotImplementedException();
        }

        public THDiagramPointIDDto GetTHDiagramPointIDByPointSequence(Guid thDiagramId, int pointSequence)
        {
            throw new NotImplementedException();
        }

        public Guid AddTHDiagramPointID(THDiagramPointIDDto thDiagramPointIdDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateTHDiagramPointID(THDiagramPointIDDto thDiagramPointIdDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteTHDiagramPointID(Guid thDiagramPointId)
        {
            throw new NotImplementedException();
        }
        #endregion      // METHODS
    }
    #endregion      // public class THDiagramPointIDRepo
}
#endregion      // namespace HenPersistence.Repos

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
