#region HEADER
//#####################################################################################################################
//#######################################  C o s t M e t a d a t a D t o . c s  #######################################
//#####################################################################################################################
//  FILENAME:  CostMetadataDto.cs
//  NAMESPACE: HenRepositories.Dto
//  CLASS(S):  CostMetadataDto
//  COMPONENT: _HenRepositories.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the CostMetadataDto Project-Cost Params sub table.
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
    #region public class CostMetadataDto
    /// <summary>
    /// Cost Metadata DTO Class
    /// </summary>
    public class CostMetadataDto
    {
        #region PROPERTIES
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public string CostIndexBaseYear { get; set; }
        public string CostIndexName { get; set; }
        public double CostIndexValue { get; set; }
        public string CostIndexCurrency { get; set; }
        public double CostIndexInstalledCost { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class CostMetadataDto
}
#endregion      // namespace HenRepositories.Dto

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
