#region HEADER
//#####################################################################################################################
//####################  G r a n d C o m p o s i t e C u r v e P o i n t I D R e p o . c s  ############################
//#####################################################################################################################
//  FILENAME:  GrandCompositeCurvePointIDRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Pinch.Plots
//  CLASS(S):  GrandCompositeCurvePointIDRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the GrandCompositeCurvePointID Pinch sub table.
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

using HenModel.RepoInterfaces.Pinch.Plots;
using HenModel.Dto.Pinch.Plots;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoImplementations.Pinch.Plots
namespace HenModel.RepoImplementations.Pinch.Plots
{
    #region public class GrandCompositeCurvePointIDRepo
    /// <summary>
    /// GrandCompositeCurvePointID Repo Class
    /// </summary>
    public class GrandCompositeCurvePointIDRepo : IGrandCompositeCurvePointIDRepo
    {
        #region PRIVATE FIELDS
        private readonly IDbConnectionFactory _connectionFactory;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public GrandCompositeCurvePointIDRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS
        public IList<GrandCompositeCurvePointIDDto> GetGrandCompositeCurvePointIDs()
        {
            throw new NotImplementedException();
        }

        public IList<GrandCompositeCurvePointIDDto> GetGrandCompositeCurvePointIDsByGrandCompositeCurveId(Guid grandCompositeCurveId)
        {
            throw new NotImplementedException();
        }

        public GrandCompositeCurvePointIDDto GetGrandCompositeCurvePointIDById(Guid grandCompositeCurvePointId)
        {
            throw new NotImplementedException();
        }

        public GrandCompositeCurvePointIDDto GetGrandCompositeCurvePointIDByPointSequence(Guid grandCompositeCurveId, int pointSequence)
        {
            throw new NotImplementedException();
        }

        public Guid AddGrandCompositeCurvePointID(GrandCompositeCurvePointIDDto grandCompositeCurvePointIdDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateGrandCompositeCurvePointID(GrandCompositeCurvePointIDDto grandCompositeCurvePointIdDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteGrandCompositeCurvePointID(Guid grandCompositeCurvePointId)
        {
            throw new NotImplementedException();
        }
        #endregion      // METHODS
    }
    #endregion      // public class GrandCompositeCurvePointIDRepo
}
#endregion      // namespace HenModel.RepoImplementations.Pinch.Plots

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
