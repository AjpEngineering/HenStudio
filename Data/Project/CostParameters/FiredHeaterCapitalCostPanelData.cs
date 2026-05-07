#region HEADER
//#####################################################################################################################
//######################  F i r e d H e a t e r C a p i t a l C o s t P a n e l D a t a . c s  ########################
//#####################################################################################################################
//  FILENAME:  FiredHeaterCapitalCostPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.CostParameters
//  CLASS(S):  FiredHeaterCapitalCostPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Fired Heater Capital Cost Panel Data object -
//    data needed for Fired Heater Capital Cost Panel.
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
    #region public class FiredHeaterCapitalCostPanelData
    public class FiredHeaterCapitalCostPanelData : IFiredHeaterCapitalCostPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.CostParameters";
        const string CLASS = "FiredHeaterCapitalCostPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public FiredHeaterCapitalCostDto FiredHeaterCapitalCostDtoObj { get; set; }
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public double ParameterAlpha_Metric { get; set; }
        public double ParameterAlpha_English { get; set; }
        public double ParameterBeta { get; set; }
        public double Efficiency { get; set; }
        public string DutyUnits_Metric { get; set; }
        public string DutyUnits_English { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for FiredHeaterCapitalCostPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public FiredHeaterCapitalCostPanelData()
        {
            FiredHeaterCapitalCostDtoObj = new FiredHeaterCapitalCostDto();
            Id = new Guid();
            ProjectId = new Guid();
            ParameterAlpha_Metric = 0.0;
            ParameterAlpha_English = 0.0;
            ParameterBeta = 0.0;
            Efficiency = 0.0;
            DutyUnits_Metric = string.Empty;
            DutyUnits_English = string.Empty;
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

        #region GetParameterAlpha_Metric()
        /// <summary>
        /// Gets the Capital Cost Alpha Parameter (metric Units) value as a string.
        /// </summary>
        /// <returns>A string representation of the Capital Cost Alpha Parameter (metric Units) value.</returns>
        public string GetParameterAlpha_Metric()
        {
            return ParameterAlpha_Metric.ToString();
        }
        #endregion  // GetParameterAlpha_Metric()

        #region GetParameterAlpha_English()
        /// <summary>
        /// Gets the Capital Cost Alpha Parameter value (english Units)  as a string.
        /// </summary>
        /// <returns>A string representation of the Capital Cost Alpha Parameter value (english Units).</returns>
        public string GetParameterAlpha_English()
        {
            return ParameterAlpha_English.ToString();
        }
        #endregion  // GetParameterAlpha_English()

        #region GetParameterBeta()
        /// <summary>
        /// Gets the Capital Cost Beta Parameter value as a string.
        /// </summary>
        /// <returns>A string representation of the Capital Cost Beta Parameter value.</returns>
        public string GetParameterBeta()
        {
            return ParameterBeta.ToString();
        }
        #endregion  // GetParameterBeta()

        #region GetEfficiency()
        /// <summary>
        /// Gets the Capital Cost Efficiency value as a string.
        /// </summary>
        /// <returns>A string representation of the Capital Cost Efficiency value.</returns>
        public string GetEfficiency()
        {
            return Efficiency.ToString();
        }
        #endregion  // GetEfficiency()

        #endregion  // STRING CONVERSION METHODS

        #region IMPLEMENTATION of IFiredHeaterCapitalCostPanelData METHODS

        #region ConvertToPanelData(CostMetadataDto costMetadataDto)
        /// <summary>
        /// Creates a new CostMetadataPanelData instance by copying values from the specified CostMetadataDto object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from CostMetadataDto to
        /// CostMetadataPanelData. All relevant fields are transferred directly. If costMetadataDto is null,
        /// a NullReferenceException may occur.</remarks>
        /// <param name="firedDto">The FiredHeaterCapitalCostDto object containing the source values to copy. Cannot be null.</param>
        /// <returns>A FiredHeaterCapitalCostPanelData instance populated with values from the provided FiredHeaterCapitalCostDto object.</returns>
        public FiredHeaterCapitalCostPanelData ConvertToPanelData(FiredHeaterCapitalCostDto firedHeaterCapitalCostDto)
        {
            FiredHeaterCapitalCostDtoObj = firedHeaterCapitalCostDto;
            this.Id = firedHeaterCapitalCostDto.Id;
            this.ProjectId = firedHeaterCapitalCostDto.ProjectId;
            this.ParameterAlpha_Metric = firedHeaterCapitalCostDto.ParameterAlpha_Metric;
            this.ParameterAlpha_English = firedHeaterCapitalCostDto.ParameterAlpha_English;
            this.ParameterBeta = firedHeaterCapitalCostDto.ParameterBeta;
            this.Efficiency = firedHeaterCapitalCostDto.Efficiency;
            this.DutyUnits_Metric = firedHeaterCapitalCostDto.DutyUnits_Metric;
            this.DutyUnits_English = firedHeaterCapitalCostDto.DutyUnits_English;
            return this;
        }
        #endregion  // ConvertToPanelData(FiredHeaterCapitalCostDto firedHeaterCapitalCostDto)

        #region ConvertFromPanelData()
        /// <summary>
        /// Creates a new FiredHeaterCapitalCostDto instance by copying values from the current FiredHeaterCapitalCostPanelData object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from FiredHeaterCapitalCostPanelData to
        /// FiredHeaterCapitalCostDto. All relevant fields are transferred directly.</remarks>
        /// <returns>A FiredHeaterCapitalCostDto instance populated with values from the current FiredHeaterCapitalCostPanelData object.</returns>
        public FiredHeaterCapitalCostDto ConvertFromPanelData()
        {
            FiredHeaterCapitalCostDtoObj = new FiredHeaterCapitalCostDto();
            FiredHeaterCapitalCostDtoObj.Id = this.Id;
            FiredHeaterCapitalCostDtoObj.ProjectId = this.ProjectId;
            FiredHeaterCapitalCostDtoObj.ParameterAlpha_Metric = this.ParameterAlpha_Metric;
            FiredHeaterCapitalCostDtoObj.ParameterAlpha_English = this.ParameterAlpha_English;
            FiredHeaterCapitalCostDtoObj.ParameterBeta = this.ParameterBeta;
            FiredHeaterCapitalCostDtoObj.Efficiency = this.Efficiency;
            FiredHeaterCapitalCostDtoObj.DutyUnits_Metric = this.DutyUnits_Metric;
            FiredHeaterCapitalCostDtoObj.DutyUnits_English = this.DutyUnits_English;
            return FiredHeaterCapitalCostDtoObj;
        }
        #endregion  // ConvertFromPanelData()   

        #endregion  // IMPLEMENTATION of IFiredHeaterCapitalCostPanelData
    }
    #endregion      // public class FiredHeaterCapitalCostPanelData
}
#endregion  // namespace HenStudio.Data.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
