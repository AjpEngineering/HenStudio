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
//    This file contains the view model class for the Cost Metadata Parameters View Model.
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

        #region PRIVATE DTO CONVERSION METHODS

        #region ConvertToExternalDto(CostMetadataDto internalDto)
        /// <summary>
        /// Converts a Cost Metadata DTO from INTERNAL units to EXTERNAL units.
        /// </summary>
        /// <param name="internalDto">The Cost Metadata DTO in INTERNAL units.</param>
        /// <returns>A <see cref="CostMetadataDto"/> DTO in EXTERNAL units.</returns>
        private CostMetadataDto ConvertToExternalDto(CostMetadataDto internalDto)
        {
            //-------------------------- Null DTO Guard ----------------------------
            //--- If the user provided DTO is null,                              ---
            //--- Then return null to indicate that there is nothing to convert. ---
            //--- This prevents potential null reference exceptions when trying  ---
            //--- to access properties of a null object.                         ---
            //----------------------------------------------------------------------
            if (internalDto == null)
            {
                return null;
            }
            //------------------------------ Create EXTERNAL DTO -----------------------------------
            //--- Create a new DTO object to hold the converted values in EXTERNAL units.        ---
            //--- This object will be populated with the converted values from the INTERNAL DTO. ---
            //--------------------------------------------------------------------------------------
            CostMetadataDto externalDto = new CostMetadataDto();
            //---------------------------------------------------------
            //--- Convert INTERNAL DTO Fields to EXTERNAL DTO Units ---
            //---------------------------------------------------------
            externalDto.Id = internalDto.Id;
            externalDto.ProjectId = internalDto.ProjectId;

            externalDto.CostIndexBaseYear      = internalDto.CostIndexBaseYear;
            externalDto.CostIndexName          = internalDto.CostIndexName;
            externalDto.CostIndexValue         = internalDto.CostIndexValue;
            externalDto.CostIndexCurrency      = internalDto.CostIndexCurrency;
            externalDto.CostIndexInstalledCost = internalDto.CostIndexInstalledCost;
            //--------------------------------------------------
            //--- Return the EXTERNAL DTO in EXTERNAL units. ---
            //--------------------------------------------------
            return externalDto;
        }
        #endregion  // ConvertToExternalDto(CostMetadataDto internalDto)

        #region ConvertToInternalDto(CostMetadataDto externalDto)
        /// <summary>
        /// Converts a Cost Metadata DTO from EXTERNAL units to INTERNAL units.
        /// </summary>
        /// <param name="externalDto">The Cost Metadata DTO in EXTERNAL units.</param>
        /// <returns>A <see cref="CostMetadataDto"/> DTO in INTERNAL units.</returns>
        private CostMetadataDto ConvertToInternalDto(CostMetadataDto externalDto)
        {
            //-------------------------- Null DTO Guard ----------------------------
            //--- If the user provided DTO is null,                              ---
            //--- Then return null to indicate that there is nothing to convert. ---
            //--- This prevents potential null reference exceptions when trying  ---
            //--- to access properties of a null object.                         ---
            //----------------------------------------------------------------------
            if (externalDto == null)
            {
                return null;
            }
            //------------------------------ Create INTERNAL DTO -----------------------------------
            //--- Create a new DTO object to hold the converted values in INTERNAL units.        ---
            //--- This object will be populated with the converted values from the EXTERNAL DTO. ---
            //--------------------------------------------------------------------------------------
            CostMetadataDto internalDto = new CostMetadataDto();
            //-------------------------------------------------
            //--- Convert EXTERNAL Fields to INTERNAL Units ---
            //-------------------------------------------------
            internalDto.Id = externalDto.Id;
            internalDto.ProjectId = externalDto.ProjectId;

            internalDto.CostIndexBaseYear      = externalDto.CostIndexBaseYear;
            internalDto.CostIndexName          = externalDto.CostIndexName;
            internalDto.CostIndexValue         = externalDto.CostIndexValue;
            internalDto.CostIndexCurrency      = externalDto.CostIndexCurrency;
            internalDto.CostIndexInstalledCost = externalDto.CostIndexInstalledCost;
            //--------------------------------------------------
            //--- Return the INTERNAL DTO in INTERNAL units. ---
            //--------------------------------------------------
            return internalDto;
        }
        #endregion  // ConvertToInternalDto(CostMetadataDto externalDto)

        #endregion  // PRIVATE DTO CONVERSION METHODS

        #region COST METADATA CRUD METHODS

        #region AddCostMetadata(CostMetadataDto costMetadataDto) ... CREATE
        /// <summary>
        /// Adds (CREATE) a new cost metadata to the database using the specified DTO.
        /// </summary>
        /// <param name="externalCostMetadataDto">The cost metadata data to add.</param>
        /// <returns>A GUID representing the unique identifier of the newly added cost metadata.</returns>
        public Guid AddCostMetadata(CostMetadataDto externalCostMetadataDto)
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
                internalCostMetadataDto = ConvertToInternalDto(externalCostMetadataDto);
                //---------------------------------------------------------------------------------------
                //--- Add INTERNAL CostMetadata Dto to the Database using the CostMetadataRepo Object ---
                //--- Returns the CostMetadata ID (PK) from the CostMetadata Table database addition  ---
                //---------------------------------------------------------------------------------------
                costMetadataId = CostMetadataRepoObj.AddCostMetadata(internalCostMetadataDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding cost metadata: {ex.Message}");
            }
            //------------------------------------------------------------------------------------
            //--- Return the CostMetadata ID (PK) from the Database addition.                  ---
            //--- This ID can be used for further operations on the newly added cost metadata. ---
            //--- If the addition failed, the returned GUID will be empty (all zeros).         ---
            //------------------------------------------------------------------------------------
            return costMetadataId;
        }
        #endregion  // AddCostMetadata(CostMetadataDto costMetadataDto) ... CREATE

        #region GetCostMetadataByProjectId(Guid projectId) ... READ
        /// <summary>
        /// Retrieves (READ) the CostMetadata Dto associated with the specified unique identifier.
        /// The CostMetadata retrieved from the Database is in INTERNAL Units, database access 
        /// performed by the repository layer, the fields of the CostMetadata are converted to 
        /// EXTERNAL Units, which are the units used in the user interface, 
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
                //---------------------- Guard against empty or null projectId ------------------------
                //--- If the provided projectId is empty, return null to indicate that there is no  ---
                //--- valid cost metadata to retrieve.                                              ---
                //--- This prevents unnecessary database calls and potential errors when trying to  ---
                //--- retrieve cost metadata with an invalid identifier.                            ---
                //--- An empty projectId is not valid for retrieval, so we return null to indicate  ---
                //---that the cost metadata cannot be found.                                        ---
                //-------------------------------------------------------------------------------------
                if (projectId == Guid.Empty)
                {
                    return null; // Return null if the projectId is empty
                }
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
                externalCostMetadataDto = ConvertToExternalDto(internalCostMetadata);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving cost metadata: {ex.Message}");
                return null;
            }
            //--------------------------------------------------------------------
            //--- Return the CostMetadata Dto in EXTERNAL Units to the caller. ---
            //--- If the retrieval failed or no cost metadata is found,        ---
            //--- the returned DTO will be null.                               ---
            //--------------------------------------------------------------------
            return externalCostMetadataDto;
        }
        #endregion  // GetCostMetadataByProjectId(Guid projectId) ... READ

        #region UpdateCostMetadata(CostMetadataDto externalCostMetadataDto) ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing cost metadata in the database using the 
        /// specified cost metadata data transfer object (DTO) with external units.
        /// </summary>
        /// <remarks>This method converts the provided cost metadata data 
        /// from external units to the internal units required by the database before 
        /// updating the cost metadata. If the specified cost metadata does not exist,
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
                internalCostMetadataDto = ConvertToInternalDto(externalCostMetadataDto);
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
                //-----------------------------------------------------
                //--- DELETE Cost Metadata from the Database using  ---
                //--- the CostMetadataRepo Object                   ---
                //--- The Cost Metadata to be deleted is identified ---
                //--- by the provided costMetadataId (PK)           ---
                //-----------------------------------------------------
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
