#region HEADER
//#####################################################################################################################
//###################################  T H D i a g r a m V i e w M o d e l T e s t s . c s  ###########################
//#####################################################################################################################
//  FILENAME:  THDiagramViewModelTests.cs
//  NAMESPACE: HenStudio.Tests.Profile
//  CLASS(S):  THDiagramViewModelTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for the THDiagramViewModel class.
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
    #region public class THDiagramViewModelTests
    /// <summary>
    /// Unit tests for the THDiagramViewModel class.
    /// </summary>
    [TestFixture]
    public class THDiagramViewModelTests
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

        #region CreateTHDiagramViewModel()
        /// <summary>
        /// Creates a T-H diagram view model and its backing fake ADO.NET objects for unit testing.
        /// </summary>
        private static THDiagramViewModel CreateTHDiagramViewModel(out TestDbCommand command,
                                                                   out TestDbConnection connection)
        {
            command = new TestDbCommand();
            connection = new TestDbConnection(command);

            THDiagramRepo thDiagramRepo = new THDiagramRepo(new TestDbConnectionFactory(connection));

            return new THDiagramViewModel(thDiagramRepo,
                                          ProfileViewModelTestHelpers.CreateExternalUnits(),
                                          ProfileViewModelTestHelpers.CreateInternalUnits());
        }
        #endregion      // CreateTHDiagramViewModel()

        #endregion      // PRIVATE METHODS

        #region THDiagramViewModel_CTOR_SetsProperties()
        /// <summary>
        /// Verifies that the constructor sets the repository and units properties.
        /// </summary>
        [Test]
        public void THDiagramViewModel_CTOR_SetsProperties()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            THDiagramRepo thDiagramRepo = new THDiagramRepo(new TestDbConnectionFactory(connection));
            HenProjectUnits externalUnits = ProfileViewModelTestHelpers.CreateExternalUnits();
            HenProjectUnits internalUnits = ProfileViewModelTestHelpers.CreateInternalUnits();

            THDiagramViewModel viewModel = new THDiagramViewModel(thDiagramRepo, externalUnits, internalUnits);

            Assert.That(viewModel.THDiagramRepoObj, Is.SameAs(thDiagramRepo));
            Assert.That(viewModel.ExternalUnitsObj, Is.SameAs(externalUnits));
            Assert.That(viewModel.InternalUnitsObj, Is.SameAs(internalUnits));
        }
        #endregion      // THDiagramViewModel_CTOR_SetsProperties()

        #region GetTHDiagrams_ReturnsTHDiagrams()
        /// <summary>
        /// Verifies that GetTHDiagrams returns the T-H diagrams from the repository.
        /// </summary>
        [Test]
        public void GetTHDiagrams_ReturnsTHDiagrams()
        {
            TestDbCommand command;
            TestDbConnection connection;
            THDiagramViewModel viewModel = CreateTHDiagramViewModel(out command, out connection);
            Guid profileId = Guid.NewGuid();
            THDiagramDto thDiagram1 = CreateTHDiagramDto(Guid.NewGuid(), profileId, "Alpha");
            THDiagramDto thDiagram2 = CreateTHDiagramDto(Guid.NewGuid(), profileId, "Beta");

            command.ReaderResult = CreateTHDiagramReader(thDiagram1, thDiagram2);

            IList<THDiagramDto> result = viewModel.GetTHDiagrams();

            Assert.That(connection.OpenWasCalled, Is.True);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].Title, Is.EqualTo("Alpha"));
            Assert.That(result[1].Title, Is.EqualTo("Beta"));
        }
        #endregion      // GetTHDiagrams_ReturnsTHDiagrams()

        #region GetTHDiagramsByProfileId_ReturnsTHDiagrams()
        /// <summary>
        /// Verifies that GetTHDiagramsByProfileId returns the matching T-H diagrams from the repository.
        /// </summary>
        [Test]
        public void GetTHDiagramsByProfileId_ReturnsTHDiagrams()
        {
            TestDbCommand command;
            TestDbConnection connection;
            THDiagramViewModel viewModel = CreateTHDiagramViewModel(out command, out connection);
            Guid profileId = Guid.NewGuid();
            THDiagramDto thDiagram = CreateTHDiagramDto(Guid.NewGuid(), profileId, "Alpha");

            command.ReaderResult = CreateTHDiagramReader(thDiagram);

            IList<THDiagramDto> result = viewModel.GetTHDiagramsByProfileId(profileId);

            Assert.That(command.ExecuteReaderWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@ProfileId"), Is.EqualTo(profileId));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].ProfileId, Is.EqualTo(profileId));
        }
        #endregion      // GetTHDiagramsByProfileId_ReturnsTHDiagrams()

        #region GetTHDiagramById_ReturnsTHDiagram()
        /// <summary>
        /// Verifies that GetTHDiagramById returns the matching T-H diagram from the repository.
        /// </summary>
        [Test]
        public void GetTHDiagramById_ReturnsTHDiagram()
        {
            TestDbCommand command;
            TestDbConnection connection;
            THDiagramViewModel viewModel = CreateTHDiagramViewModel(out command, out connection);
            THDiagramDto thDiagram = CreateTHDiagramDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");

            command.ReaderResult = CreateTHDiagramReader(thDiagram);

            THDiagramDto result = viewModel.GetTHDiagramById(thDiagram.Id);

            Assert.That(command.ExecuteReaderWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(thDiagram.Id));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(thDiagram.Id));
            Assert.That(result.Title, Is.EqualTo("Alpha"));
        }
        #endregion      // GetTHDiagramById_ReturnsTHDiagram()

        #region GetTHDiagramByTitle_ReturnsTHDiagram()
        /// <summary>
        /// Verifies that GetTHDiagramByTitle returns the matching T-H diagram from the repository.
        /// </summary>
        [Test]
        public void GetTHDiagramByTitle_ReturnsTHDiagram()
        {
            TestDbCommand command;
            TestDbConnection connection;
            THDiagramViewModel viewModel = CreateTHDiagramViewModel(out command, out connection);
            THDiagramDto thDiagram = CreateTHDiagramDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");

            command.ReaderResult = CreateTHDiagramReader(thDiagram);

            THDiagramDto result = viewModel.GetTHDiagramByTitle(thDiagram.ProfileId, thDiagram.Title);

            Assert.That(command.ExecuteReaderWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@ProfileId"), Is.EqualTo(thDiagram.ProfileId));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Title"), Is.EqualTo("Alpha"));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Title, Is.EqualTo("Alpha"));
        }
        #endregion      // GetTHDiagramByTitle_ReturnsTHDiagram()

        #region AddTHDiagram_ReturnsInsertedTHDiagramId()
        /// <summary>
        /// Verifies that AddTHDiagram returns the inserted T-H diagram identifier.
        /// </summary>
        [Test]
        public void AddTHDiagram_ReturnsInsertedTHDiagramId()
        {
            TestDbCommand command;
            TestDbConnection connection;
            THDiagramViewModel viewModel = CreateTHDiagramViewModel(out command, out connection);
            THDiagramDto thDiagram = CreateTHDiagramDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");
            Guid insertedId = Guid.NewGuid();

            command.ScalarResult = insertedId;

            Guid result = viewModel.AddTHDiagram(thDiagram);

            Assert.That(command.ExecuteScalarWasCalled, Is.True);
            Assert.That(result, Is.EqualTo(insertedId));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Title"), Is.EqualTo("Alpha"));
        }
        #endregion      // AddTHDiagram_ReturnsInsertedTHDiagramId()

        #region UpdateTHDiagram_StoresTHDiagram()
        /// <summary>
        /// Verifies that UpdateTHDiagram forwards the T-H diagram to the repository.
        /// </summary>
        [Test]
        public void UpdateTHDiagram_StoresTHDiagram()
        {
            TestDbCommand command;
            TestDbConnection connection;
            THDiagramViewModel viewModel = CreateTHDiagramViewModel(out command, out connection);
            THDiagramDto thDiagram = CreateTHDiagramDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");
            command.NonQueryResult = 1;

            viewModel.UpdateTHDiagram(thDiagram);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(thDiagram.Id));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Title"), Is.EqualTo("Alpha"));
        }
        #endregion      // UpdateTHDiagram_StoresTHDiagram()

        #region DeleteTHDiagram_DeletesTHDiagramById()
        /// <summary>
        /// Verifies that DeleteTHDiagram forwards the T-H diagram identifier to the repository.
        /// </summary>
        [Test]
        public void DeleteTHDiagram_DeletesTHDiagramById()
        {
            TestDbCommand command;
            TestDbConnection connection;
            THDiagramViewModel viewModel = CreateTHDiagramViewModel(out command, out connection);
            Guid thDiagramId = Guid.NewGuid();
            command.NonQueryResult = 1;

            viewModel.DeleteTHDiagram(thDiagramId);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(thDiagramId));
        }
        #endregion      // DeleteTHDiagram_DeletesTHDiagramById()
    }
    #endregion      // public class THDiagramViewModelTests
}
#endregion      // namespace HenStudio.Tests.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
