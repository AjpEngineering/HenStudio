#region HEADER
//#####################################################################################################################
//#########################  T o t a l A n n u a l i z e d C o s t P a n e l D a t a . c s  ###########################
//#####################################################################################################################
//  FILENAME:  TotalAnnualizedCostPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.CostParameters
//  CLASS(S):  TotalAnnualizedCostPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Total Annualized Cost Panel Data object -
//    data needed for Total Annualized Cost Panel.
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
    #region public class TotalAnnualizedCostPanelData
    public class TotalAnnualizedCostPanelData : ITotalAnnualizedCostPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.CostParameters";
        const string CLASS = "TotalAnnualizedCostPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public TotalAnnualizedCostDto TotalAnnualizedCostDtoObj { get; set; }
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public double TAC_InterestRate { get; set; }
        public double TAC_LifeYears { get; set; }
        public double TAC_MaintenanceFraction { get; set; }
        public double TAC_OperatingHours { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for FiredHeaterCapitalCostPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public TotalAnnualizedCostPanelData()
        {
            TotalAnnualizedCostDtoObj = new TotalAnnualizedCostDto();
            Id = new Guid();
            ProjectId = new Guid();
            TAC_InterestRate = 0.10;
            TAC_LifeYears = 10.0;
            TAC_MaintenanceFraction = 0.03;     // 3% of Installed Cost/yr
            TAC_OperatingHours = 8000.0;
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

        #region GetTAC_InterestRate()
        /// <summary>
        /// Gets the Total Annualized Cost Interest Rate value as a string.
        /// </summary>
        /// <returns>A string representation of the Total Annualized Cost Interest Rate value.</returns>
        public string GetTAC_InterestRate()
        {
            return TAC_InterestRate.ToString();
        }
        #endregion  // GetTAC_InterestRate()

        #region GetTAC_LifeYears()
        /// <summary>
        /// Gets the Total Annualized Cost Life Years value as a string.
        /// </summary>
        /// <returns>A string representation of the Total Annualized Cost Life Years value.</returns>
        public string GetTAC_LifeYears()
        {
            return TAC_LifeYears.ToString();
        }
        #endregion  // GetTAC_LifeYears()

        #region GetTAC_MaintenanceFraction()
        /// <summary>
        /// Gets the Total Annualized Cost Maintenance Fraction value as a string.
        /// </summary>
        /// <returns>A string representation of the Total Annualized Cost Maintenance Fraction value.</returns>
        public string GetTAC_MaintenanceFraction()
        {
            return TAC_MaintenanceFraction.ToString();
        }
        #endregion  // GetTAC_MaintenanceFraction()

        #region GetTAC_OperatingHours()
        /// <summary>
        /// Gets the Total Annualized Cost Operating Hours value as a string.
        /// </summary>
        /// <returns>A string representation of the Total Annualized Cost Operating Hours value.</returns>
        public string GetTAC_OperatingHours()
        {
            return TAC_OperatingHours.ToString();
        }
        #endregion  // GetTAC_OperatingHours()

        #endregion  // STRING CONVERSION METHODS

        #region IMPLEMENTATION of ITotalAnnualizedCostPanelData METHODS

        #region ConvertToPanelData(TotalAnnualizedCostDto totalAnnualizedCostDto)
        /// <summary>
        /// Creates a new TotalAnnualizedCostPanelData instance by copying values from the specified TotalAnnualizedCostDto object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from TotalAnnualizedCostDto to
        /// TotalAnnualizedCostPanelData. All relevant fields are transferred directly. If totalAnnualizedCostDto is null,
        /// a NullReferenceException may occur.</remarks>
        /// <param name="totalAnnualizedCostDto">The TotalAnnualizedCostDto object containing the source values to copy. Cannot be null.</param>
        /// <returns>A TotalAnnualizedCostPanelData instance populated with values from the provided TotalAnnualizedCostDto object.</returns>
        public TotalAnnualizedCostPanelData ConvertToPanelData(TotalAnnualizedCostDto totalAnnualizedCostDto)
        {
            TotalAnnualizedCostDtoObj = totalAnnualizedCostDto;
            this.Id = totalAnnualizedCostDto.Id;
            this.ProjectId = totalAnnualizedCostDto.ProjectId;
            this.TAC_InterestRate = totalAnnualizedCostDto.TAC_InterestRate;
            this.TAC_LifeYears = totalAnnualizedCostDto.TAC_LifeYears;
            this.TAC_MaintenanceFraction = totalAnnualizedCostDto.TAC_MaintenanceFraction;
            this.TAC_OperatingHours = totalAnnualizedCostDto.TAC_OperatingHours;
            return this;
        }
        #endregion  // ConvertToPanelData(TotalAnnualizedCostDto totalAnnualizedCostDto)

        #region ConvertFromPanelData()
        /// <summary>
        /// Creates a new TotalAnnualizedCostDto instance by copying values from the current TotalAnnualizedCostPanelData object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from TotalAnnualizedCostPanelData to
        /// TotalAnnualizedCostDto. All relevant fields are transferred directly.</remarks>
        /// <returns>A TotalAnnualizedCostDto instance populated with values from the current TotalAnnualizedCostPanelData object.</returns>
        public TotalAnnualizedCostDto ConvertFromPanelData()
        {
            TotalAnnualizedCostDtoObj = new TotalAnnualizedCostDto();
            TotalAnnualizedCostDtoObj.Id = this.Id;
            TotalAnnualizedCostDtoObj.ProjectId = this.ProjectId;
            TotalAnnualizedCostDtoObj.TAC_InterestRate = this.TAC_InterestRate;
            TotalAnnualizedCostDtoObj.TAC_LifeYears = this.TAC_LifeYears;
            TotalAnnualizedCostDtoObj.TAC_MaintenanceFraction = this.TAC_MaintenanceFraction;
            TotalAnnualizedCostDtoObj.TAC_OperatingHours = this.TAC_OperatingHours;
            return TotalAnnualizedCostDtoObj;
        }
        #endregion  // ConvertFromPanelData()   

        #endregion  // IMPLEMENTATION of ITotalAnnualizedCostPanelData METHODS
    }
    #endregion      // public class TotalAnnualizedCostPanelData
}
#endregion  // namespace HenStudio.Data.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
