#region HEADER
//#####################################################################################################################
//######################################  D a t a b a s e T a b l e R e p o . c s  ####################################
//#####################################################################################################################
//  FILENAME:  DatabaseTableRepo.cs
//  NAMESPACE: HenPersistence.Repos
//  CLASS(S):  DatabaseTableRepo
//  COMPONENT: _HenPersistence.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation for database table name queries.
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
using System.Collections.Generic;
using System.Data;
#endregion      // REFERENCES

#region namespace HenPersistence.Repos
namespace HenPersistence.Repos
{
    #region public class DatabaseTableRepo
    /// <summary>
    /// DatabaseTable Repo Class
    /// </summary>
    public class DatabaseTableRepo : IDatabaseTableRepo
    {
        #region PRIVATE FIELDS
        private readonly IDbConnectionFactory _connectionFactory;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public DatabaseTableRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region GetDatabaseTables()
        /// <summary>
        /// Retrieves a list of all base tables in the database, including their schema and table names.
        /// </summary>
        /// <returns>A list of <see cref="DatabaseTableDto"/> objects representing the schema and name of each base table in the
        /// database. The list is empty if no base tables are found.</returns>
        public IList<DatabaseTableDto> GetDatabaseTables()
        {
            const string sql = @"SELECT TABLE_SCHEMA,
                                        TABLE_NAME
                                 FROM INFORMATION_SCHEMA.TABLES
                                 WHERE TABLE_TYPE = 'BASE TABLE'
                                 ORDER BY TABLE_SCHEMA,
                                          TABLE_NAME;";

            List<DatabaseTableDto> tables = new List<DatabaseTableDto>();

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        int schemaNameOrdinal = reader.GetOrdinal("TABLE_SCHEMA");
                        int tableNameOrdinal = reader.GetOrdinal("TABLE_NAME");

                        while (reader.Read())
                        {
                            tables.Add(new DatabaseTableDto
                            {
                                SchemaName = reader.IsDBNull(schemaNameOrdinal) ? String.Empty : reader.GetString(schemaNameOrdinal),
                                TableName = reader.IsDBNull(tableNameOrdinal) ? String.Empty : reader.GetString(tableNameOrdinal)
                            });
                        }
                    }
                }
            }

            return tables;
        }
        #endregion  // GetDatabaseTables()

        #endregion      // METHODS
    }
    #endregion      // public class DatabaseTableRepo
}
#endregion      // namespace HenPersistence.Repos

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
