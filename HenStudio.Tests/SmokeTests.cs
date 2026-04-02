#region HEADER
//#####################################################################################################################
//############################################  S m o k e T e s t s . c s  ############################################
//#####################################################################################################################
//  FILENAME:  SmokeTests.cs
//  NAMESPACE: HenStudio.Tests
//  CLASS(S):  SmokeTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains smoke tests for HEN Studio.
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
using NUnit.Framework;
#endregion      // REFERENCES

#region namespace HenStudio.Tests
namespace HenStudio.Tests
{
    #region public class SmokeTests
    [TestFixture]
    public class SmokeTests
    {
        #region ItWorks()
        /// <summary>
        /// Verifies that the smoke test fixture is executing correctly.
        /// </summary>
        [Test]
        public void ItWorks()
        {
            Assert.That(1 + 1, Is.EqualTo(2));
        }
        #endregion      // ItWorks()
    }
    #endregion      // public class SmokeTests
}
#endregion      // namespace HenStudio.Tests

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
