#region HEADER
//#####################################################################################################################
//############################################  P r o j e c t R e p o . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  ProjectRepo.cs
//  NAMESPACE: HenPersistence.Repos
//  CLASS(S):  ProjectRepo
//  COMPONENT: _HenPersistence.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the Project top-level table.
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
    #region public class ProjectRepo
    /// <summary>
    /// Project Repo Class
    /// </summary>
    public class ProjectRepo : IProjectRepo
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

        #region MapProject()
        /// <summary>
        /// Maps a data record from the project query result set to a <see cref="ProjectDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the project column values.</param>
        /// <param name="idOrdinal">The ordinal position of the <c>Id</c> column.</param>
        /// <param name="nameOrdinal">The ordinal position of the <c>Name</c> column.</param>
        /// <param name="descriptionOrdinal">The ordinal position of the <c>Description</c> column.</param>
        /// <param name="defaultHeatTransferCoefficientOrdinal">The ordinal position of the <c>DefaultHeatTransferCoefficient</c> column.</param>
        /// <param name="defaultCorrectionFactorOrdinal">The ordinal position of the <c>DefaultCorrectionFactor</c> column.</param>
        /// <param name="defaultHenOptimizerOrdinal">The ordinal position of the <c>DefaultHenOptimizer</c> column.</param>
        /// <param name="defaultSystemUnitsOrdinal">The ordinal position of the <c>DefaultSystemUnits</c> column.</param>
        /// <param name="defaultMagnitudeUnitsOrdinal">The ordinal position of the <c>DefaultMagnitudeUnits</c> column.</param>
        /// <param name="defaultTemperatureUnitsOrdinal">The ordinal position of the <c>DefaultTemperatureUnits</c> column.</param>
        /// <param name="defaultPressureUnitsOrdinal">The ordinal position of the <c>DefaultPressureUnits</c> column.</param>
        /// <param name="creationDateOrdinal">The ordinal position of the <c>CreationDate</c> column.</param>
        /// <param name="modifiedDateOrdinal">The ordinal position of the <c>ModifiedDate</c> column.</param>
        /// <returns>A <see cref="ProjectDto"/> populated from the supplied data record.</returns>
        private static ProjectDto MapProject( IDataRecord record,
                                              int idOrdinal,
                                              int nameOrdinal,
                                              int descriptionOrdinal,
                                              int defaultHeatTransferCoefficientOrdinal,
                                              int defaultCorrectionFactorOrdinal,
                                              int defaultHenOptimizerOrdinal,
                                              int defaultSystemUnitsOrdinal,
                                              int defaultMagnitudeUnitsOrdinal,
                                              int defaultTemperatureUnitsOrdinal,
                                              int defaultPressureUnitsOrdinal )
        {
            return new ProjectDto
            {
                Id = record.GetGuid(idOrdinal),
                Name = record.IsDBNull(nameOrdinal) ? null : record.GetString(nameOrdinal),
                Description = record.IsDBNull(descriptionOrdinal) ? null : record.GetString(descriptionOrdinal),
                DefaultHeatTransferCoefficient = record.GetDouble(defaultHeatTransferCoefficientOrdinal),
                DefaultCorrectionFactor = record.GetDouble(defaultCorrectionFactorOrdinal),
                DefaultHenOptimizer = record.IsDBNull(defaultHenOptimizerOrdinal) ? null : record.GetString(defaultHenOptimizerOrdinal),
                DefaultSystemUnits = record.IsDBNull(defaultSystemUnitsOrdinal) ? null : record.GetString(defaultSystemUnitsOrdinal),
                DefaultMagnitudeUnits = record.IsDBNull(defaultMagnitudeUnitsOrdinal) ? null : record.GetString(defaultMagnitudeUnitsOrdinal),
                DefaultTemperatureUnits = record.IsDBNull(defaultTemperatureUnitsOrdinal) ? null : record.GetString(defaultTemperatureUnitsOrdinal),
                DefaultPressureUnits = record.IsDBNull(defaultPressureUnitsOrdinal) ? null : record.GetString(defaultPressureUnitsOrdinal)
            };
        }
        #endregion      // MapProject()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public ProjectRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region GetProjects()
        /// <summary>
        /// Retrieves all projects from the data store.
        /// </summary>
        /// <returns>A list of <see cref="ProjectDto"/> objects representing all projects. The list is empty if no projects are found.</returns>
        public IList<ProjectDto> GetProjects()
        {
            const string sql = @"SELECT Id,
                                        Name,
                                        Description,
                                        DefaultHeatTransferCoefficient,
                                        DefaultCorrectionFactor,
                                        DefaultHenOptimizer,
                                        DefaultSystemUnits,
                                        DefaultMagnitudeUnits,
                                        DefaultTemperatureUnits,
                                        DefaultPressureUnits,
                                        CreationDate,
                                        ModifiedDate
                                 FROM dbo.Project
                                 ORDER BY Name;";

            List<ProjectDto> projects = new List<ProjectDto>();

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
                        int nameOrdinal = reader.GetOrdinal("Name");
                        int descriptionOrdinal = reader.GetOrdinal("Description");
                        int defaultHeatTransferCoefficientOrdinal = reader.GetOrdinal("DefaultHeatTransferCoefficient");
                        int defaultCorrectionFactorOrdinal = reader.GetOrdinal("DefaultCorrectionFactor");
                        int defaultHenOptimizerOrdinal = reader.GetOrdinal("DefaultHenOptimizer");
                        int defaultSystemUnitsOrdinal = reader.GetOrdinal("DefaultSystemUnits");
                        int defaultMagnitudeUnitsOrdinal = reader.GetOrdinal("DefaultMagnitudeUnits");
                        int defaultTemperatureUnitsOrdinal = reader.GetOrdinal("DefaultTemperatureUnits");
                        int defaultPressureUnitsOrdinal = reader.GetOrdinal("DefaultPressureUnits");

                        int creationDateOrdinal = reader.GetOrdinal("CreationDate");
                        int modifiedDateOrdinal = reader.GetOrdinal("ModifiedDate");
                        {
                            projects.Add(MapProject(
                                reader,
                                idOrdinal,
                                nameOrdinal,
                                descriptionOrdinal,
                                defaultHeatTransferCoefficientOrdinal,
                                defaultCorrectionFactorOrdinal,
                                defaultHenOptimizerOrdinal,
                                defaultSystemUnitsOrdinal,
                                defaultMagnitudeUnitsOrdinal,
                                defaultTemperatureUnitsOrdinal,
                                defaultPressureUnitsOrdinal));
                        }
                    }
                }
            }

            return projects;
        }
        #endregion      // GetProjects()

        #region GetProjectById()
        /// <summary>
        /// Retrieves a project from the data store by its identifier.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project to retrieve.</param>
        /// <returns>A <see cref="ProjectDto"/> object representing the requested project, or <c>null</c> if no matching project is found.</returns>
        public ProjectDto GetProjectById(Guid projectId)
        {
            const string sql = @"SELECT Id,
                                        Name,
                                        Description,
                                        DefaultHeatTransferCoefficient,
                                        DefaultCorrectionFactor,
                                        DefaultHenOptimizer,
                                        DefaultSystemUnits,
                                        DefaultMagnitudeUnits,
                                        DefaultTemperatureUnits,
                                        DefaultPressureUnits,
                                        CreationDate,
                                        ModifiedDate
                                 FROM dbo.Project
                                 WHERE Id = @Id;";

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

                        return MapProject(
                            reader,
                            reader.GetOrdinal("Id"),
                            reader.GetOrdinal("Name"),
                            reader.GetOrdinal("Description"),
                            reader.GetOrdinal("DefaultHeatTransferCoefficient"),
                            reader.GetOrdinal("DefaultCorrectionFactor"),
                            reader.GetOrdinal("DefaultHenOptimizer"),
                            reader.GetOrdinal("DefaultSystemUnits"),
                            reader.GetOrdinal("DefaultMagnitudeUnits"),
                            reader.GetOrdinal("DefaultTemperatureUnits"),
                            reader.GetOrdinal("DefaultPressureUnits"));
                    }
                }
            }
        }
        #endregion      // GetProjectById()

        #region GetProjectByName()
        /// <summary>
        /// Retrieves a project from the data store by its name.
        /// </summary>
        /// <param name="projectName">The project name to retrieve.</param>
        /// <returns>A <see cref="ProjectDto"/> object representing the requested project, or <c>null</c> if no matching project is found.</returns>
        public ProjectDto GetProjectByName(string projectName)
        {
            if (String.IsNullOrWhiteSpace(projectName))
            {
                throw new ArgumentException("Project name cannot be null or whitespace.", nameof(projectName));
            }

            const string sql = @"SELECT Id,
                                        Name,
                                        Description,
                                        DefaultHeatTransferCoefficient,
                                        DefaultCorrectionFactor,
                                        DefaultHenOptimizer,
                                        DefaultSystemUnits,
                                        DefaultMagnitudeUnits,
                                        DefaultTemperatureUnits,
                                        DefaultPressureUnits,
                                        CreationDate,
                                        ModifiedDate
                                 FROM dbo.Project
                                 WHERE Name = @Name;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Name", DbType.String, projectName);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapProject(
                            reader,
                            reader.GetOrdinal("Id"),
                            reader.GetOrdinal("Name"),
                            reader.GetOrdinal("Description"),
                            reader.GetOrdinal("DefaultHeatTransferCoefficient"),
                            reader.GetOrdinal("DefaultCorrectionFactor"),
                            reader.GetOrdinal("DefaultHenOptimizer"),
                            reader.GetOrdinal("DefaultSystemUnits"),
                            reader.GetOrdinal("DefaultMagnitudeUnits"),
                            reader.GetOrdinal("DefaultTemperatureUnits"),
                            reader.GetOrdinal("DefaultPressureUnits"));
                    }
                }
            }
        }
        #endregion      // GetProjectByName()

        #region AddProject()
        /// <summary>
        /// Adds a new project to the data store.
        /// </summary>
        /// <param name="projectDto">The project data to insert.</param>
        /// <returns>The unique identifier of the inserted project.</returns>
        public Guid AddProject(ProjectDto projectDto)
        {
            if (projectDto == null)
            {
                throw new ArgumentNullException(nameof(projectDto));
            }

            const string sql = @"INSERT INTO dbo.Project
                                    (Name,
                                     Description,
                                     DefaultHeatTransferCoefficient,
                                     DefaultCorrectionFactor,
                                     DefaultHenOptimizer,
                                     DefaultSystemUnits,
                                     DefaultMagnitudeUnits,
                                     DefaultTemperatureUnits,
                                     DefaultPressureUnits,
                                     CreationDate,
                                     ModifiedDate)
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@Name,
                                     @Description,
                                     @DefaultHeatTransferCoefficient,
                                     @DefaultCorrectionFactor,
                                     @DefaultHenOptimizer,
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
                    AddParameter(command, "@Name", DbType.String, projectDto.Name);
                    AddParameter(command, "@Description", DbType.String, projectDto.Description);
                    AddParameter(command, "@DefaultHeatTransferCoefficient", DbType.Double, projectDto.DefaultHeatTransferCoefficient);
                    AddParameter(command, "@DefaultCorrectionFactor", DbType.Double, projectDto.DefaultCorrectionFactor);
                    AddParameter(command, "@DefaultHenOptimizer", DbType.String, projectDto.DefaultHenOptimizer);
                    AddParameter(command, "@DefaultSystemUnits", DbType.String, projectDto.DefaultSystemUnits);
                    AddParameter(command, "@DefaultMagnitudeUnits", DbType.String, projectDto.DefaultMagnitudeUnits);
                    AddParameter(command, "@DefaultTemperatureUnits", DbType.String, projectDto.DefaultTemperatureUnits);
                    AddParameter(command, "@DefaultPressureUnits", DbType.String, projectDto.DefaultPressureUnits);
                    AddParameter(command, "@ModifiedDate", DbType.DateTime, DateTime.Now);
                    AddParameter(command, "@CreationDate", DbType.DateTime, projectDto.CreationDate);
                    AddParameter(command, "@ModifiedDate", DbType.DateTime, projectDto.ModifiedDate);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddProject()

        #region UpdateProject()
        /// <summary>
        /// Updates an existing project in the data store.
        /// </summary>
        /// <param name="projectDto">The project data to update.</param>
        public void UpdateProject(ProjectDto projectDto)
        {
            if (projectDto == null)
            {
                throw new ArgumentNullException(nameof(projectDto));
            }

            const string sql = @"UPDATE dbo.Project
                                 SET Name = @Name,
                                     Description = @Description,
                                     DefaultHeatTransferCoefficient = @DefaultHeatTransferCoefficient,
                                     DefaultCorrectionFactor = @DefaultCorrectionFactor,
                                     DefaultHenOptimizer = @DefaultHenOptimizer,
                                     DefaultSystemUnits = @DefaultSystemUnits,
                                     DefaultMagnitudeUnits = @DefaultMagnitudeUnits,
                                     DefaultTemperatureUnits = @DefaultTemperatureUnits,
                                     DefaultPressureUnits = @DefaultPressureUnits,
                                     ModifiedDate = @ModifiedDate
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, projectDto.Id);
                    AddParameter(command, "@Name", DbType.String, projectDto.Name);
                    AddParameter(command, "@Description", DbType.String, projectDto.Description);
                    AddParameter(command, "@DefaultHeatTransferCoefficient", DbType.Double, projectDto.DefaultHeatTransferCoefficient);
                    AddParameter(command, "@DefaultCorrectionFactor", DbType.Double, projectDto.DefaultCorrectionFactor);
                    AddParameter(command, "@DefaultHenOptimizer", DbType.String, projectDto.DefaultHenOptimizer);
                    AddParameter(command, "@DefaultSystemUnits", DbType.String, projectDto.DefaultSystemUnits);
                    AddParameter(command, "@DefaultMagnitudeUnits", DbType.String, projectDto.DefaultMagnitudeUnits);
                    AddParameter(command, "@DefaultTemperatureUnits", DbType.String, projectDto.DefaultTemperatureUnits);
                    AddParameter(command, "@DefaultPressureUnits", DbType.String, projectDto.DefaultPressureUnits);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateProject()

        #region DeleteProject()
        /// <summary>
        /// Deletes a project from the data store by its identifier.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project to delete.</param>
        public void DeleteProject(Guid projectId)
        {
            const string sql = @"DELETE FROM dbo.Project
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, projectId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // DeleteProject()

        #endregion      // METHODS
    }
    #endregion      // public class ProjectRepo
}
#endregion      // namespace HenPersistence.Repos

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
