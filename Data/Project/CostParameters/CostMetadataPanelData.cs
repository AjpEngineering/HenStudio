#region HEADER
//#####################################################################################################################
//################################  P r o j e c t U n i t s P a n e l D a t a . c s  ##################################
//#####################################################################################################################
//  FILENAME:  ProjectUnitsPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.CostParameters
//  CLASS(S):  ProjectUnitsPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Project Units Panel Data object - data needed for Project Units Panel.
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
    #region public class CostMetadataPanelData
    public class CostMetadataPanelData : ICostMetadataPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.CostParameters";
        const string CLASS = "CostMetadataPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public CostMetadataDto CostMetadataDtoObj { get; set; }
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public string CostIndexBaseYear { get; set; }
        public string CostIndexName { get; set; }
        public double CostIndexValue { get; set; }
        public string CostIndexCurrency { get; set; }
        public double CostIndexInstalledCost { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for CostMetadataPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public CostMetadataPanelData()
        {
            CostMetadataDtoObj = new CostMetadataDto();
            Id = new Guid();
            ProjectId = new Guid();
            CostIndexBaseYear = string.Empty;
            CostIndexName = string.Empty;
            CostIndexValue = 0.0;
            CostIndexCurrency = string.Empty;
            CostIndexInstalledCost = 0.0;
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

        #region GetCostIndexValue()
        /// <summary>
        /// Gets the cost index value as a string.
        /// </summary>
        /// <returns>A string representation of the cost index value.</returns>
        public string GetCostIndexValue()
        {
            return CostIndexValue.ToString();
        }
        #endregion  // GetCostIndexValue()

        #region GetCostIndexInstalledCost()
        /// <summary>
        /// Gets the cost index installed cost as a string.
        /// </summary>
        /// <returns>A string representation of the cost index installed cost.</returns>
        public string GetCostIndexInstalledCost()
        {
            return CostIndexInstalledCost.ToString();
        }
        #endregion  // GetCostIndexInstalledCost()

        #endregion  // STRING CONVERSION METHODS

        #region IMPLEMENTATION of ICostMetadataPanelData METHODS

        #region ConvertToPanelData(CostMetadataDto costMetadataDto)
        /// <summary>
        /// Creates a new CostMetadataPanelData instance by copying values from the specified CostMetadataDto object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from CostMetadataDto to
        /// CostMetadataPanelData. All relevant fields are transferred directly. If costMetadataDto is null,
        /// a NullReferenceException may occur.</remarks>
        /// <param name="costMetadataDto">The CostMetadataDto object containing the source values to copy. Cannot be null.</param>
        /// <returns>A CostMetadataPanelData instance populated with values from the provided CostMetadataDto object.</returns>
        public CostMetadataPanelData ConvertToPanelData(CostMetadataDto costMetadataDto)
        {
            CostMetadataDtoObj = costMetadataDto;
            this.Id = costMetadataDto.Id;
            this.ProjectId = costMetadataDto.ProjectId;
            this.CostIndexBaseYear = costMetadataDto.CostIndexBaseYear;
            this.CostIndexName = costMetadataDto.CostIndexName;
            this.CostIndexValue = costMetadataDto.CostIndexValue;
            this.CostIndexCurrency = costMetadataDto.CostIndexCurrency;
            this.CostIndexInstalledCost = costMetadataDto.CostIndexInstalledCost;
            return this;
        }
        #endregion  // ConvertToPanelData(CostMetadataDto costMetadataDto)

        #region ConvertFromPanelData()
        /// <summary>
        /// Creates a new CostMetadataDto instance by copying values from the current CostMetadataPanelData object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from CostMetadataPanelData to
        /// CostMetadataDto. All relevant fields are transferred directly.</remarks>
        /// <returns>A CostMetadataDto instance populated with values from the current CostMetadataPanelData object.</returns>
        public CostMetadataDto ConvertFromPanelData()
        {
            CostMetadataDtoObj = new CostMetadataDto();
            CostMetadataDtoObj.Id = this.Id;
            CostMetadataDtoObj.ProjectId = this.ProjectId;
            CostMetadataDtoObj.CostIndexBaseYear = this.CostIndexBaseYear;
            CostMetadataDtoObj.CostIndexName = this.CostIndexName;
            CostMetadataDtoObj.CostIndexValue = this.CostIndexValue;
            CostMetadataDtoObj.CostIndexCurrency = this.CostIndexCurrency;
            CostMetadataDtoObj.CostIndexInstalledCost = this.CostIndexInstalledCost;
            return CostMetadataDtoObj;
        }
        #endregion  // ConvertFromPanelData()   

        #endregion  // IMPLEMENTATION of ICostMetadataPanelData
    }
    #endregion      // public class CostMetadataPanelData
}
#endregion  // namespace HenStudio.Data.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
