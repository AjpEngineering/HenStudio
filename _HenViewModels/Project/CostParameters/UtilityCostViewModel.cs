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
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;
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

        #region PRIVATE DTO CONVERSION METHODS

        #region ConvertToExternalDto(UtilityCostDto internalDto)
        /// <summary>
        /// Converts a Utility Cost DTO from INTERNAL units to EXTERNAL units.
        /// </summary>
        /// <param name="internalDto">The Utility Cost DTO in INTERNAL units.</param>
        /// <returns>A <see cref="UtilityCostDto"/> DTO in EXTERNAL units.</returns>
        private UtilityCostDto ConvertToExternalDto(UtilityCostDto internalDto)
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
            UtilityCostDto externalDto = new UtilityCostDto();
            //---------------------------------------------------------
            //--- Convert INTERNAL DTO Fields to EXTERNAL DTO Units ---
            //---------------------------------------------------------
            externalDto.Id = internalDto.Id;
            externalDto.ProjectId = internalDto.ProjectId;

            externalDto.HP_SteamCost_Metric     = internalDto.HP_SteamCost_Metric;
            externalDto.MP_SteamCost_Metric     = internalDto.MP_SteamCost_Metric;
            externalDto.LP_SteamCost_Metric     = internalDto.LP_SteamCost_Metric;
            externalDto.CoolingWaterCost_Metric = internalDto.CoolingWaterCost_Metric;
            externalDto.ChilledWaterCost_Metric = internalDto.ChilledWaterCost_Metric;
            externalDto.FuelGasCost_Metric      = internalDto.FuelGasCost_Metric;

            externalDto.HP_SteamCost_English     = internalDto.HP_SteamCost_English;
            externalDto.MP_SteamCost_English     = internalDto.MP_SteamCost_English;
            externalDto.LP_SteamCost_English     = internalDto.LP_SteamCost_English;
            externalDto.CoolingWaterCost_English = internalDto.CoolingWaterCost_English;
            externalDto.ChilledWaterCost_English = internalDto.ChilledWaterCost_English;
            externalDto.FuelGasCost_English      = internalDto.FuelGasCost_English;
            //--------------------------------------------------
            //--- Return the EXTERNAL DTO in EXTERNAL units. ---
            //--------------------------------------------------
            return externalDto;
        }
        #endregion  // ConvertToExternalDto(UtilityCostDto internalDto)

        #region ConvertToInternalDto(UtilityCostDto externalDto)
        /// <summary>
        /// Converts a Utility Cost Params DTO from EXTERNAL units to INTERNAL units.
        /// </summary>
        /// <param name="externalDto">The Utility Cost Params DTO in EXTERNAL units.</param>
        /// <returns>A <see cref="UtilityCostDto"/> DTO in INTERNAL units.</returns>
        private UtilityCostDto ConvertToInternalDto(UtilityCostDto externalDto)
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
            UtilityCostDto internalDto = new UtilityCostDto();
            //-------------------------------------------------
            //--- Convert EXTERNAL Fields to INTERNAL Units ---
            //-------------------------------------------------
            internalDto.Id = externalDto.Id;
            internalDto.ProjectId = externalDto.ProjectId;

            internalDto.HP_SteamCost_Metric     = externalDto.HP_SteamCost_Metric;
            internalDto.MP_SteamCost_Metric     = externalDto.MP_SteamCost_Metric;
            internalDto.LP_SteamCost_Metric     = externalDto.LP_SteamCost_Metric;
            internalDto.CoolingWaterCost_Metric = externalDto.CoolingWaterCost_Metric;
            internalDto.ChilledWaterCost_Metric = externalDto.ChilledWaterCost_Metric;
            internalDto.FuelGasCost_Metric      = externalDto.FuelGasCost_Metric;

            internalDto.HP_SteamCost_English     = externalDto.HP_SteamCost_English;
            internalDto.MP_SteamCost_English     = externalDto.MP_SteamCost_English;
            internalDto.LP_SteamCost_English     = externalDto.LP_SteamCost_English;
            internalDto.CoolingWaterCost_English = externalDto.CoolingWaterCost_English;
            internalDto.ChilledWaterCost_English = externalDto.ChilledWaterCost_English;
            internalDto.FuelGasCost_English      = externalDto.FuelGasCost_English;
            //--------------------------------------------------
            //--- Return the INTERNAL DTO in INTERNAL units. ---
            //--------------------------------------------------
            return internalDto;
        }
        #endregion  // ConvertToInternalDto(UtilityCostDto externalDto)

        #endregion  // PRIVATE DTO CONVERSION METHODS

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
                internalUtilityCostDto = ConvertToInternalDto(externalUtilityCostDto);
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
            //------------------------------------------------------------------------------------
            //--- Return the UtilityCost ID (PK) from the Database addition of the provided    ---
            //--- UtilityCost Dto.                                                             ---
            //--- This ID can be used for reference in subsequent operations (e.g., retrieval, ---
            //--- update, deletion) on the added UtilityCost.                                  ---
            //--- If the addition fails, the returned GUID will be empty (all zeros), which    ---
            //--- can be used to indicate that the operation was unsuccessful.                 ---
            //------------------------------------------------------------------------------------
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
                //---------------------- Guard against empty or null projectId ------------------------
                //--- If the provided projectId is empty, return null to indicate that there is no  ---
                //--- valid UtilityCost to retrieve.                                                ---
                //--- This prevents unnecessary database calls and potential errors when trying to  ---
                //--- retrieve a UtilityCost with an invalid identifier.                            ---
                //--- An empty projectId is not valid for retrieval, so we return null to indicate  ---
                //---that the UtilityCost cannot be found.                                          ---
                //-------------------------------------------------------------------------------------
                if (projectId == Guid.Empty)
                {
                    return null; // Return null if the projectId is empty
                }
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
                externalUtilityCostDto = ConvertToExternalDto(internalUtilityCostDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving utility cost: {ex.Message}");
                return null;
            }
            //-------------------------------------------------------------------
            //--- Return the UtilityCost Dto in EXTERNAL Units to the caller. ---
            //--- If the retrieval or conversion fails, the returned DTO will ---
            //--- be null, which can be used to indicate that the operation   ---
            //--- was unsuccessful.                                           ---
            //-------------------------------------------------------------------
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
                internalUtilityCostDto = ConvertToInternalDto(externalUtilityCostDto);
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
