#region HEADER
//#####################################################################################################################
//#########################  T o t a l A n n u a l i z e d C o s t P a n e l D a t a . c s  ###########################
//#####################################################################################################################
//  FILENAME:  TotalAnnualizedCostPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.CostParameters
//  CLASS(S):  TotalAnnualizedCostPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Total Annualized Cost Panel Data object -
//    data needed for Total Annualized Cost Panel.
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
    #region public class TotalAnnualizedCostPanelData
    public class TotalAnnualizedCostPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.CostParameters";
        const string CLASS = "TotalAnnualizedCostPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public Guid TotalAnnualizedCostId { get; set; }
        public Guid ProjectId { get; set; }
        public TotalAnnualizedCostDto TotalAnnualizedCostDtoObj { get; set; }

        #region VIEW MODEL Object
        public TotalAnnualizedCostViewModel TotalAnnualizedCostViewModelObj { get; set; }
        #endregion  // VIEW MODEL Objects

        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for FiredHeaterCapitalCostPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public TotalAnnualizedCostPanelData()
        {
            TotalAnnualizedCostId = new Guid();
            ProjectId = new Guid();
            TotalAnnualizedCostDtoObj = new TotalAnnualizedCostDto();
        }
        #endregion  // CTOR

        #region CRUD Methods

        #region CREATE TOTAL ANNUALIZED COST DATA METHOD
        /// <summary>
        /// Creates a new total annualized cost data using 
        /// the data in the TotalAnnualizedCostDtoObj property 
        /// and returns the Total Annualize CostID of the newly created total annualized cost data.
        /// NOTE: Project ID is assigned in TotalAnnualizedCost DTO 
        /// object before method invocation
        /// </summary>
        /// <param name="totalAnnualizedCostDtoObj">Total Annualize Cost DTO object</param>
        /// <returns>The Total Annualize Cost ID of the newly created total annualized cost data.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the
        /// total annualized cost ID is null after creation.</exception>
        public Guid CreateTotalAnnualizedCostData(TotalAnnualizedCostDto totalAnnualizedCostDtoObj)
        {
            if (totalAnnualizedCostDtoObj == null) throw new ArgumentNullException(
                      nameof(totalAnnualizedCostDtoObj),
                      "Total Annualize Cost DTO Object is null for Create Total Annualize Cost Panel data.");
            //----------------------------------------------
            //--- Add Total Annualize Cost data and      ---
            //--- get Total Annualize Cost ID            ---
            //--- associated with the newly created Data ---
            //----------------------------------------------
            Guid totalAnnualizedCostId = TotalAnnualizedCostViewModelObj.AddTotalAnnualizedCost(totalAnnualizedCostDtoObj);

            if (totalAnnualizedCostId == null) throw new ArgumentNullException(
                      nameof(totalAnnualizedCostId),
                      "Total annualized cost ID is null for ADD Total Annualized Cost Panel data.");
            //-----------------------------------------------------------------
            //--- Assign the returned Total Annualize Cost ID and return it ---
            //-----------------------------------------------------------------
            TotalAnnualizedCostId = totalAnnualizedCostId;
            TotalAnnualizedCostDtoObj.Id = totalAnnualizedCostId;
            TotalAnnualizedCostDtoObj = totalAnnualizedCostDtoObj;
            return totalAnnualizedCostId;
        }
        #endregion  // CREATE TOTAL ANNUALIZED COST DATA METHOD

        #region READ TOTAL ANNUALIZED COST DATA METHOD
        /// <summary>
        /// Reads the total annualized cost data for the specified project ID 
        /// and populates the TotalAnnualizedCostDtoObj property with the retrieved data.
        /// </summary>
        /// <param name="projectId">The ID of the project to read.</param>
        /// <returns>Total Annualized Cost DTO object</returns>
        /// <exception cref="ArgumentNullException">Thrown when the project ID is null.</exception>
        public TotalAnnualizedCostDto ReadTotalAnnualizedCostData(Guid projectId)
        {
            if (projectId == null) throw new ArgumentNullException(
                             nameof(projectId), 
                             "Project ID is null for READ Total Annualized Cost Panel data.");

            ProjectId = projectId;

            TotalAnnualizedCostDto totalAnnualizedCostDtoObj =
                    TotalAnnualizedCostViewModelObj.GetTotalAnnualizedCostByProjectId(projectId);

            if (totalAnnualizedCostDtoObj == null) throw new ArgumentNullException(
                    nameof(totalAnnualizedCostDtoObj),
                    "Total Annualized Cost is null for READ Total Annualized Cost Panel data.");

            TotalAnnualizedCostDtoObj = totalAnnualizedCostDtoObj;
            return totalAnnualizedCostDtoObj;
        }
        #endregion  // READ TOTAL ANNUALIZED COST DATA METHOD

        #region UPDATE TOTAL ANNUALIZED COST DATA METHOD
        /// <summary>
        /// Updates the total annualized cost data using the provided TotalAnnualizedCostDto object 
        /// and returns the updated TotalAnnualizedCostDto object.
        /// </summary>
        /// <param name="totalAnnualizedCostDtoObj">The TotalAnnualizedCostDto object containing 
        /// the updated total annualized cost data.</param>
        /// <returns>The updated TotalAnnualizedCostDto object.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the total annualized cost DTO or its ID is null.</exception>
        public TotalAnnualizedCostDto UpdateTotalAnnualizedCostData(TotalAnnualizedCostDto totalAnnualizedCostDtoObj)
        {
            if (totalAnnualizedCostDtoObj == null) throw new ArgumentNullException(
                             nameof(totalAnnualizedCostDtoObj),
                             "Total Annualized Cost DTO is null for UPDATE Total Annualized Cost Panel data.");

            if (totalAnnualizedCostDtoObj.Id == null) throw new ArgumentNullException(
                             nameof(totalAnnualizedCostDtoObj),
                             "Total Annualized Cost DTO ID is null for UPDATE Total Annualized Cost Panel data.");

            if (totalAnnualizedCostDtoObj.ProjectId == null) throw new ArgumentNullException(
                             nameof(totalAnnualizedCostDtoObj),
                             "Total Annualized Cost DTO Project ID is null for UPDATE Total Annualized Cost Panel data.");

            TotalAnnualizedCostId = totalAnnualizedCostDtoObj.Id;
            ProjectId = totalAnnualizedCostDtoObj.ProjectId;
            TotalAnnualizedCostDtoObj = totalAnnualizedCostDtoObj;
            TotalAnnualizedCostViewModelObj.UpdateTotalAnnualizedCost(totalAnnualizedCostDtoObj);
            return TotalAnnualizedCostDtoObj;
        }
        #endregion  // UPDATE PROJECT DATA METHOD

        #region DELETE TOTAL ANNUALIZED COST DATA METHOD
        //------------------------------------------------------------------
        //--- DELETE method is not needed for Total Annualized Cost data ---
        //--- as it is a one-to-one relationship with the Project and    ---
        //--- should be deleted when the Project is deleted.             ---
        //--- Part of Cascade DELETE functionality.                      ---
        //------------------------------------------------------------------
        #endregion  // DELETE TOTAL ANNUALIZED COST DATA METHOD

        #endregion  // CRUD Methods
    }
    #endregion      // public class TotalAnnualizedCostPanelData
}
#endregion  // namespace HenStudio.Data.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
