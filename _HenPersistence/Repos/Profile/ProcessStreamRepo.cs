#region HEADER
//#####################################################################################################################
//#####################################  P r o c e s s S t r e a m R e p o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  ProcessStreamRepo.cs
//  NAMESPACE: HenPersistence.Repos
//  CLASS(S):  ProcessStreamRepo
//  COMPONENT: _HenPersistence.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the ProcessStream Profile sub table.
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
    #region public class ProcessStreamRepo
    /// <summary>
    /// ProcessStream Repo Class
    /// </summary>
    public class ProcessStreamRepo : IProcessStreamRepo
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

        #region MapProcessStream()
        /// <summary>
        /// Maps a data record from the process stream query result set to a <see cref="ProcessStreamDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the process stream column values.</param>
        /// <returns>A <see cref="ProcessStreamDto"/> populated from the supplied data record.</returns>
        private static ProcessStreamDto MapProcessStream(IDataRecord record)
        {
            return new ProcessStreamDto
            {
                Id = record.GetGuid(record.GetOrdinal("Id")),
                ProfileId = record.GetGuid(record.GetOrdinal("ProfileId")),
                StreamCategory = record.IsDBNull(record.GetOrdinal("StreamCategory")) ? null : record.GetString(record.GetOrdinal("StreamCategory")),
                StreamHeat = record.IsDBNull(record.GetOrdinal("StreamHeat")) ? null : record.GetString(record.GetOrdinal("StreamHeat")),
                StreamId = record.IsDBNull(record.GetOrdinal("StreamId")) ? null : record.GetString(record.GetOrdinal("StreamId")),
                StreamSegmentId = record.IsDBNull(record.GetOrdinal("StreamSegmentId")) ? null : record.GetString(record.GetOrdinal("StreamSegmentId")),
                Name = record.IsDBNull(record.GetOrdinal("Name")) ? null : record.GetString(record.GetOrdinal("Name")),
                StreamType = record.IsDBNull(record.GetOrdinal("StreamType")) ? null : record.GetString(record.GetOrdinal("StreamType")),
                StreamSubtype = record.IsDBNull(record.GetOrdinal("StreamSubtype")) ? null : record.GetString(record.GetOrdinal("StreamSubtype")),
                SupplyTemperature = record.GetDouble(record.GetOrdinal("SupplyTemperature")),
                SupplyPressure = record.GetDouble(record.GetOrdinal("SupplyPressure")),
                TargetTemperature = record.GetDouble(record.GetOrdinal("TargetTemperature")),
                TargetPressure = record.GetDouble(record.GetOrdinal("TargetPressure")),
                HeatCapacityFlowRate = record.GetDouble(record.GetOrdinal("HeatCapacityFlowRate")),
                HeatTransferCoefficient = record.GetDouble(record.GetOrdinal("HeatTransferCoefficient"))
            };
        }
        #endregion      // MapProcessStream()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public ProcessStreamRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region GetProcessStreams()
        /// <summary>
        /// Retrieves all process streams from the data store.
        /// </summary>
        /// <returns>A list of <see cref="ProcessStreamDto"/> objects representing all process streams. The list is empty if no process streams are found.</returns>
        public IList<ProcessStreamDto> GetProcessStreams()
        {
            const string sql = @"SELECT Id,
                                        ProfileId,
                                        StreamCategory,
                                        StreamHeat,
                                        StreamId,
                                        Name,
                                        StreamType,
                                        StreamSubtype,
                                        SupplyTemperature,
                                        SupplyPressure,
                                        TargetTemperature,
                                        TargetPressure,
                                        HeatCapacityFlowRate,
                                 FROM dbo.ProcessStream
                                 ORDER BY StreamId;";

            List<ProcessStreamDto> processStreams = new List<ProcessStreamDto>();

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
                            processStreams.Add(MapProcessStream(reader));
                        }
                    }
                }
            }

            return processStreams;
        }
        #endregion      // GetProcessStreams()

        #region GetProcessStreamsByProfileId()
        /// <summary>
        /// Retrieves all process streams for the specified profile from the data store.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile whose process streams are to be retrieved.</param>
        /// <returns>A list of <see cref="ProcessStreamDto"/> objects representing the matching process streams. The list is empty if no process streams are found.</returns>
        public IList<ProcessStreamDto> GetProcessStreamsByProfileId(Guid profileId)
        {
            const string sql = @"SELECT Id,
                                        ProfileId,
                                        StreamCategory,
                                        StreamHeat,
                                        StreamId,
                                        StreamSegmentId,
                                        Name,
                                        StreamType,
                                        StreamSubtype,
                                        SupplyTemperature,
                                        SupplyPressure,
                                        TargetTemperature,
                                        TargetPressure,
                                        HeatCapacityFlowRate,
                                        HeatTransferCoefficient
                                 FROM dbo.ProcessStream
                                 WHERE ProfileId = @ProfileId
                                 ORDER BY StreamId;";

            List<ProcessStreamDto> processStreams = new List<ProcessStreamDto>();

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
                            processStreams.Add(MapProcessStream(reader));
                        }
                    }
                }
            }

            return processStreams;
        }
        #endregion      // GetProcessStreamsByProfileId()

        #region GetProcessStreamById()
        /// <summary>
        /// Retrieves a process stream from the data store by its identifier.
        /// </summary>
        /// <param name="processStreamId">The unique identifier of the process stream to retrieve.</param>
        /// <returns>A <see cref="ProcessStreamDto"/> object representing the requested process stream, or <c>null</c> if no matching process stream is found.</returns>
        public ProcessStreamDto GetProcessStreamById(Guid processStreamId)
        {
            const string sql = @"SELECT Id,
                                        ProfileId,
                                        StreamCategory,
                                        StreamHeat,
                                        StreamId,
                                        StreamSegmentId,
                                        Name,
                                        StreamType,
                                        StreamSubtype,
                                        SupplyTemperature,
                                        SupplyPressure,
                                        TargetTemperature,
                                        TargetPressure,
                                        HeatCapacityFlowRate,
                                        HeatTransferCoefficient
                                 FROM dbo.ProcessStream
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, processStreamId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapProcessStream(reader);
                    }
                }
            }
        }
        #endregion      // GetProcessStreamById()

        #region GetProcessStreamByStreamId()
        /// <summary>
        /// Retrieves a process stream from the data store by its profile identifier and stream identifier.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile that owns the process stream.</param>
        /// <param name="streamId">The stream identifier to retrieve.</param>
        /// <returns>A <see cref="ProcessStreamDto"/> object representing the requested process stream, or <c>null</c> if no matching process stream is found.</returns>
        public ProcessStreamDto GetProcessStreamByStreamId(Guid profileId, string streamId)
        {
            if (String.IsNullOrWhiteSpace(streamId))
            {
                throw new ArgumentException("Stream ID cannot be null or whitespace.", nameof(streamId));
            }

            const string sql = @"SELECT Id,
                                        ProfileId,
                                        StreamCategory,
                                        StreamHeat,
                                        StreamId,
                                        StreamSegmentId,
                                        Name,
                                        StreamType,
                                        StreamSubtype,
                                        SupplyTemperature,
                                        SupplyPressure,
                                        TargetTemperature,
                                        TargetPressure,
                                        HeatCapacityFlowRate,
                                        HeatTransferCoefficient
                                 FROM dbo.ProcessStream
                                 WHERE ProfileId = @ProfileId
                                   AND StreamId = @StreamId;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProfileId", DbType.Guid, profileId);
                    AddParameter(command, "@StreamId", DbType.String, streamId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapProcessStream(reader);
                    }
                }
            }
        }
        #endregion      // GetProcessStreamByStreamId()

        #region AddProcessStream()
        /// <summary>
        /// Adds a new process stream to the data store.
        /// </summary>
        /// <param name="processStreamDto">The process stream data to insert.</param>
        /// <returns>The unique identifier of the inserted process stream.</returns>
        public Guid AddProcessStream(ProcessStreamDto processStreamDto)
        {
            if (processStreamDto == null)
            {
                throw new ArgumentNullException(nameof(processStreamDto));
            }

            const string sql = @"INSERT INTO dbo.ProcessStream
                                    (ProfileId,
                                     StreamCategory,
                                     StreamHeat,
                                     StreamId,
                                     Name,
                                     StreamType,
                                     StreamSubtype,
                                     SupplyTemperature,
                                     SupplyPressure,
                                     TargetTemperature,
                                     TargetPressure,
                                     HeatCapacityFlowRate,
                                     )
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@ProfileId,
                                     @StreamCategory,
                                     @StreamHeat,
                                     @StreamId,
                                     @StreamSegmentId,
                                     @Name,
                                     @StreamType,
                                     @StreamSubtype,
                                     @SupplyTemperature,
                                     @SupplyPressure,
                                     @TargetTemperature,
                                     @TargetPressure,
                                     @HeatCapacityFlowRate,
                                     @HeatTransferCoefficient);";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProfileId", DbType.Guid, processStreamDto.ProfileId);
                    AddParameter(command, "@StreamCategory", DbType.String, processStreamDto.StreamCategory);
                    AddParameter(command, "@StreamHeat", DbType.String, processStreamDto.StreamHeat);
                    AddParameter(command, "@StreamId", DbType.String, processStreamDto.StreamId);
                    AddParameter(command, "@Name", DbType.String, processStreamDto.Name);
                    AddParameter(command, "@StreamType", DbType.String, processStreamDto.StreamType);
                    AddParameter(command, "@StreamSubtype", DbType.String, processStreamDto.StreamSubtype);
                    AddParameter(command, "@SupplyTemperature", DbType.Double, processStreamDto.SupplyTemperature);
                    AddParameter(command, "@SupplyPressure", DbType.Double, processStreamDto.SupplyPressure);
                    AddParameter(command, "@TargetTemperature", DbType.Double, processStreamDto.TargetTemperature);
                    AddParameter(command, "@TargetPressure", DbType.Double, processStreamDto.TargetPressure);
                    AddParameter(command, "@HeatCapacityFlowRate", DbType.Double, processStreamDto.HeatCapacityFlowRate);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddProcessStream()

        #region UpdateProcessStream()
        /// <summary>
        /// Updates an existing process stream in the data store.
        /// </summary>
        /// <param name="processStreamDto">The process stream data to update.</param>
        public void UpdateProcessStream(ProcessStreamDto processStreamDto)
        {
            if (processStreamDto == null)
            {
                throw new ArgumentNullException(nameof(processStreamDto));
            }

            const string sql = @"UPDATE dbo.ProcessStream
                                 SET ProfileId = @ProfileId,
                                     StreamCategory = @StreamCategory,
                                     StreamHeat = @StreamHeat,
                                     StreamId = @StreamId,
                                     StreamSegmentId = @StreamSegmentId,
                                     Name = @Name,
                                     StreamType = @StreamType,
                                     StreamSubtype = @StreamSubtype,
                                     SupplyTemperature = @SupplyTemperature,
                                     SupplyPressure = @SupplyPressure,
                                     TargetTemperature = @TargetTemperature,
                                     TargetPressure = @TargetPressure,
                                     HeatCapacityFlowRate = @HeatCapacityFlowRate,
                                     HeatTransferCoefficient = @HeatTransferCoefficient
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, processStreamDto.Id);
                    AddParameter(command, "@ProfileId", DbType.Guid, processStreamDto.ProfileId);
                    AddParameter(command, "@StreamCategory", DbType.String, processStreamDto.StreamCategory);
                    AddParameter(command, "@StreamHeat", DbType.String, processStreamDto.StreamHeat);
                    AddParameter(command, "@StreamId", DbType.String, processStreamDto.StreamId);
                    AddParameter(command, "@StreamSegmentId", DbType.String, processStreamDto.StreamSegmentId);
                    AddParameter(command, "@Name", DbType.String, processStreamDto.Name);
                    AddParameter(command, "@StreamType", DbType.String, processStreamDto.StreamType);
                    AddParameter(command, "@StreamSubtype", DbType.String, processStreamDto.StreamSubtype);
                    AddParameter(command, "@SupplyTemperature", DbType.Double, processStreamDto.SupplyTemperature);
                    AddParameter(command, "@SupplyPressure", DbType.Double, processStreamDto.SupplyPressure);
                    AddParameter(command, "@TargetTemperature", DbType.Double, processStreamDto.TargetTemperature);
                    AddParameter(command, "@TargetPressure", DbType.Double, processStreamDto.TargetPressure);
                    AddParameter(command, "@HeatCapacityFlowRate", DbType.Double, processStreamDto.HeatCapacityFlowRate);
                    AddParameter(command, "@HeatTransferCoefficient", DbType.Double, processStreamDto.HeatTransferCoefficient);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateProcessStream()

        #region DeleteProcessStream()
        /// <summary>
        /// Deletes a process stream from the data store by its identifier.
        /// </summary>
        /// <param name="processStreamId">The unique identifier of the process stream to delete.</param>
        public void DeleteProcessStream(Guid processStreamId)
        {
            const string sql = @"DELETE FROM dbo.ProcessStream
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, processStreamId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // DeleteProcessStream()

        #endregion      // METHODS
    }
    #endregion      // public class ProcessStreamRepo
}
#endregion      // namespace HenPersistence.Repos

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
