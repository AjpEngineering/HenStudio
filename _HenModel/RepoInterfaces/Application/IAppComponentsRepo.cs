#region HEADER
//#####################################################################################################################
//#####################################  I A p p C o m p o n e n t s R e p o . c s  ###################################
//#####################################################################################################################
//  FILENAME:  IAppComponentsRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.System
//  INTERFACE: IAppComponentsRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the App Components.
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
using HenModel.Dto.Application;

using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoInterfaces.Application
namespace HenModel.RepoInterfaces.Application
{
    #region public interface IAppComponentsRepo
    /// <summary>
    /// AppComponents Repo Interface
    /// </summary>
    public interface IAppComponentsRepo
    {
        #region METHODS
        List<AppComponentsDto> GetAppComponentsList();
        #endregion      // METHODS
    }
    #endregion      // public interface IAppComponentsRepo
}
#endregion      // namespace HenModel.RepoInterfaces.Application

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
