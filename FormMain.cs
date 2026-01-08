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
        private bool _bPinchEnglishUnits;   // Pinch English Units ... English (true)  Metric (false)
        private bool _bPinchCalcModeFCp;    // Pinch Calculation Mode ... Use CP (false)  Use F Cp (true)
        private bool _bInputVerified;       // Pinch Input Stream Data Verified
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

        #region PANELS
        //--------------------------
        //--- On MAIN TabControl ---
        //--------------------------
        private TabControl MAIN_TAB_CONTROL;
        //private Panel INPUT_PANEL;      // INPUT Panel   - Index: INDEX_INPUT_PANEL
        //private Panel TARGETS_PANEL;    // TARGETS Panel - Index: INDEX_TARGETS_PANEL
        //private Panel HEN_PANEL;        // HEN Panel     - Index: INDEX_HEN_PANEL


        #endregion  // PANELS

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
        //----------------
        //--- SETTINGS ---
        //----------------
        #region bPinchEnglishUnitsFlag
        /// <summary>
        /// bPinchEnglishUnitsFlag Property
        /// </summary>
        public bool bPinchEnglishUnitsFlag
        {
            get { return _bPinchEnglishUnits; }
            set { _bPinchEnglishUnits = value; }
        }
        #endregion      // bPinchEnglishUnitsFlag

        #region bPinchCalcModeFCpFlag
        /// <summary>
        /// bPinchCalcModeFCpFlag Property
        /// </summary>
        public bool bPinchCalcModeFCpFlag
        {
            get { return _bPinchCalcModeFCp; }
            set { _bPinchCalcModeFCp = value; }
        }
        #endregion      // bPinchCalcModeFCpFlag

        #region bInputVerifiedFlag
        /// <summary>
        /// bInputVerifiedFlag Property
        /// </summary>
        public bool bInputVerifiedFlag
        {
            get { return _bInputVerified; }
            set { _bInputVerified = value; }
        }
        #endregion      // bInputVerifiedFlag

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
                //bPinchEnglishUnitsFlag = true;
                //bPinchCalcModeFCpFlag = false;
                //bInputVerifiedFlag = false;
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
                MAIN_TAB_CONTROL = this.tabControlMain;    // ANALYSIS Tab Control <<*** TEMP *************************
                PanelTableMgrObj.MAIN_TAB_CONTROL = this.tabControlMain;    // ANALYSIS Tab Control
                PanelTableMgrObj.INPUT_PANEL   = this.panelINPUT;           // SUB-ANALYSIS Tab Control
                PanelTableMgrObj.TARGETS_PANEL = this.panelTARGETS;         // SUB-ANALYSIS Tab Control
                PanelTableMgrObj.HEN_PANEL     = this.panelHEN;             // SUB-ANALYSIS Tab Control
                //-----------------------------------------------------------------------------------------------------
                //-------------------------- Assign SUB-ANALYSIS TabControl Panel Members -----------------------------
                //-----------------------------------------------------------------------------------------------------
                //PanelTableMgrObj.INPUT_TAB_CONTROL       = this.tabControlINPUT;          // Tab Control
                //PanelTableMgrObj.INPUT_PROJECT_PANEL     = this.panelINPUT_PROJECT;       // Panel - PK: 00 ... [0,0]
                //PanelTableMgrObj.INPUT_STREAMS_PANEL     = this.panelINPUT_STREAMS;       // Panel - PK: 01 ... [0,1]
                //PanelTableMgrObj.INPUT_UTILITIES_PANEL   = this.panelINPUT_UTILITIES;     // Panel - PK: 02 ... [0,2]
                //PanelTableMgrObj.INPUT_COST_PANEL        = this.panelINPUT_COST;          // Panel - PK: 03 ... [0,3]
                //PanelTableMgrObj.INPUT_EXCHANGER_PANEL   = this.panelINPUT_EXCHANGER;     // Panel - PK: 04 ... [0,4]
                //PanelTableMgrObj.INPUT_VALIDATE_PANEL    = this.panelINPUT_VALIDATE;      // Panel - PK: 05 ... [0,5]
                //-----------------------------------------------------------------------------------------------------
                //PanelTableMgrObj.TARGETS_TAB_CONTROL     = this.tabControlTARGETS;        // Tab Control
                //PanelTableMgrObj.TARGETS_CALCULATE_PANEL = this.panelTARGETS_CALCULATE;   // Panel - PK: 06 ... [1,0]
                //PanelTableMgrObj.TARGETS_COMPOSITE_PANEL = this.panelTARGETS_COMPOSITE;   // Panel - PK: 07 ... [1,1]
                //PanelTableMgrObj.TARGETS_INTERVAL_PANEL  = this.panelTARGETS_INTERVAL;    // Panel - PK: 08 ... [1,2]
                //PanelTableMgrObj.TARGETS_OPTIMIZE_PANEL  = this.panelTARGETS_OPTIMIZE;    // Panel - PK: 09 ... [1,3]
                //-----------------------------------------------------------------------------------------------------
                //PanelTableMgrObj.HEN_TAB_CONTROL         = this.tabControlHEN;            // Tab Control
                //PanelTableMgrObj.HEN_DESIGN_PANEL        = this.panelHEN_DESIGN;          // Panel - PK: 10 ... [2,0]
                //-----------------------------------------------------------------------------------------------------

                PanelTableMgrObj.InitializeMgrObjects();    // Initialize Lists and Table in Mgr

                //SelectAnalysisPanel(0); // Initially Display INPUT Panel
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

        #region FORM EVENTS

        #region tabControlMain_SelectedIndexChanged
        /// <summary>
        /// MAIN TabControl Selected Index Changed Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strMethod = "tabControlMain_SelectedIndexChanged()";
            string strMsg = string.Empty;
            int nSelectedIndex = MAIN_TAB_CONTROL.SelectedIndex;
           try
            {
                //----------------------------------------------------
                //--- Select the correct Analysis Panel to Display ---
                //----------------------------------------------------
                //SelectAnalysisPanel(nSelectedIndex);
                PinchMsgDlg.DisplayWarningDlg("Main Tab Control Index Selected Changed!");

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

        #endregion  // FORM EVENTS

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
            PinchMsgDlg.DisplayWarningDlg("Save Menu Item Selected!");
        }
        #endregion  // SAVE MENU ITEM HANDLER

        #region SAVE AS MENU ITEM HANDLER
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PinchMsgDlg.DisplayWarningDlg("Save As Menu Item Selected!");
        }
        #endregion  // SAVE AS MENU ITEM HANDLER

        #region EXIT MEMU ITEM HANDLER
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitPinch();    // Exit Pinch Application
        }
        #endregion       // EXIT MEMU ITEM HANDLER

        #endregion  // FILE MENU ITEMS

        #region ANALYSIS MENU ITEMS

        #region SPECIFY INPUT
        private void specifyInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SelectAnalysisPanel(PanelTableMgr.INDEX_INPUT_PANEL);     // Display INPUT Panel

            PinchMsgDlg.DisplayWarningDlg("Specify Input Menu Item Selected!");
        }
        #endregion  // SPECIFY INPUT

        #region CALCULATE TARGETS
        private void calculateTargetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SelectAnalysisPanel(PanelTableMgr.INDEX_TARGETS_PANEL);     // Display TARGETS Panel

            PinchMsgDlg.DisplayWarningDlg("Calculate Targets Menu Item Selected!");
        }
        #endregion  // CALCULATE TARGETS

        #region DESIGN HEAT EXCHANGER NETWORK
        private void designHeatExchangerNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SelectAnalysisPanel(PanelTableMgr.INDEX_HEN_PANEL);     // Display HEN Panel

            PinchMsgDlg.DisplayWarningDlg("Design Heat Exchanger Network Menu Item Selected!");
        }
        #endregion  // DESIGN HEAT EXCHANGER NETWORK

        #endregion  // ANALYSIS MENU ITEMS

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

        #endregion      // EVENT HANDLERS

        #region METHODS

        //#region SelectAnalysisPanel METHOD
        ///// <summary>
        ///// Select the correct Analysis Panel to Display 
        ///// based on selected index supplied to method
        /////     INDEX_INPUT_PANEL ..... [0] ---> INPUT Panel
        /////     INDEX_TARGETS_PANEL ... [1] ---> TARGETS Panel
        /////     INDEX_HEN_PANEL ....... [2] ---> HEN Panel
        ///// </summary>
        ///// <param name="nSelectedIndex">Selected Panel Index</param>
        //private void SelectAnalysisPanel(int nSelectedIndex)
        //{
        //    string strMethod = "SelectAnalysisPanel";
        //    string strMsg = string.Empty;
        //    try
        //    {
        //        switch (nSelectedIndex)
        //        {
        //            case 0:
        //                INPUT_PANEL.Visible = true;
        //                TARGETS_PANEL.Visible = false;
        //                HEN_PANEL.Visible = false;

        //                INPUT_PANEL.Show();
        //                INPUT_PANEL.Focus();
        //                INPUT_PANEL.Select();
        //                INPUT_PANEL.BringToFront();
        //                break;
        //            case 1:
        //                TARGETS_PANEL.Visible = true;
        //                INPUT_PANEL.Visible = false;
        //                HEN_PANEL.Visible = false;

        //                TARGETS_PANEL.Show();
        //                TARGETS_PANEL.Focus();
        //                TARGETS_PANEL.Select();
        //                TARGETS_PANEL.BringToFront();
        //                break;
        //            case 2:
        //                HEN_PANEL.Visible = true;
        //                TARGETS_PANEL.Visible = false;
        //                INPUT_PANEL.Visible = false;

        //                HEN_PANEL.Show();
        //                HEN_PANEL.Focus();
        //                HEN_PANEL.Select();
        //                HEN_PANEL.BringToFront();
        //                break;
        //        }

        //        //----------------------------------------
        //        //--- Update Main Analysis Tab Control ---
        //        //----------------------------------------
        //        MAIN_TAB_CONTROL.SelectedIndex = nSelectedIndex;

        //        //****************
        //        //***** TEST *****
        //        //****************
        //        //string strTemp = String.Format("SELECTED INDEX = {0}", nSelectedIndex);
        //        //PinchMsgDlg.DisplayInfoDlg(strTemp);
        //    }
        //    catch (Exception ex)
        //    {
        //        PinchLogger.WriteSeparatorLine('*');
        //        PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
        //        PinchLogger.WriteSeparatorLine('*');
        //    }
        //    finally
        //    {
        //    }
        //}
        //#endregion  // SelectAnalysisPanel METHOD

        #region ExitPinch METHOD
        /// <summary>
        /// Common Exit Pinch Application ... invoked from Menu Item and Toolbar Click events
        /// </summary>
        private void ExitPinch()
        {
            string strMethod = "ExitPinch";
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
        #endregion  // ExitPinch METHOD

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
