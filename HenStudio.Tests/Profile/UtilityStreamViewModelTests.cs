#region HEADER
//###############################  U t i l i t y S t r e a m V i e w M o d e l T e s t s . c s  #######################
//#####################################################################################################################
//  FILENAME:  UtilityStreamViewModelTests.cs
//  NAMESPACE: HenStudio.Tests.Profile
//  CLASS(S):  UtilityStreamViewModelTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for the UtilityStreamViewModel class.
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
using HenStudio.Tests.Helpers;
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
    #region public class UtilityStreamViewModelTests
    /// <summary>
    /// Unit tests for the UtilityStreamViewModel class.
    /// </summary>
    [TestFixture]
    public class UtilityStreamViewModelTests
    {
        #region PRIVATE METHODS

        #region CreateInternalUtilityStreamDto()
        /// <summary>
        /// Creates a utility stream DTO using internal units.
        /// </summary>
        private static UtilityStreamDto CreateInternalUtilityStreamDto(Guid id, Guid profileId, string streamId)
        {
            return new UtilityStreamDto
            {
                Id = id,
                ProfileId = profileId,
                StreamCategory = "Utility",
                StreamHeat = "Latent",
                StreamId = streamId,
                Name = streamId + " Name",
                StreamType = "Cold Water",
                IsothermalTemperature = 400.0,
                SupplyPressure = 400.0,
                TargetPressure = 500.0,
                EnthalpyFlowRate = 4.0
            };
        }
        #endregion      // CreateInternalUtilityStreamDto()

        #region CreateExternalUtilityStreamDto()
        /// <summary>
        /// Creates a utility stream DTO using external units.
        /// </summary>
        private static UtilityStreamDto CreateExternalUtilityStreamDto(Guid id, Guid profileId, string streamId)
        {
            return new UtilityStreamDto
            {
                Id = id,
                ProfileId = profileId,
                StreamCategory = "Utility",
                StreamHeat = "Latent",
                StreamId = streamId,
                Name = streamId + " Name",
                StreamType = "Cold Water",
                IsothermalTemperature = 260.33,
                SupplyPressure = 58.015072,
                TargetPressure = 72.51884,
                EnthalpyFlowRate = 13648.568
            };
        }
        #endregion      // CreateExternalUtilityStreamDto()

        #region CreateUtilityStreamReader()
        /// <summary>
        /// Creates a utility stream data reader for unit testing.
        /// </summary>
        private static IDataReader CreateUtilityStreamReader(params UtilityStreamDto[] utilityStreams)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(Guid));
            table.Columns.Add("ProfileId", typeof(Guid));
            table.Columns.Add("StreamCategory", typeof(string));
            table.Columns.Add("StreamHeat", typeof(string));
            table.Columns.Add("StreamId", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("StreamType", typeof(string));
            table.Columns.Add("IsothermalTemperature", typeof(double));
            table.Columns.Add("SupplyPressure", typeof(double));
            table.Columns.Add("TargetPressure", typeof(double));
            table.Columns.Add("EnthalpyFlowRate", typeof(double));

            foreach (UtilityStreamDto utilityStream in utilityStreams)
            {
                table.Rows.Add(utilityStream.Id,
                               utilityStream.ProfileId,
                               utilityStream.StreamCategory,
                               utilityStream.StreamHeat,
                               utilityStream.StreamId,
                               utilityStream.Name,
                               utilityStream.StreamType,
                               utilityStream.IsothermalTemperature,
                               utilityStream.SupplyPressure,
                               utilityStream.TargetPressure,
                               utilityStream.EnthalpyFlowRate);
            }

            return table.CreateDataReader();
        }
        #endregion      // CreateUtilityStreamReader()

        #region CreateUtilityStreamViewModel()
        /// <summary>
        /// Creates a utility stream view model and its backing fake ADO.NET objects for unit testing.
        /// </summary>
        private static UtilityStreamViewModel CreateUtilityStreamViewModel(out TestDbCommand command,
                                                                           out TestDbConnection connection)
        {
            command = new TestDbCommand();
            connection = new TestDbConnection(command);

            UtilityStreamRepo utilityStreamRepo = new UtilityStreamRepo(new TestDbConnectionFactory(connection));

            return new UtilityStreamViewModel(utilityStreamRepo,
                                              ProfileViewModelTestHelpers.CreateExternalUnits(),
                                              ProfileViewModelTestHelpers.CreateInternalUnits());
        }
        #endregion      // CreateUtilityStreamViewModel()

        #endregion      // PRIVATE METHODS

        #region UtilityStreamViewModel_CTOR_SetsProperties()
        /// <summary>
        /// Verifies that the constructor sets the repository and units properties.
        /// </summary>
        [Test]
        public void UtilityStreamViewModel_CTOR_SetsProperties()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            UtilityStreamRepo utilityStreamRepo = new UtilityStreamRepo(new TestDbConnectionFactory(connection));
            HenProjectUnits externalUnits = ProfileViewModelTestHelpers.CreateExternalUnits();
            HenProjectUnits internalUnits = ProfileViewModelTestHelpers.CreateInternalUnits();

            UtilityStreamViewModel viewModel = new UtilityStreamViewModel(utilityStreamRepo, externalUnits, internalUnits);

            Assert.That(viewModel.UtilityStreamRepoObj, Is.SameAs(utilityStreamRepo));
            Assert.That(viewModel.ExternalUnitsObj, Is.SameAs(externalUnits));
            Assert.That(viewModel.InternalUnitsObj, Is.SameAs(internalUnits));
        }
        #endregion      // UtilityStreamViewModel_CTOR_SetsProperties()

        #region GetUtilityStreams_ReturnsUtilityStreamsInExternalUnits()
        /// <summary>
        /// Verifies that GetUtilityStreams returns utility streams converted from internal units to external units.
        /// </summary>
        [Test]
        public void GetUtilityStreams_ReturnsUtilityStreamsInExternalUnits()
        {
            TestDbCommand command;
            TestDbConnection connection;
            UtilityStreamViewModel viewModel = CreateUtilityStreamViewModel(out command, out connection);
            UtilityStreamDto utilityStream = CreateInternalUtilityStreamDto(Guid.NewGuid(), Guid.NewGuid(), "CW01");

            command.ReaderResult = CreateUtilityStreamReader(utilityStream);

            IList<UtilityStreamDto> result = viewModel.GetUtilityStreams();

            Assert.That(connection.OpenWasCalled, Is.True);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
            AssertEx.NearlyEqual(260.33, result[0].IsothermalTemperature, 0.001);
            AssertEx.NearlyEqual(58.015072, result[0].SupplyPressure, 0.001);
            AssertEx.NearlyEqual(72.51884, result[0].TargetPressure, 0.001);
            AssertEx.NearlyEqual(13648.568, result[0].EnthalpyFlowRate, 0.001);
        }
        #endregion      // GetUtilityStreams_ReturnsUtilityStreamsInExternalUnits()

        #region GetUtilityStreamsByProfileId_ReturnsUtilityStreamsInExternalUnits()
        /// <summary>
        /// Verifies that GetUtilityStreamsByProfileId returns matching utility streams converted from internal units to external units.
        /// </summary>
        [Test]
        public void GetUtilityStreamsByProfileId_ReturnsUtilityStreamsInExternalUnits()
        {
            TestDbCommand command;
            TestDbConnection connection;
            UtilityStreamViewModel viewModel = CreateUtilityStreamViewModel(out command, out connection);
            Guid profileId = Guid.NewGuid();
            UtilityStreamDto utilityStream = CreateInternalUtilityStreamDto(Guid.NewGuid(), profileId, "CW01");

            command.ReaderResult = CreateUtilityStreamReader(utilityStream);

            IList<UtilityStreamDto> result = viewModel.GetUtilityStreamsByProfileId(profileId);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@ProfileId"), Is.EqualTo(profileId));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
            AssertEx.NearlyEqual(13648.568, result[0].EnthalpyFlowRate, 0.001);
        }
        #endregion      // GetUtilityStreamsByProfileId_ReturnsUtilityStreamsInExternalUnits()

        #region GetUtilityStreamById_ReturnsUtilityStreamInExternalUnits()
        /// <summary>
        /// Verifies that GetUtilityStreamById returns a utility stream converted from internal units to external units.
        /// </summary>
        [Test]
        public void GetUtilityStreamById_ReturnsUtilityStreamInExternalUnits()
        {
            TestDbCommand command;
            TestDbConnection connection;
            UtilityStreamViewModel viewModel = CreateUtilityStreamViewModel(out command, out connection);
            UtilityStreamDto utilityStream = CreateInternalUtilityStreamDto(Guid.NewGuid(), Guid.NewGuid(), "CW01");

            command.ReaderResult = CreateUtilityStreamReader(utilityStream);

            UtilityStreamDto result = viewModel.GetUtilityStreamById(utilityStream.Id);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(utilityStream.Id));
            Assert.That(result, Is.Not.Null);
            AssertEx.NearlyEqual(260.33, result.IsothermalTemperature, 0.001);
        }
        #endregion      // GetUtilityStreamById_ReturnsUtilityStreamInExternalUnits()

        #region GetUtilityStreamByStreamId_ReturnsUtilityStreamInExternalUnits()
        /// <summary>
        /// Verifies that GetUtilityStreamByStreamId returns a utility stream converted from internal units to external units.
        /// </summary>
        [Test]
        public void GetUtilityStreamByStreamId_ReturnsUtilityStreamInExternalUnits()
        {
            TestDbCommand command;
            TestDbConnection connection;
            UtilityStreamViewModel viewModel = CreateUtilityStreamViewModel(out command, out connection);
            UtilityStreamDto utilityStream = CreateInternalUtilityStreamDto(Guid.NewGuid(), Guid.NewGuid(), "CW01");

            command.ReaderResult = CreateUtilityStreamReader(utilityStream);

            UtilityStreamDto result = viewModel.GetUtilityStreamByStreamId(utilityStream.ProfileId, utilityStream.StreamId);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@ProfileId"), Is.EqualTo(utilityStream.ProfileId));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@StreamId"), Is.EqualTo("CW01"));
            Assert.That(result, Is.Not.Null);
            AssertEx.NearlyEqual(58.015072, result.SupplyPressure, 0.001);
        }
        #endregion      // GetUtilityStreamByStreamId_ReturnsUtilityStreamInExternalUnits()

        #region AddUtilityStream_ReturnsInsertedUtilityStreamId_AndStoresInternalUnits()
        /// <summary>
        /// Verifies that AddUtilityStream converts external units to internal units and returns the inserted utility stream identifier.
        /// </summary>
        [Test]
        public void AddUtilityStream_ReturnsInsertedUtilityStreamId_AndStoresInternalUnits()
        {
            TestDbCommand command;
            TestDbConnection connection;
            UtilityStreamViewModel viewModel = CreateUtilityStreamViewModel(out command, out connection);
            UtilityStreamDto externalUtilityStream = CreateExternalUtilityStreamDto(Guid.NewGuid(), Guid.NewGuid(), "CW01");
            Guid insertedId = Guid.NewGuid();

            command.ScalarResult = insertedId;

            Guid result = viewModel.AddUtilityStream(externalUtilityStream);

            Assert.That(command.ExecuteScalarWasCalled, Is.True);
            Assert.That(result, Is.EqualTo(insertedId));
            AssertEx.NearlyEqual(400.0, Convert.ToDouble(ProfileViewModelTestHelpers.GetParameterValue(command, "@IsothermalTemperature")), 0.001);
            AssertEx.NearlyEqual(400.0, Convert.ToDouble(ProfileViewModelTestHelpers.GetParameterValue(command, "@SupplyPressure")), 0.001);
            AssertEx.NearlyEqual(500.0, Convert.ToDouble(ProfileViewModelTestHelpers.GetParameterValue(command, "@TargetPressure")), 0.001);
            AssertEx.NearlyEqual(4.0, Convert.ToDouble(ProfileViewModelTestHelpers.GetParameterValue(command, "@EnthalpyFlowRate")), 0.001);
        }
        #endregion      // AddUtilityStream_ReturnsInsertedUtilityStreamId_AndStoresInternalUnits()

        #region UpdateUtilityStream_StoresInternalUnits()
        /// <summary>
        /// Verifies that UpdateUtilityStream converts external units to internal units before updating the repository.
        /// </summary>
        [Test]
        public void UpdateUtilityStream_StoresInternalUnits()
        {
            TestDbCommand command;
            TestDbConnection connection;
            UtilityStreamViewModel viewModel = CreateUtilityStreamViewModel(out command, out connection);
            UtilityStreamDto externalUtilityStream = CreateExternalUtilityStreamDto(Guid.NewGuid(), Guid.NewGuid(), "CW01");
            command.NonQueryResult = 1;

            viewModel.UpdateUtilityStream(externalUtilityStream);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(externalUtilityStream.Id));
            AssertEx.NearlyEqual(4.0, Convert.ToDouble(ProfileViewModelTestHelpers.GetParameterValue(command, "@EnthalpyFlowRate")), 0.001);
        }
        #endregion      // UpdateUtilityStream_StoresInternalUnits()

        #region DeleteUtilityStream_DeletesUtilityStreamById()
        /// <summary>
        /// Verifies that DeleteUtilityStream forwards the utility stream identifier to the repository.
        /// </summary>
        [Test]
        public void DeleteUtilityStream_DeletesUtilityStreamById()
        {
            TestDbCommand command;
            TestDbConnection connection;
            UtilityStreamViewModel viewModel = CreateUtilityStreamViewModel(out command, out connection);
            Guid utilityStreamId = Guid.NewGuid();
            command.NonQueryResult = 1;

            viewModel.DeleteUtilityStream(utilityStreamId);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(utilityStreamId));
        }
        #endregion      // DeleteUtilityStream_DeletesUtilityStreamById()
    }
    #endregion      // public class UtilityStreamViewModelTests
}
#endregion      // namespace HenStudio.Tests.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
