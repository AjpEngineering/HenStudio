#region HEADER
//#####################################################################################################################
//#######################################  P r o j e c t U n i t s R e p o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  ProjectUnitsRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Project.DefaultParameters.ProjectUnits
//  CLASS(S):  ProjectUnitsRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the Project Units table.
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

using HenModel.RepoInterfaces.Project.DefaultParameters.ProjectUnits;
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

using System;
using System.Collections.Generic;
using System.Data;
#endregion      // REFERENCES

#region namespace HenModel.RepoImplementations.Project.DefaultParameters.ProjectUnits
namespace HenModel.RepoImplementations.Project.DefaultParameters.ProjectUnits
{
    #region public class ProjectUnitsRepo
    /// <summary>
    /// Project Units Repo Class
    /// </summary>
    public class ProjectUnitsRepo : IProjectUnitsRepo
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

        #region MapProjectUnits()
        /// <summary>
        /// Maps a data record from the project query result set to a <see cref="ProjectUnitsDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the project column values.</param>
        /// <param name="idOrdinal">The ordinal position of the <c>Id</c> column.</param>
        /// <param name="projectIdOrdinal">The ordinal position of the <c>ProjectId</c> column.</param>
        /// <param name="defaultSystemUnitsOrdinal">The ordinal position of the <c>DefaultSystemUnits</c> column.</param>
        /// <param name="defaultMagnitudeUnitsOrdinal">The ordinal position of the <c>DefaultMagnitudeUnits</c> column.</param>
        /// <param name="defaultTemperatureUnitsOrdinal">The ordinal position of the <c>DefaultTemperatureUnits</c> column.</param>
        /// <param name="defaultPressureUnitsOrdinal">The ordinal position of the <c>DefaultPressureUnits</c> column.</param>
        /// <returns>A <see cref="ProjectUnitsDto"/> populated from the supplied data record.</returns>
        private static ProjectUnitsDto MapProjectUnits( IDataRecord record,
                                              int idOrdinal,
                                              int projectIdOrdinal,
                                              int defaultSystemUnitsOrdinal,
                                              int defaultMagnitudeUnitsOrdinal,
                                              int defaultTemperatureUnitsOrdinal,
                                              int defaultPressureUnitsOrdinal)
        {
            return new ProjectUnitsDto
            {
                Id = record.GetGuid(idOrdinal),
                ProjectId = record.GetGuid(projectIdOrdinal),
                DefaultSystemUnits = record.IsDBNull(defaultSystemUnitsOrdinal) ? null : record.GetString(defaultSystemUnitsOrdinal),
                DefaultMagnitudeUnits = record.IsDBNull(defaultMagnitudeUnitsOrdinal) ? null : record.GetString(defaultMagnitudeUnitsOrdinal),
                DefaultTemperatureUnits = record.IsDBNull(defaultTemperatureUnitsOrdinal) ? null : record.GetString(defaultTemperatureUnitsOrdinal),
                DefaultPressureUnits = record.IsDBNull(defaultPressureUnitsOrdinal) ? null : record.GetString(defaultPressureUnitsOrdinal),
            };
        }
        #endregion      // MapProjectUnits()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public ProjectUnitsRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region GetProjectUnitsById()
        /// <summary>
        /// Retrieves a project from the data store by its identifier.
        /// </summary>
        /// <param name="projectUnitsId">The unique identifier of the project units to retrieve.</param>
        /// <returns>A <see cref="ProjectUnitsDto"/> object representing the requested project units, or <c>null</c> if no matching project units is found.</returns>
        public ProjectUnitsDto GetProjectUnitsById(Guid projectUnitsId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        DefaultSystemUnits,
                                        DefaultMagnitudeUnits,
                                        DefaultTemperatureUnits,
                                        DefaultPressureUnits
                                 FROM dbo.ProjectUnits
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, projectUnitsId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapProjectUnits(
                            reader,
                            reader.GetOrdinal("Id"),
                            reader.GetOrdinal("ProjectId"),
                            reader.GetOrdinal("DefaultSystemUnits"),
                            reader.GetOrdinal("DefaultMagnitudeUnits"),
                            reader.GetOrdinal("DefaultTemperatureUnits"),
                            reader.GetOrdinal("DefaultPressureUnits"));
                    }
                }
            }
        }
        #endregion      // GetProjectUnitsById()

        #region GetProjectUnitsByProjectId()
        /// <summary>
        /// Retrieves a project from the data store by its identifier.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project to retrieve.</param>
        /// <returns>A <see cref="ProjectUnitsDto"/> object representing the requested project, or <c>null</c> if no matching project is found.</returns>
        public ProjectUnitsDto GetProjectUnitsByProjectId(Guid projectId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        DefaultSystemUnits,
                                        DefaultMagnitudeUnits,
                                        DefaultTemperatureUnits,
                                        DefaultPressureUnits
                                 FROM dbo.ProjectUnits
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

                        return MapProjectUnits(
                            reader,
                            reader.GetOrdinal("Id"),
                            reader.GetOrdinal("ProjectId"),
                            reader.GetOrdinal("DefaultSystemUnits"),
                            reader.GetOrdinal("DefaultMagnitudeUnits"),
                            reader.GetOrdinal("DefaultTemperatureUnits"),
                            reader.GetOrdinal("DefaultPressureUnits"));
                    }
                }
            }
        }
        #endregion      // GetProjectByProjectId()

        #region AddProjectUnits()
        /// <summary>
        /// Adds a new project units to the data store.
        /// </summary>
        /// <param name="projectUnitsDto">The project units data to insert.</param>
        /// <returns>The unique identifier of the inserted project units.</returns>
        public Guid AddProjectUnits(ProjectUnitsDto projectUnitsDto)
        {
            if (projectUnitsDto == null)
            {
                throw new ArgumentNullException(nameof(projectUnitsDto));
            }

            const string sql = @"INSERT INTO dbo.ProjectUnits
                                    (ProjectId,
                                     DefaultSystemUnits,
                                     DefaultMagnitudeUnits,
                                     DefaultTemperatureUnits,
                                     DefaultPressureUnits)
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@ProjectId,
                                     @DefaultSystemUnits,
                                     @DefaultMagnitudeUnits,
                                     @DefaultTemperatureUnits,
                                     @DefaultPressureUnits);";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProjectId   ", DbType.String, projectUnitsDto.ProjectId);
                    AddParameter(command, "@DefaultSystemUnits", DbType.String, projectUnitsDto.DefaultSystemUnits);
                    AddParameter(command, "@DefaultMagnitudeUnits", DbType.String, projectUnitsDto.DefaultMagnitudeUnits);
                    AddParameter(command, "@DefaultTemperatureUnits", DbType.String, projectUnitsDto.DefaultTemperatureUnits);
                    AddParameter(command, "@DefaultPressureUnits", DbType.String, projectUnitsDto.DefaultPressureUnits);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddProjectUnits()

        #region UpdateProjectUnits()
        /// <summary>
        /// Updates an existing project units in the data store.
        /// </summary>
        /// <param name="projectUnitsDto">The project units data to update.</param>
        public void UpdateProjectUnits(ProjectUnitsDto projectUnitsDto)
        {
            if (projectUnitsDto == null)
            {
                throw new ArgumentNullException(nameof(projectUnitsDto));
            }

            const string sql = @"UPDATE dbo.ProjectUnits
                                 SET ProjectId = @ProjectId,
                                     DefaultSystemUnits = @DefaultSystemUnits,
                                     DefaultMagnitudeUnits = @DefaultMagnitudeUnits,
                                     DefaultTemperatureUnits = @DefaultTemperatureUnits,
                                     DefaultPressureUnits = @DefaultPressureUnits
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, projectUnitsDto.Id);
                    AddParameter(command, "@ProjectId", DbType.String, projectUnitsDto.ProjectId);
                    AddParameter(command, "@DefaultSystemUnits", DbType.String, projectUnitsDto.DefaultSystemUnits);
                    AddParameter(command, "@DefaultMagnitudeUnits", DbType.String, projectUnitsDto.DefaultMagnitudeUnits);
                    AddParameter(command, "@DefaultTemperatureUnits", DbType.String, projectUnitsDto.DefaultTemperatureUnits);
                    AddParameter(command, "@DefaultPressureUnits", DbType.String, projectUnitsDto.DefaultPressureUnits);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateProjectUnits()

        #region DeleteProjectUnits()
        /// <summary>
        /// Deletes a project units from the data store by its identifier.
        /// </summary>
        /// <param name="projectUnitsId">The unique identifier of the project units to delete.</param>
        public void DeleteProjectUnits(Guid projectUnitsId)
        {
            const string sql = @"DELETE FROM dbo.ProjectUnits
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, projectUnitsId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // DeleteProjectUnits()

        #endregion      // METHODS
    }
    #endregion      // public class ProjectUnitsRepo
}
#endregion      // namespace HenModel.RepoImplementations.Project.DefaultParameters.ProjectUnits

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
