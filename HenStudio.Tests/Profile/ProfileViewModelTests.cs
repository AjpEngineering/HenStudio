#region HEADER
//#####################################################################################################################
//####################################  P r o f i l e V i e w M o d e l T e s t s . c s  ##############################
//#####################################################################################################################
//  FILENAME:  ProfileViewModelTests.cs
//  NAMESPACE: HenStudio.Tests.Profile
//  CLASS(S):  ProfileViewModelTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for the ProfileViewModel class.
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
using HenPersistence.Interfaces;
using HenPersistence.Repos;
using HenRepositories.Dto;
using HenViewModels;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

using NUnit.Framework;
#endregion      // REFERENCES

#region namespace HenStudio.Tests.Profile
namespace HenStudio.Tests.Profile
{
    #region public class ProfileViewModelTests
    /// <summary>
    /// Unit tests for the ProfileViewModel class.
    /// </summary>
    [TestFixture]
    public class ProfileViewModelTests
    {
        #region PRIVATE CLASSES

        #region private sealed class TestDbConnectionFactory
        /// <summary>
        /// Test database connection factory class.
        /// </summary>
        private sealed class TestDbConnectionFactory : IDbConnectionFactory
        {
            #region PRIVATE FIELDS
            private readonly IDbConnection _connection;
            #endregion      // PRIVATE FIELDS

            #region CTOR
            /// <summary>
            /// Parameterized Constructor
            /// </summary>
            /// <param name="connection">The fake connection instance.</param>
            public TestDbConnectionFactory(IDbConnection connection)
            {
                _connection = connection;
            }
            #endregion      // CTOR

            #region CreateConnection()
            /// <summary>
            /// Creates a database connection for the repository under test.
            /// </summary>
            /// <returns>The configured fake database connection.</returns>
            public IDbConnection CreateConnection()
            {
                return _connection;
            }
            #endregion      // CreateConnection()
        }
        #endregion      // private sealed class TestDbConnectionFactory

        #region private sealed class TestDbConnection
        /// <summary>
        /// Test database connection class.
        /// </summary>
        private sealed class TestDbConnection : IDbConnection
        {
            #region PRIVATE FIELDS
            private readonly IDbCommand _command;
            private ConnectionState _state;
            #endregion      // PRIVATE FIELDS

            #region PROPERTIES
            public bool OpenWasCalled { get; private set; }
            #endregion      // PROPERTIES

            #region CTOR
            /// <summary>
            /// Parameterized Constructor
            /// </summary>
            /// <param name="command">The fake command instance.</param>
            public TestDbConnection(IDbCommand command)
            {
                _command = command;
                _state = ConnectionState.Closed;
            }
            #endregion      // CTOR

            #region ConnectionString
            /// <summary>
            /// Gets or sets the connection string.
            /// </summary>
            public string ConnectionString { get; set; }
            #endregion      // ConnectionString

            #region ConnectionTimeout
            /// <summary>
            /// Gets the connection timeout.
            /// </summary>
            public int ConnectionTimeout
            {
                get
                {
                    return 0;
                }
            }
            #endregion      // ConnectionTimeout

            #region Database
            /// <summary>
            /// Gets the database name.
            /// </summary>
            public string Database
            {
                get
                {
                    return String.Empty;
                }
            }
            #endregion      // Database

            #region State
            /// <summary>
            /// Gets the current connection state.
            /// </summary>
            public ConnectionState State
            {
                get
                {
                    return _state;
                }
            }
            #endregion      // State

            #region BeginTransaction()
            /// <summary>
            /// Begins a database transaction.
            /// </summary>
            /// <returns>This fake implementation always throws <see cref="NotSupportedException"/>.</returns>
            public IDbTransaction BeginTransaction()
            {
                throw new NotSupportedException();
            }
            #endregion      // BeginTransaction()

            #region BeginTransaction()
            /// <summary>
            /// Begins a database transaction with the supplied isolation level.
            /// </summary>
            /// <param name="il">The transaction isolation level.</param>
            /// <returns>This fake implementation always throws <see cref="NotSupportedException"/>.</returns>
            public IDbTransaction BeginTransaction(IsolationLevel il)
            {
                throw new NotSupportedException();
            }
            #endregion      // BeginTransaction()

            #region ChangeDatabase()
            /// <summary>
            /// Changes the current database.
            /// </summary>
            /// <param name="databaseName">The database name.</param>
            public void ChangeDatabase(string databaseName)
            {
            }
            #endregion      // ChangeDatabase()

            #region Close()
            /// <summary>
            /// Closes the fake connection.
            /// </summary>
            public void Close()
            {
                _state = ConnectionState.Closed;
            }
            #endregion      // Close()

            #region CreateCommand()
            /// <summary>
            /// Creates the fake command instance.
            /// </summary>
            /// <returns>The configured fake command.</returns>
            public IDbCommand CreateCommand()
            {
                return _command;
            }
            #endregion      // CreateCommand()

            #region Open()
            /// <summary>
            /// Opens the fake connection.
            /// </summary>
            public void Open()
            {
                OpenWasCalled = true;
                _state = ConnectionState.Open;
            }
            #endregion      // Open()

            #region Dispose()
            /// <summary>
            /// Disposes the fake connection.
            /// </summary>
            public void Dispose()
            {
                Close();
            }
            #endregion      // Dispose()
        }
        #endregion      // private sealed class TestDbConnection

        #region private sealed class TestDbCommand
        /// <summary>
        /// Test database command class.
        /// </summary>
        private sealed class TestDbCommand : IDbCommand
        {
            #region PRIVATE FIELDS
            private readonly TestDataParameterCollection _parameters;
            #endregion      // PRIVATE FIELDS

            #region PROPERTIES
            public IDataReader ReaderResult { get; set; }
            public object ScalarResult { get; set; }
            public int NonQueryResult { get; set; }
            public bool ExecuteReaderWasCalled { get; private set; }
            public bool ExecuteScalarWasCalled { get; private set; }
            public bool ExecuteNonQueryWasCalled { get; private set; }
            public IList<IDbDataParameter> CapturedParameters
            {
                get
                {
                    return _parameters.Items;
                }
            }
            #endregion      // PROPERTIES

            #region CTOR
            /// <summary>
            /// Default Constructor
            /// </summary>
            public TestDbCommand()
            {
                _parameters = new TestDataParameterCollection();
                CommandType = CommandType.Text;
            }
            #endregion      // CTOR

            #region CommandText
            /// <summary>
            /// Gets or sets the command text.
            /// </summary>
            public string CommandText { get; set; }
            #endregion      // CommandText

            #region CommandTimeout
            /// <summary>
            /// Gets or sets the command timeout.
            /// </summary>
            public int CommandTimeout { get; set; }
            #endregion      // CommandTimeout

            #region CommandType
            /// <summary>
            /// Gets or sets the command type.
            /// </summary>
            public CommandType CommandType { get; set; }
            #endregion      // CommandType

            #region Connection
            /// <summary>
            /// Gets or sets the connection.
            /// </summary>
            public IDbConnection Connection { get; set; }
            #endregion      // Connection

            #region Parameters
            /// <summary>
            /// Gets the command parameters.
            /// </summary>
            public IDataParameterCollection Parameters
            {
                get
                {
                    return _parameters;
                }
            }
            #endregion      // Parameters

            #region Transaction
            /// <summary>
            /// Gets or sets the transaction.
            /// </summary>
            public IDbTransaction Transaction { get; set; }
            #endregion      // Transaction

            #region UpdatedRowSource
            /// <summary>
            /// Gets or sets the updated row source.
            /// </summary>
            public UpdateRowSource UpdatedRowSource { get; set; }
            #endregion      // UpdatedRowSource

            #region Cancel()
            /// <summary>
            /// Cancels the command.
            /// </summary>
            public void Cancel()
            {
            }
            #endregion      // Cancel()

            #region CreateParameter()
            /// <summary>
            /// Creates a fake data parameter.
            /// </summary>
            /// <returns>A fake data parameter instance.</returns>
            public IDbDataParameter CreateParameter()
            {
                return new TestDbDataParameter();
            }
            #endregion      // CreateParameter()

            #region ExecuteNonQuery()
            /// <summary>
            /// Executes the fake non-query command.
            /// </summary>
            /// <returns>The configured non-query result.</returns>
            public int ExecuteNonQuery()
            {
                ExecuteNonQueryWasCalled = true;
                return NonQueryResult;
            }
            #endregion      // ExecuteNonQuery()

            #region ExecuteReader()
            /// <summary>
            /// Executes the fake reader command.
            /// </summary>
            /// <returns>The configured data reader result.</returns>
            public IDataReader ExecuteReader()
            {
                ExecuteReaderWasCalled = true;
                return ReaderResult;
            }
            #endregion      // ExecuteReader()

            #region ExecuteReader()
            /// <summary>
            /// Executes the fake reader command with the supplied behavior.
            /// </summary>
            /// <param name="behavior">The command behavior.</param>
            /// <returns>The configured data reader result.</returns>
            public IDataReader ExecuteReader(CommandBehavior behavior)
            {
                return ExecuteReader();
            }
            #endregion      // ExecuteReader()

            #region ExecuteScalar()
            /// <summary>
            /// Executes the fake scalar command.
            /// </summary>
            /// <returns>The configured scalar result.</returns>
            public object ExecuteScalar()
            {
                ExecuteScalarWasCalled = true;
                return ScalarResult;
            }
            #endregion      // ExecuteScalar()

            #region Prepare()
            /// <summary>
            /// Prepares the command.
            /// </summary>
            public void Prepare()
            {
            }
            #endregion      // Prepare()

            #region Dispose()
            /// <summary>
            /// Disposes the fake command.
            /// </summary>
            public void Dispose()
            {
            }
            #endregion      // Dispose()
        }
        #endregion      // private sealed class TestDbCommand

        #region private sealed class TestDbDataParameter
        /// <summary>
        /// Test database data parameter class.
        /// </summary>
        private sealed class TestDbDataParameter : IDbDataParameter
        {
            #region DbType
            /// <summary>
            /// Gets or sets the database type.
            /// </summary>
            public DbType DbType { get; set; }
            #endregion      // DbType

            #region Direction
            /// <summary>
            /// Gets or sets the parameter direction.
            /// </summary>
            public ParameterDirection Direction { get; set; }
            #endregion      // Direction

            #region IsNullable
            /// <summary>
            /// Gets whether the parameter is nullable.
            /// </summary>
            public bool IsNullable
            {
                get
                {
                    return true;
                }
            }
            #endregion      // IsNullable

            #region ParameterName
            /// <summary>
            /// Gets or sets the parameter name.
            /// </summary>
            public string ParameterName { get; set; }
            #endregion      // ParameterName

            #region SourceColumn
            /// <summary>
            /// Gets or sets the source column.
            /// </summary>
            public string SourceColumn { get; set; }
            #endregion      // SourceColumn

            #region SourceVersion
            /// <summary>
            /// Gets or sets the source version.
            /// </summary>
            public DataRowVersion SourceVersion { get; set; }
            #endregion      // SourceVersion

            #region Value
            /// <summary>
            /// Gets or sets the parameter value.
            /// </summary>
            public object Value { get; set; }
            #endregion      // Value

            #region Precision
            /// <summary>
            /// Gets or sets the precision.
            /// </summary>
            public byte Precision { get; set; }
            #endregion      // Precision

            #region Scale
            /// <summary>
            /// Gets or sets the scale.
            /// </summary>
            public byte Scale { get; set; }
            #endregion      // Scale

            #region Size
            /// <summary>
            /// Gets or sets the size.
            /// </summary>
            public int Size { get; set; }
            #endregion      // Size
        }
        #endregion      // private sealed class TestDbDataParameter

        #region private sealed class TestDataParameterCollection
        /// <summary>
        /// Test data parameter collection class.
        /// </summary>
        private sealed class TestDataParameterCollection : IDataParameterCollection
        {
            #region PRIVATE FIELDS
            private readonly List<object> _items = new List<object>();
            #endregion      // PRIVATE FIELDS

            #region PROPERTIES
            public IList<IDbDataParameter> Items
            {
                get
                {
                    List<IDbDataParameter> items = new List<IDbDataParameter>();

                    foreach (object item in _items)
                    {
                        items.Add((IDbDataParameter)item);
                    }

                    return items;
                }
            }
            #endregion      // PROPERTIES

            #region this[]
            /// <summary>
            /// Gets or sets an item by index.
            /// </summary>
            /// <param name="index">The item index.</param>
            /// <returns>The item at the supplied index.</returns>
            public object this[int index]
            {
                get
                {
                    return _items[index];
                }
                set
                {
                    _items[index] = value;
                }
            }
            #endregion      // this[]

            #region this[]
            /// <summary>
            /// Gets or sets an item by parameter name.
            /// </summary>
            /// <param name="parameterName">The parameter name.</param>
            /// <returns>The item matching the supplied parameter name.</returns>
            public object this[string parameterName]
            {
                get
                {
                    return _items[IndexOf(parameterName)];
                }
                set
                {
                    _items[IndexOf(parameterName)] = value;
                }
            }
            #endregion      // this[]

            #region Count
            /// <summary>
            /// Gets the number of items in the collection.
            /// </summary>
            public int Count
            {
                get
                {
                    return _items.Count;
                }
            }
            #endregion      // Count

            #region IsFixedSize
            /// <summary>
            /// Gets whether the collection has a fixed size.
            /// </summary>
            public bool IsFixedSize
            {
                get
                {
                    return false;
                }
            }
            #endregion      // IsFixedSize

            #region IsReadOnly
            /// <summary>
            /// Gets whether the collection is read-only.
            /// </summary>
            public bool IsReadOnly
            {
                get
                {
                    return false;
                }
            }
            #endregion      // IsReadOnly

            #region IsSynchronized
            /// <summary>
            /// Gets whether the collection is synchronized.
            /// </summary>
            public bool IsSynchronized
            {
                get
                {
                    return false;
                }
            }
            #endregion      // IsSynchronized

            #region SyncRoot
            /// <summary>
            /// Gets the synchronization root.
            /// </summary>
            public object SyncRoot
            {
                get
                {
                    return this;
                }
            }
            #endregion      // SyncRoot

            #region Add()
            /// <summary>
            /// Adds an item to the collection.
            /// </summary>
            /// <param name="value">The item to add.</param>
            /// <returns>The index of the added item.</returns>
            public int Add(object value)
            {
                _items.Add(value);
                return _items.Count - 1;
            }
            #endregion      // Add()

            #region Clear()
            /// <summary>
            /// Clears the collection.
            /// </summary>
            public void Clear()
            {
                _items.Clear();
            }
            #endregion      // Clear()

            #region Contains()
            /// <summary>
            /// Determines whether the collection contains the supplied item.
            /// </summary>
            /// <param name="value">The item to find.</param>
            /// <returns><c>true</c> if the item exists; otherwise, <c>false</c>.</returns>
            public bool Contains(object value)
            {
                return _items.Contains(value);
            }
            #endregion      // Contains()

            #region Contains()
            /// <summary>
            /// Determines whether the collection contains the supplied parameter name.
            /// </summary>
            /// <param name="parameterName">The parameter name to find.</param>
            /// <returns><c>true</c> if the parameter exists; otherwise, <c>false</c>.</returns>
            public bool Contains(string parameterName)
            {
                return IndexOf(parameterName) >= 0;
            }
            #endregion      // Contains()

            #region CopyTo()
            /// <summary>
            /// Copies the collection items to an array.
            /// </summary>
            /// <param name="array">The destination array.</param>
            /// <param name="index">The starting array index.</param>
            public void CopyTo(Array array, int index)
            {
                ((ICollection)_items).CopyTo(array, index);
            }
            #endregion      // CopyTo()

            #region GetEnumerator()
            /// <summary>
            /// Gets the collection enumerator.
            /// </summary>
            /// <returns>The collection enumerator.</returns>
            public IEnumerator GetEnumerator()
            {
                return _items.GetEnumerator();
            }
            #endregion      // GetEnumerator()

            #region IndexOf()
            /// <summary>
            /// Gets the index of the supplied item.
            /// </summary>
            /// <param name="value">The item to find.</param>
            /// <returns>The item index, or <c>-1</c> if not found.</returns>
            public int IndexOf(object value)
            {
                return _items.IndexOf(value);
            }
            #endregion      // IndexOf()

            #region IndexOf()
            /// <summary>
            /// Gets the index of the supplied parameter name.
            /// </summary>
            /// <param name="parameterName">The parameter name to find.</param>
            /// <returns>The item index, or <c>-1</c> if not found.</returns>
            public int IndexOf(string parameterName)
            {
                for (int i = 0; i < _items.Count; i++)
                {
                    IDbDataParameter parameter = (IDbDataParameter)_items[i];

                    if (String.Equals(parameter.ParameterName, parameterName, StringComparison.Ordinal))
                    {
                        return i;
                    }
                }

                return -1;
            }
            #endregion      // IndexOf()

            #region Insert()
            /// <summary>
            /// Inserts an item into the collection.
            /// </summary>
            /// <param name="index">The target index.</param>
            /// <param name="value">The item to insert.</param>
            public void Insert(int index, object value)
            {
                _items.Insert(index, value);
            }
            #endregion      // Insert()

            #region Remove()
            /// <summary>
            /// Removes an item from the collection.
            /// </summary>
            /// <param name="value">The item to remove.</param>
            public void Remove(object value)
            {
                _items.Remove(value);
            }
            #endregion      // Remove()

            #region RemoveAt()
            /// <summary>
            /// Removes an item at the supplied index.
            /// </summary>
            /// <param name="index">The item index.</param>
            public void RemoveAt(int index)
            {
                _items.RemoveAt(index);
            }
            #endregion      // RemoveAt()

            #region RemoveAt()
            /// <summary>
            /// Removes an item matching the supplied parameter name.
            /// </summary>
            /// <param name="parameterName">The parameter name.</param>
            public void RemoveAt(string parameterName)
            {
                int index = IndexOf(parameterName);

                if (index >= 0)
                {
                    _items.RemoveAt(index);
                }
            }
            #endregion      // RemoveAt()
        }
        #endregion      // private sealed class TestDataParameterCollection

        #endregion      // PRIVATE CLASSES

        #region PRIVATE METHODS

        #region CreateExternalUnits()
        /// <summary>
        /// Creates the external project units object for unit testing.
        /// </summary>
        /// <returns>A <see cref="HenProjectUnits"/> object configured for English base units.</returns>
        private static HenProjectUnits CreateExternalUnits()
        {
            HenProjectUnits externalUnits = new HenProjectUnits();

            externalUnits.ProjectSystemUnitsEnum = HenProjectUnits.ProjectSystemUnits.ENGLISH;
            externalUnits.ProjectMagnitudeEnum = HenProjectUnits.ProjectMagnitude.BASE;
            externalUnits.ProjectEnglishTempEnum = HenProjectUnits.ProjectEnglishTemp.DEG_F;
            externalUnits.ProjectEnglishPressEnum = HenProjectUnits.ProjectEnglishPress.PSIA;
            externalUnits.ProjectEnglishAreaEnum = HenProjectUnits.ProjectEnglishArea.FT2;

            return externalUnits;
        }
        #endregion      // CreateExternalUnits()

        #region CreateInternalUnits()
        /// <summary>
        /// Creates the internal project units object for unit testing.
        /// </summary>
        /// <returns>A <see cref="HenProjectUnits"/> object configured with default internal units.</returns>
        private static HenProjectUnits CreateInternalUnits()
        {
            return new HenProjectUnits();
        }
        #endregion      // CreateInternalUnits()

        #region CreateProfileDto()
        /// <summary>
        /// Creates a profile data transfer object for unit testing.
        /// </summary>
        /// <param name="id">The profile identifier.</param>
        /// <param name="projectId">The project identifier.</param>
        /// <param name="name">The profile name.</param>
        /// <returns>A populated <see cref="ProfileDto"/> instance.</returns>
        private static ProfileDto CreateProfileDto(Guid id, Guid projectId, string name)
        {
            return new ProfileDto
            {
                Id = id,
                ProjectId = projectId,
                Name = name,
                Description = name + " Description"
            };
        }
        #endregion      // CreateProfileDto()

        #region CreateProfileReader()
        /// <summary>
        /// Creates a profile data reader for unit testing.
        /// </summary>
        /// <param name="profiles">The profiles to expose through the reader.</param>
        /// <returns>An <see cref="IDataReader"/> over the supplied profile rows.</returns>
        private static IDataReader CreateProfileReader(params ProfileDto[] profiles)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(Guid));
            table.Columns.Add("ProjectId", typeof(Guid));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Description", typeof(string));

            foreach (ProfileDto profile in profiles)
            {
                table.Rows.Add(
                    profile.Id,
                    profile.ProjectId,
                    profile.Name,
                    (object)profile.Description ?? DBNull.Value);
            }

            return table.CreateDataReader();
        }
        #endregion      // CreateProfileReader()

        #region CreateProfileViewModel()
        /// <summary>
        /// Creates a profile view model and its backing fake ADO.NET objects for unit testing.
        /// </summary>
        /// <param name="command">The created fake database command.</param>
        /// <param name="connection">The created fake database connection.</param>
        /// <returns>A <see cref="ProfileViewModel"/> instance configured with a testable repository.</returns>
        private static ProfileViewModel CreateProfileViewModel(out TestDbCommand command,
                                                               out TestDbConnection connection)
        {
            command = new TestDbCommand();
            connection = new TestDbConnection(command);

            ProfileRepo profileRepo = new ProfileRepo(new TestDbConnectionFactory(connection));

            return new ProfileViewModel(profileRepo, CreateExternalUnits(), CreateInternalUnits());
        }
        #endregion      // CreateProfileViewModel()

        #region GetParameterValue()
        /// <summary>
        /// Gets a parameter value from the fake command by parameter name.
        /// </summary>
        /// <param name="command">The fake database command.</param>
        /// <param name="parameterName">The parameter name to retrieve.</param>
        /// <returns>The parameter value.</returns>
        private static object GetParameterValue(TestDbCommand command, string parameterName)
        {
            foreach (IDbDataParameter parameter in command.CapturedParameters)
            {
                if (String.Equals(parameter.ParameterName, parameterName, StringComparison.Ordinal))
                {
                    return parameter.Value;
                }
            }

            return null;
        }
        #endregion      // GetParameterValue()

        #endregion      // PRIVATE METHODS

        #region ProfileViewModel_CTOR_SetsProperties()
        /// <summary>
        /// Verifies that the constructor sets the repository and units properties.
        /// </summary>
        [Test]
        public void ProfileViewModel_CTOR_SetsProperties()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            ProfileRepo profileRepo = new ProfileRepo(new TestDbConnectionFactory(connection));
            HenProjectUnits externalUnits = CreateExternalUnits();
            HenProjectUnits internalUnits = CreateInternalUnits();

            ProfileViewModel viewModel = new ProfileViewModel(profileRepo, externalUnits, internalUnits);

            Assert.That(viewModel.ProfileRepoObj, Is.SameAs(profileRepo));
            Assert.That(viewModel.ExternalUnitsObj, Is.SameAs(externalUnits));
            Assert.That(viewModel.InternalUnitsObj, Is.SameAs(internalUnits));
        }
        #endregion      // ProfileViewModel_CTOR_SetsProperties()

        #region GetProfiles_ReturnsProfiles()
        /// <summary>
        /// Verifies that GetProfiles returns the profiles from the repository.
        /// </summary>
        [Test]
        public void GetProfiles_ReturnsProfiles()
        {
            TestDbCommand command;
            TestDbConnection connection;
            ProfileViewModel viewModel = CreateProfileViewModel(out command, out connection);
            Guid projectId = Guid.NewGuid();
            ProfileDto profile1 = CreateProfileDto(Guid.NewGuid(), projectId, "Alpha");
            ProfileDto profile2 = CreateProfileDto(Guid.NewGuid(), projectId, "Beta");

            command.ReaderResult = CreateProfileReader(profile1, profile2);

            IList<ProfileDto> result = viewModel.GetProfiles();

            Assert.That(connection.OpenWasCalled, Is.True);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].Name, Is.EqualTo("Alpha"));
            Assert.That(result[0].ProjectId, Is.EqualTo(projectId));
            Assert.That(result[1].Name, Is.EqualTo("Beta"));
        }
        #endregion      // GetProfiles_ReturnsProfiles()

        #region GetProfilesByProjectId_ReturnsProfiles()
        /// <summary>
        /// Verifies that GetProfilesByProjectId returns the matching profiles from the repository.
        /// </summary>
        [Test]
        public void GetProfilesByProjectId_ReturnsProfiles()
        {
            TestDbCommand command;
            TestDbConnection connection;
            ProfileViewModel viewModel = CreateProfileViewModel(out command, out connection);
            Guid projectId = Guid.NewGuid();
            ProfileDto profile1 = CreateProfileDto(Guid.NewGuid(), projectId, "Alpha");
            ProfileDto profile2 = CreateProfileDto(Guid.NewGuid(), projectId, "Beta");

            command.ReaderResult = CreateProfileReader(profile1, profile2);

            IList<ProfileDto> result = viewModel.GetProfilesByProjectId(projectId);

            Assert.That(command.ExecuteReaderWasCalled, Is.True);
            Assert.That(GetParameterValue(command, "@ProjectId"), Is.EqualTo(projectId));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].ProjectId, Is.EqualTo(projectId));
            Assert.That(result[1].ProjectId, Is.EqualTo(projectId));
        }
        #endregion      // GetProfilesByProjectId_ReturnsProfiles()

        #region GetProfileById_ReturnsProfile()
        /// <summary>
        /// Verifies that GetProfileById returns the matching profile from the repository.
        /// </summary>
        [Test]
        public void GetProfileById_ReturnsProfile()
        {
            TestDbCommand command;
            TestDbConnection connection;
            ProfileViewModel viewModel = CreateProfileViewModel(out command, out connection);
            ProfileDto profile = CreateProfileDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");

            command.ReaderResult = CreateProfileReader(profile);

            ProfileDto result = viewModel.GetProfileById(profile.Id);

            Assert.That(command.ExecuteReaderWasCalled, Is.True);
            Assert.That(GetParameterValue(command, "@Id"), Is.EqualTo(profile.Id));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(profile.Id));
            Assert.That(result.Name, Is.EqualTo("Alpha"));
        }
        #endregion      // GetProfileById_ReturnsProfile()

        #region GetProfileByName_ReturnsProfile()
        /// <summary>
        /// Verifies that GetProfileByName returns the matching profile from the repository.
        /// </summary>
        [Test]
        public void GetProfileByName_ReturnsProfile()
        {
            TestDbCommand command;
            TestDbConnection connection;
            ProfileViewModel viewModel = CreateProfileViewModel(out command, out connection);
            ProfileDto profile = CreateProfileDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");

            command.ReaderResult = CreateProfileReader(profile);

            ProfileDto result = viewModel.GetProfileByName(profile.ProjectId, profile.Name);

            Assert.That(command.ExecuteReaderWasCalled, Is.True);
            Assert.That(GetParameterValue(command, "@ProjectId"), Is.EqualTo(profile.ProjectId));
            Assert.That(GetParameterValue(command, "@Name"), Is.EqualTo(profile.Name));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Name, Is.EqualTo("Alpha"));
        }
        #endregion      // GetProfileByName_ReturnsProfile()

        #region AddProfile_ReturnsInsertedProfileId()
        /// <summary>
        /// Verifies that AddProfile returns the inserted profile identifier.
        /// </summary>
        [Test]
        public void AddProfile_ReturnsInsertedProfileId()
        {
            TestDbCommand command;
            TestDbConnection connection;
            ProfileViewModel viewModel = CreateProfileViewModel(out command, out connection);
            ProfileDto profile = CreateProfileDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");
            Guid insertedId = Guid.NewGuid();

            command.ScalarResult = insertedId;

            Guid result = viewModel.AddProfile(profile);

            Assert.That(command.ExecuteScalarWasCalled, Is.True);
            Assert.That(result, Is.EqualTo(insertedId));
            Assert.That(GetParameterValue(command, "@ProjectId"), Is.EqualTo(profile.ProjectId));
            Assert.That(GetParameterValue(command, "@Name"), Is.EqualTo(profile.Name));
            Assert.That(GetParameterValue(command, "@Description"), Is.EqualTo(profile.Description));
        }
        #endregion      // AddProfile_ReturnsInsertedProfileId()

        #region UpdateProfile_StoresProfile()
        /// <summary>
        /// Verifies that UpdateProfile forwards the profile to the repository.
        /// </summary>
        [Test]
        public void UpdateProfile_StoresProfile()
        {
            TestDbCommand command;
            TestDbConnection connection;
            ProfileViewModel viewModel = CreateProfileViewModel(out command, out connection);
            ProfileDto profile = CreateProfileDto(Guid.NewGuid(), Guid.NewGuid(), "Alpha");
            command.NonQueryResult = 1;

            viewModel.UpdateProfile(profile);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(GetParameterValue(command, "@Id"), Is.EqualTo(profile.Id));
            Assert.That(GetParameterValue(command, "@ProjectId"), Is.EqualTo(profile.ProjectId));
            Assert.That(GetParameterValue(command, "@Name"), Is.EqualTo(profile.Name));
            Assert.That(GetParameterValue(command, "@Description"), Is.EqualTo(profile.Description));
        }
        #endregion      // UpdateProfile_StoresProfile()

        #region DeleteProfile_DeletesProfileById()
        /// <summary>
        /// Verifies that DeleteProfile forwards the profile identifier to the repository.
        /// </summary>
        [Test]
        public void DeleteProfile_DeletesProfileById()
        {
            TestDbCommand command;
            TestDbConnection connection;
            ProfileViewModel viewModel = CreateProfileViewModel(out command, out connection);
            Guid profileId = Guid.NewGuid();
            command.NonQueryResult = 1;

            viewModel.DeleteProfile(profileId);

            Assert.That(command.ExecuteNonQueryWasCalled, Is.True);
            Assert.That(GetParameterValue(command, "@Id"), Is.EqualTo(profileId));
        }
        #endregion      // DeleteProfile_DeletesProfileById()
    }
    #endregion      // public class ProfileViewModelTests
}
#endregion      // namespace HenStudio.Tests.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
