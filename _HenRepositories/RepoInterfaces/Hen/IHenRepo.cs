#region HEADER
//#####################################################################################################################
//##############################################  I H e n R e p o . c s  ##############################################
//#####################################################################################################################
//  FILENAME:  IHenRepo.cs
//  NAMESPACE: HenModel.RepoInterface.Hen
//  INTERFACE: IHenRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repository interface for the Hen top-level table.
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
using HenModel.Dto.Hen;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoInterface.Hen
namespace HenModel.RepoInterface.Hen
{
    #region public interface IHenRepo
    /// <summary>
    /// Hen Repo Interface
    /// </summary>
    public interface IHenRepo
    {
        #region METHODS
        IList<HenDto> GetHens();
        IList<HenDto> GetHensByPinchId(Guid pinchId);
        HenDto GetHenById(Guid henId);
        HenDto GetHenByName(Guid pinchId, string henName);
        Guid AddHen(HenDto henDto);
        void UpdateHen(HenDto henDto);
        void DeleteHen(Guid henId);
        #endregion      // METHODS
    }
    #endregion      // public interface IHenRepo
}
#endregion      // namespace HenModel.RepoInterface.Hen

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
