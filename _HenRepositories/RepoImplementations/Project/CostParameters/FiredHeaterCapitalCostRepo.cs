#region HEADER
//#####################################################################################################################
//#############################  F i r e d H e a t e r C a p i t a l C o s t R e p o . c s  ###########################
//#####################################################################################################################
//  FILENAME:  FiredHeaterCapitalCostRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Project.CostParameters
//  CLASS(S):  FiredHeaterCapitalCostRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation for the Fired Heater Capital Cost Parameters Object.
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
    #region public class FiredHeaterCapitalCostRepo
    /// <summary>
    /// Fired Heater Capital Cost Repo Class
    /// </summary>
    public class FiredHeaterCapitalCostRepo : IFiredHeaterCapitalCostRepo
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

        #region MapFiredHeaterCapitalCost()
        /// <summary>
        /// Maps a data record from the Fired Heater Capital Cost query result set to an <see cref="FiredHeaterCapitalCostDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the fired heater capital cost column values.</param>
        /// <returns>An <see cref="FiredHeaterCapitalCostDto"/> populated from the supplied data record.</returns>
        private static FiredHeaterCapitalCostDto MapFiredHeaterCapitalCost(IDataRecord record)
        {
            return new FiredHeaterCapitalCostDto
            {
                Id = record.GetGuid(record.GetOrdinal("Id")),
                ProjectId = record.GetGuid(record.GetOrdinal("ProjectId")),
                ParameterAlpha_Metric = record.GetDouble(record.GetOrdinal("ParameterAlpha_Metric")),
                ParameterAlpha_English = record.GetDouble(record.GetOrdinal("ParameterAlpha_English")),
                ParameterBeta = record.GetDouble(record.GetOrdinal("ParameterBeta")),
                Efficiency = record.GetDouble(record.GetOrdinal("Efficiency")),
                DutyUnits_Metric = record.IsDBNull(record.GetOrdinal("DutyUnits_Metric")) ? null : record.GetString(record.GetOrdinal("DutyUnits_Metric")),
                DutyUnits_English = record.IsDBNull(record.GetOrdinal("DutyUnits_English")) ? null : record.GetString(record.GetOrdinal("DutyUnits_English")),
            };
        }
        #endregion      // MapFiredHeaterCapitalCost()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public FiredHeaterCapitalCostRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region AddFiredHeaterCapitalCost() ... CREATE
        /// <summary>
        /// Adds (CREATE) a new fired heater capital cost entry to the data store.
        /// </summary>
        /// <param name="firedHeaterCapitalCostDto">The fired heater capital cost data to insert.</param>
        /// <returns>The unique identifier of the inserted fired heater capital cost entry.</returns>
        public Guid AddFiredHeaterCapitalCost(FiredHeaterCapitalCostDto firedHeaterCapitalCostDto)
        {
            if (firedHeaterCapitalCostDto == null)
            {
                throw new ArgumentNullException(nameof(firedHeaterCapitalCostDto));
            }

            const string sql = @"INSERT INTO dbo.FiredHeaterCapitalCost
                                    (ProjectId,
                                     ParameterAlpha_Metric,
                                     ParameterAlpha_English,
                                     ParameterBeta,
                                     Efficiency,
                                     DutyUnits_Metric,
                                     DutyUnits_English)
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@ProjectId,
                                     @ParameterAlpha_Metric,
                                     @ParameterAlpha_English,
                                     @ParameterBeta,
                                     @Efficiency,
                                     @DutyUnits_Metric,
                                     @DutyUnits_English);";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProjectId", DbType.Guid, firedHeaterCapitalCostDto.ProjectId);
                    AddParameter(command, "@ParameterAlpha_Metric", DbType.Double, firedHeaterCapitalCostDto.ParameterAlpha_Metric);
                    AddParameter(command, "@ParameterAlpha_English", DbType.Double, firedHeaterCapitalCostDto.ParameterAlpha_English);
                    AddParameter(command, "@ParameterBeta", DbType.Double, firedHeaterCapitalCostDto.ParameterBeta);
                    AddParameter(command, "@Efficiency", DbType.Double, firedHeaterCapitalCostDto.Efficiency);
                    AddParameter(command, "@DutyUnits_Metric", DbType.String, firedHeaterCapitalCostDto.DutyUnits_Metric);
                    AddParameter(command, "@DutyUnits_English", DbType.String, firedHeaterCapitalCostDto.DutyUnits_English);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddFiredHeaterCapitalCost() ... CREATE

        #region GetFiredHeaterCapitalCost() ... READ
        /// <summary>
        /// Retrieves (READ) all fired heater capital costs from the data store.
        /// </summary>
        /// <returns>A list of <see cref="FiredHeaterCapitalCostDto"/> objects representing all fired heater capital costs. 
        /// The list is empty if no fired heater capital costs are found.</returns>
        public IList<FiredHeaterCapitalCostDto> GetFiredHeaterCapitalCost()
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        ParameterAlpha_Metric,
                                        ParameterAlpha_English,
                                        ParameterBeta,
                                        Efficiency,
                                        DutyUnits_Metric,
                                        DutyUnits_English
                                 FROM dbo.FiredHeaterCapitalCost
                                 ORDER BY ProjectId;";

            List<FiredHeaterCapitalCostDto> firedHeaterCapitalCostList = new List<FiredHeaterCapitalCostDto>();

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
                            firedHeaterCapitalCostList.Add(MapFiredHeaterCapitalCost(reader));
                        }
                    }
                }
            }

            return firedHeaterCapitalCostList;
        }
        #endregion      // GetFiredHeaterCapitalCost() ... READ

        #region GetFiredHeaterCapitalCostById() ... READ
        /// <summary>
        /// Retrieves (READ) a fired heater capital cost entry from the data store by its identifier.
        /// </summary>
        /// <param name="firedHeaterCapitalCostId">The unique identifier of the fired heater capital cost entry to retrieve.</param>
        /// <returns>An <see cref="FiredHeaterCapitalCostDto"/> object representing the requested fired heater capital cost entry, 
        /// or <c>null</c> if no matching entry is found.</returns>
        public FiredHeaterCapitalCostDto GetFiredHeaterCapitalCostById(Guid firedHeaterCapitalCostId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        ParameterAlpha_Metric,
                                        ParameterAlpha_English,
                                        ParameterBeta,
                                        Efficiency,
                                        DutyUnits_Metric,
                                        DutyUnits_English
                                 FROM dbo.FiredHeaterCapitalCost
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, firedHeaterCapitalCostId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapFiredHeaterCapitalCost(reader);
                    }
                }
            }
        }
        #endregion      // GetFiredHeaterCapitalCostById() ... READ

        #region GetFiredHeaterCapitalCostByProjectId() ... READ
        /// <summary>
        /// Retrieves (READ) a fired heater capital cost entry from the data store by its Project identifier.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project whose fired heater capital cost entry is to be retrieved.</param>
        /// <returns>A <see cref="FiredHeaterCapitalCostDto"/> object representing the matching fired heater capital cost entry. 
        /// <c>null</c> if no matching entry is found.</returns>
        public FiredHeaterCapitalCostDto GetFiredHeaterCapitalCostByProjectId(Guid projectId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        ParameterAlpha_Metric,
                                        ParameterAlpha_English,
                                        ParameterBeta,
                                        Efficiency,
                                        DutyUnits_Metric,
                                        DutyUnits_English
                                 FROM dbo.FiredHeaterCapitalCost
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

                        return MapFiredHeaterCapitalCost(reader);
                    }
                }
            }
        }
        #endregion      // GetFiredHeaterCapitalCostByProjectId() ... READ

        #region UpdateFiredHeaterCapitalCost() ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing Fired Heater Capital Cost entry in the data store.
        /// </summary>
        /// <param name="firedHeaterCapitalCostDto">The fired heater capital cost data to update.</param>
        public void UpdateFiredHeaterCapitalCost(FiredHeaterCapitalCostDto firedHeaterCapitalCostDto)
        {
            if (firedHeaterCapitalCostDto == null)
            {
                throw new ArgumentNullException(nameof(firedHeaterCapitalCostDto));
            }

            const string sql = @"UPDATE dbo.FiredHeaterCapitalCost
                                 SET ParameterAlpha_Metric = @ParameterAlpha_Metric,
                                     ParameterAlpha_English = @ParameterAlpha_English,
                                     ParameterBeta = @ParameterBeta,
                                     Efficiency = @Efficiency,
                                     DutyUnits_Metric = @DutyUnits_Metric,
                                     DutyUnits_English = @DutyUnits_English
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, firedHeaterCapitalCostDto.Id);
                    AddParameter(command, "@ParameterAlpha_Metric", DbType.Double, firedHeaterCapitalCostDto.ParameterAlpha_Metric);
                    AddParameter(command, "@ParameterAlpha_English", DbType.Double, firedHeaterCapitalCostDto.ParameterAlpha_English);
                    AddParameter(command, "@ParameterBeta", DbType.Double, firedHeaterCapitalCostDto.ParameterBeta);
                    AddParameter(command, "@Efficiency", DbType.Double, firedHeaterCapitalCostDto.Efficiency);
                    AddParameter(command, "@DutyUnits_Metric", DbType.String, firedHeaterCapitalCostDto.DutyUnits_Metric);
                    AddParameter(command, "@DutyUnits_English", DbType.String, firedHeaterCapitalCostDto.DutyUnits_English);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateFiredHeaterCapitalCost() ... UPDATE

        #region DeleteFiredHeaterCapitalCost() ... DELETE
        /// <summary>
        /// Deletes (DELETE) a fired heater capital cost entry from the data store by its identifier.
        /// </summary>
        /// <param name="firedHeaterCapitalCostId">The unique identifier of the fired heater capital cost entry to delete.</param>
        public void DeleteFiredHeaterCapitalCost(Guid firedHeaterCapitalCostId)
        {
            const string sql = @"DELETE FROM dbo.FiredHeaterCapitalCost
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, firedHeaterCapitalCostId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // DeleteFiredHeaterCapitalCost() ... DELETE

        #endregion      // METHODS
    }
    #endregion      // public class FiredHeaterCapitalCostRepo
}
#endregion      // namespace HenModel.RepoImplementations.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
