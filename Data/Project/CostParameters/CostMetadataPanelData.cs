#region HEADER
//#####################################################################################################################
//################################  P r o j e c t U n i t s P a n e l D a t a . c s  ##################################
//#####################################################################################################################
//  FILENAME:  ProjectUnitsPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.CostParameters
//  CLASS(S):  ProjectUnitsPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Project Units Panel Data object - data needed for Project Units Panel.
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
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;

using HenViewModel.Project.CostParameters;
using HenViewModel.Project.DefaultParameters.OptimizerParams;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Project.CostParameters
namespace HenStudio.Data.Project.CostParameters
{
    #region public class CostMetadataPanelData
    public class CostMetadataPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.CostParameters";
        const string CLASS = "CostMetadataPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public Guid CostMetadataId { get; set; }
        public Guid ProjectId { get; set; }
        public CostMetadataDto CostMetadataDtoObj { get; set; }

        #region VIEW MODEL Object
        public CostMetadataViewModel CostMetadataViewModelObj { get; set; }
        #endregion  // VIEW MODEL Objects

        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for CostMetadataPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public CostMetadataPanelData()
        {
            CostMetadataId = new Guid();
            ProjectId = new Guid();
            CostMetadataDtoObj = new CostMetadataDto();
        }
        #endregion  // CTOR

        #region CRUD Methods

        #region CREATE COST METADATA DATA METHOD
        /// <summary>
        /// Creates a new cost metadata data using the data in the CostMetadataDtoObj property 
        /// and returns the ID of the newly created cost metadata data.
        /// </summary>
        /// <returns>The ID of the newly created cost metadata data.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the cost metadata ID is null after creation.</exception>
        public Guid CreateCostMetadataData()
        {
            CostMetadataId = CostMetadataViewModelObj.AddCostMetadata(CostMetadataDtoObj);
            if (CostMetadataId == null) throw new ArgumentNullException(
                             nameof(CostMetadataId), "Cost metadata ID is null for ADD Cost Metadata Panel data.");
            CostMetadataDtoObj.Id = CostMetadataId;
            return CostMetadataId;  // CostMetadata ID
        }
        #endregion  // CREATE COST METADATA DATA METHOD

        #region READ COST METADATA DATA METHOD
        /// <summary>
        /// Reads the cost metadata data for the specified project ID 
        /// and populates the CostMetadataDtoObj property with the retrieved data.
        /// </summary>
        /// <param name="projectId">The ID of the project to read.</param>
        /// <exception cref="ArgumentNullException">Thrown when the project ID is null.</exception>
        public void ReadCostMetadataData(Guid projectId)
        {
            if (projectId == null) throw new ArgumentNullException(
                             nameof(projectId), "Project ID is null for READ Cost Metadata Panel data.");
            ProjectId = projectId;
            CostMetadataDtoObj = CostMetadataViewModelObj.GetCostMetadataByProjectId(projectId);
        }
        #endregion  // READ COST METADATA DATA METHOD

        #region UPDATE COST METADATA DATA METHOD
        /// <summary>
        /// Updates the cost metadata data using the provided CostMetadataDto object 
        /// and returns the updated CostMetadataDto object.
        /// </summary>
        /// <param name="costMetadataDtoObj">The CostMetadataDto object containing 
        /// the updated cost metadata data.</param>
        /// <returns>The updated CostMetadataDto object.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the cost metadata DTO or its ID is null.</exception>
        public CostMetadataDto UpdateCostMetadataData(CostMetadataDto costMetadataDtoObj)
        {
            if (costMetadataDtoObj == null) throw new ArgumentNullException(
                             nameof(costMetadataDtoObj), "Cost Metadata DTO is null for UPDATE Cost Metadata Panel data.");

            if (costMetadataDtoObj.Id == null) throw new ArgumentNullException(
                             nameof(costMetadataDtoObj), "Cost Metadata DTO ID is null for UPDATE Cost Metadata Panel data.");

            if (costMetadataDtoObj.ProjectId == null) throw new ArgumentNullException(
                             nameof(costMetadataDtoObj), "Cost Metadata DTO Project ID is null for UPDATE Cost Metadata Panel data.");

            CostMetadataId = costMetadataDtoObj.Id;
            ProjectId = costMetadataDtoObj.ProjectId;
            CostMetadataDtoObj = costMetadataDtoObj;
            CostMetadataViewModelObj.UpdateCostMetadata(costMetadataDtoObj);
            return CostMetadataDtoObj;
        }
        #endregion  // UPDATE PROJECT DATA METHOD

        #region DELETE COST METADATA DATA METHOD
        //---------------------------------------------------------------
        //--- DELETE method is not needed for Cost Metadata data      ---
        //--- as it is a one-to-one relationship with the Project and ---
        //--- should be deleted when the Project is deleted.          ---
        //--- Part of Cascade DELETE functionality.                   ---
        //---------------------------------------------------------------
        #endregion  // DELETE COST METADATA DATA METHOD

        #endregion  // CRUD Methods

    }
    #endregion      // public class CostMetadataPanelData
}
#endregion  // namespace HenStudio.Data.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
