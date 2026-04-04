#region HEADER
//#####################################################################################################################
//########################################  D t o T e s t H e l p e r . c s  ###########################################
//#####################################################################################################################
//  FILENAME:  DtoTestHelper.cs
//  NAMESPACE: HenStudio.Tests.Helpers
//  CLASS(S):  DtoTestHelper
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains helper methods for DTO unit tests.
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
using System;
using System.Collections.Generic;
using System.Reflection;

using NUnit.Framework;
#endregion      // REFERENCES

#region namespace HenStudio.Tests.Helpers
namespace HenStudio.Tests.Helpers
{
    #region public static class DtoTestHelper
    /// <summary>
    /// Helper methods for DTO unit tests.
    /// </summary>
    public static class DtoTestHelper
    {
        #region AssertDefaultPropertyValues<T>()
        /// <summary>
        /// Verifies that the default constructor initializes all auto-properties to their default values.
        /// </summary>
        /// <typeparam name="T">The DTO type under test.</typeparam>
        public static void AssertDefaultPropertyValues<T>() where T : new()
        {
            T dto = new T();

            foreach (PropertyInfo property in typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                object expectedValue = property.PropertyType.IsValueType
                    ? Activator.CreateInstance(property.PropertyType)
                    : null;

                Assert.That(property.GetValue(dto), Is.EqualTo(expectedValue), property.Name);
            }
        }
        #endregion      // AssertDefaultPropertyValues<T>()

        #region AssertPropertyRoundTrip<T>()
        /// <summary>
        /// Verifies that all writable public properties retain assigned values.
        /// </summary>
        /// <typeparam name="T">The DTO type under test.</typeparam>
        public static void AssertPropertyRoundTrip<T>() where T : new()
        {
            T dto = new T();
            Dictionary<string, object> expectedValues = new Dictionary<string, object>();
            int index = 1;

            foreach (PropertyInfo property in typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                if (!property.CanRead || !property.CanWrite)
                {
                    continue;
                }

                object sampleValue = CreateSampleValue(property.PropertyType, property.Name, index++);
                property.SetValue(dto, sampleValue);
                expectedValues[property.Name] = sampleValue;
            }

            foreach (PropertyInfo property in typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                if (!property.CanRead || !property.CanWrite)
                {
                    continue;
                }

                Assert.That(property.GetValue(dto), Is.EqualTo(expectedValues[property.Name]), property.Name);
            }
        }
        #endregion      // AssertPropertyRoundTrip<T>()

        #region CreateSampleValue()
        /// <summary>
        /// Creates a sample value for the supplied property type.
        /// </summary>
        /// <param name="propertyType">The property type.</param>
        /// <param name="propertyName">The property name.</param>
        /// <param name="index">The property sequence index.</param>
        /// <returns>A sample value compatible with the supplied property type.</returns>
        private static object CreateSampleValue(Type propertyType, string propertyName, int index)
        {
            if (propertyType == typeof(string))
            {
                return propertyName + " Value " + index;
            }

            if (propertyType == typeof(Guid))
            {
                return Guid.Parse(string.Format("00000000-0000-0000-0000-{0:000000000000}", index));
            }

            if (propertyType == typeof(int))
            {
                return 100 + index;
            }

            if (propertyType == typeof(double))
            {
                return 1000.0 + index + 0.25;
            }

            if (propertyType == typeof(DateTime))
            {
                return new DateTime(2026, 1, 1, 12, 0, 0).AddDays(index).AddMinutes(index);
            }

            if (propertyType == typeof(bool))
            {
                return (index % 2) == 0;
            }

            if (propertyType == typeof(float))
            {
                return 100.0f + index + 0.5f;
            }

            if (propertyType == typeof(long))
            {
                return 1000L + index;
            }

            if (propertyType == typeof(decimal))
            {
                return 1000.0m + index + 0.75m;
            }

            throw new NotSupportedException("Unsupported DTO property type: " + propertyType.FullName);
        }
        #endregion      // CreateSampleValue()
    }
    #endregion      // public static class DtoTestHelper
}
#endregion      // namespace HenStudio.Tests.Helpers

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
