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
using System;
using System.Data;

using Microsoft.Data.Sqlite;

using HenModel.Database.HenStudio;
#endregion  // REFERENCES

#region namespace HenModel.Connection
namespace HenModel.Connection
{
    #region public class SQLiteConnectionFactory
    /// <summary>
    /// SQLite Connection Factory Class
    /// </summary>
    public class SQLiteConnectionFactory : IConnectionFactory
    {
        #region PRIVATE FIELDS
        private readonly SQLiteConnectionOptions _options;
        private bool _initialized = false;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionString">SQLite connection string (e.g. Data Source=path\file.db;)</param>
        public SQLiteConnectionFactory(SQLiteConnectionOptions options)
        {
            _options = options;
        }
        #endregion      // CTOR

        #region CreateConnection()
        /// <summary>
        /// Creates and returns a new SQLite connection using the configured connection string.
        /// The connection is not opened by this method.
        /// </summary>
        /// <returns>An <see cref="IDbConnection"/> instance.</returns>
        public SqliteConnection CreateConnection()
        {
            if (!_initialized)
            {
                DatabaseInitializer.Initialize(_options);
                _initialized = true;
            }
            return new SqliteConnection(_options.BuildConnectionString());
        }
        #endregion  // CreateConnection()
    }
    #endregion  // public class SQLiteConnectionFactory
}
#endregion  // namespace HenModel.Connection

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
