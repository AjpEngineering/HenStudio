#region HEADER
//#####################################################################################################################
//################################  I n p u t S t r e a m s T a b l e D a t a . c s  ##################################
//#####################################################################################################################
//  FILENAME:  InputStreamsTableData.cs
//  NAMESPACE: PinchData
//  CLASS(S):  InputStreamsTableData
//  COMPONENT: _PinchData.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Input Streams Table Data class. 
//    The table is an ArrayList of InputStreamsRowData Objects.
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
using System.Xml.Schema;

using PinchGlobal;
#endregion  // REFERENCES

#region namespace PinchData
namespace PinchData
{
    #region public class InputStreamsTableData
    /// <summary>
    /// Input Streams Table Data Class
    /// </summary>
    public class InputStreamsTableData
    {
        #region CONSTANTS
        private const string NAMESPACE = "PinchData";
        private const string CLASS = "InputStreamsTableData";

        #endregion      // CONSTANTS        

        #region PROPERTIES
        public ArrayList InputStreamsTable { get; set; }    // ArrayList of InputStreamsRowData Objects
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public InputStreamsTableData()
        {
            string strMethod = "CTOR";
            string strMsg = string.Empty;
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating InputStreamsTableData Object");
            try
            {
                //---------------------------------
                //--- Create Empty List Objects ---
                //---------------------------------
                InputStreamsTable = new ArrayList();     // Input Streams Table
            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "InputStreamsTableData Object CREATED");
            }
        }
        #endregion  // CTOR

        #region ClearTable()
        /// <summary>
        /// Clears the contents of the table
        /// </summary>
        public void ClearTable()
        {
            InputStreamsTable.Clear();
        }
        #endregion  // ClearTable()

        #region AddRow()
        /// <summary>
        /// Add Row to the table
        /// </summary>
        public void AddRow(InputStreamsRowData row)
        {
            InputStreamsTable.Add(row);
        }
        #endregion  // AddRow()

        #region LogInputStreamsTable()
        /// <summary>
        /// Log the contents of the Input Streams Table.
        /// </summary>
        public void LogInputStreamsTable()
        {
            string strMethod = "LogInputStreamsTable()";
            string strMsg = string.Empty;
            try
            {
                //strMsg = String.Format("      ACTIVITY        SUB-ACTIVITY         PANEL STATUS");
                //PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                //strMsg = String.Format(" PK  INDEX  NAME     INDEX   NAME          NAME");
                //PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                //PinchLogger.WriteSeparatorLine('-');

                //foreach (InputStreamsRowData row in InputStreamsTable)
                //{
                //    strMsg = String.Format(" {0:00}   {1}     {2,-9} {3}      {4,-12}  {5,-25} ",
                //                            row.PK, 
                //                            row.ActivityIndex,    row.ActivityName,
                //                            row.SubActivityIndex, row.SubActivityName,
                //                            row.PanelStatusName);
                //    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                //}
            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                //PinchLogger.WriteSeparatorLine('=');
            }
        }
        #endregion  // LogInputStreamsTable()

    }
    #endregion  // public class InputStreamsTableData
}
#endregion  // namespace PinchData

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
