#region HEADER
//#####################################################################################################################
//###############################  P r o j e c t W r a p p e r V i e w M o d e l . c s  ###############################
//#####################################################################################################################
//  FILENAME:  ProjectWrapperViewModel.cs
//  NAMESPACE: HenViewModel.Project
//  CLASS(S):  ProjectWrapperViewModel
//  COMPONENT: HenModel.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the Data class for the Project Wrapper View Model Object.
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

using HenModel.Dto.Project;
using HenModel.Dto.Project.CostParameters;
using HenModel.Dto.Project.DefaultParameters;
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

using HenModel.Dto.Profile;
using HenModel.Dto.Profile.Streams;

using HenViewModel.Project;
using HenViewModel.Project.CostParameters;
using HenViewModel.Project.DefaultParameters;
using HenViewModel.Project.DefaultParameters.ExchangerParams;
using HenViewModel.Project.DefaultParameters.OptimizerParams;
using HenViewModel.Project.DefaultParameters.ProjectUnits;
#endregion  // HEN STUDIO REFERENCES

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Linq;

using HenModel.Connection;
using HenModel.RepoInterfaces.Project.DefaultParameters.ExchangerParams;

#endregion      // REFERENCES

#region HenViewModel.Project
namespace HenViewModel.Project
{
    #region public class ProjectWrapperViewModel
    /// <summary>
    /// Project Wrapper View Model Class
    /// </summary>
    public class ProjectWrapperViewModel : ViewModelBase
    {
        #region CONSTANTS
        const string NAMESPACE = "HenViewModel.Project";
        const string CLASS = "ProjectWrapperViewModel";
        #endregion  // CONSTANTS

        #region PROPERTIES

        #region PROJECT Database Name
        string ProjectDbName { get; set; } = string.Empty;
        #endregion  // PROJECT Database Name

        #region ProjectWrapperDto OBJECT
        //-----------------------------------------------------------------------------
        //--- ProjectWrapperPanelData Object contains all the IDs, and DTO Objects, ---
        //--- for the Project Wrapper Panel. [INTRA-VIEW LAYER]                     ---
        //-----------------------------------------------------------------------------
        //--- Project panel data is passed between Controls and this Wrapper Dto.   ---
        //-----------------------------------------------------------------------------
        ProjectWrapperDto ProjectWrapperDtoObj { get; set; } = new ProjectWrapperDto();
        #endregion  // ProjectWrapperDto OBJECT

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

        #region SUB-Panel ViewModel OBJECTS
        //----------------------------------------------- Project Sub-Panel ---
        public ProjectViewModel ProjectViewModelObj { get; set; }

        //------------------------------- Project Default Params Sub-Panels ---
        public ProjectUnitsViewModel ProjectUnitsViewModelObj { get; set; }
        public ExchangerParamsViewModel ExchangerParamsViewModelObj { get; set; }
        public HeatTransferCoeffViewModel HeatTransferCoeffViewModelObj { get; set; }
        public OptimizerParamsViewModel OptimizerParamsViewModelObj { get; set; }

        //---------------------------------- Project Cost Params Sub-Panels ---
        public CostMetadataViewModel CostMetadataViewModelObj { get; set; }
        public FiredHeaterCapitalCostViewModel FiredHeaterCapitalCostViewModelObj { get; set; }
        public ShellAndTubeCapitalCostViewModel ShellAndTubeCapitalCostViewModelObj { get; set; }
        public TotalAnnualizedCostViewModel TotalAnnualizedCostViewModelObj { get; set; }
        public UtilityCostViewModel UtilityCostViewModelObj { get; set; }

        #endregion  // SUB-Panel ViewModel OBJECTS


        #endregion      // PROPERTIES

        #region Parameterized CTOR
        /// <summary>
        /// Parameterized Constructor for ProjectWrapperViewModel Class
        /// </summary>
        /// <param name="strProjectDbNameOnly">Project Db Name... NO ".db" extension</param>
        public ProjectWrapperViewModel(string strProjectDbNameOnly)
        {
            #region PROJECT Database Name
            if (strProjectDbNameOnly == string.Empty) throw new ArgumentNullException(
                           nameof(strProjectDbNameOnly),
                           "Project DB Name can not be empty");

            //---------------------------------------------------
            //--- Add File Extension ".db" to Project Db Name ---
            //---------------------------------------------------
            ProjectDbName = string.Format("{0].db", strProjectDbNameOnly);
            #endregion  // PROJECT Database Name

            #region PROJECT Database Connection
            //-----------------------------------------------------------------------------------------
            //--- Configure PROJECT database connection options
            //-----------------------------------------------------------------------------------------
            SQLiteConnectionOptions options = new SQLiteConnectionOptions
            {
                DbType = DatabaseType.PROJECT,
                DatabasePath = ProjectDbName
            };

            //-----------------------------------------------------------------------------------------
            //--- Create the SQLite connection factory using APPLICATION options
            //-----------------------------------------------------------------------------------------
            SQLiteConnectionFactory connFactoryObj = new SQLiteConnectionFactory(options);
            #endregion  // PROJECT Database Connection

            #region Initialize PROJECT-level ViewModel Objects
            //----------------------------------------------- Project Sub-Panel ---
            ProjectViewModelObj = new ProjectViewModel(connFactoryObj);

            //------------------------------- Project Default Params Sub-Panels ---
            ProjectUnitsViewModelObj = new ProjectUnitsViewModel(connFactoryObj);
            ExchangerParamsViewModelObj = new ExchangerParamsViewModel(connFactoryObj);
            OptimizerParamsViewModelObj = new OptimizerParamsViewModel(connFactoryObj);

            //---------------------------------- Project Cost Params Sub-Panels ---
            CostMetadataViewModelObj = new CostMetadataViewModel(connFactoryObj);
            FiredHeaterCapitalCostViewModelObj = new FiredHeaterCapitalCostViewModel(connFactoryObj);
            ShellAndTubeCapitalCostViewModelObj = new ShellAndTubeCapitalCostViewModel(connFactoryObj);
            TotalAnnualizedCostViewModelObj = new TotalAnnualizedCostViewModel(connFactoryObj);
            UtilityCostViewModelObj = new UtilityCostViewModel(connFactoryObj);

            //-----------------------------------------------------------------------------------
            //--- Initialize Heat Transfer Coefficient Panel Data based on Project Units      ---
            //--- NOTE: Heat Transfer Coefficient ViewModel is Dependent on Project Units,    ---
            //--- so ProjectUnits object is already been created and assigned in wrapper DTO. ---
            //--- NOTE: Heat Transfer Coefficient ViewModel is NOT stored in the DB, but is   ---
            //--- calculated based on the Project Units.                                      ---
            //-----------------------------------------------------------------------------------
            HeatTransferCoeffViewModelObj = new HeatTransferCoeffViewModel(
                ProjectWrapperDtoObj.ProjectUnitsDtoObj.DefaultSystemUnits);  // Data Source is NOT DB

            #endregion  // Initialize PROJECT-level ViewModel Objects

        }
        #endregion  // Parameterized CTOR

        #region CRUD METHODS

        #region --> CREATE ... CreateProjectWrapperData(ProjectWrapperDto projecteWrapperDtoObj)
        /// <summary>
        /// Add (CREATE) the Project data contained in the WRAPPER DTO to the SQLite PROJECT DB
        /// using Sub-Panel ViewModle to Sub-Panel Repo interfaces
        /// Returns Project Id associated with added data
        /// </summary>
        /// <returns>Project WRAPPER DTO Object including all PK and FK IDs.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ProjectWrapperDto CreateProjectWrapperData(ProjectWrapperDto projectWrapperDtoObj)
        {
            string strMethod = "CreateProjectWrapperData";

            if (projectWrapperDtoObj == null) throw new ArgumentNullException(
                                         nameof(projectWrapperDtoObj),
                                         "Project Wrapper DTO can not be null");

            if (projectWrapperDtoObj.ProjectDbName == string.Empty) throw new ArgumentNullException(
                                         nameof(projectWrapperDtoObj.ProjectDbName),
                                         "Project DB Name can not be empty");
            //-----------------------------
            //--- Initialize Project ID ---
            //-----------------------------
            int projectId = -1; // Project ViewModel AddProject() return value [PROJECT PANEL]
            try
            {
                ProjectWrapperDtoObj = projectWrapperDtoObj;

                #region TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=- BEGIN TRANSACTION -=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** BEGIN TRANSACTION FOR CREATE PROJECT WRAPPER ***.

                #region PROJECT PANEL DATA
                if (ProjectWrapperDtoObj.ProjectDtoObj == null) throw new ArgumentNullException(
                                     nameof(ProjectWrapperDtoObj.ProjectDtoObj),
                                     "Project DTO Object cannot be null.");
                //---------------------------------------------------------------
                //--- Add Project Data to DB using ViewModel Object           ---
                //--- Returns Project ID for Foreign Key Relationships in DB  ---
                //--- NOTE: Project ID used for all the other Project WRAPPER ---
                //---       Sub-Panel ViewModel Object Add() methods as FK    ---
                //---------------------------------------------------------------
                ProjectDto externalProjectDto = ProjectWrapperDtoObj.ProjectDtoObj;
                projectId = ProjectViewModelObj.AddProject(externalProjectDto);     // ADD Data

                if (projectId == -1) throw new ArgumentNullException(
                                           nameof(projectId), 
                                           "Project ID is -1 for ADD Project ViewModel.");

                ProjectWrapperDtoObj.ProjectId = projectId;               // Assign WRAPPER Project ID
                externalProjectDto.Id = projectId;                        // Assign Project DTO Project ID (PK)
                ProjectWrapperDtoObj.ProjectDtoObj = externalProjectDto;  // Assign WRAPPER Project DTO
                #endregion  // PROJECT PANEL DATA

                #region PROJECT DEFAULT PARAMETERS SUB-PANELS

                #region PROJECT UNITS DATA
                if (ProjectWrapperDtoObj.ProjectUnitsDtoObj == null) throw new ArgumentNullException(
                                 nameof(ProjectWrapperDtoObj.ProjectUnitsDtoObj),
                                 "Project Units DTO Object cannot be null.");

                ProjectWrapperDtoObj.ProjectUnitsDtoObj.ProjectId = projectId;   // Assign ProjectUnits DTO Project ID (FK)
                //----------------------------------------------------------
                //--- Add ProjectUnits Data to DB using ViewModel Object ---
                //--- Returns Project Units ID                           ---
                //----------------------------------------------------------
                ProjectUnitsDto externalProjecUnitsDto = ProjectWrapperDtoObj.ProjectUnitsDtoObj;
                int projectUnitsId = ProjectUnitsViewModelObj.AddProjectUnits(externalProjecUnitsDto);     // ADD Data

                ProjectWrapperDtoObj.ProjectUnitsId = projectUnitsId;              // Assign WRAPPER ProjectUnits ID (PK)
                externalProjecUnitsDto.Id = projectUnitsId;                        // Assign ProjectUnits DTO Project Units ID (PK)
                ProjectWrapperDtoObj.ProjectUnitsDtoObj = externalProjecUnitsDto;  // Assign WRAPPER ProjectUnits DTO
                #endregion  // PROJECT UNITS DATA

                #region EXCHANGER PARAMS DATA
                if (ProjectWrapperDtoObj.ExchangerParamsDtoObj == null) throw new ArgumentNullException(
                                 nameof(ProjectWrapperDtoObj.ExchangerParamsDtoObj),
                                 "Exchanger Params DTO Object cannot be null.");

                ProjectWrapperDtoObj.ExchangerParamsDtoObj.ProjectId = projectId;   // Assign ExchangerParams DTO Project ID (FK)
                //-------------------------------------------------------------
                //--- Add ExchangerParams Data to DB using ViewModel Object ---
                //--- Returns Exchanger Params ID                           ---
                //-------------------------------------------------------------
                ExchangerParamsDto externalExchangerParamsDto = ProjectWrapperDtoObj.ExchangerParamsDtoObj;
                int exchangerParamsId = ExchangerParamsViewModelObj.AddExchangerParams(externalExchangerParamsDto);

                ProjectWrapperDtoObj.ExchangerParamsId = exchangerParamsId;               // Assign WRAPPER Exchanger Params ID (PK)
                externalExchangerParamsDto.Id = exchangerParamsId;                        // Assign ExchangerParams DTO ExchangerParams ID (PK)
                ProjectWrapperDtoObj.ExchangerParamsDtoObj = externalExchangerParamsDto;  // Assign WRAPPER ExchangerParams DTO
                #endregion  // EXCHANGER PARAMS DATA

                #region HEAT TRANSFER COEFFICIENT LIST
                //------------------------------------------------------
                //--- Create Heat Transfer Coeff ViewModel Object    ---
                //--- CTOR load List of HeatTransferCoeffDto Objects ---
                //--- List is assigned to Project WRAPPER DTO        ---  
                //------------------------------------------------------
                HeatTransferCoeffViewModelObj = new HeatTransferCoeffViewModel(
                    ProjectWrapperDtoObj.ProjectUnitsDtoObj.DefaultSystemUnits);  // Data Source is NOT DB
                ProjectWrapperDtoObj.HeatTransferCoeffDtoList = 
                                     HeatTransferCoeffViewModelObj.HeatTransferCoeffDtoList;
                #endregion  // HEAT TRANSFER COEFFICIENT LIST

                #region OPTIMIZER PARAMS DATA
                if (ProjectWrapperDtoObj.OptimizerParamsDtoObj == null) throw new ArgumentNullException(
                                 nameof(ProjectWrapperDtoObj.OptimizerParamsDtoObj),
                                 "Optimizer Params DTO Object cannot be null.");

                ProjectWrapperDtoObj.OptimizerParamsDtoObj.ProjectId = projectId;   // Assign OptimizerParams DTO Project ID (FK)
                //-------------------------------------------------------------
                //--- Add OptimizerParams Data to DB using ViewModel Object ---
                //--- Returns Optimizer Params ID                           ---
                //-------------------------------------------------------------
                OptimizerParamsDto externalOptimizerParamsDto = ProjectWrapperDtoObj.OptimizerParamsDtoObj;
                int optimizerParamsId = OptimizerParamsViewModelObj.AddOptimizerParams(externalOptimizerParamsDto);

                ProjectWrapperDtoObj.OptimizerParamsId = optimizerParamsId;               // Assign WRAPPER OptimizerParams ID (PK)
                externalOptimizerParamsDto.Id = optimizerParamsId;                        // Assign OptimizerParams DTO OptimizerParams ID (PK)
                ProjectWrapperDtoObj.OptimizerParamsDtoObj = externalOptimizerParamsDto;  // Assign WRAPPER OptimizerParams DTO
                #endregion      //  OPTIMIZER PARAMS DATA

                #endregion  // PROJECT DEFAULT PARAMETERS SUB-PANELS

                #region PROJECT COST PARAMETERS SUB-PANELS

                #region COST METADATA DATA
                if (ProjectWrapperDtoObj.CostMetadataDtoObj == null) throw new ArgumentNullException(
                                         nameof(ProjectWrapperDtoObj.CostMetadataDtoObj),
                                         "Cost Metadata DTO Object cannot be null.");

                ProjectWrapperDtoObj.CostMetadataDtoObj.ProjectId = projectId;   // Assign Cost Metadata DTO Project ID (FK)
                //----------------------------------------------------------
                //--- Add CostMetadata Data to DB using ViewModel Object ---
                //--- Returns Cost Metadata ID                           ---
                //----------------------------------------------------------
                CostMetadataDto externalCostMetadataDto = ProjectWrapperDtoObj.CostMetadataDtoObj;
                int costMetadataId = CostMetadataViewModelObj.AddCostMetadata(externalCostMetadataDto);

                ProjectWrapperDtoObj.CostMetadataId = costMetadataId;               // Assign WRAPPER CostMetadata ID (PK)
                externalCostMetadataDto.Id = costMetadataId;                        // Assign CostMetadata DTO CostMetadata ID (PK)
                ProjectWrapperDtoObj.CostMetadataDtoObj = externalCostMetadataDto;  // Assign WRAPPER CostMetadata DTO
                #endregion  // COST METADATA DATA

                #region FIRED HEATER CAPITAL COST DATA
                if (ProjectWrapperDtoObj.FiredHeaterCapitalCostDtoObj == null) throw new ArgumentNullException(
                                         nameof(ProjectWrapperDtoObj.FiredHeaterCapitalCostDtoObj),
                                         "Fired Heater Capital Cost DTO Object cannot be null.");

                ProjectWrapperDtoObj.FiredHeaterCapitalCostDtoObj.ProjectId = 
                                     projectId;   // Assign Fired heater Capital Cost DTO Project ID (FK)
                //--------------------------------------------------------------------
                //--- Add FiredHeaterCapitalCost Data to DB using ViewModel Object ---
                //--- Returns Fired Heater Capital Cost ID                         ---
                //--------------------------------------------------------------------
                FiredHeaterCapitalCostDto externalFiredHeaterCapitalCostDto = ProjectWrapperDtoObj.FiredHeaterCapitalCostDtoObj;
                int firedHeaterCapitalCostId =
                    FiredHeaterCapitalCostViewModelObj.AddFiredHeaterCapitalCost(externalFiredHeaterCapitalCostDto);

                ProjectWrapperDtoObj.FiredHeaterCapitalCostId = firedHeaterCapitalCostId;               // Assign WRAPPER FiredHeaterCapitalCost ID (PK)
                externalFiredHeaterCapitalCostDto.Id = firedHeaterCapitalCostId;                        // Assign FiredHeaterCapitalCost DTO FiredHeaterCapitalCost ID (PK)
                ProjectWrapperDtoObj.FiredHeaterCapitalCostDtoObj = externalFiredHeaterCapitalCostDto;  // Assign WRAPPER FiredHeaterCapitalCost DTO
                #endregion  // FIRED HEATER CAPITAL COST DATA

                #region SHELL AND TUBE CAPITAL COST DATA
                if (ProjectWrapperDtoObj.ShellAndTubeCapitalCostDtoObj == null) throw new ArgumentNullException(
                                         nameof(ProjectWrapperDtoObj.ShellAndTubeCapitalCostDtoObj),
                                         "Shell And Tube Capital Cost DTO Object cannot be null.");

                ProjectWrapperDtoObj.ShellAndTubeCapitalCostDtoObj.ProjectId = 
                                     projectId;   // Assign Shell And Tube Capital Cost DTO Project ID (FK)
                //---------------------------------------------------------------------
                //--- Add ShellAndTubeCapitalCost Data to DB using ViewModel Object ---
                //--- Returns Shell And Tube Capital Cost ID                        ---
                //---------------------------------------------------------------------
                ShellAndTubeCapitalCostDto externalShellAndTubeCapitalCostDto = ProjectWrapperDtoObj.ShellAndTubeCapitalCostDtoObj;
                int shellAndTubeCapitalCostId =
                    ShellAndTubeCapitalCostViewModelObj.AddShellAndTubeCapitalCost(externalShellAndTubeCapitalCostDto);

                ProjectWrapperDtoObj.ShellAndTubeCapitalCostId = shellAndTubeCapitalCostId;               // Assign WRAPPER ShellAndTubeCapitalCost ID (PK)
                externalShellAndTubeCapitalCostDto.Id = shellAndTubeCapitalCostId;                        // Assign ShellAndTubeCapitalCost DTO ShellAndTubeCapitalCost ID (PK)
                ProjectWrapperDtoObj.ShellAndTubeCapitalCostDtoObj = externalShellAndTubeCapitalCostDto;  // Assign WRAPPER ShellAndTubeCapitalCost DTO
                #endregion      // SHELL AND TUBE CAPITAL COST DATA

                #region TOTAL ANNUALIZED COST DATA
                if (ProjectWrapperDtoObj.TotalAnnualizedCostDtoObj == null) throw new ArgumentNullException(
                                                 nameof(ProjectWrapperDtoObj.TotalAnnualizedCostDtoObj),
                                                 "Total Annualized Cost DTO Object cannot be null.");

                ProjectWrapperDtoObj.TotalAnnualizedCostDtoObj.ProjectId = projectId;   // Assign Total Annualized Cost DTO Project ID (FK)
                //-----------------------------------------------------------------
                //--- Add TotalAnnualizedCost Data to DB using ViewModel Object ---
                //--- Returns Total Annualized Cost ID                          ---
                //-----------------------------------------------------------------
                TotalAnnualizedCostDto externalTotalAnnualizedCostDto = ProjectWrapperDtoObj.TotalAnnualizedCostDtoObj;
                int totalAnnualizedCostId =
                     TotalAnnualizedCostViewModelObj.AddTotalAnnualizedCost(externalTotalAnnualizedCostDto);

                ProjectWrapperDtoObj.TotalAnnualizedCostId = totalAnnualizedCostId;               // Assign WRAPPER TotalAnnualizedCost ID (PK)
                externalTotalAnnualizedCostDto.Id = totalAnnualizedCostId;                        // Assign TotalAnnualizedCost DTO TotalAnnualizedCost ID (PK)
                ProjectWrapperDtoObj.TotalAnnualizedCostDtoObj = externalTotalAnnualizedCostDto;  // Assign WRAPPER TotalAnnualizedCost DTO
                #endregion  // TOTAL ANNUALIZED COST DATA

                #region UTILITY COST DATA
                if (ProjectWrapperDtoObj.UtilityCostDtoObj == null) throw new ArgumentNullException(
                                                 nameof(ProjectWrapperDtoObj.UtilityCostDtoObj),
                                                 "Utility Cost DTO Object cannot be null.");

                ProjectWrapperDtoObj.UtilityCostDtoObj.ProjectId = projectId;   // Assign Utility Cost DTO Project ID (FK)
                //---------------------------------------------------------
                //--- Add UtilityCost Data to DB using ViewModel Object ---
                //--- Returns Utility Cost ID                           ---
                //---------------------------------------------------------
                UtilityCostDto externalUtilityCostDto = ProjectWrapperDtoObj.UtilityCostDtoObj;
                int utilityCostId = UtilityCostViewModelObj.AddUtilityCost(externalUtilityCostDto);

                ProjectWrapperDtoObj.UtilityCostId = utilityCostId;               // Assign WRAPPER UtilityCost ID (PK)
                externalUtilityCostDto.Id = utilityCostId;                        // Assign UtilityCost DTO UtilityCost ID (PK)
                ProjectWrapperDtoObj.UtilityCostDtoObj = externalUtilityCostDto;  // Assign WRAPPER UtilityCost DTO
                #endregion  // UTILITY COST DATA

                #endregion  // PROJECT COST PARAMETERS SUB-PANELS

                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-= END TRANSACTION =-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** END TRANSACTION FOR CREATE PROJECT WRAPPER ***.

                #endregion  // TRANSACTION
            }
            catch (Exception ex)
            {
                #region ROLL-BACK TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=- ROLL-BACK TRANSACTION -=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** ROLL-BACK TRANSACTION FOR CREATE PROJECT WRAPPER ***.

                #endregion  // ROLL-BACK TRANSACTION

                //---------------------
                //--- Log Exception ---
                //---------------------
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, "EXCEPTION ENCOUNTERED: CREATE TRANSACTION ROLLED BACK!");
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            //-----------------------------------------
            //--- Return Project WRAPPER DTO Object ---
            //-----------------------------------------
            return ProjectWrapperDtoObj;
        }
        #endregion  // --> CREATE ... AddProjectWrapperData(ProjectWrapperDto projecteWrapperDtoObj)

        #region --> READ ..... ReadProjectWrapperData(int projectId)
        /// <summary>
        /// Read (GET) the Project Wrapper Data using the specified Project ID.
        /// </summary>
        /// <param name="projectId">The ID of the project-related data to READ.</param>
        /// <returns>Project WRAPPER DTO object</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ProjectWrapperDto ReadProjectWrapperData(int projectId)
        {
            string strMethod = "ReadProjectWrapperData";

            if (projectId == -1) throw new ArgumentNullException(
                                       nameof(projectId), 
                                      "Project ID cannot be -1.");
            //---------------------------------------------
            //--- Initialize Project WRAPPER DTO Object ---
            //---------------------------------------------
            ProjectWrapperDtoObj = new ProjectWrapperDto();
            try
            {
                #region TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=- BEGIN TRANSACTION -=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** BEGIN TRANSACTION FOR READ PROJECT WRAPPER ***.

                #region PROJECT PANEL DATA
                //--------------------------------------------------------
                //--- READ Project Data from DB using ViewModel Object ---
                //--- NOTE: ViewModel Object returns Project DTO       ---
                //--------------------------------------------------------
                ProjectWrapperDtoObj.ProjectDtoObj = ProjectViewModelObj.GetProjectById(projectId);

                if (ProjectWrapperDtoObj.ProjectDtoObj == null) throw new ArgumentNullException(
                                  nameof(ProjectWrapperDtoObj.ProjectDtoObj),
                                 "Project DTO cannot be null.");
                #endregion  // PROJECT PANEL DATA

                #region PROJECT DEFAULT PARAMETERS PANELS DATA

                #region PROJECT UNITS PANEL DATA
                //-------------------------------------------------------------
                //--- READ ProjectUnits Data from DB using ViewModel Object ---
                //--- NOTE: ViewModel Object returns ProjectUnits DTO       ---
                //-------------------------------------------------------------
                ProjectWrapperDtoObj.ProjectUnitsDtoObj =
                                ProjectUnitsViewModelObj.GetProjectUnitsByProjectId(projectId);

                if (ProjectWrapperDtoObj.ProjectUnitsDtoObj == null) throw new ArgumentNullException(
                                  nameof(ProjectWrapperDtoObj.ProjectUnitsDtoObj),
                                 "Project Units DTO cannot be null.");
                #endregion  // PROJECT UNITS PANEL DATA

                #region EXCHANGER PARAMS PANEL DATA
                //----------------------------------------------------------------
                //--- READ ExchangerParams Data from DB using ViewModel Object ---
                //--- NOTE: ViewModel Object returns ExchangerParams DTO       ---
                //----------------------------------------------------------------
                ProjectWrapperDtoObj.ExchangerParamsDtoObj =
                          ExchangerParamsViewModelObj.GetExchangerParamsByProjectId(projectId);

                if (ProjectWrapperDtoObj.ExchangerParamsDtoObj == null) throw new ArgumentNullException(
                                   nameof(ProjectWrapperDtoObj.ExchangerParamsDtoObj),
                                  "Exchanger Params DTO cannot be null.");
                #endregion  // EXCHANGER PARAMS PANEL DATA

                #region HEAT TRANSFER COEFFICIENT LIST
                //------------------------------------------------------
                //--- Create Heat Transfer Coeff ViewModel Object    ---
                //--- CTOR load List of HeatTransferCoeffDto Objects ---
                //--- List is assigned to Project WRAPPER DTO        ---  
                //------------------------------------------------------
                HeatTransferCoeffViewModelObj = new HeatTransferCoeffViewModel(
                    ProjectWrapperDtoObj.ProjectUnitsDtoObj.DefaultSystemUnits);  // Data Source is NOT DB
                ProjectWrapperDtoObj.HeatTransferCoeffDtoList =
                                     HeatTransferCoeffViewModelObj.HeatTransferCoeffDtoList;
                #endregion  // HEAT TRANSFER COEFFICIENT LIST

                #region OPTIMIZER PARAMS PANEL DATA
                //----------------------------------------------------------------
                //--- READ OptimizerParams Data from DB using ViewModel Object ---
                //--- NOTE: ViewModel Object returns OptimizerParams DTO       ---
                //----------------------------------------------------------------
                ProjectWrapperDtoObj.OptimizerParamsDtoObj =
                    OptimizerParamsViewModelObj.GetOptimizerParamsByProjectId(projectId);

                if (ProjectWrapperDtoObj.OptimizerParamsDtoObj == null) throw new ArgumentNullException(
                                   nameof(ProjectWrapperDtoObj.OptimizerParamsDtoObj),
                                  "Optimizer Params DTO cannot be null.");
                #endregion  // OPTIMIZER PARAMS PANEL DATA

                #endregion  // PROJECT DEFAULT PARAMETERS PANELS DATA

                #region PROJECT COST PARAMETERS PANELS DATA

                #region COST METADATA PANEL DATA
                //-------------------------------------------------------------
                //--- READ CostMetadata Data from DB using ViewModel Object ---
                //--- NOTE: ViewModel Object returns CostMetadata DTO       ---
                //-------------------------------------------------------------
                ProjectWrapperDtoObj.CostMetadataDtoObj =
                                     CostMetadataViewModelObj.GetCostMetadataByProjectId(projectId);

                if (ProjectWrapperDtoObj.CostMetadataDtoObj == null) throw new ArgumentNullException(
                                nameof(ProjectWrapperDtoObj.CostMetadataDtoObj),
                               "Cost Metadata DTO cannot be null.");
                #endregion  // COST METADATA PANEL DATA

                #region FIRED HEATER CAPITAL COST PANEL DATA
                //-----------------------------------------------------------------------
                //--- READ FiredHeaterCapitalCost Data from DB using ViewModel Object ---
                //--- NOTE: ViewModel Object returns FiredHeaterCapitalCost DTO       ---
                //-----------------------------------------------------------------------
                ProjectWrapperDtoObj.FiredHeaterCapitalCostDtoObj =
                     FiredHeaterCapitalCostViewModelObj.GetFiredHeaterCapitalCostByProjectId(projectId);

                if (ProjectWrapperDtoObj.FiredHeaterCapitalCostDtoObj == null) throw new ArgumentNullException(
                                nameof(ProjectWrapperDtoObj.FiredHeaterCapitalCostDtoObj),
                               "Fired Heater Capital Cost DTO cannot be null.");
                #endregion  // FIRED HEATER CAPITAL COST PANEL DATA

                #region SHELL AND TUBE CAPITAL COST PANEL DATA
                //------------------------------------------------------------------------
                //--- READ ShellAndTubeCapitalCost Data from DB using ViewModel Object ---
                //--- NOTE: ViewModel Object returns ShellAndTubeCapitalCost DTO       ---
                //------------------------------------------------------------------------
                ProjectWrapperDtoObj.ShellAndTubeCapitalCostDtoObj =
                     ShellAndTubeCapitalCostViewModelObj.GetShellAndTubeCapitalCostByProjectId(projectId);

                if (ProjectWrapperDtoObj.ShellAndTubeCapitalCostDtoObj == null) throw new ArgumentNullException(
                                nameof(ProjectWrapperDtoObj.ShellAndTubeCapitalCostDtoObj),
                               "Shell And Tube Capital Cost DTO cannot be null.");
                #endregion  // SHELL AND TUBE CAPITAL COST PANEL DATA

                #region TOTAL ANNUALIZED COST PANEL DATA
                //--------------------------------------------------------------------
                //--- READ TotalAnnualizedCost Data from DB using ViewModel Object ---
                //--- NOTE: ViewModel Object returns TotalAnnualizedCost DTO       ---
                //--------------------------------------------------------------------
                ProjectWrapperDtoObj.TotalAnnualizedCostDtoObj =
                     TotalAnnualizedCostViewModelObj.GetTotalAnnualizedCostByProjectId(projectId);

                if (ProjectWrapperDtoObj.TotalAnnualizedCostDtoObj == null) throw new ArgumentNullException(
                                nameof(ProjectWrapperDtoObj.TotalAnnualizedCostDtoObj),
                               "Total Annualized Cost DTO cannot be null.");
                #endregion  // TOTAL ANNUALIZED COST PANEL DATA

                #region UTILITY COST PANEL DATA
                //------------------------------------------------------------
                //--- READ UtilityCost Data from DB using ViewModel Object ---
                //--- NOTE: ViewModel Object returns UtilityCost DTO       ---
                //------------------------------------------------------------
                ProjectWrapperDtoObj.UtilityCostDtoObj =
                     UtilityCostViewModelObj.GetUtilityCostByProjectId(projectId);

                if (ProjectWrapperDtoObj.UtilityCostDtoObj == null) throw new ArgumentNullException(
                                nameof(ProjectWrapperDtoObj.UtilityCostDtoObj),
                               "Utility Cost DTO cannot be null.");
                #endregion  // UTILITY COST PANEL DATA

                #endregion  // PROJECT COST PARAMETERS PANELS DATA

                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-= END TRANSACTION =-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** END TRANSACTION FOR READ PROJECT WRAPPER ***.

                #endregion  // TRANSACTION
            }
            catch (Exception ex)
            {
                #region ROLL-BACK TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=- ROLL-BACK TRANSACTION -=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** ROLL-BACK TRANSACTION FOR READ PROJECT WRAPPER ***.

                #endregion  // ROLL-BACK TRANSACTION

                //---------------------
                //--- Log Exception ---
                //---------------------
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, "EXCEPTION ENCOUNTERED: READ TRANSACTION ROLLED BACK!");
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            //-----------------------------------------------
            //--- Assign Project Id to ProjectWRAPPER DTO ---
            //--- Return Populated Project WRAPPER DTO    ---
            //-----------------------------------------------
            ProjectWrapperDtoObj.ProjectId = projectId;
            return ProjectWrapperDtoObj;
        }
        #endregion  // --> READ ..... ReadProjectWrapperData(Guid projectId)

        #region --> UPDATE ... UpdateProjectWrapperData(ProjectWrapperDto projecteWrapperDtoObj)
        /// <summary>
        /// Use the specified Project Wrapper DTO Properties to UPDATE ALL the Project Subpanel 
        /// data in the HENSTUDIO DB.
        /// NOTE: The Project ID used in assigned in the WRAPPER DTO
        /// </summary>
        /// <param name="projecteWrapperDtoObj">Project WRAPPER DTO object containing data to update.</param>
        public void UpdateProjectWrapperData(ProjectWrapperDto projectWrapperDtoObj)
        {
            string strMethod = "UpdateProjectWrapperData";

            if (projectWrapperDtoObj == null) throw new ArgumentNullException(
                             nameof(projectWrapperDtoObj), "Project ID cannot be null.");

            try
            {
                ProjectWrapperDtoObj = projectWrapperDtoObj;

                #region TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=- BEGIN TRANSACTION -=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** BEGIN TRANSACTION FOR UPDATE PROJECT WRAPPER ***.

                #region PROJECT PANEL DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //-------------------------- PROJECT DATA --------------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (projectDtoObj == null) throw new ArgumentNullException(
                                     nameof(projectDtoObj),
                                     "Project DTO Object cannot be null.");
                //----------------------------------------------------------------------------------
                //--- Extract Project ID from WRAPPER DTO object - supplied in method invocation ---
                //----------------------------------------------------------------------------------
                Guid projectId = projectWrapperDtoObj.ProjectId;    // Assign Project ID

                if (projectId == null) throw new ArgumentNullException(
                                 nameof(projectId), 
                                 "Project ID cannot be null.");
                //--------------------------------------------------------
                //--- Update Project Data to DB using PanelData Object ---
                //--- Returns Post-Update Project DTO object           ---
                //--------------------------------------------------------
                ProjectDto postUpdateProjectDto = 
                           ProjectPanelDataObj.UpdateProjectData(projectDtoObj);

                if (postUpdateProjectDto == null) throw new ArgumentNullException(
                                 nameof(postUpdateProjectDto), 
                                 "Post-Update Project DTO cannot be null.");
                //-------------------------------------------
                //--- Assign POST-UPDATE Project DTO Data ---
                //-------------------------------------------
                ProjectPanelDataObj.ProjectDtoObj = postUpdateProjectDto;
                ProjectWrapperDtoObj.ProjectDtoObj = postUpdateProjectDto;
                #endregion  // PROJECT PANEL DATA

                #region PROJECT DEFAULT PARAMETERS PANEL DATA

                #region PROJECT UNITS DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //----------------------- PROJECT UNITS DATA -----------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (projectUnitsDtoObj == null) throw new ArgumentNullException(
                                 nameof(projectUnitsDtoObj),
                                 "Project Units DTO Object cannot be null.");

                projectUnitsDtoObj.ProjectId = projectId;   // Assign Project ID
                //----------------------------------------------------------------------------------------
                //--- Extract Project Units ID from WRAPPER DTO object - supplied in method invocation ---
                //----------------------------------------------------------------------------------------
                Guid projectUnitsId = projectWrapperDtoObj.ProjectUnitsId;
                //-------------------------------------------------------------
                //--- Update ProjectUnits Data to DB using PanelData Object ---
                //--- Returns Post-Update ProjectUnits DTO object           ---
                //-------------------------------------------------------------
                ProjectUnitsDto postUpdateProjectUnitsDto =
                        ProjectUnitsPanelDataObj.UpdateProjectUnitsData(projectUnitsDtoObj);

                if (postUpdateProjectUnitsDto == null) throw new ArgumentNullException(
                                 nameof(postUpdateProjectUnitsDto), 
                                 "Post-Update Project Units DTO cannot be null.");
                //-------------------------------------------------
                //--- Assign POST-UPDATE Project Units DTO Data ---
                //-------------------------------------------------
                ProjectUnitsPanelDataObj.ProjectUnitsDtoObj = postUpdateProjectUnitsDto;
                ProjectWrapperDtoObj.ProjectUnitsDtoObj = postUpdateProjectUnitsDto;
                #endregion  // PROJECT UNITS DATA

                #region EXCHANGER PARAMS DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //--------------------- EXCHANGER PARAMS DATA ----------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (exchangerParamsDtoObj == null) throw new ArgumentNullException(
                                 nameof(exchangerParamsDtoObj),
                                 "Exchanger Params DTO Object cannot be null.");

                exchangerParamsDtoObj.ProjectId = projectId;   // Assign Project ID
                //-------------------------------------------------------------------------------------------
                //--- Extract Exchanger Params ID from WRAPPER DTO object - supplied in method invocation ---
                //-------------------------------------------------------------------------------------------
                Guid exchangerParamsId = projectWrapperDtoObj.ExchangerParamsId;
                //-----------------------------------------------------------------
                //--- Update Exchanger Params Data to DB using PanelData Object ---
                //--- Returns Post-Update Exchanger Params DTO object           ---
                //-----------------------------------------------------------------
                ExchangerParamsDto postUpdateExchangerParamsDto =
                        ExchangerParamsPanelDataObj.UpdateExchangerParamsData(exchangerParamsDtoObj);

                if (postUpdateExchangerParamsDto == null) throw new ArgumentNullException(
                                 nameof(postUpdateExchangerParamsDto),
                                 "Post-Update Exchanger Params DTO cannot be null.");
                //----------------------------------------------------
                //--- Assign POST-UPDATE Exchanger Params DTO Data ---
                //----------------------------------------------------
                ExchangerParamsPanelDataObj.ExchangerParamsDtoObj = postUpdateExchangerParamsDto;
                ProjectWrapperDtoObj.ExchangerParamsDtoObj = postUpdateExchangerParamsDto;
                #endregion  // EXCHANGER PARAMS DATA

                #region OPTIMIZER PARAMS DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //--------------------- OPTIMIZER PARAMS DATA ----------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (optimizerParmasDtoObj == null) throw new ArgumentNullException(
                                 nameof(optimizerParmasDtoObj),
                                 "Optimizer Params DTO Object cannot be null.");

                optimizerParmasDtoObj.ProjectId = projectId;   // Assign Project ID
                //-------------------------------------------------------------------------------------------
                //--- Extract Optimizer Params ID from WRAPPER DTO object - supplied in method invocation ---
                //-------------------------------------------------------------------------------------------
                Guid optimizerParamsId = projectWrapperDtoObj.OptimizerParamsId;
                //-----------------------------------------------------------------
                //--- Update Optimizer Params Data to DB using PanelData Object ---
                //--- Returns Post-Update Optimizer Params DTO object           ---
                //-----------------------------------------------------------------
                OptimizerParamsDto postUpdateOptimizerParamsDto =
                        OptimizerParamsPanelDataObj.UpdateOptimizerParamsData(optimizerParmasDtoObj);

                if (postUpdateOptimizerParamsDto == null) throw new ArgumentNullException(
                                 nameof(postUpdateOptimizerParamsDto),
                                 "Post-Update Optimizer Params DTO cannot be null.");
                //----------------------------------------------------
                //--- Assign POST-UPDATE Optimizer Params DTO Data ---
                //----------------------------------------------------
                OptimizerParamsPanelDataObj.OptimizerParamsDtoObj = postUpdateOptimizerParamsDto;
                ProjectWrapperDtoObj.OptimizerParamsDtoObj = postUpdateOptimizerParamsDto;
                #endregion  // OPTIMIZER PARAMS DATA

                #endregion  // PROJECT DEFAULT PARAMETERS PANEL DATA

                #region PROJECT COST PARAMETERS PANEL DATA

                #region COST METADATA DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //----------------------- COST METADATA DATA -----------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (costMetadataDtoObj == null) throw new ArgumentNullException(
                     nameof(costMetadataDtoObj),
                     "Cost Metadata DTO Object cannot be null.");

                costMetadataDtoObj.ProjectId = projectId;   // Assign Cost Metadata DTO Project ID
                //----------------------------------------------------------------------------------------
                //--- Extract Cost Metadata ID from WRAPPER DTO object - supplied in method invocation ---
                //----------------------------------------------------------------------------------------
                Guid costMetadataId = projectWrapperDtoObj.CostMetadataId;
                //-------------------------------------------------------------
                //--- Update CostMetadata Data to DB using PanelData Object ---
                //--- Returns Post-Update CostMetadata DTO object           ---
                //-------------------------------------------------------------
                CostMetadataDto postUpdateCostMetadataDto =
                        CostMetadataPanelDataObj.UpdateCostMetadataData(costMetadataDtoObj);

                if (postUpdateCostMetadataDto == null) throw new ArgumentNullException(
                                 nameof(postUpdateCostMetadataDto),
                                 "Post-Update Cost Metadata DTO cannot be null.");
                //-------------------------------------------------
                //--- Assign POST-UPDATE Cost Metadata DTO Data ---
                //-------------------------------------------------
                CostMetadataPanelDataObj.CostMetadataDtoObj = postUpdateCostMetadataDto;
                ProjectWrapperDtoObj.CostMetadataDtoObj = postUpdateCostMetadataDto;
                #endregion  // COST METADATA DATA

                #region FIRED HEATER CAPITAL COST DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //----------------------- FIRED HEATER CAPITAL COST DATA -----------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (firedHeaterCapitalCostDtoObj == null) throw new ArgumentNullException(
                     nameof(firedHeaterCapitalCostDtoObj),
                     "Fired Heater Capital Cost DTO Object cannot be null.");

                firedHeaterCapitalCostDtoObj.ProjectId = projectId;   // Assign Fired Heater Capital Cost DTO Project ID
                //----------------------------------------------------------------------------------------------------
                //--- Extract Fired Heater Capital Cost ID from WRAPPER DTO object - supplied in method invocation ---
                //----------------------------------------------------------------------------------------------------
                Guid firedHeaterCapitalCostId = projectWrapperDtoObj.FiredHeaterCapitalCostId;
                //--------------------------------------------------------------------------
                //--- Update Fired Heater Capital Cost Data to DB using PanelData Object ---
                //--- Returns Post-Update Fired Heater Capital Cost DTO object           ---
                //--------------------------------------------------------------------------
                FiredHeaterCapitalCostDto postUpdateFiredHeaterCapitalCostDto =
                        FiredHeaterCapitalCostPanelDataObj.UpdateFiredHeaterCapitalCostData(firedHeaterCapitalCostDtoObj);

                if (postUpdateFiredHeaterCapitalCostDto == null) throw new ArgumentNullException(
                                 nameof(postUpdateFiredHeaterCapitalCostDto),
                                 "Post-Update Fired Heater Capital Cost DTO cannot be null.");
                //-------------------------------------------------------------
                //--- Assign POST-UPDATE Fired Heater Capital Cost DTO Data ---
                //-------------------------------------------------------------
                FiredHeaterCapitalCostPanelDataObj.FiredHeaterCapitalCostDtoObj = postUpdateFiredHeaterCapitalCostDto;
                ProjectWrapperDtoObj.FiredHeaterCapitalCostDtoObj = postUpdateFiredHeaterCapitalCostDto;
                #endregion  // FIRED HEATER CAPITAL COST DATA

                #region SHELL AND TUBE CAPITAL COST DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //---------------------- SHELL AND TUBE CAPITAL COST DATA ----------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (shellAndTubeCapitalCostDtoObj == null) throw new ArgumentNullException(
                     nameof(shellAndTubeCapitalCostDtoObj),
                     "Shell And Tube Capital Cost DTO Object cannot be null.");

                shellAndTubeCapitalCostDtoObj.ProjectId = projectId;   // Assign Shell And Tube Capital Cost DTO Project ID
                //------------------------------------------------------------------------------------------------------
                //--- Extract Shell And Tube Capital Cost ID from WRAPPER DTO object - supplied in method invocation ---
                //------------------------------------------------------------------------------------------------------
                Guid shellAndTubeCapitalCostId = projectWrapperDtoObj.ShellAndTubeCapitalCostId;
                //----------------------------------------------------------------------------
                //--- Update Shell And Tube Capital Cost Data to DB using PanelData Object ---
                //--- Returns Post-Update Shell And Tube Capital Cost DTO object           ---
                //----------------------------------------------------------------------------
                ShellAndTubeCapitalCostDto postUpdateShellAndTubeCapitalCostDto =
                        ShellAndTubeCapitalCostPanelDataObj.UpdateShellAndTubeCapitalCostData(shellAndTubeCapitalCostDtoObj);

                if (postUpdateShellAndTubeCapitalCostDto == null) throw new ArgumentNullException(
                                 nameof(postUpdateShellAndTubeCapitalCostDto),
                                 "Post-Update Shell And Tube Capital Cost DTO cannot be null.");
                //---------------------------------------------------------------
                //--- Assign POST-UPDATE Shell And Tube Capital Cost DTO Data ---
                //---------------------------------------------------------------
                ShellAndTubeCapitalCostPanelDataObj.ShellAndTubeCapitalCostDtoObj = postUpdateShellAndTubeCapitalCostDto;
                ProjectWrapperDtoObj.ShellAndTubeCapitalCostDtoObj = postUpdateShellAndTubeCapitalCostDto;
                #endregion  // SHELL AND TUBE CAPITAL COST DATA

                #region TOTAL ANNUALIZED COST DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //------------------------- TOTAL ANNUALIZED COST DATA -------------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (totalAnnualizedCostDtoObj == null) throw new ArgumentNullException(
                                                 nameof(totalAnnualizedCostDtoObj),
                                                 "Total Annualized Cost DTO Object cannot be null.");

                totalAnnualizedCostDtoObj.ProjectId = projectId;   // Assign Total Annualized Cost DTO Project ID
                //------------------------------------------------------------------------------------------------
                //--- Extract Total Annualized Cost ID from WRAPPER DTO object - supplied in method invocation ---
                //------------------------------------------------------------------------------------------------
                Guid totalAnnualizedCostId = projectWrapperDtoObj.TotalAnnualizedCostId;
                //----------------------------------------------------------------------
                //--- Update Total Annualized Cost Data to DB using PanelData Object ---
                //--- Returns Post-Update Total Annualized Cost DTO object           ---
                //----------------------------------------------------------------------
                TotalAnnualizedCostDto postUpdateTotalAnnualizedCostDto =
                        TotalAnnualizedCostPanelDataObj.UpdateTotalAnnualizedCostData(totalAnnualizedCostDtoObj);

                if (postUpdateTotalAnnualizedCostDto == null) throw new ArgumentNullException(
                                 nameof(postUpdateTotalAnnualizedCostDto),
                                 "Post-Update Total Annualized Cost DTO cannot be null.");
                //---------------------------------------------------------
                //--- Assign POST-UPDATE Total Annualized Cost DTO Data ---
                //---------------------------------------------------------
                TotalAnnualizedCostPanelDataObj.TotalAnnualizedCostDtoObj = postUpdateTotalAnnualizedCostDto;
                ProjectWrapperDtoObj.TotalAnnualizedCostDtoObj = postUpdateTotalAnnualizedCostDto;
                #endregion  // TOTAL ANNUALIZED COST DATA

                #region UTILITY COST DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //------------------------------ UTILITY COST DATA ------------------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (utilityCostDtoObj == null) throw new ArgumentNullException(
                                                 nameof(utilityCostDtoObj),
                                                 "Utility Cost DTO Object cannot be null.");

                utilityCostDtoObj.ProjectId = projectId;   // Assign Utility Cost DTO Project ID
                //---------------------------------------------------------------------------------------
                //--- Extract Utility Cost ID from WRAPPER DTO object - supplied in method invocation ---
                //---------------------------------------------------------------------------------------
                Guid utilityCostId = projectWrapperDtoObj.UtilityCostId;
                //-------------------------------------------------------------
                //--- Update Utility Cost Data to DB using PanelData Object ---
                //--- Returns Post-Update Utility Cost DTO object           ---
                //-------------------------------------------------------------
                UtilityCostDto postUpdateUtilityCostDto =
                        UtilityCostPanelDataObj.UpdateUtilityCostData(utilityCostDtoObj);

                if (postUpdateUtilityCostDto == null) throw new ArgumentNullException(
                                 nameof(postUpdateUtilityCostDto),
                                 "Post-Update Utility Cost DTO cannot be null.");
                //------------------------------------------------
                //--- Assign POST-UPDATE Utility Cost DTO Data ---
                //------------------------------------------------
                UtilityCostPanelDataObj.UtilityCostDtoObj = postUpdateUtilityCostDto;
                ProjectWrapperDtoObj.UtilityCostDtoObj = postUpdateUtilityCostDto;
                #endregion  // UTILITY COST DATA

                #endregion  // PROJECT COST PARAMETERS PANEL DATA

                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-= END TRANSACTION =-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** END TRANSACTION FOR UPDATE PROJECT WRAPPER ***.

                #endregion  // TRANSACTION
            }
            catch (Exception ex)
            {
                #region ROLL-BACK TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=- ROLL-BACK TRANSACTION -=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** ROLL-BACK TRANSACTION FOR UPDATE PROJECT WRAPPER ***.

                #endregion  // ROLL-BACK TRANSACTION

                //---------------------
                //--- Log Exception ---
                //---------------------
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, "EXCEPTION ENCOUNTERED: UPDATE TRANSACTION ROLLED BACK!");
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
        }
        #endregion  // --> UPDATE ... UpdateProjectWrapperData(ProjectWrapperDto projecteWrapperDtoObj)

        #region --> DELETE ... DeleteProjectWrapperData(int projectId)
        /// <summary>
        /// Use the specified Project ID to DELETE ALL the Project WRAPPER Data.
        /// Cascading Delete is Controlled in SQLite.
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
                ProjectWrapperDtoObj.ProjectId = projectId;

                #region TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=- BEGIN TRANSACTION -=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** BEGIN TRANSACTION FOR DELETE PROJECT WRAPPER ***.

                //----------------------------------------------------
                //--- Use Project ID to DELETE Data from DB        ---
                //--- NOTE: Cascading Delete is controlled in SQL. ---
                //----------------------------------------------------
                ProjectPanelDataObj.DeleteProjectData(projectId);

                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-= END TRANSACTION =-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** END TRANSACTION FOR DELETE PROJECT WRAPPER ***.

                #endregion  // TRANSACTION
            }
            catch (Exception ex)
            {
                #region ROLL-BACK TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=- ROLL-BACK TRANSACTION -=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** ROLL-BACK TRANSACTION FOR DELETE PROJECT WRAPPER ***.

                #endregion  // ROLL-BACK TRANSACTION

                //---------------------
                //--- Log Exception ---
                //---------------------
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, "EXCEPTION ENCOUNTERED: DELETE TRANSACTION ROLLED BACK!");
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
        }
        #endregion  // --> DELETE ... DeleteProjectWrapperData(Guid projectId)

        #endregion  // CRUD METHODS
    }
    #endregion      // public class ProjectWrapperViewModel
}
#endregion      // namespace HenViewModel.Project

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
