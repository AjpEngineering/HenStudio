#region HEADER
//#####################################################################################################################
//###############################  O p t i m i z e r M I L P _ V i e w M o d e l . c s  ###############################
//#####################################################################################################################
//  FILENAME:  OptimizerMILP_ViewModel.cs
//  NAMESPACE: HenViewModel.Project.DefaultParameters.OptimizerParams
//  CLASS(S):  OptimizerMILP_ViewModel
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
    #region public class OptimizerMILP_ViewModel
    /// <summary>
    /// Optimizer MILP View Model class.
    /// </summary>
    public class OptimizerMILP_ViewModel : ViewModelBase
    {
        #region PROPERTIES
        public OptimizerMILP_Repo OptimizerMILP_RepoObj { get; set; }
        #endregion      // PROPERTIES

        #region DEFAULT CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public OptimizerMILP_ViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var optimizerMILP_RepoObj = new OptimizerMILP_Repo(connFactoryObj);

            OptimizerMILP_RepoObj = optimizerMILP_RepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // DEFAULT CTOR

        #region PRIVATE DTO CONVERSION METHODS

        #region ConvertToExternalDto(OptimizerMILP_Dto internalDto)
        /// <summary>
        /// Converts a Optimizer MILP DTO from INTERNAL units to EXTERNAL units.
        /// </summary>
        /// <param name="internalDto">The Optimizer MILP DTO in INTERNAL units.</param>
        /// <returns>A <see cref="OptimizerMILP_Dto"/> DTO in EXTERNAL units.</returns>
        private OptimizerMILP_Dto ConvertToExternalDto(OptimizerMILP_Dto internalDto)
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
            OptimizerMILP_Dto externalDto = new OptimizerMILP_Dto();
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
        #endregion  // ConvertToExternalDto(OptimizerMILP_Dto internalDto)

        #region ConvertToInternalDto(OptimizerMILP_Dto externalDto)
        /// <summary>
        /// Converts a Optimizer MILP DTO from EXTERNAL units to INTERNAL units.
        /// </summary>
        /// <param name="externalDto">The Optimizer MILP DTO in EXTERNAL units.</param>
        /// <returns>A <see cref="OptimizerMILP_Dto"/> DTO in INTERNAL units.</returns>
        private OptimizerMILP_Dto ConvertToInternalDto(OptimizerMILP_Dto externalDto)
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
            OptimizerMILP_Dto internalDto = new OptimizerMILP_Dto();
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
        #endregion  // ConvertToInternalDto(OptimizerMILP_Dto externalDto)

        #endregion  // PRIVATE DTO CONVERSION METHODS

        #region OPTIMIZER MILP CRUD METHODS

        #region AddOptimizerMILP(OptimizerMILP_Dto externalOptimizerMILP_Dto) ... CREATE
        /// <summary>
        /// Adds (CREATE) a new optimizer MILP to the database using the specified optimizer MILP data transfer object.
        /// </summary>
        /// <remarks>The method converts the provided optimizer MILP data from external to internal units before
        /// storing it in the database. If an error occurs during the operation, the method logs the error and returns
        /// an empty GUID.</remarks>
        /// <param name="externalOptimizerMILP_Dto">The optimizer MILP data to add. The object must contain 
        /// all required optimizer MILP fields in external units. Cannot be null.</param>
        /// <returns>A GUID representing the unique identifier of the newly added optimizer MILP.</returns>
        public Guid AddOptimizerMILP(OptimizerMILP_Dto externalOptimizerMILP_Dto)
        {
            Guid optimizerMILP_ID = new Guid();
            try
            {
                //----------------------------------------------------------------------
                //--- OptimizerMILP Dto [INTERNAL Units] to be Added to the Database ---
                //----------------------------------------------------------------------
                OptimizerMILP_Dto internalOptimizerMILP_Dto = new OptimizerMILP_Dto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalOptimizerMILP_Dto.Id = externalOptimizerMILP_Dto.Id;
                internalOptimizerMILP_Dto.OptimizerParamsId = externalOptimizerMILP_Dto.OptimizerParamsId;

                internalOptimizerMILP_Dto.Name        = externalOptimizerMILP_Dto.Name;
                internalOptimizerMILP_Dto.Description = externalOptimizerMILP_Dto.Description;
                //-----------------------------------------------------------------------------------------
                //--- Add INTERNAL OptimizerMILP Dto to the Database using the OptimizerMILPRepo Object ---
                //--- Returns the OptimizerMILP ID (PK) from the OptimizerMILP Table database addition  ---
                //-----------------------------------------------------------------------------------------
                optimizerMILP_ID = OptimizerMILP_RepoObj.AddOptimizerMILP(internalOptimizerMILP_Dto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving optimizer MILP: {ex.Message}");
            }
            return optimizerMILP_ID; // Return Optimizer MILP ID (PK) from the Optimizer MILP Table database addition
        }
        #endregion  // AddOptimizerMILP(OptimizerMILP_Dto externalOptimizerMILP_Dto) ... CREATE

        #region GetOptimizerMILP_ById(Guid optimizerMILP_Id) ... READ
        /// <summary>
        /// Retrieves (READ) the OptimizerMILP Dto associated with the specified unique identifier.
        /// The OptimizerMILP retrieved from the Database is in INTERNAL Units, 
        /// database access performed by the repository layer, 
        /// the fields of the OptimizerMILP are converted to EXTERNAL Units, which are the units used in the user interface,
        /// the resulting OptimizerMILP Dto is returned as a <see cref="OptimizerMILP_Dto"/> object.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve.</param>
        /// <returns>A <see cref="OptimizerMILP_Dto"/> representing the OptimizerMILP with the specified identifier. 
        /// Returns null if no OptimizerMILP is found.</returns>
        public OptimizerMILP_Dto GetOptimizerMILP_ById(Guid optimizerMILP_Id)
        {
            OptimizerMILP_Dto externalOptimizerMILP_Dto = new OptimizerMILP_Dto();
            try
            {
                //-----------------------------------------------------------------
                //--- Retrieve OptimizerMILP Dto from the Database.             ---
                //--- The retrieved OptimizerMILP Dto is in INTERNAL Units,     ---
                //--- database access performed by the OptimizerMILPRepo Object ---
                //-----------------------------------------------------------------
                OptimizerMILP_Dto internalOptimizerMILP_Dto = 
                    OptimizerMILP_RepoObj.GetOptimizerMILP_ById(optimizerMILP_Id);
                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalOptimizerMILP_Dto.Id = internalOptimizerMILP_Dto.Id;
                externalOptimizerMILP_Dto.OptimizerParamsId = internalOptimizerMILP_Dto.OptimizerParamsId;

                externalOptimizerMILP_Dto.Name        = internalOptimizerMILP_Dto.Name;
                externalOptimizerMILP_Dto.Description = internalOptimizerMILP_Dto.Description;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving optimizer MILP: {ex.Message}");
                return null; // Return null if an error occurs
            }

            return externalOptimizerMILP_Dto;
        }
        #endregion  // GetOptimizerMILP_ById(Guid optimizerMILP_Id) ... READ

        #region GetOptimizerMILP_ByOptimizerParamsId(Guid optimizerParamsId) ... READ
        /// <summary>
        /// Retrieves (READ) the OptimizerMILP Dto associated with the specified unique identifier.
        /// The OptimizerMILP retrieved from the Database is in INTERNAL Units, 
        /// database access performed by the repository layer, 
        /// the fields of the OptimizerMILP are converted to EXTERNAL Units, which are the units used in the user interface,
        /// the resulting OptimizerMILP Dto is returned as a <see cref="OptimizerMILP_Dto"/> object.
        /// </summary>
        /// <param name="optimizerParamsId">The unique identifier of the OptimizerParams to retrieve.</param>
        /// <returns>A <see cref="OptimizerMILP_Dto"/> representing the OptimizerMILP with the specified identifier. 
        /// Returns null if no OptimizerMILP is found.</returns>
        public OptimizerMILP_Dto GetOptimizerMILP_ByOptimizerParamsId(Guid optimizerParamsId)
        {
            OptimizerMILP_Dto externalOptimizerMILP_Dto = new OptimizerMILP_Dto();
            try
            {
                //-----------------------------------------------------------------
                //--- Retrieve OptimizerGreedy Dto from the Database.           ---
                //--- The retrieved OptimizerGreedy Dto is in INTERNAL Units,   ---
                //--- database access performed by the OptimizerMILPRepo Object ---
                //-----------------------------------------------------------------
                OptimizerMILP_Dto internalOptimizerMILP =
                    OptimizerMILP_RepoObj.GetOptimizerMILP_ByOptimizerParamsId(optimizerParamsId);
                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalOptimizerMILP_Dto.Id = internalOptimizerMILP.Id;
                externalOptimizerMILP_Dto.OptimizerParamsId = internalOptimizerMILP.OptimizerParamsId;

                externalOptimizerMILP_Dto.Name = internalOptimizerMILP.Name;
                externalOptimizerMILP_Dto.Description = internalOptimizerMILP.Description;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving optimizer MILP: {ex.Message}");
                return null; // Return null if an error occurs
            }

            return externalOptimizerMILP_Dto;
        }
        #endregion  // GetOptimizerMILP_ByOptimizerParamsId(Guid optimizerParamsId) ... READ

        #region UpdateOptimizerMILP(OptimizerMILP_Dto externalOptimizerMILP_Dto) ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing optimizer greedy in the database using the specified 
        /// optimizer greedy data transfer object (DTO) with external units.
        /// </summary>
        /// <remarks>This method converts the provided optimizer greedy data from external units to the internal
        /// units required by the database before updating the optimizer greedy. If the specified optimizer greedy does not exist,
        /// the behavior depends on the repository implementation.</remarks>
        /// <param name="externalOptimizerMILP_Dto">The optimizer MILP data transfer object containing updated optimizer MILP 
        /// information in external units. Cannot be null.</param>
        public void UpdateOptimizerMILP(OptimizerMILP_Dto externalOptimizerMILP_Dto)
        {
            try
            {
                //-----------------------------------------------------------------------
                //--- Optimizer MILP Dto [INTERNAL Units] to be Added to the Database ---
                //-----------------------------------------------------------------------
                OptimizerMILP_Dto internalOptimizerMILP_Dto = new OptimizerMILP_Dto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalOptimizerMILP_Dto.Id = externalOptimizerMILP_Dto.Id;
                internalOptimizerMILP_Dto.OptimizerParamsId = externalOptimizerMILP_Dto.OptimizerParamsId;

                internalOptimizerMILP_Dto.Name        = externalOptimizerMILP_Dto.Name;
                internalOptimizerMILP_Dto.Description = externalOptimizerMILP_Dto.Description;
                //----------------------------------------------------------
                //--- UPDATE INTERNAL Optimizer MILP Dto to the Database ---
                //--- The Optimizer MILP to be updated is identified by  ---
                //--- the Id field of the provided Optimizer MILP Dto    ---
                //----------------------------------------------------------
                OptimizerMILP_RepoObj.UpdateOptimizerMILP(internalOptimizerMILP_Dto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error updating optimizer MILP: {ex.Message}");
            }
        }
        #endregion  // UpdateOptimizerMILP(OptimizerMILP_Dto externalOptimizerMILP_Dto) ... UPDATE

        #region DeleteOptimizerMILP(Guid optimizerMILP_Id) ... DELETE
        /// <summary>
        /// Deletes (DELETE) the optimizer MILP with the specified unique identifier.
        /// </summary>
        /// <param name="optimizerMILP_Id">The unique identifier of the optimizer MILP to delete.</param>
        public void DeleteOptimizerMILP(Guid optimizerMILP_Id)
        {
            try
            {
                //--------------------------------------------------------------------------------------------
                //--- DELETE Optimizer MILP from the Database using the OptimizerMILP_Repo Object          ---
                //--- The Optimizer MILP to be deleted is identified by the provided optimizerMILP_Id (PK) ---
                //--------------------------------------------------------------------------------------------
                OptimizerMILP_RepoObj.DeleteOptimizerMILP(optimizerMILP_Id);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error deleting optimizer MILP: {ex.Message}");
            }
        }
        #endregion  // DeleteOptimizerMILP(Guid optimizerMILP_Id) ... DELETE

        #endregion  // OPTIMIZER MILP CRUD METHODS

    }
    #endregion      // public class OptimizerMILP_ViewModel

}
#endregion      // namespace HenViewModel.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
