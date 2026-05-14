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
using HenModel.Dto.Profile.Streams;
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

        #region ConvertToExternalDto(ProjectDto internalDto)
        /// <summary>
        /// Converts a Project DTO from INTERNAL units to EXTERNAL units.
        /// </summary>
        /// <param name="internalDto">The Project DTO in INTERNAL units.</param>
        /// <returns>A <see cref="ProjectDto"/> DTO in EXTERNAL units.</returns>
        private ProjectDto ConvertToExternalDto(ProjectDto internalDto)
        {
            //-------------------------- Null DTO Guard ----------------------------
            //--- If the user provided DTO is null,                              ---
            //--- Then return null to indicate that there is nothing to convert. ---
            //--- This prevents potential null reference exceptions when trying  ---
            //--- to access properties of a null object.                         ---
            //----------------------------------------------------------------------
            if (internalDto == null)
            {
                return null;
            }
            //------------------------------ Create EXTERNAL DTO -----------------------------------
            //--- Create a new DTO object to hold the converted values in EXTERNAL units.        ---
            //--- This object will be populated with the converted values from the INTERNAL DTO. ---
            //--------------------------------------------------------------------------------------
            ProjectDto externalDto = new ProjectDto();
            //---------------------------------------------------------
            //--- Convert INTERNAL DTO Fields to EXTERNAL DTO Units ---
            //---------------------------------------------------------
            externalDto.Id               = internalDto.Id;
            externalDto.Name             = internalDto.Name;

            externalDto.Description      = internalDto.Description;
            externalDto.DefaultOptimizer = internalDto.DefaultOptimizer;
            externalDto.CreationDate     = internalDto.CreationDate;
            externalDto.ModifiedDate     = internalDto.ModifiedDate;
            //--------------------------------------------------
            //--- Return the EXTERNAL DTO in EXTERNAL units. ---
            //--------------------------------------------------
            return externalDto;
        }
        #endregion  // ConvertToExternalDto(ProjectDto internalDto)

        #region ConvertToInternalDto(ProjectDto externalDto)
        /// <summary>
        /// Converts a Project DTO from EXTERNAL units to INTERNAL units.
        /// </summary>
        /// <param name="externalDto">The Project DTO in EXTERNAL units.</param>
        /// <returns>A <see cref="ProjectDto"/> DTO in INTERNAL units.</returns>
        private ProjectDto ConvertToInternalDto(ProjectDto externalDto)
        {
            //-------------------------- Null DTO Guard ----------------------------
            //--- If the user provided DTO is null,                              ---
            //--- Then return null to indicate that there is nothing to convert. ---
            //--- This prevents potential null reference exceptions when trying  ---
            //--- to access properties of a null object.                         ---
            //----------------------------------------------------------------------
            if (externalDto == null)
            {
                return null;
            }
            //------------------------------ Create INTERNAL DTO -----------------------------------
            //--- Create a new DTO object to hold the converted values in INTERNAL units.        ---
            //--- This object will be populated with the converted values from the EXTERNAL DTO. ---
            //--------------------------------------------------------------------------------------
            ProjectDto internalDto = new ProjectDto();
            //-------------------------------------------------
            //--- Convert EXTERNAL Fields to INTERNAL Units ---
            //-------------------------------------------------
            internalDto.Id               = externalDto.Id;
            internalDto.Name             = externalDto.Name;

            internalDto.Description      = externalDto.Description;
            internalDto.DefaultOptimizer = externalDto.DefaultOptimizer;
            internalDto.CreationDate     = externalDto.CreationDate;
            internalDto.ModifiedDate     = externalDto.ModifiedDate;
            //--------------------------------------------------
            //--- Return the INTERNAL DTO in INTERNAL units. ---
            //--------------------------------------------------
            return internalDto;
        }
        #endregion  // ConvertToInternalDto(ProjectDto externalDto)

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
                internalProjectDto = ConvertToInternalDto(externalProjectDto);
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
                    externalProject = ConvertToExternalDto(internalProject);
                    //-----------------------------------------------------------------------------------------
                    //--- Add the EXTERNAL Project Dto to the List of Projects to be returned to the caller ---
                    //-----------------------------------------------------------------------------------------
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
            ProjectDto externalProjectDto = new ProjectDto();
            try
            {
                //---------------------- Guard against empty or null projectId ------------------------
                //--- If the provided projectId is empty, return null to indicate that there is no  ---
                //--- valid project to retrieve.                                                    ---
                //--- This prevents unnecessary database calls and potential errors when trying to  ---
                //--- retrieve a project with an invalid identifier.                                ---
                //--- An empty projectId is not valid for retrieval, so we return null to indicate  ---
                //---that the project cannot be found.                                              ---
                //-------------------------------------------------------------------------------------
                if (projectId == Guid.Empty)
                {
                    return null; // Return null if the projectId is empty
                }
                //---------------------------------------------------------------------------
                //--- Retrieve Project Dto from the Database using the ProjectRepo Object ---
                //--- Retrieved Project Dto [INTERNAL Units]                              ---
                //---------------------------------------------------------------------------
                ProjectDto internalProjectDto = ProjectRepoObj.GetProjectById(projectId);
                //-----------------------------------------------------------------------
                //--- Project by Name NOT Found ... return null to indicate not found ---
                //-----------------------------------------------------------------------
                if (internalProjectDto == null)
                {
                    return null; // Return null if the project is not found
                }
                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalProjectDto = ConvertToExternalDto(internalProjectDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project: {ex.Message}");
                return null; // Return null if an error occurs
            }
            //--------------------------------------------------------------
            //--- Return the Project Dto in EXTERNAL Units to the caller ---
            //--------------------------------------------------------------
            return externalProjectDto;
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
                //----------------------------------------
                //--- Empty or Null Project Name Guard ---
                //----------------------------------------
                if (string.IsNullOrEmpty(projectName))
                {
                    return null; // Return null if the project name is null or empty
                }
                //---------------------------------------------------------------------------
                //--- Retrieve Project Dto from the Database using the ProjectRepo Object ---
                //--- Retrieved Project Dto [INTERNAL Units]                              ---
                //---------------------------------------------------------------------------
                ProjectDto internalProjectDto = ProjectRepoObj.GetProjectByName(projectName);
                //-----------------------------------------------------------------------
                //--- Project by Name NOT Found ... return null to indicate not found ---
                //-----------------------------------------------------------------------
                if (internalProjectDto == null)
                {
                    return null; // Return null if the project is not found
                }
                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                ProjectDto externalProjectDto = ConvertToExternalDto(internalProjectDto);
                //--------------------------------------------------------------
                //--- Return the Project Dto in EXTERNAL Units to the caller ---
                //--------------------------------------------------------------
                return externalProjectDto;
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
                //--- Convert EXTERNAL Fields to INTERNAL Units                ---
                //----------------------------------------------------------------
                ProjectDto internalProjectDto = ConvertToInternalDto(externalProjectDto);
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
