#region HEADER
//#####################################################################################################################
//###################################  A p p C o n n e c t i o n D a t a R e p o . c s  ###############################
//#####################################################################################################################
//  FILENAME:  AppConnectionDataRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Application
//  CLASS(S):  AppConnectionDataRepo
//  COMPONENT: _HenModel.dll
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
using HenModel.Connection;
using HenModel.Connection.Interface;

using HenModel.Dto.Application;
using HenModel.RepoInterfaces.Application;

using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
#endregion      // REFERENCES

#region namespace HenModel.RepoImplementations.Application
namespace HenModel.RepoImplementations.Application
{
    #region public class AppConnectionDataRepo
    /// <summary>
    /// AppConnectionData Repo Class
    /// </summary>
    public class AppConnectionDataRepo : IAppConnectionDataRepo
    {
        #region PRIVATE FIELDS
        private readonly IDbConnectionFactory _connectionFactory;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public AppConnectionDataRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region PRIVATE METHODS

        #endregion      // PRIVATE METHODS

        #region METHODS

        #region GetAppConnectionData()
        /// <summary>
        /// Retrieves APPLICATION (HenStudio) SQLite database connection data.
        /// </summary>
        /// <returns>A <see cref="AppConnectionDataDto"/> object containing the 
        /// APPLICATION (HenStudio) SQLite connection data.</returns>
        public AppConnectionDataDto GetAppConnectionData()
        {
            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                DbConnection dbConnection = connection as DbConnection;

                if (dbConnection == null)
                {
                    throw new InvalidOperationException("The configured connection factory did not return a DbConnection instance.");
                }

                dbConnection.Open();

                return new AppConnectionDataDto();
            }
        }
        #endregion      // GetAppConnectionData()

        #endregion      // METHODS
    }
    #endregion      // public class AppConnectionDataRepo
}
#endregion      // namespace HenModel.RepoImplementations.Application

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
