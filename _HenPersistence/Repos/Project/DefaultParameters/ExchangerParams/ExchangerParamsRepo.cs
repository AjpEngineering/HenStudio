#region HEADER
//#####################################################################################################################
//################################  E x c h a n g e r P a r a m s R e p o R e p o . c s  ##############################
//#####################################################################################################################
//  FILENAME:  ExchangerParamsRepo.cs
//  NAMESPACE: HenPersistence.Repos
//  CLASS(S):  ExchangerParamsRepo
//  COMPONENT: _HenPersistence.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation for the Exchanger Params table.
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
    #region public class ExchangerParamsRepo
    /// <summary>
    /// Exchanger Params Repo Class
    /// </summary>
    public class ExchangerParamsRepo : IExchangerParamsRepo
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

        #region MapExchangerParams()
        /// <summary>
        /// Maps a data record from the project query result set to a <see cref="ProjectUnitsDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the project column values.</param>
        /// <param name="idOrdinal">The ordinal position of the <c>Id</c> column.</param>
        /// <param name="projectIdOrdinal">The ordinal position of the <c>ProjectId</c> column.</param>
        /// <param name="defaultHeatTransferCoefficientOrdinal">The ordinal position of the <c>DefaultHeatTransferCoefficient</c> column.</param>
        /// <param name="defaultCorrectionFactorOrdinal">The ordinal position of the <c>DefaultCorrectionFactor</c> column.</param>
        /// <returns>A <see cref="ExchangerParamsDto"/> populated from the supplied data record.</returns>
        private static ExchangerParamsDto MapExchangerParams( IDataRecord record,
                                              int idOrdinal,
                                              int projectIdOrdinal,
                                              int defaultHeatTransferCoefficientOrdinal,
                                              int defaultCorrectionFactorOrdinal)
        {
            return new ExchangerParamsDto
            {
                Id = record.GetGuid(idOrdinal),
                ProjectId = record.GetGuid(projectIdOrdinal),
                DefaultHeatTransferCoefficient = record.GetDouble(defaultHeatTransferCoefficientOrdinal),
                DefaultCorrectionFactor = record.GetDouble(defaultCorrectionFactorOrdinal),
            };
        }
        #endregion      // MapExchangerParams()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public ExchangerParamsRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region GetExchangerParamsById()
        /// <summary>
        /// Retrieves a project from the data store by its identifier.
        /// </summary>
        /// <param name="exchangeParamsId">The unique identifier of the exchanger parameters to retrieve.</param>
        /// <returns>A <see cref="ExchangerParamsDto"/> object representing the requested exchanger parameters, or <c>null</c> if no matching exchanger parameters is found.</returns>
        public ExchangerParamsDto GetExchangerParamsById(Guid exchangeParamsId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        DefaultHeatTransferCoefficient,
                                        DefaultCorrectionFactor
                                 FROM dbo.ExchangerParams
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, exchangeParamsId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapExchangerParams(
                            reader,
                            reader.GetOrdinal("Id"),
                            reader.GetOrdinal("ProjectId"),
                            reader.GetOrdinal("DefaultHeatTransferCoefficient"),
                            reader.GetOrdinal("DefaultCorrectionFactor"));
                    }
                }
            }
        }
        #endregion      // GetExchangerParamsById()

        #region GetExchangerParamsByProjectId()
        /// <summary>
        /// Retrieves a project from the data store by its identifier.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project to retrieve.</param>
        /// <returns>A <see cref="ExchangerParamsDto"/> object representing the requested project, or <c>null</c> if no matching project is found.</returns>
        public ExchangerParamsDto GetExchangerParamsByProjectId(Guid projectId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        DefaultHeatTransferCoefficient,
                                        DefaultCorrectionFactor
                                 FROM dbo.ExchangerParams
                                 WHERE ProjectId = @ProjectId;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, projectId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapExchangerParams(
                            reader,
                            reader.GetOrdinal("Id"),
                            reader.GetOrdinal("ProjectId"),
                            reader.GetOrdinal("DefaultHeatTransferCoefficient"),
                            reader.GetOrdinal("DefaultCorrectionFactor"));
                    }
                }
            }
        }
        #endregion      // GetExchangerParamsByProjectId()

        #region AddExchangerParams()
        /// <summary>
        /// Adds a new project units to the data store.
        /// </summary>
        /// <param name="exchangerParamsDto">The exchanger params data to insert.</param>
        /// <returns>The unique identifier of the inserted exchanger params.</returns>
        public Guid AddExchangerParams(ExchangerParamsDto exchangerParamsDto)
        {
            if (exchangerParamsDto == null)
            {
                throw new ArgumentNullException(nameof(exchangerParamsDto));
            }

            const string sql = @"INSERT INTO dbo.ExchangerParams
                                    (ProjectId,
                                     DefaultHeatTransferCoefficient,
                                     DefaultCorrectionFactor)
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@ProjectId,
                                     @DefaultHeatTransferCoefficient,
                                     @DefaultCorrectionFactor);";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProjectId   ", DbType.String, exchangerParamsDto.ProjectId);
                    AddParameter(command, "@DefaultHeatTransferCoefficient", DbType.String, exchangerParamsDto.DefaultHeatTransferCoefficient);
                    AddParameter(command, "@DefaultCorrectionFactor", DbType.String, exchangerParamsDto.DefaultCorrectionFactor);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddExchangerParams()

        #region UpdateExchangerParams()
        /// <summary>
        /// Updates an existing project units in the data store.
        /// </summary>
        /// <param name="exchangerParamsDto">The exchanger params data to update.</param>
        public void UpdateExchangerParams(ExchangerParamsDto exchangerParamsDto)
        {
            if (exchangerParamsDto == null)
            {
                throw new ArgumentNullException(nameof(exchangerParamsDto));
            }

            const string sql = @"UPDATE dbo.ExchangerParams
                                 SET ProjectId = @ProjectId,
                                     DefaultHeatTransferCoefficient = @DefaultHeatTransferCoefficient,
                                     DefaultCorrectionFactor = @DefaultCorrectionFactor
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, exchangerParamsDto.Id);
                    AddParameter(command, "@ProjectId", DbType.String, exchangerParamsDto.ProjectId);
                    AddParameter(command, "@DefaultHeatTransferCoefficient", DbType.String, exchangerParamsDto.DefaultHeatTransferCoefficient);
                    AddParameter(command, "@DefaultCorrectionFactor", DbType.String, exchangerParamsDto.DefaultCorrectionFactor);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateExchangerParams()

        #region DeleteExchangerParams()
        /// <summary>
        /// Deletes an exchanger params from the data store by its identifier.
        /// </summary>
        /// <param name="exchangerParamsId">The unique identifier of the exchanger params to delete.</param>
        public void DeleteExchangerParams(Guid exchangerParamsId)
        {
            const string sql = @"DELETE FROM dbo.ExchangerParams
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, exchangerParamsId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // DeleteProjectUnits()

        #endregion      // METHODS
    }
    #endregion      // public class ExchangerParamsRepo
}
#endregion      // namespace HenPersistence.Repos

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
