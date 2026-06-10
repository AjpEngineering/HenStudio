#region HEADER
//#####################################################################################################################
//#######################################  P r o c e s s S t r e a m D t o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  ProcessStreamDto.cs
//  NAMESPACE: HenModel.Dto.Profile.Streams
//  CLASS(S):  ProcessStreamDto
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the ProcessStream Profile sub table.
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
    #region public class ProcessStreamDto
    /// <summary>
    /// Process Stream DTO Class
    /// </summary>
    public class ProcessStreamDto
    {
        #region PROPERTIES
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public string StreamCategory { get; set; }
        public string StreamHeat { get; set; }
        public string StreamId { get; set; }
        public string Name { get; set; }
        public string StreamType { get; set; }
        public string StreamSubtype { get; set; }
        public double SupplyTemperature { get; set; }
        public double SupplyPressure { get; set; }
        public double TargetTemperature { get; set; }
        public double TargetPressure { get; set; }
        public double HeatCapacityFlowRate { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class ProcessStreamDto
}
#endregion      // namespace HenModel.Dto.Profile.Streams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
