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
    #region public class FiredHeaterCapitalCostPanelData
    public class FiredHeaterCapitalCostPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.CostParameters";
        const string CLASS = "FiredHeaterCapitalCostPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public Guid FiredHeaterCapitalCostId { get; set; }
        public Guid ProjectId { get; set; }
        public FiredHeaterCapitalCostDto FiredHeaterCapitalCostDtoObj { get; set; }

        #region VIEW MODEL Object
        public FiredHeaterCapitalCostViewModel FiredHeaterCapitalCostViewModelObj { get; set; }
        #endregion  // VIEW MODEL Objects

        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for FiredHeaterCapitalCostPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public FiredHeaterCapitalCostPanelData()
        {
            FiredHeaterCapitalCostId = new Guid();
            ProjectId = new Guid();
            FiredHeaterCapitalCostDtoObj = new FiredHeaterCapitalCostDto();
        }
        #endregion  // CTOR

        #region CRUD Methods

        #region CREATE FIRED HEATER CAPITAL COST DATA METHOD
        /// <summary>
        /// Creates a new fired heater capital cost data using the data in the FiredHeaterCapitalCostDtoObj property 
        /// and returns the ID of the newly created fired heater capital cost data.
        /// </summary>
        /// <returns>The ID of the newly created fired heater capital cost data.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the fired heater capital cost ID is null after creation.</exception>
        public Guid CreateFiredHeaterCapitalCostData()
        {
            FiredHeaterCapitalCostId = FiredHeaterCapitalCostViewModelObj.AddFiredHeaterCapitalCost(FiredHeaterCapitalCostDtoObj);
            if (FiredHeaterCapitalCostId == null) throw new ArgumentNullException(
                             nameof(FiredHeaterCapitalCostId), "Fired heater capital cost ID is null for ADD Fired Heater Capital Cost Panel data.");
            FiredHeaterCapitalCostDtoObj.Id = FiredHeaterCapitalCostId;
            return FiredHeaterCapitalCostId;  // Fired Heater Capital Cost ID
        }
        #endregion  // CREATE FIRED HEATER CAPITAL COST DATA METHOD

        #region READ FIRED HEATER CAPITAL COST DATA METHOD
        /// <summary>
        /// Reads the fired heater capital cost data for the specified project ID 
        /// and populates the FiredHeaterCapitalCostDtoObj property with the retrieved data.
        /// </summary>
        /// <param name="projectId">The ID of the project to read.</param>
        /// <exception cref="ArgumentNullException">Thrown when the project ID is null.</exception>
        public void ReadFiredHeaterCapitalCostData(Guid projectId)
        {
            if (projectId == null) throw new ArgumentNullException(
                             nameof(projectId), "Project ID is null for READ Fired Heater Capital Cost Panel data.");
            ProjectId = projectId;
            FiredHeaterCapitalCostDtoObj = FiredHeaterCapitalCostViewModelObj.GetFiredHeaterCapitalCostByProjectId(projectId);
        }
        #endregion  // READ FIRED HEATER CAPITAL COST DATA METHOD

        #region UPDATE FIRED HEATER CAPITAL COST DATA METHOD
        /// <summary>
        /// Updates the fired heater capital cost data using the provided FiredHeaterCapitalCostDto object 
        /// and returns the updated FiredHeaterCapitalCostDto object.
        /// </summary>
        /// <param name="firedHeaterCapitalCostDtoObj">The FiredHeaterCapitalCostDto object containing 
        /// the updated fired heater capital cost data.</param>
        /// <returns>The updated FiredHeaterCapitalCostDto object.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the fired heater capital cost DTO or its ID is null.</exception>
        public FiredHeaterCapitalCostDto UpdateFiredHeaterCapitalCostData(FiredHeaterCapitalCostDto firedHeaterCapitalCostDtoObj)
        {
            if (firedHeaterCapitalCostDtoObj == null) throw new ArgumentNullException(
                             nameof(firedHeaterCapitalCostDtoObj), 
                             "Fired Heater Capital Cost DTO is null for UPDATE Fired Heater Capital Cost Panel data.");

            if (firedHeaterCapitalCostDtoObj.Id == null) throw new ArgumentNullException(
                             nameof(firedHeaterCapitalCostDtoObj), 
                             "Fired Heater Capital Cost DTO ID is null for UPDATE Fired Heater Capital Cost Panel data.");

            if (firedHeaterCapitalCostDtoObj.ProjectId == null) throw new ArgumentNullException(
                             nameof(firedHeaterCapitalCostDtoObj), 
                             "Fired Heater Capital Cost DTO Project ID is null for UPDATE Fired Heater Capital Cost Panel data.");

            FiredHeaterCapitalCostId = firedHeaterCapitalCostDtoObj.Id;
            ProjectId = firedHeaterCapitalCostDtoObj.ProjectId;
            FiredHeaterCapitalCostDtoObj = firedHeaterCapitalCostDtoObj;
            FiredHeaterCapitalCostViewModelObj.UpdateFiredHeaterCapitalCost(firedHeaterCapitalCostDtoObj);
            return FiredHeaterCapitalCostDtoObj;
        }
        #endregion  // UPDATE PROJECT DATA METHOD

        #region DELETE FIRED HEATER CAPITAL COST DATA METHOD
        //--------------------------------------------------------------------
        //--- DELETE method is not needed for Fired Heater Capital Cost    ---
        //--- data as it is a one-to-one relationship with the Project and ---
        //--- should be deleted when the Project is deleted.               ---
        //--- Part of Cascade DELETE functionality.                        ---
        //--------------------------------------------------------------------
        #endregion  // DELETE FIRED HEATER CAPITAL COST DATA METHOD

        #endregion  // CRUD Methods

    }
    #endregion      // public class FiredHeaterCapitalCostPanelData
}
#endregion  // namespace HenStudio.Data.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
