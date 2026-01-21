#region HEADER
//#####################################################################################################################
//#########################################  L i c e n s e T y p e s . c s  ###########################################
//#####################################################################################################################
//  FILENAME:  LicenseTypes.cs
//  NAMESPACE: AJP_License_File
//  CLASS(S):  LicenseTypes
//  COMPONENT: _AJP License File.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the License Types (enums).
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

using PinchGlobal;      // for Logger
#endregion  // REFERENCES

#region namespace AJP_License_File
namespace AJP_License_File
{
    #region public class LicenseTypes
    /// <summary>
    /// License Types Class
    /// </summary>
    public class LicenseTypes
    {
        #region CONSTANTS
        const string NAMESPACE = "AJP_License_File";
        const string CLASS = "LicenseTypes";

        #endregion      // CONSTANTS

        #region ENUMS

        #region enum LicenseStatus
        /// <summary>
        /// ENUMERATION: License Status
        /// </summary>
        public enum LicenseStatus
        {
            EXPIRED = -2,  // License Status is EXPIRED
            INVALID = -1,  // License Status is INVALID
            UNKNOWN =  0,  // License Status is UNKNOWN
            VALID   =  1   // License status is VALID
        };
        #endregion      // enum LicenseStatus

        #region enum LicenseTypeEnum
        /// <summary>
        /// ENUMERATION: License Type
        /// </summary>
        public enum LicenseTypeEnum
        {
            UNKNOWN = -1,  // License Type is UNKNOWN... ERROR
            TRIAL   =  0,  // License Type is TRIAL..... ANY USERS and ANY  DEVICES     ANY    COMPANY
            SITE    =  1,  // License Type is SITE...... ANY USERS and ANY  DEVICES     SINGLE COMPANY
            DEVICE  =  2,  // License Type is DEVICE.... ANY USERS on SINGLE DEVICE     SINGLE COMPANY
            USER    =  3,  // License Type is USER...... ANY DEVICES for a SINGLE USER  SINGLE COMPANY
            SEAT    =  4   // License Type is SEAT...... SINGLE USER on a SINGLE DEVICE SINGLE COMPANY
        };
        #endregion      // enum LicenseTypeEnum

        #region enum LogLevel
        /// <summary>
        /// ENUMERATION: Logging Level
        /// </summary>
        public enum LogLevel
        {
            UNKNOWN       = -1,  // UNKNOWN Log Level
            LOG_NONE      =  0,  // TURN LOGGING OFF
            LOG_ERRORS    =  1,  // LOG ONLY ERROR MESSAGES
            LOG_WARNINGS  =  2,  // LOG ERROR & WARNING MESSAGES
            LOG_IMPORTANT =  3,  // LOG ERROR,  WARNING & IMPORTANT INFO MESSAGES
            LOG_ALL       =  4   // LOG ALL MESSAGES
        };
        #endregion      // enum LogLevel

        #endregion      // ENUMS

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public LicenseTypes()
        {
            string strMethod = "CTOR";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating Object");
        }
        #endregion      // CTOR

    }
    #endregion      // public class LicenseTypes
}
#endregion      // namespace AJP_License_File

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
