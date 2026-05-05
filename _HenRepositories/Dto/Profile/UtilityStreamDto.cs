#region HEADER
//#####################################################################################################################
//#######################################  U t i l i t y S t r e a m D t o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  UtilityStreamDto.cs
//  NAMESPACE: HenModel.Dto.Profile
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

#region namespace HenModel.Dto.Profile
namespace HenModel.Dto.Profile
{
    #region public class UtilityStreamDto
    /// <summary>
    /// Utility Stream DTO Class
    /// </summary>
    public class UtilityStreamDto
    {
        #region PROPERTIES
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public string StreamCategory { get; set; }
        public string StreamHeat { get; set; }
        public string StreamId { get; set; }
        public string Name { get; set; }
        public string StreamType { get; set; }
        public double IsothermalTemperature { get; set; }
        public double SupplyPressure { get; set; }
        public double TargetPressure { get; set; }
        public double EnthalpyFlowRate { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class UtilityStreamDto
}
#endregion      // namespace HenModel.Dto.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
