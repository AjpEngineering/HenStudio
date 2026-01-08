#region HEADER
//#####################################################################################################################
//########################################  P a n e l T a b l e R o w . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  PanelTableRow.cs
//  NAMESPACE: Pinch
//  CLASS(S):  PanelTableRow
//  COMPONENT: Pinch.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Panel Table Row Data class. 
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
using System.Windows.Forms;

using PinchGlobal;
#endregion  // REFERENCES

#region namespace Pinch
namespace Pinch
{
    #region public class PanelTableRow
    /// <summary>
    /// Panel Lookup Table Row Data Class
    /// </summary>
    public class PanelTableRow
    {
        #region CONSTANTS
        const string NAMESPACE = "Pinch";
        const string CLASS = "PanelTableRow";
        #endregion  // CONSTANTS

        #region FIELDS
        private int _nPK;                   // Primary Key Index
        private int _nActivityIndex;        // Activity Index (Main Tab Control Index)
        private int _nSubActivityIndex;     // Sub-Activity Index (Sub-Activity Tab Control Index)
        private string _strActivityName;    // Activity Name
        private string _strSubActivityName; // Sub-Activity Name
        private string _strPanelStatusName; // Panel Status Name
        #endregion  // FIELDS

        #region PROPERTIES

        #region PK
        /// <summary>
        /// PK Property
        /// </summary>
        public int PK
        {
            get { return _nPK; }
            set { _nPK = value; }
        }
        #endregion      // PK

        #region ActivityIndex
        /// <summary>
        /// ActivityIndex Property
        /// </summary>
        public int ActivityIndex
        {
            get { return _nActivityIndex; }
            set { _nActivityIndex = value; }
        }
        #endregion      // ActivityIndex

        #region SubActivityIndex
        /// <summary>
        /// SubActivityIndex Property
        /// </summary>
        public int SubActivityIndex
        {
            get { return _nSubActivityIndex; }
            set { _nSubActivityIndex = value; }
        }
        #endregion      // SubActivityIndex

        #region ActivityName
        /// <summary>
        /// ActivityName Property
        /// </summary>
        public string ActivityName
        {
            get { return _strActivityName; }
            set { _strActivityName = value; }
        }
        #endregion      // ActivityName

        #region SubActivityName
        /// <summary>
        /// SubActivityName Property
        /// </summary>
        public string SubActivityName
        {
            get { return _strSubActivityName; }
            set { _strSubActivityName = value; }
        }
        #endregion      // SubActivityName

        #region PanelStatusName
        /// <summary>
        /// PanelStatusName Property
        /// </summary>
        public string PanelStatusName
        {
            get { return _strPanelStatusName; }
            set { _strPanelStatusName = value; }
        }
        #endregion      // PanelStatusName

        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public PanelTableRow(int nPK = -1, 
                             int nActivityIndex = -1, 
                             int nSubActivityIndex = -1,
                             string strActivityName = "",
                             string strSubActivityName = "",
                             string strPanelStatusName = "")
        {
            string strMethod = "CTOR";
            string strMsg = string.Empty;
            try
            {
                //------------------------------------
                //--- Initialize Object Properties ---
                //------------------------------------
                PK = nPK;
                ActivityIndex = nActivityIndex;
                SubActivityIndex = nSubActivityIndex;
                ActivityName = strActivityName;
                SubActivityName = strSubActivityName;
                PanelStatusName = strPanelStatusName;
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
                strMsg = String.Format("  ==> Panel Table Row: PK: {0:00}  Activity [{1}] Name: {2,-10} SubActivity[{3}] Name: {4,-12} STATUS Name: {5,-25}",
                                        PK, 
                                        ActivityIndex, ActivityName, 
                                        SubActivityIndex, SubActivityName, 
                                        PanelStatusName);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

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
    #endregion  // public class PanelTableRow
}
#endregion  // namespace Pinch

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
