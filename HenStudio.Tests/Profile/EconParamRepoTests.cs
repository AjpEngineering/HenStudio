#region HEADER
//#####################################################################################################################
//######################################  E c o n P a r a m R e p o T e s t s . c s  ##################################
//#####################################################################################################################
//  FILENAME:  EconParamRepoTests.cs
//  NAMESPACE: HenStudio.Tests.Profile
//  CLASS(S):  EconParamRepoTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for the EconParamRepo class.
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
using HenPersistence.Repos;
using HenRepositories.Dto;
using HenStudio.Tests.System;

using System;
using System.Collections.Generic;
using System.Data;

using NUnit.Framework;
#endregion      // REFERENCES

#region namespace HenStudio.Tests.Profile
namespace HenStudio.Tests.Profile
{
    #region public class EconParamRepoTests
    /// <summary>
    /// Unit tests for the EconParamRepo class.
    /// </summary>
    [TestFixture]
    public class EconParamRepoTests
    {
        #region PRIVATE METHODS

        #region CreateEconParamDto()
        /// <summary>
        /// Creates an EconParam DTO for unit testing.
        /// </summary>
        private static EconParamDto CreateEconParamDto(Guid id, Guid profileId, string name)
        {
            return new EconParamDto
            {
                Id = id,
                ProfileId = profileId,
                CapitalCostIndexName = name,
                CapitalCostIndexC1 = 1.1,
                CapitalCostIndexC2 = 2.2,
                CapitalCostIndexC3 = 3.3,
                CapitalCostIndexConfiguration = "Heat Exchanger",
                RateOfReturn = 10.0,
                ProjectLifetime = 20
            };
        }
        #endregion      // CreateEconParamDto()

        #region CreateEconParamReader()
        /// <summary>
        /// Creates an EconParam data reader for unit testing.
        /// </summary>
        private static IDataReader CreateEconParamReader(params EconParamDto[] econParams)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(Guid));
            table.Columns.Add("ProfileId", typeof(Guid));
            table.Columns.Add("CapitalCostIndexName", typeof(string));
            table.Columns.Add("CapitalCostIndexC1", typeof(double));
            table.Columns.Add("CapitalCostIndexC2", typeof(double));
            table.Columns.Add("CapitalCostIndexC3", typeof(double));
            table.Columns.Add("CapitalCostIndexConfiguration", typeof(string));
            table.Columns.Add("RateOfReturn", typeof(double));
            table.Columns.Add("ProjectLifetime", typeof(int));

            foreach (EconParamDto econParam in econParams)
            {
                table.Rows.Add(econParam.Id,
                               econParam.ProfileId,
                               econParam.CapitalCostIndexName,
                               econParam.CapitalCostIndexC1,
                               econParam.CapitalCostIndexC2,
                               econParam.CapitalCostIndexC3,
                               econParam.CapitalCostIndexConfiguration,
                               econParam.RateOfReturn,
                               econParam.ProjectLifetime);
            }

            return table.CreateDataReader();
        }
        #endregion      // CreateEconParamReader()

        #endregion      // PRIVATE METHODS

        #region EconParamRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()
        /// <summary>
        /// Verifies that the constructor throws when the connection factory is null.
        /// </summary>
        [Test]
        public void EconParamRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()
        {
            Assert.That(() => new EconParamRepo(null), Throws.ArgumentNullException);
        }
        #endregion      // EconParamRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()

        #region GetEconParams_ReturnsMappedEconParams()
        /// <summary>
        /// Verifies that GetEconParams returns the mapped economic parameters.
        /// </summary>
        [Test]
        public void GetEconParams_ReturnsMappedEconParams()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            EconParamRepo repo = new EconParamRepo(new TestDbConnectionFactory(connection));
            Guid profileId = Guid.NewGuid();
            EconParamDto econParam1 = CreateEconParamDto(Guid.NewGuid(), profileId, "Alpha");
            EconParamDto econParam2 = CreateEconParamDto(Guid.NewGuid(), profileId, "Beta");

            command.ReaderResult = CreateEconParamReader(econParam1, econParam2);

            IList<EconParamDto> result = repo.GetEconParams();

            Assert.That(connection.OpenWasCalled, Is.True);
            Assert.That(command.ExecuteReaderWasCalled, Is.True);
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].CapitalCostIndexName, Is.EqualTo("Alpha"));
            Assert.That(result[1].CapitalCostIndexName, Is.EqualTo("Beta"));
        }
        #endregion      // GetEconParams_ReturnsMappedEconParams()

        #region GetEconParamsByProfileId_ReturnsMappedEconParams()
        /// <summary>
        /// Verifies that GetEconParamsByProfileId returns the mapped economic parameters.
        /// </summary>
        [Test]
        public void GetEconParamsByProfileId_ReturnsMappedEconParams()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            EconParamRepo repo = new EconParamRepo(new TestDbConnectionFactory(connection));
            Guid profileId = Guid.NewGuid();
            EconParamDto econParam = CreateEconParamDto(Guid.NewGuid(), profileId, "Alpha");

            command.ReaderResult = CreateEconParamReader(econParam);

            IList<EconParamDto> result = repo.GetEconParamsByProfileId(profileId);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@ProfileId"), Is.EqualTo(profileId));
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].ProfileId, Is.EqualTo(profileId));
        }
        #endregion      // GetEconParamsByProfileId_ReturnsMappedEconParams()

        #region GetEconParamById_ReturnsMappedEconParam_WhenFound()
        /// <summary>
        /// Verifies that GetEconParamById returns the mapped economic parameter when found.
        /// </summary>
        [Test]
        public void GetEconParamById_ReturnsMappedEconParam_WhenFound()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            EconParamRepo repo = new EconParamRepo(new TestDbConnectionFactory(connection));
            EconParamDto econParam = CreateEconParamDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");

            command.ReaderResult = CreateEconParamReader(econParam);

            EconParamDto result = repo.GetEconParamById(econParam.Id);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(econParam.Id));
            Assert.That(result.CapitalCostIndexName, Is.EqualTo("Alpha"));
        }
        #endregion      // GetEconParamById_ReturnsMappedEconParam_WhenFound()

        #region GetEconParamByName_ThrowsArgumentException_WhenCapitalCostIndexNameIsBlank()
        /// <summary>
        /// Verifies that GetEconParamByName throws when the capital cost index name is blank.
        /// </summary>
        [Test]
        public void GetEconParamByName_ThrowsArgumentException_WhenCapitalCostIndexNameIsBlank()
        {
            EconParamRepo repo = new EconParamRepo(new TestDbConnectionFactory(new TestDbConnection(new TestDbCommand())));

            Assert.That(() => repo.GetEconParamByName(Guid.NewGuid(), " "), Throws.ArgumentException);
        }
        #endregion      // GetEconParamByName_ThrowsArgumentException_WhenCapitalCostIndexNameIsBlank()

        #region GetEconParamByName_ReturnsMappedEconParam_WhenFound()
        /// <summary>
        /// Verifies that GetEconParamByName returns the mapped economic parameter when found.
        /// </summary>
        [Test]
        public void GetEconParamByName_ReturnsMappedEconParam_WhenFound()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            EconParamRepo repo = new EconParamRepo(new TestDbConnectionFactory(connection));
            EconParamDto econParam = CreateEconParamDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");

            command.ReaderResult = CreateEconParamReader(econParam);

            EconParamDto result = repo.GetEconParamByName(econParam.ProfileId, econParam.CapitalCostIndexName);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@ProfileId"), Is.EqualTo(econParam.ProfileId));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@CapitalCostIndexName"), Is.EqualTo("Alpha"));
            Assert.That(result.CapitalCostIndexName, Is.EqualTo("Alpha"));
        }
        #endregion      // GetEconParamByName_ReturnsMappedEconParam_WhenFound()

        #region AddEconParam_ReturnsInsertedEconParamId()
        /// <summary>
        /// Verifies that AddEconParam returns the inserted economic parameter identifier.
        /// </summary>
        [Test]
        public void AddEconParam_ReturnsInsertedEconParamId()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            EconParamRepo repo = new EconParamRepo(new TestDbConnectionFactory(connection));
            EconParamDto econParam = CreateEconParamDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");
            Guid insertedId = Guid.NewGuid();

            command.ScalarResult = insertedId;

            Guid result = repo.AddEconParam(econParam);

            Assert.That(command.ExecuteScalarWasCalled, Is.True);
            Assert.That(result, Is.EqualTo(insertedId));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@CapitalCostIndexName"), Is.EqualTo("Alpha"));
        }
        #endregion      // AddEconParam_ReturnsInsertedEconParamId()

        #region UpdateEconParam_StoresEconParam()
        /// <summary>
        /// Verifies that UpdateEconParam forwards the economic parameter to the repository.
        /// </summary>
        [Test]
        public void UpdateEconParam_StoresEconParam()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            EconParamRepo repo = new EconParamRepo(new TestDbConnectionFactory(connection));
            EconParamDto econParam = CreateEconParamDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");

            repo.UpdateEconParam(econParam);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(econParam.Id));
        }
        #endregion      // UpdateEconParam_StoresEconParam()

        #region DeleteEconParam_DeletesEconParamById()
        /// <summary>
        /// Verifies that DeleteEconParam forwards the economic parameter identifier to the repository.
        /// </summary>
        [Test]
        public void DeleteEconParam_DeletesEconParamById()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            EconParamRepo repo = new EconParamRepo(new TestDbConnectionFactory(connection));
            Guid econParamId = Guid.NewGuid();

            repo.DeleteEconParam(econParamId);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(econParamId));
        }
        #endregion      // DeleteEconParam_DeletesEconParamById()
    }
    #endregion      // public class EconParamRepoTests
}
#endregion      // namespace HenStudio.Tests.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
