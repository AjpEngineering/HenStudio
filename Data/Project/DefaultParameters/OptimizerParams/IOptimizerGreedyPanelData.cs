#region HEADER
//#####################################################################################################################
//##############################  I O p t i m i z e r G r e e d y P a n e l D a t a . c s  ##########################
//#####################################################################################################################
//  FILENAME:  IOptimizerGreedyPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.DefaultParameters.OptimizerParams
//  INTERFACE: IOptimizerGreedyPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the Optimizer Greedy Params Panel interface for the Optimizer Greedy parameters.
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
    #region public interface IOptimizerGreedyPanelData
    /// <summary>
    /// Optimizer Greedy Params Panel Interface
    /// </summary>
    public interface IOptimizerGreedyPanelData
    {
        #region METHODS
        OptimizerGreedyPanelData ConvertToPanelData(OptimizerGreedyDto optimizerGreedyDto);
        OptimizerGreedyDto ConvertFromPanelData();
        #endregion      // METHODS
    }
    #endregion      // public interface IOptimizerGreedyPanelData
}
#endregion      // namespace HenStudio.Data.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
