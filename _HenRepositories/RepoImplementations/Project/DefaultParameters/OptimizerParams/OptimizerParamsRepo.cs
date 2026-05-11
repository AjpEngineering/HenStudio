#region HEADER
//#####################################################################################################################
//###################################  O p t i m i z e r P a r a m s R e p o . c s  ###################################
//#####################################################################################################################
//  FILENAME:  OptimizerParamsRepo  .cs
//  NAMESPACE: HenModel.RepoImplementations.Project.DefaultParameters.OptimizerParams
//  CLASS(S):  OptimizerParamsRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation for the root Optimizer parameters object.
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
using HenModel.Dto.Project;
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;
using HenModel.RepoInterfaces.Project.DefaultParameters.OptimizerParams;

using System;
using System.Collections.Generic;
using System.Data;
#endregion      // REFERENCES

#region namespace HenModel.RepoImplementations.Project.DefaultParameters.OptimizerParams
namespace HenModel.RepoImplementations.Project.DefaultParameters.OptimizerParams
{
    #region public class OptimizerParamsRepo
    /// <summary>
    /// Optimizer Params Repo Class
    /// </summary>
    public class OptimizerParamsRepo : IOptimizerParamsRepo
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

        #region MapOptimizerParams()
        /// <summary>
        /// Maps a data record from the project query result set to a <see cref="OptimizerParamsDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the project column values.</param>
        /// <param name="idOrdinal">The ordinal position of the <c>Id</c> column.</param>
        /// <param name="projectIdOrdinal">The ordinal position of the <c>ProjectId</c> column.</param>
        /// <param name="defaultHeatTransferCoefficientOrdinal">The ordinal position of the <c>DefaultHeatTransferCoefficient</c> column.</param>
        /// <param name="defaultCorrectionFactorOrdinal">The ordinal position of the <c>DefaultCorrectionFactor</c> column.</param>
        /// <returns>A <see cref="OptimizerParamsDto"/> populated from the supplied data record.</returns>
        private static OptimizerParamsDto MapOptimizerParams(IDataRecord record,
                                              int idOrdinal,
                                              int projectIdOrdinal,
                                              int nameOrdinal,
                                              int descriptionOrdinal,
                                              int optimizerTypeOrdinal,
                                              int defaultObjectiveOrdinal,
                                              int defaultMaxIterationsOrdinal,
                                              int defaultConvergenceToleranceOrdinal)
        {
            return new OptimizerParamsDto
            {
                Id = record.GetGuid(idOrdinal),
                ProjectId = record.GetGuid(projectIdOrdinal),
                Name = record.GetString(nameOrdinal),
                Description = record.GetString(descriptionOrdinal),
                OptimizerType = record.GetString(optimizerTypeOrdinal),
                DefaultObjective = record.GetString(defaultObjectiveOrdinal),
                DefaultMaxIterations = record.GetInt32(defaultMaxIterationsOrdinal),
                DefaultConvergenceTolerance = record.GetDouble(defaultConvergenceToleranceOrdinal),
            };
        }
        #endregion      // MapOptimizerParams()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public OptimizerParamsRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region AddOptimizerParams() ... CREATE
        /// <summary>
        /// Adds (CREATE) a new optimizer params to the data store.
        /// </summary>
        /// <param name="optimizerParamsDto">The optimizer parameters to add.</param>
        /// <returns>The unique identifier of the inserted optimizer params.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Guid AddOptimizerParams(OptimizerParamsDto optimizerParamsDto)
        {
            if (optimizerParamsDto == null)
            {
                throw new ArgumentNullException(nameof(optimizerParamsDto));
            }

            const string sql = @"INSERT INTO dbo.OptimizerParams
                                    (ProjectId,
                                     Name,
                                     Description,
                                     OptimizerType,
                                     DefaultObjective,
                                     DefaultMaxIterations,
                                     DefaultConvergenceTolerance)
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@ProjectId,
                                     @Name,
                                     @Description,
                                     @OptimizerType,
                                     @DefaultObjective,
                                     @DefaultMaxIterations,
                                     @DefaultConvergenceTolerance);";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProjectId   ", DbType.String, optimizerParamsDto.ProjectId);
                    AddParameter(command, "@Name", DbType.String, optimizerParamsDto.Name);
                    AddParameter(command, "@Description", DbType.String, optimizerParamsDto.Description);
                    AddParameter(command, "@OptimizerType", DbType.String, optimizerParamsDto.OptimizerType);
                    AddParameter(command, "@DefaultObjective", DbType.String, optimizerParamsDto.DefaultObjective);
                    AddParameter(command, "@DefaultMaxIterations", DbType.String, optimizerParamsDto.DefaultMaxIterations);
                    AddParameter(command, "@DefaultConvergenceTolerance", DbType.String, optimizerParamsDto.DefaultConvergenceTolerance);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddOptimizerParams() ... CREATE

        #region GetOptimizerParams() ... READ
        /// <summary>
        /// Retrieves (READ) all optimizer parameters from the data store.
        /// </summary>
        /// <returns>A list of <see cref="OptimizerParamsDto"/> objects representing all optimizer parameters. 
        /// The list is empty if no optimizer parameters are found.</returns>
        public IList<OptimizerParamsDto> GetOptimizerParams()
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        Name,
                                        Description,
                                        OptimizerType,
                                        DefaultObjective,
                                        DefaultMaxIterations,
                                        DefaultConvergenceTolerance
                                 FROM dbo.OptimizerParams
                                 ORDER BY Name;";

            List<OptimizerParamsDto> optimizerParamsList = new List<OptimizerParamsDto>();

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        int idOrdinal = reader.GetOrdinal("Id");
                        int projectIdOrdinal = reader.GetOrdinal("ProjectId");
                        int nameOrdinal = reader.GetOrdinal("Name");
                        int descriptionOrdinal = reader.GetOrdinal("Description");
                        int optimizerTypeOrdinal = reader.GetOrdinal("OptimizerType");
                        int defaultObjectiveOrdinal = reader.GetOrdinal("DefaultObjective");
                        int defaultMaxIterationsOrdinal = reader.GetOrdinal("DefaultMaxIterations");
                        int defaultConvergenceToleranceOrdinal = reader.GetOrdinal("DefaultConvergenceTolerance");

                        {
                            optimizerParamsList.Add(MapOptimizerParams(
                                reader,
                                idOrdinal,
                                projectIdOrdinal,
                                nameOrdinal,
                                descriptionOrdinal,
                                optimizerTypeOrdinal,
                                defaultObjectiveOrdinal,
                                defaultMaxIterationsOrdinal,
                                defaultConvergenceToleranceOrdinal));
                        }
                    }
                }
            }

            return optimizerParamsList;
        }
        #endregion      // GetOptimizerParams() ... READ

        #region GetOptimizerParamsByProjectId() ... READ
        /// <summary>
        /// Retrieves (READ) optimizer params from the data store by its project identifier.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project to retrieve optimizer parameters for.</param>
        /// <returns>A <see cref="OptimizerParamsDto"/> object representing the requested optimizer parameters, or <c>null</c> if no matching optimizer parameters is found.</returns>
        public OptimizerParamsDto GetOptimizerParamsByProjectId(Guid projectId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        Name,
                                        Description,
                                        OptimizerType,
                                        DefaultObjective,
                                        DefaultMaxIterations,
                                        DefaultConvergenceTolerance
                                 FROM dbo.OptimizerParams
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

                        return MapOptimizerParams(
                            reader,
                            reader.GetOrdinal("Id"),
                            reader.GetOrdinal("ProjectId"),
                            reader.GetOrdinal("Name"),
                            reader.GetOrdinal("Description"),
                            reader.GetOrdinal("OptimizerType"),
                            reader.GetOrdinal("DefaultObjective"),
                            reader.GetOrdinal("DefaultMaxIterations"),
                            reader.GetOrdinal("DefaultConvergenceTolerance"));
                    }
                }
            }
        }
        #endregion      // GetOptimizerParamsByProjectId() ... READ

        #region GetOptimizerParamsById() ... READ
        /// <summary>
        /// Retrieves (READ) optimizer params from the data store by its unique identifier.
        /// </summary>
        /// <param name="optimizerParamId">The unique identifier of the optimizer parameters to retrieve.</param>
        /// <returns>A <see cref="OptimizerParamsDto"/> object representing the requested optimizer parameters, 
        /// or <c>null</c> if no matching optimizer parameters is found.</returns>
        public OptimizerParamsDto GetOptimizerParamsById(Guid optimizerParamId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        Name,
                                        Description,
                                        OptimizerType,
                                        DefaultObjective,
                                        DefaultMaxIterations,
                                        DefaultConvergenceTolerance
                                 FROM dbo.OptimizerParams
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, optimizerParamId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapOptimizerParams(
                            reader,
                            reader.GetOrdinal("Id"),
                            reader.GetOrdinal("ProjectId"),
                            reader.GetOrdinal("Name"),
                            reader.GetOrdinal("Description"),
                            reader.GetOrdinal("OptimizerType"),
                            reader.GetOrdinal("DefaultObjective"),
                            reader.GetOrdinal("DefaultMaxIterations"),
                            reader.GetOrdinal("DefaultConvergenceTolerance"));
                    }
                }
            }
        }
        #endregion      // GetOptimizerParamsById() ... READ

        #region UpdateOptimizerParams() ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing optimizer params in the data store.
        /// </summary>
        /// <param name="optimizerParamsDto">The optimizer params data to update.</param>
        public void UpdateOptimizerParams(OptimizerParamsDto optimizerParamsDto)
        {
            if (optimizerParamsDto == null)
            {
                throw new ArgumentNullException(nameof(optimizerParamsDto));
            }

            const string sql = @"UPDATE dbo.OptimizerParams
                                 SET ProjectId = @ProjectId,
                                     Name = @Name,
                                     Description = @Description,
                                     OptimizerType = @OptimizerType,
                                     DefaultObjective = @DefaultObjective,
                                     DefaultMaxIterations = @DefaultMaxIterations,
                                     DefaultConvergenceTolerance = @DefaultConvergenceTolerance
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, optimizerParamsDto.Id);
                    AddParameter(command, "@ProjectId", DbType.String, optimizerParamsDto.ProjectId);
                    AddParameter(command, "@Name", DbType.String, optimizerParamsDto.Name);
                    AddParameter(command, "@Description", DbType.String, optimizerParamsDto.Description);
                    AddParameter(command, "@OptimizerType", DbType.String, optimizerParamsDto.OptimizerType);
                    AddParameter(command, "@DefaultObjective", DbType.String, optimizerParamsDto.DefaultObjective);
                    AddParameter(command, "@DefaultMaxIterations", DbType.Int32, optimizerParamsDto.DefaultMaxIterations);
                    AddParameter(command, "@DefaultConvergenceTolerance", DbType.Double, optimizerParamsDto.DefaultConvergenceTolerance);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateOptimizerParams() ... UPDATE

        #region DeleteOptimizerParams() ... DELETE
        /// <summary>
        /// Deletes (DELETE) an optimizer params from the data store by its identifier.
        /// </summary>
        /// <param name="optimizerParamsId">The unique identifier of the optimizer params to delete.</param>
        public void DeleteOptimizerParams(Guid optimizerParamsId)
        {
            const string sql = @"DELETE FROM dbo.OptimizerParams
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, optimizerParamsId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // DeleteOptimizerParams() ... DELETE

        #endregion      // METHODS
    }
    #endregion      // public class OptimizerRepo
}
#endregion      // namespace HenModel.RepoImplementations.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
