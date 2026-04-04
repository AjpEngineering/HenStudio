#region HEADER
//#####################################################################################################################
//########################################  S y s t e m D t o T e s t s . c s  ########################################
//#####################################################################################################################
//  FILENAME:  SystemDtoTests.cs
//  NAMESPACE: HenStudio.Tests.System
//  CLASS(S):  DatabaseTableDtoTests, GlobalSettingsDtoTests, ConnectionDataDtoTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for System DTO classes.
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

#region namespace HenStudio.Tests.System
namespace HenStudio.Tests.System
{
    #region public class DatabaseTableDtoTests
    /// <summary>
    /// Unit tests for the <see cref="DatabaseTableDto"/> class.
    /// </summary>
    [TestFixture]
    public class DatabaseTableDtoTests
    {
        #region DatabaseTableDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void DatabaseTableDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<DatabaseTableDto>();
        }
        #endregion      // DatabaseTableDto_CTOR_SetsDefaultPropertyValues()

        #region DatabaseTableDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void DatabaseTableDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<DatabaseTableDto>();
        }
        #endregion      // DatabaseTableDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class DatabaseTableDtoTests

    #region public class GlobalSettingsDtoTests
    /// <summary>
    /// Unit tests for the <see cref="GlobalSettingsDto"/> class.
    /// </summary>
    [TestFixture]
    public class GlobalSettingsDtoTests
    {
        #region GlobalSettingsDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void GlobalSettingsDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<GlobalSettingsDto>();
        }
        #endregion      // GlobalSettingsDto_CTOR_SetsDefaultPropertyValues()

        #region GlobalSettingsDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void GlobalSettingsDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<GlobalSettingsDto>();
        }
        #endregion      // GlobalSettingsDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class GlobalSettingsDtoTests

    #region public class ConnectionDataDtoTests
    /// <summary>
    /// Unit tests for the <see cref="ConnectionDataDto"/> class.
    /// </summary>
    [TestFixture]
    public class ConnectionDataDtoTests
    {
        #region ConnectionDataDto_CTOR_SetsDefaultPropertyValues()
        /// <summary>
        /// Verifies that the default constructor initializes properties to default values.
        /// </summary>
        [Test]
        public void ConnectionDataDto_CTOR_SetsDefaultPropertyValues()
        {
            DtoTestHelper.AssertDefaultPropertyValues<ConnectionDataDto>();
        }
        #endregion      // ConnectionDataDto_CTOR_SetsDefaultPropertyValues()

        #region ConnectionDataDto_Properties_RoundTripAssignedValues()
        /// <summary>
        /// Verifies that assigned property values are retained.
        /// </summary>
        [Test]
        public void ConnectionDataDto_Properties_RoundTripAssignedValues()
        {
            DtoTestHelper.AssertPropertyRoundTrip<ConnectionDataDto>();
        }
        #endregion      // ConnectionDataDto_Properties_RoundTripAssignedValues()
    }
    #endregion      // public class ConnectionDataDtoTests
}
#endregion      // namespace HenStudio.Tests.System

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
