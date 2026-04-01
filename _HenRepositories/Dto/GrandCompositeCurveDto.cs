#region HEADER
//#####################################################################################################################
//###############################  G r a n d C o m p o s i t e C u r v e D t o . c s  #################################
//#####################################################################################################################
//  FILENAME:  GrandCompositeCurveDto.cs
//  NAMESPACE: HenRepositories.Dto
//  CLASS(S):  GrandCompositeCurveDto
//  COMPONENT: _HenRepositories.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the GrandCompositeCurve Pinch sub table.
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
    #region public class GrandCompositeCurveDto
    /// <summary>
    /// GrandCompositeCurve DTO Class
    /// </summary>
    public class GrandCompositeCurveDto
    {
        #region PROPERTIES
        public Guid Id { get; set; }
        public Guid PinchId { get; set; }
        public string CurveSubtype { get; set; }
        public string Title { get; set; }
        public string XAxisLabel { get; set; }
        public string YAxisLabel { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class GrandCompositeCurveDto
}
#endregion      // namespace HenRepositories.Dto

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
