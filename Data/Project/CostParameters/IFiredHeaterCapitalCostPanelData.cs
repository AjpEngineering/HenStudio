#region HEADER
//#####################################################################################################################
//########################  I F i r e d H e a t e r C a p i t a l C o s t P a n e l D a t a . c s  ####################
//#####################################################################################################################
//  FILENAME:  IFiredHeaterCapitalCostPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.CostParameters
//  INTERFACE: IFiredHeaterCapitalCostPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the Fired Heater Capital Cost Panel interface for the Cost parameters.
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
using HenModel.Dto.Project.CostParameters;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenStudio.Data.Project.CostParameters
namespace HenStudio.Data.Project.CostParameters
{
    #region public interface IFiredHeaterCapitalCostPanelData
    /// <summary>
    /// Fired Heater Capital Cost Panel Interface
    /// </summary>
    public interface IFiredHeaterCapitalCostPanelData
    {
        #region METHODS
        FiredHeaterCapitalCostPanelData ConvertToPanelData(FiredHeaterCapitalCostDto firedHeaterCapitalCostDto);
        FiredHeaterCapitalCostDto ConvertFromPanelData();
        #endregion      // METHODS
    }
    #endregion      // public interface IFiredHeaterCapitalCostPanelData
}
#endregion      // namespace HenStudio.Data.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
