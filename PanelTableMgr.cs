#region HEADER
//#####################################################################################################################
//########################################  P a n e l T a b l e M g r . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  PanelTableMgr.cs
//  NAMESPACE: Pinch
//  CLASS(S):  PanelTableMgr
//  COMPONENT: Pinch.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Panel Table Manager class. 
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
    #region public class PanelTableMgr
    /// <summary>
    /// Panel Lookup Table Manager Class
    /// </summary>
    public class PanelTableMgr
    {
        #region CONSTANTS
        const string NAMESPACE = "Pinch";
        const string CLASS = "PanelTableMgr";

        #region TAB CONTROL PANEL INDICES
        //-----------------------------------
        //--- MAIN ACTIVITIES TAB CONTROL ---
        //-----------------------------------
        public const int INDEX_INPUT_PANEL = 0;
        public const int INDEX_TARGETS_PANEL = 1;
        public const int INDEX_HEN_PANEL = 2;
        //---------------------------------------------------------------------
        public const string NAME_INPUT_PANEL = "INPUT";
        public const string NAME_TARGETS_PANEL = "TARGETS";
        public const string NAME_HEN_PANEL = "HEN";
        //----------------------------------------
        //--- INPUT SUB-ACTIVITIES TAB CONTROL ---
        //----------------------------------------
        public const int INDEX_INPUT_PROJECT_PANEL = 0;
        public const int INDEX_INPUT_STREAMS_PANEL = 1;
        public const int INDEX_INPUT_UTILITIES_PANEL = 2;
        public const int INDEX_INPUT_COST_PANEL = 3;
        public const int INDEX_INPUT_EXCHANGER_PANEL = 4;
        public const int INDEX_INPUT_VALIDATE_PANEL = 5;
        //---------------------------------------------------------------------
        public const string NAME_INPUT_PROJECT_PANEL = "PROJECT";
        public const string NAME_INPUT_STREAMS_PANEL = "STREAMS";
        public const string NAME_INPUT_UTILITIES_PANEL = "UTILITIES";
        public const string NAME_INPUT_COST_PANEL = "COST";
        public const string NAME_INPUT_EXCHANGER_PANEL = "EXCHANGER";
        public const string NAME_INPUT_VALIDATE_PANEL = "VALIDATE";
        //------------------------------------------
        //--- TARGETS SUB-ACTIVITIES TAB CONTROL ---
        //------------------------------------------
        public const int INDEX_TARGETS_CALCULATE_PANEL = 0;
        public const int INDEX_TARGETS_COMPOSITE_PANEL = 1;
        public const int INDEX_TARGETS_INTERVAL_PANEL = 2;
        public const int INDEX_TARGETS_OPTIMIZE_PANEL = 3;
        //---------------------------------------------------------------------
        public const string NAME_TARGETS_CALCULATE_PANEL = "CALCULATE";
        public const string NAME_TARGETS_COMPOSITE_PANEL = "COMPOSITE";
        public const string NAME_TARGETS_INTERVAL_PANEL = "INTERVAL";
        public const string NAME_TARGETS_OPTIMIZE_PANEL = "OPTIMIZE";
        //--------------------------------------
        //--- HEN SUB-ACTIVITIES TAB CONTROL ---
        //--------------------------------------
        public const int INDEX_HEN_DESIGN_PANEL = 0;
        //---------------------------------------------------------------------
        public const string NAME_HEN_DESIGN_PANEL = "DESIGN";
        #endregion  // TAB CONTROL PANEL INDICES

        #region UNIQUE PANEL TABLE PK VALUES
        //----------------------------------------
        //--- INPUT SUB-ACTIVITIES TAB CONTROL ---
        //----------------------------------------
        public const int PK_INPUT_PROJECT_PANEL = 0;
        public const int PK_INPUT_STREAMS_PANEL = 1;
        public const int PK_INPUT_UTILITIES_PANEL = 2;
        public const int PK_INPUT_COST_PANEL = 3;
        public const int PK_INPUT_EXCHANGER_PANEL = 4;
        public const int PK_INPUT_VALIDATE_PANEL = 5;
        //------------------------------------------
        //--- TARGETS SUB-ACTIVITIES TAB CONTROL ---
        //------------------------------------------
        public const int PK_TARGETS_CALCULATE_PANEL = 6;
        public const int PK_TARGETS_COMPOSITE_PANEL = 7;
        public const int PK_TARGETS_INTERVAL_PANEL = 8;
        public const int PK_TARGETS_OPTIMIZE_PANEL = 9;
        //--------------------------------------
        //--- HEN SUB-ACTIVITIES TAB CONTROL ---
        //--------------------------------------
        public const int PK_HEN_DESIGN_PANEL = 10;
        #endregion  // UNIQUE PANEL TABLE PK VALUES

        #endregion      // CONSTANTS        

        #region FIELDS
        //---------------
        //--- OBJECTS ---
        //---------------
        private PinchTypes _pinchTypes;

        private ArrayList _activitiesPanelList;     // List of Activity Panels (indexed by Main Tab Control Index)
        private ArrayList _subActivitiesPanelList;  // List of Sub-Activity Panels (indexed by PK)
        private ArrayList _lookupPanelInfoTable;    // List of Panel Table Row objects (indexed by PK)

        #region TAB CONTROLS
        public TabControl MAIN_TAB_CONTROL;
        public TabControl INPUT_TAB_CONTROL;
        public TabControl TARGETS_TAB_CONTROL;
        public TabControl HEN_TAB_CONTROL;
        #endregion  // TAB CONTROLS

        #region PUBLIC ACTIVITIES PANELS
        //-------------------------------------
        //--- On MAIN ACTIVITIES TabControl ---
        //-------------------------------------
        public Panel INPUT_PANEL;      // INPUT Panel   - Index: INDEX_INPUT_PANEL
        public Panel TARGETS_PANEL;    // TARGETS Panel - Index: INDEX_TARGETS_PANEL
        public Panel HEN_PANEL;        // HEN Panel     - Index: INDEX_HEN_PANEL
        #endregion  // PUBLIC ACTIVITIES PANELS

        #region PUBLIC SUB-ACTIVITIES PANELS
        //------------------------------------------------------------------------------------
        //--- INPUT SUB-ACTIVITIES Panels   -> PK Index ... [Activity,Sub-Activity Indices ---
        //------------------------------------------------------------------------------------
        public Panel INPUT_PROJECT_PANEL;      // INPUT-PROJECT     Panel - PK: 00 ... [0,0]
        public Panel INPUT_STREAMS_PANEL;      // INPUT-STREAMS     Panel - PK: 01 ... [0,1]
        public Panel INPUT_UTILITIES_PANEL;    // INPUT-UTILITIES   Panel - PK: 02 ... [0,2]
        public Panel INPUT_COST_PANEL;         // INPUT-COST        Panel - PK: 03 ... [0,3]
        public Panel INPUT_EXCHANGER_PANEL;    // INPUT-EXCHANGER   Panel - PK: 04 ... [0,4]
        public Panel INPUT_VALIDATE_PANEL;     // INPUT-VALIDATE    Panel - PK: 05 ... [0,5]
        //------------------------------------------------------------------------------------
        //--- TARGETS SUB-ACTIVITIES Panels -> PK Index ... [Activity,Sub-Activity Indices ---
        //------------------------------------------------------------------------------------
        public Panel TARGETS_CALCULATE_PANEL;  // TARGETS-CALCULATE Panel - PK: 06 ... [1,0]
        public Panel TARGETS_COMPOSITE_PANEL;  // TARGETS-COMPOSITE Panel - PK: 07 ... [1,1]
        public Panel TARGETS_INTERVAL_PANEL;   // TARGETS-INTERVAL  Panel - PK: 08 ... [1,2]
        public Panel TARGETS_OPTIMIZE_PANEL;   // TARGETS-OPTIMIZE  Panel - PK: 09 ... [1,3]
        //------------------------------------------------------------------------------------
        //--- HEN SUB-ACTIVITIES Panels     -> PK Index ... [Activity,Sub-Activity Indices ---
        //------------------------------------------------------------------------------------
        public Panel HEN_DESIGN_PANEL;         // HEN-DESIGN        Panel - PK: 10 ... [2,0]
        //------------------------------------------------------------------------------------
        #endregion  // PUBLIC SUB-ACTIVITIES PANELS

        #endregion  // FIELDS

        #region PROPERTIES

        #region OBJECTS

        #region PinchTypesObj
        /// <summary>
        /// PinchTypesObj Property
        /// </summary>
        public PinchTypes PinchTypesObj
        {
            get { return _pinchTypes; }
            set { _pinchTypes = value; }
        }
        #endregion      // PinchTypesObj

        #region ActivitiesPanelList
        /// <summary>
        /// ActivitiesPanelList ArrayList Property (indexed by Main Tab Control Index)
        /// </summary>
        public ArrayList ActivitiesPanelList
        {
            get { return _activitiesPanelList; }
            set { _activitiesPanelList = value; }
        }
        #endregion      // ActivitiesPanelList

        #region SubActivitiesPanelList
        /// <summary>
        /// SubActivitiesPanelList ArrayList Property (indexed by PK)
        /// </summary>
        public ArrayList SubActivitiesPanelList
        {
            get { return _subActivitiesPanelList; }
            set { _subActivitiesPanelList = value; }
        }
        #endregion      // SubActivitiesPanelList

        #region LookupPanelInfoTable
        /// <summary>
        /// LookupPanelInfoTable Property (indexed by PK)
        /// ArrayList of PanelTableRow Objects 
        /// </summary>
        public ArrayList LookupPanelInfoTable
        {
            get { return _lookupPanelInfoTable; }
            set { _lookupPanelInfoTable = value; }
        }
        #endregion      // LookupPanelInfoTable

        #endregion  // OBJECTS

        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public PanelTableMgr()
        {
            string strMethod = "CTOR";
            string strMsg = string.Empty;
            PinchLogger.WriteSection("START PANEL TABLE CONSTRUCTION SECTION");
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating Object");
            try
            {
                //---------------------------------
                //--- Create Empty List Objects ---
                //---------------------------------
                ActivitiesPanelList = new ArrayList();      // Activities Panel List
                SubActivitiesPanelList = new ArrayList();   // Sub-Activities Panel List
                LookupPanelInfoTable = new ArrayList();     // Lookup Panel Info Table
                                                            // PK used as index into SubActivities Panel List
            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                PinchLogger.WriteSection("END PANEL TABLE CONSTRUCTION SECTION");
            }
        }
        #endregion  // CTOR

        #region PRIVATE METHODS

        #region private void PopulateActivitiesPanelList()
        /// <summary>
        /// Populates the Activities Panel List
        /// </summary>
        private void PopulateActivitiesPanelList()
        {
            string strMethod = "PopulateActivitiesPanelList()";
            string strMsg = string.Empty;
            try
            {
                ActivitiesPanelList.Clear();
                ActivitiesPanelList.Add(INPUT_PANEL);
                ActivitiesPanelList.Add(TARGETS_PANEL);
                ActivitiesPanelList.Add(HEN_PANEL);
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
        #endregion  // private void PopulateActivitiesPanelList()

        #region private void PopulateSubActivitiesPanelTable()
        /// <summary>
        /// Populates the Sub-Activities Panels Table
        /// </summary>
        private void PopulateSubActivitiesPanelTable()
        {
            string strMethod = "PopulateSubActivitiesPanelTable()";
            string strMsg = string.Empty;
            try
            {


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
        #endregion  // private void PopulateSubActivitiesPanelTable()

        #region private void PopulateLookupPanelInfoTable()
        /// <summary>
        /// Populates the Lookup Panels Info Table
        /// </summary>
        private void PopulateLookupPanelInfoTable()
        {
            string strMethod = "PopulateLookupPanelInfoTable()";
            string strMsg = string.Empty;
            string strPanelStatusName = string.Empty;   // Panel Status Name
            PanelTableRow row;
            try
            {
                //---------------------------------------------------------------------------------
                strPanelStatusName = (NAME_INPUT_PANEL + ":" + NAME_INPUT_PROJECT_PANEL);
                row = new PanelTableRow(PK_INPUT_PROJECT_PANEL,      // Primary Key (PK)
                                        INDEX_INPUT_PANEL,           // Activity Index
                                        INDEX_INPUT_PROJECT_PANEL,   // SubActivity Index
                                        NAME_INPUT_PANEL,            // Activity Name
                                        NAME_INPUT_PROJECT_PANEL,    // SubActivity Name
                                        strPanelStatusName);         // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //---------------------------------------------------------------------------------
                strPanelStatusName = (NAME_INPUT_PANEL + ":" + NAME_INPUT_STREAMS_PANEL);
                row = new PanelTableRow(PK_INPUT_STREAMS_PANEL,      // Primary Key (PK)
                                        INDEX_INPUT_PANEL,           // Activity Index
                                        INDEX_INPUT_STREAMS_PANEL,   // SubActivity Index
                                        NAME_INPUT_PANEL,            // Activity Name
                                        NAME_INPUT_STREAMS_PANEL,    // SubActivity Name
                                        strPanelStatusName);         // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //---------------------------------------------------------------------------------
                strPanelStatusName = (NAME_INPUT_PANEL + ":" + NAME_INPUT_UTILITIES_PANEL);
                row = new PanelTableRow(PK_INPUT_UTILITIES_PANEL,    // Primary Key (PK)
                                        INDEX_INPUT_PANEL,           // Activity Index
                                        INDEX_INPUT_UTILITIES_PANEL, // SubActivity Index
                                        NAME_INPUT_PANEL,            // Activity Name
                                        NAME_INPUT_UTILITIES_PANEL,  // SubActivity Name
                                        strPanelStatusName);         // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //---------------------------------------------------------------------------------
                strPanelStatusName = (NAME_INPUT_PANEL + ":" + NAME_INPUT_COST_PANEL);
                row = new PanelTableRow(PK_INPUT_COST_PANEL,         // Primary Key (PK)
                                        INDEX_INPUT_PANEL,           // Activity Index
                                        INDEX_INPUT_COST_PANEL,      // SubActivity Index
                                        NAME_INPUT_PANEL,            // Activity Name
                                        NAME_INPUT_COST_PANEL,       // SubActivity Name
                                        strPanelStatusName);         // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //---------------------------------------------------------------------------------
                strPanelStatusName = (NAME_INPUT_PANEL + ":" + NAME_INPUT_EXCHANGER_PANEL);
                row = new PanelTableRow(PK_INPUT_EXCHANGER_PANEL,    // Primary Key (PK)
                                        INDEX_INPUT_PANEL,           // Activity Index
                                        INDEX_INPUT_EXCHANGER_PANEL, // SubActivity Index
                                        NAME_INPUT_PANEL,            // Activity Name
                                        NAME_INPUT_EXCHANGER_PANEL,  // SubActivity Name
                                        strPanelStatusName);         // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //---------------------------------------------------------------------------------
                strPanelStatusName = (NAME_INPUT_PANEL + ":" + NAME_INPUT_VALIDATE_PANEL);
                row = new PanelTableRow(PK_INPUT_VALIDATE_PANEL,     // Primary Key (PK)
                                        INDEX_INPUT_PANEL,           // Activity Index
                                        INDEX_INPUT_VALIDATE_PANEL,  // SubActivity Index
                                        NAME_INPUT_PANEL,            // Activity Name
                                        NAME_INPUT_VALIDATE_PANEL,   // SubActivity Name
                                        strPanelStatusName);         // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //=================================================================================
                strPanelStatusName = (NAME_TARGETS_PANEL + ":" + NAME_TARGETS_CALCULATE_PANEL);
                row = new PanelTableRow(PK_TARGETS_CALCULATE_PANEL,    // Primary Key (PK)
                                        INDEX_TARGETS_PANEL,           // Activity Index
                                        INDEX_TARGETS_CALCULATE_PANEL, // SubActivity Index
                                        NAME_TARGETS_PANEL,            // Activity Name
                                        NAME_TARGETS_CALCULATE_PANEL,  // SubActivity Name
                                        strPanelStatusName);           // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //---------------------------------------------------------------------------------
                strPanelStatusName = (NAME_TARGETS_PANEL + ":" + NAME_TARGETS_COMPOSITE_PANEL);
                row = new PanelTableRow(PK_TARGETS_COMPOSITE_PANEL,    // Primary Key (PK)
                                        INDEX_TARGETS_PANEL,           // Activity Index
                                        INDEX_TARGETS_COMPOSITE_PANEL, // SubActivity Index
                                        NAME_TARGETS_PANEL,            // Activity Name
                                        NAME_TARGETS_COMPOSITE_PANEL,  // SubActivity Name
                                        strPanelStatusName);           // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //---------------------------------------------------------------------------------
                strPanelStatusName = (NAME_TARGETS_PANEL + ":" + NAME_TARGETS_INTERVAL_PANEL);
                row = new PanelTableRow(PK_TARGETS_INTERVAL_PANEL,     // Primary Key (PK)
                                        INDEX_TARGETS_PANEL,           // Activity Index
                                        INDEX_TARGETS_INTERVAL_PANEL,  // SubActivity Index
                                        NAME_TARGETS_PANEL,            // Activity Name
                                        NAME_TARGETS_INTERVAL_PANEL,   // SubActivity Name
                                        strPanelStatusName);           // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //---------------------------------------------------------------------------------
                strPanelStatusName = (NAME_TARGETS_PANEL + ":" + NAME_TARGETS_OPTIMIZE_PANEL);
                row = new PanelTableRow(PK_TARGETS_OPTIMIZE_PANEL,     // Primary Key (PK)
                                        INDEX_TARGETS_PANEL,           // Activity Index
                                        INDEX_TARGETS_OPTIMIZE_PANEL,  // SubActivity Index
                                        NAME_TARGETS_PANEL,            // Activity Name
                                        NAME_TARGETS_OPTIMIZE_PANEL,   // SubActivity Name
                                        strPanelStatusName);           // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //=================================================================================
                strPanelStatusName = (NAME_HEN_PANEL + ":" + NAME_HEN_DESIGN_PANEL);
                row = new PanelTableRow(PK_HEN_DESIGN_PANEL,           // Primary Key (PK)
                                        INDEX_HEN_PANEL,               // Activity Index
                                        INDEX_HEN_DESIGN_PANEL,        // SubActivity Index
                                        NAME_HEN_PANEL,                // Activity Name
                                        NAME_HEN_DESIGN_PANEL,         // SubActivity Name
                                        strPanelStatusName);           // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //=================================================================================

                LogLookupPanelInfoTable();      // Log Table Contents
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
        #endregion  // private void PopulateLookupPanelInfoTable()

        #endregion  // PRIVATE METHODS

        #region PUBLIC METHODS

        #region InitializeMgrObjects()
        /// <summary>
        /// Initialize the Lists and Table objects 
        /// Ensure all Panel objects are assigned to the public fields before invoking this method.
        /// Ensure all assigned Panel objects align with CONST indices
        /// (i.e., FormMain create Mgr object, assigns Panels and TabContols objects).
        /// </summary>
        public void InitializeMgrObjects()
        {
            string strMethod = "InitializeMgrObjects()";
            string strMsg = string.Empty;
            try
            {
                //-----------------------------
                //--- Activities Panel List ---
                //-----------------------------
                PopulateActivitiesPanelList();
                //---------------------------------
                //--- Sub-Activities Panel List ---
                //---------------------------------
                PopulateSubActivitiesPanelTable();
                //----------------------------------------------------------------------------------
                //--- Lookup Panel Info Table ... PK used as index into SubActivities Panel List ---
                //----------------------------------------------------------------------------------
                PopulateLookupPanelInfoTable();
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
        #endregion  // InitializeMgrObjects()

        #region LogLookupPanelInfoTable()
        /// <summary>
        /// Log the contents of the Looup Panel Information Table.
        /// </summary>
        public void LogLookupPanelInfoTable()
        {
            string strMethod = "LogLookupPanelInfoTable()";
            string strMsg = string.Empty;
            try
            {
                PinchLogger.WriteSection("LOOKUP PANEL INFORMATION TABLE");

                strMsg = String.Format("      ACTIVITY        SUB-ACTIVITY         PANEL STATUS");
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = String.Format(" PK  INDEX  NAME     INDEX   NAME          NAME");
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                PinchLogger.WriteSeparatorLine('-');

                foreach (PanelTableRow row in LookupPanelInfoTable)
                {
                    strMsg = String.Format(" {0:00}   {1}     {2,-9} {3}      {4,-12}  {5,-25} ",
                                            row.PK, 
                                            row.ActivityIndex,    row.ActivityName,
                                            row.SubActivityIndex, row.SubActivityName,
                                            row.PanelStatusName);
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
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
        #endregion  // LogLookupPanelInfoTable()

        #endregion  // PUBLIC METHODS

    }
    #endregion  // public class PanelTableMgr
}
#endregion  // namespace Pinch

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
