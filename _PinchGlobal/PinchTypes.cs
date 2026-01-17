#region HEADER
//#####################################################################################################################
//###########################################  P i n c h T y p e s . c s  #############################################
//#####################################################################################################################
//  FILENAME:  PinchTypes.cs
//  NAMESPACE: PinchGlobal
//  CLASS(S):  PinchTypes
//  COMPONENT: _PinchGLobal.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Common Pinch Types (enums).
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
    #region public class PinchTypes
    /// <summary>
    /// Pinch Types Class
    /// </summary>
    public class PinchTypes
    {
        #region CONSTANTS
        const string NAMESPACE = "PinchGlobal";
        const string CLASS = "PinchTypes";

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

        #region enum LicenseType
        /// <summary>
        /// ENUMERATION: License Type
        /// </summary>
        public enum LicenseType
        {
            UNKNOWN = -1,  // License Type is UNKNOWN... ERROR
            SITE    =  0,  // License Type is SITE...... ALL USERS and ALL  DEVICES     in a SINGLE COMPANY
            DEVICE  =  1,  // License Type is DEVICE.... ALL USERS on SINGLE DEVICE     in a SINGLE COMPANY
            USER    =  2,  // License Type is USER...... ALL DEVICES for a SINGLE USER  in a SINGLE COMPANY
            SEAT    =  3   // License Type is SEAT...... SINGLE USER on a SINGLE DEVICE in a SINGLE COMPANY
        };
        #endregion      // enum LicenseType

        #region enum PinchUnits
        /// <summary>
        /// ENUMERATION: Pinch Units
        /// </summary>
        public enum PinchUnits
        {
            UNKNOWN = -1,       // UNKNOWN Units
            ENGLISH =  0,       // ENGLISH-IMPERIAL Units
            METRIC  =  1        // METRIC-SI Units
        };
        #endregion      // enum PinchUnits

        #region enum HeatLoadType
        /// <summary>
        /// ENUMERATION: Heat Load Type
        /// </summary>
        public enum HeatLoadType
        {
            UNKNOWN  = -1,  // UNKNOWN
            RELEASED =  0,  // HEAT RELEASED (Surplus)
            REQUIRED =  1   // HEAT REQUIRED (Deficit)
        };
        #endregion      // enum HeatLoadType

        #region enum HeatType
        /// <summary>
        /// ENUMERATION: Heat Type
        /// </summary>
        public enum HeatType
        {
            UNKNOWN  = -1,  // UNKNOWN
            SENSIBLE =  0,  // SENSIBLE HEAT (Single Phase)
            LATENT   =  1   // LATENT   HEAT (Two-Phase)
       };
        #endregion      // enum HeatType

        #region enum LatentHeatType
        /// <summary>
        /// ENUMERATION: Latent Heat Type
        /// </summary>
        public enum LatentHeatType
        {
            UNKNOWN    = -1,  // UNKNOWN
            BOILING    =  0,  // BOILING    LATENT HEAT (Cold Stream)
            CONDENSING =  1   // CONDENSING LATENT HEAT (Hot  Stream)
        };
        #endregion      // enum LatentHeatType

        #region enum SensibleHeatType
        /// <summary>
        /// ENUMERATION: Sensible Heat Type
        /// </summary>
        public enum SensibleHeatType
        {
            UNKNOWN = -1,  // UNKNOWN
            LIQUID  =  0,  // LIQUID SENSIBLE HEAT
            VAPOR   =  1   // VAPOR  SENSIBLE HEAT
        };
        #endregion      // enum SensibleHeatType

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

        #region enum ProgressStates
        /// <summary>
        /// ENUMERATION: Progress States
        /// </summary>
        public enum ProgressStates
        {
            FAILED  = -1,       // FAILED STATE
            UNKNOWN =  0,       // UNKNOWN PROGRESS STATE
            TBD     =  1,       // TO BE DONE STATE
            WORKING =  2,       // WORKING STATE
            DONE    =  3        // DONE or COMPLETED STATE
        };
        #endregion      // enum ProgressStates

        #region enum StreamPhase
        /// <summary>
        /// ENUMERATION: Stream Phase Types
        /// </summary>
        public enum StreamPhase
        {
            UNKNOWN      = -1,  // UNKNOWN Phase
            LIQUID       =  0,  // Single Liquid Phase
            VAPOR        =  1,  // Single Vapor Phase
            LIQUID_VAPOR =  2   // Two-Phase Liquid-Vapor
        };
        #endregion      // enum StreamPhase

        #region enum StreamTypes
        /// <summary>
        /// ENUMERATION: Stream Types [UNKNOWN | COLD | HOT]
        /// </summary>
        public enum StreamTypes
        {
            UNKNOWN = -1,  // UNKNOWN Stream Type
            COLD    =  0,  // COLD Stream
            HOT     =  1   // HOT  Stream
        };
        #endregion      // enum StreamTypes

        #endregion      // ENUMS

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public PinchTypes()
        {
            string strMethod = "CTOR";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating Object");

        }
        #endregion      // CTOR

    }
    #endregion      // public class PinchTypes
}
#endregion      // namespace PinchGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
