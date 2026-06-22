#region HEADER
//#####################################################################################################################
//#####################################  H e a t R e l e a s e C u r v e D t o . c s  #################################
//#####################################################################################################################
//  FILENAME:  HeatReleaseCurveDto.cs
//  NAMESPACE: HenModel.Dto.Hen.Plots
//  CLASS(S):  HeatReleaseCurveDto
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the HeatReleaseCurve Hen sub table.
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
    #region public class HeatReleaseCurveDto
    /// <summary>
    /// HeatReleaseCurve DTO Class
    /// </summary>
    public class HeatReleaseCurveDto
    {
        #region PROPERTIES
        public int Id { get; set; } = -01;
        public int ExchangerId { get; set; } = -1;
        public string Title { get; set; } = "TITLE";
        public string XAxisLabel { get; set; } = "X";
        public string YAxisLabel { get; set; } = "Y";
        #endregion      // PROPERTIES
    }
    #endregion      // public class HeatReleaseCurveDto
}
#endregion      // namespace HenModel.Dto.Hen.Plots

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
