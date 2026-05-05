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
using HenPersistence.Connection;
using HenPersistence.Interfaces;

using HenRepositories.Dto;
using HenRepositories.Interfaces;

using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Claims;
using System.Xml.Linq;
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

        #region GetAppGlobalSettings()
        /// <summary>
        /// Gets application global settings as a strongly-typed <see cref="AppGlobalSettingsDto"/> object 
        /// by retrieving all global settings from the data store and mapping them to the corresponding 
        /// properties on the DTO based on their setting keys.
        /// </summary>
        /// <returns>Populated <see cref="AppGlobalSettingsDto"/> object.</returns>
        /// <exception cref="InvalidOperationException">Unrecognized global setting key encountered while mapping application global settings.</exception>
        public AppGlobalSettingsDto GetAppGlobalSettings()
        {
            AppGlobalSettingsDto settingsObj = new AppGlobalSettingsDto();  // Application Global Settings Object

            IList<GlobalSettingsDto> settingsList = GetGlobalSettings();    // Get Key-Value Pairs for All Global Settings from the Data Store
            foreach (var nameValuePair in settingsList)
            {
                //---------------------------------------------------------------
                //--- Assign Application Global Settings Based on Setting Key ---
                //---------------------------------------------------------------
                if (string.Compare(nameValuePair.SettingKey, "DatabaseCreatedOn") == 0)
                    settingsObj.DatabaseCreatedOn = DateTime.Parse(nameValuePair.SettingValue);

                else if (string.Compare(nameValuePair.SettingKey, "DefaultApproachTemperature") == 0)
                    settingsObj.DefaultApproachTemperature = double.Parse(nameValuePair.SettingValue);

                else if (string.Compare(nameValuePair.SettingKey, "DefaultEnglishU") == 0)
                    settingsObj.DefaultEnglishU = double.Parse(nameValuePair.SettingValue);

                else if (string.Compare(nameValuePair.SettingKey, "DefaultMetricU") == 0)
                    settingsObj.DefaultMetricU = double.Parse(nameValuePair.SettingValue);

                else if (string.Compare(nameValuePair.SettingKey, "DefaultOptimizer") == 0)
                    settingsObj.DefaultOptimizer = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "EnableAreaEstimation") == 0)
                    settingsObj.EnableAreaEstimation = bool.Parse(nameValuePair.SettingValue);

                else if (string.Compare(nameValuePair.SettingKey, "ExternalMagnitudeUnits") == 0)
                    settingsObj.ExternalMagnitudeUnits = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "ExternalPressUnits") == 0)
                    settingsObj.ExternalPressUnits = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "ExternalSystemUnits") == 0)
                    settingsObj.ExternalSystemUnits = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "ExternalTempUnits") == 0)
                    settingsObj.ExternalTempUnits = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "ExternalUnitsA") == 0)
                    settingsObj.ExternalUnitsA = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "ExternalUnitsEnergy") == 0)
                    settingsObj.ExternalUnitsEnergy = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "ExternalUnitsHeatCapacityFlowRate") == 0)
                    settingsObj.ExternalUnitsHeatCapacityFlowRate = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "ExternalUnitsMassFlowrate") == 0)
                    settingsObj.ExternalUnitsMassFlowrate = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "ExternalUnitsSpecificHeatCapacity") == 0)
                    settingsObj.ExternalUnitsSpecificHeatCapacity = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "ExternalUnitsU") == 0)
                    settingsObj.ExternalUnitsU = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "InternalMagnitudeUnits") == 0)
                    settingsObj.InternalMagnitudeUnits = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "InternalPressUnits") == 0)
                    settingsObj.InternalPressUnits = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "InternalSystemUnits") == 0)
                    settingsObj.InternalSystemUnits = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "InternalTempUnits") == 0)
                    settingsObj.InternalTempUnits = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "InternalUnitsA") == 0)
                    settingsObj.InternalUnitsA = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "InternalUnitsEnergy") == 0)
                    settingsObj.InternalUnitsEnergy = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "InternalUnitsHeatCapacityFlowRate") == 0)
                    settingsObj.InternalUnitsHeatCapacityFlowRate = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "InternalUnitsMassFlowrate") == 0)
                    settingsObj.InternalUnitsMassFlowrate = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "InternalUnitsSpecificHeatCapacity") == 0)
                    settingsObj.InternalUnitsSpecificHeatCapacity = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "InternalUnitsU") == 0)
                    settingsObj.InternalUnitsU = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "LastMigrationApplied") == 0)
                    settingsObj.LastMigrationApplied = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "ReportDefaultFont") == 0)
                    settingsObj.ReportDefaultFont = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "ReportIncludeAuditSection") == 0)
                    settingsObj.ReportIncludeAuditSection = bool.Parse(nameValuePair.SettingValue);

                else if (string.Compare(nameValuePair.SettingKey, "ReportUnitsProfile") == 0)
                    settingsObj.ReportUnitsProfile = nameValuePair.SettingValue;

                else if (string.Compare(nameValuePair.SettingKey, "SchemaVersion") == 0)
                    settingsObj.SchemaVersion = nameValuePair.SettingValue;

                else
                {
                    //--- Unrecognized Setting Key - Log Warning and Continue ---
                    throw new InvalidOperationException(
                        $"Unrecognized global setting key '{nameValuePair.SettingKey}' encountered while mapping application global settings. Please verify that the setting key is correct and that the application is up to date with the latest database schema.");
                }
            }
            return settingsObj;     // return populated application global settings object
        }
        #endregion  // GetAppGlobalSettings()

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
