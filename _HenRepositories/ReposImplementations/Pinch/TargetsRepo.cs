#region HEADER
//#####################################################################################################################
//############################################  T a r g e t s R e p o . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  TargetsRepo.cs
//  NAMESPACE: HenModel.ReposImplementaions.Pinch.Plots
//  CLASS(S):  TargetsRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the Targets Pinch sub table.
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

using HenModel.RepoInterface.Pinch;
using HenModel.Dto.Pinch;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.ReposImplementaions.Pinch.Plots
namespace HenModel.ReposImplementaions.Pinch.Plots
{
    #region public class TargetsRepo
    /// <summary>
    /// Targets Repo Class
    /// </summary>
    public class TargetsRepo : ITargetsRepo
    {
        #region PRIVATE FIELDS
        private readonly IDbConnectionFactory _connectionFactory;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public TargetsRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS
        public IList<TargetsDto> GetTargets()
        {
            throw new NotImplementedException();
        }

        public IList<TargetsDto> GetTargetsByPinchId(Guid pinchId)
        {
            throw new NotImplementedException();
        }

        public TargetsDto GetTargetsById(Guid targetsId)
        {
            throw new NotImplementedException();
        }

        public Guid AddTargets(TargetsDto targetsDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateTargets(TargetsDto targetsDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteTargets(Guid targetsId)
        {
            throw new NotImplementedException();
        }
        #endregion      // METHODS
    }
    #endregion      // public class TargetsRepo
}
#endregion      // namespace HenModel.ReposImplementaions.Pinch.Plots

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
