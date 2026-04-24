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

using HenRepositories.Dto;

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

        #region STANDARD COLORS
        public Color ColorNotSelectedText { get; set; }  // Color.SlateGray;
        public Color ColorCatalogText { get; set; }  // Color.FromArgb(255, 90, 200, 255);     // Light Blue
        public Color ColorProjectText { get; set; }  // Color.FromArgb(255, 255, 100, 0);      // Light Orange
        public Color ColorProfileText { get; set; }  // Color.FromArgb(255, 150, 150, 255);    // Light Purple
        public Color ColorPinchText { get; set; }  // Color.FromArgb(255, 255, 0, 0);          // Red
        public Color ColorHenText { get; set; }  // Color.FromArgb(255, 0, 210, 210);          // Turquiose
        #endregion  // STANDARD COLORS

        #region LICENSE

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

        #region PROJECT - PROFILE - PINCH - HEN ... STATE PROPERTIES ... Used by StatusBar Items

        #region ExplorerSelectedLevelEnum
        /// <summary>
        /// Project Explorer Selected Level Enumeration
        /// </summary>
        public ExplorerLevel ExplorerSelectedLevelEnum { get; set; }  // Project Explorer Selected Level Enumeration
        #endregion  // ExplorerSelectedLevelEnum

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

        #region CurrentPinchName
        /// <summary>
        /// Current Pinch Name
        /// </summary>
        public string CurrentPinchName { get; set; }  // Current Pinch Name
        #endregion  // CurrentPinchName

        #region CurrentHenName
        /// <summary>
        /// Current Hen Name
        /// </summary>
        public string CurrentHenName { get; set; }  // Current Hen Name
        #endregion  // CurrentHenName

        #endregion  // PROJECT - PROFILE - PINCH - HEN ... STATE PROPERTIES ... Used by StatusBar Items

        #region STATUS BAR

        #region DbConnectedEnum
        /// <summary>
        /// HENSTUDIO Database Connected Flag ... [UNKNOWN = -1 | UNCONNECTED = 0 | CONNECTED = 1]
        /// Used in Status Bar display
        /// </summary>
        public HenTypes.DbConnected DbConnectedEnum { get; set; } // HENSTUDIO DB Connected [UNKNOWN | UNCONNECTED | CONNECTED]
        #endregion  // DbConnectedEnum

        #region APPLICATION GLOBAL SETTINGS
        public AppGlobalSettingsDto AppGlobalSettingsObj { get; set; }
        #endregion  // APPLICATION GLOBAL SETTINGS

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
                #region STANDARD COLORS
                ColorNotSelectedText = Color.SlateGray;
                ColorCatalogText = Color.FromArgb(255, 90, 200, 255);     // Light Blue
                ColorProjectText = Color.FromArgb(255, 255, 100, 0);      // Light Orange
                ColorProfileText = Color.FromArgb(255, 150, 150, 255);    // Light Purple
                ColorPinchText = Color.FromArgb(255, 255, 0, 0);          // Red
                ColorHenText = Color.FromArgb(255, 0, 210, 210);          // Turquiose
                #endregion  // STANDARD COLORS

                #region HEN COMPONENTS (ASSEMBLIES)
                AJP_HEN_COMPONENTS = new List<string>();
                AJP_HEN_COMPONENTS.Clear();
                AJP_HEN_COMPONENTS.Add("HenStudio.exe");
                AJP_HEN_COMPONENTS.Add("_AJP License File.dll");
                AJP_HEN_COMPONENTS.Add("_HenDomainModel.dll");
                AJP_HEN_COMPONENTS.Add("_HenGlobal.dll");
                AJP_HEN_COMPONENTS.Add("_HenPersistence.dll");
                AJP_HEN_COMPONENTS.Add("_HenRepositories.dll");
                AJP_HEN_COMPONENTS.Add("_HenViewModels.dll");
                #endregion  // HEN COMPONENTS (ASSEMBLIES)

                #region LOG LICENSE DATA
                WriteSupplierDataToLog();   // Write Supplier Data to Log
                WriteCustomerDataToLog();   // Write Customer Data to Log
                WriteProductDataToLog();    // Write Product  Data to Log
                #endregion  // LOG LICENSE DATA

                #region INITIAL PROJECT-PROFILE-PINCH-HEN STATE
                CurrentProjectName = string.Empty;      // Initially set to Empty
                CurrentProfileName = string.Empty;      // Initially set to Empty
                CurrentPinchName = string.Empty;        // Initially set to Empty
                CurrentHenName = string.Empty;          // Initially set to Empty
                #endregion  // INITIAL PROJECT-PROFILE-PINCH-HEN STATE

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
                HenLogger.WriteSection("CURRENT PRODUCT - PROFILE - PINCH - HEN STATE");

                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " PROJECT : " + CurrentProjectName);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " PROFILE : " + CurrentProfileName);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " PINCH   : " + CurrentPinchName);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, " HEN     : " + CurrentHenName);
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
