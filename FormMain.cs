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
//---------------------------------------------------------------------------------------------------------------------
//                      PRESENTATION LAYER ->       BUSINESS LAYER            ->       DATA LAYER
//                       UI -> ViewModels  -> Domain -> Repository Interfaces -> Persistence -> Database
//---------------------------------------------------------------------------------------------------------------------
//    The HenStudio Component (Assembly) is part of the Presentation Layer of the Software Architecture.
//    This Layer includes the WinForms UI (Forms, Controls, Grids, etc.) AND
//    the ViewModel layer (BindingLists, commands [e.g., Unit Conversion - To/From External-Internal Units], etc.).
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

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

using static HenGlobal.HenTypes;

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

        #region PROPERTIES
        
        #region AJP COLORS & FONTS
        //---------------------------------------------------------------------------------------------- AJP COLORS ---
        public Color AJP_ENGINEERING_GREEN { get; set; }      // Caribbean Green
        public Color AJP_ENGINEERING_ORANGE { get; set; }     // Vivid Gamboge
        public Color AJP_HEN_STUDIO_RED_ORANGE { get; set; }  // Red-Orange
        public Color AJP_HEN_STUDIO_SKY_BLUE { get; set; }    // Deep Sky Blue
        //----------------------------------------------------------------------------------------------- AJP FONTS ---
        public Font AJP_HEN_STUDIO_DISPLAY_FONT { get; set; } // Display
        public Font AJP_HEN_STUDIO_MONO_FONT { get; set; }    // Monospace for Numbers
        #endregion  // AJP COLORS & FONTS

        #region PANELS COLORS
        //-------------------------------------------------------------------------------------------- PANEL COLORS ---
        public Color ColorPanelBlueBackground { get; set; }    // Blue Panel Background Color
        public Color ColorPanelBlueOutline { get; set; }       // Blue Panel Outline Color
        public Color ColorPanelGreenBackground { get; set; }   // Green Panel Background Color
        public Color ColorPanelGreenOutline { get; set; }      // Green Panel Outline Color
        public Color ColorPanelOrangeBackground { get; set; }  // Orange Panel Background Color
        public Color ColorPanelOrangeOutline { get; set; }     // Orange Panel Outline Color
        public Color ColorPanelRedBackground { get; set; }     // Red Panel Background Color
        public Color ColorPanelRedOutline { get; set; }        // Red Panel Outline Color
        #endregion  // PANELS COLORS

        #region STREAM COLORS
        //------------------------------------------------------------------------------------------- STREAM COLORS ---
        public Color ColorBackgroundHotStream { get; set; }        // Hot  Stream Background Color
        public Color ColorBackgroundColdStream { get; set; }       // Cold Stream Background Color
        public Color ColorBackgroundNA_Stream { get; set; }        // NA   Stream Background Color
        public Color ColorTextHotStream { get; set; }              // Hot  Stream Text Color
        public Color ColorTextColdStream { get; set; }             // Cold Stream Text Color
        public Color ColorTextNA_Stream { get; set; }              // NA   Stream Text Color
        #endregion  // STREAM COLORS

        #region SETTINGS
        //------------------------------------------------------------------------------------------------ SETTINGS ---
        public bool DbConnectedFlag { get; set; }                  // DB Connected FLAG
        public bool HenStudioEnglishUnitsFlag { get; set; }        // Global External UNITS FLAG
        //----------------------------------------------------------------------------------------- LICENSE OBJECTS ---
        public LicenseMgr LicenseMgrObj { get; set; }              // License Manager Object
        //------------------------------------------------------------------------------------------ GLOBAL OBJECTS ---
        public HenFileSystem HenFileSysObj { get; set; }           // HEN Studio File System Object
        public HenSettings HenSettingsObj { get; set; }            // HEN Studio Settings Object
        public HenTypes HenTypesObj { get; set; }                  // HEN Studio Types Object
        public HenMethods HenMethodsObj { get; set; }              // HEN Studio Methods Object
        #endregion  // SETTINGS

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

                this.Text = "AJP HEN Studio";      // Form Title

                #region INITIALIZE PROPERTIES

                #region GLOBAL OBJECTS
                //-----------------------------
                //--- Create Global Objects ---
                //-----------------------------
                HenFileSysObj = new HenFileSystem();
                HenSettingsObj = new HenSettings();
                HenTypesObj = new HenTypes();
                HenMethodsObj = new HenMethods(HenSettingsObj);
                #endregion  // GLOBAL OBJECTS

                #region AJP COLORS & FONTS
                AJP_ENGINEERING_GREEN = Color.FromArgb(255, 0, 204, 153);      // Caribbean Green
                AJP_ENGINEERING_ORANGE = Color.FromArgb(255, 255, 153, 0);     // Vivid Gamboge
                AJP_HEN_STUDIO_RED_ORANGE = Color.FromArgb(255, 255, 153, 0);  // Red-Orange
                AJP_HEN_STUDIO_SKY_BLUE = Color.FromArgb(255, 0, 191, 255);    // Deep Sky Blue

                AJP_HEN_STUDIO_DISPLAY_FONT = new Font("Segoe UI Variable Display", 10.0f); // Display
                AJP_HEN_STUDIO_MONO_FONT = new Font("Cascadia Mono", 9.0f);                 // Monospace for Numbers
                #endregion  // AJP COLORS & FONTS

                #region PANEL COLORS
                ColorPanelBlueBackground = Color.FromArgb(255, 150, 255, 255);
                ColorPanelBlueOutline = Color.FromArgb(255, 0, 0, 255);

                ColorPanelGreenBackground = Color.Honeydew;
                ColorPanelGreenOutline = Color.Green;

                ColorPanelOrangeBackground = Color.FromArgb(255, 255, 224, 192);
                ColorPanelOrangeOutline = Color.FromArgb(255, 242, 99, 48);

                ColorPanelRedBackground = Color.FromArgb(255, 255, 200, 200);
                ColorPanelRedOutline = Color.FromArgb(255, 255, 0, 0);
                #endregion  // PANEL COLORS

                #region STREAM COLORS
                //-------------------------------------------- STREAM BACKGROUND COLORS ---
                ColorBackgroundHotStream = Color.LightCoral;
                ColorBackgroundColdStream = Color.LightBlue;
                ColorBackgroundNA_Stream = Color.WhiteSmoke;
                //-------------------------------------------------- STREAM TEXT COLORS ---
                ColorTextHotStream = Color.Black;
                ColorTextColdStream = Color.Black;
                ColorTextNA_Stream = Color.Black;
                #endregion  // STREAM COLORS

                #region LICENSE GLOBAL SETTINGS
                //------------------------------------------
                //--- Initialize License Global Settings ---
                //------------------------------------------
                LicenseMgrObj = new LicenseMgr(HenFileSysObj.LicenseFilePath);

                HenSettingsObj.LicenseValidatedFlag = false;
                HenSettingsObj.LicenseTypeEnum = HenTypes.LicenseType.UNKNOWN;
                HenSettingsObj.LicenseStatusEnum = HenTypes.LicenseStatus.UNKNOWN;
                #endregion  // LICENSE GLOBAL SETTINGS

                #region STATUS BAR SETTINGS
                //---------------------------------------
                //--- Initialize Units Global Setting ---
                //---------------------------------------
                HenStudioEnglishUnitsFlag = true;
                //---------------------------------------
                //--- Initialize DB Connected Setting ---
                //---------------------------------------
                DbConnectedFlag = false;
                #endregion  // STATUS BAR SETTINGS

                #endregion  // INITIALIZE PROPERTIES

                //---------------------------
                //--- Initialize Controls ---
                //---------------------------
                InitializeControls();       // Set Inital State of the Form Controls

                #region License Validation
                //--------------------------
                //--- License Validation ---
                //--------------------------
                bValidLicenseFile = ValidateLicense(); // Initialize Global Settings in Method - return valid flag
                #endregion  // License Validation

                #region Initialize Catalog DB Connected Status Bar Label
                //--------------------------------------------------------
                //--- Initialize Catalog DB Connected Status Bar Label ---
                //--------------------------------------------------------
                //HenSettingsObj.CatalogDbConnectedEnum = HenTypes.DbConnected.CONNECTED;
                HenSettingsObj.CatalogDbConnectedEnum = HenTypes.DbConnected.UNCONNECTED;
                UpdateCatalogDbConnectLabel();    // Initialize Catalog Database Connected Status Bar Label
                #endregion  // Initialize Catalog DB Connected Status Bar Label

                #region Initialize Project Dirty Flag State Status Bar Label
                //------------------------------------------------------------
                //--- Initialize Project Dirty Flag State Status Bar Label ---
                //------------------------------------------------------------
                //HenSettingsObj.ProjectDirtyFlagStateEnum = HenTypes.ProjectDirtyFlagState.UPDATE;
                HenSettingsObj.ProjectDirtyFlagStateEnum = HenTypes.ProjectDirtyFlagState.UPDATED;
                UpdateProjectDirtyFlagLabel();    // Initialize Project Dirty Flag State Status Bar Label
                #endregion  // Initialize Project Dirty Flag State Status Bar Label

                #region Initialize Catalog-Project Level Status Bar Label
                //---------------------------------------------------------
                //--- Initialize Catalog-Project Level Status Bar Label ---
                //---------------------------------------------------------
                HenSettingsObj.ExplorerSelectedLevelEnum = HenTypes.ExplorerLevel.CATALOG;
                HenSettingsObj.CurrentProjectName = string.Empty;
                HenSettingsObj.CurrentProfileName = string.Empty;
                HenSettingsObj.CurrentPinchName = string.Empty;
                HenSettingsObj.CurrentHenName = string.Empty;
                UpdateProjectLevelStatusBarLabel();    // Initialize Catalog-Project Level Status Bar Label
                //***********************************************************************************************
                //***********************************************************************************************
                //***********************************************************************************************
                //HenSettingsObj.ProjectExplorerSelectedLevel = HenTypes.ExplorerLevel.CATALOG;
                //HenSettingsObj.ProjectDatabaseName = "Deer Park";
                //HenSettingsObj.CurrentProjectName = "Deer Park";
                //HenSettingsObj.CurrentProfileName = "Q1 Setup";
                //HenSettingsObj.CurrentPinchName = "Delta T = 10";
                //HenSettingsObj.CurrentHenName = "Base Design";
                //UpdateProjectLevelStatusBarLabel();    // Initialize Catalog-Project Level Status Bar Label
                //***********************************************************************************************
                //***********************************************************************************************
                //***********************************************************************************************
                #endregion  // Initialize Project DB Connected Status Bar Label

                #region Set Default Project Units Property
                //-------------------------------------------------
                //--- Initialize Default Project Units Property ---
                //-------------------------------------------------
                //HenSettingsObj.ProjectUnitsEnum = HenTypes.ProjectUnits.ENGLISH;
                HenSettingsObj.ProjectUnitsEnum = HenTypes.ProjectUnits.METRIC;
                #endregion      // Update OPEN Project Units Status Bar Label

                //---------------------------------------------------------------------
                //--- Clear the Sub-PROJECTS (Root) Nodes from Project Explorer Tree --
                //---------------------------------------------------------------------
                RemoveAllNodes();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                this.panelSELECTED_PROJECTS.BringToFront();
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
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Initializing Controls");

            try
            {
                this.Text = "AJP HEN Studio";
                this.BackColor = ColorPanelGreenBackground; // Form Background Color
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

                #region TEST UNIT CONVERSION METHODS
                //****************
                //***** TEST *****
                //****************
                HenMethodsObj.TestUnitConversions();
                #endregion  // TEST UNIT CONVERSION METHODS
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
                HenLogger.WriteSection("END CONSTRUCTION SECTION");
            }

            //-------------------------------------
            //--- Initialize Application Title  ---
            //-------------------------------------
            UpdateProjectNameUI();
        }
        #endregion  // FormMain_Load

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

        #region UpdateLicenseStatusBarLabel() ... LICENSE
        /// <summary>
        /// Update the Status Bar Label for License using Global Settings
        /// </summary>
        private void UpdateLicenseStatusBarLabel()
        {
            string strMethod = "UpdateLicenseStatusBarLabel";
            string strLicenseType = String.Format(" LICENSE ");
            try
            {
                this.toolStripStatusLabelLICENSE.Text = strLicenseType;

                switch (HenSettingsObj.LicenseStatusEnum)
                {
                    case HenTypes.LicenseStatus.EXPIRED:
                    case HenTypes.LicenseStatus.INVALID:
                        this.toolStripStatusLabelLICENSE.BackColor = Color.Red;
                        this.toolStripStatusLabelLICENSE.Image = HenStudio.Properties.Resources.NotValid_32x32;
                        break;
                     case HenTypes.LicenseStatus.UNKNOWN:
                        this.toolStripStatusLabelLICENSE.BackColor = Color.Orange;
                        this.toolStripStatusLabelLICENSE.Image = HenStudio.Properties.Resources.UNKNOWN_32x32;
                        break;
                   case HenTypes.LicenseStatus.VALID:
                        this.toolStripStatusLabelLICENSE.BackColor = Color.Green;
                        this.toolStripStatusLabelLICENSE.Image = HenStudio.Properties.Resources.Valid_32x32;
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
        #endregion  // UpdateLicenseStatusBarLabel() ... LICENSE

        #region UpdateCatalogDbConnectLabel() ... CAT_DB
        /// <summary>
        /// Update the Projects (Catalog) DB Connected Status Bar Label using Global Setting
        /// </summary>
        private void UpdateCatalogDbConnectLabel()
        {
            string strMethod = "UpdateCatalogDbConnectLabel";
            string strDbConnected = String.Format(" CONNECTED ");
            try
            {
                this.toolStripStatusLabelCAT_DB.Text = strDbConnected;

                switch (HenSettingsObj.CatalogDbConnectedEnum)
                {
                    case HenTypes.DbConnected.UNKNOWN:
                        this.toolStripStatusLabelCAT_DB.BackColor = Color.Orange;
                        this.toolStripStatusLabelCAT_DB.ForeColor = Color.White;
                        this.toolStripStatusLabelCAT_DB.Image = HenStudio.Properties.Resources.UNKNOWN_32x32;
                        break;
                    case HenTypes.DbConnected.UNCONNECTED:
                        this.toolStripStatusLabelCAT_DB.BackColor = Color.Red;
                        this.toolStripStatusLabelCAT_DB.ForeColor = Color.White;
                        this.toolStripStatusLabelCAT_DB.Image = HenStudio.Properties.Resources.NotValid_32x32;
                        break;
                    case HenTypes.DbConnected.CONNECTED:
                        this.toolStripStatusLabelCAT_DB.BackColor = Color.Green;
                        this.toolStripStatusLabelCAT_DB.ForeColor = Color.White;
                        this.toolStripStatusLabelCAT_DB.Image = HenStudio.Properties.Resources.Valid_32x32;
                        break;
                    default:
                        throw new Exception("INVALID Catalog DB Connected Enum Value!");
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
        #endregion  // UpdateCatalogDbConnectLabel() ... CAT_DB

        #region UpdateProjectDirtyFlagLabel() ... PROJ_DIRTY
        /// <summary>
        /// Update the Projects Dirty Flag State Status Bar Label using Global Setting
        /// </summary>
        private void UpdateProjectDirtyFlagLabel()
        {
            string strMethod = "UpdateProjectDirtyFlagLabel";
            try
            {
                switch (HenSettingsObj.ProjectDirtyFlagStateEnum)
                {
                    case HenTypes.ProjectDirtyFlagState.UNKNOWN:
                        this.toolStripStatusLabelProjectDirtyFlag.Text = "UNKNOWN";
                        this.toolStripStatusLabelProjectDirtyFlag.BackColor = Color.Orange;
                        this.toolStripStatusLabelProjectDirtyFlag.ForeColor = Color.White;
                        this.toolStripStatusLabelProjectDirtyFlag.Image = HenStudio.Properties.Resources.UNKNOWN_32x32;
                        break;
                    case HenTypes.ProjectDirtyFlagState.UPDATE:
                        this.toolStripStatusLabelProjectDirtyFlag.Text = "UPDATE";
                        this.toolStripStatusLabelProjectDirtyFlag.BackColor = Color.Red;
                        this.toolStripStatusLabelProjectDirtyFlag.ForeColor = Color.White;
                        this.toolStripStatusLabelProjectDirtyFlag.Image = HenStudio.Properties.Resources.NotValid_32x32;
                        break;
                    case HenTypes.ProjectDirtyFlagState.UPDATED:
                        this.toolStripStatusLabelProjectDirtyFlag.Text = "UPDATED";
                        this.toolStripStatusLabelProjectDirtyFlag.BackColor = Color.Green;
                        this.toolStripStatusLabelProjectDirtyFlag.ForeColor = Color.White;
                        this.toolStripStatusLabelProjectDirtyFlag.Image = HenStudio.Properties.Resources.Valid_32x32;
                        break;
                    default:
                        throw new Exception("INVALID Project Dirty Flag State Enum Value!");
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
        #endregion  // UpdateProjectDirtyFlagLabel() ... PROJ_DIRTY

        #region UpdateProjectLevelStatusBarLabel() ... [LEVEL_PROJECT, LEVEL_PROFILE, LEVEL_PINCH, LEVEL_HEN]
        /// <summary>
        /// Update the Catalog-Project Level Status Bar Label using Global Setting
        /// </summary>
        private void UpdateProjectLevelStatusBarLabel()
        {
            string strMethod = "UpdateProjectLevelStatusBarLabel";

            string strNone = "---";
            string strSelectedName = String.Empty;
            try
            {
                //----------------------------------------------------------------------------
                //--- Update Status Bar Text Based on Project Explorer Selected Node Level ---
                //----------------------------------------------------------------------------
                switch (HenSettingsObj.ExplorerSelectedLevelEnum)
                {
                    #region CATALOG (PROJECTS) LEVEL
                    case HenTypes.ExplorerLevel.CATALOG:
                        strSelectedName = String.Format(" PROJECT: {0} ", strNone);
                        this.toolStripStatusLabelLEVEL_PROJECT.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_PROJECT.Image = HenStudio.Properties.Resources.OPEN_Project_DB_32_32;
                        this.toolStripStatusLabelLEVEL_PROJECT.BackColor = Color.WhiteSmoke;
                        this.toolStripStatusLabelLEVEL_PROJECT.ForeColor = HenSettingsObj.ColorCatalogText;

                        strSelectedName = String.Format(" PROFILE: {0} ", strNone);
                        this.toolStripStatusLabelLEVEL_PROFILE.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_PROFILE.BackColor = Color.WhiteSmoke;
                        this.toolStripStatusLabelLEVEL_PROFILE.ForeColor = HenSettingsObj.ColorNotSelectedText;

                        strSelectedName = String.Format(" PINCH: {0} ", strNone);
                        this.toolStripStatusLabelLEVEL_PINCH.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_PINCH.BackColor = Color.WhiteSmoke;
                        this.toolStripStatusLabelLEVEL_PINCH.ForeColor = HenSettingsObj.ColorNotSelectedText;

                        strSelectedName = String.Format(" HEN: {0} ", strNone);
                        this.toolStripStatusLabelLEVEL_HEN.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_HEN.BackColor = Color.WhiteSmoke;
                        this.toolStripStatusLabelLEVEL_HEN.ForeColor = HenSettingsObj.ColorNotSelectedText;

                        break;
                    #endregion  // CATALOG (PROJECTS) LEVEL

                    #region PROJECT LEVEL
                    case HenTypes.ExplorerLevel.PROJECT:
                        strSelectedName = String.Format(" PROJECT: {0} ", HenSettingsObj.CurrentProjectName);
                        this.toolStripStatusLabelLEVEL_PROJECT.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_PROJECT.Image = HenStudio.Properties.Resources.OpenedProject_32x32;
                        this.toolStripStatusLabelLEVEL_PROJECT.BackColor = Color.Yellow;
                        this.toolStripStatusLabelLEVEL_PROJECT.ForeColor = HenSettingsObj.ColorProjectText;

                        strSelectedName = String.Format(" PROFILE: {0} ", strNone);
                        this.toolStripStatusLabelLEVEL_PROFILE.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_PROFILE.BackColor = Color.WhiteSmoke;
                        this.toolStripStatusLabelLEVEL_PROFILE.ForeColor = HenSettingsObj.ColorNotSelectedText;

                        strSelectedName = String.Format(" PINCH: {0} ", strNone);
                        this.toolStripStatusLabelLEVEL_PINCH.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_PINCH.BackColor = Color.WhiteSmoke;
                        this.toolStripStatusLabelLEVEL_PINCH.ForeColor = HenSettingsObj.ColorNotSelectedText;

                        strSelectedName = String.Format(" HEN: {0} ", strNone);
                        this.toolStripStatusLabelLEVEL_HEN.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_HEN.BackColor = Color.WhiteSmoke;
                        this.toolStripStatusLabelLEVEL_HEN.ForeColor = HenSettingsObj.ColorNotSelectedText;

                        break;
                    #endregion  // PROJECT LEVEL

                    #region PROFILE LEVEL
                    case HenTypes.ExplorerLevel.PROFILE:
                        strSelectedName = String.Format(" PROJECT: {0} ", HenSettingsObj.CurrentProjectName);
                        this.toolStripStatusLabelLEVEL_PROJECT.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_PROJECT.Image = HenStudio.Properties.Resources.OpenedProject_32x32;
                        this.toolStripStatusLabelLEVEL_PROJECT.BackColor = Color.LightYellow;
                        this.toolStripStatusLabelLEVEL_PROJECT.ForeColor = HenSettingsObj.ColorProjectText;

                        strSelectedName = String.Format(" PROFILE: {0} ", HenSettingsObj.CurrentProfileName);
                        this.toolStripStatusLabelLEVEL_PROFILE.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_PROFILE.BackColor = Color.Yellow;
                        this.toolStripStatusLabelLEVEL_PROFILE.ForeColor = HenSettingsObj.ColorProfileText;

                        strSelectedName = String.Format(" PINCH: {0} ", strNone);
                        this.toolStripStatusLabelLEVEL_PINCH.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_PINCH.BackColor = Color.WhiteSmoke;
                        this.toolStripStatusLabelLEVEL_PINCH.ForeColor = HenSettingsObj.ColorNotSelectedText;

                        strSelectedName = String.Format(" HEN: {0} ", strNone);
                        this.toolStripStatusLabelLEVEL_HEN.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_HEN.BackColor = Color.WhiteSmoke;
                        this.toolStripStatusLabelLEVEL_HEN.ForeColor = HenSettingsObj.ColorNotSelectedText;

                        break;
                    #endregion  // PROFILE LEVEL

                    #region PINCH LEVEL
                    case HenTypes.ExplorerLevel.PINCH:
                        strSelectedName = String.Format(" PROJECT: {0} ", HenSettingsObj.CurrentProjectName);
                        this.toolStripStatusLabelLEVEL_PROJECT.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_PROJECT.Image = HenStudio.Properties.Resources.OpenedProject_32x32;
                        this.toolStripStatusLabelLEVEL_PROJECT.BackColor = Color.LightYellow;
                        this.toolStripStatusLabelLEVEL_PROJECT.ForeColor = HenSettingsObj.ColorProjectText;

                        strSelectedName = String.Format(" PROFILE: {0} ", HenSettingsObj.CurrentProfileName);
                        this.toolStripStatusLabelLEVEL_PROFILE.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_PROFILE.BackColor = Color.LightYellow;
                        this.toolStripStatusLabelLEVEL_PROFILE.ForeColor = HenSettingsObj.ColorProfileText;

                        strSelectedName = String.Format(" PINCH: {0} ", HenSettingsObj.CurrentPinchName);
                        this.toolStripStatusLabelLEVEL_PINCH.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_PINCH.BackColor = Color.Yellow;
                        this.toolStripStatusLabelLEVEL_PINCH.ForeColor = HenSettingsObj.ColorPinchText;

                        strSelectedName = String.Format(" HEN: {0} ", strNone);
                        this.toolStripStatusLabelLEVEL_HEN.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_HEN.BackColor = Color.WhiteSmoke;
                        this.toolStripStatusLabelLEVEL_HEN.ForeColor = HenSettingsObj.ColorNotSelectedText;

                        break;
                    #endregion  // PINCH LEVEL

                    #region HEN LEVEL
                    case HenTypes.ExplorerLevel.HEN:
                        strSelectedName = String.Format(" PROJECT: {0} ", HenSettingsObj.CurrentProjectName);
                        this.toolStripStatusLabelLEVEL_PROJECT.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_PROJECT.Image = HenStudio.Properties.Resources.OpenedProject_32x32;
                        this.toolStripStatusLabelLEVEL_PROJECT.BackColor = Color.LightYellow;
                        this.toolStripStatusLabelLEVEL_PROJECT.ForeColor = HenSettingsObj.ColorProjectText;

                        strSelectedName = String.Format(" PROFILE: {0} ", HenSettingsObj.CurrentProfileName);
                        this.toolStripStatusLabelLEVEL_PROFILE.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_PROFILE.BackColor = Color.LightYellow;
                        this.toolStripStatusLabelLEVEL_PROFILE.ForeColor = HenSettingsObj.ColorProfileText;

                        strSelectedName = String.Format(" PINCH: {0} ", HenSettingsObj.CurrentPinchName);
                        this.toolStripStatusLabelLEVEL_PINCH.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_PINCH.BackColor = Color.LightYellow;
                        this.toolStripStatusLabelLEVEL_PINCH.ForeColor = HenSettingsObj.ColorPinchText;

                        strSelectedName = String.Format(" HEN: {0} ", HenSettingsObj.CurrentHenName);
                        this.toolStripStatusLabelLEVEL_HEN.Text = strSelectedName;
                        this.toolStripStatusLabelLEVEL_HEN.BackColor = Color.Yellow;
                        this.toolStripStatusLabelLEVEL_HEN.ForeColor = HenSettingsObj.ColorHenText;

                        break;
                    #endregion  // HEN LEVEL

                    #region UNKNOWN LEVEL
                    default:

                        break;
                    #endregion  // UNKNOWN LEVEL
                }
                //-------------------------------------------------
                //--- Update Application Title ... Project Name ---
                //-------------------------------------------------
                UpdateProjectNameUI();
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
        #endregion  // UpdateProjectLevelStatusBarLabel() ... [LEVEL_PROJECT, LEVEL_PROFILE, LEVEL_PINCH, LEVEL_HEN]

        #endregion  // UPDATE STATUS BAR LABELS METHODS

        #region EVENT HANDLERS

        #region MENU BAR EVENTS

        #region FILE MENU ITEMS

        #region NEW PROJECT MENU ITEM HANDLER
        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //HenMsgDlg.DisplayWarningDlg("New Menu Item Selected!");
            HandleNewProject();
        }
        #endregion  // NEW MENU ITEM HANDLER

        #region IMPORT PROJECT ZIP MENU ITEM HANDLER
        private void importProjectZIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //HenMsgDlg.DisplayWarningDlg("Import Menu Item Selected!");
            HandleImport();
        }
        #endregion  // IMPORT PROJECT ZIP MENU ITEM HANDLER

        #region EXIT AJP HEN STUDIO MEMU ITEM HANDLER
        private void exitAJPHENStudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleExit();    // Exit Pinch Application
        }
        #endregion       // EXIT EXIT AJP HEN STUDIO MEMU ITEM HANDLER

        #endregion  // FILE MENU ITEMS

        #region EDIT MENU ITEMS

        #region SETTINGS MENU ITME HANDLER
        private void settingsDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //HenMsgDlg.DisplayWarningDlg("Settings Menu Item Selected!");
            DisplayProjectSettingsForm();
        }        
        #endregion  // SETTINGS MENU ITME HANDLER

        #endregion  // EDIT MENU ITEMS

        #region HELP MENU ITEMS

        #region LICENSE
        private void licenseViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //HenMsgDlg.DisplayWarningDlg("License Menu Item Selected!");
            DisplayLicenseForm();
        }
        #endregion      // LICENSE

        #region SCORECARD
        private void licenseScoreCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayScoreCardForm();
        }

        #endregion  // SCORECARD

        #region USER LICENSE AGREEMENT
        private void userLicenseAgreementToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            DisplayUserLicenseAgreementForm();
        }
        #endregion  // USER LICENSE AGREEMENT

        #region ABOUT
        private void aboutAJPHENStudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAboutForm();
        }
        #endregion  // ABOUT

        #endregion  // HELP MENU ITEMS

        #endregion  // MENU BAR EVENTS

        #region STATUS BAR EVENTS

        #region LICENSE CLICK
        private void toolStripStatusLabelLICENSE_Click(object sender, EventArgs e)
        {
            HandleLicenseStatus();
        }
        #endregion  // LICENSE CLICK

        #region LICENSE DOUBLE CLICK
        private void toolStripStatusLabelLICENSE_DoubleClick(object sender, EventArgs e)
        {
            HandleLicenseStatus();
        }
        #endregion  // LICENSE DOUBLE CLICK

        #region DB CONNECTION CLICK
        private void toolStripStatusLabelCAT_DB_Click(object sender, EventArgs e)
        {
            HandleDBConnectionState();
        }
        #endregion  // DB CONNECTION CLICK

        #region DB CONNECTION DOUBLE CLICK
        private void toolStripStatusLabelCAT_DB_DoubleClick(object sender, EventArgs e)
        {
            HandleDBConnectionState();
        }
        #endregion  // DB CONNECTION DOUBLE CLICK

        #region PROJECT DIRTY FLAG CLICK
        private void toolStripStatusLabelProjectDirtyFlag_Click(object sender, EventArgs e)
        {
            //HenMsgDlg.DisplayWarningDlg("PROJECT DIRTY FLAG CLICK EVENT");
            HandleProjectDirtyFlagState();
        }
        #endregion  // PROJECT DIRTY FLAG CLICK

        #region PROJECT DIRTY FLAG DOUBLE CLICK
        private void toolStripStatusLabelProjectDirtyFlag_DoubleClick(object sender, EventArgs e)
        {
            //HenMsgDlg.DisplayWarningDlg("PROJECT DIRTY FLAG DOUBLE CLICK EVENT");
            HandleProjectDirtyFlagState();
        }
        #endregion  // PROJECT DIRTY FLAG DOUBLE CLICK

        #region AJP LOGO CLICK
        private void toolStripStatusLabelAJP_LOGO_Click(object sender, EventArgs e)
        {
            HandleAJPContactInfo();
        }
        #endregion  // AJP LOGO CLICK

        #region AJP LOGO DOUBLE CLICK
        private void toolStripStatusLabelAJP_LOGO_DoubleClick(object sender, EventArgs e)
        {
            HandleAJPContactInfo();
        }
        #endregion  // AJP LOGO DOUBLE CLICK

        #endregion  // STATUS BAR EVENTS

        #endregion      // EVENT HANDLERS

        #region METHODS

        #region UpdateProjectNameUI()
        /// <summary>
        /// Update the Application Title based on Current Project Name 
        /// (e.g., HenSettingsObj.CurrentProjectName)
        /// </summary>
        private void UpdateProjectNameUI()
        {
            string strTitle = String.Empty;

            if (HenSettingsObj.ExplorerSelectedLevelEnum == HenTypes.ExplorerLevel.CATALOG)
            {
                strTitle = string.Format("AJP HEN Studio");
            }
            else
            {
                strTitle = string.Format("AJP HEN Studio : {0}", HenSettingsObj.CurrentProjectName);
            }

            this.Text = strTitle;
        }
        #endregion  // UpdateProjectNameUI()

        #region COMMON COMMAND HANDLERS

        #region DisplayProjectSettingsForm()
        /// <summary>
        /// Common Display Project Settings Form Handler
        /// </summary>
        private void DisplayProjectSettingsForm()
        {
            string strMethod = "DisplayProjectSettingsForm";
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Display Settings Form");
            try
            {
                //HenMsgDlg.DisplayWarningDlg("Handle Project Settings Form Command!");
                FormSettings dlg = new FormSettings();
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
        #endregion  // DisplayProjectSettingsForm()

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
                        HenSettingsObj.LicenseValidatedFlag = false;
                    }
                    else if (tableData.DaysRemaining <= 0)
                    {
                        HenSettingsObj.LicenseStatusEnum = HenTypes.LicenseStatus.EXPIRED;
                        HenSettingsObj.LicenseValidatedFlag = false;
                    }
                    else
                    {
                        HenSettingsObj.LicenseStatusEnum = HenTypes.LicenseStatus.VALID;
                        HenSettingsObj.LicenseValidatedFlag = true;
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

        //-------------------------

        #region HandleLicenseStatus
        /// <summary>
        /// Common License State Handler
        /// </summary>
        private void HandleLicenseStatus()
        {
            string strMethod = "HandleLicenseStatus";
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Display License Viewer");
            try
            {
                //HenMsgDlg.DisplayWarningDlg("Display License Viewer!");
                DisplayLicenseForm();
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
        #endregion  // HandleLicenseStatus

        #region HandleDBConnectionState
        /// <summary>
        /// Common Database Connection Handler
        /// </summary>
        private void HandleDBConnectionState()
        {
            string strMethod = "HandleDBConnectionState";
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Handle Database Connection Command");
            try
            {
                //HenMsgDlg.DisplayWarningDlg("Handle Database Connection Command!");
                //----------------------------------------
                //--- Display Projects (CATALOG) Panel ---
                //----------------------------------------
                this.panelSELECTED_PROJECTS.BringToFront();
                treeViewCurrentProjectExplorer.SelectedNode = GetRootNode();
                GetRootNode().EnsureVisible();

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
        #endregion  // HandleDBConnectionState

        #region HandleProjectDirtyFlagState
        /// <summary>
        /// Common Project Dirty Flag State Handler
        /// </summary>
        private void HandleProjectDirtyFlagState()
        {
            string strMethod = "HandleProjectDirtyFlagState";
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Handle Dirty Flag");
            try
            {
                //HenMsgDlg.DisplayWarningDlg("Handle Project Dirty Falg State Command!");
                switch(HenSettingsObj.ProjectDirtyFlagStateEnum)
                {
                    case ProjectDirtyFlagState.UPDATE:
                        //---------------------------
                        //--- Update the Database ---
                        //---------------------------
                        HenMsgDlg.DisplayWarningDlg("Update the Database!");
                        //-------------------------------------------------------
                        //--- Change Dirty Flag State & Update the Status Bar ---
                        //-------------------------------------------------------
                        HenSettingsObj.ProjectDirtyFlagStateEnum = ProjectDirtyFlagState.UPDATED;
                        UpdateProjectDirtyFlagLabel();
                        break;
                    case ProjectDirtyFlagState.UPDATED:
                        //---------------------------------------
                        //--- Alreadly Updated ... Do Nothing ---
                        //---------------------------------------
                        break;
                    default:
                        throw new Exception("UNKNOWN Dirty Flag Status Encountered!");                        
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
        #endregion  // HandleProjectDirtyFlagState

        #region HandleAJPContactInfo
        /// <summary>
        /// Common AJP Contact Info Handler
        /// </summary>
        private void HandleAJPContactInfo()
        {
            string strMethod = "HandleLicenseStatus";
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Display AJP Contact Info");
            try
            {
                //HenMsgDlg.DisplayWarningDlg("Display AJP Contact Info!");
                DisplayBusinessCardForm();
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
        #endregion  // HandleAJPContactInfo

        //-------------------------

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

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        //----------------------------------- Project ZIP Explorer TreeView ---
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        #region PROJECT ZIP (EXPORT | IMPORT) EXPLORER TREE VIEW

        #region Context Menu Handlers

        #region COLLAPSE ALL
        private void toolStripMenuItemZipCollapseAll_Click(object sender, EventArgs e)
        {
            CollapseAllProjectZipExplorer();
        }
        #endregion  // COLLAPSE ALL

        #region EXPAND ALL

        private void toolStripMenuItemZipExpandAll_Click(object sender, EventArgs e)
        {
            ExpandAllProjectZipExplorer();
        }

        #endregion  // EXPAND ALL

        #endregion  // Context Menu Handlers

        #region CollapseAllProjectZipExplorer()
        public void CollapseAllProjectZipExplorer()
        {
            this.treeViewProjectZipExplorer.CollapseAll();
        }
        #endregion  // CollapseAllProjectZipExplorer()

        #region ExpandAllProjectZipExplorer()
        public void ExpandAllProjectZipExplorer()
        {
            this.treeViewProjectZipExplorer.ExpandAll();
        }

        #endregion  // ExpandAllProjectZipExplorer()

        #endregion  // PROJECT ZIP (EXPORT | IMPORT) EXPLORER TREE VIEW

    }
    #endregion      // class FormPinch
}
#endregion      // namespace HenStudio

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
