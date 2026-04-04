#region HEADER
//#####################################################################################################################
//########################################  P r o f i l eD t o T e s t s . c s  ######################################
//#####################################################################################################################
//  FILENAME:  ProfileDtoTests.cs
//  NAMESPACE: HenStudio.Tests.Profile
//  CLASS(S):  ProfileDtoTests, EconParamDtoTests, ProcessStreamDtoTests, THDiagramDtoTests, THDiagramPointDtoTests,
//             UtilityStreamDtoTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for Profile DTO classes.
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

#region namespace HenStudio.Tests.Profile
namespace HenStudio.Tests.Profile
{
    #region public class ProfileDtoTests
    /// <summary>
    /// Unit tests for the <see cref="ProfileDto"/> class.
    /// </summary>
    [TestFixture]
    public class ProfileDtoTests
    {
        #region ProfileDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void ProfileDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<ProfileDto>();
        }
        #endregion      // ProfileDto_CTOR_SetsDefaultPropertyValues()

        #region ProfileDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void ProfileDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<ProfileDto>();
        }
        #endregion      // ProfileDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class ProfileDtoTests

    #region public class EconParamDtoTests
    /// <summary>
    /// Unit tests for the <see cref="EconParamDto"/> class.
    /// </summary>
    [TestFixture]
    public class EconParamDtoTests
    {
        #region EconParamDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void EconParamDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<EconParamDto>();
        }
        #endregion      // EconParamDto_CTOR_SetsDefaultPropertyValues()

        #region EconParamDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void EconParamDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<EconParamDto>();
        }
        #endregion      // EconParamDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class EconParamDtoTests

    #region public class ProcessStreamDtoTests
    /// <summary>
    /// Unit tests for the <see cref="ProcessStreamDto"/> class.
    /// </summary>
    [TestFixture]
    public class ProcessStreamDtoTests
    {
        #region ProcessStreamDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void ProcessStreamDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<ProcessStreamDto>();
        }
        #endregion      // ProcessStreamDto_CTOR_SetsDefaultPropertyValues()

        #region ProcessStreamDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void ProcessStreamDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<ProcessStreamDto>();
        }
        #endregion      // ProcessStreamDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class ProcessStreamDtoTests

    #region public class THDiagramDtoTests
    /// <summary>
    /// Unit tests for the <see cref="THDiagramDto"/> class.
    /// </summary>
    [TestFixture]
    public class THDiagramDtoTests
    {
        #region THDiagramDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void THDiagramDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<THDiagramDto>();
        }
        #endregion      // THDiagramDto_CTOR_SetsDefaultPropertyValues()

        #region THDiagramDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void THDiagramDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<THDiagramDto>();
        }
        #endregion      // THDiagramDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class THDiagramDtoTests

    #region public class THDiagramPointDtoTests
    /// <summary>
    /// Unit tests for the <see cref="THDiagramPointDto"/> class.
    /// </summary>
    [TestFixture]
    public class THDiagramPointDtoTests
    {
        #region THDiagramPointDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void THDiagramPointDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<THDiagramPointDto>();
        }
        #endregion      // THDiagramPointDto_CTOR_SetsDefaultPropertyValues()

        #region THDiagramPointDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void THDiagramPointDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<THDiagramPointDto>();
        }
        #endregion      // THDiagramPointDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class THDiagramPointDtoTests

    #region public class UtilityStreamDtoTests
    /// <summary>
    /// Unit tests for the <see cref="UtilityStreamDto"/> class.
    /// </summary>
    [TestFixture]
    public class UtilityStreamDtoTests
    {
        #region UtilityStreamDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void UtilityStreamDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<UtilityStreamDto>();
        }
        #endregion      // UtilityStreamDto_CTOR_SetsDefaultPropertyValues()

        #region UtilityStreamDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void UtilityStreamDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<UtilityStreamDto>();
        }
        #endregion      // UtilityStreamDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class UtilityStreamDtoTests
}
#endregion      // namespace HenStudio.Tests.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
