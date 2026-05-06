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

        #region GetProjectUnitsByProjectId(Guid projectId)
        /// <summary>
        /// Retrieves the Project Dto associated with the specified unique identifier.
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
                //-------------------------------------------------------------------------
                //--- Retrieve Project Dto from the Database using the Repository layer ---
                //-------------------------------------------------------------------------
                ProjectUnitsDto internalProjectUnits = ProjectUnitsRepoObj.GetProjectUnitsByProjectId(projectId);     // Retrieved Project Dto [INTERNAL Units]

                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalProjectUnitsDto.Id = internalProjectUnits.Id;
                externalProjectUnitsDto.ProjectId = internalProjectUnits.ProjectId;
                externalProjectUnitsDto.DefaultSystemUnits = internalProjectUnits.DefaultSystemUnits;
                externalProjectUnitsDto.DefaultMagnitudeUnits = internalProjectUnits.DefaultMagnitudeUnits;
                externalProjectUnitsDto.DefaultTemperatureUnits = internalProjectUnits.DefaultTemperatureUnits;
                externalProjectUnitsDto.DefaultPressureUnits = internalProjectUnits.DefaultPressureUnits;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project units: {ex.Message}");
                return null; // Return null if an error occurs
            }

            return externalProjectUnitsDto;
        }
        #endregion  // GetProjectUnitsByProjectId(Guid projectId)

        #region AddProjectUnits(ProjectUnitsDto externalProjectUnitsDto)
        /// <summary>
        /// Adds a new project units to the database using the specified project data transfer object.
        /// </summary>
        /// <remarks>The method converts the provided project data from external to internal units before
        /// storing it in the database. If an error occurs during the operation, the method logs the error and returns
        /// an empty GUID.</remarks>
        /// <param name="externalProjectUnitsDto">The project units data to add. The object must contain all required project units fields in external units. Cannot be
        /// null.</param>
        /// <returns>A GUID representing the unique identifier of the newly added project.</returns>
        public Guid AddProjectUnits(ProjectUnitsDto externalProjectUnitsDto)
        {
            Guid projectUnitsID = new Guid();
            try
            {
                //----------------------------------------------------------------
                //--- Project Dto [INTERNAL Units] to be Added to the Database ---
                //----------------------------------------------------------------
                ProjectUnitsDto internalProjectUnitsDto = new ProjectUnitsDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalProjectUnitsDto.Id = externalProjectUnitsDto.Id;
                internalProjectUnitsDto.ProjectId = externalProjectUnitsDto.ProjectId;
                internalProjectUnitsDto.DefaultSystemUnits = externalProjectUnitsDto.DefaultSystemUnits;
                internalProjectUnitsDto.DefaultMagnitudeUnits = externalProjectUnitsDto.DefaultMagnitudeUnits;
                internalProjectUnitsDto.DefaultTemperatureUnits = externalProjectUnitsDto.DefaultTemperatureUnits;
                internalProjectUnitsDto.DefaultPressureUnits = externalProjectUnitsDto.DefaultPressureUnits;
                //----------------------------------------------------------------------------
                //--- Add INTERNAL Project Dto to the Database using the Repository Layer  ---
                //--- Returns the Project ID (PK) from the Project Table database addition ---
                //----------------------------------------------------------------------------
                projectUnitsID = ProjectUnitsRepoObj.AddProjectUnits(internalProjectUnitsDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving project units: {ex.Message}");
            }
            return projectUnitsID; // Return Project ID (PK) from the Project Table database addition
        }
        #endregion  // AddProject(ProjectDto externalProjectDto)

        #region UpdateProjectUnits(ProjectUnitsDto externalProjectUnitsDto)
        /// <summary>
        /// Updates an existing project in the database using the specified project data transfer object (DTO) 
        /// with external units.
        /// </summary>
        /// <remarks>This method converts the provided project data from external units to the internal
        /// units required by the database before updating the project. If the specified project does not exist,
        /// the behavior depends on the repository implementation.</remarks>
        /// <param name="externalProjectDto">The project data transfer object containing updated project 
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
                internalProjectUnitsDto.Id = externalProjectUnitsDto.Id;
                internalProjectUnitsDto.ProjectId = externalProjectUnitsDto.ProjectId;
                internalProjectUnitsDto.DefaultSystemUnits = externalProjectUnitsDto.DefaultSystemUnits;
                internalProjectUnitsDto.DefaultMagnitudeUnits = externalProjectUnitsDto.DefaultMagnitudeUnits;
                internalProjectUnitsDto.DefaultTemperatureUnits = externalProjectUnitsDto.DefaultTemperatureUnits;
                internalProjectUnitsDto.DefaultPressureUnits = externalProjectUnitsDto.DefaultPressureUnits;
                //------------------------------------------------------------------------------
                //--- UPDATE INTERNAL Project Dto to the Database using the Repository Layer ---
                //------------------------------------------------------------------------------
                ProjectUnitsRepoObj.UpdateProjectUnits(internalProjectUnitsDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error updating project units: {ex.Message}");
            }
        }
        #endregion  // UpdateProjectUnits(ProjectDto projectDto)

        #region DeleteProjectUnits(Guid projectUnitsId)
        /// <summary>
        /// Deletes the project units with the specified unique identifier.
        /// </summary>
        /// <param name="projectUnitsId">The unique identifier of the project units to delete.</param>
        public void DeleteProjectUnits(Guid projectUnitsId)
        {
            try
            {
                //-------------------------------------------------------------------
                //--- DELETE Project Units from the Database using the Repository Layer ---
                //-------------------------------------------------------------------
                ProjectUnitsRepoObj.DeleteProjectUnits(projectUnitsId);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error deleting project units: {ex.Message}");
            }
        }
        #endregion  // DeleteProjectUnits(Guid projectUnitsId)

    }
    #endregion      // public class ProjectUnitsViewModel

}
#endregion      // namespace HenViewModel.Project.DefaultParameters.ProjectUnits

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
