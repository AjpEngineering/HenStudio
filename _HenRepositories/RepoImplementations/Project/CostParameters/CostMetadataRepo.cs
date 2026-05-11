#region HEADER
//#####################################################################################################################
//#######################################  C o s t M e t a d a t a R e p o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  CostMetadataRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Project.CostParameters
//  CLASS(S):  CostMetadataRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the Cost Metadata Project-Cost Parameters sub table.
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
    #region public class CostMetadataRepo
    /// <summary>
    /// EconParam Repo Class
    /// </summary>
    public class CostMetadataRepo : ICostMetadataRepo
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

        #region MapCostMetadata()
        /// <summary>
        /// Maps a data record from the Cost Metadata query result set to an <see cref="CostMetadataDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the cost metadata column values.</param>
        /// <returns>An <see cref="CostMetadataDto"/> populated from the supplied data record.</returns>
        private static CostMetadataDto MapCostMetadata(IDataRecord record)
        {
            return new CostMetadataDto
            {
                Id = record.GetGuid(record.GetOrdinal("Id")),
                ProjectId = record.GetGuid(record.GetOrdinal("ProjectId")),
                CostIndexBaseYear = record.IsDBNull(record.GetOrdinal("CostIndexBaseYear")) ? null : record.GetString(record.GetOrdinal("CostIndexBaseYear")),
                CostIndexName = record.IsDBNull(record.GetOrdinal("CostIndexName")) ? null : record.GetString(record.GetOrdinal("CostIndexName")),
                CostIndexValue = record.GetDouble(record.GetOrdinal("CostIndexValue")),
                CostIndexCurrency = record.IsDBNull(record.GetOrdinal("CostIndexCurrency")) ? null : record.GetString(record.GetOrdinal("CostIndexCurrency")),
                CostIndexInstalledCost = record.GetDouble(record.GetOrdinal("CostIndexInstalledCost")),
            };
        }
        #endregion      // MapCostMetadata()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public CostMetadataRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region AddCostMetadata() ... CREATE
        /// <summary>
        /// Adds (CREATE) a new cost metadata entry to the data store.
        /// </summary>
        /// <param name="costMetadataDto">The cost metadata data to insert.</param>
        /// <returns>The unique identifier of the inserted cost metadata entry.</returns>
        public Guid AddCostMetadata(CostMetadataDto costMetadataDto)
        {
            if (costMetadataDto == null)
            {
                throw new ArgumentNullException(nameof(costMetadataDto));
            }

            const string sql = @"INSERT INTO dbo.CostMetadata
                                    (ProfileId,
                                     CostIndexBaseYear,
                                     CostIndexName,
                                     CostIndexValue,
                                     CostIndexCurrency,
                                     CostIndexInstalledCost)
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@ProfileId,
                                     @CostIndexBaseYear,
                                     @CostIndexName,
                                     @CostIndexValue,
                                     @CostIndexCurrency,
                                     @CostIndexInstalledCost);";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProjectId", DbType.Guid, costMetadataDto.ProjectId);
                    AddParameter(command, "@CostIndexBaseYear", DbType.String, costMetadataDto.CostIndexBaseYear);
                    AddParameter(command, "@CostIndexName", DbType.String, costMetadataDto.CostIndexName);
                    AddParameter(command, "@CostIndexValue", DbType.Double, costMetadataDto.CostIndexValue);
                    AddParameter(command, "@CostIndexCurrency", DbType.String, costMetadataDto.CostIndexCurrency);
                    AddParameter(command, "@CostIndexInstalledCost", DbType.Double, costMetadataDto.CostIndexInstalledCost);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddEconParam() ... CREATE

        #region GetCostMetadata() ... READ
        /// <summary>
        /// Retrieves (READ)all cost metadata from the data store.
        /// </summary>
        /// <returns>A list of <see cref="CostMetadataDto"/> objects representing all cost metadata. The list is empty if no cost metadata are found.</returns>
        public IList<CostMetadataDto> GetCostMetadata()
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        CostIndexBaseYear,
                                        CostIndexName,
                                        CostIndexValue,
                                        CostIndexCurrency,
                                        CostIndexInstalledCost
                                 FROM dbo.CostMetadata
                                 ORDER BY CostIndexName;";

            List<CostMetadataDto> econParams = new List<CostMetadataDto>();

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
                            econParams.Add(MapCostMetadata(reader));
                        }
                    }
                }
            }

            return econParams;
        }
        #endregion      // GetCostMetadata() ... READ

        #region GetCostMetadataById() ... READ
        /// <summary>
        /// Retrieves (READ) a cost metadata entry from the data store by its identifier.
        /// </summary>
        /// <param name="costMetadataId">The unique identifier of the cost metadata entry to retrieve.</param>
        /// <returns>An <see cref="CostMetadataDto"/> object representing the requested cost metadata entry, or <c>null</c> if no matching entry is found.</returns>
        public CostMetadataDto GetCostMetadataById(Guid costMetadataId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        CostIndexBaseYear,
                                        CostIndexName,
                                        CostIndexValue,
                                        CostIndexCurrency,
                                        CostIndexInstalledCost
                                 FROM dbo.CostMetadata
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, costMetadataId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapCostMetadata(reader);
                    }
                }
            }
        }
        #endregion      // GetCostMetadataById() ... READ

        #region GetCostMetadataByProjectId() ... READ
        /// <summary>
        /// Retrieves (READ) all cost metadata for the specified project from the data store.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project whose cost metadata are to be retrieved.</param>
        /// <returns>A list of <see cref="CostMetadataDto"/> objects representing the matching cost metadata. The list is empty if no cost metadata are found.</returns>
        public CostMetadataDto GetCostMetadataByProjectId(Guid projectId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        CostIndexBaseYear,
                                        CostIndexName,
                                        CostIndexValue,
                                        CostIndexCurrency,
                                        CostIndexInstalledCost
                                 FROM dbo.CostMetadata
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

                        return MapCostMetadata(reader);
                    }
                }
            }
        }
        #endregion      // GetCostMetadataByProjectId() ... READ

        #region UpdateCostMetadata() ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing cost metadata entry in the data store.
        /// </summary>
        /// <param name="costMetadataDto">The cost metadata data to update.</param>
        public void UpdateCostMetadata(CostMetadataDto costMetadataDto)
        {
            if (costMetadataDto == null)
            {
                throw new ArgumentNullException(nameof(costMetadataDto));
            }

            const string sql = @"UPDATE dbo.CostMetadata
                                 SET ProfileId = @ProfileId,
                                     CostIndexBaseYear = @CostIndexBaseYear,
                                     CostIndexName = @CostIndexName,
                                     CostIndexValue = @CostIndexValue,
                                     CostIndexCurrency = @CostIndexCurrency,
                                     CostIndexInstalledCost = @CostIndexInstalledCost,
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, costMetadataDto.Id);
                    AddParameter(command, "@ProjectId", DbType.Guid, costMetadataDto.ProjectId);
                    AddParameter(command, "@CostIndexBaseYear", DbType.String, costMetadataDto.CostIndexBaseYear);
                    AddParameter(command, "@CostIndexName", DbType.String, costMetadataDto.CostIndexName);
                    AddParameter(command, "@CostIndexValue", DbType.Double, costMetadataDto.CostIndexValue);
                    AddParameter(command, "@CostIndexCurrency", DbType.String, costMetadataDto.CostIndexCurrency);
                    AddParameter(command, "@CostIndexInstalledCost", DbType.Double, costMetadataDto.CostIndexInstalledCost);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateCostMetadata() ... UPDATE

        #region DeleteCostMetadata() ... DELETE
        /// <summary>
        /// Deletes (DELETE) a cost metadata entry from the data store by its identifier.
        /// </summary>
        /// <param name="costMetadataId">The unique identifier of the cost metadata entry to delete.</param>
        public void DeleteCostMetadata(Guid costMetadataId)
        {
            const string sql = @"DELETE FROM dbo.CostMetadata
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, costMetadataId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // DeleteCostMetadata() ... UPDATE

        #endregion      // METHODS
    }
    #endregion      // public class CostMetadataRepo
}
#endregion      // namespace HenModel.RepoImplementations.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
