#region HEADER
//#####################################################################################################################
//################################  P r o c e s s S t r e a m P a n e l D a t a . c s  ################################
//#####################################################################################################################
//  FILENAME:  ProcessStreamPanelData.cs
//  NAMESPACE: HenStudio.Data.Profile
//  CLASS(S):  ProcessStreamPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Process Stream Panel Data object - data needed for Process Stream Panel.
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
    #region public class ProcessStreamPanelData
    public class ProcessStreamPanelData : IProcessStreamPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Profile";
        const string CLASS = "ProcessStreamPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public ProcessStreamDto ProcessStreamDtoObj { get; set; }
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public string StreamCategory { get; set; }
        public string StreamHeat { get; set; }
        public string StreamId { get; set; }
        public string Name { get; set; }
        public string StreamType { get; set; }
        public string StreamSubtype { get; set; }
        public double SupplyTemperature { get; set; }
        public double SupplyPressure { get; set; }
        public double TargetTemperature { get; set; }
        public double TargetPressure { get; set; }
        public double HeatCapacityFlowRate { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Initializes a new instance of the ProcessStreamPanelData class with default values for all properties.
        /// </summary>
        /// <remarks>All string properties are initialized to empty strings, date properties are set to
        /// the current date and time, and the ProcessStreamDtoObj property is initialized with a new ProcessStreamDto instance.
        /// This constructor ensures that the object is in a valid default state upon creation.</remarks>
        public ProcessStreamPanelData()
        {
            ProcessStreamDtoObj = new ProcessStreamDto();
            Id = new Guid();
            ProfileId = new Guid();
            StreamCategory = string.Empty;
            StreamHeat = string.Empty;
            StreamId = string.Empty;
            Name = string.Empty;
            StreamType = string.Empty;
            StreamSubtype = string.Empty;
            SupplyTemperature = 0.0;
            SupplyPressure = 0.0;
            TargetTemperature = 0.0;
            TargetPressure = 0.0;
            HeatCapacityFlowRate = 0.0;
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

        #region GetSupplyTemperature()
        /// <summary>
        /// Gets the supply temperature as a string.
        /// </summary>
        /// <returns>A string representation of the supply temperature.</returns>
        public string GetSupplyTemperature()
        {
            return SupplyTemperature.ToString();
        }
        #endregion  // GetSupplyTemperature()

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

        #region GetTargetTemperature()
        /// <summary>
        /// Gets the target temperature as a string.
        /// </summary>
        /// <returns>A string representation of the target temperature.</returns>
        public string GetTargetTemperature()
        {
            return TargetTemperature.ToString();
        }
        #endregion  // GetTargetTemperature()

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

        #region GetHeatCapacityFlowRate()
        /// <summary>
        /// Gets the heat capacity flow rate as a string.
        /// </summary>
        /// <returns>A string representation of the heat capacity flow rate.</returns>
        public string GetHeatCapacityFlowRate()
        {
            return HeatCapacityFlowRate.ToString();
        }
        #endregion  // GetHeatCapacityFlowRate()

        #endregion  // STRING CONVERSION METHODS

        #region IMPLEMENTATION of IProcessStreamPanelData METHODS

        #region ConvertToPanelData(ProcessStreamDto processStreamDto)
        /// <summary>
        /// Creates a new ProcessStreamPanelData instance by copying values from the specified ProcessStreamDto object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from ProcessStreamDto to
        /// ProcessStreamPanelData. All relevant fields are transferred directly. If processStreamDto is null, a
        /// NullReferenceException may occur.</remarks>
        /// <param name="processStreamDto">The ProcessStreamDto object containing the source values to copy. Cannot be null.</param>
        /// <returns>A ProcessStreamPanelData instance populated with values from the provided ProcessStreamDto object.</returns>
        public ProcessStreamPanelData ConvertToPanelData(ProcessStreamDto processStreamDto)
        {
            ProcessStreamDtoObj = processStreamDto;
            this.Id = processStreamDto.Id;
            this.ProfileId = processStreamDto.ProfileId;
            this.StreamCategory = processStreamDto.StreamCategory;
            this.StreamHeat = processStreamDto.StreamHeat;
            this.StreamId = processStreamDto.StreamId;
            this.Name = processStreamDto.Name;
            this.StreamType = processStreamDto.StreamType;
            this.StreamSubtype = processStreamDto.StreamSubtype;
            this.SupplyTemperature = processStreamDto.SupplyTemperature;
            this.SupplyPressure = processStreamDto.SupplyPressure;
            this.TargetTemperature = processStreamDto.TargetTemperature;
            this.TargetPressure = processStreamDto.TargetPressure;
            this.HeatCapacityFlowRate = processStreamDto.HeatCapacityFlowRate;
            return this;
        }
        #endregion  // ConvertToPanelData(ProcessStreamDto processStreamDto)

        #region ConvertFromPanelData()
        /// <summary>
        /// Creates a new ProcessStreamDto instance by copying values from the current ProcessStreamPanelData object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from ProcessStreamPanelData to
        /// ProcessStreamDto. All relevant fields are transferred directly.</remarks>
        /// NullReferenceException may occur.</remarks>
        /// <returns>A ProcessStreamDto instance populated with values from the provided ProcessStreamPanelData object.</returns>
        public ProcessStreamDto ConvertFromPanelData()
        {
            ProcessStreamDtoObj = new ProcessStreamDto();
            ProcessStreamDtoObj.Id = this.Id;
            ProcessStreamDtoObj.ProfileId = this.ProfileId;
            ProcessStreamDtoObj.StreamCategory = this.StreamCategory;
            ProcessStreamDtoObj.StreamHeat = this.StreamHeat;
            ProcessStreamDtoObj.StreamId = this.StreamId;
            ProcessStreamDtoObj.Name = this.Name;
            ProcessStreamDtoObj.StreamType = this.StreamType;
            ProcessStreamDtoObj.StreamSubtype = this.StreamSubtype;
            ProcessStreamDtoObj.SupplyTemperature = this.SupplyTemperature;
            ProcessStreamDtoObj.SupplyPressure = this.SupplyPressure;
            ProcessStreamDtoObj.TargetTemperature = this.TargetTemperature;
            ProcessStreamDtoObj.TargetPressure = this.TargetPressure;
            ProcessStreamDtoObj.HeatCapacityFlowRate = this.HeatCapacityFlowRate;
            return ProcessStreamDtoObj;
        }
        #endregion  // ConvertFromPanelData()   

        #endregion  // IMPLEMENTATION of IProcessStreamPanelData METHODS
    }
    #endregion      // public class ProcessStreamPanelData
}
#endregion  // namespace HenStudio.Data.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
