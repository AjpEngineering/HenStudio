#region HEADER
//#####################################################################################################################
//#########################################  P i n c h M e t h o d s . c s  ###########################################
//#####################################################################################################################
//  FILENAME:  PinchMethods.cs
//  NAMESPACE: PinchGlobal
//  CLASS(S):  PinchMethods
//  COMPONENT: _PinchGLobal.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Common Pinch Methods (static).
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
#endregion  // REFERENCES

#region namespace PinchGlobal
namespace PinchGlobal
{
    #region public class PinchMethods
    /// <summary>
    /// Common Global Pinch Methods Class
    /// Contains String Checks, Hash, and Units Conversion methods
    /// </summary>
    public class PinchMethods
    {
        #region CONSTANTS
        const string NAMESPACE = "PinchGlobal";
        const string CLASS = "PinchMethods";

        #endregion      // CONSTANTS

        #region PROPERTIES

        #region PinchSettingsObj
        /// <summary>
        /// PinchSettings Object
        /// </summary>
        public PinchSettings PinchSettingsObj { get; set; }   // PinchSettings Object
        #endregion  // PinchSettingsObj   
        
        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor...NO CTOR for STATIC CLASS
        /// </summary>
        public PinchMethods(PinchSettings pinchSettingsObj)
        {
            string strMethod = "CTOR";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating Object");
            //-------------------------
            //--- Assign Properties ---
            //-------------------------
            PinchSettingsObj = pinchSettingsObj;
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

        #region UNITS METHODS

        #region ConvertToInternal()
        /// <summary>
        /// Convert External data value in External Units to Internal data value in Internal Units
        /// Internal units are used by the Targets and Hen Engines.
        /// External units are customer facing, i.e., UI units (controls)
        /// External Units are set by the user in the INPUT-Project Panel controls
        /// Internal units are set on initial construction and do not change
        /// Both Internal and External units string Properties are contained in PinchSettings
        /// </summary>
        /// <param name="enumConType">Conversion Units Enumeration Type [PinchTypes]</param>
        /// <param name="dExternalValue">External Value to be converted</param>
        /// <returns>Converted internal value now in internal units</returns>
        public double ConvertToInternal(PinchTypes.ConversionUnitsTypes enumConType,
                                        double dExternalValue)
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
                    case PinchTypes.ConversionUnitsTypes.A:
                        if (string.Compare(PinchSettingsObj.InternalArea_Units,
                                           PinchSettingsObj.ExternalArea_Units, true) == 0)
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
                    case PinchTypes.ConversionUnitsTypes.TEMP:
                        if (string.Compare(PinchSettingsObj.InternalTemperatureUnits,
                                           PinchSettingsObj.ExternalTemperatureUnits, true) == 0)
                        {
                            //--- No Need for Conversion - Already (K)! ---
                            dInternalValue = dExternalValue;
                        }
                        else
                        {
                            //--- Convert External Temperature Units to Internal Temperature Units (K) ---
                            switch(PinchSettingsObj.ExternalTemperatureUnits)
                            {
                                case PinchSettings.DEG_F:
                                    //--- Convert [ (°F) to (K)] ] ---
                                    dInternalValue = ((dExternalValue - 32.0) / 1.8) + 273.15;
                                    break;
                                case PinchSettings.DEG_R:
                                    //--- Convert [ (°R) to (K)] ] ---
                                    dInternalValue = ((dExternalValue - 491.67) / 1.8) + 273.15;
                                    break;
                                case PinchSettings.DEG_C:
                                    //--- Convert [ (°C) to (K)] ] ---
                                    dInternalValue = (dExternalValue + 273.15);
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Temperature Units ENCOUNTERED!  {0}",
                                                            PinchSettingsObj.ExternalTemperatureUnits);
                                    throw new Exception(strMsg);
                            }
                        }
                        break;
                    #endregion  // T - TEMPERATURE

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
                    case PinchTypes.ConversionUnitsTypes.HEAT_FLOW:
                        if (string.Compare(PinchSettingsObj.InternalUnitsSystem,
                                           PinchSettingsObj.ExternalUnitsSystem, true) == 0)
                        {
                            #region METRIC
                            //----------------------------------------------------------
                            //--- Convert External Heat Flow Units (W) | (kW) | (MW) ---
                            //--- to Internal Heat Flow Units (kW)                   ---
                            //----------------------------------------------------------
                            switch (PinchSettingsObj.ExternalMagUnits)
                            {
                                case PinchSettings.MAG_BASE:
                                    //--- Convert W to kW ---
                                    dInternalValue = dExternalValue * 0.001;
                                    break;
                                case PinchSettings.MAG_KILO:
                                    //--- No Conversion Needed - Already (kW) ! ---
                                    dInternalValue = dExternalValue;
                                    break;
                                case PinchSettings.MAG_MEGA:
                                    //--- Convert MW to kW ---
                                    dInternalValue = dExternalValue * 1000.0;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            PinchSettingsObj.ExternalMagUnits);
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
                            switch (PinchSettingsObj.ExternalMagUnits)
                            {
                                case PinchSettings.MAG_BASE:
                                    //--- Convert (Btu/hr) to (kW) ---
                                    dInternalValue = dExternalValue * 0.000293071;
                                    break;
                                case PinchSettings.MAG_KILO:
                                    //--- Convert kBtu/hr) to (kW) ---
                                    dInternalValue = dExternalValue * 0.293071071;
                                    break;
                                case PinchSettings.MAG_MEGA:
                                    //--- Convert (MMBtu/hr) to (kW) ---
                                    dInternalValue = dExternalValue * 293.071071;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            PinchSettingsObj.ExternalMagUnits);
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
                    case PinchTypes.ConversionUnitsTypes.CP:
                        if (string.Compare(PinchSettingsObj.InternalUnitsSystem,
                                           PinchSettingsObj.ExternalUnitsSystem, true) == 0)
                        {
                            #region METRIC
                            //--------------------------------------------------------------
                            //--- Convert External CP Units (W/K)  | (kW/K)  | (MW/K)  | ---
                            //---                           (W/°C) | (kW/°C) | (MW/°C) | ---
                            //--- to Internal CP Units (kW/K)                            ---
                            //--------------------------------------------------------------
                            switch (PinchSettingsObj.ExternalMagUnits)
                            {
                                case PinchSettings.MAG_BASE:
                                    //--- Convert [ (W/°C) to (kW/K)] | [(W/K) to (kW/K) ] ---
                                    //--- °C or K both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 0.001;
                                    break;
                                case PinchSettings.MAG_KILO:
                                    //--- No Conversion Needed - Already (kW/K) ! ---
                                    dInternalValue = dExternalValue;
                                    break;
                                case PinchSettings.MAG_MEGA:
                                    //--- Convert [ (MW/°C) to (kW/K)] | [(MW/K) to (kW/K) ] ---
                                    //--- °C or K both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 1000.0;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            PinchSettingsObj.ExternalMagUnits);
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
                            switch (PinchSettingsObj.ExternalMagUnits)
                            {
                                case PinchSettings.MAG_BASE:
                                    //--- Convert [ (Btu/(hr °F) to (kW/K)] | (Btu/(hr °R) to (kW/K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 0.000527529;
                                    break;
                                case PinchSettings.MAG_KILO:
                                    //--- Convert [ (kBtu/(hr °F) to (kW/K)] | (kBtu/(hr °R) to (kW/K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 0.527529;
                                    break;
                                case PinchSettings.MAG_MEGA:
                                    //--- Convert [ (MMBtu/(hr °F) to (kW/K)] | (MMBtu/(hr °R) to (kW/K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 527.5291;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            PinchSettingsObj.ExternalMagUnits);
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
                    case PinchTypes.ConversionUnitsTypes.U:
                        if (string.Compare(PinchSettingsObj.InternalUnitsSystem,
                                           PinchSettingsObj.ExternalUnitsSystem, true) == 0)
                        {
                            #region METRIC
                            //----------------------------------------------------------------------
                            //--- Convert External U Units (W/(m²K)  | (kW/(m²K)  | (MW/(m²K)  | ---
                            //---                          (W/(m²°C) | (kW/(m²°C) | (MW/(m²°C) | ---
                            //--- to Internal U Units (kW/(m²K)                                  ---
                            //----------------------------------------------------------------------
                            switch (PinchSettingsObj.ExternalMagUnits)
                            {
                                case PinchSettings.MAG_BASE:
                                    //--- Convert [ (W/(m²°C) to (kW/(m²K) | (W/(m²K) to (kW/(m²K) ] ---
                                    //--- °C or K both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 0.001;
                                    break;
                                case PinchSettings.MAG_KILO:
                                    //--- No Conversion Needed - Already (kW/(m²K)! ---
                                    dInternalValue = dExternalValue;
                                    break;
                                case PinchSettings.MAG_MEGA:
                                    //--- Convert [ (MW/(m²°C) to (kW/(m²K) | (MW/(m²K) to (kW/(m²K) ] ---
                                    //--- °C or K both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 1000.0;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            PinchSettingsObj.ExternalMagUnits);
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
                            switch (PinchSettingsObj.ExternalMagUnits)
                            {
                                case PinchSettings.MAG_BASE:
                                    //--- Convert [ (Btu/(hr ft² °F) to (kW/(m²K) | (Btu/(hr ft² °R) to (kW/(m²K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 0.005678263;
                                    break;
                                case PinchSettings.MAG_KILO:
                                    //--- Convert [ (kBtu/(hr ft² °F) to (kW/(m²K) | (kBtu/(hr ft² °R) to (kW/(m²K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 5.678263;
                                    break;
                                case PinchSettings.MAG_MEGA:
                                    //--- Convert [ (MMBtu/(hr ft² °F) to (kW/(m²K) | (MMBtu/(hr ft² °R) to (kW/(m²K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 5678.263;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            PinchSettingsObj.ExternalMagUnits);
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
                PinchLogger.WriteSeparatorLine('*');
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                PinchLogger.WriteSeparatorLine('*');
            }
            return dInternalValue;
        }
        #endregion  // ConvertToInternal()

        #region ConvertFromInternal()
        /// <summary>
        /// Convert Internal data value in Internal Units to External data value in External Units
        /// Internal units are used by the Targets and Hen Engines.
        /// External units are customer facing, i.e., UI units (controls)
        /// External Units are set by the user in the INPUT-Project Panel controls
        /// Internal units are set on initial construction and do not change
        /// Both Internal and External units string Properties are contained in PinchSettings
        /// </summary>
        /// <param name="enumConType">Conversion Units Enumeration Type [PinchTypes]</param>
        /// <param name="dInternalValued">Internal Value to be converted</param>
        /// <returns>Converted external value now in external units</returns>
        public double ConvertFromInternal(PinchTypes.ConversionUnitsTypes enumConType,
                                          double dInternalValue)
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
                    case PinchTypes.ConversionUnitsTypes.A:
                        if (string.Compare(PinchSettingsObj.InternalArea_Units,
                                           PinchSettingsObj.ExternalArea_Units, true) == 0)
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
                    case PinchTypes.ConversionUnitsTypes.TEMP:
                        if (string.Compare(PinchSettingsObj.InternalTemperatureUnits,
                                           PinchSettingsObj.ExternalTemperatureUnits, true) == 0)
                        {
                            //--- No Need for Conversion - Already (K)! ---
                            dExternalValue = dInternalValue;
                        }
                        else
                        {
                            //--- Convert Internal Temperature Units (K) to External Temperature Units ---
                            switch (PinchSettingsObj.ExternalTemperatureUnits)
                            {
                                case PinchSettings.DEG_F:
                                    //--- Convert [ (K) to (°F) ] ---
                                    dExternalValue = ((dInternalValue - 273.15) * 1.8) + 32.0;
                                    break;
                                case PinchSettings.DEG_R:
                                    //--- Convert [ (K) to (°R) ] ---
                                    dExternalValue = (dInternalValue * 1.8);
                                    break;
                                case PinchSettings.DEG_C:
                                    //--- Convert [ (K) to (°C) ] ---
                                    dExternalValue = (dInternalValue - 273.15);
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Temperature Units ENCOUNTERED!  {0}",
                                                            PinchSettingsObj.ExternalTemperatureUnits);
                                    throw new Exception(strMsg);
                            }
                        }
                        break;
                    #endregion  // T - TEMPERATURE

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
                    case PinchTypes.ConversionUnitsTypes.HEAT_FLOW:
                        if (string.Compare(PinchSettingsObj.InternalUnitsSystem,
                                           PinchSettingsObj.ExternalUnitsSystem, true) == 0)
                        {
                            #region METRIC
                            //-----------------------------------------------------
                            //--- Convert Internal Heat Flow Units (kW)         ---
                            //--- to External Heat Flow Units (W) | (kW) | (MW) ---
                            //-----------------------------------------------------
                            switch (PinchSettingsObj.ExternalMagUnits)
                            {
                                case PinchSettings.MAG_BASE:
                                    //--- Convert kW to W ---
                                    dExternalValue = dInternalValue * 1000.0;
                                    break;
                                case PinchSettings.MAG_KILO:
                                    //--- No Conversion Needed - Already (kW) ! ---
                                    dExternalValue = dInternalValue;
                                    break;
                                case PinchSettings.MAG_MEGA:
                                    //--- Convert kW to MW ---
                                    dExternalValue = dInternalValue * 0.001;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            PinchSettingsObj.ExternalMagUnits);
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
                            switch (PinchSettingsObj.ExternalMagUnits)
                            {
                                case PinchSettings.MAG_BASE:
                                    //--- Convert (kW) to (Btu/hr) ---
                                    dExternalValue = dInternalValue * 3412.142;
                                    break;
                                case PinchSettings.MAG_KILO:
                                    //--- Convert (kW) to (kBtu/hr) ---
                                    dExternalValue = dInternalValue * 3.412142;
                                    break;
                                case PinchSettings.MAG_MEGA:
                                    //--- Convert (kW) to (MMBtu/hr) ---
                                    dExternalValue = dInternalValue * 0.003412142;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            PinchSettingsObj.ExternalMagUnits);
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
                    case PinchTypes.ConversionUnitsTypes.CP:
                        if (string.Compare(PinchSettingsObj.InternalUnitsSystem,
                                           PinchSettingsObj.ExternalUnitsSystem, true) == 0)
                        {
                            #region METRIC
                            //--------------------------------------------------------------
                            //--- Convert External CP Units (W/K)  | (kW/K)  | (MW/K)  | ---
                            //---                           (W/°C) | (kW/°C) | (MW/°C) | ---
                            //--- to Internal CP Units (kW/K)                            ---
                            //--------------------------------------------------------------
                            switch (PinchSettingsObj.ExternalMagUnits)
                            {
                                case PinchSettings.MAG_BASE:
                                    //--- Convert [ (kW/K) to (W/°C) ] | [ (kW/K) to (W/K) ] ---
                                    //--- °C or K both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 1000.0;
                                    break;
                                case PinchSettings.MAG_KILO:
                                    //--- No Conversion Needed - Already (kW/K) ! ---
                                    dExternalValue = dInternalValue;
                                    break;
                                case PinchSettings.MAG_MEGA:
                                    //--- Convert [ (kW/K) to (MW/°C) ] | [ (kW/K) to (MW/K) ] ---
                                    //--- °C or K both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 0.001;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            PinchSettingsObj.ExternalMagUnits);
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
                            switch (PinchSettingsObj.ExternalMagUnits)
                            {
                                case PinchSettings.MAG_BASE:
                                    //--- Convert [ (Btu/(hr °F) to (kW/K) ] | [ (Btu/(hr °R) to (kW/K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 1895.630;
                                    break;
                                case PinchSettings.MAG_KILO:
                                    //--- Convert [ (kBtu/(hr °F) to (kW/K) ] | [ (kBtu/(hr °R) to (kW/K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 1.895630;
                                    break;
                                case PinchSettings.MAG_MEGA:
                                    //--- Convert [ (MMBtu/(hr °F) to (kW/K) ] | [ (MMBtu/(hr °R) to (kW/K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 0.00189563;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            PinchSettingsObj.ExternalMagUnits);
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
                    case PinchTypes.ConversionUnitsTypes.U:
                        if (string.Compare(PinchSettingsObj.InternalUnitsSystem,
                                           PinchSettingsObj.ExternalUnitsSystem, true) == 0)
                        {
                            #region METRIC
                            //----------------------------------------------------------------------
                            //--- Convert External U Units (W/(m²K)  | (kW/(m²K)  | (MW/(m²K)  | ---
                            //---                          (W/(m²°C) | (kW/(m²°C) | (MW/(m²°C) | ---
                            //--- to Internal U Units (kW/(m²K)                                  ---
                            //----------------------------------------------------------------------
                            switch (PinchSettingsObj.ExternalMagUnits)
                            {
                                case PinchSettings.MAG_BASE:
                                    //--- Convert [ (kW/(m²K)) to (W/(m²°C)) | (kW/(m²K)) to (W/(m²K)) ] ---
                                    //--- °C or K both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 1000.0;
                                    break;
                                case PinchSettings.MAG_KILO:
                                    //--- No Conversion Needed - Already (kW/(m²K)! ---
                                    dExternalValue = dInternalValue;
                                    break;
                                case PinchSettings.MAG_MEGA:
                                    //--- Convert [ (kW/(m²K)) to (MW/(m²°C)) | (kW/(m²K)) to (MW/(m²K)) ] ---
                                    //--- °C or K both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 0.001;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            PinchSettingsObj.ExternalMagUnits);
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
                            switch (PinchSettingsObj.ExternalMagUnits)
                            {
                                case PinchSettings.MAG_BASE:
                                    //--- Convert [ (kW/(m²K) to (Btu/(hr ft² °F) | (kW/(m²K) to (Btu/(hr ft² °R) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 176.11;
                                    break;
                                case PinchSettings.MAG_KILO:
                                    //--- Convert [ (kW/(m²K) to (kBtu/(hr ft² °F) | (kW/(m²K) to (kBtu/(hr ft² °R) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 0.17611;
                                    break;
                                case PinchSettings.MAG_MEGA:
                                    //--- Convert [ (kW/(m²K) to (MMBtu/(hr ft² °F) | (kW/(m²K) to (MMBtu/(hr ft² °R) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 0.00017611;
                                    break;
                                default:
                                    strMsg = string.Format("Unknown External Magnitude Units ENCOUNTERED!  {0}",
                                                            PinchSettingsObj.ExternalMagUnits);
                                    throw new Exception(strMsg);
                            }
                            #endregion  // ENGLISH
                        }
                        break;
                    #endregion  // U - OVERALL HEAT TRANSFER COEFFICIENT

                    #region UNKNOWN
                    default:
                        strMsg = string.Format("Unknown Units Conversion Type ENCOUNTERED!  {0}",
                                                enumConType.ToString() );
                        throw new Exception(strMsg);
                    #endregion  // UNKNOWN
                }
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                PinchLogger.WriteSeparatorLine('*');
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                PinchLogger.WriteSeparatorLine('*');
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
                PinchLogger.WriteSeparatorLine(' ');
                PinchLogger.WriteSection("START UNIT CONVERSION TEST");

                #region USER SETS EXTERNAL UNITS
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.ENGLISH_UNITS;      // System:      "ENGLISH"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_MEGA;              // Magnitude:   "MEGA"
                PinchSettingsObj.ExternalHeatFlowUnits = PinchSettings.MMBTU_HEAT_FLOW;  // Heat Flow:   "MMBtu/hr"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_F;         // Temperature: "°F"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.MMBTU_F_CP;            // CP:          "MMBtu/(hr °F)"
                PinchSettingsObj.ExternalU_Units = PinchSettings.MMBTU_F_U;              // U:           "MMBtu/(hr ft² °F)"
                PinchSettingsObj.ExternalArea_Units = PinchSettings.SqFt;                // Area:        "ft²"
                #endregion  // USER SETS EXTERNAL UNITS

                #region A - AREA

                #region TARGET VALUES
                double dAreaSqM  = 400.00;      // << INTERNAL VALUE >>
                double dAreaSqFt = 4305.56417;  // EXTERNAL VALUE
                #endregion  // TARGET VALUES

                #region TO EXTERNAL
                dAreaSqM = 400.0;     // Set INTERNAL VALUE
                dAreaSqFt = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.A, dAreaSqM);
                if (CheckForEquality(dAreaSqFt, 4305.56417))
                {
                    nPass++;
                    strMsg = string.Format("AREA CONVERSION TEST -> {0:0.000} m² to {1:0.000} ft² .... PASS",
                                            Math.Round(dAreaSqM,3), 
                                            Math.Round(dAreaSqFt,3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("AREA CONVERSION TEST -> {0:0.000} m² to 4305.564 ft² .... FAIL -- {1:0.000} ft²",
                                            Math.Round(dAreaSqM, 3),
                                            Math.Round(dAreaSqFt, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dAreaSqFt = 4305.564167;  // Set EXTERNAL VALUE
                dAreaSqM = ConvertToInternal(PinchTypes.ConversionUnitsTypes.A, dAreaSqFt);
                if (CheckForEquality(dAreaSqM, 400.0))
                {
                    nPass++;
                    strMsg = string.Format("AREA CONVERSION TEST -> {0:0.000} ft² to {1:0.000} m² .... PASS",
                                           Math.Round(dAreaSqFt, 3),
                                           Math.Round(dAreaSqM, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("AREA CONVERSION TEST -> {0:0.000} ft² to 400.000 m² .... FAIL -- {1:0.000} m²",
                                           Math.Round(dAreaSqFt, 3), 
                                           Math.Round(dAreaSqM, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
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
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_C;  // Celsius: "°C"

                dTempK = 400.0;     // Set INTERNAL VALUE
                dTempC = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.TEMP, dTempK);
                if (CheckForEquality(dTempC, 126.85))
                {
                    nPass++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} K to {1:0.00} °C .... PASS",
                                            Math.Round(dTempK, 2),
                                            Math.Round(dTempC, 2));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} K to 126.85 °C .... FAIL -- {1:0.00} °C",
                                            Math.Round(dTempK, 2), 
                                            Math.Round(dTempC, 2));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dTempC = 126.85;  // Set EXTERNAL VALUE
                dTempK = ConvertToInternal(PinchTypes.ConversionUnitsTypes.TEMP, dTempC);
                if (CheckForEquality(dTempK, 400.00))
                {
                    nPass++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} °C to {1:0.00} K .... PASS",
                                           Math.Round(dTempC, 2),
                                           Math.Round(dTempK, 2));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} °C to 400.00 K .... FAIL -- {1:0.00} K",
                                           Math.Round(dTempC, 2),
                                           Math.Round(dTempK, 2));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // CELSIUS

                #region FAHRENHEIT

                #region TO EXTERNAL
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_F;  // Fahrenheit "°F"

                dTempK = 400.0;     // Set INTERNAL VALUE
                dTempF = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.TEMP, dTempK);
                if (CheckForEquality(dTempF, 260.33))
                {
                    nPass++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} K to {1:0.00} °F .... PASS",
                                            Math.Round(dTempK,2),
                                            Math.Round(dTempF, 2));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} K to 260.33 °F .... FAIL -- {1:0.00} °F",
                                            Math.Round(dTempK, 2),
                                            Math.Round(dTempF, 2));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dTempF = 260.33;  // Set EXTERNAL VALUE
                dTempK = ConvertToInternal(PinchTypes.ConversionUnitsTypes.TEMP, dTempF);
                if (CheckForEquality(dTempK, 400.00))
                {
                    nPass++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} °F to {1:0.00} K .... PASS",
                                           Math.Round(dTempF, 2),
                                           Math.Round(dTempK, 2));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} °F to 400.00 K .... FAIL -- {1:0.00} K",
                                           Math.Round(dTempF, 2),
                                           Math.Round(dTempK, 2));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // FAHRENHEIT

                #region RANKINE

                #region TO EXTERNAL
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_R;  // Rankine "°R"

                dTempK = 400.0;     // Set INTERNAL VALUE
                dTempR = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.TEMP, dTempK);
                if (CheckForEquality(dTempR, 720.00))
                {
                    nPass++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} K to {1:0.00} °R .... PASS",
                                            Math.Round(dTempK,2),
                                            Math.Round(dTempR, 2));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} K to 720.00 °R .... FAIL -- {1:0.00} °R",
                                            Math.Round(dTempK, 2),
                                            Math.Round(dTempR, 2));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dTempR = 720.00;  // Set EXTERNAL VALUE
                dTempK = ConvertToInternal(PinchTypes.ConversionUnitsTypes.TEMP, dTempR);
                if (CheckForEquality(dTempK, 400.00))
                {
                    nPass++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} °R to {1:0.00} K .... PASS",
                                           Math.Round(dTempR, 2),
                                           Math.Round(dTempK, 2));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("TEMPERATURE CONVERSION TEST -> {0:0.00} °R to 400.00 K .... FAIL -- {1:0.00} K",
                                           Math.Round(dTempR, 2),
                                           Math.Round(dTempK, 2));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // RANKINE

                #endregion  // T - TEMPERATURE

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

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.METRIC_UNITS;   // System: "METRIC"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_BASE;          // Magnitude: "BASE"
                PinchSettingsObj.ExternalHeatFlowUnits = PinchSettings.W_HEAT_FLOW;  // Heat Flow: "W"

                dHeatFlowkW = 4.000;     // Set INTERNAL VALUE
                dHeatFlowW = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowkW);
                if (CheckForEquality(dHeatFlowW, 4000.000))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to {1:0.000} W .... PASS",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowW, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to 4000.000 W .... FAIL -- {1:0.000} W",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowW, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dHeatFlowW = 4000.000;  // Set EXTERNAL VALUE
                dHeatFlowkW = ConvertToInternal(PinchTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowW);
                if (CheckForEquality(dHeatFlowkW, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} W to {1:0.000} kW .... PASS",
                                           Math.Round(dHeatFlowW, 3),
                                           Math.Round(dHeatFlowkW, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} W to 400.000 kW .... FAIL -- {1:0.000} kW",
                                           Math.Round(dHeatFlowW, 3),
                                           Math.Round(dHeatFlowkW, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // W

                #region MW

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.METRIC_UNITS;    // System: "METRIC"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_MEGA;           // Magnitude: "MEGA"
                PinchSettingsObj.ExternalHeatFlowUnits = PinchSettings.MW_HEAT_FLOW;  // Heat Flow: "MW"

                dHeatFlowkW = 4.000;     // Set INTERNAL VALUE
                dHeatFlowMW = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowkW);
                if (CheckForEquality(dHeatFlowMW, 0.0040))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to {1:0.0000} MW .... PASS",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowMW, 4));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to 0.0040 W .... FAIL -- {1:0.0000} W",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowMW, 4));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dHeatFlowMW = 0.0040;  // Set EXTERNAL VALUE
                dHeatFlowkW = ConvertToInternal(PinchTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowMW);
                if (CheckForEquality(dHeatFlowkW, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.0000} MW to {1:0.000} kW .... PASS",
                                           Math.Round(dHeatFlowMW, 4),
                                           Math.Round(dHeatFlowkW, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.0000} MW to 4.000 kW .... FAIL -- {1:0.000} kW",
                                           Math.Round(dHeatFlowMW, 4),
                                           Math.Round(dHeatFlowkW, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');

                #endregion  // MW

                #region BTU/HR

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.ENGLISH_UNITS;    // System: "ENGLISH"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_BASE;            // Magnitude: "BASE"
                PinchSettingsObj.ExternalHeatFlowUnits = PinchSettings.BTU_HEAT_FLOW;  // Heat Flow: "Btu/hr"

                dHeatFlowkW = 4.000;     // Set INTERNAL VALUE
                dHeatFlowBtu = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowkW);
                if (CheckForEquality(dHeatFlowBtu, 13648.568))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to {1:0.000} Btu/hr .... PASS",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowBtu, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to 13648.568 Btu/hr .... FAIL -- {1:0.000} Btu/hr",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowBtu, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dHeatFlowBtu = 13648.568;  // Set EXTERNAL VALUE
                dHeatFlowkW = ConvertToInternal(PinchTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowBtu);
                if (CheckForEquality(dHeatFlowkW, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} Btu/hr to {1:0.000} kW .... PASS",
                                           Math.Round(dHeatFlowBtu, 3),
                                           Math.Round(dHeatFlowkW, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} Btu/hr to 4.000 kW .... FAIL -- {1:0.000} Btu/hr",
                                           Math.Round(dHeatFlowBtu, 3),
                                           Math.Round(dHeatFlowkW, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // #region BTU/HR

                #region kBTU/HR

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.ENGLISH_UNITS;    // System: "ENGLISH"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_KILO;            // Magnitude: "KILO"
                PinchSettingsObj.ExternalHeatFlowUnits = PinchSettings.KBTU_HEAT_FLOW;  // Heat Flow: "kBtu/hr"

                dHeatFlowkW = 4.000;     // Set INTERNAL VALUE
                dHeatFlowkBtu = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowkW);
                if (CheckForEquality(dHeatFlowkBtu, 13.6486))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to {1:0.0000} kBtu/hr .... PASS",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowkBtu, 4));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to 13.6486 kBtu/hr .... FAIL -- {1:0.0000} kBtu/hr",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowkBtu, 4));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dHeatFlowkBtu = 13.6486;  // Set EXTERNAL VALUE
                dHeatFlowkW = ConvertToInternal(PinchTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowkBtu);
                if (CheckForEquality(dHeatFlowkW, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.0000} kBtu/hr to {1:0.000} kW .... PASS",
                                           Math.Round(dHeatFlowkBtu, 4),
                                           Math.Round(dHeatFlowkW, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.0000} kBtu/hr to 4.000 kW .... FAIL -- {1:0.0000} kBtu/hr",
                                           Math.Round(dHeatFlowkBtu, 4),
                                           Math.Round(dHeatFlowkW, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // #region kBTU/HR

                #region MMBTU/HR

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.ENGLISH_UNITS;      // System: "ENGLISH"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_MEGA;              // Magnitude: "MEGA"
                PinchSettingsObj.ExternalHeatFlowUnits = PinchSettings.MMBTU_HEAT_FLOW;  // Heat Flow: "MMBtu/hr"

                dHeatFlowkW = 4.000;     // Set INTERNAL VALUE
                dHeatFlowMMBtu = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowkW);
                if (CheckForEquality(dHeatFlowMMBtu, 0.0136486))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to {1:0.000000} MMBtu/hr .... PASS",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowMMBtu, 6));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000} kW to 0.0136486 MMBtu/hr .... FAIL -- {1:0.000000} MMBtu/hr",
                                            Math.Round(dHeatFlowkW, 3),
                                            Math.Round(dHeatFlowMMBtu, 6));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dHeatFlowMMBtu = 0.0136486;  // Set EXTERNAL VALUE
                dHeatFlowkW = ConvertToInternal(PinchTypes.ConversionUnitsTypes.HEAT_FLOW, dHeatFlowMMBtu);
                if (CheckForEquality(dHeatFlowkW, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000000} MMBtu/hr to {1:0.000} kW .... PASS",
                                           Math.Round(dHeatFlowMMBtu, 6),
                                           Math.Round(dHeatFlowkW, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("HEAT FLOW CONVERSION TEST -> {0:0.000000} MMBtu/hr to 4.000 kW .... FAIL -- {1:0.000} MMBtu/hr",
                                           Math.Round(dHeatFlowMMBtu, 6),
                                           Math.Round(dHeatFlowkW, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
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

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.METRIC_UNITS;   // System: "METRIC"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_BASE;          // Magnitude: "BASE"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_C;     // Temperature: "°C"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.W_C_CP;            // CP: "W/°C"

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_W_C = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_kW_K);
                if (CheckForEquality(dCP_W_C, 4000.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000} W/°C .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_W_C, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 4000.000 W/°C .... FAIL -- {1:0.000} W/°C",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_W_C, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_W_C = 4000.000;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_W_C);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} W/°C to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_W_C, 3),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} W/°C to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_W_C, 3),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // W-C

                #region W-K

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.METRIC_UNITS;   // System: "METRIC"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_BASE;          // Magnitude: "BASE"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.KELVIN;    // Temperature: "K"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.W_K_CP;            // CP: "W/K"

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_W_K = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_kW_K);
                if (CheckForEquality(dCP_W_K, 4000.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000} W/K .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_W_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 4000.000 W/K .... FAIL -- {1:0.000} W/°C",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_W_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_W_K = 4000.000;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_W_K);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} W/K to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_W_K, 3),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} W/K to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_W_K, 3),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // W-K

                #region KW-C

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.METRIC_UNITS;   // System: "METRIC"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_KILO;          // Magnitude: "KILO"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_C;     // Temperature: "°C"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.KW_C_CP;           // CP: "kW/°C"

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_kW_C = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_kW_K);
                if (CheckForEquality(dCP_kW_C, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000} kW/°C .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_kW_C, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 4.000 kW/°C .... FAIL -- {1:0.000} kW/°C",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_kW_C, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_kW_C = 4.000;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_kW_C);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/°C to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_kW_C, 3),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/°C to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_kW_C, 3),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // KW-C

                #region MW-C

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.METRIC_UNITS;   // System: "METRIC"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_MEGA;          // Magnitude: "MEGA"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_C;     // Temperature: "°C"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.MW_C_CP;           // CP: "MW/°C"

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_MW_C = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_kW_K);
                if (CheckForEquality(dCP_MW_C, 0.004000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.0000000} MW/°C .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_MW_C, 6));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 0.004000 MW/°C .... FAIL -- {1:0.000} MW/°C",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_MW_C, 6));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_MW_C = 0.004000;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_MW_C);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} MW/°C to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_MW_C, 6),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} MW/°C to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_MW_C, 6),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // MW-C

                #region MW-K

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.METRIC_UNITS;   // System: "METRIC"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_MEGA;          // Magnitude: "MEGA"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.KELVIN;    // Temperature: "K"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.MW_K_CP;           // CP: "MW/K"

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_MW_K = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_kW_K);
                if (CheckForEquality(dCP_MW_K, 0.004000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.0000000} MW/K .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_MW_K, 6));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 0.004000 MW/K .... FAIL -- {1:0.000} MW/K",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_MW_K, 6));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_MW_K = 0.004000;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_MW_K);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} MW/K to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_MW_K, 6),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} MW/K to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_MW_C, 6),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // MW-K

                #region BTU-F

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.ENGLISH_UNITS;  // System: "ENGLISH"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_BASE;          // Magnitude: "BASE"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_F;     // Temperature: "°F"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.BTU_F_CP;          // CP: "Btu/(hr °F)"

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_Btu_F = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_kW_K);
                if (CheckForEquality(dCP_Btu_F, 7582.520))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000} Btu/(hr °F) .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_Btu_F, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 7582.520 Btu/(hr °F) .... FAIL -- {1:0.000} Btu/(hr °F)",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_Btu_F, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_Btu_F = 7582.520;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_Btu_F);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} Btu/(hr °F) to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_Btu_F, 3),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} Btu/(hr °F) to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_Btu_F, 3),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // BTU-F

                #region BTU-R

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.ENGLISH_UNITS;  // System: "ENGLISH"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_BASE;          // Magnitude: "BASE"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_R;     // Temperature: "°R"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.BTU_R_CP;          // CP: "Btu/(hr °R)"

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_Btu_R = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_kW_K);
                if (CheckForEquality(dCP_Btu_R, 7582.520))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000} Btu/(hr °R) .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_Btu_R, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 7582.520 Btu/(hr °R) .... FAIL -- {1:0.000} Btu/(hr °R)",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_Btu_R, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_Btu_R = 7582.520;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_Btu_R);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} Btu/(hr °R) to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_Btu_R, 3),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} Btu/(hr °R) to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_Btu_R, 3),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // BTU-R

                #region KBTU-F

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.ENGLISH_UNITS;  // System: "ENGLISH"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_KILO;          // Magnitude: "KILO"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_F;     // Temperature: "°F"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.KBTU_F_CP;         // CP: "kBtu/(hr °F)"

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_kBtu_F = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_kW_K);
                if (CheckForEquality(dCP_kBtu_F, 7.582520))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000000} kBtu/(hr °F) .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_kBtu_F, 6));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 7.582520 kBtu/(hr °F) .... FAIL -- {1:0.000000} kBtu/(hr °F)",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_kBtu_F, 6));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_kBtu_F = 7.582520;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_kBtu_F);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} kBtu/(hr °F) to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_kBtu_F, 6),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} kBtu/(hr °F) to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_kBtu_F, 6),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // KBTU-F

                #region KBTU-R

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.ENGLISH_UNITS;  // System: "ENGLISH"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_KILO;          // Magnitude: "KILO"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_R;     // Temperature: "°R"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.KBTU_R_CP;         // CP: "kBtu/(hr °R)"

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_kBtu_R = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_kW_K);
                if (CheckForEquality(dCP_kBtu_R, 7.582520))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000000} kBtu/(hr °R) .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_kBtu_R, 6));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 7.582520 kBtu/(hr °R) .... FAIL -- {1:0.000000} kBtu/(hr °R)",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_kBtu_R, 6));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_kBtu_R = 7.582520;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_kBtu_R);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} kBtu/(hr °R) to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_kBtu_R, 6),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} kBtu/(hr °R) to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_kBtu_R, 6),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // KBTU-R

                #region MMBTU-F

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.ENGLISH_UNITS;  // System: "ENGLISH"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_MEGA;          // Magnitude: "MEGA"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_F;     // Temperature: "°F"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.MMBTU_F_CP;        // CP: "MMBtu/(hr °F)"

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_MMBtu_F = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_kW_K);
                if (CheckForEquality(dCP_MMBtu_F, 0.007582520))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000000} MMBtu/(hr °F) .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_MMBtu_F, 6));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 0.007582520 MMBtu/(hr °F) .... FAIL -- {1:0.000000} MMBtu/(hr °F)",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_MMBtu_F, 6));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_MMBtu_F = 0.007582520;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_MMBtu_F);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} MMBtu/(hr °F) to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_MMBtu_F, 6),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} MMBtu/(hr °F) to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_MMBtu_F, 6),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // MMBTU-F

                #region MMBTU-R

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.ENGLISH_UNITS;  // System: "ENGLISH"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_MEGA;          // Magnitude: "MEGA"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_R;     // Temperature: "°R"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.MMBTU_R_CP;        // CP: "MMBtu/(hr °R)"

                dCP_kW_K = 4.000;     // Set INTERNAL VALUE
                dCP_MMBtu_R = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_kW_K);
                if (CheckForEquality(dCP_MMBtu_R, 0.007582520))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to {1:0.000000} MMBtu/(hr °R) .... PASS",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_MMBtu_R, 6));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000} kW/K to 0.007582520 MMBtu/(hr °R) .... FAIL -- {1:0.000000} MMBtu/(hr °R)",
                                            Math.Round(dCP_kW_K, 3),
                                            Math.Round(dCP_MMBtu_R, 6));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dCP_MMBtu_R = 0.007582520;  // Set EXTERNAL VALUE
                dCP_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.CP, dCP_MMBtu_R);
                if (CheckForEquality(dCP_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} MMBtu/(hr °R) to {1:0.000} kW/K .... PASS",
                                           Math.Round(dCP_MMBtu_R, 6),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("CP - HEAT CAPACITY FLOW RATE CONVERSION TEST -> {0:0.000000} MMBtu/(hr °R) to 4.000 kW/K .... FAIL -- {1:0.000} kW/K",
                                           Math.Round(dCP_MMBtu_R, 6),
                                           Math.Round(dCP_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
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

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.METRIC_UNITS;   // System: "METRIC"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_BASE;          // Magnitude: "BASE"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_C;     // Temperature: "°C"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.W_C_U;             // U: "W/(m² °C)"

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_W_C = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.U, dU_kW_K);
                if (CheckForEquality(dU_W_C, 4000.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000} W/(m² °C) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_W_C, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 4000.000 W/(m² °C) .... FAIL -- {1:0.000} W/(m² °C)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_W_C, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_W_C = 4000.000;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.U, dU_W_C);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} W/(m² °C) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_W_C, 3),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} W/(m² °C) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_W_C, 3),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // W-C

                #region W-K

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.METRIC_UNITS;   // System: "METRIC"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_BASE;          // Magnitude: "BASE"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.KELVIN;    // Temperature: "K"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.W_K_U;             // U: "W/(m² K)"

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_W_K = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.U, dU_kW_K);
                if (CheckForEquality(dU_W_K, 4000.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000} W/(m² K) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_W_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 4000.000 W/(m² K) .... FAIL -- {1:0.000} W/(m² K)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_W_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_W_K = 4000.000;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.U, dU_W_K);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} W/(m² K) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_W_K, 3),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} W/(m² K) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_W_K, 3),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // W-K

                #region KW-C

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.METRIC_UNITS;   // System: "METRIC"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_KILO;          // Magnitude: "KILO"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_C;     // Temperature: "°C"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.KW_C_U;            // U: "kW/(m² °C)"

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_kW_C = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.U, dU_kW_K);
                if (CheckForEquality(dU_kW_C, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000} kW/(m² °C) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_kW_C, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 4.000 kW/(m² °C) .... FAIL -- {1:0.000} kW/(m² °C)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_kW_C, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_kW_C = 4.000;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.U, dU_kW_C);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² °C) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_kW_C, 3),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² °C) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_kW_C, 3),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // KW-C

                #region MW-C

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.METRIC_UNITS;   // System: "METRIC"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_MEGA;          // Magnitude: "MEGA"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_C;     // Temperature: "°C"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.MW_C_U;            // U: "MW/(m² °C)"

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_MW_C = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.U, dU_kW_K);
                if (CheckForEquality(dU_MW_C, 0.004000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000000} MW/(m² °C) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_MW_C, 6));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 0.004000 MW/(m² °C) .... FAIL -- {1:0.000000} MW/(m² °C)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_MW_C, 6));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_MW_C = 0.004000;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.U, dU_MW_C);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000} MW/(m² °C) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_MW_C, 6),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000} MW/(m² °C) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_MW_C, 6),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // MW-C

                #region MW-K

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.METRIC_UNITS;   // System: "METRIC"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_MEGA;          // Magnitude: "MEGA"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.KELVIN;    // Temperature: "K"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.MW_K_U;            // U: "MW/(m² K)"

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_MW_K = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.U, dU_kW_K);
                if (CheckForEquality(dU_MW_K, 0.004000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000000} MW/(m² K) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_MW_K, 6));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 0.004000 MW/(m² K) .... FAIL -- {1:0.000000} MW/(m² K)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_MW_K, 6));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_MW_K = 0.004000;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.U, dU_MW_K);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000} MW/(m² K) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_MW_K, 6),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000} MW/(m² K) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_MW_C, 6),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // MW-K

                #region BTU-F

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.ENGLISH_UNITS;  // System: "ENGLISH"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_BASE;          // Magnitude: "BASE"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_F;     // Temperature: "°F"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.BTU_F_U;           // U: "Btu/(hr ft² °F)"

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_Btu_F = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.U, dU_kW_K);
                if (CheckForEquality(dU_Btu_F, 704.440))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000} Btu/(hr ft² °F) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_Btu_F, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 704.440 Btu/(hr ft² °F) .... FAIL -- {1:0.000} Btu/(hr ft² °F)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_Btu_F, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_Btu_F = 704.440;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.U, dU_Btu_F);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} Btu/(hr ft² °F) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_Btu_F, 3),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} Btu/(hr ft² °F) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_Btu_F, 3),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // BTU-F

                #region BTU-R

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.ENGLISH_UNITS;  // System: "ENGLISH"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_BASE;          // Magnitude: "BASE"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_R;     // Temperature: "°R"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.BTU_R_U;           // U: "Btu/(hr ft² °R)"

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_Btu_R = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.U, dU_kW_K);
                if (CheckForEquality(dU_Btu_R, 704.440))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000} Btu/(hr ft² °R) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_Btu_R, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 704.440 Btu/(hr ft² °R) .... FAIL -- {1:0.000} Btu/(hr ft² °R)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_Btu_R, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_Btu_R = 704.440;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.U, dU_Btu_R);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} Btu/(hr ft² °R) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_Btu_R, 3),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} Btu/(hr ft² °R) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_Btu_R, 3),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // BTU-R

                #region KBTU-F

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.ENGLISH_UNITS;  // System: "ENGLISH"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_KILO;          // Magnitude: "KILO"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_F;     // Temperature: "°F"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.KBTU_F_U;          // U: "kBtu/(hr ft² °F)"

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_kBtu_F = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.U, dU_kW_K);
                if (CheckForEquality(dU_kBtu_F, 0.70444))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000000} kBtu/(hr ft² °F) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_kBtu_F, 6));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 0.70444 kBtu/(hr ft² °F) .... FAIL -- {1:0.000000} kBtu/(hr ft² °F)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_kBtu_F, 6));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_kBtu_F = 0.70444;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.U, dU_kBtu_F);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000} kBtu/(hr ft² °F) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_kBtu_F, 6),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000} kBtu/(hr ft² °F) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_kBtu_F,6),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // KBTU-F

                #region KBTU-R

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.ENGLISH_UNITS;  // System: "ENGLISH"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_KILO;          // Magnitude: "KILO"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_R;     // Temperature: "°R"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.KBTU_R_U;          // U: "kBtu/(hr ft² °R)"

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_kBtu_R = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.U, dU_kW_K);
                if (CheckForEquality(dU_kBtu_R, 0.70444))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000000} kBtu/(hr ft² °R) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_kBtu_R, 6));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 0.70444 kBtu/(hr ft² °R) .... FAIL -- {1:0.000000} kBtu/(hr ft² °R)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_kBtu_R, 6));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_kBtu_R = 0.70444;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.U, dU_kBtu_R);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000} kBtu/(hr ft² °R) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_kBtu_R, 6),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000} kBtu/(hr ft² °R) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_kBtu_R, 6),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // KBTU-F

                #region MMBTU-F

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.ENGLISH_UNITS;  // System: "ENGLISH"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_MEGA;          // Magnitude: "MEGA"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_F;     // Temperature: "°F"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.MMBTU_F_U;         // U: "MMBtu/(hr ft² °F)"

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_MMBtu_F = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.U, dU_kW_K);
                if (CheckForEquality(dU_MMBtu_F, 0.00070444))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000000000} MMBtu/(hr ft² °F) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_MMBtu_F, 9));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 0.00070444 MMBtu/(hr ft² °F) .... FAIL -- {1:0.000000000} MMBtu/(hr ft² °F)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_MMBtu_F, 9));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_MMBtu_F = 0.00070444;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.U, dU_MMBtu_F);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000000} MMBtu/(hr ft² °F) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_MMBtu_F, 9),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000000} MMBtu/(hr ft² °F) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_MMBtu_F, 9),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // KBTU-F

                #region MMBTU-R

                #region TO EXTERNAL
                PinchSettingsObj.ExternalUnitsSystem = PinchSettings.ENGLISH_UNITS;  // System: "ENGLISH"
                PinchSettingsObj.ExternalMagUnits = PinchSettings.MAG_MEGA;          // Magnitude: "MEGA"
                PinchSettingsObj.ExternalTemperatureUnits = PinchSettings.DEG_R;     // Temperature: "°R"
                PinchSettingsObj.ExternalCP_Units = PinchSettings.MMBTU_R_U;         // U: "MMBtu/(hr ft² °R)"

                dU_kW_K = 4.000;     // Set INTERNAL VALUE
                dU_MMBtu_R = ConvertFromInternal(PinchTypes.ConversionUnitsTypes.U, dU_kW_K);
                if (CheckForEquality(dU_MMBtu_R, 0.00070444))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to {1:0.000000000} MMBtu/(hr ft² °R) .... PASS",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_MMBtu_R, 9));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000} kW/(m² K) to 0.00070444 MMBtu/(hr ft² °R) .... FAIL -- {1:0.000000000} MMBtu/(hr ft² °R)",
                                            Math.Round(dU_kW_K, 3),
                                            Math.Round(dU_MMBtu_R, 9));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO EXTERNAL

                #region TO INTERNAL
                dU_MMBtu_R = 0.00070444;  // Set EXTERNAL VALUE
                dU_kW_K = ConvertToInternal(PinchTypes.ConversionUnitsTypes.U, dU_MMBtu_R);
                if (CheckForEquality(dU_kW_K, 4.000))
                {
                    nPass++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000000} MMBtu/(hr ft² °R) to {1:0.000} kW/(m² K) .... PASS",
                                           Math.Round(dU_MMBtu_R, 9),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                else
                {
                    nFail++;
                    strMsg = string.Format("U - OVERALL HEAT TRANSFER COEFFICIENT CONVERSION TEST -> {0:0.000000000} MMBtu/(hr ft² °R) to 4.000 kW/K .... FAIL -- {1:0.000} kW/(m² K)",
                                           Math.Round(dU_MMBtu_R, 9),
                                           Math.Round(dU_kW_K, 3));
                    PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // TO INTERNAL

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // KBTU-R

                #endregion  // U - OVERALL HEAT TRANSFER COEFFICIENT

            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                PinchLogger.WriteSeparatorLine('*');
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, strMsg);
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                strMsg = string.Format("    ===> T E S T   T O T A L S :   PASS: {0}   FAIL: {1}", nPass, nFail);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                PinchLogger.WriteSection("END UNIT CONVERSION TEST");
                PinchLogger.WriteSeparatorLine(' ');

            }
        }
        #endregion  // TestUnitConversions()

        #endregion  // UNITS METHODS

    }
    #endregion      // public class PinchTypes
}
#endregion      // namespace PinchGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
