#region HEADER
//#####################################################################################################################
//################################  U t i l i t y S t r e a m P a n e l D a t a . c s  ################################
//#####################################################################################################################
//  FILENAME:  UtilityStreamPanelData.cs
//  NAMESPACE: HenStudio.Data.Profile
//  CLASS(S):  UtilityStreamPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Utility Stream Panel Data object - data needed for Utility Stream Panel.
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
using HenModel.Dto.Profile;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Profile
namespace HenStudio.Data.Profile
{
    #region public class UtilityStreamPanelData
    public class UtilityStreamPanelData : IUtilityStreamPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Profile";
        const string CLASS = "UtilityStreamPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public UtilityStreamDto UtilityStreamDtoObj { get; set; }
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public string StreamCategory { get; set; }
        public string StreamHeat { get; set; }
        public string StreamId { get; set; }
        public string Name { get; set; }
        public string StreamType { get; set; }
        public double IsothermalTemperature { get; set; }
        public double SupplyPressure { get; set; }
        public double TargetPressure { get; set; }
        public double EnthalpyFlowRate { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Initializes a new instance of the UtilityStreamPanelData class with default values for all properties.
        /// </summary>
        /// <remarks>All string properties are initialized to empty strings, date properties are set to
        /// the current date and time, and the UtilityStreamDtoObj property is initialized with a new UtilityStreamDto instance.
        /// This constructor ensures that the object is in a valid default state upon creation.</remarks>
        public UtilityStreamPanelData()
        {
            UtilityStreamDtoObj = new UtilityStreamDto();
            Id = new Guid();
            ProfileId = new Guid();
            StreamCategory = string.Empty;
            StreamHeat = string.Empty;
            StreamId = string.Empty;
            Name = string.Empty;
            StreamType = string.Empty;
            IsothermalTemperature = 0.0;
            SupplyPressure = 0.0;
            TargetPressure = 0.0;
            EnthalpyFlowRate = 0.0;
        }
        #endregion  // CTOR

        #region STRING CONVERSION METHODS

        #region GetId()
        /// <summary>
        /// Gets the unique identifier of the project as a string.
        /// </summary>
        /// <returns>A string representation of the project's unique identifier.</returns>
        public string GetId()
        { 
            return Id.ToString(); 
        }
        #endregion  // GetId()

        #region GetProfileId()
        /// <summary>
        /// Gets the unique identifier of the profile as a string.
        /// </summary>
        /// <returns>A string representation of the profile's unique identifier.</returns>
        public string GetProfileId()
        {
            return ProfileId.ToString();
        }
        #endregion  // GetProfileId()

        #region GetIsothermalTemperature()
        /// <summary>
        /// Gets the isothermal temperature as a string.
        /// </summary>
        /// <returns>A string representation of the isothermal temperature.</returns>
        public string GetIsothermalTemperature()
        {
            return IsothermalTemperature.ToString();
        }
        #endregion  // GetIsothermalTemperature()
        
        #region GetSupplyPressure()
        /// <summary>
        /// Gets the supply pressure as a string.
        /// </summary>
        /// <returns>A string representation of the supply pressure.</returns>
        public string GetSupplyPressure()
        {
            return SupplyPressure.ToString();
        }
        #endregion  // GetSupplyPressure()

        #region GetTargetPressure()
        /// <summary>
        /// Gets the target pressure as a string.
        /// </summary>
        /// <returns>A string representation of the target pressure.</returns>
        public string GetTargetPressure()
        {
            return TargetPressure.ToString();
        }
        #endregion  // GetTargetPressure()

        #region GetEnthalpyFlowRate()
        /// <summary>
        /// Gets the enthalpy flow rate as a string.
        /// </summary>
        /// <returns>A string representation of the enthalpy flow rate.</returns>
        public string GetEnthalpyFlowRate()
        {
            return EnthalpyFlowRate.ToString();
        }
        #endregion  // GetEnthalpyFlowRate()

        #endregion  // STRING CONVERSION METHODS

        #region IMPLEMENTATION of IUtilityStreamPanelData METHODS

        #region ConvertToPanelData(UtilityStreamDto utilityStreamDto)
        /// <summary>
        /// Creates a new UtilityStreamPanelData instance by copying values from the specified UtilityStreamDto object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from UtilityStreamDto to
        /// UtilityStreamPanelData. All relevant fields are transferred directly. If utilityStreamDto is null, a
        /// NullReferenceException may occur.</remarks>
        /// <param name="utilityStreamDto">The UtilityStreamDto object containing the source values to copy. Cannot be null.</param>
        /// <returns>A UtilityStreamPanelData instance populated with values from the provided UtilityStreamDto object.</returns>
        public UtilityStreamPanelData ConvertToPanelData(UtilityStreamDto utilityStreamDto)
        {
            UtilityStreamDtoObj = utilityStreamDto;
            this.Id = utilityStreamDto.Id;
            this.ProfileId = utilityStreamDto.ProfileId;
            this.StreamCategory = utilityStreamDto.StreamCategory;
            this.StreamHeat = utilityStreamDto.StreamHeat;
            this.StreamId = utilityStreamDto.StreamId;
            this.Name = utilityStreamDto.Name;
            this.StreamType = utilityStreamDto.StreamType;
            this.IsothermalTemperature = utilityStreamDto.IsothermalTemperature;
            this.SupplyPressure = utilityStreamDto.SupplyPressure;
            this.TargetPressure = utilityStreamDto.TargetPressure;
            this.EnthalpyFlowRate = utilityStreamDto.EnthalpyFlowRate;
            return this;
        }
        #endregion  // ConvertToPanelData(UtilityStreamDto utilityStreamDto)

        #region ConvertFromPanelData()
        /// <summary>
        /// Creates a new ProcessStreamDto instance by copying values from the current ProcessStreamPanelData object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from ProcessStreamPanelData to
        /// ProcessStreamDto. All relevant fields are transferred directly.</remarks>
        /// NullReferenceException may occur.</remarks>
        /// <returns>A ProcessStreamDto instance populated with values from the provided ProcessStreamPanelData object.</returns>
        public UtilityStreamDto ConvertFromPanelData()
        {
            UtilityStreamDtoObj = new UtilityStreamDto();
            UtilityStreamDtoObj.Id = this.Id;
            UtilityStreamDtoObj.ProfileId = this.ProfileId;
            UtilityStreamDtoObj.StreamCategory = this.StreamCategory;
            UtilityStreamDtoObj.StreamHeat = this.StreamHeat;
            UtilityStreamDtoObj.StreamId = this.StreamId;
            UtilityStreamDtoObj.Name = this.Name;
            UtilityStreamDtoObj.StreamType = this.StreamType;
            UtilityStreamDtoObj.IsothermalTemperature = this.IsothermalTemperature;
            UtilityStreamDtoObj.SupplyPressure = this.SupplyPressure;
            UtilityStreamDtoObj.TargetPressure = this.TargetPressure;
            UtilityStreamDtoObj.EnthalpyFlowRate = this.EnthalpyFlowRate;
            return UtilityStreamDtoObj;
        }
        #endregion  // ConvertFromPanelData()   

        #endregion  // IMPLEMENTATION of IUtilityStreamPanelData METHODS
    }
    #endregion      // public class UtilityStreamPanelData
}
#endregion  // namespace HenStudio.Data.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
