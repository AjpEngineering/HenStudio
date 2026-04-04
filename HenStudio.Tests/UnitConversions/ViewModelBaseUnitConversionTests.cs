#region HEADER
//#####################################################################################################################
//##########################  V i e w M o d e l B a s e U n i t C o n v e r s i o n T e s t s . c s  ##################
//#####################################################################################################################
//  FILENAME:  ViewModelBaseUnitConversionTests.cs
//  NAMESPACE: HenStudio.Tests.UnitConversions
//  CLASS(S):  ViewModelBaseUnitConversionTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for the unit conversion methods in ViewModelBase.
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
using HenStudio.Tests.Helpers;
using HenViewModels;

using static HenGlobal.HenProjectUnits;

using System;
using System.Collections.Generic;

using NUnit.Framework;
#endregion      // REFERENCES

#region namespace HenStudio.Tests.UnitConversions
namespace HenStudio.Tests.UnitConversions
{
    #region public class ViewModelBaseUnitConversionTests
    /// <summary>
    /// Unit tests for the unit conversion methods in ViewModelBase.
    /// </summary>
    [TestFixture]
    public class ViewModelBaseUnitConversionTests
    {
        #region PRIVATE CLASSES

        #region private sealed class TestViewModel
        /// <summary>
        /// Test view model class for exercising ViewModelBase methods.
        /// </summary>
        private sealed class TestViewModel : ViewModelBase
        {
        }
        #endregion      // private sealed class TestViewModel

        #region private sealed class ConversionTestCase
        /// <summary>
        /// Conversion test case class.
        /// </summary>
        public sealed class ConversionTestCase
        {
            #region PROPERTIES
            public string Name { get; set; }
            public HenTypes.ConversionUnitsTypes ConversionType { get; set; }
            public double InputValue { get; set; }
            public double ExpectedValue { get; set; }
            public HenProjectUnits ExternalUnits { get; set; }
            #endregion      // PROPERTIES
        }
        #endregion      // private sealed class ConversionTestCase

        #endregion      // PRIVATE CLASSES

        #region PRIVATE METHODS

        #region CreateConvertFromInternalCase()
        /// <summary>
        /// Creates a test case for ConvertFromInternal.
        /// </summary>
        /// <param name="name">The test case name.</param>
        /// <param name="conversionType">The conversion units type.</param>
        /// <param name="internalValue">The internal value to convert.</param>
        /// <param name="expectedValue">The expected external value.</param>
        /// <param name="externalUnits">The external units object.</param>
        /// <returns>A configured <see cref="TestCaseData"/> instance.</returns>
        private static TestCaseData CreateConvertFromInternalCase(string name,
                                                                  HenTypes.ConversionUnitsTypes conversionType,
                                                                  double internalValue,
                                                                  double expectedValue,
                                                                  HenProjectUnits externalUnits)
        {
            return new TestCaseData(new ConversionTestCase
            {
                Name = name,
                ConversionType = conversionType,
                InputValue = internalValue,
                ExpectedValue = expectedValue,
                ExternalUnits = externalUnits
            }).SetName(name);
        }
        #endregion      // CreateConvertFromInternalCase()

        #region CreateConvertToInternalCase()
        /// <summary>
        /// Creates a test case for ConvertToInternal.
        /// </summary>
        /// <param name="name">The test case name.</param>
        /// <param name="conversionType">The conversion units type.</param>
        /// <param name="externalValue">The external value to convert.</param>
        /// <param name="expectedValue">The expected internal value.</param>
        /// <param name="externalUnits">The external units object.</param>
        /// <returns>A configured <see cref="TestCaseData"/> instance.</returns>
        private static TestCaseData CreateConvertToInternalCase(string name,
                                                                HenTypes.ConversionUnitsTypes conversionType,
                                                                double externalValue,
                                                                double expectedValue,
                                                                HenProjectUnits externalUnits)
        {
            return new TestCaseData(new ConversionTestCase
            {
                Name = name,
                ConversionType = conversionType,
                InputValue = externalValue,
                ExpectedValue = expectedValue,
                ExternalUnits = externalUnits
            }).SetName(name);
        }
        #endregion      // CreateConvertToInternalCase()

        #region CreateEnglishAreaUnits()
        /// <summary>
        /// Creates an external units object configured for English area units.
        /// </summary>
        /// <returns>A <see cref="HenProjectUnits"/> object configured for English area units.</returns>
        private static HenProjectUnits CreateEnglishAreaUnits()
        {
            HenProjectUnits externalUnits = new HenProjectUnits();

            externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;
            externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;
            externalUnits.ProjectEnglishAreaEnum = ProjectEnglishArea.FT2;
            externalUnits.ProjectMetricAreaEnum = ProjectMetricArea.M2;
            return externalUnits;
        }
        #endregion      // CreateEnglishAreaUnits()

        #region CreateMetricTemperatureUnits()
        /// <summary>
        /// Creates an external units object configured for metric temperature units.
        /// </summary>
        /// <param name="magnitude">The metric magnitude units.</param>
        /// <param name="temperature">The metric temperature units.</param>
        /// <returns>A <see cref="HenProjectUnits"/> object configured for metric temperature units.</returns>
        private static HenProjectUnits CreateMetricTemperatureUnits(ProjectMagnitude magnitude,
                                                                    ProjectMetricTemp temperature)
        {
            HenProjectUnits externalUnits = new HenProjectUnits();

            externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;
            externalUnits.ProjectMagnitudeEnum = magnitude;
            externalUnits.ProjectMetricTempEnum = temperature;
            return externalUnits;
        }
        #endregion      // CreateMetricTemperatureUnits()

        #region CreateEnglishTemperatureUnits()
        /// <summary>
        /// Creates an external units object configured for English temperature units.
        /// </summary>
        /// <param name="magnitude">The English magnitude units.</param>
        /// <param name="temperature">The English temperature units.</param>
        /// <returns>A <see cref="HenProjectUnits"/> object configured for English temperature units.</returns>
        private static HenProjectUnits CreateEnglishTemperatureUnits(ProjectMagnitude magnitude,
                                                                     ProjectEnglishTemp temperature)
        {
            HenProjectUnits externalUnits = new HenProjectUnits();

            externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;
            externalUnits.ProjectMagnitudeEnum = magnitude;
            externalUnits.ProjectEnglishTempEnum = temperature;
            return externalUnits;
        }
        #endregion      // CreateEnglishTemperatureUnits()

        #region CreateMetricPressureUnits()
        /// <summary>
        /// Creates an external units object configured for metric pressure units.
        /// </summary>
        /// <param name="magnitude">The metric magnitude units.</param>
        /// <param name="pressure">The metric pressure units.</param>
        /// <returns>A <see cref="HenProjectUnits"/> object configured for metric pressure units.</returns>
        private static HenProjectUnits CreateMetricPressureUnits(ProjectMagnitude magnitude,
                                                                 ProjectMetricPress pressure)
        {
            HenProjectUnits externalUnits = new HenProjectUnits();

            externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;
            externalUnits.ProjectMagnitudeEnum = magnitude;
            externalUnits.ProjectMetricPressEnum = pressure;
            return externalUnits;
        }
        #endregion      // CreateMetricPressureUnits()

        #region CreateEnglishPressureUnits()
        /// <summary>
        /// Creates an external units object configured for English pressure units.
        /// </summary>
        /// <param name="pressure">The English pressure units.</param>
        /// <returns>A <see cref="HenProjectUnits"/> object configured for English pressure units.</returns>
        private static HenProjectUnits CreateEnglishPressureUnits(ProjectEnglishPress pressure)
        {
            HenProjectUnits externalUnits = new HenProjectUnits();

            externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;
            externalUnits.ProjectEnglishPressEnum = pressure;
            return externalUnits;
        }
        #endregion      // CreateEnglishPressureUnits()

        #region CreateConfiguredViewModel()
        /// <summary>
        /// Creates a test view model configured with the supplied external units and default internal units.
        /// </summary>
        /// <param name="externalUnits">The external units object for the test case.</param>
        /// <returns>A configured <see cref="TestViewModel"/> instance.</returns>
        private static TestViewModel CreateConfiguredViewModel(HenProjectUnits externalUnits)
        {
            TestViewModel viewModel = new TestViewModel();

            viewModel.ExternalUnitsObj = externalUnits;
            viewModel.InternalUnitsObj = new HenProjectUnits();

            return viewModel;
        }
        #endregion      // CreateConfiguredViewModel()

        #region ConvertToExternalFieldValue()
        /// <summary>
        /// Executes the field-specific internal-to-external wrapper method for the supplied conversion type.
        /// </summary>
        /// <param name="viewModel">The configured test view model.</param>
        /// <param name="conversionType">The conversion type to execute.</param>
        /// <param name="internalValue">The internal value to convert.</param>
        /// <returns>The converted external value.</returns>
        private static double ConvertToExternalFieldValue(TestViewModel viewModel,
                                                          HenTypes.ConversionUnitsTypes conversionType,
                                                          double internalValue)
        {
            switch (conversionType)
            {
                case HenTypes.ConversionUnitsTypes.A:
                    return viewModel.ConvertToExternalArea(internalValue);

                case HenTypes.ConversionUnitsTypes.TEMP:
                    return viewModel.ConvertToExternalTemp(internalValue);

                case HenTypes.ConversionUnitsTypes.PRESS:
                    return viewModel.ConvertToExternalPress(internalValue);

                case HenTypes.ConversionUnitsTypes.HEAT_FLOW:
                    return viewModel.ConvertToExternalH(internalValue);

                case HenTypes.ConversionUnitsTypes.CP:
                    return viewModel.ConvertToExternalCP(internalValue);

                case HenTypes.ConversionUnitsTypes.U:
                    return viewModel.ConvertToExternalU(internalValue);

                default:
                    throw new ArgumentOutOfRangeException(nameof(conversionType), conversionType, null);
            }
        }
        #endregion      // ConvertToExternalFieldValue()

        #region ConvertFromExternalFieldValue()
        /// <summary>
        /// Executes the field-specific external-to-internal wrapper method for the supplied conversion type.
        /// </summary>
        /// <param name="viewModel">The configured test view model.</param>
        /// <param name="conversionType">The conversion type to execute.</param>
        /// <param name="externalValue">The external value to convert.</param>
        /// <returns>The converted internal value.</returns>
        private static double ConvertFromExternalFieldValue(TestViewModel viewModel,
                                                            HenTypes.ConversionUnitsTypes conversionType,
                                                            double externalValue)
        {
            switch (conversionType)
            {
                case HenTypes.ConversionUnitsTypes.A:
                    return viewModel.ConvertFromExternalArea(externalValue);

                case HenTypes.ConversionUnitsTypes.TEMP:
                    return viewModel.ConvertFromExternalTemp(externalValue);

                case HenTypes.ConversionUnitsTypes.PRESS:
                    return viewModel.ConvertFromExternalPress(externalValue);

                case HenTypes.ConversionUnitsTypes.HEAT_FLOW:
                    return viewModel.ConvertFromExternalH(externalValue);

                case HenTypes.ConversionUnitsTypes.CP:
                    return viewModel.ConvertFromExternalCP(externalValue);

                case HenTypes.ConversionUnitsTypes.U:
                    return viewModel.ConvertFromExternalU(externalValue);

                default:
                    throw new ArgumentOutOfRangeException(nameof(conversionType), conversionType, null);
            }
        }
        #endregion      // ConvertFromExternalFieldValue()

        #region GetConvertFromInternalCases()
        /// <summary>
        /// Gets the ConvertFromInternal test cases derived from TestUnitConversions.
        /// </summary>
        /// <returns>A sequence of NUnit test cases for ConvertFromInternal.</returns>
        private static IEnumerable<TestCaseData> GetConvertFromInternalCases()
        {
            yield return CreateConvertFromInternalCase("ConvertFromInternal_Area_M2_To_FT2",
                                                       HenTypes.ConversionUnitsTypes.A,
                                                       400.0,
                                                       4305.56417,
                                                       CreateEnglishAreaUnits());

            yield return CreateConvertFromInternalCase("ConvertFromInternal_Temperature_K_To_C",
                                                       HenTypes.ConversionUnitsTypes.TEMP,
                                                       400.0,
                                                       126.85,
                                                       CreateMetricTemperatureUnits(ProjectMagnitude.KILO, ProjectMetricTemp.DEG_C));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_Temperature_K_To_F",
                                                       HenTypes.ConversionUnitsTypes.TEMP,
                                                       400.0,
                                                       260.33,
                                                       CreateEnglishTemperatureUnits(ProjectMagnitude.MEGA, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_Temperature_K_To_R",
                                                       HenTypes.ConversionUnitsTypes.TEMP,
                                                       400.0,
                                                       720.0,
                                                       CreateEnglishTemperatureUnits(ProjectMagnitude.MEGA, ProjectEnglishTemp.DEG_R));

            yield return CreateConvertFromInternalCase("ConvertFromInternal_Pressure_KPa_To_PSIA",
                                                       HenTypes.ConversionUnitsTypes.PRESS,
                                                       400.0,
                                                       58.015072,
                                                       CreateEnglishPressureUnits(ProjectEnglishPress.PSIA));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_Pressure_KPa_To_PSIG",
                                                       HenTypes.ConversionUnitsTypes.PRESS,
                                                       400.0,
                                                       43.319172,
                                                       CreateEnglishPressureUnits(ProjectEnglishPress.PSIG));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_Pressure_KPa_To_PSFA",
                                                       HenTypes.ConversionUnitsTypes.PRESS,
                                                       400.0,
                                                       8354.1664,
                                                       CreateEnglishPressureUnits(ProjectEnglishPress.PSF));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_Pressure_KPa_To_ATM",
                                                       HenTypes.ConversionUnitsTypes.PRESS,
                                                       400.0,
                                                       3.947692,
                                                       CreateEnglishPressureUnits(ProjectEnglishPress.ATM));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_Pressure_KPa_To_InHg",
                                                       HenTypes.ConversionUnitsTypes.PRESS,
                                                       400.0,
                                                       118.11988,
                                                       CreateEnglishPressureUnits(ProjectEnglishPress.IN_HG));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_Pressure_KPa_To_InH2O",
                                                       HenTypes.ConversionUnitsTypes.PRESS,
                                                       400.0,
                                                       1605.896,
                                                       CreateEnglishPressureUnits(ProjectEnglishPress.IN_H2O));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_Pressure_KPa_To_Bar",
                                                       HenTypes.ConversionUnitsTypes.PRESS,
                                                       400.0,
                                                       4.0,
                                                       CreateMetricPressureUnits(ProjectMagnitude.BASE, ProjectMetricPress.BAR));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_Pressure_KPa_To_KBar",
                                                       HenTypes.ConversionUnitsTypes.PRESS,
                                                       400.0,
                                                       0.004,
                                                       CreateMetricPressureUnits(ProjectMagnitude.KILO, ProjectMetricPress.BAR));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_Pressure_KPa_To_MBar",
                                                       HenTypes.ConversionUnitsTypes.PRESS,
                                                       400.0,
                                                       0.000004,
                                                       CreateMetricPressureUnits(ProjectMagnitude.MEGA, ProjectMetricPress.BAR));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_Pressure_KPa_To_Pa",
                                                       HenTypes.ConversionUnitsTypes.PRESS,
                                                       400.0,
                                                       400000.0,
                                                       CreateMetricPressureUnits(ProjectMagnitude.BASE, ProjectMetricPress.Pa));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_Pressure_KPa_To_MPa",
                                                       HenTypes.ConversionUnitsTypes.PRESS,
                                                       400.0,
                                                       0.400,
                                                       CreateMetricPressureUnits(ProjectMagnitude.MEGA, ProjectMetricPress.Pa));

            yield return CreateConvertFromInternalCase("ConvertFromInternal_HeatFlow_KW_To_W",
                                                       HenTypes.ConversionUnitsTypes.HEAT_FLOW,
                                                       4.0,
                                                       4000.0,
                                                       CreateMetricTemperatureUnits(ProjectMagnitude.BASE, ProjectMetricTemp.KELVIN));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_HeatFlow_KW_To_MW",
                                                       HenTypes.ConversionUnitsTypes.HEAT_FLOW,
                                                       4.0,
                                                       0.004,
                                                       CreateMetricTemperatureUnits(ProjectMagnitude.MEGA, ProjectMetricTemp.KELVIN));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_HeatFlow_KW_To_BTUPerHour",
                                                       HenTypes.ConversionUnitsTypes.HEAT_FLOW,
                                                       4.0,
                                                       13648.568,
                                                       CreateEnglishTemperatureUnits(ProjectMagnitude.BASE, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_HeatFlow_KW_To_KBTUPerHour",
                                                       HenTypes.ConversionUnitsTypes.HEAT_FLOW,
                                                       4.0,
                                                       13.6486,
                                                       CreateEnglishTemperatureUnits(ProjectMagnitude.KILO, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_HeatFlow_KW_To_MMBTUPerHour",
                                                       HenTypes.ConversionUnitsTypes.HEAT_FLOW,
                                                       4.0,
                                                       0.0136486,
                                                       CreateEnglishTemperatureUnits(ProjectMagnitude.MEGA, ProjectEnglishTemp.DEG_F));

            yield return CreateConvertFromInternalCase("ConvertFromInternal_CP_KWK_To_WPerC",
                                                       HenTypes.ConversionUnitsTypes.CP,
                                                       4.0,
                                                       4000.0,
                                                       CreateMetricTemperatureUnits(ProjectMagnitude.BASE, ProjectMetricTemp.DEG_C));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_CP_KWK_To_WPerK",
                                                       HenTypes.ConversionUnitsTypes.CP,
                                                       4.0,
                                                       4000.0,
                                                       CreateMetricTemperatureUnits(ProjectMagnitude.BASE, ProjectMetricTemp.KELVIN));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_CP_KWK_To_KWPerC",
                                                       HenTypes.ConversionUnitsTypes.CP,
                                                       4.0,
                                                       4.0,
                                                       CreateMetricTemperatureUnits(ProjectMagnitude.KILO, ProjectMetricTemp.DEG_C));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_CP_KWK_To_MWPerC",
                                                       HenTypes.ConversionUnitsTypes.CP,
                                                       4.0,
                                                       0.004000,
                                                       CreateMetricTemperatureUnits(ProjectMagnitude.MEGA, ProjectMetricTemp.DEG_C));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_CP_KWK_To_MWPerK",
                                                       HenTypes.ConversionUnitsTypes.CP,
                                                       4.0,
                                                       0.004000,
                                                       CreateMetricTemperatureUnits(ProjectMagnitude.MEGA, ProjectMetricTemp.KELVIN));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_CP_KWK_To_BTUPerHourPerF",
                                                       HenTypes.ConversionUnitsTypes.CP,
                                                       4.0,
                                                       7582.520,
                                                       CreateEnglishTemperatureUnits(ProjectMagnitude.BASE, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_CP_KWK_To_BTUPerHourPerR",
                                                       HenTypes.ConversionUnitsTypes.CP,
                                                       4.0,
                                                       7582.520,
                                                       CreateEnglishTemperatureUnits(ProjectMagnitude.BASE, ProjectEnglishTemp.DEG_R));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_CP_KWK_To_KBTUPerHourPerF",
                                                       HenTypes.ConversionUnitsTypes.CP,
                                                       4.0,
                                                       7.582520,
                                                       CreateEnglishTemperatureUnits(ProjectMagnitude.KILO, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_CP_KWK_To_KBTUPerHourPerR",
                                                       HenTypes.ConversionUnitsTypes.CP,
                                                       4.0,
                                                       7.582520,
                                                       CreateEnglishTemperatureUnits(ProjectMagnitude.KILO, ProjectEnglishTemp.DEG_R));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_CP_KWK_To_MMBTUPerHourPerF",
                                                       HenTypes.ConversionUnitsTypes.CP,
                                                       4.0,
                                                       0.007582520,
                                                       CreateEnglishTemperatureUnits(ProjectMagnitude.MEGA, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_CP_KWK_To_MMBTUPerHourPerR",
                                                       HenTypes.ConversionUnitsTypes.CP,
                                                       4.0,
                                                       0.007582520,
                                                       CreateEnglishTemperatureUnits(ProjectMagnitude.MEGA, ProjectEnglishTemp.DEG_R));

            yield return CreateConvertFromInternalCase("ConvertFromInternal_U_KWPerM2K_To_WPerM2C",
                                                       HenTypes.ConversionUnitsTypes.U,
                                                       4.0,
                                                       4000.0,
                                                       CreateMetricTemperatureUnits(ProjectMagnitude.BASE, ProjectMetricTemp.DEG_C));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_U_KWPerM2K_To_WPerM2K",
                                                       HenTypes.ConversionUnitsTypes.U,
                                                       4.0,
                                                       4000.0,
                                                       CreateMetricTemperatureUnits(ProjectMagnitude.BASE, ProjectMetricTemp.KELVIN));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_U_KWPerM2K_To_KWPerM2C",
                                                       HenTypes.ConversionUnitsTypes.U,
                                                       4.0,
                                                       4.0,
                                                       CreateMetricTemperatureUnits(ProjectMagnitude.KILO, ProjectMetricTemp.DEG_C));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_U_KWPerM2K_To_MWPerM2C",
                                                       HenTypes.ConversionUnitsTypes.U,
                                                       4.0,
                                                       0.004000,
                                                       CreateMetricTemperatureUnits(ProjectMagnitude.MEGA, ProjectMetricTemp.DEG_C));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_U_KWPerM2K_To_MWPerM2K",
                                                       HenTypes.ConversionUnitsTypes.U,
                                                       4.0,
                                                       0.004000,
                                                       CreateMetricTemperatureUnits(ProjectMagnitude.MEGA, ProjectMetricTemp.KELVIN));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_U_KWPerM2K_To_BTUPerHourFt2F",
                                                       HenTypes.ConversionUnitsTypes.U,
                                                       4.0,
                                                       704.440,
                                                       CreateEnglishTemperatureUnits(ProjectMagnitude.BASE, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_U_KWPerM2K_To_BTUPerHourFt2R",
                                                       HenTypes.ConversionUnitsTypes.U,
                                                       4.0,
                                                       704.440,
                                                       CreateEnglishTemperatureUnits(ProjectMagnitude.BASE, ProjectEnglishTemp.DEG_R));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_U_KWPerM2K_To_KBTUPerHourFt2F",
                                                       HenTypes.ConversionUnitsTypes.U,
                                                       4.0,
                                                       0.70444,
                                                       CreateEnglishTemperatureUnits(ProjectMagnitude.KILO, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_U_KWPerM2K_To_KBTUPerHourFt2R",
                                                       HenTypes.ConversionUnitsTypes.U,
                                                       4.0,
                                                       0.70444,
                                                       CreateEnglishTemperatureUnits(ProjectMagnitude.KILO, ProjectEnglishTemp.DEG_R));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_U_KWPerM2K_To_MMBTUPerHourFt2F",
                                                       HenTypes.ConversionUnitsTypes.U,
                                                       4.0,
                                                       0.00070444,
                                                       CreateEnglishTemperatureUnits(ProjectMagnitude.MEGA, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertFromInternalCase("ConvertFromInternal_U_KWPerM2K_To_MMBTUPerHourFt2R",
                                                       HenTypes.ConversionUnitsTypes.U,
                                                       4.0,
                                                       0.00070444,
                                                       CreateEnglishTemperatureUnits(ProjectMagnitude.MEGA, ProjectEnglishTemp.DEG_R));
        }
        #endregion      // GetConvertFromInternalCases()

        #region GetConvertToInternalCases()
        /// <summary>
        /// Gets the ConvertToInternal test cases derived from TestUnitConversions.
        /// </summary>
        /// <returns>A sequence of NUnit test cases for ConvertToInternal.</returns>
        private static IEnumerable<TestCaseData> GetConvertToInternalCases()
        {
            yield return CreateConvertToInternalCase("ConvertToInternal_Area_FT2_To_M2",
                                                     HenTypes.ConversionUnitsTypes.A,
                                                     4305.564167,
                                                     400.0,
                                                     CreateEnglishAreaUnits());

            yield return CreateConvertToInternalCase("ConvertToInternal_Temperature_C_To_K",
                                                     HenTypes.ConversionUnitsTypes.TEMP,
                                                     126.85,
                                                     400.0,
                                                     CreateMetricTemperatureUnits(ProjectMagnitude.KILO, ProjectMetricTemp.DEG_C));
            yield return CreateConvertToInternalCase("ConvertToInternal_Temperature_F_To_K",
                                                     HenTypes.ConversionUnitsTypes.TEMP,
                                                     260.33,
                                                     400.0,
                                                     CreateEnglishTemperatureUnits(ProjectMagnitude.MEGA, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertToInternalCase("ConvertToInternal_Temperature_R_To_K",
                                                     HenTypes.ConversionUnitsTypes.TEMP,
                                                     720.0,
                                                     400.0,
                                                     CreateEnglishTemperatureUnits(ProjectMagnitude.MEGA, ProjectEnglishTemp.DEG_R));

            yield return CreateConvertToInternalCase("ConvertToInternal_Pressure_PSIA_To_KPa",
                                                     HenTypes.ConversionUnitsTypes.PRESS,
                                                     58.015072,
                                                     400.0,
                                                     CreateEnglishPressureUnits(ProjectEnglishPress.PSIA));
            yield return CreateConvertToInternalCase("ConvertToInternal_Pressure_PSIG_To_KPa",
                                                     HenTypes.ConversionUnitsTypes.PRESS,
                                                     43.319172,
                                                     400.0,
                                                     CreateEnglishPressureUnits(ProjectEnglishPress.PSIG));
            yield return CreateConvertToInternalCase("ConvertToInternal_Pressure_PSFA_To_KPa",
                                                     HenTypes.ConversionUnitsTypes.PRESS,
                                                     8354.1664,
                                                     400.0,
                                                     CreateEnglishPressureUnits(ProjectEnglishPress.PSF));
            yield return CreateConvertToInternalCase("ConvertToInternal_Pressure_ATM_To_KPa",
                                                     HenTypes.ConversionUnitsTypes.PRESS,
                                                     3.947692,
                                                     400.0,
                                                     CreateEnglishPressureUnits(ProjectEnglishPress.ATM));
            yield return CreateConvertToInternalCase("ConvertToInternal_Pressure_InHg_To_KPa",
                                                     HenTypes.ConversionUnitsTypes.PRESS,
                                                     118.11988,
                                                     400.0,
                                                     CreateEnglishPressureUnits(ProjectEnglishPress.IN_HG));
            yield return CreateConvertToInternalCase("ConvertToInternal_Pressure_InH2O_To_KPa",
                                                     HenTypes.ConversionUnitsTypes.PRESS,
                                                     1605.896,
                                                     400.0,
                                                     CreateEnglishPressureUnits(ProjectEnglishPress.IN_H2O));
            yield return CreateConvertToInternalCase("ConvertToInternal_Pressure_Bar_To_KPa",
                                                     HenTypes.ConversionUnitsTypes.PRESS,
                                                     4.0,
                                                     400.0,
                                                     CreateMetricPressureUnits(ProjectMagnitude.BASE, ProjectMetricPress.BAR));
            yield return CreateConvertToInternalCase("ConvertToInternal_Pressure_KBar_To_KPa",
                                                     HenTypes.ConversionUnitsTypes.PRESS,
                                                     0.004,
                                                     400.0,
                                                     CreateMetricPressureUnits(ProjectMagnitude.KILO, ProjectMetricPress.BAR));
            yield return CreateConvertToInternalCase("ConvertToInternal_Pressure_MBar_To_KPa",
                                                     HenTypes.ConversionUnitsTypes.PRESS,
                                                     0.000004,
                                                     400.0,
                                                     CreateMetricPressureUnits(ProjectMagnitude.MEGA, ProjectMetricPress.BAR));
            yield return CreateConvertToInternalCase("ConvertToInternal_Pressure_Pa_To_KPa",
                                                     HenTypes.ConversionUnitsTypes.PRESS,
                                                     400000.0,
                                                     400.0,
                                                     CreateMetricPressureUnits(ProjectMagnitude.BASE, ProjectMetricPress.Pa));
            yield return CreateConvertToInternalCase("ConvertToInternal_Pressure_MPa_To_KPa",
                                                     HenTypes.ConversionUnitsTypes.PRESS,
                                                     0.400,
                                                     400.0,
                                                     CreateMetricPressureUnits(ProjectMagnitude.MEGA, ProjectMetricPress.Pa));

            yield return CreateConvertToInternalCase("ConvertToInternal_HeatFlow_W_To_KW",
                                                     HenTypes.ConversionUnitsTypes.HEAT_FLOW,
                                                     4000.0,
                                                     4.0,
                                                     CreateMetricTemperatureUnits(ProjectMagnitude.BASE, ProjectMetricTemp.KELVIN));
            yield return CreateConvertToInternalCase("ConvertToInternal_HeatFlow_MW_To_KW",
                                                     HenTypes.ConversionUnitsTypes.HEAT_FLOW,
                                                     0.0040,
                                                     4.0,
                                                     CreateMetricTemperatureUnits(ProjectMagnitude.MEGA, ProjectMetricTemp.KELVIN));
            yield return CreateConvertToInternalCase("ConvertToInternal_HeatFlow_BTUPerHour_To_KW",
                                                     HenTypes.ConversionUnitsTypes.HEAT_FLOW,
                                                     13648.568,
                                                     4.0,
                                                     CreateEnglishTemperatureUnits(ProjectMagnitude.BASE, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertToInternalCase("ConvertToInternal_HeatFlow_KBTUPerHour_To_KW",
                                                     HenTypes.ConversionUnitsTypes.HEAT_FLOW,
                                                     13.6486,
                                                     4.0,
                                                     CreateEnglishTemperatureUnits(ProjectMagnitude.KILO, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertToInternalCase("ConvertToInternal_HeatFlow_MMBTUPerHour_To_KW",
                                                     HenTypes.ConversionUnitsTypes.HEAT_FLOW,
                                                     0.0136486,
                                                     4.0,
                                                     CreateEnglishTemperatureUnits(ProjectMagnitude.MEGA, ProjectEnglishTemp.DEG_F));

            yield return CreateConvertToInternalCase("ConvertToInternal_CP_WPerC_To_KWK",
                                                     HenTypes.ConversionUnitsTypes.CP,
                                                     4000.0,
                                                     4.0,
                                                     CreateMetricTemperatureUnits(ProjectMagnitude.BASE, ProjectMetricTemp.DEG_C));
            yield return CreateConvertToInternalCase("ConvertToInternal_CP_WPerK_To_KWK",
                                                     HenTypes.ConversionUnitsTypes.CP,
                                                     4000.0,
                                                     4.0,
                                                     CreateMetricTemperatureUnits(ProjectMagnitude.BASE, ProjectMetricTemp.KELVIN));
            yield return CreateConvertToInternalCase("ConvertToInternal_CP_KWPerC_To_KWK",
                                                     HenTypes.ConversionUnitsTypes.CP,
                                                     4.0,
                                                     4.0,
                                                     CreateMetricTemperatureUnits(ProjectMagnitude.KILO, ProjectMetricTemp.DEG_C));
            yield return CreateConvertToInternalCase("ConvertToInternal_CP_MWPerC_To_KWK",
                                                     HenTypes.ConversionUnitsTypes.CP,
                                                     0.004000,
                                                     4.0,
                                                     CreateMetricTemperatureUnits(ProjectMagnitude.MEGA, ProjectMetricTemp.DEG_C));
            yield return CreateConvertToInternalCase("ConvertToInternal_CP_MWPerK_To_KWK",
                                                     HenTypes.ConversionUnitsTypes.CP,
                                                     0.004000,
                                                     4.0,
                                                     CreateMetricTemperatureUnits(ProjectMagnitude.MEGA, ProjectMetricTemp.KELVIN));
            yield return CreateConvertToInternalCase("ConvertToInternal_CP_BTUPerHourPerF_To_KWK",
                                                     HenTypes.ConversionUnitsTypes.CP,
                                                     7582.520,
                                                     4.0,
                                                     CreateEnglishTemperatureUnits(ProjectMagnitude.BASE, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertToInternalCase("ConvertToInternal_CP_BTUPerHourPerR_To_KWK",
                                                     HenTypes.ConversionUnitsTypes.CP,
                                                     7582.520,
                                                     4.0,
                                                     CreateEnglishTemperatureUnits(ProjectMagnitude.BASE, ProjectEnglishTemp.DEG_R));
            yield return CreateConvertToInternalCase("ConvertToInternal_CP_KBTUPerHourPerF_To_KWK",
                                                     HenTypes.ConversionUnitsTypes.CP,
                                                     7.582520,
                                                     4.0,
                                                     CreateEnglishTemperatureUnits(ProjectMagnitude.KILO, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertToInternalCase("ConvertToInternal_CP_KBTUPerHourPerR_To_KWK",
                                                     HenTypes.ConversionUnitsTypes.CP,
                                                     7.582520,
                                                     4.0,
                                                     CreateEnglishTemperatureUnits(ProjectMagnitude.KILO, ProjectEnglishTemp.DEG_R));
            yield return CreateConvertToInternalCase("ConvertToInternal_CP_MMBTUPerHourPerF_To_KWK",
                                                     HenTypes.ConversionUnitsTypes.CP,
                                                     0.007582520,
                                                     4.0,
                                                     CreateEnglishTemperatureUnits(ProjectMagnitude.MEGA, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertToInternalCase("ConvertToInternal_CP_MMBTUPerHourPerR_To_KWK",
                                                     HenTypes.ConversionUnitsTypes.CP,
                                                     0.007582520,
                                                     4.0,
                                                     CreateEnglishTemperatureUnits(ProjectMagnitude.MEGA, ProjectEnglishTemp.DEG_R));

            yield return CreateConvertToInternalCase("ConvertToInternal_U_WPerM2C_To_KWPerM2K",
                                                     HenTypes.ConversionUnitsTypes.U,
                                                     4000.0,
                                                     4.0,
                                                     CreateMetricTemperatureUnits(ProjectMagnitude.BASE, ProjectMetricTemp.DEG_C));
            yield return CreateConvertToInternalCase("ConvertToInternal_U_WPerM2K_To_KWPerM2K",
                                                     HenTypes.ConversionUnitsTypes.U,
                                                     4000.0,
                                                     4.0,
                                                     CreateMetricTemperatureUnits(ProjectMagnitude.BASE, ProjectMetricTemp.KELVIN));
            yield return CreateConvertToInternalCase("ConvertToInternal_U_KWPerM2C_To_KWPerM2K",
                                                     HenTypes.ConversionUnitsTypes.U,
                                                     4.0,
                                                     4.0,
                                                     CreateMetricTemperatureUnits(ProjectMagnitude.KILO, ProjectMetricTemp.DEG_C));
            yield return CreateConvertToInternalCase("ConvertToInternal_U_MWPerM2C_To_KWPerM2K",
                                                     HenTypes.ConversionUnitsTypes.U,
                                                     0.004000,
                                                     4.0,
                                                     CreateMetricTemperatureUnits(ProjectMagnitude.MEGA, ProjectMetricTemp.DEG_C));
            yield return CreateConvertToInternalCase("ConvertToInternal_U_MWPerM2K_To_KWPerM2K",
                                                     HenTypes.ConversionUnitsTypes.U,
                                                     0.004000,
                                                     4.0,
                                                     CreateMetricTemperatureUnits(ProjectMagnitude.MEGA, ProjectMetricTemp.KELVIN));
            yield return CreateConvertToInternalCase("ConvertToInternal_U_BTUPerHourFt2F_To_KWPerM2K",
                                                     HenTypes.ConversionUnitsTypes.U,
                                                     704.440,
                                                     4.0,
                                                     CreateEnglishTemperatureUnits(ProjectMagnitude.BASE, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertToInternalCase("ConvertToInternal_U_BTUPerHourFt2R_To_KWPerM2K",
                                                     HenTypes.ConversionUnitsTypes.U,
                                                     704.440,
                                                     4.0,
                                                     CreateEnglishTemperatureUnits(ProjectMagnitude.BASE, ProjectEnglishTemp.DEG_R));
            yield return CreateConvertToInternalCase("ConvertToInternal_U_KBTUPerHourFt2F_To_KWPerM2K",
                                                     HenTypes.ConversionUnitsTypes.U,
                                                     0.70444,
                                                     4.0,
                                                     CreateEnglishTemperatureUnits(ProjectMagnitude.KILO, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertToInternalCase("ConvertToInternal_U_KBTUPerHourFt2R_To_KWPerM2K",
                                                     HenTypes.ConversionUnitsTypes.U,
                                                     0.70444,
                                                     4.0,
                                                     CreateEnglishTemperatureUnits(ProjectMagnitude.KILO, ProjectEnglishTemp.DEG_R));
            yield return CreateConvertToInternalCase("ConvertToInternal_U_MMBTUPerHourFt2F_To_KWPerM2K",
                                                     HenTypes.ConversionUnitsTypes.U,
                                                     0.00070444,
                                                     4.0,
                                                     CreateEnglishTemperatureUnits(ProjectMagnitude.MEGA, ProjectEnglishTemp.DEG_F));
            yield return CreateConvertToInternalCase("ConvertToInternal_U_MMBTUPerHourFt2R_To_KWPerM2K",
                                                     HenTypes.ConversionUnitsTypes.U,
                                                     0.00070444,
                                                     4.0,
                                                     CreateEnglishTemperatureUnits(ProjectMagnitude.MEGA, ProjectEnglishTemp.DEG_R));
        }
        #endregion      // GetConvertToInternalCases()

        #endregion      // PRIVATE METHODS

        #region CheckForEquality_ReturnsTrue_WhenValuesAreWithinTolerance()
        /// <summary>
        /// Verifies that CheckForEquality returns true when the values are within the specified tolerance.
        /// </summary>
        [Test]
        public void CheckForEquality_ReturnsTrue_WhenValuesAreWithinTolerance()
        {
            bool result = ViewModelBase.CheckForEquality(100.0, 100.0005);

            Assert.That(result, Is.True);
        }
        #endregion      // CheckForEquality_ReturnsTrue_WhenValuesAreWithinTolerance()

        #region CheckForEquality_ReturnsFalse_WhenValuesAreOutsideTolerance()
        /// <summary>
        /// Verifies that CheckForEquality returns false when the values are outside the specified tolerance.
        /// </summary>
        [Test]
        public void CheckForEquality_ReturnsFalse_WhenValuesAreOutsideTolerance()
        {
            bool result = ViewModelBase.CheckForEquality(100.0, 100.01);

            Assert.That(result, Is.False);
        }
        #endregion      // CheckForEquality_ReturnsFalse_WhenValuesAreOutsideTolerance()

        #region ConvertFromInternal_ReturnsExpectedExternalValue()
        /// <summary>
        /// Verifies that ConvertFromInternal returns the expected external unit value for each conversion test case.
        /// </summary>
        /// <param name="testCase">The conversion test case to execute.</param>
        [TestCaseSource(nameof(GetConvertFromInternalCases))]
        public void ConvertFromInternal_ReturnsExpectedExternalValue(ConversionTestCase testCase)
        {
            TestViewModel viewModel = new TestViewModel();
            HenProjectUnits internalUnits = new HenProjectUnits();

            double result = viewModel.ConvertFromInternal(testCase.ConversionType,
                                                          testCase.InputValue,
                                                          testCase.ExternalUnits,
                                                          internalUnits);

            AssertEx.NearlyEqual(testCase.ExpectedValue, result, 0.001, testCase.Name);
        }
        #endregion      // ConvertFromInternal_ReturnsExpectedExternalValue()

        #region ConvertToInternal_ReturnsExpectedInternalValue()
        /// <summary>
        /// Verifies that ConvertToInternal returns the expected internal unit value for each conversion test case.
        /// </summary>
        /// <param name="testCase">The conversion test case to execute.</param>
        [TestCaseSource(nameof(GetConvertToInternalCases))]
        public void ConvertToInternal_ReturnsExpectedInternalValue(ConversionTestCase testCase)
        {
            TestViewModel viewModel = new TestViewModel();
            HenProjectUnits internalUnits = new HenProjectUnits();

            double result = viewModel.ConvertToInternal(testCase.ConversionType,
                                                        testCase.InputValue,
                                                        testCase.ExternalUnits,
                                                        internalUnits);

            AssertEx.NearlyEqual(testCase.ExpectedValue, result, 0.001, testCase.Name);
        }
        #endregion      // ConvertToInternal_ReturnsExpectedInternalValue()

        #region ConvertToExternalFieldMethods_ReturnExpectedExternalValue()
        /// <summary>
        /// Verifies that the field-specific internal-to-external wrapper methods return the expected external unit value.
        /// </summary>
        /// <param name="testCase">The conversion test case to execute.</param>
        [TestCaseSource(nameof(GetConvertFromInternalCases))]
        public void ConvertToExternalFieldMethods_ReturnExpectedExternalValue(ConversionTestCase testCase)
        {
            TestViewModel viewModel = CreateConfiguredViewModel(testCase.ExternalUnits);

            double result = ConvertToExternalFieldValue(viewModel,
                                                        testCase.ConversionType,
                                                        testCase.InputValue);

            AssertEx.NearlyEqual(testCase.ExpectedValue, result, 0.001, testCase.Name);
        }
        #endregion      // ConvertToExternalFieldMethods_ReturnExpectedExternalValue()

        #region ConvertFromExternalFieldMethods_ReturnExpectedInternalValue()
        /// <summary>
        /// Verifies that the field-specific external-to-internal wrapper methods return the expected internal unit value.
        /// </summary>
        /// <param name="testCase">The conversion test case to execute.</param>
        [TestCaseSource(nameof(GetConvertToInternalCases))]
        public void ConvertFromExternalFieldMethods_ReturnExpectedInternalValue(ConversionTestCase testCase)
        {
            TestViewModel viewModel = CreateConfiguredViewModel(testCase.ExternalUnits);

            double result = ConvertFromExternalFieldValue(viewModel,
                                                          testCase.ConversionType,
                                                          testCase.InputValue);

            AssertEx.NearlyEqual(testCase.ExpectedValue, result, 0.001, testCase.Name);
        }
        #endregion      // ConvertFromExternalFieldMethods_ReturnExpectedInternalValue()
    }
    #endregion      // public class ViewModelBaseUnitConversionTests
}
#endregion      // namespace HenStudio.Tests.UnitConversions

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
