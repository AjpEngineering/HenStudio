#region HEADER
//#####################################################################################################################
//########################################  U t i l i t y C o s t D t o . c s  ########################################
//#####################################################################################################################
//  FILENAME:  UtilityCostDto.cs
//  NAMESPACE: HenRepositories.Dto
//  CLASS(S):  UtilityCostDto
//  COMPONENT: _HenRepositories.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the Utility Cost Project-Cost Parameters sub table.
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

#region namespace HenRepositories.Dto
namespace HenRepositories.Dto
{
    #region public class UtilityCostDto
    /// <summary>
    /// Utility Cost DTO Class
    /// </summary>
    public class UtilityCostDto
    {
        #region PROPERTIES
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public double HP_SteamCost_Metric { get; set; }
        public double MP_SteamCost_Metric { get; set; }
        public double LP_SteamCost_Metric { get; set; }
        public double CoolingWaterCost_Metric { get; set; }
        public double ChilledWaterCost_Metric { get; set; }
        public double FuelGasCost_Metric { get; set; }
        public double HP_SteamCost_English { get; set; }
        public double MP_SteamCost_English { get; set; }
        public double LP_SteamCost_English { get; set; }
        public double CoolingWaterCost_English { get; set; }
        public double ChilledWaterCost_English { get; set; }
        public double FuelGasCost_English { get; set; }
        public string DutyUnits_Metric { get; set; }
        public string DutyUnits_English { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class UtilityCostDto
}
#endregion      // namespace HenRepositories.Dto

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
