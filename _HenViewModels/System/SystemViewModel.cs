#region HEADER
//#####################################################################################################################
//########################################  S y s t e m V i e w M o d e l . c s  ######################################
//#####################################################################################################################
//  FILENAME:  SystemViewModel.cs
//  NAMESPACE: HenViewModel.System
//  CLASS(S):  SystemViewModel
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the system DTO objects.
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
using HenModel.Dto.System;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenViewModel.System
namespace HenViewModel.System
{
    #region public class SystemViewModel
    /// <summary>
    /// System view model class.
    /// </summary>
    public class SystemViewModel : ViewModelBase
    {
        #region PROPERTIES
        public GlobalSettingsRepo GlobalSettingsRepoObj { get; set; }
        public DatabaseTableRepo DatabaseTableRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Initializes a new instance of the SystemViewModel class and sets up repository dependencies required for
        /// system operations.
        /// </summary>
        /// <remarks>This constructor creates and configures repository objects using the default
        /// connection string for the Hen Studio database. The repositories are initialized and ready for use after
        /// construction.</remarks>
        public SystemViewModel() 
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var ProjectRepoObj = new ProjectRepo(connFactoryObj);

            GlobalSettingsRepoObj = new GlobalSettingsRepo(connFactoryObj);
            DatabaseTableRepoObj = new DatabaseTableRepo(connFactoryObj);
        }
        #endregion  // CTOR

        #region GetAppGlobalSettings()
        /// <summary>
        /// Gets application global settings as a strongly-typed <see cref="AppGlobalSettingsDto"/> object 
        /// by retrieving all global settings from the data store and mapping them to the corresponding 
        /// properties on the DTO based on their setting keys.
        /// </summary>
        /// <returns>Populated <see cref="AppGlobalSettingsDto"/> object.</returns>
        /// <exception cref="InvalidOperationException">Unrecognized global setting key encountered while mapping application global settings.</exception>
        public AppGlobalSettingsDto GetAppGlobalSettings()
        {
            try
            {
                //-------------------------------------------------------------------------------------------
                //--- No Conversion needed as the DTO is already in the desired format for the view model ---
                //-------------------------------------------------------------------------------------------
                return GlobalSettingsRepoObj.GetAppGlobalSettings();
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetAppGlobalSettings()

        #region GetGlobalSettings()
        /// <summary>
        /// Retrieves a list of all Global Settings Name-Value pairs.
        /// </summary>
        /// <returns>A list of <see cref="GlobalSettingsDto"/> objects representing the available Global Settings, 
        /// or an empty list if no Global Settings found.</returns>
        public IList<GlobalSettingsDto> GetGlobalSettings()
        {
            try
            {
                //-------------------------------------------------------------------------------------------
                //--- No Conversion needed as the DTO is already in the desired format for the view model ---
                //-------------------------------------------------------------------------------------------
                return GlobalSettingsRepoObj.GetGlobalSettings();
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetGlobalSettings()

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
    #endregion      // public class SystemViewModel
}
#endregion      // namespace HenViewModel.System

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
