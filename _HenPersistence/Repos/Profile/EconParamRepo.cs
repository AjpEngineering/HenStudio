#region HEADER
//#####################################################################################################################
//##########################################  E c o n P a r a m R e p o . c s  ########################################
//#####################################################################################################################
//  FILENAME:  EconParamRepo.cs
//  NAMESPACE: HenPersistence.Repos
//  CLASS(S):  EconParamRepo
//  COMPONENT: _HenPersistence.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the EconParam Profile sub table.
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
    #region public class EconParamRepo
    /// <summary>
    /// EconParam Repo Class
    /// </summary>
    public class EconParamRepo : IEconParamRepo
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

        #region MapEconParam()
        /// <summary>
        /// Maps a data record from the economic parameters query result set to an <see cref="EconParamDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the economic parameter column values.</param>
        /// <returns>An <see cref="EconParamDto"/> populated from the supplied data record.</returns>
        private static EconParamDto MapEconParam(IDataRecord record)
        {
            return new EconParamDto
            {
                Id = record.GetGuid(record.GetOrdinal("Id")),
                ProfileId = record.GetGuid(record.GetOrdinal("ProfileId")),
                CapitalCostIndexName = record.IsDBNull(record.GetOrdinal("CapitalCostIndexName")) ? null : record.GetString(record.GetOrdinal("CapitalCostIndexName")),
                CapitalCostIndexC1 = record.GetDouble(record.GetOrdinal("CapitalCostIndexC1")),
                CapitalCostIndexC2 = record.GetDouble(record.GetOrdinal("CapitalCostIndexC2")),
                CapitalCostIndexC3 = record.GetDouble(record.GetOrdinal("CapitalCostIndexC3")),
                CapitalCostIndexConfiguration = record.IsDBNull(record.GetOrdinal("CapitalCostIndexConfiguration")) ? null : record.GetString(record.GetOrdinal("CapitalCostIndexConfiguration")),
                RateOfReturn = record.GetDouble(record.GetOrdinal("RateOfReturn")),
                ProjectLifetime = record.GetInt32(record.GetOrdinal("ProjectLifetime"))
            };
        }
        #endregion      // MapEconParam()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public EconParamRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region GetEconParams()
        /// <summary>
        /// Retrieves all economic parameters from the data store.
        /// </summary>
        /// <returns>A list of <see cref="EconParamDto"/> objects representing all economic parameters. The list is empty if no economic parameters are found.</returns>
        public IList<EconParamDto> GetEconParams()
        {
            const string sql = @"SELECT Id,
                                        ProfileId,
                                        CapitalCostIndexName,
                                        CapitalCostIndexC1,
                                        CapitalCostIndexC2,
                                        CapitalCostIndexC3,
                                        CapitalCostIndexConfiguration,
                                        RateOfReturn,
                                        ProjectLifetime
                                 FROM dbo.EconParam
                                 ORDER BY CapitalCostIndexName;";

            List<EconParamDto> econParams = new List<EconParamDto>();

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
                            econParams.Add(MapEconParam(reader));
                        }
                    }
                }
            }

            return econParams;
        }
        #endregion      // GetEconParams()

        #region GetEconParamsByProfileId()
        /// <summary>
        /// Retrieves all economic parameters for the specified profile from the data store.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile whose economic parameters are to be retrieved.</param>
        /// <returns>A list of <see cref="EconParamDto"/> objects representing the matching economic parameters. The list is empty if no economic parameters are found.</returns>
        public IList<EconParamDto> GetEconParamsByProfileId(Guid profileId)
        {
            const string sql = @"SELECT Id,
                                        ProfileId,
                                        CapitalCostIndexName,
                                        CapitalCostIndexC1,
                                        CapitalCostIndexC2,
                                        CapitalCostIndexC3,
                                        CapitalCostIndexConfiguration,
                                        RateOfReturn,
                                        ProjectLifetime
                                 FROM dbo.EconParam
                                 WHERE ProfileId = @ProfileId
                                 ORDER BY CapitalCostIndexName;";

            List<EconParamDto> econParams = new List<EconParamDto>();

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProfileId", DbType.Guid, profileId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            econParams.Add(MapEconParam(reader));
                        }
                    }
                }
            }

            return econParams;
        }
        #endregion      // GetEconParamsByProfileId()

        #region GetEconParamById()
        /// <summary>
        /// Retrieves an economic parameter from the data store by its identifier.
        /// </summary>
        /// <param name="econParamId">The unique identifier of the economic parameter to retrieve.</param>
        /// <returns>An <see cref="EconParamDto"/> object representing the requested economic parameter, or <c>null</c> if no matching economic parameter is found.</returns>
        public EconParamDto GetEconParamById(Guid econParamId)
        {
            const string sql = @"SELECT Id,
                                        ProfileId,
                                        CapitalCostIndexName,
                                        CapitalCostIndexC1,
                                        CapitalCostIndexC2,
                                        CapitalCostIndexC3,
                                        CapitalCostIndexConfiguration,
                                        RateOfReturn,
                                        ProjectLifetime
                                 FROM dbo.EconParam
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, econParamId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapEconParam(reader);
                    }
                }
            }
        }
        #endregion      // GetEconParamById()

        #region GetEconParamByName()
        /// <summary>
        /// Retrieves an economic parameter from the data store by its profile identifier and capital cost index name.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile that owns the economic parameter.</param>
        /// <param name="capitalCostIndexName">The capital cost index name to retrieve.</param>
        /// <returns>An <see cref="EconParamDto"/> object representing the requested economic parameter, or <c>null</c> if no matching economic parameter is found.</returns>
        public EconParamDto GetEconParamByName(Guid profileId, string capitalCostIndexName)
        {
            if (String.IsNullOrWhiteSpace(capitalCostIndexName))
            {
                throw new ArgumentException("Capital cost index name cannot be null or whitespace.", nameof(capitalCostIndexName));
            }

            const string sql = @"SELECT Id,
                                        ProfileId,
                                        CapitalCostIndexName,
                                        CapitalCostIndexC1,
                                        CapitalCostIndexC2,
                                        CapitalCostIndexC3,
                                        CapitalCostIndexConfiguration,
                                        RateOfReturn,
                                        ProjectLifetime
                                 FROM dbo.EconParam
                                 WHERE ProfileId = @ProfileId
                                   AND CapitalCostIndexName = @CapitalCostIndexName;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProfileId", DbType.Guid, profileId);
                    AddParameter(command, "@CapitalCostIndexName", DbType.String, capitalCostIndexName);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapEconParam(reader);
                    }
                }
            }
        }
        #endregion      // GetEconParamByName()

        #region AddEconParam()
        /// <summary>
        /// Adds a new economic parameter to the data store.
        /// </summary>
        /// <param name="econParamDto">The economic parameter data to insert.</param>
        /// <returns>The unique identifier of the inserted economic parameter.</returns>
        public Guid AddEconParam(EconParamDto econParamDto)
        {
            if (econParamDto == null)
            {
                throw new ArgumentNullException(nameof(econParamDto));
            }

            const string sql = @"INSERT INTO dbo.EconParam
                                    (ProfileId,
                                     CapitalCostIndexName,
                                     CapitalCostIndexC1,
                                     CapitalCostIndexC2,
                                     CapitalCostIndexC3,
                                     CapitalCostIndexConfiguration,
                                     RateOfReturn,
                                     ProjectLifetime)
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@ProfileId,
                                     @CapitalCostIndexName,
                                     @CapitalCostIndexC1,
                                     @CapitalCostIndexC2,
                                     @CapitalCostIndexC3,
                                     @CapitalCostIndexConfiguration,
                                     @RateOfReturn,
                                     @ProjectLifetime);";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProfileId", DbType.Guid, econParamDto.ProfileId);
                    AddParameter(command, "@CapitalCostIndexName", DbType.String, econParamDto.CapitalCostIndexName);
                    AddParameter(command, "@CapitalCostIndexC1", DbType.Double, econParamDto.CapitalCostIndexC1);
                    AddParameter(command, "@CapitalCostIndexC2", DbType.Double, econParamDto.CapitalCostIndexC2);
                    AddParameter(command, "@CapitalCostIndexC3", DbType.Double, econParamDto.CapitalCostIndexC3);
                    AddParameter(command, "@CapitalCostIndexConfiguration", DbType.String, econParamDto.CapitalCostIndexConfiguration);
                    AddParameter(command, "@RateOfReturn", DbType.Double, econParamDto.RateOfReturn);
                    AddParameter(command, "@ProjectLifetime", DbType.Int32, econParamDto.ProjectLifetime);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddEconParam()

        #region UpdateEconParam()
        /// <summary>
        /// Updates an existing economic parameter in the data store.
        /// </summary>
        /// <param name="econParamDto">The economic parameter data to update.</param>
        public void UpdateEconParam(EconParamDto econParamDto)
        {
            if (econParamDto == null)
            {
                throw new ArgumentNullException(nameof(econParamDto));
            }

            const string sql = @"UPDATE dbo.EconParam
                                 SET ProfileId = @ProfileId,
                                     CapitalCostIndexName = @CapitalCostIndexName,
                                     CapitalCostIndexC1 = @CapitalCostIndexC1,
                                     CapitalCostIndexC2 = @CapitalCostIndexC2,
                                     CapitalCostIndexC3 = @CapitalCostIndexC3,
                                     CapitalCostIndexConfiguration = @CapitalCostIndexConfiguration,
                                     RateOfReturn = @RateOfReturn,
                                     ProjectLifetime = @ProjectLifetime
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, econParamDto.Id);
                    AddParameter(command, "@ProfileId", DbType.Guid, econParamDto.ProfileId);
                    AddParameter(command, "@CapitalCostIndexName", DbType.String, econParamDto.CapitalCostIndexName);
                    AddParameter(command, "@CapitalCostIndexC1", DbType.Double, econParamDto.CapitalCostIndexC1);
                    AddParameter(command, "@CapitalCostIndexC2", DbType.Double, econParamDto.CapitalCostIndexC2);
                    AddParameter(command, "@CapitalCostIndexC3", DbType.Double, econParamDto.CapitalCostIndexC3);
                    AddParameter(command, "@CapitalCostIndexConfiguration", DbType.String, econParamDto.CapitalCostIndexConfiguration);
                    AddParameter(command, "@RateOfReturn", DbType.Double, econParamDto.RateOfReturn);
                    AddParameter(command, "@ProjectLifetime", DbType.Int32, econParamDto.ProjectLifetime);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateEconParam()

        #region DeleteEconParam()
        /// <summary>
        /// Deletes an economic parameter from the data store by its identifier.
        /// </summary>
        /// <param name="econParamId">The unique identifier of the economic parameter to delete.</param>
        public void DeleteEconParam(Guid econParamId)
        {
            const string sql = @"DELETE FROM dbo.EconParam
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, econParamId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // DeleteEconParam()

        #endregion      // METHODS
    }
    #endregion      // public class EconParamRepo
}
#endregion      // namespace HenPersistence.Repos

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
