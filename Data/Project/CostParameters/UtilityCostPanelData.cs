#region HEADER
//#####################################################################################################################
//#################################  U t i l i t y C o s t P a n e l D a t a . c s  ###################################
//#####################################################################################################################
//  FILENAME:  UtilityCostPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.CostParameters
//  CLASS(S):  UtilityCostPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Utility Cost Panel Data object - data needed for Utility Cost Panel.
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
//    01/01/26 .. pg .. Version 4.0
//#####################################################################################################################
//#####################################################################################################################
//#####################################################################################################################
#endregion      // HEADER

#region REFERENCES
using HenModel.Dto.Project.CostParameters;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Project.CostParameters
namespace HenStudio.Data.Project.CostParameters
{
    #region public class UtilityCostPanelData
    public class UtilityCostPanelData : IUtilityCostPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.CostParameters";
        const string CLASS = "UtilityCostPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public UtilityCostDto UtilityCostDtoObj { get; set; }
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public double HP_SteamCost_Metric { get; set; }
        public double MP_SteamCost_Metric { get; set; }
        public double LP_SteamCost_Metric { get; set; }
        public double CoolingWaterCost_Metric { get; set; }
        public double ChilledWaterCost_Metric { get; set; }
        public double FuelGasCost_Metric { get; set; }
        public double HP_SteamCost_English { get; set; }
        public double MP_SteamCost_English { get; set; }
        public double LP_SteamCost_English { get; set; }
        public double CoolingWaterCost_English { get; set; }
        public double ChilledWaterCost_English { get; set; }
        public double FuelGasCost_English { get; set; }
        public string DutyUnits_Metric { get; set; }
        public string DutyUnits_English { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for UtilityCostPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public UtilityCostPanelData()
        {
            UtilityCostDtoObj = new UtilityCostDto();
            Id = new Guid();
            ProjectId = new Guid();
            HP_SteamCost_Metric = 40.94;
            MP_SteamCost_Metric = 34.12;
            LP_SteamCost_Metric = 27.30;
            CoolingWaterCost_Metric = 0.34;
            ChilledWaterCost_Metric = 68.24;
            FuelGasCost_Metric = 20.47;
            HP_SteamCost_English = 12.00;
            MP_SteamCost_English = 10.00;
            LP_SteamCost_English = 8.00;
            CoolingWaterCost_English = 0.10;
            ChilledWaterCost_English = 20.00;
            FuelGasCost_English = 6.00;
            DutyUnits_Metric = "$/MWh";
            DutyUnits_English = "$/MMBtu";
        }
        #endregion  // CTOR

        #region STRING CONVERSION METHODS

        #region GetId()
        /// <summary>
        /// Gets the unique identifier of the project units as a string.
        /// </summary>
        /// <returns>A string representation of the project units' unique identifier.</returns>
        public string GetId()
        {
            return Id.ToString();
        }
        #endregion  // GetId()

        #region GetProjectId()
        /// <summary>
        /// Gets the unique identifier of the project as a string.
        /// </summary>
        /// <returns>A string representation of the project's unique identifier.</returns>
        public string GetProjectId()
        {
            return ProjectId.ToString();
        }
        #endregion  // GetProjectId()

        #region GetHP_SteamCost_Metric()
        /// <summary>
        /// Gets the HP steam cost in metric units as a string.
        /// </summary>
        /// <returns>A string representation of the HP steam cost in metric units.</returns>
        public string GetHP_SteamCost_Metric()
        {
            return HP_SteamCost_Metric.ToString();
        }
        #endregion  // GetHP_SteamCost_Metric()

        #region GetMP_SteamCost_Metric()
        /// <summary>
        /// Gets the MP steam cost in metric units as a string.
        /// </summary>
        /// <returns>A string representation of the MP steam cost in metric units.</returns>
        public string GetMP_SteamCost_Metric()
        {
            return MP_SteamCost_Metric.ToString();
        }
        #endregion  // GetMP_SteamCost_Metric()

        #region GetLP_SteamCost_Metric()
        /// <summary>
        /// Gets the LP steam cost in metric units as a string.
        /// </summary>
        /// <returns>A string representation of the LP steam cost in metric units.</returns>
        public string GetLP_SteamCost_Metric()
        {
            return LP_SteamCost_Metric.ToString();
        }
        #endregion  // GetLP_SteamCost_Metric()

        #region GetCoolingWaterCost_Metric()
        /// <summary>
        /// Gets the cooling water cost in metric units as a string.
        /// </summary>
        /// <returns>A string representation of the cooling water cost in metric units.</returns>
        public string GetCoolingWaterCost_Metric()
        {
            return CoolingWaterCost_Metric.ToString();
        }
        #endregion  // GetCoolingWaterCost_Metric()

        #region GetChilledWaterCost_Metric()
        /// <summary>
        /// Gets the chilled water cost in metric units as a string.
        /// </summary>
        /// <returns>A string representation of the chilled water cost in metric units.</returns>
        public string GetChilledWaterCost_Metric()
        {
            return ChilledWaterCost_Metric.ToString();
        }
        #endregion  // GetChilledWaterCost_Metric()

        #region GetFuelGasCost_Metric()
        /// <summary>
        /// Gets the fuel gas cost in metric units as a string.
        /// </summary>
        /// <returns>A string representation of the fuel gas cost in metric units.</returns>
        public string GetFuelGasCost_Metric()
        {
            return FuelGasCost_Metric.ToString();
        }
        #endregion  // GetFuelGasCost_Metric()

        #region GetHP_SteamCost_English()
        /// <summary>
        /// Gets the HP steam cost in English units as a string.
        /// </summary>
        /// <returns>A string representation of the HP steam cost in English units.</returns>
        public string GetHP_SteamCost_English()
        {
            return HP_SteamCost_English.ToString();
        }
        #endregion  // GetHP_SteamCost_English()

        #region GetMP_SteamCost_English()
        /// <summary>
        /// Gets the MP steam cost in English units as a string.
        /// </summary>
        /// <returns>A string representation of the MP steam cost in English units.</returns>
        public string GetMP_SteamCost_English()
        {
            return MP_SteamCost_English.ToString();
        }
        #endregion  // GetMP_SteamCost_English()
        
        #region GetLP_SteamCost_English()
        /// <summary>
        /// Gets the LP steam cost in English units as a string.
        /// </summary>
        /// <returns>A string representation of the LP steam cost in English units.</returns>
        public string GetLP_SteamCost_English()
        {
            return LP_SteamCost_English.ToString();
        }
        #endregion  // GetLP_SteamCost_English()

        #region GetCoolingWaterCost_English()
        /// <summary>
        /// Gets the cooling water cost in English units as a string.
        /// </summary>
        /// <returns>A string representation of the cooling water cost in English units.</returns>
        public string GetCoolingWaterCost_English()
        {
            return CoolingWaterCost_English.ToString();
        }
        #endregion  // GetCoolingWaterCost_English()
        
        #region GetChilledWaterCost_English()
        /// <summary>
        /// Gets the chilled water cost in English units as a string.
        /// </summary>
        /// <returns>A string representation of the chilled water cost in English units.</returns>
        public string GetChilledWaterCost_English()
        {
            return ChilledWaterCost_English.ToString();
        }
        #endregion  // GetChilledWaterCost_English()

        #region GetFuelGasCost_English()
        /// <summary>
        /// Gets the fuel gas cost in English units as a string.
        /// </summary>
        /// <returns>A string representation of the fuel gas cost in English units.</returns>
        public string GetFuelGasCost_English()
        {
            return FuelGasCost_English.ToString();
        }
        #endregion  // GetFuelGasCost_English()

        #endregion  // STRING CONVERSION METHODS

        #region IMPLEMENTATION of IUtilityCostPanelData METHODS

        #region ConvertToPanelData(UtilityCostDto utilityCostDto)
        /// <summary>
        /// Creates a new UtilityCostPanelData instance by copying values from the specified UtilityCostDto object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from UtilityCostDto to
        /// UtilityCostPanelData. All relevant fields are transferred directly. If utilityCostDto is null,
        /// a NullReferenceException may occur.</remarks>
        /// <param name="utilityCostDto">The UtilityCostDto object containing the source values to copy. Cannot be null.</param>
        /// <returns>A UtilityCostPanelData instance populated with values from the provided UtilityCostDto object.</returns>
        public UtilityCostPanelData ConvertToPanelData(UtilityCostDto utilityCostDto)
        {
            UtilityCostDtoObj = utilityCostDto;
            this.Id = utilityCostDto.Id;
            this.ProjectId = utilityCostDto.ProjectId;
            this.HP_SteamCost_Metric = utilityCostDto.HP_SteamCost_Metric;
            this.MP_SteamCost_Metric = utilityCostDto.MP_SteamCost_Metric;
            this.LP_SteamCost_Metric = utilityCostDto.LP_SteamCost_Metric;
            this.CoolingWaterCost_Metric = utilityCostDto.CoolingWaterCost_Metric;
            this.ChilledWaterCost_Metric = utilityCostDto.ChilledWaterCost_Metric;
            this.FuelGasCost_Metric = utilityCostDto.FuelGasCost_Metric;
            this.HP_SteamCost_English = utilityCostDto.HP_SteamCost_English;
            this.MP_SteamCost_English = utilityCostDto.MP_SteamCost_English;
            this.LP_SteamCost_English = utilityCostDto.LP_SteamCost_English;
            this.CoolingWaterCost_English = utilityCostDto.CoolingWaterCost_English;
            this.ChilledWaterCost_English = utilityCostDto.ChilledWaterCost_English;
            this.FuelGasCost_English = utilityCostDto.FuelGasCost_English;
            this.DutyUnits_Metric = utilityCostDto.DutyUnits_Metric;
            this.DutyUnits_English = utilityCostDto.DutyUnits_English;
            return this;
        }
        #endregion  // ConvertToPanelData(UtilityCostDto utilityCostDto)

        #region ConvertFromPanelData()
        /// <summary>
        /// Creates a new CostMetadataDto instance by copying values from the current CostMetadataPanelData object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from CostMetadataPanelData to
        /// CostMetadataDto. All relevant fields are transferred directly.</remarks>
        /// <returns>A UtilityCostDto instance populated with values from the current UtilityCostPanelData object.</returns>
        public UtilityCostDto ConvertFromPanelData()
        {
            UtilityCostDtoObj = new UtilityCostDto();
            UtilityCostDtoObj.Id = this.Id;
            UtilityCostDtoObj.ProjectId = this.ProjectId;
            UtilityCostDtoObj.HP_SteamCost_Metric = this.HP_SteamCost_Metric;
            UtilityCostDtoObj.MP_SteamCost_Metric = this.MP_SteamCost_Metric;
            UtilityCostDtoObj.LP_SteamCost_Metric = this.LP_SteamCost_Metric;
            UtilityCostDtoObj.CoolingWaterCost_Metric = this.CoolingWaterCost_Metric;
            UtilityCostDtoObj.ChilledWaterCost_Metric = this.ChilledWaterCost_Metric;
            UtilityCostDtoObj.FuelGasCost_Metric = this.FuelGasCost_Metric;
            UtilityCostDtoObj.HP_SteamCost_English = this.HP_SteamCost_English;
            UtilityCostDtoObj.MP_SteamCost_English = this.MP_SteamCost_English;
            UtilityCostDtoObj.LP_SteamCost_English = this.LP_SteamCost_English;
            UtilityCostDtoObj.CoolingWaterCost_English = this.CoolingWaterCost_English;
            UtilityCostDtoObj.ChilledWaterCost_English = this.ChilledWaterCost_English;
            UtilityCostDtoObj.FuelGasCost_English = this.FuelGasCost_English;
            UtilityCostDtoObj.DutyUnits_Metric = this.DutyUnits_Metric;
            UtilityCostDtoObj.DutyUnits_English = this.DutyUnits_English;
            return UtilityCostDtoObj;
        }
        #endregion  // ConvertFromPanelData()   

        #endregion  // IMPLEMENTATION of IUtilityCostPanelData METHODS
    }
    #endregion      // public class UtilityCostPanelData
}
#endregion  // namespace HenStudio.Data.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
