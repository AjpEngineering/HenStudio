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

using HenViewModel.Pinch;
using HenViewModel.Pinch.Plots;

using HenViewModel.Hen;
//using HenViewModel.Hen.Plots;

using HenStudio.Properties;
using HenStudio.Data.Project;
using HenStudio.Data.Project.DefaultParameters;
using HenStudio.Data.Project.DefaultParameters.ExchangerParams;
using HenStudio.Data.Project.DefaultParameters.OptimizerParams;
using HenStudio.Data.Project.DefaultParameters.ProjectUnits;
using HenStudio.Data.Project.CostParameters;
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

using System.Runtime;
using System.Runtime.InteropServices.ComTypes;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

                this.Text = HenSettings.AJP_PRODUCT_NAME;      // Form Title

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

                #region Initialize Root-Project-Profile-Study Property Values
                //---------------------------------------------------------
                //--- Initialize Root-Project Level Status Bar Label ---
                //---------------------------------------------------------
                HenSettingsObj.ExplorerSelectedNodeIdEnum = HenTypes.ExplorerNodeIdType.CATALOG;
                HenSettingsObj.CurrentProjectName = string.Empty;
                HenSettingsObj.CurrentProfileName = string.Empty;
                HenSettingsObj.CurrentStudyName = string.Empty;
                #endregion  // Initialize Root-Project-Profile-Study Property Values

            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                this.panelSELECTED_ROOT.BringToFront();
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
                this.Text = HenSettings.AJP_PRODUCT_NAME;   // Form Title
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
            HenLogger.WriteSection("GET SYSTEM FACTORY SETTINGS");
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

                #region GET SYSTEM DATA FROM DB ... Populate HenSettings Properties
                GetSystemFactorySettings();

                PopulateConnectionStringControls();
                #endregion  // GET SYSTEM DATA FROM DB ... Populate HenSettings Properties

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
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=  ASSIGN LICENSE STATUS  =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

                #region Get Scorecard Data
                ScoreCardTableData scoreCardTableDataObj = LicenseMgrObj.GetScoreCardTableData(HenFileSysObj.LicenseFolderPath);
                if(scoreCardTableDataObj.NumInvalidProps > 0)
                {
                    HenSettingsObj.LicenseValidatedFlag = false;
                    HenSettingsObj.LicenseStatusEnum = HenTypes.LicenseStatus.INVALID;
                }
                else
                {
                    HenSettingsObj.LicenseValidatedFlag = true;
                    HenSettingsObj.LicenseStatusEnum = HenTypes.LicenseStatus.VALID;
                }

                //-----------------------------------------------------------------------------------------
                //--- Get Scorecard Data into Global HenSettings Object for use in UI and other methods ---
                //-----------------------------------------------------------------------------------------
                HenSettingsObj.ScoreCardListObj = new ScoreCardList();
                foreach(ScoreCardRowData rowData in scoreCardTableDataObj.ScoreCardListObj)
                {
                    ScoreCardRow row = new ScoreCardRow(rowData.PropertyID, 
                                                        rowData.PropertyName, 
                                                        rowData.PropertyValue, 
                                                        rowData.PropertyState);

                    HenSettingsObj.ScoreCardListObj.AddRow(row);
                }
                #endregion  // Get Scorecard Data

                #region Get License File Data
                //--------------------------------------------------------------------------------------------
                //--- Get License File Data into Global HenSettings Object for use in UI and other methods ---
                //-------------------------------------------------------------------------------------------
                HenSettingsObj.LicenseFileDtoObj.FileHash = licenseFileXmlObj.FileHash;

                HenSettingsObj.LicenseFileDtoObj.RunTimeDeviceName = licenseFileXmlObj.RunTimeDeviceName;
                HenSettingsObj.LicenseFileDtoObj.RunTimeUserName = licenseFileXmlObj.RunTimeUserName;

                HenSettingsObj.LicenseFileDtoObj.Author = licenseFileXmlObj.Author;
                HenSettingsObj.LicenseFileDtoObj.SupplierName = licenseFileXmlObj.SupplierName;
                HenSettingsObj.LicenseFileDtoObj.SupplierUrl = licenseFileXmlObj.SupplierUrl;

                HenSettingsObj.LicenseFileDtoObj.CustomerName = licenseFileXmlObj.CustomerName;
                HenSettingsObj.LicenseFileDtoObj.CustomerEmail = licenseFileXmlObj.CustomerEmail;

                HenSettingsObj.LicenseFileDtoObj.ProductName = licenseFileXmlObj.ProductName;
                HenSettingsObj.LicenseFileDtoObj.ProductVersion = licenseFileXmlObj.ProductVersion; 
                HenSettingsObj.LicenseFileDtoObj.SerialNumber = licenseFileXmlObj.SerialNumber;
                HenSettingsObj.LicenseFileDtoObj.ProductCode = licenseFileXmlObj.ProductCode;

                HenSettingsObj.LicenseFileDtoObj.LicenseType = licenseFileXmlObj.LicenseType;

                HenSettingsObj.LicenseFileDtoObj.Corporation = licenseFileXmlObj.Corporation;
                HenSettingsObj.LicenseFileDtoObj.Division = licenseFileXmlObj.Division;
                HenSettingsObj.LicenseFileDtoObj.Group = licenseFileXmlObj.Group;

                HenSettingsObj.LicenseFileDtoObj.DeviceName = licenseFileXmlObj.DeviceName;
                HenSettingsObj.LicenseFileDtoObj.UserName = licenseFileXmlObj.UserName;

                HenSettingsObj.LicenseFileDtoObj.FileLicenseKey = licenseFileXmlObj.FileLicenseKey;

                HenSettingsObj.LicenseFileDtoObj.DurationDays = licenseFileXmlObj.DurationDays;
                HenSettingsObj.LicenseFileDtoObj.StartDate = licenseFileXmlObj.StartDate;
                HenSettingsObj.LicenseFileDtoObj.EndDate = licenseFileXmlObj.EndDate;
                HenSettingsObj.LicenseFileDtoObj.RemainingDays = licenseFileXmlObj.RemainingDays;
                #endregion  // Get License File Data

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
            try
            {
                ConnectionDataDto connDataDto = HenSettingsObj.ConnectionDataDtoObj;

                textBoxConnDataSourceValue.Text = connDataDto.DataSource;
                textBoxConnUserIDValue.Text = connDataDto.UserId;
                textBoxConnWorkstationIDValue.Text = connDataDto.WorkstationId;
                textBoxConnInitCatalogValue.Text = connDataDto.InitialCatalog;
                textBoxConnTimeoutValue.Text = connDataDto.Timeout.ToString();
                textBoxConnPacketSizeValue.Text = (connDataDto.PacketSize.ToString() + " Kb");
                textBoxConnServerVersionValue.Text = connDataDto.ServerVersion;
                textBoxConnStateValue.Text = connDataDto.ConnectionState;
                //------------------------------------------------------------------------------------------------
                //--- SET GLOBAL DB CONNECTED FLAG AND ENUM VALUE IN SETTINGS OBJECT BASED ON CONNECTION STATE ---
                //------------------------------------------------------------------------------------------------
                if (string.Compare(connDataDto.ConnectionState, "Open",true) == 0)
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
            }
        }
        #endregion  // PopulateConnectionStringControls()

        #region GetSystemFactorySettings()
        /// <summary>
        /// Get the System Factory Settings from the Database and Assign Global Settings Properties
        /// </summary>
        private void GetSystemFactorySettings()
        {
            string strMethod = "GetSystemFactorySettings";
            string strMsg = string.Empty;
            //---------------------------------------------------------
            //--- Create ViewModel Repo Objects to Retrieve DB Data ---
            //---------------------------------------------------------
            SystemViewModel systemViewModelObj = new SystemViewModel();

            SqlConnectionFactory connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            ConnectionDataRepo connDataRepo = new ConnectionDataRepo(connFactoryObj);

            try
            {
                HenLogger.WriteSection("CONNECTING TO DATABASE ... GET SYSTEM FACTORY SETTINGS");

                #region APP GLOBAL SETTINGS

                #endregion  // APP GLOBAL SETTINGS

                #region CONNECTION DATA
                ConnectionDataDto connDataDto = connDataRepo.GetConnectionData();

                HenSettingsObj.ConnectionDataDtoObj = connDataDto;

                LogConnectionState(connDataDto);
                connFactoryObj.CloseConnection(connFactoryObj.dbConnection);
                #endregion  // CONNECTION DATA

                #region DATABASE TABLES
                //----------------------------------------------------------
                //--- Get Database Tables Data from DB using Repo Method ---
                //----------------------------------------------------------
                HenSettingsObj.DatabaseTableDtoList = systemViewModelObj.GetDatabaseTables();
                //--------------------------------------------------------------------
                //--- Log Database Tables Schame and Table Names Retrieved from DB ---
                //--------------------------------------------------------------------
                foreach (var databaseTableDto in HenSettingsObj.DatabaseTableDtoList)
                {
                    strMsg = string.Format("  + SCHEMA: {0,-40} ... TABLE: {1}",
                                           databaseTableDto.SchemaName,
                                           databaseTableDto.TableName);
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // DATABASE TABLES

                #region GLOBAL SETTINGS
                //----------------------------------------------------------
                //--- Get Global Settings Data from DB using Repo Method ---
                //----------------------------------------------------------
                HenSettingsObj.GlobalSettingsDtoList = systemViewModelObj.GetGlobalSettings();
                //-------------------------------------------------------------
                //--- Log Global Settings Key-Value Pairs Retrieved from DB ---
                //-------------------------------------------------------------
                foreach (var nameValuePair in HenSettingsObj.GlobalSettingsDtoList)
                {
                    strMsg = string.Format("  + KEY: {0,-40} ... VALUE: {1}",
                                           nameValuePair.SettingKey,
                                           nameValuePair.SettingValue);
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // GLOBAL SETTINGS

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
        #endregion  // GetSystemFactorySettings()

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
                        this.toolStripStatusLabelLICENSE.Image = HenStudio.Properties.Resources.NotValid;
                        break;
                     case HenTypes.LicenseStatus.UNKNOWN:
                        this.toolStripStatusLabelLICENSE.BackColor = Color.Orange;
                        this.toolStripStatusLabelLICENSE.Image = HenStudio.Properties.Resources.UNKNOWN32;
                        break;
                   case HenTypes.LicenseStatus.VALID:
                        this.toolStripStatusLabelLICENSE.BackColor = Color.Green;
                        this.toolStripStatusLabelLICENSE.Image = HenStudio.Properties.Resources.Valid32;
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
                        this.toolStripStatusLabelCAT_DB.Image = HenStudio.Properties.Resources.UNKNOWN32;
                        break;
                    case HenTypes.DbConnected.UNCONNECTED:
                        strDbConnected = String.Format(" DISCONNECTED ");
                        this.toolStripStatusLabelCAT_DB.BackColor = Color.Red;
                        this.toolStripStatusLabelCAT_DB.ForeColor = Color.White;
                        this.toolStripStatusLabelCAT_DB.Image = HenStudio.Properties.Resources.NotValid;
                        break;
                    case HenTypes.DbConnected.CONNECTED:
                        strDbConnected = String.Format(" CONNECTED ");
                        this.toolStripStatusLabelCAT_DB.BackColor = Color.Green;
                        this.toolStripStatusLabelCAT_DB.ForeColor = Color.White;
                        this.toolStripStatusLabelCAT_DB.Image = HenStudio.Properties.Resources.Valid32;
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

        #region EXIT AJP HEN STUDIO MEMU ITEM HANDLER
        private void exitAJPHENStudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleExit();    // Exit Pinch Application
        }
        #endregion       // EXIT EXIT AJP HEN STUDIO MEMU ITEM HANDLER

        #endregion  // FILE MENU ITEMS

        #endregion  // MENU BAR EVENTS

        #region STATUS BAR EVENTS

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

        #region EXIT APP CLICK
        private void toolStripStatusLabelExitApp_Click(object sender, EventArgs e)
        {
            HandleExit();    // Exit Pinch Application
        }
        #endregion  // EXIT APP CLICK

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

            if (HenSettingsObj.ExplorerSelectedNodeIdEnum == HenTypes.ExplorerNodeIdType.CATALOG)
            {
                strTitle = string.Format("{0} ",
                                         HenSettings.AJP_PRODUCT_NAME);
            }
            else
            {
                strTitle = string.Format("{0}} : {1}", 
                                         HenSettings.AJP_PRODUCT_NAME,
                                         HenSettingsObj.CurrentProjectName);
            }

            this.Text = strTitle;
        }
        #endregion  // UpdateProjectNameUI()

        #region COMMON COMMAND HANDLERS

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

                this.panelSELECTED_ROOT.BringToFront();
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
        private void LogConnectionState(ConnectionDataDto connDataDto)
        {
            string strMethod = "LogConnectionState";
            string strMsg = string.Empty;
            try
            {
                HenLogger.WriteSection("HENSTUDIO DATABASE CONNECTION STATE");

                strMsg = string.Format("  + DATA SOURCE      : {0}", connDataDto.DataSource);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("  + USER ID          : {0}", connDataDto.UserId);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("  + WORKSTATION ID   : {0}", connDataDto.WorkstationId);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("  + INITIAL CATALOG  : {0}", connDataDto.InitialCatalog);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("  + TIME OUT         : {0}", connDataDto.Timeout.ToString());
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("  + PACKET SIZE      : {0}", (connDataDto.PacketSize.ToString() + " Kb"));
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("  + SERVER VERSION   : {0}", connDataDto.ServerVersion);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("  + CONNECTION STATE : {0}", connDataDto.ConnectionState);
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
        #endregion  // LogConnectionState()

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
        //--------------------------------------------- CATALOG (ROOT) Panel---
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        #region CATALOG (Root) Panel

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

        #region PICTURE BOX CLICK EVENTS

        #region CONTACT AJP CLICK
        private void pictureBoxHomeAjpLogo_Click(object sender, EventArgs e)
        {
            DisplayBusinessCardForm();
        }
        private void pictureBoxAjpContactInfo_Click(object sender, EventArgs e)
        {
            DisplayBusinessCardForm();
        }
        private void pictureBoxFactorySettingsAjpEngLogo_Click(object sender, EventArgs e)
        {
            DisplayBusinessCardForm();
            }

        private void pictureBoxDbAjpEndLogo_Click(object sender, EventArgs e)
        {
            DisplayBusinessCardForm();
        }

        private void pictureBoxAjpEngLogo_Click(object sender, EventArgs e)
        {
            DisplayBusinessCardForm();
        }
        #endregion  // CONTACT AJP CLICK

        #region LICENSE AGREEMENT CLICK
        private void pictureBoxLicenseAgreement_Click(object sender, EventArgs e)
        {
            FormUserLicenseAgreement dlg = new FormUserLicenseAgreement();
            dlg.ShowDialog();
        }
        #endregion  // LICENSE AGREEMENT CLICK

        #endregion  // PICTURE BOX CLICK EVENTS

        #endregion  // CATALOG (Root) Panel

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //----------------------------------------- Project Panel---
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

        #region Project Panel

        #region PopulateProjectPanel(ProjectViewData projectPanelData)
        /// <summary>
        /// Populate the Project Panel and Subpanels with Project ViewData Objects
        /// </summary>
        /// <param name="projectPanelDataObj">Project Panel Data Object</param>
        /// <param name="projectUnitsPanelDataObj">Project Units Panel Data Object</param>
        /// <param name="optimizerParamsPanelDataObj">Optimizer Parameters Panel Data Object</param>
        /// <param name="exchangerParamsPanelDataObj">Exchanger Parameters Panel Data Object</param>
        private void PopulateProjectPanel(ProjectPanelData projectPanelDataObj,
                                          ProjectUnitsPanelData projectUnitsPanelDataObj,
                                          OptimizerParamsPanelData optimizerParamsPanelDataObj,
                                          ExchangerParamsPanelData exchangerParamsPanelDataObj)
        {
            //this.textBoxProjectGUID.Text = projectPanelData.Id.ToString();
            //this.textBoxProjectNameValue.Text = projectPanelData.Name;
            //this.textBoxProjectDescriptionValue.Text = projectPanelData.Description;

            //this.textBoxDefaultU_Value.Text = projectPanelData.ProjectU_Value.ToString();
            //this.textBoxFValue.Text = projectPanelData.ProjectF_Value.ToString();
            //this.textBoxDefaultHenOpitimizer.Text = projectPanelData.ProjectHenOptimizer;
            //this.textBoxDefaultU_Units.Text = projectPanelData.ProjectU_Units;
           
            ////--- PROJECT UNITS ---

            //this.textBoxProjectUnitsSystem.Text = projectPanelData.ProjectSystem_Units;
            //this.textBoxProjectUnitsMagnitude.Text = projectPanelData.ProjectMagnitude_Units;
            //this.textBoxProjectUnitsTemp.Text = projectPanelData.ProjectTemperature_Units;
            //this.textBoxProjectUnitsPress.Text = projectPanelData.ProjectPressure_Units;

            //this.textBoxUnitsAreaValue.Text = projectPanelData.ProjectArea_Units;
            //this.textBoxUnitsDutyValue.Text = projectPanelData.ProjectDuty_Units;
            //this.textBoxUnitsCPValue.Text = projectPanelData.ProjectCP_Units;
            //this.textBoxUnitsUValue.Text = projectPanelData.ProjectU_Units;

            ////--- Update Systems Units Image ---
            //if (string.Compare(projectPanelData.ProjectSystem_Units, "Metric - SI", true) == 0)
            //{
            //    pictureBoxUnitsSystem.Image = Resources.Metric_SI_Units_32x32;
            //}
            //else if (string.Compare(projectPanelData.ProjectSystem_Units, "English - Imperial", true) == 0)
            //{
            //    pictureBoxUnitsSystem.Image = Resources.English_Imperial_Units_32x32;
            //}
            //else throw new Exception("Invalid System Units!");
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
  