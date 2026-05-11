#region HEADER
//#####################################################################################################################
//#####################################  O p t i m i z e r M I L P _ R e p o . c s  ###################################
//#####################################################################################################################
//  FILENAME:  OptimizerMILP_Repo.cs
//  NAMESPACE: HenModel.RepoImplementations.Project.DefaultParameters.OptimizerParams
//  CLASS(S):  OptimizerMILP_Repo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the Optimizer MILP Project sub table.
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
    #region public class OptimizerMILP_Repo
    /// <summary>
    /// Optimizer MILP Repo Class
    /// </summary>
    public class OptimizerMILP_Repo : IOptimizerMILP_Repo
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

        #region MapOptimizerMILP()
        /// <summary>
        /// Maps a data record from the project query result set to a <see cref="OptimizerMILP_Dto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the project column values.</param>
        /// <param name="idOrdinal">The ordinal position of the <c>Id</c> column.</param>
        /// <param name="optimizerParamsIdOrdinal">The ordinal position of the <c>OptimizerParamsId</c> column.</param>
        /// <param name="nameOrdinal">The ordinal position of the <c>Name</c> column.</param>
        /// <param name="descriptionOrdinal">The ordinal position of the <c>Description</c> column.</param>
        /// <returns>A <see cref="OptimizerGreedyDto"/> populated from the supplied data record.</returns>
        private static OptimizerMILP_Dto MapOptimizerMILP(IDataRecord record,
                                              int idOrdinal,
                                              int optimizerParamsIdOrdinal,
                                              int nameOrdinal,
                                              int descriptionOrdinal)
        {
            return new OptimizerMILP_Dto
            {
                Id = record.GetGuid(idOrdinal),
                OptimizerParamsId = record.GetGuid(optimizerParamsIdOrdinal),
                Name = record.IsDBNull(nameOrdinal) ? null : record.GetString(nameOrdinal),
                Description = record.IsDBNull(descriptionOrdinal) ? null : record.GetString(descriptionOrdinal)
            };
        }
        #endregion      // MapOptimizerMILP()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public OptimizerMILP_Repo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region AddOptimizerMILP() ... CREATE
        /// <summary>
        /// Adds (CREATE) a new optimizer MILP parameters to the data store.
        /// </summary>
        /// <param name="optimizerMilp_Dto">The optimizer MILP parameters to add.</param>
        /// <returns>The unique identifier of the inserted optimizer MILP parameters.</returns>
        public Guid AddOptimizerMILP(OptimizerMILP_Dto optimizerMilp_Dto)
        {
            if (optimizerMilp_Dto == null)
            {
                throw new ArgumentNullException(nameof(optimizerMilp_Dto));
            }

            const string sql = @"INSERT INTO dbo.[OptimizerMILP_Params]
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
                    AddParameter(command, "@OptimizerParamsId", DbType.String, optimizerMilp_Dto.OptimizerParamsId);
                    AddParameter(command, "@Name", DbType.String, optimizerMilp_Dto.Name);
                    AddParameter(command, "@Description", DbType.String, optimizerMilp_Dto.Description);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddOptimizerMILP() ... CREATE

        #region GetOptimizerMILPs() ... READ
        /// <summary>
        /// Retrieves (READ) all optimizer MILP parameters from the data store.
        /// </summary>
        /// <returns>A list of <see cref="OptimizerMILP_Dto"/> objects representing all optimizer MILP parameters. 
        /// The list is empty if no optimizer MILP parameters are found.</returns>
        public IList<OptimizerMILP_Dto> GetOptimizerMILPs()
        {
            const string sql = @"SELECT Id,
                                        OptimizerParamsId
                                        Name,
                                        Description
                                 FROM dbo.OptimizerMILP_Params
                                 ORDER BY OptimizerParamsId;";

            List<OptimizerMILP_Dto> optimizerMilpList = new List<OptimizerMILP_Dto>();

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
                            optimizerMilpList.Add(MapOptimizerMILP(
                                reader,
                                idOrdinal,
                                optimizerParamsIdOrdinal,
                                nameOrdinal,
                                descriptionOrdinal));
                        }
                    }
                }
            }

            return optimizerMilpList;
        }
        #endregion      // GetOptimizerMILPs() ... READ

        #region GetOptimizerMILP_ById() ... READ
        /// <summary>
        /// Retrieves (READ) optimizer MILP parameters from the data store by its unique identifier.
        /// </summary>
        /// <param name="optimizerMILP_Id">The unique identifier of the optimizer MILP parameters to retrieve.</param>
        /// <returns>A <see cref="OptimizerMILP_Dto"/> object representing the requested optimizer MILP parameters, 
        /// or <c>null</c> if no matching optimizer MILP parameters is found.</returns>
        public OptimizerMILP_Dto GetOptimizerMILP_ById(Guid optimizerMILP_Id)
        {
            const string sql = @"SELECT Id,
                                        OptimizerParamsId,
                                        Name,
                                        Description
                                 FROM dbo.OptimizerMILP_Params
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, optimizerMILP_Id);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapOptimizerMILP(
                            reader,
                            reader.GetOrdinal("Id"),
                            reader.GetOrdinal("OptimizerParamsId"),
                            reader.GetOrdinal("Name"),
                            reader.GetOrdinal("Description"));
                    }
                }
            }
        }
        #endregion      // GetOptimizerMILP_ById() ... READ

        #region GetOptimizerMILP_ByOptimizerParamsId() ... READ
        /// <summary>
        /// Retrieves (READ) optimizer MILP parameters from the data store by its Parent 
        /// unique Optimizer Params identifier.
        /// </summary>
        /// <param name="optimizerParamsId">The unique identifier of the optimizer parameters to retrieve.</param>
        /// <returns>A <see cref="OptimizerMILP_Dto"/> object representing the requested optimizer MILP parameters, 
        /// or <c>null</c> if no matching optimizer MILP parameters is found.</returns>
        public OptimizerMILP_Dto GetOptimizerMILP_ByOptimizerParamsId(Guid optimizerParamsId)
        {
            const string sql = @"SELECT Id,
                                        OptimizerParamsId,
                                        Name,
                                        Description
                                 FROM dbo.OptimizerMILP_Params
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

                        return MapOptimizerMILP(
                            reader,
                            reader.GetOrdinal("Id"),
                            reader.GetOrdinal("OptimizerParamsId"),
                            reader.GetOrdinal("Name"),
                            reader.GetOrdinal("Description"));
                    }
                }
            }
        }
        #endregion      // GetOptimizerMILP_ByOptimizerParamsId() ... READ

        #region UpdateOptimizerMILP() ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing optimizer MILP parameters in the data store.
        /// </summary>
        /// <param name="optimizerMilpDto">The optimizer MILP data to update.</param>
        public void UpdateOptimizerMILP(OptimizerMILP_Dto optimizerMilpDto)
        {
            if (optimizerMilpDto == null)
            {
                throw new ArgumentNullException(nameof(optimizerMilpDto));
            }

            const string sql = @"UPDATE dbo.OptimizerMILP_Params
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
                    AddParameter(command, "@Id", DbType.Guid, optimizerMilpDto.Id);
                    AddParameter(command, "@OptimizerParamsId", DbType.Guid, optimizerMilpDto.OptimizerParamsId);
                    AddParameter(command, "@Name", DbType.String, optimizerMilpDto.Name);
                    AddParameter(command, "@Description", DbType.String, optimizerMilpDto.Description);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateOptimizerMILP() ... UPDATE

        #region DeleteOptimizerMILP() ... DELETE
        /// <summary>
        /// Deletes (DELETE) an optimizer MILP parameters from the data store by its identifier.
        /// </summary>
        /// <param name="optimizerMilpId">The unique identifier of the optimizer MILP parameters to delete.</param>
        public void DeleteOptimizerMILP(Guid optimizerMilpId)
        {
            const string sql = @"DELETE FROM dbo.OptimizerMILP_Params
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, optimizerMilpId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // DeleteOptimizerMILP() ... DELETE

        #endregion      // METHODS
    }
    #endregion      // public class HenOptimizerMILPRepo
}
#endregion      // namespace HenModel.RepoImplementations.Project.DefaultParameters.OptimizerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
