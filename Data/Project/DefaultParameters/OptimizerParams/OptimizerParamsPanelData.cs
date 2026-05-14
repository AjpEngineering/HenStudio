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
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;

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
    public class OptimizerParamsPanelData : IOptimizerParamsPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.DefaultParameters.OptimizerParams";
        const string CLASS = "OptimizerParamsPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public OptimizerParamsDto OptimizerParamsDtoObj { get; set; }
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OptimizerType { get; set; }
        public string DefaultObjective { get; set; }
        public int DefaultMaxIterations { get; set; }
        public double DefaultConvergenceTolerance { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for the OptimizerParamsPanelData class. 
        /// Initializes all properties to their default values. 
        /// </summary>
        public OptimizerParamsPanelData()
        {
            OptimizerParamsDtoObj = new OptimizerParamsDto();
            Id = new Guid();
            ProjectId = new Guid();
            Name = string.Empty;
            Description = string.Empty;
            OptimizerType = string.Empty;
            DefaultObjective = string.Empty;
            DefaultMaxIterations = 99;
            DefaultConvergenceTolerance = 0.001;
        }
        #endregion  // CTOR

        #region STRING CONVERSION METHODS

        #region GetId()
        /// <summary>
        /// Gets the unique identifier of the project units as a string.
        /// </summary>
        /// <returns>A string representation of the project units' unique identifier.</returns>
        public string GetId()
        {
            return Id.ToString();
        }
        #endregion  // GetId()

        #region GetProjectId()
        /// <summary>
        /// Gets the unique identifier of the project as a string.
        /// </summary>
        /// <returns>A string representation of the project's unique identifier.</returns>
        public string GetProjectId()
        {
            return ProjectId.ToString();
        }
        #endregion  // GetProjectId()

        #region GetDefaultMaxIterations()
        /// <summary>
        /// Gets the default maximum number of iterations as a string.
        /// </summary>
        /// <returns>A string representation of the default maximum number of iterations.</returns>
        public string GetDefaultMaxIterations()
        {
            return DefaultMaxIterations.ToString();
        }
        #endregion  // GetDefaultMaxIterations()

        #region GetDefaultConvergenceTolerance()
        /// <summary>
        /// Gets the default convergence tolerance as a string.
        /// </summary>
        /// <returns>A string representation of the default convergence tolerance.</returns>
        public string GetDefaultConvergenceTolerance()
        {
            return DefaultConvergenceTolerance.ToString();
        }
        #endregion  // GetDefaultConvergenceTolerance()

        #endregion  // STRING CONVERSION METHODS

        #region IMPLEMENTATION of IOptimizerParamsPanelData METHODS

        #region ConvertToPanelData(OptimizerParamsDto optimizerParamsDto)
        /// <summary>
        /// Creates a new OptimizerParamsPanelData instance by copying values from the specified OptimizerParamsDto object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from OptimizerParamsDto to
        /// OptimizerParamsPanelData. All relevant fields are transferred directly. If optimizerParamsDto is null,
        /// a NullReferenceException may occur.</remarks>
        /// <param name="optimizerParamsDto">The OptimizerParamsDto object containing the source values to copy. Cannot be null.</param>
        /// <returns>An OptimizerParamsPanelData instance populated with values from the provided OptimizerParamsDto object.</returns>
        public OptimizerParamsPanelData ConvertToPanelData(OptimizerParamsDto optimizerParamsDto)
        {
            OptimizerParamsDtoObj = optimizerParamsDto;
            this.Id = optimizerParamsDto.Id;
            this.ProjectId = optimizerParamsDto.ProjectId;
            this.Name = optimizerParamsDto.Name;
            this.Description = optimizerParamsDto.Description;
            this.OptimizerType = optimizerParamsDto.OptimizerType;
            this.DefaultObjective = optimizerParamsDto.DefaultObjective;
            this.DefaultMaxIterations = optimizerParamsDto.DefaultMaxIterations;
            this.DefaultConvergenceTolerance = optimizerParamsDto.DefaultConvergenceTolerance;
            return this;
        }
        #endregion  // ConvertToPanelData(OptimizerParamsDto optimizerParamsDto)
        
        #region ConvertFromPanelData()
        /// <summary>
        /// Creates a new OptimizerParamsDto instance by copying values from the current OptimizerParamsPanelData object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from OptimizerParamsPanelData to
        /// OptimizerParamsDto. All relevant fields are transferred directly.</remarks>
        /// <returns>An OptimizerParamsDto instance populated with values from the current OptimizerParamsPanelData object.</returns>
        public OptimizerParamsDto ConvertFromPanelData()
        {
            OptimizerParamsDtoObj = new OptimizerParamsDto();
            OptimizerParamsDtoObj.Id = this.Id;
            OptimizerParamsDtoObj.ProjectId = this.ProjectId;
            OptimizerParamsDtoObj.Name = this.Name;
            OptimizerParamsDtoObj.Description = this.Description;
            OptimizerParamsDtoObj.OptimizerType = this.OptimizerType;
            OptimizerParamsDtoObj.DefaultObjective = this.DefaultObjective;
            OptimizerParamsDtoObj.DefaultMaxIterations = this.DefaultMaxIterations;
            OptimizerParamsDtoObj.DefaultConvergenceTolerance = this.DefaultConvergenceTolerance;
            return OptimizerParamsDtoObj;
        }
        #endregion  // ConvertFromPanelData()   

        #endregion  // IMPLEMENTATION of IOptimizerParamsPanelData
    }
    #endregion      // public class OptimizerParamsPanelData
}
#endregion  // namespace HenStudio.Data.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
