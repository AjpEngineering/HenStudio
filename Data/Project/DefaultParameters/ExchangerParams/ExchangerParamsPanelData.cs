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

using HenViewModel.Project.DefaultParameters.ExchangerParams;

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
    public class ExchangerParamsPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.DefaultParameters.ExchangerParams";
        const string CLASS = "ExchangerParamsPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public Guid ExchangerParamsId { get; set; }
        public Guid ProjectId { get; set; }
        public ExchangerParamsDto ExchangerParamsDtoObj { get; set; }

        #region VIEW MODEL Object
        public ExchangerParamsViewModel ExchangerParamsViewModelObj { get; set; }
        #endregion  // VIEW MODEL Objects

        #endregion  // PROPERTIES

        #region CTOR
        public ExchangerParamsPanelData()
        {
            ExchangerParamsId = new Guid();
            ProjectId = new Guid();
            ExchangerParamsDtoObj = new ExchangerParamsDto();
        }
        #endregion  // CTOR

        #region CRUD Methods

        #region CREATE EXCHANGER PARAMS DATA METHOD
        /// <summary>
        /// Creates a new exchanger params data using the data in the ExchangerParamsDtoObj property 
        /// and returns the ID of the newly created exchanger params data.
        /// </summary>
        /// <returns>The ID of the newly created exchanger params data.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the exchanger params ID is null after creation.</exception>
        public Guid CreateExchangerParamsData()
        {
            ExchangerParamsId = ExchangerParamsViewModelObj.AddExchangerParams(ExchangerParamsDtoObj);
            if (ExchangerParamsId == null) throw new ArgumentNullException(
                             nameof(ExchangerParamsId), "Exchanger params ID is null for ADD Exchanger Params Panel data.");
            ExchangerParamsDtoObj.Id = ExchangerParamsId;
            return ExchangerParamsId;  // ExchangerParams ID
        }
        #endregion  // CREATE EXCHANGER PARAMS DATA METHOD

        #region READ EXCHANGER PARAMS DATA METHOD
        /// <summary>
        /// Reads the exchanger params data for the specified project ID 
        /// and populates the ExchangerParamsDtoObj property with the retrieved data.
        /// </summary>
        /// <param name="projectId">The ID of the project to read.</param>
        /// <exception cref="ArgumentNullException">Thrown when the project ID is null.</exception>
        public void ReadExchangerParamsData(Guid projectId)
        {
            if (projectId == null) throw new ArgumentNullException(
                             nameof(projectId), "Project ID is null for READ Exchanger Params Panel data.");
            ProjectId = projectId;
            ExchangerParamsDtoObj = ExchangerParamsViewModelObj.GetExchangerParamsByProjectId(projectId);
        }

        #endregion  // READ EXCHANGER PARAMS DATA METHOD

        #endregion  // CRUD Methods

    }
    #endregion      // public class ExchangerParamsPanelData
}
#endregion  // namespace HenStudio.Data.Project.DefaultParameters.ExchangerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
