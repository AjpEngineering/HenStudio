#region HEADER
//#####################################################################################################################
//###################################  S q l C o n n e c t i o n F a c t o r y . c s  #################################
//#####################################################################################################################
//  FILENAME:  SqlConnectionFactory.cs
//  NAMESPACE: HenPersistence.Connection
//  CLASS(S):  SqlConnectionFactory
//  COMPONENT: _HenPersistence.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the SQL Server connection factory class for the persistence layer.
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

using System;
using System.Data;
using System.Data.SqlClient;
#endregion      // REFERENCES

#region namespace HenPersistence.Connection
namespace HenPersistence.Connection
{
    #region public class SqlConnectionFactory
    /// <summary>
    /// SQL Server Connection Factory Class
    /// </summary>
    public class SqlConnectionFactory : IDbConnectionFactory
    {
        #region PRIVATE FIELDS
        private readonly string _connectionString;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionString">Database connection string.</param>
        public SqlConnectionFactory(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("Connection string cannot be null or whitespace.", nameof(connectionString));
            }

            _connectionString = connectionString;
        }
        #endregion      // CTOR

        #region METHODS
        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
        #endregion      // METHODS
    }
    #endregion      // public class SqlConnectionFactory
}
#endregion      // namespace HenPersistence.Connection

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
