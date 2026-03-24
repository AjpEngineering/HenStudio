#region HEADER
//#####################################################################################################################
//#############################################  H e n T y p e s . c s  ###############################################
//#####################################################################################################################
//  FILENAME:  HenTypes.cs
//  NAMESPACE: HenGlobal
//  CLASS(S):  HenTypes
//  COMPONENT: _HenGLobal.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Common HEN Studio Types (enums).
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

#region namespace HenGlobal
namespace HenGlobal
{
    #region public class HenTypes
    /// <summary>
    /// AJP HEN Studio Types Class
    /// </summary>
    public class HenTypes
    {
        #region CONSTANTS
        const string NAMESPACE = "HenGlobal";
        const string CLASS = "HenTypes";

        #endregion      // CONSTANTS

        #region ENUMS

        #region LICENSE

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
            TRIAL   =  0,  // License Type is TRIAL..... ALL USERS and ALL  DEVICES     any  COMPANY
            SITE    =  1,  // License Type is SITE...... ALL USERS and ALL  DEVICES     in a SINGLE COMPANY
            DEVICE  =  2,  // License Type is DEVICE.... ALL USERS on SINGLE DEVICE     in a SINGLE COMPANY
            USER    =  3,  // License Type is USER...... ALL DEVICES for a SINGLE USER  in a SINGLE COMPANY
            SEAT    =  4   // License Type is SEAT...... SINGLE USER on a SINGLE DEVICE in a SINGLE COMPANY
        };
        #endregion      // enum LicenseType

        #endregion  // LICENSE

        #region CATALOG & PROJECT DB CONNECTION STATUS

        #region enum DbConnected
        /// <summary>
        /// ENUMERATION: Database Connection Status [ UNKNOWN | UNCONNECTED| CONNECTED ]
        /// </summary>
        public enum DbConnected
        {
            UNKNOWN = -1,       // UNKNOWN Connection
            UNCONNECTED =  0,   // UNCONNECTED
            CONNECTED =  1      // CONNECTED
        };
        #endregion      // enum DbConnected

        #endregion  // DB CONNECTED

        #region PROJECT DIRTY FLAG STATE

        #region enum ProjectDirtyFlagState
        /// <summary>
        /// ENUMERATION: Project Dirty Flag State [ UNKNOWN = -1 | UPDATE = 0 | UPDATED = 1 ]
        /// UPDATE  the same as SYNCHED [RED]   (Dirty Flag is true) ... 
        /// UPDATED the same as SYNCHED [GREEN] (Dirty Flag is false - data Clean)
        /// </summary>
        public enum ProjectDirtyFlagState
        {
            UNKNOWN = -1,    // UNKNOWN Dirty Flag State
            DIRTY = 0,       // DIRTY Project Data ... DirtyFlag = true  ... DB Needs to be Synched
            CLEAN = 1        // CLEAN Project Data ... DirtyFlag = false ... DB Synched
        };
        #endregion      // enum ProjectDirtyFlagState

        #endregion  // PROJECT DIRTY FLAG STATE

        #region UNITS

        #region enum ProjectSystemUnits
        /// <summary>
        /// ENUMERATION: Project System Units [ UNKNOWN | ENGLISH | METRIC ]
        /// </summary>
        public enum ProjectSystemUnits
        {
            UNKNOWN = -1,       // UNKNOWN Units
            ENGLISH =  0,       // ENGLISH-IMPERIAL Units
            METRIC  =  1        // METRIC-SI Units
        };
        #endregion      // enum ProjectSystemUnits

        #region enum ConversionUnitsTypes
        /// <summary>
        /// ENUMERATION: Conversion Units Types [ UNKNOWN | HEAT_FLOW | TEMP | CP | U | A ]
        /// </summary>
        public enum ConversionUnitsTypes
        {
            UNKNOWN = -1,   // UNKNOWN
            HEAT_FLOW = 0,  // Heat Flow (e.g., Btu/hr | W)
            TEMP = 1,       // Temperature (e.g., °F | °R | °C | K ) 
            PRESS = 2,      // Pressure (e.g., psia | kPa)
            CP = 3,         // CP - Heat Capacity Flow Rate (e.g., Btu/(hr °F) | W/K ) 
            U = 4,          // U - Overall Heat Transfer Coefficient (e.g., Btu/(hr ft² °F) | W/(m² K) 
            A = 5           // A - Area (e.g., ft² | m²)
        };
        #endregion      // enum ConversionUnitsTypes

        #endregion  // UNITS

        #region OPTIMIZER

        #region enum HenOptimizer
        /// <summary>
        /// ENUMERATION: AJP HEN Studio Optimizer [ UNKNOWN | GENETIC | GREEDY ]
        /// </summary>
        public enum HenOptimizer
        {
            UNKNOWN = -1,     // UNKNOWN Units
            GENETIC = 0,      // GENETIC Optimizer
            GREEDY = 1        // GREEDY Optimizer
        };
        #endregion      // enum HenOptimizer


        #endregion  // OPTIMIZER

        #region PROJECT EXPLORER LEVEL

        #region enum ExplorerLevel
        /// <summary>
        /// ENUMERATION: Project-Explorer Level [ UNKNOWN | CATALOG | PROJECT | PROFILE | PINCH | HEN ]
        /// </summary>
        public enum ExplorerLevel
        {
            UNKNOWN = -1,   // UNKNOWN Level
            CATALOG = 0,    // Projects (Catalog) - No Project Selected (root)
            PROJECT = 1,    // Project Selected
            PROFILE = 2,    // Profile Input
            PINCH   = 3,    // Pinch Study
            HEN     = 4     // HEN Design
        };
        #endregion      // enum ExplorerLevel

        #endregion  // PROJECT EXPLORER LEVEL

        #region PROFILE INPUT

        #region enum ProfileInputType
        /// <summary>
        /// ENUMERATION: Profile Input Type [ UNKNOWN | PROCESS_STREAM | UTILITY_STREAM | ECONOMIC_PARAMS ]
        /// </summary>
        public enum ProfileInputType
        {
            UNKNOWN = -1,          // UNKNOWN Input Type
            PROCESS_STREAM = 0,    // Process Streams Input Type
            UTILITY_STREAM = 1,    // Utilities Streams Input Type
            ECONOMIC_PARAMS = 2    // Economic Parameters Input Type
        };
        #endregion      // enum ProfileInputType

        #endregion  // PROJECT EXPLORER LEVEL

        #region HEAT

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

        #endregion  // HEAT

        #region STREAM

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

        #endregion      // STREAM

        #region PROGRESS

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

        #endregion  // PROGRESS

        #region LOG

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

        #endregion  // LOG

        #endregion      // ENUMS

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public HenTypes()
        {
            string strMethod = "CTOR";
            HenLogger.WriteSeparatorLine(' ');
            HenLogger.WriteSeparatorLine('>');
            HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating HenTypes Object");
            try
            {

            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "HenTypes Object CREATED");
                HenLogger.WriteSeparatorLine('<');
            }
        }
        #endregion      // CTOR

    }
    #endregion      // public class HenTypes
}
#endregion      // namespace HenGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
