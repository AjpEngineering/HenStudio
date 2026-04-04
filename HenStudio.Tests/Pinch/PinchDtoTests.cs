#region HEADER
//#####################################################################################################################
//#########################################  P i n c h D t o T e s t s . c s  #########################################
//#####################################################################################################################
//  FILENAME:  PinchDtoTests.cs
//  NAMESPACE: HenStudio.Tests.Pinch
//  CLASS(S):  PinchDtoTests, TargetsDtoTests, CompositeCurveDtoTests, CompositeCurvePointIDDtoTests,
//             GrandCompositeCurveDtoTests, GrandCompositeCurvePointIDDtoTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for Pinch DTO classes.
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
using HenRepositories.Dto;
using HenStudio.Tests.Helpers;

using NUnit.Framework;
#endregion      // REFERENCES

#region namespace HenStudio.Tests.Pinch
namespace HenStudio.Tests.Pinch
{
    #region public class PinchDtoTests
    /// <summary>
    /// Unit tests for the <see cref="PinchDto"/> class.
    /// </summary>
    [TestFixture]
    public class PinchDtoTests
    {
        #region PinchDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void PinchDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<PinchDto>();
        }
        #endregion      // PinchDto_CTOR_SetsDefaultPropertyValues()

        #region PinchDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void PinchDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<PinchDto>();
        }
        #endregion      // PinchDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class PinchDtoTests

    #region public class TargetsDtoTests
    /// <summary>
    /// Unit tests for the <see cref="TargetsDto"/> class.
    /// </summary>
    [TestFixture]
    public class TargetsDtoTests
    {
        #region TargetsDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void TargetsDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<TargetsDto>();
        }
        #endregion      // TargetsDto_CTOR_SetsDefaultPropertyValues()

        #region TargetsDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void TargetsDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<TargetsDto>();
        }
        #endregion      // TargetsDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class TargetsDtoTests

    #region public class CompositeCurveDtoTests
    /// <summary>
    /// Unit tests for the <see cref="CompositeCurveDto"/> class.
    /// </summary>
    [TestFixture]
    public class CompositeCurveDtoTests
    {
        #region CompositeCurveDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void CompositeCurveDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<CompositeCurveDto>();
        }
        #endregion      // CompositeCurveDto_CTOR_SetsDefaultPropertyValues()

        #region CompositeCurveDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void CompositeCurveDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<CompositeCurveDto>();
        }
        #endregion      // CompositeCurveDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class CompositeCurveDtoTests

    #region public class CompositeCurvePointIDDtoTests
    /// <summary>
    /// Unit tests for the <see cref="CompositeCurvePointIDDto"/> class.
    /// </summary>
    [TestFixture]
    public class CompositeCurvePointIDDtoTests
    {
        #region CompositeCurvePointIDDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void CompositeCurvePointIDDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<CompositeCurvePointIDDto>();
        }
        #endregion      // CompositeCurvePointIDDto_CTOR_SetsDefaultPropertyValues()

        #region CompositeCurvePointIDDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void CompositeCurvePointIDDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<CompositeCurvePointIDDto>();
        }
        #endregion      // CompositeCurvePointIDDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class CompositeCurvePointIDDtoTests

    #region public class GrandCompositeCurveDtoTests
    /// <summary>
    /// Unit tests for the <see cref="GrandCompositeCurveDto"/> class.
    /// </summary>
    [TestFixture]
    public class GrandCompositeCurveDtoTests
    {
        #region GrandCompositeCurveDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void GrandCompositeCurveDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<GrandCompositeCurveDto>();
        }
        #endregion      // GrandCompositeCurveDto_CTOR_SetsDefaultPropertyValues()

        #region GrandCompositeCurveDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void GrandCompositeCurveDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<GrandCompositeCurveDto>();
        }
        #endregion      // GrandCompositeCurveDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class GrandCompositeCurveDtoTests

    #region public class GrandCompositeCurvePointIDDtoTests
    /// <summary>
    /// Unit tests for the <see cref="GrandCompositeCurvePointIDDto"/> class.
    /// </summary>
    [TestFixture]
    public class GrandCompositeCurvePointIDDtoTests
    {
        #region GrandCompositeCurvePointIDDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void GrandCompositeCurvePointIDDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<GrandCompositeCurvePointIDDto>();
        }
        #endregion      // GrandCompositeCurvePointIDDto_CTOR_SetsDefaultPropertyValues()

        #region GrandCompositeCurvePointIDDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void GrandCompositeCurvePointIDDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<GrandCompositeCurvePointIDDto>();
        }
        #endregion      // GrandCompositeCurvePointIDDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class GrandCompositeCurvePointIDDtoTests
}
#endregion      // namespace HenStudio.Tests.Pinch

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
