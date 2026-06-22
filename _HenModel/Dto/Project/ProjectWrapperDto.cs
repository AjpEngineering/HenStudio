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
        //------------------------------------------------------- IDs ---
        //--- Initialize IDs to -1 to Avoid Null Reference Exceptions ---
        //---------------------------------------------------------------
        public int ProjectId { get; set; } = -1;

        public int ProjectUnitsId { get; set; } = -1;
        public int ExchangerParamsId { get; set; } = -1;
        public int OptimizerParamsId { get; set; } = -1;

        public int CostMetadataId { get; set; } = -1;
        public int FiredHeaterCapitalCostId { get; set; } = -1;
        public int ShellAndTubeCapitalCostId { get; set; } = -1;
        public int TotalAnnualizedCostId { get; set; } = -1;
        public int UtilityCostId { get; set; } = -1;

        //------------------------------------------------- DTOs ---
        //--- Initialize DTOs to Avoid Null Reference Exceptions ---
        //----------------------------------------------------------
        public ProjectDto ProjectDtoObj { get; set; } = new ProjectDto();

        public ProjectUnitsDto ProjectUnitsDtoObj { get; set; } = new ProjectUnitsDto();
        public ExchangerParamsDto ExchangerParamsDtoObj{ get; set; } = new ExchangerParamsDto();
        public OptimizerParamsDto OptimizerParamsDtoObj { get; set; } = new OptimizerParamsDto();

        public CostMetadataDto CostMetadataDtoObj { get; set; } = new CostMetadataDto();
        public FiredHeaterCapitalCostDto FiredHeaterCapitalCostDtoObj { get; set; } = new FiredHeaterCapitalCostDto();
        public ShellAndTubeCapitalCostDto ShellAndTubeCapitalCostDtoObj { get; set; } = new ShellAndTubeCapitalCostDto();
        public TotalAnnualizedCostDto TotalAnnualizedCostDtoObj { get; set; } = new TotalAnnualizedCostDto();
        public UtilityCostDto UtilityCostDtoObj { get; set; } = new UtilityCostDto();

        #endregion      // PROPERTIES

        //#region CTOR
        ///// <summary>
        ///// Default Constructor for ProjectWrapperDto Class
        ///// </summary>
        //public ProjectWrapperDto()
        //{
        //}
        //#endregion  // CTOR

    }
    #endregion      // public class ProjectWrapperDto
}
#endregion      // namespace HenModel.Dto.Project

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
