#region HEADER
//#####################################################################################################################
//###################################  S q l i t e C o n n e c t i o n F a c t o r y . c s  #########################
//#####################################################################################################################
//  FILENAME:  SQLiteConnectionFactory.cs
//  NAMESPACE: HenModel.Connection
//  CLASS(S):  SQLiteConnectionFactory
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the SQLite Connection Factory class.
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
#endregion

#region REFERENCES
using HenModel.Connection.Interface;

using System;
using System.Data;
using Microsoft.Data.Sqlite;
#endregion  // REFERENCES

#region namespace HenModel.Connection
namespace HenModel.Connection
{
    #region public class SQLiteConnectionFactory
    /// <summary>
    /// SQLite Connection Factory Class
    /// </summary>
    public class SQLiteConnectionFactory : IDbConnectionFactory
    {
        #region PRIVATE FIELDS
        private readonly string _connectionString;
        #endregion      // PRIVATE FIELDS

        public IDbConnection dbConnection { get; set; }

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionString">SQLite connection string (e.g. Data Source=path\file.db;)</param>
        public SQLiteConnectionFactory(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("Connection string cannot be null or whitespace.", nameof(connectionString));
            }

            _connectionString = connectionString;
        }
        #endregion      // CTOR

        #region CreateConnection()
        /// <summary>
        /// Creates and returns a new SQLite connection using the configured connection string.
        /// The connection is not opened by this method.
        /// </summary>
        /// <returns>An <see cref="IDbConnection"/> instance.</returns>
        public IDbConnection CreateConnection()
        {
            dbConnection = new SqliteConnection(_connectionString);
            return dbConnection;
        }
        #endregion  // CreateConnection()

        #region CloseConnection()
        /// <summary>
        /// Closes the specified database connection if it is not already closed.
        /// </summary>
        /// <param name="connection">The database connection to close.</param>
        public void CloseConnection(IDbConnection connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException(nameof(connection));
            }
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        #endregion  // CloseConnection()
    }
    #endregion  // public class SQLiteConnectionFactory
}
#endregion  // namespace HenModel.Connection

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
