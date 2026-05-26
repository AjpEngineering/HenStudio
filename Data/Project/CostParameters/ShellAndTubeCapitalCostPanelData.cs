#region HEADER
//#####################################################################################################################
//#####################  S h e l l A n d T u b e C a p i t a l C o s t P a n e l D a t a . c s  #######################
//#####################################################################################################################
//  FILENAME:  ShellAndTubeCapitalCostPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.CostParameters
//  CLASS(S):  ShellAndTubeCapitalCostPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Shell and Tube Capital Cost Panel Data object -
//    data needed for Shell and Tube Capital Cost Panel.
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
//    01/01/26 .. pg .. Version 4.0
//#####################################################################################################################
//#####################################################################################################################
//#####################################################################################################################
#endregion      // HEADER

#region REFERENCES
using HenModel.Dto.Project.CostParameters;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Project.CostParameters
namespace HenStudio.Data.Project.CostParameters
{
    #region public class ShellAndTubeCapitalCostPanelData
    public class ShellAndTubeCapitalCostPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.CostParameters";
        const string CLASS = "ShellAndTubeCapitalCostPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public ShellAndTubeCapitalCostDto ShellAndTubeCapitalCostDtoObj { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for ShellAndTubeCapitalCostPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public ShellAndTubeCapitalCostPanelData()
        {
            Id = new Guid();
            ProjectId = new Guid();
            ShellAndTubeCapitalCostDtoObj = new ShellAndTubeCapitalCostDto();
        }
        #endregion  // CTOR

    }
    #endregion      // public class ShellAndTubeCapitalCostPanelData
}
#endregion  // namespace HenStudio.Data.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
