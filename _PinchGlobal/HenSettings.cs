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

        #region UNITS STRINGS

        #region UNITS SYSTEM
        //----------------------------------------------------- PINCH UNITS ---
        public const string ENGLISH_UNITS = "ENGLISH";
        public const string METRIC_UNITS = "METRIC";     // <<<--- INTERNAL ---<<<
        #endregion  // UNITS SYSTEM

        #region MAG - MAGNITUDE UNITS
        //------------------------------------------- MAG - MAGNITUDE UNITS ---
        public const string MAG_BASE = "BASE";    // BASE * 10^0
        public const string MAG_KILO = "KILO";    // BASE * 10^3   // <<<--- INTERNAL ---<<<
        public const string MAG_MEGA = "MEGA";    // BASE * 10^6
        #endregion  // MAG - MAGNITUDE UNITS

        #region T - TEMPERATURE UNITS
        //---------------------------------------------- ENGLISH TEMPEATURE ---
        public const string DEG_F = "°F";   // $"\u00B0F";
        public const string DEG_R = "°R";   // $"\u00B0R";
        //----------------------------------------------- METRIC TEMPEATURE ---
        public const string DEG_C = "°C";   // $"\u00B0C";
        public const string KELVIN = "K";   // <<<---------------- INTERNAL ---<<<
        #endregion  // T - TEMPERATURE UNITS

        #region P - PRESSURE UNITS
        //------------------------------------------------ ENGLISH PRESSURE ---
        public const string Psia = "psia";   // "psia  - lbs/in² absolute"
        public const string Psig = "psig";   // "psia  - lbs/in² guage"
        public const string Psfa = "psfa";   // "psia  - lbs/ft² absolute"
        public const string Atm = "atm";     // "atm   - atmosphere"
        public const string InHg = "inHg";   // "inHg  - inches of Mercury"
        public const string InH2O = "inH2O"; // "inH2O - inches of Water"
        //------------------------------------------------- METRIC PRESSURE ---
        public const string Bar = "bar";     // "bar
        public const string KBar = "kBbar";  // "kilo bar"
        public const string MBar = "MBar";   // "Mega bar"
        public const string Pa = "Pa";       // "Pa  - Pascals" 
        public const string kPa = "kPa";     // "kPa - Kilo Pascals" <<<------ INTERNAL ---<<<
        public const string MPa = "MPa";     // "MPa - Mega Pascals"
        #endregion  // P - PRESSURE UNITS

        #region A - AREA UNITS
        //---------------------------------------------------- ENGLISH AREA ---
        public const string SqFt = "ft²";   // "ft\u00B2"
        //----------------------------------------------------- METRIC AREA ---
        public const string SqM = "m²";     // "m\u00B2" <<<------ INTERNAL ---<<<
        #endregion  // A - AREA UNITS

        #region H - HEAT FLOW UNITS
        //------------------------------------------- ENGLISH BTU HEAT FLOW ---
        public const string BTU_HEAT_FLOW = "Btu/hr";
        public const string KBTU_HEAT_FLOW = "kBtu/hr";
        public const string MMBTU_HEAT_FLOW = "MMBtu/hr";
        //---------------------------------------------- METRIC W HEAT FLOW ---
        public const string W_HEAT_FLOW = "W";
        public const string KW_HEAT_FLOW = "kW";    // <<<-------- INTERNAL ---<<<
        public const string MW_HEAT_FLOW = "MW";
        #endregion  // H - HEAT FLOW UNITS

        #region CP - HEAT CAPACITY FLOW RATE UNITS
        //-------------------------------------------------- ENGLISH BTU CP ---
        public const string BTU_F_CP = "Btu/(hr °F)";        // °F
        public const string KBTU_F_CP = "kBtu/(hr °F)";      // °F
        public const string MMBTU_F_CP = "MMBtu/(hr °F)";    // °F
        //---------------------------------------------------------------------
        public const string BTU_R_CP = "Btu/(hr °R)";        // °R
        public const string KBTU_R_CP = "kBtu/(hr °R)";      // °R
        public const string MMBTU_R_CP = "MMBtu/(hr °R)";    // °R

        //----------------------------------------------------- METRIC W CP ---
        public const string W_C_CP = "W/°C";    // °C
        public const string KW_C_CP = "kW/°C";  // °C
        public const string MW_C_CP = "MW/°C"; // °C
        //---------------------------------------------------------------------
        public const string W_K_CP = "W/K";     // K
        public const string KW_K_CP = "kW/K";   // <<<------------ INTERNAL ---<<<
        public const string MW_K_CP = "MW/K";  // K
        #endregion  // CP - HEAT CAPACITY FLOW RATE UNITS

        #region U - OVERALL HEAT TRANSFER COEFFICIENT UNITS
        //--------------------------------------------------- ENGLISH BTU U ---
        public const string BTU_F_U = "Btu/(hr ft² °F)";        // °F
        public const string KBTU_F_U = "kBtu/(hr ft² °F)";      // °F
        public const string MMBTU_F_U = "MMBtu/(hr ft² °F)";    // °F
        //---------------------------------------------------------------------
        public const string BTU_R_U = "Btu/(hr ft² °R)";        // °R
        public const string KBTU_R_U = "kBtu/(hr ft² °R)";      // °R
        public const string MMBTU_R_U = "MMBtu/(hr ft² °R)";    // °R

        //------------------------------------------------------ METRIC W U ---
        public const string W_C_U = "W/(m² °C)";                // °C
        public const string KW_C_U = "kW/(m² °C)";              // °C
        public const string MW_C_U = "MMW/(m² °C)";             // °C
        //---------------------------------------------------------------------
        public const string W_K_U = "W/(m² K)";                 // K
        public const string KW_K_U = "kW/(m² K)";    // <<<------- INTERNAL ---<<<
        public const string MW_K_U = "MMW/(m² K)";              // K
        #endregion  // U - OVERALL HEAT TRANSFER COEFFICIENT UNITS

        #endregion  // UNITS STRINGS

        #region FIELDS

        #region CUSTOMER INFORMATION ... SPECIFIED IN LICENSE FILE
        //---------------------------------------------------------
        //--- Customer Information ... Specifed in License File ---
        //---------------------------------------------------------
        public string CUSTOMER_NAME  = "TBD - REQUIRED!";
        public string CUSTOMER_EMAIL = "TBD";
        #endregion  // CUSTOMER INFORMATION ... SPECIFIED IN LICENSE FILE

        #region HEN COMPONENTS ... ArrayList
        //------------------------------
        //--- HEN Product Components ---
        //------------------------------
        public ArrayList AJP_HEN_COMPONENTS = new ArrayList();
        #endregion  // HEN  COMPONENTS ... ArrayList

        #region LICENSE INFORMATION - SEE LICENSE FILE CLASS
        //-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //--- License Information ... Specified in License File ---
        //-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        #endregion  // LICENSE INFORMATION - SEE LICENSE FILE CLASS

        #endregion      // FIELDS

        #region PROPERTIES

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

        #region PROJECT - PROFILE - PINCH - HEN ... STATE PROPERTIES

        #region ProjectExplorerSelectedLevel
        /// <summary>
        /// Project Explorer Selected Level
        /// </summary>
        public ProjectExplorerLevel ProjectExplorerSelectedLevel { get; set; }  // Project Explorer Selected Level
        #endregion  // ProjectExplorerSelectedLevel

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

        #endregion  // PROJECT - PROFILE - PINCH - HEN ... STATE PROPERTIES

        #region STATUS BAR

        #region CatalogDbConnectedEnum
        /// <summary>
        /// Catalog Database Connected Flag ... [UNKNOWN = -1 | UNCONNECTED = 0 | CONNECTED = 1]
        /// Used in Status Bar display
        /// </summary>
        public HenTypes.DbConnected CatalogDbConnectedEnum { get; set; } // Catalog DB Connected [UNKNOWN | UNCONNECTED | CONNECTED]
        #endregion  // CatalogDbConnectedEnum

        #region ProjectDbConnectedEnum
        /// <summary>
        /// Project Database Connected Flag ... [UNKNOWN = -1 | UNCONNECTED = 0 | CONNECTED = 1]
        /// Used in Status Bar display
        /// </summary>
        public HenTypes.DbConnected ProjectDbConnectedEnum { get; set; } // Project DB Connected [UNKNOWN | UNCONNECTED | CONNECTED]
        #endregion  // DbConnectedEnum

        #region ProjectUnitsEnum
        /// <summary>
        /// Project Units System ... [UNKNOWN = -1 | NA = 0 | ENGLISH = 1 | METRIC = 2 ]
        /// OPEN Project ENGLISH-IMPERIAL Units or METRIC-SI Units
        /// </summary>
        public HenTypes.ProjectUnits ProjectUnitsEnum { get; set; }        // OPEN Project Units [ UNKNOWN | NA | ENGLISH | METRIC ]
        #endregion  // ProjectUnitsEnum

        #endregion  // STATUS BAR

        #region INTERNAL UNITS
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        //-=-=-=-=-=- INTERNAL UNITS PROPERTIES ARE GETTER ONLY -=-=-=-=-=-
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        #region InternalUnitsSystem
        /// <summary>
        /// Internal Units System ... Set to "METRIC"
        /// </summary>
        public string InternalUnitsSystem { get; }      // INTERNAL Units System ... Getter ONLY
        #endregion  // InternalUnitsSystem

        #region InternalMagUnits
        /// <summary>
        /// Internal Magnitude Units ... Set to "KILO" ... (BASE * 10^3)
        /// </summary>
        public string InternalMagUnits { get; }      // INTERNAL Magnitude Units ... Getter ONLY
        #endregion  // InternalMagUnits

        #region InternalHeatFlowUnits
        /// <summary>
        /// Internal Heat Flow Units ... Set to "W"
        /// </summary>
        public string InternalHeatFlowUnits { get; }  // INTERNAL Heat Flow Units ... Getter ONLY
        #endregion  // InternalHeatFlowUnits

        #region InternalTemperatureUnits
        /// <summary>
        /// Internal Temperature Units ... Set to "K"  -  Kelvin
        /// </summary>
        public string InternalTemperatureUnits { get; }      // INTERNAL Temperature Units ... Getter ONLY
        #endregion  // InternalTemperatureUnits

        #region InternalPressureUnits
        /// <summary>
        /// Internal Pressure Units ... Set to "kPa"  -  Kilo Pascals
        /// </summary>
        public string InternalPressureUnits { get; }      // INTERNAL Pressure Units ... Getter ONLY
        #endregion  // InternalPressureUnits

        #region InternalCP_Units
        /// <summary>
        /// Internal CP - Heat Capacity Flow Rate (m*Cp) Units ... Set to "kW/K"
        /// </summary>
        public string InternalCP_Units { get; }   // INTERNAL CP - Heat Capacity Flow Rate (m*Cp) Units ... Getter ONLY
        #endregion  // InternalCP_Units

        #region InternalU_Units
        /// <summary>
        /// Internal U - Overall Heat Transfer Coefficient Units ... Set to "kW/(m² K)"
        /// </summary>
        public string InternalU_Units { get; }   // INTERNAL U - Overall Heat Transfer Coefficient Units ... Getter ONLY
        #endregion  // InternalU_Units

        #region InternalArea_Units
        /// <summary>
        /// Internal A - Area Units ... Set to "m²"
        /// </summary>
        public string InternalArea_Units { get; }   // INTERNAL A - Area Units ... Getter ONLY
        #endregion  // InternalArea_Units

        #endregion  // INTERNAL UNITS

        #region EXTERNAL UNITS
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //-=-=-=-=-=- EXTERNAL UNITS PROPERTIES ARE BOTH GETTER AND SETTER =-=-=-=-=-=
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

        #region ExternalUnitsSystem
        /// <summary>
        /// External Units System ... Set by User Selection (e.g., "ENGLISH")
        /// </summary>
        public string ExternalUnitsSystem { get; set; }      // EXTERNAL Units System
        #endregion  // ExternalUnitsSystem

        #region ExternalMagUnits
        /// <summary>
        /// External Magnitude Units ... Set by User Selection (e.g., "MEGA" - MM ... [BASE * 10^6])
        /// </summary>
        public string ExternalMagUnits { get; set; }      // EXTERNAL Magnitude Units
        #endregion  // ExternalMagUnits

        #region ExternalHeatFlowUnits
        /// <summary>
        /// External Heat Flow Units ... Set by User Selections
        /// User selects System (e.g., ENGLISH), Magnitude (e.g., MEGA-MM) 
        /// Heat Flow External Units constructed based on User Selections (e.g., "MMBtu/hr")
        /// </summary>
        public string ExternalHeatFlowUnits { get; set; }      // EXTERNAL Heat Flow Units
        #endregion  // ExternalHeatFlowUnits

        #region ExternalTemperatureUnits
        /// <summary>
        /// External Temperature Units ... Set to "°F"  -  Fahrenheit
        /// </summary>
        public string ExternalTemperatureUnits { get; set; }      // EXTERNAL Temperature Units
        #endregion  // ExternalTemperatureUnits

        #region ExternalPressureUnits
        /// <summary>
        /// External Pressure Units ... Set to "psia" ... lbs/in² absolute
        /// </summary>
        public string ExternalPressureUnits { get; set; }      // EXTERNAL Temperature Units
        #endregion  // ExternalPressureUnits

        #region ExternalCP_Units
        /// <summary>
        /// Internal CP - Heat Capacity Flow Rate (m*Cp) Units ... Set by User Selections
        /// User selects System (e.g., ENGLISH), Magnitude (e.g., MEGA-MM), and Temperature (e.g., °F)
        /// CP External Units constructed based on User Selections (e.g., "MMBtu/(hr °F)" )
        /// </summary>
        public string ExternalCP_Units { get; set; }   // EXTERNAL CP - Heat Capacity Flow Rate (m*Cp) Units
        #endregion  // ExternalCP_Units

        #region ExternalU_Units
        /// <summary>
        /// Internal U - Overall Heat Transfer Coefficient Units ... Set by User Selections
        /// User selects System (e.g., ENGLISH), Magnitude (e.g., MEGA-MM), and Temperature (e.g., °F)
        /// U External Units constructed based on User Selections (e.g., "MMBtu/(hr ft² °F)"
        /// </summary>
        public string ExternalU_Units { get; set; }   // EXTERNAL U - Overall Heat Transfer Coefficient Units
        #endregion  // ExternalU_Units

        #region ExternalArea_Units
        /// <summary>
        /// External A - Area Units ... Set by User Selections
        /// User selects System (e.g., ENGLISH)
        /// Area (A) External Units constructed based on User Selections (e.g., "ft²")
        /// </summary>
        public string ExternalArea_Units { get; set; }   // EXTERNAL A - Area Units
        #endregion  // ExternalArea_Units

        #endregion  // INTERNAL UNITS

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
                #region HEN COMPONENTS
                AJP_HEN_COMPONENTS.Clear();
                AJP_HEN_COMPONENTS.Add("HenStudio.exe");
                AJP_HEN_COMPONENTS.Add("_AJP License File.dll");
                AJP_HEN_COMPONENTS.Add("_HenDatabase.dll");
                AJP_HEN_COMPONENTS.Add("_HenDomain.dll");
                AJP_HEN_COMPONENTS.Add("_HenGlobal.dll");
                AJP_HEN_COMPONENTS.Add("_HenReport.dll");
                #endregion  // HEN COMPONENTS

                #region LOG LICENSE DATA
                WriteSupplierDataToLog();   // Write Supplier Data to Log
                WriteCustomerDataToLog();   // Write Customer Data to Log
                WriteProductDataToLog();    // Write Product  Data to Log
                #endregion  // LOG LICENSE DATA

                #region INTERNAL UNITS
                InternalUnitsSystem = METRIC_UNITS;     // INTERNAL System:      "METRIC"
                InternalMagUnits = MAG_KILO;            // INTERNAL Magnitude:   "KILO"
                InternalHeatFlowUnits = KW_HEAT_FLOW;   // INTERNAL Heat Flow:   "kW"
                InternalTemperatureUnits = KELVIN;      // INTERNAL Temperature: "K"
                InternalPressureUnits = KELVIN;         // INTERNAL Pressure:    "kPa"
                InternalCP_Units = KW_K_CP;             // INTERNAL CP:          "kW/K"
                InternalU_Units = KW_K_U;               // INTERNAL U:           "kW/(m² K)"
                InternalArea_Units = SqM;               // INTERNAL Area:        "m²"
                WriteInternalUnitsDataToLog();          // Write INTERNAL Units Data to Log
                #endregion  // INTERNAL UNITS

                #region EXTERNAL UNITS
                ExternalUnitsSystem = ENGLISH_UNITS;      // EXTERNAL System:      "ENGLISH"
                ExternalMagUnits = MAG_MEGA;              // EXTERNAL Magnitude:   "MEGA"
                ExternalHeatFlowUnits = MMBTU_HEAT_FLOW;  // EXTERNAL Heat Flow:   "MMBtu/hr"
                ExternalTemperatureUnits = DEG_F;         // EXTERNAL Temperature: "°F"
                ExternalPressureUnits = Psia;             // EXTERNAL Pressure:    "psia"
                ExternalCP_Units = MMBTU_F_CP;            // EXTERNAL CP:          "MMBtu/(hr °F)"
                ExternalU_Units = MMBTU_F_U;              // EXTERNAL U:           "MMBtu/(hr ft² °F)"
                ExternalArea_Units = SqFt;                // EXTERNAL Area:        "ft²"
                WriteExternalUnitsDataToLog();            // Write EXTERNAL Units Data to Log
                #endregion  // EXTERNAL UNITS

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

        #region WriteInternalUnitsDataToLog()
        /// <summary>
        /// Write AJP HEN Studio Internal Units to Log
        /// </summary>
        private void WriteInternalUnitsDataToLog()
        {
            string strMethod = "WriteInternalUnitsDataToLog()";
            try
            {
                HenLogger.WriteSection("INTERNAL UNITS DATA");

                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  INTERNAL System      : " + InternalUnitsSystem);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  INTERNAL Magnitude   : " + InternalMagUnits);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  INTERNAL Heat Flow   : " + InternalHeatFlowUnits);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  INTERNAL Temperature : " + InternalTemperatureUnits);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  INTERNAL CP          : " + InternalCP_Units);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  INTERNAL U           : " + InternalU_Units);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  INTERNAL Area        : " + InternalArea_Units);

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
        #endregion  // WriteInternalUnitsDataToLog()

        #region WriteExternalUnitsDataToLog()
        /// <summary>
        /// Write AJP HEN Studio Internal Units to Log
        /// </summary>
        private void WriteExternalUnitsDataToLog()
        {
            string strMethod = "WriteExternalUnitsDataToLog()";
            try
            {
                HenLogger.WriteSection("EXTERNAL UNITS DATA");

                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  EXTERNAL System      : " + ExternalUnitsSystem);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  EXTERNAL Magnitude   : " + ExternalMagUnits);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  EXTERNAL Heat Flow   : " + ExternalHeatFlowUnits);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  EXTERNAL Temperature : " + ExternalTemperatureUnits);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  EXTERNAL CP          : " + ExternalCP_Units);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  EXTERNAL U           : " + ExternalU_Units);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  EXTERNAL Area        : " + ExternalArea_Units);

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
        #endregion  // WriteExternalUnitsDataToLog()

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
