#region HEADER
//#####################################################################################################################
//###############################  T H D i a g r a m P o i n t V i e w M o d e l T e s t s . c s  #####################
//#####################################################################################################################
//  FILENAME:  THDiagramPointViewModelTests.cs
//  NAMESPACE: HenStudio.Tests.Profile
//  CLASS(S):  THDiagramPointViewModelTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for the THDiagramPointViewModel class.
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
    #region public class THDiagramPointViewModelTests
    /// <summary>
    /// Unit tests for the THDiagramPointViewModel class.
    /// </summary>
    [TestFixture]
    public class THDiagramPointViewModelTests
    {
        #region PRIVATE METHODS

        #region CreateTHDiagramPointDto()
        /// <summary>
        /// Creates a T-H diagram point DTO for unit testing.
        /// </summary>
        private static THDiagramPointDto CreateTHDiagramPointDto(Guid id, Guid thDiagramId, int pointSequence)
        {
            return new THDiagramPointDto
            {
                Id = id,
                THDiagramId = thDiagramId,
                PointSequence = pointSequence,
                EnthalpyValue = 100.0,
                TemperatureValue = 200.0
            };
        }
        #endregion      // CreateTHDiagramPointDto()

        #region CreateTHDiagramPointReader()
        /// <summary>
        /// Creates a T-H diagram point data reader for unit testing.
        /// </summary>
        private static IDataReader CreateTHDiagramPointReader(params THDiagramPointDto[] thDiagramPoints)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(Guid));
            table.Columns.Add("THDiagramId", typeof(Guid));
            table.Columns.Add("PointSequence", typeof(int));
            table.Columns.Add("EnthalpyValue", typeof(double));
            table.Columns.Add("TemperatureValue", typeof(double));

            foreach (THDiagramPointDto thDiagramPoint in thDiagramPoints)
            {
                table.Rows.Add(thDiagramPoint.Id,
                               thDiagramPoint.THDiagramId,
                               thDiagramPoint.PointSequence,
                               thDiagramPoint.EnthalpyValue,
                               thDiagramPoint.TemperatureValue);
            }

            return table.CreateDataReader();
        }
        #endregion      // CreateTHDiagramPointReader()

        #region CreateTHDiagramPointViewModel()
        /// <summary>
        /// Creates a T-H diagram point view model and its backing fake ADO.NET objects for unit testing.
        /// </summary>
        private static THDiagramPointViewModel CreateTHDiagramPointViewModel(out TestDbCommand command,
                                                                             out TestDbConnection connection)
        {
            command = new TestDbCommand();
            connection = new TestDbConnection(command);

            THDiagramPointRepo thDiagramPointRepo = new THDiagramPointRepo(new TestDbConnectionFactory(connection));

            return new THDiagramPointViewModel(thDiagramPointRepo,
                                               ProfileViewModelTestHelpers.CreateExternalUnits(),
                                               ProfileViewModelTestHelpers.CreateInternalUnits());
        }
        #endregion      // CreateTHDiagramPointViewModel()

        #endregion      // PRIVATE METHODS

        #region THDiagramPointViewModel_CTOR_SetsProperties()
        /// <summary>
        /// Verifies that the constructor sets the repository and units properties.
        /// </summary>
        [Test]
        public void THDiagramPointViewModel_CTOR_SetsProperties()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            THDiagramPointRepo thDiagramPointRepo = new THDiagramPointRepo(new TestDbConnectionFactory(connection));
            HenProjectUnits externalUnits = ProfileViewModelTestHelpers.CreateExternalUnits();
            HenProjectUnits internalUnits = ProfileViewModelTestHelpers.CreateInternalUnits();

            THDiagramPointViewModel viewModel = new THDiagramPointViewModel(thDiagramPointRepo, externalUnits, internalUnits);

            Assert.That(viewModel.THDiagramPointRepoObj, Is.SameAs(thDiagramPointRepo));
            Assert.That(viewModel.ExternalUnitsObj, Is.SameAs(externalUnits));
            Assert.That(viewModel.InternalUnitsObj, Is.SameAs(internalUnits));
        }
        #endregion      // THDiagramPointViewModel_CTOR_SetsProperties()

        #region GetTHDiagramPoints_ReturnsTHDiagramPoints()
        /// <summary>
        /// Verifies that GetTHDiagramPoints returns the T-H diagram points from the repository.
        /// </summary>
        [Test]
        public void GetTHDiagramPoints_ReturnsTHDiagramPoints()
        {
            TestDbCommand command;
            TestDbConnection connection;
            THDiagramPointViewModel viewModel = CreateTHDiagramPointViewModel(out command, out connection);
            Guid thDiagramId = Guid.NewGuid();
            THDiagramPointDto thDiagramPoint1 = CreateTHDiagramPointDto(Guid.NewGuid(), thDiagramId, 1);
            THDiagramPointDto thDiagramPoint2 = CreateTHDiagramPointDto(Guid.NewGuid(), thDiagramId, 2);

            command.ReaderResult = CreateTHDiagramPointReader(thDiagramPoint1, thDiagramPoint2);

            IList<THDiagramPointDto> result = viewModel.GetTHDiagramPoints();

            Assert.That(connection.OpenWasCalled, Is.True);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].PointSequence, Is.EqualTo(1));
            Assert.That(result[1].PointSequence, Is.EqualTo(2));
        }
        #endregion      // GetTHDiagramPoints_ReturnsTHDiagramPoints()

        #region GetTHDiagramPointsByTHDiagramId_ReturnsTHDiagramPoints()
        /// <summary>
        /// Verifies that GetTHDiagramPointsByTHDiagramId returns the matching T-H diagram points from the repository.
        /// </summary>
        [Test]
        public void GetTHDiagramPointsByTHDiagramId_ReturnsTHDiagramPoints()
        {
            TestDbCommand command;
            TestDbConnection connection;
            THDiagramPointViewModel viewModel = CreateTHDiagramPointViewModel(out command, out connection);
            Guid thDiagramId = Guid.NewGuid();
            THDiagramPointDto thDiagramPoint = CreateTHDiagramPointDto(Guid.NewGuid(), thDiagramId, 1);

            command.ReaderResult = CreateTHDiagramPointReader(thDiagramPoint);

            IList<THDiagramPointDto> result = viewModel.GetTHDiagramPointsByTHDiagramId(thDiagramId);

            Assert.That(command.ExecuteReaderWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@THDiagramId"), Is.EqualTo(thDiagramId));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].THDiagramId, Is.EqualTo(thDiagramId));
        }
        #endregion      // GetTHDiagramPointsByTHDiagramId_ReturnsTHDiagramPoints()

        #region GetTHDiagramPointById_ReturnsTHDiagramPoint()
        /// <summary>
        /// Verifies that GetTHDiagramPointById returns the matching T-H diagram point from the repository.
        /// </summary>
        [Test]
        public void GetTHDiagramPointById_ReturnsTHDiagramPoint()
        {
            TestDbCommand command;
            TestDbConnection connection;
            THDiagramPointViewModel viewModel = CreateTHDiagramPointViewModel(out command, out connection);
            THDiagramPointDto thDiagramPoint = CreateTHDiagramPointDto(Guid.NewGuid(), Guid.NewGuid(), 1);

            command.ReaderResult = CreateTHDiagramPointReader(thDiagramPoint);

            THDiagramPointDto result = viewModel.GetTHDiagramPointById(thDiagramPoint.Id);

            Assert.That(command.ExecuteReaderWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(thDiagramPoint.Id));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(thDiagramPoint.Id));
            Assert.That(result.PointSequence, Is.EqualTo(1));
        }
        #endregion      // GetTHDiagramPointById_ReturnsTHDiagramPoint()

        #region GetTHDiagramPointByPointSequence_ReturnsTHDiagramPoint()
        /// <summary>
        /// Verifies that GetTHDiagramPointByPointSequence returns the matching T-H diagram point from the repository.
        /// </summary>
        [Test]
        public void GetTHDiagramPointByPointSequence_ReturnsTHDiagramPoint()
        {
            TestDbCommand command;
            TestDbConnection connection;
            THDiagramPointViewModel viewModel = CreateTHDiagramPointViewModel(out command, out connection);
            THDiagramPointDto thDiagramPoint = CreateTHDiagramPointDto(Guid.NewGuid(), Guid.NewGuid(), 1);

            command.ReaderResult = CreateTHDiagramPointReader(thDiagramPoint);

            THDiagramPointDto result = viewModel.GetTHDiagramPointByPointSequence(thDiagramPoint.THDiagramId, thDiagramPoint.PointSequence);

            Assert.That(command.ExecuteReaderWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@THDiagramId"), Is.EqualTo(thDiagramPoint.THDiagramId));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@PointSequence"), Is.EqualTo(1));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.PointSequence, Is.EqualTo(1));
        }
        #endregion      // GetTHDiagramPointByPointSequence_ReturnsTHDiagramPoint()

        #region AddTHDiagramPoint_ReturnsInsertedTHDiagramPointId()
        /// <summary>
        /// Verifies that AddTHDiagramPoint returns the inserted T-H diagram point identifier.
        /// </summary>
        [Test]
        public void AddTHDiagramPoint_ReturnsInsertedTHDiagramPointId()
        {
            TestDbCommand command;
            TestDbConnection connection;
            THDiagramPointViewModel viewModel = CreateTHDiagramPointViewModel(out command, out connection);
            THDiagramPointDto thDiagramPoint = CreateTHDiagramPointDto(Guid.NewGuid(), Guid.NewGuid(), 1);
            Guid insertedId = Guid.NewGuid();

            command.ScalarResult = insertedId;

            Guid result = viewModel.AddTHDiagramPoint(thDiagramPoint);

            Assert.That(command.ExecuteScalarWasCalled, Is.True);
            Assert.That(result, Is.EqualTo(insertedId));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@PointSequence"), Is.EqualTo(1));
        }
        #endregion      // AddTHDiagramPoint_ReturnsInsertedTHDiagramPointId()

        #region UpdateTHDiagramPoint_StoresTHDiagramPoint()
        /// <summary>
        /// Verifies that UpdateTHDiagramPoint forwards the T-H diagram point to the repository.
        /// </summary>
        [Test]
        public void UpdateTHDiagramPoint_StoresTHDiagramPoint()
        {
            TestDbCommand command;
            TestDbConnection connection;
            THDiagramPointViewModel viewModel = CreateTHDiagramPointViewModel(out command, out connection);
            THDiagramPointDto thDiagramPoint = CreateTHDiagramPointDto(Guid.NewGuid(), Guid.NewGuid(), 1);
            command.NonQueryResult = 1;

            viewModel.UpdateTHDiagramPoint(thDiagramPoint);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(thDiagramPoint.Id));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@PointSequence"), Is.EqualTo(1));
        }
        #endregion      // UpdateTHDiagramPoint_StoresTHDiagramPoint()

        #region DeleteTHDiagramPoint_DeletesTHDiagramPointById()
        /// <summary>
        /// Verifies that DeleteTHDiagramPoint forwards the T-H diagram point identifier to the repository.
        /// </summary>
        [Test]
        public void DeleteTHDiagramPoint_DeletesTHDiagramPointById()
        {
            TestDbCommand command;
            TestDbConnection connection;
            THDiagramPointViewModel viewModel = CreateTHDiagramPointViewModel(out command, out connection);
            Guid thDiagramPointId = Guid.NewGuid();
            command.NonQueryResult = 1;

            viewModel.DeleteTHDiagramPoint(thDiagramPointId);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(thDiagramPointId));
        }
        #endregion      // DeleteTHDiagramPoint_DeletesTHDiagramPointById()
    }
    #endregion      // public class THDiagramPointViewModelTests
}
#endregion      // namespace HenStudio.Tests.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
