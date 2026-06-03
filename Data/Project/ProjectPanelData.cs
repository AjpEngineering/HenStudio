#region HEADER
//#####################################################################################################################
//######################################  P r o j e c t P a n e l D a t a . c s  ########################################
//#####################################################################################################################
//  FILENAME:  ProjectPanelData.cs
//  NAMESPACE: HenStudio.Data.Project
//  CLASS(S):  ProjectPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Project Panel Data object - data needed for Project Panel.
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

using HenViewModel.Project;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Project
namespace HenStudio.Data.Project
{
    #region public class ProjectPanelData
    public class ProjectPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project";
        const string CLASS = "ProjectPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public Guid ProjectId { get; set; }
        public ProjectDto ProjectDtoObj { get; set; }

        #region VIEW MODEL Object
        public ProjectViewModel ProjectViewModelObj { get; set; }
        #endregion  // VIEW MODEL Objects


        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Initializes a new instance of the ProjectPanelData class with default values for all properties.
        /// </summary>
        /// <remarks>All string properties are initialized to empty strings, date properties are set to
        /// the current date and time, and the ProjectDtoObj property is initialized with a new ProjectDto instance.
        /// This constructor ensures that the object is in a valid default state upon creation.</remarks>
        public ProjectPanelData()
        {
            ProjectId = new Guid();
            ProjectDtoObj = new ProjectDto();

            ProjectViewModelObj = new ProjectViewModel();
        }
        #endregion  // CTOR

        #region CRUD Methods

        #region CREATE PROJECT DATA METHOD
        /// <summary>
        /// Creates a new project using the data in the ProjectDtoObj property 
        /// and returns the ID of the newly created project.
        /// </summary>
        /// <returns>The ID of the newly created project.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the project ID is null after creation.</exception>
        public Guid CreateProjectData()
        {
            ProjectId = ProjectViewModelObj.AddProject(ProjectDtoObj);
            if (ProjectId == null) throw new ArgumentNullException(
                             nameof(ProjectId), "Project ID is null for ADD Project Panel data.");
            ProjectDtoObj.Id = ProjectId;
            return ProjectId;
        }
        #endregion  // CREATE PROJECT DATA METHOD

        #region READ PROJECT DATA METHOD
        /// <summary>
        /// Reads the project data for the specified project ID 
        /// and populates the ProjectDtoObj property with the retrieved data.
        /// </summary>
        /// <param name="projectId">The ID of the project to read.</param>
        /// <exception cref="ArgumentNullException">Thrown when the project ID is null.</exception>
        public void ReadProjectData(Guid projectId)
        {
            if (projectId == null) throw new ArgumentNullException(
                             nameof(projectId), "Project ID is null for READ Project Panel data.");
            ProjectId = projectId;
            ProjectDtoObj = ProjectViewModelObj.GetProjectById(projectId);

            if (ProjectDtoObj == null) throw new ArgumentNullException(
                             nameof(ProjectDtoObj), "Project DTO is null for READ Project Panel data.");
            ProjectDtoObj.Id = ProjectId;
        }

        #endregion  // READ PROJECT DATA METHOD

        #region UPDATE PROJECT DATA METHOD
        /// <summary>
        /// Updates the project data using the provided ProjectDto object 
        /// and returns the updated ProjectDto object.
        /// </summary>
        /// <param name="projectDtoObj">The ProjectDto object containing 
        /// the updated project data.</param>
        /// <returns>The updated ProjectDto object.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the project DTO or its ID is null.</exception>
        public ProjectDto UpdateProjectData(ProjectDto projectDtoObj)
        {
            if (projectDtoObj == null) throw new ArgumentNullException(
                             nameof(projectDtoObj), "Project DTO is null for UPDATE Project Panel data.");


            if (projectDtoObj.Id == null) throw new ArgumentNullException(
                             nameof(projectDtoObj), "Project DTO ID is null for UPDATE Project Panel data.");
            
            ProjectId = projectDtoObj.Id;
            ProjectDtoObj = projectDtoObj;
            ProjectViewModelObj.UpdateProject(projectDtoObj);
            return ProjectDtoObj;
        }
        #endregion  // UPDATE PROJECT DATA METHOD

        #region DELETE PROJECT DATA METHOD
        /// <summary>
        /// Deletes the project data for the specified project ID.
        /// </summary>
        /// <param name="projectId">The ID of the project to delete.</param>
        /// <exception cref="ArgumentNullException">Thrown when the project ID is null.</exception>
        public void DeleteProjectData(Guid projectId)
        {
            if (projectId == null) throw new ArgumentNullException(
                             nameof(projectId), "Project ID is null for DELETE Project Panel data.");

            ProjectId = projectId;
            ProjectViewModelObj.DeleteProject(projectId);
        }
        #endregion  // DELETE PROJECT DATA METHOD

        #endregion  // CRUD Methods

    }
    #endregion      // public class ProjectPanelData
}
#endregion  // namespace HenStudio.Data.Project

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
