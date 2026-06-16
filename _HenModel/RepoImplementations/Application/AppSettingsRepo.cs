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
//    This file contains the concrete repo implementation for the GlobalSettings table.
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
using System.Collections.Generic;
using System.Data;
using System.Security.Claims;
using System.Xml.Linq;
#endregion      // REFERENCES

#region namespace HenModel.RepoImplementations.Application
namespace HenModel.RepoImplementations.Application
{
    #region public class AppSettingsRepo
    /// <summary>
    /// GlobalSettings Repo Class
    /// </summary>
    public class AppSettingsRepo : IAppSettingsRepo
    {
        #region PRIVATE FIELDS
        private readonly IDbConnectionFactory _connectionFactory;
        #endregion      // PRIVATE FIELDS

        #region PRIVATE METHODS

        #region MapAppSettings()
        /// <summary>
        /// Maps a data record from the application settings query result set to a <see cref="AppSettingsDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the global settings column values.</param>
        /// <param name="appSettingIdOrdinal">The ordinal position of the <c>AppSettingId</c> column.</param>
        /// <param name="appSettingNameOrdinal">The ordinal position of the <c>AppSettingName</c> column.</param>
        /// <param name="AppSettingValueOrdinal">The ordinal position of the <c>AppSettingValue</c> column.</param>
        /// <returns>A <see cref="AppSettingsDto"/> populated from the supplied data record.</returns>
        private static AppSettingsDto MapAppSettings(IDataRecord record, 
                                                     int appSettingIdOrdinal, 
                                                     int appSettingNameOrdinal, 
                                                     int appSettingValueOrdinal)
        {
            return new AppSettingsDto
            {
                AppSettingId = record.GetInt32(appSettingIdOrdinal),
                AppSettingName = record.IsDBNull(appSettingNameOrdinal) ? null : record.GetString(appSettingNameOrdinal),
                AppSettingValue = record.IsDBNull(appSettingValueOrdinal) ? null : record.GetString(appSettingValueOrdinal),
            };
        }
        #endregion  // MapAppSettings()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public AppSettingsRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region GetAppSettingsList()
        /// <summary>
        /// Retrieves all application settings as a list of AppSettingsDto objects.
        /// </summary>
        /// <remarks>The settings are returned in ascending order by their setting key. This method is
        /// typically used to access configuration values that apply across the entire application.</remarks>
        /// <returns>A list of <see cref="AppSettingsDto"/> objects representing the global settings. The list is empty if no
        /// settings are found.</returns>
        public List<AppSettingsDto> GetAppSettingsList()
        {
            const string sql = @"SELECT AppSettingId,
                                        AppSettingName,
                                        AppSettingValue
                                 FROM dbo.AppSettings
                                 ORDER BY AppSettingId;";

            List<AppSettingsDto> settings = new List<AppSettingsDto>();

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        int appSettingIdOrdinal = reader.GetOrdinal("AppSettingId");
                        int appSettingNameOrdinal = reader.GetOrdinal("AppSettingName");
                        int appSettingValueOrdinal = reader.GetOrdinal("AppSettingValue");

                        while (reader.Read())
                        {
                            settings.Add(MapAppSettings(reader,
                                                        appSettingIdOrdinal,
                                                        appSettingNameOrdinal,
                                                        appSettingValueOrdinal));
                        }
                    }
                }
            }

            return settings;
        }
        #endregion  // GetGlobalSettings()

        #region GetAppSettingsByName()
        /// <summary>
        /// Retrieves a application setting using setting name.
        /// </summary>
        /// <param name="settingKey">The unique key that identifies the global setting to retrieve.</param>
        /// <returns>A <see cref="AppSettingsDto"/> object representing the requested setting, or <c>null</c> if no matching setting is found.</returns>
        public AppSettingsDto GetAppSettingsByName(string settingName)
        {
            if (String.IsNullOrWhiteSpace(settingName))
            {
                throw new ArgumentException("Setting name cannot be null or whitespace.", nameof(settingName));
            }

            const string sql = @"SELECT AppSettingId,
                                        AppSettingName,
                                        AppSettingValue
                                 FROM dbo.AppSettings
                                 WHERE AppSettingName = @SettingName;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;

                    IDbDataParameter parameter = command.CreateParameter();
                    parameter.ParameterName = "@SettingName";
                    parameter.DbType = DbType.String;
                    parameter.Value = settingName;
                    command.Parameters.Add(parameter);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        int appSettingIdOrdinal = reader.GetOrdinal("AppSettingId");
                        int appSettingNameOrdinal = reader.GetOrdinal("AppSettingName");
                        int appSettingValueOrdinal = reader.GetOrdinal("AppSettingValue");

                        return MapAppSettings(reader,
                                              appSettingIdOrdinal,
                                              appSettingNameOrdinal,
                                              appSettingValueOrdinal);
                    }
                }
            }
        }
        #endregion  // GetGlobalSettingsByKey()

        #endregion      // METHODS
    }
    #endregion      // public class GlobalSettingsRepo
}
#endregion      // namespace HenModel.RepoImplementations.Application

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
