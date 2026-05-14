#region HEADER
//#####################################################################################################################
//########################  F i r e d H e a t e r C a p i t a l C o s t V i e w M o d e l . c s  ######################
//#####################################################################################################################
//  FILENAME:  FiredHeaterCapitalCostViewModel.cs
//  NAMESPACE: HenViewModel.Project.CostParameters
//  CLASS(S):  FiredHeaterCapitalCostViewModel
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the Fired Heater Capital Cost Parameters View Model.
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
    /// Fired Heater Capital Cost view model class.
    /// </summary>
    public class FiredHeaterCapitalCostViewModel : ViewModelBase
    {
        #region PROPERTIES
        public FiredHeaterCapitalCostRepo FiredHeaterCapitalCostRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public FiredHeaterCapitalCostViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var firedHeaterCapitalCostRepoObj = new FiredHeaterCapitalCostRepo(connFactoryObj);

            FiredHeaterCapitalCostRepoObj = firedHeaterCapitalCostRepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // CTOR

        #region PRIVATE DTO CONVERSION METHODS

        #region ConvertToExternalDto(FiredHeaterCapitalCostDto internalDto)
        /// <summary>
        /// Converts a Fired Heater Capital Cost DTO from INTERNAL units to EXTERNAL units.
        /// </summary>
        /// <param name="internalDto">The Fired Heater Capital Cost DTO in INTERNAL units.</param>
        /// <returns>A <see cref="FiredHeaterCapitalCostDto"/> DTO in EXTERNAL units.</returns>
        private FiredHeaterCapitalCostDto ConvertToExternalDto(FiredHeaterCapitalCostDto internalDto)
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
            FiredHeaterCapitalCostDto externalDto = new FiredHeaterCapitalCostDto();
            //---------------------------------------------------------
            //--- Convert INTERNAL DTO Fields to EXTERNAL DTO Units ---
            //---------------------------------------------------------
            externalDto.Id = internalDto.Id;
            externalDto.ProjectId = internalDto.ProjectId;

            externalDto.ParameterAlpha_Metric  = internalDto.ParameterAlpha_Metric;
            externalDto.ParameterAlpha_English = internalDto.ParameterAlpha_English;
            externalDto.ParameterBeta          = internalDto.ParameterBeta;
            externalDto.Efficiency             = internalDto.Efficiency;
            externalDto.DutyUnits_Metric       = internalDto.DutyUnits_Metric;
            externalDto.DutyUnits_English      = internalDto.DutyUnits_English;
            //--------------------------------------------------
            //--- Return the EXTERNAL DTO in EXTERNAL units. ---
            //--------------------------------------------------
            return externalDto;
        }
        #endregion  // ConvertToExternalDto(FiredHeaterCapitalCostDto internalDto)

        #region ConvertToInternalDto(FiredHeaterCapitalCostDto externalDto)
        /// <summary>
        /// Converts a Fired Heater Capital Cost DTO from EXTERNAL units to INTERNAL units.
        /// </summary>
        /// <param name="externalDto">The Fired Heater Capital Cost DTO in EXTERNAL units.</param>
        /// <returns>A <see cref="FiredHeaterCapitalCostDto"/> DTO in INTERNAL units.</returns>
        private FiredHeaterCapitalCostDto ConvertToInternalDto(FiredHeaterCapitalCostDto externalDto)
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
            FiredHeaterCapitalCostDto internalDto = new FiredHeaterCapitalCostDto();
            //-------------------------------------------------
            //--- Convert EXTERNAL Fields to INTERNAL Units ---
            //-------------------------------------------------
            internalDto.Id = externalDto.Id;
            internalDto.ProjectId = externalDto.ProjectId;

            internalDto.ParameterAlpha_Metric  = externalDto.ParameterAlpha_Metric;
            internalDto.ParameterAlpha_English = externalDto.ParameterAlpha_English;
            internalDto.ParameterBeta          = externalDto.ParameterBeta;
            internalDto.Efficiency             = externalDto.Efficiency;
            internalDto.DutyUnits_Metric       = externalDto.DutyUnits_Metric;
            internalDto.DutyUnits_English      = externalDto.DutyUnits_English;
            //--------------------------------------------------
            //--- Return the INTERNAL DTO in INTERNAL units. ---
            //--------------------------------------------------
            return internalDto;
        }
        #endregion  // ConvertToInternalDto(FiredHeaterCapitalCostDto externalDto)

        #endregion  // PRIVATE DTO CONVERSION METHODS

        #region FIRED HEATER CAPITAL COST CRUD METHODS

        #region AddFiredHeaterCapitalCost(FiredHeaterCapitalCostDto firedHeaterCapitalCostDto) ... CREATE
        /// <summary>
        /// Adds (CREATE) a new fired heater capital cost to the database using the specified DTO.
        /// </summary>
        /// <param name="firedHeaterCapitalCostDto">The fired heater capital cost data to add.</param>
        /// <returns>A GUID representing the unique identifier of the newly added fired heater capital cost.</returns>
        public Guid AddFiredHeaterCapitalCost(FiredHeaterCapitalCostDto firedHeaterCapitalCostDto)
        {
            Guid firedHeaterCapitalCostId = new Guid();
            try
            {
                //----------------------------------------------------------------------------------
                //--- FiredHeaterCapitalCostDto Dto [INTERNAL Units] to be Added to the Database ---
                //----------------------------------------------------------------------------------
                FiredHeaterCapitalCostDto internalFiredHeaterCapitalCostDto = new FiredHeaterCapitalCostDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalFiredHeaterCapitalCostDto = ConvertToInternalDto(firedHeaterCapitalCostDto);
                //---------------------------------------------------------------
                //--- Add INTERNAL FiredHeaterCapitalCost Dto to the Database ---
                //--- using the FiredHeaterCapitalCostRepo Object             ---
                //--- Returns the FiredHeaterCapitalCost ID (PK) from the     ---
                //--- FiredHeaterCapitalCost Table database addition          ---
                //---------------------------------------------------------------
                firedHeaterCapitalCostId = 
                        FiredHeaterCapitalCostRepoObj.AddFiredHeaterCapitalCost(internalFiredHeaterCapitalCostDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding fired heater capital cost: {ex.Message}");
            }
            //----------------------------------------------------------------------------------
            //--- Return the FiredHeaterCapitalCost ID (PK) from the Database Addition       ---
            //--- This ID can be used for further operations on the newly added fired heater ---
            //--- capital cost.                                                              ---
            //--- If the addition failed, the returned ID will be an empty GUID (all zeros). ---
            //----------------------------------------------------------------------------------
            return firedHeaterCapitalCostId;
        }
        #endregion  // AddFiredHeaterCapitalCost(FiredHeaterCapitalCostDto firedHeaterCapitalCostDto) ... CREATE

        #region GetFiredHeaterCapitalCostByProjectId(Guid projectId) ... READ
        /// <summary>
        /// Retrieves (READ) the FiredHeaterCapitalCost Dto associated with the specified unique identifier.
        /// The FiredHeaterCapitalCost retrieved from the Database is in INTERNAL Units, 
        /// database access performed by the repository layer, 
        /// the fields of the FiredHeaterCapitalCost are converted to EXTERNAL Units, which are the units used in the user interface,
        /// the resulting FiredHeaterCapitalCost Dto is returned as a <see cref="FiredHeaterCapitalCostDto"/> object.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve.</param>
        /// <returns>A <see cref="FiredHeaterCapitalCostDto"/> representing the FiredHeaterCapitalCost with the specified identifier. 
        /// Returns null if no FiredHeaterCapitalCost is found.</returns>
        public FiredHeaterCapitalCostDto GetFiredHeaterCapitalCostByProjectId(Guid projectId)
        {
            FiredHeaterCapitalCostDto externalFiredHeaterCapitalCostDto = new FiredHeaterCapitalCostDto();
            try
            {
                //---------------------- Guard against empty or null projectId ------------------------
                //--- If the provided projectId is empty, return null to indicate that there is no  ---
                //--- valid fired heater capital cost to retrieve.                                  ---
                //--- This prevents unnecessary database calls and potential errors when trying to  ---
                //--- retrieve a fired heater capital cost with an invalid identifier.              ---
                //--- An empty projectId is not valid for retrieval, so we return null to indicate  ---
                //---that the fired heater capital cost cannot be found.                            ---
                //-------------------------------------------------------------------------------------
                if (projectId == Guid.Empty)
                {
                    return null; // Return null if the projectId is empty
                }
                //--------------------------------------------------------------------------
                //--- Retrieve FiredHeaterCapitalCost Dto from the Database.             ---
                //--- The retrieved FiredHeaterCapitalCost Dto is in INTERNAL Units,     ---
                //--- database access performed by the FiredHeaterCapitalCostRepo Object ---
                //--------------------------------------------------------------------------
                FiredHeaterCapitalCostDto internalFiredHeaterCapitalCostDto =
                        FiredHeaterCapitalCostRepoObj.GetFiredHeaterCapitalCostByProjectId(projectId);
                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalFiredHeaterCapitalCostDto = ConvertToExternalDto(internalFiredHeaterCapitalCostDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving fired heater capital cost: {ex.Message}");
                return null;
            }
            //--------------------------------------------------------------------------------------
            //--- Return the FiredHeaterCapitalCost Dto in EXTERNAL Units to the caller.         ---
            //--- The returned DTO can be used in the user interface or for further processing.  ---
            //--- If the retrieval failed or no fired heater capital cost is found, the returned ---
            //--- DTO will be null.                                                              ---
            //--------------------------------------------------------------------------------------
            return externalFiredHeaterCapitalCostDto;
        }
        #endregion  // GetFiredHeaterCapitalCostByProjectId(Guid projectId) ... READ

        #region UpdateFiredHeaterCapitalCost(FiredHeaterCapitalCostDto externalFiredHeaterCapitalCostDto) ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing fired heater capital cost in the database using the 
        /// specified fired heater capital cost data transfer object (DTO) with external units.
        /// </summary>
        /// <remarks>This method converts the provided fired heater capital cost data from external units to the internal
        /// units required by the database before updating the fired heater capital cost. 
        /// If the specified fired heater capital cost does not exist,
        /// the behavior depends on the repository implementation.
        /// </remarks>
        /// <param name="externalFiredHeaterCapitalCostDto">The fired heater capital cost data transfer object containing 
        /// updated fired heater capital cost information in external units. Cannot be null.
        /// </param>
        public void UpdateFiredHeaterCapitalCost(FiredHeaterCapitalCostDto externalFiredHeaterCapitalCostDto)
        {
            try
            {
                //----------------------------------------------------------------------------------
                //--- Fired Heater Capital Cost Dto [INTERNAL Units] to be Added to the Database ---
                //----------------------------------------------------------------------------------
                FiredHeaterCapitalCostDto internalFiredHeaterCapitalCostDto = new FiredHeaterCapitalCostDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalFiredHeaterCapitalCostDto = ConvertToInternalDto(externalFiredHeaterCapitalCostDto);
                //---------------------------------------------------------------------
                //--- UPDATE INTERNAL Fired Heater Capital Cost Dto to the Database ---
                //--- The Fired Heater Capital Cost to be updated is identified by  ---
                //--- the Id field of the provided Fired Heater Capital Cost Dto    ---
                //---------------------------------------------------------------------
                FiredHeaterCapitalCostRepoObj.UpdateFiredHeaterCapitalCost(internalFiredHeaterCapitalCostDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating fired heater capital cost: {ex.Message}");
            }
        }
        #endregion  // UpdateFiredHeaterCapitalCost(FiredHeaterCapitalCostDto firedHeaterCapitalCostDto) ... UPDATE

        #region DeleteFiredHeaterCapitalCost(Guid firedHeaterCapitalCostId) ... DELETE
        /// <summary>
        /// Deletes (DELETE) the fired heater capital cost with the specified unique identifier.
        /// </summary>
        /// <param name="firedHeaterCapitalCostId">The unique identifier of the fired heater capital cost to delete.</param>
        public void DeleteFiredHeaterCapitalCost(Guid firedHeaterCapitalCostId)
        {
            try
            {
                //-----------------------------------------------------------------
                //--- DELETE Fired Heater Capital Cost from the Database using  ---
                //--- the FiredHeaterCapitalCostRepo Object                     ---
                //--- The Fired Heater Capital Cost to be deleted is identified ---
                //--- by the provided firedHeaterCapitalCostId (PK)             ---
                //-----------------------------------------------------------------
                FiredHeaterCapitalCostRepoObj.DeleteFiredHeaterCapitalCost(firedHeaterCapitalCostId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting fired heater capital cost: {ex.Message}");
            }
        }
        #endregion  // DeleteFiredHeaterCapitalCost(Guid firedHeaterCapitalCostId) ... DELETE

        #endregion  // FIRED HEATER CAPITAL COST CRUD METHODS

    }
    #endregion      // public class FiredHeaterCapitalCostViewModel
}
#endregion      // namespace HenViewModel.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
