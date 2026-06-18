#region HEADER
//#####################################################################################################################
//#########################################  A p p S e t t i n g s R e p o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  AppSettingsRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Application
//  CLASS(S):  AppSettingsRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    Concrete repository implementation for the AppSettings table.
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
    #region public class AppSettingsRepo
    /// <summary>
    /// Repository class for accessing application settings records.
    /// </summary>
    public class AppSettingsRepo : IAppSettingsRepo
    {
        #region PRIVATE FIELDS
        private readonly IConnectionFactory _factory;
        #endregion      // PRIVATE FIELDS

        #region CTOR
        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        /// <param name="factory">SQLite connection factory.</param>
        public AppSettingsRepo(IConnectionFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }
        #endregion      // CTOR

        #region PRIVATE METHODS

        #region MapAppSettings()
        /// <summary>
        /// Maps a SqliteDataReader record to an AppSettingsDto instance.
        /// </summary>
        private static AppSettingsDto MapAppSettings(SqliteDataReader reader)
        {
            int idOrdinal = reader.GetOrdinal("AppSettingId");
            int nameOrdinal = reader.GetOrdinal("AppSettingName");
            int valueOrdinal = reader.GetOrdinal("AppSettingValue");

            return new AppSettingsDto
            {
                AppSettingId = reader.GetInt32(idOrdinal),
                AppSettingName = reader.IsDBNull(nameOrdinal) ? null : reader.GetString(nameOrdinal),
                AppSettingValue = reader.IsDBNull(valueOrdinal) ? null : reader.GetString(valueOrdinal)
            };
        }
        #endregion  // MapAppSettings()

        #endregion      // PRIVATE METHODS

        #region METHODS

        #region GetAppSettingsList()
        /// <summary>
        /// Retrieves all application settings.
        /// </summary>
        /// <returns>List of AppSettingsDto objects.</returns>
        public List<AppSettingsDto> GetAppSettingsList()
        {
            const string sql = @"
                SELECT AppSettingId,
                       AppSettingName,
                       AppSettingValue
                FROM AppSettings
                ORDER BY AppSettingId;
            ";

            List<AppSettingsDto> settings = new List<AppSettingsDto>();

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
                            settings.Add(MapAppSettings(reader));
                        }
                    }
                }
            }

            return settings;
        }
        #endregion  // GetAppSettingsList()

        #region GetAppSettingsByName()
        /// <summary>
        /// Retrieves a single application setting by name.
        /// </summary>
        /// <param name="settingName">The setting name.</param>
        /// <returns>AppSettingsDto or null if not found.</returns>
        public AppSettingsDto GetAppSettingsByName(string settingName)
        {
            if (String.IsNullOrWhiteSpace(settingName))
            {
                throw new ArgumentException("Setting name cannot be null or whitespace.", nameof(settingName));
            }

            const string sql = @"
                SELECT AppSettingId,
                       AppSettingName,
                       AppSettingValue
                FROM AppSettings
                WHERE AppSettingName = @SettingName;
            ";

            using (SqliteConnection conn = _factory.CreateConnection())
            {
                conn.Open();

                using (SqliteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new SqliteParameter("@SettingName", settingName));

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapAppSettings(reader);
                    }
                }
            }
        }
        #endregion  // GetAppSettingsByName()

        #endregion      // METHODS
    }
    #endregion      // public class AppSettingsRepo
}
#endregion      // namespace HenModel.RepoImplementations.Application