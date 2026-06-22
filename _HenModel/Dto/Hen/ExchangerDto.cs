#region HEADER
//#####################################################################################################################
//##########################################  E x c h a n g e r D t o . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  ExchangerDto.cs
//  NAMESPACE: HenModel.Dto.Hen
//  CLASS(S):  ExchangerDto
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the Exchanger Hen sub table.
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

#region namespace HenModel.Dto.Hen
namespace HenModel.Dto.Hen
{
    #region public class ExchangerDto
    /// <summary>
    /// Exchanger DTO Class
    /// </summary>
    public class ExchangerDto
    {
        #region PROPERTIES
        public int Id { get; set; } = -1;
        public int HenId { get; set; } = -1;
        public string ExchangerId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string ExchangerType { get; set; } = string.Empty;
        public int Shells { get; set; } = 0;
        public double Area { get; set; } = 0.00;
        public double HotTemperatureIn { get; set; } = 0.00;
        public double HotTemperatureOut { get; set; } = 0.00;
        public double HotPressureIn { get; set; } = 0.00;
        public double HotPressureOut { get; set; } = 0.00;
        public double ColdTemperatureIn { get; set; } = 0.00;
        public double ColdTemperatureOut { get; set; } = 0.00;
        public double ColdPressureIn { get; set; } = 0.00;
        public double ColdPressureOut { get; set; } = 0.00;
        public double PressureDrop { get; set; } = 0.00;
        public double HeatDuty { get; set; } = 0.00;
        public double LmtdCorrectionFactor { get; set; } = 0.00;
        public double HeatTransferCoefficient { get; set; } = 0.00;
        public double CapitalCost { get; set; } = 0.00;
        public double AnnualizedCost { get; set; } = 0.00;
        public double FoulingFactor { get; set; } = 0.00;
        #endregion      // PROPERTIES
    }
    #endregion      // public class ExchangerDto
}
#endregion      // namespace HenModel.Dto.Hen

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
