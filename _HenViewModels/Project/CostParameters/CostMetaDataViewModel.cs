#region HEADER
//#####################################################################################################################
//##################################  C o s t M e t a D a t a V i e w M o d e l . c s  ################################
//#####################################################################################################################
//  FILENAME:  CostMetadataViewModel.cs
//  NAMESPACE: HenViewModel.Project.CostParameters
//  CLASS(S):  CostMetadataViewModel
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the Cost Metadata Project-Cost Parameters View Model.
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
using HenGlobal;

using HenModel.Connection;
using HenModel.Dto.Project.CostParameters;
using HenModel.RepoImplementations.Project.CostParameters;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenViewModel.Project.CostParameters
namespace HenViewModel.Project.CostParameters
{
    #region public class CostMetadataViewModel
    /// <summary>
    /// Cost Metadata view model class.
    /// </summary>
    public class CostMetadataViewModel : ViewModelBase
    {
        #region PROPERTIES
        public CostMetadataRepo CostMetadataRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public CostMetadataViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var costMetadataRepoObj = new CostMetadataRepo(connFactoryObj);

            CostMetadataRepoObj = costMetadataRepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // CTOR

        #region GetCostMetadata()
        /// <summary>
        /// Retrieves a list of all CostMetadata.
        /// </summary>
        /// <returns>A list of <see cref="CostMetadataDto"/> objects representing the available cost metadata, or an empty list if none are found.</returns>
        public IList<CostMetadataDto> GetCostMetadata()
        {
            try
            {
                return CostMetadataRepoObj.GetCostMetadata();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving cost metadata: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetCostMetadata()

        #region GetCostMetadataByProjectId(Guid projectId)
        /// <summary>
        /// Retrieves a list of all CostMetadata associated with the specified project identifier.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project whose cost metadata are to be retrieved.</param>
        /// <returns>A list of <see cref="CostMetadataDto"/> objects representing the matching cost metadata, or an empty list if none are found.</returns>
        public CostMetadataDto GetCostMetadataByProjectId(Guid projectId)
        {
            try
            {
                return CostMetadataRepoObj.GetCostMetadataByProjectId(projectId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving cost metadata: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetCostMetadataByProjectId(Guid projectId)

        #region GetCostMetadataById(Guid costMetadataId)
        /// <summary>
        /// Retrieves the CostMetadata DTO associated with the specified unique identifier.
        /// </summary>
        /// <param name="costMetadataId">The unique identifier of the CostMetadata to retrieve.</param>
        /// <returns>An <see cref="CostMetadataDto"/> representing the CostMetadata with the specified identifier. Returns null if none is found.</returns>
        public CostMetadataDto GetCostMetadataById(Guid costMetadataId)
        {
            try
            {
                return CostMetadataRepoObj.GetCostMetadataById(costMetadataId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving cost metadata: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetCostMetadataById(Guid costMetadataId)

        #region AddEconParam(EconParamDto econParamDto)
        /// <summary>
        /// Adds a new economic parameter to the database using the specified DTO.
        /// </summary>
        /// <param name="costMetadataDto">The cost metadata data to add.</param>
        /// <returns>A GUID representing the unique identifier of the newly added cost metadata.</returns>
        public Guid AddCostMetadata(CostMetadataDto costMetadataDto)
        {
            Guid costMetadataId = new Guid();
            try
            {
                costMetadataId = CostMetadataRepoObj.AddCostMetadata(costMetadataDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding cost metadata: {ex.Message}");
            }
            return costMetadataId;
        }
        #endregion  // AddCostMetadata(CostMetadataDto costMetadataDto)
        
        #region UpdateCostMetadata(CostMetadataDto costMetadataDto)
        /// <summary>
        /// Updates an existing cost metadata in the database using the specified DTO.
        /// </summary>
        /// <param name="costMetadataDto">The cost metadata DTO containing updated information.</param>
        public void UpdateCostMetadata(CostMetadataDto costMetadataDto)
        {
            try
            {
                CostMetadataRepoObj.UpdateCostMetadata(costMetadataDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating cost metadata: {ex.Message}");
            }
        }
        #endregion  // UpdateCostMetadata(CostMetadataDto costMetadataDto)

        #region DeleteCostMetadata(Guid costMetadataId)
        /// <summary>
        /// Deletes the cost metadata with the specified unique identifier.
        /// </summary>
        /// <param name="costMetadataId">The unique identifier of the cost metadata to delete.</param>
        public void DeleteCostMetadata(Guid costMetadataId)
        {
            try
            {
                CostMetadataRepoObj.DeleteCostMetadata(costMetadataId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting cost metadata: {ex.Message}");
            }
        }
        #endregion  // DeleteCostMetadata(Guid costMetadataId)

    }
    #endregion      // public class CostMetadataViewModel
}
#endregion      // namespace HenViewModel.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
