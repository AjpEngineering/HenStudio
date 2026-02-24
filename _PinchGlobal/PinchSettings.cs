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
        public const string AJP_PRODUCT_FULLNAME = "AJP Pinch 4.0";
        public const string AJP_PRODUCT_NAME = "AJP Pinch";
        public const string AJP_PRODUCT_VERSION = "4.0.1";
        public const string AJP_PRODUCT_SERIAL_NUMBER = "{6C6D7807-B72E-4460-9D5C-1A911D1299FB}";
        public const string AJP_PRODUCT_CODE = "1022-456-1189";
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

        #region PINCH COMPONENTS ... ArrayList
        //--------------------------------
        //--- Pinch Product Components ---
        //--------------------------------
        public ArrayList AJP_PINCH_COMPONENTS = new ArrayList();
        #endregion  // PINCH COMPONENTS ... ArrayList

        #region LICENSE INFORMATION - SEE LICENSE FILE CLASS
        //-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //--- License Information ... Specified in License File ---
        //-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        #endregion  // LICENSE INFORMATION - SEE LICENSE FILE CLASS

        #region COLORS & FONTS
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
        #endregion  // COLORS & FONTS

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
        public PinchTypes.LicenseType LicenseTypeEnum { get; set; }      // License Type
        #endregion  // LicenseTypeEnum

        #region LicenseStatusEnum
        /// <summary>
        /// License Status ... [EXPIRED = -2 | INVALID = -1 | UNKNOWN = 0 | VALID = 1]
        /// </summary>
        public PinchTypes.LicenseStatus LicenseStatusEnum { get; set; }  // License Status
        #endregion  // LicenseStatusEnum
        #endregion  // LICENSE

        #region STATUS BAR
        #region PinchUnitsEnum
        /// <summary>
        /// Pinch Units System ... [UNKNOWN = -1 | ENGLISH = 0 | METRIC = 1]
        /// ENGLISH-IMPERIAL Units or METRIC-SI Units
        /// </summary>
        public PinchTypes.PinchUnits PinchUnitsEnum { get; set; }        // Pinch Units [ENGLISH | METRIC]
        #endregion  // PinchUnitsEnum

        #region InputValidatedFlag
        /// <summary>
        /// Input Validated Flag
        /// true if Input has been validated - OK to Proceed to Calculate Targets; otherwise false
        /// </summary>
        public bool InputValidatedFlag { get; set; }      // Input   Validated  Flag - true: Proceed to Targets
        #endregion  // InputValidatedFlag

        #region TargetsCalculatedFlag
        /// <summary>
        /// Targets Calculated Flag
        /// true of Targets has been calculated - OK to Proceed to Heat Exchanger Network (HEN) Design; otherwise false
        /// </summary>
        public bool TargetsCalculatedFlag { get; set; }   // Targets Calculated Flag - true: Proceed to HEN
        #endregion  // TargetsCalculatedFlag
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
        public PinchSettings()
        {
            string strMethod = "CTOR";
            PinchLogger.WriteSeparatorLine(' ');
            PinchLogger.WriteSeparatorLine('>');
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating PinchSettings Object");
            try
            {
                #region PINCH COMPONENTS
                AJP_PINCH_COMPONENTS.Clear();
                AJP_PINCH_COMPONENTS.Add("Pinch.exe");
                AJP_PINCH_COMPONENTS.Add("_AJP License File.ll");
                AJP_PINCH_COMPONENTS.Add("_PinchData.dll");
                AJP_PINCH_COMPONENTS.Add("_PinchFigures.dll");
                AJP_PINCH_COMPONENTS.Add("_PinchGlobal.dll");
                AJP_PINCH_COMPONENTS.Add("_PinchHen.dll");
                AJP_PINCH_COMPONENTS.Add("_PinchReports.dll");
                AJP_PINCH_COMPONENTS.Add("_PinchTargets.dll");
                #endregion  // PINCH COMPONENTS

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

            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                PinchLogger.WriteSeparatorLine('=');

                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "PinchSettings Object CREATED");
                PinchLogger.WriteSeparatorLine('<');
            }
        }
        #endregion      // CTOR

        #region WRITE LOG METHODS

        #region WriteInternalUnitsDataToLog()
        /// <summary>
        /// Write AJP Pinch Internal Units to Log
        /// </summary>
        private void WriteInternalUnitsDataToLog()
        {
            string strMethod = "WriteInternalUnitsDataToLog()";
            try
            {
                PinchLogger.WriteSection("INTERNAL UNITS DATA");

                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  INTERNAL System      : " + InternalUnitsSystem);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  INTERNAL Magnitude   : " + InternalMagUnits);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  INTERNAL Heat Flow   : " + InternalHeatFlowUnits);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  INTERNAL Temperature : " + InternalTemperatureUnits);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  INTERNAL CP          : " + InternalCP_Units);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  INTERNAL U           : " + InternalU_Units);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  INTERNAL Area        : " + InternalArea_Units);

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
        #endregion  // WriteInternalUnitsDataToLog()

        #region WriteExternalUnitsDataToLog()
        /// <summary>
        /// Write AJP Pinch Internal Units to Log
        /// </summary>
        private void WriteExternalUnitsDataToLog()
        {
            string strMethod = "WriteExternalUnitsDataToLog()";
            try
            {
                PinchLogger.WriteSection("EXTERNAL UNITS DATA");

                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  EXTERNAL System      : " + ExternalUnitsSystem);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  EXTERNAL Magnitude   : " + ExternalMagUnits);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  EXTERNAL Heat Flow   : " + ExternalHeatFlowUnits);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  EXTERNAL Temperature : " + ExternalTemperatureUnits);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  EXTERNAL CP          : " + ExternalCP_Units);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  EXTERNAL U           : " + ExternalU_Units);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "  EXTERNAL Area        : " + ExternalArea_Units);

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
        #endregion  // WriteExternalUnitsDataToLog()

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
        #endregion  // WriteProductDataToLog()

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

        #endregion  // WRITE LOG METHODS

    }
    #endregion      // public class PinchSettings
}
#endregion      // namespace PinchGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
