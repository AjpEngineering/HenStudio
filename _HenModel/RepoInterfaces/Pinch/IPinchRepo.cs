#region HEADER
//#####################################################################################################################
//##############################################  I P i n c h R e p o . c s  ###########################################
//#####################################################################################################################
//  FILENAME:  IPinchRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.Pinch
//  INTERFACE: IPinchRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repository interface for the Pinch top-level table.
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
using HenModel.Dto.Pinch;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoInterfaces.Pinch
namespace HenModel.RepoInterfaces.Pinch
{
    #region public interface IPinchRepo
    /// <summary>
    /// Pinch Repo Interface
    /// </summary>
    public interface IPinchRepo
    {
        #region METHODS
        IList<PinchDto> GetPinches();
        IList<PinchDto> GetPinchesByProfileId(Guid profileId);
        PinchDto GetPinchById(Guid pinchId);
        PinchDto GetPinchByName(Guid profileId, string pinchName);
        Guid AddPinch(PinchDto pinchDto);
        void UpdatePinch(PinchDto pinchDto);
        void DeletePinch(Guid pinchId);
        #endregion      // METHODS
    }
    #endregion      // public interface IPinchRepo
}
#endregion      // namespace HenModel.RepoInterfaces.Pinch

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
