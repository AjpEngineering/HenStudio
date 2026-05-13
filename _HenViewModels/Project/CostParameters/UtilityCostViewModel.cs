#region HEADER
//#####################################################################################################################
//#################################  U t i l i t y   C o s t   V i e w M o d e l . c s  ###############################
//#####################################################################################################################
//  FILENAME:  UtilityCostViewModel.cs
//  NAMESPACE: HenViewModel.Project.CostParameters
//  CLASS(S):  UtilityCostViewModel
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the Utility Cost Parameters View Model.
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
    #region public class UtilityCostViewModel
    /// <summary>
    /// Utility Cost view model class.
    /// </summary>
    public class UtilityCostViewModel : ViewModelBase
    {
        #region PROPERTIES
        public UtilityCostRepo UtilityCostRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public UtilityCostViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var utilityCostRepoObj = new UtilityCostRepo(connFactoryObj);

            UtilityCostRepoObj = utilityCostRepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // CTOR

        #region UTILITY COST CRUD METHODS

        #region AddUtilityCost(UtilityCostDto utilityCostDto) ... CREATE
        /// <summary>
        /// Adds (CREATE) a new utility cost to the database using the specified DTO.
        /// </summary>
        /// <param name="externalUtilityCostDto">The utility cost data to add.</param>
        /// <returns>A GUID representing the unique identifier of the newly added utility cost.</returns>
        public Guid AddUtilityCost(UtilityCostDto externalUtilityCostDto)
        {
            Guid utilityCostId = new Guid();
            try
            {
                //-----------------------------------------------------------------------
                //--- UtilityCostDto Dto [INTERNAL Units] to be Added to the Database ---
                //-----------------------------------------------------------------------
                UtilityCostDto internalUtilityCostDto = new UtilityCostDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalUtilityCostDto.Id        = externalUtilityCostDto.Id;
                internalUtilityCostDto.ProjectId = externalUtilityCostDto.ProjectId;

                internalUtilityCostDto.HP_SteamCost_Metric      = externalUtilityCostDto.HP_SteamCost_Metric;
                internalUtilityCostDto.MP_SteamCost_Metric      = externalUtilityCostDto.MP_SteamCost_Metric;
                internalUtilityCostDto.LP_SteamCost_Metric      = externalUtilityCostDto.LP_SteamCost_Metric;
                internalUtilityCostDto.CoolingWaterCost_Metric  = externalUtilityCostDto.CoolingWaterCost_Metric;
                internalUtilityCostDto.ChilledWaterCost_Metric  = externalUtilityCostDto.ChilledWaterCost_Metric;
                internalUtilityCostDto.FuelGasCost_Metric       = externalUtilityCostDto.FuelGasCost_Metric;

                internalUtilityCostDto.HP_SteamCost_English     = externalUtilityCostDto.HP_SteamCost_English;
                internalUtilityCostDto.MP_SteamCost_English     = externalUtilityCostDto.MP_SteamCost_English;
                internalUtilityCostDto.LP_SteamCost_English     = externalUtilityCostDto.LP_SteamCost_English;
                internalUtilityCostDto.CoolingWaterCost_English = externalUtilityCostDto.CoolingWaterCost_English;
                internalUtilityCostDto.ChilledWaterCost_English = externalUtilityCostDto.ChilledWaterCost_English;
                internalUtilityCostDto.FuelGasCost_English      = externalUtilityCostDto.FuelGasCost_English;

                internalUtilityCostDto.DutyUnits_Metric         = externalUtilityCostDto.DutyUnits_Metric;
                internalUtilityCostDto.DutyUnits_English        = externalUtilityCostDto.DutyUnits_English;
                //-------------------------------------------------------------------------------------
                //--- Add INTERNAL UtilityCost Dto to the Database using the UtilityCostRepo Object ---
                //--- Returns the UtilityCost ID (PK) from the UtilityCost Table database addition  ---
                //-------------------------------------------------------------------------------------
                utilityCostId = UtilityCostRepoObj.AddUtilityCost(internalUtilityCostDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding utility cost: {ex.Message}");
            }
            return utilityCostId;
        }
        #endregion  // AddUtilityCost(UtilityCostDto utilityCostDto) ... CREATE
        
        #region GetUtilityCostByProjectId(Guid projectId) ... READ
        /// <summary>
        /// Retrieves (READ) the UtilityCost Dto associated with the specified unique identifier.
        /// The UtilityCost retrieved from the Database is in INTERNAL Units, 
        /// database access performed by the repository layer, 
        /// the fields of the UtilityCost are converted to EXTERNAL Units, which are the units used in the user interface,
        /// the resulting UtilityCost Dto is returned as a <see cref="UtilityCostDto"/> object.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve.</param>
        /// <returns>A <see cref="UtilityCostDto"/> representing the UtilityCost with the specified identifier. 
        /// Returns null if no UtilityCost is found.</returns>
        public UtilityCostDto GetUtilityCostByProjectId(Guid projectId)
        {
            UtilityCostDto externalUtilityCostDto = new UtilityCostDto();
            try
            {
                //---------------------------------------------------------------
                //--- Retrieve UtilityCost Dto from the Database.             ---
                //--- The retrieved UtilityCost Dto is in INTERNAL Units,     ---
                //--- database access performed by the UtilityCostRepo Object ---
                //---------------------------------------------------------------
                UtilityCostDto internalUtilityCostDto =
                    UtilityCostRepoObj.GetUtilityCostByProjectId(projectId);
                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalUtilityCostDto.Id        = internalUtilityCostDto.Id;
                externalUtilityCostDto.ProjectId = internalUtilityCostDto.ProjectId;

                externalUtilityCostDto.HP_SteamCost_Metric      = internalUtilityCostDto.HP_SteamCost_Metric;
                externalUtilityCostDto.MP_SteamCost_Metric      = internalUtilityCostDto.MP_SteamCost_Metric;
                externalUtilityCostDto.LP_SteamCost_Metric      = internalUtilityCostDto.LP_SteamCost_Metric;
                externalUtilityCostDto.CoolingWaterCost_Metric  = internalUtilityCostDto.CoolingWaterCost_Metric;
                externalUtilityCostDto.ChilledWaterCost_Metric  = internalUtilityCostDto.ChilledWaterCost_Metric;
                externalUtilityCostDto.FuelGasCost_Metric       = internalUtilityCostDto.FuelGasCost_Metric;

                externalUtilityCostDto.HP_SteamCost_English     = internalUtilityCostDto.HP_SteamCost_English;
                externalUtilityCostDto.MP_SteamCost_English     = internalUtilityCostDto.MP_SteamCost_English;
                externalUtilityCostDto.LP_SteamCost_English     = internalUtilityCostDto.LP_SteamCost_English;
                externalUtilityCostDto.CoolingWaterCost_English = internalUtilityCostDto.CoolingWaterCost_English;
                externalUtilityCostDto.ChilledWaterCost_English = internalUtilityCostDto.ChilledWaterCost_English;
                externalUtilityCostDto.FuelGasCost_English      = internalUtilityCostDto.FuelGasCost_English;

                externalUtilityCostDto.DutyUnits_Metric         = internalUtilityCostDto.DutyUnits_Metric;
                externalUtilityCostDto.DutyUnits_English        = internalUtilityCostDto.DutyUnits_English;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving utility cost: {ex.Message}");
                return null;
            }

            return externalUtilityCostDto;
        }
        #endregion  // GetUtilityCostByProjectId(Guid projectId) ... READ

        #region UpdateUtilityCost(UtilityCostDto externalUtilityCostDto) ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing utility cost in the database using the 
        /// specified utility cost data transfer object (DTO) with external units.
        /// </summary>
        /// <remarks>This method converts the provided utility cost data from external units to the internal
        /// units required by the database before updating the cost metadata. If the specified cost metadata does not exist,
        /// the behavior depends on the repository implementation.</remarks>
        /// <param name="externalUtilityCostDto">The utility cost data transfer object containing updated utility cost 
        /// information in external units. Cannot be null.</param>
        public void UpdateUtilityCost(UtilityCostDto externalUtilityCostDto)
        {
            try
            {
                //---------------------------------------------------------------------
                //--- Utility Cost Dto [INTERNAL Units] to be Added to the Database ---
                //---------------------------------------------------------------------
                UtilityCostDto internalUtilityCostDto = new UtilityCostDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalUtilityCostDto.Id        = externalUtilityCostDto.Id;
                internalUtilityCostDto.ProjectId = externalUtilityCostDto.ProjectId;

                internalUtilityCostDto.HP_SteamCost_Metric      = externalUtilityCostDto.HP_SteamCost_Metric;
                internalUtilityCostDto.MP_SteamCost_Metric      = externalUtilityCostDto.MP_SteamCost_Metric;
                internalUtilityCostDto.LP_SteamCost_Metric      = externalUtilityCostDto.LP_SteamCost_Metric;
                internalUtilityCostDto.CoolingWaterCost_Metric  = externalUtilityCostDto.CoolingWaterCost_Metric;
                internalUtilityCostDto.ChilledWaterCost_Metric  = externalUtilityCostDto.ChilledWaterCost_Metric;
                internalUtilityCostDto.FuelGasCost_Metric       = externalUtilityCostDto.FuelGasCost_Metric;

                internalUtilityCostDto.HP_SteamCost_English     = externalUtilityCostDto.HP_SteamCost_English;
                internalUtilityCostDto.MP_SteamCost_English     = externalUtilityCostDto.MP_SteamCost_English;
                internalUtilityCostDto.LP_SteamCost_English     = externalUtilityCostDto.LP_SteamCost_English;
                internalUtilityCostDto.CoolingWaterCost_English = externalUtilityCostDto.CoolingWaterCost_English;
                internalUtilityCostDto.ChilledWaterCost_English = externalUtilityCostDto.ChilledWaterCost_English;
                internalUtilityCostDto.FuelGasCost_English      = externalUtilityCostDto.FuelGasCost_English;

                internalUtilityCostDto.DutyUnits_Metric         = externalUtilityCostDto.DutyUnits_Metric;
                internalUtilityCostDto.DutyUnits_English        = externalUtilityCostDto.DutyUnits_English;
                //--------------------------------------------------------
                //--- UPDATE INTERNAL Utility Cost Dto to the Database ---
                //--- The Utility Cost to be updated is identified by  ---
                //--- the Id field of the provided Utility Cost Dto    ---
                //--------------------------------------------------------
                UtilityCostRepoObj.UpdateUtilityCost(internalUtilityCostDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating utility cost: {ex.Message}");
            }
        }
        #endregion  // UpdateUtilityCost(UtilityCostDto externalUtilityCostDto) ... UPDATE

        #region DeleteUtilityCost(Guid utilityCostId) ... DELETE
        /// <summary>
        /// Deletes (DELETE) the utility cost with the specified unique identifier.
        /// </summary>
        /// <param name="utilityCostId">The unique identifier of the utility cost to delete.</param>
        public void DeleteUtilityCost(Guid utilityCostId)
        {
            try
            {
                //---------------------------------------------------------------------------------------
                //--- DELETE Utility Cost from the Database using the UtilityCostRepo Object          ---
                //--- The Utility Cost to be deleted is identified by the provided utilityCostId (PK) ---
                //---------------------------------------------------------------------------------------
                UtilityCostRepoObj.DeleteUtilityCost(utilityCostId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting utility cost: {ex.Message}");
            }
        }
        #endregion  // DeleteUtilityCost(Guid utilityCostId) ... DELETE

        #endregion  // UTILITY COST CRUD METHODS

    }
    #endregion      // public class UtilityCostViewModel
}
#endregion      // namespace HenViewModel.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
