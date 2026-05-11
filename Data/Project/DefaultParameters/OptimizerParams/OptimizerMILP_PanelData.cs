#region HEADER
//#####################################################################################################################
//##############################  O p t i m i z e r M I L P _ P a n e l D a t a . c s  ################################
//#####################################################################################################################
//  FILENAME:  OptimizerMILP_PanelData.cs
//  NAMESPACE: HenStudio.Data.Project.DefaultParameters.OptimizerParams
//  CLASS(S):  OptimizerMILP_PanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Optimizer MILP Params Panel Data object -
//    data needed for Optimizer MILP Params Panel.
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
    #region public class OptimizerMILP_PanelData
    public class OptimizerMILP_PanelData : IOptimizerMILP_PanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.DefaultParameters.OptimizerParams";
        const string CLASS = "OptimizerMILP_PanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public OptimizerMILP_Dto OptimizerMILP_DtoObj { get; set; }
        public Guid Id { get; set; }
        public Guid OptimizerParamsId { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for the OptimizerMILP_PanelData class. 
        /// Initializes all properties to their default values. 
        /// </summary>
        public OptimizerMILP_PanelData()
        {
            OptimizerMILP_DtoObj = new OptimizerMILP_Dto();
            Id = new Guid();
            OptimizerParamsId = new Guid();
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
        /// Gets the unique identifier of the OptimizerParams as a string.
        /// </summary>
        /// <returns>A string representation of the OptimizerParams unique identifier.</returns>
        public string GetOptimizerParamsId()
        {
            return OptimizerParamsId.ToString();
        }
        #endregion  // GetOptimizerParamsId()

        #endregion  // STRING CONVERSION METHODS

        #region IMPLEMENTATION of IOptimizerMILP_PanelData METHODS

        #region ConvertToPanelData(OptimizerMILP_Dto optimizerMILP_Dto)
        /// <summary>
        /// Creates a new OptimizerMILP_PanelData instance by copying values from the specified OptimizerMILP_Dto object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from OptimizerMILP_Dto to
        /// OptimizerMILP_PanelData. All relevant fields are transferred directly. If optimizerMILP_Dto is null,
        /// a NullReferenceException may occur.</remarks>
        /// <param name="optimizerMILP_Dto">The OptimizerMILP_Dto object containing the source values to copy. Cannot be null.</param>
        /// <returns>An OptimizerMILP_PanelData instance populated with values from the provided OptimizerMILP_Dto object.</returns>
        public OptimizerMILP_PanelData ConvertToPanelData(OptimizerMILP_Dto optimizerMILP_Dto)
        {
            OptimizerMILP_DtoObj = optimizerMILP_Dto;
            this.Id = optimizerMILP_Dto.Id;
            this.OptimizerParamsId = optimizerMILP_Dto.OptimizerParamsId;
            return this;
        }
        #endregion  // ConvertToPanelData(OptimizerMILP_Dto optimizerMILP_Dto)
        
        #region ConvertFromPanelData()
        /// <summary>
        /// Creates a new OptimizerMILP_Dto instance by copying values from the current OptimizerMILP_PanelData object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from OptimizerMILP_PanelData to
        /// OptimizerMILP_Dto. All relevant fields are transferred directly.</remarks>
        /// <returns>An OptimizerMILP_Dto instance populated with values from the current OptimizerMILP_PanelData object.</returns>
        public OptimizerMILP_Dto ConvertFromPanelData()
        {
            OptimizerMILP_DtoObj = new OptimizerMILP_Dto();
            OptimizerMILP_DtoObj.Id = this.Id;
            OptimizerMILP_DtoObj.OptimizerParamsId = this.OptimizerParamsId;
            return OptimizerMILP_DtoObj;
        }
        #endregion  // ConvertFromPanelData()   

        #endregion  // IMPLEMENTATION of IOptimizerMILP_PanelData
    }
    #endregion      // public class OptimizerMILP_PanelData
}
#endregion  // namespace HenStudio.Data.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
