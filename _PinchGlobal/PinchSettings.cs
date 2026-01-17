#region HEADER
//#####################################################################################################################
//########################################  P i n c h S e t t i n g s . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  PinchSettings.cs
//  NAMESPACE: PinchGlobal
//  CLASS(S):  PinchSettings
//  COMPONENT: _PinchGLobal.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Global Pinch Settings.
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
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace PinchGlobal
namespace PinchGlobal
{
    #region public class PinchSettings
    /// <summary>
    /// Global Pinch Settings Class
    /// </summary>
    public class PinchSettings
    {
        #region CONSTANTS
        const string NAMESPACE = "PinchGlobal";
        const string CLASS = "PinchSettings";

        //-------------------------------------------------------------------------------
        //--- Supplier Information ... Check Against What is Supplied in License File ---
        //-------------------------------------------------------------------------------
        public const string AJP_SUPPLIER_NAME = "AJP Engineering";
        public const string AJP_SUPPLIER_URL = "http:://www.AJPEngineering.com";
        //------------------------------------------------------------------------------
        //--- Product Information ... Check Against What is Supplied in License File ---
        //------------------------------------------------------------------------------
        public const string AJP_PRODUCT_FULLNAME = "AJP Pinch 4.0";
        public const string AJP_PRODUCT_NAME = "AJP Pinch";
        public const string AJP_PRODUCT_VERSION = "4.0.1";
        public const string AJP_PRODUCT_SERIAL_NUMBER = "{6C6D7807-B72E-4460-9D5C-1A911D1299FB}";
        public const string AJP_PRODUCT_CODE = "1022-456-1189";
        //--------------------
        //--- REPORT SPECS ---
        //--------------------
        public const int LINE_LEN = 80;  // Report Line Length in Number of Characters (Courier New, 11 pt, Regular)
        #endregion      // CONSTANTS

        #region FIELDS

        #region PUBLIC
        //---------------------------------------------------------
        //--- Customer Information ... Specifed in License File ---
        //---------------------------------------------------------
        public string CUSTOMER_NAME  = "TBD - REQUIRED!";
        public string CUSTOMER_EMAIL = "TBD";

        //--------------------------------
        //--- Pinch Product Components ---
        //--------------------------------
        public ArrayList AJP_PINCH_COMPONENTS = new ArrayList();

        //---------------------------------------------------------
        //--- License Information ... Specified in License File ---
        //---------------------------------------------------------

        //--------------
        //--- Colors ---
        //--------------
        public Color AJP_ENGINEERING_GREEN = Color.FromArgb(255, 0, 204, 153);   // Caribbean Green
        public Color AJP_ENGINEERING_ORANGE = Color.FromArgb(255, 255, 153, 0);  // Vivid Gamboge
        public Color AJP_PINCH_RED_ORANGE = Color.FromArgb(255, 255, 83, 73);    // Red-Orange
        public Color AJP_PINCH_SKY_BLUE = Color.FromArgb(255, 0, 191, 255);      // Deep Sky Blue
        //-------------
        //--- Fonts ---
        //-------------
        public Font AJP_PINCH_DISPLAY_FONT = new Font("Segoe UI Variable Display", 10.0f); // Display
        public Font AJP_PINCH_MONO_FONT = new Font("Cascadia Mono", 9.0f);              // Monospace for Numbers

        #endregion  // PUBLIC

        #region PRIVATE
        private bool _bLicenseValidated;                    // License Validate Flag
        private PinchTypes.LicenseType _licTypeEnum;        // License Type
        private PinchTypes.LicenseStatus _licStatusEnum;    // license Status

        private bool _bInputValidated;      // Input   Validated  Flag - true: Proceed to Targets
        private bool _bTargetsCalculated;   // Targets Calculated Flag - true: Proceed to HEN

        #endregion  // PRIVATE

        #endregion      // FIELDS

        #region PROPERTIES

        #region InputValidatedFlag
        /// <summary>
        /// InputValidatedFlag Property
        /// </summary>
        public bool InputValidatedFlag
        {
            get { return _bInputValidated; }
            set { _bInputValidated = value; }
        }
        #endregion      // InputValidatedFlag

        #region TargetsCalculatedFlag
        /// <summary>
        /// TargetsCalculatedFlag Property
        /// </summary>
        public bool TargetsCalculatedFlag
        {
            get { return _bTargetsCalculated; }
            set { _bTargetsCalculated = value; }
        }
        #endregion      // TargetsCalculatedFlag

        #region LicenseValidatedFlag
        /// <summary>
        /// LicenseValidatedFlag Property
        /// </summary>
        public bool LicenseValidatedFlag
        {
            get { return _bLicenseValidated; }
            set { _bLicenseValidated = value; }
        }
        #endregion      // LicenseValidatedFlag

        #region LicenseTypeEnum
        /// <summary>
        /// LicenseTypeEnum Property
        /// </summary>
        public PinchTypes.LicenseType LicenseTypeEnum
        {
            get { return _licTypeEnum; }
            set { _licTypeEnum = value; }
        }
        #endregion      // LicenseTypeEnum

        #region LicenseStatusEnum
        /// <summary>
        /// LicenseStatusEnum Property
        /// </summary>
        public PinchTypes.LicenseStatus LicenseStatusEnum
        {
            get { return _licStatusEnum; }
            set { _licStatusEnum = value; }
        }
        #endregion      // LicenseStatusEnum

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public PinchSettings()
        {
            string strMethod = "CTOR";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating Object");

            //------------------------
            //--- GET LICENSE DATA ---
            //------------------------
            // TBD: Read License File (XML to Data Object)
            // TBD: Compare License Data to Specified Supplier, Customer, Product, License Type, License Key
            //-----------------------------------------------------------------------------------------------

            //------------------------
            //--- PINCH COMPONENTS ---
            //------------------------
            AJP_PINCH_COMPONENTS.Clear();
            AJP_PINCH_COMPONENTS.Add("Pinch.exe");
            AJP_PINCH_COMPONENTS.Add("_PinchData.dll");
            AJP_PINCH_COMPONENTS.Add("_PinchFigures.dll");
            AJP_PINCH_COMPONENTS.Add("_PinchGlobal.dll");
            AJP_PINCH_COMPONENTS.Add("_PinchHen.dll");
            AJP_PINCH_COMPONENTS.Add("_PinchReports.dll");
            AJP_PINCH_COMPONENTS.Add("_PinchTargets.dll");

            WriteSupplierDataToLog();   // Write Supplier Data to Log
            WriteCustomerDataToLog();   // Write Customer Data to Log
            WriteProductDataToLog();    // Write Product  Data to Log
        }
        #endregion      // CTOR

        #region WRITE LOG METHODS

        #region WriteSupplierDataToLog()
        /// <summary>
        /// Write AJP Pinch Supplier Metadata to Log
        /// </summary>
        private void WriteSupplierDataToLog()
        {
            string strMethod = "WriteSupplierDataToLog()";
            try
            {
                PinchLogger.WriteSection("PINCH SUPPLIER INFORMATION");

                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "[REQUIRED] AJP SUPPLIER NAME    : " + AJP_SUPPLIER_NAME);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "           AJP SUPPLIER URL     : " + AJP_SUPPLIER_URL);

                //PinchLogger.WriteSeparatorLine('=');
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
                PinchLogger.WriteSection("CUSTOMER INFORMATION");

                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "[REQUIRED] CUSTOMER NAME        : " + CUSTOMER_NAME);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "           CUSTOMER EMAIL       : " + CUSTOMER_EMAIL);

                //PinchLogger.WriteSeparatorLine('=');
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
        #endregion  // WriteCustomerDataToLog()

        #region WriteProductDataToLog()
        /// <summary>
        /// Write AJP Pinch Product Metadata to Log
        /// </summary>
        private void WriteProductDataToLog()
        {
            string strMethod = "WriteProductDataToLog()";
            try
            {
                PinchLogger.WriteSection("PINCH PRODUCT INFORMATION");

                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "[REQUIRED] PRODUCT FULLNAME      : " + AJP_PRODUCT_FULLNAME);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "[REQUIRED] PRODUCT NAME          : " + AJP_PRODUCT_NAME);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "[REQUIRED] PRODUCT VERSION       : " + AJP_PRODUCT_VERSION);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "[REQUIRED] PRODUCT SERIAL_NUMBER : " + AJP_PRODUCT_SERIAL_NUMBER);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "[REQUIRED] PRODUCT CODE          : " + AJP_PRODUCT_CODE);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "----------- COMPONENTS ----------- ");
                foreach(string str in AJP_PINCH_COMPONENTS)
                {
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  > " + str);
                }
                //PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "----------- COMPONENTS ----------- ");
                PinchLogger.WriteSeparatorLine('=');
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
        #endregion  // WriteProductDataToLog()

        #endregion  // WRITE LOG METHODS

    }
    #endregion      // public class PinchSettings
}
#endregion      // namespace PinchGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
