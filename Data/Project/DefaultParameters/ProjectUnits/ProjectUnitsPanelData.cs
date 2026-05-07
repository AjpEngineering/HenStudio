#region HEADER
//#####################################################################################################################
//################################  P r o j e c t U n i t s P a n e l D a t a . c s  ##################################
//#####################################################################################################################
//  FILENAME:  ProjectUnitsPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.DefaultParameters.ProjectUnits
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
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Project.DefaultParameters.ProjectUnits
namespace HenStudio.Data.Project.DefaultParameters.ProjectUnits
{
    #region public class ProjectUnitsPanelData
    public class ProjectUnitsPanelData : IProjectUnitsPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.DefaultParameters.ProjectUnits";
        const string CLASS = "ProjectUnitsPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public ProjectUnitsDto ProjectUnitsDtoObj { get; set; }
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public string DefaultSystemUnits { get; set; }
        public string DefaultMagnitudeUnits { get; set; }
        public string DefaultTemperatureUnits { get; set; }
        public string DefaultPressureUnits { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        public ProjectUnitsPanelData()
        {
            ProjectUnitsDtoObj = new ProjectUnitsDto();
            Id = new Guid();
            ProjectId = new Guid();
            DefaultSystemUnits = string.Empty;
            DefaultMagnitudeUnits = string.Empty;
            DefaultTemperatureUnits = string.Empty;
            DefaultPressureUnits = string.Empty;
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

        #endregion  // STRING CONVERSION METHODS

        #region IMPLEMENTATION of IProjectUnitsPanelData METHODS

        #region ConvertToPanelData(ProjectUnitsDto projectUnitsDto)
        /// <summary>
        /// Creates a new ProjectUnitsPanelData instance by copying values from the specified ProjectUnitsDto object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from ProjectUnitsDto to
        /// ProjectUnitsPanelData. All relevant fields are transferred directly. If projectUnitsDto is null,
        /// a NullReferenceException may occur.</remarks>
        /// <param name="projectUnitsDto">The ProjectUnitsDto object containing the source values to copy. Cannot be null.</param>
        /// <returns>A ProjectUnitsPanelData instance populated with values from the provided ProjectUnitsDto object.</returns>
        public ProjectUnitsPanelData ConvertToPanelData(ProjectUnitsDto projectUnitsDto)
        {
            ProjectUnitsDtoObj = projectUnitsDto;
            this.Id = projectUnitsDto.Id;
            this.ProjectId = projectUnitsDto.ProjectId;
            this.DefaultSystemUnits = projectUnitsDto.DefaultSystemUnits;
            this.DefaultMagnitudeUnits = projectUnitsDto.DefaultMagnitudeUnits;
            this.DefaultTemperatureUnits = projectUnitsDto.DefaultTemperatureUnits;
            this.DefaultPressureUnits = projectUnitsDto.DefaultPressureUnits;
            return this;
        }
        #endregion  // ConvertToPanelData(ProjectUnitsDto projectUnitsDto)

        #region ConvertFromPanelData()
        /// <summary>
        /// Creates a new ProjectUnitsDto instance by copying values from the current ProjectUnitsPanelData object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from ProjectUnitsPanelData to
        /// ProjectUnitsDto. All relevant fields are transferred directly.</remarks>
        /// <returns>A ProjectUnitsDto instance populated with values from the current ProjectUnitsPanelData object.</returns>
        public ProjectUnitsDto ConvertFromPanelData()
        {
            ProjectUnitsDtoObj = new ProjectUnitsDto();
            ProjectUnitsDtoObj.Id = this.Id;
            ProjectUnitsDtoObj.ProjectId = this.ProjectId;
            ProjectUnitsDtoObj.DefaultSystemUnits = this.DefaultSystemUnits;
            ProjectUnitsDtoObj.DefaultMagnitudeUnits = this.DefaultMagnitudeUnits;
            ProjectUnitsDtoObj.DefaultTemperatureUnits = this.DefaultTemperatureUnits;
            ProjectUnitsDtoObj.DefaultPressureUnits = this.DefaultPressureUnits;
            return ProjectUnitsDtoObj;
        }
        #endregion  // ConvertFromPanelData()   

        #endregion  // IMPLEMENTATION of IProjectUnitsPanelData
    }
    #endregion      // public class ProjectUnitsPanelData
}
#endregion  // namespace HenStudio.Data.Project.DefaultParameters.ProjectUnits

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
