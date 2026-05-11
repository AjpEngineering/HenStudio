#region HEADER
//#####################################################################################################################
//###################################  O p t i m i z e r G r e e d y R e p o . c s  ###################################
//#####################################################################################################################
//  FILENAME:  OptimizerGreedyRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Project.DefaultParameters.OptimizerParams
//  CLASS(S):  OptimizerGreedyRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the Optimizer Greedy Parameters object.
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
    #region public class HenOptimizerGreedyRepo
    /// <summary>
    /// HenOptimizerGreedy Repo Class
    /// </summary>
    public class OptimizerGreedyRepo : IOptimizerGreedyRepo
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

        #region MapOptimizerGreedy()
        /// <summary>
        /// Maps a data record from the project query result set to a <see cref="OptimizerGreedyDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the project column values.</param>
        /// <param name="idOrdinal">The ordinal position of the <c>Id</c> column.</param>
        /// <param name="optimizerParamsIdOrdinal">The ordinal position of the <c>OptimizerParamsId</c> column.</param>
        /// <param name="nameOrdinal">The ordinal position of the <c>Name</c> column.</param>
        /// <param name="descriptionOrdinal">The ordinal position of the <c>Description</c> column.</param>
        /// <returns>A <see cref="OptimizerGreedyDto"/> populated from the supplied data record.</returns>
        private static OptimizerGreedyDto MapOptimizerGreedy(IDataRecord record,
                                              int idOrdinal,
                                              int optimizerParamsIdOrdinal,
                                              int nameOrdinal,
                                              int descriptionOrdinal)
        {
            return new OptimizerGreedyDto
            {
                Id = record.GetGuid(idOrdinal),
                OptimizerParamsId = record.GetGuid(optimizerParamsIdOrdinal),
                Name = record.IsDBNull(nameOrdinal) ? null : record.GetString(nameOrdinal),
                Description = record.IsDBNull(descriptionOrdinal) ? null : record.GetString(descriptionOrdinal)
            };
        }
        #endregion      // MapOptimizerGreedy()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public OptimizerGreedyRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region AddOptimizerGreedy() ... CREATE
        /// <summary>
        /// Adds (CREATE) a new optimizer genetic parameters to the data store.
        /// </summary>
        /// <param name="optimizerGreedyDto">The optimizer greedy parameters to add.</param>
        /// <returns>The unique identifier of the inserted optimizer greedy parameters.</returns>
        public Guid AddOptimizerGreedy(OptimizerGreedyDto optimizerGreedyDto)
        {
            if (optimizerGreedyDto == null)
            {
                throw new ArgumentNullException(nameof(optimizerGreedyDto));
            }

            const string sql = @"INSERT INTO dbo.[OptimizerGreedyParams]
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
                    AddParameter(command, "@OptimizerParamsId", DbType.String, optimizerGreedyDto.OptimizerParamsId);
                    AddParameter(command, "@Name", DbType.String, optimizerGreedyDto.Name);
                    AddParameter(command, "@Description", DbType.String, optimizerGreedyDto.Description);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddOptimizerGreedy() ... CREATE

        #region GetOptimizerGreedys() ... READ
        /// Retrieves (READ) all optimizer parameters from the data store.
        /// </summary>
        /// <returns>A list of <see cref="OptimizerGreedyDto"/> objects representing all optimizer greedy parameters. 
        /// The list is empty if no optimizer greedy parameters are found.</returns>
        public IList<OptimizerGreedyDto> GetOptimizerGreedys()
        {
            const string sql = @"SELECT Id,
                                        OptimizerParamsId
                                        Name,
                                        Description
                                 FROM dbo.OptimizerGreedyParams
                                 ORDER BY OptimizerParamsId;";

            List<OptimizerGreedyDto> optimizerGreedyList = new List<OptimizerGreedyDto>();

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
                            optimizerGreedyList.Add(MapOptimizerGreedy(
                                reader,
                                idOrdinal,
                                optimizerParamsIdOrdinal,
                                nameOrdinal,
                                descriptionOrdinal));
                        }
                    }
                }
            }

            return optimizerGreedyList;
        }
        #endregion      // GetOptimizerGreedys() ... READ

        #region GetOptimizerGreedyById() ... READ
        /// <summary>
        /// Retrieves (READ) optimizer greedy parameters from the data store by its unique identifier.
        /// </summary>
        /// <param name="optimizerGreedyId">The unique identifier of the optimizer greedy parameters to retrieve.</param>
        /// <returns>A <see cref="OptimizerGreedyDto"/> object representing the requested optimizer greedy parameters, 
        /// or <c>null</c> if no matching optimizer greedy parameters is found.</returns>
        public OptimizerGreedyDto GetOptimizerGreedyById(Guid optimizerGreedyId)
        {
            const string sql = @"SELECT Id,
                                        OptimizerParamsId,
                                        Name,
                                        Description
                                 FROM dbo.OptimizerGreedyParams
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, optimizerGreedyId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapOptimizerGreedy(
                            reader,
                            reader.GetOrdinal("Id"),
                            reader.GetOrdinal("OptimizerParamsId"),
                            reader.GetOrdinal("Name"),
                            reader.GetOrdinal("Description"));
                    }
                }
            }
        }
        #endregion      // GetOptimizerGreedyById() ... READ

        #region GetOptimizerGreedyByOptimizerParamsId() ... READ
        /// <summary>
        /// Retrieves (READ) optimizer greedy parameters from the data store by its Parent 
        /// unique Optimizer Params identifier.
        /// </summary>
        /// <param name="optimizerParamsId">The unique identifier of the optimizer parameters to retrieve.</param>
        /// <returns>A <see cref="OptimizerGreedyDto"/> object representing the requested optimizer greedy parameters, 
        /// or <c>null</c> if no matching optimizer greedy parameters is found.</returns>
        public OptimizerGreedyDto GetOptimizerGreedyByOptimizerParamsId(Guid optimizerParamsId)
        {
            const string sql = @"SELECT Id,
                                        OptimizerParamsId,
                                        Name,
                                        Description
                                 FROM dbo.OptimizerGreedyParams
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

                        return MapOptimizerGreedy(
                            reader,
                            reader.GetOrdinal("Id"),
                            reader.GetOrdinal("OptimizerParamsId"),
                            reader.GetOrdinal("Name"),
                            reader.GetOrdinal("Description"));
                    }
                }
            }
        }
        #endregion      // GetOptimizerGreedyByOptimizerParamsId() ... READ

        #region UpdateOptimizerGreedy() ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing optimizer greedy parameters in the data store.
        /// </summary>
        /// <param name="optimizerGreedyDto">The optimizer greedy data to update.</param>
        public void UpdateOptimizerGreedy(OptimizerGreedyDto optimizerGreedyDto)
        {
            if (optimizerGreedyDto == null)
            {
                throw new ArgumentNullException(nameof(optimizerGreedyDto));
            }

            const string sql = @"UPDATE dbo.OptimizerGreedyParams
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
                    AddParameter(command, "@Id", DbType.Guid, optimizerGreedyDto.Id);
                    AddParameter(command, "@OptimizerParamsId", DbType.Guid, optimizerGreedyDto.OptimizerParamsId);
                    AddParameter(command, "@Name", DbType.String, optimizerGreedyDto.Name);
                    AddParameter(command, "@Description", DbType.String, optimizerGreedyDto.Description);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateOptimizerGreedy() ... UPDATE

        #region DeleteOptimizerGreedy() ... DELETE
        /// <summary>
        /// Deletes (DELETE) an optimizer greedy parameters from the data store by its identifier.
        /// </summary>
        /// <param name="optimizerGreedyId">The unique identifier of the optimizer greedy parameters to delete.</param>
        public void DeleteOptimizerGreedy(Guid optimizerGreedyId)
        {
            const string sql = @"DELETE FROM dbo.OptimizerGreedyParams
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, optimizerGreedyId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // DeleteOptimizerGreedy() ... DELETE

        #endregion      // METHODS
    }
    #endregion      // public class HenOptimizerGreedyRepo
}
#endregion      // namespace HenModel.RepoImplementations.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
