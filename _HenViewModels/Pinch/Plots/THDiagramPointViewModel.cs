#region HEADER
//#####################################################################################################################
//####################################  T H D i a g r a m P o i n t V i e w M o d e l . c s  ##########################
//#####################################################################################################################
//  FILENAME:  THDiagramPointViewModel.cs
//  NAMESPACE: HenViewModel.Pinch.Plots
//  CLASS(S):  THDiagramPointViewModel
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the THDiagramPoint Profile DTO.
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
using HenModel.RepoImplementations.Pinch.Plots;

using HenModel.Dto.Pinch.Plots;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenViewModel.Pinch.Plots
namespace HenViewModel.Pinch.Plots
{
    #region public class THDiagramPointViewModel
    /// <summary>
    /// THDiagramPoint view model class.
    /// </summary>
    public class THDiagramPointViewModel : ViewModelBase
    {
        #region PROPERTIES
        public THDiagramPointRepo THDiagramPointRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region Parameterized CTOR
        /// <summary>
        /// Parameterized CTOR
        /// </summary>
        /// <param name="strProjectDatabaseName">Project Database Name</param>
        public THDiagramPointViewModel(string strProjectDatabaseName)
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

            THDiagramPointRepoObj = new THDiagramPointRepo(connFactoryObj);
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // Parameterized CTOR

        #region GetTHDiagramPoints()
        /// <summary>
        /// Retrieves a list of all T-H diagram points.
        /// </summary>
        /// <returns>A list of <see cref="THDiagramPointDto"/> objects representing the available T-H diagram points, or an empty list if none are found.</returns>
        public IList<THDiagramPointDto> GetTHDiagramPoints()
        {
            try
            {
                return THDiagramPointRepoObj.GetTHDiagramPoints();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving T-H diagram point: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetTHDiagramPoints()

        #region GetTHDiagramPointsByTHDiagramId(int thDiagramId)
        /// <summary>
        /// Retrieves a list of all T-H diagram points associated with the specified T-H diagram identifier.
        /// </summary>
        /// <param name="thDiagramId">The unique identifier of the T-H diagram whose points are to be retrieved.</param>
        /// <returns>A list of <see cref="THDiagramPointDto"/> objects representing the matching T-H diagram points, or an empty list if none are found.</returns>
        public IList<THDiagramPointDto> GetTHDiagramPointsByTHDiagramId(int thDiagramId)
        {
            try
            {
                return THDiagramPointRepoObj.GetTHDiagramPointsByTHDiagramId(thDiagramId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving T-H diagram point: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetTHDiagramPointsByTHDiagramId(int thDiagramId)

        #region GetTHDiagramPointById(int thDiagramPointId)
        /// <summary>
        /// Retrieves the THDiagramPoint DTO associated with the specified unique identifier.
        /// </summary>
        /// <param name="thDiagramPointId">The unique identifier of the T-H diagram point to retrieve.</param>
        /// <returns>A <see cref="THDiagramPointDto"/> representing the T-H diagram point with the specified identifier. Returns null if none is found.</returns>
        public THDiagramPointDto GetTHDiagramPointById(int thDiagramPointId)
        {
            try
            {
                return THDiagramPointRepoObj.GetTHDiagramPointById(thDiagramPointId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving T-H diagram point: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetTHDiagramPointById(int thDiagramPointId)

        #region GetTHDiagramPointByPointSequence(int thDiagramId, int pointSequence)
        /// <summary>
        /// Retrieves a T-H diagram point by its T-H diagram identifier and point sequence.
        /// </summary>
        /// <param name="thDiagramId">The unique identifier of the T-H diagram that owns the point.</param>
        /// <param name="pointSequence">The point sequence to retrieve.</param>
        /// <returns>A <see cref="THDiagramPointDto"/> containing the T-H diagram point details if found; otherwise, null.</returns>
        public THDiagramPointDto GetTHDiagramPointByPointSequence(int thDiagramId, int pointSequence)
        {
            try
            {
                return THDiagramPointRepoObj.GetTHDiagramPointByPointSequence(thDiagramId, pointSequence);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving T-H diagram point: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetTHDiagramPointByPointSequence(int thDiagramId, int pointSequence)

        #region AddTHDiagramPoint(THDiagramPointDto thDiagramPointDto)
        /// <summary>
        /// Adds a new T-H diagram point to the database using the specified DTO.
        /// </summary>
        /// <param name="thDiagramPointDto">The T-H diagram point data to add.</param>
        /// <returns>A GUID representing the unique identifier of the newly added T-H diagram point.</returns>
        public int AddTHDiagramPoint(THDiagramPointDto thDiagramPointDto)
        {
            int thDiagramPointId = -1;
            try
            {
                thDiagramPointId = THDiagramPointRepoObj.AddTHDiagramPoint(thDiagramPointDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving T-H diagram point: {ex.Message}");
            }
            return thDiagramPointId;
        }
        #endregion  // AddTHDiagramPoint(THDiagramPointDto thDiagramPointDto)

        #region UpdateTHDiagramPoint(THDiagramPointDto thDiagramPointDto)
        /// <summary>
        /// Updates an existing T-H diagram point in the database using the specified DTO.
        /// </summary>
        /// <param name="thDiagramPointDto">The T-H diagram point DTO containing updated information.</param>
        public void UpdateTHDiagramPoint(THDiagramPointDto thDiagramPointDto)
        {
            try
            {
                THDiagramPointRepoObj.UpdateTHDiagramPoint(thDiagramPointDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving T-H diagram point: {ex.Message}");
            }
        }
        #endregion  // UpdateTHDiagramPoint(THDiagramPointDto thDiagramPointDto)

        #region DeleteTHDiagramPoint(int thDiagramPointId)
        /// <summary>
        /// Deletes the T-H diagram point with the specified unique identifier.
        /// </summary>
        /// <param name="thDiagramPointId">The unique identifier of the T-H diagram point to delete.</param>
        public void DeleteTHDiagramPoint(int thDiagramPointId)
        {
            try
            {
                THDiagramPointRepoObj.DeleteTHDiagramPoint(thDiagramPointId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving T-H diagram point: {ex.Message}");
            }
        }
        #endregion  // DeleteTHDiagramPoint(int thDiagramPointId)
    }
    #endregion      // public class THDiagramPointViewModel
}
#endregion      // namespace HenViewModel.Pinch.Plots

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
