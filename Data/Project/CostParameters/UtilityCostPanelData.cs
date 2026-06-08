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
        /// NOTE: Project ID is assigned in UtilityCost DTO 
        /// </summary>
        /// <param name="utilityCostDtoObj">Utility Cost DTO object</param>
        /// <returns>The Utility Cost ID of the newly created Utility Cost data.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the Utility Cost ID is null after creation.</exception>
        public Guid CreateUtilityCostData(UtilityCostDto utilityCostDtoObj)
        {
            if (utilityCostDtoObj == null) throw new ArgumentNullException(
                      nameof(utilityCostDtoObj),
                      "Utility Cost DTO Object is null for Create Utility Cost Panel data.");
            //-----------------------------------------------------
            //--- Add Utility Cost data and get Utility Cost ID ---
            //--- associated with the newly created Data        ---
            //-----------------------------------------------------
            Guid utilityCostId = UtilityCostViewModelObj.AddUtilityCost(utilityCostDtoObj);

            if (utilityCostId == null) throw new ArgumentNullException(
                                 nameof(utilityCostId),
                                 "Utility cost ID is null for ADD Utility Cost Panel data.");
            //-----------------------------------------------------------------
            //--- Assign the returned Total Annualize Cost ID and return it ---
            //-----------------------------------------------------------------
            UtilityCostId = utilityCostId;
            UtilityCostDtoObj.Id = utilityCostId;
            UtilityCostDtoObj = utilityCostDtoObj;
            return utilityCostId;
        }
        #endregion  // CREATE UTILITY COST DATA METHOD

        #region READ UTILITY COST DATA METHOD
        /// <summary>
        /// Reads the utility cost data for the specified project ID 
        /// and populates the UtilityCostDtoObj property with the retrieved data.
        /// </summary>
        /// <param name="projectId">The ID of the project to read.</param>
        /// <returns>Utility Cost DTO object</returns>
        /// <exception cref="ArgumentNullException">Thrown when the project ID is null.</exception>
        public UtilityCostDto ReadUtilityCostData(Guid projectId)
        {
            if (projectId == null) throw new ArgumentNullException(
                             nameof(projectId), 
                             "Project ID is null for READ Utility Cost Panel data.");

            ProjectId = projectId;

            UtilityCostDto utilityCostDtoObj =
                    UtilityCostDtoObj = UtilityCostViewModelObj.GetUtilityCostByProjectId(projectId);

            UtilityCostDtoObj = utilityCostDtoObj;
            return utilityCostDtoObj;            
        }
        #endregion  // READ UTILITY COST DATA METHOD

        #region UPDATE UTILITY COST DATA METHOD
        /// <summary>
        /// Updates the utility cost data using the provided UtilityCostDto object 
        /// and returns the updated UtilityCostDto object.
        /// </summary>
        /// <param name="utilityCostDtoObj">The UtilityCostDto object containing 
        /// the updated utility cost data.</param>
        /// <returns>The updated UtilityCostDto object.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the utility cost DTO or its ID is null.</exception>
        public UtilityCostDto UpdateUtilityCostData(UtilityCostDto utilityCostDtoObj)
        {
            if (utilityCostDtoObj == null) throw new ArgumentNullException(
                             nameof(utilityCostDtoObj),
                             "Utility Cost DTO is null for UPDATE Utility Cost Panel data.");

            if (utilityCostDtoObj.Id == null) throw new ArgumentNullException(
                             nameof(utilityCostDtoObj),
                             "Utility Cost DTO ID is null for UPDATE Utility Cost Panel data.");

            if (utilityCostDtoObj.ProjectId == null) throw new ArgumentNullException(
                             nameof(utilityCostDtoObj),
                             "Utility Cost DTO Project ID is null for UPDATE Utility Cost Panel data.");

            UtilityCostId = utilityCostDtoObj.Id;
            ProjectId = utilityCostDtoObj.ProjectId;
            UtilityCostDtoObj = utilityCostDtoObj;
            UtilityCostViewModelObj.UpdateUtilityCost(utilityCostDtoObj);
            return UtilityCostDtoObj;
        }
        #endregion  // UPDATE PROJECT DATA METHOD

        #region DELETE UTILITY COST DATA METHOD
        //-------------------------------------------------------------------
        //--- DELETE method is not needed for Utility Cost data as it     ---
        //--- is a one-to-one relationship with the Project and should be ---
        //--- deleted when the Project is deleted.                        ---
        //--- Part of Cascade DELETE functionality.                       ---
        //-------------------------------------------------------------------
        #endregion  // DELETE UTILITY COST DATA METHOD

        #endregion  // CRUD Methods

    }
    #endregion      // public class UtilityCostPanelData
}
#endregion  // namespace HenStudio.Data.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
