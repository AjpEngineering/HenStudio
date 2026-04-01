#region HEADER
//#####################################################################################################################
//########################################  I E c o n P a r a m R e p o . c s  ########################################
//#####################################################################################################################
//  FILENAME:  IEconParamRepo.cs
//  NAMESPACE: HenRepositories.Interfaces
//  INTERFACE: IEconParamRepo
//  COMPONENT: _HenRepositories.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the EconParam Profile sub table.
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
using HenRepositories.Dto;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenRepositories.Interfaces
namespace HenRepositories.Interfaces
{
    #region public interface IEconParamRepo
    /// <summary>
    /// EconParam Repo Interface
    /// </summary>
    public interface IEconParamRepo
    {
        #region METHODS
        IList<EconParamDto> GetEconParams();
        IList<EconParamDto> GetEconParamsByProfileId(Guid profileId);
        EconParamDto GetEconParamById(Guid econParamId);
        EconParamDto GetEconParamByName(Guid profileId, string capitalCostIndexName);
        Guid AddEconParam(EconParamDto econParamDto);
        void UpdateEconParam(EconParamDto econParamDto);
        void DeleteEconParam(Guid econParamId);
        #endregion      // METHODS
    }
    #endregion      // public interface IEconParamRepo
}
#endregion      // namespace HenRepositories.Interfaces

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
