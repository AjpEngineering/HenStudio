#region HEADER
//#####################################################################################################################
//#########################################  G r i d D i a g r a m D t o . c s  #######################################
//#####################################################################################################################
//  FILENAME:  GridDiagramDto.cs
//  NAMESPACE: HenModel.Dto.Hen.Plots
//  CLASS(S):  GridDiagramDto
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the GridDiagram Hen sub table.
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

#region namespace HenModel.Dto.Hen.Plots
namespace HenModel.Dto.Hen.Plots
{
    #region public class GridDiagramDto
    /// <summary>
    /// GridDiagram DTO Class
    /// </summary>
    public class GridDiagramDto
    {
        #region PROPERTIES
        public Guid Id { get; set; }
        public Guid HenId { get; set; }
        public string Title { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class GridDiagramDto
}
#endregion      // namespace HenModel.Dto.Hen.Plots

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
