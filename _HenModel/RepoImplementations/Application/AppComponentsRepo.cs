#region HEADER
//#####################################################################################################################
//#######################################  A p p C o m p o n e n t s R e p o . c s  ###################################
//#####################################################################################################################
//  FILENAME:  AppComponentsRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Application
//  CLASS(S):  AppComponentsRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    Concrete repository implementation for the AppComponents table.
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
using HenModel.Dto.Application;
using HenModel.RepoInterfaces.Application;

using Microsoft.Data.Sqlite;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoImplementations.Application
namespace HenModel.RepoImplementations.Application
{
    #region public class AppComponentsRepo
    /// <summary>
    /// Repository class for accessing application component records.
    /// </summary>
    public class AppComponentsRepo : IAppComponentsRepo
    {
        #region PRIVATE FIELDS
        private readonly IConnectionFactory _factory;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        /// <param name="factory">SQLite connection factory.</param>
        public AppComponentsRepo(IConnectionFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }
        #endregion      // CTOR

        #region PRIVATE METHODS

        #region MapAppComponents()
        /// <summary>
        /// Maps a SqliteDataReader record to an AppComponentsDto instance.
        /// </summary>
        private static AppComponentsDto MapAppComponents(SqliteDataReader reader)
        {
            int idOrdinal = reader.GetOrdinal("ComponentId");
            int nameOrdinal = reader.GetOrdinal("ComponentName");
            int typeOrdinal = reader.GetOrdinal("ComponentType");

            return new AppComponentsDto
            {
                ComponentId = reader.GetInt32(idOrdinal),
                ComponentName = reader.IsDBNull(nameOrdinal) ? null : reader.GetString(nameOrdinal),
                ComponentType = reader.IsDBNull(typeOrdinal) ? null : reader.GetString(typeOrdinal)
            };
        }
        #endregion  // MapAppComponents()

        #endregion      // PRIVATE METHODS

        #region METHODS

        #region GetAppComponentsList()
        /// <summary>
        /// Retrieves all application components.
        /// </summary>
        /// <returns>List of AppComponentsDto objects.</returns>
        public List<AppComponentsDto> GetAppComponentsList()
        {
            const string sql = @"
                SELECT ComponentId,
                       ComponentName,
                       ComponentType
                FROM AppComponents
                ORDER BY ComponentId;
            ";

            List<AppComponentsDto> components = new List<AppComponentsDto>();

            using (SqliteConnection conn = _factory.CreateConnection())
            {
                conn.Open();

                using (SqliteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            components.Add(MapAppComponents(reader));
                        }
                    }
                }
            }

            return components;
        }
        #endregion  // GetAppComponentsList()

        #endregion      // METHODS
    }
    #endregion      // public class AppComponentsRepo
}
#endregion      // namespace HenModel.RepoImplementations.Application
