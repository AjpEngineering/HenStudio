#region HEADER
//#####################################################################################################################
//##########################################  E c o n P a r a m D t o . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  EconParamDto.cs
//  NAMESPACE: HenRepositories.Dto
//  CLASS(S):  EconParamDto
//  COMPONENT: _HenRepositories.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the EconParam Profile sub table.
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
    #region public class EconParamDto
    /// <summary>
    /// EconParam DTO Class
    /// </summary>
    public class EconParamDto
    {
        #region PROPERTIES
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public string CapitalCostIndexName { get; set; }
        public double CapitalCostIndexC1 { get; set; }
        public double CapitalCostIndexC2 { get; set; }
        public double CapitalCostIndexC3 { get; set; }
        public string CapitalCostIndexConfiguration { get; set; }
        public double RateOfReturn { get; set; }
        public int ProjectLifetime { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class EconParamDto
}
#endregion      // namespace HenRepositories.Dto

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
