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
        public HenProjectUnits ExternalUnitsObj { get; set; }
        public HenProjectUnits InternalUnitsObj { get; set; }
        public ProjectDto Project { get; set; }
        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public ProjectViewModel(HenProjectUnits EXTERNAL_UnitsObj,
                                HenProjectUnits INTERNAL_UnitsObj) 
        {
            ExternalUnitsObj = EXTERNAL_UnitsObj;
            InternalUnitsObj = INTERNAL_UnitsObj;
        }
        #endregion  // CTOR

        #region ConvertToExternalU()
        /// <summary>
        /// Conver the Het Transfer Coefficient (U) value from INTERNAL Units to EXTERNAL Units.
        /// </summary>
        /// <param name="internalValueU"></param>
        /// <returns>Heat Transfer Coefficient (U) in EXTERNAL Units on Success; 0.0 otherwise</returns>
        private double ConvertToExternalU(double internalValueU)
        {
            double valueInExternalUnits = 0.0;
             valueInExternalUnits = ConvertFromInternal(HenGlobal.HenTypes.ConversionUnitsTypes.U, 
                                                        internalValueU, 
                                                        ExternalUnitsObj, 
                                                        InternalUnitsObj);
            return valueInExternalUnits; 
        }
        #endregion  // ConvertToExternalU()

        /// <summary>
        /// Retrieves a list of all projects in EXTERNAL Units.
        /// Database access is performed by the repository layer, and the results are returned as a 
        /// list of <see cref="ProjectDto"/> objects in INTERNAL Units.
        /// </summary>
        /// <returns>A list of <see cref="ProjectDto"/> objects in EXTERNAL Units
        /// representing the available projects. The list is empty if no
        /// projects are found.</returns>
        public IList<ProjectDto> GetProjects()
        {
            return new List<ProjectDto>();
        }

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
                ProjectDto internalProject = GetProjectById(projectId);     // Retrieved Project Dto [INTERNAL Units]

                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalProject.Id = internalProject.Id;
                externalProject.Name = internalProject.Name;
                externalProject.Description = internalProject.Description;

                externalProject.DefaultHeatTransferCoefficient = internalProject.DefaultHeatTransferCoefficient; // Convert to EXTERNAL Units
                
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
    }
    #endregion      // public class ProjectViewModel

}
#endregion      // namespace HenViewModels

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
