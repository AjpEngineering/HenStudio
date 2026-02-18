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
                    //--- NOTE: Conversion factors are the same as CP - Heat Capacity Flow Rate
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
                    //--- NOTE: Conversion factors are the same as Heat Flow
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
                                    dInternalValue = dExternalValue * 0.000293071;
                                    break;
                                case PinchSettings.MAG_KILO:
                                    //--- Convert [ (kBtu/(hr °F) to (kW/K)] | (kBtu/(hr °R) to (kW/K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dInternalValue = dExternalValue * 0.293071071;
                                    break;
                                case PinchSettings.MAG_MEGA:
                                    //--- Convert [ (MMBtu/(hr °F) to (kW/K)] | (MMBtu/(hr °R) to (kW/K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
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
                    //--- NOTE: Conversion factors are the same as CP - Heat Capacity Flow Rate
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
                    //--- NOTE: Conversion factors are the same as Heat Flow
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
                                    dExternalValue = dInternalValue * 3412.142;
                                    break;
                                case PinchSettings.MAG_KILO:
                                    //--- Convert [ (kBtu/(hr °F) to (kW/K) ] | [ (kBtu/(hr °R) to (kW/K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
                                    dExternalValue = dInternalValue * 3.412142;
                                    break;
                                case PinchSettings.MAG_MEGA:
                                    //--- Convert [ (MMBtu/(hr °F) to (kW/K) ] | [ (MMBtu/(hr °R) to (kW/K) ] ---
                                    //--- °F or °R both use the same conversion factor - dealing with delta temperatures
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
                double dAreaSqM  = 400.00;      // INTERNAL VALUE
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
                double dTempK = 400.00;  // INTERNAL VALUE
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

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // H - HEAT FLOW

                #region CP - HEAT CAPACITY FLOW RATE

                PinchLogger.WriteSeparatorLine('-');
                #endregion  // CP - HEAT CAPACITY FLOW RATE

                #region U - OVERALL HEAT TRANSFER COEFFICIENT

                PinchLogger.WriteSeparatorLine('-');
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
            PinchLogger.WriteSeparatorLine(' ');
            PinchLogger.WriteSection("END UNIT CONVERSION TEST");
            PinchLogger.WriteSeparatorLine(' ');
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
