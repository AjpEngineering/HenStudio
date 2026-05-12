#region HEADER
//#####################################################################################################################
//################################  T o t a l A n n u a l i z e d C o s t R e p o . c s  ##############################
//#####################################################################################################################
//  FILENAME:  TotalAnnualizedCostRepo.cs
//  NAMESPACE: HenModel.RepoImplementations.Project.CostParameters
//  CLASS(S):  TotalAnnualizedCostRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation for the Total Annualized Cost Parameters Object.
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

using HenModel.RepoInterfaces.Project.CostParameters;
using HenModel.Dto.Project.CostParameters;

using System;
using System.Collections.Generic;
using System.Data;
#endregion      // REFERENCES

#region namespace HenModel.RepoImplementations.Project.CostParameters
namespace HenModel.RepoImplementations.Project.CostParameters
{
    #region public class TotalAnnualizedCostRepo
    /// <summary>
    /// Total Annualized Cost Repo Class
    /// </summary>
    public class TotalAnnualizedCostRepo : ITotalAnnualizedCostRepo
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

        #region MapTotalAnnualizedCost()
        /// <summary>
        /// Maps a data record from the Total Annualized Cost query result set to an <see cref="TotalAnnualizedCostDto  "/> instance.
        /// </summary>
        /// <param name="record">The data record containing the total annualized cost column values.</param>
        /// <returns>An <see cref="TotalAnnualizedCostDto"/> populated from the supplied data record.</returns>
        private static TotalAnnualizedCostDto MapTotalAnnualizedCost(IDataRecord record)
        {
            return new TotalAnnualizedCostDto
            {
                Id = record.GetGuid(record.GetOrdinal("Id")),
                ProjectId = record.GetGuid(record.GetOrdinal("ProjectId")),
                TAC_InterestRate = record.GetDouble(record.GetOrdinal("TAC_InterestRate")),
                TAC_LifeYears= record.GetDouble(record.GetOrdinal("TAC_LifeYears")),
                TAC_MaintenanceFraction = record.GetDouble(record.GetOrdinal("TAC_MaintenanceFraction")),
                TAC_OperatingHours = record.GetDouble(record.GetOrdinal("TAC_OperatingHours")),
            };
        }
        #endregion      // MapTotalAnnualizedCost()

        #endregion      // PRIVATE METHODS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="connectionFactory">Database connection factory.</param>
        public TotalAnnualizedCostRepo(IDbConnectionFactory connectionFactory)
        {
            if (connectionFactory == null)
            {
                throw new ArgumentNullException(nameof(connectionFactory));
            }

            _connectionFactory = connectionFactory;
        }
        #endregion      // CTOR

        #region METHODS

        #region AddTotalAnnualizedCost() ... CREATE
        /// <summary>
        /// Adds (CREATE) a new total annualized cost (TAC) entry to the data store.
        /// </summary>
        /// <param name="totalAnnualizedCostDto">The total annualized cost data to insert.</param>
        /// <returns>The unique identifier of the inserted total annualized cost entry.</returns>
        public Guid AddTotalAnnualizedCost(TotalAnnualizedCostDto totalAnnualizedCostDto)
        {
            if (totalAnnualizedCostDto == null)
            {
                throw new ArgumentNullException(nameof(totalAnnualizedCostDto));
            }

            const string sql = @"INSERT INTO dbo.TotalAnnualizedCost
                                    (ProjectId,
                                     TAC_InterestRate,
                                     TAC_LifeYears,
                                     TAC_MaintenanceFraction,
                                     TAC_OperatingHours)
                                 OUTPUT INSERTED.Id
                                 VALUES
                                    (@ProjectId,
                                     @TAC_InterestRate,
                                     @TAC_LifeYears,
                                     @TAC_MaintenanceFraction,
                                     @TAC_OperatingHours);";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProjectId", DbType.Guid, totalAnnualizedCostDto.ProjectId);
                    AddParameter(command, "@TAC_InterestRate", DbType.Double, totalAnnualizedCostDto.TAC_InterestRate);
                    AddParameter(command, "@TAC_LifeYears", DbType.Double, totalAnnualizedCostDto.TAC_LifeYears);
                    AddParameter(command, "@TAC_MaintenanceFraction", DbType.Double, totalAnnualizedCostDto.TAC_MaintenanceFraction);
                    AddParameter(command, "@TAC_OperatingHours", DbType.Double, totalAnnualizedCostDto.TAC_OperatingHours);

                    connection.Open();

                    return (Guid)command.ExecuteScalar();
                }
            }
        }
        #endregion      // AddTotalAnnualizedCost() ... CREATE

        #region GetTotalAnnualizedCost() ... READ
        /// <summary>
        /// Retrieves (READ) all total annualized cost (TAC) entries from the data store.
        /// </summary>
        /// <returns>A list of <see cref="TotalAnnualizedCostDto"/> objects representing all total annualized cost entries. 
        /// The list is empty if no total annualized cost entries are found.</returns>
        public IList<TotalAnnualizedCostDto> GetTotalAnnualizedCost()
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        TAC_InterestRate,
                                        TAC_LifeYears,
                                        TAC_MaintenanceFraction,
                                        TAC_OperatingHours
                                 FROM dbo.TotalAnnualizedCost
                                 ORDER BY ProjectId;";

            List<TotalAnnualizedCostDto> totalAnnualizedCostList = new List<TotalAnnualizedCostDto>();

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
                            totalAnnualizedCostList.Add(MapTotalAnnualizedCost(reader));
                        }
                    }
                }
            }

            return totalAnnualizedCostList;
        }
        #endregion      // GetTotalAnnualizedCost() ... READ

        #region GetTotalAnnualizedCostById() ... READ
        /// <summary>
        /// Retrieves (READ) a total annualized cost entry from the data store by its identifier.
        /// </summary>
        /// <param name="totalAnnualizedCostId">The unique identifier of the total annualized cost entry to retrieve.</param>
        /// <returns>An <see cref="TotalAnnualizedCostDto"/> object representing the requested total annualized cost entry, 
        /// or <c>null</c> if no matching entry is found.</returns>
        public TotalAnnualizedCostDto GetTotalAnnualizedCostById(Guid totalAnnualizedCostId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        TAC_InterestRate,
                                        TAC_LifeYears,
                                        TAC_MaintenanceFraction,
                                        TAC_OperatingHours
                                 FROM dbo.TotalAnnualizedCost
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, totalAnnualizedCostId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapTotalAnnualizedCost(reader);
                    }
                }
            }
        }
        #endregion      // GetTotalAnnualizedCostById() ... READ

        #region GetTotalAnnualizedCostByProjectId() ... READ
        /// <summary>
        /// Retrieves (READ) a total annualized cost entry from the data store by its identifier.
        /// </summary>
        /// <param name="totalAnnualizedCostId">The unique identifier of the total annualized cost entry to retrieve.</param>
        /// <returns>An <see cref="TotalAnnualizedCostDto"/> object representing the requested total annualized cost entry, 
        /// or <c>null</c> if no matching entry is found.</returns>
        public TotalAnnualizedCostDto GetTotalAnnualizedCostByProjectId(Guid projectId)
        {
            const string sql = @"SELECT Id,
                                        ProjectId,
                                        TAC_InterestRate,
                                        TAC_LifeYears,
                                        TAC_MaintenanceFraction,
                                        TAC_OperatingHours
                                 FROM dbo.TotalAnnualizedCost
                                 WHERE ProjectId = @ProjectId;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@ProjecId", DbType.Guid, projectId);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return MapTotalAnnualizedCost(reader);
                    }
                }
            }
        }
        #endregion      // GetTotalAnnualizedCostByProjectId() ... READ

        #region UpdateTotalAnnualizedCost() ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing cost metadata entry in the data store.
        /// </summary>
        /// <param name="costMetadataDto">The cost metadata data to update.</param>
        public void UpdateTotalAnnualizedCost(TotalAnnualizedCostDto totalAnnualizedCostDto)
        {
            if (totalAnnualizedCostDto == null)
            {
                throw new ArgumentNullException(nameof(totalAnnualizedCostDto));
            }

            const string sql = @"UPDATE dbo.TotalAnnualizedCost
                                 SET TAC_InterestRate = @TAC_InterestRate,
                                     TAC_LifeYears = @TAC_LifeYears,
                                     TAC_MaintenanceFraction = @TAC_MaintenanceFraction,
                                     TAC_OperatingHours = @TAC_OperatingHours
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, totalAnnualizedCostDto.Id);
                    AddParameter(command, "@TAC_InterestRate", DbType.Double, totalAnnualizedCostDto.TAC_InterestRate);
                    AddParameter(command, "@TAC_LifeYears", DbType.Double, totalAnnualizedCostDto.TAC_LifeYears);
                    AddParameter(command, "@TAC_MaintenanceFraction", DbType.Double, totalAnnualizedCostDto.TAC_MaintenanceFraction);
                    AddParameter(command, "@TAC_OperatingHours", DbType.Double, totalAnnualizedCostDto.TAC_OperatingHours);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // UpdateTotalAnnualizedCost() ... UPDATE

        #region DeleteTotalAnnualizedCost() ... DELETE
        /// <summary>
        /// Deletes (DELETE) a total annualized cost (TAC) entry from the data store by its identifier.
        /// </summary>
        /// <param name="totalAnnualizedCostId">The unique identifier of the total annualized cost (TAC) entry to delete.</param>
        public void DeleteTotalAnnualizedCost(Guid totalAnnualizedCostId)
        {
            const string sql = @"DELETE FROM dbo.TotalAnnualizedCost
                                 WHERE Id = @Id;";

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    AddParameter(command, "@Id", DbType.Guid, totalAnnualizedCostId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion      // DeleteTotalAnnualizedCost() ... DELETE

        #endregion      // METHODS
    }
    #endregion      // public class TotalAnnualizedCostRepo
}
#endregion      // namespace HenModel.RepoImplementations.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
