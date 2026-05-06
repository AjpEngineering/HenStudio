#region HEADER
//#####################################################################################################################
//##########################  I H e a t R e l e a s e C u r v e P o i n t I D R e p o . c s  ##########################
//#####################################################################################################################
//  FILENAME:  IHeatReleaseCurvePointIDRepo.cs
//  NAMESPACE: HenModel.RepoInterface.Hen.Plots
//  INTERFACE: IHeatReleaseCurvePointIDRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the HeatReleaseCurvePointID Hen sub table.
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
    #region public interface IHeatReleaseCurvePointIDRepo
    /// <summary>
    /// HeatReleaseCurvePointID Repo Interface
    /// </summary>
    public interface IHeatReleaseCurvePointIDRepo
    {
        #region METHODS
        IList<HeatReleaseCurvePointIDDto> GetHeatReleaseCurvePointIDs();
        IList<HeatReleaseCurvePointIDDto> GetHeatReleaseCurvePointIDsByHeatReleaseCurveId(Guid heatReleaseCurveId);
        HeatReleaseCurvePointIDDto GetHeatReleaseCurvePointIDById(Guid heatReleaseCurvePointId);
        HeatReleaseCurvePointIDDto GetHeatReleaseCurvePointIDByPointSequence(Guid heatReleaseCurveId, int pointSequence);
        Guid AddHeatReleaseCurvePointID(HeatReleaseCurvePointIDDto heatReleaseCurvePointIdDto);
        void UpdateHeatReleaseCurvePointID(HeatReleaseCurvePointIDDto heatReleaseCurvePointIdDto);
        void DeleteHeatReleaseCurvePointID(Guid heatReleaseCurvePointId);
        #endregion      // METHODS
    }
    #endregion      // public interface IHeatReleaseCurvePointIDRepo
}
#endregion      // namespace HenModel.RepoInterface.Hen.Plots

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
