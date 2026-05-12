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
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;
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

        #region COST METADATA CRUD METHODS

        #region AddCostMetadata(CostMetadataDto costMetadataDto) ... CREATE
        /// <summary>
        /// Adds (CREATE) a new cost metadata to the database using the specified DTO.
        /// </summary>
        /// <param name="costMetadataDto">The cost metadata data to add.</param>
        /// <returns>A GUID representing the unique identifier of the newly added cost metadata.</returns>
        public Guid AddCostMetadata(CostMetadataDto costMetadataDto)
        {
            Guid costMetadataId = new Guid();
            try
            {
                //------------------------------------------------------------------------
                //--- CostMetadataDto Dto [INTERNAL Units] to be Added to the Database ---
                //------------------------------------------------------------------------
                CostMetadataDto internalCostMetadataDto = new CostMetadataDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalCostMetadataDto.Id = costMetadataDto.Id;
                internalCostMetadataDto.ProjectId = costMetadataDto.ProjectId;
                internalCostMetadataDto.CostIndexBaseYear = costMetadataDto.CostIndexBaseYear;
                internalCostMetadataDto.CostIndexName = costMetadataDto.CostIndexName;
                internalCostMetadataDto.CostIndexValue = costMetadataDto.CostIndexValue;
                internalCostMetadataDto.CostIndexCurrency = costMetadataDto.CostIndexCurrency;
                internalCostMetadataDto.CostIndexInstalledCost = costMetadataDto.CostIndexInstalledCost;
                //---------------------------------------------------------------------------------------------
                //--- Add INTERNAL CostMetadata Dto to the Database using the CostMetadataRepo Object ---
                //--- Returns the CostMetadata ID (PK) from the CostMetadata Table database addition  ---
                //---------------------------------------------------------------------------------------------
                costMetadataId = CostMetadataRepoObj.AddCostMetadata(internalCostMetadataDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding cost metadata: {ex.Message}");
            }
            return costMetadataId;
        }
        #endregion  // AddCostMetadata(CostMetadataDto costMetadataDto) ... CREATE

        #region GetCostMetadataByProjectId(Guid projectId) ... READ
        /// <summary>
        /// Retrieves (READ) the CostMetadata Dto associated with the specified unique identifier.
        /// The CostMetadata retrieved from the Database is in INTERNAL Units, 
        /// database access performed by the repository layer, 
        /// the fields of the CostMetadata are converted to EXTERNAL Units, which are the units used in the user interface,
        /// the resulting CostMetadata Dto is returned as a <see cref="CostMetadataDto"/> object.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve.</param>
        /// <returns>A <see cref="CostMetadataDto"/> representing the CostMetadata with the specified identifier. 
        /// Returns null if no CostMetadata is found.</returns>
        public CostMetadataDto GetCostMetadataByProjectId(Guid projectId)
        {
            CostMetadataDto externalCostMetadataDto = new CostMetadataDto();
            try
            {
                //----------------------------------------------------------------
                //--- Retrieve CostMetadata Dto from the Database.             ---
                //--- The retrieved CostMetadata Dto is in INTERNAL Units,     ---
                //--- database access performed by the CostMetadataRepo Object ---
                //----------------------------------------------------------------
                CostMetadataDto internalCostMetadata =
                    CostMetadataRepoObj.GetCostMetadataByProjectId(projectId);

                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalCostMetadataDto.Id = internalCostMetadata.Id;
                externalCostMetadataDto.ProjectId = internalCostMetadata.ProjectId;
                externalCostMetadataDto.CostIndexBaseYear = internalCostMetadata.CostIndexBaseYear;
                externalCostMetadataDto.CostIndexName = internalCostMetadata.CostIndexName;
                externalCostMetadataDto.CostIndexValue = internalCostMetadata.CostIndexValue;
                externalCostMetadataDto.CostIndexCurrency = internalCostMetadata.CostIndexCurrency;
                externalCostMetadataDto.CostIndexInstalledCost = internalCostMetadata.CostIndexInstalledCost;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving cost metadata: {ex.Message}");
                return null;
            }

            return externalCostMetadataDto;
        }
        #endregion  // GetCostMetadataByProjectId(Guid projectId) ... READ

        #region UpdateCostMetadata(CostMetadataDto externalCostMetadataDto) ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing cost metadata in the database using the specified cost metadata data transfer object (DTO) 
        /// with external units.
        /// </summary>
        /// <remarks>This method converts the provided cost metadata data from external units to the internal
        /// units required by the database before updating the cost metadata. If the specified cost metadata does not exist,
        /// the behavior depends on the repository implementation.</remarks>
        /// <param name="externalCostMetadataDto">The cost metadata data transfer object containing updated cost metadata 
        /// information in external units. Cannot be null.</param>
        public void UpdateCostMetadata(CostMetadataDto externalCostMetadataDto)
        {
            try
            {
                //----------------------------------------------------------------------
                //--- Cost Metadata Dto [INTERNAL Units] to be Added to the Database ---
                //----------------------------------------------------------------------
                CostMetadataDto internalCostMetadataDto = new CostMetadataDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalCostMetadataDto.Id = externalCostMetadataDto.Id;
                internalCostMetadataDto.ProjectId = externalCostMetadataDto.ProjectId;
                internalCostMetadataDto.CostIndexBaseYear = externalCostMetadataDto.CostIndexBaseYear;
                internalCostMetadataDto.CostIndexName = externalCostMetadataDto.CostIndexName;
                internalCostMetadataDto.CostIndexValue = externalCostMetadataDto.CostIndexValue;
                internalCostMetadataDto.CostIndexCurrency = externalCostMetadataDto.CostIndexCurrency;
                internalCostMetadataDto.CostIndexInstalledCost = externalCostMetadataDto.CostIndexInstalledCost;
                //---------------------------------------------------------
                //--- UPDATE INTERNAL Cost Metadata Dto to the Database ---
                //--- The Cost Metadata to be updated is identified by  ---
                //--- the Id field of the provided Cost Metadata Dto    ---
                //---------------------------------------------------------
                CostMetadataRepoObj.UpdateCostMetadata(internalCostMetadataDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating cost metadata: {ex.Message}");
            }
        }
        #endregion  // UpdateCostMetadata(CostMetadataDto costMetadataDto) ... UPDATE

        #region DeleteCostMetadata(Guid costMetadataId) ... DELETE
        /// <summary>
        /// Deletes (DELETE) the cost metadata with the specified unique identifier.
        /// </summary>
        /// <param name="costMetadataId">The unique identifier of the cost metadata to delete.</param>
        public void DeleteCostMetadata(Guid costMetadataId)
        {
            try
            {
                //-----------------------------------------------------------------------------------------
                //--- DELETE Cost Metadata from the Database using the CostMetadataRepo Object          ---
                //--- The Cost Metadata to be deleted is identified by the provided costMetadataId (PK) ---
                //-----------------------------------------------------------------------------------------
                CostMetadataRepoObj.DeleteCostMetadata(costMetadataId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting cost metadata: {ex.Message}");
            }
        }
        #endregion  // DeleteCostMetadata(Guid costMetadataId) ... DELETE

        #endregion  // COST METADATA CRUD METHODS

    }
    #endregion      // public class CostMetadataViewModel
}
#endregion      // namespace HenViewModel.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
