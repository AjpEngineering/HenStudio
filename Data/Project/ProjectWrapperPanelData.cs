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

using HenGlobal;

using HenViewModel.Profile.Streams;

using HenStudio.Data.Profile.Streams;

using HenViewModel.Profile;

using HenStudio.Data.Profile;
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

        #region PROJECT ID
        public Guid ProjectId { get; set; }     //--- PROJECT Identifier
        #endregion  // // PROJECT ID

        #region PanelData Objects
        public ProjectPanelData ProjectPanelDataObj { get; set; }

        public ExchangerParamsPanelData ExchangerParamsPanelDataObj { get; set; }
        public OptimizerParamsPanelData OptimizerParamsPanelDataObj { get; set; }
        public ProjectUnitsPanelData ProjectUnitsPanelDataObj { get; set; }

        public HeatTransferCoeffPanelData HeatTransferCoeffPanelDataObj { get; set; }

        public CostMetadataPanelData CostMetadataPanelDataObj { get; set; }
        public FiredHeaterCapitalCostPanelData FiredHeaterCapitalCostPanelDataObj { get; set; }
        public ShellAndTubeCapitalCostPanelData ShellAndTubeCapitalCostPanelDataObj { get; set; }
        public TotalAnnualizedCostPanelData TotalAnnualizedCostPanelDataObj { get; set; }
        public UtilityCostPanelData UtilityCostPanelDataObj { get; set; }
        #endregion      // PanelData Objects

        #region VIEW MODEL Objects
        public ProjectViewModel ProjectViewModelObj { get; set; }
        
        public ExchangerParamsViewModel ExchangerParamsViewModelObj { get; set; }
        public OptimizerParamsViewModel OptimizerParamsViewModelObj { get; set; }
        public ProjectUnitsViewModel ProjectUnitsViewModelObj { get; set; }

        public CostMetadataViewModel CostMetadataViewModelObj { get; set; }
        public FiredHeaterCapitalCostViewModel FiredHeaterCapitalCostViewModelObj { get; set; }
        public ShellAndTubeCapitalCostViewModel ShellAndTubeCapitalCostViewModelObj { get; set; }
        public TotalAnnualizedCostViewModel TotalAnnualizedCostViewModelObj { get; set; }
        public UtilityCostViewModel UtilityCostViewModelObj { get; set; }
        #endregion  //  VIEW MODEL Objects

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
            ProjectId = Guid.Empty;
            //-----------------------------------------------------------------
            //--- Initialize PanelData Objects to Avoid Null Reference Exceptions ---
            //-----------------------------------------------------------------
            ProjectPanelDataObj = new ProjectPanelData();

            ExchangerParamsPanelDataObj = new ExchangerParamsPanelData();
            OptimizerParamsPanelDataObj = new OptimizerParamsPanelData();
            ProjectUnitsPanelDataObj = new ProjectUnitsPanelData();

            HeatTransferCoeffPanelDataObj = new HeatTransferCoeffPanelData("English");

            CostMetadataPanelDataObj = new CostMetadataPanelData();
            FiredHeaterCapitalCostPanelDataObj = new FiredHeaterCapitalCostPanelData();
            ShellAndTubeCapitalCostPanelDataObj = new ShellAndTubeCapitalCostPanelData();
            TotalAnnualizedCostPanelDataObj = new TotalAnnualizedCostPanelData();
            UtilityCostPanelDataObj = new UtilityCostPanelData();
            //-----------------------------------------------------------------------
            //--- Initialize ViewModel Objects to Avoid Null Reference Exceptions ---
            //-----------------------------------------------------------------------
            ProjectViewModelObj = new ProjectViewModel();

            ExchangerParamsViewModelObj = new ExchangerParamsViewModel();
            OptimizerParamsViewModelObj = new OptimizerParamsViewModel();
            ProjectUnitsViewModelObj = new ProjectUnitsViewModel();

            CostMetadataViewModelObj = new CostMetadataViewModel();
            FiredHeaterCapitalCostViewModelObj = new FiredHeaterCapitalCostViewModel();
            ShellAndTubeCapitalCostViewModelObj = new ShellAndTubeCapitalCostViewModel();
            TotalAnnualizedCostViewModelObj = new TotalAnnualizedCostViewModel();
            UtilityCostViewModelObj = new UtilityCostViewModel();
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
            else ProjectId = projectId;

            //---------------------------------------------
            //--- Assign PanelData Object Id Properties ---
            //---------------------------------------------
            ProjectPanelDataObj.Id = ProjectId;

            ExchangerParamsPanelDataObj.ProjectId = ProjectId;
            OptimizerParamsPanelDataObj.ProjectId = ProjectId;
            ProjectUnitsPanelDataObj.ProjectId = ProjectId;

            CostMetadataPanelDataObj.ProjectId = ProjectId;
            FiredHeaterCapitalCostPanelDataObj.ProjectId = ProjectId;
            ShellAndTubeCapitalCostPanelDataObj.ProjectId = ProjectId;
            TotalAnnualizedCostPanelDataObj.ProjectId = ProjectId;
            UtilityCostPanelDataObj.ProjectId = ProjectId;
            //--------------------------------------------------
            //--- Initialize Property HenProjectUnits Object ---
            //--------------------------------------------------
            ProjectUnitsDto projectUnitsDtoObj =
                            ProjectUnitsViewModelObj.GetProjectUnitsByProjectId(ProjectId);
            if (projectUnitsDtoObj != null)
                throw new Exception("Project Units DTO Object is null for Project ID: " + ProjectId);
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
            //--- Add Project Data to DB using Project ViewModel         ---
            //--- returns Project ID for Foreign Key Relationships in DB ---
            //--------------------------------------------------------------
            ProjectId = ProjectViewModelObj.AddProject(ProjectPanelDataObj.ProjectDtoObj);
            if (ProjectId == null) throw new ArgumentNullException(
                             nameof(ProjectId), "Project ID is null for ADD Project Panel data.");
            ProjectPanelDataObj.ProjectDtoObj.Id = ProjectId;

            #endregion  // PROJECT PANEL DATA

            //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

            #region PROJECT DEFAULT PARAMETERS PANELS DATA

            //----------------------------------------------------------------
            //--- Add ProjectUnits Data to DB using ProjectUnits ViewModel ---
            //--- returns Project ID for Foreign Key Relationships in DB   ---
            //----------------------------------------------------------------
            ProjectId = ProjectUnitsViewModelObj.AddProjectUnits(ProjectUnitsPanelDataObj.ProjectUnitsDtoObj);
            if (ProjectId == null) throw new ArgumentNullException(
                             nameof(ProjectId), "Project ID is null for ADD Project Units Panel data.");
            ProjectUnitsPanelDataObj.ProjectUnitsDtoObj.Id = ProjectId;
            //----------------------------------------------------------------------
            //--- Add ExchangerParams Data to DB using ExchangerParams ViewModel ---
            //--- returns Project ID for Foreign Key Relationships in DB         ---
            //----------------------------------------------------------------------
            ProjectId = ExchangerParamsViewModelObj.AddExchangerParams(ExchangerParamsPanelDataObj.ExchangerParamsDtoObj);
            if (ProjectId == null) throw new ArgumentNullException(
                             nameof(ProjectId), "Project ID is null for ADD Exchanger Params Panel data.");
            ExchangerParamsPanelDataObj.ExchangerParamsDtoObj.Id = ProjectId;
            //----------------------------------------------------------------------
            //--- Add OptimizerParams Data to DB using OptimizerParams ViewModel ---
            //--- returns Project ID for Foreign Key Relationships in DB         ---
            //----------------------------------------------------------------------
            ProjectId = OptimizerParamsViewModelObj.AddOptimizerParams(OptimizerParamsPanelDataObj.OptimizerParamsDtoObj);
            if (ProjectId == null) throw new ArgumentNullException(
                             nameof(ProjectId), "Project ID is null for ADD Optimizer Params Panel data.");
            OptimizerParamsPanelDataObj.OptimizerParamsDtoObj.Id = ProjectId;

            #endregion  // PROJECT DEFAULT PARAMETERS PANELS DATA

            //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

            #region PROJECT COST PARAMETERS PANELS DATA

            //----------------------------------------------------------------
            //--- Add CostMetadata Data to DB using CostMetadata ViewModel ---
            //--- returns Project ID for Foreign Key Relationships in DB   ---
            //----------------------------------------------------------------
            ProjectId = CostMetadataViewModelObj.AddCostMetadata(CostMetadataPanelDataObj.CostMetadataDtoObj);
            if (ProjectId == null) throw new ArgumentNullException(
                             nameof(ProjectId), "Project ID is null for ADD Cost Metadata Panel data.");
            CostMetadataPanelDataObj.CostMetadataDtoObj.Id = ProjectId;
            //------------------------------------------------------------------------------------
            //--- Add FiredHeaterCapitalCost Data to DB using FiredHeaterCapitalCost ViewModel ---
            //--- returns Project ID for Foreign Key Relationships in DB                       ---
            //------------------------------------------------------------------------------------
            ProjectId = FiredHeaterCapitalCostViewModelObj.AddFiredHeaterCapitalCost(FiredHeaterCapitalCostPanelDataObj.FiredHeaterCapitalCostDtoObj);
            if (ProjectId == null) throw new ArgumentNullException(
                             nameof(ProjectId), "Project ID is null for ADD Fired Heater Capital Cost Panel data.");
            FiredHeaterCapitalCostPanelDataObj.FiredHeaterCapitalCostDtoObj.Id = ProjectId;
            //--------------------------------------------------------------------------------------
            //--- Add ShellAndTubeCapitalCost Data to DB using ShellAndTubeCapitalCost ViewModel ---
            //--- returns Project ID for Foreign Key Relationships in DB                         ---
            //--------------------------------------------------------------------------------------
            ProjectId = ShellAndTubeCapitalCostViewModelObj.AddShellAndTubeCapitalCost(ShellAndTubeCapitalCostPanelDataObj.ShellAndTubeCapitalCostDtoObj);
            if (ProjectId == null) throw new ArgumentNullException(
                             nameof(ProjectId), "Project ID is null for ADD Shell And Tube Capital Cost Panel data.");
            ShellAndTubeCapitalCostPanelDataObj.ShellAndTubeCapitalCostDtoObj.Id = ProjectId;
            //------------------------------------------------------------------------------
            //--- Add TotalAnnualizedCost Data to DB using TotalAnnualizedCost ViewModel ---
            //--- returns Project ID for Foreign Key Relationships in DB                 ---
            //------------------------------------------------------------------------------
            ProjectId = TotalAnnualizedCostViewModelObj.AddTotalAnnualizedCost(TotalAnnualizedCostPanelDataObj.TotalAnnualizedCostDtoObj);
            if (ProjectId == null) throw new ArgumentNullException(
                             nameof(ProjectId), "Project ID is null for ADD Total Annualized Cost Panel data.");
            TotalAnnualizedCostPanelDataObj.TotalAnnualizedCostDtoObj.Id = ProjectId;
            //--------------------------------------------------------------
            //--- Add UtilityCost Data to DB using UtilityCost ViewModel ---
            //--- returns Project ID for Foreign Key Relationships in DB ---
            //--------------------------------------------------------------
            ProjectId = UtilityCostViewModelObj.AddUtilityCost(UtilityCostPanelDataObj.UtilityCostDtoObj);
            if (ProjectId == null) throw new ArgumentNullException(
                             nameof(ProjectId), "Project ID is null for ADD Utility Cost Panel data.");
            UtilityCostPanelDataObj.UtilityCostDtoObj.Id = ProjectId;

            #endregion  // PROJECT COST PARAMETERS PANELS DATA

            //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

            return ProjectId;
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
            else ProjectId = projectId;
            //----------------------------------------------------------
            //--- READ Project Data from DB using Project ViewModels ---
            //--- NOTE: ViewModel Return DTO Objects, and PanelData  ---
            //--- Objects are Populated using the DTO Objects        ---
            //----------------------------------------------------------
            #region PROJECT PANEL DATA
            ProjectPanelDataObj.Id = ProjectId;
            ProjectPanelDataObj.ProjectDtoObj = ProjectViewModelObj.GetProjectById(projectId);
            #endregion  // PROJECT PANEL DATA

            #region PROJECT DEFAULT PARAMETERS PANELS DATA
            ExchangerParamsPanelDataObj.ProjectId = ProjectId;
            ExchangerParamsPanelDataObj.ExchangerParamsDtoObj = ExchangerParamsViewModelObj.GetExchangerParamsByProjectId(projectId);

            OptimizerParamsPanelDataObj.ProjectId = ProjectId;
            OptimizerParamsPanelDataObj.OptimizerParamsDtoObj = OptimizerParamsViewModelObj.GetOptimizerParamsByProjectId(projectId);
            
            ProjectUnitsPanelDataObj.ProjectId = ProjectId;
            ProjectUnitsPanelDataObj.ProjectUnitsDtoObj = ProjectUnitsViewModelObj.GetProjectUnitsByProjectId(projectId);

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
            CostMetadataPanelDataObj.ProjectId = ProjectId;
            CostMetadataPanelDataObj.CostMetadataDtoObj = CostMetadataViewModelObj.GetCostMetadataByProjectId(projectId);

            FiredHeaterCapitalCostPanelDataObj.ProjectId = ProjectId;
            FiredHeaterCapitalCostPanelDataObj.FiredHeaterCapitalCostDtoObj = FiredHeaterCapitalCostViewModelObj.GetFiredHeaterCapitalCostByProjectId(projectId);

            ShellAndTubeCapitalCostPanelDataObj.ProjectId = ProjectId;
            ShellAndTubeCapitalCostPanelDataObj.ShellAndTubeCapitalCostDtoObj = ShellAndTubeCapitalCostViewModelObj.GetShellAndTubeCapitalCostByProjectId(projectId);

            TotalAnnualizedCostPanelDataObj.ProjectId = ProjectId;
            TotalAnnualizedCostPanelDataObj.TotalAnnualizedCostDtoObj = TotalAnnualizedCostViewModelObj.GetTotalAnnualizedCostByProjectId(projectId);

            UtilityCostPanelDataObj.ProjectId = ProjectId;
            UtilityCostPanelDataObj.UtilityCostDtoObj = UtilityCostViewModelObj.GetUtilityCostByProjectId(projectId);            
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
            else ProjectId = projectId;
            //----------------------------------------------------------
            //--- UPDATE Project Data from DB using Project ViewModels ---
            //--- NOTE: ViewModel Return DTO Objects, and PanelData  ---
            //--- Objects are Populated using the DTO Objects        ---
            //----------------------------------------------------------

            #region PROJECT PANEL DATA
            ProjectPanelDataObj.Id = ProjectId;
            ProjectViewModelObj.UpdateProject(ProjectPanelDataObj.ProjectDtoObj);
            #endregion  // PROJECT PANEL DATA

            #region PROJECT DEFAULT PARAMETERS PANEL DATA
            ExchangerParamsPanelDataObj.Id = ProjectId;
            ExchangerParamsViewModelObj.UpdateExchangerParams(ExchangerParamsPanelDataObj.ExchangerParamsDtoObj);
            
            OptimizerParamsPanelDataObj.Id = ProjectId;
            OptimizerParamsViewModelObj.UpdateOptimizerParams(OptimizerParamsPanelDataObj.OptimizerParamsDtoObj);
            
            ProjectUnitsPanelDataObj.Id = ProjectId;
            ProjectUnitsViewModelObj.UpdateProjectUnits(ProjectUnitsPanelDataObj.ProjectUnitsDtoObj);
            #endregion  // PROJECT DEFAULT PARAMETERS PANEL DATA

            #region PROJECT COST PARAMETERS PANEL DATA
            CostMetadataPanelDataObj.Id = ProjectId;
            CostMetadataViewModelObj.UpdateCostMetadata(CostMetadataPanelDataObj.CostMetadataDtoObj);
            
            FiredHeaterCapitalCostPanelDataObj.Id = ProjectId;
            FiredHeaterCapitalCostViewModelObj.UpdateFiredHeaterCapitalCost(FiredHeaterCapitalCostPanelDataObj.FiredHeaterCapitalCostDtoObj);
            
            ShellAndTubeCapitalCostPanelDataObj.Id = ProjectId;
            ShellAndTubeCapitalCostViewModelObj.UpdateShellAndTubeCapitalCost(ShellAndTubeCapitalCostPanelDataObj.ShellAndTubeCapitalCostDtoObj);
           
            TotalAnnualizedCostPanelDataObj.Id = ProjectId;
            TotalAnnualizedCostViewModelObj.UpdateTotalAnnualizedCost(TotalAnnualizedCostPanelDataObj.TotalAnnualizedCostDtoObj);
            
            UtilityCostPanelDataObj.Id = ProjectId;
            UtilityCostViewModelObj.UpdateUtilityCost(UtilityCostPanelDataObj.UtilityCostDtoObj);
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
            else ProjectId = projectId;
            //----------------------------------------------------
            //--- Use ViewModel to DELETE Data from DB         ---
            //--- NOTE: Cascading Delete is controlled in SQL. ---
            //----------------------------------------------------
            ProjectViewModelObj.DeleteProject(ProjectId);
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
