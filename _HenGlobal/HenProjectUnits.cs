#region HEADER
//#####################################################################################################################
//######################################  H e n P r o j e c t U n i t s . c s  ########################################
//#####################################################################################################################
//  FILENAME:  HenProjectUnits.cs
//  NAMESPACE: HenGlobal
//  CLASS(S):  HenProjectUnits
//  COMPONENT: _HenGlobal.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the HEN Project Units Class.
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
    #region public class HenProjectUnits
    /// <summary>
    /// HEN Project Units Class
    /// </summary>
    public class HenProjectUnits
    {
        #region CONSTANTS
        const string NAMESPACE = "HenGlobal";
        const string CLASS = "HenProjectUnits";

        #region UNITS STRINGS

        #region SYSTEM UNITS
        public const string ENGLISH_UNITS = "English - Imperial";
        public const string METRIC_UNITS  = "Metric - SI";     // <<<--- INTERNAL ---<<<
        #endregion  // SYSTEM UNITS

        #region MAG - MAGNITUDE UNITS
        //------------------------------------------- MAG - MAGNITUDE UNITS ---
        public const string MAG_BASE = "Base";    // BASE * 10^0
        public const string MAG_KILO = "Kilo";    // BASE * 10^3   // <<<--- INTERNAL ---<<<
        public const string MAG_MEGA = "Mega";    // BASE * 10^6
        #endregion  // MAG - MAGNITUDE UNITS

        #region A - AREA UNITS
        //---------------------------------------------------- ENGLISH AREA ---
        public const string SqFt = "ft²";   // "ft\u00B2"
        //----------------------------------------------------- METRIC AREA ---
        public const string SqM = "m²";     // "m\u00B2" <<<------ INTERNAL ---<<<
        #endregion  // A - AREA UNITS

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
        public const string BTU_F_CP = "Btu/(hr·°F)";        // °F
        public const string KBTU_F_CP = "kBtu/(hr·°F)";      // °F
        public const string MMBTU_F_CP = "MMBtu/(hr·°F)";    // °F
        //---------------------------------------------------------------------
        public const string BTU_R_CP = "Btu/(hr·°R)";        // °R
        public const string KBTU_R_CP = "kBtu/(hr·°R)";      // °R
        public const string MMBTU_R_CP = "MMBtu/(hr·°R)";    // °R

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
        public const string BTU_F_U = "Btu/(hr·ft²·°F)";        // °F
        public const string KBTU_F_U = "kBtu/(hr·ft²·°F)";      // °F
        public const string MMBTU_F_U = "MMBtu/(hr·ft²·°F)";    // °F
        //---------------------------------------------------------------------
        public const string BTU_R_U = "Btu/(hr·ft²·°R)";        // °R
        public const string KBTU_R_U = "kBtu/(hr·ft²·°R)";      // °R
        public const string MMBTU_R_U = "MMBtu/(hr·ft²·°R)";    // °R

        //------------------------------------------------------ METRIC W U ---
        public const string W_C_U = "W/(m²·°C)";                // °C
        public const string KW_C_U = "kW/(m²·°C)";              // °C
        public const string MW_C_U = "MW/(m²·°C)";              // °C
        //---------------------------------------------------------------------
        public const string W_K_U = "W/(m²·K)";                 // K
        public const string KW_K_U = "kW/(m²·K)";    // <<<------- INTERNAL ---<<<
        public const string MW_K_U = "MW/(m²·K)";               // K
        #endregion  // U - OVERALL HEAT TRANSFER COEFFICIENT UNITS

        #endregion  // UNITS STRINGS

        #endregion      // CONSTANTS

        #region ENUMS

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

        #region enum ProjectSystemUnits
        /// <summary>
        /// ENUMERATION: Project System Units [ UNKNOWN | ENGLISH | METRIC ]
        /// </summary>
        public enum ProjectSystemUnits
        {
            UNKNOWN = -1,     // UNKNOWN Units
            ENGLISH = 0,      // ENGLISH-IMPERIAL Units
            METRIC  = 1       // METRIC-SI Units
        };
        #endregion      // enum ProjectSystemUnits

        #region enum ProjectMagnitude
        /// <summary>
        /// ENUMERATION: Project Magnitude [ UNKNOWN = -1 | BASE = 0 | KILO = 1 | MEGA = 2 ]
        /// </summary>
        public enum ProjectMagnitude
        {
            UNKNOWN = -1,   // UNKNOWN Units
            BASE = 0,       // BASE ... 10^0 ... Base (10^0)
            KILO = 1,       // KILO ... 10^3 ... Kilo (10^3)
            MEGA = 2        // MEGA ... 10^6 ... Mega (10^6)
        };
        #endregion      // enum ProjectMagnitude

        #region enum ProjectEnglishTemp
        /// <summary>
        /// ENUMERATION: Project English Temp [ UNKNOWN = -1 | DEG_F = 0 | DEG_R = 1 ]
        /// </summary>
        public enum ProjectEnglishTemp
        {
            UNKNOWN = -1,   // UNKNOWN Units
            DEG_F = 0,      // Degrees Fahrenheit
            DEG_R = 1       // Degrees Rankine
        };
        #endregion      // enum ProjectEnglishTemp

        #region enum ProjectMetricTemp
        /// <summary>
        /// ENUMERATION: Project Metric Temp [ UNKNOWN = -1 | DEG_C = 0 | K = 1 ]
        /// </summary>
        public enum ProjectMetricTemp
        {
            UNKNOWN = -1,   // UNKNOWN Units
            DEG_C = 0,      // Degrees Celsius
            KELVIN = 1      // Kelvin
        };
        #endregion      // enum ProjectMetricTemp

        #region enum ProjectEnglishPress
        /// <summary>
        /// ENUMERATION: Project English Press [ UNKNOWN = -1 | PSIA = 0 | PSIG = 1 | PSF = 2 | ATM = 3 | IN_HG = 4 | IN_H2O = 5 ]
        /// </summary>
        public enum ProjectEnglishPress
        {
            UNKNOWN = -1,   // UNKNOWN Units
            PSIA = 0,       // Pounds per Square Inch Absoulte
            PSIG = 1,       // Pounds per Square Inch Gauge
            PSF = 2,        // Pounds per Square Foot Abaolute
            ATM = 3,        // Atmospheres
            IN_HG = 4,      // Inches Mercury
            IN_H2O = 5      // Inches Water
        };
        #endregion      // enum ProjectEnglishPress

        #region enum ProjectMetricPress
        /// <summary>
        /// ENUMERATION: Project Metric Press [ UNKNOWN = -1 | BAR = 0 | Pa = 1 ]
        /// </summary>
        public enum ProjectMetricPress
        {
            UNKNOWN = -1,  // UNKNOWN Units
            BAR = 0,       // Bars
            Pa = 1         // Pascals
        };
        #endregion      // enum ProjectMetricPress

        #region enum ProjectEnglishArea
        /// <summary>
        /// ENUMERATION: Project English Area [ UNKNOWN = -1 | FT2 = 0 ]
        /// </summary>
        public enum ProjectEnglishArea
        {
            UNKNOWN = -1,   // UNKNOWN Units
            FT2 = 0         // Square Feet
        };
        #endregion      // enum ProjectEnglishArea

        #region enum ProjectMetricArea
        /// <summary>
        /// ENUMERATION: Project Metric Area [ UNKNOWN = -1 | M2 = 0 ]
        /// </summary>
        public enum ProjectMetricArea
        {
            UNKNOWN = -1,   // UNKNOWN Units
            M2 = 0          // Square Meters
        };
        #endregion      // enum ProjectMetricArea

        #endregion      // ENUMS

        #region PROPERTIES
        public ProjectSystemUnits ProjectSystemUnitsEnum { get; set; }    // Project System Units Enum [ UNKNOWN | ENGLISH | METRIC ]
        public ProjectMagnitude ProjectMagnitudeEnum { get; set; }        // Project Magnitude Enum [ UNKNOWN | BASE | KILO | MEGA ]

        public ProjectEnglishTemp ProjectEnglishTempEnum { get; set; }    // Project English Temp Enum [ UNKNOWN = -1 | DEG_F = 0 | DEG_R = 1 ]
        public ProjectMetricTemp ProjectMetricTempEnum { get; set; }      // Project Metric  Temp Enum [ UNKNOWN = -1 | DEG_C = 0 | K = 1 ]

        public ProjectEnglishPress ProjectEnglishPressEnum { get; set; }  // Project English Press Enum [ UNKNOWN = -1 | PSIA = 0 | PSIG = 1 | PSF = 2 | ATM = 3 | IN_HG = 4 | IN_H2O = 5 ]
        public ProjectMetricPress ProjectMetricPressEnum { get; set; }    // Project Metric  Press Enum [ UNKNOWN = -1 | BAR = 0 | Pa = 1 ]

        public ProjectEnglishArea ProjectEnglishAreaEnum { get; set; }    // Project English Area [ UNKNOWN = -1 | FT2 = 0 ]
        public ProjectMetricArea ProjectMetricAreaEnum { get; set; }      // Project Metric  Area [ UNKNOWN = -1 | M2 = 0 ]
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public HenProjectUnits()
        {
            string strMethod = "CTOR";
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating HenProjectUnits Object");
            try
            {
                //-----------------------------------------------
                //--- Initialize With INTERNAL Property Value ---
                //-----------------------------------------------

                ProjectSystemUnitsEnum  = ProjectSystemUnits.METRIC;    // <- INTERNAL

                ProjectMagnitudeEnum    = ProjectMagnitude.KILO;        // <- INTERNAL

                ProjectEnglishTempEnum  = ProjectEnglishTemp.DEG_F;
                ProjectMetricTempEnum   = ProjectMetricTemp.KELVIN;     // <- INTERNAL

                ProjectEnglishPressEnum = ProjectEnglishPress.PSIA;
                ProjectMetricPressEnum  = ProjectMetricPress.Pa;        // <- INTERNAL (KPa)

                ProjectEnglishAreaEnum  = ProjectEnglishArea.FT2;
                ProjectMetricAreaEnum   = ProjectMetricArea.M2;         // <- INTERNAL

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
        #endregion      // CTOR

        #region GET STRING LISTS FOR COMBO BOX DROPDOWN

        #region GetSystemUnitsList()
        /// <summary>
        /// Get the List of Stings used for System Units Combo Box Dropdowns
        /// </summary>
        /// <returns>List of System Units strings for Combo Box</returns>
        public List<string> GetSystemUnitsList()
        {
            List<string> lst = new List<string>();

            lst.Clear();
            lst.Add(METRIC_UNITS);
            lst.Add(ENGLISH_UNITS);
            return lst;
        }
        #endregion  // GetSystemUnitsList()

        #region GetMagnitudeList()
        /// <summary>
        /// Get the List of Stings used for Magnitude Combo Box Dropdowns
        /// </summary>
        /// <returns>List of Magnitude strings for Combo Box</returns>
        public List<string> GetMagnitudeList()
        {
            List<string> lst = new List<string>();

            lst.Clear();
            lst.Add(MAG_BASE);
            lst.Add(MAG_KILO);
            lst.Add(MAG_MEGA);
            return lst;
        }
        #endregion  // GetMagnitudeList()

        #region GetEnglishTempList()
        /// <summary>
        /// Get the List of Stings used for English Temperature Combo Box Dropdowns
        /// </summary>
        /// <returns>List of English Temperature strings for Combo Box</returns>
        public List<string> GetEnglishTempList()
        {
            List<string> lst = new List<string>();

            lst.Clear();
            lst.Add(DEG_F);
            lst.Add(DEG_R);
            return lst;
        }
        #endregion  // GetMetricTempList()

        #region GetMetricTempList()
        /// <summary>
        /// Get the List of Stings used for Metric Temperature Combo Box Dropdowns
        /// </summary>
        /// <returns>List of Metric Temperature strings for Combo Box</returns>
        public List<string> GetMetricTempList()
        {
            List<string> lst = new List<string>();

            lst.Clear();
            lst.Add(DEG_C);
            lst.Add(KELVIN);
            return lst;
        }
        #endregion  // GetMetricTempList()

        #region GetEnglishPressList()
        /// <summary>
        /// Get the List of Stings used for English Pressure Combo Box Dropdowns
        /// </summary>
        /// <returns>List of English Pressure strings for Combo Box</returns>
        public List<string> GetEnglishPressList()
        {
            List<string> lst = new List<string>();

            lst.Clear();
            lst.Add(Psia);
            lst.Add(Psig);
            lst.Add(Psfa);
            lst.Add(Atm);
            lst.Add(InHg);
            lst.Add(InH2O);
            return lst;
        }
        #endregion  // GetEnglishPressList()

        #region GetMetricPressList()
        /// <summary>
        /// Get the List of Stings used for Metric Pressure Combo Box Dropdowns
        /// </summary>
        /// <param name="ProjectMagnitudeEnum">Magnitude used for Pressure (Metric Only)</param>
        /// <returns>List of Metric Pressure strings for Combo Box</returns>
        public List<string> GetMetricPressList(ProjectMagnitude ProjectMagnitudeEnum)
        {
            List<string> lst = new List<string>();

            lst.Clear();

            switch(ProjectMagnitudeEnum)
            {
                case ProjectMagnitude.BASE:
                    lst.Add(Bar);
                    lst.Add(Pa);
                    break;

                case ProjectMagnitude.KILO:
                    lst.Add(KBar);
                    lst.Add(kPa);
                    break;

                case ProjectMagnitude.MEGA:
                    lst.Add(MBar);
                    lst.Add(MPa);
                    break;

                default:
                    lst.Add("???");
                    break;
            }
            
            return lst;
        }
        #endregion  // GetMetricPressList()

        #endregion  // GET STRING LISTS FOR COMBO BOX DROPDOWN

        #region GET UNIT STRINGS ... based on Property Settings

        #region GetSystemUnitsString()
        /// <summary>
        /// Get System Units String
        /// </summary>
        /// <returns>System Units String</returns>
        public string GetSystemUnitsString()
        {
            string strMethod = "GetSystemUnitsString";
            string strUnitsString = String.Empty;
            try
            {
                #region METRIC
                if (ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC)
                {
                    strUnitsString = METRIC_UNITS;
                }
                #endregion  // METRIC

                #region ENGLISH
                else if (ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH)
                {
                    strUnitsString = ENGLISH_UNITS;
                }
                #endregion  // ENGLISH

                #region UNKNOWN
                else
                {
                    strUnitsString = "???";
                }
                #endregion  // UNKNOWN

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
            return strUnitsString;
        }
        #endregion  // GetSystemUnitsString()

        #region GetMagnitudeString()
        /// <summary>
        /// Get the Magnitude Units String
        /// </summary>
        /// <returns>Magnitude Units String</returns>
        public string GetMagnitudeString()
        {
            string strMethod = "GetMagnitudeString";
            string strUnitsString = String.Empty;
            try
            {
                #region BASE
                if (ProjectMagnitudeEnum == ProjectMagnitude.BASE)
                {
                    strUnitsString = MAG_BASE;
                }
                #endregion  // BASE

                #region KILO
                else if (ProjectMagnitudeEnum == ProjectMagnitude.KILO)
                {
                    strUnitsString = MAG_KILO;
                }
                #endregion  // KILO

                #region MEGA
                else if (ProjectMagnitudeEnum == ProjectMagnitude.MEGA)
                {
                    strUnitsString = MAG_MEGA;
                }
                #endregion  // MEGA

                #region UNKNOWN
                else
                {
                    strUnitsString = "???";
                }
                #endregion  // UNKNOWN

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
            return strUnitsString;
        }
        #endregion  // GetMagnitudeString()

        #region GetAreaString()
        /// <summary>
        /// Get Area Units String
        /// </summary>
        /// <returns>Area Units String</returns>
        public string GetAreaString()
        {
            string strMethod = "GetAreaString";
            string strUnitsString = String.Empty;
            try
            {
                #region METRIC
                if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                    (ProjectMetricAreaEnum == ProjectMetricArea.M2) )
                {
                    strUnitsString = SqM;
                }
                #endregion  // METRIC

                #region ENGLISH
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishAreaEnum == ProjectEnglishArea.FT2))
                {
                    strUnitsString = SqFt;
                }
                #endregion  // ENGLISH

                #region UNKNOWN
                else
                {
                    strUnitsString = "???";
                }
                #endregion  // UNKNOWN

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
            return strUnitsString;
        }
        #endregion  // GetAreaString()

        #region GetTemperatureString()
        /// <summary>
        /// Get Temperature Units String
        /// </summary>
        /// <returns>Temperature Units String</returns>
        public string GetTemperatureString()
        {
            string strMethod = "GetTemperatureString";
            string strUnitsString = String.Empty;
            try
            {
                #region METRIC
                if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                    (ProjectMetricTempEnum == ProjectMetricTemp.DEG_C))
                {
                    strUnitsString = DEG_C;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.KELVIN))
                {
                    strUnitsString = KELVIN;
                }
                #endregion  // METRIC

                #region ENGLISH
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_F))
                {
                    strUnitsString = DEG_F;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_R))
                {
                    strUnitsString = DEG_R;
                }
                #endregion  // ENGLISH

                #region UNKNOWN
                else
                {
                    strUnitsString = "???";
                }
                #endregion  // UNKNOWN

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
            return strUnitsString;
        }
        #endregion  // GetTemperatureString()

        #region GetPressureString()
        /// <summary>
        /// Get Pressure Units String
        /// </summary>
        /// <returns>Pressure Units String</returns>
        public string GetPressureString()
        {
            string strMethod = "GetPressureString";
            string strUnitsString = String.Empty;
            try
            {
                #region METRIC
                if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                    (ProjectMagnitudeEnum == ProjectMagnitude.BASE) &&
                    (ProjectMetricPressEnum == ProjectMetricPress.BAR))
                {
                    strUnitsString = Bar;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.BASE) &&
                         (ProjectMetricPressEnum == ProjectMetricPress.Pa))
                {
                    strUnitsString = Pa;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectMetricPressEnum == ProjectMetricPress.BAR))
                {
                    strUnitsString = KBar;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectMetricPressEnum == ProjectMetricPress.Pa))
                {
                    strUnitsString = kPa;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectMetricPressEnum == ProjectMetricPress.BAR))
                {
                    strUnitsString = MBar;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectMetricPressEnum == ProjectMetricPress.Pa))
                {
                    strUnitsString = MPa;
                }
                #endregion  // METRIC

                #region ENGLISH
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishPressEnum == ProjectEnglishPress.PSIA))
                {
                    strUnitsString = Psia;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishPressEnum == ProjectEnglishPress.PSIG))
                {
                    strUnitsString = Psig;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishPressEnum == ProjectEnglishPress.PSF))
                {
                    strUnitsString = Psfa;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishPressEnum == ProjectEnglishPress.ATM))
                {
                    strUnitsString = Atm;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishPressEnum == ProjectEnglishPress.IN_HG))
                {
                    strUnitsString = InHg;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishPressEnum == ProjectEnglishPress.IN_H2O))
                {
                    strUnitsString = InH2O;
                }
                #endregion  // ENGLISH

                #region UNKNOWN
                else
                {
                    strUnitsString = "???";
                }
                #endregion  // UNKNOWN

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
            return strUnitsString;
        }
        #endregion  // GetPressureString()

        #region GetEnthalpyString()
        /// <summary>
        /// Get Heat Flow (Enthalpy) Units String 
        /// </summary>
        /// <returns>Heat Flow (Enthalpy) Units String</returns>
        public string GetEnthalpyString()
        {
            string strMethod = "GetEnthalpyString";
            string strEnthalpyString = String.Empty;
            try
            {
                #region METRIC
                if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) && 
                   (ProjectMagnitudeEnum == ProjectMagnitude.BASE))
                {
                    strEnthalpyString = W_HEAT_FLOW;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO))
                {
                    strEnthalpyString = KW_HEAT_FLOW;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA))
                {
                    strEnthalpyString = MW_HEAT_FLOW;
                }
                #endregion  // METRIC

                #region ENGLISH
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.BASE))
                {
                    strEnthalpyString = BTU_HEAT_FLOW;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO))
                {
                    strEnthalpyString = KBTU_HEAT_FLOW;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA))
                {
                    strEnthalpyString = MMBTU_HEAT_FLOW;
                }
                #endregion  // ENGLISH

                #region UNKNOWN
                else
                {
                    strEnthalpyString = "???";
                }
                #endregion  // UNKNOWN

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
            return strEnthalpyString;
        }
        #endregion  // GetEnthalpyString()

        #region GetHeatCapacityFlowRateString()
        /// <summary>
        /// Get Heat Capacity Flow Rate (CP) Units String
        /// </summary>
        /// <returns>Heat Capacity Flow Rate (CP) Units String</returns>
        public string GetHeatCapacityFlowRateString()
        {
            string strMethod = "GetHeatCapacityFlowRateString";
            string strUnitsString = String.Empty;
            try
            {
                #region METRIC
                if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                   (ProjectMagnitudeEnum == ProjectMagnitude.BASE) &&
                   (ProjectMetricTempEnum == ProjectMetricTemp.DEG_C))
                {
                    strUnitsString = W_C_CP;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.BASE) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.KELVIN))
                {
                    strUnitsString = W_K_CP;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.DEG_C))
                {
                    strUnitsString = KW_C_CP;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.KELVIN))
                {
                    strUnitsString = KW_K_CP;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.DEG_C))
                {
                    strUnitsString = MW_C_CP;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.KELVIN))
                {
                    strUnitsString = MW_K_CP;
                }
                #endregion  // METRIC

                #region ENGLISH
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.BASE) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_F))
                {
                    strUnitsString = BTU_F_CP;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.BASE) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_R))
                {
                    strUnitsString = BTU_R_CP;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_F))
                {
                    strUnitsString = KBTU_F_CP;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_R))
                {
                    strUnitsString = KBTU_R_CP;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_F))
                {
                    strUnitsString = MMBTU_F_CP;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_R))
                {
                    strUnitsString = MMBTU_R_CP;
                }
                #endregion  // ENGLISH

                #region UNKNOWN
                else
                {
                    strUnitsString = "???";
                }
                #endregion  // UNKNOWN

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
            return strUnitsString;
        }
        #endregion  // GetHeatCapacityFlowRateString()

        #region GetHeatTransferCoefficientString()
        /// <summary>
        /// Get Heat Transfer Coefficient Units (U) String
        /// </summary>
        /// <returns>Heat Transfer Coefficient Units (U) String </returns>
        public string GetHeatTransferCoefficientString()
        {
            string strMethod = "GetHeatTransferCoefficientString";
            string strUnitsString = String.Empty;
            try
            {
                #region METRIC
                if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                   (ProjectMagnitudeEnum == ProjectMagnitude.BASE) &&
                   (ProjectMetricTempEnum == ProjectMetricTemp.DEG_C))
                {
                    strUnitsString = W_C_U;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.BASE) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.KELVIN))
                {
                    strUnitsString = W_K_U;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.DEG_C))
                {
                    strUnitsString = KW_C_U;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.KELVIN))
                {
                    strUnitsString = KW_K_U;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.DEG_C))
                {
                    strUnitsString = MW_C_U;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.KELVIN))
                {
                    strUnitsString = MW_K_U;
                }
                #endregion  // METRIC

                #region ENGLISH
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.BASE) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_F))
                {
                    strUnitsString = BTU_F_U;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.BASE) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_R))
                {
                    strUnitsString = BTU_R_U;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_F))
                {
                    strUnitsString = KBTU_F_U;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_R))
                {
                    strUnitsString = KBTU_R_U;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_F))
                {
                    strUnitsString = MMBTU_F_U;
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_R))
                {
                    strUnitsString = MMBTU_R_U;
                }
                #endregion  // ENGLISH

                #region UNKNOWN
                else
                {
                    strUnitsString = "???";
                }
                #endregion  // UNKNOWN

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
            return strUnitsString;
        }
        #endregion  // GetHeatTransferCoefficientString()

        #endregion  // GET UNIT STRINGS ... based on Property Settings

        #region GET ENUMERATION FROM STRING

        #region GetSystemUnitsEnum()
        /// <summary>
        /// Get the System Units Enum Given System Units String
        /// </summary>
        /// <param name="strSystemUnits">System Units String</param>
        /// <returns>System Units Enum value</returns>
        public ProjectSystemUnits GetSystemUnitsEnum(string strSystemUnits)
        {
            string strMethod = "GetSystemUnitsEnum";
            ProjectSystemUnits projectSystemUnitsEnum = ProjectSystemUnits.UNKNOWN;
            try
            {
                if(string.Compare(strSystemUnits, ENGLISH_UNITS, true) ==0) projectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;
                else if (string.Compare(strSystemUnits, METRIC_UNITS, true) == 0) projectSystemUnitsEnum = ProjectSystemUnits.METRIC;
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
            return projectSystemUnitsEnum;
        }
        #endregion  // GetSystemUnitsEnum()

        #region GetMagnitudeEnum()
        /// <summary>
        /// Get the Magnitude Enum Given Magnitude String
        /// </summary>
        /// <param name="strMagnitude">Magnitude String</param>
        /// <returns>Magnitude Enum value</returns>
        public ProjectMagnitude GetMagnitudeEnum(string strMagnitude)
        {
            string strMethod = "GetMagnitudeEnum";
            ProjectMagnitude projectMagnitudeEnum = ProjectMagnitude.UNKNOWN;
            try
            {
                if (string.Compare(strMagnitude, MAG_BASE, true) == 0) projectMagnitudeEnum = ProjectMagnitude.BASE;
                else if (string.Compare(strMagnitude, MAG_KILO, true) == 0) projectMagnitudeEnum = ProjectMagnitude.KILO;
                else if (string.Compare(strMagnitude, MAG_MEGA, true) == 0) projectMagnitudeEnum = ProjectMagnitude.MEGA;
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
            return projectMagnitudeEnum;
        }
        #endregion  // GetMagnitudeEnum()

        #region GetEnglishTempEnum()
        /// <summary>
        /// Get the English Temperature Enum Given English Temperature String
        /// </summary>
        /// <param name="strEnglishTemp">English Temperature String</param>
        /// <returns>English Temperature Enum value</returns>
        public ProjectEnglishTemp GetEnglishTempEnum(string strEnglishTemp)
        {
            string strMethod = "GetEnglishTempEnum";
            ProjectEnglishTemp projectEnglishTempEnum = ProjectEnglishTemp.UNKNOWN;
            try
            {
                if (string.Compare(strEnglishTemp, DEG_F, true) == 0) projectEnglishTempEnum = ProjectEnglishTemp.DEG_F;
                else if (string.Compare(strEnglishTemp, DEG_R, true) == 0) projectEnglishTempEnum = ProjectEnglishTemp.DEG_R;
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
            return projectEnglishTempEnum;
        }
        #endregion  // GetEnglishTempEnum()

        #region GetMetricTempEnum()
        /// <summary>
        /// Get the Metric Temperature Enum Given Metric Temperature String
        /// </summary>
        /// <param name="strMetricTemp">Metric Temperature String</param>
        /// <returns>Metric Temperature Enum value</returns>
        public ProjectMetricTemp GetMetricTempEnum(string strMetricTemp)
        {
            string strMethod = "GetMetricTempEnum";
            ProjectMetricTemp projectMetricTempEnum = ProjectMetricTemp.UNKNOWN;
            try
            {
                if (string.Compare(strMetricTemp, DEG_C, true) == 0) projectMetricTempEnum = ProjectMetricTemp.DEG_C;
                else if (string.Compare(strMetricTemp, KELVIN, true) == 0) projectMetricTempEnum = ProjectMetricTemp.KELVIN;
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
            return projectMetricTempEnum;
        }
        #endregion  // GetMetricTempEnum()

        #region GetEnglishPressEnum()
        /// <summary>
        /// Get the English Pressure Enum Given English Pressure String
        /// </summary>
        /// <param name="strEnglishPress">English Pressure String</param>
        /// <returns>English Pressure Enum value</returns>
        public ProjectEnglishPress GetEnglishPressEnum(string strEnglishPress)
        {
            string strMethod = "GetEnglishPressEnum";
            ProjectEnglishPress projectEnglishPressEnum = ProjectEnglishPress.UNKNOWN;
            try
            {
                if (string.Compare(strEnglishPress, Psia, true) == 0) projectEnglishPressEnum = ProjectEnglishPress.PSIA;
                else if (string.Compare(strEnglishPress, Psig, true) == 0) projectEnglishPressEnum = ProjectEnglishPress.PSIG;
                else if (string.Compare(strEnglishPress, Psfa, true) == 0) projectEnglishPressEnum = ProjectEnglishPress.PSF;
                else if (string.Compare(strEnglishPress, Atm, true) == 0) projectEnglishPressEnum = ProjectEnglishPress.ATM;
                else if (string.Compare(strEnglishPress, InHg, true) == 0) projectEnglishPressEnum = ProjectEnglishPress.IN_HG;
                else if (string.Compare(strEnglishPress, InH2O, true) == 0) projectEnglishPressEnum = ProjectEnglishPress.IN_H2O;
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
            return projectEnglishPressEnum;
        }
        #endregion  // GetEnglishPressEnum()

        #region GetMetricPressEnum()
        /// <summary>
        /// Get the Metric Pressure Enum Given Metric Pressure String
        /// </summary>
        /// <param name="strMetricPress">Metric Pressure String</param>
        /// <returns>Metric Pressure Enum value</returns>
        public ProjectMetricPress GetMetricPressEnum(string strMetricPress)
        {
            string strMethod = "GetMetricPressEnum";
            ProjectMetricPress projectMetricPressEnum = ProjectMetricPress.UNKNOWN;
            try
            {
                if (string.Compare(strMetricPress, Bar, true) == 0) projectMetricPressEnum = ProjectMetricPress.BAR;
                else if (string.Compare(strMetricPress, KBar, true) == 0) projectMetricPressEnum = ProjectMetricPress.BAR;
                else if (string.Compare(strMetricPress, MBar, true) == 0) projectMetricPressEnum = ProjectMetricPress.BAR;
                else if (string.Compare(strMetricPress, Pa, true) == 0) projectMetricPressEnum = ProjectMetricPress.Pa;
                else if (string.Compare(strMetricPress, kPa, true) == 0) projectMetricPressEnum = ProjectMetricPress.Pa;
                else if (string.Compare(strMetricPress, MPa, true) == 0) projectMetricPressEnum = ProjectMetricPress.Pa;
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
            return projectMetricPressEnum;
        }
        #endregion  // GetMetricPressEnum()

        #endregion  // GET ENUMERATION FROM STRING

    }
    #endregion      // public class HenProjectUnits
}
#endregion      // namespace HenGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
