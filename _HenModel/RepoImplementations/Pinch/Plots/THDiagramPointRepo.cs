#region HEADER
//#####################################################################################################################
//###################################  T H D i a g r a m P o i n t R e p o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  THDiagramPointRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Pinch.Plots
//  CLASS(S):  THDiagramPointRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the THDiagramPoint Profile sub table.
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

using HenModel.RepoInterfaces.Pinch.Plots;
using HenModel.Dto.Pinch.Plots;

using System;
using System.Collections.Generic;
using System.Data;
#endregion      // REFERENCES

#region namespace HenModel.RepoImplementations.Pinch.Plots
namespace HenModel.RepoImplementations.Pinch.Plots
{
    #region public class THDiagramPointRepo
    /// <summary>
    /// THDiagramPoint Repo Class
    /// </summary>
    public class THDiagramPointRepo : ITHDiagramPointRepo
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

        #region MapTHDiagramPoint()
        /// <summary>
        /// Maps a data record from the T-H diagram point query result set to a <see cref="THDiagramPointDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the T-H diagram point column values.</param>
        /// <returns>A <see cref="THDiagramPointDto"/> populated from the supplied data record.</returns>
        private static THDiagramPointDto MapTHDiagramPoint(IDataRecord record)
        {
            return new THDiagramPointDto
            {
                Id = record.GetGuid(record.GetOrdinal("Id")),
                THDiagramId = record.GetGuid(record.GetOrdinal("THDiagramId")),
                PointSequence = record.GetInt32(record.GetOrdinal("PointSequence")),
                EnthalpyValue = record.GetDouble(record.GetOrdinal("EnthalpyValue")),
                TemperatureValue = record.GetDouble(record.GetOrdinal("TemperatureValue"))
            };
        }
        #endregion      // MapTHDiagramPoint()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public THDiagramPointRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region GetTHDiagramPoints()
        /// <summary>
        /// Retrieves all T-H diagram points from the data store.
        /// </summary>
        /// <returns>A list of <see cref="THDiagramPointDto"/> objects representing all T-H diagram points. The list is empty if no T-H diagram points are found.</returns>
        public IList<THDiagramPointDto> GetTHDiagramPoints()
        {
            const string sql = @"SELECT Id,
                                        THDiagramId,
                                        PointSequence,
                                        EnthalpyValue,
                                        TemperatureValue
                                 FROM dbo.THDiagramPoint
                                 ORDER BY THDiagramId,
                                          PointSequence;";

            List<THDiagramPointDto> thDiagramPoints = new List<THDiagramPointDto>();

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
                            thDiagramPoints.Add(MapTHDiagramPoint(reader));
                        }
                    }
                }
            }

            return thDiagramPoints;
        }
        #endregion      // GetTHDiagramPoints()

        #region GetTHDiagramPointsByTHDiagramId()
        /// <summary>
        /// Retrieves all T-H diagram points for the specified T-H diagram from the data store.
        /// </summary>
        /// <param name="thDiagramId">The unique identifier of the T-H diagram whose points are to be retrieved.</param>
        /// <returns>A list of <see cref="THDiagramPointDto"/> objects representing the matching T-H diagram points. The list is empty if no T-H diagram points are found.</returns>
        public IList<THDiagramPointDto> GetTHDiagramPointsByTHDiagramId(Guid thDiagramId)
        {
            const string sql = @"SELECT Id,
                                        THDiagramId,
                                        PointSequence,
                                        EnthalpyValue,
                                        TemperatureValue
                                 FROM dbo.THDiagramPoint
                                 WHERE THDiagramId = @THDiagramId
                                 ORDER BY PointSequence;";

            List<THDiagramPointDto> thDiagramPoints = new List<THDiagramPointDto>();

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@THDiagramId", DbType.Guid, thDiagramId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            thDiagramPoints.Add(MapTHDiagramPoint(reader));
                        }
                    }
                }
            }

            return thDiagramPoints;
        }
        #endregion      // GetTHDiagramPointsByTHDiagramId()

        #region GetTHDiagramPointById()
        /// <summary>
        /// Retrieves a T-H diagram point from the data store by its identifier.
        /// </summary>
        /// <param name="thDiagramPointId">The unique identifier of the T-H diagram point to retrieve.</param>
        /// <returns>A <see cref="THDiagramPointDto"/> object representing the requested T-H diagram point, or <c>null</c> if no matching T-H diagram point is found.</returns>
        public THDiagramPointDto GetTHDiagramPointById(Guid thDiagramPointId)
        {
            const string sql = @"SELECT Id,
                                        THDiagramId,
                                        PointSequence,
                                        EnthalpyValue,
                                        TemperatureValue
                                 FROM dbo.THDiagramPoint
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, thDiagramPointId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapTHDiagramPoint(reader);
                    }
                }
            }
        }
        #endregion      // GetTHDiagramPointById()

        #region GetTHDiagramPointByPointSequence()
        /// <summary>
        /// Retrieves a T-H diagram point from the data store by its T-H diagram identifier and point sequence.
        /// </summary>
        /// <param name="thDiagramId">The unique identifier of the T-H diagram that owns the point.</param>
        /// <param name="pointSequence">The point sequence number to retrieve.</param>
        /// <returns>A <see cref="THDiagramPointDto"/> object representing the requested T-H diagram point, or <c>null</c> if no matching T-H diagram point is found.</returns>
        public THDiagramPointDto GetTHDiagramPointByPointSequence(Guid thDiagramId, int pointSequence)
        {
            const string sql = @"SELECT Id,
                                        THDiagramId,
                                        PointSequence,
                                        EnthalpyValue,
                                        TemperatureValue
                                 FROM dbo.THDiagramPoint
                                 WHERE THDiagramId = @THDiagramId
                                   AND PointSequence = @PointSequence;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@THDiagramId", DbType.Guid, thDiagramId);
                    AddParameter(command, "@PointSequence", DbType.Int32, pointSequence);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapTHDiagramPoint(reader);
                    }
                }
            }
        }
        #endregion      // GetTHDiagramPointByPointSequence()

        #region AddTHDiagramPoint()
        /// <summary>
        /// Adds a new T-H diagram point to the data store.
        /// </summary>
        /// <param name="thDiagramPointDto">The T-H diagram point data to insert.</param>
        /// <returns>The unique identifier of the inserted T-H diagram point.</returns>
        public Guid AddTHDiagramPoint(THDiagramPointDto thDiagramPointDto)
        {
            if (thDiagramPointDto == null)
            {
                throw new ArgumentNullException(nameof(thDiagramPointDto));
            }

            const string sql = @"INSERT INTO dbo.THDiagramPoint
                                    (THDiagramId,
                                     PointSequence,
                                     EnthalpyValue,
                                     TemperatureValue)
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@THDiagramId,
                                     @PointSequence,
                                     @EnthalpyValue,
                                     @TemperatureValue);";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@THDiagramId", DbType.Guid, thDiagramPointDto.THDiagramId);
                    AddParameter(command, "@PointSequence", DbType.Int32, thDiagramPointDto.PointSequence);
                    AddParameter(command, "@EnthalpyValue", DbType.Double, thDiagramPointDto.EnthalpyValue);
                    AddParameter(command, "@TemperatureValue", DbType.Double, thDiagramPointDto.TemperatureValue);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddTHDiagramPoint()

        #region UpdateTHDiagramPoint()
        /// <summary>
        /// Updates an existing T-H diagram point in the data store.
        /// </summary>
        /// <param name="thDiagramPointDto">The T-H diagram point data to update.</param>
        public void UpdateTHDiagramPoint(THDiagramPointDto thDiagramPointDto)
        {
            if (thDiagramPointDto == null)
            {
                throw new ArgumentNullException(nameof(thDiagramPointDto));
            }

            const string sql = @"UPDATE dbo.THDiagramPoint
                                 SET THDiagramId = @THDiagramId,
                                     PointSequence = @PointSequence,
                                     EnthalpyValue = @EnthalpyValue,
                                     TemperatureValue = @TemperatureValue
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, thDiagramPointDto.Id);
                    AddParameter(command, "@THDiagramId", DbType.Guid, thDiagramPointDto.THDiagramId);
                    AddParameter(command, "@PointSequence", DbType.Int32, thDiagramPointDto.PointSequence);
                    AddParameter(command, "@EnthalpyValue", DbType.Double, thDiagramPointDto.EnthalpyValue);
                    AddParameter(command, "@TemperatureValue", DbType.Double, thDiagramPointDto.TemperatureValue);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateTHDiagramPoint()

        #region DeleteTHDiagramPoint()
        /// <summary>
        /// Deletes a T-H diagram point from the data store by its identifier.
        /// </summary>
        /// <param name="thDiagramPointId">The unique identifier of the T-H diagram point to delete.</param>
        public void DeleteTHDiagramPoint(Guid thDiagramPointId)
        {
            const string sql = @"DELETE FROM dbo.THDiagramPoint
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, thDiagramPointId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // DeleteTHDiagramPoint()

        #endregion      // METHODS
    }
    #endregion      // public class THDiagramPointRepo
}
#endregion      // namespace HenModel.RepoImplementations.Pinch.Plots

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
