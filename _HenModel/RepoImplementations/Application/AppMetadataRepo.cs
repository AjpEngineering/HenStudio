#region HEADER
//#####################################################################################################################
//#########################################  A p p M e t a d a t a R e p o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  AppMetadataRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Application
//  CLASS(S):  AppMetadataRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    Concrete repository implementation for the AppMetadata table.
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
    #region public class AppMetadataRepo
    /// <summary>
    /// Repository class for accessing application metadata records.
    /// </summary>
    public class AppMetadataRepo : IAppMetadataRepo
    {
        #region PRIVATE FIELDS
        private readonly IConnectionFactory _factory;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        /// <param name="factory">SQLite connection factory.</param>
        public AppMetadataRepo(IConnectionFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }
        #endregion      // CTOR

        #region PRIVATE METHODS

        #region MapMetadata()
        /// <summary>
        /// Maps a SqliteDataReader record to an AppMetadataDto instance.
        /// </summary>
        private static AppMetadataDto MapMetadata(SqliteDataReader reader)
        {
            int idOrdinal = reader.GetOrdinal("AppMetadataId");
            int nameOrdinal = reader.GetOrdinal("AppMetadataName");
            int valueOrdinal = reader.GetOrdinal("AppMetadataValue");

            return new AppMetadataDto
            {
                AppMetadataId = reader.GetInt32(idOrdinal),
                AppMetadataName = reader.IsDBNull(nameOrdinal) ? null : reader.GetString(nameOrdinal),
                AppMetadataValue = reader.IsDBNull(valueOrdinal) ? null : reader.GetString(valueOrdinal)
            };
        }
        #endregion  // MapMetadata()

        #endregion      // PRIVATE METHODS

        #region METHODS

        #region GetAppMetadataList()
        /// <summary>
        /// Retrieves all application metadata records.
        /// </summary>
        /// <returns>List of AppMetadataDto objects.</returns>
        public List<AppMetadataDto> GetAppMetadataList()
        {
            const string sql = @"
                SELECT AppMetadataId,
                       AppMetadataName,
                       AppMetadataValue
                FROM AppMetadata
                ORDER BY AppMetadataId;
            ";

            List<AppMetadataDto> metadata = new List<AppMetadataDto>();

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
                            metadata.Add(MapMetadata(reader));
                        }
                    }
                }
            }

            return metadata;
        }
        #endregion  // GetAppMetadataList()

        #endregion      // METHODS
    }
    #endregion      // public class AppMetadataRepo
}
#endregion      // namespace HenModel.RepoImplementations.Application
