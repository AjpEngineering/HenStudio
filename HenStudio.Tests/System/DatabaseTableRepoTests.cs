#region HEADER
//#####################################################################################################################
//#####################################  D a t a b a s e T a b l e R e p o T e s t s . c s  ###########################
//#####################################################################################################################
//  FILENAME:  DatabaseTableRepoTests.cs
//  NAMESPACE: HenStudio.Tests.System
//  CLASS(S):  DatabaseTableRepoTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for the DatabaseTableRepo class.
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

using System;
using System.Collections.Generic;
using System.Data;

using NUnit.Framework;
#endregion      // REFERENCES

#region namespace HenStudio.Tests.System
namespace HenStudio.Tests.System
{
    #region public class DatabaseTableRepoTests
    /// <summary>
    /// Unit tests for the <see cref="DatabaseTableRepo"/> class.
    /// </summary>
    [TestFixture]
    public class DatabaseTableRepoTests
    {
        #region PRIVATE METHODS

        #region CreateReader()
        /// <summary>
        /// Creates a database table data reader for unit testing.
        /// </summary>
        /// <param name="tables">The tables to expose through the reader.</param>
        /// <returns>An <see cref="IDataReader"/> over the supplied table rows.</returns>
        private static IDataReader CreateReader(params DatabaseTableDto[] tables)
        {
            DataTable table = new DataTable();

            table.Columns.Add("TABLE_SCHEMA", typeof(string));
            table.Columns.Add("TABLE_NAME", typeof(string));

            foreach (DatabaseTableDto databaseTable in tables)
            {
                table.Rows.Add(
                    (object)databaseTable.SchemaName ?? DBNull.Value,
                    (object)databaseTable.TableName ?? DBNull.Value);
            }

            return table.CreateDataReader();
        }
        #endregion      // CreateReader()

        #endregion      // PRIVATE METHODS

        #region DatabaseTableRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()
        /// <summary>
        /// Verifies that the constructor throws when the connection factory is null.
        /// </summary>
        [Test]
        public void DatabaseTableRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()
        {
            Assert.That(() => new DatabaseTableRepo(null), Throws.ArgumentNullException);
        }
        #endregion      // DatabaseTableRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()

        #region GetDatabaseTables_ReturnsMappedTables()
        /// <summary>
        /// Verifies that GetDatabaseTables returns the mapped database tables.
        /// </summary>
        [Test]
        public void GetDatabaseTables_ReturnsMappedTables()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            DatabaseTableRepo repo = new DatabaseTableRepo(new TestDbConnectionFactory(connection));
            DatabaseTableDto table1 = new DatabaseTableDto { SchemaName = "dbo", TableName = "Project" };
            DatabaseTableDto table2 = new DatabaseTableDto { SchemaName = "cfg", TableName = "GlobalSettings" };

            command.ReaderResult = CreateReader(table1, table2);

            IList<DatabaseTableDto> result = repo.GetDatabaseTables();

            Assert.That(connection.OpenWasCalled, Is.True);
            Assert.That(command.ExecuteReaderWasCalled, Is.True);
            Assert.That(command.CommandType, Is.EqualTo(CommandType.Text));
            Assert.That(command.CommandText, Does.Contain("INFORMATION_SCHEMA.TABLES"));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].SchemaName, Is.EqualTo("dbo"));
            Assert.That(result[0].TableName, Is.EqualTo("Project"));
            Assert.That(result[1].SchemaName, Is.EqualTo("cfg"));
            Assert.That(result[1].TableName, Is.EqualTo("GlobalSettings"));
        }
        #endregion      // GetDatabaseTables_ReturnsMappedTables()

        #region GetDatabaseTables_ReturnsEmptyStrings_WhenColumnsAreDBNull()
        /// <summary>
        /// Verifies that GetDatabaseTables maps DBNull string columns to empty strings.
        /// </summary>
        [Test]
        public void GetDatabaseTables_ReturnsEmptyStrings_WhenColumnsAreDBNull()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            DatabaseTableRepo repo = new DatabaseTableRepo(new TestDbConnectionFactory(connection));
            DatabaseTableDto table = new DatabaseTableDto { SchemaName = null, TableName = null };

            command.ReaderResult = CreateReader(table);

            IList<DatabaseTableDto> result = repo.GetDatabaseTables();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].SchemaName, Is.EqualTo(String.Empty));
            Assert.That(result[0].TableName, Is.EqualTo(String.Empty));
        }
        #endregion      // GetDatabaseTables_ReturnsEmptyStrings_WhenColumnsAreDBNull()

        #region GetDatabaseTables_ReturnsEmptyList_WhenNoRowsExist()
        /// <summary>
        /// Verifies that GetDatabaseTables returns an empty list when no rows exist.
        /// </summary>
        [Test]
        public void GetDatabaseTables_ReturnsEmptyList_WhenNoRowsExist()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            DatabaseTableRepo repo = new DatabaseTableRepo(new TestDbConnectionFactory(connection));

            command.ReaderResult = CreateReader();

            IList<DatabaseTableDto> result = repo.GetDatabaseTables();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(0));
        }
        #endregion      // GetDatabaseTables_ReturnsEmptyList_WhenNoRowsExist()
    }
    #endregion      // public class DatabaseTableRepoTests
}
#endregion      // namespace HenStudio.Tests.System

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
