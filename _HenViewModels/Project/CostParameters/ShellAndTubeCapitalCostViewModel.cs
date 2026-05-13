#region HEADER
//#####################################################################################################################
//##################  S h e l l   a n d   T u b e   C a p i t a l   C o s t   V i e w M o d e l . c s  ################
//#####################################################################################################################
//  FILENAME:  ShellAndTubeCapitalCostViewModel.cs
//  NAMESPACE: HenViewModel.Project.CostParameters
//  CLASS(S):  ShellAndTubeCapitalCostViewModel
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the Shell and Tube Capital Cost Parameters View Model.
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
    #region public class FiredHeaterCapitalCostViewModel
    /// <summary>
    /// Shell and Tube Capital Cost view model class.
    /// </summary>
    public class ShellAndTubeCapitalCostViewModel : ViewModelBase
    {
        #region PROPERTIES
        public ShellAndTubeCapitalCostRepo ShellAndTubeCapitalCostRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public ShellAndTubeCapitalCostViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var shellAndTubeCapitalCostRepoObj = new ShellAndTubeCapitalCostRepo(connFactoryObj);

            ShellAndTubeCapitalCostRepoObj = shellAndTubeCapitalCostRepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // CTOR

        #region PRIVATE DTO CONVERSION METHODS

        #region ConvertToExternalDto(ShellAndTubeCapitalCostDto internalDto)
        /// <summary>
        /// Converts a Shell And Tube Capital Cost DTO from INTERNAL units to EXTERNAL units.
        /// </summary>
        /// <param name="internalDto">The Shell And Tube Capital Cost DTO in INTERNAL units.</param>
        /// <returns>A <see cref="ShellAndTubeCapitalCostDto"/> DTO in EXTERNAL units.</returns>
        private ShellAndTubeCapitalCostDto ConvertToExternalDto(ShellAndTubeCapitalCostDto internalDto)
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
            ShellAndTubeCapitalCostDto externalDto = new ShellAndTubeCapitalCostDto();
            //---------------------------------------------------------
            //--- Convert INTERNAL DTO Fields to EXTERNAL DTO Units ---
            //---------------------------------------------------------
            externalDto.Id = internalDto.Id;
            externalDto.ProjectId = internalDto.ProjectId;

            externalDto.ParameterA         = internalDto.ParameterA;
            externalDto.ParameterB_Metric  = internalDto.ParameterB_Metric;
            externalDto.ParameterB_English = internalDto.ParameterB_English;
            externalDto.ParameterN         = internalDto.ParameterN;
            externalDto.MaterialFactor     = internalDto.MaterialFactor;
            externalDto.AreaUnits_Metric   = internalDto.AreaUnits_Metric;
            externalDto.AreaUnits_English  = internalDto.AreaUnits_English;
            //--------------------------------------------------
            //--- Return the EXTERNAL DTO in EXTERNAL units. ---
            //--------------------------------------------------
            return externalDto;
        }
        #endregion  // ConvertToExternalDto(ShellAndTubeCapitalCostDto internalDto)

        #region ConvertToInternalDto(ShellAndTubeCapitalCostDto externalDto)
        /// <summary>
        /// Converts a Shell And Tube Capital Cost DTO from EXTERNAL units to INTERNAL units.
        /// </summary>
        /// <param name="externalDto">The Shell And Tube Capital Cost DTO in EXTERNAL units.</param>
        /// <returns>A <see cref="ShellAndTubeCapitalCostDto"/> DTO in INTERNAL units.</returns>
        private ShellAndTubeCapitalCostDto ConvertToInternalDto(ShellAndTubeCapitalCostDto externalDto)
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
            ShellAndTubeCapitalCostDto internalDto = new ShellAndTubeCapitalCostDto();
            //-------------------------------------------------
            //--- Convert EXTERNAL Fields to INTERNAL Units ---
            //-------------------------------------------------
            internalDto.Id = externalDto.Id;
            internalDto.ProjectId = externalDto.ProjectId;

            internalDto.ParameterA         = externalDto.ParameterA;
            internalDto.ParameterB_Metric  = externalDto.ParameterB_Metric;
            internalDto.ParameterB_English = externalDto.ParameterB_English;
            internalDto.ParameterN         = externalDto.ParameterN;
            internalDto.MaterialFactor     = externalDto.MaterialFactor;
            internalDto.AreaUnits_Metric   = externalDto.AreaUnits_Metric;
            internalDto.AreaUnits_English  = externalDto.AreaUnits_English;
            //--------------------------------------------------
            //--- Return the INTERNAL DTO in INTERNAL units. ---
            //--------------------------------------------------
            return internalDto;
        }
        #endregion  // ConvertToInternalDto(ShellAndTubeCapitalCostDto externalDto)

        #endregion  // PRIVATE DTO CONVERSION METHODS

        #region SHELL AND TUBE CAPITAL COST CRUD METHODS

        #region AddShellAndTubeCapitalCost(ShellAndTubeCapitalCostDto shellAndTubeCapitalCostDto) ... CREATE
        /// <summary>
        /// Adds (CREATE) a new shell and tube capital cost to the database using the specified DTO.
        /// </summary>
        /// <param name="externalShellAndTubeCapitalCostDto">The shell and tube capital cost data to add.</param>
        /// <returns>A GUID representing the unique identifier of the newly added shell and tube capital cost.</returns>
        public Guid AddShellAndTubeCapitalCost(ShellAndTubeCapitalCostDto externalShellAndTubeCapitalCostDto)
        {
            Guid shellAndTubeCapitalCostId = new Guid();
            try
            {
                //----------------------------------------------------------------------------------
                //--- ShellAndTubeCapitalCostDto Dto [INTERNAL Units] to be Added to the Database ---
                //----------------------------------------------------------------------------------
                ShellAndTubeCapitalCostDto internalShellAndTubeCapitalCostDto = new ShellAndTubeCapitalCostDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalShellAndTubeCapitalCostDto.Id        = externalShellAndTubeCapitalCostDto.Id;
                internalShellAndTubeCapitalCostDto.ProjectId = externalShellAndTubeCapitalCostDto.ProjectId;

                internalShellAndTubeCapitalCostDto.ParameterA         = externalShellAndTubeCapitalCostDto.ParameterA;
                internalShellAndTubeCapitalCostDto.ParameterB_Metric  = externalShellAndTubeCapitalCostDto.ParameterB_Metric;
                internalShellAndTubeCapitalCostDto.ParameterB_English = externalShellAndTubeCapitalCostDto.ParameterB_English;
                internalShellAndTubeCapitalCostDto.ParameterN         = externalShellAndTubeCapitalCostDto.ParameterN;
                internalShellAndTubeCapitalCostDto.MaterialFactor     = externalShellAndTubeCapitalCostDto.MaterialFactor;
                internalShellAndTubeCapitalCostDto.AreaUnits_Metric   = externalShellAndTubeCapitalCostDto.AreaUnits_Metric;
                internalShellAndTubeCapitalCostDto.AreaUnits_English  = externalShellAndTubeCapitalCostDto.AreaUnits_English;
                //-------------------------------------------------------------------------------------------------------------
                //--- Add INTERNAL ShellAndTubeCapitalCost Dto to the Database using the ShellAndTubeCapitalCostRepo Object ---
                //--- Returns the ShellAndTubeCapitalCost ID (PK) from the ShellAndTubeCapitalCost Table database addition  ---
                //-------------------------------------------------------------------------------------------------------------
                shellAndTubeCapitalCostId = ShellAndTubeCapitalCostRepoObj.AddShellAndTubeCapitalCost(internalShellAndTubeCapitalCostDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding shell and tube capital cost: {ex.Message}");
            }
            return shellAndTubeCapitalCostId;
        }
        #endregion  // AddShellAndTubeCapitalCost(ShellAndTubeCapitalCostDto shellAndTubeCapitalCostDto) ... CREATE

        #region GetShellAndTubeCapitalCostByProjectId(Guid projectId) ... READ
        /// <summary>
        /// Retrieves (READ) the ShellAndTubeCapitalCost Dto associated with the specified unique identifier.
        /// The ShellAndTubeCapitalCost retrieved from the Database is in INTERNAL Units, 
        /// database access performed by the repository layer, 
        /// the fields of the ShellAndTubeCapitalCost are converted to EXTERNAL Units, which are the units used in the user interface,
        /// the resulting ShellAndTubeCapitalCost Dto is returned as a <see cref="ShellAndTubeCapitalCostDto"/> object.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve.</param>
        /// <returns>A <see cref="ShellAndTubeCapitalCostDto"/> representing the ShellAndTubeCapitalCost with the specified identifier. 
        /// Returns null if no ShellAndTubeCapitalCost is found.</returns>
        public ShellAndTubeCapitalCostDto GetShellAndTubeCapitalCostByProjectId(Guid projectId)
        {
            ShellAndTubeCapitalCostDto externalShellAndTubeCapitalCostDto = new ShellAndTubeCapitalCostDto();
            try
            {
                //---------------------------------------------------------------------------
                //--- Retrieve ShellAndTubeCapitalCost Dto from the Database.             ---
                //--- The retrieved ShellAndTubeCapitalCost Dto is in INTERNAL Units,     ---
                //--- database access performed by the ShellAndTubeCapitalCostRepo Object ---
                //---------------------------------------------------------------------------
                ShellAndTubeCapitalCostDto internalShellAndTubeCapitalCostDto =
                    ShellAndTubeCapitalCostRepoObj.GetShellAndTubeCapitalCostByProjectId(projectId);
                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalShellAndTubeCapitalCostDto.Id        = internalShellAndTubeCapitalCostDto.Id;
                externalShellAndTubeCapitalCostDto.ProjectId = internalShellAndTubeCapitalCostDto.ProjectId;

                externalShellAndTubeCapitalCostDto.ParameterA         = internalShellAndTubeCapitalCostDto.ParameterA;
                externalShellAndTubeCapitalCostDto.ParameterB_Metric  = internalShellAndTubeCapitalCostDto.ParameterB_Metric;
                externalShellAndTubeCapitalCostDto.ParameterB_English = internalShellAndTubeCapitalCostDto.ParameterB_English;
                externalShellAndTubeCapitalCostDto.ParameterN         = internalShellAndTubeCapitalCostDto.ParameterN;
                externalShellAndTubeCapitalCostDto.MaterialFactor     = internalShellAndTubeCapitalCostDto.MaterialFactor;
                externalShellAndTubeCapitalCostDto.AreaUnits_Metric   = internalShellAndTubeCapitalCostDto.AreaUnits_Metric;
                externalShellAndTubeCapitalCostDto.AreaUnits_English  = internalShellAndTubeCapitalCostDto.AreaUnits_English;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving shell and tube capital cost: {ex.Message}");
                return null;
            }

            return externalShellAndTubeCapitalCostDto;
        }
        #endregion  // GetShellAndTubeCapitalCostByProjectId(Guid projectId) ... READ

        #region UpdateShellAndTubeCapitalCost(ShellAndTubeCapitalCostDto externalShellAndTubeCapitalCostDto) ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing shell and tube capital cost in the database using the 
        /// specified shell and tube capital cost data transfer object (DTO) with external units.
        /// </summary>
        /// <remarks>This method converts the provided shell and tube capital cost data from external units to the internal
        /// units required by the database before updating the shell and tube capital cost. 
        /// If the specified shell and tube capital cost does not exist,
        /// the behavior depends on the repository implementation.
        /// </remarks>
        /// <param name="externalShellAndTubeCapitalCostDto">The shell and tube capital cost data transfer object 
        /// containing updated shell and tube capital cost information in external units. Cannot be null.
        /// </param>
        public void UpdateShellAndTubeCapitalCost(ShellAndTubeCapitalCostDto externalShellAndTubeCapitalCostDto)
        {
            try
            {
                //----------------------------------------------------------------------------------
                //--- Shell and Tube Capital Cost Dto [INTERNAL Units] to be Added to the Database ---
                //----------------------------------------------------------------------------------
                ShellAndTubeCapitalCostDto internalShellAndTubeCapitalCostDto = new ShellAndTubeCapitalCostDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalShellAndTubeCapitalCostDto.Id        = externalShellAndTubeCapitalCostDto.Id;
                internalShellAndTubeCapitalCostDto.ProjectId = externalShellAndTubeCapitalCostDto.ProjectId;

                internalShellAndTubeCapitalCostDto.ParameterA         = externalShellAndTubeCapitalCostDto.ParameterA;
                internalShellAndTubeCapitalCostDto.ParameterB_Metric  = externalShellAndTubeCapitalCostDto.ParameterB_Metric;
                internalShellAndTubeCapitalCostDto.ParameterB_English = externalShellAndTubeCapitalCostDto.ParameterB_English;
                internalShellAndTubeCapitalCostDto.ParameterN         = externalShellAndTubeCapitalCostDto.ParameterN;
                internalShellAndTubeCapitalCostDto.MaterialFactor     = externalShellAndTubeCapitalCostDto.MaterialFactor;
                internalShellAndTubeCapitalCostDto.AreaUnits_Metric   = externalShellAndTubeCapitalCostDto.AreaUnits_Metric;
                internalShellAndTubeCapitalCostDto.AreaUnits_English  = externalShellAndTubeCapitalCostDto.AreaUnits_English;
                //-----------------------------------------------------------------------
                //--- UPDATE INTERNAL Shell and Tube Capital Cost Dto to the Database ---
                //--- The Shell and Tube Capital Cost to be updated is identified by  ---
                //--- the Id field of the provided Shell and Tube Capital Cost Dto    ---
                //-----------------------------------------------------------------------
                ShellAndTubeCapitalCostRepoObj.UpdateShellAndTubeCapitalCost(internalShellAndTubeCapitalCostDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating shell and tube capital cost: {ex.Message}");
            }
        }
        #endregion  // UpdateShellAndTubeCapitalCost(ShellAndTubeCapitalCostDto shellAndTubeCapitalCostDto) ... UPDATE

        #region DeleteShellAndTubeCapitalCost(Guid shellAndTubeCapitalCostId) ... DELETE
        /// <summary>
        /// Deletes (DELETE) the shell and tube capital cost with the specified unique identifier.
        /// </summary>
        /// <param name="shellAndTubeCapitalCostId">The unique identifier of the shell and tube capital cost to delete.</param>
        public void DeleteShellAndTubeCapitalCost(Guid shellAndTubeCapitalCostId)
        {
            try
            {
                //------------------------------------------------------------------------------------------------------------------
                //--- DELETE Shell and Tube Capital Cost from the Database using the ShellAndTubeCapitalCostRepo Object          ---
                //--- The Shell and Tube Capital Cost to be deleted is identified by the provided shellAndTubeCapitalCostId (PK) ---
                //------------------------------------------------------------------------------------------------------------------
                ShellAndTubeCapitalCostRepoObj.DeleteShellAndTubeCapitalCost(shellAndTubeCapitalCostId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting shell and tube capital cost: {ex.Message}");
            }
        }
        #endregion  // DeleteShellAndTubeCapitalCost(Guid shellAndTubeCapitalCostId) ... DELETE

        #endregion  // SHELL AND TUBE CAPITAL COST CRUD METHODS

    }
    #endregion      // public class ShellAndTubeCapitalCostViewModel
}
#endregion      // namespace HenViewModel.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
