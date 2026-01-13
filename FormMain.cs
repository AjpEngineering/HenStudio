#region HEADER
//#####################################################################################################################
//#############################################  F o r m M a i n . c s  ###############################################
//#####################################################################################################################
//  FILENAME:  FormMain.cs
//  NAMESPACE: Pinch
//  CLASS(S):  FormMain
//  COMPONENT: Pinch.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Main Pinch Form.
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;   // Chart Component
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

using PinchData;
using PinchGlobal;
using PinchHen;
using PinchTargets;
using System.CodeDom;

#endregion  // REFERENCES

#region namespace Pinch
namespace Pinch
{
    #region public partial class FormMain
    /// <summary>
    /// Pinch Main Form Class
    /// </summary>
    public partial class FormMain : Form
    {
        #region CONSTANTS
        const string NAMESPACE = "Pinch";
        const string CLASS = "FormMain";

        //#region PANEL INDICES
        ////------------------------
        ////--- MAIN TAB CONTROL ---
        ////------------------------
        //const int INDEX_INPUT_PANEL   = 0;
        //const int INDEX_TARGETS_PANEL = 1;
        //const int INDEX_HEN_PANEL     = 2;

        //#endregion  // PANEL INDICES

        const string PINCH_UNITS_ENGLISH = "English";
        const string PINCH_UNITS_METRIC = "Metric";

        const string PINCH_CALC_MODE_ENTER_CP = "Enter CP - Heat Capacity Flow Rate";
        const string PINCH_CALC_MODE_ENTER_F_Cp = "Enter Flow Rate and Specific Heat Capacity (Cp)";

        const string STREAM_TYPE_HOT = "HOT";
        const string STREAM_TYPE_COLD = "COLD";
        const string STREAM_TYPE_NA = "NA";

        const string STREAM_PHASE_LIQUID = "LIQUID";
        const string STREAM_PHASE_TWO_PHASE = "TWO-PHASE";
        const string STREAM_PHASE_VAPOR = "VAPOR";
        const string STREAM_PHASE_LNA = "NA";
        #endregion      // CONSTANTS

        #region ENUMS
        #endregion      // ENUMS

        #region FIELDS

        #region COLORS
        //--------------------------------
        //--- Stream Background Colors ---
        //--------------------------------
        private Color _colorBackgroundHotStream  = Color.LightCoral;
        private Color _colorBackgroundColdStream = Color.LightBlue;
        private Color _colorBackgroundNA_Stream  = Color.WhiteSmoke;
        //--------------------------
        //--- Stream Text Colors ---
        //--------------------------
        private Color _colorTextHotStream  = Color.Black;
        private Color _colorTextColdStream = Color.Black;
        private Color _colorTextNA_Stream  = Color.Black;
        #endregion  // COLORS

        #region SETTINGS
        private bool _bLicenseVerified;     // Pinch License Verified
        private bool _bInputVerified;       // Pinch Input Stream Data Verified
        private bool _bPinchEnglishUnits;   // Pinch English Units ... English (true)  Metric (false)
        private bool _bPinchCalcModeFCp;    // Pinch Calculation Mode ... Use CP (false)  Use F Cp (true)
        #endregion  // SETTINGS

        #region OBJECTS
        //---------------
        //--- OBJECTS ---
        //---------------
        private PinchTypes _pinchTypes;
        private PinchFileSystem _pinchFileSys;

        private PanelTableMgr _panelTableMgr;

        //private PinchProjectData _projectPropertiesDataObj;
        //private PinchInputMgr _pinchInput;
        //private EnergyTargetsMgr _pinchEnergyTargets;
        //private PinchReportMgr _pinchReport;
        #endregion  // OBJECTS

        #endregion      // FIELDS

        #region PROPERTIES

        #region COLORS
        //--------------
        //--- COLORS ---
        //--------------
        #region ColorBackgroundHotStream
        /// <summary>
        /// ColorBackgroundHotStream Property
        /// </summary>
        public Color ColorBackgroundHotStream
        {
            get { return _colorBackgroundHotStream; }
            set { _colorBackgroundHotStream = value; }
        }
        #endregion      // ColorBackgroundHotStream

        #region ColorBackgroundColdStream
        /// <summary>
        /// ColorBackgroundColdStream Property
        /// </summary>
        public Color ColorBackgroundColdStream
        {
            get { return _colorBackgroundColdStream; }
            set { _colorBackgroundColdStream = value; }
        }
        #endregion      // ColorBackgroundColdStream

        #region ColorBackgroundNA_Stream
        /// <summary>
        /// ColorBackgroundNA_Stream Property
        /// </summary>
        public Color ColorBackgroundNA_Stream
        {
            get { return _colorBackgroundNA_Stream; }
            set { _colorBackgroundNA_Stream = value; }
        }
        #endregion      // ColorBackgroundNA_Stream

        #region ColorTextHotStream
        /// <summary>
        /// ColorTextHotStream Property
        /// </summary>
        public Color ColorTextHotStream
        {
            get { return _colorTextHotStream; }
            set { _colorTextHotStream = value; }
        }
        #endregion      // ColorTextHotStream

        #region ColorTextColdStream
        /// <summary>
        /// ColorTextColdStream Property
        /// </summary>
        public Color ColorTextColdStream
        {
            get { return _colorTextColdStream; }
            set { _colorTextColdStream = value; }
        }
        #endregion      // ColorTextColdStream

        #region ColorTextNA_Stream
        /// <summary>
        /// ColorTextNA_Stream Property
        /// </summary>
        public Color ColorTextNA_Stream
        {
            get { return _colorTextNA_Stream; }
            set { _colorTextNA_Stream = value; }
        }
        #endregion      // ColorTextNA_Stream

        #endregion  // COLORS

        #region SETTINGS

        #region LicenseVerified
        /// <summary>
        /// LicenseVerified Property
        /// </summary>
        public bool LicenseVerified
        {
            get { return _bLicenseVerified; }
            set { _bLicenseVerified = value; }
        }
        #endregion      // LicenseVerified

        #region InputVerifiedFlag
        /// <summary>
        /// InputVerifiedFlag Property
        /// </summary>
        public bool InputVerifiedFlag
        {
            get { return _bInputVerified; }
            set { _bInputVerified = value; }
        }
        #endregion      // InputVerifiedFlag

        #region PinchEnglishUnitsFlag
        /// <summary>
        /// PinchEnglishUnitsFlag Property
        /// </summary>
        public bool PinchEnglishUnitsFlag
        {
            get { return _bPinchEnglishUnits; }
            set { _bPinchEnglishUnits = value; }
        }
        #endregion      // PinchEnglishUnitsFlag

        #region PinchCalcModeFCpFlag
        /// <summary>
        /// PinchCalcModeFCpFlag Property
        /// </summary>
        public bool PinchCalcModeFCpFlag
        {
            get { return _bPinchCalcModeFCp; }
            set { _bPinchCalcModeFCp = value; }
        }
        #endregion      // PinchCalcModeFCpFlag

        #endregion  // SETTINGS

        #region PINCH OBJECTS

        #region PanelTableMgrObj
        /// <summary>
        /// PanelTableMgrObj Property
        /// </summary>
        public PanelTableMgr PanelTableMgrObj
        {
            get { return _panelTableMgr; }
            set { _panelTableMgr = value; }
        }
        #endregion      // PanelTableMgrObj

        #endregion  // PINCH OBJECTS

        #region GLOBL OBJECTS
        //----------------------
        //--- GLOBAL OBJECTS ---
        //----------------------
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

        #region PinchFileSysObj
        /// <summary>
        /// PinchFileSystem Property
        /// </summary>
        public PinchFileSystem PinchFileSysObj
        {
            get { return _pinchFileSys; }
            set { _pinchFileSys = value; }
        }
        #endregion      // PinchFileSysObj

        #endregion  // GLOBL OBJECTS

        #region DATA OBJECTS
        //--------------------
        //--- DATA OBJECTS ---
        //--------------------
        //#region projectPropertiesDataObj
        ///// <summary>
        ///// projectPropertiesDataObj Property
        ///// </summary>
        //public PinchProjectData projectPropertiesDataObj
        //{
        //    get { return _projectPropertiesDataObj; }
        //    set { _projectPropertiesDataObj = value; }
        //}
        //#endregion      // projectPropertiesDataObj

        //#region PinchInputObj
        ///// <summary>
        ///// PinchInput Property
        ///// </summary>
        //public PinchInputMgr PinchInputObj
        //{
        //    get { return _pinchInput; }
        //    set { _pinchInput = value; }
        //}
        //#endregion      // PinchInputObj

        #endregion  // DATA OBJECTS

        #region TARGETS OBJECTS
        //#region PinchEnergyTargetsObj
        ///// <summary>
        ///// PinchEnergyTargetsObj Property
        ///// </summary>
        //public EnergyTargetsMgr PinchEnergyTargetsObj
        //{
        //    get { return _pinchEnergyTargets; }
        //    set { _pinchEnergyTargets = value; }
        //}
        //#endregion      // PinchEnergyTargetsObj

        #endregion  // TARGETS OBJECTS

        #region REPORTS OBJECTS
        //#region PinchReportObj
        ///// <summary>
        ///// PinchReport Property
        ///// </summary>
        //public PinchReportMgr PinchReportObj
        //{
        //    get { return _pinchReport; }
        //    set { _pinchReport = value; }
        //}
        //#endregion      // PinchReportObj

        #endregion  // REPORTS OBJECTS

        #region FIGURES OBJECTS
        #endregion  // FIGURES OBJECTS

        #region HEN OBJECTS
        #endregion  // HEN OBJECTS

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public FormMain()
        {
            string strMethod = "CTOR";
            string strMsg = string.Empty;
            PinchLogger.WriteHeader();
            PinchLogger.WriteSection("START CONSTRUCTION SECTION");
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating Object");
            try
            {
                InitializeComponent();
                this.Text = "AJP Pinch 4";
                //----------------------
                //--- Create Objects ---
                //----------------------
                PinchTypesObj = new PinchTypes();
                PinchFileSysObj = new PinchFileSystem();
                //------------------------
                //--- Initialize Flags ---
                //------------------------
                LicenseVerified = false;
                InputVerifiedFlag = false;
                //PinchEnglishUnitsFlag = true;
                //PinchCalcModeFCpFlag = false;
                //---------------------------
                //--- Initialize Controls ---
                //---------------------------
                InitializeControls();       // Set Inital State of the Form Controls
                //-----------------------------------
                //--- Create PanelTableMgr Object ---
                //-----------------------------------
                PanelTableMgrObj = new PanelTableMgr(PinchTypesObj);
                //-----------------------------------------------------------------------------------------------------
                //---------------------------- Assign ANALYSIS TabControl Panel Members -------------------------------
                //-----------------------------------------------------------------------------------------------------
                PanelTableMgrObj.MAIN_TAB_CONTROL = this.tabControlMain;    // ANALYSIS Tab Control
                PanelTableMgrObj.INPUT_PANEL   = this.panelINPUT;           // SUB-ANALYSIS Tab Control
                PanelTableMgrObj.TARGETS_PANEL = this.panelTARGETS;         // SUB-ANALYSIS Tab Control
                PanelTableMgrObj.HEN_PANEL     = this.panelHEN;             // SUB-ANALYSIS Tab Control
                //-----------------------------------------------------------------------------------------------------
                //-------------------------- Assign SUB-ANALYSIS TabControl Panel Members -----------------------------
                //-----------------------------------------------------------------------------------------------------
                PanelTableMgrObj.INPUT_TAB_CONTROL       = this.tabControlINPUT;          // Tab Control
                PanelTableMgrObj.INPUT_PROJECT_PANEL     = this.panelINPUT_PROJECT;       // Panel - PK: 00 ... [0,0]
                PanelTableMgrObj.INPUT_STREAMS_PANEL     = this.panelINPUT_STREAMS;       // Panel - PK: 01 ... [0,1]
                PanelTableMgrObj.INPUT_UTILITIES_PANEL   = this.panelINPUT_UTILITIES;     // Panel - PK: 02 ... [0,2]
                PanelTableMgrObj.INPUT_COST_PANEL        = this.panelINPUT_COST;          // Panel - PK: 03 ... [0,3]
                PanelTableMgrObj.INPUT_EXCHANGER_PANEL   = this.panelINPUT_EXCHANGER;     // Panel - PK: 04 ... [0,4]
                PanelTableMgrObj.INPUT_VALIDATE_PANEL    = this.panelINPUT_VALIDATE;      // Panel - PK: 05 ... [0,5]
                //-----------------------------------------------------------------------------------------------------
                PanelTableMgrObj.TARGETS_TAB_CONTROL     = this.tabControlTARGETS;        // Tab Control
                PanelTableMgrObj.TARGETS_CALCULATE_PANEL = this.panelTARGETS_CALCULATE;   // Panel - PK: 06 ... [1,0]
                PanelTableMgrObj.TARGETS_COMPOSITE_PANEL = this.panelTARGETS_COMPOSITE;   // Panel - PK: 07 ... [1,1]
                PanelTableMgrObj.TARGETS_INTERVAL_PANEL  = this.panelTARGETS_INTERVAL;    // Panel - PK: 08 ... [1,2]
                PanelTableMgrObj.TARGETS_OPTIMIZE_PANEL  = this.panelTARGETS_OPTIMIZE;    // Panel - PK: 09 ... [1,3]
                //-----------------------------------------------------------------------------------------------------
                PanelTableMgrObj.HEN_TAB_CONTROL         = this.tabControlHEN;            // Tab Control
                PanelTableMgrObj.HEN_DESIGN_PANEL        = this.panelHEN_DESIGN;          // Panel - PK: 10 ... [2,0]
                //-----------------------------------------------------------------------------------------------------
                PanelTableMgrObj.STATUS_BAR_LABEL_SELECTED_STATE =                        // StatusBar Label
                                                           this.toolStripStatusLabelSELECTED_STATE;
                //-----------------------------------------------------------------------------------------------------

                PanelTableMgrObj.InitializeMgrObjects();    // Initialize Lists and Table in Mgr
                PanelTableMgrObj.DisplaySelectedView(0,0);  // Display View


            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                PanelTableMgrObj.LogCurrentState(); // Log the current index state of the Panel Table Manager
                PinchLogger.WriteSection("END CONSTRUCTION SECTION");
            }
        }
        #endregion      // CTOR

        #region public void Initialize Controls
        /// <summary>
        /// Set Initial State of Controls
        /// </summary>
        public void InitializeControls()
        {
            string strMethod = "InitializeControls";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Initializing Controls");
            try
            {
                this.Text = "AJP Pinch 4";
                this.BackColor = PinchTypesObj.AJP_ENGINEERING_GREEN; // Form Background Color
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
        #endregion      // public void Initialize Controls

        #region EVENT HANDLERS

        #region MENU BAR EVENTS

        #region FILE MENU ITEMS

        #region NEW MENU ITEM HANDLER
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PinchMsgDlg.DisplayWarningDlg("New Menu Item Selected!");
        }
        #endregion  // NEW MENU ITEM HANDLER

        #region OPEN MENU ITEM HANDLER
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PinchMsgDlg.DisplayWarningDlg("Open Menu Item Selected!");
        }
        #endregion  // OPEN MENU ITEM HANDLER

        #region SAVE MENU ITEM HANDLER
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PinchMsgDlg.DisplayWarningDlg("Save Menu Item Selected!");
            HandleSave();
        }
        #endregion  // SAVE MENU ITEM HANDLER

        #region SAVE AS MENU ITEM HANDLER
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PinchMsgDlg.DisplayWarningDlg("Save As Menu Item Selected!");
            HandleSaveAs();
        }
        #endregion  // SAVE AS MENU ITEM HANDLER

        #region IMPORT MENU ITEM HANDLER
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PinchMsgDlg.DisplayWarningDlg("Import Menu Item Selected!");
            HandleImport();
        }
        #endregion  // IMPORT MENU ITEM HANDLER


        #region EXPORT MENU ITEM HANDLER
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PinchMsgDlg.DisplayWarningDlg("Export Menu Item Selected!");
            HandleExport();
        }
        #endregion  // EXPORT MENU ITEM HANDLER

        #region EXIT MEMU ITEM HANDLER
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleExit();    // Exit Pinch Application
        }
        #endregion       // EXIT MEMU ITEM HANDLER

        #endregion  // FILE MENU ITEMS

        #region ANALYSIS MENU ITEMS

        #region SPECIFY INPUT
        private void specifyInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strMethod = "specifyInputToolStripMenuItem_Click";
            int nActivity = PanelTableMgr.INDEX_INPUT_PANEL;
            int nSubActivity = PanelTableMgrObj.LastInputSubActivityIndex;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("Specify Input Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
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
        #endregion  // SPECIFY INPUT

        #region CALCULATE TARGETS
        private void calculateTargetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strMethod = "calculateTargetsToolStripMenuItem_Click";
            int nActivity = PanelTableMgr.INDEX_TARGETS_PANEL;
            int nSubActivity = PanelTableMgrObj.LastTargetsSubActivityIndex;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("Calculate Targets Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
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
        #endregion  // CALCULATE TARGETS

        #region DESIGN HEAT EXCHANGER NETWORK
        private void designHeatExchangerNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strMethod = "designHeatExchangerNetworkToolStripMenuItem_Click";
            int nActivity = PanelTableMgr.INDEX_HEN_PANEL;
            int nSubActivity = PanelTableMgrObj.LastHenSubActivityIndex;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("Design Heat Exchanger Network Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);

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
        #endregion  // DESIGN HEAT EXCHANGER NETWORK

        #endregion  // ANALYSIS MENU ITEMS

        #region SUB-ANALYSIS MENU ITEMS

        //=========================================================================================
        //======================================== INPUT ==========================================
        //=========================================================================================

        #region INPUT-PROJECT MENU EVENT
        private void inputProjectDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strMethod = "inputProjectDataToolStripMenuItem_Click";
            int nActivity = PanelTableMgr.INDEX_INPUT_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_INPUT_PROJECT_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("INPUT-PROJECT Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
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
        #endregion  // INPUT-PROJECT MENU EVENT

        #region INPUT-STREAMS MENU EVENT
        private void inputStreamsDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strMethod = "inputStreamsDataToolStripMenuItem_Click";
            int nActivity = PanelTableMgr.INDEX_INPUT_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_INPUT_STREAMS_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("INPUT-STREAMS Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
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
        #endregion  // INPUT-STREAMS MENU EVENT

        #region INPUT-UTILITIES MENU EVENT
        private void utilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strMethod = "utilitiesToolStripMenuItem_Click";
            int nActivity = PanelTableMgr.INDEX_INPUT_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_INPUT_UTILITIES_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("INPUT-UTILITIES Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
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
        #endregion  // INPUT-UTILITIES MENU EVENT

        #region INPUT-COST MENU EVENT
        private void costToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strMethod = "costToolStripMenuItem_Click";
            int nActivity = PanelTableMgr.INDEX_INPUT_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_INPUT_COST_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("INPUT-COST Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
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
        #endregion  // INPUT-COST MENU EVENT

        #region INPUT-EXCHANGER MENU EVENT
        private void exchangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strMethod = "exchangerToolStripMenuItem_Click";
            int nActivity = PanelTableMgr.INDEX_INPUT_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_INPUT_EXCHANGER_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("INPUT-EXCHANGER Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
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
        #endregion  // INPUT-EXCHANGER MENU EVENT

        #region INPUT-VALIDATE MENU EVENT
        private void validateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strMethod = "validateToolStripMenuItem_Click";
            int nActivity = PanelTableMgr.INDEX_INPUT_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_INPUT_VALIDATE_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("INPUT-VALIDATE Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
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
        #endregion  // INPUT-VALIDATE MENU EVENT

        //=========================================================================================
        //======================================= TARGETS =========================================
        //=========================================================================================

        #region TARGETS-CALCULATE MENU EVENT
        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strMethod = "calculateToolStripMenuItem_Click";
            int nActivity = PanelTableMgr.INDEX_TARGETS_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_TARGETS_CALCULATE_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("TARGETS-CALCULATE Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
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
        #endregion  // TARGETS-CALCULATE MENU EVENT

        #region TARGETS-COMPOSITE MENU EVENT
        private void compositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strMethod = "compositeToolStripMenuItem_Click";
            int nActivity = PanelTableMgr.INDEX_TARGETS_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_TARGETS_COMPOSITE_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("TARGETS-COMPOSITE Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
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
        #endregion  // TARGETS-COMPOSITE MENU EVENT

        #region TARGETS-INTERVAL MENU EVENT
        private void intervalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strMethod = "intervalToolStripMenuItem_Click";
            int nActivity = PanelTableMgr.INDEX_TARGETS_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_TARGETS_INTERVAL_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("TARGETS-INTERVAL Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
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
        #endregion  // TARGETS-INTERVAL MENU EVENT

        #region TARGETS-OPTIMIZE MENU EVENT
        private void optimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strMethod = "optimizeToolStripMenuItem_Click";
            int nActivity = PanelTableMgr.INDEX_TARGETS_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_TARGETS_OPTIMIZE_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("TARGETS-OPTIMIZE Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
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
        #endregion  // TARGETS-OPTIMIZE MENU EVENT

        //=========================================================================================
        //========================================== HEN ==========================================
        //=========================================================================================

        #region HEN-DESIGN MENU EVENT
        private void designToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strMethod = "designToolStripMenuItem_Click";
            int nActivity = PanelTableMgr.INDEX_HEN_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_HEN_DESIGN_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("HEN-DESIGN Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
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
        #endregion  // HEN-DESIGN MENU EVENT

        #endregion  // SUB-ANALYSIS MENU ITEMS

        #region HELP MENU ITEMS

        #region LICENSE
        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PinchMsgDlg.DisplayWarningDlg("License Menu Item Selected!");
            // TODO: Create FormLicense dialog - pass in LicenceData Object
        }
        #endregion      // LICENSE

        #region ABOUT
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutPinch dlg = new FormAboutPinch();
            dlg.PinchTypesObj = this.PinchTypesObj;     // Assign Global Types and Properties
            dlg.ShowDialog();
        }
        #endregion  // ABOUT

        #endregion  // HELP MENU ITEMS

        #endregion  // MENU BAR EVENTS

        #region TOOLBAR EVENTS

        #region TOOLBAR NEW BUTTON EVENT
        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            //PinchMsgDlg.DisplayWarningDlg("New Toobar Button Pressed!");
            HandleNew();
        }
        #endregion  // TOOLBAR NEW BUTTON EVENT

        #region TOOLBAR OPEN BUTTON EVENT
        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            //PinchMsgDlg.DisplayWarningDlg("Open Toobar Button Pressed!");
            HandleOpen();
        }
        #endregion  // TOOLBAR OPEN BUTTON EVENT

        #region TOOLBAR SAVE BUTTON EVENT
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            //PinchMsgDlg.DisplayWarningDlg("Save Toobar Button Pressed!");
            HandleSave();
        }
        #endregion  // TOOLBAR SAVE BUTTON EVENT

        #region TOOLBAR SAVE AS BUTTON EVENT
        private void toolStripButtonSaveAs_Click(object sender, EventArgs e)
        {
            //PinchMsgDlg.DisplayWarningDlg("Save As Toobar Button Pressed!");
            HandleSaveAs();
        }
        #endregion      // TOOLBAR SAVE AS BUTTON EVENT

        #region TOOLBAR IMPORT BUTTON EVENT
        private void toolStripButtonImport_Click(object sender, EventArgs e)
        {
            //PinchMsgDlg.DisplayWarningDlg("Import Toobar Button Pressed!");
            HandleImport();
        }
        #endregion  // TOOLBAR IMPORT BUTTON EVENT

        #region TOOLBAR EXPORT BUTTON EVENT
        private void toolStripButtonExport_Click(object sender, EventArgs e)
        {
            //PinchMsgDlg.DisplayWarningDlg("Export Toobar Button Pressed!");
            HandleExport();
        }
        #endregion  // TOOLBAR EXPORT BUTTON EVENT

        #region TOOLBAR INPUT-PROJECT BUTTON EVENT
        private void toolStripButtonProject_Click(object sender, EventArgs e)
        {

            string strMethod = "toolStripButtonProject_Click";
            int nActivity = PanelTableMgr.INDEX_INPUT_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_INPUT_PROJECT_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("INPUT-PROJECT Toobar Button Pressed!");
                HandleViewCommand(nActivity, nSubActivity);
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
        #endregion  // TOOLBAR INPUT-PROJECT BUTTON EVENT

        #endregion  // TOOLBAR EVENTS

        #region TAB CONTROL EVENTS

        #region MAIN ANALYSIS TAB CONTROL

        #region tabControlMain_SelectedIndexChanged
        /// <summary>
        /// MAIN TabControl Selected Index Changed Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strMethod = "tabControlMain_SelectedIndexChanged()";
            int nActivity;
            int nSubActivity;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("MAIN ANALYSIS Tab Control Index Selected Changed!");
                nActivity = PanelTableMgrObj.MAIN_TAB_CONTROL.SelectedIndex;
                switch (nActivity)
                {
                    case PanelTableMgr.INDEX_INPUT_PANEL:
                        nSubActivity = PanelTableMgrObj.LastInputSubActivityIndex;
                        break;
                    case PanelTableMgr.INDEX_TARGETS_PANEL:
                        nSubActivity = PanelTableMgrObj.LastTargetsSubActivityIndex;
                        break;
                    case PanelTableMgr.INDEX_HEN_PANEL:
                        nSubActivity = PanelTableMgrObj.LastHenSubActivityIndex;
                        break;
                    default:
                        throw new Exception("INVALID Activity Index!");
                }
                HandleViewCommand(nActivity, nSubActivity);
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
        #endregion  // tabControlMain_SelectedIndexChanged

        #endregion  // MAIN ANALYSIS TAB CONTROL

        #region INPUT TAB CONTROL
        private void tabControlINPUT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strMethod = "tabControlINPUT_SelectedIndexChanged()";
            int nActivity;
            int nSubActivity;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("INPUT Tab Control Index Selected Changed!");
                nActivity = PanelTableMgr.INDEX_INPUT_PANEL;
                nSubActivity = this.tabControlINPUT.SelectedIndex; ;
                HandleViewCommand(nActivity, nSubActivity);
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
        #endregion  // INPUT TAB CONTROL

        #region TARGETS TAB CONTROL
        private void tabControlTARGETS_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strMethod = "tabControlTARGETS_SelectedIndexChanged()";
            int nActivity;
            int nSubActivity;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("TARGETS Tab Control Index Selected Changed!");
                nActivity = PanelTableMgr.INDEX_TARGETS_PANEL;
                nSubActivity = this.tabControlTARGETS.SelectedIndex; ;
                HandleViewCommand(nActivity, nSubActivity);
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

        #endregion  // TARGETS TAB CONTROL

        #region HEN TAB CONTROL
        private void tabControlHEN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strMethod = "tabControlHEN_SelectedIndexChanged()";
            int nActivity;
            int nSubActivity;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("HEN Tab Control Index Selected Changed!");
                nActivity = PanelTableMgr.INDEX_HEN_PANEL;
                nSubActivity = this.tabControlHEN.SelectedIndex; ;
                HandleViewCommand(nActivity, nSubActivity);
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

        #endregion  // HEN TAB CONTROL

        #endregion  // TAB CONTROL EVENTS

        #endregion      // EVENT HANDLERS

        #region METHODS

        #region COMMON COMMAND HANDLERS

        #region HandleNew
        /// <summary>
        /// Common New Command Handler
        /// </summary>
        private void HandleNew()
        {
            string strMethod = "HandleNew";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "New Project");
            try
            {
                PinchMsgDlg.DisplayWarningDlg("Handle NEW Command!");
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
        #endregion  // HandleNew

        #region HandleOpen
        /// <summary>
        /// Common Open Command Handler
        /// </summary>
        private void HandleOpen()
        {
            string strMethod = "HandleOpen";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Open Project");
            try
            {
                PinchMsgDlg.DisplayWarningDlg("Handle OPEN Command!");
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
        #endregion  // HandleOpen

        #region HandleSave
        /// <summary>
        /// Common Save Command Handler
        /// </summary>
        private void HandleSave()
        {
            string strMethod = "HandleSave";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Save Project");
            try
            {
                PinchMsgDlg.DisplayWarningDlg("Handle SAVE Command!");
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
        #endregion  // HandleSave

        #region HandleSaveAs
        /// <summary>
        /// Common Save A Command Handler
        /// </summary>
        private void HandleSaveAs()
        {
            string strMethod = "HandleSaveAs";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Save Project");
            try
            {
                PinchMsgDlg.DisplayWarningDlg("Handle SAVE AS Command!");
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
        #endregion  // HandleSaveAs

        #region HandleImport
        /// <summary>
        /// Common Import Pinch Results ... invoked from Menu Item and Toolbar Click events
        /// </summary>
        private void HandleImport()
        {
            string strMethod = "HandleImport";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Import Pinch Results");
            try
            {
                PinchMsgDlg.DisplayWarningDlg("Handle IMPORT Command!");
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
        #endregion  // HandleImport

        #region HandleExport
        /// <summary>
        /// Common Export Pinch Results ... invoked from Menu Item and Toolbar Click events
        /// </summary>
        private void HandleExport()
        {
            string strMethod = "HandleExport";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Export Pinch Results");
            try
            {
                PinchMsgDlg.DisplayWarningDlg("Handle EXPORT Command!");
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
        #endregion  // HandleExport

        #region HandleExit
        /// <summary>
        /// Common Exit Pinch Application ... invoked from Menu Item and Toolbar Click events
        /// </summary>
        private void HandleExit()
        {
            string strMethod = "HandleExit";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Exiting Pinch Application");
            try
            {
                this.Close();
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
        #endregion  // HandleExit

        #region HandleViewCommand
        private void HandleViewCommand(int nActivity, int nSubActivity)
        {
            string strMethod = "HandleViewCommand";
            PanelTableRow row;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("Handle View Command!");
                row = PanelTableMgrObj.DisplaySelectedView(nActivity, nSubActivity);
                if (row == null) throw (new Exception("Handle View Command: Null View"));
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
        #endregion  // HandleViewCommand

        #endregion  // COMMON COMMAND HANDLERS

        #region LOG METHODS

        #region private string GetFixedLengthString(string strOriginal, int nLen=15)
        /// <summary>
        /// Get a Fixed Length Padded/Ellipsed String GIVEN String and Length
        /// Default length is 15 characters - pad with ' ' , ellipse "..."
        /// </summary>
        /// <param name="strOriginal">Original String</param>
        /// <param name="nLen">Fixed length of the final string</param>
        /// <returns></returns>
        private string GetFixedLengthString(string strOriginal, int nLen = 15)
        {
            string strTemp = string.Empty;
            string strFixedLengthString = string.Empty;
            string strPad = string.Empty;
            int nPad = 0;
            //--------------------
            //--- Lenght Guard ---
            //--------------------
            if (nLen < 4) return strOriginal;   // Minimum Fixed Length check
            //---------------------
            //--- Update String ---
            //---------------------
            if (strOriginal.Length == nLen) strFixedLengthString = strOriginal;
            else if (strOriginal.Length > nLen)
            {
                strTemp = strOriginal.Substring(0, nLen - 4);
                strFixedLengthString = string.Format("{0}...", strTemp);
            }
            else
            {
                nPad = nLen - strOriginal.Length;
                strPad = new string(' ', nPad);
                strFixedLengthString = string.Format("{0}{1}", strOriginal, strPad);
            }
            //----------------------------------
            //--- Return Fixed Length String ---
            //----------------------------------
            return strFixedLengthString;
        }










        #endregion      // private string GetFixedLengthString(string strOriginal, int nLen=15)

        #endregion      // LOG METHODS

        #endregion  // METHODS

    }
    #endregion      // class FormPinch
}
#endregion      // namespace Pinch
//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
