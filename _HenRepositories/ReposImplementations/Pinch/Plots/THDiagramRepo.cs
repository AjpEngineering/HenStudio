#region HEADER
//#####################################################################################################################
//##########################################  T H D i a g r a m R e p o . c s  ########################################
//#####################################################################################################################
//  FILENAME:  THDiagramRepo.cs
//  NAMESPACE: HenPersistence.Repos
//  CLASS(S):  THDiagramRepo
//  COMPONENT: _HenPersistence.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the THDiagram Profile sub table.
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
    #region public class THDiagramRepo
    /// <summary>
    /// THDiagram Repo Class
    /// </summary>
    public class THDiagramRepo : ITHDiagramRepo
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

        #region MapTHDiagram()
        /// <summary>
        /// Maps a data record from the T-H diagram query result set to a <see cref="THDiagramDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the T-H diagram column values.</param>
        /// <returns>A <see cref="THDiagramDto"/> populated from the supplied data record.</returns>
        private static THDiagramDto MapTHDiagram(IDataRecord record)
        {
            return new THDiagramDto
            {
                Id = record.GetGuid(record.GetOrdinal("Id")),
                ProfileId = record.GetGuid(record.GetOrdinal("ProfileId")),
                DiagramType = record.IsDBNull(record.GetOrdinal("DiagramType")) ? null : record.GetString(record.GetOrdinal("DiagramType")),
                Title = record.IsDBNull(record.GetOrdinal("Title")) ? null : record.GetString(record.GetOrdinal("Title")),
                XAxisLabel = record.IsDBNull(record.GetOrdinal("XAxisLabel")) ? null : record.GetString(record.GetOrdinal("XAxisLabel")),
                YAxisLabel = record.IsDBNull(record.GetOrdinal("YAxisLabel")) ? null : record.GetString(record.GetOrdinal("YAxisLabel"))
            };
        }
        #endregion      // MapTHDiagram()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public THDiagramRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region GetTHDiagrams()
        /// <summary>
        /// Retrieves all T-H diagrams from the data store.
        /// </summary>
        /// <returns>A list of <see cref="THDiagramDto"/> objects representing all T-H diagrams. The list is empty if no T-H diagrams are found.</returns>
        public IList<THDiagramDto> GetTHDiagrams()
        {
            const string sql = @"SELECT Id,
                                        ProfileId,
                                        DiagramType,
                                        Title,
                                        XAxisLabel,
                                        YAxisLabel
                                 FROM dbo.THDiagram
                                 ORDER BY Title;";

            List<THDiagramDto> thDiagrams = new List<THDiagramDto>();

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
                            thDiagrams.Add(MapTHDiagram(reader));
                        }
                    }
                }
            }

            return thDiagrams;
        }
        #endregion      // GetTHDiagrams()

        #region GetTHDiagramsByProfileId()
        /// <summary>
        /// Retrieves all T-H diagrams for the specified profile from the data store.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile whose T-H diagrams are to be retrieved.</param>
        /// <returns>A list of <see cref="THDiagramDto"/> objects representing the matching T-H diagrams. The list is empty if no T-H diagrams are found.</returns>
        public IList<THDiagramDto> GetTHDiagramsByProfileId(Guid profileId)
        {
            const string sql = @"SELECT Id,
                                        ProfileId,
                                        DiagramType,
                                        Title,
                                        XAxisLabel,
                                        YAxisLabel
                                 FROM dbo.THDiagram
                                 WHERE ProfileId = @ProfileId
                                 ORDER BY Title;";

            List<THDiagramDto> thDiagrams = new List<THDiagramDto>();

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
                            thDiagrams.Add(MapTHDiagram(reader));
                        }
                    }
                }
            }

            return thDiagrams;
        }
        #endregion      // GetTHDiagramsByProfileId()

        #region GetTHDiagramById()
        /// <summary>
        /// Retrieves a T-H diagram from the data store by its identifier.
        /// </summary>
        /// <param name="thDiagramId">The unique identifier of the T-H diagram to retrieve.</param>
        /// <returns>A <see cref="THDiagramDto"/> object representing the requested T-H diagram, or <c>null</c> if no matching T-H diagram is found.</returns>
        public THDiagramDto GetTHDiagramById(Guid thDiagramId)
        {
            const string sql = @"SELECT Id,
                                        ProfileId,
                                        DiagramType,
                                        Title,
                                        XAxisLabel,
                                        YAxisLabel
                                 FROM dbo.THDiagram
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, thDiagramId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapTHDiagram(reader);
                    }
                }
            }
        }
        #endregion      // GetTHDiagramById()

        #region GetTHDiagramByTitle()
        /// <summary>
        /// Retrieves a T-H diagram from the data store by its profile identifier and title.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile that owns the T-H diagram.</param>
        /// <param name="title">The title to retrieve.</param>
        /// <returns>A <see cref="THDiagramDto"/> object representing the requested T-H diagram, or <c>null</c> if no matching T-H diagram is found.</returns>
        public THDiagramDto GetTHDiagramByTitle(Guid profileId, string title)
        {
            if (String.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title cannot be null or whitespace.", nameof(title));
            }

            const string sql = @"SELECT Id,
                                        ProfileId,
                                        DiagramType,
                                        Title,
                                        XAxisLabel,
                                        YAxisLabel
                                 FROM dbo.THDiagram
                                 WHERE ProfileId = @ProfileId
                                   AND Title = @Title;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProfileId", DbType.Guid, profileId);
                    AddParameter(command, "@Title", DbType.String, title);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapTHDiagram(reader);
                    }
                }
            }
        }
        #endregion      // GetTHDiagramByTitle()

        #region AddTHDiagram()
        /// <summary>
        /// Adds a new T-H diagram to the data store.
        /// </summary>
        /// <param name="thDiagramDto">The T-H diagram data to insert.</param>
        /// <returns>The unique identifier of the inserted T-H diagram.</returns>
        public Guid AddTHDiagram(THDiagramDto thDiagramDto)
        {
            if (thDiagramDto == null)
            {
                throw new ArgumentNullException(nameof(thDiagramDto));
            }

            const string sql = @"INSERT INTO dbo.THDiagram
                                    (ProfileId,
                                     DiagramType,
                                     Title,
                                     XAxisLabel,
                                     YAxisLabel)
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@ProfileId,
                                     @DiagramType,
                                     @Title,
                                     @XAxisLabel,
                                     @YAxisLabel);";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProfileId", DbType.Guid, thDiagramDto.ProfileId);
                    AddParameter(command, "@DiagramType", DbType.String, thDiagramDto.DiagramType);
                    AddParameter(command, "@Title", DbType.String, thDiagramDto.Title);
                    AddParameter(command, "@XAxisLabel", DbType.String, thDiagramDto.XAxisLabel);
                    AddParameter(command, "@YAxisLabel", DbType.String, thDiagramDto.YAxisLabel);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddTHDiagram()

        #region UpdateTHDiagram()
        /// <summary>
        /// Updates an existing T-H diagram in the data store.
        /// </summary>
        /// <param name="thDiagramDto">The T-H diagram data to update.</param>
        public void UpdateTHDiagram(THDiagramDto thDiagramDto)
        {
            if (thDiagramDto == null)
            {
                throw new ArgumentNullException(nameof(thDiagramDto));
            }

            const string sql = @"UPDATE dbo.THDiagram
                                 SET ProfileId = @ProfileId,
                                     DiagramType = @DiagramType,
                                     Title = @Title,
                                     XAxisLabel = @XAxisLabel,
                                     YAxisLabel = @YAxisLabel
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, thDiagramDto.Id);
                    AddParameter(command, "@ProfileId", DbType.Guid, thDiagramDto.ProfileId);
                    AddParameter(command, "@DiagramType", DbType.String, thDiagramDto.DiagramType);
                    AddParameter(command, "@Title", DbType.String, thDiagramDto.Title);
                    AddParameter(command, "@XAxisLabel", DbType.String, thDiagramDto.XAxisLabel);
                    AddParameter(command, "@YAxisLabel", DbType.String, thDiagramDto.YAxisLabel);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateTHDiagram()

        #region DeleteTHDiagram()
        /// <summary>
        /// Deletes a T-H diagram from the data store by its identifier.
        /// </summary>
        /// <param name="thDiagramId">The unique identifier of the T-H diagram to delete.</param>
        public void DeleteTHDiagram(Guid thDiagramId)
        {
            const string sql = @"DELETE FROM dbo.THDiagram
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, thDiagramId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // DeleteTHDiagram()

        #endregion      // METHODS
    }
    #endregion      // public class THDiagramRepo
}
#endregion      // namespace HenPersistence.Repos

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
