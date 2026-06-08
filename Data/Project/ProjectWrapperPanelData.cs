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

using HenGlobal;

using HenModel.Dto.Profile;
using HenModel.Dto.Profile.Streams;



#region HEN STUDIO REFERENCES
using HenModel.Dto.Project;
using HenModel.Dto.Project.CostParameters;
using HenModel.Dto.Project.DefaultParameters;
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

using HenStudio.Data.Project;
using HenStudio.Data.Project.CostParameters;
using HenStudio.Data.Project.DefaultParameters;
using HenStudio.Data.Project.DefaultParameters.ExchangerParams;
using HenStudio.Data.Project.DefaultParameters.OptimizerParams;
using HenStudio.Data.Project.DefaultParameters.ProjectUnits;
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
    #region public class ProjectWrapperDto
    /// <summary>
    /// Project Wrapper Data Class
    /// </summary>
    public class ProjectWrapperPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio";
        const string CLASS = "ProjectWrapperPanelData";
        #endregion  // CONSTANTS

        #region PROPERTIES

        #region ProjectWrapperDto OBJECT
        //-------------------------------------------------
        //--- ProjectWrapperPanelData Object contains   ---
        //--- all the IDs, and DTO Objects, for the     ---
        //--- Project Wrapper Panel. [INTRA-VIEW LAYER] ---
        //-------------------------------------------------
        ProjectWrapperDto ProjectWrapperDtoObj { get; set; }
        #endregion  // ProjectWrapperDto OBJECT

        #region SUB-PanelData OBJECTS
        //---------------------------------- PROJECT Sub-PANEL DATA OBJECTS ---
        public ProjectPanelData ProjectPanelDataObj { get; set; }
        //---------------------------------------------------------------------
        public ProjectUnitsPanelData ProjectUnitsPanelDataObj { get; set; }
        public ExchangerParamsPanelData ExchangerParamsPanelDataObj { get; set; }
        public HeatTransferCoeffPanelData HeatTransferCoeffPanelDataObj { get; set; }
        public OptimizerParamsPanelData OptimizerParamsPanelDataObj { get; set; }
        //---------------------------------------------------------------------
        public CostMetadataPanelData CostMetadataPanelDataObj { get; set; }
        public FiredHeaterCapitalCostPanelData FiredHeaterCapitalCostPanelDataObj { get; set; }
        public ShellAndTubeCapitalCostPanelData ShellAndTubeCapitalCostPanelDataObj { get; set; }
        public TotalAnnualizedCostPanelData TotalAnnualizedCostPanelDataObj { get; set; }
        public UtilityCostPanelData UtilityCostPanelDataObj { get; set; }
        #endregion      // SUB-PanelData OBJECTS

        #region HenProjectUnits OBJECT
        //------------------------------------------------------------------------
        //--- HenProjectUnits Holds PROJECT Units Data (INTERNAL & EXTERNAL)   ---
        //------------------------------------------------------------------------
        //--- Object contains methods to retrieve the following PROJECT UNITS: ---
        //--- SystemUnits, MagnitudeUnits, AreaUnits, TemperatureUnits,        ---
        //--- PressureUnits, HeatFlowRateUnits, HeatCapacityFlowRateUnits,     ---
        //--- Overall HeatTransferCoefficientUnits                             ---
        //------------------------------------------------------------------------
        public HenProjectUnits HenProjectUnitsObj { get; set; }
        #endregion  // HenProjectUnits OBJECT

        #endregion      // PROPERTIES

        #region InitializeWrapperData()
        /// <summary>
        /// Initialize the Project Wrapper Data Object with Default Values 
        /// to Avoid Null Reference Exceptions.
        /// NOTE: ProjectWrapperPanelData Object contains all the IDs, and 
        /// DTO Objects, for the Project Wrapper Panel. [INTRA-VIEW LAYER]
        /// </summary>
        private void InitializeWrapperData()
        {
            //------------------------------------------------------
            //--- Initialize ProjectWrapperPanelData Property to ---
            //--- Avoid Null Reference Exceptions                ---
            //------------------------------------------------------
            ProjectWrapperDto projectWrapperDtoObj = new ProjectWrapperDto();
            //-----------------------------------------------------------------------
            //--- Initialize PanelData Objects to Avoid Null Reference Exceptions ---
            //-----------------------------------------------------------------------
            ProjectPanelDataObj = new ProjectPanelData();

            ProjectUnitsPanelDataObj = new ProjectUnitsPanelData();
            ExchangerParamsPanelDataObj = new ExchangerParamsPanelData();
            HeatTransferCoeffPanelDataObj = new HeatTransferCoeffPanelData("English");
            OptimizerParamsPanelDataObj = new OptimizerParamsPanelData();

            CostMetadataPanelDataObj = new CostMetadataPanelData();
            FiredHeaterCapitalCostPanelDataObj = new FiredHeaterCapitalCostPanelData();
            ShellAndTubeCapitalCostPanelDataObj = new ShellAndTubeCapitalCostPanelData();
            TotalAnnualizedCostPanelDataObj = new TotalAnnualizedCostPanelData();
            UtilityCostPanelDataObj = new UtilityCostPanelData();
            //----------------------------------------------------------------------------
            //--- Initialize HenProjectUnits Object to Avoid Null Reference Exceptions ---
            //----------------------------------------------------------------------------
            //--- Object contains methods to retrieve the following PROJECT UNITS:     ---
            //--- SystemUnits, MagnitudeUnits, AreaUnits, TemperatureUnits,            ---
            //--- PressureUnits, HeatFlowRateUnits, HeatCapacityFlowRateUnits,         ---
            //--- Overall HeatTransferCoefficientUnits                                 ---
            //----------------------------------------------------------------------------
            HenProjectUnitsObj = new HenProjectUnits();
        }
        #endregion  // InitializeWrapperData()

        #region Default CTOR
        /// <summary>
        /// Default Constructor for ProjectWrapperData Class
        /// </summary>
        public ProjectWrapperPanelData()
        {
            //-----------------------------------------------------------
            // --- Initialize the Project Wrapper Data Object with    ---
            // --- Default Values to Avoid Null Reference Exceptions. ---
            //-----------------------------------------------------------
            InitializeWrapperData();
        }
        #endregion  // Default CTOR

        #region Parameterized CTOR
        /// <summary>
        /// Parameterized Constructor for ProjectWrapperData Class
        /// </summary>
        public ProjectWrapperPanelData(Guid projectId)
        {
            //-----------------------------------------------------------
            // --- Initialize the Profile Wrapper Data Object with    ---
            // --- Default Values to Avoid Null Reference Exceptions. ---
            //-----------------------------------------------------------
            InitializeWrapperData();
            //--------------------------------------------------------------------------
            //--- Null Guard on User Supplied Ids to Avoid Null Reference Exceptions ---
            //--------------------------------------------------------------------------   
            if (projectId == null) throw new ArgumentNullException(
                                         nameof(projectId), "Project ID cannot be null.");
            else ProjectWrapperDtoObj.ProjectId = projectId;

            //---------------------------------------------
            //--- Assign PanelData Object Id Properties ---
            //---------------------------------------------
            ProjectPanelDataObj.ProjectId = projectId;

            ExchangerParamsPanelDataObj.ProjectId = projectId;
            OptimizerParamsPanelDataObj.ProjectId = projectId;
            ProjectUnitsPanelDataObj.ProjectId = projectId;

            CostMetadataPanelDataObj.ProjectId = projectId;
            FiredHeaterCapitalCostPanelDataObj.ProjectId = projectId;
            ShellAndTubeCapitalCostPanelDataObj.ProjectId = projectId;
            TotalAnnualizedCostPanelDataObj.ProjectId = projectId;
            UtilityCostPanelDataObj.ProjectId = projectId;
            //--------------------------------------------------
            //--- Initialize Property HenProjectUnits Object ---
            //--------------------------------------------------
            ProjectUnitsPanelDataObj.ReadProjectUnitsData(projectId);
            ProjectUnitsDto projectUnitsDtoObj = ProjectUnitsPanelDataObj.ProjectUnitsDtoObj;
            
            if (projectUnitsDtoObj == null)
                throw new Exception("Project Units DTO Object is null for Project ID: " + projectId);
            
            HenProjectUnitsObj = new HenProjectUnits(projectUnitsDtoObj.DefaultSystemUnits,
                                                     projectUnitsDtoObj.DefaultMagnitudeUnits,
                                                     projectUnitsDtoObj.DefaultTemperatureUnits,
                                                     projectUnitsDtoObj.DefaultPressureUnits);
            //----------------------------------------------------------------------------------
            //--- Initialize Heat Transfer Coefficient Panel Data based on Project Units     ---
            //--- NOTE: Heat Transfer Coefficient Panel Data is Dependent on Project Units,  ---
            //--- so it is initialized here after the Project Units data is retrieved.       ---
            //--- NOTE: Heat Transfer Coefficient Panel Data is NOT stored in the DB, but is ---
            //--- calculated based on the Project Units.                                     ---
            //----------------------------------------------------------------------------------
            HeatTransferCoeffPanelDataObj = new HeatTransferCoeffPanelData(projectUnitsDtoObj.DefaultSystemUnits);
        }
        #endregion  // FULL Parameterized CTOR

        #region CRUD METHODS

        #region --> CREATE ... CreateProjectWrapperData(ProjectWrapperDto projecteWrapperDtoObj)
        /// <summary>
        /// Create (ADD) the Project data contained in the WRAPPER DTO to the HENSTUDIO DB
        /// </summary>
        /// <returns>Project ID of the newly created project-related data.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Guid CreateProjectWrapperData(ProjectWrapperDto projectWrapperDtoObj)
        {
            string strMethod = "CreateProjectWrapperData";

            if (projectWrapperDtoObj == null) throw new ArgumentNullException(
                                         nameof(projectWrapperDtoObj),
                                         "Project Wrapper DTO can not be null");
            //-----------------------------
            //--- Initialize Project ID ---
            //-----------------------------
            Guid projectId = Guid.Empty;
            try
            {
                #region DTO DATA
                //-----------------------------------------------------------------------------
                //--- Get DTO Data for Adding to DB ... VIEW Objects populatle WRAPPER DTOs ---
                //-----------------------------------------------------------------------------
                ProjectWrapperDtoObj = projectWrapperDtoObj;

                ProjectDto projectDtoObj = projectWrapperDtoObj.ProjectDtoObj;

                ProjectUnitsDto projectUnitsDtoObj = projectWrapperDtoObj.ProjectUnitsDtoObj;
                ExchangerParamsDto exchangerParamsDtoObj = projectWrapperDtoObj.ExchangerParamsDtoObj;
                OptimizerParamsDto optimizerParmasDtoObj = projectWrapperDtoObj.OptimizerParamsDtoObj;

                CostMetadataDto costMetadataDtoObj = projectWrapperDtoObj.CostMetadataDtoObj;
                FiredHeaterCapitalCostDto firedHeaterCapitalCostDtoObj = projectWrapperDtoObj.FiredHeaterCapitalCostDtoObj;
                ShellAndTubeCapitalCostDto shellAndTubeCapitalCostDtoObj = projectWrapperDtoObj.ShellAndTubeCapitalCostDtoObj;
                TotalAnnualizedCostDto totalAnnualizedCostDtoObj = projectWrapperDtoObj.TotalAnnualizedCostDtoObj;
                UtilityCostDto utilityCostDtoObj = projectWrapperDtoObj.UtilityCostDtoObj;
                #endregion  // DTO DATA

                #region TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=- BEGIN TRANSACTION -=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** BEGIN TRANSACTION FOR CREATE PROJECT WRAPPER ***.

                #region PROJECT PANEL DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //-------------------------- PROJECT DATA --------------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (projectDtoObj == null) throw new ArgumentNullException(
                                     nameof(projectDtoObj),
                                     "Project DTO Object cannot be null.");
                //--------------------------------------------------------------
                //--- Add Project Data to DB using PanelData Object          ---
                //--- Returns Project ID for Foreign Key Relationships in DB ---
                //--------------------------------------------------------------
                projectId = ProjectPanelDataObj.CreateProjectData(projectDtoObj);

                if (projectId == null) throw new ArgumentNullException(
                                 nameof(projectId), "Project ID is null for ADD Project Panel data.");

                projectDtoObj.Id = projectId;   // Assign Project DTO Project ID

                ProjectWrapperDtoObj.ProjectId = projectId;          // Assign WRAPPER Project ID
                ProjectWrapperDtoObj.ProjectDtoObj = projectDtoObj;  // Assign WRAPPER Project DTO
                #endregion  // PROJECT PANEL DATA

                #region PROJECT DEFAULT PARAMETERS PANELS DATA

                #region PROJECT UNITS DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //----------------------- PROJECT UNITS DATA -----------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (projectUnitsDtoObj == null) throw new ArgumentNullException(
                                 nameof(projectUnitsDtoObj),
                                 "Project Units DTO Object cannot be null.");

                projectUnitsDtoObj.ProjectId = projectId;   // Assign ProjectUnits DTO Project ID
                //----------------------------------------------------------
                //--- Add ProjectUnits Data to DB using PanelData Object ---
                //--- Returns Project Units ID                           ---
                //----------------------------------------------------------
                Guid projectUnitsId = ProjectUnitsPanelDataObj.CreateProjectUnitsData(projectUnitsDtoObj);
            
                projectUnitsDtoObj.Id = projectUnitsId;     // Assign ProjectUnits DTO ProjectUnits ID

                ProjectWrapperDtoObj.ProjectUnitsId = projectUnitsId;           // Assign WRAPPER Project Units ID
                ProjectWrapperDtoObj.ProjectUnitsDtoObj = projectUnitsDtoObj;   // Assign WRAPPER ProjectUnits DTO
                #endregion  // PROJECT UNITS DATA

                #region EXCHANGER PARAMS DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //--------------------- EXCHANGER PARAMS DATA ----------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (exchangerParamsDtoObj == null) throw new ArgumentNullException(
                                 nameof(exchangerParamsDtoObj),
                                 "Exchanger Params DTO Object cannot be null.");

                exchangerParamsDtoObj.ProjectId = projectId;   // Assign ExchangerParams DTO Project ID
                //-------------------------------------------------------------
                //--- Add ExchangerParams Data to DB using PanelData Object ---
                //--- Returns Exchanger Params ID                           ---
                //-------------------------------------------------------------
                Guid exchangerParamsId = ExchangerParamsPanelDataObj.CreateExchangerParamsData(exchangerParamsDtoObj);

                exchangerParamsDtoObj.Id = exchangerParamsId;  // Assign ExchangerParams DTO ExchangerParams ID

                ProjectWrapperDtoObj.ExchangerParamsId = exchangerParamsId;           // Assign WRAPPER ExchangerParams ID
                ProjectWrapperDtoObj.ExchangerParamsDtoObj = exchangerParamsDtoObj;   // Assign WRAPPER ExchangerParams DTO
                #endregion  // EXCHANGER PARAMS DATA

                #region OPTIMIZER PARAMS DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //--------------------- OPTIMIZER PARAMS DATA ----------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (optimizerParmasDtoObj == null) throw new ArgumentNullException(
                                 nameof(optimizerParmasDtoObj),
                                 "Optimizer Params DTO Object cannot be null.");

                optimizerParmasDtoObj.ProjectId = projectId;   // Assign OptimizerParams DTO Project ID
                //-------------------------------------------------------------
                //--- Add OptimizerParams Data to DB using PanelData Object ---
                //--- Returns Optimizer Params ID                           ---
                //-------------------------------------------------------------
                Guid optimizerParamsId = OptimizerParamsPanelDataObj.CreateOptimizerParamsData(optimizerParmasDtoObj);

                optimizerParmasDtoObj.Id = optimizerParamsId;  // Assign OptimizerParams DTO ExchangerParams ID

                ProjectWrapperDtoObj.OptimizerParamsId = optimizerParamsId;           // Assign WRAPPER OptimizerParams ID
                ProjectWrapperDtoObj.OptimizerParamsDtoObj = optimizerParmasDtoObj;   // Assign WRAPPER OptimizerParams DTO
                #endregion      //  OPTIMIZER PARAMS DATA

                #endregion  // PROJECT DEFAULT PARAMETERS PANELS DATA

                #region PROJECT COST PARAMETERS PANELS DATA

                #region COST METADATA DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //----------------------- COST METADATA DATA -----------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (costMetadataDtoObj == null) throw new ArgumentNullException(
                     nameof(costMetadataDtoObj),
                     "Cost Metadata DTO Object cannot be null.");

                costMetadataDtoObj.ProjectId = projectId;   // Assign Cost Metadata DTO Project ID
                //----------------------------------------------------------
                //--- Add CostMetadata Data to DB using PanelData Object ---
                //--- Returns Cost Metadata ID                           ---
                //----------------------------------------------------------
                Guid costMetadataId = CostMetadataPanelDataObj.CreateCostMetadataData(costMetadataDtoObj);

                costMetadataDtoObj.Id = costMetadataId;     // Assign Cost Metadata DTO Cost Metadata ID

                ProjectWrapperDtoObj.CostMetadataId = projectUnitsId;           // Assign WRAPPER Cost Metadata ID
                ProjectWrapperDtoObj.CostMetadataDtoObj = costMetadataDtoObj;   // Assign WRAPPER Cost Metadata DTO
                #endregion  // COST METADATA DATA

                #region FIRED HEATER CAPITAL COST DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //----------------------- FIRED HEATER CAPITAL COST DATA -----------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (firedHeaterCapitalCostDtoObj == null) throw new ArgumentNullException(
                     nameof(firedHeaterCapitalCostDtoObj),
                     "Fired Heater Capital Cost DTO Object cannot be null.");

                firedHeaterCapitalCostDtoObj.ProjectId = projectId;   // Assign Fired heater Capital Cost DTO Project ID
                //--------------------------------------------------------------------
                //--- Add FiredHeaterCapitalCost Data to DB using PanelData Object ---
                //--- Returns Fired heater Capital Cost ID                         ---
                //--------------------------------------------------------------------
                Guid firedHeaterCapitalCostId = 
                    FiredHeaterCapitalCostPanelDataObj.CreateFiredHeaterCapitalCostData(firedHeaterCapitalCostDtoObj);

                firedHeaterCapitalCostDtoObj.Id = firedHeaterCapitalCostId;    // Assign Fired Heater Capital Cost DTO Fired heater Capital Cost ID

                ProjectWrapperDtoObj.FiredHeaterCapitalCostId = firedHeaterCapitalCostId;         // Assign WRAPPER Fired heater Capital Cost ID
                ProjectWrapperDtoObj.FiredHeaterCapitalCostDtoObj = firedHeaterCapitalCostDtoObj; // Assign WRAPPER Fired heater Capital Cost DTO
                #endregion  // FIRED HEATER CAPITAL COST DATA

                #region SHELL AND TUBE CAPITAL COST DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //---------------------- SHELL AND TUBE CAPITAL COST DATA ----------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (shellAndTubeCapitalCostDtoObj == null) throw new ArgumentNullException(
                     nameof(shellAndTubeCapitalCostDtoObj),
                     "Shell And Tube Capital Cost DTO Object cannot be null.");

                shellAndTubeCapitalCostDtoObj.ProjectId = projectId;   // Assign Shell And Tube Capital Cost DTO Project ID
                //---------------------------------------------------------------------
                //--- Add ShellAndTubeCapitalCost Data to DB using PanelData Object ---
                //--- Returns Shell And Tube Capital Cost ID                        ---
                //---------------------------------------------------------------------
                Guid shellAndTubeCapitalCostId =
                    ShellAndTubeCapitalCostPanelDataObj.CreateShellAndTubeCapitalCostData(shellAndTubeCapitalCostDtoObj);

                shellAndTubeCapitalCostDtoObj.Id = shellAndTubeCapitalCostId;    // Assign Shell And Tube Capital Cost DTO Shell And Tube Capital Cost ID

                ProjectWrapperDtoObj.ShellAndTubeCapitalCostId = shellAndTubeCapitalCostId;         // Assign WRAPPER Shell And Tube Capital Cost ID
                ProjectWrapperDtoObj.ShellAndTubeCapitalCostDtoObj = shellAndTubeCapitalCostDtoObj; // Assign WRAPPER Shell And Tube Capital Cost DTO
                #endregion      // SHELL AND TUBE CAPITAL COST DATA

                #region TOTAL ANNUALIZED COST DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //------------------------- TOTAL ANNUALIZED COST DATA -------------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (totalAnnualizedCostDtoObj == null) throw new ArgumentNullException(
                                                 nameof(totalAnnualizedCostDtoObj),
                                                 "Total Annualized Cost DTO Object cannot be null.");

                totalAnnualizedCostDtoObj.ProjectId = projectId;   // Assign Total Annualized Cost DTO Project ID
                //-----------------------------------------------------------------
                //--- Add TotalAnnualizedCost Data to DB using PanelData Object ---
                //--- Returns Total Annualized Cost ID                          ---
                //-----------------------------------------------------------------
                Guid totalAnnualizedCostId =
                     TotalAnnualizedCostPanelDataObj.CreateTotalAnnualizedCostData(totalAnnualizedCostDtoObj);

                totalAnnualizedCostDtoObj.Id = totalAnnualizedCostId;    // Assign Total Annualized Cost DTO Total Annualized Cost ID

                ProjectWrapperDtoObj.TotalAnnualizedCostId = totalAnnualizedCostId;         // Assign WRAPPER Total Annualized Cost ID
                ProjectWrapperDtoObj.TotalAnnualizedCostDtoObj = totalAnnualizedCostDtoObj; // Assign WRAPPER Total Annualized Cost DTO
                #endregion  // TOTAL ANNUALIZED COST DATA

                #region UTILITY COST DATA
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //------------------------------ UTILITY COST DATA ------------------------------
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (utilityCostDtoObj == null) throw new ArgumentNullException(
                                                 nameof(utilityCostDtoObj),
                                                 "Utility Cost DTO Object cannot be null.");

                utilityCostDtoObj.ProjectId = projectId;   // Assign Utility Cost DTO Project ID
                //---------------------------------------------------------
                //--- Add UtilityCost Data to DB using PanelData Object ---
                //--- Returns Utility Cost ID                           ---
                //---------------------------------------------------------
                Guid utilityCostId = UtilityCostPanelDataObj.CreateUtilityCostData(utilityCostDtoObj);

                utilityCostDtoObj.Id = utilityCostId;    // Assign Utility Cost DTO Utility Cost ID

                ProjectWrapperDtoObj.UtilityCostId = utilityCostId;         // Assign WRAPPER Utility Cost ID
                ProjectWrapperDtoObj.UtilityCostDtoObj = utilityCostDtoObj; // Assign WRAPPER Utility Cost DTO

                #endregion  // UTILITY COST DATA

                #endregion  // PROJECT COST PARAMETERS PANELS DATA

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
            //-------------------------
            //--- Return Project ID ---
            //-------------------------
            return projectId;
        }
        #endregion  // --> CREATE ... CreateProjectWrapperData(ProjectWrapperDto projecteWrapperDtoObj)

        #region --> READ ..... ReadProjectWrapperData(Guid projectId)
        /// <summary>
        /// Read (GET) the Project Wrapper Data from the HENSTUDIO DB 
        /// using the specified Project ID.
        /// NOTE: WRAPPER DTO data should match PANEL DATA DTO data
        /// </summary>
        /// <param name="projectId">The ID of the project-related data to READ.</param>
        /// <returns>Project WRAPPER DTO object</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ProjectWrapperDto ReadProjectWrapperData(Guid projectId)
        {
            string strMethod = "ReadProjectWrapperData";

            if (projectId == null) throw new ArgumentNullException(
                             nameof(projectId), 
                             "Project ID cannot be null.");
            //---------------------------------
            //--- Assign WRAPPER Project ID ---
            //---------------------------------
            ProjectWrapperDtoObj.ProjectId = projectId;     // Assign WRAPPER Project ID
            try
            {
                #region TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=- BEGIN TRANSACTION -=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** BEGIN TRANSACTION FOR READ PROJECT WRAPPER ***.

                #region PROJECT PANEL DATA
                //--------------------------------------------------------
                //--- READ Project Data from DB using PanelData Object ---
                //--- NOTE: PanelData Object returns Project DTO       ---
                //--------------------------------------------------------
                ProjectDto projectDtoObj = ProjectPanelDataObj.ReadProjectData(projectId);

            if (projectDtoObj == null) throw new ArgumentNullException(
                             nameof(projectDtoObj),
                             "Project DTO cannot be null.");
            //----------------------------------
            //--- Assign WRAPPER Project DTO ---
            //----------------------------------
            ProjectWrapperDtoObj.ProjectDtoObj = projectDtoObj;
            #endregion  // PROJECT PANEL DATA

                #region PROJECT DEFAULT PARAMETERS PANELS DATA

                #region PROJECT UNITS PANEL DATA
                //-------------------------------------------------------------
                //--- READ ProjectUnits Data from DB using PanelData Object ---
                //--- NOTE: PanelData Object returns ProjectUnits DTO       ---
                //-------------------------------------------------------------
                ProjectUnitsDto projectUnitsDtoObj = 
                                ProjectUnitsPanelDataObj.ReadProjectUnitsData(projectId);

                if (projectUnitsDtoObj == null) throw new ArgumentNullException(
                                 nameof(projectUnitsDtoObj),
                                 "Project Units DTO cannot be null.");
                //----------------------------------------
                //--- Assign WRAPPER Project Units DTO ---
                //----------------------------------------
                ProjectWrapperDtoObj.ProjectUnitsDtoObj = projectUnitsDtoObj;
                #endregion  // PROJECT UNITS PANEL DATA

                #region EXCHANGER PARAMS PANEL DATA
                //----------------------------------------------------------------
                //--- READ ExchangerParams Data from DB using PanelData Object ---
                //--- NOTE: PanelData Object returns ExchangerParams DTO       ---
                //----------------------------------------------------------------
                ExchangerParamsDto exchangerParamsDtoObj =
                    ExchangerParamsPanelDataObj.ReadExchangerParamsData(ProjectWrapperDtoObj.ProjectId);

                if (exchangerParamsDtoObj == null) throw new ArgumentNullException(
                                 nameof(exchangerParamsDtoObj),
                                 "Exchanger Params DTO cannot be null.");
                //-------------------------------------------
                //--- Assign WRAPPER Exchanger Params DTO ---
                //-------------------------------------------
                ProjectWrapperDtoObj.ExchangerParamsDtoObj = exchangerParamsDtoObj;
                #endregion  // EXCHANGER PARAMS PANEL DATA

                #region OPTIMIZER PARAMS PANEL DATA
                //----------------------------------------------------------------
                //--- READ OptimizerParams Data from DB using PanelData Object ---
                //--- NOTE: PanelData Object returns OptimizerParams DTO       ---
                //----------------------------------------------------------------
                OptimizerParamsDto optimizerParamsDtoObj =
                    OptimizerParamsPanelDataObj.ReadOptimizerParamsData(ProjectWrapperDtoObj.ProjectId);

                if (optimizerParamsDtoObj == null) throw new ArgumentNullException(
                                 nameof(optimizerParamsDtoObj),
                                 "Optimizer Params DTO cannot be null.");
                //-------------------------------------------
                //--- Assign WRAPPER Optimizer Params DTO ---
                //-------------------------------------------
                ProjectWrapperDtoObj.OptimizerParamsDtoObj = optimizerParamsDtoObj;
                #endregion  // OPTIMIZER PARAMS PANEL DATA

                #region HEAT TRANSFER COEFFICIENT PANEL DATA
                //----------------------------------------------------------------------------------
                //--- Initialize Heat Transfer Coefficient Panel Data based on Project Units     ---
                //--- NOTE: Heat Transfer Coefficient Panel Data is Dependent on Project Units,  ---
                //--- so it is initialized here after the Project Units data is retrieved.       ---
                //--- NOTE: Heat Transfer Coefficient Panel Data is NOT stored in the DB, but is ---
                //--- calculated based on the Project Units.                                     ---
                //----------------------------------------------------------------------------------
                HeatTransferCoeffPanelDataObj = new HeatTransferCoeffPanelData(
                                 ProjectUnitsPanelDataObj.ProjectUnitsDtoObj.DefaultSystemUnits);
                #endregion  // HEAT TRANSFER COEFFICIENT PANEL DATA

                #endregion  // PROJECT DEFAULT PARAMETERS PANELS DATA

                #region PROJECT COST PARAMETERS PANELS DATA

                #region COST METADATA PANEL DATA
                //-------------------------------------------------------------
                //--- READ CostMetadata Data from DB using PanelData Object ---
                //--- NOTE: PanelData Object returns CostMetadata DTO       ---
                //-------------------------------------------------------------
                CostMetadataDto costMetadataDtoObj =
                    CostMetadataPanelDataObj.ReadCostMetadataData(ProjectWrapperDtoObj.ProjectId);

                if (costMetadataDtoObj == null) throw new ArgumentNullException(
                                 nameof(costMetadataDtoObj),
                                 "CostMetadataDtoObj DTO cannot be null.");
                //----------------------------------------
                //--- Assign WRAPPER Cost Metadata DTO ---
                //----------------------------------------
                ProjectWrapperDtoObj.CostMetadataDtoObj = costMetadataDtoObj;
                #endregion  // COST METADATA PANEL DATA

                #region FIRED HEATER CAPITAL COST PANEL DATA
                //-----------------------------------------------------------------------
                //--- READ FiredHeaterCapitalCost Data from DB using PanelData Object ---
                //--- NOTE: PanelData Object returns FiredHeaterCapitalCost DTO       ---
                //-----------------------------------------------------------------------
                FiredHeaterCapitalCostDto firedHeaterCapitalCostDtoObj =
                    FiredHeaterCapitalCostPanelDataObj.ReadFiredHeaterCapitalCostData(ProjectWrapperDtoObj.ProjectId);

                if (firedHeaterCapitalCostDtoObj == null) throw new ArgumentNullException(
                                 nameof(firedHeaterCapitalCostDtoObj),
                                 "FiredHeaterCapitalCostDtoObj DTO cannot be null.");
                //----------------------------------------------------
                //--- Assign WRAPPER Fired Heater Capital Cost DTO ---
                //----------------------------------------------------
                ProjectWrapperDtoObj.FiredHeaterCapitalCostDtoObj = 
                                     firedHeaterCapitalCostDtoObj;
                #endregion  // FIRED HEATER CAPITAL COST PANEL DATA

                #region SHELL AND TUBE CAPITAL COST PANEL DATA
                //------------------------------------------------------------------------
                //--- READ ShellAndTubeCapitalCost Data from DB using PanelData Object ---
                //--- NOTE: PanelData Object returns ShellAndTubeCapitalCost DTO       ---
                //------------------------------------------------------------------------
                ShellAndTubeCapitalCostDto shellAndTubeCapitalCostDtoObj =
                    ShellAndTubeCapitalCostPanelDataObj.ReadShellAndTubeCapitalCostData(ProjectWrapperDtoObj.ProjectId);

                if (shellAndTubeCapitalCostDtoObj == null) throw new ArgumentNullException(
                                 nameof(shellAndTubeCapitalCostDtoObj),
                                 "shellAndTubeCapitalCostDtoObj DTO cannot be null.");
                //------------------------------------------------------
                //--- Assign WRAPPER shell And Tube Capital Cost DTO ---
                //------------------------------------------------------
                ProjectWrapperDtoObj.ShellAndTubeCapitalCostDtoObj =
                                     shellAndTubeCapitalCostDtoObj;
                #endregion  // SHELL AND TUBE CAPITAL COST PANEL DATA

                #region TOTAL ANNUALIZED COST PANEL DATA
                //--------------------------------------------------------------------
                //--- READ TotalAnnualizedCost Data from DB using PanelData Object ---
                //--- NOTE: PanelData Object returns TotalAnnualizedCost DTO       ---
                //--------------------------------------------------------------------
                TotalAnnualizedCostDto totalAnnualizedCostDtoObj =
                     TotalAnnualizedCostPanelDataObj.ReadTotalAnnualizedCostData(ProjectWrapperDtoObj.ProjectId);

                if (totalAnnualizedCostDtoObj == null) throw new ArgumentNullException(
                                 nameof(totalAnnualizedCostDtoObj),
                                 "totalAnnualizedCostDtoObj DTO cannot be null.");
                //------------------------------------------------
                //--- Assign WRAPPER Total Annualized Cost DTO ---
                //------------------------------------------------
                ProjectWrapperDtoObj.TotalAnnualizedCostDtoObj =
                                     totalAnnualizedCostDtoObj;
                #endregion  // TOTAL ANNUALIZED COST PANEL DATA

                #region UTILITY COST PANEL DATA
                //------------------------------------------------------------
                //--- READ UtilityCost Data from DB using PanelData Object ---
                //--- NOTE: PanelData Object returns UtilityCost DTO       ---
                //------------------------------------------------------------
                UtilityCostDto utilityCostDtoObj =
                     UtilityCostPanelDataObj.ReadUtilityCostData(ProjectWrapperDtoObj.ProjectId);

                if (utilityCostDtoObj == null) throw new ArgumentNullException(
                                 nameof(utilityCostDtoObj),
                                 "utilityCostDtoObj DTO cannot be null.");
                //---------------------------------------
                //--- Assign WRAPPER Utility Cost DTO ---
                //---------------------------------------
                ProjectWrapperDtoObj.UtilityCostDtoObj =
                                     utilityCostDtoObj;
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
            //--------------------------------------------
            //--- Return Populated Project WRAPPER DTO ---
            //--------------------------------------------
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
        /// <returns>Project WRAPPER DTO including data updated</returns>
        public ProjectWrapperDto UpdateProjectWrapperData(ProjectWrapperDto projectWrapperDtoObj)
        {
            string strMethod = "UpdateProjectWrapperData";

            if (projectWrapperDtoObj == null) throw new ArgumentNullException(
                             nameof(projectWrapperDtoObj), "Project ID cannot be null.");

            try
            {
                #region DTO DATA
                //--------------------------------------------------------------------------------
                //--- Get DTO Data for Updating the DB ... VIEW Objects populatle WRAPPER DTOs ---
                //--------------------------------------------------------------------------------
                ProjectWrapperDtoObj = projectWrapperDtoObj;

            ProjectDto projectDtoObj = projectWrapperDtoObj.ProjectDtoObj;

            ProjectUnitsDto projectUnitsDtoObj = projectWrapperDtoObj.ProjectUnitsDtoObj;
            ExchangerParamsDto exchangerParamsDtoObj = projectWrapperDtoObj.ExchangerParamsDtoObj;
            OptimizerParamsDto optimizerParmasDtoObj = projectWrapperDtoObj.OptimizerParamsDtoObj;

            CostMetadataDto costMetadataDtoObj = projectWrapperDtoObj.CostMetadataDtoObj;
            FiredHeaterCapitalCostDto firedHeaterCapitalCostDtoObj = projectWrapperDtoObj.FiredHeaterCapitalCostDtoObj;
            ShellAndTubeCapitalCostDto shellAndTubeCapitalCostDtoObj = projectWrapperDtoObj.ShellAndTubeCapitalCostDtoObj;
            TotalAnnualizedCostDto totalAnnualizedCostDtoObj = projectWrapperDtoObj.TotalAnnualizedCostDtoObj;
            UtilityCostDto utilityCostDtoObj = projectWrapperDtoObj.UtilityCostDtoObj;
                #endregion  // DTO DATA

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
            //--------------------------------------------
            //--- Return Populated Project WRAPPER DTO ---
            //--------------------------------------------
            return projectWrapperDtoObj;
        }
        #endregion  // --> UPDATE ... UpdateProjectWrapperData(ProjectWrapperDto projecteWrapperDtoObj)

        #region --> DELETE ... DeleteProjectWrapperData(Guid projectId)
        /// <summary>
        /// Use the specified Project ID to DELETE ALL the Project Subpanel data in the HENSTUDIO DB.
        /// Cascading Delete is Controlled in SQL.
        /// </summary>
        /// <param name="projectId">The ID of the project-related data to DELETE.</param>
        public void DeleteProjectWrapperData(Guid projectId)
        {
            string strMethod = "DeleteProjectWrapperData";

            if (projectId == null) throw new ArgumentNullException(
                                         nameof(projectId), "Project ID cannot be null.");

            ProjectWrapperDtoObj.ProjectId = projectId;
            try
            {
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

        #region RENAME PROJECT METHOD
        /// <summary>
        /// Use the specified Project ID and the new project name and 
        /// description to RENAME the project in the HENSTUDIO DB.
        /// </summary>
        /// <param name="projectId">Project ID of project to rename</param>
        /// <param name="newName">New Name</param>
        /// <param name="newDescription">New Description</param>
        /// <returns>Project DTO of renamed Project</returns>
        /// <exception cref="ArgumentNullException">Check for null project id</exception>
        /// <exception cref="ArgumentException">Check for empty name</exception>
        public ProjectDto RenameProject(Guid projectId,
                                        string newName,
                                        string newDescription)
        {
            string strMethod = "RenameProject";
            ProjectDto projectDto = null;

            if (projectId == null) throw new ArgumentNullException(
                 nameof(projectId), "Project ID is null for READ Project Panel data.");

            if (string.IsNullOrEmpty(newName)) throw new ArgumentException(
                 nameof(newName), "New project name is null or empty for RENAME Project Panel data.");
            //------------------------------------------------
            //--- Update Project Wrapper  Panel Project ID ---
            //------------------------------------------------
            ProjectWrapperDtoObj.ProjectId = projectId;

            try
            {
                #region TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=- BEGIN TRANSACTION -=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** BEGIN TRANSACTION FOR RENAME PROJECT ***.

                projectDto = ProjectPanelDataObj.RenameProject(projectId,
                                                               newName,
                                                               newDescription);

                if (projectDto == null) throw new ArgumentNullException(
                     nameof(projectDto), "Project DTO is null for RENAME Project Panel data.");

                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-= END TRANSACTION =-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** END TRANSACTION FOR RENAME PROJECT ***.


                #endregion  // TRANSACTION
            }
            catch (Exception ex)
            {
                #region ROLL-BACK TRANSACTION
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=- ROLL-BACK TRANSACTION -=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
#warning TBD: *** ROLL-BACK TRANSACTION FOR RENAME PROJECT ***.

                #endregion  // ROLL-BACK TRANSACTION

                //---------------------
                //--- Log Exception ---
                //---------------------
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, "EXCEPTION ENCOUNTERED: RENAME TRANSACTION ROLLED BACK!");
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            //------------------------------------------------------
            //--- Return the Project DTO Renamed (updated) in DB ---
            //------------------------------------------------------
            return projectDto;
        }
        #endregion  // RENAME PROJECT METHOD
    }
    #endregion      // public class ProjectWrapperDto
}
#endregion      // namespace HenStudio.Data.Project

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
