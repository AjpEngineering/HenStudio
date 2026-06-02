#region HEADER
//#####################################################################################################################
//#################################  U t i l i t y C o s t P a n e l D a t a . c s  ###################################
//#####################################################################################################################
//  FILENAME:  UtilityCostPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.CostParameters
//  CLASS(S):  UtilityCostPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Utility Cost Panel Data object - data needed for Utility Cost Panel.
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

using HenViewModel.Project.CostParameters;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Project.CostParameters
namespace HenStudio.Data.Project.CostParameters
{
    #region public class UtilityCostPanelData
    public class UtilityCostPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.CostParameters";
        const string CLASS = "UtilityCostPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public Guid UtilityCostId { get; set; }
        public Guid ProjectId { get; set; }
        public UtilityCostDto UtilityCostDtoObj { get; set; }

        #region VIEW MODEL Object
        public UtilityCostViewModel UtilityCostViewModelObj { get; set; }
        #endregion  // VIEW MODEL Objects

        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for UtilityCostPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public UtilityCostPanelData()
        {
            UtilityCostId = new Guid();
            ProjectId = new Guid();
            UtilityCostDtoObj = new UtilityCostDto();
        }
        #endregion  // CTOR

        #region CRUD Methods

        #region CREATE UTILITY COST DATA METHOD
        /// <summary>
        /// Creates a new utility cost data using the data in the UtilityCostDtoObj property 
        /// and returns the ID of the newly created utility cost data.
        /// </summary>
        /// <returns>The ID of the newly created Utility Cost data.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the Utility Cost ID is null after creation.</exception>
        public Guid CreateUtilityCostData()
        {
            UtilityCostId = UtilityCostViewModelObj.AddUtilityCost(UtilityCostDtoObj);
            if (UtilityCostId == null) throw new ArgumentNullException(
                             nameof(UtilityCostId),
                             "Utility cost ID is null for ADD Utility Cost Panel data.");
            UtilityCostDtoObj.Id = UtilityCostId;
            return UtilityCostId;  // Total Annualized Cost ID
        }
        #endregion  // CREATE UTILITY COST DATA METHOD


        #endregion  // CRUD Methods

    }
    #endregion      // public class UtilityCostPanelData
}
#endregion  // namespace HenStudio.Data.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
