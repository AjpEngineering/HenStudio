#region HEADER
//#####################################################################################################################
//############################################  P r o j e c t R e p o . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  ProjectRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Project
//  CLASS(S):  ProjectRepo
//  COMPONENT: _HenModel.dll
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
using HenModel.Connection;
using HenModel.Connection.Interface;
using HenModel.Dto.Project;
using HenModel.RepoInterfaces.Project;

using System;
using System.Collections.Generic;
using System.Data;
#endregion      // REFERENCES

#region namespace HenModel.RepoImplementations.Project
namespace HenModel.RepoImplementations.Project
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
        /// <param name="defaultOptimizerOrdinal">The ordinal position of the <c>DefaultOptimizer</c> column.</param>
        /// <param name="creationDateOrdinal">The ordinal position of the <c>CreationDate</c> column.</param>
        /// <param name="modifiedDateOrdinal">The ordinal position of the <c>ModifiedDate</c> column.</param>
        /// <returns>A <see cref="ProjectUnitsDto"/> populated from the supplied data record.</returns>
        private static ProjectDto MapProject( IDataRecord record,
                                              int idOrdinal,
                                              int nameOrdinal,
                                              int descriptionOrdinal,
                                              int defaultOptimizerOrdinal,
                                              int creationDateOrdinal,
                                              int modifiedDateOrdinal)
        {
            return new ProjectDto
            {
                Id = record.GetGuid(idOrdinal),
                Name = record.IsDBNull(nameOrdinal) ? null : record.GetString(nameOrdinal),
                Description = record.IsDBNull(descriptionOrdinal) ? null : record.GetString(descriptionOrdinal),
                DefaultOptimizer = record.IsDBNull(defaultOptimizerOrdinal) ? null : record.GetString(defaultOptimizerOrdinal),
                CreationDate = record.GetDateTime(creationDateOrdinal),
                ModifiedDate = record.GetDateTime(modifiedDateOrdinal),
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

        #region AddProject() ... CREATE
        /// <summary>
        /// Adds (CREATE) a new project to the data store.
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
                                     DefaultOptimizer,
                                     CreationDate,
                                     ModifiedDate)
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@Name,
                                     @Description,
                                     @DefaultHenOptimizer,
                                     @CreationDate,
                                     @ModifiedDate);";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Name", DbType.String, projectDto.Name);
                    AddParameter(command, "@Description", DbType.String, projectDto.Description);
                    AddParameter(command, "@DefaultOptimizer", DbType.String, projectDto.DefaultOptimizer);
                    AddParameter(command, "@CreationDate", DbType.DateTime, DateTime.Now);
                    AddParameter(command, "@ModifiedDate", DbType.DateTime, DateTime.Now);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddProject() ... CREATE

        #region GetProjects() ... READ
        /// <summary>
        /// Retrieves (READ) all projects from the data store.
        /// </summary>
        /// <returns>A list of <see cref="ProjectDto"/> objects representing all projects. The list is empty if no projects are found.</returns>
        public IList<ProjectDto> GetProjects()
        {
            const string sql = @"SELECT Id,
                                        Name,
                                        Description,
                                        DefaultOptimizer,
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
                        int defaultOptimizerOrdinal = reader.GetOrdinal("DefaultOptimizer");

                        int creationDateOrdinal = reader.GetOrdinal("CreationDate");
                        int modifiedDateOrdinal = reader.GetOrdinal("ModifiedDate");
                        {
                            projects.Add(MapProject(
                                reader,
                                idOrdinal,
                                nameOrdinal,
                                descriptionOrdinal,
                                defaultOptimizerOrdinal,
                                creationDateOrdinal,
                                modifiedDateOrdinal));
                        }
                    }
                }
            }
            
            return projects;
        }
        #endregion      // GetProjects() ... READ

        #region GetProjectById() ... READ
        /// <summary>
        /// Retrieves (READ) a project from the data store by its identifier.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project to retrieve.</param>
        /// <returns>A <see cref="ProjectDto"/> object representing the requested project, or <c>null</c> if no matching project is found.</returns>
        public ProjectDto GetProjectById(Guid projectId)
        {
            const string sql = @"SELECT Id,
                                        Name,
                                        Description,
                                        DefaultOptimizer,
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
                            reader.GetOrdinal("DefaultOptimizer"),
                            reader.GetOrdinal("CreationDate"),
                            reader.GetOrdinal("ModifiedDate"));
                    }
                }
            }
        }
        #endregion      // GetProjectById() ... READ

        #region GetProjectByName() ... READ
        /// <summary>
        /// Retrieves (READ) a project from the data store by its name.
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
                                        DefaultOptimizer,
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
                            reader.GetOrdinal("DefaultOptimizer"),
                            reader.GetOrdinal("CreationDate"),
                            reader.GetOrdinal("ModifiedDate"));
                    }
                }
            }
        }
        #endregion      // GetProjectByName() ... READ

        #region UpdateProject() ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing project in the data store.
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
                                     DefaultOptimizer = @DefaultOptimizer,
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
                    AddParameter(command, "@DefaultOptimizer", DbType.String, projectDto.DefaultOptimizer);
                    AddParameter(command, "@ModifiedDate", DbType.DateTime, DateTime.Now);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateProject() ... UPDATE

        #region DeleteProject() ... DELETE
        /// <summary>
        /// Deletes (DELETE) a project from the data store by its identifier.
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
        #endregion      // DeleteProject() ... DELETE

        #endregion      // METHODS
    }
    #endregion      // public class ProjectRepo
}
#endregion      // namespace HenModel.RepoImplementations.Project

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
