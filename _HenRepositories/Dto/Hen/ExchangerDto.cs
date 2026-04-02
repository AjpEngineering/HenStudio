#region HEADER
//#####################################################################################################################
//##########################################  E x c h a n g e r D t o . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  ExchangerDto.cs
//  NAMESPACE: HenRepositories.Dto
//  CLASS(S):  ExchangerDto
//  COMPONENT: _HenRepositories.dll
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

#region namespace HenRepositories.Dto
namespace HenRepositories.Dto
{
    #region public class ExchangerDto
    /// <summary>
    /// Exchanger DTO Class
    /// </summary>
    public class ExchangerDto
    {
        #region PROPERTIES
        public Guid Id { get; set; }
        public Guid HenId { get; set; }
        public string ExchangerId { get; set; }
        public string Name { get; set; }
        public bool IsUtility { get; set; }
        public string ExchangerType { get; set; }
        public int Shells { get; set; }
        public double Area { get; set; }
        public double HotTemperatureIn { get; set; }
        public double HotTemperatureOut { get; set; }
        public double HotPressureIn { get; set; }
        public double HotPressureOut { get; set; }
        public double ColdTemperatureIn { get; set; }
        public double ColdTemperatureOut { get; set; }
        public double ColdPressureIn { get; set; }
        public double ColdPressureOut { get; set; }
        public double PressureDrop { get; set; }
        public double HeatDuty { get; set; }
        public double LmtdCorrectionFactor { get; set; }
        public double HeatTransferCoefficient { get; set; }
        public double CapitalCost { get; set; }
        public double AnnualizedCost { get; set; }
        public double FoulingFactor { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class ExchangerDto
}
#endregion      // namespace HenRepositories.Dto

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
