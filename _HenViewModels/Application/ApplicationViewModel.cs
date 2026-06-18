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
        public AppComponentsRepo AppComponentsRepoObj { get; set; }
        public AppMetadataRepo AppMetadataRepoObj { get; set; }
        public AppSettingsRepo AppSettingsRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Initializes a new instance of the ApplicationViewModel class
        /// and sets up APPLICATION repository dependencies.
        /// </summary>
        /// <remarks>
        /// This constructor configures the APPLICATION SQLite database connection
        /// using SQLiteConnectionOptions and initializes all APPLICATION-level repositories.
        /// </remarks>
        public ApplicationViewModel()
        {
            //-----------------------------------------------------------------------------------------
            // Configure APPLICATION database connection options
            //-----------------------------------------------------------------------------------------
            SQLiteConnectionOptions options = new SQLiteConnectionOptions
            {
                DbType = DatabaseType.APPLICATION,
                DatabasePath = "HenStudio.db"
            };

            //-----------------------------------------------------------------------------------------
            // Create the SQLite connection factory using APPLICATION options
            //-----------------------------------------------------------------------------------------
            SQLiteConnectionFactory connFactoryObj = new SQLiteConnectionFactory(options);

            //-----------------------------------------------------------------------------------------
            // Initialize APPLICATION-level repositories
            //-----------------------------------------------------------------------------------------
            AppComponentsRepoObj = new AppComponentsRepo(connFactoryObj);
            AppMetadataRepoObj = new AppMetadataRepo(connFactoryObj);
            AppSettingsRepoObj = new AppSettingsRepo(connFactoryObj);
        }
        #endregion // CTOR

        #region GetAppComponentsList()
        /// <summary>
        /// Gets APPLICATION (HenStudio SQLite database connection data as a 
        /// strongly-typed <see cref="AppConnectionDataRepo"/> object.
        /// </summary>
        /// <returns>Populated <see cref="AppConnectionDataDto"/> object.</returns>
        /// <exception cref="InvalidOperationException">Unrecognized connection data key encountered while mapping connection data.</exception>
        public List<AppComponentsDto> GetAppComponentsList()
        {
            try
            {
                //-------------------------------------------------------------------------------------------
                //--- No Conversion needed as the DTO is already in the desired format for the view model ---
                //-------------------------------------------------------------------------------------------
                return AppComponentsRepoObj.GetAppComponentsList();
            }
            catch (Exception ex)
            {
                //--- Handle exceptions (e.g., log the error, rethrow, or return null) ---
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetAppComponentsList()

        #region GetAppMetadataList()
        /// <summary>
        /// Retrieves a list of all Application Metadata.
        /// </summary>
        /// <returns>A list of <see cref="AppMetadataDto"/> objects, or an empty list.</returns>
        public List<AppMetadataDto> GetAppMetadataList()
        {
            try
            {
                //-------------------------------------------------------------------------------------------
                //--- No Conversion needed as the DTO is already in the desired format for the view model ---
                //-------------------------------------------------------------------------------------------
                return AppMetadataRepoObj.GetAppMetadataList();
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error, rethrow, or return null)
                Console.WriteLine($"Error retrieving profile: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetAppMetadataList()

        #region GetAppSettingsList()
        /// <summary>
        /// Retrieves a list of all Application Factory Settings Name-Value pairs.
        /// </summary>
        /// <returns>A list of <see cref="AppSettingsDto"/> objects representing the available Global Settings, 
        /// or an empty list if no Global Settings found.</returns>
        public List<AppSettingsDto> GetAppSettingsList()
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
        #endregion  // GetAppSettingsList()

    }
    #endregion      // public class ApplicationViewModel
}
#endregion      // namespace HenViewModel.Application

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
