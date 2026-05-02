#region HEADER
//#####################################################################################################################
//##################  I G r a n d C o m p o s i t e C u r v e P o i n t I D R e p o . c s  ###########################
//#####################################################################################################################
//  FILENAME:  IGrandCompositeCurvePointIDRepo.cs
//  NAMESPACE: HenRepositories.Interfaces
//  INTERFACE: IGrandCompositeCurvePointIDRepo
//  COMPONENT: _HenRepositories.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the GrandCompositeCurvePointID Pinch sub table.
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
    #region public interface IGrandCompositeCurvePointIDRepo
    /// <summary>
    /// GrandCompositeCurvePointID Repo Interface
    /// </summary>
    public interface IGrandCompositeCurvePointIDRepo
    {
        #region METHODS
        IList<GrandCompositeCurvePointIDDto> GetGrandCompositeCurvePointIDs();
        IList<GrandCompositeCurvePointIDDto> GetGrandCompositeCurvePointIDsByGrandCompositeCurveId(Guid grandCompositeCurveId);
        GrandCompositeCurvePointIDDto GetGrandCompositeCurvePointIDById(Guid grandCompositeCurvePointId);
        GrandCompositeCurvePointIDDto GetGrandCompositeCurvePointIDByPointSequence(Guid grandCompositeCurveId, int pointSequence);
        Guid AddGrandCompositeCurvePointID(GrandCompositeCurvePointIDDto grandCompositeCurvePointIdDto);
        void UpdateGrandCompositeCurvePointID(GrandCompositeCurvePointIDDto grandCompositeCurvePointIdDto);
        void DeleteGrandCompositeCurvePointID(Guid grandCompositeCurvePointId);
        #endregion      // METHODS
    }
    #endregion      // public interface IGrandCompositeCurvePointIDRepo
}
#endregion      // namespace HenRepositories.Interfaces

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
