#region HEADER
//#####################################################################################################################
//############################################  A s s e r t E x . c s  ################################################
//#####################################################################################################################
//  FILENAME:  AssertEx.cs
//  NAMESPACE: HenStudio.Tests.Helpers
//  CLASS(S):  AssertEx
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains assertion helper methods for HEN Studio tests.
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

using NUnit.Framework;
#endregion      // REFERENCES

#region namespace HenStudio.Tests.Helpers
namespace HenStudio.Tests.Helpers
{
    #region public static class AssertEx
    /// <summary>
    /// Assertion helper class for HEN Studio tests.
    /// </summary>
    public static class AssertEx
    {
        #region NearlyEqual()
        /// <summary>
        /// Asserts that two doubles are equal within an absolute tolerance.
        /// </summary>
        /// <param name="expected">The expected value.</param>
        /// <param name="actual">The actual value.</param>
        /// <param name="tolerance">The absolute tolerance allowed between the values.</param>
        /// <param name="message">The optional assertion message.</param>
        public static void NearlyEqual(
            double expected,
            double actual,
            double tolerance = 1e-6,
            string message = null)
        {
            Assert.That(actual, Is.EqualTo(expected).Within(tolerance), message);
        }
        #endregion      // NearlyEqual()

        #region NearlyEqualRelative()
        /// <summary>
        /// Asserts that two doubles are equal within a relative tolerance.
        /// </summary>
        /// <param name="expected">The expected value.</param>
        /// <param name="actual">The actual value.</param>
        /// <param name="relativeTolerance">The relative tolerance allowed between the values.</param>
        /// <param name="message">The optional assertion message.</param>
        public static void NearlyEqualRelative(
            double expected,
            double actual,
            double relativeTolerance = 1e-6,
            string message = null)
        {
            var denom = Math.Max(1.0, Math.Abs(expected));
            var diff = Math.Abs(expected - actual) / denom;

            Assert.That(diff, Is.LessThanOrEqualTo(relativeTolerance),
                message ?? $"Expected {expected} but got {actual} (relative diff {diff})");
        }
        #endregion      // NearlyEqualRelative()

        #region NearlyEqualSequence()
        /// <summary>
        /// Asserts that two sequences of doubles match element-by-element within a tolerance.
        /// </summary>
        /// <param name="expected">The expected sequence.</param>
        /// <param name="actual">The actual sequence.</param>
        /// <param name="tolerance">The absolute tolerance allowed between sequence elements.</param>
        /// <param name="message">The optional assertion message.</param>
        public static void NearlyEqualSequence(
            IList<double> expected,
            IList<double> actual,
            double tolerance = 1e-6,
            string message = null)
        {
            Assert.That(actual.Count, Is.EqualTo(expected.Count),
                message ?? "Sequence lengths differ.");

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.That(actual[i], Is.EqualTo(expected[i]).Within(tolerance),
                    $"{message} (index {i})");
            }
        }
        #endregion      // NearlyEqualSequence()

        #region InRange()
        /// <summary>
        /// Asserts that a value is within an inclusive range.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <param name="min">The inclusive minimum value.</param>
        /// <param name="max">The inclusive maximum value.</param>
        /// <param name="message">The optional assertion message.</param>
        public static void InRange(
            double value,
            double min,
            double max,
            string message = null)
        {
            Assert.That(value, Is.InRange(min, max), message);
        }
        #endregion      // InRange()
    }
    #endregion      // public static class AssertEx
}
#endregion      // namespace HenStudio.Tests.Helpers

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
