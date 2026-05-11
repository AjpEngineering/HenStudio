#region HEADER
//#####################################################################################################################
//##################################  O p t i m i z e r G e n e t i c R e p o . c s  ##################################
//#####################################################################################################################
//  FILENAME:  OptimizerGeneticRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Project.DefaultParameters.OptimizerParams
//  CLASS(S):  OptimizerGeneticRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation for the Optimizer Genetic Parameters object.
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
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;
using HenModel.RepoInterfaces.Project.DefaultParameters.OptimizerParams;

using System;
using System.Collections.Generic;
using System.Data;
#endregion      // REFERENCES

#region namespace HenModel.RepoImplementations.Project.DefaultParameters.OptimizerParams
namespace HenModel.RepoImplementations.Project.DefaultParameters.OptimizerParams
{
    #region public class OptimizerGeneticRepo
    /// <summary>
    /// OptimizerGenetic Repo Class
    /// </summary>
    public class OptimizerGeneticRepo : IOptimizerGeneticRepo
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

        #region MapOptimizerGenetic()
        /// <summary>
        /// Maps a data record from the project query result set to a <see cref="OptimizerGeneticDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the project column values.</param>
        /// <param name="idOrdinal">The ordinal position of the <c>Id</c> column.</param>
        /// <param name="optimizerParamsIdOrdinal">The ordinal position of the <c>OptimizerParamsId</c> column.</param>
        /// <param name="nameOrdinal">The ordinal position of the <c>Name</c> column.</param>
        /// <param name="descriptionOrdinal">The ordinal position of the <c>Description</c> column.</param>
        /// <returns>A <see cref="OptimizerGeneticDto"/> populated from the supplied data record.</returns>
        private static OptimizerGeneticDto MapOptimizerGenetic(IDataRecord record,
                                              int idOrdinal,
                                              int optimizerParamsIdOrdinal,
                                              int nameOrdinal,
                                              int descriptionOrdinal)
        {
            return new OptimizerGeneticDto
            {
                Id = record.GetGuid(idOrdinal),
                OptimizerParamsId = record.GetGuid(optimizerParamsIdOrdinal),
                Name = record.IsDBNull(nameOrdinal) ? null : record.GetString(nameOrdinal),
                Description = record.IsDBNull(descriptionOrdinal) ? null : record.GetString(descriptionOrdinal)
            };
        }
        #endregion      // MapOptimizerGenetic()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public OptimizerGeneticRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region AddOptimizerGenetic() ... CREATE
        /// <summary>
        /// Adds (CREATE) a new optimizer genetic parameters to the data store.
        /// </summary>
        /// <param name="optimizerGeneticDto">The optimizer genetic parameters to add.</param>
        /// <returns>The unique identifier of the inserted optimizer genetic parameters.</returns>
        public Guid AddOptimizerGenetic(OptimizerGeneticDto optimizerGeneticDto)
        {
            if (optimizerGeneticDto == null)
            {
                throw new ArgumentNullException(nameof(optimizerGeneticDto));
            }

            const string sql = @"INSERT INTO dbo.[OptimizerGeneticParams]
                                    ([OptimizerParamsId],
                                     [Name],
                                     [Description])
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@OptimizerParamsId,
                                     @Name,
                                     @Description);";
            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@OptimizerParamsId", DbType.String, optimizerGeneticDto.OptimizerParamsId);
                    AddParameter(command, "@Name", DbType.String, optimizerGeneticDto.Name);
                    AddParameter(command, "@Description", DbType.String, optimizerGeneticDto.Description);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion  // AddOptimizerGenetic() ... CREATE

        #region GetOptimizerGenetics() ... READ
        /// Retrieves (READ) all optimizer parameters from the data store.
        /// </summary>
        /// <returns>A list of <see cref="OptimizerGeneticDto"/> objects representing all optimizer genetic parameters. 
        /// The list is empty if no optimizer genetic parameters are found.</returns>
        public IList<OptimizerGeneticDto> GetOptimizerGenetics()
        {
            const string sql = @"SELECT Id,
                                        OptimizerParamsId
                                        Name,
                                        Description
                                 FROM dbo.OptimizerGeneticParams
                                 ORDER BY OptimizerParamsId;";

            List<OptimizerGeneticDto> optimizerGeneticList = new List<OptimizerGeneticDto>();

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
                        int optimizerParamsIdOrdinal = reader.GetOrdinal("OptimizerParamsId");
                        int nameOrdinal = reader.GetOrdinal("Name");
                        int descriptionOrdinal = reader.GetOrdinal("Description");

                        {
                            optimizerGeneticList.Add(MapOptimizerGenetic(
                                reader,
                                idOrdinal,
                                optimizerParamsIdOrdinal,
                                nameOrdinal,
                                descriptionOrdinal));
                        }
                    }
                }
            }

            return optimizerGeneticList;
        }
        #endregion  // GetOptimizerGenetics() ... READ

        #region GetOptimizerGeneticById() ... READ
        /// <summary>
        /// Retrieves (READ) optimizer genetic parameters from the data store by its unique identifier.
        /// </summary>
        /// <param name="optimizerGeneticId">The unique identifier of the optimizer genetic parameters to retrieve.</param>
        /// <returns>A <see cref="OptimizerGeneticDto"/> object representing the requested optimizer genetic parameters, 
        /// or <c>null</c> if no matching optimizer genetic parameters is found.</returns>
        public OptimizerGeneticDto GetOptimizerGeneticById(Guid optimizerGeneticId)
        {
            const string sql = @"SELECT Id,
                                        OptimizerParamsId,
                                        Name,
                                        Description
                                 FROM dbo.OptimizerGeneticParams
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, optimizerGeneticId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapOptimizerGenetic(
                            reader,
                            reader.GetOrdinal("Id"),
                            reader.GetOrdinal("OptimizerParamsId"),
                            reader.GetOrdinal("Name"),
                            reader.GetOrdinal("Description"));
                    }
                }
            }
        }
        #endregion  // GetOptimizerGeneticById() ... READ

        #region GetOptimizerGeneticByOptimizerParamsId() ... READ
        /// <summary>
        /// Retrieves (READ) optimizer genetic parameters from the data store by its Parent 
        /// unique Optimizer Params identifier.
        /// </summary>
        /// <param name="optimizerParamsId">The unique identifier of the optimizer parameters to retrieve.</param>
        /// <returns>A <see cref="OptimizerGeneticDto"/> object representing the requested optimizer genetic parameters, 
        /// or <c>null</c> if no matching optimizer genetic parameters is found.</returns>
        public OptimizerGeneticDto GetOptimizerGeneticByOptimizerParamsId(Guid optimizerParamsId)
        {
            const string sql = @"SELECT Id,
                                        OptimizerParamsId,
                                        Name,
                                        Description
                                 FROM dbo.OptimizerGeneticParams
                                 WHERE OptimizerParamsId = @OptimizerParamsId;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@OptimizerParamsId", DbType.Guid, optimizerParamsId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapOptimizerGenetic(
                            reader,
                            reader.GetOrdinal("Id"),
                            reader.GetOrdinal("OptimizerParamsId"),
                            reader.GetOrdinal("Name"),
                            reader.GetOrdinal("Description"));
                    }
                }
            }
        }
        #endregion  // GetOptimizerGeneticByOptimizerParamsId() ... READ

        #region UpdateOptimizerGenetic() ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing optimizer genetic parameters in the data store.
        /// </summary>
        /// <param name="optimizerGeneticDto">The optimizer genetic data to update.</param>
        public void UpdateOptimizerGenetic(OptimizerGeneticDto optimizerGeneticDto)
        {
            if (optimizerGeneticDto == null)
            {
                throw new ArgumentNullException(nameof(optimizerGeneticDto));
            }

            const string sql = @"UPDATE dbo.OptimizerGeneticParams
                                 SET Id = @Id,
                                     OptimizerParamsId = @OptimizerParamsId,
                                     Name = @Name,
                                     Description = @Description
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, optimizerGeneticDto.Id);
                    AddParameter(command, "@OptimizerParamsId", DbType.Guid, optimizerGeneticDto.OptimizerParamsId);
                    AddParameter(command, "@Name", DbType.String, optimizerGeneticDto.Name);
                    AddParameter(command, "@Description", DbType.String, optimizerGeneticDto.Description);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion  // UpdateOptimizerGenetic() ... UPDATE

        #region DeleteOptimizerGenetic() ... DELETE
        /// <summary>
        /// Deletes (DELETE) an optimizer genetic parameters from the data store by its identifier.
        /// </summary>
        /// <param name="optimizerGeneticId">The unique identifier of the optimizer genetic parameters to delete.</param>
        public void DeleteOptimizerGenetic(Guid optimizerGeneticId)
        {
            const string sql = @"DELETE FROM dbo.OptimizerGeneticParams
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, optimizerGeneticId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion  // DeleteOptimizerGenetic() ... DELETE

        #endregion      // METHODS
    }
    #endregion      // public class HenOptimizerGeneticRepo
}
#endregion      // namespace HenModel.RepoImplementations.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
