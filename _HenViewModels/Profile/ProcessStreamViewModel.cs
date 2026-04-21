#region HEADER
//#####################################################################################################################
//###################################  P r o c e s s S t r e a m V i e w M o d e l . c s  #############################
//#####################################################################################################################
//  FILENAME:  ProcessStreamViewModel.cs
//  NAMESPACE: HenViewModels
//  CLASS(S):  ProcessStreamViewModel
//  COMPONENT: _HenViewModels.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the ProcessStream Profile DTO.
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
    #region public class ProcessStreamViewModel
    /// <summary>
    /// ProcessStream view model class.
    /// </summary>
    public class ProcessStreamViewModel : ViewModelBase
    {
        #region PROPERTIES
        public ProcessStreamRepo ProcessStreamRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public ProcessStreamViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var processStreamRepoObj = new ProcessStreamRepo(connFactoryObj);

            ProcessStreamRepoObj = processStreamRepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // CTOR

        #region PRIVATE METHODS

        #region ConvertToExternalProcessStream(ProcessStreamDto internalProcessStream)
        /// <summary>
        /// Converts a process stream DTO from internal units to external units.
        /// </summary>
        /// <param name="internalProcessStream">The process stream DTO in internal units.</param>
        /// <returns>A <see cref="ProcessStreamDto"/> in external units.</returns>
        private ProcessStreamDto ConvertToExternalProcessStream(ProcessStreamDto internalProcessStream)
        {
            if (internalProcessStream == null)
            {
                return null;
            }

            ProcessStreamDto externalProcessStream = new ProcessStreamDto();
            externalProcessStream.Id = internalProcessStream.Id;
            externalProcessStream.ProfileId = internalProcessStream.ProfileId;
            externalProcessStream.StreamCategory = internalProcessStream.StreamCategory;
            externalProcessStream.StreamHeat = internalProcessStream.StreamHeat;
            externalProcessStream.StreamId = internalProcessStream.StreamId;
            externalProcessStream.StreamSegmentId = internalProcessStream.StreamSegmentId;
            externalProcessStream.Name = internalProcessStream.Name;
            externalProcessStream.StreamType = internalProcessStream.StreamType;
            externalProcessStream.StreamSubtype = internalProcessStream.StreamSubtype;
            externalProcessStream.SupplyTemperature = ConvertToExternalTemp(internalProcessStream.SupplyTemperature);
            externalProcessStream.SupplyPressure = ConvertToExternalPress(internalProcessStream.SupplyPressure);
            externalProcessStream.TargetTemperature = ConvertToExternalTemp(internalProcessStream.TargetTemperature);
            externalProcessStream.TargetPressure = ConvertToExternalPress(internalProcessStream.TargetPressure);
            externalProcessStream.HeatCapacityFlowRate = ConvertToExternalCP(internalProcessStream.HeatCapacityFlowRate);
            externalProcessStream.HeatTransferCoefficient = ConvertToExternalU(internalProcessStream.HeatTransferCoefficient);
            return externalProcessStream;
        }
        #endregion  // ConvertToExternalProcessStream(ProcessStreamDto internalProcessStream)

        #region ConvertFromExternalProcessStream(ProcessStreamDto externalProcessStream)
        /// <summary>
        /// Converts a process stream DTO from external units to internal units.
        /// </summary>
        /// <param name="externalProcessStream">The process stream DTO in external units.</param>
        /// <returns>A <see cref="ProcessStreamDto"/> in internal units.</returns>
        private ProcessStreamDto ConvertFromExternalProcessStream(ProcessStreamDto externalProcessStream)
        {
            if (externalProcessStream == null)
            {
                return null;
            }

            ProcessStreamDto internalProcessStream = new ProcessStreamDto();
            internalProcessStream.Id = externalProcessStream.Id;
            internalProcessStream.ProfileId = externalProcessStream.ProfileId;
            internalProcessStream.StreamCategory = externalProcessStream.StreamCategory;
            internalProcessStream.StreamHeat = externalProcessStream.StreamHeat;
            internalProcessStream.StreamId = externalProcessStream.StreamId;
            internalProcessStream.StreamSegmentId = externalProcessStream.StreamSegmentId;
            internalProcessStream.Name = externalProcessStream.Name;
            internalProcessStream.StreamType = externalProcessStream.StreamType;
            internalProcessStream.StreamSubtype = externalProcessStream.StreamSubtype;
            internalProcessStream.SupplyTemperature = ConvertFromExternalTemp(externalProcessStream.SupplyTemperature);
            internalProcessStream.SupplyPressure = ConvertFromExternalPress(externalProcessStream.SupplyPressure);
            internalProcessStream.TargetTemperature = ConvertFromExternalTemp(externalProcessStream.TargetTemperature);
            internalProcessStream.TargetPressure = ConvertFromExternalPress(externalProcessStream.TargetPressure);
            internalProcessStream.HeatCapacityFlowRate = ConvertFromExternalCP(externalProcessStream.HeatCapacityFlowRate);
            internalProcessStream.HeatTransferCoefficient = ConvertFromExternalU(externalProcessStream.HeatTransferCoefficient);
            return internalProcessStream;
        }
        #endregion  // ConvertFromExternalProcessStream(ProcessStreamDto externalProcessStream)

        #endregion      // PRIVATE METHODS

        #region GetProcessStreams()
        /// <summary>
        /// Retrieves a list of all ProcessStreams in external units.
        /// </summary>
        /// <returns>A list of <see cref="ProcessStreamDto"/> objects representing the available process streams, or an empty list if none are found.</returns>
        public IList<ProcessStreamDto> GetProcessStreams()
        {
            List<ProcessStreamDto> externalProcessStreams = new List<ProcessStreamDto>();
            try
            {
                foreach (ProcessStreamDto internalProcessStream in ProcessStreamRepoObj.GetProcessStreams())
                {
                    externalProcessStreams.Add(ConvertToExternalProcessStream(internalProcessStream));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving process stream: {ex.Message}");
                return null;
            }
            return externalProcessStreams;
        }
        #endregion  // GetProcessStreams()

        #region GetProcessStreamsByProfileId(Guid profileId)
        /// <summary>
        /// Retrieves a list of all ProcessStreams associated with the specified profile identifier in external units.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile whose process streams are to be retrieved.</param>
        /// <returns>A list of <see cref="ProcessStreamDto"/> objects representing the matching process streams, or an empty list if none are found.</returns>
        public IList<ProcessStreamDto> GetProcessStreamsByProfileId(Guid profileId)
        {
            List<ProcessStreamDto> externalProcessStreams = new List<ProcessStreamDto>();
            try
            {
                foreach (ProcessStreamDto internalProcessStream in ProcessStreamRepoObj.GetProcessStreamsByProfileId(profileId))
                {
                    externalProcessStreams.Add(ConvertToExternalProcessStream(internalProcessStream));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving process stream: {ex.Message}");
                return null;
            }
            return externalProcessStreams;
        }
        #endregion  // GetProcessStreamsByProfileId(Guid profileId)

        #region GetProcessStreamById(Guid processStreamId)
        /// <summary>
        /// Retrieves the ProcessStream DTO associated with the specified unique identifier.
        /// </summary>
        /// <param name="processStreamId">The unique identifier of the process stream to retrieve.</param>
        /// <returns>A <see cref="ProcessStreamDto"/> representing the process stream with the specified identifier. Returns null if none is found.</returns>
        public ProcessStreamDto GetProcessStreamById(Guid processStreamId)
        {
            try
            {
                ProcessStreamDto internalProcessStream = ProcessStreamRepoObj.GetProcessStreamById(processStreamId);
                return ConvertToExternalProcessStream(internalProcessStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving process stream: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetProcessStreamById(Guid processStreamId)

        #region GetProcessStreamByStreamId(Guid profileId, string streamId)
        /// <summary>
        /// Retrieves a process stream by its profile identifier and stream identifier.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile that owns the process stream.</param>
        /// <param name="streamId">The stream identifier of the process stream to retrieve.</param>
        /// <returns>A <see cref="ProcessStreamDto"/> containing the process stream details if found; otherwise, null.</returns>
        public ProcessStreamDto GetProcessStreamByStreamId(Guid profileId, string streamId)
        {
            try
            {
                ProcessStreamDto internalProcessStream = ProcessStreamRepoObj.GetProcessStreamByStreamId(profileId, streamId);
                return ConvertToExternalProcessStream(internalProcessStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving process stream: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetProcessStreamByStreamId(Guid profileId, string streamId)

        #region AddProcessStream(ProcessStreamDto externalProcessStreamDto)
        /// <summary>
        /// Adds a new process stream to the database using the specified DTO in external units.
        /// </summary>
        /// <param name="externalProcessStreamDto">The process stream data to add in external units.</param>
        /// <returns>A GUID representing the unique identifier of the newly added process stream.</returns>
        public Guid AddProcessStream(ProcessStreamDto externalProcessStreamDto)
        {
            Guid processStreamId = new Guid();
            try
            {
                ProcessStreamDto internalProcessStreamDto = ConvertFromExternalProcessStream(externalProcessStreamDto);
                processStreamId = ProcessStreamRepoObj.AddProcessStream(internalProcessStreamDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving process stream: {ex.Message}");
            }
            return processStreamId;
        }
        #endregion  // AddProcessStream(ProcessStreamDto externalProcessStreamDto)

        #region UpdateProcessStream(ProcessStreamDto externalProcessStreamDto)
        /// <summary>
        /// Updates an existing process stream in the database using the specified DTO in external units.
        /// </summary>
        /// <param name="externalProcessStreamDto">The process stream DTO containing updated information in external units.</param>
        public void UpdateProcessStream(ProcessStreamDto externalProcessStreamDto)
        {
            try
            {
                ProcessStreamDto internalProcessStreamDto = ConvertFromExternalProcessStream(externalProcessStreamDto);
                ProcessStreamRepoObj.UpdateProcessStream(internalProcessStreamDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving process stream: {ex.Message}");
            }
        }
        #endregion  // UpdateProcessStream(ProcessStreamDto externalProcessStreamDto)

        #region DeleteProcessStream(Guid processStreamId)
        /// <summary>
        /// Deletes the process stream with the specified unique identifier.
        /// </summary>
        /// <param name="processStreamId">The unique identifier of the process stream to delete.</param>
        public void DeleteProcessStream(Guid processStreamId)
        {
            try
            {
                ProcessStreamRepoObj.DeleteProcessStream(processStreamId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving process stream: {ex.Message}");
            }
        }
        #endregion  // DeleteProcessStream(Guid processStreamId)
    }
    #endregion      // public class ProcessStreamViewModel
}
#endregion      // namespace HenViewModels

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
