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

#region HEN STUDIO REFERENCES
using HenModel.Dto.Project;
using HenModel.Dto.Project.CostParameters;
using HenModel.Dto.Project.DefaultParameters;
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

using HenViewModel.Project;
using HenViewModel.Project.CostParameters;
using HenViewModel.Project.DefaultParameters;
using HenViewModel.Project.DefaultParameters.ExchangerParams;
using HenViewModel.Project.DefaultParameters.OptimizerParams;
using HenViewModel.Project.DefaultParameters.ProjectUnits;

using HenStudio.Data.Project;
using HenStudio.Data.Project.CostParameters;
using HenStudio.Data.Project.DefaultParameters;
using HenStudio.Data.Project.DefaultParameters.ExchangerParams;
using HenStudio.Data.Project.DefaultParameters.OptimizerParams;
using HenStudio.Data.Project.DefaultParameters.ProjectUnits;
#endregion  // HEN STUDIO REFERENCES

using System;

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
        #region PROPERTIES
        //-------------------------------------------------
        //--- ProjectWrapperPanelData Object contains   ---
        //--- all the IDs, and DTO Objects, for the     ---
        //--- Project Wrapper Panel. [INTRA-VIEW LAYER] ---
        //-------------------------------------------------
        ProjectWrapperDto ProjectWrapperDtoObj { get; set; }

        //#region PROJECT IDs
        //public Guid ProjectId { get; set; } 
        ////---------------------------------------------------------------------
        //public Guid ProjectUnitsId { get; set; } 
        //public Guid ExchangerParamsId { get; set; }
        //public Guid OptimizerParamsId { get; set; }
        ////---------------------------------------------------------------------
        //public Guid CostMetadataId { get; set; }    
        //public Guid FiredHeaterCapitalCostId { get; set; }   
        //public Guid ShellAndTubeCapitalCostId { get; set; }  
        //public Guid TotalAnnualizedCostId { get; set; }      
        //public Guid UtilityCostId { get; set; }
        //#endregion  // // PROJECT IDs

        #region PanelData Objects
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
        #endregion      // PanelData Objects

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
        /// </summary>
        private void InitializeWrapperData()
        {
            //------------------------------------------------------
            //--- Initialize ProjectWrapperPanelData Property to ---
            //--- Avoid Null Reference Exceptions                ---
            //------------------------------------------------------
            //--- NOTE: ProjectWrapperPanelData Object contains  ---
            //--- all the IDs, and DTO Objects, for the Project  ---
            //--- Wrapper Panel. [INTRA-VIEW LAYER]              ---
            //------------------------------------------------------
            ProjectWrapperDto projectWrapperDtoObj = new ProjectWrapperDto();
            ////------------------------------------------------------------------------
            ////--- Initialize IDs to Empty GUIDs to Avoid Null Reference Exceptions ---
            ////------------------------------------------------------------------------
            //ProjectId = Guid.Empty;
            //ProjectUnitsId = Guid.Empty;
            //ExchangerParamsId = Guid.Empty;
            //OptimizerParamsId = Guid.Empty;
            //CostMetadataId = Guid.Empty;
            //FiredHeaterCapitalCostId = Guid.Empty;
            //ShellAndTubeCapitalCostId = Guid.Empty;
            //TotalAnnualizedCostId = Guid.Empty;
            //UtilityCostId = Guid.Empty;
            //-----------------------------------------------------------------
            //--- Initialize PanelData Objects to Avoid Null Reference Exceptions ---
            //-----------------------------------------------------------------
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
            ////-----------------------------------------------------------------------
            ////--- Initialize ViewModel Objects to Avoid Null Reference Exceptions ---
            ////-----------------------------------------------------------------------
            //ProjectViewModelObj = new ProjectViewModel();

            //ExchangerParamsViewModelObj = new ExchangerParamsViewModel();
            //OptimizerParamsViewModelObj = new OptimizerParamsViewModel();
            //ProjectUnitsViewModelObj = new ProjectUnitsViewModel();

            //CostMetadataViewModelObj = new CostMetadataViewModel();
            //FiredHeaterCapitalCostViewModelObj = new FiredHeaterCapitalCostViewModel();
            //ShellAndTubeCapitalCostViewModelObj = new ShellAndTubeCapitalCostViewModel();
            //TotalAnnualizedCostViewModelObj = new TotalAnnualizedCostViewModel();
            //UtilityCostViewModelObj = new UtilityCostViewModel();
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

        #region CRUD Methods

        #region CreateProjectWrapperData() ... CREATE ... ADD ALL PROJECT DATA
        /// <summary>
        /// Create (ADD) the Project Wrapper Data to the HENSTUDIO DB using
        /// the DTO and ViewModel object properties of this class.
        /// </summary>
        /// <returns>Project ID of the newly created project-related data.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Guid CreateProjectWrapperData()
        {
            #region PROJECT PANEL DATA
            //--------------------------------------------------------------
            //--- Add Project Data to DB using PanelData Object          ---
            //--- Returns Project ID for Foreign Key Relationships in DB ---
            //--------------------------------------------------------------
            ProjectWrapperDtoObj.ProjectId = ProjectPanelDataObj.CreateProjectData();
            #endregion  // PROJECT PANEL DATA

            #region PROJECT DEFAULT PARAMETERS PANELS DATA
            //----------------------------------------------------------
            //--- Add ProjectUnits Data to DB using PanelData Object ---
            //--- Returns Project Units ID                           ---
            //--- Assign Project ID (ProjectPanelData)               ---
            //----------------------------------------------------------
            ProjectWrapperDtoObj.ProjectUnitsId = ProjectUnitsPanelDataObj.CreateProjectUnitsData();
            ProjectUnitsPanelDataObj.ProjectId = ProjectWrapperDtoObj.ProjectId;
            //-------------------------------------------------------------
            //--- Add ExchangerParams Data to DB using PanelData Object ---
            //--- Returns Exchanger Params ID                           ---
            //--- Assign Project ID (ProjectPanelData)                  ---
            //-------------------------------------------------------------
            ProjectWrapperDtoObj.ExchangerParamsId = ExchangerParamsPanelDataObj.CreateExchangerParamsData();
            ExchangerParamsPanelDataObj.ProjectId = ProjectWrapperDtoObj.ProjectId;
            //-------------------------------------------------------------
            //--- Add OptimizerParams Data to DB using PanelData Object ---
            //--- Returns Optimizer Params ID                           ---
            //--- Assign Project ID (ProjectPanelData)                  ---
            //-------------------------------------------------------------
            ProjectWrapperDtoObj.OptimizerParamsId = OptimizerParamsPanelDataObj.CreateOptimizerParamsData();
            OptimizerParamsPanelDataObj.ProjectId = ProjectWrapperDtoObj.ProjectId;
            #endregion  // PROJECT DEFAULT PARAMETERS PANELS DATA

            #region PROJECT COST PARAMETERS PANELS DATA
            //----------------------------------------------------------
            //--- Add CostMetadata Data to DB using PanelData Object ---
            //--- Returns Cost Metadata ID                           ---
            //--- Assign Project ID (ProjectPanelData)               ---
            //----------------------------------------------------------
            ProjectWrapperDtoObj.CostMetadataId = CostMetadataPanelDataObj.CreateCostMetadataData();
            CostMetadataPanelDataObj.ProjectId = ProjectWrapperDtoObj.ProjectId;
            //--------------------------------------------------------------------
            //--- Add FiredHeaterCapitalCost Data to DB using PanelData Object ---
            //--- Returns Fired heater Capital Cost ID                         ---
            //--- Assign Project ID (ProjectPanelData)                         ---
            //--------------------------------------------------------------------
            ProjectWrapperDtoObj.FiredHeaterCapitalCostId = FiredHeaterCapitalCostPanelDataObj.CreateFiredHeaterCapitalCostData();
            FiredHeaterCapitalCostPanelDataObj.ProjectId = ProjectWrapperDtoObj.ProjectId;
            //---------------------------------------------------------------------
            //--- Add ShellAndTubeCapitalCost Data to DB using PanelData Object ---
            //--- Returns Fired heater Capital Cost ID                          ---
            //--- Assign Project ID (ProjectPanelData)                          ---
            //---------------------------------------------------------------------
            ProjectWrapperDtoObj.ShellAndTubeCapitalCostId = ShellAndTubeCapitalCostPanelDataObj.CreateShellAndTubeCapitalCostData();
            ShellAndTubeCapitalCostPanelDataObj.ProjectId = ProjectWrapperDtoObj.ProjectId;
            //-----------------------------------------------------------------
            //--- Add TotalAnnualizedCost Data to DB using PanelData Object ---
            //--- Returns Total Annualized Cost ID                          ---
            //--- Assign Project ID (ProjectPanelData)                      ---
            //-----------------------------------------------------------------
            ProjectWrapperDtoObj.TotalAnnualizedCostId = TotalAnnualizedCostPanelDataObj.CreateTotalAnnualizedCostData();
            TotalAnnualizedCostPanelDataObj.ProjectId = ProjectWrapperDtoObj.ProjectId;
            //---------------------------------------------------------
            //--- Add UtilityCost Data to DB using PanelData Object ---
            //--- Returns Utility Cost ID                           ---
            //--- Assign Project ID (ProjectPanelData)              ---
            //---------------------------------------------------------
            ProjectWrapperDtoObj.UtilityCostId = UtilityCostPanelDataObj.CreateUtilityCostData();
            UtilityCostPanelDataObj.ProjectId = ProjectWrapperDtoObj.ProjectId;
            #endregion  // PROJECT COST PARAMETERS PANELS DATA

            return ProjectWrapperDtoObj.ProjectId;
        }
        #endregion  // CreateProjectWrapperData() ... CREATE ... ADD ALL PROJECT DATA

        #region ReadProjectWrapperData(Guid projectId) ... READ ... GET ALL PROJECT DATA
        /// <summary>
        /// Read (GET) the Project Wrapper Data from the HENSTUDIO DB using the specified Project ID.
        /// </summary>
        /// <param name="projectId">The ID of the project-related data to READ.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void ReadProjectWrapperData(Guid projectId)
        {
            //------------------------------------------------------------
            //--- Null Guard on User Supplied Project ID to Avoid Null ---
            //--- References in ViewModel Invocations                  ---
            //------------------------------------------------------------   
            if (projectId == null) throw new ArgumentNullException(
                             nameof(projectId), "Project ID cannot be null.");
            else ProjectWrapperDtoObj.ProjectId = projectId;

            #region PROJECT PANEL DATA
            //----------------------------------------------------------
            //--- READ Project Data from DB using PanelData Object   ---
            //--- NOTE: returns void ... PanelData contains the data ---
            //----------------------------------------------------------
            ProjectPanelDataObj.ReadProjectData(ProjectWrapperDtoObj.ProjectId);
            #endregion  // PROJECT PANEL DATA

            #region PROJECT DEFAULT PARAMETERS PANELS DATA
            //----------------------------------------------------------
            //--- READ Project - DEFAULT PARAMETERS Data from DB     ---
            //--- using PanelData Object                             ---
            //--- NOTE: returns void ... PanelData contains the data ---
            //----------------------------------------------------------
            ProjectUnitsPanelDataObj.ReadProjectUnitsData(ProjectWrapperDtoObj.ProjectId);
            ExchangerParamsPanelDataObj.ReadExchangerParamsData(ProjectWrapperDtoObj.ProjectId);
            OptimizerParamsPanelDataObj.ReadOptimizerParamsData(ProjectWrapperDtoObj.ProjectId);
            
            //----------------------------------------------------------------------------------
            //--- Initialize Heat Transfer Coefficient Panel Data based on Project Units     ---
            //--- NOTE: Heat Transfer Coefficient Panel Data is Dependent on Project Units,  ---
            //--- so it is initialized here after the Project Units data is retrieved.       ---
            //--- NOTE: Heat Transfer Coefficient Panel Data is NOT stored in the DB, but is ---
            //--- calculated based on the Project Units.                                     ---
            //----------------------------------------------------------------------------------
            HeatTransferCoeffPanelDataObj = new HeatTransferCoeffPanelData(
                             ProjectUnitsPanelDataObj.ProjectUnitsDtoObj.DefaultSystemUnits);

            #endregion  // PROJECT DEFAULT PARAMETERS PANELS DATA

            #region PROJECT COST PARAMETERS PANELS DATA
            //----------------------------------------------------------
            //--- READ Project - COST PARAMETERS Data from DB using  ---
            //--- PanelData Object                                   ---
            //--- NOTE: returns void ... PanelData contains the data ---
            //----------------------------------------------------------
            CostMetadataPanelDataObj.ReadCostMetadataData(ProjectWrapperDtoObj.ProjectId);
            FiredHeaterCapitalCostPanelDataObj.ReadFiredHeaterCapitalCostData(ProjectWrapperDtoObj.ProjectId);
            ShellAndTubeCapitalCostPanelDataObj.ReadShellAndTubeCapitalCostData(ProjectWrapperDtoObj.ProjectId);
            TotalAnnualizedCostPanelDataObj.ReadTotalAnnualizedCostData(ProjectWrapperDtoObj.ProjectId);
            UtilityCostPanelDataObj.ReadUtilityCostData(ProjectWrapperDtoObj.ProjectId);
            #endregion  // PROJECT COST PARAMETERS PANELS DATA
        }
        #endregion  // ReadProjectWrapperData(Guid projectId) ... READ ... GET ALL PROFILE DATA

        #region UpdateProjectWrapperData(Guid projectId) ... UPDATE ... UPDATE ALL PROJECT DATA
        /// <summary>
        /// Use the specified Project ID and the DTO and ViewModel object 
        /// properties of this class to UPDATE ALL the Project Subpanel 
        /// data in the HENSTUDIO DB.
        /// </summary>
        /// <param name="projectId">The ID of the project-related data to UPDATE.</param>

        public void UpdateProjectWrapperData(Guid projectId)
        {
            //------------------------------------------------------------
            //--- Null Guard on User Supplied Project ID to Avoid Null ---
            //--- References in ViewModel Invocations                  ---
            //------------------------------------------------------------   
            if (projectId == null) throw new ArgumentNullException(
                             nameof(projectId), "Project ID cannot be null.");
            else ProjectWrapperDtoObj.ProjectId = projectId;
            //---------------------------------------------------------------
            //--- UPDATE Project Data to DB using PanelData Object        ---
            //--- NOTE: ViewModel Return DTO Objects, and PanelData       ---
            //--- Objects. VIEW objects populate the WRAPPER DTO Objects. ---
            //---------------------------------------------------------------
            #region PROJECT PANEL DATA
            //--- Copy WRAPPER to SubPanel Project ID ---
            ProjectPanelDataObj.ProjectId = ProjectWrapperDtoObj.ProjectId;
            //--- Update SubPanel Data to DB using PanelData Object ---
            ProjectWrapperDtoObj.ProjectDtoObj = ProjectPanelDataObj.
                           UpdateProjectData(ProjectPanelDataObj.ProjectDtoObj);
            #endregion  // PROJECT PANEL DATA

            #region PROJECT DEFAULT PARAMETERS PANEL DATA
            //--- Copy WRAPPER to SubPanel DTO Object ---
            ProjectUnitsPanelDataObj.ProjectUnitsDtoObj = ProjectWrapperDtoObj.ProjectUnitsDtoObj;
            //--- Update SubPanel Data to DB using PanelData Object ---
            ProjectUnitsPanelDataObj.ProjectUnitsDtoObj = ProjectUnitsPanelDataObj.
                               UpdateProjectUnitsData(ProjectUnitsPanelDataObj.ProjectUnitsDtoObj);

            //--- Copy WRAPPER to SubPanel DTO Object ---
            ExchangerParamsPanelDataObj.ExchangerParamsDtoObj = ProjectWrapperDtoObj.ExchangerParamsDtoObj;
            //--- Update SubPanel Data to DB using PanelData Object ---
            ExchangerParamsPanelDataObj.ExchangerParamsDtoObj = ExchangerParamsPanelDataObj.
                                  UpdateExchangerParamsData(ExchangerParamsPanelDataObj.ExchangerParamsDtoObj);

            //--- Copy WRAPPER to SubPanel DTO Object ---
            OptimizerParamsPanelDataObj.OptimizerParamsDtoObj = ProjectWrapperDtoObj.OptimizerParamsDtoObj;
            //--- Update SubPanel Data to DB using PanelData Object ---
            OptimizerParamsPanelDataObj.OptimizerParamsDtoObj = OptimizerParamsPanelDataObj.
                                  UpdateOptimizerParamsData(OptimizerParamsPanelDataObj.OptimizerParamsDtoObj);
            #endregion  // PROJECT DEFAULT PARAMETERS PANEL DATA

            #region PROJECT COST PARAMETERS PANEL DATA
            //--- Copy WRAPPER to SubPanel DTO Object ---
            CostMetadataPanelDataObj.CostMetadataDtoObj = ProjectWrapperDtoObj.CostMetadataDtoObj;
            //--- Update SubPanel Data to DB using PanelData Object ---
            CostMetadataPanelDataObj.CostMetadataDtoObj = CostMetadataPanelDataObj.
                               UpdateCostMetadataData(CostMetadataPanelDataObj.CostMetadataDtoObj);

            //--- Copy WRAPPER to SubPanel DTO Object ---
            FiredHeaterCapitalCostPanelDataObj.FiredHeaterCapitalCostDtoObj = ProjectWrapperDtoObj.FiredHeaterCapitalCostDtoObj;
            //--- Update SubPanel Data to DB using PanelData Object ---
            FiredHeaterCapitalCostPanelDataObj.FiredHeaterCapitalCostDtoObj = FiredHeaterCapitalCostPanelDataObj.
                                         UpdateFiredHeaterCapitalCostData(FiredHeaterCapitalCostPanelDataObj.FiredHeaterCapitalCostDtoObj);

            //--- Copy WRAPPER to SubPanel DTO Object ---
            ShellAndTubeCapitalCostPanelDataObj.ShellAndTubeCapitalCostDtoObj = ProjectWrapperDtoObj.ShellAndTubeCapitalCostDtoObj;
            //--- Update SubPanel Data to DB using PanelData Object ---
            ShellAndTubeCapitalCostPanelDataObj.ShellAndTubeCapitalCostDtoObj = ShellAndTubeCapitalCostPanelDataObj.
                                         UpdateShellAndTubeCapitalCostData(ShellAndTubeCapitalCostPanelDataObj.ShellAndTubeCapitalCostDtoObj);

            //--- Copy WRAPPER to SubPanel DTO Object ---
            TotalAnnualizedCostPanelDataObj.TotalAnnualizedCostDtoObj = ProjectWrapperDtoObj.TotalAnnualizedCostDtoObj;
            //--- Update SubPanel Data to DB using PanelData Object ---
            TotalAnnualizedCostPanelDataObj.TotalAnnualizedCostDtoObj = TotalAnnualizedCostPanelDataObj.
                                      UpdateTotalAnnualizedCostData(TotalAnnualizedCostPanelDataObj.TotalAnnualizedCostDtoObj);

            //--- Copy WRAPPER to SubPanel DTO Object ---
            UtilityCostPanelDataObj.UtilityCostDtoObj = ProjectWrapperDtoObj.UtilityCostDtoObj;
            //--- Update SubPanel Data to DB using PanelData Object ---
            UtilityCostPanelDataObj.UtilityCostDtoObj = UtilityCostPanelDataObj.
                                      UpdateUtilityCostData(UtilityCostPanelDataObj.UtilityCostDtoObj);
            #endregion  // PROJECT COST PARAMETERS PANEL DATA

        }
        #endregion  // UpdateProjectWrapperData(Guid projectId) ... UPDATE ... UPDATE ALL PROJECT DATA

        #region DeleteProjectWrapperData(Guid projectId) ... DELETE ... DELETE ALL PROJECT DATA
        /// <summary>
        /// Use the specified Project ID and ViewModel object 
        /// to DELETE ALL the Project Subpanel data in the HENSTUDIO DB.
        /// Cascading Delete is Controlled in SQL.
        /// </summary>
        /// <param name="projectId">The ID of the project-related data to DELETE.</param>
        public void DeleteProjectWrapperData(Guid projectId)
        {
            //-------------------------------------------------------
            //--- Null Guard on User Supplied Profile ID to Avoid ---
            //--- Null References in ViewModel Invocations        ---
            //-------------------------------------------------------   
            if (projectId == null) throw new ArgumentNullException(
                                         nameof(projectId), "Project ID cannot be null.");

            else ProjectWrapperDtoObj.ProjectId = projectId;
            //----------------------------------------------------
            //--- Use Project ID to DELETE Data from DB        ---
            //--- NOTE: Cascading Delete is controlled in SQL. ---
            //----------------------------------------------------
            ProjectPanelDataObj.DeleteProjectData(ProjectWrapperDtoObj.ProjectId);
        }
        #endregion  // DeleteProjectWrapperData(Guid projectId) ... DELETE ... DELETE ALL PROJECT DATA

        #endregion  // CRUD Methods
    }
    #endregion      // public class ProjectWrapperDto
}
#endregion      // namespace HenStudio.Data.Project

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
