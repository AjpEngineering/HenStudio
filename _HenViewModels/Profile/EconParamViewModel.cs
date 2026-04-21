#region HEADER
//#####################################################################################################################
//#####################################  E c o n P a r a m V i e w M o d e l . c s  ###################################
//#####################################################################################################################
//  FILENAME:  EconParamViewModel.cs
//  NAMESPACE: HenViewModels
//  CLASS(S):  EconParamViewModel
//  COMPONENT: _HenViewModels.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the EconParam Profile DTO.
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
    #region public class EconParamViewModel
    /// <summary>
    /// EconParam view model class.
    /// </summary>
    public class EconParamViewModel : ViewModelBase
    {
        #region PROPERTIES
        public EconParamRepo EconParamRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public EconParamViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var econParamRepoObj = new EconParamRepo(connFactoryObj);

            EconParamRepoObj = econParamRepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // CTOR

        #region GetEconParams()
        /// <summary>
        /// Retrieves a list of all EconParams.
        /// </summary>
        /// <returns>A list of <see cref="EconParamDto"/> objects representing the available economic parameters, or an empty list if none are found.</returns>
        public IList<EconParamDto> GetEconParams()
        {
            try
            {
                return EconParamRepoObj.GetEconParams();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving econ param: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetEconParams()

        #region GetEconParamsByProfileId(Guid profileId)
        /// <summary>
        /// Retrieves a list of all EconParams associated with the specified profile identifier.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile whose economic parameters are to be retrieved.</param>
        /// <returns>A list of <see cref="EconParamDto"/> objects representing the matching economic parameters, or an empty list if none are found.</returns>
        public IList<EconParamDto> GetEconParamsByProfileId(Guid profileId)
        {
            try
            {
                return EconParamRepoObj.GetEconParamsByProfileId(profileId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving econ param: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetEconParamsByProfileId(Guid profileId)

        #region GetEconParamById(Guid econParamId)
        /// <summary>
        /// Retrieves the EconParam DTO associated with the specified unique identifier.
        /// </summary>
        /// <param name="econParamId">The unique identifier of the EconParam to retrieve.</param>
        /// <returns>An <see cref="EconParamDto"/> representing the EconParam with the specified identifier. Returns null if none is found.</returns>
        public EconParamDto GetEconParamById(Guid econParamId)
        {
            try
            {
                return EconParamRepoObj.GetEconParamById(econParamId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving econ param: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetEconParamById(Guid econParamId)

        #region GetEconParamByName(Guid profileId, string capitalCostIndexName)
        /// <summary>
        /// Retrieves an EconParam by its profile identifier and capital cost index name.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile that owns the economic parameter.</param>
        /// <param name="capitalCostIndexName">The capital cost index name to retrieve.</param>
        /// <returns>An <see cref="EconParamDto"/> containing the economic parameter details if found; otherwise, null.</returns>
        public EconParamDto GetEconParamByName(Guid profileId, string capitalCostIndexName)
        {
            try
            {
                return EconParamRepoObj.GetEconParamByName(profileId, capitalCostIndexName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving econ param: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetEconParamByName(Guid profileId, string capitalCostIndexName)

        #region AddEconParam(EconParamDto econParamDto)
        /// <summary>
        /// Adds a new economic parameter to the database using the specified DTO.
        /// </summary>
        /// <param name="econParamDto">The economic parameter data to add.</param>
        /// <returns>A GUID representing the unique identifier of the newly added economic parameter.</returns>
        public Guid AddEconParam(EconParamDto econParamDto)
        {
            Guid econParamId = new Guid();
            try
            {
                econParamId = EconParamRepoObj.AddEconParam(econParamDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving econ param: {ex.Message}");
            }
            return econParamId;
        }
        #endregion  // AddEconParam(EconParamDto econParamDto)

        #region UpdateEconParam(EconParamDto econParamDto)
        /// <summary>
        /// Updates an existing economic parameter in the database using the specified DTO.
        /// </summary>
        /// <param name="econParamDto">The economic parameter DTO containing updated information.</param>
        public void UpdateEconParam(EconParamDto econParamDto)
        {
            try
            {
                EconParamRepoObj.UpdateEconParam(econParamDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving econ param: {ex.Message}");
            }
        }
        #endregion  // UpdateEconParam(EconParamDto econParamDto)

        #region DeleteEconParam(Guid econParamId)
        /// <summary>
        /// Deletes the economic parameter with the specified unique identifier.
        /// </summary>
        /// <param name="econParamId">The unique identifier of the economic parameter to delete.</param>
        public void DeleteEconParam(Guid econParamId)
        {
            try
            {
                EconParamRepoObj.DeleteEconParam(econParamId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving econ param: {ex.Message}");
            }
        }
        #endregion  // DeleteEconParam(Guid econParamId)
    }
    #endregion      // public class EconParamViewModel
}
#endregion      // namespace HenViewModels

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
