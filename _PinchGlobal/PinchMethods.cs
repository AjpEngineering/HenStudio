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

        #region CONVERSION METHODS

        #region ConvertToInternal()
        /// <summary>
        /// Convert External data value in External Units to data value in Internal Units
        /// Internal units are used by the Targets and Hen Engines.
        /// External units are customer facing, i.e., UI units (controls)
        /// External Units are set by the user in the INPUT-Project Panel controls
        /// Internal units are set on initial construction and do not change
        /// Both Internal and External units string Properties are contained in PinchSettings
        /// </summary>
        /// <param name="enumConType">Conversion Units Enumeration Type [PinchTypes]</param>
        /// <param name="dExternalValue">External Value to be converted</param>
        /// <returns>Converted internal value now in internal units</returns>
        public double ConvertAreaToInternal(PinchTypes.ConversionUnitsTypes enumConType,
                                            double dExternalValue)
        {
            string strMethod = "ConvertAreaToInternal";
            string strMsg = String.Empty;
            double dInternalValue = 0.0;
            try
            {
                switch (enumConType)
                {
                    #region A - AREA
                    case PinchTypes.ConversionUnitsTypes.A:
                        if (string.Compare(PinchSettingsObj.InternalArea_Units,
                                           PinchSettingsObj.ExternalArea_Units, true) == 0)
                        {
                            //--- No Need for Conversion ! ---
                            dInternalValue = dExternalValue;
                        }
                        else
                        {
                            //--- Convert SqFt to SqM ---
                            dInternalValue = dExternalValue * 0.09290313;
                        }                    
                        break;
                    #endregion  // A- AREA

                    #region T - TEMPERATURE
                    case PinchTypes.ConversionUnitsTypes.TEMP:
                        if (string.Compare(PinchSettingsObj.InternalTemperatureUnits,
                                           PinchSettingsObj.ExternalTemperatureUnits, true) == 0)
                        {
                            //--- No Need for Conversion - Already (K)! ---
                            dInternalValue = dExternalValue;
                        }
                        else
                        {
                            //--- Convert External Temperature Units to Internal Temperature Units ---
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
                    //--- Heat Flow is (Btu/hr) for ENGLISH and (W) for METRIC
                    //--- User selects [ENGLISH | METRIC] - Heat Flow is set to [Btu/hr | W]
                    //--- User then selects Magnitude [BASE | KILO | MEGA]
                    //--- Use Heat Flow Units to determine [ METRIC | ENGLISH ]
                    //--- Then Determine Magnitude for Conversions
                    //--- NOTE: Conversion factors are the same as Heat Flow
                    //-----------------------------------------------------------------------------
                    case PinchTypes.ConversionUnitsTypes.HEAT_FLOW:
                        if (string.Compare(PinchSettingsObj.InternalHeatFlowUnits,
                                           PinchSettingsObj.ExternalHeatFlowUnits, true) == 0)
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
                    //--- CP consists of Heat Flow divided by Temp
                    //-----------------------------------------------------------------------------
                    //--- Heat Flow is (Btu/hr) for ENGLISH and (W) for METRIC
                    //--- User selects [ENGLISH | METRIC] - Heat Flow is set to [Btu/hr | W]
                    //--- User then selects Magnitude [BASE | KILO | MEGA]
                    //--- For CP Conversion use Heat Flow Units to determine [ METRIC | ENGLISH ]
                    //--- Then Determine Magnitude for Conversions
                    //--- NOTE: Conversion factors are the same as Heat Flow
                    //-----------------------------------------------------------------------------
                    case PinchTypes.ConversionUnitsTypes.CP:
                        if (string.Compare(PinchSettingsObj.InternalHeatFlowUnits,
                                           PinchSettingsObj.ExternalHeatFlowUnits, true) == 0)
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
                    //--- U consists of CP divided by Temp
                    //-----------------------------------------------------------------------------
                    //--- Heat Flow is (Btu/hr) for ENGLISH and (W) for METRIC
                    //--- User selects [ENGLISH | METRIC] - Heat Flow is set to [Btu/hr | W]
                    //--- User then selects Magnitude [BASE | KILO | MEGA]
                    //--- User selects Heat Flow as [Btu/hr | W] and then selects Magnitude
                    //--- For U Conversion use Heat Flow Units to determine [ METRIC | ENGLISH ]
                    //--- Then Determine Magnitude for Conversions
                    //-----------------------------------------------------------------------------
                    case PinchTypes.ConversionUnitsTypes.U:
                        if (string.Compare(PinchSettingsObj.InternalHeatFlowUnits,
                                           PinchSettingsObj.ExternalHeatFlowUnits, true) == 0)
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

                        break;
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
        /// Convert Internal data value in Internal Units to data value in External Units
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
            double dExternalValue = 0.0;
            try
            {

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

        #endregion  // CONVERSION METHODS

        }
    #endregion      // public class PinchTypes
}
#endregion      // namespace PinchGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
