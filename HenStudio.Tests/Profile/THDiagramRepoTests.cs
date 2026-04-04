#region HEADER
//#####################################################################################################################
//########################################  T H D i a g r a m R e p o T e s t s . c s  ################################
//#####################################################################################################################
//  FILENAME:  THDiagramRepoTests.cs
//  NAMESPACE: HenStudio.Tests.Profile
//  CLASS(S):  THDiagramRepoTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for the THDiagramRepo class.
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
    #region public class THDiagramRepoTests
    /// <summary>
    /// Unit tests for the THDiagramRepo class.
    /// </summary>
    [TestFixture]
    public class THDiagramRepoTests
    {
        #region PRIVATE METHODS

        #region CreateTHDiagramDto()
        /// <summary>
        /// Creates a T-H diagram DTO for unit testing.
        /// </summary>
        private static THDiagramDto CreateTHDiagramDto(Guid id, Guid profileId, string title)
        {
            return new THDiagramDto
            {
                Id = id,
                ProfileId = profileId,
                DiagramType = "Hot",
                Title = title,
                XAxisLabel = "Enthalpy",
                YAxisLabel = "Temperature"
            };
        }
        #endregion      // CreateTHDiagramDto()

        #region CreateTHDiagramReader()
        /// <summary>
        /// Creates a T-H diagram data reader for unit testing.
        /// </summary>
        private static IDataReader CreateTHDiagramReader(params THDiagramDto[] thDiagrams)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(Guid));
            table.Columns.Add("ProfileId", typeof(Guid));
            table.Columns.Add("DiagramType", typeof(string));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("XAxisLabel", typeof(string));
            table.Columns.Add("YAxisLabel", typeof(string));

            foreach (THDiagramDto thDiagram in thDiagrams)
            {
                table.Rows.Add(thDiagram.Id,
                               thDiagram.ProfileId,
                               thDiagram.DiagramType,
                               thDiagram.Title,
                               thDiagram.XAxisLabel,
                               thDiagram.YAxisLabel);
            }

            return table.CreateDataReader();
        }
        #endregion      // CreateTHDiagramReader()

        #endregion      // PRIVATE METHODS

        #region THDiagramRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()
        /// <summary>
        /// Verifies that the constructor throws when the connection factory is null.
        /// </summary>
        [Test]
        public void THDiagramRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()
        {
            Assert.That(() => new THDiagramRepo(null), Throws.ArgumentNullException);
        }
        #endregion      // THDiagramRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()

        #region GetTHDiagrams_ReturnsMappedTHDiagrams()
        /// <summary>
        /// Verifies that GetTHDiagrams returns the mapped T-H diagrams.
        /// </summary>
        [Test]
        public void GetTHDiagrams_ReturnsMappedTHDiagrams()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            THDiagramRepo repo = new THDiagramRepo(new TestDbConnectionFactory(connection));
            Guid profileId = Guid.NewGuid();
            THDiagramDto thDiagram1 = CreateTHDiagramDto(Guid.NewGuid(), profileId, "Alpha");
            THDiagramDto thDiagram2 = CreateTHDiagramDto(Guid.NewGuid(), profileId, "Beta");

            command.ReaderResult = CreateTHDiagramReader(thDiagram1, thDiagram2);

            IList<THDiagramDto> result = repo.GetTHDiagrams();

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].Title, Is.EqualTo("Alpha"));
            Assert.That(result[1].Title, Is.EqualTo("Beta"));
        }
        #endregion      // GetTHDiagrams_ReturnsMappedTHDiagrams()

        #region GetTHDiagramsByProfileId_ReturnsMappedTHDiagrams()
        /// <summary>
        /// Verifies that GetTHDiagramsByProfileId returns the mapped T-H diagrams.
        /// </summary>
        [Test]
        public void GetTHDiagramsByProfileId_ReturnsMappedTHDiagrams()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            THDiagramRepo repo = new THDiagramRepo(new TestDbConnectionFactory(connection));
            Guid profileId = Guid.NewGuid();
            THDiagramDto thDiagram = CreateTHDiagramDto(Guid.NewGuid(), profileId, "Alpha");

            command.ReaderResult = CreateTHDiagramReader(thDiagram);

            IList<THDiagramDto> result = repo.GetTHDiagramsByProfileId(profileId);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@ProfileId"), Is.EqualTo(profileId));
            Assert.That(result.Count, Is.EqualTo(1));
        }
        #endregion      // GetTHDiagramsByProfileId_ReturnsMappedTHDiagrams()

        #region GetTHDiagramById_ReturnsMappedTHDiagram_WhenFound()
        /// <summary>
        /// Verifies that GetTHDiagramById returns the mapped T-H diagram when found.
        /// </summary>
        [Test]
        public void GetTHDiagramById_ReturnsMappedTHDiagram_WhenFound()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            THDiagramRepo repo = new THDiagramRepo(new TestDbConnectionFactory(connection));
            THDiagramDto thDiagram = CreateTHDiagramDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");

            command.ReaderResult = CreateTHDiagramReader(thDiagram);

            THDiagramDto result = repo.GetTHDiagramById(thDiagram.Id);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(thDiagram.Id));
            Assert.That(result.Title, Is.EqualTo("Alpha"));
        }
        #endregion      // GetTHDiagramById_ReturnsMappedTHDiagram_WhenFound()

        #region GetTHDiagramByTitle_ThrowsArgumentException_WhenTitleIsBlank()
        /// <summary>
        /// Verifies that GetTHDiagramByTitle throws when the title is blank.
        /// </summary>
        [Test]
        public void GetTHDiagramByTitle_ThrowsArgumentException_WhenTitleIsBlank()
        {
            THDiagramRepo repo = new THDiagramRepo(new TestDbConnectionFactory(new TestDbConnection(new TestDbCommand())));

            Assert.That(() => repo.GetTHDiagramByTitle(Guid.NewGuid(), " "), Throws.ArgumentException);
        }
        #endregion      // GetTHDiagramByTitle_ThrowsArgumentException_WhenTitleIsBlank()

        #region GetTHDiagramByTitle_ReturnsMappedTHDiagram_WhenFound()
        /// <summary>
        /// Verifies that GetTHDiagramByTitle returns the mapped T-H diagram when found.
        /// </summary>
        [Test]
        public void GetTHDiagramByTitle_ReturnsMappedTHDiagram_WhenFound()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            THDiagramRepo repo = new THDiagramRepo(new TestDbConnectionFactory(connection));
            THDiagramDto thDiagram = CreateTHDiagramDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");

            command.ReaderResult = CreateTHDiagramReader(thDiagram);

            THDiagramDto result = repo.GetTHDiagramByTitle(thDiagram.ProfileId, thDiagram.Title);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@ProfileId"), Is.EqualTo(thDiagram.ProfileId));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Title"), Is.EqualTo("Alpha"));
            Assert.That(result.Title, Is.EqualTo("Alpha"));
        }
        #endregion      // GetTHDiagramByTitle_ReturnsMappedTHDiagram_WhenFound()

        #region AddTHDiagram_ReturnsInsertedTHDiagramId()
        /// <summary>
        /// Verifies that AddTHDiagram returns the inserted T-H diagram identifier.
        /// </summary>
        [Test]
        public void AddTHDiagram_ReturnsInsertedTHDiagramId()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            THDiagramRepo repo = new THDiagramRepo(new TestDbConnectionFactory(connection));
            THDiagramDto thDiagram = CreateTHDiagramDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");
            Guid insertedId = Guid.NewGuid();

            command.ScalarResult = insertedId;

            Guid result = repo.AddTHDiagram(thDiagram);

            Assert.That(command.ExecuteScalarWasCalled, Is.True);
            Assert.That(result, Is.EqualTo(insertedId));
        }
        #endregion      // AddTHDiagram_ReturnsInsertedTHDiagramId()

        #region UpdateTHDiagram_StoresTHDiagram()
        /// <summary>
        /// Verifies that UpdateTHDiagram forwards the T-H diagram to the repository.
        /// </summary>
        [Test]
        public void UpdateTHDiagram_StoresTHDiagram()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            THDiagramRepo repo = new THDiagramRepo(new TestDbConnectionFactory(connection));
            THDiagramDto thDiagram = CreateTHDiagramDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");

            repo.UpdateTHDiagram(thDiagram);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(thDiagram.Id));
        }
        #endregion      // UpdateTHDiagram_StoresTHDiagram()

        #region DeleteTHDiagram_DeletesTHDiagramById()
        /// <summary>
        /// Verifies that DeleteTHDiagram forwards the T-H diagram identifier to the repository.
        /// </summary>
        [Test]
        public void DeleteTHDiagram_DeletesTHDiagramById()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            THDiagramRepo repo = new THDiagramRepo(new TestDbConnectionFactory(connection));
            Guid thDiagramId = Guid.NewGuid();

            repo.DeleteTHDiagram(thDiagramId);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(thDiagramId));
        }
        #endregion      // DeleteTHDiagram_DeletesTHDiagramById()
    }
    #endregion      // public class THDiagramRepoTests
}
#endregion      // namespace HenStudio.Tests.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
