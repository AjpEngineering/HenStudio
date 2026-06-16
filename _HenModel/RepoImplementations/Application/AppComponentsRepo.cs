#region HEADER
//#####################################################################################################################
//#######################################  A p p C o m p o n e n t s R e p o . c s  ###################################
//#####################################################################################################################
//  FILENAME:  AppComponentsRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Application
//  CLASS(S):  AppComponentsRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation for the AppMetadataRepo.
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

using HenModel.Dto.Application;
using HenModel.RepoInterfaces.Application;

using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Claims;
using System.Xml.Linq;
#endregion      // REFERENCES

#region namespace HenModel.RepoImplementations.Application
namespace HenModel.RepoImplementations.Application
{
    #region public class AppComponentsRepo
    /// <summary>
    /// GlobalSettings Repo Class
    /// </summary>
    public class AppComponentsRepo : IAppComponentsRepo
    {
        #region PRIVATE FIELDS
        private readonly IDbConnectionFactory _connectionFactory;
        #endregion      // PRIVATE FIELDS

        #region PRIVATE METHODS

        #region MapAppComponents()
        /// <summary>
        /// Maps a data record from the application settings query result set to a <see cref="AppSettingsDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the global settings column values.</param>
        /// <param name="appMetadataIdOrdinal">The ordinal position of the <c>AppMetadataId</c> column.</param>
        /// <param name="appMetadataNameOrdinal">The ordinal position of the <c>AppMetadataName</c> column.</param>
        /// <param name="appMetadataValueOrdinal">The ordinal position of the <c>AppSettingValue</c> column.</param>
        /// <returns>A <see cref="AppComponentsDto"/> populated from the supplied data record.</returns>
        private static AppComponentsDto MapAppComponents(IDataRecord record, 
                                                         int componentIdOrdinal, 
                                                         int componentNameOrdinal, 
                                                         int componentTypeOrdinal)
        {
            return new AppComponentsDto
            {
                ComponentId = record.GetInt32(componentIdOrdinal),
                ComponentName = record.IsDBNull(componentNameOrdinal) ? null : record.GetString(componentNameOrdinal),
                ComponentType = record.IsDBNull(componentTypeOrdinal) ? null : record.GetString(componentTypeOrdinal),
            };
        }
        #endregion  // MapAppComponents()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public AppComponentsRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region GetAppComponentsList()
        /// <summary>
        /// Retrieves all application components as a list of AppComponentsDto objects.
        /// </summary>
        /// <remarks>The settings are returned in ascending order by their setting key. This method is
        /// typically used to access configuration values that apply across the entire application.</remarks>
        /// <returns>A list of <see cref="AppComponentsDto"/> objects. The list is empty if no
        /// settings are found.</returns>
        public List<AppComponentsDto> GetAppComponentsList()
        {
            const string sql = @"SELECT ComponentId,
                                        ComponentName,
                                        ComponentType
                                 FROM dbo.AppComponents
                                 ORDER BY ComponentId;";

            List<AppComponentsDto> components = new List<AppComponentsDto>();

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        int componentIdOrdinal = reader.GetOrdinal("ComponentId");
                        int componentNameOrdinal = reader.GetOrdinal("ComponentName");
                        int componentTypeOrdinal = reader.GetOrdinal("ComponentType");

                        while (reader.Read())
                        {
                            components.Add(MapAppComponents(reader,
                                                            componentIdOrdinal,
                                                            componentNameOrdinal,
                                                            componentTypeOrdinal));
                        }
                    }
                }
            }

            return components;
        }
        #endregion  // GetAppComponentsList()

        #endregion      // METHODS
    }
    #endregion      // public class AppComponentsRepo
}
#endregion      // namespace HenModel.RepoImplementations.Application

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
