#region HEADER
//#####################################################################################################################
//###########################  H e a t R e l e a s e C u r v e P o i n t I D R e p o . c s  ###########################
//#####################################################################################################################
//  FILENAME:  HeatReleaseCurvePointIDRepo.cs
//  NAMESPACE: HenModel.ReposImplementations.Hen.Plots
//  CLASS(S):  HeatReleaseCurvePointIDRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the HeatReleaseCurvePointID Hen sub table.
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

using HenModel.RepoInterface.Hen.Plots;
using HenModel.Dto.Hen.Plots;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoImplementations.Hen.Plots
namespace HenModel.RepoImplementations.Hen.Plots
{
    #region public class HeatReleaseCurvePointIDRepo
    /// <summary>
    /// HeatReleaseCurvePointID Repo Class
    /// </summary>
    public class HeatReleaseCurvePointIDRepo : IHeatReleaseCurvePointIDRepo
    {
        #region PRIVATE FIELDS
        private readonly IDbConnectionFactory _connectionFactory;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public HeatReleaseCurvePointIDRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS
        public IList<HeatReleaseCurvePointIDDto> GetHeatReleaseCurvePointIDs()
        {
            throw new NotImplementedException();
        }

        public IList<HeatReleaseCurvePointIDDto> GetHeatReleaseCurvePointIDsByHeatReleaseCurveId(Guid heatReleaseCurveId)
        {
            throw new NotImplementedException();
        }

        public HeatReleaseCurvePointIDDto GetHeatReleaseCurvePointIDById(Guid heatReleaseCurvePointId)
        {
            throw new NotImplementedException();
        }

        public HeatReleaseCurvePointIDDto GetHeatReleaseCurvePointIDByPointSequence(Guid heatReleaseCurveId, int pointSequence)
        {
            throw new NotImplementedException();
        }

        public Guid AddHeatReleaseCurvePointID(HeatReleaseCurvePointIDDto heatReleaseCurvePointIdDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateHeatReleaseCurvePointID(HeatReleaseCurvePointIDDto heatReleaseCurvePointIdDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteHeatReleaseCurvePointID(Guid heatReleaseCurvePointId)
        {
            throw new NotImplementedException();
        }
        #endregion      // METHODS
    }
    #endregion      // public class HeatReleaseCurvePointIDRepo
}
#endregion      // namespace HenModel.RepoImplementations.Hen.Plots

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
