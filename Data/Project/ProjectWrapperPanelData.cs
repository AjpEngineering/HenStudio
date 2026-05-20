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
        //---------- Unique Identifier for the Project ------------
        public Guid ProjectId { get; set; }
        #endregion  // // PROJECT ID

        #region VIEW MODEL Objects
        //---------- Project SUB-PANEL ViewModel Objects ----------
        public ProjectViewModel ProjectViewModelObj { get; set; }
        
        //---------- Default Parameters SUB-PANEL ViewModel Objects ----------
        public ExchangerParamsViewModel ExchangerParamsViewModelObj { get; set; }
        public OptimizerParamsViewModel OptimizerParamsViewModelObj { get; set; }
        public ProjectUnitsViewModel ProjectUnitsViewModelObj { get; set; }

        //---------- Cost Parameters SUB-PANEL ViewModel Objects ----------
        public CostMetadataViewModel CostMetadataViewModelObj { get; set; }
        public FiredHeaterCapitalCostViewModel FiredHeaterCapitalCostViewModelObj { get; set; }
        public ShellAndTubeCapitalCostViewModel ShellAndTubeCapitalCostViewModelObj { get; set; }
        public TotalAnnualizedCostViewModel TotalAnnualizedCostViewModelObj { get; set; }
        public UtilityCostViewModel UtilityCostViewModelObj { get; set; }
        #endregion  //  VIEW MODEL Objects

        #region PanelData Objects
        //---------- Project SUB-PANEL PanelData Objects ----------
        public ProjectPanelData ProjectPanelDataObj { get; set; }

        //---------- Default Parameters SUB-PANEL PanelData Objects ----------
        public ExchangerParamsPanelData ExchangerParamsPanelDataObj{ get; set; }
        public OptimizerParamsPanelData OptimizerParamsPanelDataObj { get; set; }
        public ProjectUnitsPanelData ProjectUnitsPanelDataObj { get; set; }

        //---------- Cost Parameters SUB-PANEL PanelData Objects ----------
        public CostMetadataPanelData CostMetadataPanelDataObj { get; set; }
        public FiredHeaterCapitalCostPanelData FiredHeaterCapitalCostPanelDataObj { get; set; }
        public ShellAndTubeCapitalCostPanelData ShellAndTubeCapitalCostPanelDataObj { get; set; }
        public TotalAnnualizedCostPanelData TotalAnnualizedCostPanelDataObj { get; set; }
        public UtilityCostPanelData UtilityCostPanelDataObj { get; set; }
        #endregion      // PanelData Objects

        #endregion      // PROPERTIES

        #region Default CTOR
        /// <summary>
        /// Default Constructor for ProjectWrapperData Class
        /// </summary>
        public ProjectWrapperPanelData()
        {
            ProjectId = Guid.Empty;
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
            //-----------------------------------------------------------------
            //--- Initialize PanelData Objects to Avoid Null Reference Exceptions ---
            //-----------------------------------------------------------------
            ProjectPanelDataObj = new ProjectPanelData();

            ExchangerParamsPanelDataObj = new ExchangerParamsPanelData();
            OptimizerParamsPanelDataObj = new OptimizerParamsPanelData();
            ProjectUnitsPanelDataObj = new ProjectUnitsPanelData();
            CostMetadataPanelDataObj = new CostMetadataPanelData();
            FiredHeaterCapitalCostPanelDataObj = new FiredHeaterCapitalCostPanelData();
            ShellAndTubeCapitalCostPanelDataObj = new ShellAndTubeCapitalCostPanelData();
            TotalAnnualizedCostPanelDataObj = new TotalAnnualizedCostPanelData();
            UtilityCostPanelDataObj = new UtilityCostPanelData();
        }
        #endregion  // Default CTOR

        #region FULL Parameterized CTOR
        /// <summary>
        /// FULL Parameterized Constructor for ProjectWrapperData Class
        /// </summary>
        public ProjectWrapperPanelData(Guid projectId,
                                  ProjectPanelData projectPanelDataObj,
                                  ExchangerParamsPanelData exchangerParamsPanelDataObj,
                                  OptimizerParamsPanelData optimizerParamsPanelDataObj,
                                  ProjectUnitsPanelData projectUnitsPanelDataObj,
                                  CostMetadataPanelData costMetadataPanelDataObj,
                                  FiredHeaterCapitalCostPanelData firedHeaterCapitalCostPanelDataObj,
                                  ShellAndTubeCapitalCostPanelData shellAndTubeCapitalCostPanelDataObj,
                                  TotalAnnualizedCostPanelData totalAnnualizedCostPanelDataObj,
                                  UtilityCostPanelData utilityCostPanelDataObj)
        {
            //-------------------------------------------------------------------------------------
            //--- Null Guard on User Supplied PanelData Parameters to Avoid Null Reference Exceptions ---
            //-------------------------------------------------------------------------------------   
            if (projectId == null) ProjectId = new Guid();
            else ProjectId = projectId;

            //--- Project SUB-PANEL PanelData Objects ---
            if (projectPanelDataObj == null) ProjectPanelDataObj = new ProjectPanelData();
            else ProjectPanelDataObj = projectPanelDataObj;

            //--- Default Parameters SUB-PANEL PanelData Objects ---
            if (exchangerParamsPanelDataObj == null) ExchangerParamsPanelDataObj = new ExchangerParamsPanelData();
            else ExchangerParamsPanelDataObj = exchangerParamsPanelDataObj;

            if (optimizerParamsPanelDataObj == null) OptimizerParamsPanelDataObj = new OptimizerParamsPanelData();
            else OptimizerParamsPanelDataObj = optimizerParamsPanelDataObj;

            if (projectUnitsPanelDataObj == null) ProjectUnitsPanelDataObj = new ProjectUnitsPanelData();
            else ProjectUnitsPanelDataObj = projectUnitsPanelDataObj;

            //--- Cost Parameters SUB-PANEL PanelData Objects ---
            if (costMetadataPanelDataObj == null) CostMetadataPanelDataObj = new CostMetadataPanelData();
            else CostMetadataPanelDataObj = costMetadataPanelDataObj;

            if (firedHeaterCapitalCostPanelDataObj == null) FiredHeaterCapitalCostPanelDataObj = new FiredHeaterCapitalCostPanelData();
            else FiredHeaterCapitalCostPanelDataObj = firedHeaterCapitalCostPanelDataObj;

            if (shellAndTubeCapitalCostPanelDataObj == null) ShellAndTubeCapitalCostPanelDataObj = new ShellAndTubeCapitalCostPanelData();
            else ShellAndTubeCapitalCostPanelDataObj = shellAndTubeCapitalCostPanelDataObj;

            if (totalAnnualizedCostPanelDataObj == null) TotalAnnualizedCostPanelDataObj = new TotalAnnualizedCostPanelData();
            else TotalAnnualizedCostPanelDataObj = totalAnnualizedCostPanelDataObj;

            if (utilityCostPanelDataObj == null) UtilityCostPanelDataObj = new UtilityCostPanelData();
            else UtilityCostPanelDataObj = utilityCostPanelDataObj;
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
        }
        #endregion  // FULL Parameterized CTOR

        #region CRUD Methods

        #region CreateProjectWrapperData()
        /// <summary>
        /// Use the DTO and ViewModel object properties of this class to 
        /// CREATE ALL the new Project Subpanel data in the HENSTUDIO DB.
        /// </summary>
        /// <returns>Project ID of the newly created project-related data.</returns>
        public Guid CreateProjectWrapperData()
        {
            //-----------------------------------------------------------
            //--- Convert PanelData Objects to EXTERNAL DTO Objects   ---
            //--- and Use Project ViewModel to Add Project Data to DB ---
            //--- NOTE: ProjectViewModel Add Method Returns the       ---
            //--- Project ID of the Newly Created Project Data in DB  ---
            //-----------------------------------------------------------
            ProjectId = ProjectViewModelObj.AddProject(ProjectPanelDataObj.ConvertFromPanelData());
            //-------------------------------------------------------
            //--- Null Guard on ViewModel returned Project ID to  ---
            //--- Avoid Null  References in ViewModel Invocations ---
            //-------------------------------------------------------   
            if (ProjectId == null) throw new ArgumentNullException(nameof(ProjectId), "Project ID cannot be null.");
            //---------------------------------------------------------
            //--- Convert PanelData Objects to EXTERNAL DTO Objects ---
            //---------------------------------------------------------
            var ExchangerParamsDto = ExchangerParamsPanelDataObj.ConvertFromPanelData();
            var OptimizerParamsDto = OptimizerParamsPanelDataObj.ConvertFromPanelData();
            var ProjectUnitsDto = ProjectUnitsPanelDataObj.ConvertFromPanelData();

            var CostMetadataDto = CostMetadataPanelDataObj.ConvertFromPanelData();
            var FiredHeaterCapitalCostDto = FiredHeaterCapitalCostPanelDataObj.ConvertFromPanelData();
            var ShellAndTubeCapitalCostDto = ShellAndTubeCapitalCostPanelDataObj.ConvertFromPanelData();
            var TotalAnnualizedCostDto = TotalAnnualizedCostPanelDataObj.ConvertFromPanelData();
            var UtilityCostDto = UtilityCostPanelDataObj.ConvertFromPanelData();

            //-----------------------------------------------------
            //--- Use Project ID from Created Project to Ensure ---
            //--- Proper Foreign Key Relationships in DB        ---
            //--- NOTE: This is Done for All Subpanel Data to   ---
            //--- Ensure Proper Foreign Key Relationships in DB ---
            //-----------------------------------------------------
            ExchangerParamsDto.ProjectId = ProjectId;
            OptimizerParamsDto.ProjectId = ProjectId;
            ProjectUnitsDto.ProjectId = ProjectId;

            CostMetadataDto.ProjectId = ProjectId;
            FiredHeaterCapitalCostDto.ProjectId = ProjectId;
            ShellAndTubeCapitalCostDto.ProjectId = ProjectId;
            TotalAnnualizedCostDto.ProjectId = ProjectId;
            UtilityCostDto.ProjectId = ProjectId;

            //----------------------------------------------------
            //--- Use ViewModel to Add EXTERNAL DTO Data to DB ---
            //----------------------------------------------------
            var ExchangerParamsId = ExchangerParamsViewModelObj.AddExchangerParams(ExchangerParamsDto);
            var OptimizerParamsId = OptimizerParamsViewModelObj.AddOptimizerParams(OptimizerParamsDto);
            var ProjectUnitsId = ProjectUnitsViewModelObj.AddProjectUnits(ProjectUnitsDto);

            var CostMetadataId = CostMetadataViewModelObj.AddCostMetadata(CostMetadataDto);
            var FiredHeaterCapitalCostId = FiredHeaterCapitalCostViewModelObj.AddFiredHeaterCapitalCost(FiredHeaterCapitalCostDto);
            var ShellAndTubeCapitalCostId = ShellAndTubeCapitalCostViewModelObj.AddShellAndTubeCapitalCost(ShellAndTubeCapitalCostDto);
            var TotalAnnualizedCostId = TotalAnnualizedCostViewModelObj.AddTotalAnnualizedCost(TotalAnnualizedCostDto);
            var UtilityCostId = UtilityCostViewModelObj.AddUtilityCost(UtilityCostDto);

            return ProjectId;
        }
        #endregion  // CreateProjectWrapperData()

        #region ReadProjectWrapperData(Guid projectId)
        /// <summary>
        /// Retrieve (READ) the Project Wrapper Data for a Given Project ID. 
        /// This method will be used to Populate the Project Wrapper Data Object 
        /// with Data from the DB for a Given Project ID when the User Selects 
        /// a Project from the UI.
        /// </summary>
        /// <param name="projectId">The ID of the project-related data to READ.</param>
        public void ReadProjectWrapperData(Guid projectId)
        {
            //------------------------------------------------------------
            //--- Null Guard on User Supplied Project ID to Avoid Null ---
            //--- References in ViewModel Invocations                  ---
            //------------------------------------------------------------   
            if (projectId == null) throw new ArgumentNullException(nameof(projectId), "Project ID cannot be null.");
            else ProjectId = projectId;
            //----------------------------------------------------------
            //--- READ Project Data from DB using Project ViewModels ---
            //--- NOTE: ViewModel Return DTO Objects, and PanelData  ---
            //--- Objects are Populated using the DTO Objects        ---
            //----------------------------------------------------------
            ProjectPanelDataObj.ConvertToPanelData(ProjectViewModelObj.GetProjectById(projectId));

            ExchangerParamsPanelDataObj.ConvertToPanelData(ExchangerParamsViewModelObj.GetExchangerParamsByProjectId(projectId));
            OptimizerParamsPanelDataObj.ConvertToPanelData(OptimizerParamsViewModelObj.GetOptimizerParamsByProjectId(projectId));
            ProjectUnitsPanelDataObj.ConvertToPanelData(ProjectUnitsViewModelObj.GetProjectUnitsByProjectId(projectId));

            CostMetadataPanelDataObj.ConvertToPanelData(CostMetadataViewModelObj.GetCostMetadataByProjectId(projectId));
            FiredHeaterCapitalCostPanelDataObj.ConvertToPanelData(FiredHeaterCapitalCostViewModelObj.GetFiredHeaterCapitalCostByProjectId(projectId));
            ShellAndTubeCapitalCostPanelDataObj.ConvertToPanelData(ShellAndTubeCapitalCostViewModelObj.GetShellAndTubeCapitalCostByProjectId(projectId));
            TotalAnnualizedCostPanelDataObj.ConvertToPanelData(TotalAnnualizedCostViewModelObj.GetTotalAnnualizedCostByProjectId(projectId));
            UtilityCostPanelDataObj.ConvertToPanelData(UtilityCostViewModelObj.GetUtilityCostByProjectId(projectId));
        }
        #endregion  // ReadProjectWrapperData(Guid projectId)

        #region UpdateProjectWrapperData(Guid projectId)
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
            if (projectId == null) throw new ArgumentNullException(nameof(projectId), "Project ID cannot be null.");
            else ProjectId = projectId;
            //---------------------------------------------------------
            //--- Convert PanelData Objects to EXTERNAL DTO Objects ---
            //---------------------------------------------------------
            var ProjectDto = ProjectPanelDataObj.ConvertFromPanelData();

            var ExchangerParamsDto = ExchangerParamsPanelDataObj.ConvertFromPanelData();
            var OptimizerParamsDto = OptimizerParamsPanelDataObj.ConvertFromPanelData();
            var ProjectUnitsDto = ProjectUnitsPanelDataObj.ConvertFromPanelData();

            var CostMetadataDto = CostMetadataPanelDataObj.ConvertFromPanelData();
            var FiredHeaterCapitalCostDto = FiredHeaterCapitalCostPanelDataObj.ConvertFromPanelData();
            var ShellAndTubeCapitalCostDto = ShellAndTubeCapitalCostPanelDataObj.ConvertFromPanelData();
            var TotalAnnualizedCostDto = TotalAnnualizedCostPanelDataObj.ConvertFromPanelData();
            var UtilityCostDto = UtilityCostPanelDataObj.ConvertFromPanelData();

            //-----------------------------------------------------
            //--- Use Project ID from Created Project to Ensure ---
            //--- Proper Foreign Key Relationships in DB        ---
            //--- NOTE: This is Done for All Subpanel Data to   ---
            //--- Ensure Proper Foreign Key Relationships in DB ---
            //-----------------------------------------------------
            ProjectDto.Id = ProjectId;

            ExchangerParamsDto.ProjectId = ProjectId;
            OptimizerParamsDto.ProjectId = ProjectId;
            ProjectUnitsDto.ProjectId = ProjectId;

            CostMetadataDto.ProjectId = ProjectId;
            FiredHeaterCapitalCostDto.ProjectId = ProjectId;
            ShellAndTubeCapitalCostDto.ProjectId = ProjectId;
            TotalAnnualizedCostDto.ProjectId = ProjectId;
            UtilityCostDto.ProjectId = ProjectId;

            //-------------------------------------------------------
            //--- Use ViewModel to UPDATE EXTERNAL DTO Data in DB ---
            //-------------------------------------------------------
            ProjectViewModelObj.UpdateProject(ProjectDto);

            ExchangerParamsViewModelObj.UpdateExchangerParams(ExchangerParamsDto);
            OptimizerParamsViewModelObj.UpdateOptimizerParams(OptimizerParamsDto);
            ProjectUnitsViewModelObj.UpdateProjectUnits(ProjectUnitsDto);

            CostMetadataViewModelObj.UpdateCostMetadata(CostMetadataDto);
            FiredHeaterCapitalCostViewModelObj.UpdateFiredHeaterCapitalCost(FiredHeaterCapitalCostDto);
            ShellAndTubeCapitalCostViewModelObj.UpdateShellAndTubeCapitalCost(ShellAndTubeCapitalCostDto);
            TotalAnnualizedCostViewModelObj.UpdateTotalAnnualizedCost(TotalAnnualizedCostDto);
            UtilityCostViewModelObj.UpdateUtilityCost(UtilityCostDto);
        }
        #endregion  // UpdateProjectWrapperData(Guid projectId)

        #region DeleteProjectWrapperData(Guid projectId)
        /// <summary>
        /// Use the specified Project ID and the DTO and ViewModel object 
        /// properties of this class to DELETE ALL the Project Subpanel 
        /// data in the HENSTUDIO DB.
        /// </summary>
        /// <param name="projectId">The ID of the project-related data to DELETE.</param>
        public void DeleteProjectWrapperData(Guid projectId)
        {
            //------------------------------------------------------------
            //--- Null Guard on User Supplied Project ID to Avoid Null ---
            //--- References in ViewModel Invocations                  ---
            //------------------------------------------------------------   
            if (projectId == null) throw new ArgumentNullException(nameof(projectId), "Project ID cannot be null.");
            else ProjectId = projectId;

            //---------------------------------------------------------
            //--- Use ViewModel to DELETE EXTERNAL DTO Data from DB ---
            //--- NOTE: Project Data MUST be Deleted LAST to Avoid  ---
            //--- Foreign Key Constraint Violations in DB           ---
            //---------------------------------------------------------
            ExchangerParamsViewModelObj.DeleteExchangerParams(ProjectId);
            OptimizerParamsViewModelObj.DeleteOptimizerParams(ProjectId);
            ProjectUnitsViewModelObj.DeleteProjectUnits(ProjectId);

            CostMetadataViewModelObj.DeleteCostMetadata(ProjectId);
            FiredHeaterCapitalCostViewModelObj.DeleteFiredHeaterCapitalCost(ProjectId);
            ShellAndTubeCapitalCostViewModelObj.DeleteShellAndTubeCapitalCost(ProjectId);
            TotalAnnualizedCostViewModelObj.DeleteTotalAnnualizedCost(ProjectId);
            UtilityCostViewModelObj.DeleteUtilityCost(ProjectId);

            //-----------------------------------------------
            //--- Project Table MUST BE LAST TO AVOID     ---
            //--- FOREIGN KEY CONSTRAINT VIOLATIONS IN DB ---
            //-----------------------------------------------
            ProjectViewModelObj.DeleteProject(ProjectId);
        }
        #endregion  // DeleteProjectWrapperData(Guid projectId)

        #endregion  // CRUD Methods
    }
    #endregion      // public class ProjectWrapperDto
}
#endregion      // namespace HenStudio.Data.Project

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
