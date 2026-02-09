#region HEADER
//#####################################################################################################################
//##################################  I n p u t S t r e a m s R o w D a t a . c s  ####################################
//#####################################################################################################################
//  FILENAME:  InputStreamsRowData.cs
//  NAMESPACE: PinchData
//  CLASS(S):  InputStreamsRowData
//  COMPONENT: _PinchData.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Input Streams Table Row Data class. 
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
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using PinchGlobal;
#endregion  // REFERENCES

#region namespace PinchData
namespace PinchData
{
    #region public class InputStreamsRowData
    /// <summary>
    /// Input Streams Table Row Data Class
    /// </summary>
    public class InputStreamsRowData
    {
        #region CONSTANTS
        const string NAMESPACE = "PinchData";
        const string CLASS = "InputStreamsRowData";
        #endregion  // CONSTANTS

        #region PROPERTIES
        public string StreamID { get; set; }

        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public InputStreamsRowData()
        {
            string strMethod = "CTOR";
            string strMsg = string.Empty;
            try
            {
                //------------------------------------
                //--- Initialize Object Properties ---
                //------------------------------------
                StreamID = string.Empty;
            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                LogRow();   // Log Row Data
            }
        }
        #endregion  // CTOR

        #region LogRow
        /// <summary>
        /// Log Row Data
        /// </summary>
        public void LogRow()
        {
            string strMethod = "LogRow()";
            string strMsg = string.Empty;
            try
            {
                //strMsg = String.Format("  ==> Panel Table Row: PK: {0:00}  Activity [{1}] Name: {2,-10} SubActivity[{3}] Name: {4,-12} STATUS Name: {5,-25}",
                //                        PK, 
                //                        ActivityIndex, ActivityName, 
                //                        SubActivityIndex, SubActivityName, 
                //                        PanelStatusName);
                //PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // LogRow

    }
    #endregion  // public class InputStreamsRowData
}
#endregion  // namespace PinchData

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
