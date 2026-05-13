#region HEADER
//#####################################################################################################################
//###################################  U t i l i t y S t r e a m V i e w M o d e l . c s  #############################
//#####################################################################################################################
//  FILENAME:  UtilityStreamViewModel.cs
//  NAMESPACE: HenViewModel.Profile.Streams
//  CLASS(S):  UtilityStreamViewModel
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the UtilityStream Profile DTO.
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
using HenModel.RepoImplementations.Profile.Streams;
using HenModel.RepoInterfaces.Profile.Streams;
using HenModel.Dto.Profile;
using HenModel.Dto.Profile.Streams;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenViewModel.Profile.Streams
namespace HenViewModel.Profile.Streams
{
    #region public class UtilityStreamViewModel
    /// <summary>
    /// UtilityStream view model class.
    /// </summary>
    public class UtilityStreamViewModel : ViewModelBase
    {
        #region PROPERTIES
        public UtilityStreamRepo UtilityStreamRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public UtilityStreamViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var utilityStreamRepoObj = new UtilityStreamRepo(connFactoryObj);

            UtilityStreamRepoObj = utilityStreamRepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // CTOR

        #region PRIVATE DTO CONVERSION METHODS

        #region ConvertToExternalUtilityStream(UtilityStreamDto internalUtilityStream)
        /// <summary>
        /// Converts a utility stream DTO from internal units to external units.
        /// </summary>
        /// <param name="internalUtilityStream">The utility stream DTO in internal units.</param>
        /// <returns>A <see cref="UtilityStreamDto"/> in external units.</returns>
        private UtilityStreamDto ConvertToExternalUtilityStream(UtilityStreamDto internalUtilityStream)
        {
            if (internalUtilityStream == null)
            {
                return null;
            }

            UtilityStreamDto externalUtilityStream = new UtilityStreamDto();
            externalUtilityStream.Id = internalUtilityStream.Id;
            externalUtilityStream.ProfileId = internalUtilityStream.ProfileId;
            externalUtilityStream.StreamCategory = internalUtilityStream.StreamCategory;
            externalUtilityStream.StreamHeat = internalUtilityStream.StreamHeat;
            externalUtilityStream.StreamId = internalUtilityStream.StreamId;
            externalUtilityStream.Name = internalUtilityStream.Name;
            externalUtilityStream.StreamType = internalUtilityStream.StreamType;
            externalUtilityStream.IsothermalTemperature = ConvertToExternalTemp(internalUtilityStream.IsothermalTemperature);
            externalUtilityStream.SupplyPressure = ConvertToExternalPress(internalUtilityStream.SupplyPressure);
            externalUtilityStream.TargetPressure = ConvertToExternalPress(internalUtilityStream.TargetPressure);
            externalUtilityStream.EnthalpyFlowRate = ConvertToExternalH(internalUtilityStream.EnthalpyFlowRate);
            return externalUtilityStream;
        }
        #endregion  // ConvertToExternalUtilityStream(UtilityStreamDto internalUtilityStream)

        #region ConvertFromExternalUtilityStream(UtilityStreamDto externalUtilityStream)
        /// <summary>
        /// Converts a utility stream DTO from external units to internal units.
        /// </summary>
        /// <param name="externalUtilityStream">The utility stream DTO in external units.</param>
        /// <returns>A <see cref="UtilityStreamDto"/> in internal units.</returns>
        private UtilityStreamDto ConvertFromExternalUtilityStream(UtilityStreamDto externalUtilityStream)
        {
            if (externalUtilityStream == null)
            {
                return null;
            }

            UtilityStreamDto internalUtilityStream = new UtilityStreamDto();
            internalUtilityStream.Id = externalUtilityStream.Id;
            internalUtilityStream.ProfileId = externalUtilityStream.ProfileId;
            internalUtilityStream.StreamCategory = externalUtilityStream.StreamCategory;
            internalUtilityStream.StreamHeat = externalUtilityStream.StreamHeat;
            internalUtilityStream.StreamId = externalUtilityStream.StreamId;
            internalUtilityStream.Name = externalUtilityStream.Name;
            internalUtilityStream.StreamType = externalUtilityStream.StreamType;
            internalUtilityStream.IsothermalTemperature = ConvertFromExternalTemp(externalUtilityStream.IsothermalTemperature);
            internalUtilityStream.SupplyPressure = ConvertFromExternalPress(externalUtilityStream.SupplyPressure);
            internalUtilityStream.TargetPressure = ConvertFromExternalPress(externalUtilityStream.TargetPressure);
            internalUtilityStream.EnthalpyFlowRate = ConvertFromExternalH(externalUtilityStream.EnthalpyFlowRate);
            return internalUtilityStream;
        }
        #endregion  // ConvertFromExternalUtilityStream(UtilityStreamDto externalUtilityStream)

        #endregion      // PRIVATE DTO CONVERSION METHODS

        #region UTILITY STREAM CRUD METHODS

        #region AddUtilityStream(UtilityStreamDto externalUtilityStreamDto) ... CREATE
        /// <summary>
        /// Adds (CREATE) a new utility stream to the database using the specified DTO in external units.
        /// </summary>
        /// <param name="externalUtilityStreamDto">The utility stream data to add in external units.</param>
        /// <returns>A GUID representing the unique identifier of the newly added utility stream.</returns>
        public Guid AddUtilityStream(UtilityStreamDto externalUtilityStreamDto)
        {
            Guid utilityStreamId = new Guid();
            try
            {
                UtilityStreamDto internalUtilityStreamDto = ConvertFromExternalUtilityStream(externalUtilityStreamDto);
                utilityStreamId = UtilityStreamRepoObj.AddUtilityStream(internalUtilityStreamDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving utility stream: {ex.Message}");
            }
            return utilityStreamId;
        }
        #endregion  // AddUtilityStream(UtilityStreamDto externalUtilityStreamDto) ... CREATE

        #region GetUtilityStreams() ... READ
        /// <summary>
        /// Retrieves (READ) a list of all UtilityStreams in external units.
        /// </summary>
        /// <returns>A list of <see cref="UtilityStreamDto"/> objects representing the available utility streams, or an empty list if none are found.</returns>
        public IList<UtilityStreamDto> GetUtilityStreams()
        {
            List<UtilityStreamDto> externalUtilityStreams = new List<UtilityStreamDto>();
            try
            {
                foreach (UtilityStreamDto internalUtilityStream in UtilityStreamRepoObj.GetUtilityStreams())
                {
                    externalUtilityStreams.Add(ConvertToExternalUtilityStream(internalUtilityStream));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving utility stream: {ex.Message}");
                return null;
            }
            return externalUtilityStreams;
        }
        #endregion  // GetUtilityStreams() ... READ

        #region GetUtilityStreamsByProfileId(Guid profileId) ... READ
        /// <summary>
        /// Retrieves (READ) a list of all UtilityStreams associated with the specified profile identifier in external units.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile whose utility streams are to be retrieved.</param>
        /// <returns>A list of <see cref="UtilityStreamDto"/> objects representing the matching utility streams, or an empty list if none are found.</returns>
        public IList<UtilityStreamDto> GetUtilityStreamsByProfileId(Guid profileId)
        {
            List<UtilityStreamDto> externalUtilityStreams = new List<UtilityStreamDto>();
            try
            {
                foreach (UtilityStreamDto internalUtilityStream in UtilityStreamRepoObj.GetUtilityStreamsByProfileId(profileId))
                {
                    externalUtilityStreams.Add(ConvertToExternalUtilityStream(internalUtilityStream));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving utility stream: {ex.Message}");
                return null;
            }
            return externalUtilityStreams;
        }
        #endregion  // GetUtilityStreamsByProfileId(Guid profileId) ... READ

        #region GetUtilityStreamById(Guid utilityStreamId) ... READ
        /// <summary>
        /// Retrieves (READ) the UtilityStream DTO associated with the specified unique identifier.
        /// </summary>
        /// <param name="utilityStreamId">The unique identifier of the utility stream to retrieve.</param>
        /// <returns>A <see cref="UtilityStreamDto"/> representing the utility stream with the specified identifier. Returns null if none is found.</returns>
        public UtilityStreamDto GetUtilityStreamById(Guid utilityStreamId)
        {
            try
            {
                UtilityStreamDto internalUtilityStream = UtilityStreamRepoObj.GetUtilityStreamById(utilityStreamId);
                return ConvertToExternalUtilityStream(internalUtilityStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving utility stream: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetUtilityStreamById(Guid utilityStreamId) ... READ

        #region GetUtilityStreamByStreamId(Guid profileId, string streamId) ... READ
        /// <summary>
        /// Retrieves (READ) a utility stream by its profile identifier and stream identifier.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile that owns the utility stream.</param>
        /// <param name="streamId">The stream identifier of the utility stream to retrieve.</param>
        /// <returns>A <see cref="UtilityStreamDto"/> containing the utility stream details if found; otherwise, null.</returns>
        public UtilityStreamDto GetUtilityStreamByStreamId(Guid profileId, string streamId)
        {
            try
            {
                UtilityStreamDto internalUtilityStream = UtilityStreamRepoObj.GetUtilityStreamByStreamId(profileId, streamId);
                return ConvertToExternalUtilityStream(internalUtilityStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving utility stream: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetUtilityStreamByStreamId(Guid profileId, string streamId) ... READ

        #region UpdateUtilityStream(UtilityStreamDto externalUtilityStreamDto) ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing utility stream in the database using the specified DTO in external units.
        /// </summary>
        /// <param name="externalUtilityStreamDto">The utility stream DTO containing updated information in external units.</param>
        public void UpdateUtilityStream(UtilityStreamDto externalUtilityStreamDto)
        {
            try
            {
                UtilityStreamDto internalUtilityStreamDto = ConvertFromExternalUtilityStream(externalUtilityStreamDto);
                UtilityStreamRepoObj.UpdateUtilityStream(internalUtilityStreamDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving utility stream: {ex.Message}");
            }
        }
        #endregion  // UpdateUtilityStream(UtilityStreamDto externalUtilityStreamDto) ... UPDATE

        #region DeleteUtilityStream(Guid utilityStreamId) ... DELETE
        /// <summary>
        /// Deletes (DELETE) the utility stream with the specified unique identifier.
        /// </summary>
        /// <param name="utilityStreamId">The unique identifier of the utility stream to delete.</param>
        public void DeleteUtilityStream(Guid utilityStreamId)
        {
            try
            {
                UtilityStreamRepoObj.DeleteUtilityStream(utilityStreamId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving utility stream: {ex.Message}");
            }
        }
        #endregion  // DeleteUtilityStream(Guid utilityStreamId) ... DELETE

        #endregion  // UTILITY STREAM CRUD METHODS

    }
    #endregion      // public class UtilityStreamViewModel
}
#endregion      // namespace HenViewModel.Profile.Streams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
