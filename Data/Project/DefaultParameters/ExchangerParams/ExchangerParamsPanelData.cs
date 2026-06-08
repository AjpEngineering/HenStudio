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
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

using HenViewModel.Project.DefaultParameters.ExchangerParams;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        /// NOTE: Project ID is assigned in ExchangerParams DTO object before method invocation
        /// </summary>
        /// <param name="exchangerParmasDtoObj">Exchanger Params DTO</param>
        /// <returns>The Exchanger Params ID of the newly created exchanger params data.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the exchanger params ID is null after creation.</exception>
        public Guid CreateExchangerParamsData(ExchangerParamsDto exchangerParmasDtoObj)
        {
            if (exchangerParmasDtoObj == null) throw new ArgumentNullException(
                             nameof(exchangerParmasDtoObj),
                             "Exchanger Params DTO Object is null for Create Exchanger Params data.");
            //-------------------------------------------------------------
            //--- Add Exchanger Params data and get Exchanger Params ID ---
            //--- associated with the newly created Data                ---
            //-------------------------------------------------------------
            Guid exchangerParamsId = ExchangerParamsViewModelObj.AddExchangerParams(exchangerParmasDtoObj);

            if (exchangerParamsId == Guid.Empty) throw new ArgumentException(
                             nameof(exchangerParamsId), 
                             "Exchanger params ID is Empty for ADD Exchanger Params Panel data.");
            //-------------------------------------------------------------
            //--- Assign the returned Exchanger Params ID and return it ---
            //-------------------------------------------------------------
            ExchangerParamsId = exchangerParamsId;
            exchangerParmasDtoObj.Id = exchangerParamsId;
            ExchangerParamsDtoObj = exchangerParmasDtoObj;
            return exchangerParamsId;
        }
        #endregion  // CREATE EXCHANGER PARAMS DATA METHOD

        #region READ EXCHANGER PARAMS DATA METHOD
        /// <summary>
        /// Reads the exchanger params data for the specified project ID 
        /// and populates the ExchangerParamsDtoObj property with the retrieved data.
        /// </summary>
        /// <param name="projectId">The ID of the project to read.</param>
        /// <returns>ExchangerParams DTO object</returns>
        /// <exception cref="ArgumentNullException">Thrown when the project ID is null.</exception>
        public ExchangerParamsDto ReadExchangerParamsData(Guid projectId)
        {
            if (projectId == Guid.Empty) throw new ArgumentException(
                             nameof(projectId), 
                             "Project ID is Empty for READ Exchanger Params Panel data.");

            ProjectId = projectId;

            ExchangerParamsDto exchangerParamsDtoObj = 
                               ExchangerParamsViewModelObj.GetExchangerParamsByProjectId(projectId);
            
            if (exchangerParamsDtoObj == null) throw new ArgumentNullException(
                             nameof(exchangerParamsDtoObj),
                             "Exchanger Params is null for READ Exchanger Params Panel data.");

            ExchangerParamsDtoObj = exchangerParamsDtoObj;
            return exchangerParamsDtoObj;
        }
        #endregion  // READ EXCHANGER PARAMS DATA METHOD

        #region UPDATE EXCHANGER PARAMS DATA METHOD
        /// <summary>
        /// Updates the exchanger params data using the provided ExchangerParamsDto object 
        /// and returns the updated ExchangerParamsDto object.
        /// </summary>
        /// <param name="exchangerParamsDtoObj">The ExchangerParamsDto object containing 
        /// the updated exchanger params data.</param>
        /// <returns>The updated ExchangerParamsDto object.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the exchanger params DTO or its ID is null.</exception>
        public ExchangerParamsDto UpdateExchangerParamsData(ExchangerParamsDto exchangerParamsDtoObj)
        {
            if (exchangerParamsDtoObj == null) throw new ArgumentNullException(
                             nameof(exchangerParamsDtoObj), 
                             "Exchanger Params DTO is null for UPDATE Exchanger Params Panel data.");

            if (exchangerParamsDtoObj.Id == Guid.Empty) throw new ArgumentException(
                             nameof(exchangerParamsDtoObj), 
                             "Exchanger Params DTO ID is Empty for UPDATE Exchanger Params Panel data.");

            if (exchangerParamsDtoObj.ProjectId == Guid.Empty) throw new ArgumentException(
                             nameof(exchangerParamsDtoObj), 
                             "Exchanger Params DTO Project ID is Empty for UPDATE Exchanger Params Panel data.");

            ExchangerParamsId = exchangerParamsDtoObj.Id;
            ProjectId = exchangerParamsDtoObj.ProjectId;
            ExchangerParamsDtoObj = exchangerParamsDtoObj;
            ExchangerParamsViewModelObj.UpdateExchangerParams(exchangerParamsDtoObj);
            return ExchangerParamsDtoObj;
        }
        #endregion  // UPDATE PROJECT DATA METHOD

        #region DELETE EXCHANGER PARAMS DATA METHOD
        //-------------------------------------------------------------------
        //--- DELETE method is not needed for Exchanger Params data as it ---
        //--- is a one-to-one relationship with the Project and should be ---
        //--- deleted when the Project is deleted.                        ---
        //--- Part of Cascade DELETE functionality.                       ---
        //-------------------------------------------------------------------
        #endregion  // DELETE EXCHANGER PARAMS DATA METHOD

        #endregion  // CRUD Methods

    }
    #endregion      // public class ExchangerParamsPanelData
}
#endregion  // namespace HenStudio.Data.Project.DefaultParameters.ExchangerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
