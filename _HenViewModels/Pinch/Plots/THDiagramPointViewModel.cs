#region HEADER
//#####################################################################################################################
//####################################  T H D i a g r a m P o i n t V i e w M o d e l . c s  ##########################
//#####################################################################################################################
//  FILENAME:  THDiagramPointViewModel.cs
//  NAMESPACE: HenViewModels
//  CLASS(S):  THDiagramPointViewModel
//  COMPONENT: _HenViewModels.dll
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

using HenPersistence.Connection;
using HenPersistence.Repos;

using HenRepositories.Dto;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenViewModels
namespace HenViewModels
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

        #region CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public THDiagramPointViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var thDiagramPointRepoObj = new THDiagramPointRepo(connFactoryObj);

            THDiagramPointRepoObj = thDiagramPointRepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // CTOR

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

        #region GetTHDiagramPointsByTHDiagramId(Guid thDiagramId)
        /// <summary>
        /// Retrieves a list of all T-H diagram points associated with the specified T-H diagram identifier.
        /// </summary>
        /// <param name="thDiagramId">The unique identifier of the T-H diagram whose points are to be retrieved.</param>
        /// <returns>A list of <see cref="THDiagramPointDto"/> objects representing the matching T-H diagram points, or an empty list if none are found.</returns>
        public IList<THDiagramPointDto> GetTHDiagramPointsByTHDiagramId(Guid thDiagramId)
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
        #endregion  // GetTHDiagramPointsByTHDiagramId(Guid thDiagramId)

        #region GetTHDiagramPointById(Guid thDiagramPointId)
        /// <summary>
        /// Retrieves the THDiagramPoint DTO associated with the specified unique identifier.
        /// </summary>
        /// <param name="thDiagramPointId">The unique identifier of the T-H diagram point to retrieve.</param>
        /// <returns>A <see cref="THDiagramPointDto"/> representing the T-H diagram point with the specified identifier. Returns null if none is found.</returns>
        public THDiagramPointDto GetTHDiagramPointById(Guid thDiagramPointId)
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
        #endregion  // GetTHDiagramPointById(Guid thDiagramPointId)

        #region GetTHDiagramPointByPointSequence(Guid thDiagramId, int pointSequence)
        /// <summary>
        /// Retrieves a T-H diagram point by its T-H diagram identifier and point sequence.
        /// </summary>
        /// <param name="thDiagramId">The unique identifier of the T-H diagram that owns the point.</param>
        /// <param name="pointSequence">The point sequence to retrieve.</param>
        /// <returns>A <see cref="THDiagramPointDto"/> containing the T-H diagram point details if found; otherwise, null.</returns>
        public THDiagramPointDto GetTHDiagramPointByPointSequence(Guid thDiagramId, int pointSequence)
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
        #endregion  // GetTHDiagramPointByPointSequence(Guid thDiagramId, int pointSequence)

        #region AddTHDiagramPoint(THDiagramPointDto thDiagramPointDto)
        /// <summary>
        /// Adds a new T-H diagram point to the database using the specified DTO.
        /// </summary>
        /// <param name="thDiagramPointDto">The T-H diagram point data to add.</param>
        /// <returns>A GUID representing the unique identifier of the newly added T-H diagram point.</returns>
        public Guid AddTHDiagramPoint(THDiagramPointDto thDiagramPointDto)
        {
            Guid thDiagramPointId = new Guid();
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

        #region DeleteTHDiagramPoint(Guid thDiagramPointId)
        /// <summary>
        /// Deletes the T-H diagram point with the specified unique identifier.
        /// </summary>
        /// <param name="thDiagramPointId">The unique identifier of the T-H diagram point to delete.</param>
        public void DeleteTHDiagramPoint(Guid thDiagramPointId)
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
        #endregion  // DeleteTHDiagramPoint(Guid thDiagramPointId)
    }
    #endregion      // public class THDiagramPointViewModel
}
#endregion      // namespace HenViewModels

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
