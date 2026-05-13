#region HEADER
//#####################################################################################################################
//#####################  E x c h a n g e r P a r a m s V i e w M o d e l V i e w M o d e l . c s  #####################
//#####################################################################################################################
//  FILENAME:  ExchangerParamsViewModel.cs
//  NAMESPACE: HenViewModel.Project.DefaultParameters.ExchangerParams
//  CLASS(S):  ExchangerParamsViewModel
//  COMPONENT: _HenViewModels.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the Exchanger Params DTO.
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
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;
using HenModel.RepoImplementations.Project.DefaultParameters.ExchangerParams;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenViewModel.Project.DefaultParameters.ExchangerParams
namespace HenViewModel.Project.DefaultParameters.ExchangerParams
{
    #region public class ExchangerParamsViewModel
    /// <summary>
    /// Exchanger Params view model class.
    /// </summary>
    public class ExchangerParamsViewModel : ViewModelBase
    {
        #region PROPERTIES
        public ExchangerParamsRepo ExchangerParamsRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region DEFAULT CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public ExchangerParamsViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var exchangerParamsRepoObj = new ExchangerParamsRepo(connFactoryObj);

            ExchangerParamsRepoObj = exchangerParamsRepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // DEFAULT CTOR

        #region PRIVATE DTO CONVERSION METHODS

        #region ConvertToExternalDto(ExchangerParamsDto internalDto)
        /// <summary>
        /// Converts a Exchanger Params DTO from INTERNAL units to EXTERNAL units.
        /// </summary>
        /// <param name="internalDto">The Exchanger Params DTO in INTERNAL units.</param>
        /// <returns>A <see cref="ExchangerParamsDto"/> DTO in EXTERNAL units.</returns>
        private ExchangerParamsDto ConvertToExternalDto(ExchangerParamsDto internalDto)
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
            ExchangerParamsDto externalDto = new ExchangerParamsDto();
            //---------------------------------------------------------
            //--- Convert INTERNAL DTO Fields to EXTERNAL DTO Units ---
            //---------------------------------------------------------
            externalDto.Id = internalDto.Id;
            externalDto.ProjectId = internalDto.ProjectId;

            externalDto.DefaultHeatTransferCoefficient = internalDto.DefaultHeatTransferCoefficient;
            externalDto.DefaultCorrectionFactor = internalDto.DefaultCorrectionFactor;
            //--------------------------------------------------
            //--- Return the EXTERNAL DTO in EXTERNAL units. ---
            //--------------------------------------------------
            return externalDto;
        }
        #endregion  // ConvertToExternalDto(ExchangerParamsDto internalDto)

        #region ConvertToInternalDto(ExchangerParamsDto externalDto)
        /// <summary>
        /// Converts a Exchanger Params DTO from EXTERNAL units to INTERNAL units.
        /// </summary>
        /// <param name="externalDto">The Exchanger Params DTO in EXTERNAL units.</param>
        /// <returns>A <see cref="ExchangerParamsDto"/> DTO in INTERNAL units.</returns>
        private ExchangerParamsDto ConvertToInternalDto(ExchangerParamsDto externalDto)
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
            ExchangerParamsDto internalDto = new ExchangerParamsDto();
            //-------------------------------------------------
            //--- Convert EXTERNAL Fields to INTERNAL Units ---
            //-------------------------------------------------
            internalDto.Id = externalDto.Id;
            internalDto.ProjectId = externalDto.ProjectId;

            internalDto.DefaultHeatTransferCoefficient = externalDto.DefaultHeatTransferCoefficient;
            internalDto.DefaultCorrectionFactor = externalDto.DefaultCorrectionFactor;
            //--------------------------------------------------
            //--- Return the INTERNAL DTO in INTERNAL units. ---
            //--------------------------------------------------
            return internalDto;
        }
        #endregion  // ConvertToInternalDto(ExchangerParamsDto externalDto)

        #endregion  // PRIVATE DTO CONVERSION METHODS

        #region EXCHANGER PARAMS CRUD METHODS

        #region AddExchangerParams(ExchangerParamsDto externalExchangerParamsDto) ... CREATE
        /// <summary>
        /// Adds (CREATE) a new exchanger params to the database using the specified exchanger params data transfer object.
        /// </summary>
        /// <remarks>The method converts the provided exchanger params data from external to internal units before
        /// storing it in the database. If an error occurs during the operation, the method logs the error and returns
        /// an empty GUID.</remarks>
        /// <param name="externalExchangerParamsDto">The exchanger params data to add. The object must contain all required 
        /// exchanger params fields in external units. Cannot be null.</param>
        /// <returns>A GUID representing the unique identifier of the newly added exchanger params.</returns>
        public Guid AddExchangerParams(ExchangerParamsDto externalExchangerParamsDto)
        {
            Guid exchangerParamsID = new Guid();
            try
            {
                //------------------------------------------------------------------------
                //--- ExchangerParams Dto [INTERNAL Units] to be Added to the Database ---
                //------------------------------------------------------------------------
                ExchangerParamsDto internalExchangerParamsDto = new ExchangerParamsDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalExchangerParamsDto.Id = externalExchangerParamsDto.Id;
                internalExchangerParamsDto.ProjectId = externalExchangerParamsDto.ProjectId;
                internalExchangerParamsDto.DefaultHeatTransferCoefficient = 
                                            ConvertFromExternalU(externalExchangerParamsDto.DefaultHeatTransferCoefficient);
                internalExchangerParamsDto.DefaultCorrectionFactor = externalExchangerParamsDto.DefaultCorrectionFactor;

                //----------------------------------------------------------------------------------------------
                //--- Add INTERNAL ExchangerParams Dto to the Database using the ExchangerParamsRepo Object  ---
                //--- Returns the Exchanger Params ID (PK) from the Exchanger Params Table database addition ---
                //----------------------------------------------------------------------------------------------
                exchangerParamsID = ExchangerParamsRepoObj.AddExchangerParams(internalExchangerParamsDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving exchanger params: {ex.Message}");
            }
            return exchangerParamsID; // Return Exchanger Params ID (PK) from the Exchanger Params Table database addition
        }
        #endregion  // AddExchangerParams(ExchangerParamsDto externalExchangerParamsDto) ... CREATE

        #region GetExchangerParamsByProjectId(Guid projectId) ... READ
        /// <summary>
        /// Retrieves (READ) the Exchanger Params Dto associated with the specified unique identifier.
        /// The exchanger params retrieved from the Database are in INTERNAL Units, 
        /// database access performed by the ExchangerParamsRepo Object, 
        /// the fields of the exchanger params are converted to EXTERNAL Units, which are the units used in the user interface,
        /// the resulting Exchanger Params Dto is returned as a <see cref="ExchangerParamsDto"/> object.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve.</param>
        /// <returns>A <see cref="ExchangerParamsDto"/> representing the Project with the specified identifier. 
        /// Returns null if no Project is found.</returns>
        public ExchangerParamsDto GetExchangerParamsByProjectId(Guid projectId)
        {
            ExchangerParamsDto externalExchangerParams = new ExchangerParamsDto();
            try
            {
                //-------------------------------------------------------------------
                //--- Retrieve Exchanger Params Dto from the Database             ---
                //--- The retrieved Exchanger Params Dto is in INTERNAL Units,    ---
                //--- database access performed by the ExchangerParamsRepo Object ---
                //-------------------------------------------------------------------
                ExchangerParamsDto internalExchangerParams = ExchangerParamsRepoObj.GetExchangerParamsByProjectId(projectId);

                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalExchangerParams.Id = internalExchangerParams.Id;
                externalExchangerParams.ProjectId = internalExchangerParams.ProjectId;
                externalExchangerParams.DefaultCorrectionFactor = internalExchangerParams.DefaultCorrectionFactor;
                externalExchangerParams.DefaultHeatTransferCoefficient = 
                                        ConvertToExternalU(internalExchangerParams.DefaultHeatTransferCoefficient);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project units: {ex.Message}");
                return null; // Return null if an error occurs
            }

            return externalExchangerParams;
        }
        #endregion  // GetExchangerParamsByProjectId(Guid projectId) ... READ

        #region UpdateExchangerParams(ExchangerParamsDto externalExchangerParamsDto) ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing exchanger params in the database using the specified exchanger params data transfer object (DTO) 
        /// with external units.
        /// </summary>
        /// <remarks>This method converts the provided exchanger params data from external units to the internal
        /// units required by the database before updating the exchanger params. If the specified exchanger params does not exist,
        /// the behavior depends on the repository implementation.</remarks>
        /// <param name="externalExchangerParamsDto">The exchanger params data transfer object containing updated exchanger params 
        /// information in external units. Cannot be null.</param>
        public void UpdateExchangerParams(ExchangerParamsDto externalExchangerParamsDto)
        {
            try
            {
                //-------------------------------------------------------------------------
                //--- Exchanger Params Dto [INTERNAL Units] to be Added to the Database ---
                //-------------------------------------------------------------------------
                ExchangerParamsDto internalExchangerParamsDto = new ExchangerParamsDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalExchangerParamsDto.Id = externalExchangerParamsDto.Id;
                internalExchangerParamsDto.ProjectId = externalExchangerParamsDto.ProjectId;
                internalExchangerParamsDto.DefaultCorrectionFactor = externalExchangerParamsDto.DefaultCorrectionFactor;
                internalExchangerParamsDto.DefaultHeatTransferCoefficient = 
                                            ConvertFromExternalU(externalExchangerParamsDto.DefaultHeatTransferCoefficient);
                //-------------------------------------------------------------------------------------------------
                //--- UPDATE INTERNAL Exchanger Params Dto to the Database using the ExchangerParamsRepo Object ---
                //-------------------------------------------------------------------------------------------------
                ExchangerParamsRepoObj.UpdateExchangerParams(internalExchangerParamsDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error updating exchanger params: {ex.Message}");
            }
        }
        #endregion  // UpdateExchangerParams(ExchangerParamsDto externalExchangerParamsDto) ... UPDATE

        #region DeleteExchangerParams(Guid exchangerParamsId) ... DELETE
        /// <summary>
        /// Deletes (DELETE) the exchanger params with the specified unique identifier.
        /// </summary>
        /// <param name="exchangerParamsId">The unique identifier of the exchanger params to delete.</param>
        public void DeleteExchangerParams(Guid exchangerParamsId)
        {
            try
            {
                //--------------------------------------------------------------------------------------
                //--- DELETE Exchanger Params from the Database using the ExchangerParamsRepo Object ---
                //--------------------------------------------------------------------------------------
                ExchangerParamsRepoObj.DeleteExchangerParams(exchangerParamsId);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error deleting exchanger params: {ex.Message}");
            }
        }
        #endregion  // DeleteExchangerParams(Guid exchangerParamsId) ... DELETE

        #endregion  // EXCHANGER PARAMS CRUD METHODS

    }
    #endregion      // public class ExchangerParamsViewModel

}
#endregion      // namespace HenViewModel.Project.DefaultParameters.ExchangerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
