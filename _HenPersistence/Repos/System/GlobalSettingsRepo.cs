#region HEADER
//#####################################################################################################################
//######################################  G l o b a l S e t t i n g s R e p o . c s  ##################################
//#####################################################################################################################
//  FILENAME:  GlobalSettingsRepo.cs
//  NAMESPACE: HenPersistence.Repos
//  CLASS(S):  GlobalSettingsRepo
//  COMPONENT: _HenPersistence.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the GlobalSettings table.
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
    #region public class GlobalSettingsRepo
    /// <summary>
    /// GlobalSettings Repo Class
    /// </summary>
    public class GlobalSettingsRepo : IGlobalSettingsRepo
    {
        #region PRIVATE FIELDS
        private readonly IDbConnectionFactory _connectionFactory;
        #endregion      // PRIVATE FIELDS

        #region PRIVATE METHODS

        #region MapGlobalSettings()
        /// <summary>
        /// Maps a data record from the global settings query result set to a <see cref="GlobalSettingsDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the global settings column values.</param>
        /// <param name="settingKeyOrdinal">The ordinal position of the <c>SettingKey</c> column.</param>
        /// <param name="settingValueOrdinal">The ordinal position of the <c>SettingValue</c> column.</param>
        /// <param name="valueTypeOrdinal">The ordinal position of the <c>ValueType</c> column.</param>
        /// <param name="descriptionOrdinal">The ordinal position of the <c>Description</c> column.</param>
        /// <param name="updatedOnOrdinal">The ordinal position of the <c>UpdatedOn</c> column.</param>
        /// <returns>A <see cref="GlobalSettingsDto"/> populated from the supplied data record.</returns>
        private static GlobalSettingsDto MapGlobalSettings(IDataRecord record, 
                                                           int settingKeyOrdinal, 
                                                           int settingValueOrdinal, 
                                                           int valueTypeOrdinal, 
                                                           int descriptionOrdinal, 
                                                           int updatedOnOrdinal)
        {
            return new GlobalSettingsDto
            {
                SettingKey = record.IsDBNull(settingKeyOrdinal) ? null : record.GetString(settingKeyOrdinal),
                SettingValue = record.IsDBNull(settingValueOrdinal) ? null : record.GetString(settingValueOrdinal),
                ValueType = record.IsDBNull(valueTypeOrdinal) ? null : record.GetString(valueTypeOrdinal),
                Description = record.IsDBNull(descriptionOrdinal) ? null : record.GetString(descriptionOrdinal),
                UpdatedOn = record.GetDateTime(updatedOnOrdinal)
            };
        }
        #endregion  // MapGlobalSettings()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public GlobalSettingsRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region GetGlobalSettings()
        /// <summary>
        /// Retrieves all global application settings from the data store.
        /// </summary>
        /// <remarks>The settings are returned in ascending order by their setting key. This method is
        /// typically used to access configuration values that apply across the entire application.</remarks>
        /// <returns>A list of <see cref="GlobalSettingsDto"/> objects representing the global settings. The list is empty if no
        /// settings are found.</returns>
        public IList<GlobalSettingsDto> GetGlobalSettings()
        {
            const string sql = @"SELECT SettingKey,
                                        SettingValue,
                                        ValueType,
                                        Description,
                                        UpdatedOn
                                 FROM dbo.GlobalSettings
                                 ORDER BY SettingKey;";

            List<GlobalSettingsDto> settings = new List<GlobalSettingsDto>();

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        int settingKeyOrdinal = reader.GetOrdinal("SettingKey");
                        int settingValueOrdinal = reader.GetOrdinal("SettingValue");
                        int valueTypeOrdinal = reader.GetOrdinal("ValueType");
                        int descriptionOrdinal = reader.GetOrdinal("Description");
                        int updatedOnOrdinal = reader.GetOrdinal("UpdatedOn");

                        while (reader.Read())
                        {
                            settings.Add(MapGlobalSettings(reader, 
                                                           settingKeyOrdinal, 
                                                           settingValueOrdinal, 
                                                           valueTypeOrdinal, 
                                                           descriptionOrdinal, 
                                                           updatedOnOrdinal));
                        }
                    }
                }
            }

            return settings;
        }
        #endregion  // GetGlobalSettings()

        #region GetGlobalSettingsByKey()
        /// <summary>
        /// Retrieves a global application setting from the data store by its setting key.
        /// </summary>
        /// <param name="settingKey">The unique key that identifies the global setting to retrieve.</param>
        /// <returns>A <see cref="GlobalSettingsDto"/> object representing the requested setting, or <c>null</c> if no matching setting is found.</returns>
        public GlobalSettingsDto GetGlobalSettingsByKey(string settingKey)
        {
            if (String.IsNullOrWhiteSpace(settingKey))
            {
                throw new ArgumentException("Setting key cannot be null or whitespace.", nameof(settingKey));
            }

            const string sql = @"SELECT SettingKey,
                                        SettingValue,
                                        ValueType,
                                        Description,
                                        UpdatedOn
                                 FROM dbo.GlobalSettings
                                 WHERE SettingKey = @SettingKey;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;

                    IDbDataParameter parameter = command.CreateParameter();
                    parameter.ParameterName = "@SettingKey";
                    parameter.DbType = DbType.String;
                    parameter.Value = settingKey;
                    command.Parameters.Add(parameter);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        int settingKeyOrdinal = reader.GetOrdinal("SettingKey");
                        int settingValueOrdinal = reader.GetOrdinal("SettingValue");
                        int valueTypeOrdinal = reader.GetOrdinal("ValueType");
                        int descriptionOrdinal = reader.GetOrdinal("Description");
                        int updatedOnOrdinal = reader.GetOrdinal("UpdatedOn");

                        return MapGlobalSettings(reader, settingKeyOrdinal, settingValueOrdinal, valueTypeOrdinal, descriptionOrdinal, updatedOnOrdinal);
                    }
                }
            }
        }
        #endregion  // GetGlobalSettingsByKey()

        #endregion      // METHODS
    }
    #endregion      // public class GlobalSettingsRepo
}
#endregion      // namespace HenPersistence.Repos

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
