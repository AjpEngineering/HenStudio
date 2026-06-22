#region HEADER
//#####################################################################################################################
//############################  S h e l l A n d T u b e C a p i t a l C o s t D t o . c s  ############################
//#####################################################################################################################
//  FILENAME:  ShellAndTubeCapitalCostDto.cs
//  NAMESPACE: HenModel.Dto.Project.CostParameters
//  CLASS(S):  ShellAndTubeCapitalCostDto
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the Shell And Tube Capital Cost Project-Cost Parameters sub table.
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
using System.Web;
#endregion      // REFERENCES

#region namespace HenModel.Dto.Project.CostParameters
namespace HenModel.Dto.Project.CostParameters
{
    #region public class ShellAndTubeCapitalCostDto
    /// <summary>
    /// Shell And Tube Capital Cost DTO Class
    /// </summary>
    public class ShellAndTubeCapitalCostDto
    {
        #region PROPERTIES
        public int Id { get; set; } = -1;
        public int ProjectId { get; set; } = -1;
        public double ParameterA { get; set; } = 0.00;
        public double ParameterB_Metric { get; set; } = 0.00;
        public double ParameterB_English { get; set; } = 0.00;
        public double ParameterN { get; set; } = 0.00;
        public double MaterialFactor { get; set; } = 0.00;
        public string AreaUnits_Metric { get; set; } = string.Empty;
        public string AreaUnits_English { get; set; } = string.Empty;
        #endregion      // PROPERTIES
    }
    #endregion      // public class ShellAndTubeCapitalCostDto
}
#endregion      // namespace HenModel.Dto.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
