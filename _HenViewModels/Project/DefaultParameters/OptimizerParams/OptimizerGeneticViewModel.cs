#region HEADER
//#####################################################################################################################
//#############################  O p t i m i z e r G e n e t i c V i e w M o d e l . c s  #############################
//#####################################################################################################################
//  FILENAME:  OptimizerGeneticViewModel.cs
//  NAMESPACE: HenViewModel.Project.DefaultParameters.OptimizerParams
//  CLASS(S):  OptimizerGeneticViewModel
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the Optimizer Genetic Params DTO.
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
    #region public class OptimizerGeneticViewModel
    /// <summary>
    /// Optimizer Genetic View Model class.
    /// </summary>
    public class OptimizerGeneticViewModel : ViewModelBase
    {
        #region PROPERTIES
        public OptimizerGeneticRepo OptimizerGeneticRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region DEFAULT CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public OptimizerGeneticViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var optimizerGeneticRepoObj = new OptimizerGeneticRepo(connFactoryObj);

            OptimizerGeneticRepoObj = optimizerGeneticRepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // DEFAULT CTOR

        #region PRIVATE DTO CONVERSION METHODS

        #region ConvertToExternalDto(OptimizerGeneticDto internalDto)
        /// <summary>
        /// Converts a Optimizer Genetic DTO from INTERNAL units to EXTERNAL units.
        /// </summary>
        /// <param name="internalDto">The Optimizer Genetic DTO in INTERNAL units.</param>
        /// <returns>A <see cref="OptimizerGeneticDto"/> DTO in EXTERNAL units.</returns>
        private OptimizerGeneticDto ConvertToExternalDto(OptimizerGeneticDto internalDto)
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
            OptimizerGeneticDto externalDto = new OptimizerGeneticDto();
            //---------------------------------------------------------
            //--- Convert INTERNAL DTO Fields to EXTERNAL DTO Units ---
            //---------------------------------------------------------
            externalDto.Id = internalDto.Id;
            externalDto.OptimizerParamsId = internalDto.OptimizerParamsId;

            externalDto.Name                        = internalDto.Name;
            externalDto.Description                 = internalDto.Description;
            //--------------------------------------------------
            //--- Return the EXTERNAL DTO in EXTERNAL units. ---
            //--------------------------------------------------
            return externalDto;
        }
        #endregion  // ConvertToExternalDto(OptimizerGeneticDto internalDto)

        #region ConvertToInternalDto(OptimizerGeneticDto externalDto)
        /// <summary>
        /// Converts a Optimizer Genetic DTO from EXTERNAL units to INTERNAL units.
        /// </summary>
        /// <param name="externalDto">The Optimizer Genetic DTO in EXTERNAL units.</param>
        /// <returns>A <see cref="OptimizerGeneticDto"/> DTO in INTERNAL units.</returns>
        private OptimizerGeneticDto ConvertToInternalDto(OptimizerGeneticDto externalDto)
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
            OptimizerGeneticDto internalDto = new OptimizerGeneticDto();
            //-------------------------------------------------
            //--- Convert EXTERNAL Fields to INTERNAL Units ---
            //-------------------------------------------------
            internalDto.Id = externalDto.Id;
            internalDto.OptimizerParamsId = externalDto.OptimizerParamsId;

            internalDto.Name                        = externalDto.Name;
            internalDto.Description                 = externalDto.Description;
            //--------------------------------------------------
            //--- Return the INTERNAL DTO in INTERNAL units. ---
            //--------------------------------------------------
            return internalDto;
        }
        #endregion  // ConvertToInternalDto(OptimizerParamsDto externalDto)

        #endregion  // PRIVATE DTO CONVERSION METHODS

        #region OPTIMIZER GENETIC CRUD METHODS

        #region AddOptimizerGenetic(OptimizerGeneticDto externalOptimizerGeneticDto) ... CREATE
        /// <summary>
        /// Adds (CREATE) a new optimizer genetic to the database using the specified optimizer genetic data transfer object.
        /// </summary>
        /// <remarks>The method converts the provided optimizer genetic data from external to internal units before
        /// storing it in the database. If an error occurs during the operation, the method logs the error and returns
        /// an empty GUID.</remarks>
        /// <param name="externalOptimizerGeneticDto">The optimizer genetic data to add. The object must contain 
        /// all required optimizer genetic fields in external units. Cannot be null.</param>
        /// <returns>A GUID representing the unique identifier of the newly added optimizer genetic.</returns>
        public Guid AddOptimizerGenetic(OptimizerGeneticDto externalOptimizerGeneticDto)
        {
            Guid optimizerGeneticID = new Guid();
            try
            {
                //-------------------------------------------------------------------------
                //--- OptimizerGenetic Dto [INTERNAL Units] to be Added to the Database ---
                //-------------------------------------------------------------------------
                OptimizerGeneticDto internalOptimizerGeneticDto = new OptimizerGeneticDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalOptimizerGeneticDto.Id = externalOptimizerGeneticDto.Id;
                internalOptimizerGeneticDto.OptimizerParamsId = externalOptimizerGeneticDto.OptimizerParamsId;

                internalOptimizerGeneticDto.Name        = externalOptimizerGeneticDto.Name;
                internalOptimizerGeneticDto.Description = externalOptimizerGeneticDto.Description;
                //---------------------------------------------------------------------------------------------
                //--- Add INTERNAL OptimizerGenetic Dto to the Database using the OptimizerGeneticRepo Object ---
                //--- Returns the OptimizerGenetic ID (PK) from the OptimizerGenetic Table database addition  ---
                //---------------------------------------------------------------------------------------------
                optimizerGeneticID = OptimizerGeneticRepoObj.AddOptimizerGenetic(internalOptimizerGeneticDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving optimizer genetic: {ex.Message}");
            }
            return optimizerGeneticID; // Return Optimizer Genetic ID (PK) from the Optimizer Genetic Table database addition
        }
        #endregion  // AddOptimizerGenetic(OptimizerGeneticDto externalOptimizerGeneticDto) ... CREATE

        #region GetOptimizerGeneticById(Guid optimizerGeneticId) ... READ
        /// <summary>
        /// Retrieves (READ) the OptimizerGenetic Dto associated with the specified unique identifier.
        /// The OptimizerGenetic retrieved from the Database is in INTERNAL Units, 
        /// database access performed by the repository layer, 
        /// the fields of the OptimizerGenetic are converted to EXTERNAL Units, which are the units used in the user interface,
        /// the resulting OptimizerGenetic Dto is returned as a <see cref="OptimizerGeneticDto"/> object.
        /// </summary>
        /// <param name="optimizerGeneticId">The unique identifier of the OptimizerGenetic to retrieve.</param>
        /// <returns>A <see cref="OptimizerGeneticDto"/> representing the OptimizerGenetic with the specified identifier. 
        /// Returns null if no OptimizerGenetic is found.</returns>
        public OptimizerGeneticDto GetOptimizerGeneticById(Guid optimizerGeneticId)
        {
            OptimizerGeneticDto externalOptimizerGeneticDto = new OptimizerGeneticDto();
            try
            {
                //-------------------------------------------------------------------
                //--- Retrieve OptimizerGenetic Dto from the Database.             ---
                //--- The retrieved OptimizerGenetic Dto is in INTERNAL Units,     ---
                //--- database access performed by the OptimizerGeneticRepo Object ---
                //-------------------------------------------------------------------
                OptimizerGeneticDto internalOptimizerGenetic = 
                    OptimizerGeneticRepoObj.GetOptimizerGeneticById(optimizerGeneticId);
                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalOptimizerGeneticDto.Id = internalOptimizerGenetic.Id;
                externalOptimizerGeneticDto.OptimizerParamsId = internalOptimizerGenetic.OptimizerParamsId;

                externalOptimizerGeneticDto.Name        = internalOptimizerGenetic.Name;
                externalOptimizerGeneticDto.Description = internalOptimizerGenetic.Description;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving optimizer genetic: {ex.Message}");
                return null; // Return null if an error occurs
            }

            return externalOptimizerGeneticDto;
        }
        #endregion  // GetOptimizerGeneticById(Guid optimizerGeneticId) ... READ

        #region etOptimizerGeneticByOptimizerParamsId(Guid optimizerParamsId) ... READ
        /// <summary>
        /// Retrieves (READ) the OptimizerGenetic Dto associated with the specified unique identifier.
        /// The OptimizerGenetic retrieved from the Database is in INTERNAL Units, 
        /// database access performed by the repository layer, 
        /// the fields of the OptimizerGenetic are converted to EXTERNAL Units, which are the units used in the user interface,
        /// the resulting OptimizerGenetic Dto is returned as a <see cref="OptimizerGeneticDto"/> object.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve.</param>
        /// <returns>A <see cref="OptimizerGeneticDto"/> representing the OptimizerGenetic with the specified identifier. 
        /// Returns null if no OptimizerGenetic is found.</returns>
        public OptimizerGeneticDto etOptimizerGeneticByOptimizerParamsId(Guid optimizerParamsId)
        {
            OptimizerGeneticDto externalOptimizerGeneticDto = new OptimizerGeneticDto();
            try
            {
                //-------------------------------------------------------------------
                //--- Retrieve OptimizerGenetic Dto from the Database.             ---
                //--- The retrieved OptimizerGenetic Dto is in INTERNAL Units,     ---
                //--- database access performed by the OptimizerGeneticRepo Object ---
                //-------------------------------------------------------------------
                OptimizerGeneticDto internalOptimizerGenetic =
                    OptimizerGeneticRepoObj.GetOptimizerGeneticByOptimizerParamsId(optimizerParamsId);
                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalOptimizerGeneticDto.Id = internalOptimizerGenetic.Id;
                externalOptimizerGeneticDto.OptimizerParamsId = internalOptimizerGenetic.OptimizerParamsId;

                externalOptimizerGeneticDto.Name = internalOptimizerGenetic.Name;
                externalOptimizerGeneticDto.Description = internalOptimizerGenetic.Description;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving optimizer genetic: {ex.Message}");
                return null; // Return null if an error occurs
            }

            return externalOptimizerGeneticDto;
        }
        #endregion  // GetOptimizerGeneticByOptimizerParamsId(Guid optimizerParamsId) ... READ

        #region UpdateOptimizerGenetic(OptimizerGeneticDto externalOptimizerGeneticDto) ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing optimizer genetic in the database using the specified 
        /// optimizer genetic data transfer object (DTO) with external units.
        /// </summary>
        /// <remarks>This method converts the provided optimizer genetic data from external units to the internal
        /// units required by the database before updating the optimizer genetic. If the specified optimizer genetic does not exist,
        /// the behavior depends on the repository implementation.</remarks>
        /// <param name="externalOptimizerGeneticDto">The optimizer genetic data transfer object containing updated optimizer genetic 
        /// information in external units. Cannot be null.</param>
        public void UpdateOptimizerGenetic(OptimizerGeneticDto externalOptimizerGeneticDto)
        {
            try
            {
                //--------------------------------------------------------------------------
                //--- Optimizer Genetic Dto [INTERNAL Units] to be Added to the Database ---
                //--------------------------------------------------------------------------
                OptimizerGeneticDto internalOptimizerGeneticDto = new OptimizerGeneticDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalOptimizerGeneticDto.Id = externalOptimizerGeneticDto.Id;
                internalOptimizerGeneticDto.OptimizerParamsId = externalOptimizerGeneticDto.OptimizerParamsId;

                internalOptimizerGeneticDto.Name        = externalOptimizerGeneticDto.Name;
                internalOptimizerGeneticDto.Description = externalOptimizerGeneticDto.Description;
                //------------------------------------------------------------
                //--- UPDATE INTERNAL Optimizer Genetic Dto to the Database ---
                //--- The Optimizer Genetic to be updated is identified by  ---
                //--- the Id field of the provided Optimizer Genetic Dto    ---
                //------------------------------------------------------------
                OptimizerGeneticRepoObj.UpdateOptimizerGenetic(internalOptimizerGeneticDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error updating optimizer genetic: {ex.Message}");
            }
        }
        #endregion  // UpdateOptimizerGenetic(OptimizerGeneticDto externalOptimizerGeneticDto) ... UPDATE

        #region DeleteOptimizerGenetic(Guid optimizerGeneticId) ... DELETE
        /// <summary>
        /// Deletes (DELETE) the optimizer genetic with the specified unique identifier.
        /// </summary>
        /// <param name="optimizerGeneticId">The unique identifier of the optimizer genetic to delete.</param>
        public void DeleteOptimizerGenetic(Guid optimizerGeneticId)
        {
            try
            {
                //-------------------------------------------------------------------------------------------------
                //--- DELETE Optimizer Genetic from the Database using the OptimizerGeneticRepo Object          ---
                //--- The Optimizer Genetic to be deleted is identified by the provided optimizerGeneticId (PK) ---
                //-------------------------------------------------------------------------------------------------
                OptimizerGeneticRepoObj.DeleteOptimizerGenetic(optimizerGeneticId);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error deleting optimizer genetic: {ex.Message}");
            }
        }
        #endregion  // DeleteOptimizerGenetic(Guid optimizerGeneticId) ... DELETE

        #endregion  // OPTIMIZER GENETIC CRUD METHODS

    }
    #endregion      // public class OptimizerGeneticViewModel

}
#endregion      // namespace HenViewModel.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
