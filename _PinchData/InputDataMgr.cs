#region HEADER
//#####################################################################################################################
//#########################################  I n p u t D a t a M g r . c s  ###########################################
//#####################################################################################################################
//  FILENAME:  InputDataMgr.cs
//  NAMESPACE: PinchData
//  CLASS(S):  InputDataMgr
//  COMPONENT: _PinchData.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Input Data Manager class.
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PinchGlobal;
#endregion  // REFERENCES

#region namespace PinchData
namespace PinchData
{
    #region public class InputDataMgr
    /// <summary>
    /// Input Data Manager Class
    /// </summary>
    public class InputDataMgr
    {
        #region CONSTANTS
        const string NAMESPACE = "PinchData";
        const string CLASS = "InputDataMgr";
        #endregion      // CONSTANTS

        #region FIELDS

        #endregion      // FIELDS

        #region PROPERTIES
        public InputProjectData InputProjectDataObj { get; set; }
        public InputUtilitiesData InputUtilitiesDataObj { get; set; }
        public InputCostData InputCostDataObj { get; set; }
        public InputExchangerData InputExchangerDataObj { get; set; }
        public InputValidationData InputValidationDataObj { get; set; }

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public InputDataMgr()
        {
            string strMethod = "CTOR";
            PinchLogger.WriteSeparatorLine('-');
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating InputDataMgr Object");
            try
            {
                //---------------------------------------
                //--- Create Input Panel Data Objects ---
                //---------------------------------------
                InputProjectDataObj = new InputProjectData();         // Project Data
                InputUtilitiesDataObj = new InputUtilitiesData();     // Utilities Data
                InputCostDataObj = new InputCostData();               // Cost Data
                InputExchangerDataObj = new InputExchangerData();     // Exchanger Data
                InputValidationDataObj = new InputValidationData();   // Validation Data

            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "InputDataMgr Object CREATED");
            }
        }
        #endregion      // CTOR

    }
    #endregion      // public class InputDataMgr
}
#endregion      // namespace PinchData

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
