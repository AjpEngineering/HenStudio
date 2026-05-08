#region HEADER
//#####################################################################################################################
//##############################  I O p t i m i z e r M I L P P a n e l D a t a . c s  ##########################
//#####################################################################################################################
//  FILENAME:  IOptimizerMILP_PanelData.cs
//  NAMESPACE: HenStudio.Data.Project.DefaultParameters.OptimizerParams
//  INTERFACE: IOptimizerMILP_PanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the Optimizer MILP Params Panel interface for the Optimizer MILP parameters.
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
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenStudio.Data.Project.DefaultParameters.OptimizerParams
namespace HenStudio.Data.Project.DefaultParameters.OptimizerParams
{
    #region public interface IOptimizerMILP_PanelData
    /// <summary>
    /// Optimizer MILP Params Panel Interface
    /// </summary>
    public interface IOptimizerMILP_PanelData
    {
        #region METHODS
        OptimizerMILP_PanelData ConvertToPanelData(OptimizerMILP_Dto optimizerMILP_Dto);
        OptimizerMILP_Dto ConvertFromPanelData();
        #endregion      // METHODS
    }
    #endregion      // public interface IOptimizerMILP_PanelData
}
#endregion      // namespace HenStudio.Data.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
