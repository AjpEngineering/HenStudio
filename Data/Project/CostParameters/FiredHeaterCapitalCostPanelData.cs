#region HEADER
//#####################################################################################################################
//######################  F i r e d H e a t e r C a p i t a l C o s t P a n e l D a t a . c s  ########################
//#####################################################################################################################
//  FILENAME:  FiredHeaterCapitalCostPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.CostParameters
//  CLASS(S):  FiredHeaterCapitalCostPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Fired Heater Capital Cost Panel Data object -
//    data needed for Fired Heater Capital Cost Panel.
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
    #region public class FiredHeaterCapitalCostPanelData
    public class FiredHeaterCapitalCostPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.CostParameters";
        const string CLASS = "FiredHeaterCapitalCostPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public FiredHeaterCapitalCostDto FiredHeaterCapitalCostDtoObj { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for FiredHeaterCapitalCostPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public FiredHeaterCapitalCostPanelData()
        {
            Id = new Guid();
            ProjectId = new Guid();
            FiredHeaterCapitalCostDtoObj = new FiredHeaterCapitalCostDto();
        }
        #endregion  // CTOR

    }
    #endregion      // public class FiredHeaterCapitalCostPanelData
}
#endregion  // namespace HenStudio.Data.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
