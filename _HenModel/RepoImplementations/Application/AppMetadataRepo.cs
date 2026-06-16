#region HEADER
//#####################################################################################################################
//#########################################  A p p M e t a d a t a R e p o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  AppMetadataRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Application
//  CLASS(S):  AppMetadataRepo
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
    #region public class AppMetadataRepo
    /// <summary>
    /// AppMetadata Repo Class
    /// </summary>
    public class AppMetadataRepo : IAppMetadataRepo
    {
        #region PRIVATE FIELDS
        private readonly IDbConnectionFactory _connectionFactory;
        #endregion      // PRIVATE FIELDS

        #region PRIVATE METHODS

        #region MapMetadata()
        /// <summary>
        /// Maps a data record from the application settings query result set to a <see cref="AppSettingsDto"/> instance.
        /// </summary>
        /// <param name="record">The data record containing the global settings column values.</param>
        /// <param name="appMetadataIdOrdinal">The ordinal position of the <c>AppMetadataId</c> column.</param>
        /// <param name="appMetadataNameOrdinal">The ordinal position of the <c>AppMetadataName</c> column.</param>
        /// <param name="appMetadataValueOrdinal">The ordinal position of the <c>AppSettingValue</c> column.</param>
        /// <returns>A <see cref="AppMetadataDto"/> populated from the supplied data record.</returns>
        private static AppMetadataDto MapMetadata(IDataRecord record, 
                                                  int appMetadataIdOrdinal, 
                                                  int appMetadataNameOrdinal, 
                                                  int appMetadataValueOrdinal)
        {
            return new AppMetadataDto
            {
                AppMetadataId = record.GetInt32(appMetadataIdOrdinal),
                AppMetadataName = record.IsDBNull(appMetadataNameOrdinal) ? null : record.GetString(appMetadataNameOrdinal),
                AppMetadataValue = record.IsDBNull(appMetadataValueOrdinal) ? null : record.GetString(appMetadataValueOrdinal),
            };
        }
        #endregion  // MapMetadata()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public AppMetadataRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region GetAppMetadataList()
        /// <summary>
        /// Retrieves all application metadata as a list of AppMetadataDto objects.
        /// </summary>
        /// <remarks>The settings are returned in ascending order by their setting key. This method is
        /// typically used to access configuration values that apply across the entire application.</remarks>
        /// <returns>A list of <see cref="AppSettingsDto"/> objects representing the global settings. The list is empty if no
        /// settings are found.</returns>
        public List<AppMetadataDto> GetAppMetadataList()
        {
            const string sql = @"SELECT AppMetadataId,
                                        AppMetadataName,
                                        AppMetadataValue
                                 FROM dbo.AppMetadata
                                 ORDER BY AppMetadataId;";

            List<AppMetadataDto> metadata = new List<AppMetadataDto>();

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        int appMetadataIdOrdinal = reader.GetOrdinal("AppMetadataId");
                        int appMetadataNameOrdinal = reader.GetOrdinal("AppMetadataName");
                        int appMetadataValueOrdinal = reader.GetOrdinal("AppMetadataValue");

                        while (reader.Read())
                        {
                            metadata.Add(MapMetadata(reader,
                                                     appMetadataIdOrdinal,
                                                     appMetadataNameOrdinal,
                                                     appMetadataValueOrdinal));
                        }
                    }
                }
            }

            return metadata;
        }
        #endregion  // GetAppMetadataList()

        #endregion      // METHODS
    }
    #endregion      // public class AppMetadataRepo
}
#endregion      // namespace HenModel.RepoImplementations.Application

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
