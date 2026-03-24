#region HEADER
//#####################################################################################################################
//######################################  H e n P r o j e c t U n i t s . c s  ########################################
//#####################################################################################################################
//  FILENAME:  HenProjectUnits.cs
//  NAMESPACE: HenGlobal
//  CLASS(S):  HenProjectUnits
//  COMPONENT: _HenGLobal.dll
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
            UNKNOWN = -1,       // UNKNOWN Units
            ENGLISH = 0,       // ENGLISH-IMPERIAL Units
            METRIC = 1        // METRIC-SI Units
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
        public ProjectSystemUnits ProjectSystemUnitsEnum { get; set; } // Project System Units Enum [ UNKNOWN | ENGLISH | METRIC ]
        public ProjectMagnitude ProjectMagnitudeEnum { get; set; }     // Project Magnitude Enum [ UNKNOWN | BASE | KILO | MEGA ]

        public ProjectEnglishTemp ProjectEnglishTempEnum { get; set; }  // Project English Temp Enum [ UNKNOWN = -1 | DEG_F = 0 | DEG_R = 1 ]
        public ProjectMetricTemp ProjectMetricTempEnum { get; set; }    // Project Metric  Temp Enum [ UNKNOWN = -1 | DEG_C = 0 | K = 1 ]

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

                ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;     // INTERNAL

                ProjectMagnitudeEnum = ProjectMagnitude.KILO;           // INTERNAL

                ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_F;
                ProjectMetricTempEnum = ProjectMetricTemp.KELVIN;       // INTERNAL

                ProjectEnglishPressEnum = ProjectEnglishPress.PSIA;
                ProjectMetricPressEnum = ProjectMetricPress.Pa;         // INTERNAL (KPa)

                ProjectEnglishAreaEnum = ProjectEnglishArea.FT2;
                ProjectMetricAreaEnum = ProjectMetricArea.M2;           // INTERNAL

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
            lst.Add("Metric  - SI");
            lst.Add("English - Imperial");
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
            lst.Add("Base ... 10^0");
            lst.Add("Kilo ... 10^3");
            lst.Add("Mega ... 10^6");
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
            lst.Add("°F");
            lst.Add("°R");
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
            lst.Add("°C");
            lst.Add("K");
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
            lst.Add("psia");
            lst.Add("psig");
            lst.Add("psf");
            lst.Add("Atm");
            lst.Add("inHg");
            lst.Add("InH2O");
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
                    lst.Add("bar");
                    lst.Add("Pa");
                    break;

                case ProjectMagnitude.KILO:
                    lst.Add("kBar");
                    lst.Add("KPa");
                    break;

                case ProjectMagnitude.MEGA:
                    lst.Add("MBar");
                    lst.Add("MPa");
                    break;

                default:
                    lst.Add("???");
                    break;
            }
            
            return lst;
        }
        #endregion  // GetMetricPressList()

        #region GetHenOptimizerList()
        /// <summary>
        /// Get the List of Stings used for the HEN Optimizer List Combo Box Dropdowns
        /// </summary>
        /// <returns>List of HEN Optimizer strings for Combo Box</returns>
        public List<string> GetHenOptimizerList()
        {
            List<string> lst = new List<string>();

            lst.Clear();
            lst.Add("Genetic");
            lst.Add("Greedy");
            return lst;
        }
        #endregion  // GetHenOptimizerList()

        #endregion  // GET STRING LISTS FOR COMBO BOX DROPDOWN

        #region GET UNIT STRINGS ... based on Property Settings

        #region GetAreaString()
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
                    strUnitsString = "m2";
                }
                #endregion  // METRIC

                #region ENGLISH
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishAreaEnum == ProjectEnglishArea.FT2))
                {
                    strUnitsString = "ft2";
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
                    strUnitsString = "°C";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.KELVIN))
                {
                    strUnitsString = "K";
                }
                #endregion  // METRIC

                #region ENGLISH
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_F))
                {
                    strUnitsString = "°F";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_R))
                {
                    strUnitsString = "°R";
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
                    strUnitsString = "bar";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.BASE) &&
                         (ProjectMetricPressEnum == ProjectMetricPress.Pa))
                {
                    strUnitsString = "Pa";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectMetricPressEnum == ProjectMetricPress.BAR))
                {
                    strUnitsString = "kBar";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectMetricPressEnum == ProjectMetricPress.Pa))
                {
                    strUnitsString = "kPa";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectMetricPressEnum == ProjectMetricPress.BAR))
                {
                    strUnitsString = "mBar";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectMetricPressEnum == ProjectMetricPress.Pa))
                {
                    strUnitsString = "MPa";
                }
                #endregion  // METRIC

                #region ENGLISH
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishPressEnum == ProjectEnglishPress.PSIA))
                {
                    strUnitsString = "psia";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishPressEnum == ProjectEnglishPress.PSIG))
                {
                    strUnitsString = "psig";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishPressEnum == ProjectEnglishPress.PSF))
                {
                    strUnitsString = "psf";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishPressEnum == ProjectEnglishPress.ATM))
                {
                    strUnitsString = "atm";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishPressEnum == ProjectEnglishPress.IN_HG))
                {
                    strUnitsString = "inHg";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectEnglishPressEnum == ProjectEnglishPress.IN_H2O))
                {
                    strUnitsString = "inH2O";
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
                    strEnthalpyString = "W";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO))
                {
                    strEnthalpyString = "kW";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA))
                {
                    strEnthalpyString = "MW";
                }
                #endregion  // METRIC

                #region ENGLISH
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.BASE))
                {
                    strEnthalpyString = "Btu/hr";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO))
                {
                    strEnthalpyString = "kBtu/hr";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA))
                {
                    strEnthalpyString = "MMBtu/hr";
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
                    strUnitsString = "W/°C";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.BASE) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.KELVIN))
                {
                    strUnitsString = "W/K";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.DEG_C))
                {
                    strUnitsString = "kW/°C";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.KELVIN))
                {
                    strUnitsString = "kW/K";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.DEG_C))
                {
                    strUnitsString = "MW/°C";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.KELVIN))
                {
                    strUnitsString = "MW/K";
                }
                #endregion  // METRIC

                #region ENGLISH
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.BASE) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_F))
                {
                    strUnitsString = "Btu/(hr °F)";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.BASE) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_R))
                {
                    strUnitsString = "Btu/(hr °R)";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_F))
                {
                    strUnitsString = "kBtu/(hr °F)";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_R))
                {
                    strUnitsString = "kBtu/(hr °R)";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_F))
                {
                    strUnitsString = "MMBtu/(hr °F)";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_R))
                {
                    strUnitsString = "MMBtu/(hr °R)";
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
                    strUnitsString = "W/(m2 °C)";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.BASE) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.KELVIN))
                {
                    strUnitsString = "W/(m2 K)";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.DEG_C))
                {
                    strUnitsString = "kW/(m2 °C)";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.KELVIN))
                {
                    strUnitsString = "kW/(m2 K)";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.DEG_C))
                {
                    strUnitsString = "MW/(m2 °C)";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.METRIC) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectMetricTempEnum == ProjectMetricTemp.KELVIN))
                {
                    strUnitsString = "MW/(m2 K)";
                }
                #endregion  // METRIC

                #region ENGLISH
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.BASE) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_F))
                {
                    strUnitsString = "Btu/(hr ft2 °F)";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.BASE) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_R))
                {
                    strUnitsString = "Btu/(hr ft2 °R)";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_F))
                {
                    strUnitsString = "kBtu/(hr ft2 °F)";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.KILO) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_R))
                {
                    strUnitsString = "kBtu/(hr ft2 °R)";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_F))
                {
                    strUnitsString = "MMBtu/(hr ft2 °F)";
                }
                else if ((ProjectSystemUnitsEnum == ProjectSystemUnits.ENGLISH) &&
                         (ProjectMagnitudeEnum == ProjectMagnitude.MEGA) &&
                         (ProjectEnglishTempEnum == ProjectEnglishTemp.DEG_R))
                {
                    strUnitsString = "MMBtu/(hr ft2 °R)";
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


    }
    #endregion      // public class HenProjectUnits
}
#endregion      // namespace HenGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
