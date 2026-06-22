#region HEADER
//#####################################################################################################################
//########################################  T H D i a g r a m V i e w M o d e l . c s  ################################
//#####################################################################################################################
//  FILENAME:  THDiagramViewModel.cs
//  NAMESPACE: HenViewModel.Pinch.Plots
//  CLASS(S):  THDiagramViewModel
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the THDiagram Profile DTO.
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
using HenGlobal;

using HenModel.Connection;
using HenModel.Dto.Pinch.Plots;
using HenModel.RepoImplementations.Pinch.Plots;
using HenModel.RepoImplementations.Profile.Streams;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenViewModel.Pinch.Plots
namespace HenViewModel.Pinch.Plots
{
    #region public class THDiagramViewModel
    /// <summary>
    /// THDiagram view model class.
    /// </summary>
    public class THDiagramViewModel : ViewModelBase
    {
        #region PROPERTIES
        public THDiagramRepo THDiagramRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region Parameterized CTOR
        /// <summary>
        /// Parameterized CTOR
        /// </summary>
        /// <param name="strProjectDatabaseName">Project Database Name</param>
        public THDiagramViewModel(string strProjectDatabaseName)
        {
            #region Get SQLiteConnectionFactory Object (connFactoryObj)
            //-----------------------------------------------------
            //--- Configure PROJECT database connection options ---
            //-----------------------------------------------------
            SQLiteConnectionOptions options = new SQLiteConnectionOptions
            {
                DbType = DatabaseType.PROJECT,
                DatabasePath = strProjectDatabaseName
            };

            //------------------------------------------------------------------
            //--- Create the SQLite connection factory using PROJECT options ---
            //------------------------------------------------------------------
            SQLiteConnectionFactory connFactoryObj = new SQLiteConnectionFactory(options);
            #endregion  // Get SQLiteConnectionFactory Object (connFactoryObj)

            THDiagramRepoObj = new THDiagramRepo(connFactoryObj);
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // Parameterized CTOR

        #region GetTHDiagrams()
        /// <summary>
        /// Retrieves a list of all T-H diagrams.
        /// </summary>
        /// <returns>A list of <see cref="THDiagramDto"/> objects representing the available T-H diagrams, or an empty list if none are found.</returns>
        public IList<THDiagramDto> GetTHDiagrams()
        {
            try
            {
                return THDiagramRepoObj.GetTHDiagrams();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving T-H diagram: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetTHDiagrams()

        #region GetTHDiagramsByProfileId(int profileId)
        /// <summary>
        /// Retrieves a list of all T-H diagrams associated with the specified profile identifier.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile whose T-H diagrams are to be retrieved.</param>
        /// <returns>A list of <see cref="THDiagramDto"/> objects representing the matching T-H diagrams, or an empty list if none are found.</returns>
        public IList<THDiagramDto> GetTHDiagramsByProfileId(int profileId)
        {
            try
            {
                return THDiagramRepoObj.GetTHDiagramsByProfileId(profileId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving T-H diagram: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetTHDiagramsByProfileId(int profileId)

        #region GetTHDiagramById(int thDiagramId)
        /// <summary>
        /// Retrieves the THDiagram DTO associated with the specified unique identifier.
        /// </summary>
        /// <param name="thDiagramId">The unique identifier of the T-H diagram to retrieve.</param>
        /// <returns>A <see cref="THDiagramDto"/> representing the T-H diagram with the specified identifier. Returns null if none is found.</returns>
        public THDiagramDto GetTHDiagramById(int thDiagramId)
        {
            try
            {
                return THDiagramRepoObj.GetTHDiagramById(thDiagramId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving T-H diagram: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetTHDiagramById(int thDiagramId)

        #region GetTHDiagramByTitle(int profileId, string title)
        /// <summary>
        /// Retrieves a T-H diagram by its profile identifier and title.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile that owns the T-H diagram.</param>
        /// <param name="title">The title of the T-H diagram to retrieve.</param>
        /// <returns>A <see cref="THDiagramDto"/> containing the T-H diagram details if found; otherwise, null.</returns>
        public THDiagramDto GetTHDiagramByTitle(int profileId, string title)
        {
            try
            {
                return THDiagramRepoObj.GetTHDiagramByTitle(profileId, title);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving T-H diagram: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetTHDiagramByTitle(Guid profileId, string title)

        #region AddTHDiagram(THDiagramDto thDiagramDto)
        /// <summary>
        /// Adds a new T-H diagram to the database using the specified DTO.
        /// </summary>
        /// <param name="thDiagramDto">The T-H diagram data to add.</param>
        /// <returns>A GUID representing the unique identifier of the newly added T-H diagram.</returns>
        public int AddTHDiagram(THDiagramDto thDiagramDto)
        {
            int thDiagramId = -1;
            try
            {
                thDiagramId = THDiagramRepoObj.AddTHDiagram(thDiagramDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving T-H diagram: {ex.Message}");
            }
            return thDiagramId;
        }
        #endregion  // AddTHDiagram(THDiagramDto thDiagramDto)

        #region UpdateTHDiagram(THDiagramDto thDiagramDto)
        /// <summary>
        /// Updates an existing T-H diagram in the database using the specified DTO.
        /// </summary>
        /// <param name="thDiagramDto">The T-H diagram DTO containing updated information.</param>
        public void UpdateTHDiagram(THDiagramDto thDiagramDto)
        {
            try
            {
                THDiagramRepoObj.UpdateTHDiagram(thDiagramDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving T-H diagram: {ex.Message}");
            }
        }
        #endregion  // UpdateTHDiagram(THDiagramDto thDiagramDto)

        #region DeleteTHDiagram(int thDiagramId)
        /// <summary>
        /// Deletes the T-H diagram with the specified unique identifier.
        /// </summary>
        /// <param name="thDiagramId">The unique identifier of the T-H diagram to delete.</param>
        public void DeleteTHDiagram(int thDiagramId)
        {
            try
            {
                THDiagramRepoObj.DeleteTHDiagram(thDiagramId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving T-H diagram: {ex.Message}");
            }
        }
        #endregion  // DeleteTHDiagram(int thDiagramId)
    }
    #endregion      // public class THDiagramViewModel
}
#endregion      // namespace HenViewModel.Pinch.Plots

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
