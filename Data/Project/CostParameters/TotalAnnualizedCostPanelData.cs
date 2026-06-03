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
        /// Creates a new total annualized cost data using the data in the TotalAnnualizedCostDtoObj property 
        /// and returns the ID of the newly created total annualized cost data.
        /// </summary>
        /// <returns>The ID of the newly created total annualized cost data.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the total annualized cost ID is null after creation.</exception>
        public Guid CreateTotalAnnualizedCostData()
        {
            TotalAnnualizedCostId = TotalAnnualizedCostViewModelObj.AddTotalAnnualizedCost(TotalAnnualizedCostDtoObj);
            if (TotalAnnualizedCostId == null) throw new ArgumentNullException(
                             nameof(TotalAnnualizedCostId),
                             "Total annualized cost ID is null for ADD Total Annualized Cost Panel data.");
            TotalAnnualizedCostDtoObj.Id = TotalAnnualizedCostId;
            return TotalAnnualizedCostId;  // Total Annualized Cost ID
        }
        #endregion  // CREATE TOTAL ANNUALIZED COST DATA METHOD

        #region READ TOTAL ANNUALIZED COST DATA METHOD
        /// <summary>
        /// Reads the total annualized cost data for the specified project ID 
        /// and populates the TotalAnnualizedCostDtoObj property with the retrieved data.
        /// </summary>
        /// <param name="projectId">The ID of the project to read.</param>
        /// <exception cref="ArgumentNullException">Thrown when the project ID is null.</exception>
        public void ReadTotalAnnualizedCostData(Guid projectId)
        {
            if (projectId == null) throw new ArgumentNullException(
                             nameof(projectId), "Project ID is null for READ Total Annualized Cost Panel data.");
            ProjectId = projectId;
            TotalAnnualizedCostDtoObj = TotalAnnualizedCostViewModelObj.GetTotalAnnualizedCostByProjectId(projectId);
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

        #endregion  // CRUD Methods
    }
    #endregion      // public class TotalAnnualizedCostPanelData
}
#endregion  // namespace HenStudio.Data.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
