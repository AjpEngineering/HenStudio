#region HEADER
//#####################################################################################################################
//#############################  O p t i m i z e r G r e e d y P a n e l D a t a . c s  ###############################
//#####################################################################################################################
//  FILENAME:  OptimizerGreedyPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.DefaultParameters.OptimizerParams
//  CLASS(S):  OptimizerGreedyPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Optimizer Greedy Params Panel Data object -
//    data needed for Optimizer Greedy Params Panel.
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
    #region public class OptimizerGreedyPanelData
    public class OptimizerGreedyPanelData : IOptimizerGreedyPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.DefaultParameters.OptimizerParams";
        const string CLASS = "OptimizerGreedyPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public OptimizerGreedyDto OptimizerGreedyDtoObj { get; set; }
        public Guid Id { get; set; }
        public Guid HenOptimizerParamsId { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for the OptimizerGreedyPanelData class. 
        /// Initializes all properties to their default values. 
        /// </summary>
        public OptimizerGreedyPanelData()
        {
            OptimizerGreedyDtoObj = new OptimizerGreedyDto();
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

        #region IMPLEMENTATION of IOptimizerGreedyPanelData METHODS

        #region ConvertToPanelData(OptimizerGreedyDto optimizerGreedyDto)
        /// <summary>
        /// Creates a new OptimizerGreedyPanelData instance by copying values from the specified OptimizerGreedyDto object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from OptimizerGreedyDto to
        /// OptimizerGreedyPanelData. All relevant fields are transferred directly. If optimizerGreedyDto is null,
        /// a NullReferenceException may occur.</remarks>
        /// <param name="optimizerGreedyDto">The OptimizerGreedyDto object containing the source values to copy. Cannot be null.</param>
        /// <returns>An OptimizerGreedyPanelData instance populated with values from the provided OptimizerGreedyDto object.</returns>
        public OptimizerGreedyPanelData ConvertToPanelData(OptimizerGreedyDto optimizerGreedyDto)
        {
            OptimizerGreedyDtoObj = optimizerGreedyDto;
            this.Id = optimizerGreedyDto.Id;
            this.HenOptimizerParamsId = optimizerGreedyDto.HenOptimizerParamsId;
            return this;
        }
        #endregion  // ConvertToPanelData(OptimizerGreedyDto optimizerGreedyDto)
        
        #region ConvertFromPanelData()
        /// <summary>
        /// Creates a new OptimizerGreedyDto instance by copying values from the current OptimizerGreedyPanelData object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from OptimizerGreedyPanelData to
        /// OptimizerGreedyDto. All relevant fields are transferred directly.</remarks>
        /// <returns>An OptimizerGreedyDto instance populated with values from the current OptimizerGreedyPanelData object.</returns>
        public OptimizerGreedyDto ConvertFromPanelData()
        {
            OptimizerGreedyDtoObj = new OptimizerGreedyDto();
            OptimizerGreedyDtoObj.Id = this.Id;
            OptimizerGreedyDtoObj.HenOptimizerParamsId = this.HenOptimizerParamsId;
            return OptimizerGreedyDtoObj;
        }
        #endregion  // ConvertFromPanelData()   

        #endregion  // IMPLEMENTATION of IOptimizerGreedyPanelData
    }
    #endregion      // public class OptimizerGreedyPanelData
}
#endregion  // namespace HenStudio.Data.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
