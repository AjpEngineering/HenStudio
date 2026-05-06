#region HEADER
//#####################################################################################################################
//############################  I G r a n d C o m p o s i t e C u r v e R e p o . c s  ################################
//#####################################################################################################################
//  FILENAME:  IGrandCompositeCurveRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.Pinch.Plots
//  INTERFACE: IGrandCompositeCurveRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the GrandCompositeCurve Pinch sub table.
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
using HenModel.Dto.Pinch.Plots;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoInterfaces.Pinch.Plots
namespace HenModel.RepoInterfaces.Pinch.Plots
{
    #region public interface IGrandCompositeCurveRepo
    /// <summary>
    /// GrandCompositeCurve Repo Interface
    /// </summary>
    public interface IGrandCompositeCurveRepo
    {
        #region METHODS
        IList<GrandCompositeCurveDto> GetGrandCompositeCurves();
        IList<GrandCompositeCurveDto> GetGrandCompositeCurvesByPinchId(Guid pinchId);
        GrandCompositeCurveDto GetGrandCompositeCurveById(Guid grandCompositeCurveId);
        GrandCompositeCurveDto GetGrandCompositeCurveByTitle(Guid pinchId, string title);
        Guid AddGrandCompositeCurve(GrandCompositeCurveDto grandCompositeCurveDto);
        void UpdateGrandCompositeCurve(GrandCompositeCurveDto grandCompositeCurveDto);
        void DeleteGrandCompositeCurve(Guid grandCompositeCurveId);
        #endregion      // METHODS
    }
    #endregion      // public interface IGrandCompositeCurveRepo
}
#endregion      // namespace HenModel.RepoInterfaces.Pinch.Plots

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
