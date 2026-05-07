#region HEADER
//#####################################################################################################################
//#############################  E x c h a n g e r P a r a m s P a n e l D a t a . c s  ###############################
//#####################################################################################################################
//  FILENAME:  ExchangerParamsPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.DefaultParameters.ExchangerParams
//  CLASS(S):  ExchangerParamsPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Exchanger Params Panel Data object - data needed for Exchanger Params Panel.
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Project.DefaultParameters.ExchangerParams
namespace HenStudio.Data.Project.DefaultParameters.ExchangerParams
{
    #region public class ExchangerParamsPanelData
    public class ExchangerParamsPanelData : IExchangerParamsPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.DefaultParameters.ExchangerParams";
        const string CLASS = "ExchangerParamsPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public ExchangerParamsDto ExchangerParamsDtoObj { get; set; }
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public double DefaultHeatTransferCoefficient { get; set; }
        public double DefaultCorrectionFactor { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        public ExchangerParamsPanelData()
        {
            ExchangerParamsDtoObj = new ExchangerParamsDto();
            Id = new Guid();
            ProjectId = new Guid();
            DefaultHeatTransferCoefficient = 0.0;
            DefaultCorrectionFactor = 0.0;
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

        #region GetDefaultHeatTransferCoefficient()
        /// <summary>
        /// Gets the default heat transfer coefficient as a string.
        /// </summary>
        /// <returns>A string representation of the default heat transfer coefficient.</returns>
        public string GetDefaultHeatTransferCoefficient()
        {
            return DefaultHeatTransferCoefficient.ToString();
        }
        #endregion  // GetDefaultHeatTransferCoefficient()

        #region GetDefaultCorrectionFactor()
        /// <summary>
        /// Gets the default correction factor as a string.
        /// </summary>
        /// <returns>A string representation of the default correction factor.</returns>
        public string GetDefaultCorrectionFactor()
        {
            return DefaultCorrectionFactor.ToString();
        }
        #endregion  // GetDefaultCorrectionFactor()

        #endregion  // STRING CONVERSION METHODS

        #region IMPLEMENTATION of IExchangerParamsPanelData METHODS

        #region ConvertToPanelData(ExchangerParamsDto exchangerParamsDto)
        /// <summary>
        /// Creates a new ExchangerParamsPanelData instance by copying values from the specified ExchangerParamsDto object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from ExchangerParamsDto to
        /// ExchangerParamsPanelData. All relevant fields are transferred directly. If exchangerParamsDto is null,
        /// a NullReferenceException may occur.</remarks>
        /// <param name="exchangerParamsDto">The ExchangerParamsDto object containing the source values to copy. Cannot be null.</param>
        /// <returns>An ExchangerParamsPanelData instance populated with values from the provided ExchangerParamsDto object.</returns>
        public ExchangerParamsPanelData ConvertToPanelData(ExchangerParamsDto exchangerParamsDto)
        {
            ExchangerParamsDtoObj = exchangerParamsDto;
            this.Id = exchangerParamsDto.Id;
            this.ProjectId = exchangerParamsDto.ProjectId;
            this.DefaultHeatTransferCoefficient = exchangerParamsDto.DefaultHeatTransferCoefficient;
            this.DefaultCorrectionFactor = exchangerParamsDto.DefaultCorrectionFactor;
            return this;
        }
        #endregion  // ConvertToPanelData(ExchangerParamsDto exchangerParamsDto)

        #region ConvertFromPanelData()
        /// <summary>
        /// Creates a new ProjectUnitsDto instance by copying values from the current ProjectUnitsPanelData object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from ProjectUnitsPanelData to
        /// ExchangerParamsDto. All relevant fields are transferred directly.</remarks>
        /// <returns>An ExchangerParamsDto instance populated with values from the current ExchangerParamsPanelData object.</returns>
        public ExchangerParamsDto ConvertFromPanelData()
        {
            ExchangerParamsDtoObj = new ExchangerParamsDto();
            ExchangerParamsDtoObj.Id = this.Id;
            ExchangerParamsDtoObj.ProjectId = this.ProjectId;
            ExchangerParamsDtoObj.DefaultHeatTransferCoefficient = this.DefaultHeatTransferCoefficient;
            ExchangerParamsDtoObj.DefaultCorrectionFactor = this.DefaultCorrectionFactor;
            return ExchangerParamsDtoObj;
        }
        #endregion  // ConvertFromPanelData()   

        #endregion  // IMPLEMENTATION of IExchangerParamsPanelData
    }
    #endregion      // public class ExchangerParamsPanelData
}
#endregion  // namespace HenStudio.Data.Project.DefaultParameters.ExchangerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
