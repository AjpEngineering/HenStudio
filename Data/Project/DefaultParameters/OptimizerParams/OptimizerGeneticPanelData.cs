#region HEADER
//#####################################################################################################################
//#############################  O p t i m i z e r G e n e t i c P a n e l D a t a . c s  ###############################
//#####################################################################################################################
//  FILENAME:  OptimizerGeneticPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.DefaultParameters.OptimizerParams
//  CLASS(S):  OptimizerGeneticPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Optimizer Genetic Params Panel Data object -
//    data needed for Optimizer Genetic Params Panel.
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
    #region public class OptimizerGeneticPanelData
    public class OptimizerGeneticPanelData : IOptimizerGeneticPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.DefaultParameters.OptimizerParams";
        const string CLASS = "OptimizerGeneticPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public OptimizerGeneticDto OptimizerGeneticDtoObj { get; set; }
        public Guid Id { get; set; }
        public Guid HenOptimizerParamsId { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for the OptimizerGeneticPanelData class. 
        /// Initializes all properties to their default values. 
        /// </summary>
        public OptimizerGeneticPanelData()
        {
            OptimizerGeneticDtoObj = new OptimizerGeneticDto();
            Id = new Guid();
            HenOptimizerParamsId = new Guid();
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

        #region GetHenOptimizerParamsId()
        /// <summary>
        /// Gets the unique identifier of the HenOptimizerParams as a string.
        /// </summary>
        /// <returns>A string representation of the HenOptimizerParams' unique identifier.</returns>
        public string GetHenOptimizerParamsId()
        {
            return HenOptimizerParamsId.ToString();
        }
        #endregion  // GetHenOptimizerParamsId()

        #endregion  // STRING CONVERSION METHODS

        #region IMPLEMENTATION of IOptimizerGeneticPanelData METHODS

        #region ConvertToPanelData(OptimizerGeneticDto optimizerGeneticDto)
        /// <summary>
        /// Creates a new OptimizerGeneticPanelData instance by copying values from the specified OptimizerGeneticDto object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from OptimizerGeneticDto to
        /// OptimizerGeneticPanelData. All relevant fields are transferred directly. If optimizerGeneticDto is null,
        /// a NullReferenceException may occur.</remarks>
        /// <param name="optimizerGeneticDto">The OptimizerGeneticDto object containing the source values to copy. Cannot be null.</param>
        /// <returns>An OptimizerGeneticPanelData instance populated with values from the provided OptimizerGeneticDto object.</returns>
        public OptimizerGeneticPanelData ConvertToPanelData(OptimizerGeneticDto optimizerGeneticDto)
        {
            OptimizerGeneticDtoObj = optimizerGeneticDto;
            this.Id = optimizerGeneticDto.Id;
            this.HenOptimizerParamsId = optimizerGeneticDto.OptimizerParamsId;
            return this;
        }
        #endregion  // ConvertToPanelData(OptimizerGeneticDto optimizerGeneticDto)
        
        #region ConvertFromPanelData()
        /// <summary>
        /// Creates a new OptimizerGeneticDto instance by copying values from the current OptimizerGeneticPanelData object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from OptimizerGeneticPanelData to
        /// OptimizerGeneticDto. All relevant fields are transferred directly.</remarks>
        /// <returns>An OptimizerGeneticDto instance populated with values from the current OptimizerGeneticPanelData object.</returns>
        public OptimizerGeneticDto ConvertFromPanelData()
        {
            OptimizerGeneticDtoObj = new OptimizerGeneticDto();
            OptimizerGeneticDtoObj.Id = this.Id;
            OptimizerGeneticDtoObj.OptimizerParamsId = this.HenOptimizerParamsId;
            return OptimizerGeneticDtoObj;
        }
        #endregion  // ConvertFromPanelData()   

        #endregion  // IMPLEMENTATION of IOptimizerGeneticPanelData
    }
    #endregion      // public class OptimizerGeneticPanelData
}
#endregion  // namespace HenStudio.Data.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
