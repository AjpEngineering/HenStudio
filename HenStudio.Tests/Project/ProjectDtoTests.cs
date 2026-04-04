#region HEADER
//#####################################################################################################################
//########################################  P r o j e c t D t o T e s t s . c s  ######################################
//#####################################################################################################################
//  FILENAME:  ProjectDtoTests.cs
//  NAMESPACE: HenStudio.Tests.Project
//  CLASS(S):  ProjectDtoTests, HenOptimizerDtoTests, HenOptimizerGeneticDtoTests, HenOptimizerGreedyDtoTests,
//             HenOptimizerMILPDtoTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for Project DTO classes.
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

#region namespace HenStudio.Tests.Project
namespace HenStudio.Tests.Project
{
    #region public class ProjectDtoTests
    /// <summary>
    /// Unit tests for the <see cref="ProjectDto"/> class.
    /// </summary>
    [TestFixture]
    public class ProjectDtoTests
    {
        #region ProjectDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void ProjectDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<ProjectDto>();
        }
        #endregion      // ProjectDto_CTOR_SetsDefaultPropertyValues()

        #region ProjectDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void ProjectDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<ProjectDto>();
        }
        #endregion      // ProjectDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class ProjectDtoTests

    #region public class HenOptimizerDtoTests
    /// <summary>
    /// Unit tests for the <see cref="HenOptimizerDto"/> class.
    /// </summary>
    [TestFixture]
    public class HenOptimizerDtoTests
    {
        #region HenOptimizerDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void HenOptimizerDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<HenOptimizerDto>();
        }
        #endregion      // HenOptimizerDto_CTOR_SetsDefaultPropertyValues()

        #region HenOptimizerDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void HenOptimizerDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<HenOptimizerDto>();
        }
        #endregion      // HenOptimizerDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class HenOptimizerDtoTests

    #region public class HenOptimizerGeneticDtoTests
    /// <summary>
    /// Unit tests for the <see cref="HenOptimizerGeneticDto"/> class.
    /// </summary>
    [TestFixture]
    public class HenOptimizerGeneticDtoTests
    {
        #region HenOptimizerGeneticDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void HenOptimizerGeneticDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<HenOptimizerGeneticDto>();
        }
        #endregion      // HenOptimizerGeneticDto_CTOR_SetsDefaultPropertyValues()

        #region HenOptimizerGeneticDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void HenOptimizerGeneticDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<HenOptimizerGeneticDto>();
        }
        #endregion      // HenOptimizerGeneticDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class HenOptimizerGeneticDtoTests

    #region public class HenOptimizerGreedyDtoTests
    /// <summary>
    /// Unit tests for the <see cref="HenOptimizerGreedyDto"/> class.
    /// </summary>
    [TestFixture]
    public class HenOptimizerGreedyDtoTests
    {
        #region HenOptimizerGreedyDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void HenOptimizerGreedyDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<HenOptimizerGreedyDto>();
        }
        #endregion      // HenOptimizerGreedyDto_CTOR_SetsDefaultPropertyValues()

        #region HenOptimizerGreedyDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void HenOptimizerGreedyDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<HenOptimizerGreedyDto>();
        }
        #endregion      // HenOptimizerGreedyDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class HenOptimizerGreedyDtoTests

    #region public class HenOptimizerMILPDtoTests
    /// <summary>
    /// Unit tests for the <see cref="HenOptimizerMILPDto"/> class.
    /// </summary>
    [TestFixture]
    public class HenOptimizerMILPDtoTests
    {
        #region HenOptimizerMILPDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void HenOptimizerMILPDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<HenOptimizerMILPDto>();
        }
        #endregion      // HenOptimizerMILPDto_CTOR_SetsDefaultPropertyValues()

        #region HenOptimizerMILPDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void HenOptimizerMILPDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<HenOptimizerMILPDto>();
        }
        #endregion      // HenOptimizerMILPDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class HenOptimizerMILPDtoTests
}
#endregion      // namespace HenStudio.Tests.Project

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
