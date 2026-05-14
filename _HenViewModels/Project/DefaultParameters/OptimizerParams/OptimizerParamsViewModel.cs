#region HEADER
//#####################################################################################################################
//##############################  O p t i m i z e r P a r a m s V i e w M o d e l . c s  ##############################
//#####################################################################################################################
//  FILENAME:  OptimizerParamsViewModel.cs
//  NAMESPACE: HenViewModel.Project.DefaultParameters.OptimizerParams
//  CLASS(S):  OptimizerParamsViewModel
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the Optimizer Params DTO.
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
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;
using HenModel.RepoImplementations.Project.DefaultParameters.OptimizerParams;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenViewModel.Project.DefaultParameters.OptimizerParams
namespace HenViewModel.Project.DefaultParameters.OptimizerParams
{
    #region public class OptimizerParamsViewModel
    /// <summary>
    /// Optimizer Params View Model class.
    /// </summary>
    public class OptimizerParamsViewModel : ViewModelBase
    {
        #region PROPERTIES
        public OptimizerParamsRepo OptimizerParamsRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region DEFAULT CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public OptimizerParamsViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var optimizerParamsRepoObj = new OptimizerParamsRepo(connFactoryObj);

            OptimizerParamsRepoObj = optimizerParamsRepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // DEFAULT CTOR

        #region PRIVATE DTO CONVERSION METHODS

        #region ConvertToExternalDto(OptimizerParamsDto internalDto)
        /// <summary>
        /// Converts a Optimizer Params DTO from INTERNAL units to EXTERNAL units.
        /// </summary>
        /// <param name="internalDto">The Optimizer Params DTO in INTERNAL units.</param>
        /// <returns>A <see cref="OptimizerParamsDto"/> DTO in EXTERNAL units.</returns>
        private OptimizerParamsDto ConvertToExternalDto(OptimizerParamsDto internalDto)
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
            OptimizerParamsDto externalDto = new OptimizerParamsDto();
            //---------------------------------------------------------
            //--- Convert INTERNAL DTO Fields to EXTERNAL DTO Units ---
            //---------------------------------------------------------
            externalDto.Id = internalDto.Id;
            externalDto.ProjectId = internalDto.ProjectId;

            externalDto.Name                        = internalDto.Name;
            externalDto.Description                 = internalDto.Description;
            externalDto.OptimizerType               = internalDto.OptimizerType;
            externalDto.DefaultObjective            = internalDto.DefaultObjective;
            externalDto.DefaultMaxIterations        = internalDto.DefaultMaxIterations;
            externalDto.DefaultConvergenceTolerance = internalDto.DefaultConvergenceTolerance;
            //--------------------------------------------------
            //--- Return the EXTERNAL DTO in EXTERNAL units. ---
            //--------------------------------------------------
            return externalDto;
        }
        #endregion  // ConvertToExternalDto(OptimizerParamsDto internalDto)

        #region ConvertToInternalDto(OptimizerParamsDto externalDto)
        /// <summary>
        /// Converts a Optimizer Params DTO from EXTERNAL units to INTERNAL units.
        /// </summary>
        /// <param name="externalDto">The Optimizer Params DTO in EXTERNAL units.</param>
        /// <returns>A <see cref="OptimizerParamsDto"/> DTO in INTERNAL units.</returns>
        private OptimizerParamsDto ConvertToInternalDto(OptimizerParamsDto externalDto)
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
            OptimizerParamsDto internalDto = new OptimizerParamsDto();
            //-------------------------------------------------
            //--- Convert EXTERNAL Fields to INTERNAL Units ---
            //-------------------------------------------------
            internalDto.Id = externalDto.Id;
            internalDto.ProjectId = externalDto.ProjectId;

            internalDto.Name                        = externalDto.Name;
            internalDto.Description                 = externalDto.Description;
            internalDto.OptimizerType               = externalDto.OptimizerType;
            internalDto.DefaultObjective            = externalDto.DefaultObjective;
            internalDto.DefaultMaxIterations        = externalDto.DefaultMaxIterations;
            internalDto.DefaultConvergenceTolerance = externalDto.DefaultConvergenceTolerance;
            //--------------------------------------------------
            //--- Return the INTERNAL DTO in INTERNAL units. ---
            //--------------------------------------------------
            return internalDto;
        }
        #endregion  // ConvertToInternalDto(OptimizerParamsDto externalDto)

        #endregion  // PRIVATE DTO CONVERSION METHODS

        #region OPTIMIZER PARAMS CRUD METHODS

        #region AddOptimizerParam(OptimizerParamsDto externalOptimizerParamsDto) ... CREATE
        /// <summary>
        /// Adds (CREATE) a new optimizer params to the database using the specified optimizer params data transfer object.
        /// </summary>
        /// <remarks>The method converts the provided optimizer params data from external to internal units before
        /// storing it in the database. If an error occurs during the operation, the method logs the error and returns
        /// an empty GUID.</remarks>
        /// <param name="externalOptimizerParamsDto">The optimizer params data to add. The object must contain 
        /// all required optimizer params fields in external units. Cannot be null.</param>
        /// <returns>A GUID representing the unique identifier of the newly added optimizer params.</returns>
        public Guid AddOptimizerParam(OptimizerParamsDto externalOptimizerParamsDto)
        {
            Guid optimizerParamsID = new Guid();
            try
            {
                //------------------------------------------------------------------------
                //--- OptimizerParams Dto [INTERNAL Units] to be Added to the Database ---
                //------------------------------------------------------------------------
                OptimizerParamsDto internalOptimizerParamsDto = new OptimizerParamsDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalOptimizerParamsDto = ConvertToInternalDto(externalOptimizerParamsDto);
                //---------------------------------------------------------------------------------------------
                //--- Add INTERNAL OptimizerParams Dto to the Database using the OptimizerParamsRepo Object ---
                //--- Returns the OptimizerParams ID (PK) from the OptimizerParams Table database addition  ---
                //---------------------------------------------------------------------------------------------
                optimizerParamsID = OptimizerParamsRepoObj.AddOptimizerParams(internalOptimizerParamsDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving optimizer params: {ex.Message}");
            }
            return optimizerParamsID; // Return Optimizer Params ID (PK) from the Optimizer Params Table database addition
        }
        #endregion  // AddOptimizerParam(OptimizerParamsDto externalOptimizerParamsDto) ... CREATE

        #region GetOptimizerParamByProjectId(Guid projectId) ... READ
        /// <summary>
        /// Retrieves (READ) the OptimizerParams Dto associated with the specified unique identifier.
        /// The OptimizerParams retrieved from the Database is in INTERNAL Units, 
        /// database access performed by the repository layer, 
        /// the fields of the OptimizerParams are converted to EXTERNAL Units, which are the units used in the user interface,
        /// the resulting OptimizerParams Dto is returned as a <see cref="OptimizerParamsDto"/> object.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve.</param>
        /// <returns>A <see cref="OptimizerParamsDto"/> representing the OptimizerParams with the specified identifier. 
        /// Returns null if no OptimizerParams is found.</returns>
        public OptimizerParamsDto GetOptimizerParamByProjectId(Guid projectId)
        {
            OptimizerParamsDto externalOptimizerParamsDto = new OptimizerParamsDto();
            try
            {
                //---------------------- Guard against empty or null projectId ------------------------
                //--- If the provided projectId is empty, return null to indicate that there is no  ---
                //--- valid optimizerParams to retrieve.                                            ---
                //--- This prevents unnecessary database calls and potential errors when trying to  ---
                //--- retrieve an optimizerParams with an invalid identifier.                       ---
                //--- An empty projectId is not valid for retrieval, so we return null to indicate  ---
                //---that the optimizerParams cannot be found.                                      ---
                //-------------------------------------------------------------------------------------
                if (projectId == Guid.Empty)
                {
                    return null; // Return null if the projectId is empty
                }
                //-------------------------------------------------------------------
                //--- Retrieve OptimizerParams Dto from the Database.             ---
                //--- The retrieved OptimizerParams Dto is in INTERNAL Units,     ---
                //--- database access performed by the OptimizerParamsRepo Object ---
                //-------------------------------------------------------------------
                OptimizerParamsDto internalOptimizerParamsDto = 
                    OptimizerParamsRepoObj.GetOptimizerParamsByProjectId(projectId);
                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalOptimizerParamsDto = ConvertToExternalDto(internalOptimizerParamsDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving optimizer params: {ex.Message}");
                return null; // Return null if an error occurs
            }

            return externalOptimizerParamsDto;
        }
        #endregion  // GetOptimizerParamByProjectId(Guid projectId) ... READ

        #region UpdateOptimizerParam(OptimizerParamsDto externalOptimizerParamsDto) ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing optimizer params in the database using the specified 
        /// optimizer params data transfer object (DTO) with external units.
        /// </summary>
        /// <remarks>This method converts the provided optimizer params data from external units to the internal
        /// units required by the database before updating the optimizer params. If the specified optimizer params does not exist,
        /// the behavior depends on the repository implementation.</remarks>
        /// <param name="externalOptimizerParamsDto">The optimizer params data transfer object containing updated optimizer params 
        /// information in external units. Cannot be null.</param>
        public void UpdateOptimizerParam(OptimizerParamsDto externalOptimizerParamDto)
        {
            try
            {
                //-------------------------------------------------------------------------
                //--- Optimizer Params Dto [INTERNAL Units] to be Added to the Database ---
                //-------------------------------------------------------------------------
                OptimizerParamsDto internalOptimizerParamDto = new OptimizerParamsDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalOptimizerParamDto = ConvertToInternalDto(externalOptimizerParamDto);
                //------------------------------------------------------------
                //--- UPDATE INTERNAL Optimizer Params Dto to the Database ---
                //--- The Optimizer Params to be updated is identified by  ---
                //--- the Id field of the provided Optimizer Params Dto    ---
                //------------------------------------------------------------
                OptimizerParamsRepoObj.UpdateOptimizerParams(internalOptimizerParamDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error updating optimizer params: {ex.Message}");
            }
        }
        #endregion  // UpdateOptimizerParam(OptimizerParamsDto externalOptimizerParamsDto) ... UPDATE

        #region DeleteOptimizerParams(Guid optimizerParamsId) ... DELETE
        /// <summary>
        /// Deletes (DELETE) the optimizer params with the specified unique identifier.
        /// </summary>
        /// <param name="optimizerParamsId">The unique identifier of the optimizer params to delete.</param>
        public void DeleteOptimizerParams(Guid optimizerParamsId)
        {
            try
            {
                //-----------------------------------------------------------------------------------------------
                //--- DELETE Optimizer Params from the Database using the OptimizerRepo Object                ---
                //--- The Optimizer Params to be deleted is identified by the provided optimizerParamsId (PK) ---
                //-----------------------------------------------------------------------------------------------
                OptimizerParamsRepoObj.DeleteOptimizerParams(optimizerParamsId);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error deleting optimizer params: {ex.Message}");
            }
        }
        #endregion  // DeleteOptimizerParams(Guid optimizerParamsId) ... DELETE

        #endregion  // OPTIMIZER PARAMS CRUD METHODS

    }
    #endregion      // public class OptimizerParamsViewModel

}
#endregion      // namespace HenViewModel.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
