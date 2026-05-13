#region HEADER
//#####################################################################################################################
//###################################  P r o c e s s S t r e a m V i e w M o d e l . c s  #############################
//#####################################################################################################################
//  FILENAME:  ProcessStreamViewModel.cs
//  NAMESPACE: HenViewModel.Profile.Streams
//  CLASS(S):  ProcessStreamViewModel
//  COMPONENT: _HenViewModel.dll
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

using HenModel.Connection;
using HenModel.RepoImplementations.Profile.Streams;
using HenModel.RepoInterfaces.Profile.Streams;
using HenModel.Dto.Profile.Streams;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenViewModel.Profile.Streams
namespace HenViewModel.Profile.Streams
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

        #region PRIVATE DTO CONVERSION METHODS

        #region ConvertToExternalDto(ProcessStreamDto internalDto)
        /// <summary>
        /// Converts a Process Stream DTO from INTERNAL units to EXTERNAL units.
        /// </summary>
        /// <param name="internalDto">The Process Stream DTO in INTERNAL units.</param>
        /// <returns>A <see cref="ProcessStreamDto"/> DTO in EXTERNAL units.</returns>
        private ProcessStreamDto ConvertToExternalDto(ProcessStreamDto internalDto)
        {
            //-------------------------- Null DTO Guard ----------------------------
            //--- If the user provided DTO is null,                              ---
            //--- Then return null to indicate that there is nothing to convert. ---
            //--- This prevents potential null reference exceptions when trying  ---
            //--- to access properties of a null object.                         ---
            //----------------------------------------------------------------------
            if (internalDto == null)
            {
                return null;
            }
            //------------------------------ Create EXTERNAL DTO -----------------------------------
            //--- Create a new DTO object to hold the converted values in EXTERNAL units.        ---
            //--- This object will be populated with the converted values from the INTERNAL DTO. ---
            //--------------------------------------------------------------------------------------
            ProcessStreamDto externalDto = new ProcessStreamDto();
            //---------------------------------------------------------
            //--- Convert INTERNAL DTO Fields to EXTERNAL DTO Units ---
            //---------------------------------------------------------
            externalDto.Id = internalDto.Id;
            externalDto.ProfileId = internalDto.ProfileId;

            externalDto.StreamCategory       = internalDto.StreamCategory;
            externalDto.StreamHeat           = internalDto.StreamHeat;
            externalDto.StreamId             = internalDto.StreamId;
            externalDto.Name                 = internalDto.Name;
            externalDto.StreamType           = internalDto.StreamType;
            externalDto.StreamSubtype        = internalDto.StreamSubtype;
            externalDto.SupplyTemperature    = ConvertToExternalTemp(internalDto.SupplyTemperature);
            externalDto.SupplyPressure       = ConvertToExternalPress(internalDto.SupplyPressure);
            externalDto.TargetTemperature    = ConvertToExternalTemp(internalDto.TargetTemperature);
            externalDto.TargetPressure       = ConvertToExternalPress(internalDto.TargetPressure);
            externalDto.HeatCapacityFlowRate = ConvertToExternalCP(internalDto.HeatCapacityFlowRate);
            //--------------------------------------------------
            //--- Return the EXTERNAL DTO in EXTERNAL units. ---
            //--------------------------------------------------
            return externalDto;
        }
        #endregion  // ConvertToExternalDto(ProcessStreamDto internalDto)

        #region ConvertToInternalDto(ProcessStreamDto externalDto)
        /// <summary>
        /// Converts a Process Stream DTO from EXTERNAL units to INTERNAL units.
        /// </summary>
        /// <param name="externalDto">The Process Stream DTO in EXTERNAL units.</param>
        /// <returns>A <see cref="ProcessStreamDto"/> DTO in INTERNAL units.</returns>
        private ProcessStreamDto ConvertToInternalDto(ProcessStreamDto externalDto)
        {
            //-------------------------- Null DTO Guard ----------------------------
            //--- If the user provided DTO is null,                              ---
            //--- Then return null to indicate that there is nothing to convert. ---
            //--- This prevents potential null reference exceptions when trying  ---
            //--- to access properties of a null object.                         ---
            //----------------------------------------------------------------------
            if (externalDto == null)
            {
                return null;
            }
            //------------------------------ Create INTERNAL DTO -----------------------------------
            //--- Create a new DTO object to hold the converted values in INTERNAL units.        ---
            //--- This object will be populated with the converted values from the EXTERNAL DTO. ---
            //--------------------------------------------------------------------------------------
            ProcessStreamDto internalDto = new ProcessStreamDto();
            //-------------------------------------------------
            //--- Convert EXTERNAL Fields to INTERNAL Units ---
            //-------------------------------------------------
            internalDto.Id = externalDto.Id;
            internalDto.ProfileId = externalDto.ProfileId;

            internalDto.StreamCategory       = externalDto.StreamCategory;
            internalDto.StreamHeat           = externalDto.StreamHeat;
            internalDto.StreamId             = externalDto.StreamId;
            internalDto.Name                 = externalDto.Name;
            internalDto.StreamType           = externalDto.StreamType;
            internalDto.StreamSubtype        = externalDto.StreamSubtype;
            internalDto.SupplyTemperature    = ConvertFromExternalTemp(externalDto.SupplyTemperature);
            internalDto.SupplyPressure       = ConvertFromExternalPress(externalDto.SupplyPressure);
            internalDto.TargetTemperature    = ConvertFromExternalTemp(externalDto.TargetTemperature);
            internalDto.TargetPressure       = ConvertFromExternalPress(externalDto.TargetPressure);
            internalDto.HeatCapacityFlowRate = ConvertFromExternalCP(externalDto.HeatCapacityFlowRate);
            //--------------------------------------------------
            //--- Return the INTERNAL DTO in INTERNAL units. ---
            //--------------------------------------------------
            return internalDto;
        }
        #endregion  // ConvertToInternalDto(ProcessStreamDto externalDto)

        #endregion      // PRIVATE DTO CONVERSION METHODS

        #region PROCESS STREAM CRUD METHODS

        #region AddProcessStream(ProcessStreamDto externalProcessStreamDto) ... CREATE
        /// <summary>
        /// Adds (CREATE) a new process stream to the database using the specified DTO in external units.
        /// </summary>
        /// <param name="externalProcessStreamDto">The process stream data to add in external units.</param>
        /// <returns>A GUID representing the unique identifier of the newly added process stream.</returns>
        public Guid AddProcessStream(ProcessStreamDto externalProcessStreamDto)
        {
            //-------------------------------------------------------------------------------------------------------------------
            //--- Initialize a variable to hold the unique identifier of the newly added process stream.                      ---
            //--- This variable will be assigned the value returned by the repository method after adding the process stream. ---
            //--- It is initialized to a new GUID to ensure it has a valid value even if the addition fails.                  ---
            //-------------------------------------------------------------------------------------------------------------------
            Guid processStreamId = new Guid();
            try
            {
                //---------------------------------------------------------------------------------------
                //--- Convert the provided EXTERNAL DTO to an INTERNAL DTO for repository processing. ---
                //--- The repository methods expect DTOs in INTERNAL units, so the conversion is      ---
                //--- necessary before calling the add method.                                        ---
                //---------------------------------------------------------------------------------------
                ProcessStreamDto internalProcessStreamDto = ConvertToInternalDto(externalProcessStreamDto);
                //------------------------------------------------------------------------------------------------------------
                //--- Add the process stream using the repository method and capture the returned unique identifier.       ---
                //--- The repository method will handle the actual database insertion and return the ID of the new record. ---
                //------------------------------------------------------------------------------------------------------------
                processStreamId = ProcessStreamRepoObj.AddProcessStream(internalProcessStreamDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving process stream: {ex.Message}");
            }
            return processStreamId;
        }
        #endregion  // AddProcessStream(ProcessStreamDto externalProcessStreamDto) ... CREATE

        #region GetProcessStreams() ... READ
        /// <summary>
        /// Retrieves (READ) a list of all ProcessStreams in external units.
        /// </summary>
        /// <returns>A list of <see cref="ProcessStreamDto"/> objects representing the available process streams, or an empty list if none are found.</returns>
        public IList<ProcessStreamDto> GetProcessStreams()
        {
            //------------------------------------------------------------------------------------------------------
            //--- Initialize a list to hold the process stream DTOs in EXTERNAL units.                           ---
            //--- This list will be populated with the converted DTOs retrieved from the repository.             ---
            //--- It is initialized as an empty list to ensure it has a valid value even if the retrieval fails. ---
            //------------------------------------------------------------------------------------------------------
            List<ProcessStreamDto> externalProcessStreams = new List<ProcessStreamDto>();
            try
            {
                //----------------------------------------------------------------------------
                //--- Loop through each process stream DTO retrieved from the repository,  ---
                //--- convert it to EXTERNAL units, and add it to the list.                ---
                //----------------------------------------------------------------------------
                //--- The repository method returns DTOs in INTERNAL units,                ---
                //--- so each DTO must be converted before being added to the list.        ---
                //----------------------------------------------------------------------------
                //--- This loop ensures that all process streams are retrieved, converted, ---
                //--- and made available in EXTERNAL units for the caller.                 ---
                //----------------------------------------------------------------------------
                //--- If the repository retrieval fails, the catch block will handle the   ---
                //--- exception and return an empty list.                                  ---
                //----------------------------------------------------------------------------
                foreach (ProcessStreamDto internalProcessStream in ProcessStreamRepoObj.GetProcessStreams())
                {
                    externalProcessStreams.Add(ConvertToExternalDto(internalProcessStream));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving process stream: {ex.Message}");
                return null;
            }
            return externalProcessStreams;
        }
        #endregion  // GetProcessStreams() ... READ

        #region GetProcessStreamsByProfileId(Guid profileId) ... READ
        /// <summary>
        /// Retrieves (READ) a list of all ProcessStreams associated with the specified profile identifier in external units.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile whose process streams are to be retrieved.</param>
        /// <returns>A list of <see cref="ProcessStreamDto"/> objects representing the matching process streams, 
        /// or an empty list if none are found.</returns>
        public IList<ProcessStreamDto> GetProcessStreamsByProfileId(Guid profileId)
        {
            //------------------------------------------------------------------------------------------------------
            //--- Initialize a list to hold the process stream DTOs in EXTERNAL units.                           ---
            //--- This list will be populated with the converted DTOs retrieved from the repository.             ---
            //--- It is initialized as an empty list to ensure it has a valid value even if the retrieval fails. ---
            //------------------------------------------------------------------------------------------------------
            List<ProcessStreamDto> externalProcessStreams = new List<ProcessStreamDto>();
            try
            {
                //-------------------------------------------------------------------------------------------
                //--- Loop through each process stream DTO retrieved from the repository                  ---
                //--- for the specified profile ID, convert it to EXTERNAL units, and add it to the list. ---
                //-------------------------------------------------------------------------------------------
                //--- The repository method returns DTOs in INTERNAL units, so each DTO must be converted ---
                //--- before being added to the list.                                                     ---
                //-------------------------------------------------------------------------------------------
                //--- This loop ensures that all process streams associated with the specified profile ID ---
                //--- are retrieved, converted, and made available in EXTERNAL units for the caller.      ---
                //--- If the repository retrieval fails, the catch block will handle the exception and    ---
                //--- return an empty list.                                                               ---
                //-------------------------------------------------------------------------------------------
                //--- The profile ID parameter allows for filtering the process streams to only those     ---
                //--- that belong to a specific profile, which is essential for organizing and managing   ---
                //--- process streams within different profiles.                                          ---
                //-------------------------------------------------------------------------------------------
                foreach (ProcessStreamDto internalProcessStream in ProcessStreamRepoObj.GetProcessStreamsByProfileId(profileId))
                {
                    externalProcessStreams.Add(ConvertToExternalDto(internalProcessStream));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving process stream: {ex.Message}");
                return null;
            }
            return externalProcessStreams;
        }
        #endregion  // GetProcessStreamsByProfileId(Guid profileId) ... READ

        #region GetProcessStreamById(Guid processStreamId) ... READ
        /// <summary>
        /// Retrieves (READ) the ProcessStream DTO associated with the specified unique identifier.
        /// </summary>
        /// <param name="processStreamId">The unique identifier of the process stream to retrieve.</param>
        /// <returns>A <see cref="ProcessStreamDto"/> representing the process stream with the specified identifier. Returns null if none is found.</returns>
        public ProcessStreamDto GetProcessStreamById(Guid processStreamId)
        {
            try
            {
                //-----------------------------------------------------------------------------------------------------
                //--- Retrieve the process stream DTO from the repository using the specified unique identifier.    ---
                //-----------------------------------------------------------------------------------------------------
                //--- The repository method returns the DTO in INTERNAL units, so it must be converted to           ---
                //--- EXTERNAL units before being returned.                                                         ---
                //-----------------------------------------------------------------------------------------------------
                //--- If the repository retrieval fails, the catch block will handle the exception and return null. ---
                //-----------------------------------------------------------------------------------------------------
                //--- The unique identifier is essential for retrieving a specific process stream, especially when  ---
                //--- there are multiple streams in the database. This method allows for precise retrieval of a     ---
                //--- process stream based on its unique ID, which is critical for operations that require specific ---
                //--- stream details. ---
                //-----------------------------------------------------------------------------------------------------
                //--- The returned DTO will contain all the details of the process stream, including its properties ---
                //--- and values, in EXTERNAL units for use in the application.                                     ---
                //-----------------------------------------------------------------------------------------------------
                //--- If the process stream with the specified ID does not exist, the repository method may return  ---
                //--- null, which will be handled by the catch block.                                               ---
                //-----------------------------------------------------------------------------------------------------
                ProcessStreamDto internalProcessStream = ProcessStreamRepoObj.GetProcessStreamById(processStreamId);
                return ConvertToExternalDto(internalProcessStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving process stream: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetProcessStreamById(Guid processStreamId) ... READ

        #region GetProcessStreamByStreamId(Guid profileId, string streamId) ... READ
        /// <summary>
        /// Retrieves (READ) a process stream by its profile identifier and stream identifier.
        /// </summary>
        /// <param name="profileId">The unique identifier of the profile that owns the process stream.</param>
        /// <param name="streamId">The stream identifier of the process stream to retrieve.</param>
        /// <returns>A <see cref="ProcessStreamDto"/> containing the process stream details if found; otherwise, null.</returns>
        public ProcessStreamDto GetProcessStreamByStreamId(Guid profileId, string streamId)
        {
            //----------------------- Null Guid and Empty String Guard -----------------------
            //--- If the provided profileId is an empty GUID or null, or streamId is empty ---
            //--- return null to indicate that there is no valid identifier to search for. ---
            //--------------------------------------------------------------------------------
            //--- This prevents unnecessary database queries and potential errors when     ---
            //--- trying to retrieve a utility stream with an invalid identifier.          ---
            //--------------------------------------------------------------------------------
            if ((profileId == Guid.Empty) || (profileId == null) || string.IsNullOrEmpty(streamId))
            {
                return null;
            }
            try
            {
                //---------------------------------------------------------------------------------------------------------
                //--- Retrieve the process stream DTO from the repository using the specified profile ID and stream ID. ---
                //---------------------------------------------------------------------------------------------------------
                //--- The repository method returns the DTO in INTERNAL units, so it must be converted to               ---
                //--- EXTERNAL units before being returned.                                                             ---
                //---------------------------------------------------------------------------------------------------------
                //--- If the repository retrieval fails, the catch block will handle the exception and return null.     ---
                //---------------------------------------------------------------------------------------------------------
                //--- The combination of profile ID and stream ID allows for retrieving a specific process stream that  ---
                //--- belongs to a particular profile, which is useful for scenarios where stream IDs may not be unique ---
                //--- across different profiles.                                                                        ---
                //---------------------------------------------------------------------------------------------------------
                //--- The returned DTO will contain all the details of the process stream, including its properties and ---
                //--- values, in EXTERNAL units for use in the application.                                             ---
                //--------------------------------------------------------------------------------------------------------- 
                //--- If the process stream with the specified profile ID and stream ID does not exist, the repository  ---
                //--- method may return null, which will be handled by the catch block.                                 ---
                //---------------------------------------------------------------------------------------------------------
                ProcessStreamDto internalProcessStream = ProcessStreamRepoObj.GetProcessStreamByStreamId(profileId, streamId);
                return ConvertToExternalDto(internalProcessStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving process stream: {ex.Message}");
                return null;
            }
        }
        #endregion  // GetProcessStreamByStreamId(Guid profileId, string streamId) ... READ

        #region UpdateProcessStream(ProcessStreamDto externalProcessStreamDto) ... UPDATE
        /// <summary>
        /// Updates (UPDATE)an existing process stream in the database using the specified DTO in external units.
        /// </summary>
        /// <param name="externalProcessStreamDto">The process stream DTO containing updated information in external units.</param>
        public void UpdateProcessStream(ProcessStreamDto externalProcessStreamDto)
        {
            try
            {
                //---------------------------------------------------------------------------------------
                //--- Convert the provided EXTERNAL DTO to an INTERNAL DTO for repository processing. ---
                //--- The repository methods expect DTOs in INTERNAL units, so the conversion is      ---
                //--- necessary before calling the update method.                                     ---
                //---------------------------------------------------------------------------------------
                ProcessStreamDto internalProcessStreamDto = ConvertToInternalDto(externalProcessStreamDto);
                //---------------------------------------------------------------------------------------
                //--- Request the repository to update the process stream using the converted         ---
                //--- INTERNAL DTO.                                                                   ---
                //---------------------------------------------------------------------------------------
                //--- The repository method will handle the actual database update based on the       ---
                //--- information in the DTO.                                                         ---
                //---------------------------------------------------------------------------------------
                //--- If the repository update fails, the catch block will handle the exception.      ---
                //---------------------------------------------------------------------------------------
                //--- The update operation typically requires the unique identifier of the process    ---
                //--- stream to be included in the DTO, which allows the repository to locate and     ---
                //--- update the correct record in the database.                                      ---
                //---------------------------------------------------------------------------------------
                ProcessStreamRepoObj.UpdateProcessStream(internalProcessStreamDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving process stream: {ex.Message}");
            }
        }
        #endregion  // UpdateProcessStream(ProcessStreamDto externalProcessStreamDto) ... UPDATE

        #region DeleteProcessStream(Guid processStreamId) ... DELETE
        /// <summary>
        /// Deletes (DELETE) the process stream with the specified unique identifier.
        /// </summary>
        /// <param name="processStreamId">The unique identifier of the process stream to delete.</param>
        public void DeleteProcessStream(Guid processStreamId)
        {
            try
            {
                //---------------------------------------------------------------------------------------
                //--- Delete the process stream using the repository method with the specified        ---
                //--- unique identifier.                                                              ---
                //---------------------------------------------------------------------------------------
                //--- The repository method will handle the actual database deletion based on the     ---
                //--- provided ID.                                                                    ---
                //---------------------------------------------------------------------------------------
                //--- If the repository deletion fails, the catch block will handle the exception.    ---
                //---------------------------------------------------------------------------------------
                //--- The unique identifier is essential for deleting a specific process stream,      ---
                //--- especially when there are multiple streams in the database. This method allows  ---
                //--- for precise deletion of a process stream based on its unique ID, which is       ---
                //--- critical for maintaining data integrity. ---
                //---------------------------------------------------------------------------------------
                //--- If the process stream with the specified ID does not exist, the repository      ---
                //--- method may throw an exception, which will be handled by the catch block.        ---
                //---------------------------------------------------------------------------------------
                ProcessStreamRepoObj.DeleteProcessStream(processStreamId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving process stream: {ex.Message}");
            }
        }
        #endregion  // DeleteProcessStream(Guid processStreamId) ... DELETE

        #endregion  // PROCESS STREAM CRUD METHODS

    }
    #endregion      // public class ProcessStreamViewModel
}
#endregion      // namespace HenViewModel.Profile.Streams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
