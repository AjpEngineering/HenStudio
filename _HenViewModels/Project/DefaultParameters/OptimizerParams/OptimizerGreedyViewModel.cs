#region HEADER
//#####################################################################################################################
//##############################  O p t i m i z e r G r e e d y V i e w M o d e l . c s  ##############################
//#####################################################################################################################
//  FILENAME:  OptimizerGreedyViewModel.cs
//  NAMESPACE: HenViewModel.Project.DefaultParameters.OptimizerParams
//  CLASS(S):  OptimizerGreedyViewModel
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the Optimizer Greedy Params DTO.
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
    #region public class OptimizerGreedyViewModel
    /// <summary>
    /// Optimizer Greedy View Model class.
    /// </summary>
    public class OptimizerGreedyViewModel : ViewModelBase
    {
        #region PROPERTIES
        public OptimizerGreedyRepo OptimizerGreedyRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region DEFAULT CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public OptimizerGreedyViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var optimizerGreedyRepoObj = new OptimizerGreedyRepo(connFactoryObj);

            OptimizerGreedyRepoObj = optimizerGreedyRepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // DEFAULT CTOR

        #region PRIVATE DTO CONVERSION METHODS

        #region ConvertToExternalDto(OptimizerGreedyDto internalDto)
        /// <summary>
        /// Converts a Optimizer Greedy DTO from INTERNAL units to EXTERNAL units.
        /// </summary>
        /// <param name="internalDto">The Optimizer Greedy DTO in INTERNAL units.</param>
        /// <returns>A <see cref="OptimizerGreedyDto"/> DTO in EXTERNAL units.</returns>
        private OptimizerGreedyDto ConvertToExternalDto(OptimizerGreedyDto internalDto)
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
            OptimizerGreedyDto externalDto = new OptimizerGreedyDto();
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
        #endregion  // ConvertToExternalDto(OptimizerGreedyDto internalDto)

        #region ConvertToInternalDto(OptimizerGreedyDto externalDto)
        /// <summary>
        /// Converts a Optimizer Greedy DTO from EXTERNAL units to INTERNAL units.
        /// </summary>
        /// <param name="externalDto">The Optimizer Greedy DTO in EXTERNAL units.</param>
        /// <returns>A <see cref="OptimizerGreedyDto"/> DTO in INTERNAL units.</returns>
        private OptimizerGreedyDto ConvertToInternalDto(OptimizerGreedyDto externalDto)
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
            OptimizerGreedyDto internalDto = new OptimizerGreedyDto();
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
        #endregion  // ConvertToInternalDto(OptimizerGreedyDto externalDto)

        #endregion  // PRIVATE DTO CONVERSION METHODS

        #region OPTIMIZER GREEDY CRUD METHODS

        #region AddOptimizerGreedy(OptimizerGreedyDto externalOptimizerGreedyDto) ... CREATE
        /// <summary>
        /// Adds (CREATE) a new optimizer greedy to the database using the specified optimizer greedy data transfer object.
        /// </summary>
        /// <remarks>The method converts the provided optimizer greedy data from external to internal units before
        /// storing it in the database. If an error occurs during the operation, the method logs the error and returns
        /// an empty GUID.</remarks>
        /// <param name="externalOptimizerGreedyDto">The optimizer greedy data to add. The object must contain 
        /// all required optimizer greedy fields in external units. Cannot be null.</param>
        /// <returns>A GUID representing the unique identifier of the newly added optimizer greedy.</returns>
        public Guid AddOptimizerGreedy(OptimizerGreedyDto externalOptimizerGreedyDto)
        {
            Guid optimizerGreedyID = new Guid();
            try
            {
                //------------------------------------------------------------------------
                //--- OptimizerGreedy Dto [INTERNAL Units] to be Added to the Database ---
                //------------------------------------------------------------------------
                OptimizerGreedyDto internalOptimizerGreedyDto = new OptimizerGreedyDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalOptimizerGreedyDto = ConvertToInternalDto(externalOptimizerGreedyDto);
                //---------------------------------------------------------------------------------------------
                //--- Add INTERNAL OptimizerGreedy Dto to the Database using the OptimizerGreedyRepo Object ---
                //--- Returns the OptimizerGreedy ID (PK) from the OptimizerGreedy Table database addition  ---
                //---------------------------------------------------------------------------------------------
                optimizerGreedyID = OptimizerGreedyRepoObj.AddOptimizerGreedy(internalOptimizerGreedyDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving optimizer greedy: {ex.Message}");
            }
            return optimizerGreedyID; // Return Optimizer Greedy ID (PK) from the Optimizer Greedy Table database addition
        }
        #endregion  // AddOptimizerGreedy(OptimizerGreedyDto externalOptimizerGreedyDto) ... CREATE

        #region GetOptimizerGreedyById(Guid optimizerGreedyId) ... READ
        /// <summary>
        /// Retrieves (READ) the OptimizerGreedy Dto associated with the specified unique identifier.
        /// The OptimizerGreedy retrieved from the Database is in INTERNAL Units, 
        /// database access performed by the repository layer, 
        /// the fields of the OptimizerGreedy are converted to EXTERNAL Units, which are the units used in the user interface,
        /// the resulting OptimizerGreedy Dto is returned as a <see cref="OptimizerGreedyDto"/> object.
        /// </summary>
        /// <param name="optimizerGreedyId">The unique identifier of the OptimizerGreedy to retrieve.</param>
        /// <returns>A <see cref="OptimizerGreedyDto"/> representing the OptimizerGreedy with the specified identifier. 
        /// Returns null if no OptimizerGreedy is found.</returns>
        public OptimizerGreedyDto GetOptimizerGreedyById(Guid optimizerGreedyId)
        {
            OptimizerGreedyDto externalOptimizerGreedyDto = new OptimizerGreedyDto();
            try
            {
                //---------------------- Guard against empty or null optimizerGreedyId ----------------
                //--- If the provided optimizerGreedyId is empty, return null to indicate that      ---
                //--- there is no valid optimizerGreedy to retrieve.                                ---
                //--- This prevents unnecessary database calls and potential errors when trying to  ---
                //--- retrieve an optimizerGreedy with an invalid identifier.                       ---
                //--- An empty optimizerGreedyId is not valid for retrieval, so we return null to   ---
                //--- indicate that the optimizerGreedy cannot be found.                            ---
                //-------------------------------------------------------------------------------------
                if (optimizerGreedyId == Guid.Empty)
                {
                    return null; // Return null if the optimizerGreedyId is empty
                }
                //-------------------------------------------------------------------
                //--- Retrieve OptimizerGreedy Dto from the Database.             ---
                //--- The retrieved OptimizerGreedy Dto is in INTERNAL Units,     ---
                //--- database access performed by the OptimizerGreedyRepo Object ---
                //-------------------------------------------------------------------
                OptimizerGreedyDto internalOptimizerGreedyDto = 
                        OptimizerGreedyRepoObj.GetOptimizerGreedyById(optimizerGreedyId);
                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalOptimizerGreedyDto = ConvertToExternalDto(internalOptimizerGreedyDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving optimizer greedy: {ex.Message}");
                return null; // Return null if an error occurs
            }
            //---------------------------------------------------------
            //--- Return the OptimizerGreedy Dto in EXTERNAL Units. ---
            //--- If the retrieval and conversion were successful,  ---
            //--- this will be a valid OptimizerGreedyDto.          ---
            //--- If the optimizerGreedyId was empty or an error    ---
            //--- occurred, this will return null.                  ---
            //---------------------------------------------------------
            return externalOptimizerGreedyDto;
        }
        #endregion  // GetOptimizerGreedyById(Guid optimizerGreedyId) ... READ

        #region GetOptimizerGreedyByOptimizerParamsId(Guid optimizerParamsId) ... READ
        /// <summary>
        /// Retrieves (READ) the OptimizerGreedy Dto associated with the specified unique identifier.
        /// The OptimizerGreedy retrieved from the Database is in INTERNAL Units, 
        /// database access performed by the repository layer, 
        /// the fields of the OptimizerGreedy are converted to EXTERNAL Units, which are the units used in the user interface,
        /// the resulting OptimizerGreedy Dto is returned as a <see cref="OptimizerGreedyDto"/> object.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve.</param>
        /// <returns>A <see cref="OptimizerGreedyDto"/> representing the OptimizerGreedy with the specified identifier. 
        /// Returns null if no OptimizerGreedy is found.</returns>
        public OptimizerGreedyDto GetOptimizerGreedyByOptimizerParamsId(Guid optimizerParamsId)
        {
            OptimizerGreedyDto externalOptimizerGreedyDto = new OptimizerGreedyDto();
            try
            {
                //---------------------- Guard against empty or null optimizerParamsId ----------------
                //--- If the provided optimizerParamsId is empty, return null to indicate that      ---
                //--- there is no valid optimizerGreedy to retrieve.                                ---
                //--- This prevents unnecessary database calls and potential errors when trying to  ---
                //--- retrieve an optimizerGreedy with an invalid identifier.                       ---
                //--- An empty optimizerParamsId is not valid for retrieval, so we return null to   ---
                //--- indicate that the optimizerGreedy cannot be found.                            ---
                //-------------------------------------------------------------------------------------
                if (optimizerParamsId == Guid.Empty)
                {
                    return null; // Return null if the optimizerParamsId is empty
                }
                //-------------------------------------------------------------------
                //--- Retrieve OptimizerGreedy Dto from the Database.             ---
                //--- The retrieved OptimizerGreedy Dto is in INTERNAL Units,     ---
                //--- database access performed by the OptimizerGreedyRepo Object ---
                //-------------------------------------------------------------------
                OptimizerGreedyDto internalOptimizerGreedyDto =
                        OptimizerGreedyRepoObj.GetOptimizerGreedyByOptimizerParamsId(optimizerParamsId);
                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalOptimizerGreedyDto = ConvertToExternalDto(internalOptimizerGreedyDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving optimizer greedy: {ex.Message}");
                return null; // Return null if an error occurs
            }
            //---------------------------------------------------------
            //--- Return the OptimizerGreedy Dto in EXTERNAL Units. ---
            //--- If the retrieval and conversion were successful,  ---
            //--- this will be a valid OptimizerGreedyDto.          ---
            //--- If the optimizerParamsId was empty or an error    ---
            //--- occurred, this will return null.                  ---
            //---------------------------------------------------------
            return externalOptimizerGreedyDto;
        }
        #endregion  // GetOptimizerGreedyByOptimizerParamsId(Guid optimizerParamsId) ... READ

        #region UpdateOptimizerGreedy(OptimizerGreedyDto externalOptimizerGreedyDto) ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing optimizer greedy in the database using the specified 
        /// optimizer greedy data transfer object (DTO) with external units.
        /// </summary>
        /// <remarks>This method converts the provided optimizer greedy data from external units to the internal
        /// units required by the database before updating the optimizer greedy. If the specified optimizer greedy does not exist,
        /// the behavior depends on the repository implementation.</remarks>
        /// <param name="externalOptimizerGreedyDto">The optimizer greedy data transfer object containing updated optimizer greedy 
        /// information in external units. Cannot be null.</param>
        public void UpdateOptimizerGreedy(OptimizerGreedyDto externalOptimizerGreedyDto)
        {
            try
            {
                //-------------------------------------------------------------------------
                //--- Optimizer Greedy Dto [INTERNAL Units] to be Added to the Database ---
                //-------------------------------------------------------------------------
                OptimizerGreedyDto internalOptimizerGreedyDto = new OptimizerGreedyDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalOptimizerGreedyDto = ConvertToInternalDto(externalOptimizerGreedyDto);
                //------------------------------------------------------------
                //--- UPDATE INTERNAL Optimizer Greedy Dto to the Database ---
                //--- The Optimizer Greedy to be updated is identified by  ---
                //--- the Id field of the provided Optimizer Greedy Dto    ---
                //------------------------------------------------------------
                OptimizerGreedyRepoObj.UpdateOptimizerGreedy(internalOptimizerGreedyDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error updating optimizer greedy: {ex.Message}");
            }
        }
        #endregion  // UpdateOptimizerGreedy(OptimizerGreedyDto externalOptimizerGreedyDto) ... UPDATE

        #region DeleteOptimizerGreedy(Guid optimizerGreedyId) ... DELETE
        /// <summary>
        /// Deletes (DELETE) the optimizer greedy with the specified unique identifier.
        /// </summary>
        /// <param name="optimizerGreedyId">The unique identifier of the optimizer greedy to delete.</param>
        public void DeleteOptimizerGreedy(Guid optimizerGreedyId)
        {
            try
            {
                //-----------------------------------------------------------------------------------------------
                //--- DELETE Optimizer Greedy from the Database using the OptimizerGreedyRepo Object          ---
                //--- The Optimizer Greedy to be deleted is identified by the provided optimizerGreedyId (PK) ---
                //-----------------------------------------------------------------------------------------------
                OptimizerGreedyRepoObj.DeleteOptimizerGreedy(optimizerGreedyId);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error deleting optimizer greedy: {ex.Message}");
            }
        }
        #endregion  // DeleteOptimizerGreedy(Guid optimizerGreedyId) ... DELETE

        #endregion  // OPTIMIZER GREEDY CRUD METHODS

    }
    #endregion      // public class OptimizerGreedyViewModel

}
#endregion      // namespace HenViewModel.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
