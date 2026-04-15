#region HEADER
//#####################################################################################################################
//######################################  P r o j e c t V i e w M o d e l . c s  ######################################
//#####################################################################################################################
//  FILENAME:  ProjectViewModel.cs
//  NAMESPACE: HenViewModels
//  CLASS(S):  ProjectViewModel
//  COMPONENT: _HenViewModels.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the Project top-level DTO.
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
//    01/01/26 .. AJP Engineering .. Version 1.0
//#####################################################################################################################
//#####################################################################################################################
//#####################################################################################################################
#endregion      // HEADER

#region REFERENCES
using HenGlobal;

using HenRepositories.Dto;

using HenPersistence.Repos;
using HenPersistence.Connection;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenViewModels
namespace HenViewModels
{
    #region public class ProjectViewModel
    /// <summary>
    /// Project view model class.
    /// </summary>
    public class ProjectViewModel : ViewModelBase
    {
        #region PROPERTIES
        public ProjectRepo ProjectRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region DEFAULT CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public ProjectViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var projectRepoObj = new ProjectRepo(connFactoryObj);

            ProjectRepoObj = projectRepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // DEFAULT CTOR

        #region GetProjects()
        /// <summary>
        /// Retrieves a list of all Projects in EXTERNAL Units.
        /// Database access is performed by the repository layer, and the results are returned as a 
        /// list of <see cref="ProjectDto"/> objects in INTERNAL Units.
        /// </summary>
        /// <returns>A list of <see cref="ProjectDto"/> objects in EXTERNAL Units
        /// representing the available projects, or an empty list if no projects found.</returns>
        public IList<ProjectDto> GetProjects()
        {
            List<ProjectDto> externalProjects = new List<ProjectDto>(); // List of Project Dtos [EXTERNAL Units]
            try
            {
                foreach (ProjectDto internalProject in ProjectRepoObj.GetProjects())   // List of Project Dtos [INTERNAL Units]
                {
                    ProjectDto externalProject = new ProjectDto();
                    //-------------------------------------------------
                    //--- Convert INTERNAL Fields to EXTERNAL Units ---
                    //-------------------------------------------------
                    externalProject.Id = internalProject.Id;
                    externalProject.Name = internalProject.Name;
                    externalProject.Description = internalProject.Description;
                    externalProject.DefaultHeatTransferCoefficient = ConvertToExternalU(internalProject.DefaultHeatTransferCoefficient);
                    externalProject.DefaultHenOptimizer = internalProject.DefaultHenOptimizer;
                    externalProject.DefaultSystemUnits = internalProject.DefaultSystemUnits;
                    externalProject.DefaultMagnitudeUnits = internalProject.DefaultMagnitudeUnits;
                    externalProject.DefaultTemperatureUnits = internalProject.DefaultTemperatureUnits;
                    externalProject.DefaultPressureUnits = internalProject.DefaultPressureUnits;
                    externalProjects.Add(externalProject);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project: {ex.Message}");
                return null; // Return null if an error occurs
            }
            return externalProjects;
        }
        #endregion  // GetProjects()

        #region GetProjectById(Guid projectId)
        /// <summary>
        /// Retrieves the Project Dto associated with the specified unique identifier.
        /// The project retrieved from the Database is in INTERNAL Units, 
        /// database access performed by the repository layer, 
        /// the fields of the project are converted to EXTERNAL Units, which are the units used in the user interface,
        /// the resulting Project Dto is returned as a <see cref="ProjectDto"/> object.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve.</param>
        /// <returns>A <see cref="ProjectDto"/> representing the Project with the specified identifier. 
        /// Returns null if no Project is found.</returns>
        public ProjectDto GetProjectById(Guid projectId)
        {
            ProjectDto externalProject = new ProjectDto();
            try
            {
                //-------------------------------------------------------------------------
                //--- Retrieve Project Dto from the Database using the Repository layer ---
                //-------------------------------------------------------------------------
                ProjectDto internalProject = ProjectRepoObj.GetProjectById(projectId);     // Retrieved Project Dto [INTERNAL Units]

                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalProject.Id = internalProject.Id;
                externalProject.Name = internalProject.Name;
                externalProject.Description = internalProject.Description;
                externalProject.DefaultHeatTransferCoefficient = ConvertToExternalU(internalProject.DefaultHeatTransferCoefficient);
                externalProject.DefaultHenOptimizer = internalProject.DefaultHenOptimizer;
                externalProject.DefaultSystemUnits = internalProject.DefaultSystemUnits;
                externalProject.DefaultMagnitudeUnits = internalProject.DefaultMagnitudeUnits;
                externalProject.DefaultTemperatureUnits = internalProject.DefaultTemperatureUnits;
                externalProject.DefaultPressureUnits = internalProject.DefaultPressureUnits;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project: {ex.Message}");
                return null; // Return null if an error occurs
            }

            return externalProject;
        }
        #endregion  // GetProjectById(Guid projectId)

        #region GetProjectByName(string projectName)
        /// <summary>
        /// Retrieves a Project by its name and returns its details as a data transfer object.
        /// </summary>
        /// <remarks>The returned ProjectDto contains project information with fields converted to
        /// EXTERNAL units where applicable. If an error occurs during retrieval, the method returns null.</remarks>
        /// <param name="projectName">The name of the project to retrieve. Cannot be null or empty.</param>
        /// <returns>A ProjectDto containing the project's details if found; otherwise, null.</returns>
        public ProjectDto GetProjectByName(string projectName)
        {
            try
            {
                //-------------------------------------------------------------------------
                //--- Retrieve Project Dto from the Database using the Repository Layer ---
                //-------------------------------------------------------------------------
                ProjectDto internalProject = ProjectRepoObj.GetProjectByName(projectName);     // Retrieved Project Dto [INTERNAL Units]
                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                ProjectDto externalProject = new ProjectDto();
                externalProject.Id = internalProject.Id;
                externalProject.Name = internalProject.Name;
                externalProject.Description = internalProject.Description;
                externalProject.DefaultHeatTransferCoefficient = ConvertToExternalU(internalProject.DefaultHeatTransferCoefficient);
                externalProject.DefaultHenOptimizer = internalProject.DefaultHenOptimizer;
                externalProject.DefaultSystemUnits = internalProject.DefaultSystemUnits;
                externalProject.DefaultMagnitudeUnits = internalProject.DefaultMagnitudeUnits;
                externalProject.DefaultTemperatureUnits = internalProject.DefaultTemperatureUnits;
                externalProject.DefaultPressureUnits = internalProject.DefaultPressureUnits;
                return externalProject;

            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project: {ex.Message}");
                return null; // Return null if an error occurs
            }
        }
        #endregion  // GetProjectByName(string projectName)

        #region AddProject(ProjectDto externalProjectDto)
        /// <summary>
        /// Adds a new project to the database using the specified project data transfer object.
        /// </summary>
        /// <remarks>The method converts the provided project data from external to internal units before
        /// storing it in the database. If an error occurs during the operation, the method logs the error and returns
        /// an empty GUID.</remarks>
        /// <param name="externalProjectDto">The project data to add. The object must contain all required project fields in external units. Cannot be
        /// null.</param>
        /// <returns>A GUID representing the unique identifier of the newly added project.</returns>
        public Guid AddProject(ProjectDto externalProjectDto)
        {
            Guid projectID = new Guid();
            try
            {
                //----------------------------------------------------------------
                //--- Project Dto [INTERNAL Units] to be Added to the Database ---
                //----------------------------------------------------------------
                ProjectDto internalProjectDto = new ProjectDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalProjectDto.Id = externalProjectDto.Id;
                internalProjectDto.Name = externalProjectDto.Name;
                internalProjectDto.Description = externalProjectDto.Description;
                internalProjectDto.DefaultHeatTransferCoefficient = ConvertFromExternalU(externalProjectDto.DefaultHeatTransferCoefficient);
                internalProjectDto.DefaultHenOptimizer = externalProjectDto.DefaultHenOptimizer;
                internalProjectDto.DefaultSystemUnits = externalProjectDto.DefaultSystemUnits;
                internalProjectDto.DefaultMagnitudeUnits = externalProjectDto.DefaultMagnitudeUnits;
                internalProjectDto.DefaultTemperatureUnits = externalProjectDto.DefaultTemperatureUnits;
                internalProjectDto.DefaultPressureUnits = externalProjectDto.DefaultPressureUnits;
                //----------------------------------------------------------------------------
                //--- Add INTERNAL Project Dto to the Database using the Repository Layer  ---
                //--- Returns the Project ID (PK) from the Project Table database addition ---
                //----------------------------------------------------------------------------
                projectID = ProjectRepoObj.AddProject(internalProjectDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project: {ex.Message}");
            }
            return projectID; // Return Project ID (PK) from the Project Table database addition
        }
        #endregion  // AddProject(ProjectDto externalProjectDto)

        #region UpdateProject(ProjectDto externalProjectDto)
        /// <summary>
        /// Updates an existing project in the database using the specified project data transfer object (DTO) 
        /// with external units.
        /// </summary>
        /// <remarks>This method converts the provided project data from external units to the internal
        /// units required by the database before updating the project. If the specified project does not exist,
        /// the behavior depends on the repository implementation.</remarks>
        /// <param name="externalProjectDto">The project data transfer object containing updated project 
        /// information in external units. Cannot be null.</param>
        public void UpdateProject(ProjectDto externalProjectDto)
        {
            try
            {
                //----------------------------------------------------------------
                //--- Project Dto [INTERNAL Units] to be Added to the Database ---
                //----------------------------------------------------------------
                ProjectDto internalProjectDto = new ProjectDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalProjectDto.Id = externalProjectDto.Id;
                internalProjectDto.Name = externalProjectDto.Name;
                internalProjectDto.Description = externalProjectDto.Description;
                internalProjectDto.DefaultHeatTransferCoefficient = ConvertFromExternalU(externalProjectDto.DefaultHeatTransferCoefficient);
                internalProjectDto.DefaultHenOptimizer = externalProjectDto.DefaultHenOptimizer;
                internalProjectDto.DefaultSystemUnits = externalProjectDto.DefaultSystemUnits;
                internalProjectDto.DefaultMagnitudeUnits = externalProjectDto.DefaultMagnitudeUnits;
                internalProjectDto.DefaultTemperatureUnits = externalProjectDto.DefaultTemperatureUnits;
                internalProjectDto.DefaultPressureUnits = externalProjectDto.DefaultPressureUnits;
                //------------------------------------------------------------------------------
                //--- UPDATE INTERNAL Project Dto to the Database using the Repository Layer ---
                //------------------------------------------------------------------------------
                ProjectRepoObj.UpdateProject(internalProjectDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project: {ex.Message}");
            }
        }
        #endregion  // UpdateProject(ProjectDto projectDto)

        #region DeleteProject(Guid projectId)
        /// <summary>
        /// Deletes the project with the specified unique identifier.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project to delete.</param>
        public void DeleteProject(Guid projectId)
        {
            try
            {
                //-------------------------------------------------------------------
                //--- DELETE Project from the Database using the Repository Layer ---
                //-------------------------------------------------------------------
                ProjectRepoObj.DeleteProject(projectId);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project: {ex.Message}");
            }
        }
        #endregion  // DeleteProject(Guid projectId)

    }
    #endregion      // public class ProjectViewModel

}
#endregion      // namespace HenViewModels

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
