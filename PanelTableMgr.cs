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
using System.Xml.Schema;

using PinchGlobal;

using static System.Windows.Forms.AxHost;
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
        private const string NAMESPACE = "Pinch";
        private const string CLASS = "PanelTableMgr";

        #region TAB CONTROL AND PANEL INDICES
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
        #endregion  // TAB CONTROL AND PANEL INDICES

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
        private PinchTypes _pinchTypes;

        //-------------------------------------------- ArrayList Objects ----------------------------------------------
        private ArrayList _activitiesPanelList;     // List of Activity Panels (indexed by Main Tab Control Index)
        private ArrayList _subActivitiesPanelList;  // List of Sub-Activity Panels (indexed by PK)
        private ArrayList _lookupPanelInfoTable;    // List of Panel Table Row objects (indexed by PK)

        //--------------------------------------- Last Activity Index State -------------------------------------------
        private int _nLastActivityIndex = 0;            // Last Activity Index

        //------------------------------------- Last SubActivity Index State ------------------------------------------
        private int _nLastInputSubActivityIndex = 0;    // Last INPUT SubActivity Index
        private int _nLastTargetsSubActivityIndex = 0;  // Last TARGETS SubActivity Index
        private int _nLastHenSubActivityIndex = 0;      // Last HEN SubActivity Index

        //-------------------------------------------- Selected State -------------------------------------------------
        private int _nSelActivity = 0;              // Selected Activity     (Activity     Tab Control) Index - Bottom
        private int _nSelSubActivity = 0;           // Selected Sub-Activity (Sub-Activity Tab Control) Index - Top
        private int _nSelPK = 0;                    // Selected Panel Primary Key (Lookup Table & SubActivity List)

        private PanelTableRow _selRow;              // Selected Lookup Table Row

        private string _strSelActivityName = String.Empty;     // Selected Activity     Name
        private string _strSelSubActivityName = String.Empty;  // Selected SubActivity  Name
        private string _strSelPanelStatusName = String.Empty;  // Selected Panel Status Name

        private TabControl _selActivityTabControl = null;       // Selected Activity TabControl
        private TabControl _selSubActivityTabControl = null;    // Selected Sub-Activity TabControl

        private Panel _selActivityPanel = null;     // Selected Activity Panel
        private Panel _selSubActivityPanel = null;  // Selected Sub-Activity Panel
        //-------------------------------------------------------------------------------------------------------------

        #region FORM CONTROLS ... public ... Assign in FormMain Construction

        #region TAB CONTROLS ... public ... Assign in FormMain Construction
        public TabControl MAIN_TAB_CONTROL;         // Main Activity TabControl
        public TabControl INPUT_TAB_CONTROL;        // INPUT Sub-Activity TabControl 
        public TabControl TARGETS_TAB_CONTROL;      // TARGETS  Sub-Activity TabControl 
        public TabControl HEN_TAB_CONTROL;          // HEN Sub-Activity TabControl 
        #endregion  // TAB CONTROLS ...public ... Assign in FormMain Construction

        #region PUBLIC ACTIVITIES PANELS ... public ... Assign in FormMain Construction
        //-------------------------------------
        //--- On MAIN ACTIVITIES TabControl ---
        //-------------------------------------
        public Panel INPUT_PANEL;      // INPUT Panel   - Index: INDEX_INPUT_PANEL ..... Name: "INPUT"
        public Panel TARGETS_PANEL;    // TARGETS Panel - Index: INDEX_TARGETS_PANEL ... Name: "TARGETS"
        public Panel HEN_PANEL;        // HEN Panel     - Index: INDEX_HEN_PANEL ....... Name: "HEN"
        #endregion  // PUBLIC ACTIVITIES PANELS ... public ... Assign in FormMain Construction

        #region PUBLIC SUB-ACTIVITIES PANELS ... public ... Assign in FormMain Construction
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
        #endregion  // PUBLIC SUB-ACTIVITIES PANELS ... public ... Assign in FormMain Construction

        #region PUBLIC STATUS BAR Text ... public ... Assign in FormMain Construction
        public ToolStripStatusLabel STATUS_BAR_LABEL_SELECTED_STATE;    // Status Bar Selected View ... Label
        #endregion  // PUBLIC STATUS BAR Text ... public ... Assign in FormMain Construction

        #endregion  // FORM CONTROLS ... public ... Assign in FormMain Construction

        #endregion  // FIELDS

        #region PROPERTIES

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

        //-------------------------------------------------------------------------------------------------------------
        //-------------------------------------------- ArrayList Objects ----------------------------------------------
        //-------------------------------------------------------------------------------------------------------------

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

        //-------------------------------------------------------------------------------------------------------------
        //--------------------------------------- Last Activity Index State -------------------------------------------
        //-------------------------------------------------------------------------------------------------------------

        #region LastActivityIndex
        /// <summary>
        /// LastActivityIndex Property
        /// </summary>
        public int LastActivityIndex
        {
            get { return _nLastActivityIndex; }
            set { _nLastActivityIndex = value; }
        }
        #endregion      // LastActivityIndex

        //-------------------------------------------------------------------------------------------------------------
        //------------------------------------- Last SubActivity Index State ------------------------------------------
        //-------------------------------------------------------------------------------------------------------------

        #region LastInputSubActivityIndex
        /// <summary>
        /// LastInputSubActivityIndex Property
        /// </summary>
        public int LastInputSubActivityIndex
        {
            get { return _nLastInputSubActivityIndex; }
            set { _nLastInputSubActivityIndex = value; }
        }
        #endregion      // LastInputSubActivityIndex

        #region LastTargetsSubActivityIndex
        /// <summary>
        /// LastTargetsSubActivityIndex Property
        /// </summary>
        public int LastTargetsSubActivityIndex
        {
            get { return _nLastTargetsSubActivityIndex; }
            set { _nLastTargetsSubActivityIndex = value; }
        }
        #endregion      // LastTargetsSubActivityIndex

        #region LastHenSubActivityIndex
        /// <summary>
        /// LastHenSubActivityIndex Property
        /// </summary>
        public int LastHenSubActivityIndex
        {
            get { return _nLastHenSubActivityIndex; }
            set { _nLastHenSubActivityIndex = value; }
        }
        #endregion      // LastHenSubActivityIndex

        //-------------------------------------------------------------------------------------------------------------
        //-------------------------------------------- Selected State -------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------

        #region SelActivity
        /// <summary>
        /// SelActivity Property
        /// </summary>
        public int SelActivity
        {
            get { return _nSelActivity; }
            set { _nSelActivity = value; }
        }
        #endregion      // SelActivity

        #region SelSubActivity
        /// <summary>
        /// SelSubActivity Property
        /// </summary>
        public int SelSubActivity
        {
            get { return _nSelSubActivity; }
            set { _nSelSubActivity = value; }
        }
        #endregion      // SelSubActivity

        #region SelPK
        /// <summary>
        /// SelPK Property
        /// </summary>
        public int SelPK
        {
            get { return _nSelPK; }
            set { _nSelPK = value; }
        }
        #endregion      // SelPK

        #region SelRow
        /// <summary>
        /// SelRow Property
        /// </summary>
        public PanelTableRow SelRow
        {
            get { return _selRow; }
            set { _selRow = value; }
        }
        #endregion      // SelRow

        #region SelActivityName
        /// <summary>
        /// ActivityName Property
        /// </summary>
        public string SelActivityName
        {
            get { return _strSelActivityName; }
            set { _strSelActivityName = value; }
        }
        #endregion      // SelActivityName

        #region SelSubActivityName
        /// <summary>
        /// SelSubActivityName Property
        /// </summary>
        public string SelSubActivityName
        {
            get { return _strSelSubActivityName; }
            set { _strSelSubActivityName = value; }
        }
        #endregion      // SelSubActivityName

        #region SelPanelStatusName
        /// <summary>
        /// SelPanelStatusName Property
        /// </summary>
        public string SelPanelStatusName
        {
            get { return _strSelPanelStatusName; }
            set { _strSelPanelStatusName = value; }
        }
        #endregion      // SelPanelStatusName

        #region SelActivityTabControl
        /// <summary>
        /// SelActivityTabControl Property
        /// </summary>
        public TabControl SelActivityTabControl
        {
            get { return _selActivityTabControl; }
            set { _selActivityTabControl = value; }
        }
        #endregion      // SelActivityTabControl

        #region SelSubActivityTabControl
        /// <summary>
        /// SelSubActivityTabControl Property
        /// </summary>
        public TabControl SelSubActivityTabControl
        {
            get { return _selSubActivityTabControl; }
            set { _selSubActivityTabControl = value; }
        }
        #endregion      // SelSubActivityTabControl

        #region SelActivityPanel
        /// <summary>
        /// SelActivityPanel Property
        /// </summary>
        public Panel SelActivityPanel
        {
            get { return _selActivityPanel; }
            set { _selActivityPanel = value; }
        }
        #endregion      // SelActivityPanel

        #region SelSubActivityPanel
        /// <summary>
        /// SelSubActivityPanel Property
        /// </summary>
        public Panel SelSubActivityPanel
        {
            get { return _selSubActivityPanel; }
            set { _selSubActivityPanel = value; }
        }
        #endregion      // SelSubActivityPanel

        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public PanelTableMgr(PinchTypes pinchTypesObj)
        {
            string strMethod = "CTOR";
            string strMsg = string.Empty;
            PinchLogger.WriteSection("START PANEL TABLE CONSTRUCTION SECTION");
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating Object");
            try
            {
                PinchTypesObj = pinchTypesObj;              // Assign PinchTypes Object
                //---------------------------------
                //--- Create Empty List Objects ---
                //---------------------------------
                ActivitiesPanelList = new ArrayList();      // Activities Panel List
                SubActivitiesPanelList = new ArrayList();   // Sub-Activities Panel List
                LookupPanelInfoTable = new ArrayList();     // Lookup Panel Info Table
                                                            // PK used as index into SubActivities Panel List
                //----------------------------------------------------------------------
                //--- Set Initial Current Indices                                    ---
                //--- Initial State Set in InitializeMgrObjects() ... from FormMain  ---
                //----------------------------------------------------------------------
                SelActivity = -1;       // Initialize Activity Index
                SelSubActivity = -1;    // Initialize Sub-Activity Index
                SelPK = -1;             // Initialize Primary Key for SubActivities List and Lookup Table
            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                LogCurrentState(); // Log the current index state of the Panel Table Manager
                PinchLogger.WriteSection("END PANEL TABLE CONSTRUCTION SECTION");
            }
        }
        #endregion  // CTOR

        #region PUBLIC METHODS

        #region InitializeMgrObjects()
        /// <summary>
        /// Initialize the Lists and Table objects 
        /// Ensure all Panel objects are assigned to the public fields before invoking this method.
        /// Ensure all assigned Panel objects align with CONST indices
        /// (i.e., FormMain create Mgr object, assigns Panels and TabContols objects).
        /// Initial Selected State set.
        /// </summary>
        public void InitializeMgrObjects()
        {
            string strMethod = "InitializeMgrObjects()";
            string strMsg = string.Empty;

            int nInitialActivityIndex = INDEX_INPUT_PANEL;              // Initial Activity Index
            int nInitialSubActivityIndex = INDEX_INPUT_PROJECT_PANEL;   // Initial SubActivity Index
            try
            {
                //---------------------------
                //--- Populate ArrayLists ---
                //---------------------------
                PopulateActivitiesPanelList();      // Populate Activities Panel List
                PopulateSubActivitiesPanelTable();  // Populate SubActivities Panel List (PK as Index)
                PopulateLookupPanelInfoTable();     // Populate Lookup Panel Table (PK)
                //----------------------------------
                //--- Set Initial Selected State ---
                //----------------------------------
                SetSelectedState(nInitialActivityIndex, nInitialSubActivityIndex);
                //---------------------------------------
                //--- Set Initial Last Selected State ---
                //---------------------------------------
                LastActivityIndex = nInitialActivityIndex;
                LastInputSubActivityIndex = nInitialSubActivityIndex;
                LastTargetsSubActivityIndex = nInitialSubActivityIndex;
                LastHenSubActivityIndex = nInitialSubActivityIndex;
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

        #region DisplaySelectedView
        /// <summary>
        /// Display the Selected View which includes,
        ///   + the Main Tab Control
        ///   + the Activity Panel  [0:INPUT | 1:TARGETS | 2:HEN]
        ///   + Associated SubActivity Panel
        ///     - [0]:INPUT   : [0:PROJECT   | 1:STREAMS   | 2:UTILITIES | 
        ///                      3:COST      | 4:EXCHANGER | 5:VALIDATE  ]
        ///     - [1]:TARGETS : [0:CALCULATE | 1:COMPOSITE | 
        ///                      2:INTERVAL  | 3:OPTIMIZE  ]
        ///     - [2]:HEN     : [0:DESIGN ]
        ///   + Status Bar text ... [Activity, SUbActivity]
        ///        [0,0] : "INPUT:PROJECT"
        ///        [0,1] : "INPUT:STREAMS"
        ///        [0,2] : "INPUT:UTILITIES"
        ///        [0,3] : "INPUT:COST"
        ///        [0,4] : "INPUT:EXCHANGER"
        ///        [0,5] : "INPUT:VALIDATE"
        ///        [0,0] : "TARGETS:CALCULATE"
        ///        [1,1] : "TARGETS:COMPOSITE"
        ///        [1,2] : "TARGETS:INTERVAL"
        ///        [1,3] : "TARGETS:OPTIMIZE"
        ///        [2,0] : "HEN:DESIGN"
        /// </summary>
        /// <param name="nActivity">Activity Index</param>
        /// <param name="nSubActivity">SubActivity Index</param>
        /// <returns>PanelTableRow object on success; otherwise null</returns>
        public PanelTableRow DisplaySelectedView(int nActivity, int nSubActivity)
        {
            string strMethod = "DisplaySelectedView()";
            string strView = string.Empty;
            PanelTableRow row = null;
            try
            {
                ClearView();    // Clear View ... set Visible=false on Controls

                SetLastSelectedState(nActivity, nSubActivity);

                row = SetSelectedState(nActivity, nSubActivity);
                if (row == null) throw (new Exception("Set Selected State returns NULL Row!"));
                
                MAIN_TAB_CONTROL.Visible = true;
                MAIN_TAB_CONTROL.SelectedIndex = nActivity;

                SelectTabControlButton(nActivity, nSubActivity);

                SelActivityPanel.Visible = true;
                SelSubActivityPanel.Visible = true;

                strView = row.PanelStatusName;
                STATUS_BAR_LABEL_SELECTED_STATE.Text = strView;
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
            return row;     // Return Selected PanelTableRow object
        }
        #endregion      // DisplaySelectedView

        #region LOG METHODS

        #region LogCurrentState()
        /// <summary>
        /// Log the current index state of the Panel Table Manager.
        /// </summary>
        public void LogCurrentState()
        {
            string strMethod = "LogCurrentState()";
            string strMsg = string.Empty;
            try
            {
                PinchLogger.WriteSection("CURRENT TABLE MANAGER STATE");

                strMsg = String.Format(" ==> Current Primary Key (PK) : {0:00}  PANEL NAME: {1}", 
                                       SelPK, SelPanelStatusName);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = String.Format(" ==> Current Activity    Index: {0:00}  NAME: {1}", 
                                       SelActivity, SelActivityName);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = String.Format(" ==> Current SubActivity Index: {0:00}  Name: {1}", 
                                       SelSubActivity, SelSubActivityName);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                if(SelRow != null)  SelRow.LogRow();  // Log Row Data
                else PinchLogger.LogWarning(NAMESPACE, CLASS, strMethod, "Selected Row is Null! ... NOT Initialized Yet!");
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
        #endregion  // LogCurrentState()

        #region LogActivitiesPanelList()
        /// <summary>
        /// Log the contents of the Activities Panel List.
        /// </summary>
        public void LogActivitiesPanelList()
        {
            string strMethod = "LogActivitiesPanelList()";
            string strMsg = string.Empty;
            int nIndex = 0;     // ArrayList index
            try
            {
                PinchLogger.WriteSection("ACTIVITIES PANEL LIST");

                strMsg = String.Format("ACTIVITY   PANEL ");
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = String.Format(" INDEX     NAME");
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                PinchLogger.WriteSeparatorLine('-');

                foreach (Panel panel in ActivitiesPanelList)
                {
                    if(panel==null) strMsg = String.Format("   {0:00}      NULL ", nIndex);
                    else strMsg = String.Format("   {0:00}      {1} ", nIndex, panel.Name);
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                    
                    nIndex++;   // Increment Index
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
        #endregion  // LogActivitiesPanelList()

        #region LogSubActivitiesPanelList()
        /// <summary>
        /// Log the contents of the Aub-ctivities Panel List.
        /// </summary>
        public void LogSubActivitiesPanelList()
        {
            string strMethod = "LogSubActivitiesPanelList()";
            string strMsg = string.Empty;
            int nIndex = 0;     // ArrayList index
            try
            {
                PinchLogger.WriteSection("SUB-ACTIVITIES PANEL LIST");

                strMsg = String.Format("SUB-ACTIVITY   PANEL ");
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = String.Format("   INDEX       NAME");
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                PinchLogger.WriteSeparatorLine('-');

                foreach (Panel panel in SubActivitiesPanelList)
                {
                    if (panel == null) strMsg = String.Format("     {0:00}        NULL ", nIndex);
                    else strMsg = String.Format("     {0:00}        {1} ", nIndex, panel.Name);
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                    nIndex++;   // Increment Index
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
        #endregion  // LogSubActivitiesPanelList()

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
                //PinchLogger.WriteSection("LOOKUP PANEL INFORMATION TABLE");

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

        #endregion  // LOG METHODS

        #endregion  // PUBLIC METHODS

        #region PRIVATE METHODS

        #region POPULATE METHODS

        #region PopulateActivitiesPanelList()
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
                    LogActivitiesPanelList();   // Log Activities Panel List            
            }
        }
        #endregion  // PopulateActivitiesPanelList()

        #region PopulateSubActivitiesPanelTable()
        /// <summary>
        /// Populates the Sub-Activities Panels Table
        /// </summary>
        private void PopulateSubActivitiesPanelTable()
        {
            string strMethod = "PopulateSubActivitiesPanelTable()";
            string strMsg = string.Empty;
            try
            {
                SubActivitiesPanelList.Clear();
                //-------------------------------------------------------------
                SubActivitiesPanelList.Add(INPUT_PROJECT_PANEL);
                SubActivitiesPanelList.Add(INPUT_STREAMS_PANEL);
                SubActivitiesPanelList.Add(INPUT_UTILITIES_PANEL);
                SubActivitiesPanelList.Add(INPUT_COST_PANEL);
                SubActivitiesPanelList.Add(INPUT_EXCHANGER_PANEL);
                SubActivitiesPanelList.Add(INPUT_VALIDATE_PANEL);
                //-------------------------------------------------------------
                SubActivitiesPanelList.Add(TARGETS_CALCULATE_PANEL);
                SubActivitiesPanelList.Add(TARGETS_COMPOSITE_PANEL);
                SubActivitiesPanelList.Add(TARGETS_INTERVAL_PANEL);
                SubActivitiesPanelList.Add(TARGETS_OPTIMIZE_PANEL);
                //-------------------------------------------------------------
                SubActivitiesPanelList.Add(HEN_DESIGN_PANEL);
                //-------------------------------------------------------------
            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
               LogSubActivitiesPanelList();    // Log Sub-Activities Panel list
            }
        }
        #endregion  // PopulateSubActivitiesPanelTable()

        #region PopulateLookupPanelInfoTable()
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
                PinchLogger.WriteSection("LOOKUP PANEL INFORMATION TABLE");
                //---------------------------------------------------------------------------------
                strPanelStatusName = FormatPanelStatusName(NAME_INPUT_PANEL, NAME_INPUT_PROJECT_PANEL);
                row = new PanelTableRow(PK_INPUT_PROJECT_PANEL,      // Primary Key (PK)
                                        INDEX_INPUT_PANEL,           // Activity Index
                                        INDEX_INPUT_PROJECT_PANEL,   // SubActivity Index
                                        NAME_INPUT_PANEL,            // Activity Name
                                        NAME_INPUT_PROJECT_PANEL,    // SubActivity Name
                                        strPanelStatusName);         // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //---------------------------------------------------------------------------------
                strPanelStatusName = FormatPanelStatusName(NAME_INPUT_PANEL, NAME_INPUT_STREAMS_PANEL);
                row = new PanelTableRow(PK_INPUT_STREAMS_PANEL,      // Primary Key (PK)
                                        INDEX_INPUT_PANEL,           // Activity Index
                                        INDEX_INPUT_STREAMS_PANEL,   // SubActivity Index
                                        NAME_INPUT_PANEL,            // Activity Name
                                        NAME_INPUT_STREAMS_PANEL,    // SubActivity Name
                                        strPanelStatusName);         // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //---------------------------------------------------------------------------------
                strPanelStatusName = FormatPanelStatusName(NAME_INPUT_PANEL, NAME_INPUT_UTILITIES_PANEL);
                row = new PanelTableRow(PK_INPUT_UTILITIES_PANEL,    // Primary Key (PK)
                                        INDEX_INPUT_PANEL,           // Activity Index
                                        INDEX_INPUT_UTILITIES_PANEL, // SubActivity Index
                                        NAME_INPUT_PANEL,            // Activity Name
                                        NAME_INPUT_UTILITIES_PANEL,  // SubActivity Name
                                        strPanelStatusName);         // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //---------------------------------------------------------------------------------
                strPanelStatusName = FormatPanelStatusName(NAME_INPUT_PANEL, NAME_INPUT_COST_PANEL);
                row = new PanelTableRow(PK_INPUT_COST_PANEL,         // Primary Key (PK)
                                        INDEX_INPUT_PANEL,           // Activity Index
                                        INDEX_INPUT_COST_PANEL,      // SubActivity Index
                                        NAME_INPUT_PANEL,            // Activity Name
                                        NAME_INPUT_COST_PANEL,       // SubActivity Name
                                        strPanelStatusName);         // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //---------------------------------------------------------------------------------
                strPanelStatusName = FormatPanelStatusName(NAME_INPUT_PANEL, NAME_INPUT_EXCHANGER_PANEL);
                row = new PanelTableRow(PK_INPUT_EXCHANGER_PANEL,    // Primary Key (PK)
                                        INDEX_INPUT_PANEL,           // Activity Index
                                        INDEX_INPUT_EXCHANGER_PANEL, // SubActivity Index
                                        NAME_INPUT_PANEL,            // Activity Name
                                        NAME_INPUT_EXCHANGER_PANEL,  // SubActivity Name
                                        strPanelStatusName);         // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //---------------------------------------------------------------------------------
                strPanelStatusName = FormatPanelStatusName(NAME_INPUT_PANEL, NAME_INPUT_VALIDATE_PANEL);
                row = new PanelTableRow(PK_INPUT_VALIDATE_PANEL,     // Primary Key (PK)
                                        INDEX_INPUT_PANEL,           // Activity Index
                                        INDEX_INPUT_VALIDATE_PANEL,  // SubActivity Index
                                        NAME_INPUT_PANEL,            // Activity Name
                                        NAME_INPUT_VALIDATE_PANEL,   // SubActivity Name
                                        strPanelStatusName);         // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //=================================================================================
                strPanelStatusName = FormatPanelStatusName(NAME_TARGETS_PANEL, NAME_TARGETS_CALCULATE_PANEL);
                row = new PanelTableRow(PK_TARGETS_CALCULATE_PANEL,    // Primary Key (PK)
                                        INDEX_TARGETS_PANEL,           // Activity Index
                                        INDEX_TARGETS_CALCULATE_PANEL, // SubActivity Index
                                        NAME_TARGETS_PANEL,            // Activity Name
                                        NAME_TARGETS_CALCULATE_PANEL,  // SubActivity Name
                                        strPanelStatusName);           // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //---------------------------------------------------------------------------------
                strPanelStatusName = FormatPanelStatusName(NAME_TARGETS_PANEL, NAME_TARGETS_COMPOSITE_PANEL);
                row = new PanelTableRow(PK_TARGETS_COMPOSITE_PANEL,    // Primary Key (PK)
                                        INDEX_TARGETS_PANEL,           // Activity Index
                                        INDEX_TARGETS_COMPOSITE_PANEL, // SubActivity Index
                                        NAME_TARGETS_PANEL,            // Activity Name
                                        NAME_TARGETS_COMPOSITE_PANEL,  // SubActivity Name
                                        strPanelStatusName);           // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //---------------------------------------------------------------------------------
                strPanelStatusName = FormatPanelStatusName(NAME_TARGETS_PANEL, NAME_TARGETS_INTERVAL_PANEL);
                row = new PanelTableRow(PK_TARGETS_INTERVAL_PANEL,     // Primary Key (PK)
                                        INDEX_TARGETS_PANEL,           // Activity Index
                                        INDEX_TARGETS_INTERVAL_PANEL,  // SubActivity Index
                                        NAME_TARGETS_PANEL,            // Activity Name
                                        NAME_TARGETS_INTERVAL_PANEL,   // SubActivity Name
                                        strPanelStatusName);           // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //---------------------------------------------------------------------------------
                strPanelStatusName = FormatPanelStatusName(NAME_TARGETS_PANEL, NAME_TARGETS_OPTIMIZE_PANEL);
                row = new PanelTableRow(PK_TARGETS_OPTIMIZE_PANEL,     // Primary Key (PK)
                                        INDEX_TARGETS_PANEL,           // Activity Index
                                        INDEX_TARGETS_OPTIMIZE_PANEL,  // SubActivity Index
                                        NAME_TARGETS_PANEL,            // Activity Name
                                        NAME_TARGETS_OPTIMIZE_PANEL,   // SubActivity Name
                                        strPanelStatusName);           // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //=================================================================================
                strPanelStatusName = FormatPanelStatusName(NAME_HEN_PANEL, NAME_HEN_DESIGN_PANEL);
                row = new PanelTableRow(PK_HEN_DESIGN_PANEL,           // Primary Key (PK)
                                        INDEX_HEN_PANEL,               // Activity Index
                                        INDEX_HEN_DESIGN_PANEL,        // SubActivity Index
                                        NAME_HEN_PANEL,                // Activity Name
                                        NAME_HEN_DESIGN_PANEL,         // SubActivity Name
                                        strPanelStatusName);           // Panel Status Name
                LookupPanelInfoTable.Add(row);
                //=================================================================================
                PinchLogger.WriteSeparatorLine('-');

            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                 LogLookupPanelInfoTable();      // Log Table Contents
           }
        }
        #endregion  // PopulateLookupPanelInfoTable()

        #region SelectTabControlButton()
        private void SelectTabControlButton(int nActivity, int nSubActivity)
        {
            string strMethod = "SelectTabControlButton()";
            string strView = string.Empty;
            try
            {
                switch(nActivity)
                {
                    case INDEX_INPUT_PANEL:
                        INPUT_TAB_CONTROL.SelectedIndex = nSubActivity;
                        break;

                    case INDEX_TARGETS_PANEL:
                        TARGETS_TAB_CONTROL.SelectedIndex = nSubActivity;
                        break;

                    case INDEX_HEN_PANEL:
                        HEN_TAB_CONTROL.SelectedIndex = nSubActivity;
                        break;

                    default:
                        throw(new Exception("INVALID Acitiviy Index!"));
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
            }
        }
        #endregion  // SelectTabControlButton()

        #region FormatPanelStatusName()
        private string FormatPanelStatusName(string strActivity, string strSubActivity)
        {
            string strPanelStatusName = String.Format("{0}  :  {1}", strActivity, strSubActivity);
            return strPanelStatusName;
        }
        #endregion  // FormatPanelStatusName()

        #endregion  // POPULATE METHODS

        #region TABLE LOOKUP METHODS

        #region FindTableRow(int nPK)
        /// <summary>
        /// Look through the Lookup Panel Info Table for row matching user supplierd PK index
        /// </summary>
        /// <param name="nPK">Primary Key Index</param>
        /// <returns>PanelTableRow object if matching PK found; otherwise Null</returns>
        private PanelTableRow FindTableRow(int nPK)
        {
            string strMethod = "FindTableRow()";
            string strMsg = string.Empty;
            PanelTableRow row = null;
            try
            {
                foreach(PanelTableRow currRow in LookupPanelInfoTable)
                {
                    if (currRow.PK == nPK) return currRow;
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
            }            
            return row;     // Rturn row with assocated PK if found, otherwise NULL
        }
        #endregion  // FindTableRow(int nPK)

        #region FindTableRow(int nActivity, int nSubActivity)
        /// <summary>
        /// Look through the Lookup Panel Info Table for row 
        /// matching user supplierd Activity and SubActivity indices
        /// </summary>
        /// <param name="nPK">Primary Key Index</param>
        /// <returns>PanelTableRow object if matching indices are found; otherwise Null</returns>
        private PanelTableRow FindTableRow(int nActivity, int nSubActivity)
        {
            string strMethod = "FindTableRow()";
            string strMsg = string.Empty;
            PanelTableRow row = null;
            try
            {
                foreach (PanelTableRow currRow in LookupPanelInfoTable)
                {
                    if ((currRow.ActivityIndex == nActivity) &&
                        (currRow.SubActivityIndex == nSubActivity)) return currRow;
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
            }
            return row;     // Return row with assocated PK if found, otherwise NULL
        }
        #endregion  // FindTableRow(int nActivity, int nSubActivity)

        #endregion  // TABLE LOOKUP METHODS

        #region ClearView
        /// <summary>
        /// Clear View 
        ///  ... set Visible to false for Main Tab Control and All Panels
        ///  ... clear status bar Label text
        /// </summary>
        private void ClearView()
        {
            string strMethod = "ClearView()";
            string strMsg = string.Empty;
            try
            {
                MAIN_TAB_CONTROL.Visible = false;

                foreach (Panel panelAct in ActivitiesPanelList)
                {
                    panelAct.Visible = false;
                }

                foreach (Panel panelSub in SubActivitiesPanelList)
                {
                    panelSub.Visible = false;
                }

                STATUS_BAR_LABEL_SELECTED_STATE.Text = string.Empty;
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
        #endregion  // ClearView

        #region SetLastSelectedState()
        /// <summary>
        /// Assign the Last Selected Settings
        /// </summary>
        /// <param name="nActivityIndex">Activity Index</param>
        /// <param name="nSubActivityIndex">SubActivity Index</param>
        private void SetLastSelectedState(int nActivityIndex, int nSubActivityIndex)
        {
            string strMethod = "SetLastSelectedState()";
            string strMsg = string.Empty;
            try
            {
                LastActivityIndex = nActivityIndex;
                switch (nActivityIndex)
                {
                    case INDEX_INPUT_PANEL:
                        LastInputSubActivityIndex = nSubActivityIndex;
                        break;
                    case INDEX_TARGETS_PANEL:
                         LastTargetsSubActivityIndex = nSubActivityIndex;
                        break;
                    case INDEX_HEN_PANEL:
                        LastHenSubActivityIndex = nSubActivityIndex;
                        break;
                    default:
                        throw new Exception("*** INVALID: Activity Index!");
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
            }
        }

        #endregion  // SetLastSelectedState()

        #region SetSelectedState()
        /// <summary>
        /// Assign the Current Selected Settings
        /// </summary>
        /// <param name="nActivityIndex">Activity Index</param>
        /// <param name="nSubActivityIndex">SubActivity Index</param>
        /// <returns>Lookup Table Row Matching Indices</returns>
        private PanelTableRow SetSelectedState(int nActivityIndex, int nSubActivityIndex)
        {
            string strMethod = "SetSelectedState()";
            string strMsg = string.Empty;
            PanelTableRow row = null;
            try
            {
                SelActivity = nActivityIndex;           // Set Selected Activity     Index
                SelSubActivity = nSubActivityIndex;     // Set Selected Sub-Activity Index
                //--------------------------------------------------
                //--- Find Lookup Table Row for Selected Indices ---
                //--------------------------------------------------
                row = FindTableRow(SelActivity, SelSubActivity);   // Find Lookup Table Row for Selected Indices 
                if (row != null)
                {
                    SelPK = row.PK;

                    SelActivityName = row.ActivityName;
                    SelSubActivityName = row.SubActivityName;
                    SelPanelStatusName = row.PanelStatusName;

                    SelActivityPanel = (Panel)ActivitiesPanelList[SelActivity];
                    SelSubActivityPanel = (Panel)SubActivitiesPanelList[SelPK];
                }
                //---------------------------------
                //--- Main Activity Tab Control ---
                //---------------------------------
                SelActivityTabControl = MAIN_TAB_CONTROL;   // Activity TabControl ... ALWAYS MAIN_TAB_CONTROL
                //--------------------------------
                //--- Sub-Activity Tab Control ---
                //--------------------------------
                switch (SelActivity)
                {
                    case INDEX_INPUT_PANEL:
                        SelSubActivityTabControl = INPUT_TAB_CONTROL;   // INPUT SubActivity TabControl
                        break;
                    case INDEX_TARGETS_PANEL:
                        SelSubActivityTabControl = TARGETS_TAB_CONTROL; // TARGETS SubActivity TabControl
                        break;
                    case INDEX_HEN_PANEL:
                        SelSubActivityTabControl = HEN_TAB_CONTROL;     // HEN SubActivity TabControl
                        break;
                    default:
                        throw new Exception("*** INVALID Selected Activity Index for SubActivity Tab Control ***");
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
                SelRow = row;
            }
            return row;     // Return PanelTable Row Object
        }

        #endregion  // SetSelectedState()

        #endregion  // PRIVATE METHODS

    }
    #endregion  // public class PanelTableMgr
}
#endregion  // namespace Pinch

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
