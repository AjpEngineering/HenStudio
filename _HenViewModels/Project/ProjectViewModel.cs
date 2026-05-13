#region HEADER
//#####################################################################################################################
//######################################  P r o j e c t V i e w M o d e l . c s  ######################################
//#####################################################################################################################
//  FILENAME:  ProjectViewModel.cs
//  NAMESPACE: HenViewModel.Project
//  CLASS(S):  ProjectViewModel
//  COMPONENT: _HenViewModel.dll
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

using HenModel.Connection;
using HenModel.Dto.Project;
using HenModel.RepoImplementations.Project;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenViewModel.Project
namespace HenViewModel.Project
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

        #region PRIVATE DTO CONVERSION METHODS


        #endregion  // PRIVATE DTO CONVERSION METHODS

        #region PROJECT CRUD METHODS

        #region AddProject(ProjectDto externalProjectDto) ... CREATE
        /// <summary>
        /// Adds (CREATE) a new project to the database using the specified project data transfer object.
        /// </summary>
        /// <remarks>The method converts the provided project data from external to internal units before
        /// storing it in the database. If an error occurs during the operation, the method logs the error and returns
        /// an empty GUID.</remarks>
        /// <param name="externalProjectDto">The project data to add. The object must contain all required project fields 
        /// in external units. Cannot be null.</param>
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
                internalProjectDto.DefaultOptimizer = externalProjectDto.DefaultOptimizer;
                internalProjectDto.CreationDate = externalProjectDto.CreationDate;
                internalProjectDto.ModifiedDate = externalProjectDto.ModifiedDate;
                //------------------------------------------------------------------------------
                //--- Add INTERNAL Project Dto to the Database using the ProjectRepo Object  ---
                //--- Returns the Project ID (PK) from the Project Table database addition   ---
                //------------------------------------------------------------------------------
                projectID = ProjectRepoObj.AddProject(internalProjectDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project: {ex.Message}");
            }
            return projectID; // Return Project ID (PK) from the Project Table database addition
        }
        #endregion  // AddProject(ProjectDto externalProjectDto) ... CREATE

        #region GetProjects() ... READ
        /// <summary>
        /// Retrieves (READ) a list of all Projects in EXTERNAL Units.
        /// Database access is performed by the repository layer, and the results are returned as a 
        /// list of <see cref="ProjectDto"/> objects in INTERNAL Units.
        /// </summary>
        /// <returns>A list of <see cref="ProjectDto"/> objects in EXTERNAL Units
        /// representing the available projects, or an empty list if no projects found.</returns>
        public IList<ProjectDto> GetProjects()
        {
            //---------------------------------------------------------------
            //--- List to Hold Projects to be Returned to the Caller      ---
            //--- This List will Contain Project Dtos with EXTERNAL Units ---
            //---------------------------------------------------------------
            List<ProjectDto> externalProjects = new List<ProjectDto>();
            try
            {
                //-----------------------------------------------------------------------------
                //--- Use ProjectRepo Object to Retrieve List of Projects from the Database ---
                //--- Retrieved List of Project Dtos [INTERNAL Units] from the Database     ---
                //-----------------------------------------------------------------------------
                foreach (ProjectDto internalProject in ProjectRepoObj.GetProjects())
                {
                    ProjectDto externalProject = new ProjectDto();
                    //-------------------------------------------------
                    //--- Convert INTERNAL Fields to EXTERNAL Units ---
                    //-------------------------------------------------
                    externalProject.Id = internalProject.Id;
                    externalProject.Name = internalProject.Name;
                    externalProject.Description = internalProject.Description;
                    externalProject.DefaultOptimizer = internalProject.DefaultOptimizer;
                    externalProject.CreationDate = internalProject.CreationDate;
                    externalProject.ModifiedDate = internalProject.ModifiedDate;
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
        #endregion  // GetProjects() ... READ

        #region GetProjectById(Guid projectId) ... READ
        /// <summary>
        /// Retrieves (READ) the Project Dto associated with the specified unique identifier.
        /// The project retrieved from the Database is in INTERNAL Units, 
        /// database access performed by the repository layer, 
        /// the fields of the project are converted to EXTERNAL Units, which are the units used in the user interface,
        /// the resulting Project Dto is returned as a <see cref="ProjectUnitsDto"/> object.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve.</param>
        /// <returns>A <see cref="ProjectDto"/> representing the Project with the specified identifier. 
        /// Returns null if no Project is found.</returns>
        public ProjectDto GetProjectById(Guid projectId)
        {
            ProjectDto externalProject = new ProjectDto();
            try
            {
                //---------------------------------------------------------------------------
                //--- Retrieve Project Dto from the Database using the ProjectRepo Object ---
                //--- Retrieved Project Dto [INTERNAL Units]                              ---
                //---------------------------------------------------------------------------
                ProjectDto internalProject = ProjectRepoObj.GetProjectById(projectId);

                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalProject.Id = internalProject.Id;
                externalProject.Name = internalProject.Name;
                externalProject.Description = internalProject.Description;
                externalProject.DefaultOptimizer = internalProject.DefaultOptimizer;
                externalProject.CreationDate = internalProject.CreationDate;
                externalProject.ModifiedDate = internalProject.ModifiedDate;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project: {ex.Message}");
                return null; // Return null if an error occurs
            }

            return externalProject;
        }
        #endregion  // GetProjectById(Guid projectId) ... READ

        #region GetProjectByName(string projectName) ... READ
        /// <summary>
        /// Retrieves (READ) a Project by its name and returns its details as a data transfer object.
        /// </summary>
        /// <remarks>The returned ProjectDto contains project information with fields converted to
        /// EXTERNAL units where applicable. If an error occurs during retrieval, the method returns null.</remarks>
        /// <param name="projectName">The name of the project to retrieve. Cannot be null or empty.</param>
        /// <returns>A ProjectDto containing the project's details if found; otherwise, null.</returns>
        public ProjectDto GetProjectByName(string projectName)
        {
            try
            {
                //---------------------------------------------------------------------------
                //--- Retrieve Project Dto from the Database using the ProjectRepo Object ---
                //--- Retrieved Project Dto [INTERNAL Units]                              ---
                //---------------------------------------------------------------------------
                ProjectDto internalProject = ProjectRepoObj.GetProjectByName(projectName);

                //-----------------------------------------------------------------------
                //--- Project by Name NOT Found ... return null to indicate not found ---
                //-----------------------------------------------------------------------
                if (internalProject==null)
                {
                    return null; // Return null if the project is not found
                }

                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                ProjectDto externalProject = new ProjectDto();
                externalProject.Id = internalProject.Id;
                externalProject.Name = internalProject.Name;
                externalProject.Description = internalProject.Description;
                externalProject.DefaultOptimizer = internalProject.DefaultOptimizer;
                externalProject.CreationDate = internalProject.CreationDate;
                externalProject.ModifiedDate = internalProject.ModifiedDate;
                return externalProject;

            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project: {ex.Message}");
                return null; // Return null if an error occurs
            }
        }
        #endregion  // GetProjectByName(string projectName) ... READ

        #region UpdateProject(ProjectDto externalProjectDto) ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing project in the database using the specified project data transfer object (DTO) 
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
                internalProjectDto.DefaultOptimizer = externalProjectDto.DefaultOptimizer;
                internalProjectDto.CreationDate = externalProjectDto.CreationDate;
                internalProjectDto.ModifiedDate = externalProjectDto.ModifiedDate;
                //--------------------------------------------------------------------------------
                //--- UPDATE INTERNAL Project Dto to the Database using the ProjectRepo Object ---
                //--------------------------------------------------------------------------------
                ProjectRepoObj.UpdateProject(internalProjectDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project: {ex.Message}");
            }
        }
        #endregion  // UpdateProject(ProjectDto projectDto) ... UPDATE

        #region DeleteProject(Guid projectId) ... DELETE
        /// <summary>
        /// Deletes (DELETE) the project with the specified unique identifier.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project to delete.</param>
        public void DeleteProject(Guid projectId)
        {
            try
            {
                //--------------------------------------------------------------------
                //--- DELETE Project from the Database using the ProjectRep Object ---
                //--------------------------------------------------------------------
                ProjectRepoObj.DeleteProject(projectId);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error deleting project: {ex.Message}");
            }
        }
        #endregion  // DeleteProject(Guid projectId) ... DELETE

        #endregion  // PROJECT CRUD METHODS

    }
    #endregion      // public class ProjectViewModel

}
#endregion      // namespace HenViewModel.Project

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
