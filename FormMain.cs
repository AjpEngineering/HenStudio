#region HEADER
//#####################################################################################################################
//#############################################  F o r m M a i n . c s  ###############################################
//#####################################################################################################################
//  FILENAME:  FormMain.cs
//  NAMESPACE: HenStudio
//  CLASS(S):  FormMain
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Main HEN Studio Form.
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
using AJP_License_File;

using HenGlobal;

using HenStudio.Properties;

using System;
using System.Drawing;
using System.Windows.Forms;

#endregion  // REFERENCES

#region namespace HenStudio
namespace HenStudio
{
    #region public partial class FormMain
    /// <summary>
    /// HEN Studio Main Form Class
    /// </summary>
    public partial class FormMain : Form
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio";
        const string CLASS = "FormMain";

        const string LICENSE_TYPE_UNKNOWN = "UNKNOWN";
        const string LICENSE_TYPE_TRIAL= "TRIAL";
        const string LICENSE_TYPE_SITE = "SITE";
        const string LICENSE_TYPE_DEVICE = "DEVICE";
        const string LICENSE_TYPE_USER = "USER";
        const string LICENSE_TYPE_SEAT = "SEAT";

        const string PINCH_UNITS_ENGLISH = "English";
        const string PINCH_UNITS_METRIC = "Metric";

        const string STREAM_TYPE_HOT = "HOT";
        const string STREAM_TYPE_COLD = "COLD";
        const string STREAM_TYPE_NA = "NA";

        const string STREAM_PHASE_LIQUID = "LIQUID";
        const string STREAM_PHASE_TWO_PHASE = "TWO-PHASE";
        const string STREAM_PHASE_VAPOR = "VAPOR";
        const string STREAM_PHASE_LNA = "NA";
        #endregion      // CONSTANTS

        #region FIELDS

        #region PUBLIC COLORS AND FONTS
        //---------------------------------------------------------------------------------------------- AJP COLORS ---
        public Color AJP_ENGINEERING_GREEN = Color.FromArgb(255, 0, 204, 153);   // Caribbean Green
        public Color AJP_ENGINEERING_ORANGE = Color.FromArgb(255, 255, 153, 0);  // Vivid Gamboge
        public Color AJP_PINCH_RED_ORANGE = Color.FromArgb(255, 255, 83, 73);    // Red-Orange
        public Color AJP_PINCH_SKY_BLUE = Color.FromArgb(255, 0, 191, 255);      // Deep Sky Blue
        //----------------------------------------------------------------------------------------------- AJP FONTS ---
        public Font AJP_PINCH_DISPLAY_FONT = new Font("Segoe UI Variable Display", 10.0f); // Display
        public Font AJP_PINCH_MONO_FONT = new Font("Cascadia Mono", 9.0f);              // Monospace for Numbers
        #endregion  // PUBLIC COLORS AND FONTS

        #region PRIVATE COLORS
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
        #endregion  // PRIVATE COLORS

        #endregion      // FIELDS

        #region PROPERTIES
        //------------------------------------------------------------------------------------------- STREAM COLORS ---
        public Color ColorBackgroundHotStream { get; set; }        // Hot  Stream Background Color
        public Color ColorBackgroundColdStream { get; set; }       // Cold Stream Background Color
        public Color ColorBackgroundNA_Stream { get; set; }        // NA   Stream Background Color
        public Color ColorTextHotStream { get; set; }              // Hot  Stream Text Color
        public Color ColorTextColdStream { get; set; }             // Cold Stream Text Color
        public Color ColorTextNA_Stream { get; set; }              // NA   Stream Text Color
        //------------------------------------------------------------------------------------------------ SETTINGS ---
        public bool LicenseVerified { get; set; }                  // License Verified FLAG
        public bool InputVerifiedFlag { get; set; }                // INPUT Verified FLAG
        public bool PinchEnglishUnitsFlag { get; set; }            // UNITS FLAG
        //----------------------------------------------------------------------------------------- LICENSE OBJECTS ---
        public LicenseMgr LicenseMgrObj { get; set; }              // License Manager Object
        //------------------------------------------------------------------------------------------ GLOBAL OBJECTS ---
        public HenFileSystem HenFileSysObj { get; set; }           // HEN Studio File System Object
        public HenSettings HenSettingsObj { get; set; }            // HEN Studio Settings Object
        public HenTypes HenTypesObj { get; set; }                  // HEN Studio Types Object
        public HenMethods HenMethodsObj { get; set; }              // HEN Studio Methods Object
        public PanelTableMgr PanelTableMgrObj { get; set; }        // Panel Table Manager Object
        //-------------------------------------------------------------------------------------------- DATA OBJECTS ---
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
            HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating Object");
            bool bValidLicenseFile = false;
            try
            {
                InitializeComponent();

                #region INITIALIZE PROPERTIES
                this.Text = "AJP HEN Studio";      // Form Title
                //-------------------------------------------- STREAM BACKGROUND COLORS ---
                ColorBackgroundHotStream = Color.LightCoral;
                ColorBackgroundColdStream = Color.LightBlue;
                ColorBackgroundNA_Stream = Color.WhiteSmoke;
                //-------------------------------------------------- STREAM TEXT COLORS ---
                ColorTextHotStream = Color.Black;
                ColorTextColdStream = Color.Black;
                ColorTextNA_Stream = Color.Black;
                //----------------------
                //--- Create Objects ---
                //----------------------
                HenFileSysObj = new HenFileSystem();
                HenSettingsObj = new HenSettings();
                HenTypesObj = new HenTypes();
                HenMethodsObj = new HenMethods(HenSettingsObj);

                LicenseMgrObj = new LicenseMgr(HenFileSysObj.LicenseFilePath);
                //------------------------------------------
                //--- Initialize License Global Settings ---
                //------------------------------------------
                HenSettingsObj.LicenseValidatedFlag = false;
                HenSettingsObj.LicenseTypeEnum = HenTypes.LicenseType.UNKNOWN;
                HenSettingsObj.LicenseStatusEnum = HenTypes.LicenseStatus.UNKNOWN;

                HenSettingsObj.InputValidatedFlag = false;
                HenSettingsObj.TargetsCalculatedFlag = false;
                //---------------------------------------
                //--- Initialize Units Global Setting ---
                //---------------------------------------
                PinchEnglishUnitsFlag = true;
                #endregion  // INITIALIZE PROPERTIES

                //---------------------------
                //--- Initialize Controls ---
                //---------------------------
                InitializeControls();       // Set Inital State of the Form Controls
                
                #region Create PanelTableMgr Object
                //-----------------------------------
                //--- Create PanelTableMgr Object ---
                //-----------------------------------
                PanelTableMgrObj = new PanelTableMgr(HenTypesObj, HenSettingsObj);
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
                //HenSettingsObj.PinchUnitsEnum = HenTypes.PinchUnits.ENGLISH;
                HenSettingsObj.PinchUnitsEnum = HenTypes.PinchUnits.METRIC;
                UpdateUnitsStatusBarLabel();        // Update Pinch Units Status Bar Label
                #endregion      // Update Pinch Units Status Bar Label

                #region Update Input Validated Flag Status Bar Label
                //----------------------------------------------------
                //--- Update Input Validated Flag Status Bar Label ---
                //----------------------------------------------------
                //HenSettingsObj.InputValidatedFlag = true;
                HenSettingsObj.InputValidatedFlag = false;
                UpdateInputStatusBarLabel();        // Update Input Validated Status Bar Label
                #endregion  // Update Input Validated Flag Status Bar Label

                #region Update Targets Calculated Flag Status Bar Label
                //-------------------------------------------------------
                //--- Update Targets Calculated Flag Status Bar Label ---
                //-------------------------------------------------------
                //HenSettingsObj.TargetsCalculatedFlag = true;
                HenSettingsObj.TargetsCalculatedFlag = false;
                UpdateTargetsStatusBarLabel();      // Update Targets Calculated Status Bar Label
                #endregion  // Update Targets Calculated Flag Status Bar Label

            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion      // CTOR

        #region FormMain_Load
        private void FormMain_Load(object sender, EventArgs e)
        {
            string strMethod = "FormMain_Load";
            string strMsg = string.Empty;
            HenLogger.WriteSeparatorLine(' ');
            HenLogger.WriteSection("START OBJECT TREE CONSTRUCTION");
            HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Load Main Form - Create Object Tree");
            try
            {
                #region VALID XML File Exists Guard - EXIT ON ERROR
                //-----------------------------
                //--- XML File Exists Guard ---
                //-----------------------------
                if (!HenFileSysObj.LicenseFileExists())
                {
                    strMsg = String.Format("XML License File is Missing! [{0}]",
                                            HenFileSysObj.LicenseFilePath);
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                    HenMsgDlg.DisplayErrorDlg(strMsg);

                    HandleExit();
                }
                else if (HenSettingsObj.LicenseStatusEnum != HenTypes.LicenseStatus.VALID)
                {
                    string strStatus = HenSettingsObj.LicenseStatusEnum.ToString();
                    strMsg = String.Format("{0} License File Encountered!{1} Contact AJP Engineering!",
                                            strStatus, Environment.NewLine);
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                    HenMsgDlg.DisplayErrorDlg(strMsg);

                    HandleExit();
                }
                #endregion  // VALID XML File Exists Guard - EXIT ON ERROR

                #region CONSTRUCT INITIAL OBJECT TREE
                //***** TBD
                #endregion  // CONSTRUCT INITIAL OBJECT TREE

                //--- TEST ---
                HenMethodsObj.TestUnitConversions();

            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                HenLogger.WriteSection("END OBJECT TREE CONSTRUCTION");
                HenLogger.WriteSeparatorLine(' ');

                PanelTableMgrObj.LogCurrentState(); // Log the current index state of the Panel Table Manager

                HenLogger.WriteSection("END CONSTRUCTION SECTION");
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
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Initializing Controls");

            int nPanelLocationX = 0;
            int nPanelLocationY = 61;
            int nPanelSizeX = 1264;
            int nPanelSizeY = 543;
            try
            {
                this.Text = "AJP Pinch 4";
                this.BackColor = AJP_ENGINEERING_GREEN; // Form Background Color

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
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
            HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Validate Product License!");

            string strFullPathXmlFile = HenFileSysObj.LicenseFilePath;
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
                if (!HenFileSysObj.LicenseFileExists())
                {
                    //------------------------
                    //--- XML FILE MISSING ---
                    //------------------------
                    HenSettingsObj.LicenseValidatedFlag = false;
                    HenSettingsObj.LicenseStatusEnum = HenTypes.LicenseStatus.INVALID;

                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, 
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
                        HenSettingsObj.LicenseTypeEnum = HenTypes.LicenseType.TRIAL;
                        break;
                    case "SITE":
                        HenSettingsObj.LicenseTypeEnum = HenTypes.LicenseType.SITE;
                        break;
                    case "DEVICE":
                        HenSettingsObj.LicenseTypeEnum = HenTypes.LicenseType.DEVICE;
                        break;
                    case "SEAT":
                        HenSettingsObj.LicenseTypeEnum = HenTypes.LicenseType.SEAT;
                        break;
                    case "USER":    // NOT SUPPORTED
                        //HenSettingsObj.LicenseTypeEnum = HenTypes.LicenseType.USER;
                        //break;
                    default:
                        HenSettingsObj.LicenseTypeEnum = HenTypes.LicenseType.UNKNOWN;
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
                DisplayScoreCardForm(true);         // Display The License ScoreCard Form
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
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                LogLicenseStatus();               // Log License Status ... use Global Settings
            }
            return HenSettingsObj.LicenseValidatedFlag;
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
                                    HenSettingsObj.LicenseTypeEnum.ToString());
            try
            {
                this.toolStripStatusLabelLicense.Text = strLicenseType;

                switch(HenSettingsObj.LicenseStatusEnum)
                {
                    case HenTypes.LicenseStatus.EXPIRED:
                    case HenTypes.LicenseStatus.INVALID:
                        this.toolStripStatusLabelLicense.BackColor = Color.Red;
                        this.toolStripStatusLabelLicense.Image = Resources.InValid_32x32;
                        break;
                     case HenTypes.LicenseStatus.UNKNOWN:
                        this.toolStripStatusLabelLicense.BackColor = Color.Orange;
                        this.toolStripStatusLabelLicense.Image = Resources.Unknown_32x32;
                        break;
                   case HenTypes.LicenseStatus.VALID:
                        this.toolStripStatusLabelLicense.BackColor = Color.Green;
                        this.toolStripStatusLabelLicense.Image = Resources.Valid_32x32;
                        break;
                    default:
                        throw new Exception("INVALID Licesne Status Enum Value!");
                }
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                                    HenSettingsObj.PinchUnitsEnum.ToString());
            try
            {
                this.toolStripStatusLabelUnits.Text = strUnitsType;

                switch (HenSettingsObj.PinchUnitsEnum)
                {
                    case HenTypes.PinchUnits.UNKNOWN:
                        this.toolStripStatusLabelUnits.BackColor = Color.Orange;
                        this.toolStripStatusLabelUnits.ForeColor = Color.White;
                        this.toolStripStatusLabelUnits.Image = Resources.Unknown_32x32;
                        break;
                    case HenTypes.PinchUnits.ENGLISH:
                        this.toolStripStatusLabelUnits.BackColor = Color.Blue;
                        this.toolStripStatusLabelUnits.ForeColor = Color.White;
                        this.toolStripStatusLabelUnits.Image = Resources.English_Imperial_Units_32x32;
                        break;
                    case HenTypes.PinchUnits.METRIC:
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
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
            bool bInputValidated = HenSettingsObj.InputValidatedFlag;
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
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
            bool bTargetsCalculated = HenSettingsObj.TargetsCalculatedFlag;
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
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
            HenMsgDlg.DisplayWarningDlg("New Menu Item Selected!");
        }
        #endregion  // NEW MENU ITEM HANDLER

        #region OPEN MENU ITEM HANDLER
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HenMsgDlg.DisplayWarningDlg("Open Menu Item Selected!");
        }
        #endregion  // OPEN MENU ITEM HANDLER

        #region SAVE MENU ITEM HANDLER
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //HenMsgDlg.DisplayWarningDlg("Save Menu Item Selected!");
            HandleSave();
        }
        #endregion  // SAVE MENU ITEM HANDLER

        #region SAVE AS MENU ITEM HANDLER
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //HenMsgDlg.DisplayWarningDlg("Save As Menu Item Selected!");
            HandleSaveAs();
        }
        #endregion  // SAVE AS MENU ITEM HANDLER

        #region IMPORT MENU ITEM HANDLER
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //HenMsgDlg.DisplayWarningDlg("Import Menu Item Selected!");
            HandleImport();
        }
        #endregion  // IMPORT MENU ITEM HANDLER

        #region EXPORT MENU ITEM HANDLER
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //HenMsgDlg.DisplayWarningDlg("Export Menu Item Selected!");
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
                //HenMsgDlg.DisplayWarningDlg("Specify Input Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("Calculate Targets Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("Design Heat Exchanger Network Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);

            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("INPUT-PROJECT Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("INPUT-STREAMS Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("INPUT-UTILITIES Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("INPUT-COST Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("INPUT-EXCHANGER Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("INPUT-VALIDATE Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("TARGETS-CALCULATE Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("TARGETS-COMPOSITE Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("TARGETS-INTERVAL Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("TARGETS-OPTIMIZE Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("HEN-DESIGN Menu Item Selected!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
            //HenMsgDlg.DisplayWarningDlg("License Menu Item Selected!");
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
            //HenMsgDlg.DisplayWarningDlg("New Toobar Button Pressed!");
            HandleNew();
        }
        #endregion  // TOOLBAR NEW BUTTON EVENT

        #region TOOLBAR OPEN BUTTON EVENT
        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            //HenMsgDlg.DisplayWarningDlg("Open Toobar Button Pressed!");
            HandleOpen();
        }
        #endregion  // TOOLBAR OPEN BUTTON EVENT

        #region TOOLBAR SAVE BUTTON EVENT
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            //HenMsgDlg.DisplayWarningDlg("Save Toobar Button Pressed!");
            HandleSave();
        }
        #endregion  // TOOLBAR SAVE BUTTON EVENT

        #region TOOLBAR SAVE AS BUTTON EVENT
        private void toolStripButtonSaveAs_Click(object sender, EventArgs e)
        {
            //HenMsgDlg.DisplayWarningDlg("Save As Toobar Button Pressed!");
            HandleSaveAs();
        }
        #endregion      // TOOLBAR SAVE AS BUTTON EVENT

        #region TOOLBAR IMPORT BUTTON EVENT
        private void toolStripButtonImport_Click(object sender, EventArgs e)
        {
            //HenMsgDlg.DisplayWarningDlg("Import Toobar Button Pressed!");
            HandleImport();
        }
        #endregion  // TOOLBAR IMPORT BUTTON EVENT

        #region TOOLBAR EXPORT BUTTON EVENT
        private void toolStripButtonExport_Click(object sender, EventArgs e)
        {
            //HenMsgDlg.DisplayWarningDlg("Export Toobar Button Pressed!");
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
                //HenMsgDlg.DisplayWarningDlg("INPUT-PROJECT Toobar Button Pressed!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("INPUT-STREAMS Toobar Button Pressed!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("INPUT-UTILITIES Toobar Button Pressed!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("INPUT-COST Toobar Button Pressed!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("INPUT-EXCHANGER Toobar Button Pressed!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("INPUT-VALIDATE Toobar Button Pressed!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("TARGETS-CALCULATE Toobar Button Pressed!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("TARGETS-COMPOSITE Toobar Button Pressed!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("TARGETS-INTERVAL Toobar Button Pressed!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("TARGETS-OPTIMIZE Toobar Button Pressed!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("HEN-DESIGN Toobar Button Pressed!");
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
            //HenMsgDlg.DisplayWarningDlg("License Toolbar Button Presses!");
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
                //HenMsgDlg.DisplayWarningDlg("MAIN ANALYSIS Tab Control Index Selected Changed!");
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
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("INPUT Tab Control Index Selected Changed!");
                nActivity = PanelTableMgr.INDEX_INPUT_PANEL;
                nSubActivity = this.tabControlINPUT.SelectedIndex; ;
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("TARGETS Tab Control Index Selected Changed!");
                nActivity = PanelTableMgr.INDEX_TARGETS_PANEL;
                nSubActivity = this.tabControlTARGETS.SelectedIndex; ;
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("HEN Tab Control Index Selected Changed!");
                nActivity = PanelTableMgr.INDEX_HEN_PANEL;
                nSubActivity = this.tabControlHEN.SelectedIndex; ;
                HandleViewCommand(nActivity, nSubActivity);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }

        #endregion  // HEN TAB CONTROL

        #endregion  // TAB CONTROL EVENTS

        #region PICTURE BOX EVENTS
        private void pictureBoxAJPLogo_Click(object sender, EventArgs e)
        {
            DisplayBusinessCardForm();
        }
        #endregion  // PICTURE BOX EVENTS

        #endregion      // EVENT HANDLERS

        #region USER LICENSE AGREEMENT EVENTS

        #region MENU BAR EVENT
        private void userLicenseAgreementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUserLicenseAgreementForm();
        }
        #endregion  // MENU BAR EVENT

        #region TOOLBAR EVENT
        private void toolStripButtonUserLicenseAgreement_Click(object sender, EventArgs e)
        {
            DisplayUserLicenseAgreementForm();
        }
        #endregion  // TOOLBAR EVENT

        #endregion  // USER LICENSE AGREEMENT EVENTS

        #region METHODS

        #region COMMON COMMAND HANDLERS

        #region DisplayLicenseForm()
        /// <summary>
        /// Common Display License Form Handler
        /// </summary>
        private void DisplayLicenseForm()
        {
            string strMethod = "DisplayLicenseForm";
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Display License Form");
            try
            {
                //HenMsgDlg.DisplayWarningDlg("Handle Common Display License Form Command!");
                FormLicenseFile dlg = new FormLicenseFile();
                dlg.ShowDialog();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
        /// <param name="bOnLaunch">On Launch Flag; true when method called on Constructor sequesce; otherwise false</param>
        private void DisplayScoreCardForm(bool bOnLaunch=false)
        {
            string strMethod = "DisplayScoreCardForm";
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Display License Form");
            try
            {
                ScoreCardTableData tableData;
                try
                {
                    #region GET LICENSE STATUS
                    tableData = LicenseMgrObj.GetScoreCardTableData(HenFileSysObj.AppExeFolderPath);

                    if (tableData.NumInvalidProps > 0)
                    {
                        HenSettingsObj.LicenseStatusEnum = HenTypes.LicenseStatus.INVALID;
                    }
                    else if (tableData.DaysRemaining <= 0)
                    {
                        HenSettingsObj.LicenseStatusEnum = HenTypes.LicenseStatus.EXPIRED;
                    }
                    else
                    {
                        HenSettingsObj.LicenseStatusEnum = HenTypes.LicenseStatus.VALID;
                    }

                    #endregion  // GET LICENSE STATUS

                    if ((bOnLaunch) && (HenSettingsObj.LicenseStatusEnum != HenTypes.LicenseStatus.VALID))
                    {
                        //--------------------------------------------
                        //--- [ON LAUNCH AND NOT A VALID LICENSE:] ---
                        //--- Show ScardCard and EXIT Application  ---
                        //--------------------------------------------
                        FormScoreCard dlg = new FormScoreCard(tableData);
                        dlg.ShowDialog();
                        Application.Exit();
                    }
                    else if(!bOnLaunch)
                    {
                        //----------------------------------------------------
                        //--- [NOT ON LAUNCH - i.e., from Menu or Toolbar] ---
                        //--- Show ScoreCard - DO NOT EXIT Application     ---
                        //----------------------------------------------------
                        FormScoreCard dlg = new FormScoreCard(tableData);
                        dlg.ShowDialog();
                    }

                    //----------------------------------------
                    //--- Log ScoreCard Data and Continue  ---
                    //----------------------------------------
                    LogScoreCardTable(tableData);    // Log ScoreCard Table Data
                }
                catch (Exception ex)
                {
                    HenLogger.WriteSeparatorLine('*');
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                    HenLogger.WriteSeparatorLine('*');
                }
                finally
                {
                }
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // DisplayScoreCardForm()

        #region DisplayUserLicenseAgreementForm()
        /// <summary>
        /// Common Display About Form Handler
        /// </summary>
        private void DisplayUserLicenseAgreementForm()
        {
            string strMethod = "DisplayUserLicenseAgreementForm";
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Display User License Agreement Form");
            try
            {
                FormUserLicenseAgreement dlg = new FormUserLicenseAgreement();
                dlg.ShowDialog();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // DisplayUserLicenseAgreementForm()

        #region DisplayAboutForm()
        /// <summary>
        /// Common Display About Form Handler
        /// </summary>
        private void DisplayAboutForm()
        {
            string strMethod = "DisplayAboutForm";
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Display About Form");
            try
            {
                //HenMsgDlg.DisplayWarningDlg("Handle Common Display About Form Command!");
                FormAboutPinch dlg = new FormAboutPinch();
                dlg.HenTypesObj = this.HenTypesObj;     // Assign Global Types and Properties
                dlg.ShowDialog();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Display Business Card Form");
            try
            {
                //HenMsgDlg.DisplayWarningDlg("Handle Common Display Business Card Form Command!");
                FormBusinessCard dlg = new FormBusinessCard();
                dlg.ShowDialog();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "New Project");
            try
            {
                HenMsgDlg.DisplayWarningDlg("Handle NEW Command!");
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Open Project");
            try
            {
                HenMsgDlg.DisplayWarningDlg("Handle OPEN Command!");
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Save Project");
            try
            {
                HenMsgDlg.DisplayWarningDlg("Handle SAVE Command!");
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Save Project");
            try
            {
                HenMsgDlg.DisplayWarningDlg("Handle SAVE AS Command!");
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Import Pinch Results");
            try
            {
                HenMsgDlg.DisplayWarningDlg("Handle IMPORT Command!");
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Export Pinch Results");
            try
            {
                HenMsgDlg.DisplayWarningDlg("Handle EXPORT Command!");
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
            HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Exiting Pinch Application");
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                //HenMsgDlg.DisplayWarningDlg("Handle View Command!");
                row = PanelTableMgrObj.DisplaySelectedView(nActivity, nSubActivity);
                if (row == null) throw (new Exception("Handle View Command: Null View"));
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
            HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ---------------------------------------");
            HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ------- License Type and Status -------");
            HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ---------------------------------------");
            try
            {
                strMsg = String.Format(" LICENSE VALIDATED FLAG: {0}",
                                       HenSettingsObj.LicenseValidatedFlag);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = String.Format("           LICENSE Type: {0}",
                                       HenSettingsObj.LicenseTypeEnum.ToString());
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = String.Format("         LICENSE Status: {0}",
                                       HenSettingsObj.LicenseStatusEnum.ToString());
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ---------------------------------------");
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ----------------------------------------------------------------------------");
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " --------------------------- SCORECARD TABLE DATA ---------------------------");
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ----------------------------------------------------------------------------");
                strMsg = String.Format(" {0}  {1,-8}  {2,-22}  {3}", "ID", "STATE", "NAME", "VALUE");
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ----------------------------------------------------------------------------");

                foreach (ScoreCardRowData row in tableData.ScoreCardListObj)
                {
                    strMsg = String.Format(" {0}  {1,-8}  {2,-22}  {3}",
                                           row.PropertyID,
                                           row.PropertyState,
                                           row.PropertyName,
                                           row.PropertyValue);
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ----------------------------------------------------------------------------");
                strMsg = String.Format("     Num INVALID:{0}   Num VALID:{1}   TOTAL:{2}   STATUS:{3}",
                                       tableData.NumInvalidProps.ToString(),
                                       tableData.NumValidProps.ToString(),
                                       tableData.NumProperties.ToString(),
                                       tableData.ValidationState);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = String.Format("     Days Remaining on License:{0} days  ... [ Current Date: {1} ]", 
                                       tableData.DaysRemaining.ToString(),
                                       DateTime.Now.ToShortDateString());
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ----------------------------------------------------------------------------");

            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
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
#endregion      // namespace HenStudio
//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
