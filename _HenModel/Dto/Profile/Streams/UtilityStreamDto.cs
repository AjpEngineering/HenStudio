#region HEADER
//#####################################################################################################################
//#######################################  U t i l i t y S t r e a m D t o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  UtilityStreamDto.cs
//  NAMESPACE: HenModel.Dto.Profile.Streams
//  CLASS(S):  UtilityStreamDto
//  COMPONENT: _HenRepositories.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the UtilityStream Profile sub table.
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

#region namespace HenModel.Dto.Profile.Streams
namespace HenModel.Dto.Profile.Streams
{
    #region public class UtilityStreamDto
    /// <summary>
    /// Utility Stream DTO Class
    /// </summary>
    public class UtilityStreamDto
    {
        #region PROPERTIES
        public int Id { get; set; } = -1;
        public int ProfileId { get; set; } = -1;
        public string StreamCategory { get; set; } = string.Empty;
        public string StreamHeat { get; set; } = string.Empty;
        public string StreamId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string UtilityType { get; set; } = string.Empty;
        public string StreamSubtype { get; set; } = string.Empty;
        public double IsothermalTemperature { get; set; } = 0.00;
        public double SupplyTemperature { get; set; } = 0.00;
        public double TargetTemperature { get; set; } = 0.00;
        public double SupplyPressure { get; set; } = 0.00;
        public double TargetPressure { get; set; } = 0.00;
        public double EnthalpyFlowRate { get; set; } = 0.00;
        #endregion      // PROPERTIES
    }
    #endregion      // public class UtilityStreamDto
}
#endregion      // namespace HenModel.Dto.Profile.Streams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
