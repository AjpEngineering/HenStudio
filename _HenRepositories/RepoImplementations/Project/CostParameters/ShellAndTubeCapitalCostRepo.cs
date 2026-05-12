#region HEADER
//#####################################################################################################################
//############################  S h e l l A n d T u b e C a p i t a l C o s t R e p o . c s  ##########################
//#####################################################################################################################
//  FILENAME:  ShellAndTubeCapitalCostRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Project.CostParameters
//  CLASS(S):  ShellAndTubeCapitalCostRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation for the Shell And Tube Capital Cost Parameters Object.
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
    #region public class ShellAndTubeCapitalCostRepo
    /// <summary>
    /// Shell And Tube Capital Cost Repo Class
    /// </summary>
    public class ShellAndTubeCapitalCostRepo : IShellAndTubeCapitalCostRepo
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

        #region MapShellAndTubeCapitalCost()
        /// <summary>
        /// Maps a data record from the Shell And Tube Capital Cost query result set to an <see cref="ShellAndTubeCapitalCostDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the shell and tube capital cost column values.</param>
        /// <returns>An <see cref="ShellAndTubeCapitalCostDto"/> populated from the supplied data record.</returns>
        private static ShellAndTubeCapitalCostDto MapShellAndTubeCapitalCost(IDataRecord record)
        {
            return new ShellAndTubeCapitalCostDto
            {
                Id = record.GetGuid(record.GetOrdinal("Id")),
                ProjectId = record.GetGuid(record.GetOrdinal("ProjectId")),
                ParameterA = record.GetDouble(record.GetOrdinal("ParameterA")),
                ParameterB_Metric = record.GetDouble(record.GetOrdinal("ParameterB_Metric")),
                ParameterB_English = record.GetDouble(record.GetOrdinal("ParameterB_English")),
                ParameterN = record.GetDouble(record.GetOrdinal("ParameterN")),
                MaterialFactor = record.GetDouble(record.GetOrdinal("MaterialFactor")),
                AreaUnits_Metric = record.IsDBNull(record.GetOrdinal("AreaUnits_Metric")) ? null : record.GetString(record.GetOrdinal("AreaUnits_Metric")),
                AreaUnits_English = record.IsDBNull(record.GetOrdinal("AreaUnits_English")) ? null : record.GetString(record.GetOrdinal("AreaUnits_English")),
            };
        }
        #endregion      // MapShellAndTubeCapitalCost()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public ShellAndTubeCapitalCostRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region AddShellAndTubeCapitalCost() ... CREATE
        /// <summary>
        /// Adds (CREATE) a new shell and tube capital cost entry to the data store.
        /// </summary>
        /// <param name="shellAndTubeCapitalCostDto">The shell and tube capital cost data to insert.</param>
        /// <returns>The unique identifier of the inserted shell and tube capital cost entry.</returns>
        public Guid AddShellAndTubeCapitalCost(ShellAndTubeCapitalCostDto shellAndTubeCapitalCostDto)
        {
            if (shellAndTubeCapitalCostDto == null)
            {
                throw new ArgumentNullException(nameof(shellAndTubeCapitalCostDto));
            }

            const string sql = @"INSERT INTO dbo.ShellAndTubeCapitalCost
                                    (ProjectId,
                                     ParameterA,
                                     ParameterB_Metric,
                                     ParameterB_English,
                                     ParameterN,
                                     MaterialFactor,
                                     AreaUnits_Metric,
                                     AreaUnits_English)
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@ProjectId,
                                     @ParameterA,
                                     @ParameterB_Metric,
                                     @ParameterB_English,
                                     @ParameterN,
                                     @MaterialFactor,
                                     @AreaUnits_Metric,
                                     @AreaUnits_English);";
            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProjectId", DbType.Guid, shellAndTubeCapitalCostDto.ProjectId);
                    AddParameter(command, "@ParameterA", DbType.Double, shellAndTubeCapitalCostDto.ParameterA);
                    AddParameter(command, "@ParameterB_Metric", DbType.Double, shellAndTubeCapitalCostDto.ParameterB_Metric);
                    AddParameter(command, "@ParameterB_English", DbType.Double, shellAndTubeCapitalCostDto.ParameterB_English);
                    AddParameter(command, "@ParameterN", DbType.Double, shellAndTubeCapitalCostDto.ParameterN);
                    AddParameter(command, "@MaterialFactor", DbType.Double, shellAndTubeCapitalCostDto.MaterialFactor);
                    AddParameter(command, "@AreaUnits_Metric", DbType.String, shellAndTubeCapitalCostDto.AreaUnits_Metric);
                    AddParameter(command, "@AreaUnits_English", DbType.String, shellAndTubeCapitalCostDto.AreaUnits_English);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddShellAndTubeCapitalCost() ... CREATE

        #region GetShellAndTubeCapitalCost() ... READ
        /// <summary>
        /// Retrieves (READ) all fired heater capital costs from the data store.
        /// </summary>
        /// <returns>A list of <see cref="FiredHeaterCapitalCostDto"/> objects representing all fired heater capital costs. 
        /// The list is empty if no fired heater capital costs are found.</returns>
        public IList<ShellAndTubeCapitalCostDto> GetShellAndTubeCapitalCost()
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        ParameterA,
                                        ParameterB_Metric,
                                        ParameterB_English,
                                        ParameterN,
                                        MaterialFactor,
                                        AreaUnits_Metric,
                                        AreaUnits_English
                                 FROM dbo.ShellAndTubeCapitalCost
                                 ORDER BY ProjectId;";

            List<ShellAndTubeCapitalCostDto> shellAndTubeCapitalCostList = new List<ShellAndTubeCapitalCostDto>();

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
                            shellAndTubeCapitalCostList.Add(MapShellAndTubeCapitalCost(reader));
                        }
                    }
                }
            }

            return shellAndTubeCapitalCostList;
        }
        #endregion      // GetShellAndTubeCapitalCost() ... READ

        #region GetShellAndTubeCapitalCostById() ... READ
        /// <summary>
        /// Retrieves (READ) a shell and tube capital cost entry from the data store by its unique identifier.
        /// </summary>
        /// <param name="shellAndTubeCapitalCostId">The unique identifier of the shell and tube capital cost entry to be retrieved.</param>
        /// <returns>A <see cref="ShellAndTubeCapitalCostDto"/> object representing the matching shell and tube capital cost entry. 
        /// <c>null</c> if no matching entry is found.</returns>
        public ShellAndTubeCapitalCostDto GetShellAndTubeCapitalCostById(Guid shellAndTubeCapitalCostId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        ParameterA,
                                        ParameterB_Metric,
                                        ParameterB_English,
                                        ParameterN,
                                        MaterialFactor,
                                        AreaUnits_Metric,
                                        AreaUnits_English
                                 FROM dbo.ShellAndTubeCapitalCost
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, shellAndTubeCapitalCostId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapShellAndTubeCapitalCost(reader);
                    }
                }
            }
        }
        #endregion      // GetShellAndTubeCapitalCostById() ... READ

        #region GetShellAndTubeCapitalCostByProjectId() ... READ
        /// <summary>
        /// Retrieves (READ) a shell and tube capital cost entry from the data store by its project identifier.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project whose shell and tube capital cost entry is to be retrieved.</param>
        /// <returns>A <see cref="ShellAndTubeCapitalCostDto"/> object representing the requested shell and tube capital cost entry, 
        /// or <c>null</c> if no matching entry is found.</returns>
        public ShellAndTubeCapitalCostDto GetShellAndTubeCapitalCostByProjectId(Guid projectId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        ParameterA,
                                        ParameterB_Metric,
                                        ParameterB_English,
                                        ParameterN,
                                        MaterialFactor,
                                        AreaUnits_Metric,
                                        AreaUnits_English
                                 FROM dbo.ShellAndTubeCapitalCost
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

                        return MapShellAndTubeCapitalCost(reader);
                    }
                }
            }
        }
        #endregion      // GetShellAndTubeCapitalCostByProjectId() ... READ

        #region UpdateShellAndTubeCapitalCost() ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing shell and tube capital cost entry in the data store.
        /// </summary>
        /// <param name="shellAndTubeCapitalCostDto">The shell and tube capital cost data to update.</param>
        public void UpdateShellAndTubeCapitalCost(ShellAndTubeCapitalCostDto shellAndTubeCapitalCostDto)
        {
            if (shellAndTubeCapitalCostDto == null)
            {
                throw new ArgumentNullException(nameof(shellAndTubeCapitalCostDto));
            }

            const string sql = @"UPDATE dbo.ShellAndTubeCapitalCost
                                 SET ParameterA = @ParameterA,
                                     ParameterB_Metric = @ParameterB_Metric,
                                     ParameterB_English = @ParameterB_English,
                                     ParameterN = @ParameterN,
                                     MaterialFactor = @MaterialFactor,
                                     AreaUnits_Metric = @AreaUnits_Metric,
                                     AreaUnits_English = @AreaUnits_English
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, shellAndTubeCapitalCostDto.Id);
                    AddParameter(command, "@ParameterA", DbType.Double, shellAndTubeCapitalCostDto.ParameterA);
                    AddParameter(command, "@ParameterB_Metric", DbType.Double, shellAndTubeCapitalCostDto.ParameterB_Metric);
                    AddParameter(command, "@ParameterB_English", DbType.Double, shellAndTubeCapitalCostDto.ParameterB_English);
                    AddParameter(command, "@ParameterN", DbType.Double, shellAndTubeCapitalCostDto.ParameterN);
                    AddParameter(command, "@MaterialFactor", DbType.Double, shellAndTubeCapitalCostDto.MaterialFactor);
                    AddParameter(command, "@AreaUnits_Metric", DbType.String, shellAndTubeCapitalCostDto.AreaUnits_Metric);
                    AddParameter(command, "@AreaUnits_English", DbType.String, shellAndTubeCapitalCostDto.AreaUnits_English);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateShellAndTubeCapitalCost() ... UPDATE

        #region DeleteShellAndTubeCapitalCost() ... DELETE
        /// <summary>
        /// Deletes (DELETE) a shell and tube capital cost entry from the data store by its identifier.
        /// </summary>
        /// <param name="shellAndTubeCapitalCostId">The unique identifier of the shell and tube capital cost entry to delete.</param>
        public void DeleteShellAndTubeCapitalCost(Guid shellAndTubeCapitalCostId)
        {
            const string sql = @"DELETE FROM dbo.ShellAndTubeCapitalCost
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, shellAndTubeCapitalCostId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // DeleteShellAndTubeCapitalCost() ... DELETE

        #endregion      // METHODS
    }
    #endregion      // public class ShellAndTubeCapitalCostRepo
}
#endregion      // namespace HenModel.RepoImplementations.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
