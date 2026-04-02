#region HEADER
//#####################################################################################################################
//######################################  C o n n e c t i o n D a t a R e p o . c s  ##################################
//#####################################################################################################################
//  FILENAME:  ConnectionDataRepo.cs
//  NAMESPACE: HenPersistence.Repos
//  CLASS(S):  ConnectionDataRepo
//  COMPONENT: _HenPersistence.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation for database connection metadata queries.
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
using HenPersistence.Interfaces;
using HenRepositories.Dto;
using HenRepositories.Interfaces;

using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
#endregion      // REFERENCES

#region namespace HenPersistence.Repos
namespace HenPersistence.Repos
{
    #region public class ConnectionDataRepo
    /// <summary>
    /// ConnectionData Repo Class
    /// </summary>
    public class ConnectionDataRepo : IConnectionDataRepo
    {
        #region PRIVATE FIELDS
        private readonly IDbConnectionFactory _connectionFactory;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public ConnectionDataRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region PRIVATE METHODS

        #region GetConnectionStringBuilder()
        /// <summary>
        /// Creates a SQL connection string builder from the supplied connection string.
        /// </summary>
        /// <param name="connectionString">The database connection string.</param>
        /// <returns>A <see cref="SqlConnectionStringBuilder"/> populated from the supplied connection string.</returns>
        private static SqlConnectionStringBuilder GetConnectionStringBuilder(string connectionString)
        {
            return new SqlConnectionStringBuilder(connectionString);
        }
        #endregion      // GetConnectionStringBuilder()

        #region GetUserId()
        /// <summary>
        /// Gets the user identifier from the SQL connection string.
        /// </summary>
        /// <param name="connectionString">The SQL Server connection string.</param>
        /// <returns>The configured user identifier, or <c>Integrated Security</c> when integrated security is enabled.</returns>
        private static string GetUserId(string connectionString)
        {
            SqlConnectionStringBuilder builder = GetConnectionStringBuilder(connectionString);

            if (builder.IntegratedSecurity)
            {
                return "Integrated Security";
            }

            return builder.UserID;
        }
        #endregion      // GetUserId()

        #region GetWorkstationId()
        /// <summary>
        /// Gets the workstation identifier from the SQL connection string.
        /// </summary>
        /// <param name="connectionString">The SQL Server connection string.</param>
        /// <returns>The configured workstation identifier.</returns>
        private static string GetWorkstationId(string connectionString)
        {
            SqlConnectionStringBuilder builder = GetConnectionStringBuilder(connectionString);

            return builder.WorkstationID;
        }
        #endregion      // GetWorkstationId()

        #region GetPacketSize()
        /// <summary>
        /// Gets the packet size from the SQL connection string.
        /// </summary>
        /// <param name="connectionString">The SQL Server connection string.</param>
        /// <returns>The configured packet size.</returns>
        private static int GetPacketSize(string connectionString)
        {
            SqlConnectionStringBuilder builder = GetConnectionStringBuilder(connectionString);

            return builder.PacketSize;
        }
        #endregion      // GetPacketSize()

        #endregion      // PRIVATE METHODS

        #region METHODS

        #region GetConnectionData()
        /// <summary>
        /// Retrieves database connection metadata for the current SQL Server connection.
        /// </summary>
        /// <returns>A <see cref="ConnectionDataDto"/> object containing the current connection metadata.</returns>
        public ConnectionDataDto GetConnectionData()
        {
            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                DbConnection dbConnection = connection as DbConnection;

                if (dbConnection == null)
                {
                    throw new InvalidOperationException("The configured connection factory did not return a DbConnection instance.");
                }

                dbConnection.Open();

                return new ConnectionDataDto
                {
                    DataSource = dbConnection.DataSource,
                    UserId = GetUserId(dbConnection.ConnectionString),
                    WorkstationId = GetWorkstationId(dbConnection.ConnectionString),
                    InitialCatalog = dbConnection.Database,
                    Timeout = dbConnection.ConnectionTimeout,
                    PacketSize = GetPacketSize(dbConnection.ConnectionString),
                    ServerVersion = dbConnection.ServerVersion,
                    ConnectionState = dbConnection.State.ToString()
                };
            }
        }
        #endregion      // GetConnectionData()

        #endregion      // METHODS
    }
    #endregion      // public class ConnectionDataRepo
}
#endregion      // namespace HenPersistence.Repos

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
