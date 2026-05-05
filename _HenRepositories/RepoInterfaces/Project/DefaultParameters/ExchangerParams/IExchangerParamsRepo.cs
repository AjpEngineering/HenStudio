#region HEADER
//#####################################################################################################################
//################################  I E x c h a n g e r P a r a m s R e p o R e p o . c s  ############################
//#####################################################################################################################
//  FILENAME:  IExchangerParamsRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.Project.DefaultParameters.ExchangerParams
//  INTERFACE: IExchangerParamsRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repository interface for the Exchanger Params top-level table.
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
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoInterfaces.Project.DefaultParameters.ExchangerParams
namespace HenModel.RepoInterfaces.Project.DefaultParameters.ExchangerParams
{
    #region public interface IExchangerParamsRepo
    /// <summary>
    /// Exchanger Params Repo Interface
    /// </summary>
    public interface IExchangerParamsRepo
    {
        #region METHODS
        ExchangerParamsDto GetExchangerParamsById(Guid exchangeParamsId);
        ExchangerParamsDto GetExchangerParamsByProjectId(Guid projectId);
        Guid AddExchangerParams(ExchangerParamsDto exchangerParamsDto);
        void UpdateExchangerParams(ExchangerParamsDto exchangerParamsDto);
        void DeleteExchangerParams(Guid exchangerParamsId);
        #endregion      // METHODS
    }
    #endregion      // public interface IExchangerParamsRepo
}
#endregion      // namespace HenModel.RepoInterfaces.Project.DefaultParameters.ExchangerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
