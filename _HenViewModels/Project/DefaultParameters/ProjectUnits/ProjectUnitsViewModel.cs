#region HEADER
//#####################################################################################################################
//#################################  P r o j e c t U n i t s V i e w M o d e l . c s  #################################
//#####################################################################################################################
//  FILENAME:  ProjectUnitsViewModel.cs
//  NAMESPACE: HenViewModel.Project.DefaultParameters.ProjectUnits
//  CLASS(S):  ProjectUnitsViewModel
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the Project Units DTO.
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
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;
using HenModel.RepoImplementations.Project.DefaultParameters.ProjectUnits;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenViewModel.Project.DefaultParameters.ProjectUnits
namespace HenViewModel.Project.DefaultParameters.ProjectUnits
{
    #region public class ProjectUnitsViewModel
    /// <summary>
    /// Project Units View Model class.
    /// </summary>
    public class ProjectUnitsViewModel : ViewModelBase
    {
        #region PROPERTIES
        public ProjectUnitsRepo ProjectUnitsRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region DEFAULT CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public ProjectUnitsViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var projectUnitsRepoObj = new ProjectUnitsRepo(connFactoryObj);

            ProjectUnitsRepoObj = projectUnitsRepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // DEFAULT CTOR

        #region PRIVATE DTO CONVERSION METHODS

        #region ConvertToExternalDto(ProjectUnitsDto internalDto)
        /// <summary>
        /// Converts a Project Units DTO from INTERNAL units to EXTERNAL units.
        /// </summary>
        /// <param name="internalDto">The Project Units DTO in INTERNAL units.</param>
        /// <returns>A <see cref="ProjectUnitsDto"/> DTO in EXTERNAL units.</returns>
        private ProjectUnitsDto ConvertToExternalDto(ProjectUnitsDto internalDto)
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
            ProjectUnitsDto externalDto = new ProjectUnitsDto();
            //---------------------------------------------------------
            //--- Convert INTERNAL DTO Fields to EXTERNAL DTO Units ---
            //---------------------------------------------------------
            externalDto.Id = internalDto.Id;
            externalDto.ProjectId = internalDto.ProjectId;

            externalDto.DefaultSystemUnits      = internalDto.DefaultSystemUnits;
            externalDto.DefaultMagnitudeUnits   = internalDto.DefaultMagnitudeUnits;
            externalDto.DefaultTemperatureUnits = internalDto.DefaultTemperatureUnits;
            externalDto.DefaultPressureUnits    = internalDto.DefaultPressureUnits;
            //--------------------------------------------------
            //--- Return the EXTERNAL DTO in EXTERNAL units. ---
            //--------------------------------------------------
            return externalDto;
        }
        #endregion  // ConvertToExternalDto(ProjectUnitsDto internalDto)

        #region ConvertToInternalDto(ProjectUnitsDto externalDto)
        /// <summary>
        /// Converts a Project DTO from EXTERNAL units to INTERNAL units.
        /// </summary>
        /// <param name="externalDto">The Project Units DTO in EXTERNAL units.</param>
        /// <returns>A <see cref="ProjectUnitsDto"/> DTO in INTERNAL units.</returns>
        private ProjectUnitsDto ConvertToInternalDto(ProjectUnitsDto externalDto)
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
            ProjectUnitsDto internalDto = new ProjectUnitsDto();
            //-------------------------------------------------
            //--- Convert EXTERNAL Fields to INTERNAL Units ---
            //-------------------------------------------------
            internalDto.Id = externalDto.Id;
            internalDto.ProjectId = externalDto.ProjectId;

            internalDto.DefaultSystemUnits      = externalDto.DefaultSystemUnits;
            internalDto.DefaultMagnitudeUnits   = externalDto.DefaultMagnitudeUnits;
            internalDto.DefaultTemperatureUnits = externalDto.DefaultTemperatureUnits;
            internalDto.DefaultPressureUnits    = externalDto.DefaultPressureUnits;
            //--------------------------------------------------
            //--- Return the INTERNAL DTO in INTERNAL units. ---
            //--------------------------------------------------
            return internalDto;
        }
        #endregion  // ConvertToInternalDto(ProjectUnitsDto externalDto)

        #endregion  // PRIVATE DTO CONVERSION METHODS

        #region PROJECT UNITS CRUD METHODS

        #region AddProjectUnits(ProjectUnitsDto externalProjectUnitsDto) ... CREATE
        /// <summary>
        /// Adds (CREATE) a new project units to the database using the specified project data transfer object.
        /// </summary>
        /// <remarks>The method converts the provided project data from external to internal units before
        /// storing it in the database. If an error occurs during the operation, the method logs the error and returns
        /// an empty GUID.</remarks>
        /// <param name="externalProjectUnitsDto">The project units data to add. The object must contain all 
        /// required project units fields in external units. Cannot be null.</param>
        /// <returns>A GUID representing the unique identifier of the newly added project.</returns>
        public Guid AddProjectUnits(ProjectUnitsDto externalProjectUnitsDto)
        {
            Guid projectUnitsID = new Guid();
            try
            {
                //---------------------------------------------------------------------
                //--- ProjectUnits Dto [INTERNAL Units] to be Added to the Database ---
                //---------------------------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units                     ---
                //---------------------------------------------------------------------
                ProjectUnitsDto internalProjectUnitsDto = ConvertToInternalDto(externalProjectUnitsDto);
                //----------------------------------------------------------------------------------------
                //--- Add INTERNAL ProjectUnits Dto to the Database using the ProjectUnitsRepo Object  ---
                //--- Returns the ProjectUnits ID (PK) from the ProjectUnits Table database addition   ---
                //----------------------------------------------------------------------------------------
                projectUnitsID = ProjectUnitsRepoObj.AddProjectUnits(internalProjectUnitsDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project units: {ex.Message}");
            }
            //---------------------------------------------------------------------------------------
            //--- Return the ProjectUnits ID (PK) from the ProjectUnits Table database addition   ---
            //---------------------------------------------------------------------------------------
            //--- If an error occurs, the returned GUID will be empty (default value) to          ---
            //--- indicate failure.                                                               ---
            //--- If the operation is successful, the returned GUID will be the unique identifier ---
            //--- The caller can check for an empty GUID to determine if the operation was        ---
            //--- successful or if an error occurred.                                             ---
            //---------------------------------------------------------------------------------------
            return projectUnitsID;
        }
        #endregion  // AddProjectUnits(ProjectUnitsDto externalProjectUnitsDto) ... CREATE

        #region GetProjectUnitsByProjectId(Guid projectId) ... READ
        /// <summary>
        /// Retrieves (READ) the Project Units Dto associated with the specified unique identifier.
        /// The project retrieved from the Database is in INTERNAL Units, 
        /// database access performed by the repository layer, 
        /// the fields of the project are converted to EXTERNAL Units, which are the units used in the user interface,
        /// the resulting Project Dto is returned as a <see cref="ProjectUnitsDto"/> object.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve.</param>
        /// <returns>A <see cref="ProjectUnitsDto"/> representing the Project with the specified identifier. 
        /// Returns null if no Project is found.</returns>
        public ProjectUnitsDto GetProjectUnitsByProjectId(Guid projectId)
        {
            ProjectUnitsDto externalProjectUnitsDto = new ProjectUnitsDto();
            try
            {
                //---------------------- Guard against empty or null projectId ------------------------
                //--- If the provided projectId is empty, return null to indicate that there is no  ---
                //--- valid project units to retrieve.                                              ---
                //--- This prevents unnecessary database calls and potential errors when trying to  ---
                //--- retrieve project units with an invalid identifier.                            ---
                //--- An empty projectId is not valid for retrieval, so we return null to indicate  ---
                //---that the project units cannot be found.                                        ---
                //-------------------------------------------------------------------------------------
                if (projectId == Guid.Empty)
                {
                    return null; // Return null if the projectId is empty
                }
                //------------------------------------------------------------------------------------------------------
                //--- Retrieve Project Units Dto from the Database using the Repository layer                        ---
                //--- The retrieved Project Units Dto is in INTERNAL Units, which are the units used in the database ---
                //------------------------------------------------------------------------------------------------------
                ProjectUnitsDto internalProjectUnitsDto = ProjectUnitsRepoObj.GetProjectUnitsByProjectId(projectId);
                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalProjectUnitsDto = ConvertToExternalDto(internalProjectUnitsDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project units: {ex.Message}");
                return null; // Return null if an error occurs
            }
            //-------------------------------------------------------------------------------------------
            //--- Return the Project Units Dto in EXTERNAL Units to the caller (e.g., user interface) ---
            //--- If the project is not found, the returned DTO will be null to indicate that there   ---
            //--- is no project with the specified ID.                                                ---
            //--- If the operation is successful, the returned DTO will contain the project units     ---
            //--- information in EXTERNAL units.                                                      ---
            //-------------------------------------------------------------------------------------------
            return externalProjectUnitsDto;
        }
        #endregion  // GetProjectUnitsByProjectId(Guid projectId) ... READ

        #region UpdateProjectUnits(ProjectUnitsDto externalProjectUnitsDto) ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing project units in the database using the 
        /// specified project units data transfer object (DTO) with external units.
        /// </summary>
        /// <remarks>This method converts the provided project units data from external units to the internal
        /// units required by the database before updating the project units. If the specified project units does not exist,
        /// the behavior depends on the repository implementation.</remarks>
        /// <param name="externalProjectUnitsDto">The project units data transfer object containing updated project units 
        /// information in external units. Cannot be null.</param>
        public void UpdateProjectUnits(ProjectUnitsDto externalProjectUnitsDto)
        {
            try
            {
                //----------------------------------------------------------------------
                //--- Project Units Dto [INTERNAL Units] to be Added to the Database ---
                //----------------------------------------------------------------------
                ProjectUnitsDto internalProjectUnitsDto = new ProjectUnitsDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalProjectUnitsDto = ConvertToInternalDto(externalProjectUnitsDto);
                //-------------------------------------------------------------------------------------------
                //--- UPDATE INTERNAL Project Units Dto to the Database using the ProjectUnitsRepo Object ---
                //-------------------------------------------------------------------------------------------
                ProjectUnitsRepoObj.UpdateProjectUnits(internalProjectUnitsDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error updating project units: {ex.Message}");
            }
        }
        #endregion  // UpdateProjectUnits(ProjectDto projectDto) ... UPDATE

        #region DeleteProjectUnits(Guid projectUnitsId) ... DELETE
        /// <summary>
        /// Deletes (DELETE) the project units with the specified unique identifier.
        /// </summary>
        /// <param name="projectUnitsId">The unique identifier of the project units to delete.</param>
        public void DeleteProjectUnits(Guid projectUnitsId)
        {
            try
            {
                //--------------------------------------------------------------------------------
                //--- DELETE Project Units from the Database using the ProjectUnitsRepo Object ---
                //--------------------------------------------------------------------------------
                ProjectUnitsRepoObj.DeleteProjectUnits(projectUnitsId);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error deleting project units: {ex.Message}");
            }
        }
        #endregion  // DeleteProjectUnits(Guid projectUnitsId) ... DELETE

        #endregion  // PROJECT UNITS CRUD METHODS
    }
    #endregion      // public class ProjectUnitsViewModel

}
#endregion      // namespace HenViewModel.Project.DefaultParameters.ProjectUnits

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
