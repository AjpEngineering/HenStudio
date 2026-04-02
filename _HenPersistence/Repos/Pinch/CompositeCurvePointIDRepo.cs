#region HEADER
//#####################################################################################################################
//#############################  C o m p o s i t e C u r v e P o i n t I D R e p o . c s  #############################
//#####################################################################################################################
//  FILENAME:  CompositeCurvePointIDRepo.cs
//  NAMESPACE: HenPersistence.Repos
//  CLASS(S):  CompositeCurvePointIDRepo
//  COMPONENT: _HenPersistence.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the CompositeCurvePointID Pinch sub table.
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
    #region public class CompositeCurvePointIDRepo
    /// <summary>
    /// CompositeCurvePointID Repo Class
    /// </summary>
    public class CompositeCurvePointIDRepo : ICompositeCurvePointIDRepo
    {
        #region PRIVATE FIELDS
        private readonly IDbConnectionFactory _connectionFactory;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public CompositeCurvePointIDRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS
        public IList<CompositeCurvePointIDDto> GetCompositeCurvePointIDs()
        {
            throw new NotImplementedException();
        }

        public IList<CompositeCurvePointIDDto> GetCompositeCurvePointIDsByCompositeCurveId(Guid compositeCurveId)
        {
            throw new NotImplementedException();
        }

        public CompositeCurvePointIDDto GetCompositeCurvePointIDById(Guid compositeCurvePointId)
        {
            throw new NotImplementedException();
        }

        public CompositeCurvePointIDDto GetCompositeCurvePointIDByPointSequence(Guid compositeCurveId, string pointCurveType, int pointSequence)
        {
            throw new NotImplementedException();
        }

        public Guid AddCompositeCurvePointID(CompositeCurvePointIDDto compositeCurvePointIdDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateCompositeCurvePointID(CompositeCurvePointIDDto compositeCurvePointIdDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteCompositeCurvePointID(Guid compositeCurvePointId)
        {
            throw new NotImplementedException();
        }
        #endregion      // METHODS
    }
    #endregion      // public class CompositeCurvePointIDRepo
}
#endregion      // namespace HenPersistence.Repos

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
