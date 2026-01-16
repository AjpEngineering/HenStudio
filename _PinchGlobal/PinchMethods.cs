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
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace PinchGlobal
namespace PinchGlobal
{
    #region public class PinchMethods
    /// <summary>
    /// Common Global static Pinch Methods Class
    /// </summary>
    public static class PinchMethods
    {
        #region CONSTANTS
        const string NAMESPACE = "PinchGlobal";
        const string CLASS = "PinchMethods";

        #endregion      // CONSTANTS

        #region FIELDS

        #endregion      // FIELDS

        #region PROPERTIES

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor ... NO CTOR for STATIC CLASS
        /// </summary>
        //public PinchMethods()
        //{
        //    string strMethod = "CTOR";
        //    PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating Object");

        //}
        #endregion      // CTOR

        #region STRING VALUE CHECK STATIC METHODS

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

        #endregion      // STRING VALUE CHECK STATIC METHODS

    }
    #endregion      // public class PinchTypes
}
#endregion      // namespace PinchGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
