#region HEADER
//#####################################################################################################################
//################################### A p p l i c a t i o n V i e w M o d e l . c s  ##################################
//#####################################################################################################################
//  FILENAME:  ApplicationViewModel.cs
//  NAMESPACE: HenViewModel.System
//  CLASS(S):  ApplicationViewModel
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the Application Database DTO objects.
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
using HenModel.Dto.Application;
using HenModel.Dto.Project;
using HenModel.RepoImplementations.Application;
using HenModel.RepoImplementations.Project;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenViewModel.Application
namespace HenViewModel.Application
{
    #region public class ApplicationViewModel
    /// <summary>
    /// System view model class.
    /// </summary>
    public class ApplicationViewModel : ViewModelBase
    {
        #region PROPERTIES
        public ConnectionDataRepo ConnectionDataRepoObj { get; set; }
        public AppSettingsRepo AppSettingsRepoObj { get; set; }
        public DatabaseTableRepo DatabaseTableRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Initializes a new instance of the ApplicationViewModel class 
        /// and sets up APPLICATION repository dependencies.
        /// </summary>
        /// <remarks>This constructor creates and configures repository objects using the default
        /// connection string for the Hen Studio database. The repositories are initialized and ready for use after
        /// construction.</remarks>
        public ApplicationViewModel() 
        {
            SQLiteConnectionFactory connFactoryObj = 
                new SQLiteConnectionFactory(ConnectionString.GetSqliteAppConnectionString() );

            ConnectionDataRepoObj = new ConnectionDataRepo(connFactoryObj);
            AppSettingsRepoObj = new AppSettingsRepo(connFactoryObj);
            DatabaseTableRepoObj = new DatabaseTableRepo(connFactoryObj);
        }
        #endregion  // CTOR

        #region GetDatabaseConnectionData()
        /// <summary>
        /// Gets database connection data as a strongly-typed <see cref="ConnectionDataRepo"/> object 
        /// by retrieving all connection data from the data store and mapping them to the corresponding 
        /// properties on the DTO based on their setting keys.
        /// </summary>
        /// <returns>Populated <see cref="ConnectionDataDto"/> object.</returns>
        /// <exception cref="InvalidOperationException">Unrecognized connection data key encountered while mapping connection data.</exception>
        public ConnectionDataDto GetDatabaseConnectionData()
        {
            try
            {
                //-------------------------------------------------------------------------------------------
                //--- No Conversion needed as the DTO is already in the desired format for the view model ---
                //-------------------------------------------------------------------------------------------
                return ConnectionDataRepoObj.GetConnectionData();
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetDatabaseConnectionData()

        #region GetFactorySettingsList()
        /// <summary>
        /// Retrieves a list of all Application Factory Settings Name-Value pairs.
        /// </summary>
        /// <returns>A list of <see cref="AppSettingsDto"/> objects representing the available Global Settings, 
        /// or an empty list if no Global Settings found.</returns>
        public List<AppSettingsDto> GetFactorySettingsList()
        {
            try
            {
                //-------------------------------------------------------------------------------------------
                //--- No Conversion needed as the DTO is already in the desired format for the view model ---
                //-------------------------------------------------------------------------------------------
                return AppSettingsRepoObj.GetAppSettingsList();
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetFactorySettingsList()

        #region GetDatabaseTables()
        /// <summary>
        /// Retrieves a list of all Database Tables.
        /// </summary>
        /// <returns>A list of <see cref="DatabaseTableDto"/> objects representing the available Database Tables, 
        /// or an empty list if no Global Settings found.</returns>
        public IList<DatabaseTableDto> GetDatabaseTables()
        {
            try
            {
                //-------------------------------------------------------------------------------------------
                //--- No Conversion needed as the DTO is already in the desired format for the view model ---
                //-------------------------------------------------------------------------------------------
                return DatabaseTableRepoObj.GetDatabaseTables();
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetDatabaseTables()

    }
    #endregion      // public class ApplicationViewModel
}
#endregion      // namespace HenViewModel.Application

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
