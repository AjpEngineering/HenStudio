#region HEADER
//#####################################################################################################################
//#####################  S h e l l A n d T u b e C a p i t a l C o s t P a n e l D a t a . c s  #######################
//#####################################################################################################################
//  FILENAME:  ShellAndTubeCapitalCostPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.CostParameters
//  CLASS(S):  ShellAndTubeCapitalCostPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Shell and Tube Capital Cost Panel Data object -
//    data needed for Shell and Tube Capital Cost Panel.
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
    #region public class ShellAndTubeCapitalCostPanelData
    public class ShellAndTubeCapitalCostPanelData : IShellAndTubeCapitalCostPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.CostParameters";
        const string CLASS = "ShellAndTubeCapitalCostPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public ShellAndTubeCapitalCostDto ShellAndTubeCapitalCostDtoObj { get; set; }
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public double ParameterA { get; set; }
        public double ParameterB_Metric { get; set; }
        public double ParameterB_English { get; set; }
        public double ParameterN { get; set; }
        public double MaterialFactor { get; set; }
        public string AreaUnits_Metric { get; set; }
        public string AreaUnits_English { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for ShellAndTubeCapitalCostPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public ShellAndTubeCapitalCostPanelData()
        {
            ShellAndTubeCapitalCostDtoObj = new ShellAndTubeCapitalCostDto();
            Id = new Guid();
            ProjectId = new Guid();
            ParameterA = 0.0;
            ParameterB_Metric = 10000.0;
            ParameterB_English = 170.729;
            ParameterN = 0.65;
            MaterialFactor = 1.0;
            AreaUnits_Metric = "m2";
            AreaUnits_English = "Ft2";
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

        #region GetParameterA()
        /// <summary>
        /// Gets the Capital Cost A Parameter value as a string.
        /// </summary>
        /// <returns>A string representation of the Capital Cost A Parameter value.</returns>
        public string GetParameterA()
        {
            return ParameterA.ToString();
        }
        #endregion  // GetParameterA()

        #region GetParameterB_Metric()
        /// <summary>
        /// Gets the Capital Cost B Parameter value (metric Units)  as a string.
        /// </summary>
        /// <returns>A string representation of the Capital Cost B Parameter value (metric Units).</returns>
        public string GetParameterB_Metric()
        {
            return ParameterB_Metric.ToString();
        }
        #endregion  // GetParameterB_Metric()

        #region GetParameterB_English()
        /// <summary>
        /// Gets the Capital Cost B Parameter value (english Units)  as a string.
        /// </summary>
        /// <returns>A string representation of the Capital Cost B Parameter value (english Units).</returns>
        public string GetParameterB_English()
        {
            return ParameterB_English.ToString();
        }
        #endregion  // GetParameterB_English()

        #region GetParameterN()
        /// <summary>
        /// Gets the Capital Cost N Parameter value as a string.
        /// </summary>
        /// <returns>A string representation of the Capital Cost N Parameter value.</returns>
        public string GetParameterN()
        {
            return ParameterN.ToString();
        }
        #endregion  // GetParameterN()

        #region GetMaterialFactor()
        /// <summary>
        /// Gets the Capital Cost Material Factor value as a string.
        /// </summary>
        /// <returns>A string representation of the Capital Cost Material Factor value.</returns>
        public string GetMaterialFactor()
        {
            return MaterialFactor.ToString();
        }
        #endregion  // GetMaterialFactor()

        #endregion  // STRING CONVERSION METHODS

        #region IMPLEMENTATION of IShellAndTubeCapitalCostPanelData METHODS

        #region ConvertToPanelData(ShellAndTubeCapitalCostDto shellAndTubeCapitalCostDto)
        /// <summary>
        /// Creates a new ShellAndTubeCapitalCostPanelData instance by copying values from the specified ShellAndTubeCapitalCostDto object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from ShellAndTubeCapitalCostDto to
        /// ShellAndTubeCapitalCostPanelData. All relevant fields are transferred directly. If shellAndTubeCapitalCostDto is null,
        /// a NullReferenceException may occur.</remarks>
        /// <param name="shellAndTubeCapitalCostDto">The ShellAndTubeCapitalCostDto object containing the source values to copy. Cannot be null.</param>
        /// <returns>A ShellAndTubeCapitalCostPanelData instance populated with values from the provided ShellAndTubeCapitalCostDto object.</returns>
        public ShellAndTubeCapitalCostPanelData ConvertToPanelData(ShellAndTubeCapitalCostDto shellAndTubeCapitalCostDto)
        {
            ShellAndTubeCapitalCostDtoObj = shellAndTubeCapitalCostDto;
            this.Id = shellAndTubeCapitalCostDto.Id;
            this.ProjectId = shellAndTubeCapitalCostDto.ProjectId;
            this.ParameterA = shellAndTubeCapitalCostDto.ParameterA;
            this.ParameterB_Metric = shellAndTubeCapitalCostDto.ParameterB_Metric;
            this.ParameterB_English = shellAndTubeCapitalCostDto.ParameterB_English;
            this.ParameterN = shellAndTubeCapitalCostDto.ParameterN;
            this.MaterialFactor = shellAndTubeCapitalCostDto.MaterialFactor;
            this.AreaUnits_Metric = shellAndTubeCapitalCostDto.AreaUnits_Metric;
            this.AreaUnits_English = shellAndTubeCapitalCostDto.AreaUnits_English;
            return this;
        }
        #endregion  // ConvertToPanelData(ShellAndTubeCapitalCostDto shellAndTubeCapitalCostDto)

        #region ConvertFromPanelData()
        /// <summary>
        /// Creates a new ShellAndTubeCapitalCostDto instance by copying values from the current ShellAndTubeCapitalCostPanelData object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from ShellAndTubeCapitalCostPanelData to
        /// ShellAndTubeCapitalCostDto. All relevant fields are transferred directly.</remarks>
        /// <returns>A ShellAndTubeCapitalCostDto instance populated with values from the current ShellAndTubeCapitalCostPanelData object.</returns>
        public ShellAndTubeCapitalCostDto ConvertFromPanelData()
        {
            ShellAndTubeCapitalCostDtoObj = new ShellAndTubeCapitalCostDto();
            ShellAndTubeCapitalCostDtoObj.Id = this.Id;
            ShellAndTubeCapitalCostDtoObj.ProjectId = this.ProjectId;
            ShellAndTubeCapitalCostDtoObj.ParameterA = this.ParameterA;
            ShellAndTubeCapitalCostDtoObj.ParameterB_Metric = this.ParameterB_Metric;
            ShellAndTubeCapitalCostDtoObj.ParameterB_English = this.ParameterB_English;
            ShellAndTubeCapitalCostDtoObj.ParameterN = this.ParameterN;
            ShellAndTubeCapitalCostDtoObj.MaterialFactor = this.MaterialFactor;
            ShellAndTubeCapitalCostDtoObj.AreaUnits_Metric = this.AreaUnits_Metric;
            ShellAndTubeCapitalCostDtoObj.AreaUnits_English = this.AreaUnits_English;
            return ShellAndTubeCapitalCostDtoObj;
        }
        #endregion  // ConvertFromPanelData()   

        #endregion  // IMPLEMENTATION of IShellAndTubeCapitalCostPanelData METHODS
    }
    #endregion      // public class ShellAndTubeCapitalCostPanelData
}
#endregion  // namespace HenStudio.Data.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
