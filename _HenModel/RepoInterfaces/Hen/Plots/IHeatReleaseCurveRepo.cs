#region HEADER
//#####################################################################################################################
//################################  I H e a t R e l e a s e C u r v e R e p o . c s  ##################################
//#####################################################################################################################
//  FILENAME:  IHeatReleaseCurveRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.Hen.Plots
//  INTERFACE: IHeatReleaseCurveRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the HeatReleaseCurve Hen sub table.
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
using HenModel.Dto.Hen.Plots;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoInterface.Hen.Plots
namespace HenModel.RepoInterface.Hen.Plots
{
    #region public interface IHeatReleaseCurveRepo
    /// <summary>
    /// HeatReleaseCurve Repo Interface
    /// </summary>
    public interface IHeatReleaseCurveRepo
    {
        #region METHODS
        IList<HeatReleaseCurveDto> GetHeatReleaseCurves();
        IList<HeatReleaseCurveDto> GetHeatReleaseCurvesByExchangerId(Guid exchangerId);
        HeatReleaseCurveDto GetHeatReleaseCurveById(Guid heatReleaseCurveId);
        HeatReleaseCurveDto GetHeatReleaseCurveByTitle(Guid exchangerId, string title);
        Guid AddHeatReleaseCurve(HeatReleaseCurveDto heatReleaseCurveDto);
        void UpdateHeatReleaseCurve(HeatReleaseCurveDto heatReleaseCurveDto);
        void DeleteHeatReleaseCurve(Guid heatReleaseCurveId);
        #endregion      // METHODS
    }
    #endregion      // public interface IHeatReleaseCurveRepo
}
#endregion      // namespace HenModel.RepoInterface.Hen.Plots

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
