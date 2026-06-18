#region HEADER
//#####################################################################################################################
//#####################################  U t i l i t y S t r e a m R e p o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  UtilityStreamRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Profile
//  CLASS(S):  UtilityStreamRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the UtilityStream Profile sub table.
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
using HenModel.RepoInterfaces.Profile.Streams;
using HenModel.Dto.Profile.Streams;

using System;
using System.Collections.Generic;
using System.Data;
#endregion      // REFERENCES

#region namespace HenModel.RepoImplementations.Profile.Streams
namespace HenModel.RepoImplementations.Profile.Streams
{
    #region public class UtilityStreamRepo
    /// <summary>
    /// UtilityStream Repo Class
    /// </summary>
    public class UtilityStreamRepo : IUtilityStreamRepo
    {
        #region PRIVATE FIELDS
        private readonly IConnectionFactory _connectionFactory;
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

        #region MapUtilityStream()
        /// <summary>
        /// Maps a data record from the utility stream query result set to a <see cref="UtilityStreamDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the utility stream column values.</param>
        /// <returns>A <see cref="UtilityStreamDto"/> populated from the supplied data record.</returns>
        private static UtilityStreamDto MapUtilityStream(IDataRecord record)
        {
            return new UtilityStreamDto
            {
                Id = record.GetGuid(record.GetOrdinal("Id")),
                ProfileId = record.GetGuid(record.GetOrdinal("ProfileId")),
                StreamCategory = record.IsDBNull(record.GetOrdinal("StreamCategory")) ? null : record.GetString(record.GetOrdinal("StreamCategory")),
                StreamHeat = record.IsDBNull(record.GetOrdinal("StreamHeat")) ? null : record.GetString(record.GetOrdinal("StreamHeat")),
                StreamId = record.IsDBNull(record.GetOrdinal("StreamId")) ? null : record.GetString(record.GetOrdinal("StreamId")),
                Name = record.IsDBNull(record.GetOrdinal("Name")) ? null : record.GetString(record.GetOrdinal("Name")),
                UtilityType = record.IsDBNull(record.GetOrdinal("UtilityType")) ? null : record.GetString(record.GetOrdinal("UtilityType")),
                StreamSubtype = record.IsDBNull(record.GetOrdinal("StreamSubtype")) ? null : record.GetString(record.GetOrdinal("StreamSubtype")),
                IsothermalTemperature = record.GetDouble(record.GetOrdinal("IsothermalTemperature")),
                SupplyTemperature = record.GetDouble(record.GetOrdinal("SupplyTemperature")),
                SupplyPressure = record.GetDouble(record.GetOrdinal("SupplyPressure")),
                TargetTemperature = record.GetDouble(record.GetOrdinal("TargetTemperature")),
                TargetPressure = record.GetDouble(record.GetOrdinal("TargetPressure")),
                EnthalpyFlowRate = record.GetDouble(record.GetOrdinal("EnthalpyFlowRate"))
            };
        }
        #endregion      // MapUtilityStream()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public UtilityStreamRepo(IConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region UTILITY STREAM CRUD METHODS

        #region CREATE METHODS

        #region AddUtilityStream() ... CREATE SINGLE STREAM ROW
        /// <summary>
        /// Adds (CREATE) a new SINGLE utility stream to the data store.
        /// </summary>
        /// <param name="utilityStreamDto">The utility stream data to insert.</param>
        /// <returns>The unique identifier of the inserted utility stream.</returns>
        public Guid AddUtilityStream(UtilityStreamDto utilityStreamDto)
        {
            if (utilityStreamDto == null)
            {
                throw new ArgumentNullException(nameof(utilityStreamDto));
            }

            const string sql = @"INSERT INTO dbo.UtilityStream
                                    (ProfileId,
                                     StreamCategory,
                                     StreamHeat,
                                     StreamId,
                                     Name,
                                     UtilityType,
                                     StreamSubtype,
                                     IsothermalTemperature,
                                     SupplyTemperature,
                                     SupplyPressure,
                                     TargetTemperature,
                                     TargetPressure,
                                     EnthalpyFlowRate)
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@ProfileId,
                                     @StreamCategory,
                                     @StreamHeat,
                                     @StreamId,
                                     @Name,
                                     @UtilityType,
                                     @StreamSubtype,
                                     @IsothermalTemperature,
                                     @SupplyTemperature,
                                     @SupplyPressure,
                                     @TargetTemperature,
                                     @TargetPressure,
                                     @EnthalpyFlowRate);";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProfileId", DbType.Guid, utilityStreamDto.ProfileId);
                    AddParameter(command, "@StreamCategory", DbType.String, utilityStreamDto.StreamCategory);
                    AddParameter(command, "@StreamHeat", DbType.String, utilityStreamDto.StreamHeat);
                    AddParameter(command, "@StreamId", DbType.String, utilityStreamDto.StreamId);
                    AddParameter(command, "@Name", DbType.String, utilityStreamDto.Name);
                    AddParameter(command, "@UtilityType", DbType.String, utilityStreamDto.UtilityType);
                    AddParameter(command, "@StreamSubtype", DbType.String, utilityStreamDto.StreamSubtype);
                    AddParameter(command, "@IsothermalTemperature", DbType.Double, utilityStreamDto.IsothermalTemperature);
                    AddParameter(command, "@SupplyTemperature", DbType.Double, utilityStreamDto.SupplyTemperature);
                    AddParameter(command, "@SupplyPressure", DbType.Double, utilityStreamDto.SupplyPressure);
                    AddParameter(command, "@TargetTemperature", DbType.Double, utilityStreamDto.TargetTemperature);
                    AddParameter(command, "@TargetPressure", DbType.Double, utilityStreamDto.TargetPressure);
                    AddParameter(command, "@EnthalpyFlowRate", DbType.Double, utilityStreamDto.EnthalpyFlowRate);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddUtilityStream() ... CREATE SINGLE STREAM ROW

        #region AddUtilityStreams() ... CREATE MULTIPLE STREAM ROWS
        /// <summary>
        /// Adds (CREATE) a new LIST of utility stream to the data store.
        /// </summary>
        /// <param name="utilityStreamDto">The utility stream data to insert.</param>
        /// <returns>The unique identifier of the inserted utility stream.</returns>
        public Guid AddUtilityStreams(List<UtilityStreamDto> utilityStreamDtos)
        {
            Guid profileId = new Guid();

            if (utilityStreamDtos == null)
            {
                throw new ArgumentNullException(nameof(utilityStreamDtos));
            }

            const string sql = @"INSERT INTO dbo.UtilityStream
                                    (ProfileId,
                                     StreamCategory,
                                     StreamHeat,
                                     StreamId,
                                     Name,
                                     UtilityType,
                                     StreamSubtype,
                                     IsothermalTemperature,
                                     SupplyTemperature,
                                     SupplyPressure,
                                     TargetTemperature,
                                     TargetPressure,
                                     EnthalpyFlowRate)
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@ProfileId,
                                     @StreamCategory,
                                     @StreamHeat,
                                     @StreamId,
                                     @Name,
                                     @UtilityType,
                                     @StreamSubtype,
                                     @IsothermalTemperature,
                                     @SupplyTemperature,
                                     @SupplyPressure,
                                     @TargetTemperature,
                                     @TargetPressure,
                                     @EnthalpyFlowRate);";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                connection.Open();

                foreach (var utilityStreamDto in utilityStreamDtos)
                {
                    profileId = utilityStreamDto.ProfileId;

                    using (IDbCommand command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        command.CommandType = CommandType.Text;
                        AddParameter(command, "@ProfileId", DbType.Guid, utilityStreamDto.ProfileId);
                        AddParameter(command, "@StreamCategory", DbType.String, utilityStreamDto.StreamCategory);
                        AddParameter(command, "@StreamHeat", DbType.String, utilityStreamDto.StreamHeat);
                        AddParameter(command, "@StreamId", DbType.String, utilityStreamDto.StreamId);
                        AddParameter(command, "@Name", DbType.String, utilityStreamDto.Name);
                        AddParameter(command, "@UtilityType", DbType.String, utilityStreamDto.UtilityType);
                        AddParameter(command, "@StreamSubtype", DbType.String, utilityStreamDto.StreamSubtype);
                        AddParameter(command, "@IsothermalTemperature", DbType.Double, utilityStreamDto.IsothermalTemperature);
                        AddParameter(command, "@SupplyTemperature", DbType.Double, utilityStreamDto.SupplyTemperature);
                        AddParameter(command, "@SupplyPressure", DbType.Double, utilityStreamDto.SupplyPressure);
                        AddParameter(command, "@TargetTemperature", DbType.Double, utilityStreamDto.TargetTemperature);
                        AddParameter(command, "@TargetPressure", DbType.Double, utilityStreamDto.TargetPressure);
                        AddParameter(command, "@EnthalpyFlowRate", DbType.Double, utilityStreamDto.EnthalpyFlowRate);

                        command.ExecuteScalar();
                    }
                }
            }
            return profileId;
        }
        #endregion      // AddUtilityStreams() ... CREATE SINGLE STREAM ROW

        #endregion  // CREATE METHODS

        #region READ METHODS

        #region GetUtilityStreams() ... READ MULTIPLE STREAM ROWS
        /// <summary>
        /// Retrieves (READ) LIST of utility streams from the data store.
        /// </summary>
        /// <returns>A list of <see cref="UtilityStreamDto"/> objects representing all utility streams. The list is empty if no utility streams are found.</returns>
        public IList<UtilityStreamDto> GetUtilityStreams()
        {
            const string sql = @"SELECT Id,
                                        ProfileId,
                                        StreamCategory,
                                        StreamHeat,
                                        StreamId,
                                        Name,
                                        UtilityType,
                                        StreamSubtype,
                                        IsothermalTemperature,
                                        SupplyTemperature,
                                        SupplyPressure,
                                        TargetTemperature,
                                        TargetPressure,
                                        EnthalpyFlowRate
                                 FROM dbo.UtilityStream
                                 ORDER BY StreamId;";

            List<UtilityStreamDto> utilityStreams = new List<UtilityStreamDto>();

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
                            utilityStreams.Add(MapUtilityStream(reader));
                        }
                    }
                }
            }

            return utilityStreams;
        }
        #endregion      // GetUtilityStreams() ... READ MULTIPLE STREAM ROWS

        #region GetUtilityStreamsByProfileId() ... READ MULTIPLE STREAM ROWS BY PROFILE ID
        /// <summary>
        /// Retrieves (READ) LIST of utility streams for the specified profile from the data store.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile whose utility streams are to be retrieved.</param>
        /// <returns>A list of <see cref="UtilityStreamDto"/> objects representing the matching utility streams. The list is empty if no utility streams are found.</returns>
        public IList<UtilityStreamDto> GetUtilityStreamsByProfileId(Guid profileId)
        {
            const string sql = @"SELECT Id,
                                        ProfileId,
                                        StreamCategory,
                                        StreamHeat,
                                        StreamId,
                                        Name,
                                        UtilityType,
                                        StreamSubtype,
                                        IsothermalTemperature,
                                        SupplyTemperature,
                                        SupplyPressure,
                                        TargetTemperature,
                                        TargetPressure,
                                        EnthalpyFlowRate
                                 FROM dbo.UtilityStream
                                 WHERE ProfileId = @ProfileId
                                 ORDER BY StreamId;";

            List<UtilityStreamDto> utilityStreams = new List<UtilityStreamDto>();

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
                            utilityStreams.Add(MapUtilityStream(reader));
                        }
                    }
                }
            }

            return utilityStreams;
        }
        #endregion      // GetUtilityStreamsByProfileId() ... READ MULTIPLE STREAM ROWS BY PROFILE ID

        #region GetUtilityStreamById() ... READ SINGLE STREAM ROW
        /// <summary>
        /// Retrieves (READ) a SINGLE utility stream from the data store by its identifier.
        /// </summary>
        /// <param name="utilityStreamId">The unique identifier of the utility stream to retrieve.</param>
        /// <returns>A <see cref="UtilityStreamDto"/> object representing the requested utility stream, or <c>null</c> if no matching utility stream is found.</returns>
        public UtilityStreamDto GetUtilityStreamById(Guid utilityStreamId)
        {
            const string sql = @"SELECT Id,
                                        ProfileId,
                                        StreamCategory,
                                        StreamHeat,
                                        StreamId,
                                        Name,
                                        UtilityType,
                                        StreamSubtype,
                                        IsothermalTemperature,
                                        SupplyTemperature,
                                        SupplyPressure,
                                        TargetTemperature,
                                        TargetPressure,
                                        EnthalpyFlowRate
                                 FROM dbo.UtilityStream
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, utilityStreamId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapUtilityStream(reader);
                    }
                }
            }
        }
        #endregion      // GetUtilityStreamById() ... READ

        #region GetUtilityStreamByStreamId() ... READ SINGLE STREAM ROW BY STREAM ID
        /// <summary>
        /// Retrieves (READ) a SINGLE utility stream from the data store by its profile identifier and stream identifier.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile that owns the utility stream.</param>
        /// <param name="streamId">The stream identifier to retrieve.</param>
        /// <returns>A <see cref="UtilityStreamDto"/> object representing the requested utility stream, or <c>null</c> if no matching utility stream is found.</returns>
        public UtilityStreamDto GetUtilityStreamByStreamId(Guid profileId, string streamId)
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
                                        Name,
                                        UtilityType,
                                        StreamSubtype,
                                        IsothermalTemperature,
                                        SupplyTemperature,
                                        SupplyPressure,
                                        TargetTemperature,
                                        TargetPressure,
                                        EnthalpyFlowRate
                                 FROM dbo.UtilityStream
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

                        return MapUtilityStream(reader);
                    }
                }
            }
        }
        #endregion      // GetUtilityStreamByStreamId() ... READ SINGLE STREAM ROW BY STREAM ID

        #endregion  // READ METHODS

        #region UPDATE METHODS

        #region UpdateUtilityStream() ... UPDATE SINGLE STREAM ROW
        /// <summary>
        /// Updates (UPDATE) a SINGLE existing utility stream in the data store.
        /// </summary>
        /// <param name="utilityStreamDto">The utility stream data to update.</param>
        public void UpdateUtilityStream(UtilityStreamDto utilityStreamDto)
        {
            if (utilityStreamDto == null)
            {
                throw new ArgumentNullException(nameof(utilityStreamDto));
            }

            const string sql = @"UPDATE dbo.UtilityStream
                                 SET ProfileId = @ProfileId,
                                     StreamCategory = @StreamCategory,
                                     StreamHeat = @StreamHeat,
                                     StreamId = @StreamId,
                                     Name = @Name,
                                     UtilityType = @UtilityType,
                                     StreamSubtype = @StreamSubtype,
                                     IsothermalTemperature = @IsothermalTemperature,
                                     SupplyTemperature = @SupplyTemperature,
                                     SupplyPressure = @SupplyPressure,
                                     TargetTemperature = @TargetTemperature,
                                     TargetPressure = @TargetPressure,
                                     EnthalpyFlowRate = @EnthalpyFlowRate
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, utilityStreamDto.Id);
                    AddParameter(command, "@ProfileId", DbType.Guid, utilityStreamDto.ProfileId);
                    AddParameter(command, "@StreamCategory", DbType.String, utilityStreamDto.StreamCategory);
                    AddParameter(command, "@StreamHeat", DbType.String, utilityStreamDto.StreamHeat);
                    AddParameter(command, "@StreamId", DbType.String, utilityStreamDto.StreamId);
                    AddParameter(command, "@Name", DbType.String, utilityStreamDto.Name);
                    AddParameter(command, "@UtilityType", DbType.String, utilityStreamDto.UtilityType);
                    AddParameter(command, "@StreamSubtype", DbType.String, utilityStreamDto.StreamSubtype);
                    AddParameter(command, "@IsothermalTemperature", DbType.Double, utilityStreamDto.IsothermalTemperature);
                    AddParameter(command, "@SupplyTemperature", DbType.Double, utilityStreamDto.SupplyTemperature);
                    AddParameter(command, "@SupplyPressure", DbType.Double, utilityStreamDto.SupplyPressure);
                    AddParameter(command, "@TargetTemperature", DbType.Double, utilityStreamDto.TargetTemperature);
                    AddParameter(command, "@TargetPressure", DbType.Double, utilityStreamDto.TargetPressure);
                    AddParameter(command, "@EnthalpyFlowRate", DbType.Double, utilityStreamDto.EnthalpyFlowRate);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateUtilityStream() ... UPDATE SINGLE STREAM ROW

        #region UpdateUtilityStreams() ... UPDATE MULTIPLE STREAM ROWS
        /// <summary>
        /// Updates (UPDATE) MULTIPLE existing utility streams in the data store.
        /// </summary>
        /// <param name="utilityStreamDtos">The utility stream data to update.</param>
        public void UpdateUtilityStreams(IList<UtilityStreamDto> utilityStreamDtos)
        {
            if (utilityStreamDtos == null)
            {
                throw new ArgumentNullException(nameof(utilityStreamDtos));
            }

            const string sql = @"UPDATE dbo.UtilityStream
                                 SET ProfileId = @ProfileId,
                                     StreamCategory = @StreamCategory,
                                     StreamHeat = @StreamHeat,
                                     StreamId = @StreamId,
                                     Name = @Name,
                                     UtilityType = @UtilityType,
                                     StreamSubtype = @StreamSubtype,
                                     IsothermalTemperature = @IsothermalTemperature,
                                     SupplyTemperature = @SupplyTemperature,
                                     SupplyPressure = @SupplyPressure,
                                     TargetTemperature = @TargetTemperature,
                                     TargetPressure = @TargetPressure,
                                     EnthalpyFlowRate = @EnthalpyFlowRate
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                connection.Open();

                foreach (var utilityStreamDto in utilityStreamDtos)
                {
                    using (IDbCommand command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        command.CommandType = CommandType.Text;
                        AddParameter(command, "@Id", DbType.Guid, utilityStreamDto.Id);
                        AddParameter(command, "@ProfileId", DbType.Guid, utilityStreamDto.ProfileId);
                        AddParameter(command, "@StreamCategory", DbType.String, utilityStreamDto.StreamCategory);
                        AddParameter(command, "@StreamHeat", DbType.String, utilityStreamDto.StreamHeat);
                        AddParameter(command, "@StreamId", DbType.String, utilityStreamDto.StreamId);
                        AddParameter(command, "@Name", DbType.String, utilityStreamDto.Name);
                        AddParameter(command, "@UtilityType", DbType.String, utilityStreamDto.UtilityType);
                        AddParameter(command, "@StreamSubtype", DbType.String, utilityStreamDto.StreamSubtype);
                        AddParameter(command, "@IsothermalTemperature", DbType.Double, utilityStreamDto.IsothermalTemperature);
                        AddParameter(command, "@SupplyTemperature", DbType.Double, utilityStreamDto.SupplyTemperature);
                        AddParameter(command, "@SupplyPressure", DbType.Double, utilityStreamDto.SupplyPressure);
                        AddParameter(command, "@TargetTemperature", DbType.Double, utilityStreamDto.TargetTemperature);
                        AddParameter(command, "@TargetPressure", DbType.Double, utilityStreamDto.TargetPressure);
                        AddParameter(command, "@EnthalpyFlowRate", DbType.Double, utilityStreamDto.EnthalpyFlowRate);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        #endregion      // UpdateUtilityStream() ... UPDATE MULTIPLE STREAM ROWS

        #endregion  // UPDATE METHODS

        #region DELETE METHODS

        #region DeleteUtilityStream() ... DELETE SINGLE STREAM ROW
        /// <summary>
        /// Deletes (DELETE) a SINGLE utility stream from the data store by its identifier.
        /// </summary>
        /// <param name="utilityStreamId">The unique identifier of the utility stream to delete.</param>
        public void DeleteUtilityStream(Guid utilityStreamId)
        {
            const string sql = @"DELETE FROM dbo.UtilityStream
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, utilityStreamId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // DeleteUtilityStream() ... DELETE SINGLE STREAM ROW

        #endregion  // DELETE METHODS

        #endregion      // UTILITY STREAM CRUD METHODS
    }
    #endregion      // public class UtilityStreamRepo
}
#endregion      // namespace HenModel.RepoImplementations.Profile.Streams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
