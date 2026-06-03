#region HEADER
//#####################################################################################################################
//#############################  O p t i m i z e r P a r a m s P a n e l D a t a . c s  ###############################
//#####################################################################################################################
//  FILENAME:  OptimizerParamsPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.DefaultParameters.OptimizerParams
//  CLASS(S):  OptimizerParamsPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Optimizer Params Panel Data object - data needed for Optimizer Params Panel.
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
//    01/01/26 .. pg .. Version 4.0
//#####################################################################################################################
//#####################################################################################################################
//#####################################################################################################################
#endregion      // HEADER

#region REFERENCES
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;

using HenViewModel.Project.DefaultParameters.OptimizerParams;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Project.DefaultParameters.OptimizerParams
namespace HenStudio.Data.Project.DefaultParameters.OptimizerParams
{
    #region public class OptimizerParamsPanelData
    public class OptimizerParamsPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.DefaultParameters.OptimizerParams";
        const string CLASS = "OptimizerParamsPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public Guid OptimizerParamsId { get; set; }
        public Guid ProjectId { get; set; }
        public OptimizerParamsDto OptimizerParamsDtoObj { get; set; }

        #region VIEW MODEL Object
        public OptimizerParamsViewModel OptimizerParamsViewModelObj { get; set; }
        #endregion  // VIEW MODEL Objects

        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for the OptimizerParamsPanelData class. 
        /// Initializes all properties to their default values. 
        /// </summary>
        public OptimizerParamsPanelData()
        {
            OptimizerParamsId = new Guid();
            ProjectId = new Guid();
            OptimizerParamsDtoObj = new OptimizerParamsDto();
        }
        #endregion  // CTOR

        #region CRUD Methods

        #region CREATE OPTIMIZER PARAMS DATA METHOD
        /// <summary>
        /// Creates a new optimizer params data using the data in the OptimizerParamsDtoObj property 
        /// and returns the ID of the newly created optimizer params data.
        /// </summary>
        /// <returns>The ID of the newly created optimizer params data.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the optimizer params ID is null after creation.</exception>
        public Guid CreateOptimizerParamsData()
        {
            OptimizerParamsId = OptimizerParamsViewModelObj.AddOptimizerParams(OptimizerParamsDtoObj);

            if (OptimizerParamsId == null) throw new ArgumentNullException(
                             nameof(OptimizerParamsId), "Optimizer params ID is null for ADD Optimizer Params Panel data.");

            OptimizerParamsDtoObj.Id = OptimizerParamsId;
            return OptimizerParamsId;  // OptimizerParams ID
        }
        #endregion  // CREATE OPTIMIZER PARAMS DATA METHOD

        #region READ OPTIMIZER PARAMS DATA METHOD
        /// <summary>
        /// Reads the optimizer params data for the specified project ID 
        /// and populates the OptimizerParamsDtoObj property with the retrieved data.
        /// </summary>
        /// <param name="projectId">The ID of the project to read.</param>
        /// <exception cref="ArgumentNullException">Thrown when the project ID is null.</exception>
        public void ReadOptimizerParamsData(Guid projectId)
        {
            if (projectId == null) throw new ArgumentNullException(
                             nameof(projectId), "Project ID is null for READ Optimizer Params Panel data.");
            ProjectId = projectId;
            OptimizerParamsDtoObj = OptimizerParamsViewModelObj.GetOptimizerParamsByProjectId(projectId);
        }
        #endregion  // READ OPTIMIZER PARAMS DATA METHOD

        #region UPDATE OPTIMIZER PARAMS DATA METHOD
        /// <summary>
        /// Updates the optimizer params data using the provided OptimizerParamsDto object 
        /// and returns the updated OptimizerParamsDto object.
        /// </summary>
        /// <param name="optimizerParamsDtoObj">The OptimizerParamsDto object containing 
        /// the updated optimizer params data.</param>
        /// <returns>The updated OptimizerParamsDto object.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the optimizer params DTO or its ID is null.</exception>
        public OptimizerParamsDto UpdateOptimizerParamsData(OptimizerParamsDto optimizerParamsDtoObj)
        {
            if (optimizerParamsDtoObj == null) throw new ArgumentNullException(
                             nameof(optimizerParamsDtoObj), "Optimizer Params DTO is null for UPDATE Optimizer Params Panel data.");

            if (optimizerParamsDtoObj.Id == null) throw new ArgumentNullException(
                             nameof(optimizerParamsDtoObj), "Optimizer Params DTO ID is null for UPDATE Optimizer Params Panel data.");

            if (optimizerParamsDtoObj.ProjectId == null) throw new ArgumentNullException(
                             nameof(optimizerParamsDtoObj), "Optimizer Params DTO Project ID is null for UPDATE Optimizer Params Panel data.");

            OptimizerParamsId = optimizerParamsDtoObj.Id;
            ProjectId = optimizerParamsDtoObj.ProjectId;
            OptimizerParamsDtoObj = optimizerParamsDtoObj;
            OptimizerParamsViewModelObj.UpdateOptimizerParams(optimizerParamsDtoObj);
            return OptimizerParamsDtoObj;
        }
        #endregion  // UPDATE PROJECT DATA METHOD

        #endregion  // CRUD Methods

    }
    #endregion      // public class OptimizerParamsPanelData
}
#endregion  // namespace HenStudio.Data.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
