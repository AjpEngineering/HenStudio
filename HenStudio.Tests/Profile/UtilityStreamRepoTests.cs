#region HEADER
//#####################################################################################################################
//####################################  U t i l i t y S t r e a m R e p o T e s t s . c s  ############################
//#####################################################################################################################
//  FILENAME:  UtilityStreamRepoTests.cs
//  NAMESPACE: HenStudio.Tests.Profile
//  CLASS(S):  UtilityStreamRepoTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for the UtilityStreamRepo class.
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
    #region public class UtilityStreamRepoTests
    /// <summary>
    /// Unit tests for the UtilityStreamRepo class.
    /// </summary>
    [TestFixture]
    public class UtilityStreamRepoTests
    {
        #region PRIVATE METHODS

        #region CreateUtilityStreamDto()
        /// <summary>
        /// Creates a utility stream DTO for unit testing.
        /// </summary>
        private static UtilityStreamDto CreateUtilityStreamDto(Guid id, Guid profileId, string streamId)
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
        #endregion      // CreateUtilityStreamDto()

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

        #endregion      // PRIVATE METHODS

        #region UtilityStreamRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()
        /// <summary>
        /// Verifies that the constructor throws when the connection factory is null.
        /// </summary>
        [Test]
        public void UtilityStreamRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()
        {
            Assert.That(() => new UtilityStreamRepo(null), Throws.ArgumentNullException);
        }
        #endregion      // UtilityStreamRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()

        #region GetUtilityStreams_ReturnsMappedUtilityStreams()
        /// <summary>
        /// Verifies that GetUtilityStreams returns the mapped utility streams.
        /// </summary>
        [Test]
        public void GetUtilityStreams_ReturnsMappedUtilityStreams()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            UtilityStreamRepo repo = new UtilityStreamRepo(new TestDbConnectionFactory(connection));
            Guid profileId = Guid.NewGuid();
            UtilityStreamDto utilityStream1 = CreateUtilityStreamDto(Guid.NewGuid(), profileId, "CW01");
            UtilityStreamDto utilityStream2 = CreateUtilityStreamDto(Guid.NewGuid(), profileId, "CW02");

            command.ReaderResult = CreateUtilityStreamReader(utilityStream1, utilityStream2);

            IList<UtilityStreamDto> result = repo.GetUtilityStreams();

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].StreamId, Is.EqualTo("CW01"));
            Assert.That(result[1].StreamId, Is.EqualTo("CW02"));
        }
        #endregion      // GetUtilityStreams_ReturnsMappedUtilityStreams()

        #region GetUtilityStreamsByProfileId_ReturnsMappedUtilityStreams()
        /// <summary>
        /// Verifies that GetUtilityStreamsByProfileId returns the mapped utility streams.
        /// </summary>
        [Test]
        public void GetUtilityStreamsByProfileId_ReturnsMappedUtilityStreams()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            UtilityStreamRepo repo = new UtilityStreamRepo(new TestDbConnectionFactory(connection));
            Guid profileId = Guid.NewGuid();
            UtilityStreamDto utilityStream = CreateUtilityStreamDto(Guid.NewGuid(), profileId, "CW01");

            command.ReaderResult = CreateUtilityStreamReader(utilityStream);

            IList<UtilityStreamDto> result = repo.GetUtilityStreamsByProfileId(profileId);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@ProfileId"), Is.EqualTo(profileId));
            Assert.That(result.Count, Is.EqualTo(1));
        }
        #endregion      // GetUtilityStreamsByProfileId_ReturnsMappedUtilityStreams()

        #region GetUtilityStreamById_ReturnsMappedUtilityStream_WhenFound()
        /// <summary>
        /// Verifies that GetUtilityStreamById returns the mapped utility stream when found.
        /// </summary>
        [Test]
        public void GetUtilityStreamById_ReturnsMappedUtilityStream_WhenFound()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            UtilityStreamRepo repo = new UtilityStreamRepo(new TestDbConnectionFactory(connection));
            UtilityStreamDto utilityStream = CreateUtilityStreamDto(Guid.NewGuid(), Guid.NewGuid(), "CW01");

            command.ReaderResult = CreateUtilityStreamReader(utilityStream);

            UtilityStreamDto result = repo.GetUtilityStreamById(utilityStream.Id);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(utilityStream.Id));
            Assert.That(result.StreamId, Is.EqualTo("CW01"));
        }
        #endregion      // GetUtilityStreamById_ReturnsMappedUtilityStream_WhenFound()

        #region GetUtilityStreamByStreamId_ThrowsArgumentException_WhenStreamIdIsBlank()
        /// <summary>
        /// Verifies that GetUtilityStreamByStreamId throws when the stream identifier is blank.
        /// </summary>
        [Test]
        public void GetUtilityStreamByStreamId_ThrowsArgumentException_WhenStreamIdIsBlank()
        {
            UtilityStreamRepo repo = new UtilityStreamRepo(new TestDbConnectionFactory(new TestDbConnection(new TestDbCommand())));

            Assert.That(() => repo.GetUtilityStreamByStreamId(Guid.NewGuid(), " "), Throws.ArgumentException);
        }
        #endregion      // GetUtilityStreamByStreamId_ThrowsArgumentException_WhenStreamIdIsBlank()

        #region GetUtilityStreamByStreamId_ReturnsMappedUtilityStream_WhenFound()
        /// <summary>
        /// Verifies that GetUtilityStreamByStreamId returns the mapped utility stream when found.
        /// </summary>
        [Test]
        public void GetUtilityStreamByStreamId_ReturnsMappedUtilityStream_WhenFound()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            UtilityStreamRepo repo = new UtilityStreamRepo(new TestDbConnectionFactory(connection));
            UtilityStreamDto utilityStream = CreateUtilityStreamDto(Guid.NewGuid(), Guid.NewGuid(), "CW01");

            command.ReaderResult = CreateUtilityStreamReader(utilityStream);

            UtilityStreamDto result = repo.GetUtilityStreamByStreamId(utilityStream.ProfileId, utilityStream.StreamId);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@ProfileId"), Is.EqualTo(utilityStream.ProfileId));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@StreamId"), Is.EqualTo("CW01"));
            Assert.That(result.StreamId, Is.EqualTo("CW01"));
        }
        #endregion      // GetUtilityStreamByStreamId_ReturnsMappedUtilityStream_WhenFound()

        #region AddUtilityStream_ReturnsInsertedUtilityStreamId()
        /// <summary>
        /// Verifies that AddUtilityStream returns the inserted utility stream identifier.
        /// </summary>
        [Test]
        public void AddUtilityStream_ReturnsInsertedUtilityStreamId()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            UtilityStreamRepo repo = new UtilityStreamRepo(new TestDbConnectionFactory(connection));
            UtilityStreamDto utilityStream = CreateUtilityStreamDto(Guid.NewGuid(), Guid.NewGuid(), "CW01");
            Guid insertedId = Guid.NewGuid();

            command.ScalarResult = insertedId;

            Guid result = repo.AddUtilityStream(utilityStream);

            Assert.That(command.ExecuteScalarWasCalled, Is.True);
            Assert.That(result, Is.EqualTo(insertedId));
        }
        #endregion      // AddUtilityStream_ReturnsInsertedUtilityStreamId()

        #region UpdateUtilityStream_StoresUtilityStream()
        /// <summary>
        /// Verifies that UpdateUtilityStream forwards the utility stream to the repository.
        /// </summary>
        [Test]
        public void UpdateUtilityStream_StoresUtilityStream()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            UtilityStreamRepo repo = new UtilityStreamRepo(new TestDbConnectionFactory(connection));
            UtilityStreamDto utilityStream = CreateUtilityStreamDto(Guid.NewGuid(), Guid.NewGuid(), "CW01");

            repo.UpdateUtilityStream(utilityStream);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(utilityStream.Id));
        }
        #endregion      // UpdateUtilityStream_StoresUtilityStream()

        #region DeleteUtilityStream_DeletesUtilityStreamById()
        /// <summary>
        /// Verifies that DeleteUtilityStream forwards the utility stream identifier to the repository.
        /// </summary>
        [Test]
        public void DeleteUtilityStream_DeletesUtilityStreamById()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            UtilityStreamRepo repo = new UtilityStreamRepo(new TestDbConnectionFactory(connection));
            Guid utilityStreamId = Guid.NewGuid();

            repo.DeleteUtilityStream(utilityStreamId);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(utilityStreamId));
        }
        #endregion      // DeleteUtilityStream_DeletesUtilityStreamById()
    }
    #endregion      // public class UtilityStreamRepoTests
}
#endregion      // namespace HenStudio.Tests.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
