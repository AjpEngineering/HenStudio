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

        #region GetOptimizerParamByProjectId(Guid projectId)
        /// <summary>
        /// Retrieves the OptimizerParams Dto associated with the specified unique identifier.
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
                //---------------------------------------------------------------------------------
                //--- Retrieve OptimizerParams Dto from the Database using the Repository layer ---
                //---------------------------------------------------------------------------------
                OptimizerParamsDto internalOptimizerParams = 
                    OptimizerParamsRepoObj.GetOptimizerParamsByProjectId(projectId);     // Retrieved OptimizerParams Dto [INTERNAL Units]

                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalOptimizerParamsDto.Id = internalOptimizerParams.Id;
                externalOptimizerParamsDto.ProjectId = internalOptimizerParams.ProjectId;
                externalOptimizerParamsDto.Name = internalOptimizerParams.Name;
                externalOptimizerParamsDto.Description = internalOptimizerParams.Description;
                externalOptimizerParamsDto.OptimizerType = internalOptimizerParams.OptimizerType;
                externalOptimizerParamsDto.DefaultObjective = internalOptimizerParams.DefaultObjective;
                externalOptimizerParamsDto.DefaultMaxIterations = internalOptimizerParams.DefaultMaxIterations;
                externalOptimizerParamsDto.DefaultConvergenceTolerance = internalOptimizerParams.DefaultConvergenceTolerance;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving optimizer params: {ex.Message}");
                return null; // Return null if an error occurs
            }

            return externalOptimizerParamsDto;
        }
        #endregion  // GetOptimizerParamByProjectId(Guid projectId)

        #region AddOptimizerParam(OptimizerParamsDto externalOptimizerParamsDto)
        /// <summary>
        /// Adds a new project units to the database using the specified project data transfer object.
        /// </summary>
        /// <remarks>The method converts the provided project data from external to internal units before
        /// storing it in the database. If an error occurs during the operation, the method logs the error and returns
        /// an empty GUID.</remarks>
        /// <param name="externalOptimizerParamsDto">The optimizer params data to add. The object must contain all required optimizer params fields in external units. Cannot be
        /// null.</param>
        /// <returns>A GUID representing the unique identifier of the newly added optimizer params.</returns>
        public Guid AddOptimizerParam(OptimizerParamsDto externalOptimizerParamsDto)
        {
            Guid optimizerParamsID = new Guid();
            try
            {
                //----------------------------------------------------------------
                //--- Project Dto [INTERNAL Units] to be Added to the Database ---
                //----------------------------------------------------------------
                OptimizerParamsDto internalOptimizerParamsDto = new OptimizerParamsDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalOptimizerParamsDto.Id = externalOptimizerParamsDto.Id;
                internalOptimizerParamsDto.ProjectId = externalOptimizerParamsDto.ProjectId;
                internalOptimizerParamsDto.Name = externalOptimizerParamsDto.Name;
                internalOptimizerParamsDto.Description = externalOptimizerParamsDto.Description;
                internalOptimizerParamsDto.OptimizerType = externalOptimizerParamsDto.OptimizerType;
                internalOptimizerParamsDto.DefaultObjective = externalOptimizerParamsDto.DefaultObjective;
                internalOptimizerParamsDto.DefaultMaxIterations = externalOptimizerParamsDto.DefaultMaxIterations;
                internalOptimizerParamsDto.DefaultConvergenceTolerance = externalOptimizerParamsDto.DefaultConvergenceTolerance;
                //----------------------------------------------------------------------------
                //--- Add INTERNAL OptimizerParams Dto to the Database using the Repository Layer  ---
                //--- Returns the OptimizerParams ID (PK) from the OptimizerParams Table database addition ---
                //----------------------------------------------------------------------------
                optimizerParamsID = OptimizerParamsRepoObj.AddOptimizerParams(internalOptimizerParamsDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving optimizer params: {ex.Message}");
            }
            return optimizerParamsID; // Return Optimizer Params ID (PK) from the Optimizer Params Table database addition
        }
        #endregion  // AddOptimizerParam(OptimizerParamsDto externalOptimizerParamsDto)
        
        #region UpdateOptimizerParam(OptimizerParamsDto externalOptimizerParamsDto)
        /// <summary>
        /// Updates an existing optimizer params in the database using the specified optimizer params data transfer object (DTO) 
        /// with external units.
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
                //----------------------------------------------------------------------
                //--- Optimizer Params Dto [INTERNAL Units] to be Added to the Database ---
                //----------------------------------------------------------------------
                OptimizerParamsDto internalOptimizerParamDto = new OptimizerParamsDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalOptimizerParamDto.Id = externalOptimizerParamDto.Id;
                internalOptimizerParamDto.ProjectId = externalOptimizerParamDto.ProjectId;
                internalOptimizerParamDto.Name = externalOptimizerParamDto.Name;
                internalOptimizerParamDto.Description = externalOptimizerParamDto.Description;
                internalOptimizerParamDto.OptimizerType = externalOptimizerParamDto.OptimizerType;
                internalOptimizerParamDto.DefaultObjective = externalOptimizerParamDto.DefaultObjective;
                internalOptimizerParamDto.DefaultMaxIterations = externalOptimizerParamDto.DefaultMaxIterations;
                internalOptimizerParamDto.DefaultConvergenceTolerance = externalOptimizerParamDto.DefaultConvergenceTolerance;
                //------------------------------------------------------------------------------
                //--- UPDATE INTERNAL Optimizer Params Dto to the Database using the Repository Layer ---
                //------------------------------------------------------------------------------
                OptimizerParamsRepoObj.UpdateOptimizerParams(internalOptimizerParamDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error updating optimizer params: {ex.Message}");
            }
        }
        #endregion  // UpdateOptimizerParam(OptimizerParamsDto externalOptimizerParamsDto)

        #region DeleteOptimizerParams(Guid optimizerParamsId)
        /// <summary>
        /// Deletes the optimizer params with the specified unique identifier.
        /// </summary>
        /// <param name="optimizerParamsId">The unique identifier of the optimizer params to delete.</param>
        public void DeleteOptimizerParams(Guid optimizerParamsId)
        {
            try
            {
                //-------------------------------------------------------------------
                //--- DELETE Optimizer Params from the Database using the Repository Layer ---
                //-------------------------------------------------------------------
                OptimizerParamsRepoObj.DeleteOptimizerParams(optimizerParamsId);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error deleting optimizer params: {ex.Message}");
            }
        }
        #endregion  // DeleteOptimizerParams(Guid optimizerParamsId)

    }
    #endregion      // public class OptimizerParamsViewModel

}
#endregion      // namespace HenViewModel.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
