#region HEADER
//#####################################################################################################################
//############################################  T a r g e t s D t o . c s  ############################################
//#####################################################################################################################
//  FILENAME:  TargetsDto.cs
//  NAMESPACE: HenModel.Dto.Pinch
//  CLASS(S):  TargetsDto
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the Targets Pinch sub table.
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

#region namespace HenModel.Dto.Pinch
namespace HenModel.Dto.Pinch
{
    #region public class TargetsDto
    /// <summary>
    /// Targets DTO Class
    /// </summary>
    public class TargetsDto
    {
        #region PROPERTIES
        public int Id { get; set; } = -1;
        public int PinchId { get; set; } = -1;
        public double MinimumHotUtilityLoad { get; set; } = 0.00;
        public double MinimumColdUtilityLoad { get; set; } = 0.00;
        public int MinimumNumberOfExchangers { get; set; } = 1;
        public double HotPinchTargetTemperature { get; set; } = 0.00;
        public double ColdPinchTargetTemperature { get; set; } = 0.00;
        #endregion      // PROPERTIES
    }
    #endregion      // public class TargetsDto
}
#endregion      // namespace HenModel.Dto.Pinch

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
