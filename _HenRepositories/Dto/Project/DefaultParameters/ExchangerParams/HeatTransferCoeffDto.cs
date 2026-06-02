#region HEADER
//#####################################################################################################################
//##################################  H e a t T r a n s f e r C o e f f D t o . c s  ##################################
//#####################################################################################################################
//  FILENAME:  HeatTransferCoeffDto.cs
//  NAMESPACE: HenModel.Dto.System
//  CLASS(S):  HeatTransferCoeffDto
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the Typical Heat Transfer Coefficient Range table.
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

#region namespace HenModel.Dto.Project.DefaultParameters.ExchangerParams
namespace HenModel.Dto.Project.DefaultParameters.ExchangerParams
{
    #region public class HeatTransferCoeffDto
    /// <summary>
    /// HeatTransferCoeff DTO Class
    /// </summary>
    public class HeatTransferCoeffDto
    {
        #region PROPERTIES
        public string Id { get; set; }
        public string Service { get; set; }
        public string Range { get; set; }
        public string Note { get; set; }
        #endregion      // PROPERTIES

        #region CTOR
        public HeatTransferCoeffDto() 
        {
            Id = string.Empty;
            Service = string.Empty;
            Range = string.Empty;
            Note = string.Empty;
        }
        #endregion      // CTOR
    }
    #endregion      // public class HeatTransferCoeffDto
}
#endregion      // namespace HenModel.Dto.Project.DefaultParameters.ExchangerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
