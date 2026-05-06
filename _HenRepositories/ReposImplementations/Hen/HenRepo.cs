#region HEADER
//#####################################################################################################################
//################################################  H e n R e p o . c s  ##############################################
//#####################################################################################################################
//  FILENAME:  HenRepo.cs
//  NAMESPACE: HenModel.ReposImplementaions.Hen
//  CLASS(S):  HenRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the Hen top-level table.
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

using HenModel.RepoInterface.Hen;
using HenModel.Dto.Hen;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.ReposImplementaions.Hen
namespace HenModel.ReposImplementaions.Hen
{
    #region public class HenRepo
    /// <summary>
    /// Hen Repo Class
    /// </summary>
    public class HenRepo : IHenRepo
    {
        #region PRIVATE FIELDS
        private readonly IDbConnectionFactory _connectionFactory;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public HenRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS
        public IList<HenDto> GetHens()
        {
            throw new NotImplementedException();
        }

        public IList<HenDto> GetHensByPinchId(Guid pinchId)
        {
            throw new NotImplementedException();
        }

        public HenDto GetHenById(Guid henId)
        {
            throw new NotImplementedException();
        }

        public HenDto GetHenByName(Guid pinchId, string henName)
        {
            throw new NotImplementedException();
        }

        public Guid AddHen(HenDto henDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateHen(HenDto henDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteHen(Guid henId)
        {
            throw new NotImplementedException();
        }
        #endregion      // METHODS
    }
    #endregion      // public class HenRepo
}
#endregion      // namespace HenModel.ReposImplementaions.Hen

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
