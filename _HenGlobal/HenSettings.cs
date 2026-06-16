#region HEADER
//#####################################################################################################################
//##########################################  H e n S e t t i n g s . c s  ############################################
//#####################################################################################################################
//  FILENAME:  HenSettings.cs
//  NAMESPACE: HenGlobal
//  CLASS(S):  HenSettings
//  COMPONENT: _HenGLobal.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Global HEN Studio Settings.
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
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HenModel.Connection;

using HenModel.Dto;
using HenModel.Dto.Hen;
using HenModel.Dto.Pinch;
using HenModel.Dto.Profile;

using HenModel.Dto.Project;
using HenModel.Dto.Project.CostParameters;
using HenModel.Dto.Project.DefaultParameters;
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

using HenModel.Dto.Application;

using static HenGlobal.HenTypes;
#endregion  // REFERENCES

#region namespace HenGlobal
namespace HenGlobal
{
    #region public class HenSettings
    /// <summary>
    /// Global HEN Studio Settings Class
    /// </summary>
    public class HenSettings
    {
        #region CONSTANTS
        const string NAMESPACE = "HenGlobal";
        const string CLASS = "HenSettings";
        #endregion      // CONSTANTS

        #region CONNECTION STRINGS
        //public const string HenStudio = HenModel.Connection.ConnectionString;
        //public const string HenStudio = "Server=localhost\\HENSTUDIO;Database=HenStudio;Trusted_Connection=True;";
        #endregion  // CONNECTION STRINGS

        #region ROOT NAME
        const string ROOT_NAME = "HenStudio";
        #endregion  //// ROOT NAME

        #region SUPPLIER & PRODUCT INFORMATION ... LICENSE FILE STRINGS
        //-------------------------------------------------------------------------------
        //--- Supplier Information ... Check Against What is Supplied in License File ---
        //-------------------------------------------------------------------------------
        public const string AJP_SUPPLIER_NAME = "AJP Engineering";
        public const string AJP_SUPPLIER_URL = "http:://www.AJPEngineering.com";
        //------------------------------------------------------------------------------
        //--- Product Information ... Check Against What is Supplied in License File ---
        //------------------------------------------------------------------------------
        public const string AJP_PRODUCT_FULLNAME = "AJP HEN Studio 1.0";
        public const string AJP_PRODUCT_NAME = "AJP HEN Studio";
        public const string AJP_PRODUCT_VERSION = "1.0.1";
        public const string AJP_PRODUCT_SERIAL_NUMBER = "1022-789-1189" ;
        public const string AJP_PRODUCT_CODE = "{3D9721BA-003E-4711-B7AF-B579645F0AC9}";
        #endregion  // SUPPLIER & PRODUCT INFORMATION ... LICENSE FILE STRINGS

        #region FIELDS

        #region CUSTOMER INFORMATION ... SPECIFIED IN LICENSE FILE
        //---------------------------------------------------------
        //--- Customer Information ... Specifed in License File ---
        //---------------------------------------------------------
        public string CUSTOMER_NAME  = "TBD - REQUIRED!";
        public string CUSTOMER_EMAIL = "TBD";
        #endregion  // CUSTOMER INFORMATION ... SPECIFIED IN LICENSE FILE

        #region LICENSE INFORMATION - SEE LICENSE FILE CLASS
        //-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //--- License Information ... Specified in License File ---
        //-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        #endregion  // LICENSE INFORMATION - SEE LICENSE FILE CLASS

        #endregion      // FIELDS

        #region PROPERTIES
        
        #region HEN Studio Application Components (Assemblies)
        public List<string> AJP_HEN_COMPONENTS { get; set; }  // Component List;
        #endregion  // HEN Studio Application Components (Assemblies)

        #region STANDARD APPLICATION TEXT COLORS

        #region GENERAL
        public Color ColorGeneral_NotSelected_Text { get; set; }  // Color.FromArgb(255, 112, 128, 144 ... SlateGray
        public Color ColorGeneral_Selected_Text { get; set; }     // Color.FromArgb(255, 0, 0, 0 ......... Black
        #endregion  // GENERAL

        #region PROJECTS-CATALOG
        public Color ColorProjects_Catalog_NotSelected_Text { get; set; }  // Color.FromArgb(255, 250, 0, 0) ...... Blue
        public Color ColorProjects_Catalog_Selected_Text { get; set; }     // Color.FromArgb(255, 91, 203, 250) ... Icon Blue
        #endregion  // PROJECTS-CATALOG

        #region PROJECT
        public Color ColorProject_NotSelected_Text { get; set; }  // Color.FromArgb(255, 91, 203, 250) ... Icon Blue
        public Color ColorProject_Selected_Text { get; set; }     // Color.FromArgb(255, 250, 100, 87) ... Icon Orange
        #endregion  // PROJECT

        #region PROFILE
        public Color ColorProfile_NotSelected_Text { get; set; }  // Color.FromArgb(255, 150, 150, 255) ... Icon Purple
        public Color ColorProfile_Selected_Text { get; set; }     // Color.FromArgb(255, 135, 80, 255) .... Icon Purple (darker)
        #endregion  // PROFILE

        #region STUDY
        public Color ColorStudy_NotSelected_Text { get; set; }    // Color.FromArgb(255, 255, 100, 100) ... Light Red
        public Color ColorStudy_Selected_Text { get; set; }       // Color.FromArgb(255, 255, 0, 0) ....... Red
        #endregion  // STUDY

        #region PINCH
        public Color ColorPinch_NotSelected_Text { get; set; }    // Color.FromArgb(255, 0, 255, 255) ....... Turquiose
        public Color ColorPinch_Selected_Text { get; set; }       // Color.FromArgb(255, 0, 230, 230) ....... Darker Turquiose
        #endregion  // PINCH

        #region HEN
        public Color ColorHen_NotSelected_Text { get; set; }      // Color.FromArgb(255, 75, 255, 180) .... Greenish Turquiose
        public Color ColorHen_Selected_Text { get; set; }         // Color.FromArgb(255, 0, 230, 130) ..... Darker Greenish Turquiose
        #endregion  // HEN

        #region FIGURE
        public Color ColorFigure_NotSelected_Text { get; set; }      // Color.FromArgb(255, 180, 60, 0) .... Brown
        public Color ColorFigure_Selected_Text { get; set; }         // Color.FromArgb(255, 150, 50, 0) .... Darker Brown
        #endregion  // FIGURE

        #endregion  // STANDARD APPLICATION TEXT COLORS

        #region LICENSE

        #region LicenseFileDtoObj
        /// <summary>
        /// License File DTO Object for License Scorecard Panel
        /// </summary>
        public LicenseFileDto LicenseFileDtoObj { get; set; }
        #endregion  // LicenseFileDtoObj

        #region ScoreCardListObj
        /// <summary>
        /// ScoreCard List Object for License Scorecard Panel
        /// </summary>
        public ScoreCardList ScoreCardListObj { get; set; }
        #endregion  // ScoreCardListObj

        #region LicenseValidatedFlag
        /// <summary>
        /// License Validation Flag
        /// true if License is Valid and NOT Expired; otherwise false
        /// </summary>
        public bool LicenseValidatedFlag { get; set; }                   // License Validate Flag
        #endregion  // LicenseValidatedFlag

        #region LicenseTypeEnum
        /// <summary>
        /// License Type ... [ UNKNOWN = -1 | TRIAL = 0 | SITE = 1 | DEVICE = 2 | USER = 3 | SEAT = 4 ]
        /// Note: USER type not Supported for Pinch
        /// </summary>
        public HenTypes.LicenseType LicenseTypeEnum { get; set; }      // License Type
        #endregion  // LicenseTypeEnum

        #region LicenseStatusEnum
        /// <summary>
        /// License Status ... [EXPIRED = -2 | INVALID = -1 | UNKNOWN = 0 | VALID = 1]
        /// </summary>
        public HenTypes.LicenseStatus LicenseStatusEnum { get; set; }  // License Status
        #endregion  // LicenseStatusEnum

        #endregion  // LICENSE

        #region SYSTEM DATA
        //public List<AppGlobalSettingsDto> AppGlobalSettingsList { get; set; }
        public ConnectionDataDto ConnectionDataDtoObj { get; set; }
        public IList<DatabaseTableDto> DatabaseTableDtoList { get; set; }
        public IList<AppSettingsDto> GlobalSettingsDtoList { get; set; }
        #endregion  // SYSTEM DATA

        #region ROOT - PROJECT - PROFILE - STUDY ... STATE PROPERTIES

        #region ExplorerSelectedNodeIdEnum
        /// <summary>
        /// Project Explorer Selected Node ID Enumeration
        /// </summary>
        public ExplorerNodeIdType ExplorerSelectedNodeIdEnum 
                { get; set; }  // Project Explorer Selected Node ID Enumeration
        #endregion  // ExplorerSelectedNodeIdEnum

        #region CurrentRootName
        /// <summary>
        /// Current Root Name
        /// </summary>
        public string CurrentRootName { get; set; }  // Current Root Name
        #endregion  // CurrentRootName

        #region CurrentProjectName
        /// <summary>
        /// Current Project Name
        /// </summary>
        public string CurrentProjectName { get; set; }  // Current Project Name
        #endregion  // CurrentProjectName

        #region CurrentProfileName
        /// <summary>
        /// Current Profile Name
        /// </summary>
        public string CurrentProfileName { get; set; }  // Current Profile Name
        #endregion  // CurrentProfileName

        #region CurrentStudyName
        /// <summary>
        /// Current Study Name
        /// </summary>
        public string CurrentStudyName { get; set; }  // Current Study Name
        #endregion  // CurrentStudyName

        #endregion  // ROOT - PROJECT - PROFILE - STUDY ... STATE PROPERTIES

        #region STATUS BAR

        #region DbConnectedEnum
        /// <summary>
        /// HENSTUDIO Database Connected Flag ... [UNKNOWN = -1 | UNCONNECTED = 0 | CONNECTED = 1]
        /// Used in Status Bar display
        /// </summary>
        public HenTypes.DbConnected DbConnectedEnum { get; set; } // HENSTUDIO DB Connected [UNKNOWN | UNCONNECTED | CONNECTED]
        #endregion  // DbConnectedEnum

        #endregion  // STATUS BAR

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public HenSettings()
        {
            string strMethod = "CTOR";
            HenLogger.WriteSeparatorLine(' ');
            HenLogger.WriteSeparatorLine('>');
            HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating HenSettings Object");
            try
            {
                #region STANDARD APPLICATION TEXT COLORS
                ColorGeneral_NotSelected_Text = Color.SlateGray;
                ColorGeneral_Selected_Text = Color.Black;

                ColorProjects_Catalog_NotSelected_Text = Color.FromArgb(255, 250, 0, 0);  // Blue
                ColorProjects_Catalog_Selected_Text = Color.FromArgb(255, 91, 203, 250);  // Icon Blue

                ColorProject_NotSelected_Text = Color.FromArgb(255, 91, 203, 250);        // Icon Blue
                ColorProject_Selected_Text = Color.FromArgb(255, 250, 100, 87);           // Icon Orange

                ColorProfile_NotSelected_Text = Color.FromArgb(255, 150, 150, 255);       // Icon Purple
                ColorProfile_Selected_Text = Color.FromArgb(255, 135, 80, 255);           // Icon Purple (darker)

                ColorStudy_NotSelected_Text = Color.FromArgb(255, 255, 100, 100);         // Light Red
                ColorStudy_Selected_Text = Color.FromArgb(255, 255, 0, 0);                // Red  

                ColorPinch_NotSelected_Text = Color.FromArgb(255, 0, 255, 255);           // Turquiose
                ColorPinch_Selected_Text = Color.FromArgb(255, 0, 230, 230);              // Darker Turquiose

                ColorHen_NotSelected_Text = Color.FromArgb(255, 75, 255, 180);            // Greenish Turquiose
                ColorHen_Selected_Text = Color.FromArgb(255, 0, 230, 130);                // Darker Greenish Turquiose

                ColorFigure_NotSelected_Text = Color.FromArgb(255, 180, 60, 0);           // Brown
                ColorFigure_Selected_Text = Color.FromArgb(255, 150, 50, 0);              // Darker Brown
                #endregion  // STANDARD APPLICATION TEXT COLORS

                #region HEN COMPONENTS (ASSEMBLIES)
                AJP_HEN_COMPONENTS = new List<string>();
                AJP_HEN_COMPONENTS.Clear();
                AJP_HEN_COMPONENTS.Add("_AJP License File.dll");
                AJP_HEN_COMPONENTS.Add("_HenDomainModel.dll");
                AJP_HEN_COMPONENTS.Add("_HenGlobal.dll");
                AJP_HEN_COMPONENTS.Add("_HenModel.dll");
                AJP_HEN_COMPONENTS.Add("_HenStudioDatabase.dll");
                AJP_HEN_COMPONENTS.Add("_HenViewModel.dll");
                AJP_HEN_COMPONENTS.Add("HenStudio.exe");
                #endregion  // HEN COMPONENTS (ASSEMBLIES)
                
                #region LICENSE
                LicenseFileDtoObj = new LicenseFileDto();
                ScoreCardListObj = new ScoreCardList();
                LicenseValidatedFlag = false;
                LicenseTypeEnum = HenTypes.LicenseType.UNKNOWN;
                LicenseStatusEnum = HenTypes.LicenseStatus.UNKNOWN;

                #region LOG LICENSE DATA
                WriteSupplierDataToLog();   // Write Supplier Data to Log
                WriteCustomerDataToLog();   // Write Customer Data to Log
                WriteProductDataToLog();    // Write Product  Data to Log
                #endregion  // LOG LICENSE DATA
                
                #endregion  // LICENSE

                #region SYSTEM DATA
                //AppGlobalSettingsList = new List<AppGlobalSettingsDto>();
                ConnectionDataDtoObj = new ConnectionDataDto();

                DatabaseTableDtoList = new List<DatabaseTableDto>();
                GlobalSettingsDtoList = new List<AppSettingsDto>();
                #endregion  // SYSTEM DATA

                #region INITIAL ROOT-PROJECT-PROFILE-STUDY STATE
                ExplorerSelectedNodeIdEnum = ExplorerNodeIdType.CATALOG;
                CurrentRootName = ROOT_NAME;            // Initially set to ROOT_NAME ("HenStudio")
                CurrentProjectName = string.Empty;      // Initially set to Empty
                CurrentProfileName = string.Empty;      // Initially set to Empty
                CurrentStudyName = string.Empty;        // Initially set to Empty
                #endregion  // INITIAL ROOT-PROJECT-PROFILE-STUDY STATE

                LogCurrentState();      // Log Current INITIAL State
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                //HenLogger.WriteSeparatorLine('=');

                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "HenSettings Object CREATED");
                HenLogger.WriteSeparatorLine('<');
            }
        }
        #endregion      // CTOR

        #region WRITE LOG METHODS

        #region LogCurrentState()
        /// <summary>
        /// Write Current Product - Profile - Pinch - Hen State to Log
        /// </summary>
        private void LogCurrentState()
        {
            string strMethod = "LogCurrentState()";
            try
            {
                HenLogger.WriteSection("CURRENT ROOT - PROJECT - PROFILE - STUDY STATE");

                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " ROOT    : " + CurrentRootName);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " PROJECT : " + CurrentProjectName);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " PROFILE : " + CurrentProfileName);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " STUDY   : " + CurrentStudyName);
                HenLogger.WriteSeparatorLine('=');
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
        #endregion  // LogCurrentState()

        #region WriteProductDataToLog()
        /// <summary>
        /// Write AJP HEN Studio Product Metadata to Log
        /// </summary>
        private void WriteProductDataToLog()
        {
            string strMethod = "WriteProductDataToLog()";
            try
            {
                HenLogger.WriteSection("HEN STUDIO PRODUCT INFORMATION");

                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "[REQUIRED] PRODUCT FULLNAME      : " + AJP_PRODUCT_FULLNAME);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "[REQUIRED] PRODUCT NAME          : " + AJP_PRODUCT_NAME);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "[REQUIRED] PRODUCT VERSION       : " + AJP_PRODUCT_VERSION);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "[REQUIRED] PRODUCT SERIAL_NUMBER : " + AJP_PRODUCT_SERIAL_NUMBER);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "[REQUIRED] PRODUCT CODE          : " + AJP_PRODUCT_CODE);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "----------- COMPONENTS ----------- ");
                foreach(string str in AJP_HEN_COMPONENTS)
                {
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  > " + str);
                }
                //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "----------- COMPONENTS ----------- ");
                //HenLogger.WriteSeparatorLine('=');
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
        #endregion  // WriteProductDataToLog()

        #region WriteSupplierDataToLog()
        /// <summary>
        /// Write AJP HEN Studio Supplier Metadata to Log
        /// </summary>
        private void WriteSupplierDataToLog()
        {
            string strMethod = "WriteSupplierDataToLog()";
            try
            {
                HenLogger.WriteSection("HEN STUDIO SUPPLIER INFORMATION");

                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "[REQUIRED] AJP SUPPLIER NAME    : " + AJP_SUPPLIER_NAME);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "           AJP SUPPLIER URL     : " + AJP_SUPPLIER_URL);

                //HenLogger.WriteSeparatorLine('=');
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
        #endregion  // WriteSupplierDataToLog()

        #region WriteCustomerDataToLog()
        /// <summary>
        /// Write Customer Metadata to Log
        /// </summary>
        private void WriteCustomerDataToLog()
        {
            string strMethod = "WriteCustomerDataToLog()";
            try
            {
                HenLogger.WriteSection("CUSTOMER INFORMATION");

                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "[REQUIRED] CUSTOMER NAME        : " + CUSTOMER_NAME);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "           CUSTOMER EMAIL       : " + CUSTOMER_EMAIL);

                //HenLogger.WriteSeparatorLine('=');
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
        #endregion  // WriteCustomerDataToLog()

        #endregion  // WRITE LOG METHODS

    }
    #endregion      // public class HenSettings
}
#endregion      // namespace HenGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
