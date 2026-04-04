#region HEADER
//#####################################################################################################################
//##########################################  H e n D t o T e s t s . c s  ############################################
//#####################################################################################################################
//  FILENAME:  HenDtoTests.cs
//  NAMESPACE: HenStudio.Tests.Hen
//  CLASS(S):  HenDtoTests, ExchangerDtoTests, GridDiagramDtoTests, GridDiagramPointIDDtoTests,
//             HeatReleaseCurveDtoTests, HeatReleaseCurvePointIDDtoTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for Hen DTO classes.
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

#region namespace HenStudio.Tests.Hen
namespace HenStudio.Tests.Hen
{
    #region public class HenDtoTests
    /// <summary>
    /// Unit tests for the <see cref="HenDto"/> class.
    /// </summary>
    [TestFixture]
    public class HenDtoTests
    {
        #region HenDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void HenDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<HenDto>();
        }
        #endregion      // HenDto_CTOR_SetsDefaultPropertyValues()

        #region HenDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void HenDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<HenDto>();
        }
        #endregion      // HenDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class HenDtoTests

    #region public class ExchangerDtoTests
    /// <summary>
    /// Unit tests for the <see cref="ExchangerDto"/> class.
    /// </summary>
    [TestFixture]
    public class ExchangerDtoTests
    {
        #region ExchangerDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void ExchangerDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<ExchangerDto>();
        }
        #endregion      // ExchangerDto_CTOR_SetsDefaultPropertyValues()

        #region ExchangerDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void ExchangerDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<ExchangerDto>();
        }
        #endregion      // ExchangerDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class ExchangerDtoTests

    #region public class GridDiagramDtoTests
    /// <summary>
    /// Unit tests for the <see cref="GridDiagramDto"/> class.
    /// </summary>
    [TestFixture]
    public class GridDiagramDtoTests
    {
        #region GridDiagramDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void GridDiagramDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<GridDiagramDto>();
        }
        #endregion      // GridDiagramDto_CTOR_SetsDefaultPropertyValues()

        #region GridDiagramDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void GridDiagramDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<GridDiagramDto>();
        }
        #endregion      // GridDiagramDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class GridDiagramDtoTests

    #region public class GridDiagramPointIDDtoTests
    /// <summary>
    /// Unit tests for the <see cref="GridDiagramPointIDDto"/> class.
    /// </summary>
    [TestFixture]
    public class GridDiagramPointIDDtoTests
    {
        #region GridDiagramPointIDDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void GridDiagramPointIDDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<GridDiagramPointIDDto>();
        }
        #endregion      // GridDiagramPointIDDto_CTOR_SetsDefaultPropertyValues()

        #region GridDiagramPointIDDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void GridDiagramPointIDDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<GridDiagramPointIDDto>();
        }
        #endregion      // GridDiagramPointIDDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class GridDiagramPointIDDtoTests

    #region public class HeatReleaseCurveDtoTests
    /// <summary>
    /// Unit tests for the <see cref="HeatReleaseCurveDto"/> class.
    /// </summary>
    [TestFixture]
    public class HeatReleaseCurveDtoTests
    {
        #region HeatReleaseCurveDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void HeatReleaseCurveDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<HeatReleaseCurveDto>();
        }
        #endregion      // HeatReleaseCurveDto_CTOR_SetsDefaultPropertyValues()

        #region HeatReleaseCurveDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void HeatReleaseCurveDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<HeatReleaseCurveDto>();
        }
        #endregion      // HeatReleaseCurveDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class HeatReleaseCurveDtoTests

    #region public class HeatReleaseCurvePointIDDtoTests
    /// <summary>
    /// Unit tests for the <see cref="HeatReleaseCurvePointIDDto"/> class.
    /// </summary>
    [TestFixture]
    public class HeatReleaseCurvePointIDDtoTests
    {
        #region HeatReleaseCurvePointIDDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void HeatReleaseCurvePointIDDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<HeatReleaseCurvePointIDDto>();
        }
        #endregion      // HeatReleaseCurvePointIDDto_CTOR_SetsDefaultPropertyValues()

        #region HeatReleaseCurvePointIDDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void HeatReleaseCurvePointIDDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<HeatReleaseCurvePointIDDto>();
        }
        #endregion      // HeatReleaseCurvePointIDDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class HeatReleaseCurvePointIDDtoTests
}
#endregion      // namespace HenStudio.Tests.Hen

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
