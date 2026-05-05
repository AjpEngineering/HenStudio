#region HEADER
//#####################################################################################################################
//######################################  T H D i a g r a m P o i n t D t o . c s  ####################################
//#####################################################################################################################
//  FILENAME:  THDiagramPointDto.cs
//  NAMESPACE: HenModel.Dto.Pinch.Plots
//  CLASS(S):  THDiagramPointDto
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the THDiagramPoint Profile sub table.
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
    #region public class THDiagramPointDto
    /// <summary>
    /// THDiagramPoint DTO Class
    /// </summary>
    public class THDiagramPointDto
    {
        #region PROPERTIES
        public Guid Id { get; set; }
        public Guid THDiagramId { get; set; }
        public int PointSequence { get; set; }
        public double EnthalpyValue { get; set; }
        public double TemperatureValue { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class THDiagramPointDto
}
#endregion      // namespace HenModel.Dto.Pinch.Plots

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
