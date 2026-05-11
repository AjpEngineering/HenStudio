#region HEADER
//#####################################################################################################################
//############################################  P r o f i l e R e p o . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  ProfileRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Profile
//  CLASS(S):  ProfileRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the Profile top-level table.
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

using HenModel.RepoInterfaces.Profile;
using HenModel.Dto.Profile;

using System;
using System.Collections.Generic;
using System.Data;
#endregion      // REFERENCES

#region namespace HenModel.RepoImplementations.Profile
namespace HenModel.RepoImplementations.Profile
{
    #region public class ProfileRepo
    /// <summary>
    /// Profile Repo Class
    /// </summary>
    public class ProfileRepo : IProfileRepo
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

        #region MapProfile()
        /// <summary>
        /// Maps a data record from the profile query result set to a <see cref="ProfileDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the profile column values.</param>
        /// <param name="idOrdinal">The ordinal position of the <c>Id</c> column.</param>
        /// <param name="projectIdOrdinal">The ordinal position of the <c>ProjectId</c> column.</param>
        /// <param name="nameOrdinal">The ordinal position of the <c>Name</c> column.</param>
        /// <param name="descriptionOrdinal">The ordinal position of the <c>Description</c> column.</param>
        /// <returns>A <see cref="ProfileDto"/> populated from the supplied data record.</returns>
        private static ProfileDto MapProfile( IDataRecord record,
                                              int idOrdinal,
                                              int projectIdOrdinal,
                                              int nameOrdinal,
                                              int descriptionOrdinal )
        {
            return new ProfileDto
            {
                Id = record.GetGuid(idOrdinal),
                ProjectId = record.GetGuid(projectIdOrdinal),
                Name = record.IsDBNull(nameOrdinal) ? null : record.GetString(nameOrdinal),
                Description = record.IsDBNull(descriptionOrdinal) ? null : record.GetString(descriptionOrdinal)
            };
        }
        #endregion      // MapProfile()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public ProfileRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region AddProfile()
        /// <summary>
        /// Adds a new profile to the data store.
        /// </summary>
        /// <param name="profileDto">The profile data to insert.</param>
        /// <returns>The unique identifier of the inserted profile.</returns>
        public Guid AddProfile(ProfileDto profileDto)
        {
            if (profileDto == null)
            {
                throw new ArgumentNullException(nameof(profileDto));
            }

            const string sql = @"INSERT INTO dbo.Profile
                                    (ProjectId,
                                     Name,
                                     Description)
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@ProjectId,
                                     @Name,
                                     @Description);";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProjectId", DbType.Guid, profileDto.ProjectId);
                    AddParameter(command, "@Name", DbType.String, profileDto.Name);
                    AddParameter(command, "@Description", DbType.String, profileDto.Description);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddProfile()

        #region GetProfiles()
        /// <summary>
        /// Retrieves all profiles from the data store.
        /// </summary>
        /// <returns>A list of <see cref="ProfileDto"/> objects representing all profiles. 
        /// The list is empty if no profiles are found.</returns>
        public IList<ProfileDto> GetProfiles()
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        Name,
                                        Description
                                 FROM dbo.Profile
                                 ORDER BY Name;";

            List<ProfileDto> profiles = new List<ProfileDto>();

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
                        int projectIdOrdinal = reader.GetOrdinal("ProjectId");
                        int nameOrdinal = reader.GetOrdinal("Name");
                        int descriptionOrdinal = reader.GetOrdinal("Description");

                        while (reader.Read())
                        {
                            profiles.Add(MapProfile(
                                reader,
                                idOrdinal,
                                projectIdOrdinal,
                                nameOrdinal,
                                descriptionOrdinal));
                        }
                    }
                }
            }
            return profiles;
        }
        #endregion      // GetProfiles()

        #region GetProfilesByProjectId()
        /// <summary>
        /// Retrieves all profiles for the specified project from the data store.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project whose profiles are to be retrieved.</param>
        /// <returns>A list of <see cref="ProfileDto"/> objects representing the matching profiles. 
        /// The list is empty if no profiles are found.</returns>
        public IList<ProfileDto> GetProfilesByProjectId(Guid projectId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        Name,
                                        Description
                                 FROM dbo.Profile
                                 WHERE ProjectId = @ProjectId
                                 ORDER BY Name;";

            List<ProfileDto> profiles = new List<ProfileDto>();

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProjectId", DbType.Guid, projectId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        int idOrdinal = reader.GetOrdinal("Id");
                        int projectIdOrdinal = reader.GetOrdinal("ProjectId");
                        int nameOrdinal = reader.GetOrdinal("Name");
                        int descriptionOrdinal = reader.GetOrdinal("Description");

                        while (reader.Read())
                        {
                            profiles.Add(MapProfile(
                                reader,
                                idOrdinal,
                                projectIdOrdinal,
                                nameOrdinal,
                                descriptionOrdinal));
                        }
                    }
                }
            }
            return profiles;
        }
        #endregion      // GetProfilesByProjectId()

        #region GetProfileById()
        /// <summary>
        /// Retrieves a profile from the data store by its identifier.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile to retrieve.</param>
        /// <returns>A <see cref="ProfileDto"/> object representing the requested profile, 
        /// or <c>null</c> if no matching profile is found.</returns>
        public ProfileDto GetProfileById(Guid profileId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        Name,
                                        Description
                                 FROM dbo.Profile
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, profileId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapProfile(
                            reader,
                            reader.GetOrdinal("Id"),
                            reader.GetOrdinal("ProjectId"),
                            reader.GetOrdinal("Name"),
                            reader.GetOrdinal("Description"));
                    }
                }
            }
        }
        #endregion      // GetProfileById()

        #region GetProfileByName()
        /// <summary>
        /// Retrieves a profile from the data store by its project identifier and name.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project that owns the profile.</param>
        /// <param name="profileName">The profile name to retrieve.</param>
        /// <returns>A <see cref="ProfileDto"/> object representing the requested profile, 
        /// or <c>null</c> if no matching profile is found.</returns>
        public ProfileDto GetProfileByName(Guid projectId, string profileName)
        {
            if (String.IsNullOrWhiteSpace(profileName))
            {
                throw new ArgumentException("Profile name cannot be null or whitespace.", nameof(profileName));
            }

            const string sql = @"SELECT Id,
                                        ProjectId,
                                        Name,
                                        Description
                                 FROM dbo.Profile
                                 WHERE ProjectId = @ProjectId
                                   AND Name = @Name;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProjectId", DbType.Guid, projectId);
                    AddParameter(command, "@Name", DbType.String, profileName);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapProfile(
                            reader,
                            reader.GetOrdinal("Id"),
                            reader.GetOrdinal("ProjectId"),
                            reader.GetOrdinal("Name"),
                            reader.GetOrdinal("Description"));
                    }
                }
            }
        }
        #endregion      // GetProfileByName()

        #region UpdateProfile()
        /// <summary>
        /// Updates an existing profile in the data store.
        /// </summary>
        /// <param name="profileDto">The profile data to update.</param>
        public void UpdateProfile(ProfileDto profileDto)
        {
            if (profileDto == null)
            {
                throw new ArgumentNullException(nameof(profileDto));
            }

            const string sql = @"UPDATE dbo.Profile
                                 SET ProjectId = @ProjectId,
                                     Name = @Name,
                                     Description = @Description
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, profileDto.Id);
                    AddParameter(command, "@ProjectId", DbType.Guid, profileDto.ProjectId);
                    AddParameter(command, "@Name", DbType.String, profileDto.Name);
                    AddParameter(command, "@Description", DbType.String, profileDto.Description);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateProfile()

        #region DeleteProfile()
        /// <summary>
        /// Deletes a profile from the data store by its identifier.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile to delete.</param>
        public void DeleteProfile(Guid profileId)
        {
            const string sql = @"DELETE FROM dbo.Profile
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, profileId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // DeleteProfile()

        #endregion      // METHODS
    }
    #endregion      // public class ProfileRepo
}
#endregion      // namespace HenModel.RepoImplementations.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
