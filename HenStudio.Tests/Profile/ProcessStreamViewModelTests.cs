#region HEADER
//#####################################################################################################################
//###############################  P r o c e s s S t r e a m V i e w M o d e l T e s t s . c s  #######################
//#####################################################################################################################
//  FILENAME:  ProcessStreamViewModelTests.cs
//  NAMESPACE: HenStudio.Tests.Profile
//  CLASS(S):  ProcessStreamViewModelTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for the ProcessStreamViewModel class.
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
    #region public class ProcessStreamViewModelTests
    /// <summary>
    /// Unit tests for the ProcessStreamViewModel class.
    /// </summary>
    [TestFixture]
    public class ProcessStreamViewModelTests
    {
        #region PRIVATE METHODS

        #region CreateInternalProcessStreamDto()
        /// <summary>
        /// Creates a process stream DTO using internal units.
        /// </summary>
        private static ProcessStreamDto CreateInternalProcessStreamDto(Guid id, Guid profileId, string streamId)
        {
            return new ProcessStreamDto
            {
                Id = id,
                ProfileId = profileId,
                StreamCategory = "Process",
                StreamHeat = "Sensible",
                StreamId = streamId,
                StreamSegmentId = streamId + "-1",
                Name = streamId + " Name",
                StreamType = "Hot",
                StreamSubtype = "Liquid",
                SupplyTemperature = 400.0,
                SupplyPressure = 400.0,
                TargetTemperature = 500.0,
                TargetPressure = 500.0,
                HeatCapacityFlowRate = 4.0,
                HeatTransferCoefficient = 4.0
            };
        }
        #endregion      // CreateInternalProcessStreamDto()

        #region CreateExternalProcessStreamDto()
        /// <summary>
        /// Creates a process stream DTO using external units.
        /// </summary>
        private static ProcessStreamDto CreateExternalProcessStreamDto(Guid id, Guid profileId, string streamId)
        {
            return new ProcessStreamDto
            {
                Id = id,
                ProfileId = profileId,
                StreamCategory = "Process",
                StreamHeat = "Sensible",
                StreamId = streamId,
                StreamSegmentId = streamId + "-1",
                Name = streamId + " Name",
                StreamType = "Hot",
                StreamSubtype = "Liquid",
                SupplyTemperature = 260.33,
                SupplyPressure = 58.015072,
                TargetTemperature = 440.33,
                TargetPressure = 72.51884,
                HeatCapacityFlowRate = 7582.520,
                HeatTransferCoefficient = 704.440
            };
        }
        #endregion      // CreateExternalProcessStreamDto()

        #region CreateProcessStreamReader()
        /// <summary>
        /// Creates a process stream data reader for unit testing.
        /// </summary>
        private static IDataReader CreateProcessStreamReader(params ProcessStreamDto[] processStreams)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(Guid));
            table.Columns.Add("ProfileId", typeof(Guid));
            table.Columns.Add("StreamCategory", typeof(string));
            table.Columns.Add("StreamHeat", typeof(string));
            table.Columns.Add("StreamId", typeof(string));
            table.Columns.Add("StreamSegmentId", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("StreamType", typeof(string));
            table.Columns.Add("StreamSubtype", typeof(string));
            table.Columns.Add("SupplyTemperature", typeof(double));
            table.Columns.Add("SupplyPressure", typeof(double));
            table.Columns.Add("TargetTemperature", typeof(double));
            table.Columns.Add("TargetPressure", typeof(double));
            table.Columns.Add("HeatCapacityFlowRate", typeof(double));
            table.Columns.Add("HeatTransferCoefficient", typeof(double));

            foreach (ProcessStreamDto processStream in processStreams)
            {
                table.Rows.Add(processStream.Id,
                               processStream.ProfileId,
                               processStream.StreamCategory,
                               processStream.StreamHeat,
                               processStream.StreamId,
                               processStream.StreamSegmentId,
                               processStream.Name,
                               processStream.StreamType,
                               processStream.StreamSubtype,
                               processStream.SupplyTemperature,
                               processStream.SupplyPressure,
                               processStream.TargetTemperature,
                               processStream.TargetPressure,
                               processStream.HeatCapacityFlowRate,
                               processStream.HeatTransferCoefficient);
            }

            return table.CreateDataReader();
        }
        #endregion      // CreateProcessStreamReader()

        #region CreateProcessStreamViewModel()
        /// <summary>
        /// Creates a process stream view model and its backing fake ADO.NET objects for unit testing.
        /// </summary>
        private static ProcessStreamViewModel CreateProcessStreamViewModel(out TestDbCommand command,
                                                                           out TestDbConnection connection)
        {
            command = new TestDbCommand();
            connection = new TestDbConnection(command);

            ProcessStreamRepo processStreamRepo = new ProcessStreamRepo(new TestDbConnectionFactory(connection));

            return new ProcessStreamViewModel(processStreamRepo,
                                              ProfileViewModelTestHelpers.CreateExternalUnits(),
                                              ProfileViewModelTestHelpers.CreateInternalUnits());
        }
        #endregion      // CreateProcessStreamViewModel()

        #endregion      // PRIVATE METHODS

        #region ProcessStreamViewModel_CTOR_SetsProperties()
        /// <summary>
        /// Verifies that the constructor sets the repository and units properties.
        /// </summary>
        [Test]
        public void ProcessStreamViewModel_CTOR_SetsProperties()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            ProcessStreamRepo processStreamRepo = new ProcessStreamRepo(new TestDbConnectionFactory(connection));
            HenProjectUnits externalUnits = ProfileViewModelTestHelpers.CreateExternalUnits();
            HenProjectUnits internalUnits = ProfileViewModelTestHelpers.CreateInternalUnits();

            ProcessStreamViewModel viewModel = new ProcessStreamViewModel(processStreamRepo, externalUnits, internalUnits);

            Assert.That(viewModel.ProcessStreamRepoObj, Is.SameAs(processStreamRepo));
            Assert.That(viewModel.ExternalUnitsObj, Is.SameAs(externalUnits));
            Assert.That(viewModel.InternalUnitsObj, Is.SameAs(internalUnits));
        }
        #endregion      // ProcessStreamViewModel_CTOR_SetsProperties()

        #region GetProcessStreams_ReturnsProcessStreamsInExternalUnits()
        /// <summary>
        /// Verifies that GetProcessStreams returns process streams converted from internal units to external units.
        /// </summary>
        [Test]
        public void GetProcessStreams_ReturnsProcessStreamsInExternalUnits()
        {
            TestDbCommand command;
            TestDbConnection connection;
            ProcessStreamViewModel viewModel = CreateProcessStreamViewModel(out command, out connection);
            ProcessStreamDto processStream = CreateInternalProcessStreamDto(Guid.NewGuid(), Guid.NewGuid(), "H01");

            command.ReaderResult = CreateProcessStreamReader(processStream);

            IList<ProcessStreamDto> result = viewModel.GetProcessStreams();

            Assert.That(connection.OpenWasCalled, Is.True);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
            AssertEx.NearlyEqual(260.33, result[0].SupplyTemperature, 0.001);
            AssertEx.NearlyEqual(58.015072, result[0].SupplyPressure, 0.001);
            AssertEx.NearlyEqual(440.33, result[0].TargetTemperature, 0.001);
            AssertEx.NearlyEqual(72.51884, result[0].TargetPressure, 0.001);
            AssertEx.NearlyEqual(7582.520, result[0].HeatCapacityFlowRate, 0.001);
            AssertEx.NearlyEqual(704.440, result[0].HeatTransferCoefficient, 0.001);
        }
        #endregion      // GetProcessStreams_ReturnsProcessStreamsInExternalUnits()

        #region GetProcessStreamsByProfileId_ReturnsProcessStreamsInExternalUnits()
        /// <summary>
        /// Verifies that GetProcessStreamsByProfileId returns matching process streams converted from internal units to external units.
        /// </summary>
        [Test]
        public void GetProcessStreamsByProfileId_ReturnsProcessStreamsInExternalUnits()
        {
            TestDbCommand command;
            TestDbConnection connection;
            ProcessStreamViewModel viewModel = CreateProcessStreamViewModel(out command, out connection);
            Guid profileId = Guid.NewGuid();
            ProcessStreamDto processStream = CreateInternalProcessStreamDto(Guid.NewGuid(), profileId, "H01");

            command.ReaderResult = CreateProcessStreamReader(processStream);

            IList<ProcessStreamDto> result = viewModel.GetProcessStreamsByProfileId(profileId);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@ProfileId"), Is.EqualTo(profileId));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
            AssertEx.NearlyEqual(7582.520, result[0].HeatCapacityFlowRate, 0.001);
        }
        #endregion      // GetProcessStreamsByProfileId_ReturnsProcessStreamsInExternalUnits()

        #region GetProcessStreamById_ReturnsProcessStreamInExternalUnits()
        /// <summary>
        /// Verifies that GetProcessStreamById returns a process stream converted from internal units to external units.
        /// </summary>
        [Test]
        public void GetProcessStreamById_ReturnsProcessStreamInExternalUnits()
        {
            TestDbCommand command;
            TestDbConnection connection;
            ProcessStreamViewModel viewModel = CreateProcessStreamViewModel(out command, out connection);
            ProcessStreamDto processStream = CreateInternalProcessStreamDto(Guid.NewGuid(), Guid.NewGuid(), "H01");

            command.ReaderResult = CreateProcessStreamReader(processStream);

            ProcessStreamDto result = viewModel.GetProcessStreamById(processStream.Id);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(processStream.Id));
            Assert.That(result, Is.Not.Null);
            AssertEx.NearlyEqual(704.440, result.HeatTransferCoefficient, 0.001);
        }
        #endregion      // GetProcessStreamById_ReturnsProcessStreamInExternalUnits()

        #region GetProcessStreamByStreamId_ReturnsProcessStreamInExternalUnits()
        /// <summary>
        /// Verifies that GetProcessStreamByStreamId returns a process stream converted from internal units to external units.
        /// </summary>
        [Test]
        public void GetProcessStreamByStreamId_ReturnsProcessStreamInExternalUnits()
        {
            TestDbCommand command;
            TestDbConnection connection;
            ProcessStreamViewModel viewModel = CreateProcessStreamViewModel(out command, out connection);
            ProcessStreamDto processStream = CreateInternalProcessStreamDto(Guid.NewGuid(), Guid.NewGuid(), "H01");

            command.ReaderResult = CreateProcessStreamReader(processStream);

            ProcessStreamDto result = viewModel.GetProcessStreamByStreamId(processStream.ProfileId, processStream.StreamId);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@ProfileId"), Is.EqualTo(processStream.ProfileId));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@StreamId"), Is.EqualTo("H01"));
            Assert.That(result, Is.Not.Null);
            AssertEx.NearlyEqual(260.33, result.SupplyTemperature, 0.001);
        }
        #endregion      // GetProcessStreamByStreamId_ReturnsProcessStreamInExternalUnits()

        #region AddProcessStream_ReturnsInsertedProcessStreamId_AndStoresInternalUnits()
        /// <summary>
        /// Verifies that AddProcessStream converts external units to internal units and returns the inserted process stream identifier.
        /// </summary>
        [Test]
        public void AddProcessStream_ReturnsInsertedProcessStreamId_AndStoresInternalUnits()
        {
            TestDbCommand command;
            TestDbConnection connection;
            ProcessStreamViewModel viewModel = CreateProcessStreamViewModel(out command, out connection);
            ProcessStreamDto externalProcessStream = CreateExternalProcessStreamDto(Guid.NewGuid(), Guid.NewGuid(), "H01");
            Guid insertedId = Guid.NewGuid();

            command.ScalarResult = insertedId;

            Guid result = viewModel.AddProcessStream(externalProcessStream);

            Assert.That(command.ExecuteScalarWasCalled, Is.True);
            Assert.That(result, Is.EqualTo(insertedId));
            AssertEx.NearlyEqual(400.0, Convert.ToDouble(ProfileViewModelTestHelpers.GetParameterValue(command, "@SupplyTemperature")), 0.001);
            AssertEx.NearlyEqual(400.0, Convert.ToDouble(ProfileViewModelTestHelpers.GetParameterValue(command, "@SupplyPressure")), 0.001);
            AssertEx.NearlyEqual(500.0, Convert.ToDouble(ProfileViewModelTestHelpers.GetParameterValue(command, "@TargetTemperature")), 0.001);
            AssertEx.NearlyEqual(500.0, Convert.ToDouble(ProfileViewModelTestHelpers.GetParameterValue(command, "@TargetPressure")), 0.001);
            AssertEx.NearlyEqual(4.0, Convert.ToDouble(ProfileViewModelTestHelpers.GetParameterValue(command, "@HeatCapacityFlowRate")), 0.001);
            AssertEx.NearlyEqual(4.0, Convert.ToDouble(ProfileViewModelTestHelpers.GetParameterValue(command, "@HeatTransferCoefficient")), 0.001);
        }
        #endregion      // AddProcessStream_ReturnsInsertedProcessStreamId_AndStoresInternalUnits()

        #region UpdateProcessStream_StoresInternalUnits()
        /// <summary>
        /// Verifies that UpdateProcessStream converts external units to internal units before updating the repository.
        /// </summary>
        [Test]
        public void UpdateProcessStream_StoresInternalUnits()
        {
            TestDbCommand command;
            TestDbConnection connection;
            ProcessStreamViewModel viewModel = CreateProcessStreamViewModel(out command, out connection);
            ProcessStreamDto externalProcessStream = CreateExternalProcessStreamDto(Guid.NewGuid(), Guid.NewGuid(), "H01");
            command.NonQueryResult = 1;

            viewModel.UpdateProcessStream(externalProcessStream);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(externalProcessStream.Id));
            AssertEx.NearlyEqual(4.0, Convert.ToDouble(ProfileViewModelTestHelpers.GetParameterValue(command, "@HeatCapacityFlowRate")), 0.001);
            AssertEx.NearlyEqual(4.0, Convert.ToDouble(ProfileViewModelTestHelpers.GetParameterValue(command, "@HeatTransferCoefficient")), 0.001);
        }
        #endregion      // UpdateProcessStream_StoresInternalUnits()

        #region DeleteProcessStream_DeletesProcessStreamById()
        /// <summary>
        /// Verifies that DeleteProcessStream forwards the process stream identifier to the repository.
        /// </summary>
        [Test]
        public void DeleteProcessStream_DeletesProcessStreamById()
        {
            TestDbCommand command;
            TestDbConnection connection;
            ProcessStreamViewModel viewModel = CreateProcessStreamViewModel(out command, out connection);
            Guid processStreamId = Guid.NewGuid();
            command.NonQueryResult = 1;

            viewModel.DeleteProcessStream(processStreamId);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(processStreamId));
        }
        #endregion      // DeleteProcessStream_DeletesProcessStreamById()
    }
    #endregion      // public class ProcessStreamViewModelTests
}
#endregion      // namespace HenStudio.Tests.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
