#region HEADER
//#####################################################################################################################
//######################################  E x c h a n g e r P a r a m s D t o.c s  ####################################
//#####################################################################################################################
//  FILENAME:  ExchangerParamsDto.cs
//  NAMESPACE: HenRepositories.Dto
//  CLASS(S):  ExchangerParamsDto
//  COMPONENT: _HenRepositories.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the Exchanger Params top-level table.
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
    #region public class ExchangerParamsDto
    /// <summary>
    /// Exchanger Params DTO Class
    /// </summary>
    public class ExchangerParamsDto
    {
        #region PROPERTIES
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public double DefaultHeatTransferCoefficient { get; set; }
        public double DefaultCorrectionFactor { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class ExchangerParamsDto
}
#endregion      // namespace HenRepositories.Dto

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
