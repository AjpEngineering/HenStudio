#region HEADER
//#####################################################################################################################
//###########################################  H e n M e t h o d s . c s  #############################################
//#####################################################################################################################
//  FILENAME:  HenMethods.cs
//  NAMESPACE: HenGlobal
//  CLASS(S):  HenMethods
//  COMPONENT: _HenGLobal.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Common HEN Studio Methods (static).
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
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

using static HenGlobal.HenProjectUnits;

#endregion  // REFERENCES

#region namespace HenGlobal
namespace HenGlobal
{
    #region public class HenMethods
    /// <summary>
    /// Common Global HEN Studio Methods Class
    /// Contains String Checks, Hash, and Units Conversion methods
    /// </summary>
    public class HenMethods
    {
        #region CONSTANTS
        const string NAMESPACE = "HenGlobal";
        const string CLASS = "HenMethods";

        #endregion      // CONSTANTS

        #region PROPERTIES

        #region HenSettingsObj
        /// <summary>
        /// HenSettings Object
        /// </summary>
        public HenSettings HenSettingsObj { get; set; }   // HenSettings Object
        #endregion  // HenSettingsObj   
        
        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor...NO CTOR for STATIC CLASS
        /// </summary>
        public HenMethods(HenSettings pinchSettingsObj)
        {
            string strMethod = "CTOR";
            HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating Object");
            //-------------------------
            //--- Assign Properties ---
            //-------------------------
            HenSettingsObj = pinchSettingsObj;
        }
        #endregion      // CTOR

        #region public static CheckForEquality()
        /// <summary>
        /// Check if two double numbers are equal
        /// Equal here means the two double values are with a specifed tolernce value
        /// Difference is rounded to 5 digits
        /// Default tolerance is 0.001 - may be overidden by user on method signature
        /// </summary>
        /// <param name="dValue1">double value 1</param>
        /// <param name="dValue2">double value 2</param>
        /// <param name="dTolerance">tolerance value; default to 0.001</param>
        /// <returns>true if two numbers are within tolerance; otherwise false</returns>
        public static bool CheckForEquality(double dValue1, 
                                            double dValue2,
                                            double dTolerance = 0.001)
        {
            bool bEqual = false;

            double dDiff = Math.Abs(dValue2 - dValue1);

            if (Math.Round(dDiff, 5) < dTolerance) return true;
            else return bEqual;
        }
        #endregion  // public static CheckForEquality()

        #region STATIC STRING VALUE CHECK STATIC METHODS

        #region StringCheckIsNull ... CHECK ID: CHECK_NULL
        /// <summary>
        /// CHECK ID: CHECK_NULL
        /// Check if String is Null or Empty
        /// </summary>
        /// <param name="strVal">String to check</param>
        /// <returns>true if String is Null or Empty</returns>
        public static bool StringCheckIsNull(string strVal)
        {
            if (strVal == null) return true;            // String is NULL               (true)
            else if (strVal.Length == 0) return true;   // String is Empty              (true)
            else return false;                          // String is Not NULL or Empty (false)
        }
        #endregion      // StringCheckIsNull ... CHECK ID: CHECK_NULL

        #region StringCheckIsNA ... CHECK ID: CHECK_NA
        /// <summary>
        /// CHECK ID: CHECK_NA
        /// Check if String is "NA" 
        /// </summary>
        /// <param name="strVal">String to check</param>
        /// <returns>true if strVal is "NA"</returns>
        public static bool StringCheckIsNA(string strVal)
        {
            if (string.Compare(strVal, "NA", true) == 0) return true;  // String is "NA"      (true)
            else return false;                                         // String is NOT "NA" (false)
        }
        #endregion      // StringCheckIsNA ... CHECK ID: CHECK_NA

        #region StringCheckIsDouble ... CHECK ID: CHECK_DOUBLE 
        /// <summary>
        /// CHECK ID: CHECK_DOUBLE 
        /// Check if String is a double
        /// </summary>
        /// <param name="strVal">String to check</param>
        /// <returns>return true if strVal is a double)</returns>
        public static bool StringCheckIsDouble(string strVal)
        {
            double dVal = 0.00;
            if (StringCheckIsNull(strVal)) return false;  // String is NULL   (false)
            else return double.TryParse(strVal, out dVal); // String is double (true | false)
        }
        #endregion      // StringCheckIsDouble ... CHECK ID: CHECK_DOUBLE 

        #region StringCheckIsDoublePositive ... CHECK ID: CHECK_DOUBLE_POSITIVE
        /// <summary>
        /// CHECK ID: CHECK_DOUBLE_POSITIVE 
        /// Check if String is a positive double value (greater than zero)
        /// </summary>
        /// <param name="strVal">String to check</param>
        /// <returns>true if strVal is a Positive double Number</returns>
        public static bool StringCheckIsDoublePositive(string strVal)
        {
            if (StringCheckIsDouble(strVal))    // Check if Double
            {
                if (Convert.ToDouble(strVal) > 0.000) return true;   // String is Positive double (true)
                else return false;                                   // String is Non-Positive   (false)
            }
            else return false;      // String is Not a double  (false)
        }
        #endregion      // StringCheckIsDoublePositive ... CHECK ID: CHECK_DOUBLE_POSITIVE

        #region StringCheckIsDoubleNonNegative ... CHECK ID: CHECK_DOUBLE_NON_NEGATIVE
        /// <summary>
        /// CHECK ID: CHECK_DOUBLE_NON_NEGATIVE 
        /// Check if String is a non-negative double value (greater than or equal to zero)
        /// </summary>
        /// <param name="strVal">String to check</param>
        /// <returns>true if strVal is a Non-Negative double Number</returns>
        public static bool StringCheckIsDoubleNonNegative(string strVal)
        {
            if (StringCheckIsDouble(strVal))    // Check if Double
            {
                if (Convert.ToDouble(strVal) >= 0.000) return true;   // String is Non-Negative double (true)
                else return false;                                    // String is Negative double    (false)
            }
            else return false;      // String is Not a double  (false)
        }
        #endregion      // StringCheckIsDoubleNonNegative ... CHECK ID: CHECK_DOUBLE_NON_NEGATIVE

        #region StringCheckIsDoubleNegative ... CHECK ID: CHECK_DOUBLE_NEGATIVE
        /// <summary>
        /// CHECK ID: CHECK_DOUBLE_NEGATIVE 
        /// Check if String is a negative double value (less than zero)
        /// </summary>
        /// <param name="strVal">String to check</param>
        /// <returns>true if strVal is a Negative double Number</returns>
        public static bool StringCheckIsDoubleNegative(string strVal)
        {
            if (StringCheckIsDouble(strVal))    // Check if Double
            {
                if (Convert.ToDouble(strVal) < 0.000) return true;   // String is Negative double (true)
                else return false;                                   // String is Non-Negative   (false)
            }
            else return false;      // String is Not a double  (false)
        }
        #endregion      // StringCheckIsDoubleNegative ... CHECK ID: CHECK_DOUBLE_NEGATIVE

        #region StringCheckIsDoubleNonPositive ... CHECK ID: CHECK_DOUBLE_NON_POSITIVE
        /// <summary>
        /// CHECK ID: CHECK_DOUBLE_NON_POSITIVE 
        /// Check if String is a non-positive double value (less than or equal to zero)
        /// </summary>
        /// <param name="strVal">String to check</param>
        /// <returns>true if strVal is a Non-Positive double Number</returns>
        public static bool StringCheckIsDoubleNonPositive(string strVal)
        {
            if (StringCheckIsDouble(strVal))    // Check if Double
            {
                if (Convert.ToDouble(strVal) <= 0.000) return true;   // String is Non-Positive double (true)
                else return false;                                    // String is Positive double    (false)
            }
            else return false;      // String is Not a double  (false)
        }
        #endregion      // StringCheckIsDoubleNonPositive ... CHECK ID: CHECK_DOUBLE_NON_POSITIVE

        #endregion      // STATIC STRING VALUE CHECK STATIC METHODS

        #region STATIC HASH METHODS
        //=============================================================================================================
        //----------------------------------------------- HASH METHODS ------------------------------------------------
        //=============================================================================================================

        #region static ComputeSha256Hash
        /// <summary>
        /// Perform SHA-256 HASH on User Provided rawData string
        /// Returns 64 Character Hash String
        /// </summary>
        /// <param name="rawData">Raw Input Data String</param>
        /// <returns>64-char Hash String on success; Empty string otherwise</returns>
        public static string ComputeSha256Hash(string rawData)
        {
            string strMethod = "ComputeSha256Hash";
            string strMsg = String.Empty;
            string strHash = String.Empty;
            try
            {
                rawData += "_fugacity_";    // Salt String
                //------------------------------
                //--- Create a SHA256 Object ---
                //------------------------------
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    //------------------------------------------
                    //--- ComputeHash - Returns a byte Array ---
                    //------------------------------------------
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                    //--------------------------------------
                    //--- Convert byte Array to a string ---
                    //--------------------------------------
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    strHash = builder.ToString();
                }
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            //---------------------------------
            //--- Return Hash String Result ---
            //---------------------------------
            return strHash;
        }
        #endregion      // static ComputeSha256Hash

        #region static Extract32CharHash
        /// <summary>
        /// Extract 32 Characters from the User Provided HASH
        /// Returns 32 Character Hash String
        /// </summary>
        /// <param name="str64Hash">Full 64-Char Hash String</param>
        /// <param name="nIndex">Start Index of Substring ... must be less than 32</param>
        /// <returns>32-char Hash String on success; Empty string otherwise</returns>
        public static string Extract32CharHash(string str64Hash, int nIndex)
        {
            string strMethod = "Extract32CharHash";
            string strMsg = String.Empty;
            string str32Hash = String.Empty;
            int nStartIndex = 0;    // Start Index of Substring
            int nLength = 32;       // Length of Substring
            try
            {
                //-----------------------------
                //--- Determine Start Index ---
                //-----------------------------
                nStartIndex = nIndex;
                str32Hash = str64Hash.Substring(nStartIndex, nLength);
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            //--------------------------------------------
            //--- Return 32-Char Substring Hash Result ---
            //--------------------------------------------
            return str32Hash;
        }
        #endregion      // static Extract32CharHash

        #region staticFormatExtractedString
        /// <summary>
        /// Format Inputted Extracted 32 Character String
        /// Returns Formatted 32-Char License Key String
        /// </summary>
        /// <param name="str32Extracted">Extracted 32-Char String</param>
        /// <returns>Formatted 32-Char License Key String on success; Empty string otherwise</returns>
        public static string FormatExtractedString(string str32Extracted)
        {
            string strMethod = "FormatExtractedString";
            string strMsg = String.Empty;
            string strTemp = String.Empty;
            try
            {
                strTemp = str32Extracted;

                int pos = 0;
                char replacement = 'A';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 1;
                replacement = 'J';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 2;
                replacement = 'P';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 3;
                replacement = '-';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 8;
                replacement = '-';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 13;
                replacement = '-';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 18;
                replacement = '-';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 23;
                replacement = '-';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 28;
                replacement = '-';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 29;
                replacement = 'E';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 30;
                replacement = 'N';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 31;
                replacement = 'G';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                //------------------------------------------
                //--- Ensure All Letters are Uppder Case ---
                //------------------------------------------
                strTemp = strTemp.ToUpper();
                //--------------------------------------------------------
                //--- Remove Extraneous Leading or Trailing Whitespace ---
                //--------------------------------------------------------
                strTemp = strTemp.Trim();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            //---------------------------------------------------
            //--- Return Formatted 32-Char License Key Result ---
            //---------------------------------------------------
            return strTemp;
        }
        #endregion      // static FormatExtractedString

        #endregion  // STATIC HASH METHODS

        #region UNITS CONVERSION METHODS

        #region ConvertToInternal()
        /// <summary>
        /// Convert External data value in External Units to Internal data value in Internal Units
        /// Internal units are used by the Pinch Targets and Hen Engines.
        /// External units are customer facing, i.e., UI Project units (controls)
        /// External Units are set by the user in the New Project Form & Project Panel controls
        /// Internal units are set on initial construction and do not change
        /// User Provides an Internal and External HenProjectUnit Object identifying the INTERNAL
        /// and EXTERNAL units
        /// </summary>
        /// <param name="enumConType">Conversion Units Enumeration Type [HenTypes]</param>
        /// <param name="dExternalValue">External Value to be converted</param>
        /// <param name="EXTERNAL_UnitsObj">EXTERNAL Units object</param>
        /// <param name="INTERNAL_UnitsObj">INTERNAL Units object</param>
        /// <returns>Converted internal value now in internal units</returns>
        public double ConvertToInternal(HenTypes.ConversionUnitsTypes enumConType,
                                        double dExternalValue, 
                                        HenProjectUnits EXTERNAL_UnitsObj,
                                        HenProjectUnits INTERNAL_UnitsObj)
        {
            string strMethod = "ConvertToInternal";
            string strMsg = String.Empty;
            double dInternalValue = -1.0;
            try
            {
                switch (enumConType)
                {
                    #region A - AREA
                    //-----------------------------------------------------------------------------
                    //--- Area - A is (ft²) for ENGLISH and (m²) for METRIC
                    //-----------------------------------------------------------------------------
                    //--- User selects [ENGLISH | METRIC]
                    //---   - Area is set to [ft²] for ENGLISH | [m²]  for METRIC
                    //-----------------------------------------------------------------------------
                    //--- For Conversion: Use Area Units to determine [ METRIC | ENGLISH ]
                    //-----------------------------------------------------------------------------
                    case HenTypes.ConversionUnitsTypes.A:
                        if (string.Compare(INTERNAL_UnitsObj.GetAreaString(),
                                           EXTERNAL_UnitsObj.GetAreaString(), true) == 0)
                        {
                            //--- No Need for Conversion Already set to (m²)! ---
                            dInternalValue = dExternalValue;
                        }
                        else
                        {
                            //--- Convert ft² to m² ---
                            dInternalValue = dExternalValue * 0.09290313;
                        }
                        break;
                    #endregion  // A- AREA

                    #region T - TEMPERATURE
                    //-----------------------------------------------------------------------------
                    //--- Temperature - T is [(°F) | (°R)] for ENGLISH and [(°C) | (K)] for METRIC
                    //-----------------------------------------------------------------------------
                    //--- User selects [ENGLISH | METRIC]
                    //--- User selects Temperature [(°F) | (°R)] for ENGLISH
                    //---                      and [(°C) | (K)]  for METRIC
                    //-----------------------------------------------------------------------------
                    case HenTypes.ConversionUnitsTypes.TEMP:
                        if (string.Compare(INTERNAL_UnitsObj.GetTemperatureString(),
                                           EXTERNAL_UnitsObj.GetTemperatureString(), true) == 0)
                        {
                            //--- No Need for Conversion - Already (K)! ---
                            dInternalValue = dExternalValue;
                        }
                        else
                        {
                            //--- Convert External Temperature Units to Internal Temperature Units (K) ---
                            switch (EXTERNAL_UnitsObj.GetTemperatureString())
                            {
                                case HenProjectUnits.DEG_F:
                                    //--- Convert [ (°F) to (K)] ] ---
                                    dInternalValue = ((dExternalValue - 32.0) / 1.8) + 273.15;
                                    break;
                                case HenProjectUnits.DEG_R:
                                    //--- Convert [ (°R) to (K)] ] ---
                                    dInternalValue = ((dExternalValue - 491.67) / 1.8) + 273.15;
                                    break;
                                case HenProjectUnits.DEG_C:
                                    //--- Convert [ (°C) to (K)] ] ---
                                    dInternalValue = (dExternalValue + 273.15);
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Temperature Units ENCOUNTERED!  {0}",
                                                            EXTERNAL_UnitsObj.GetTemperatureString());
                                    throw new Exception(strMsg);
                            }
                        }
                        break;
                    #endregion  // T - TEMPERATURE

                    #region P - PRESSURE
                    //-----------------------------------------------------------------------------
                    //--- Pressure - P is [ psia | psia | psf  | atm | inHg | inH2O) ] for ENGLISH
                    //---             and [ bar  | kBar | MBar | Pa  | kPa  | MPa    ] for METRIC
                    //-----------------------------------------------------------------------------
                    //--- User selects [ENGLISH | METRIC]
                    //--- User selects Pressure [ psia | psia | psf  | atm | inHg | inH2O) ] for ENGLISH
                    //---                   and [ bar  | kBar | MBar | Pa  | kPa  | MPa    ] for METRIC
                    //-----------------------------------------------------------------------------
                    case HenTypes.ConversionUnitsTypes.PRESS:
                        if (string.Compare(INTERNAL_UnitsObj.GetPressureString(),
                                           EXTERNAL_UnitsObj.GetPressureString(), true) == 0)
                        {
                            //--- No Need for Conversion - Already (kPa)! ---
                            dInternalValue = dExternalValue;
                        }
                        else
                        {
                            //--- Convert External Pressure Units to Internal Pressure Units (KPa) ---
                            switch (EXTERNAL_UnitsObj.GetPressureString())
                            {
                                case HenProjectUnits.Psia:
                                    //--- Convert [ (psia) to (KPa)] ] ---
                                    dInternalValue = dExternalValue * 6.894765;
                                    break;
                                case HenProjectUnits.Psig:
                                    //--- Convert [ (psig) to (KPa)] ] ---
                                    dInternalValue = (dExternalValue + 14.6959) * 6.894765;
                                    break;
                                case HenProjectUnits.Psfa:
                                    //--- Convert [ (psfa) to (KPa)] ] ---
                                    dInternalValue = dExternalValue * 0.0478803;
                                    break;
                                case HenProjectUnits.Atm:
                                    //--- Convert [ (atm) to (KPa)] ] ---
                                    dInternalValue = dExternalValue * 101.325;
                                    break;
                                case HenProjectUnits.InHg:
                                    //--- Convert [ (inHg) to (KPa)] ] ---
                                    dInternalValue = dExternalValue * 3.38639;
                                    break;
                                case HenProjectUnits.InH2O:
                                    //--- Convert [ (inH2O) to (KPa)] ] ---
                                    dInternalValue = dExternalValue * 0.24908213;
                                    break;
                                //-----------------------------------------------------------------
                                case HenProjectUnits.Bar:
                                    //--- Convert [ (bar) to (KPa)] ] ---
                                    dInternalValue = dExternalValue * 100.0;
                                    break;
                                case HenProjectUnits.KBar:
                                    //--- Convert [ (kBar) to (KPa)] ] ---
                                    dInternalValue = dExternalValue * 100000.0;
                                    break;
                                case HenProjectUnits.MBar:
                                    //--- Convert [ (MBar) to (KPa)] ] ---
                                    dInternalValue = dExternalValue * 100000000.0;
                                    break;
                                case HenProjectUnits.Pa:
                                    //--- Convert [ (Pa) to (KPa)] ] ---
                                    dInternalValue = dExternalValue * 0.001;
                                    break;
                                case HenProjectUnits.MPa:
                                    //--- Convert [ (MPa) to (KPa)] ] ---
                                    dInternalValue = dExternalValue * 1000.0;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Pressure Units ENCOUNTERED!  {0}",
                                                            EXTERNAL_UnitsObj.GetPressureString());
                                    throw new Exception(strMsg);
                            }
                        }
                        break;
                    #endregion  // P - PRESSURE

                    #region H - HEAT FLOW 
                    //-----------------------------------------------------------------------------
                    //--- Heat Flow is [(Btu/hr) | (kBtu/hr) | (MMBtu/hr)] for ENGLISH
                    //---          and [(W)      | (kW)      | (MW)      ] for METRIC
                    //-----------------------------------------------------------------------------
                    //--- User selects System [ENGLISH | METRIC]
                    //--- User selects Magnitude [BASE | KILO | MEGA]
                    //---   - Heat Flow is set to [(Btu/hr) | (kBtu/hr) | (MMBtu/hr)] for ENGLISH
                    //---                      or [(W)      | (kW)      | (MW)      ] for METRIC
                    //-----------------------------------------------------------------------------
                    //--- For Conversion: Use System Units to determine [ METRIC | ENGLISH ]
                    //--- Then Determine Magnitude for Conversions
                    //-----------------------------------------------------------------------------
                    case HenTypes.ConversionUnitsTypes.HEAT_FLOW:
                        if (string.Compare(INTERNAL_UnitsObj.GetSystemUnitsString(),
                                           EXTERNAL_UnitsObj.GetSystemUnitsString(), true) == 0)
                        {
                            #region METRIC
                            //----------------------------------------------------------
                            //--- Convert External Heat Flow Units (W) | (kW) | (MW) ---
                            //--- to Internal Heat Flow Units (kW)                   ---
                            //----------------------------------------------------------
                            switch (EXTERNAL_UnitsObj.GetMagnitudeString())
                            {
                                case HenProjectUnits.MAG_BASE:
                                    //--- Convert W to kW ---
                                    dInternalValue = dExternalValue * 0.001;
                                    break;
                                case HenProjectUnits.MAG_KILO:
                                    //--- No Conversion Needed - Already (kW) ! ---
                                    dInternalValue = dExternalValue;
                                    break;
                                case HenProjectUnits.MAG_MEGA:
                                    //--- Convert MW to kW ---
                                    dInternalValue = dExternalValue * 1000.0;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            EXTERNAL_UnitsObj.GetMagnitudeString());
                                    throw new Exception(strMsg);
                            }
                            #endregion  // METRIC
                        }
                        else
                        {
                            #region ENGLISH
                            //--------------------------------------------------------------------------
                            //--- Convert External Heat Flow Units (Btu/hr) | (kBtu/hr) | (MMBtu/hr) ---
                            //--- to Internal Heat Flow Units (kW)                                   ---
                            //--------------------------------------------------------------------------
                            switch (EXTERNAL_UnitsObj.GetMagnitudeString())
                            {
                                case HenProjectUnits.MAG_BASE:
                                    //--- Convert (Btu/hr) to (kW) ---
                                    dInternalValue = dExternalValue * 0.000293071;
                                    break;
                                case HenProjectUnits.MAG_KILO:
                                    //--- Convert kBtu/hr) to (kW) ---
                                    dInternalValue = dExternalValue * 0.293071071;
                                    break;
                                case HenProjectUnits.MAG_MEGA:
                                    //--- Convert (MMBtu/hr) to (kW) ---
                                    dInternalValue = dExternalValue * 293.071071;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            EXTERNAL_UnitsObj.GetMagnitudeString());
                                    throw new Exception(strMsg);
                            }
                            #endregion  // ENGLISH
                        }
                        break;
                    #endregion  // H - HEAT FLOW

                    #region CP - HEAT CAPACITY FLOW RATE
                    //-----------------------------------------------------------------------------
                    //--- CP consists of Heat Flow divided by Temperature
                    //-----------------------------------------------------------------------------
                    //--- Heat Flow is [(Btu/hr) | (kBtu/hr) | (MMBtu/hr)] for ENGLISH
                    //---          and [(W)      | (kW)      | (MW)      ] for METRIC
                    //--- Temperature is [(°F) | (°R)] for ENGLISH
                    //---            and [(°C) | (K)]  for METRIC
                    //-----------------------------------------------------------------------------
                    //--- User selects System [ENGLISH | METRIC]
                    //--- User selects Magnitude [BASE | KILO | MEGA]
                    //---   - Heat Flow is set to [(Btu/hr) | (kBtu/hr) | (MMBtu/hr)] for ENGLISH
                    //---                      or [(W)      | (kW)      | (MW)      ] for METRIC
                    //--- User then selects Temperature [(°F) | (°R)] for ENGLISH
                    //---                               [(°C) | (K)]  for METRIC
                    //-----------------------------------------------------------------------------
                    //--- For Conversion: Use System Units to determine [ METRIC | ENGLISH ]
                    //--- Then Determine Magnitude and Temperature for Conversions
                    //--- NOTE: Conversion are the same for [(°F) | (°R)] and [(°C) | (K)]
                    //-----------------------------------------------------------------------------
                    case HenTypes.ConversionUnitsTypes.CP:
                        if (string.Compare(INTERNAL_UnitsObj.GetSystemUnitsString(),
                                           EXTERNAL_UnitsObj.GetSystemUnitsString(), true) == 0)
                        {
                            #region METRIC
                            //--------------------------------------------------------------
                            //--- Convert External CP Units (W/K)  | (kW/K)  | (MW/K)  | ---
                            //---                           (W/°C) | (kW/°C) | (MW/°C) | ---
                            //--- to Internal CP Units (kW/K)                            ---
                            //--------------------------------------------------------------
                            switch (EXTERNAL_UnitsObj.GetMagnitudeString())
                            {
                                case HenProjectUnits.MAG_BASE:
                                    //--- Convert [ (W/°C) to (kW/K)] | [(W/K) to (kW/K) ] ---
                                    //--- °C or K both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 0.001;
                                    break;
                                case HenProjectUnits.MAG_KILO:
                                    //--- No Conversion Needed - Already (kW/K) ! ---
                                    dInternalValue = dExternalValue;
                                    break;
                                case HenProjectUnits.MAG_MEGA:
                                    //--- Convert [ (MW/°C) to (kW/K)] | [(MW/K) to (kW/K) ] ---
                                    //--- °C or K both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 1000.0;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            EXTERNAL_UnitsObj.GetMagnitudeString());
                                    throw new Exception(strMsg);
                            }
                            #endregion  // METRIC
                        }
                        else
                        {
                            #region ENGLISH
                            //----------------------------------------------------------------------------------
                            //--- Convert External CP Units (Btu/(hr °F) | (kBtu/(hr °F)  | (MMBtu/(hr °F) | ---
                            //---                           (Btu/(hr °R) | (kBtu/(hr °R)  | (MMBtu/(hr °R)   ---
                            //--- to Internal CP Units (kW/K)                                                ---
                            //----------------------------------------------------------------------------------
                            switch (EXTERNAL_UnitsObj.GetMagnitudeString())
                            {
                                case HenProjectUnits.MAG_BASE:
                                    //--- Convert [ (Btu/(hr °F) to (kW/K)] | (Btu/(hr °R) to (kW/K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 0.000527529;
                                    break;
                                case HenProjectUnits.MAG_KILO:
                                    //--- Convert [ (kBtu/(hr °F) to (kW/K)] | (kBtu/(hr °R) to (kW/K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 0.527529;
                                    break;
                                case HenProjectUnits.MAG_MEGA:
                                    //--- Convert [ (MMBtu/(hr °F) to (kW/K)] | (MMBtu/(hr °R) to (kW/K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 527.5291;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            EXTERNAL_UnitsObj.GetMagnitudeString());
                                    throw new Exception(strMsg);
                            }
                            #endregion  // ENGLISH
                        }
                        break;
                    #endregion  // CP - HEAT CAPACITY FLOW RATE

                    #region U - OVERALL HEAT TRANSFER COEFFICIENT
                    //-----------------------------------------------------------------------------
                    //--- U consists of CP divided by Temperature
                    //-----------------------------------------------------------------------------
                    //--- Heat Flow is (Btu/hr) for ENGLISH and (W) for METRIC
                    //--- Temperature is [(°F) | (°R)] for ENGLISH
                    //---             or [(°C) | (K)]  for METRIC
                    //--- Area is (ft²) for ENGLISH or (m²) for METRIC
                    //-----------------------------------------------------------------------------
                    //--- User selects System [ENGLISH | METRIC]
                    //--- User selects Magnitude [BASE | KILO | MEGA]
                    //---   - Heat Flow is set to [(Btu/hr) | (kBtu/hr) | (MMBtu/hr)] for ENGLISH
                    //---                      or [(W)      | (kW)      | (MW)      ] for METRIC
                    //---   - Area      is set to [ft²] for ENGLISH or [m²] for METRIC
                    //--- User selects Temperature [(°F) | (°R)] for ENGLISH
                    //---                          [(°C) | (K)]  for METRIC
                    //-----------------------------------------------------------------------------
                    //--- For Conversion: Use System Units to determine [ METRIC | ENGLISH ]
                    //--- Then Determine Magnitude for Conversions
                    //--- NOTE: Conversion are the same for [(°F) | (°R)] and [(°C) | (K)]
                    //-----------------------------------------------------------------------------
                    case HenTypes.ConversionUnitsTypes.U:
                        if (string.Compare(INTERNAL_UnitsObj.GetSystemUnitsString(),
                                           EXTERNAL_UnitsObj.GetSystemUnitsString(), true) == 0)
                        {
                            #region METRIC
                            //----------------------------------------------------------------------
                            //--- Convert External U Units (W/(m²K)  | (kW/(m²K)  | (MW/(m²K)  | ---
                            //---                          (W/(m²°C) | (kW/(m²°C) | (MW/(m²°C) | ---
                            //--- to Internal U Units (kW/(m²K)                                  ---
                            //----------------------------------------------------------------------
                            switch (EXTERNAL_UnitsObj.GetMagnitudeString())
                            {
                                case HenProjectUnits.MAG_BASE:
                                    //--- Convert [ (W/(m²°C) to (kW/(m²K) | (W/(m²K) to (kW/(m²K) ] ---
                                    //--- °C or K both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 0.001;
                                    break;
                                case HenProjectUnits.MAG_KILO:
                                    //--- No Conversion Needed - Already (kW/(m²K)! ---
                                    dInternalValue = dExternalValue;
                                    break;
                                case HenProjectUnits.MAG_MEGA:
                                    //--- Convert [ (MW/(m²°C) to (kW/(m²K) | (MW/(m²K) to (kW/(m²K) ] ---
                                    //--- °C or K both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 1000.0;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            EXTERNAL_UnitsObj.GetMagnitudeString());
                                    throw new Exception(strMsg);
                            }
                            #endregion  // METRIC
                        }
                        else
                        {
                            #region ENGLISH
                            //---------------------------------------------------------------------------------------------
                            //--- Convert External U Units (Btu/(hr ft² °F) | (kBtu/(hr ft² °F)  | (MMBtu/(hr ft² °F) | ---
                            //---                          (Btu/(hr ft² °R) | (kBtu/(hr ft² °R)  | (MMBtu/(hr ft² °R)   ---
                            //--- to Internal U Units (kW/K)                                                            ---
                            //---------------------------------------------------------------------------------------------
                            switch (EXTERNAL_UnitsObj.GetMagnitudeString())
                            {
                                case HenProjectUnits.MAG_BASE:
                                    //--- Convert [ (Btu/(hr ft² °F) to (kW/(m²K) | (Btu/(hr ft² °R) to (kW/(m²K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 0.005678263;
                                    break;
                                case HenProjectUnits.MAG_KILO:
                                    //--- Convert [ (kBtu/(hr ft² °F) to (kW/(m²K) | (kBtu/(hr ft² °R) to (kW/(m²K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 5.678263;
                                    break;
                                case HenProjectUnits.MAG_MEGA:
                                    //--- Convert [ (MMBtu/(hr ft² °F) to (kW/(m²K) | (MMBtu/(hr ft² °R) to (kW/(m²K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 5678.263;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            EXTERNAL_UnitsObj.GetMagnitudeString());
                                    throw new Exception(strMsg);
                            }
                            #endregion  // ENGLISH
                        }
                        break;
                    #endregion  // U - OVERALL HEAT TRANSFER COEFFICIENT

                    #region UNKNOWN
                    default:
                        strMsg = string.Format("Unknown Units Conversion Type ENCOUNTERED!  {0}",
                                                enumConType.ToString());
                        throw new Exception(strMsg);
                    #endregion  // UNKNOWN
                }
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                HenLogger.WriteSeparatorLine('*');
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                HenLogger.WriteSeparatorLine('*');
            }
            return dInternalValue;
        }
        #endregion  // ConvertToInternal()

        #region ConvertFromInternal()
        /// <summary>
        /// Convert Internal data value in Internal Units to External data value in External Units
        /// Internal units are used by the Pinch Targets and Hen Engines.
        /// External units are customer facing, i.e., UI Project units (controls)
        /// External Units are set by the user in the New Project Form & Project Panel controls
        /// Internal units are set on initial construction and do not change
        /// User Provides an Internal and External HenProjectUnit Object identifying the INTERNAL
        /// and EXTERNAL units
        /// </summary>
        /// <param name="enumConType">Conversion Units Enumeration Type [HenTypes]</param>
        /// <param name="dInternalValued">Internal Value to be converted</param>
        /// <param name="INTERNAL_UnitsObj">INTERNAL Units object</param>
        /// <param name="EXTERNAL_UnitsObj">EXTERNAL Units object</param>
        /// <returns>Converted external value now in external units</returns>
        public double ConvertFromInternal(HenTypes.ConversionUnitsTypes enumConType,
                                          double dInternalValue, 
                                          HenProjectUnits EXTERNAL_UnitsObj,
                                          HenProjectUnits INTERNAL_UnitsObj)
        {
            string strMethod = "ConvertFromInternal";
            string strMsg = String.Empty;
            double dExternalValue = -1.0;
            try
            {
                switch (enumConType)
                {
                    #region A - AREA
                    //-----------------------------------------------------------------------------
                    //--- Area - A is (ft²) for ENGLISH and (m²) for METRIC
                    //-----------------------------------------------------------------------------
                    //--- User selects [ENGLISH | METRIC]
                    //---   - Area is set to [ft²] for ENGLISH | [m²]  for METRIC
                    //-----------------------------------------------------------------------------
                    //--- For Conversion: Use Area Units to determine [ METRIC | ENGLISH ]
                    //-----------------------------------------------------------------------------
                    case HenTypes.ConversionUnitsTypes.A:
                        if (string.Compare(INTERNAL_UnitsObj.GetAreaString(),
                                           EXTERNAL_UnitsObj.GetAreaString(), true) == 0)
                        {
                            //--- No Need for Conversion ALreay (m²)! ---
                            dExternalValue = dInternalValue;
                        }
                        else
                        {
                            //--- Convert m² to ft² ---
                            dExternalValue = dInternalValue * 10.7639104167;
                        }
                        break;
                    #endregion  // A- AREA

                    #region T - TEMPERATURE
                    //-----------------------------------------------------------------------------
                    //--- Temperature - T is [(°F) | (°R)] for ENGLISH and [(°C) | (K)] for METRIC
                    //-----------------------------------------------------------------------------
                    //--- User selects [ENGLISH | METRIC]
                    //--- User selects Temperature [(°F) | (°R)] for ENGLISH
                    //---                      and [(°C) | (K)]  for METRIC
                    //-----------------------------------------------------------------------------
                    case HenTypes.ConversionUnitsTypes.TEMP:
                        if (string.Compare(INTERNAL_UnitsObj.GetTemperatureString(),
                                           EXTERNAL_UnitsObj.GetTemperatureString(), true) == 0)
                        {
                            //--- No Need for Conversion - Already (K)! ---
                            dExternalValue = dInternalValue;
                        }
                        else
                        {
                            //--- Convert Internal Temperature Units (K) to External Temperature Units ---
                            switch (EXTERNAL_UnitsObj.GetTemperatureString())
                            {
                                case HenProjectUnits.DEG_F:
                                    //--- Convert [ (K) to (°F) ] ---
                                    dExternalValue = ((dInternalValue - 273.15) * 1.8) + 32.0;
                                    break;
                                case HenProjectUnits.DEG_R:
                                    //--- Convert [ (K) to (°R) ] ---
                                    dExternalValue = (dInternalValue * 1.8);
                                    break;
                                case HenProjectUnits.DEG_C:
                                    //--- Convert [ (K) to (°C) ] ---
                                    dExternalValue = (dInternalValue - 273.15);
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Temperature Units ENCOUNTERED!  {0}",
                                                            EXTERNAL_UnitsObj.GetTemperatureString());
                                    throw new Exception(strMsg);
                            }
                        }
                        break;
                    #endregion  // T - TEMPERATURE

                    #region P - PRESSURE
                    //-----------------------------------------------------------------------------
                    //--- Pressure - P is [ psia | psia | psf  | atm | inHg | inH2O) ] for ENGLISH
                    //---             and [ bar  | kBar | MBar | Pa  | kPa  | MPa    ] for METRIC
                    //-----------------------------------------------------------------------------
                    //--- User selects [ENGLISH | METRIC]
                    //--- User selects Pressure [ psia | psia | psf  | atm | inHg | inH2O) ] for ENGLISH
                    //---                   and [ bar  | kBar | MBar | Pa  | kPa  | MPa    ] for METRIC
                    //-----------------------------------------------------------------------------
                    case HenTypes.ConversionUnitsTypes.PRESS:
                        if (string.Compare(INTERNAL_UnitsObj.GetPressureString(),
                                           EXTERNAL_UnitsObj.GetPressureString(), true) == 0)
                        {
                            //--- No Need for Conversion - Already (K)! ---
                            dExternalValue = dInternalValue;
                        }
                        else
                        {
                            //--- Convert Internal Pressure Units (K) to External Pressure Units ---
                            switch (EXTERNAL_UnitsObj.GetPressureString())
                            {
                                case HenProjectUnits.Psia:
                                    //--- Convert [ (KPa) to (psia) ] ---
                                    dExternalValue = dInternalValue * 0.14503768;
                                    break;
                                case HenProjectUnits.Psig:
                                    //--- Convert [ (KPa) to (psig) ] ---
                                    dExternalValue = (dInternalValue * 0.14503768) - 14.6959;
                                    break;
                                case HenProjectUnits.Psfa:
                                    //--- Convert [ (KPa) to (psfa) ] ---
                                    dExternalValue = dInternalValue * 20.885416;
                                    break;
                                case HenProjectUnits.Atm:
                                    //--- Convert [ (KPa) to (atm) ] ---
                                    dExternalValue = dInternalValue * 0.00986923;
                                    break;
                                case HenProjectUnits.InHg:
                                    //--- Convert [ (KPa) to (inHg) ] ---
                                    dExternalValue = dInternalValue * 0.2952997;
                                    break;
                                case HenProjectUnits.InH2O:
                                    //--- Convert [ (KPa) to (inH2O) ] ---
                                    dExternalValue = dInternalValue * 4.01474;
                                    break;
                                //--------------------------------------------------------
                                case HenProjectUnits.Bar:
                                    //--- Convert [ (KPa) to (bar) ] ---
                                    dExternalValue = dInternalValue * 0.010;
                                    break;
                                case HenProjectUnits.KBar:
                                    //--- Convert [ (KPa) to (kBar) ] ---
                                    dExternalValue = dInternalValue * 0.00001;
                                    break;
                                case HenProjectUnits.MBar:
                                    //--- Convert [ (KPa) to (MBar) ] ---
                                    dExternalValue = dInternalValue * 0.00000001;
                                    break;
                                case HenProjectUnits.Pa:
                                    //--- Convert [ (KPa) to (Pa) ] ---
                                    dExternalValue = dInternalValue * 1000.0;
                                    break;
                                case HenProjectUnits.MPa:
                                    //--- Convert [ (KPa) to (MPa) ] ---
                                    dExternalValue = dInternalValue * 0.001;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Pressure Units ENCOUNTERED!  {0}",
                                                            EXTERNAL_UnitsObj.GetPressureString());
                                    throw new Exception(strMsg);
                            }
                        }
                        break;
                    #endregion  // P - PRESSURE

                    #region H - HEAT FLOW 
                    //-----------------------------------------------------------------------------
                    //--- Heat Flow is [(Btu/hr) | (kBtu/hr) | (MMBtu/hr)] for ENGLISH
                    //---          and [(W)      | (kW)      | (MW)      ] for METRIC
                    //-----------------------------------------------------------------------------
                    //--- User selects System [ENGLISH | METRIC]
                    //--- User selects Magnitude [BASE | KILO | MEGA]
                    //---   - Heat Flow is set to [(Btu/hr) | (kBtu/hr) | (MMBtu/hr)] for ENGLISH
                    //---                      or [(W)      | (kW)      | (MW)      ] for METRIC
                    //-----------------------------------------------------------------------------
                    //--- For Conversion: Use System Units to determine [ METRIC | ENGLISH ]
                    //--- Then Determine Magnitude for Conversions
                    //-----------------------------------------------------------------------------
                    case HenTypes.ConversionUnitsTypes.HEAT_FLOW:
                        if (string.Compare(INTERNAL_UnitsObj.GetSystemUnitsString(),
                                           EXTERNAL_UnitsObj.GetSystemUnitsString(), true) == 0)
                        {
                            #region METRIC
                            //-----------------------------------------------------
                            //--- Convert Internal Heat Flow Units (kW)         ---
                            //--- to External Heat Flow Units (W) | (kW) | (MW) ---
                            //-----------------------------------------------------
                            switch (EXTERNAL_UnitsObj.GetMagnitudeString())
                            {
                                case HenProjectUnits.MAG_BASE:
                                    //--- Convert kW to W ---
                                    dExternalValue = dInternalValue * 1000.0;
                                    break;
                                case HenProjectUnits.MAG_KILO:
                                    //--- No Conversion Needed - Already (kW) ! ---
                                    dExternalValue = dInternalValue;
                                    break;
                                case HenProjectUnits.MAG_MEGA:
                                    //--- Convert kW to MW ---
                                    dExternalValue = dInternalValue * 0.001;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            EXTERNAL_UnitsObj.GetMagnitudeString());
                                    throw new Exception(strMsg);
                            }
                            #endregion  // METRIC
                        }
                        else
                        {
                            #region ENGLISH
                            //---------------------------------------------------------------------
                            //--- Convert Internal Heat Flow Units (kW)                         ---
                            //--- to External Heat Flow Units (Btu/hr) | (kBtu/hr) | (MMBtu/hr) ---
                            //---------------------------------------------------------------------
                            switch (EXTERNAL_UnitsObj.GetMagnitudeString())
                            {
                                case HenProjectUnits.MAG_BASE:
                                    //--- Convert (kW) to (Btu/hr) ---
                                    dExternalValue = dInternalValue * 3412.142;
                                    break;
                                case HenProjectUnits.MAG_KILO:
                                    //--- Convert (kW) to (kBtu/hr) ---
                                    dExternalValue = dInternalValue * 3.412142;
                                    break;
                                case HenProjectUnits.MAG_MEGA:
                                    //--- Convert (kW) to (MMBtu/hr) ---
                                    dExternalValue = dInternalValue * 0.003412142;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            EXTERNAL_UnitsObj.GetMagnitudeString());
                                    throw new Exception(strMsg);
                            }
                            #endregion  // ENGLISH
                        }
                        break;
                    #endregion  // H - HEAT FLOW

                    #region CP - HEAT CAPACITY FLOW RATE
                    //-----------------------------------------------------------------------------
                    //--- CP consists of Heat Flow divided by Temperature
                    //-----------------------------------------------------------------------------
                    //--- Heat Flow is [(Btu/hr) | (kBtu/hr) | (MMBtu/hr)] for ENGLISH
                    //---          and [(W)      | (kW)      | (MW)      ] for METRIC
                    //--- Temperature is [(°F) | (°R)] for ENGLISH
                    //---             or [(°C) | (K)]  for METRIC
                    //-----------------------------------------------------------------------------
                    //--- User selects System [ENGLISH | METRIC]
                    //--- User selects Magnitude [BASE | KILO | MEGA]
                    //---   - Heat Flow is set to [(Btu/hr) | (kBtu/hr) | (MMBtu/hr)] for ENGLISH
                    //---                      or [(W)      | (kW)      | (MW)      ] for METRIC
                    //--- User then selects Temperature [(°F) | (°R)] for ENGLISH
                    //---                               [(°C) | (K)]  for METRIC
                    //-----------------------------------------------------------------------------
                    //--- For Conversion: Use System Units to determine [ METRIC | ENGLISH ]
                    //--- Then Determine Magnitude and Temperature for Conversions
                    //--- NOTE: Conversion are the same for [(°F) | (°R)] and [(°C) | (K)]
                    //-----------------------------------------------------------------------------
                    case HenTypes.ConversionUnitsTypes.CP:
                        if (string.Compare(INTERNAL_UnitsObj.GetSystemUnitsString(),
                                           EXTERNAL_UnitsObj.GetSystemUnitsString(), true) == 0)
                        {
                            #region METRIC
                            //--------------------------------------------------------------
                            //--- Convert External CP Units (W/K)  | (kW/K)  | (MW/K)  | ---
                            //---                           (W/°C) | (kW/°C) | (MW/°C) | ---
                            //--- to Internal CP Units (kW/K)                            ---
                            //--------------------------------------------------------------
                            switch (EXTERNAL_UnitsObj.GetMagnitudeString())
                            {
                                case HenProjectUnits.MAG_BASE:
                                    //--- Convert [ (kW/K) to (W/°C) ] | [ (kW/K) to (W/K) ] ---
                                    //--- °C or K both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 1000.0;
                                    break;
                                case HenProjectUnits.MAG_KILO:
                                    //--- No Conversion Needed - Already (kW/K) ! ---
                                    dExternalValue = dInternalValue;
                                    break;
                                case HenProjectUnits.MAG_MEGA:
                                    //--- Convert [ (kW/K) to (MW/°C) ] | [ (kW/K) to (MW/K) ] ---
                                    //--- °C or K both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 0.001;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            EXTERNAL_UnitsObj.GetMagnitudeString());
                                    throw new Exception(strMsg);
                            }
                            #endregion  // METRIC
                        }
                        else
                        {
                            #region ENGLISH
                            //-----------------------------------------------------------------------------
                            //--- Convert Internal CP Units (kW/K)                                      ---
                            //--- to External CP Units (Btu/(hr °F) | (kBtu/(hr °F)  | (MMBtu/(hr °F) | ---
                            //---                      (Btu/(hr °R) | (kBtu/(hr °R)  | (MMBtu/(hr °R)   ---
                            //-----------------------------------------------------------------------------
                            switch (EXTERNAL_UnitsObj.GetMagnitudeString())
                            {
                                case HenProjectUnits.MAG_BASE:
                                    //--- Convert [ (Btu/(hr °F) to (kW/K) ] | [ (Btu/(hr °R) to (kW/K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 1895.630;
                                    break;
                                case HenProjectUnits.MAG_KILO:
                                    //--- Convert [ (kBtu/(hr °F) to (kW/K) ] | [ (kBtu/(hr °R) to (kW/K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 1.895630;
                                    break;
                                case HenProjectUnits.MAG_MEGA:
                                    //--- Convert [ (MMBtu/(hr °F) to (kW/K) ] | [ (MMBtu/(hr °R) to (kW/K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 0.00189563;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            EXTERNAL_UnitsObj.GetMagnitudeString());
                                    throw new Exception(strMsg);
                            }
                            #endregion  // ENGLISH
                        }
                        break;
                    #endregion  // CP - HEAT CAPACITY FLOW RATE

                    #region U - OVERALL HEAT TRANSFER COEFFICIENT
                    //-----------------------------------------------------------------------------
                    //--- U consists of CP divided by Temperature
                    //-----------------------------------------------------------------------------
                    //--- Heat Flow is (Btu/hr) for ENGLISH and (W) for METRIC
                    //--- Temperature is [(°F) | (°R)] for ENGLISH
                    //---             or [(°C) | (K)]  for METRIC
                    //--- Area is (ft²) for ENGLISH or (m²) for METRIC
                    //-----------------------------------------------------------------------------
                    //--- User selects System [ENGLISH | METRIC]
                    //--- User selects Magnitude [BASE | KILO | MEGA]
                    //---   - Heat Flow is set to [(Btu/hr) | (kBtu/hr) | (MMBtu/hr)] for ENGLISH
                    //---                      or [(W)      | (kW)      | (MW)      ] for METRIC
                    //---   - Area      is set to [ft²] for ENGLISH or [m²] for METRIC
                    //--- User selects Temperature [(°F) | (°R)] for ENGLISH
                    //---                          [(°C) | (K)]  for METRIC
                    //-----------------------------------------------------------------------------
                    //--- For Conversion: Use System Units to determine [ METRIC | ENGLISH ]
                    //--- Then Determine Magnitude for Conversions
                    //--- NOTE: Conversion are the same for [(°F) | (°R)] and [(°C) | (K)]
                    //-----------------------------------------------------------------------------
                    case HenTypes.ConversionUnitsTypes.U:
                        if (string.Compare(INTERNAL_UnitsObj.GetSystemUnitsString(),
                                           EXTERNAL_UnitsObj.GetSystemUnitsString(), true) == 0)
                        {
                            #region METRIC
                            //----------------------------------------------------------------------
                            //--- Convert External U Units (W/(m²K)  | (kW/(m²K)  | (MW/(m²K)  | ---
                            //---                          (W/(m²°C) | (kW/(m²°C) | (MW/(m²°C) | ---
                            //--- to Internal U Units (kW/(m²K)                                  ---
                            //----------------------------------------------------------------------
                            switch (EXTERNAL_UnitsObj.GetMagnitudeString())
                            {
                                case HenProjectUnits.MAG_BASE:
                                    //--- Convert [ (kW/(m²K)) to (W/(m²°C)) | (kW/(m²K)) to (W/(m²K)) ] ---
                                    //--- °C or K both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 1000.0;
                                    break;
                                case HenProjectUnits.MAG_KILO:
                                    //--- No Conversion Needed - Already (kW/(m²K)! ---
                                    dExternalValue = dInternalValue;
                                    break;
                                case HenProjectUnits.MAG_MEGA:
                                    //--- Convert [ (kW/(m²K)) to (MW/(m²°C)) | (kW/(m²K)) to (MW/(m²K)) ] ---
                                    //--- °C or K both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 0.001;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            EXTERNAL_UnitsObj.GetMagnitudeString());
                                    throw new Exception(strMsg);
                            }
                            #endregion  // METRIC
                        }
                        else
                        {
                            #region ENGLISH
                            //-----------------------------------------------------------------------------------------------
                            //--- Convert External U Units (Btu/(hr ft² °F)) | (kBtu/(hr ft² °F)) | (MMBtu/(hr ft² °F)) | ---
                            //---                          (Btu/(hr ft² °R)) | (kBtu/(hr ft² °R)) | (MMBtu/(hr ft² °R))   ---                                                            ---
                            //--- to Internal U Units (kW/(m² K))                                                          --
                            //-----------------------------------------------------------------------------------------------
                            switch (EXTERNAL_UnitsObj.GetMagnitudeString())
                            {
                                case HenProjectUnits.MAG_BASE:
                                    //--- Convert [ (kW/(m²K) to (Btu/(hr ft² °F) | (kW/(m²K) to (Btu/(hr ft² °R) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 176.11;
                                    break;
                                case HenProjectUnits.MAG_KILO:
                                    //--- Convert [ (kW/(m²K) to (kBtu/(hr ft² °F) | (kW/(m²K) to (kBtu/(hr ft² °R) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 0.17611;
                                    break;
                                case HenProjectUnits.MAG_MEGA:
                                    //--- Convert [ (kW/(m²K) to (MMBtu/(hr ft² °F) | (kW/(m²K) to (MMBtu/(hr ft² °R) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 0.00017611;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            EXTERNAL_UnitsObj.GetMagnitudeString());
                                    throw new Exception(strMsg);
                            }
                            #endregion  // ENGLISH
                        }
                        break;
                    #endregion  // U - OVERALL HEAT TRANSFER COEFFICIENT

                    #region UNKNOWN
                    default:
                        strMsg = string.Format("Unknown Units Conversion Type ENCOUNTERED!  {0}",
                                                enumConType.ToString());
                        throw new Exception(strMsg);
                    #endregion  // UNKNOWN
                }
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                HenLogger.WriteSeparatorLine('*');
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                HenLogger.WriteSeparatorLine('*');
            }
            return dExternalValue;
        }
        #endregion  // ConvertFromInternal()

        #region TestUnitConversions()
        /// <summary>
        /// Test Unit Conversions
        /// </summary>
        public void TestUnitConversions()
        {
            string strMethod = "TestUnitConversions";
            string strMsg = String.Empty;
            int nPass = 0;
            int nFail = 0;
            try
            {
                HenLogger.WriteSeparatorLine(' ');
                HenLogger.WriteSection("START UNIT CONVERSION TEST");

                #region USER SETS EXTERNAL UNITS
                HenProjectUnits internalUnits = new HenProjectUnits();  // Defaults are INTERNAL
                HenProjectUnits externalUnits = new HenProjectUnits();  // Modify for Test

                externalUnits.ProjectSystemUnitsEnum = HenProjectUnits.ProjectSystemUnits.ENGLISH;      // System:      "ENGLISH"
                externalUnits.ProjectMagnitudeEnum = HenProjectUnits.ProjectMagnitude.MEGA;             // Magnitude:   "MEGA"
                
                externalUnits.ProjectEnglishAreaEnum = HenProjectUnits.ProjectEnglishArea.FT2;          // Area:        "ft²"
                externalUnits.ProjectMetricAreaEnum = HenProjectUnits.ProjectMetricArea.M2;             // Area:        "m²"

                externalUnits.ProjectEnglishTempEnum = HenProjectUnits.ProjectEnglishTemp.DEG_F;        // Temperature: "°F"
                externalUnits.ProjectMetricTempEnum = HenProjectUnits.ProjectMetricTemp.DEG_C;          // Temperature: "°C"

                externalUnits.ProjectEnglishPressEnum = HenProjectUnits.ProjectEnglishPress.PSIA;      // Pressure:    "psia"
                externalUnits.ProjectMetricPressEnum = HenProjectUnits.ProjectMetricPress.Pa;          // Pressure:    "Pa"

                externalUnits.ProjectEnglishPressEnum = HenProjectUnits.ProjectEnglishPress.PSIA;      // Pressure:    "psia"
                #endregion  // USER SETS EXTERNAL UNITS

                #region A - AREA

                #region TARGET VALUES
                double dAreaSqM = 400.00;      // << INTERNAL VALUE >>
                double dAreaSqFt = 4305.56417;  // EXTERNAL VALUE
                #endregion  // TARGET VALUES

                #region TO EXTERNAL
                dAreaSqM = 400.0;     // Set INTERNAL VALUE
                dAreaSqFt = ConvertFromInternal(HenTypes.ConversionUnitsTypes.A, dAreaSqM, externalUnits, internalUnits);
                if (CheckForEquality(dAreaSqFt, 4305.56417))
                {
                    nPass++;
                    strMsg = string.Format("AREA CONVERSION TEST -> {0:0.000} m² to {1:0.000} ft² .... PASS",
                                            Math.Round(dAreaSqM, 3),
                                            Math.Round(dAreaSqFt, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("AREA CONVERSION TEST -> {0:0.000} m² to 4305.564 ft² .... FAIL -- {1:0.000} ft²",
                                            Math.Round(dAreaSqM, 3),
                                            Math.Round(dAreaSqFt, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dAreaSqFt = 4305.564167;  // Set EXTERNAL VALUE
                dAreaSqM = ConvertToInternal(HenTypes.ConversionUnitsTypes.A, dAreaSqFt, externalUnits, internalUnits);
                if (CheckForEquality(dAreaSqM, 400.0))
                {
                    nPass++;
                    strMsg = string.Format("AREA CONVERSION TEST -> {0:0.000} ft² to {1:0.000} m² .... PASS",
                                           Math.Round(dAreaSqFt, 3),
                                           Math.Round(dAreaSqM, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("AREA CONVERSION TEST -> {0:0.000} ft² to 400.000 m² .... FAIL -- {1:0.000} m²",
                                           Math.Round(dAreaSqFt, 3),
                                           Math.Round(dAreaSqM, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // A - AREA

                #region T - TEMPERATURE

                #region TARGET VALUES
                double dTempK = 400.00;  // << INTERNAL VALUE >>
                double dTempC = 126.85;  // EXTERNAL VALUE
                double dTempF = 260.33;  // EXTERNAL VALUE
                double dTempR = 720.00;  // EXTERNAL VALUE
                #endregion  // TARGET VALUES

                #region CELSIUS

                #region TO EXTERNAL
                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;   // METRIC
                externalUnits.ProjectMetricTempEnum = ProjectMetricTemp.DEG_C;      // Celsius: "°C"

                dTempK = 400.0;     // Set INTERNAL VALUE
                dTempC = ConvertFromInternal(HenTypes.ConversionUnitsTypes.TEMP, dTempK, externalUnits, internalUnits);
                if (CheckForEquality(dTempC, 126.85))
                {
                    nPass++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} K to {1:0.00} °C .... PASS",
                                            Math.Round(dTempK, 2),
                                            Math.Round(dTempC, 2));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} K to 126.85 °C .... FAIL -- {1:0.00} °C",
                                            Math.Round(dTempK, 2),
                                            Math.Round(dTempC, 2));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dTempC = 126.85;  // Set EXTERNAL VALUE
                dTempK = ConvertToInternal(HenTypes.ConversionUnitsTypes.TEMP, dTempC, externalUnits, internalUnits);
                if (CheckForEquality(dTempK, 400.00))
                {
                    nPass++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} °C to {1:0.00} K .... PASS",
                                           Math.Round(dTempC, 2),
                                           Math.Round(dTempK, 2));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} °C to 400.00 K .... FAIL -- {1:0.00} K",
                                           Math.Round(dTempC, 2),
                                           Math.Round(dTempK, 2));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // CELSIUS

                #region FAHRENHEIT

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;   // ENGLISH
                externalUnits.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_F;     // Fahrenheit: "°F"

                #region TO EXTERNAL

                dTempK = 400.0;     // Set INTERNAL VALUE
                dTempF = ConvertFromInternal(HenTypes.ConversionUnitsTypes.TEMP, dTempK, externalUnits, internalUnits);
                if (CheckForEquality(dTempF, 260.33))
                {
                    nPass++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} K to {1:0.00} °F .... PASS",
                                            Math.Round(dTempK, 2),
                                            Math.Round(dTempF, 2));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} K to 260.33 °F .... FAIL -- {1:0.00} °F",
                                            Math.Round(dTempK, 2),
                                            Math.Round(dTempF, 2));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dTempF = 260.33;  // Set EXTERNAL VALUE
                dTempK = ConvertToInternal(HenTypes.ConversionUnitsTypes.TEMP, dTempF, externalUnits, internalUnits);
                if (CheckForEquality(dTempK, 400.00))
                {
                    nPass++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} °F to {1:0.00} K .... PASS",
                                           Math.Round(dTempF, 2),
                                           Math.Round(dTempK, 2));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} °F to 400.00 K .... FAIL -- {1:0.00} K",
                                           Math.Round(dTempF, 2),
                                           Math.Round(dTempK, 2));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // FAHRENHEIT

                #region RANKINE

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;   // ENGLISH
                externalUnits.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_R;     // Fahrenheit: "°R"

                #region TO EXTERNAL

                dTempK = 400.0;     // Set INTERNAL VALUE
                dTempR = ConvertFromInternal(HenTypes.ConversionUnitsTypes.TEMP, dTempK, externalUnits, internalUnits);
                if (CheckForEquality(dTempR, 720.00))
                {
                    nPass++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} K to {1:0.00} °R .... PASS",
                                            Math.Round(dTempK, 2),
                                            Math.Round(dTempR, 2));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} K to 720.00 °R .... FAIL -- {1:0.00} °R",
                                            Math.Round(dTempK, 2),
                                            Math.Round(dTempR, 2));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dTempR = 720.00;  // Set EXTERNAL VALUE
                dTempK = ConvertToInternal(HenTypes.ConversionUnitsTypes.TEMP, dTempR, externalUnits, internalUnits);
                if (CheckForEquality(dTempK, 400.00))
                {
                    nPass++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} °R to {1:0.00} K .... PASS",
                                           Math.Round(dTempR, 2),
                                           Math.Round(dTempK, 2));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} °R to 400.00 K .... FAIL -- {1:0.00} K",
                                           Math.Round(dTempR, 2),
                                           Math.Round(dTempK, 2));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // RANKINE

                #endregion  // T - TEMPERATURE

                #region P - PRESSURE

                #region TARGET VALUES
                double dPressKPa = 400.00;      // << INTERNAL VALUE >>
                double dPressPsia = 58.015072;  // EXTERNAL VALUE
                double dPressPsig = 43.319172;  // EXTERNAL VALUE
                double dPressPsfa = 8354.1664;  // EXTERNAL VALUE
                double dPressAtm = 3.947692;    // EXTERNAL VALUE
                double dPressInHg = 118.11988;  // EXTERNAL VALUE
                double dPressInH2O = 1605.896;   // EXTERNAL VALUE
                double dPressBar = 4.000;       // EXTERNAL VALUE
                double dPressKBar = 0.004;      // EXTERNAL VALUE
                double dPressMBar = 0.000004;   // EXTERNAL VALUE
                double dPressPa = 400000.0;     // EXTERNAL VALUE
                double dPressMPa = 0.400;       // EXTERNAL VALUE
                #endregion  // TARGET VALUES

                #region PSIA

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;   // ENGLISH
                externalUnits.ProjectEnglishPressEnum = ProjectEnglishPress.PSIA;    // lbs/in² absolute : "psia"

                #region TO EXTERNAL

                dPressKPa = 400.0;     // Set INTERNAL VALUE
                dPressPsia = ConvertFromInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressKPa, externalUnits, internalUnits);
                if (CheckForEquality(dPressPsia, 58.015072))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to {1:0.000000} psia .... PASS",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressPsia, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to 58.015072 psia .... FAIL -- {1:0.000000} psia",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressPsia, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dPressPsia = 58.015072;  // Set EXTERNAL VALUE
                dPressKPa = ConvertToInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressPsia, externalUnits, internalUnits);
                if (CheckForEquality(dPressKPa, 400.00))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} psia to {1:0.0000} KPa .... PASS",
                                           Math.Round(dPressPsia, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} psia to 400.0000 KPa .... FAIL -- {1:0.0000} KPa",
                                           Math.Round(dPressPsia, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // PSIA

                #region PSIG

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;   // ENGLISH
                externalUnits.ProjectEnglishPressEnum = ProjectEnglishPress.PSIG;    // lbs/in² Gauge : "psig"

                #region TO EXTERNAL

                dPressKPa = 400.0;     // Set INTERNAL VALUE
                dPressPsig = ConvertFromInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressKPa, externalUnits, internalUnits);
                if (CheckForEquality(dPressPsig, 43.319172))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to {1:0.000000} psig .... PASS",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressPsig, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to 43.319172 psig .... FAIL -- {1:0.000000} psig",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressPsig, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dPressPsig = 43.319172;  // Set EXTERNAL VALUE
                dPressKPa = ConvertToInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressPsig, externalUnits, internalUnits);
                if (CheckForEquality(dPressKPa, 400.00))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} psig to {1:0.0000} KPa .... PASS",
                                           Math.Round(dPressPsig, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} psig to 400.0000 KPa .... FAIL -- {1:0.0000} KPa",
                                           Math.Round(dPressPsig, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // PSIG

                #region PSFA

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;   // ENGLISH
                externalUnits.ProjectEnglishPressEnum = ProjectEnglishPress.PSF;     // lbs/ft² Absolute : "psfa"

                #region TO EXTERNAL

                dPressKPa = 400.0;     // Set INTERNAL VALUE
                dPressPsfa = ConvertFromInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressKPa, externalUnits, internalUnits);
                if (CheckForEquality(dPressPsfa, 8354.1664))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to {1:0.000000} psfa .... PASS",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressPsfa, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to 8354.1664 psfa .... FAIL -- {1:0.000000} psfa",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressPsfa, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dPressPsfa = 8354.1664;  // Set EXTERNAL VALUE
                dPressKPa = ConvertToInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressPsfa, externalUnits, internalUnits);
                if (CheckForEquality(dPressKPa, 400.00))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} psfa to {1:0.0000} KPa .... PASS",
                                           Math.Round(dPressPsfa, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} psfa to 400.0000 KPa .... FAIL -- {1:0.0000} KPa",
                                           Math.Round(dPressPsfa, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // PSFA

                #region ATM

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;   // ENGLISH
                externalUnits.ProjectEnglishPressEnum = ProjectEnglishPress.ATM;     // atmospheres : "atm"

                #region TO EXTERNAL

                dPressKPa = 400.0;     // Set INTERNAL VALUE
                dPressAtm = ConvertFromInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressKPa, externalUnits, internalUnits);
                if (CheckForEquality(dPressAtm, 3.947692))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to {1:0.000000} atm .... PASS",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressAtm, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to 3.947692 atm .... FAIL -- {1:0.000000} atm",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressAtm, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dPressAtm = 3.947692;  // Set EXTERNAL VALUE
                dPressKPa = ConvertToInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressAtm, externalUnits, internalUnits);
                if (CheckForEquality(dPressKPa, 400.00))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} atm to {1:0.0000} KPa .... PASS",
                                           Math.Round(dPressAtm, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} atm to 400.0000 KPa .... FAIL -- {1:0.0000} KPa",
                                           Math.Round(dPressAtm, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // ATM

                #region inHg

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;   // ENGLISH
                externalUnits.ProjectEnglishPressEnum = ProjectEnglishPress.IN_HG;   // inches Mercury : "inHg"

                #region TO EXTERNAL

                dPressKPa = 400.0;     // Set INTERNAL VALUE
                dPressInHg = ConvertFromInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressKPa, externalUnits, internalUnits);
                if (CheckForEquality(dPressInHg, 118.11988))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to {1:0.000000} inHg .... PASS",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressInHg, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to 118.11988 inHg .... FAIL -- {1:0.000000} inHg",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressInHg, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dPressInHg = 118.11988;  // Set EXTERNAL VALUE
                dPressKPa = ConvertToInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressInHg, externalUnits, internalUnits);
                if (CheckForEquality(dPressKPa, 400.00))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} inHg to {1:0.0000} KPa .... PASS",
                                           Math.Round(dPressInHg, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} inHg to 400.0000 KPa .... FAIL -- {1:0.0000} KPa",
                                           Math.Round(dPressInHg, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // inHg

                #region inH2O

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;   // ENGLISH
                externalUnits.ProjectEnglishPressEnum = ProjectEnglishPress.IN_H2O;  // inches Water : "inH2O"

                #region TO EXTERNAL

                dPressKPa = 400.0;     // Set INTERNAL VALUE
                dPressInH2O = ConvertFromInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressKPa, externalUnits, internalUnits);
                if (CheckForEquality(dPressInH2O, 1605.896))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to {1:0.000000} inH2O .... PASS",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressInH2O, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to 1605.896 inH2O .... FAIL -- {1:0.000000} inH2O",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressInH2O, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dPressInH2O = 1605.896;  // Set EXTERNAL VALUE
                dPressKPa = ConvertToInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressInH2O, externalUnits, internalUnits);
                if (CheckForEquality(dPressKPa, 400.00))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} inH2O to {1:0.0000} KPa .... PASS",
                                           Math.Round(dPressInH2O, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} inH2O to 400.0000 KPa .... FAIL -- {1:0.0000} KPa",
                                           Math.Round(dPressInH2O, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // inH2O

                #region BAR

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;   // METRIC
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.BASE;         // BASE
                externalUnits.ProjectMetricPressEnum = ProjectMetricPress.BAR;      // bar : "bar"

                #region TO EXTERNAL

                dPressKPa = 400.0;     // Set INTERNAL VALUE
                dPressBar = ConvertFromInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressKPa, externalUnits, internalUnits);
                if (CheckForEquality(dPressBar, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to {1:0.000000} bar .... PASS",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressBar, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to 4.000 bar .... FAIL -- {1:0.000000} bar",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressBar, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dPressBar = 4.000;  // Set EXTERNAL VALUE
                dPressKPa = ConvertToInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressBar, externalUnits, internalUnits);
                if (CheckForEquality(dPressKPa, 400.00))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} bar to {1:0.0000} KPa .... PASS",
                                           Math.Round(dPressBar, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} bar to 400.0000 KPa .... FAIL -- {1:0.0000} KPa",
                                           Math.Round(dPressBar, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // BAR

                #region KBAR

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;   // METRIC
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.KILO;         // KILO
                externalUnits.ProjectMetricPressEnum = ProjectMetricPress.BAR;      // bar : "bar"

                #region TO EXTERNAL

                dPressKPa = 400.0;     // Set INTERNAL VALUE
                dPressKBar = ConvertFromInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressKPa, externalUnits, internalUnits);
                if (CheckForEquality(dPressKBar, 0.004))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to {1:0.000000} kBar .... PASS",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressKBar, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to 0.004 kBar .... FAIL -- {1:0.000000} kBar",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressKBar, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dPressKBar = 0.004;  // Set EXTERNAL VALUE
                dPressKPa = ConvertToInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressKBar, externalUnits, internalUnits);
                if (CheckForEquality(dPressKPa, 400.00))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} kBar to {1:0.0000} KPa .... PASS",
                                           Math.Round(dPressKBar, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} kBar to 400.0000 KPa .... FAIL -- {1:0.0000} KPa",
                                           Math.Round(dPressKBar, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // KBAR

                #region MBAR

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;   // METRIC
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;         // MEGA
                externalUnits.ProjectMetricPressEnum = ProjectMetricPress.BAR;      // bar : "bar"

                #region TO EXTERNAL

                dPressKPa = 400.0;     // Set INTERNAL VALUE
                dPressMBar = ConvertFromInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressKPa, externalUnits, internalUnits);
                if (CheckForEquality(dPressMBar, 0.000004))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to {1:0.000000} MBar .... PASS",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressMBar, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to 0.000004 MBar .... FAIL -- {1:0.000000} MBar",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressMBar, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dPressMBar = 0.000004;  // Set EXTERNAL VALUE
                dPressKPa = ConvertToInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressMBar, externalUnits, internalUnits);
                if (CheckForEquality(dPressKPa, 400.00))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} MBar to {1:0.0000} KPa .... PASS",
                                           Math.Round(dPressMBar, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} MBar to 400.0000 KPa .... FAIL -- {1:0.0000} KPa",
                                           Math.Round(dPressMBar, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // MBAR

                #region PA

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;   // METRIC
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.BASE;         // BASE
                externalUnits.ProjectMetricPressEnum = ProjectMetricPress.Pa;       // Pascal : "Pa"

                #region TO EXTERNAL

                dPressKPa = 400.0;     // Set INTERNAL VALUE
                dPressPa = ConvertFromInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressKPa, externalUnits, internalUnits);
                if (CheckForEquality(dPressPa, 400000.0))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to {1:0.000000} Pa .... PASS",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressPa, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to 400000.0 Pa .... FAIL -- {1:0.000000} Pa",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressPa, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dPressPa = 400000.0;  // Set EXTERNAL VALUE
                dPressKPa = ConvertToInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressPa, externalUnits, internalUnits);
                if (CheckForEquality(dPressKPa, 400.00))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} Pa to {1:0.0000} KPa .... PASS",
                                           Math.Round(dPressPa, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} Pa to 400.0000 KPa .... FAIL -- {1:0.0000} KPa",
                                           Math.Round(dPressPa, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // PA

                #region MPA

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;   // METRIC
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;         // MEGA
                externalUnits.ProjectMetricPressEnum = ProjectMetricPress.Pa;       // Pascal : "Pa"

                #region TO EXTERNAL

                dPressKPa = 400.0;     // Set INTERNAL VALUE
                dPressMPa = ConvertFromInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressKPa, externalUnits, internalUnits);
                if (CheckForEquality(dPressMPa, 0.400))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to {1:0.000000} MPa .... PASS",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressMPa, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.0000} KPa to 0.400 MPa .... FAIL -- {1:0.000000} MPa",
                                            Math.Round(dPressKPa, 4),
                                            Math.Round(dPressMPa, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dPressMPa = 0.400;  // Set EXTERNAL VALUE
                dPressKPa = ConvertToInternal(HenTypes.ConversionUnitsTypes.PRESS, dPressMPa, externalUnits, internalUnits);
                if (CheckForEquality(dPressKPa, 400.00))
                {
                    nPass++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} MPa to {1:0.0000} KPa .... PASS",
                                           Math.Round(dPressMPa, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("PRESSURE CONVERSION TEST -> {0:0.000000} MPa to 400.0000 KPa .... FAIL -- {1:0.0000} KPa",
                                           Math.Round(dPressMPa, 6),
                                           Math.Round(dPressKPa, 4));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // MPA

                #endregion  // P - PRESSURE

                #region H - HEAT FLOW

                #region TARGET VALUES
                double dHeatFlowW = 4000.000;        // EXTERNAL VALUE
                double dHeatFlowkW = 4.000;          // << INTERNAL VALUE >>
                double dHeatFlowMW = 0.004;          // EXTERNAL VALUE
                double dHeatFlowBtu = 13648.56;      // EXTERNAL VALUE
                double dHeatFlowkBtu = 13.64856;     // EXTERNAL VALUE
                double dHeatFlowMMBtu = 0.01364856;  // EXTERNAL VALUE
                #endregion  // TARGET VALUES

                #region W

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;   // METRIC
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.BASE;         // BASE

                #region TO EXTERNAL

                dHeatFlowkW = 4.000;     // Set INTERNAL VALUE
                dHeatFlowW = ConvertFromInternal(HenTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowkW, externalUnits, internalUnits);
                if (CheckForEquality(dHeatFlowW, 4000.000))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to {1:0.000} W .... PASS",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowW, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to 4000.000 W .... FAIL -- {1:0.000} W",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowW, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dHeatFlowW = 4000.000;  // Set EXTERNAL VALUE
                dHeatFlowkW = ConvertToInternal(HenTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowW, externalUnits, internalUnits);
                if (CheckForEquality(dHeatFlowkW, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} W to {1:0.000} kW .... PASS",
                                           Math.Round(dHeatFlowW, 3),
                                           Math.Round(dHeatFlowkW, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} W to 400.000 kW .... FAIL -- {1:0.000} kW",
                                           Math.Round(dHeatFlowW, 3),
                                           Math.Round(dHeatFlowkW, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // W

                #region MW

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;   // METRIC
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;         // MEGA

                #region TO EXTERNAL

                dHeatFlowkW = 4.000;     // Set INTERNAL VALUE
                dHeatFlowMW = ConvertFromInternal(HenTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowkW, externalUnits, internalUnits);
                if (CheckForEquality(dHeatFlowMW, 0.0040))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to {1:0.0000} MW .... PASS",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowMW, 4));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to 0.0040 W .... FAIL -- {1:0.0000} W",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowMW, 4));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dHeatFlowMW = 0.0040;  // Set EXTERNAL VALUE
                dHeatFlowkW = ConvertToInternal(HenTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowMW, externalUnits, internalUnits);
                if (CheckForEquality(dHeatFlowkW, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.0000} MW to {1:0.000} kW .... PASS",
                                           Math.Round(dHeatFlowMW, 4),
                                           Math.Round(dHeatFlowkW, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.0000} MW to 4.000 kW .... FAIL -- {1:0.000} kW",
                                           Math.Round(dHeatFlowMW, 4),
                                           Math.Round(dHeatFlowkW, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');

                #endregion  // MW

                #region BTU/HR

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;   // ENGLISH
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.BASE;          // BASE

                #region TO EXTERNAL

                dHeatFlowkW = 4.000;     // Set INTERNAL VALUE
                dHeatFlowBtu = ConvertFromInternal(HenTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowkW, externalUnits, internalUnits);
                if (CheckForEquality(dHeatFlowBtu, 13648.568))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to {1:0.000} Btu/hr .... PASS",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowBtu, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to 13648.568 Btu/hr .... FAIL -- {1:0.000} Btu/hr",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowBtu, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dHeatFlowBtu = 13648.568;  // Set EXTERNAL VALUE
                dHeatFlowkW = ConvertToInternal(HenTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowBtu, externalUnits, internalUnits);
                if (CheckForEquality(dHeatFlowkW, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} Btu/hr to {1:0.000} kW .... PASS",
                                           Math.Round(dHeatFlowBtu, 3),
                                           Math.Round(dHeatFlowkW, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} Btu/hr to 4.000 kW .... FAIL -- {1:0.000} Btu/hr",
                                           Math.Round(dHeatFlowBtu, 3),
                                           Math.Round(dHeatFlowkW, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // #region BTU/HR

                #region kBTU/HR

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;   // ENGLISH
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.KILO;          // KILO

                #region TO EXTERNAL

                dHeatFlowkW = 4.000;     // Set INTERNAL VALUE
                dHeatFlowkBtu = ConvertFromInternal(HenTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowkW, externalUnits, internalUnits);
                if (CheckForEquality(dHeatFlowkBtu, 13.6486))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to {1:0.0000} kBtu/hr .... PASS",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowkBtu, 4));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to 13.6486 kBtu/hr .... FAIL -- {1:0.0000} kBtu/hr",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowkBtu, 4));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dHeatFlowkBtu = 13.6486;  // Set EXTERNAL VALUE
                dHeatFlowkW = ConvertToInternal(HenTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowkBtu, externalUnits, internalUnits);
                if (CheckForEquality(dHeatFlowkW, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.0000} kBtu/hr to {1:0.000} kW .... PASS",
                                           Math.Round(dHeatFlowkBtu, 4),
                                           Math.Round(dHeatFlowkW, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.0000} kBtu/hr to 4.000 kW .... FAIL -- {1:0.0000} kBtu/hr",
                                           Math.Round(dHeatFlowkBtu, 4),
                                           Math.Round(dHeatFlowkW, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // #region kBTU/HR

                #region MMBTU/HR

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;   // ENGLISH
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;          // MEGA

                #region TO EXTERNAL

                dHeatFlowkW = 4.000;     // Set INTERNAL VALUE
                dHeatFlowMMBtu = ConvertFromInternal(HenTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowkW, externalUnits, internalUnits);
                if (CheckForEquality(dHeatFlowMMBtu, 0.0136486))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to {1:0.000000} MMBtu/hr .... PASS",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowMMBtu, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to 0.0136486 MMBtu/hr .... FAIL -- {1:0.000000} MMBtu/hr",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowMMBtu, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dHeatFlowMMBtu = 0.0136486;  // Set EXTERNAL VALUE
                dHeatFlowkW = ConvertToInternal(HenTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowMMBtu, externalUnits, internalUnits);
                if (CheckForEquality(dHeatFlowkW, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000000} MMBtu/hr to {1:0.000} kW .... PASS",
                                           Math.Round(dHeatFlowMMBtu, 6),
                                           Math.Round(dHeatFlowkW, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000000} MMBtu/hr to 4.000 kW .... FAIL -- {1:0.000} MMBtu/hr",
                                           Math.Round(dHeatFlowMMBtu, 6),
                                           Math.Round(dHeatFlowkW, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // #region MMBTU/HR

                #endregion  // H - HEAT FLOW

                #region CP - HEAT CAPACITY FLOW RATE

                #region TARGET VALUES
                double dCP_W_C = 4000.000;          // EXTERNAL VALUE
                double dCP_W_K = 4000.000;          // EXTERNAL VALUE
                double dCP_kW_C = 4.000;            // EXTERNAL VALUE
                double dCP_kW_K = 4.000;            // << INTERNAL VALUE >>
                double dCP_MW_C = 0.004000;         // EXTERNAL VALUE
                double dCP_MW_K = 0.004000;         // EXTERNAL VALUE
                double dCP_Btu_F = 7582.520;        // EXTERNAL VALUE
                double dCP_Btu_R = 7582.520;        // EXTERNAL VALUE
                double dCP_kBtu_F = 7.582520;       // EXTERNAL VALUE
                double dCP_kBtu_R = 7.582520;       // EXTERNAL VALUE
                double dCP_MMBtu_F = 0.007582520;   // EXTERNAL VALUE
                double dCP_MMBtu_R = 0.007582520;   // EXTERNAL VALUE
                #endregion  // TARGET VALUES

                #region W-C

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;   // METRIC
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.BASE;         // BASE
                externalUnits.ProjectMetricTempEnum = ProjectMetricTemp.DEG_C;      // Temperature: "°C"

                #region TO EXTERNAL

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_W_C = ConvertFromInternal(HenTypes.ConversionUnitsTypes.CP, dCP_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dCP_W_C, 4000.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000} W/°C .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_W_C, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 4000.000 W/°C .... FAIL -- {1:0.000} W/°C",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_W_C, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_W_C = 4000.000;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.CP, dCP_W_C, externalUnits, internalUnits);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} W/°C to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_W_C, 3),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} W/°C to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_W_C, 3),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // W-C

                #region W-K

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;   // METRIC
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.BASE;         // BASE
                externalUnits.ProjectMetricTempEnum = ProjectMetricTemp.KELVIN;     // Temperature: "K"

                #region TO EXTERNAL

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_W_K = ConvertFromInternal(HenTypes.ConversionUnitsTypes.CP, dCP_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dCP_W_K, 4000.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000} W/K .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_W_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 4000.000 W/K .... FAIL -- {1:0.000} W/°C",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_W_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_W_K = 4000.000;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.CP, dCP_W_K, externalUnits, internalUnits);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} W/K to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_W_K, 3),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} W/K to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_W_K, 3),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // W-K

                #region KW-C

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;   // METRIC
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.KILO;         // KILO
                externalUnits.ProjectMetricTempEnum = ProjectMetricTemp.DEG_C;      // Temperature: "°C"

                #region TO EXTERNAL

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_kW_C = ConvertFromInternal(HenTypes.ConversionUnitsTypes.CP, dCP_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dCP_kW_C, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000} kW/°C .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_kW_C, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 4.000 kW/°C .... FAIL -- {1:0.000} kW/°C",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_kW_C, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_kW_C = 4.000;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.CP, dCP_kW_C, externalUnits, internalUnits);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/°C to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_kW_C, 3),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/°C to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_kW_C, 3),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // KW-C

                #region MW-C

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;   // METRIC
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;         // MEGA
                externalUnits.ProjectMetricTempEnum = ProjectMetricTemp.DEG_C;      // Temperature: "°C"

                #region TO EXTERNAL

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_MW_C = ConvertFromInternal(HenTypes.ConversionUnitsTypes.CP, dCP_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dCP_MW_C, 0.004000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.0000000} MW/°C .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_MW_C, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 0.004000 MW/°C .... FAIL -- {1:0.000} MW/°C",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_MW_C, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_MW_C = 0.004000;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.CP, dCP_MW_C, externalUnits, internalUnits);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} MW/°C to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_MW_C, 6),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} MW/°C to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_MW_C, 6),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // MW-C

                #region MW-K

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;   // METRIC
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;         // MEGA
                externalUnits.ProjectMetricTempEnum = ProjectMetricTemp.KELVIN;     // Temperature: "K"

                #region TO EXTERNAL

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_MW_K = ConvertFromInternal(HenTypes.ConversionUnitsTypes.CP, dCP_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dCP_MW_K, 0.004000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.0000000} MW/K .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_MW_K, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 0.004000 MW/K .... FAIL -- {1:0.000} MW/K",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_MW_K, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_MW_K = 0.004000;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.CP, dCP_MW_K, externalUnits, internalUnits);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} MW/K to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_MW_K, 6),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} MW/K to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_MW_C, 6),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // MW-K

                #region BTU-F

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;  // ENGLISH
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.BASE;         // BASE
                externalUnits.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_F;    // Temperature: "°F"

                #region TO EXTERNAL

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_Btu_F = ConvertFromInternal(HenTypes.ConversionUnitsTypes.CP, dCP_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dCP_Btu_F, 7582.520))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000} Btu/(hr °F) .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_Btu_F, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 7582.520 Btu/(hr °F) .... FAIL -- {1:0.000} Btu/(hr °F)",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_Btu_F, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_Btu_F = 7582.520;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.CP, dCP_Btu_F, externalUnits, internalUnits);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} Btu/(hr °F) to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_Btu_F, 3),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} Btu/(hr °F) to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_Btu_F, 3),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // BTU-F

                #region BTU-R

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;  // ENGLISH
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.BASE;         // BASE
                externalUnits.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_R;    // Temperature: "°R"

                #region TO EXTERNAL

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_Btu_R = ConvertFromInternal(HenTypes.ConversionUnitsTypes.CP, dCP_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dCP_Btu_R, 7582.520))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000} Btu/(hr °R) .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_Btu_R, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 7582.520 Btu/(hr °R) .... FAIL -- {1:0.000} Btu/(hr °R)",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_Btu_R, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_Btu_R = 7582.520;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.CP, dCP_Btu_R, externalUnits, internalUnits);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} Btu/(hr °R) to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_Btu_R, 3),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} Btu/(hr °R) to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_Btu_R, 3),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // BTU-R

                #region KBTU-F

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;  // ENGLISH
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.KILO;         // KILO
                externalUnits.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_F;    // Temperature: "°F"

                #region TO EXTERNAL

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_kBtu_F = ConvertFromInternal(HenTypes.ConversionUnitsTypes.CP, dCP_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dCP_kBtu_F, 7.582520))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000000} kBtu/(hr °F) .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_kBtu_F, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 7.582520 kBtu/(hr °F) .... FAIL -- {1:0.000000} kBtu/(hr °F)",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_kBtu_F, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_kBtu_F = 7.582520;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.CP, dCP_kBtu_F, externalUnits, internalUnits);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} kBtu/(hr °F) to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_kBtu_F, 6),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} kBtu/(hr °F) to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_kBtu_F, 6),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // KBTU-F

                #region KBTU-R

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;  // ENGLISH
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.KILO;         // KILO
                externalUnits.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_R;    // Temperature: "°R"

                #region TO EXTERNAL

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_kBtu_R = ConvertFromInternal(HenTypes.ConversionUnitsTypes.CP, dCP_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dCP_kBtu_R, 7.582520))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000000} kBtu/(hr °R) .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_kBtu_R, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 7.582520 kBtu/(hr °R) .... FAIL -- {1:0.000000} kBtu/(hr °R)",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_kBtu_R, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_kBtu_R = 7.582520;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.CP, dCP_kBtu_R, externalUnits, internalUnits);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} kBtu/(hr °R) to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_kBtu_R, 6),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} kBtu/(hr °R) to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_kBtu_R, 6),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // KBTU-R

                #region MMBTU-F

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;  // ENGLISH
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;         // MEGA
                externalUnits.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_F;    // Temperature: "°F"

                #region TO EXTERNAL

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_MMBtu_F = ConvertFromInternal(HenTypes.ConversionUnitsTypes.CP, dCP_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dCP_MMBtu_F, 0.007582520))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000000} MMBtu/(hr °F) .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_MMBtu_F, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 0.007582520 MMBtu/(hr °F) .... FAIL -- {1:0.000000} MMBtu/(hr °F)",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_MMBtu_F, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_MMBtu_F = 0.007582520;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.CP, dCP_MMBtu_F, externalUnits, internalUnits);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} MMBtu/(hr °F) to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_MMBtu_F, 6),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} MMBtu/(hr °F) to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_MMBtu_F, 6),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // MMBTU-F

                #region MMBTU-R

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;  // ENGLISH
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;         // MEGA
                externalUnits.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_R;    // Temperature: "°R"

                #region TO EXTERNAL

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_MMBtu_R = ConvertFromInternal(HenTypes.ConversionUnitsTypes.CP, dCP_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dCP_MMBtu_R, 0.007582520))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000000} MMBtu/(hr °R) .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_MMBtu_R, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 0.007582520 MMBtu/(hr °R) .... FAIL -- {1:0.000000} MMBtu/(hr °R)",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_MMBtu_R, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_MMBtu_R = 0.007582520;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.CP, dCP_MMBtu_R, externalUnits, internalUnits);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} MMBtu/(hr °R) to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_MMBtu_R, 6),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} MMBtu/(hr °R) to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_MMBtu_R, 6),
                                           Math.Round(dCP_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // MMBTU-R

                #endregion  // CP - HEAT CAPACITY FLOW RATE

                #region U - OVERALL HEAT TRANSFER COEFFICIENT

                #region TARGET VALUES
                double dU_W_C = 4000.000;         // EXTERNAL VALUE
                double dU_W_K = 4000.000;         // EXTERNAL VALUE
                double dU_kW_C = 4.000;           // EXTERNAL VALUE
                double dU_kW_K = 4.000;           // << INTERNAL VALUE >>
                double dU_MW_C = 0.004000;        // EXTERNAL VALUE
                double dU_MW_K = 0.004000;        // EXTERNAL VALUE
                double dU_Btu_F = 704.440;        // EXTERNAL VALUE
                double dU_Btu_R = 704.440;        // EXTERNAL VALUE
                double dU_kBtu_F = 0.70444;       // EXTERNAL VALUE
                double dU_kBtu_R = 0.70444;       // EXTERNAL VALUE
                double dU_MMBtu_F = 0.00070444;   // EXTERNAL VALUE
                double dU_MMBtu_R = 0.00070444;   // EXTERNAL VALUE
                #endregion  // TARGET VALUES

                #region W-C

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;  // METRIC
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.BASE;        // BASE
                externalUnits.ProjectMetricTempEnum = ProjectMetricTemp.DEG_C;     // Temperature: "°C"

                #region TO EXTERNAL

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_W_C = ConvertFromInternal(HenTypes.ConversionUnitsTypes.U, dU_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dU_W_C, 4000.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000} W/(m² °C) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_W_C, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 4000.000 W/(m² °C) .... FAIL -- {1:0.000} W/(m² °C)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_W_C, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_W_C = 4000.000;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.U, dU_W_C, externalUnits, internalUnits);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} W/(m² °C) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_W_C, 3),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} W/(m² °C) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_W_C, 3),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // W-C

                #region W-K

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;  // METRIC
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.BASE;        // BASE
                externalUnits.ProjectMetricTempEnum = ProjectMetricTemp.KELVIN;    // Temperature: "K"

                #region TO EXTERNAL

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_W_K = ConvertFromInternal(HenTypes.ConversionUnitsTypes.U, dU_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dU_W_K, 4000.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000} W/(m² K) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_W_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 4000.000 W/(m² K) .... FAIL -- {1:0.000} W/(m² K)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_W_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_W_K = 4000.000;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.U, dU_W_K, externalUnits, internalUnits);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} W/(m² K) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_W_K, 3),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} W/(m² K) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_W_K, 3),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // W-K

                #region KW-C

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;  // METRIC
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.KILO;        // KILO
                externalUnits.ProjectMetricTempEnum = ProjectMetricTemp.DEG_C;     // Temperature: "°C"

                #region TO EXTERNAL

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_kW_C = ConvertFromInternal(HenTypes.ConversionUnitsTypes.U, dU_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dU_kW_C, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000} kW/(m² °C) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_kW_C, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 4.000 kW/(m² °C) .... FAIL -- {1:0.000} kW/(m² °C)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_kW_C, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_kW_C = 4.000;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.U, dU_kW_C, externalUnits, internalUnits);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² °C) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_kW_C, 3),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² °C) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_kW_C, 3),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // KW-C

                #region MW-C

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;  // METRIC
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;        // MEGA
                externalUnits.ProjectMetricTempEnum = ProjectMetricTemp.DEG_C;     // Temperature: "°C"

                #region TO EXTERNAL

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_MW_C = ConvertFromInternal(HenTypes.ConversionUnitsTypes.U, dU_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dU_MW_C, 0.004000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000000} MW/(m² °C) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_MW_C, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 0.004000 MW/(m² °C) .... FAIL -- {1:0.000000} MW/(m² °C)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_MW_C, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_MW_C = 0.004000;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.U, dU_MW_C, externalUnits, internalUnits);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000} MW/(m² °C) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_MW_C, 6),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000} MW/(m² °C) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_MW_C, 6),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // MW-C

                #region MW-K

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;  // METRIC
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;        // MEGA
                externalUnits.ProjectMetricTempEnum = ProjectMetricTemp.KELVIN;     // Temperature: "K"

                #region TO EXTERNAL

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_MW_K = ConvertFromInternal(HenTypes.ConversionUnitsTypes.U, dU_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dU_MW_K, 0.004000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000000} MW/(m² K) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_MW_K, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 0.004000 MW/(m² K) .... FAIL -- {1:0.000000} MW/(m² K)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_MW_K, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_MW_K = 0.004000;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.U, dU_MW_K, externalUnits, internalUnits);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000} MW/(m² K) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_MW_K, 6),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000} MW/(m² K) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_MW_C, 6),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // MW-K

                #region BTU-F

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;  // ENGLISH
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.BASE;         // BASE
                externalUnits.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_F;    // Temperature: "°F"

                #region TO EXTERNAL

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_Btu_F = ConvertFromInternal(HenTypes.ConversionUnitsTypes.U, dU_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dU_Btu_F, 704.440))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000} Btu/(hr ft² °F) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_Btu_F, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 704.440 Btu/(hr ft² °F) .... FAIL -- {1:0.000} Btu/(hr ft² °F)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_Btu_F, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_Btu_F = 704.440;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.U, dU_Btu_F, externalUnits, internalUnits);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} Btu/(hr ft² °F) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_Btu_F, 3),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} Btu/(hr ft² °F) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_Btu_F, 3),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // BTU-F

                #region BTU-R

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;  // ENGLISH
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.BASE;         // BASE
                externalUnits.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_R;    // Temperature: "°R"

                #region TO EXTERNAL

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_Btu_R = ConvertFromInternal(HenTypes.ConversionUnitsTypes.U, dU_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dU_Btu_R, 704.440))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000} Btu/(hr ft² °R) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_Btu_R, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 704.440 Btu/(hr ft² °R) .... FAIL -- {1:0.000} Btu/(hr ft² °R)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_Btu_R, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_Btu_R = 704.440;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.U, dU_Btu_R, externalUnits, internalUnits);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} Btu/(hr ft² °R) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_Btu_R, 3),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} Btu/(hr ft² °R) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_Btu_R, 3),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // BTU-R

                #region KBTU-F

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;  // ENGLISH
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.KILO;         // KILO
                externalUnits.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_F;    // Temperature: "°F"

                #region TO EXTERNAL

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_kBtu_F = ConvertFromInternal(HenTypes.ConversionUnitsTypes.U, dU_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dU_kBtu_F, 0.70444))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000000} kBtu/(hr ft² °F) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_kBtu_F, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 0.70444 kBtu/(hr ft² °F) .... FAIL -- {1:0.000000} kBtu/(hr ft² °F)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_kBtu_F, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_kBtu_F = 0.70444;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.U, dU_kBtu_F, externalUnits, internalUnits);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000} kBtu/(hr ft² °F) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_kBtu_F, 6),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000} kBtu/(hr ft² °F) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_kBtu_F, 6),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // KBTU-F

                #region KBTU-R

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;  // ENGLISH
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.KILO;         // KILO
                externalUnits.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_R;    // Temperature: "°R"

                #region TO EXTERNAL

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_kBtu_R = ConvertFromInternal(HenTypes.ConversionUnitsTypes.U, dU_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dU_kBtu_R, 0.70444))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000000} kBtu/(hr ft² °R) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_kBtu_R, 6));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 0.70444 kBtu/(hr ft² °R) .... FAIL -- {1:0.000000} kBtu/(hr ft² °R)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_kBtu_R, 6));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_kBtu_R = 0.70444;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.U, dU_kBtu_R, externalUnits, internalUnits);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000} kBtu/(hr ft² °R) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_kBtu_R, 6),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000} kBtu/(hr ft² °R) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_kBtu_R, 6),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // KBTU-F

                #region MMBTU-F

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;  // ENGLISH
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;         // MEGA
                externalUnits.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_F;    // Temperature: "°F"

                #region TO EXTERNAL

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_MMBtu_F = ConvertFromInternal(HenTypes.ConversionUnitsTypes.U, dU_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dU_MMBtu_F, 0.00070444))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000000000} MMBtu/(hr ft² °F) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_MMBtu_F, 9));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 0.00070444 MMBtu/(hr ft² °F) .... FAIL -- {1:0.000000000} MMBtu/(hr ft² °F)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_MMBtu_F, 9));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_MMBtu_F = 0.00070444;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.U, dU_MMBtu_F, externalUnits, internalUnits);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000000} MMBtu/(hr ft² °F) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_MMBtu_F, 9),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000000} MMBtu/(hr ft² °F) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_MMBtu_F, 9),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // KBTU-F

                #region MMBTU-R

                externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;  // ENGLISH
                externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;         // MEGA
                externalUnits.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_R;    // Temperature: "°R"

                #region TO EXTERNAL

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_MMBtu_R = ConvertFromInternal(HenTypes.ConversionUnitsTypes.U, dU_kW_K, externalUnits, internalUnits);
                if (CheckForEquality(dU_MMBtu_R, 0.00070444))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000000000} MMBtu/(hr ft² °R) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_MMBtu_R, 9));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 0.00070444 MMBtu/(hr ft² °R) .... FAIL -- {1:0.000000000} MMBtu/(hr ft² °R)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_MMBtu_R, 9));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_MMBtu_R = 0.00070444;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(HenTypes.ConversionUnitsTypes.U, dU_MMBtu_R, externalUnits, internalUnits);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000000} MMBtu/(hr ft² °R) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_MMBtu_R, 9),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000000} MMBtu/(hr ft² °R) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_MMBtu_R, 9),
                                           Math.Round(dU_kW_K, 3));
                    HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                HenLogger.WriteSeparatorLine('-');
                #endregion  // KBTU-R

                #endregion  // U - OVERALL HEAT TRANSFER COEFFICIENT

            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                HenLogger.WriteSeparatorLine('*');
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                strMsg = string.Format("    ===> T E S T   T O T A L S :   PASS: {0}   FAIL: {1}", nPass, nFail);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                HenLogger.WriteSection("END UNIT CONVERSION TEST");
                HenLogger.WriteSeparatorLine(' ');

            }
        }
        #endregion  // TestUnitConversions()

        #endregion  // UNITS CONVERSION METHODS

    }
    #endregion      // public class HenTypes
}
#endregion      // namespace HenGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================