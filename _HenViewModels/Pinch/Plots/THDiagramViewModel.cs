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

using HenPersistence.Connection;
using HenPersistence.Repos;

using HenRepositories.Dto;
using HenRepositories.Interfaces;

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

        #region CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public THDiagramViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var thDiagramRepoObj = new THDiagramRepo(connFactoryObj);

            THDiagramRepoObj = thDiagramRepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // CTOR

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

        #region GetTHDiagramsByProfileId(Guid profileId)
        /// <summary>
        /// Retrieves a list of all T-H diagrams associated with the specified profile identifier.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile whose T-H diagrams are to be retrieved.</param>
        /// <returns>A list of <see cref="THDiagramDto"/> objects representing the matching T-H diagrams, or an empty list if none are found.</returns>
        public IList<THDiagramDto> GetTHDiagramsByProfileId(Guid profileId)
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
        #endregion  // GetTHDiagramsByProfileId(Guid profileId)

        #region GetTHDiagramById(Guid thDiagramId)
        /// <summary>
        /// Retrieves the THDiagram DTO associated with the specified unique identifier.
        /// </summary>
        /// <param name="thDiagramId">The unique identifier of the T-H diagram to retrieve.</param>
        /// <returns>A <see cref="THDiagramDto"/> representing the T-H diagram with the specified identifier. Returns null if none is found.</returns>
        public THDiagramDto GetTHDiagramById(Guid thDiagramId)
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
        #endregion  // GetTHDiagramById(Guid thDiagramId)

        #region GetTHDiagramByTitle(Guid profileId, string title)
        /// <summary>
        /// Retrieves a T-H diagram by its profile identifier and title.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile that owns the T-H diagram.</param>
        /// <param name="title">The title of the T-H diagram to retrieve.</param>
        /// <returns>A <see cref="THDiagramDto"/> containing the T-H diagram details if found; otherwise, null.</returns>
        public THDiagramDto GetTHDiagramByTitle(Guid profileId, string title)
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
        public Guid AddTHDiagram(THDiagramDto thDiagramDto)
        {
            Guid thDiagramId = new Guid();
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

        #region DeleteTHDiagram(Guid thDiagramId)
        /// <summary>
        /// Deletes the T-H diagram with the specified unique identifier.
        /// </summary>
        /// <param name="thDiagramId">The unique identifier of the T-H diagram to delete.</param>
        public void DeleteTHDiagram(Guid thDiagramId)
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
        #endregion  // DeleteTHDiagram(Guid thDiagramId)
    }
    #endregion      // public class THDiagramViewModel
}
#endregion      // namespace HenViewModel.Pinch.Plots

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
