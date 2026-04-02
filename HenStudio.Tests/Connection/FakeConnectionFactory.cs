#region HEADER
//#####################################################################################################################
//######################################  F a k e C o n n e c t i o n F a c t o r y . c s  ############################
//#####################################################################################################################
//  FILENAME:  FakeConnectionFactory.cs
//  NAMESPACE: HenStudio.Tests.Connection
//  CLASS(S):  FakeConnectionFactory
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains a fake database connection factory for ConnectionDataRepo tests.
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

#region namespace HenStudio.Tests.Connection
namespace HenStudio.Tests.Connection
{
    #region public class FakeConnectionFactory
    /// <summary>
    /// Fake connection factory class for ConnectionDataRepo tests.
    /// </summary>
    public class FakeConnectionFactory : IDbConnectionFactory
    {
        #region PRIVATE FIELDS
        private readonly IDbConnection _connection;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connection">The fake SQL connection instance.</param>
        public FakeConnectionFactory(IDbConnection connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException(nameof(connection));
            }

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connection.ConnectionString);

            _connection = connection;
        }
        #endregion      // CTOR

        #region CreateConnection()
        /// <summary>
        /// Creates a database connection for the test repository.
        /// </summary>
        /// <returns>The configured fake SQL connection.</returns>
        public IDbConnection CreateConnection()
        {
            return _connection;
        }
        #endregion      // CreateConnection()
    }
    #endregion      // public class FakeConnectionFactory
}
#endregion      // namespace HenStudio.Tests.Connection

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
