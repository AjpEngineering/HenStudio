#region HEADER
//#####################################################################################################################
//####################################  P r o c e s s S t r e a m R e p o T e s t s . c s  ############################
//#####################################################################################################################
//  FILENAME:  ProcessStreamRepoTests.cs
//  NAMESPACE: HenStudio.Tests.Profile
//  CLASS(S):  ProcessStreamRepoTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for the ProcessStreamRepo class.
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
    #region public class ProcessStreamRepoTests
    /// <summary>
    /// Unit tests for the ProcessStreamRepo class.
    /// </summary>
    [TestFixture]
    public class ProcessStreamRepoTests
    {
        #region PRIVATE METHODS

        #region CreateProcessStreamDto()
        /// <summary>
        /// Creates a process stream DTO for unit testing.
        /// </summary>
        private static ProcessStreamDto CreateProcessStreamDto(Guid id, Guid profileId, string streamId)
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
        #endregion      // CreateProcessStreamDto()

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

        #endregion      // PRIVATE METHODS

        #region ProcessStreamRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()
        /// <summary>
        /// Verifies that the constructor throws when the connection factory is null.
        /// </summary>
        [Test]
        public void ProcessStreamRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()
        {
            Assert.That(() => new ProcessStreamRepo(null), Throws.ArgumentNullException);
        }
        #endregion      // ProcessStreamRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()

        #region GetProcessStreams_ReturnsMappedProcessStreams()
        /// <summary>
        /// Verifies that GetProcessStreams returns the mapped process streams.
        /// </summary>
        [Test]
        public void GetProcessStreams_ReturnsMappedProcessStreams()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            ProcessStreamRepo repo = new ProcessStreamRepo(new TestDbConnectionFactory(connection));
            Guid profileId = Guid.NewGuid();
            ProcessStreamDto processStream1 = CreateProcessStreamDto(Guid.NewGuid(), profileId, "H01");
            ProcessStreamDto processStream2 = CreateProcessStreamDto(Guid.NewGuid(), profileId, "H02");

            command.ReaderResult = CreateProcessStreamReader(processStream1, processStream2);

            IList<ProcessStreamDto> result = repo.GetProcessStreams();

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].StreamId, Is.EqualTo("H01"));
            Assert.That(result[1].StreamId, Is.EqualTo("H02"));
        }
        #endregion      // GetProcessStreams_ReturnsMappedProcessStreams()

        #region GetProcessStreamsByProfileId_ReturnsMappedProcessStreams()
        /// <summary>
        /// Verifies that GetProcessStreamsByProfileId returns the mapped process streams.
        /// </summary>
        [Test]
        public void GetProcessStreamsByProfileId_ReturnsMappedProcessStreams()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            ProcessStreamRepo repo = new ProcessStreamRepo(new TestDbConnectionFactory(connection));
            Guid profileId = Guid.NewGuid();
            ProcessStreamDto processStream = CreateProcessStreamDto(Guid.NewGuid(), profileId, "H01");

            command.ReaderResult = CreateProcessStreamReader(processStream);

            IList<ProcessStreamDto> result = repo.GetProcessStreamsByProfileId(profileId);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@ProfileId"), Is.EqualTo(profileId));
            Assert.That(result.Count, Is.EqualTo(1));
        }
        #endregion      // GetProcessStreamsByProfileId_ReturnsMappedProcessStreams()

        #region GetProcessStreamById_ReturnsMappedProcessStream_WhenFound()
        /// <summary>
        /// Verifies that GetProcessStreamById returns the mapped process stream when found.
        /// </summary>
        [Test]
        public void GetProcessStreamById_ReturnsMappedProcessStream_WhenFound()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            ProcessStreamRepo repo = new ProcessStreamRepo(new TestDbConnectionFactory(connection));
            ProcessStreamDto processStream = CreateProcessStreamDto(Guid.NewGuid(), Guid.NewGuid(), "H01");

            command.ReaderResult = CreateProcessStreamReader(processStream);

            ProcessStreamDto result = repo.GetProcessStreamById(processStream.Id);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(processStream.Id));
            Assert.That(result.StreamId, Is.EqualTo("H01"));
        }
        #endregion      // GetProcessStreamById_ReturnsMappedProcessStream_WhenFound()

        #region GetProcessStreamByStreamId_ThrowsArgumentException_WhenStreamIdIsBlank()
        /// <summary>
        /// Verifies that GetProcessStreamByStreamId throws when the stream identifier is blank.
        /// </summary>
        [Test]
        public void GetProcessStreamByStreamId_ThrowsArgumentException_WhenStreamIdIsBlank()
        {
            ProcessStreamRepo repo = new ProcessStreamRepo(new TestDbConnectionFactory(new TestDbConnection(new TestDbCommand())));

            Assert.That(() => repo.GetProcessStreamByStreamId(Guid.NewGuid(), " "), Throws.ArgumentException);
        }
        #endregion      // GetProcessStreamByStreamId_ThrowsArgumentException_WhenStreamIdIsBlank()

        #region GetProcessStreamByStreamId_ReturnsMappedProcessStream_WhenFound()
        /// <summary>
        /// Verifies that GetProcessStreamByStreamId returns the mapped process stream when found.
        /// </summary>
        [Test]
        public void GetProcessStreamByStreamId_ReturnsMappedProcessStream_WhenFound()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            ProcessStreamRepo repo = new ProcessStreamRepo(new TestDbConnectionFactory(connection));
            ProcessStreamDto processStream = CreateProcessStreamDto(Guid.NewGuid(), Guid.NewGuid(), "H01");

            command.ReaderResult = CreateProcessStreamReader(processStream);

            ProcessStreamDto result = repo.GetProcessStreamByStreamId(processStream.ProfileId, processStream.StreamId);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@ProfileId"), Is.EqualTo(processStream.ProfileId));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@StreamId"), Is.EqualTo("H01"));
            Assert.That(result.StreamId, Is.EqualTo("H01"));
        }
        #endregion      // GetProcessStreamByStreamId_ReturnsMappedProcessStream_WhenFound()

        #region AddProcessStream_ReturnsInsertedProcessStreamId()
        /// <summary>
        /// Verifies that AddProcessStream returns the inserted process stream identifier.
        /// </summary>
        [Test]
        public void AddProcessStream_ReturnsInsertedProcessStreamId()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            ProcessStreamRepo repo = new ProcessStreamRepo(new TestDbConnectionFactory(connection));
            ProcessStreamDto processStream = CreateProcessStreamDto(Guid.NewGuid(), Guid.NewGuid(), "H01");
            Guid insertedId = Guid.NewGuid();

            command.ScalarResult = insertedId;

            Guid result = repo.AddProcessStream(processStream);

            Assert.That(command.ExecuteScalarWasCalled, Is.True);
            Assert.That(result, Is.EqualTo(insertedId));
        }
        #endregion      // AddProcessStream_ReturnsInsertedProcessStreamId()

        #region UpdateProcessStream_StoresProcessStream()
        /// <summary>
        /// Verifies that UpdateProcessStream forwards the process stream to the repository.
        /// </summary>
        [Test]
        public void UpdateProcessStream_StoresProcessStream()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            ProcessStreamRepo repo = new ProcessStreamRepo(new TestDbConnectionFactory(connection));
            ProcessStreamDto processStream = CreateProcessStreamDto(Guid.NewGuid(), Guid.NewGuid(), "H01");

            repo.UpdateProcessStream(processStream);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(processStream.Id));
        }
        #endregion      // UpdateProcessStream_StoresProcessStream()

        #region DeleteProcessStream_DeletesProcessStreamById()
        /// <summary>
        /// Verifies that DeleteProcessStream forwards the process stream identifier to the repository.
        /// </summary>
        [Test]
        public void DeleteProcessStream_DeletesProcessStreamById()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            ProcessStreamRepo repo = new ProcessStreamRepo(new TestDbConnectionFactory(connection));
            Guid processStreamId = Guid.NewGuid();

            repo.DeleteProcessStream(processStreamId);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(processStreamId));
        }
        #endregion      // DeleteProcessStream_DeletesProcessStreamById()
    }
    #endregion      // public class ProcessStreamRepoTests
}
#endregion      // namespace HenStudio.Tests.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
