#region HEADER
//#####################################################################################################################
//########################################  F a k e S q l C o n n e c t i o n . c s  ##################################
//#####################################################################################################################
//  FILENAME:  FakeSqlConnection.cs
//  NAMESPACE: HenStudio.Tests.Connection
//  CLASS(S):  FakeSqlConnection
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains a fake SQL connection implementation for ConnectionDataRepo tests.
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
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
#endregion      // REFERENCES

#region namespace HenStudio.Tests.Connection
namespace HenStudio.Tests.Connection
{
    #region public class FakeSqlConnection
    /// <summary>
    /// Fake SQL connection class for ConnectionDataRepo tests.
    /// </summary>
    public class FakeSqlConnection : DbConnection
    {
        #region PRIVATE FIELDS
        private string _connectionString;
        private string _dataSource;
        private string _database;
        private int _timeout;
        private readonly string _serverVersion;
        private ConnectionState _state;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="dataSource">The fake data source.</param>
        /// <param name="initialCatalog">The fake initial catalog.</param>
        /// <param name="userId">The fake user identifier.</param>
        /// <param name="password">The fake password.</param>
        /// <param name="workstationId">The fake workstation identifier.</param>
        /// <param name="timeout">The fake connection timeout.</param>
        /// <param name="packetSize">The fake packet size.</param>
        /// <param name="serverVersion">The fake server version.</param>
        /// <param name="integratedSecurity">Whether integrated security is enabled.</param>
        public FakeSqlConnection(
            string dataSource,
            string initialCatalog,
            string userId,
            string password,
            string workstationId,
            int timeout,
            int packetSize,
            string serverVersion,
            bool integratedSecurity = false)
        {
            _connectionString = BuildConnectionString(dataSource, initialCatalog, userId, password, workstationId, timeout, packetSize, integratedSecurity);
            _dataSource = dataSource;
            _database = initialCatalog;
            _timeout = timeout;
            _serverVersion = serverVersion;
            _state = ConnectionState.Closed;
        }
        #endregion      // CTOR

        #region PRIVATE METHODS

        #region BuildConnectionString()
        /// <summary>
        /// Builds the fake SQL connection string for the test connection.
        /// </summary>
        /// <param name="dataSource">The fake data source.</param>
        /// <param name="initialCatalog">The fake initial catalog.</param>
        /// <param name="userId">The fake user identifier.</param>
        /// <param name="password">The fake password.</param>
        /// <param name="workstationId">The fake workstation identifier.</param>
        /// <param name="timeout">The fake connection timeout.</param>
        /// <param name="packetSize">The fake packet size.</param>
        /// <param name="integratedSecurity">Whether integrated security is enabled.</param>
        /// <returns>A SQL Server connection string for the fake connection.</returns>
        private static string BuildConnectionString(
            string dataSource,
            string initialCatalog,
            string userId,
            string password,
            string workstationId,
            int timeout,
            int packetSize,
            bool integratedSecurity)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = dataSource;
            builder.InitialCatalog = initialCatalog;
            builder.ConnectTimeout = timeout;
            builder.PacketSize = packetSize;
            builder.WorkstationID = workstationId;
            builder.IntegratedSecurity = integratedSecurity;

            if (!integratedSecurity)
            {
                builder.UserID = userId;
                builder.Password = password;
            }

            return builder.ConnectionString;
        }
        #endregion      // BuildConnectionString()

        #endregion      // PRIVATE METHODS

        #region ConnectionString
        /// <summary>
        /// Gets or sets the fake SQL connection string.
        /// </summary>
        public override string ConnectionString
        {
            get
            {
                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }
        #endregion      // ConnectionString

        #region Database
        /// <summary>
        /// Gets the fake initial catalog.
        /// </summary>
        public override string Database
        {
            get
            {
                return _database;
            }
        }
        #endregion      // Database

        #region DataSource
        /// <summary>
        /// Gets the fake data source.
        /// </summary>
        public override string DataSource
        {
            get
            {
                return _dataSource;
            }
        }
        #endregion      // DataSource

        #region ConnectionTimeout
        /// <summary>
        /// Gets the fake connection timeout.
        /// </summary>
        public override int ConnectionTimeout
        {
            get
            {
                return _timeout;
            }
        }
        #endregion      // ConnectionTimeout

        #region Open()
        /// <summary>
        /// Opens the fake SQL connection.
        /// </summary>
        public override void Open()
        {
            _state = ConnectionState.Open;
        }
        #endregion      // Open()

        #region Close()
        /// <summary>
        /// Closes the fake SQL connection.
        /// </summary>
        public override void Close()
        {
            _state = ConnectionState.Closed;
        }
        #endregion      // Close()

        #region ChangeDatabase()
        /// <summary>
        /// Changes the fake initial catalog.
        /// </summary>
        /// <param name="databaseName">The new database name.</param>
        public override void ChangeDatabase(string databaseName)
        {
            _database = databaseName;
        }
        #endregion      // ChangeDatabase()

        #region BeginDbTransaction()
        /// <summary>
        /// Begins a fake database transaction.
        /// </summary>
        /// <param name="isolationLevel">The transaction isolation level.</param>
        /// <returns>This fake implementation always throws <see cref="NotSupportedException"/>.</returns>
        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
        {
            throw new NotSupportedException();
        }
        #endregion      // BeginDbTransaction()

        #region CreateDbCommand()
        /// <summary>
        /// Creates a fake database command.
        /// </summary>
        /// <returns>This fake implementation always throws <see cref="NotSupportedException"/>.</returns>
        protected override DbCommand CreateDbCommand()
        {
            throw new NotSupportedException();
        }
        #endregion      // CreateDbCommand()

        #region State
        /// <summary>
        /// Gets the current connection state.
        /// </summary>
        public override ConnectionState State
        {
            get
            {
                return _state;
            }
        }
        #endregion      // State

        #region ServerVersion
        /// <summary>
        /// Gets the fake SQL Server version.
        /// </summary>
        public override string ServerVersion
        {
            get
            {
                return _serverVersion;
            }
        }
        #endregion      // ServerVersion
    }
    #endregion      // public class FakeSqlConnection
}
#endregion      // namespace HenStudio.Tests.Connection

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
