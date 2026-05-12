#region HEADER
//#####################################################################################################################
//#####################################  U t i l i t y C o s t R e p o . c s  #########################################
//#####################################################################################################################
//  FILENAME:  UtilityCostRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Project.CostParameters
//  CLASS(S):  UtilityCostRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation for the Utility Cost Parameters Object.
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

using HenModel.RepoInterfaces.Project.CostParameters;
using HenModel.Dto.Project.CostParameters;

using System;
using System.Collections.Generic;
using System.Data;
#endregion      // REFERENCES

#region namespace HenModel.RepoImplementations.Project.CostParameters
namespace HenModel.RepoImplementations.Project.CostParameters
{
    #region public class UtilityCostRepo
    /// <summary>
    /// Utility Cost Repo Class
    /// </summary>
    public class UtilityCostRepo : IUtilityCostRepo
    {
        #region PRIVATE FIELDS
        private readonly IDbConnectionFactory _connectionFactory;
        #endregion      // PRIVATE FIELDS

        #region PRIVATE METHODS

        #region AddParameter()
        /// <summary>
        /// Adds a parameter to the supplied database command.
        /// </summary>
        /// <param name="command">The database command receiving the parameter.</param>
        /// <param name="parameterName">The parameter name.</param>
        /// <param name="dbType">The database type for the parameter.</param>
        /// <param name="value">The parameter value.</param>
        private static void AddParameter(IDbCommand command, string parameterName, DbType dbType, object value)
        {
            IDbDataParameter parameter = command.CreateParameter();
            parameter.ParameterName = parameterName;
            parameter.DbType = dbType;
            parameter.Value = value ?? DBNull.Value;
            command.Parameters.Add(parameter);
        }
        #endregion      // AddParameter()

        #region MapUtilityCost()
        /// <summary>
        /// Maps a data record from the Utility Cost query result set to an <see cref="UtilityCostDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the utility cost column values.</param>
        /// <returns>An <see cref="UtilityCostDto"/> populated from the supplied data record.</returns>
        private static UtilityCostDto MapUtilityCost(IDataRecord record)
        {
            return new UtilityCostDto
            {
                Id = record.GetGuid(record.GetOrdinal("Id")),
                ProjectId = record.GetGuid(record.GetOrdinal("ProjectId")),
                HP_SteamCost_Metric = record.GetDouble(record.GetOrdinal("HP_SteamCost_Metric")),
                MP_SteamCost_Metric = record.GetDouble(record.GetOrdinal("MP_SteamCost_Metric")),
                LP_SteamCost_Metric = record.GetDouble(record.GetOrdinal("LP_SteamCost_Metric")),
                CoolingWaterCost_Metric = record.GetDouble(record.GetOrdinal("CoolingWaterCost_Metric")),
                ChilledWaterCost_Metric = record.GetDouble(record.GetOrdinal("ChilledWaterCost_Metric")),
                FuelGasCost_Metric = record.GetDouble(record.GetOrdinal("FuelGasCost_Metric")),
                HP_SteamCost_English = record.GetDouble(record.GetOrdinal("HP_SteamCost_English")),
                MP_SteamCost_English = record.GetDouble(record.GetOrdinal("MP_SteamCost_English")),
                LP_SteamCost_English = record.GetDouble(record.GetOrdinal("LP_SteamCost_English")),
                CoolingWaterCost_English = record.GetDouble(record.GetOrdinal("CoolingWaterCost_English")),
                ChilledWaterCost_English = record.GetDouble(record.GetOrdinal("ChilledWaterCost_English")),
                FuelGasCost_English = record.GetDouble(record.GetOrdinal("FuelGasCost_English")),
                DutyUnits_Metric = record.IsDBNull(record.GetOrdinal("DutyUnits_Metric")) ? null : record.GetString(record.GetOrdinal("DutyUnits_Metric")),
                DutyUnits_English = record.IsDBNull(record.GetOrdinal("DutyUnits_English")) ? null : record.GetString(record.GetOrdinal("DutyUnits_English")),
            };
        }
        #endregion      // MapUtilityCost()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public UtilityCostRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region AddUtilityCost() ... CREATE
        /// <summary>
        /// Adds (CREATE) a new utility cost entry to the data store.
        /// </summary>
        /// <param name="utilityCostDto">The utility cost data to insert.</param>
        /// <returns>The unique identifier of the inserted utility cost entry.</returns>
        public Guid AddUtilityCost(UtilityCostDto utilityCostDto)
        {
            if (utilityCostDto == null)
            {
                throw new ArgumentNullException(nameof(utilityCostDto));
            }

            const string sql = @"INSERT INTO dbo.UtilityCost
                                    (ProjectId,
                                     HP_SteamCost_Metric,
                                     MP_SteamCost_Metric,
                                     LP_SteamCost_Metric,
                                     CoolingWaterCost_Metric,
                                     ChilledWaterCost_Metric,
                                     FuelGasCost_Metric,
                                     HP_SteamCost_English,
                                     MP_SteamCost_English,
                                     LP_SteamCost_English,
                                     CoolingWaterCost_English,
                                     ChilledWaterCost_English,
                                     FuelGasCost_English,
                                     DutyUnits_Metric,
                                     DutyUnits_English)
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@ProjectId,
                                     @HP_SteamCost_Metric,
                                     @MP_SteamCost_Metric,
                                     @LP_SteamCost_Metric,
                                     @CoolingWaterCost_Metric,
                                     @ChilledWaterCost_Metric,
                                     @FuelGasCost_Metric,
                                     @HP_SteamCost_English,
                                     @MP_SteamCost_English,
                                     @LP_SteamCost_English,
                                     @CoolingWaterCost_English,
                                     @ChilledWaterCost_English,
                                     @FuelGasCost_English,
                                     @DutyUnits_Metric,
                                     @DutyUnits_English);";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProjectId", DbType.Guid, utilityCostDto.ProjectId);
                    AddParameter(command, "@HP_SteamCost_Metric", DbType.Double, utilityCostDto.HP_SteamCost_Metric);
                    AddParameter(command, "@MP_SteamCost_Metric", DbType.Double, utilityCostDto.MP_SteamCost_Metric);
                    AddParameter(command, "@LP_SteamCost_Metric", DbType.Double, utilityCostDto.LP_SteamCost_Metric);
                    AddParameter(command, "@CoolingWaterCost_Metric", DbType.Double, utilityCostDto.CoolingWaterCost_Metric);
                    AddParameter(command, "@ChilledWaterCost_Metric", DbType.Double, utilityCostDto.ChilledWaterCost_Metric);
                    AddParameter(command, "@FuelGasCost_Metric", DbType.Double, utilityCostDto.FuelGasCost_Metric);
                    AddParameter(command, "@HP_SteamCost_English", DbType.Double, utilityCostDto.HP_SteamCost_English);
                    AddParameter(command, "@MP_SteamCost_English", DbType.Double, utilityCostDto.MP_SteamCost_English);
                    AddParameter(command, "@LP_SteamCost_English", DbType.Double, utilityCostDto.LP_SteamCost_English);
                    AddParameter(command, "@CoolingWaterCost_English", DbType.Double, utilityCostDto.CoolingWaterCost_English);
                    AddParameter(command, "@ChilledWaterCost_English", DbType.Double, utilityCostDto.ChilledWaterCost_English);
                    AddParameter(command, "@FuelGasCost_English", DbType.Double, utilityCostDto.FuelGasCost_English);
                    AddParameter(command, "@DutyUnits_Metric", DbType.String, utilityCostDto.DutyUnits_Metric);
                    AddParameter(command, "@DutyUnits_English", DbType.String, utilityCostDto.DutyUnits_English);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddUtilityCost() ... CREATE

        #region GetUtilityCost() ... READ
        /// <summary>
        /// Retrieves (READ) all utility costs from the data store.
        /// </summary>
        /// <returns>A list of <see cref="UtilityCostDto"/> objects representing all utility costs. 
        /// The list is empty if no utility costs are found.</returns>
        public IList<UtilityCostDto> GetUtilityCost()
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        HP_SteamCost_Metric,
                                        MP_SteamCost_Metric,
                                        LP_SteamCost_Metric,
                                        CoolingWaterCost_Metric,
                                        ChilledWaterCost_Metric,
                                        FuelGasCost_Metric,
                                        HP_SteamCost_English,
                                        MP_SteamCost_English,
                                        LP_SteamCost_English,
                                        CoolingWaterCost_English,
                                        ChilledWaterCost_English,
                                        FuelGasCost_English,
                                        DutyUnits_Metric,
                                        DutyUnits_English
                                 FROM dbo.UtilityCost
                                 ORDER BY ProjectId;";

            List<UtilityCostDto> utilityCostList = new List<UtilityCostDto>();

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            utilityCostList.Add(MapUtilityCost(reader));
                        }
                    }
                }
            }

            return utilityCostList;
        }
        #endregion      // GetUtilityCost() ... READ

        #region GetUtilityCostById() ... READ
        /// <summary>
        /// Retrieves (READ) a fired heater capital cost entry from the data store by its identifier.
        /// </summary>
        /// <param name="utilityCostId">The unique identifier of the utility cost entry to retrieve.</param>
        /// <returns>An <see cref="UtilityCostDto"/> object representing the requested utility cost entry, 
        /// or <c>null</c> if no matching entry is found.</returns>
        public UtilityCostDto GetUtilityCostById(Guid utilityCostId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        HP_SteamCost_Metric,
                                        MP_SteamCost_Metric,
                                        LP_SteamCost_Metric,
                                        CoolingWaterCost_Metric,
                                        ChilledWaterCost_Metric,
                                        FuelGasCost_Metric,
                                        HP_SteamCost_English,
                                        MP_SteamCost_English,
                                        LP_SteamCost_English,
                                        CoolingWaterCost_English,
                                        ChilledWaterCost_English,
                                        FuelGasCost_English,
                                        DutyUnits_Metric,
                                        DutyUnits_English
                                 FROM dbo.UtilityCost
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, utilityCostId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapUtilityCost(reader);
                    }
                }
            }
        }
        #endregion      // GetUtilityCostById() ... READ

        #region GetUtilityCostByProjectId() ... READ
        /// <summary>
        /// Retrieves (READ) a fired heater capital cost entry from the data store by its identifier.
        /// </summary>
        /// <param name="utilityCostId">The unique identifier of the utility cost entry to retrieve.</param>
        /// <returns>An <see cref="UtilityCostDto"/> object representing the requested utility cost entry, 
        /// or <c>null</c> if no matching entry is found.</returns>
        public UtilityCostDto GetUtilityCostByProjectId(Guid projectId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        HP_SteamCost_Metric,
                                        MP_SteamCost_Metric,
                                        LP_SteamCost_Metric,
                                        CoolingWaterCost_Metric,
                                        ChilledWaterCost_Metric,
                                        FuelGasCost_Metric,
                                        HP_SteamCost_English,
                                        MP_SteamCost_English,
                                        LP_SteamCost_English,
                                        CoolingWaterCost_English,
                                        ChilledWaterCost_English,
                                        FuelGasCost_English,
                                        DutyUnits_Metric,
                                        DutyUnits_English
                                 FROM dbo.UtilityCost
                                 WHERE ProjectId = @ProjectId;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProjectId", DbType.Guid, projectId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapUtilityCost(reader);
                    }
                }
            }
        }
        #endregion      // GetUtilityCostByProjectId() ... READ

        #region UpdateUtilityCost() ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing Fired Heater Capital Cost entry in the data store.
        /// </summary>
        /// <param name="utilityCostDto">The fired heater capital cost data to update.</param>
        public void UpdateUtilityCost(UtilityCostDto utilityCostDto)
        {
            if (utilityCostDto == null)
            {
                throw new ArgumentNullException(nameof(utilityCostDto));
            }

            const string sql = @"UPDATE dbo.UtilityCost
                                 SET ProjectId = @ProjectId,
                                     HP_SteamCost_Metric = @HP_SteamCost_Metric,
                                     MP_SteamCost_Metric = @MP_SteamCost_Metric,
                                     LP_SteamCost_Metric = @LP_SteamCost_Metric,
                                     CoolingWaterCost_Metric = @CoolingWaterCost_Metric,
                                     ChilledWaterCost_Metric = @ChilledWaterCost_Metric,
                                     FuelGasCost_Metric = @FuelGasCost_Metric,
                                     HP_SteamCost_English = @HP_SteamCost_English,
                                     MP_SteamCost_English = @MP_SteamCost_English,
                                     LP_SteamCost_English = @LP_SteamCost_English,
                                     CoolingWaterCost_English = @CoolingWaterCost_English,
                                     ChilledWaterCost_English = @ChilledWaterCost_English,
                                     FuelGasCost_English = @FuelGasCost_English,
                                     DutyUnits_Metric = @DutyUnits_Metric,
                                     DutyUnits_English = @DutyUnits_English
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, utilityCostDto.Id);
                    AddParameter(command, "@ProjectId", DbType.Guid, utilityCostDto.ProjectId);
                    AddParameter(command, "@HP_SteamCost_Metric", DbType.Double, utilityCostDto.HP_SteamCost_Metric);
                    AddParameter(command, "@MP_SteamCost_Metric", DbType.Double, utilityCostDto.MP_SteamCost_Metric);
                    AddParameter(command, "@LP_SteamCost_Metric", DbType.Double, utilityCostDto.LP_SteamCost_Metric);
                    AddParameter(command, "@CoolingWaterCost_Metric", DbType.Double, utilityCostDto.CoolingWaterCost_Metric);
                    AddParameter(command, "@ChilledWaterCost_Metric", DbType.Double, utilityCostDto.ChilledWaterCost_Metric);
                    AddParameter(command, "@FuelGasCost_Metric", DbType.Double, utilityCostDto.FuelGasCost_Metric);
                    AddParameter(command, "@HP_SteamCost_English", DbType.Double, utilityCostDto.HP_SteamCost_English);
                    AddParameter(command, "@MP_SteamCost_English", DbType.Double, utilityCostDto.MP_SteamCost_English);
                    AddParameter(command, "@LP_SteamCost_English", DbType.Double, utilityCostDto.LP_SteamCost_English);
                    AddParameter(command, "@CoolingWaterCost_English", DbType.Double, utilityCostDto.CoolingWaterCost_English);
                    AddParameter(command, "@ChilledWaterCost_English", DbType.Double, utilityCostDto.ChilledWaterCost_English);
                    AddParameter(command, "@FuelGasCost_English", DbType.Double, utilityCostDto.FuelGasCost_English);
                    AddParameter(command, "@DutyUnits_Metric", DbType.String, utilityCostDto.DutyUnits_Metric);
                    AddParameter(command, "@DutyUnits_English", DbType.String, utilityCostDto.DutyUnits_English);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateUtilityCost() ... UPDATE

        #region DeleteUtilityCost() ... DELETE
        /// <summary>
        /// Deletes (DELETE) a utility cost entry from the data store by its identifier.
        /// </summary>
        /// <param name="utilityCostId">The unique identifier of the utility cost entry to delete.</param>
        public void DeleteUtilityCost(Guid utilityCostId)
        {
            const string sql = @"DELETE FROM dbo.UtilityCost
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, utilityCostId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // DeleteUtilityCost() ... DELETE

        #endregion      // METHODS

    }
    #endregion      // public class UtilityCostRepo
}
#endregion      // namespace HenModel.RepoImplementations.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
