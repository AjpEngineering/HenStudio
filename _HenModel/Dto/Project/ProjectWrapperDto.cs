#region HEADER
//#####################################################################################################################
//#####################################  P r o j e c t W r a p p e r D t o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  ProjectWrapperDto.cs
//  NAMESPACE: HenModel.Dto.Project
//  CLASS(S):  ProjectWrapperDto
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the Project Wrapper DTO.
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
using HenModel.Dto.Project;
using HenModel.Dto.Project.DefaultParameters;
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

using HenModel.Dto.Project.CostParameters;

using System;
#endregion      // REFERENCES

#region namespace HenModel.Dto.Project
namespace HenModel.Dto.Project
{
    #region public class ProjectWrapperDto
    /// <summary>
    /// Project Wrapper DTO Class
    /// </summary>
    public class ProjectWrapperDto
    {
        #region PROPERTIES
        //------------------------------------------------------------- IDs ---
        public Guid ProjectId { get; set; }

        public Guid ProjectUnitsId { get; set; }
        public Guid ExchangerParamsId { get; set; }
        public Guid OptimizerParamsId { get; set; }

        public Guid CostMetadataId { get; set; }
        public Guid FiredHeaterCapitalCostId { get; set; }
        public Guid ShellAndTubeCapitalCostId { get; set; }
        public Guid TotalAnnualizedCostId { get; set; }
        public Guid UtilityCostId { get; set; }

        //------------------------------------------------------------ DTOs ---
        public ProjectDto ProjectDtoObj { get; set; }

        public ProjectUnitsDto ProjectUnitsDtoObj { get; set; }
        public ExchangerParamsDto ExchangerParamsDtoObj{ get; set; }
        public OptimizerParamsDto OptimizerParamsDtoObj { get; set; }

        public CostMetadataDto CostMetadataDtoObj { get; set; }
        public FiredHeaterCapitalCostDto FiredHeaterCapitalCostDtoObj { get; set; }
        public ShellAndTubeCapitalCostDto ShellAndTubeCapitalCostDtoObj { get; set; }
        public TotalAnnualizedCostDto TotalAnnualizedCostDtoObj { get; set; }
        public UtilityCostDto UtilityCostDtoObj { get; set; }

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor for ProjectWrapperDto Class
        /// </summary>
        public ProjectWrapperDto()
        {
            InitializeDto();
        }
        #endregion  // CTOR

        #region INITIALIZE DTO
        /// <summary>
        /// Method to Initialize DTO Properties to Avoid Null Reference Exceptions
        /// </summary>
        private void InitializeDto()
        {
            //------------------------------------------------------------------------
            //--- Initialize IDs to Empty GUIDs to Avoid Null Reference Exceptions ---
            //------------------------------------------------------------------------
            ProjectId = Guid.Empty;
            ProjectUnitsId = Guid.Empty;
            ExchangerParamsId = Guid.Empty;
            OptimizerParamsId = Guid.Empty;
            CostMetadataId = Guid.Empty;
            FiredHeaterCapitalCostId = Guid.Empty;
            ShellAndTubeCapitalCostId = Guid.Empty;
            TotalAnnualizedCostId = Guid.Empty;
            UtilityCostId = Guid.Empty;
            //----------------------------------------------------------
            //--- Initialize DTOs to Avoid Null Reference Exceptions ---
            //----------------------------------------------------------
            ProjectDtoObj = new ProjectDto();

            ExchangerParamsDtoObj = new ExchangerParamsDto();
            OptimizerParamsDtoObj = new OptimizerParamsDto();
            ProjectUnitsDtoObj = new ProjectUnitsDto();

            CostMetadataDtoObj = new CostMetadataDto();
            FiredHeaterCapitalCostDtoObj = new FiredHeaterCapitalCostDto();
            ShellAndTubeCapitalCostDtoObj = new ShellAndTubeCapitalCostDto();
            TotalAnnualizedCostDtoObj = new TotalAnnualizedCostDto();
            UtilityCostDtoObj = new UtilityCostDto();
        }
        #endregion  // INITIALIZE DTO

    }
    #endregion      // public class ProjectWrapperDto
}
#endregion      // namespace HenModel.Dto.Project

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
