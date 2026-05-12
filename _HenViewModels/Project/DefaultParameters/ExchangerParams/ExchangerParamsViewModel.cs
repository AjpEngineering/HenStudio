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
using HenModel.RepoImplementations.Project.DefaultParameters.ExchangerParams;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenViewModel.Project.DefaultParameters.ExchangerParams
namespace HenViewModel.Project.DefaultParameters.ExchangerParams
{
    #region public class ExchangerParamsViewModel
    /// <summary>
    /// Project view model class.
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

                //--------------------------------------------------------------------------------------
                //--- Add INTERNAL Project Dto to the Database using the ExchangerParamsRepo Object  ---
                //--- Returns the Project ID (PK) from the Project Table database addition           ---
                //--------------------------------------------------------------------------------------
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
