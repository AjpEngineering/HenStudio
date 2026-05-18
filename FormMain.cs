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

#region AJP HEN NAMESPACES
using AJP_License_File;

using HenGlobal;

using HenModel.Connection;
using HenModel.Connection.Interface;

using HenModel.Dto;
using HenModel.Dto.System;

using HenModel.Dto.Project;
using HenModel.Dto.Project.CostParameters;
using HenModel.Dto.Project.DefaultParameters;
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

using HenModel.Dto.Profile;

using HenModel.Dto.Pinch;
using HenModel.Dto.Pinch.Plots;

using HenModel.Dto.Hen;
using HenModel.Dto.Hen.Plots;

using HenModel.RepoImplementations.System;
using HenModel.RepoImplementations.Project;
using HenModel.RepoImplementations.Profile;
using HenModel.RepoImplementations.Pinch;
using HenModel.RepoImplementations.Hen;

using HenViewModel;
using HenViewModel.System;

using HenViewModel.Project;
using HenViewModel.Project.CostParameters;
using HenViewModel.Project.DefaultParameters;
using HenViewModel.Project.DefaultParameters.ExchangerParams;
using HenViewModel.Project.DefaultParameters.OptimizerParams;
using HenViewModel.Project.DefaultParameters.ProjectUnits;

using HenViewModel.Profile;
using HenViewModel.Profile.Streams;

using HenViewModel.Pinch;
using HenViewModel.Pinch.Plots;

using HenViewModel.Hen;
//using HenViewModel.Hen.Plots;

using HenStudio.Properties;
using HenStudio.Data.Project;
using HenStudio.Data.Tag;

#endregion  // AJP HEN NAMESPACES

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Threading;
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

                #region DATABASE CONNECTION SETTINGS
                //----------------------------------------
                //--- Initialize DB Connection Setting ---
                //----------------------------------------
                DbConnectedFlag = false;
                HenSettingsObj.DbConnectedEnum = HenTypes.DbConnected.UNCONNECTED;
                #endregion  // DATABASE CONNECTION SETTINGS

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

                #region Initialize Catalog-Project Level Status Bar Label
                //---------------------------------------------------------
                //--- Initialize Catalog-Project Level Status Bar Label ---
                //---------------------------------------------------------
                HenSettingsObj.ExplorerSelectedLevelEnum = HenTypes.ExplorerNodeId.CATALOG;
                HenSettingsObj.CurrentProjectName = string.Empty;
                HenSettingsObj.CurrentProfileName = string.Empty;
                HenSettingsObj.CurrentPinchName = string.Empty;
                HenSettingsObj.CurrentHenName = string.Empty;
                UpdateProjectLevelStatusBarLabel();    // Initialize Catalog-Project Level Status Bar Label
                //***********************************************************************************************
                //***********************************************************************************************
                //***********************************************************************************************
                //HenSettingsObj.ProjectExplorerSelectedLevel = HenTypes.ExplorerNodeId.CATALOG;
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
            HenLogger.WriteSection("GET HENSTUDIO DATABASE TABLE NAMES");
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

                #region LOG DATABASE TABLE NAMES
                LogDatabaseTables();
                #endregion  // LOG DATABASE TABLE NAMES

                #region POPULATE CONNECTION STRING CONTROLS
                PopulateConnectionStringControls();
                LogConnectionState();
                #endregion  // POPULATE CONNECTION STRING CONTROLS

                #region GET APPLICATION GLOBAL SETTINGS FROM DB
                GetGlobalSettings();
                #endregion  // GET APPLICATION GLOBAL SETTINGS FROM DB

                #region POPULATE PROJECT TREE NODES
                HenLogger.WriteSection("START POPULATE PROJECT TREE NODES");
                RefreshTree();
                LogTree();
                HenLogger.WriteSection("END POPULATE PROJECT TREE NODES");
                #endregion  // POPULATE PROJECT TREE NODES
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
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

        #region PopulateConnectionStringControls()
        /// <summary>
        /// Populates the connection string-related UI controls with the current connection data.
        /// </summary>
        /// <remarks>Retrieves connection information from the configured data source and updates the
        /// corresponding UI fields. If an error occurs during retrieval, the error is logged and the UI fields may not
        /// be updated.</remarks>
        private void PopulateConnectionStringControls()
        {
            string strMethod = "PopulateConnectionStringControls";
            //-------------------------------------------------------------------------------------------------
            //--- Initialize DB Connected Enum to UNCONNECTED before attempting to retrieve connection data ---
            //-------------------------------------------------------------------------------------------------
            HenSettingsObj.DbConnectedEnum = DbConnected.UNCONNECTED;   

            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var connDataRepo = new ConnectionDataRepo(connFactoryObj);
            try
            {
                var connData = connDataRepo.GetConnectionData();

                textBoxConnDataSourceValue.Text = connData.DataSource;
                textBoxConnUserIDValue.Text = connData.UserId;
                textBoxConnWorkstationIDValue.Text = connData.WorkstationId;
                textBoxConnInitCatalogValue.Text = connData.InitialCatalog;
                textBoxConnTimeoutValue.Text = connData.Timeout.ToString();
                textBoxConnPacketSizeValue.Text = (connData.PacketSize.ToString() + " Kb");
                textBoxConnServerVersionValue.Text = connData.ServerVersion;
                textBoxConnStateValue.Text = connData.ConnectionState;

                //------------------------------------------------------------------------------------------------
                //--- SET GLOBAL DB CONNECTED FLAG AND ENUM VALUE IN SETTINGS OBJECT BASED ON CONNECTION STATE ---
                //------------------------------------------------------------------------------------------------
                if (string.Compare(connData.ConnectionState, "Open",true) == 0)
                {
                    //-----------------------------
                    //--- OPEN Connection State ---
                    //-----------------------------
                    HenSettingsObj.DbConnectedEnum = DbConnected.CONNECTED;
                }
                else
                {
                    //---------------------------------
                    //--- NOT OPEN Connection State ---
                    //---------------------------------
                    HenSettingsObj.DbConnectedEnum = DbConnected.UNCONNECTED;
                }

                //-----------------------------------------------------------------
                //--- Update DB Connected Status Bar Label using Global Setting ---
                //-----------------------------------------------------------------
                UpdateDbConnectLabel();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                //----------------------------------------------------------------
                //--- Use Connection Factory Object Method to Close Connection ---
                //--- Null Guard for Connection Object in case of Exception    ---
                //--- during Connection Creation                               ---
                //----------------------------------------------------------------
                if (connFactoryObj.dbConnection != null)
                {
                    connFactoryObj.CloseConnection(connFactoryObj.dbConnection);
                }
            }
        }
        #endregion  // PopulateConnectionStringControls()

        #region GetGlobalSettings()
        private void GetGlobalSettings()
        {
            string strMethod = "GetGlobalSettings";
            string strMsg = string.Empty;
            try
            {
                HenLogger.WriteSection("CONNECTING TO DATABASE ... GET GLOBAL SETTING KEY-VALUE PAIRS");

                //-------------------------------------------------------------------------------------------------
                //--- Create System ViewModel Object to Retrieve Global Settings Data from DB using Repo Method ---
                //-------------------------------------------------------------------------------------------------
                var systemViewModelObj = new SystemViewModel();

                var settingsDtos = systemViewModelObj.GetGlobalSettings();
                foreach (var nameValuePair in settingsDtos)
                {
                    strMsg = string.Format("  + KEY: {0,-40} ... VALUE: {1}",
                                           nameValuePair.SettingKey,
                                           nameValuePair.SettingValue);
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }

                //--------------------------------------------------------------------------------------
                //--- ASSIGN APPLICATION GLOBAL SETTINGS PROPERTIES FROM DB VALUES USING REPO METHOD ---
                //--------------------------------------------------------------------------------------
                HenSettingsObj.AppGlobalSettingsObj = systemViewModelObj.GetAppGlobalSettings();
                LogAppGlobalSettings();  // Log Application Global Settings based on data retrieved from DB
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
        #endregion  // GetGlobalSettings()

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

        #region UpdateDbConnectLabel() ... HENSTUDIO DB
        /// <summary>
        /// Update the Projects (Catalog) DB Connected Status Bar Label using Global Setting
        /// </summary>
        private void UpdateDbConnectLabel()
        {
            string strMethod = "UpdateDbConnectLabel";
            string strDbConnected = String.Format(" DISCONNECTED ");
            try
            {
                this.toolStripStatusLabelCAT_DB.Text = strDbConnected;

                switch (HenSettingsObj.DbConnectedEnum)
                {
                    case HenTypes.DbConnected.UNKNOWN:
                        strDbConnected = String.Format(" UNKNOWN ");
                        this.toolStripStatusLabelCAT_DB.BackColor = Color.Orange;
                        this.toolStripStatusLabelCAT_DB.ForeColor = Color.White;
                        this.toolStripStatusLabelCAT_DB.Image = HenStudio.Properties.Resources.UNKNOWN_32x32;
                        break;
                    case HenTypes.DbConnected.UNCONNECTED:
                        strDbConnected = String.Format(" DISCONNECTED ");
                        this.toolStripStatusLabelCAT_DB.BackColor = Color.Red;
                        this.toolStripStatusLabelCAT_DB.ForeColor = Color.White;
                        this.toolStripStatusLabelCAT_DB.Image = HenStudio.Properties.Resources.NotValid_32x32;
                        break;
                    case HenTypes.DbConnected.CONNECTED:
                        strDbConnected = String.Format(" CONNECTED ");
                        this.toolStripStatusLabelCAT_DB.BackColor = Color.Green;
                        this.toolStripStatusLabelCAT_DB.ForeColor = Color.White;
                        this.toolStripStatusLabelCAT_DB.Image = HenStudio.Properties.Resources.Valid_32x32;
                        break;
                    default:
                        throw new Exception("INVALID HENSTUDIO DB Connected Enum Value!");
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
                this.toolStripStatusLabelCAT_DB.Text = strDbConnected;
            }
        }
        #endregion  // UpdateDbConnectLabel() ... HENSTUDIO DB

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
                    case HenTypes.ExplorerNodeId.CATALOG:
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
                    case HenTypes.ExplorerNodeId.PROJECT:
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
                    case HenTypes.ExplorerNodeId.PROFILE:
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
                    case HenTypes.ExplorerNodeId.PINCH:
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
                    case HenTypes.ExplorerNodeId.HEN:
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

            if (HenSettingsObj.ExplorerSelectedLevelEnum == HenTypes.ExplorerNodeId.CATALOG)
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
            TreeNode rootNode = GetRootNode();
            try
            {
                //---------------------------------------------
                //--- Display Projects (HENSTUDIO DB) Panel ---
                //---------------------------------------------
                rootNode.ImageIndex = 9;

                this.panelSELECTED_PROJECTS.BringToFront();
                treeViewCurrentProjectExplorer.SelectedNode = rootNode;
                rootNode.EnsureVisible();
                treeViewCurrentProjectExplorer.HideSelection = false;
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                CheckDbConnection();
            }
        }
        #endregion  // HandleDBConnectionState

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

        #region LogConnectionState()
        private void LogConnectionState()
        {
            string strMethod = "LogConnectionState";
            string strMsg = string.Empty;

            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var connDataRepo = new ConnectionDataRepo(connFactoryObj);
            var connData = connDataRepo.GetConnectionData();
            try
            {
                HenLogger.WriteSection("HENSTUDIO DATABASE CONNECTION STATE");

                strMsg = string.Format("  + DATA SOURCE      : {0}", connData.DataSource);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("  + USER ID          : {0}", connData.UserId);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("  + WORKSTATION ID   : {0}", connData.WorkstationId);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("  + INITIAL CATALOG  : {0}", connData.InitialCatalog);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("  + TIME OUT         : {0}", connData.Timeout.ToString());
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("  + PACKET SIZE      : {0}", (connData.PacketSize.ToString() + " Kb"));
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("  + SERVER VERSION   : {0}", connData.ServerVersion);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("  + CONNECTION STATE : {0}", connData.ConnectionState);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                //----------------------------------------------------------------
                //--- Use Connection Factory Object Method to Close Connection ---
                //----------------------------------------------------------------
                connFactoryObj.CloseConnection(connFactoryObj.dbConnection);
            }
        }
        #endregion  // LogConnectionState()

        #region LogDatabaseTables()
        /// <summary>
        /// Logs the names and schemas of all database tables in the current Hen Studio database connection for
        /// diagnostic or informational purposes.
        /// </summary>
        /// <remarks>This method connects to the configured Hen Studio database, retrieves all available
        /// table names and their schemas, and writes this information to the log. It is typically used for
        /// troubleshooting or verifying database structure during development or support operations. Any exceptions
        /// encountered during the process are logged as errors. The database connection is closed automatically when
        /// the operation completes.
        /// </remarks>
        private void LogDatabaseTables()
        {
            string strMethod = "LogDatabaseTables";
            string strMsg = string.Empty;
            HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Log Database Tables");
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var dbTablesRepo = new DatabaseTableRepo(connFactoryObj);
            var connDataRepo = new ConnectionDataRepo(connFactoryObj);
            try
            {
                HenLogger.WriteSection("CONNECTING TO DATABASE ... GET TABLE NAMES");

                foreach (var tableName in dbTablesRepo.GetDatabaseTables())
                {
                    strMsg = string.Format("  + TABLE: {0,-30} ... SCHEMA: {1}",
                                           tableName.TableName,
                                           tableName.SchemaName);
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
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
                //----------------------------------------------------------------
                //--- Use Connection Factory Object Method to Close Connection ---
                //----------------------------------------------------------------
                connFactoryObj.CloseConnection(connFactoryObj.dbConnection);
            }
        }
        #endregion  // LogDatabaseTables()

        #region LogAppGlobalSettings()
        /// <summary>
        /// Logs Application Global Settings values.
        /// </summary>
        /// <remarks>This method Logs Application Global Settings values based on retrieved DB key-value pairs. 
        /// It is typically used for troubleshooting or verifying configuration during development or support operations. 
        /// Any exceptions encountered during the process are logged as errors.
        /// </remarks>
        private void LogAppGlobalSettings()
        {
            string strMethod = "LogAppGlobalSettings";
            string strMsg = string.Empty;
            try
            {
                HenLogger.WriteSection("LOG APPLICATION GLOBAL SETTINGS ... BASED ON RETRIEVED DB KEY-VALUE PAIRS");

                strMsg = string.Format("  {0,-44} ... {1}", "DatabaseCreatedOn", HenSettingsObj.AppGlobalSettingsObj.DatabaseCreatedOn.ToString());
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1:0.00}", "DefaultApproachTemperature", HenSettingsObj.AppGlobalSettingsObj.DefaultApproachTemperature);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1:0.00}", "DefaultEnglishU", HenSettingsObj.AppGlobalSettingsObj.DefaultEnglishU);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1:0.00}", "DefaultMetricU", HenSettingsObj.AppGlobalSettingsObj.DefaultMetricU);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "DefaultOptimizer", HenSettingsObj.AppGlobalSettingsObj.DefaultOptimizer);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "EnableAreaEstimation", HenSettingsObj.AppGlobalSettingsObj.EnableAreaEstimation.ToString());
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "ExternalMagnitudeUnits", HenSettingsObj.AppGlobalSettingsObj.ExternalMagnitudeUnits);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "ExternalPressUnits", HenSettingsObj.AppGlobalSettingsObj.ExternalPressUnits);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "ExternalSystemUnits", HenSettingsObj.AppGlobalSettingsObj.ExternalSystemUnits);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "ExternalTempUnits", HenSettingsObj.AppGlobalSettingsObj.ExternalTempUnits);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "ExternalUnitsA", HenSettingsObj.AppGlobalSettingsObj.ExternalUnitsA);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "ExternalUnitsEnergy", HenSettingsObj.AppGlobalSettingsObj.ExternalUnitsEnergy);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "ExternalUnitsHeatCapacityFlowRate", HenSettingsObj.AppGlobalSettingsObj.ExternalUnitsHeatCapacityFlowRate);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "ExternalUnitsMassFlowrate", HenSettingsObj.AppGlobalSettingsObj.ExternalUnitsMassFlowrate);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "ExternalUnitsSpecificHeatCapacity", HenSettingsObj.AppGlobalSettingsObj.ExternalUnitsSpecificHeatCapacity);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "ExternalUnitsU", HenSettingsObj.AppGlobalSettingsObj.ExternalUnitsU);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "InternalMagnitudeUnits", HenSettingsObj.AppGlobalSettingsObj.InternalMagnitudeUnits);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "InternalPressUnits", HenSettingsObj.AppGlobalSettingsObj.InternalPressUnits);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "InternalSystemUnits", HenSettingsObj.AppGlobalSettingsObj.InternalSystemUnits);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "InternalTempUnits", HenSettingsObj.AppGlobalSettingsObj.InternalTempUnits);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "InternalUnitsA", HenSettingsObj.AppGlobalSettingsObj.InternalUnitsA);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "InternalUnitsEnergy", HenSettingsObj.AppGlobalSettingsObj.InternalUnitsEnergy);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "InternalUnitsHeatCapacityFlowRate", HenSettingsObj.AppGlobalSettingsObj.InternalUnitsHeatCapacityFlowRate);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "InternalUnitsMassFlowrate", HenSettingsObj.AppGlobalSettingsObj.InternalUnitsMassFlowrate);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "InternalUnitsSpecificHeatCapacity", HenSettingsObj.AppGlobalSettingsObj.InternalUnitsSpecificHeatCapacity);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "InternalUnitsU", HenSettingsObj.AppGlobalSettingsObj.InternalUnitsU);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "LastMigrationApplied", HenSettingsObj.AppGlobalSettingsObj.LastMigrationApplied);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "ReportDefaultFont", HenSettingsObj.AppGlobalSettingsObj.ReportDefaultFont);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "ReportIncludeAuditSection", HenSettingsObj.AppGlobalSettingsObj.ReportIncludeAuditSection.ToString());
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "ReportUnitsProfile", HenSettingsObj.AppGlobalSettingsObj.ReportUnitsProfile);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("  {0,-44} ... {1}", "SchemaVersion", HenSettingsObj.AppGlobalSettingsObj.SchemaVersion);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
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
        #endregion  // LogAppGlobalSettings()

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
        //----------------------------------------- CATALOG (Projects) Panel---
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        #region CATALOG (Projects) Panel

        #region CLICK CONNECTION BUTTON EVENT
        private void buttonConnection_Click(object sender, EventArgs e)
        {
            string strMethod = "buttonConnection_Click";
            try
            {
                CheckDbConnection();
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
        #endregion  // CLICK CONNECTION BUTTON EVENT

        #region CheckDbConnection()
        private void CheckDbConnection()
        {
            string strMethod = "CheckDbConnection";
            try
            {
                //-------------------------------------------
                //--- Populate Connection String Controls ---
                //-------------------------------------------
                PopulateConnectionStringControls();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                UpdateDbConnectLabel();
                //LogConnectionState();
            }
        }
        #endregion  // CheckDbConnection()

        #region AJP HEN STUDIO LOGO CLICK
        private void pictureBoxProductLogo_Click(object sender, EventArgs e)
        {
            DisplayAboutForm();
        }
        #endregion  // AJP HEN STUDIO LOGO CLICK

        #endregion  // CATALOG (Projects) Panel

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //----------------------------------------- Project Panel---
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

        #region Project Panel

        #region CONVERSION METHODS ... DTO - PANEL VIEW DATA

        #region GetProjectViewData()
        /// <summary>
        /// Creates a new ProjectViewData instance populated with All Project Panel data 
        /// based on the specified Project Data Transfer Object values.
        /// </summary>
        /// <remarks>The returned ProjectViewData will have its Properties set according to the
        /// system, magnitude, and temperature units specified in the input ProjectDto. This ensures that all
        /// unit-related fields are consistent with the project's configuration.</remarks>
        /// <param name="projectDto">The Project Data Transfer Object containing the source Project information. 
        /// Cannot be null.</param>
        /// <returns>A ProjectPanelData object containing the mapped project details and unit display values derived from the
        /// provided project data.</returns>
        private ProjectPanelData GetProjectViewData(ProjectDto projectDto, 
                                                   ExchangerParamsDto exchangerParamsDto,
                                                   ProjectUnitsDto projectUnitsDto)
        {
            //-----------------------------
            //--- Null ProjectDto Guard ---
            //-----------------------------
            if (projectDto == null) throw new ArgumentNullException(nameof(projectDto),
                                       "Project Data Transfer Object cannot be null.");

            ProjectPanelData projectViewDataObj = new ProjectPanelData();

            projectViewDataObj.Id = projectDto.Id;
            projectViewDataObj.Name = projectDto.Name;
            projectViewDataObj.Description = projectDto.Description;
            projectViewDataObj.ProjectU_Value = exchangerParamsDto.DefaultHeatTransferCoefficient.ToString();
            projectViewDataObj.ProjectF_Value = exchangerParamsDto.DefaultCorrectionFactor.ToString();
            projectViewDataObj.ProjectOptimizer = projectDto.DefaultOptimizer;

            projectViewDataObj.ProjectSystem_Units = projectUnitsDto.DefaultSystemUnits;
            projectViewDataObj.ProjectMagnitude_Units = projectUnitsDto.DefaultMagnitudeUnits;
            projectViewDataObj.ProjectTemperature_Units = projectUnitsDto.DefaultTemperatureUnits;
            projectViewDataObj.ProjectPressure_Units = projectUnitsDto.DefaultPressureUnits;

            projectViewDataObj.ProjectCreationDate = projectDto.CreationDate;
            projectViewDataObj.ProjectModificationDate = projectDto.ModifiedDate;

            #region ENGLISH
            if (string.Compare(projectUnitsDto.DefaultSystemUnits, "English - Imperial", true) == 0)
            {
                projectViewDataObj.ProjectArea_Units = "ft2";

                #region BASE
                if (string.Compare(projectUnitsDto.DefaultMagnitudeUnits, "Base", true) == 0)
                {
                    projectViewDataObj.ProjectDuty_Units = "Btu/hr";

                    if (string.Compare(projectUnitsDto.DefaultTemperatureUnits, "°F", true) == 0)
                    {
                        projectViewDataObj.ProjectCP_Units = "BTU/(hr·°F)";
                        projectViewDataObj.ProjectU_Units = "BTU/(hr·ft2·°F)";
                    }
                    else if (string.Compare(projectUnitsDto.DefaultTemperatureUnits, "°R", true) == 0)
                    {
                        projectViewDataObj.ProjectCP_Units = "BTU/(hr·°R)";
                        projectViewDataObj.ProjectU_Units = "BTU/(hr·ft2·°R)";
                    }
                }
                #endregion  // BASE

                #region KILO
                else if (string.Compare(projectUnitsDto.DefaultMagnitudeUnits, "Kilo", true) == 0)
                {
                    projectViewDataObj.ProjectDuty_Units = "KBtu/hr";

                    if (string.Compare(projectUnitsDto.DefaultTemperatureUnits, "°F", true) == 0)
                    {
                        projectViewDataObj.ProjectCP_Units = "KBTU/(hr·°F)";
                        projectViewDataObj.ProjectU_Units = "KBTU/(hr·ft2·°F)";
                    }
                    else if (string.Compare(projectUnitsDto.DefaultTemperatureUnits, "°R", true) == 0)
                    {
                        projectViewDataObj.ProjectCP_Units = "KBTU/(hr·°R)";
                        projectViewDataObj.ProjectU_Units = "KBTU/(hr·ft2·°R)";
                    }

                }
                #endregion  // KILO

                #region MEGA
                else if (string.Compare(projectUnitsDto.DefaultMagnitudeUnits, "Mega", true) == 0)
                {
                    projectViewDataObj.ProjectDuty_Units = "MMBtu/hr";

                    if (string.Compare(projectUnitsDto.DefaultTemperatureUnits, "°F", true) == 0)
                    {
                        projectViewDataObj.ProjectCP_Units = "MMBTU/(hr·°F)";
                        projectViewDataObj.ProjectU_Units = "MMBTU/(hr·ft2·°F)";
                    }
                    else if (string.Compare(projectUnitsDto.DefaultTemperatureUnits, "°R", true) == 0)
                    {
                        projectViewDataObj.ProjectCP_Units = "MMBTU/(hr·°R)";
                        projectViewDataObj.ProjectU_Units = "MMBTU/(hr·ft2·°R)";
                    }

                }
                #endregion  // MEGA
            }
            #endregion  // ENGLISH

            #region METRIC
            else if (string.Compare(projectUnitsDto.DefaultSystemUnits, "Metric - SI", true) == 0)
            {
                projectViewDataObj.ProjectArea_Units = "m2";

                #region BASE
                if (string.Compare(projectUnitsDto.DefaultMagnitudeUnits, "Base", true) == 0)
                {
                    projectViewDataObj.ProjectDuty_Units = "W";

                    if (string.Compare(projectUnitsDto.DefaultTemperatureUnits, "K", true) == 0)
                    {
                        projectViewDataObj.ProjectCP_Units = "W/(K)";
                        projectViewDataObj.ProjectU_Units = "W/(m2·K)";
                    }
                    else if (string.Compare(projectUnitsDto.DefaultTemperatureUnits, "°C", true) == 0)
                    {
                        projectViewDataObj.ProjectCP_Units = "W/(°C)";
                        projectViewDataObj.ProjectU_Units = "W/(m2·°C)";
                    }
                }
                #endregion  // BASE

                #region KILO
                else if (string.Compare(projectUnitsDto.DefaultMagnitudeUnits, "Kilo", true) == 0)
                {
                    projectViewDataObj.ProjectDuty_Units = "kW";

                    if (string.Compare(projectUnitsDto.DefaultTemperatureUnits, "K", true) == 0)
                    {
                        projectViewDataObj.ProjectCP_Units = "kW/(K)";
                        projectViewDataObj.ProjectU_Units = "kW/(m2·K)";
                    }
                    else if (string.Compare(projectUnitsDto.DefaultTemperatureUnits, "°C", true) == 0)
                    {
                        projectViewDataObj.ProjectCP_Units = "kW/(°C)";
                        projectViewDataObj.ProjectU_Units = "kW/(m2·°C)";
                    }
                }
                #endregion  // KILO

                #region MEGA
                else if (string.Compare(projectUnitsDto.DefaultMagnitudeUnits, "Mega", true) == 0)
                {
                    projectViewDataObj.ProjectDuty_Units = "MW";

                    if (string.Compare(projectUnitsDto.DefaultTemperatureUnits, "K", true) == 0)
                    {
                        projectViewDataObj.ProjectCP_Units = "MW/(K)";
                        projectViewDataObj.ProjectU_Units = "MW/(m2·K)";
                    }
                    else if (string.Compare(projectUnitsDto.DefaultTemperatureUnits, "°C", true) == 0)
                    {
                        projectViewDataObj.ProjectCP_Units = "MW/(°C)";
                        projectViewDataObj.ProjectU_Units = "MW/(m2·°C)";
                    }
                }
                #endregion  // MEGA
            }
            #endregion  // METRIC

            return projectViewDataObj;
        }
        #endregion  // GetProjectViewData()

        #region GetProjectDtoFromViewData()
        /// <summary>
        /// Gets Project Data Transfer Objects populated with All Project Panel data 
        /// based on the specified ProjectViewData values.
        /// </summary>
        /// <param name="projectViewDataObj">Project Panel Data</param>
        /// <param name="ProjectDtoObj">Project Data Transfer Object</param>
        /// <param name="ExchangerParamsDtoObj">Exchanger Parameters Data Transfer Object</param>
        /// <param name="ProjectUnitsDtoObj">Project Units Data Transfer Object</param>
        /// <exception cref="ArgumentNullException"></exception>
        private void GetDtosFromViewData(in  ProjectPanelData projectViewDataObj,
                                         out ProjectDto ProjectDtoObj,
                                         out ExchangerParamsDto ExchangerParamsDtoObj,
                                         out ProjectUnitsDto ProjectUnitsDtoObj)                                                     
        {
            //-----------------------------------------
            //--- Null ProjectViewData Object Guard ---
            //-----------------------------------------
             if (projectViewDataObj == null) throw new ArgumentNullException(nameof(projectViewDataObj),
                                       "Project View Data Object cannot be null.");

            ProjectDtoObj = new ProjectDto();
            ExchangerParamsDtoObj = new ExchangerParamsDto();
            ProjectUnitsDtoObj = new ProjectUnitsDto();

            ProjectDtoObj.Id = projectViewDataObj.Id;
            ProjectDtoObj.Name = projectViewDataObj.Name;
            ProjectDtoObj.Description = projectViewDataObj.Description;

            ProjectDtoObj.CreationDate = projectViewDataObj.ProjectCreationDate;
            ProjectDtoObj.ModifiedDate = projectViewDataObj.ProjectModificationDate;

            ProjectDtoObj.DefaultHenOptimizer = projectViewDataObj.ProjectHenOptimizer;

            ExchangerParamsDtoObj.DefaultHeatTransferCoefficient = double.Parse(projectViewDataObj.ProjectU_Value);
            ExchangerParamsDtoObj.DefaultCorrectionFactor = double.Parse(projectViewDataObj.ProjectF_Value);

            ProjectUnitsDtoObj.DefaultSystemUnits = projectViewDataObj.ProjectSystem_Units;
            ProjectUnitsDtoObj.DefaultMagnitudeUnits = projectViewDataObj.ProjectMagnitude_Units;
            ProjectUnitsDtoObj.DefaultTemperatureUnits = projectViewDataObj.ProjectTemperature_Units;
            ProjectUnitsDtoObj.DefaultPressureUnits = projectViewDataObj.ProjectPressure_Units;

        }

        #endregion  // GetProjectDtoFromViewData()

        #endregion  // CONVERSION METHODS ... DTO - PANEL VIEW DATA

        #region PopulateProjectPanel(ProjectViewData projectPanelData)
        /// <summary>
        /// Populate the Project Panel with ProjectViewData
        /// </summary>
        /// <param name="projectPanelData"></param>
        private void PopulateProjectPanel(ProjectPanelData projectPanelData)
        {
            this.textBoxProjectGUID.Text = projectPanelData.Id.ToString();
            this.textBoxProjectNameValue.Text = projectPanelData.Name;
            this.textBoxProjectDescriptionValue.Text = projectPanelData.Description;

            this.textBoxDefaultU_Value.Text = projectPanelData.ProjectU_Value.ToString();
            this.textBoxFValue.Text = projectPanelData.ProjectF_Value.ToString();
            this.textBoxDefaultHenOpitimizer.Text = projectPanelData.ProjectHenOptimizer;
            this.textBoxDefaultU_Units.Text = projectPanelData.ProjectU_Units;
           
            //--- PROJECT UNITS ---

            this.textBoxProjectUnitsSystem.Text = projectPanelData.ProjectSystem_Units;
            this.textBoxProjectUnitsMagnitude.Text = projectPanelData.ProjectMagnitude_Units;
            this.textBoxProjectUnitsTemp.Text = projectPanelData.ProjectTemperature_Units;
            this.textBoxProjectUnitsPress.Text = projectPanelData.ProjectPressure_Units;

            this.textBoxUnitsAreaValue.Text = projectPanelData.ProjectArea_Units;
            this.textBoxUnitsDutyValue.Text = projectPanelData.ProjectDuty_Units;
            this.textBoxUnitsCPValue.Text = projectPanelData.ProjectCP_Units;
            this.textBoxUnitsUValue.Text = projectPanelData.ProjectU_Units;

            //--- Update Systems Units Image ---
            if (string.Compare(projectPanelData.ProjectSystem_Units, "Metric - SI", true) == 0)
            {
                pictureBoxUnitsSystem.Image = Resources.Metric_SI_Units_32x32;
            }
            else if (string.Compare(projectPanelData.ProjectSystem_Units, "English - Imperial", true) == 0)
            {
                pictureBoxUnitsSystem.Image = Resources.English_Imperial_Units_32x32;
            }
            else throw new Exception("Invalid System Units!");
        }
        #endregion  // PopulateProjectPanel(ProjectViewData projectPanelData)

        #endregion  // Project Panel

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //----------------------------------------- Profile Panel---
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

        #region Profile Panel

        #endregion  // Profile Panel

    }
    #endregion      // class FormMain
}
#endregion      // namespace HenStudio

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
  