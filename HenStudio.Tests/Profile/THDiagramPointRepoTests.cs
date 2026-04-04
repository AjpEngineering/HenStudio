#region HEADER
//#####################################################################################################################
//####################################  T H D i a g r a m P o i n t R e p o T e s t s . c s  ##########################
//#####################################################################################################################
//  FILENAME:  THDiagramPointRepoTests.cs
//  NAMESPACE: HenStudio.Tests.Profile
//  CLASS(S):  THDiagramPointRepoTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for the THDiagramPointRepo class.
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
    #region public class THDiagramPointRepoTests
    /// <summary>
    /// Unit tests for the THDiagramPointRepo class.
    /// </summary>
    [TestFixture]
    public class THDiagramPointRepoTests
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

        #endregion      // PRIVATE METHODS

        #region THDiagramPointRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()
        /// <summary>
        /// Verifies that the constructor throws when the connection factory is null.
        /// </summary>
        [Test]
        public void THDiagramPointRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()
        {
            Assert.That(() => new THDiagramPointRepo(null), Throws.ArgumentNullException);
        }
        #endregion      // THDiagramPointRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()

        #region GetTHDiagramPoints_ReturnsMappedTHDiagramPoints()
        /// <summary>
        /// Verifies that GetTHDiagramPoints returns the mapped T-H diagram points.
        /// </summary>
        [Test]
        public void GetTHDiagramPoints_ReturnsMappedTHDiagramPoints()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            THDiagramPointRepo repo = new THDiagramPointRepo(new TestDbConnectionFactory(connection));
            Guid thDiagramId = Guid.NewGuid();
            THDiagramPointDto point1 = CreateTHDiagramPointDto(Guid.NewGuid(), thDiagramId, 1);
            THDiagramPointDto point2 = CreateTHDiagramPointDto(Guid.NewGuid(), thDiagramId, 2);

            command.ReaderResult = CreateTHDiagramPointReader(point1, point2);

            IList<THDiagramPointDto> result = repo.GetTHDiagramPoints();

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].PointSequence, Is.EqualTo(1));
            Assert.That(result[1].PointSequence, Is.EqualTo(2));
        }
        #endregion      // GetTHDiagramPoints_ReturnsMappedTHDiagramPoints()

        #region GetTHDiagramPointsByTHDiagramId_ReturnsMappedTHDiagramPoints()
        /// <summary>
        /// Verifies that GetTHDiagramPointsByTHDiagramId returns the mapped T-H diagram points.
        /// </summary>
        [Test]
        public void GetTHDiagramPointsByTHDiagramId_ReturnsMappedTHDiagramPoints()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            THDiagramPointRepo repo = new THDiagramPointRepo(new TestDbConnectionFactory(connection));
            Guid thDiagramId = Guid.NewGuid();
            THDiagramPointDto point = CreateTHDiagramPointDto(Guid.NewGuid(), thDiagramId, 1);

            command.ReaderResult = CreateTHDiagramPointReader(point);

            IList<THDiagramPointDto> result = repo.GetTHDiagramPointsByTHDiagramId(thDiagramId);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@THDiagramId"), Is.EqualTo(thDiagramId));
            Assert.That(result.Count, Is.EqualTo(1));
        }
        #endregion      // GetTHDiagramPointsByTHDiagramId_ReturnsMappedTHDiagramPoints()

        #region GetTHDiagramPointById_ReturnsMappedTHDiagramPoint_WhenFound()
        /// <summary>
        /// Verifies that GetTHDiagramPointById returns the mapped T-H diagram point when found.
        /// </summary>
        [Test]
        public void GetTHDiagramPointById_ReturnsMappedTHDiagramPoint_WhenFound()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            THDiagramPointRepo repo = new THDiagramPointRepo(new TestDbConnectionFactory(connection));
            THDiagramPointDto point = CreateTHDiagramPointDto(Guid.NewGuid(), Guid.NewGuid(), 1);

            command.ReaderResult = CreateTHDiagramPointReader(point);

            THDiagramPointDto result = repo.GetTHDiagramPointById(point.Id);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(point.Id));
            Assert.That(result.PointSequence, Is.EqualTo(1));
        }
        #endregion      // GetTHDiagramPointById_ReturnsMappedTHDiagramPoint_WhenFound()

        #region GetTHDiagramPointByPointSequence_ReturnsMappedTHDiagramPoint_WhenFound()
        /// <summary>
        /// Verifies that GetTHDiagramPointByPointSequence returns the mapped T-H diagram point when found.
        /// </summary>
        [Test]
        public void GetTHDiagramPointByPointSequence_ReturnsMappedTHDiagramPoint_WhenFound()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            THDiagramPointRepo repo = new THDiagramPointRepo(new TestDbConnectionFactory(connection));
            THDiagramPointDto point = CreateTHDiagramPointDto(Guid.NewGuid(), Guid.NewGuid(), 1);

            command.ReaderResult = CreateTHDiagramPointReader(point);

            THDiagramPointDto result = repo.GetTHDiagramPointByPointSequence(point.THDiagramId, point.PointSequence);

            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@THDiagramId"), Is.EqualTo(point.THDiagramId));
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@PointSequence"), Is.EqualTo(1));
            Assert.That(result.PointSequence, Is.EqualTo(1));
        }
        #endregion      // GetTHDiagramPointByPointSequence_ReturnsMappedTHDiagramPoint_WhenFound()

        #region AddTHDiagramPoint_ReturnsInsertedTHDiagramPointId()
        /// <summary>
        /// Verifies that AddTHDiagramPoint returns the inserted T-H diagram point identifier.
        /// </summary>
        [Test]
        public void AddTHDiagramPoint_ReturnsInsertedTHDiagramPointId()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            THDiagramPointRepo repo = new THDiagramPointRepo(new TestDbConnectionFactory(connection));
            THDiagramPointDto point = CreateTHDiagramPointDto(Guid.NewGuid(), Guid.NewGuid(), 1);
            Guid insertedId = Guid.NewGuid();

            command.ScalarResult = insertedId;

            Guid result = repo.AddTHDiagramPoint(point);

            Assert.That(command.ExecuteScalarWasCalled, Is.True);
            Assert.That(result, Is.EqualTo(insertedId));
        }
        #endregion      // AddTHDiagramPoint_ReturnsInsertedTHDiagramPointId()

        #region UpdateTHDiagramPoint_StoresTHDiagramPoint()
        /// <summary>
        /// Verifies that UpdateTHDiagramPoint forwards the T-H diagram point to the repository.
        /// </summary>
        [Test]
        public void UpdateTHDiagramPoint_StoresTHDiagramPoint()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            THDiagramPointRepo repo = new THDiagramPointRepo(new TestDbConnectionFactory(connection));
            THDiagramPointDto point = CreateTHDiagramPointDto(Guid.NewGuid(), Guid.NewGuid(), 1);

            repo.UpdateTHDiagramPoint(point);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(point.Id));
        }
        #endregion      // UpdateTHDiagramPoint_StoresTHDiagramPoint()

        #region DeleteTHDiagramPoint_DeletesTHDiagramPointById()
        /// <summary>
        /// Verifies that DeleteTHDiagramPoint forwards the T-H diagram point identifier to the repository.
        /// </summary>
        [Test]
        public void DeleteTHDiagramPoint_DeletesTHDiagramPointById()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            THDiagramPointRepo repo = new THDiagramPointRepo(new TestDbConnectionFactory(connection));
            Guid pointId = Guid.NewGuid();

            repo.DeleteTHDiagramPoint(pointId);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(ProfileViewModelTestHelpers.GetParameterValue(command, "@Id"), Is.EqualTo(pointId));
        }
        #endregion      // DeleteTHDiagramPoint_DeletesTHDiagramPointById()
    }
    #endregion      // public class THDiagramPointRepoTests
}
#endregion      // namespace HenStudio.Tests.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
