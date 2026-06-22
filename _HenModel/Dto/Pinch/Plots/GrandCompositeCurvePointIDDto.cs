#region HEADER
//#####################################################################################################################
//#########################  G r a n d C o m p o s i t e C u r v e P o i n t I D D t o . c s  #########################
//#####################################################################################################################
//  FILENAME:  GrandCompositeCurvePointIDDto.cs
//  NAMESPACE: HHenModel.Dto.Pinch.Plots
//  CLASS(S):  GrandCompositeCurvePointIDDto
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the GrandCompositeCurvePointID Pinch sub table.
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
using System;
#endregion      // REFERENCES

#region namespace HenModel.Dto.Pinch.Plots
namespace HenModel.Dto.Pinch.Plots
{
    #region public class GrandCompositeCurvePointIDDto
    /// <summary>
    /// GrandCompositeCurvePointID DTO Class
    /// </summary>
    public class GrandCompositeCurvePointIDDto
    {
        #region PROPERTIES
        public int Id { get; set; } = -1;
        public int GrandCompositeCurveId { get; set; } = -1;
        public int PointSequence { get; set; } = 0;
        public double EnthalpyValue { get; set; } = 0.00;
        public double TemperatureValue { get; set; } = 0.00;
        #endregion      // PROPERTIES
    }
    #endregion      // public class GrandCompositeCurvePointIDDto
}
#endregion      // namespace HenModel.Dto.Pinch.Plots

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
