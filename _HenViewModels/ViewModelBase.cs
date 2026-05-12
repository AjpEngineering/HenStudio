#region HEADER
//#####################################################################################################################
//########################################  V i e w M o d e l B a s e . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  ViewModelBase.cs
//  NAMESPACE: HenViewModel
//  CLASS(S):  ViewModelBase
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the base class for HEN Studio view model classes.
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
//    01/01/26 .. AJP Engineering .. Version 1.0
//#####################################################################################################################
//#####################################################################################################################
//#####################################################################################################################
#endregion      // HEADER

#region REFERENCES
using HenGlobal;

using static HenGlobal.HenProjectUnits;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES


#region namespace HenViewModel
namespace HenViewModel
{
    #region public abstract class ViewModelBase
    /// <summary>
    /// View model base class.
    /// </summary>
    public abstract class ViewModelBase
    {
        #region CONSTANTS
        const string NAMESPACE = "HenViewModels";
        const string CLASS = "ViewModelBase";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public HenProjectUnits ExternalUnitsObj { get; set; }
        public HenProjectUnits InternalUnitsObj { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        protected ViewModelBase()
        {
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

        #region CONVERSION FIELD PUBLIC METHODS

        #region AREA (A) CONVERSION METHODS

        #region ConvertToExternalArea()
        /// <summary>
        /// Conver the Area (A) value from INTERNAL Units to EXTERNAL Units.
        /// </summary>
        /// <param name="dInternalValue"></param>
        /// <returns>Area (A) in EXTERNAL Units on Success; 0.0 otherwise</returns>
        public double ConvertToExternalArea(double dInternalValue)
        {
            double dExternalValue = 0.0;
            dExternalValue = ConvertFromInternal(HenGlobal.HenTypes.ConversionUnitsTypes.A,
                                                 dInternalValue,
                                                 ExternalUnitsObj,
                                                 InternalUnitsObj);
            return dExternalValue;
        }
        #endregion  // ConvertToExternalArea()

        #region ConvertFromExternalArea()
        /// <summary>
        /// Conver the Area (A) value from EXTERNAL Units to INTERNAL Units.
        /// </summary>
        /// <param name="dExternalValue"></param>
        /// <returns>Area (A) in INTERNAL Units on Success; 0.0 otherwise</returns>
        public double ConvertFromExternalArea(double dExternalValue)
        {
            double dInternalValue = 0.0;
            dInternalValue = ConvertToInternal(HenGlobal.HenTypes.ConversionUnitsTypes.A,
                                              dExternalValue,
                                              ExternalUnitsObj,
                                              InternalUnitsObj);
            return dInternalValue;
        }
        #endregion  // ConvertFromExternalArea()

        #endregion  // AREA (A) CONVERSION METHODS

        #region TEMPERATURE (TEMP) CONVERSION METHODS

        #region ConvertToExternalTemp()
        /// <summary>
        /// Conver the Temperature (Temp) value from INTERNAL Units to EXTERNAL Units.
        /// </summary>
        /// <param name="dInternalValue"></param>
        /// <returns>Temperature (Temp) in EXTERNAL Units on Success; 0.0 otherwise</returns>
        public double ConvertToExternalTemp(double dInternalValue)
        {
            double dExternalValue = 0.0;
            dExternalValue = ConvertFromInternal(HenGlobal.HenTypes.ConversionUnitsTypes.TEMP,
                                                 dInternalValue,
                                                 ExternalUnitsObj,
                                                 InternalUnitsObj);
            return dExternalValue;
        }
        #endregion  // ConvertToExternalTemp()

        #region ConvertFromExternalTemp()
        /// <summary>
        /// Conver the Temperature (Temp) value from EXTERNAL Units to INTERNAL Units.
        /// </summary>
        /// <param name="dExternalValue"></param>
        /// <returns>Temperature (Temp) in INTERNAL Units on Success; 0.0 otherwise</returns>
        public double ConvertFromExternalTemp(double dExternalValue)
        {
            double dInternalValue = 0.0;
            dInternalValue = ConvertToInternal(HenGlobal.HenTypes.ConversionUnitsTypes.TEMP,
                                              dExternalValue,
                                              ExternalUnitsObj,
                                              InternalUnitsObj);
            return dInternalValue;
        }
        #endregion  // ConvertFromExternalTemp()

        #endregion  // TEMPERATURE (TEMP) CONVERSION METHODS

        #region PRESSURE (PRESS) CONVERSION METHODS

        #region ConvertToExternalPress()
        /// <summary>
        /// Conver the Pressure (Press) value from INTERNAL Units to EXTERNAL Units.
        /// </summary>
        /// <param name="dInternalValue"></param>
        /// <returns>Pressure (Press) in EXTERNAL Units on Success; 0.0 otherwise</returns>
        public double ConvertToExternalPress(double dInternalValue)
        {
            double dExternalValue = 0.0;
            dExternalValue = ConvertFromInternal(HenGlobal.HenTypes.ConversionUnitsTypes.PRESS,
                                                 dInternalValue,
                                                 ExternalUnitsObj,
                                                 InternalUnitsObj);
            return dExternalValue;
        }
        #endregion  // ConvertToExternalPress()

        #region ConvertFromExternalPress()
        /// <summary>
        /// Conver the Pressure (Press) value from EXTERNAL Units to INTERNAL Units.
        /// </summary>
        /// <param name="dExternalValue"></param>
        /// <returns>Pressure (Press) in INTERNAL Units on Success; 0.0 otherwise</returns>
        public double ConvertFromExternalPress(double dExternalValue)
        {
            double dInternalValue = 0.0;
            dInternalValue = ConvertToInternal(HenGlobal.HenTypes.ConversionUnitsTypes.PRESS,
                                              dExternalValue,
                                              ExternalUnitsObj,
                                              InternalUnitsObj);
            return dInternalValue;
        }
        #endregion  // ConvertFromExternalPress()

        #endregion  // PRESSURE (PRESS) CONVERSION METHODS

        #region ENTHALPY ... HEAT FLOW (H) CONVERSION METHODS

        #region ConvertToExternalH()
        /// <summary>
        /// Conver the Enthaply ... Heat Flow (H) value from INTERNAL Units to EXTERNAL Units.
        /// </summary>
        /// <param name="dInternalValue"></param>
        /// <returns>Enthalpy ... Heat Flow (H) in EXTERNAL Units on Success; 0.0 otherwise</returns>
        public double ConvertToExternalH(double dInternalValue)
        {
            double dExternalValue = 0.0;
            dExternalValue = ConvertFromInternal(HenGlobal.HenTypes.ConversionUnitsTypes.HEAT_FLOW,
                                                 dInternalValue,
                                                 ExternalUnitsObj,
                                                 InternalUnitsObj);
            return dExternalValue;
        }
        #endregion  // ConvertToExternalH()

        #region ConvertFromExternalH()
        /// <summary>
        /// Conver the Enthaply ... Heat Flow (H) value from EXTERNAL Units to INTERNAL Units.
        /// </summary>
        /// <param name="dExternalValue"></param>
        /// <returns>Enthalpy ... Heat Flow (H) in INTERNAL Units on Success; 0.0 otherwise</returns>
        public double ConvertFromExternalH(double dExternalValue)
        {
            double dInternalValue = 0.0;
            dInternalValue = ConvertToInternal(HenGlobal.HenTypes.ConversionUnitsTypes.HEAT_FLOW,
                                               dExternalValue,
                                               ExternalUnitsObj,
                                               InternalUnitsObj);
            return dInternalValue;
        }
        #endregion  // ConvertFromExternalH()

        #endregion  // ENTHALPY ... HEAT FLOW (H) CONVERSION METHODS

        #region HEAT CAPACITY FLOW RATE (CP) CONVERSION METHODS

        #region ConvertToExternalCP()
        /// <summary>
        /// Conver the Heat Capacity Flow Rate (CP) value from INTERNAL Units to EXTERNAL Units.
        /// </summary>
        /// <param name="dInternalValue"></param>
        /// <returns>Heat Capacity Flow Rate  (CP) in EXTERNAL Units on Success; 0.0 otherwise</returns>
        public double ConvertToExternalCP(double dInternalValue)
        {
            double dExternalValue = 0.0;
            dExternalValue = ConvertFromInternal(HenGlobal.HenTypes.ConversionUnitsTypes.CP,
                                                 dInternalValue,
                                                 ExternalUnitsObj,
                                                 InternalUnitsObj);
            return dExternalValue;
        }
        #endregion  // ConvertToExternalCP()

        #region ConvertFromExternalCP()
        /// <summary>
        /// Conver the Heat Capacity Flow Rate (CP) value from EXTERNAL Units to INTERNAL Units.
        /// </summary>
        /// <param name="dExternalValue"></param>
        /// <returns>Heat CapacityFlow Rate (CP) in INTERNAL Units on Success; 0.0 otherwise</returns>
        public double ConvertFromExternalCP(double dExternalValue)
        {
            double dInternalValue = 0.0;
            dInternalValue = ConvertToInternal(HenGlobal.HenTypes.ConversionUnitsTypes.CP,
                                               dExternalValue,
                                               ExternalUnitsObj,
                                               InternalUnitsObj);
            return dInternalValue;
        }
        #endregion  // ConvertFromExternalCP()

        #endregion  // HEAT CAPACITY FLOW RATE (CP) CONVERSION METHODS

        #region HEAT TRANSFER COEFFICIENT (U) CONVERSION METHODS

        #region ConvertToExternalU()
        /// <summary>
        /// Conver the Heat Transfer Coefficient (U) value from INTERNAL Units to EXTERNAL Units.
        /// </summary>
        /// <param name="dInternalValue"></param>
        /// <returns>Heat Transfer Coefficient (U) in EXTERNAL Units on Success; 0.0 otherwise</returns>
        public double ConvertToExternalU(double dInternalValue)
        {
            double dExternalValue = 0.0;
            dExternalValue = ConvertFromInternal(HenGlobal.HenTypes.ConversionUnitsTypes.U,
                                                 dInternalValue,
                                                 ExternalUnitsObj,
                                                 InternalUnitsObj);
            return dExternalValue;
        }
        #endregion  // ConvertToExternalU()
        
        #region ConvertFromExternalU()
        /// <summary>
        /// Conver the Heat Transfer Coefficient (U) value from EXTERNAL Units to INTERNAL Units.
        /// </summary>
        /// <param name="dExternalValue"></param>
        /// <returns>Heat Transfer Coefficient (U) in INTERNAL Units on Success; 0.0 otherwise</returns>
        public double ConvertFromExternalU(double dExternalValue)
        {
            double dInternalValue = 0.0;
            dInternalValue = ConvertToInternal(HenGlobal.HenTypes.ConversionUnitsTypes.U,
                                               dExternalValue,
                                               ExternalUnitsObj,
                                               InternalUnitsObj);
            return dInternalValue;
        }
        #endregion  // ConvertToExternalU()

        #endregion  // HEAT TRANSFER COEFFICIENT (U) CONVERSION METHODS

        #endregion  // CONVERSION FIELD PUBLIC METHODS

        #region UNITS CONVERSION PRIVATE METHODS

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

        #endregion  // UNITS CONVERSION PRIVATE METHODS    
    }
    #endregion      // public abstract class ViewModelBase
}
#endregion      // namespace HenViewModel

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
