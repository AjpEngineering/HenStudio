#region HEADER
//#####################################################################################################################
//#############################  H e a t R e l e a s e C u r v e P o i n t I D D t o . c s  ###########################
//#####################################################################################################################
//  FILENAME:  HeatReleaseCurvePointIDDto.cs
//  NAMESPACE: HenModel.Dto.Hen.Plots
//  CLASS(S):  HeatReleaseCurvePointIDDto
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the HeatReleaseCurvePointID Hen sub table.
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

#region namespace HenModel.Dto.Hen.Plots
namespace HenModel.Dto.Hen.Plots
{
    #region public class HeatReleaseCurvePointIDDto
    /// <summary>
    /// HeatReleaseCurvePointID DTO Class
    /// </summary>
    public class HeatReleaseCurvePointIDDto
    {
        #region PROPERTIES
        public Guid Id { get; set; }
        public Guid HeatReleaseCurveId { get; set; }
        public int PointSequence { get; set; }
        public double DutyValue { get; set; }
        public double TemperatureValue { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class HeatReleaseCurvePointIDDto
}
#endregion      // namespace HenModel.Dto.Hen.Plots

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
