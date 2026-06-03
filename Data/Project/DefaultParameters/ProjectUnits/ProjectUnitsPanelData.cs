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
using HenModel.Dto.Project;
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

using HenViewModel.Project;
using HenViewModel.Project.DefaultParameters.ProjectUnits;

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
    public class ProjectUnitsPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.DefaultParameters.ProjectUnits";
        const string CLASS = "ProjectUnitsPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public Guid ProjectUnitsId { get; set; }
        public Guid ProjectId { get; set; }
        public ProjectUnitsDto ProjectUnitsDtoObj { get; set; }

        #region VIEW MODEL Object
        public ProjectUnitsViewModel ProjectUnitsViewModelObj { get; set; }
        #endregion  // VIEW MODEL Objects

        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for ProjectUnitsPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public ProjectUnitsPanelData()
        {
            ProjectUnitsId = new Guid();
            ProjectId = new Guid();
            ProjectUnitsDtoObj = new ProjectUnitsDto();
        }
        #endregion  // CTOR

        #region CRUD Methods

        #region CREATE PROJECT UNITS DATA METHOD
        /// <summary>
        /// Creates a new project units data using the data in the ProjectUnitsDtoObj property 
        /// and returns the ID of the newly created project.
        /// </summary>
        /// <returns>The ID of the newly created project units data.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the project units ID is null after creation.</exception>
        public Guid CreateProjectUnitsData()
        {
            ProjectUnitsId = ProjectUnitsViewModelObj.AddProjectUnits(ProjectUnitsDtoObj);

            if (ProjectUnitsId == null) throw new ArgumentNullException(
                             nameof(ProjectUnitsId), 
                             "Project units ID is null for ADD Project Units Panel data.");

            ProjectUnitsDtoObj.Id = ProjectUnitsId;
            return ProjectUnitsId;  // ProjectUnits ID
        }
        #endregion  // CREATE PROJECT UNITS DATA METHOD

        #region READ PROJECT UNITS DATA METHOD
        /// <summary>
        /// Reads the project units data for the specified project ID 
        /// and populates the ProjectUnitsDtoObj property with the retrieved data.
        /// </summary>
        /// <param name="projectId">The ID of the project to read.</param>
        /// <exception cref="ArgumentNullException">Thrown when the project ID is null.</exception>
        public void ReadProjectUnitsData(Guid projectId)
        {
            if (projectId == null) throw new ArgumentNullException(
                             nameof(projectId), "Project ID is null for READ Project Units Panel data.");

            ProjectId = projectId;
            ProjectUnitsDtoObj = ProjectUnitsViewModelObj.GetProjectUnitsByProjectId(projectId);
        }

        #endregion  // READ PROJECT UNITS DATA METHOD

        #region UPDATE PROJECT UNITS DATA METHOD
        /// <summary>
        /// Updates the project units data using the provided ProjectUnitsDto object 
        /// and returns the updated ProjectUnitsDto object.
        /// </summary>
        /// <param name="projectUnitsDtoObj">The ProjectUnitsDto object containing 
        /// the updated project units data.</param>
        /// <returns>The updated ProjectUnitsDto object.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the project units DTO or its ID is null.</exception>
        public ProjectUnitsDto UpdateProjectUnitsData(ProjectUnitsDto projectUnitsDtoObj)
        {
            if (projectUnitsDtoObj == null) throw new ArgumentNullException(
                             nameof(projectUnitsDtoObj), "Project Units DTO is null for UPDATE Project Units Panel data.");

            if (projectUnitsDtoObj.Id == null) throw new ArgumentNullException(
                             nameof(projectUnitsDtoObj), "Project Units DTO ID is null for UPDATE Project Units Panel data.");

            if (projectUnitsDtoObj.ProjectId == null) throw new ArgumentNullException(
                             nameof(projectUnitsDtoObj), "Project Units DTO Project ID is null for UPDATE Project Units Panel data.");

            ProjectUnitsId = projectUnitsDtoObj.Id;
            ProjectId = projectUnitsDtoObj.ProjectId;
            ProjectUnitsDtoObj = projectUnitsDtoObj;
            ProjectUnitsViewModelObj.UpdateProjectUnits(projectUnitsDtoObj);
            return ProjectUnitsDtoObj;
        }
        #endregion  // UPDATE PROJECT DATA METHOD


        #endregion  // CRUD Methods

    }
    #endregion      // public class ProjectUnitsPanelData
}
#endregion  // namespace HenStudio.Data.Project.DefaultParameters.ProjectUnits

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
