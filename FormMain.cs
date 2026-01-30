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
using System.Collections;
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

using AJP_License_File;
using PinchData;
using PinchGlobal;
using PinchHen;
using PinchTargets;
using System.CodeDom;
using Pinch.Properties;
using System.IO;

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

        const string LICENSE_TYPE_UNKNOWN = "UNKNOWN";
        const string LICENSE_TYPE_TRIAL= "TRIAL";
        const string LICENSE_TYPE_SITE = "SITE";
        const string LICENSE_TYPE_DEVICE = "DEVICE";
        const string LICENSE_TYPE_USER = "USER";
        const string LICENSE_TYPE_SEAT = "SEAT";

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
        private LicenseMgr      _licenseMgrObj;

        private PinchFileSystem _pinchFileSys;
        private PinchSettings   _pinchSettings;
        private PinchTypes      _pinchTypes;

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

        #region LICENSE MANAGER OBJECTS

        #region LicenseMgrObj
        /// <summary>
        /// LicenseMgrObj Property
        /// </summary>
        public LicenseMgr LicenseMgrObj
        {
            get { return _licenseMgrObj; }
            set { _licenseMgrObj = value; }
        }
        #endregion      // LicenseMgrObj     

        #endregion  // LICENSE MANAGER OBJECTS

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

        #region PinchSettingsObj
        /// <summary>
        /// PinchSettingsObj Property
        /// </summary>
        public PinchSettings PinchSettingsObj
        {
            get { return _pinchSettings; }
            set { _pinchSettings = value; }
        }
        #endregion      // PinchSettingsObj

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

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        //------------------------------------------------------------ CTOR ---
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public FormMain()
        {
            string strMethod = "CTOR";
            string strMsg = string.Empty;
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating Object");
            bool bValidLicenseFile = false;
            try
            {
                InitializeComponent();
                this.Text = "AJP Pinch 4";
                //----------------------
                //--- Create Objects ---
                //----------------------
                PinchFileSysObj = new PinchFileSystem();
                PinchSettingsObj = new PinchSettings();
                PinchTypesObj = new PinchTypes();

                LicenseMgrObj = new LicenseMgr(PinchFileSysObj.LicenseFilePath);
                //------------------------------------------
                //--- Initialize License Global Settings ---
                //------------------------------------------
                PinchSettingsObj.LicenseValidatedFlag = false;
                PinchSettingsObj.LicenseTypeEnum = PinchTypes.LicenseType.UNKNOWN;
                PinchSettingsObj.LicenseStatusEnum = PinchTypes.LicenseStatus.UNKNOWN;

                PinchSettingsObj.InputValidatedFlag = false;
                PinchSettingsObj.TargetsCalculatedFlag = false;

                //---------------------------------------
                //--- Initialize Units Global Setting ---
                //---------------------------------------
                //PinchEnglishUnitsFlag = true;
                //---------------------------
                //--- Initialize Controls ---
                //---------------------------
                InitializeControls();       // Set Inital State of the Form Controls
                
                #region Create PanelTableMgr Object
                //-----------------------------------
                //--- Create PanelTableMgr Object ---
                //-----------------------------------
                PanelTableMgrObj = new PanelTableMgr(PinchTypesObj, PinchSettingsObj);
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
                PanelTableMgrObj.STATUS_BAR_LABEL_SELECTED_STATE =                        // StatusBar View Label
                                                           this.toolStripStatusLabelSELECTED_STATE;
                PanelTableMgrObj.STATUS_BAR_LABEL_LICENSE_STATE =                         // StatusBar License Label
                                                           this.toolStripStatusLabelLicense;
                //-----------------------------------------------------------------------------------------------------

                //---------------------------------------------------------------------
                //--- Initialize List and Table Object for Dynamic Panel Management ---
                //--- Set Initial View                                              ---
                //---------------------------------------------------------------------
                PanelTableMgrObj.InitializeMgrObjects();    // Initialize Lists and Table in Mgr
                PanelTableMgrObj.DisplaySelectedView(0,0);  // Display Initial View

                #endregion  // Create PanelTableMgr Object

                #region License Validation
                //--------------------------
                //--- License Validation ---
                //--------------------------
                bValidLicenseFile = ValidateLicense(); // Update Global Settings in Method - return valid flag
                #endregion  // License Validation

                #region Update Pinch Units Status Bar Label
                //-------------------------------------------
                //--- Update Pinch Units Status Bar Label ---
                //-------------------------------------------
                //PinchSettingsObj.PinchUnitsEnum = PinchTypes.PinchUnits.ENGLISH;
                PinchSettingsObj.PinchUnitsEnum = PinchTypes.PinchUnits.METRIC;
                UpdateUnitsStatusBarLabel();        // Update Pinch Units Status Bar Label
                #endregion      // Update Pinch Units Status Bar Label

                #region Update Input Validated Flag Status Bar Label
                //----------------------------------------------------
                //--- Update Input Validated Flag Status Bar Label ---
                //----------------------------------------------------
                //PinchSettingsObj.InputValidatedFlag = true;
                PinchSettingsObj.InputValidatedFlag = false;
                UpdateInputStatusBarLabel();        // Update Input Validated Status Bar Label
                #endregion  // Update Input Validated Flag Status Bar Label

                #region Update Targets Calculated Flag Status Bar Label
                //-------------------------------------------------------
                //--- Update Targets Calculated Flag Status Bar Label ---
                //-------------------------------------------------------
                //PinchSettingsObj.TargetsCalculatedFlag = true;
                PinchSettingsObj.TargetsCalculatedFlag = false;
                UpdateTargetsStatusBarLabel();      // Update Targets Calculated Status Bar Label
                #endregion  // Update Targets Calculated Flag Status Bar Label

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

        #region FormMain_Load
        private void FormMain_Load(object sender, EventArgs e)
        {
            string strMethod = "FormMain_Load";
            //-----------------------------
            //--- XML File Exists Guard ---
            //-----------------------------
            if (!PinchFileSysObj.LicenseFileExists())
            {
                string strMsg = String.Format("XML License File is Missing! [{0}]",
                                              PinchFileSysObj.LicenseFilePath);
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                PinchMsgDlg.DisplayErrorDlg(strMsg);

                HandleExit();
            }
            else if (PinchSettingsObj.LicenseStatusEnum != PinchTypes.LicenseStatus.VALID)
            {
                string strStatus = PinchSettingsObj.LicenseStatusEnum.ToString();
                string strMsg = String.Format("{0} License File Encountered!{1} Contact AJP Engineering!",
                                              strStatus, Environment.NewLine);
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                PinchMsgDlg.DisplayErrorDlg(strMsg);

                HandleExit();
            }
        }
        #endregion  // FormMain_Load

        #region public void Initialize Controls
        /// <summary>
        /// Set Initial State of Controls
        /// </summary>
        public void InitializeControls()
        {
            string strMethod = "InitializeControls";
            //PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Initializing Controls");

            int nPanelLocationX = 0;
            int nPanelLocationY = 61;
            int nPanelSizeX = 1264;
            int nPanelSizeY = 543;
            try
            {
                this.Text = "AJP Pinch 4";
                this.BackColor = PinchSettingsObj.AJP_ENGINEERING_GREEN; // Form Background Color

                //--- INPUT PANEL ---
                this.panelINPUT.Location = new System.Drawing.Point(nPanelLocationX, nPanelLocationY);
                this.panelINPUT.Size = new System.Drawing.Size(nPanelSizeX, nPanelSizeY);

                //--- TARGETS PANEL ---
                this.panelTARGETS.Location = new System.Drawing.Point(nPanelLocationX, nPanelLocationY);
                this.panelTARGETS.Size = new System.Drawing.Size(nPanelSizeX, nPanelSizeY);

                //--- HEN PANEL ---
                this.panelHEN.Location = new System.Drawing.Point(nPanelLocationX, nPanelLocationY);
                this.panelHEN.Size = new System.Drawing.Size(nPanelSizeX, nPanelSizeY);
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

        #region LICENSE METHODS

        #region ValidateLicense()
        /// <summary>
        /// Check if License is Valid. Assign Global Settings Flag
        /// </summary>
        /// <returns>true if License is VALID; otherwise false</returns>
        private bool ValidateLicense()
        {
            string strMethod = "ValidateLicense";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Validate Product License!");

            string strFullPathXmlFile = PinchFileSysObj.LicenseFilePath;
            LicenseFileData licenseFileXmlObj = new LicenseFileData();
            try
            {
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=  LICENSE FILE EXISTS GUARD  -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                #region LICENSE FILE EXISTS GUARD 
                //-----------------------------
                //--- XML File Exists Guard ---
                //-----------------------------
                if (!PinchFileSysObj.LicenseFileExists())
                {
                    //------------------------
                    //--- XML FILE MISSING ---
                    //------------------------
                    PinchSettingsObj.LicenseValidatedFlag = false;
                    PinchSettingsObj.LicenseStatusEnum = PinchTypes.LicenseStatus.INVALID;

                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, 
                                         String.Format("XML License File is Missing! [{0}]", 
                                                       strFullPathXmlFile));                    
                    return false;
                }
                #endregion  // LICENSE FILE EXISTS GUARD 

                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=  READ LICENSE FILE  -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                #region READ LICENSE FILE
                licenseFileXmlObj.RestoreLicenseXmlFile(strFullPathXmlFile);    // Get XML License File Data       
                #endregion  // READ LICENSE FILE

                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=  ASSIGN LICENSE TYPE ENUM VALUE IN SETTINGS OBJECT  -=-=-=-=-=-=-=-=-=-=-=-=-
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                #region ASSIGN LICENSE TYPE ENUM VALUE IN SETTINGS OBJECT
                //---------------------------------------------------------
                //--- Assign License Type Enum Value in Settings Object ---
                //---------------------------------------------------------
                switch (licenseFileXmlObj.LicenseType)
                {
                    case "TRIAL":
                        PinchSettingsObj.LicenseTypeEnum = PinchTypes.LicenseType.TRIAL;
                        break;
                    case "SITE":
                        PinchSettingsObj.LicenseTypeEnum = PinchTypes.LicenseType.SITE;
                        break;
                    case "DEVICE":
                        PinchSettingsObj.LicenseTypeEnum = PinchTypes.LicenseType.DEVICE;
                        break;
                    case "SEAT":
                        PinchSettingsObj.LicenseTypeEnum = PinchTypes.LicenseType.SEAT;
                        break;
                    case "USER":    // NOT SUPPORTED
                        //PinchSettingsObj.LicenseTypeEnum = PinchTypes.LicenseType.USER;
                        //break;
                    default:
                        PinchSettingsObj.LicenseTypeEnum = PinchTypes.LicenseType.UNKNOWN;
                        break;
                }
                #endregion  // ASSIGN LICENSE TYPE ENUM VALUE IN SETTINGS OBJECT

                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=  DISPLAY LICENSE SCORECARD  -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                #region DISPLAY LICENSE SCORECARD
                //------------------------------------------
                //--- Display The License ScoreCard Form ---
                //------------------------------------------
                DisplayLicenseScoreCardForm();      // Display The License ScoreCard Form
                #endregion  // DISPLAY LICENSE SCORECARD

                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=  UPDATE LICENSE STATUS BAR LABEL  -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                #region UPDATE LICENSE STATUS BAR LABEL
                //------------------------------------------------
                //--- Update License Status Bar Label Settings ---
                //------------------------------------------------
                UpdateLicenseStatusBarLabel();    // Update License Status Bar Label using Global Settings
                #endregion  // UPDATE LICENSE STATUS BAR LABEL

            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                LogLicenseStatus();               // Log License Status ... use Global Settings
            }
            return PinchSettingsObj.LicenseValidatedFlag;
        }
        #endregion  // ValidateLicense()

        #endregion  // LICENSE METHODS

        #region UPDATE STATUS BAR LABELS METHODS

        #region UpdateLicenseStatusBarLabel()
        /// <summary>
        /// Update the Status Bar Label for License using Global Settings
        /// </summary>
        private void UpdateLicenseStatusBarLabel()
        {
            string strMethod = "UpdateLicenseStatusBarLabel";
            string strLicenseType = String.Format("{0} LICENSE ", 
                                    PinchSettingsObj.LicenseTypeEnum.ToString());
            try
            {
                this.toolStripStatusLabelLicense.Text = strLicenseType;

                switch(PinchSettingsObj.LicenseStatusEnum)
                {
                    case PinchTypes.LicenseStatus.EXPIRED:
                    case PinchTypes.LicenseStatus.INVALID:
                        this.toolStripStatusLabelLicense.BackColor = Color.Red;
                        this.toolStripStatusLabelLicense.Image = Resources.InValid_32x32;
                        break;
                     case PinchTypes.LicenseStatus.UNKNOWN:
                        this.toolStripStatusLabelLicense.BackColor = Color.Orange;
                        this.toolStripStatusLabelLicense.Image = Resources.Unknown_32x32;
                        break;
                   case PinchTypes.LicenseStatus.VALID:
                        this.toolStripStatusLabelLicense.BackColor = Color.Green;
                        this.toolStripStatusLabelLicense.Image = Resources.Valid_32x32;
                        break;
                    default:
                        throw new Exception("INVALID Licesne Status Enum Value!");
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
        #endregion  // UpdateLicenseStatusBarLabel()

        #region UpdateUnitsStatusBarLabel()
        /// <summary>
        /// Update the Pinch Units Status Bar Label using Global Setting
        /// </summary>
        private void UpdateUnitsStatusBarLabel()
        {
            string strMethod = "UpdateUnitsStatusBarLabel";
            string strUnitsType = String.Format("{0} UNITS ",
                                    PinchSettingsObj.PinchUnitsEnum.ToString());
            try
            {
                this.toolStripStatusLabelUnits.Text = strUnitsType;

                switch (PinchSettingsObj.PinchUnitsEnum)
                {
                    case PinchTypes.PinchUnits.UNKNOWN:
                        this.toolStripStatusLabelUnits.BackColor = Color.Orange;
                        this.toolStripStatusLabelUnits.ForeColor = Color.White;
                        this.toolStripStatusLabelUnits.Image = Resources.Unknown_32x32;
                        break;
                    case PinchTypes.PinchUnits.ENGLISH:
                        this.toolStripStatusLabelUnits.BackColor = Color.Blue;
                        this.toolStripStatusLabelUnits.ForeColor = Color.White;
                        this.toolStripStatusLabelUnits.Image = Resources.English_Imperial_Units_32x32;
                        break;
                    case PinchTypes.PinchUnits.METRIC:
                        this.toolStripStatusLabelUnits.BackColor = Color.Blue;
                        this.toolStripStatusLabelUnits.ForeColor = Color.White;
                        this.toolStripStatusLabelUnits.Image = Resources.Metric_SI_Units_32x32;
                        break;
                    default:
                        throw new Exception("INVALID Pinch Units Enum Value!");
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
        #endregion  // UpdateUnitsStatusBarLabel()

        #region UpdateInputStatusBarLabel()
        /// <summary>
        /// Update the Input Validated Flag Status Bar Label using Global Setting
        /// </summary>
        private void UpdateInputStatusBarLabel()
        {
            string strMethod = "UpdateInputStatusBarLabel";
            bool bInputValidated = PinchSettingsObj.InputValidatedFlag;
            string strInputValidated = String.Empty;
            try
            {
                if(bInputValidated)
                {
                    strInputValidated = String.Format("INPUT VALIDATED ");
                    this.toolStripStatusLabelInput.Text = strInputValidated;

                    this.toolStripStatusLabelInput.BackColor = Color.Green;
                    this.toolStripStatusLabelInput.ForeColor = Color.White;
                    this.toolStripStatusLabelInput.Image = Resources.Valid_32x32;
                }
                else
                {
                    strInputValidated = String.Format("INPUT NOT VALIDATED ");
                    this.toolStripStatusLabelInput.Text = strInputValidated;

                    this.toolStripStatusLabelInput.BackColor = Color.Red;
                    this.toolStripStatusLabelInput.ForeColor = Color.White;
                    this.toolStripStatusLabelInput.Image = Resources.InValid_32x32;
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
        #endregion  // UpdateInputStatusBarLabel()

        #region UpdateTargetsStatusBarLabel()
        /// <summary>
        /// Update the Targets Calculated Flag Status Bar Label using Global Setting
        /// </summary>
        private void UpdateTargetsStatusBarLabel()
        {
            string strMethod = "UpdateTargetsStatusBarLabel";
            bool bTargetsCalculated = PinchSettingsObj.TargetsCalculatedFlag;
            string strTargetsCalculated = String.Empty;
            try
            {
                if (bTargetsCalculated)
                {
                    strTargetsCalculated = String.Format("TARGETS CALCULATED ");
                    this.toolStripStatusLabelTargets.Text = strTargetsCalculated;

                    this.toolStripStatusLabelTargets.BackColor = Color.Green;
                    this.toolStripStatusLabelTargets.ForeColor = Color.White;
                    this.toolStripStatusLabelTargets.Image = Resources.Valid_32x32;
                }
                else
                {
                    strTargetsCalculated = String.Format("TARGETS NOT CALCULATED ");
                    this.toolStripStatusLabelTargets.Text = strTargetsCalculated;

                    this.toolStripStatusLabelTargets.BackColor = Color.Red;
                    this.toolStripStatusLabelTargets.ForeColor = Color.White;
                    this.toolStripStatusLabelTargets.Image = Resources.InValid_32x32;
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
        #endregion  // UpdateTargetsStatusBarLabel()

        #endregion  // UPDATE STATUS BAR LABELS METHODS

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
            //PinchMsgDlg.DisplayWarningDlg("License Menu Item Selected!");
            DisplayLicenseForm();
        }
        #endregion      // LICENSE

        #region SCORECARD
        private void scorecardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayScoreCardForm();
        }
        #endregion  // SCORECARD

        #region ABOUT
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAboutForm();
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

        //---------------------------------------------------------------------

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

        #region TOOLBAR INPUT-STREAMS BUTTON EVENT
        private void toolStripButtonStreams_Click(object sender, EventArgs e)
        {
            string strMethod = "toolStripButtonStreams_Click";
            int nActivity = PanelTableMgr.INDEX_INPUT_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_INPUT_STREAMS_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("INPUT-STREAMS Toobar Button Pressed!");
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
        #endregion  // TOOLBAR INPUT-STREAMS BUTTON EVENT

        #region TOOLBAR INPUT-UTILITIES BUTTON EVENT
        private void toolStripButtonUtilities_Click(object sender, EventArgs e)
        {
            string strMethod = "toolStripButtonUtilities_Click";
            int nActivity = PanelTableMgr.INDEX_INPUT_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_INPUT_UTILITIES_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("INPUT-UTILITIES Toobar Button Pressed!");
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
        #endregion  // TOOLBAR INPUT-UTILITIES BUTTON EVENT

        #region TOOLBAR INPUT-COST BUTTON EVENT
        private void toolStripButtonCost_Click(object sender, EventArgs e)
        {
            string strMethod = "toolStripButtonCost_Click";
            int nActivity = PanelTableMgr.INDEX_INPUT_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_INPUT_COST_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("INPUT-COST Toobar Button Pressed!");
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
        #endregion  // TOOLBAR INPUT-COST BUTTON EVENT

        #region TOOLBAR INPUT-EXCHANGER BUTTON EVENT
        private void toolStripButtonExchanger_Click(object sender, EventArgs e)
        {
            string strMethod = "toolStripButtonExchanger_Click";
            int nActivity = PanelTableMgr.INDEX_INPUT_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_INPUT_EXCHANGER_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("INPUT-EXCHANGER Toobar Button Pressed!");
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
        #endregion  // TOOLBAR INPUT-EXCHANGER BUTTON EVENT

        #region TOOLBAR INPUT-VALIDATE BUTTON EVENT
        private void toolStripButtonValidate_Click(object sender, EventArgs e)
        {
            string strMethod = "toolStripButtonValidate_Click";
            int nActivity = PanelTableMgr.INDEX_INPUT_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_INPUT_VALIDATE_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("INPUT-VALIDATE Toobar Button Pressed!");
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
        #endregion  // TOOLBAR INPUT-VALIDATE BUTTON EVENT

        //---------------------------------------------------------------------

        #region TOOLBAR TARGETS-CALCULATE BUTTON EVENT
        private void toolStripButtonCalculate_Click(object sender, EventArgs e)
        {
            string strMethod = "toolStripButtonCalculate_Click";
            int nActivity = PanelTableMgr.INDEX_TARGETS_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_TARGETS_CALCULATE_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("TARGETS-CALCULATE Toobar Button Pressed!");
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
        #endregion  // TOOLBAR TARGETS-CALCULATE BUTTON EVENT

        #region TOOLBAR TARGETS-COMPOSITE BUTTON EVENT
        private void toolStripButtonComposite_Click(object sender, EventArgs e)
        {
            string strMethod = "toolStripButtonComposite_Click";
            int nActivity = PanelTableMgr.INDEX_TARGETS_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_TARGETS_COMPOSITE_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("TARGETS-COMPOSITE Toobar Button Pressed!");
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
        #endregion  // TOOLBAR TARGETS-COMPOSITE BUTTON EVENT

        #region TOOLBAR TARGETS-INTERVAL BUTTON EVENT
        private void toolStripButtonInterval_Click(object sender, EventArgs e)
        {
            string strMethod = "toolStripButtonInterval_Click";
            int nActivity = PanelTableMgr.INDEX_TARGETS_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_TARGETS_INTERVAL_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("TARGETS-INTERVAL Toobar Button Pressed!");
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
        #endregion  // TOOLBAR TARGETS-INTERVAL BUTTON EVENT

        #region TOOLBAR TARGETS-OPTIMIZE BUTTON EVENT
        private void toolStripButtonOptimize_Click(object sender, EventArgs e)
        {
            string strMethod = "toolStripButtonOptimize_Click";
            int nActivity = PanelTableMgr.INDEX_TARGETS_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_TARGETS_OPTIMIZE_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("TARGETS-OPTIMIZE Toobar Button Pressed!");
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
        #endregion  // TOOLBAR TARGETS-OPTIMIZE BUTTON EVENT

        //---------------------------------------------------------------------

        #region TOOLBAR HEN-DESIGN BUTTON EVENT
        private void toolStripButtonHenDesign_Click(object sender, EventArgs e)
        {
            string strMethod = "toolStripButtonHenDesign_Click";
            int nActivity = PanelTableMgr.INDEX_HEN_PANEL;
            int nSubActivity = PanelTableMgr.INDEX_HEN_DESIGN_PANEL;
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("HEN-DESIGN Toobar Button Pressed!");
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
        #endregion  // TOOLBAR HEN-DESIGN BUTTON EVENT

        //---------------------------------------------------------------------

        #region TOOLBAR LICENSE BUTTON EVENT
        private void toolStripButtonLicense_Click(object sender, EventArgs e)
        {
            //PinchMsgDlg.DisplayWarningDlg("License Toolbar Button Presses!");
            DisplayLicenseForm();
        }
        #endregion  // TOOLBAR LICENSE BUTTON EVENT

        #region TOOLBAR SCORECARD BUTTON EVENT
        private void toolStripButtonScoreCard_Click(object sender, EventArgs e)
        {
            DisplayScoreCardForm();
        }
        #endregion  // TOOLBAR SCORECARD BUTTON EVENT

        #region TOOLBAR ABOUT BUTTON EVENT
        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            DisplayAboutForm();
        }
        #endregion  // TOOLBAR ABOUT BUTTON EVENT

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

        #region PICTURE BOX EVENTS
        private void pictureBoxAJPLogo_DoubleClick(object sender, EventArgs e)
        {
            //PinchMsgDlg.DisplayWarningDlg("Handle Double Click on AJP Engineering Logo");
            DisplayBusinessCardForm();
        }
        #endregion  // PICTURE BOX EVENTS

        #endregion      // EVENT HANDLERS

        #region METHODS

        #region COMMON COMMAND HANDLERS

        #region DisplayLicenseScoreCardForm()
        /// <summary>
        /// Common Display License ScoreCardForm Handler
        /// </summary>
        private void DisplayLicenseScoreCardForm()
        {
            string strMethod = "DisplayLicenseScoreCardForm";
            //PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Display License ScoreCard Form");
            ScoreCardTableData tableData;
            try
            {
                tableData = LicenseMgrObj.GetScoreCardTableData(PinchFileSysObj.AppExecPath);

                if(tableData.NumInvalidProps > 0)
                {
                    PinchSettingsObj.LicenseStatusEnum = PinchTypes.LicenseStatus.INVALID;

                    FormScoreCard dlg = new FormScoreCard(tableData);
                    dlg.ShowDialog();
                }
                else if (tableData.DaysRemaining <= 0)
                {
                    PinchSettingsObj.LicenseStatusEnum = PinchTypes.LicenseStatus.EXPIRED;

                    FormScoreCard dlg = new FormScoreCard(tableData);
                    dlg.ShowDialog();
                }
                else
                {
                    PinchSettingsObj.LicenseStatusEnum = PinchTypes.LicenseStatus.VALID;
                }

                LogScoreCardTable(tableData);    // Log ScoreCard Table Data
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
        #endregion  // DisplayLicenseScoreCardForm()

        #region DisplayLicenseForm()
        /// <summary>
        /// Common Display License Form Handler
        /// </summary>
        private void DisplayLicenseForm()
        {
            string strMethod = "DisplayLicenseForm";
            //PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Display License Form");
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("Handle Common Display License Form Command!");
                FormLicenseFile dlg = new FormLicenseFile();
                dlg.ShowDialog();
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
        #endregion  // DisplayLicenseForm()

        #region DisplayScoreCardForm()
        /// <summary>
        /// Common Display License ScoreCard Form Handler
        /// </summary>
        private void DisplayScoreCardForm()
        {
            string strMethod = "DisplayScoreCardForm";
            //PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Display License Form");
            try
            {
                ScoreCardTableData tableData;
                try
                {
                    tableData = LicenseMgrObj.GetScoreCardTableData(PinchFileSysObj.AppExecPath);

                    if (tableData.NumInvalidProps > 0)
                    {
                        PinchSettingsObj.LicenseStatusEnum = PinchTypes.LicenseStatus.INVALID;
                    }
                    else if (tableData.DaysRemaining <= 0)
                    {
                        PinchSettingsObj.LicenseStatusEnum = PinchTypes.LicenseStatus.EXPIRED;
                    }
                    else
                    {
                        PinchSettingsObj.LicenseStatusEnum = PinchTypes.LicenseStatus.VALID;
                    }

                    FormScoreCard dlg = new FormScoreCard(tableData);
                    dlg.ShowDialog();

                    LogScoreCardTable(tableData);    // Log ScoreCard Table Data
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
        #endregion  // DisplayScoreCardForm()

        #region DisplayAboutForm()
        /// <summary>
        /// Common Display About Form Handler
        /// </summary>
        private void DisplayAboutForm()
        {
            string strMethod = "DisplayAboutForm";
            //PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Display About Form");
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("Handle Common Display About Form Command!");
                FormAboutPinch dlg = new FormAboutPinch();
                dlg.PinchTypesObj = this.PinchTypesObj;     // Assign Global Types and Properties
                dlg.ShowDialog();
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
        #endregion  // DisplayAboutForm()

        #region DisplayBusinessCardForm()
        /// <summary>
        /// Common Display About Form Handler
        /// </summary>
        private void DisplayBusinessCardForm()
        {
            string strMethod = "DisplayBusinessCardForm";
            //PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Display Business Card Form");
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("Handle Common Display Business Card Form Command!");
                FormBusinessCard dlg = new FormBusinessCard();
                dlg.ShowDialog();
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
        #endregion  // DisplayBusinessCardForm()

        #region HandleNew
        /// <summary>
        /// Common New Command Handler
        /// </summary>
        private void HandleNew()
        {
            string strMethod = "HandleNew";
            //PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "New Project");
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
            //PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Open Project");
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
            //PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Save Project");
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
            //PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Save Project");
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
            //PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Import Pinch Results");
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
            //PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Export Pinch Results");
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

        #region LogLicenseStatus()
        /// <summary>
        /// Log License Status using GLobal Settings
        /// </summary>
        private void LogLicenseStatus()
        {
            string strMethod = "LogLicenseStatus";
            string strMsg = String.Empty;
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ---------------------------------------");
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ------- License Type and Status -------");
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ---------------------------------------");
            try
            {
                strMsg = String.Format(" LICENSE VALIDATED FLAG: {0}",
                                       PinchSettingsObj.LicenseValidatedFlag);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = String.Format("           LICENSE Type: {0}",
                                       PinchSettingsObj.LicenseTypeEnum.ToString());
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = String.Format("         LICENSE Status: {0}",
                                       PinchSettingsObj.LicenseStatusEnum.ToString());
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ---------------------------------------");
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
        #endregion  // LogLicenseStatus()

        #region LogScoreCardTable()
        /// <summary>
        /// Log ScoreCard Table Data
        /// </summary>
        private void LogScoreCardTable(ScoreCardTableData tableData)
        {
            string strMethod = "LogScoreCardTable";
            string strMsg = String.Empty;
            try
            {
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ----------------------------------------------------------------------------");
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, " --------------------------- SCORECARD TABLE DATA ---------------------------");
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ----------------------------------------------------------------------------");
                strMsg = String.Format(" {0}  {1,-8}  {2,-22}  {3}", "ID", "STATE", "NAME", "VALUE");
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ----------------------------------------------------------------------------");

                foreach (ScoreCardRowData row in tableData.ScoreCardListObj)
                {
                    strMsg = String.Format(" {0}  {1,-8}  {2,-22}  {3}",
                                           row.PropertyID,
                                           row.PropertyState,
                                           row.PropertyName,
                                           row.PropertyValue);
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ----------------------------------------------------------------------------");
                strMsg = String.Format("     Num INVALID:{0}   Num VALID:{1}   TOTAL:{2}   STATUS:{3}",
                                       tableData.NumInvalidProps.ToString(),
                                       tableData.NumValidProps.ToString(),
                                       tableData.NumProperties.ToString(),
                                       tableData.ValidationState);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = String.Format("     Days Remaining on License:{0} days  ... [ Current Date: {1} ]", 
                                       tableData.DaysRemaining.ToString(),
                                       DateTime.Now.ToShortDateString());
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ----------------------------------------------------------------------------");

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
        #endregion      // LogScoreCardTable()

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
