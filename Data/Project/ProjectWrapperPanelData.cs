#region HEADER
//#####################################################################################################################
//###############################  P r o j e c t W r a p p e r P a n e l D a t a . c s  ###############################
//#####################################################################################################################
//  FILENAME:  ProjectWrapperPanelData.cs
//  NAMESPACE: HenStudio.Data.Project
//  CLASS(S):  ProjectWrapperPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the Data class for the Project Wrapper Panel Data Object.
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

#region HEN STUDIO REFERENCES

using HenGlobal;

using HenViewModel.Project;
using HenViewModel.Project.CostParameters;
using HenViewModel.Project.DefaultParameters;
using HenViewModel.Project.DefaultParameters.ExchangerParams;
using HenViewModel.Project.DefaultParameters.OptimizerParams;
using HenViewModel.Project.DefaultParameters.ProjectUnits;

using HenModel.Dto.Project;
using HenModel.Dto.Project.CostParameters;
using HenModel.Dto.Project.DefaultParameters;
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;
using HenModel.Dto.Profile.Streams;

#endregion  // HEN STUDIO REFERENCES

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

#endregion      // REFERENCES

#region HenStudio.Data.Project
namespace HenStudio.Data.Project
{
    #region public class ProjectWrapperPanelData
    /// <summary>
    /// Project Wrapper Data Class
    /// </summary>
    public class ProjectWrapperPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project";
        const string CLASS = "ProjectWrapperPanelData";
        #endregion  // CONSTANTS

        #region PROPERTIES

        #region ProjectWrapperDto OBJECT
        ProjectWrapperDto ProjectWrapperDtoObj { get; set; } = new ProjectWrapperDto();
        #endregion  // ProjectWrapperDto OBJECT

        #region Project Wrapper ViewModel OBJECT
        ProjectWrapperViewModel ProjectWrapperViewModelObj {  get; set; }
        #endregion  // Project Wrapper ViewModel OBJECT

        #region HenProjectUnits OBJECT
        //------------------------------------------------------------------------
        //--- HenProjectUnits Holds PROJECT Units Data (INTERNAL & EXTERNAL)   ---
        //------------------------------------------------------------------------
        //--- Object contains methods to retrieve the following PROJECT UNITS: ---
        //--- SystemUnits, MagnitudeUnits, AreaUnits, TemperatureUnits,        ---
        //--- PressureUnits, HeatFlowRateUnits, HeatCapacityFlowRateUnits,     ---
        //--- Overall HeatTransferCoefficientUnits                             ---
        //------------------------------------------------------------------------
        public HenProjectUnits HenProjectUnitsObj { get; set; } = new HenProjectUnits();
        #endregion  // HenProjectUnits OBJECT

        #endregion      // PROPERTIES

        #region Parameterized CTOR
        /// <summary>
        /// Parameterized Constructor for ProjectWrapperData Class
        /// Project Wrapper DTO MUST contain ProjectDbName
        /// </summary>
        /// <param name="strProjectDbNameOnly">Project Db Name... NO ".db" extension</param>
        public ProjectWrapperPanelData(string strProjectDbNameOnly)
        {
            if (strProjectDbNameOnly == string.Empty) throw new ArgumentNullException(
               nameof(strProjectDbNameOnly),
               "Project DB Name can not be empty");

            ProjectWrapperDtoObj = new ProjectWrapperDto();
            ProjectWrapperViewModelObj = new ProjectWrapperViewModel(strProjectDbNameOnly);
            HenProjectUnitsObj = new HenProjectUnits();
        }
        #endregion  // Parameterized CTOR

        #region CRUD METHODS

        #region --> CREATE ... AddProjectWrapperData(ProjectWrapperDto projecteWrapperDtoObj)
        /// <summary>
        /// Add (CREATE) the Project data contained in the WRAPPER DTO to the SQLite PROJECT DB
        /// Returns Project WRAPPER DTO object; contains Project Id associated with added data
        /// ---------------------------------------------------------------------------------------
        /// -------------------------------------- USE CASE ---------------------------------------
        /// ---------------------------------------------------------------------------------------
        ///   1. User scrapes Control contents and assigns the DTO objects in WRAPPER DTO
        ///   2. User assigns Project Database name in WRAPPER DTO
        ///   3. User invokes this method, passing in the fully populated WRAPPER DTO object
        ///   4. Method invokes Wrapper ViewModel passing in the WRAPPER DTO object
        ///   5. Wrapper ViewModel ADDs all the Project Data, and returns the unique Project Id
        ///   6. Method ensures Project Id is assigned to WRAPPER DTO
        ///   7. Method returns the WRAPPER DTO object
        /// ---------------------------------------------------------------------------------------
        /// </summary>
        /// <returns>Project WRAPPER DTO object containing the newly created project-related data,
        /// also include Project DB Name and Project Id, on success; null otherwise.</returns>
        /// <exception cref="ArgumentNullException">Check for Null Project Wrapper Dto Object</exception>
        public ProjectWrapperDto AddProjectWrapperData(ProjectWrapperDto projectWrapperDtoObj)
        {
            string strMethod = "AddProjectWrapperData";

            if (projectWrapperDtoObj == null) throw new ArgumentNullException(
                                        nameof(projectWrapperDtoObj),
                                        "Project Wrapper DTO can not be null");

            if (projectWrapperDtoObj.ProjectDbName == string.Empty) throw new ArgumentNullException(
                                       nameof(projectWrapperDtoObj.ProjectDbName),
                                       "Project DB Name can not be empty");
            try
            {
                //-------------------------------------------------------------------
                //--- Project Wrapper ViewModel CreateProjectWrapperData() Method ---
                //------------------------------------------------------------------- 
                ProjectWrapperDtoObj = ProjectWrapperViewModelObj.CreateProjectWrapperData(
                                       projectWrapperDtoObj);
            }
            catch (Exception ex)
            {
                //---------------------
                //--- Log Exception ---
                //---------------------
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            //-----------------------------------------------------------------
            //--- Return Project Wrapper DTO Object ... contains Project ID ---
            //-----------------------------------------------------------------
            return ProjectWrapperDtoObj;
        }
        #endregion  // --> CREATE ... AddProjectWrapperData(ProjectWrapperDto projecteWrapperDtoObj)

        #region --> READ ..... GetProjectWrapperData(int projectId)
        /// <summary>
        /// Get (READ) the Project data associated with the user supplied Project Id
        /// Returns a populated Project WRAPPER DTO object.
        /// ---------------------------------------------------------------------------------------
        /// -------------------------------------- USE CASE ---------------------------------------
        /// ---------------------------------------------------------------------------------------
        ///   1. User invokes this method, passing in the Project Id
        ///   2  Method ensures Project Id is assigned to Project WRAPPER DTO object Property
        ///   2. Method invokes Wrapper ViewModel passing in the Project Id
        ///   3. Wrapper ViewModel GETs all the Project Data and populates the Project WRAPPER DTO
        ///   4. Method assigns the Project WRAPPER DTO property with the DTO returned
        ///   5. Method returns the WRAPPER DTO object
        /// ---------------------------------------------------------------------------------------
        /// </summary>
        /// <param name="projectId">Unique Project Id</param>
        /// <returns>Project WRAPPER DTO object containing the newly created project-related data,
        /// also include Project DB Name and Project Id, on success; null otherwise.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ProjectWrapperDto GetProjectWrapperData(int projectId)
        {
            string strMethod = "GetProjectWrapperData";

            if (projectId == -1) throw new ArgumentNullException(
                                       nameof(projectId), 
                                       "Project ID cannot be -1.");
            try
            {
                //---------------------------------
                //--- Assign WRAPPER Project ID ---
                //---------------------------------
                ProjectWrapperDtoObj.ProjectId = projectId;
                
                //-----------------------------------------------------------------
                //--- Project Wrapper ViewModel ReadProjectWrapperData() Method ---
                //----------------------------------------------------------------- 
                ProjectWrapperDtoObj = ProjectWrapperViewModelObj.ReadProjectWrapperData(projectId);
            }
            catch (Exception ex)
            {
                //---------------------
                //--- Log Exception ---
                //---------------------
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            //--------------------------------------------
            //--- Return Populated Project WRAPPER DTO ---
            //--------------------------------------------
            return ProjectWrapperDtoObj;
        }
        #endregion  // --> READ ..... ReadProjectWrapperData(int projectId)

        #region --> UPDATE ... ModifyProjectWrapperData(ProjectWrapperDto projecteWrapperDtoObj)
        /// <summary>
        /// Modify (UPDATE) the Project data associated with the user supplied Project Id
        /// Returns a populated Project WRAPPER DTO object.
        /// NOTE: The Project ID used is assigned in the Project WRAPPER DTO Object
        /// ---------------------------------------------------------------------------------------
        /// -------------------------------------- USE CASE ---------------------------------------
        /// ---------------------------------------------------------------------------------------
        ///   1. User scrapes the Controls, assigns Project Data to Project WRAPPER DTO Object
        ///   2. User invokes this method, passing in the populated Project WRAPPER DTO Object
        ///   3. Method assigns the Project WRAPPER DTO Property
        ///   4. Method invokes Wrapper ViewModel passing in the Project WRAPPER DTO Object
        ///   5. Wrapper ViewModel MODIFIES all the Project Data 
        ///   6. Method returns void
        /// ---------------------------------------------------------------------------------------
        /// </summary>
        /// <param name="projecteWrapperDtoObj">Project WRAPPER DTO object containing data to update.</param>
        /// <returns>Project WRAPPER DTO including data updated</returns>
        public void ModifyProjectWrapperData(ProjectWrapperDto projectWrapperDtoObj)
        {
            string strMethod = "ModifyProjectWrapperData";

            if (projectWrapperDtoObj == null) throw new ArgumentNullException(
                                        nameof(projectWrapperDtoObj), 
                                        "Project Wrapper DTO cannot be null.");
            
            if (projectWrapperDtoObj.ProjectId == -1) throw new ArgumentNullException(
                                        nameof(projectWrapperDtoObj.ProjectId),
                                        "Project ID cannot be -1.");
            try
            {
                //--------------------------------------------------
                //--- Assign Project WRAPPER DTO Object Property ---
                //--------------------------------------------------
                ProjectWrapperDtoObj = projectWrapperDtoObj;

                //-------------------------------------------------------------------
                //--- Project Wrapper ViewModel UpdateProjectWrapperData() Method ---
                //------------------------------------------------------------------- 
                ProjectWrapperViewModelObj.UpdateProjectWrapperData(projectWrapperDtoObj);
            }
            catch (Exception ex)
            {
                //---------------------
                //--- Log Exception ---
                //---------------------
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
        }
        #endregion  // --> UPDATE ... ModifyProjectWrapperData(ProjectWrapperDto projecteWrapperDtoObj)

        #region --> DELETE ... DeleteProjectWrapperData(Guid projectId)
        /// <summary>
        /// Delete (DELETE) the Project data associated with the user supplied Project Id
        /// Returns void.
        /// ---------------------------------------------------------------------------------------
        /// -------------------------------------- USE CASE ---------------------------------------
        /// ---------------------------------------------------------------------------------------
        ///   1. User invokes this method, passing in the Project Id
        ///   2. Method assigns the Project Id in the Project WRAPPER DTO Property
        ///   3. Method invokes Wrapper ViewModel passing in the Project Id
        ///   4. Wrapper ViewModel DELETES all the Project Data associated with the Project Id 
        ///   5. Method returns void
        /// ---------------------------------------------------------------------------------------
        /// NOTE: Cascading Delete is Controlled in SQL.
        /// </summary>
        /// <param name="projectId">The ID of the project-related data to DELETE.</param>
        public void DeleteProjectWrapperData(int projectId)
        {
            string strMethod = "DeleteProjectWrapperData";

            if (projectId == -1) throw new ArgumentNullException(
                                       nameof(projectId), 
                                       "Project ID cannot be -1.");
            try
            {
                //--------------------------------------------------------------------
                //--- Assign Project Id in the Project WRAPPER DTO Object Property ---
                //--------------------------------------------------------------------
                ProjectWrapperDtoObj.ProjectId = projectId;

                //-------------------------------------------------------------------
                //--- Project Wrapper ViewModel DeleteProjectWrapperData() Method ---
                //-------------------------------------------------------------------
                ProjectWrapperViewModelObj.DeleteProjectWrapperData(projectId);
            }
            catch (Exception ex)
            {
                //---------------------
                //--- Log Exception ---
                //---------------------
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
        }
        #endregion  // --> DELETE ... DeleteProjectWrapperData(Guid projectId)

        #endregion  // CRUD METHODS
    }
    #endregion      // public class ProjectWrapperPanelData
}
#endregion      // namespace HenStudio.Data.Project

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
