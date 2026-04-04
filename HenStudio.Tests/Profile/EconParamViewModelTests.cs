#region HEADER
//#####################################################################################################################
//###################################  E c o n P a r a m V i e w M o d e l T e s t s . c s  ###########################
//#####################################################################################################################
//  FILENAME:  EconParamViewModelTests.cs
//  NAMESPACE: HenStudio.Tests.Profile
//  CLASS(S):  EconParamViewModelTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for the EconParamViewModel class.
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
using HenPersistence.Repos;
using HenRepositories.Dto;
using HenStudio.Tests.System;
using HenViewModels;

using System;
using System.Collections.Generic;
using System.Data;

using NUnit.Framework;
#endregion      // REFERENCES

#region namespace HenStudio.Tests.Profile
namespace HenStudio.Tests.Profile
{
    #region public class EconParamViewModelTests
    /// <summary>
    /// Unit tests for the EconParamViewModel class.
    /// </summary>
    [TestFixture]
    public class EconParamViewModelTests
    {
        #region PRIVATE METHODS

        #region CreateEconParamDto()
        /// <summary>
        /// Creates an EconParam DTO for unit testing.
        /// </summary>
        /// <param name="id">The economic parameter identifier.</param>
        /// <param name="profileId">The profile identifier.</param>
        /// <param name="name">The capital cost index name.</param>
        /// <returns>A populated <see cref="EconParamDto"/> instance.</returns>
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
        /// <param name="econParams">The economic parameters to expose through the reader.</param>
        /// <returns>An <see cref="IDataReader"/> over the supplied economic parameter rows.</returns>
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
                table.Rows.Add(
                    econParam.Id,
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

        #region CreateEconParamViewModel()
        /// <summary>
        /// Creates an EconParam view model and its backing fake ADO.NET objects for unit testing.
        /// </summary>
        /// <param name="command">The created fake database command.</param>
        /// <param name="connection">The created fake database connection.</param>
        /// <returns>An <see cref="EconParamViewModel"/> instance configured with a testable repository.</returns>
        private static EconParamViewModel CreateEconParamViewModel(out TestDbCommand command,
                                                                   out TestDbConnection connection)
        {
            command = new TestDbCommand();
            connection = new TestDbConnection(command);

            EconParamRepo econParamRepo = new EconParamRepo(new TestDbConnectionFactory(connection));

            return new EconParamViewModel(econParamRepo,
                                          ProfileViewModelTestHelpers.CreateExternalUnits(),
                                          ProfileViewModelTestHelpers.CreateInternalUnits());
        }
        #endregion      // CreateEconParamViewModel()

        #endregion      // PRIVATE METHODS

        #region EconParamViewModel_CTOR_SetsProperties()
        /// <summary>
        /// Verifies that the constructor sets the repository and units properties.
        /// </summary>
        [Test]
        public void EconParamViewModel_CTOR_SetsProperties()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            EconParamRepo econParamRepo = new EconParamRepo(new TestDbConnectionFactory(connection));
            HenProjectUnits externalUnits = ProfileViewModelTestHelpers.CreateExternalUnits();
            HenProjectUnits internalUnits = ProfileViewModelTestHelpers.CreateInternalUnits();

            EconParamViewModel viewModel = new EconParamViewModel(econParamRepo, externalUnits, internalUnits);

            Assert.That(viewModel.EconParamRepoObj, Is.SameAs(econParamRepo));
            Assert.That(viewModel.ExternalUnitsObj, Is.SameAs(externalUnits));
            Assert.That(viewModel.InternalUnitsObj, Is.SameAs(internalUnits));
        }
        #endregion      // EconParamViewModel_CTOR_SetsProperties()

        #region GetEconParams_ReturnsEconParams()
        /// <summary>
        /// Verifies that GetEconParams returns the economic parameters from the repository.
        /// </summary>
        [Test]
        public void GetEconParams_ReturnsEconParams()
        {
            TestDbCommand command;
            TestDbConnection connection;
            EconParamViewModel viewModel = CreateEconParamViewModel(out command, out connection);
            Guid profileId = Guid.NewGuid();
            EconParamDto econParam1 = CreateEconParamDto(Guid.NewGuid(), profileId, "Alpha");
            EconParamDto econParam2 = CreateEconParamDto(Guid.NewGuid(), profileId, "Beta");

            command.ReaderResult = CreateEconParamReader(econParam1, econParam2);

            IList<EconParamDto> result = viewModel.GetEconParams();

            Assert.That(connection.OpenWasCalled, Is.True);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].CapitalCostIndexName, Is.EqualTo("Alpha"));
            Assert.That(result[1].CapitalCostIndexName, Is.EqualTo("Beta"));
        }
        #endregion      // GetEconParams_ReturnsEconParams()

        #region GetEconParamsByProfileId_ReturnsEconParams()
        /// <summary>
        /// Verifies that GetEconParamsByProfileId returns the matching economic parameters from the repository.
        /// </summary>
        [Test]
        public void GetEconParamsByProfileId_ReturnsEconParams()
        {
            TestDbCommand command;
            TestDbConnection connection;
            EconParamViewModel viewModel = CreateEconParamViewModel(out command, out connection);
            Guid profileId = Guid.NewGuid();
            EconParamDto econParam = CreateEconParamDto(Guid.NewGuid(), profileId, "Alpha");

            command.ReaderResult = CreateEconParamReader(econParam);

            IList<EconParamDto> result = viewModel.GetEconParamsByProfileId(profileId);

            Assert.That(command.ExecuteReaderWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@ProfileId"), Is.EqualTo(profileId));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].ProfileId, Is.EqualTo(profileId));
        }
        #endregion      // GetEconParamsByProfileId_ReturnsEconParams()

        #region GetEconParamById_ReturnsEconParam()
        /// <summary>
        /// Verifies that GetEconParamById returns the matching economic parameter from the repository.
        /// </summary>
        [Test]
        public void GetEconParamById_ReturnsEconParam()
        {
            TestDbCommand command;
            TestDbConnection connection;
            EconParamViewModel viewModel = CreateEconParamViewModel(out command, out connection);
            EconParamDto econParam = CreateEconParamDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");

            command.ReaderResult = CreateEconParamReader(econParam);

            EconParamDto result = viewModel.GetEconParamById(econParam.Id);

            Assert.That(command.ExecuteReaderWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(econParam.Id));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(econParam.Id));
            Assert.That(result.CapitalCostIndexName, Is.EqualTo("Alpha"));
        }
        #endregion      // GetEconParamById_ReturnsEconParam()

        #region GetEconParamByName_ReturnsEconParam()
        /// <summary>
        /// Verifies that GetEconParamByName returns the matching economic parameter from the repository.
        /// </summary>
        [Test]
        public void GetEconParamByName_ReturnsEconParam()
        {
            TestDbCommand command;
            TestDbConnection connection;
            EconParamViewModel viewModel = CreateEconParamViewModel(out command, out connection);
            EconParamDto econParam = CreateEconParamDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");

            command.ReaderResult = CreateEconParamReader(econParam);

            EconParamDto result = viewModel.GetEconParamByName(econParam.ProfileId, econParam.CapitalCostIndexName);

            Assert.That(command.ExecuteReaderWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@ProfileId"), Is.EqualTo(econParam.ProfileId));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@CapitalCostIndexName"), Is.EqualTo("Alpha"));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.CapitalCostIndexName, Is.EqualTo("Alpha"));
        }
        #endregion      // GetEconParamByName_ReturnsEconParam()

        #region AddEconParam_ReturnsInsertedEconParamId()
        /// <summary>
        /// Verifies that AddEconParam returns the inserted economic parameter identifier.
        /// </summary>
        [Test]
        public void AddEconParam_ReturnsInsertedEconParamId()
        {
            TestDbCommand command;
            TestDbConnection connection;
            EconParamViewModel viewModel = CreateEconParamViewModel(out command, out connection);
            EconParamDto econParam = CreateEconParamDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");
            Guid insertedId = Guid.NewGuid();

            command.ScalarResult = insertedId;

            Guid result = viewModel.AddEconParam(econParam);

            Assert.That(command.ExecuteScalarWasCalled, Is.True);
            Assert.That(result, Is.EqualTo(insertedId));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@CapitalCostIndexName"), Is.EqualTo("Alpha"));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@ProjectLifetime"), Is.EqualTo(20));
        }
        #endregion      // AddEconParam_ReturnsInsertedEconParamId()

        #region UpdateEconParam_StoresEconParam()
        /// <summary>
        /// Verifies that UpdateEconParam forwards the economic parameter to the repository.
        /// </summary>
        [Test]
        public void UpdateEconParam_StoresEconParam()
        {
            TestDbCommand command;
            TestDbConnection connection;
            EconParamViewModel viewModel = CreateEconParamViewModel(out command, out connection);
            EconParamDto econParam = CreateEconParamDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");
            command.NonQueryResult = 1;

            viewModel.UpdateEconParam(econParam);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(econParam.Id));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@CapitalCostIndexName"), Is.EqualTo("Alpha"));
        }
        #endregion      // UpdateEconParam_StoresEconParam()

        #region DeleteEconParam_DeletesEconParamById()
        /// <summary>
        /// Verifies that DeleteEconParam forwards the economic parameter identifier to the repository.
        /// </summary>
        [Test]
        public void DeleteEconParam_DeletesEconParamById()
        {
            TestDbCommand command;
            TestDbConnection connection;
            EconParamViewModel viewModel = CreateEconParamViewModel(out command, out connection);
            Guid econParamId = Guid.NewGuid();
            command.NonQueryResult = 1;

            viewModel.DeleteEconParam(econParamId);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(econParamId));
        }
        #endregion      // DeleteEconParam_DeletesEconParamById()
    }
    #endregion      // public class EconParamViewModelTests
}
#endregion      // namespace HenStudio.Tests.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
