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

        #region ConvertToExternalDto(UtilityStreamDto internalDto)
        /// <summary>
        /// Converts a Utility Stream DTO from INTERNAL units to EXTERNAL units.
        /// </summary>
        /// <param name="internalDto">The Utility Stream DTO in INTERNAL units.</param>
        /// <returns>A <see cref="UtilityStreamDto"/> DTO in EXTERNAL units.</returns>
        private UtilityStreamDto ConvertToExternalDto(UtilityStreamDto internalDto)
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
            UtilityStreamDto externalDto = new UtilityStreamDto();
            //---------------------------------------------------------
            //--- Convert INTERNAL DTO Fields to EXTERNAL DTO Units ---
            //---------------------------------------------------------
            externalDto.Id = internalDto.Id;
            externalDto.ProfileId = internalDto.ProfileId;

            externalDto.StreamCategory        = internalDto.StreamCategory;
            externalDto.StreamHeat            = internalDto.StreamHeat;
            externalDto.StreamId              = internalDto.StreamId;
            externalDto.Name                  = internalDto.Name;
            externalDto.StreamType            = internalDto.StreamType;
            externalDto.IsothermalTemperature = ConvertToExternalTemp(internalDto.IsothermalTemperature);
            externalDto.SupplyPressure        = ConvertToExternalPress(internalDto.SupplyPressure);
            externalDto.TargetPressure        = ConvertToExternalPress(internalDto.TargetPressure);
            externalDto.EnthalpyFlowRate      = ConvertToExternalH(internalDto.EnthalpyFlowRate);
            //--------------------------------------------------
            //--- Return the EXTERNAL DTO in EXTERNAL units. ---
            //--------------------------------------------------
            return externalDto;
        }
        #endregion  // ConvertToExternalDto(UtilityStreamDto internalDto)

        #region ConvertToInternalDto(UtilityStreamDto externalDto)
        /// <summary>
        /// Converts a Utility Stream DTO from EXTERNAL units to INTERNAL units.
        /// </summary>
        /// <param name="externalDto">The Utility Stream DTO in EXTERNAL units.</param>
        /// <returns>A <see cref="UtilityStreamDto"/> DTO in INTERNAL units.</returns>
        private UtilityStreamDto ConvertToInternalDto(UtilityStreamDto externalDto)
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
            UtilityStreamDto internalDto = new UtilityStreamDto();
            //-------------------------------------------------
            //--- Convert EXTERNAL Fields to INTERNAL Units ---
            //-------------------------------------------------
            internalDto.Id = externalDto.Id;
            internalDto.ProfileId = externalDto.ProfileId;

            internalDto.StreamCategory        = externalDto.StreamCategory;
            internalDto.StreamHeat            = externalDto.StreamHeat;
            internalDto.StreamId              = externalDto.StreamId;
            internalDto.Name                  = externalDto.Name;
            internalDto.StreamType            = externalDto.StreamType;
            internalDto.IsothermalTemperature = ConvertFromExternalTemp(externalDto.IsothermalTemperature);
            internalDto.SupplyPressure        = ConvertFromExternalPress(externalDto.SupplyPressure);
            internalDto.TargetPressure        = ConvertFromExternalPress(externalDto.TargetPressure);
            internalDto.EnthalpyFlowRate      = ConvertFromExternalH(externalDto.EnthalpyFlowRate);
            //--------------------------------------------------
            //--- Return the INTERNAL DTO in INTERNAL units. ---
            //--------------------------------------------------
            return internalDto;
        }
        #endregion  // ConvertToInternalDto(UtilityStreamDto externalDto)

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
            //-------------------------- Null DTO Guard ---------------------------------
            //--- If the user provided DTO is null,                                   ---
            //--- Then return an empty GUID to indicate that there is nothing to add. ---
            //--- This prevents potential null reference exceptions when trying       ---
            //--- to access properties of a null object.                              ---
            //---------------------------------------------------------------------------
            if (externalUtilityStreamDto == null)
            {
                return Guid.Empty;
            }
            //------------------------------------------------------------------------------
            //--- Initialize a variable to hold the unique identifier of the newly added ---
            //--- utility stream. This variable will be assigned the value returned by   ---
            //--- the repository method after adding the utility stream.                 ---
            //------------------------------------------------------------------------------
            Guid utilityStreamId = new Guid();
            try
            {
                //-------------------------------------------------------------------------------
                //--- Convert the provided EXTERNAL DTO to an INTERNAL DTO in INTERNAL units. ---
                //-------------------------------------------------------------------------------
                //--- This conversion is necessary because the repository layer operates with ---
                //--- INTERNAL units.                                                         ---
                //-------------------------------------------------------------------------------
                //--- The conversion method will handle the unit conversion for all relevant  ---
                //--- properties. After conversion, the INTERNAL DTO can be passed to the     ---
                //--- repository method for adding the utility stream.                        ---
                //-------------------------------------------------------------------------------
                UtilityStreamDto internalUtilityStreamDto = ConvertToInternalDto(externalUtilityStreamDto);
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
            //------------------------------------------------------------------------------------------
            //--- Initialize a list to hold the utility stream DTOs in EXTERNAL units.               ---
            //------------------------------------------------------------------------------------------
            //--- This list will be populated with the converted DTOs retrieved from the repository. ---
            //--- The repository returns DTOs in INTERNAL units, so each retrieved DTO will be       ---
            //--- converted to EXTERNAL units before being added to this list.                       ---
            //------------------------------------------------------------------------------------------
            //--- This approach ensures that the view model provides data in the expected EXTERNAL   ---
            //--- units to any consuming views or components.                                        ---
            //------------------------------------------------------------------------------------------
            //--- If an error occurs during retrieval or conversion, the method will return null to  ---
            //--- indicate that the operation was unsuccessful.                                      ---
            //--- Consumers of this method should check for a null return value to handle potential  ---
            //--- errors gracefully.                                                                 ---
            //------------------------------------------------------------------------------------------
            //--- If the method returns an empty list, it indicates that there are no utility        ---
            //----streams available, but the retrieval operation itself was successful.              ---
            //--- This distinction between null (error) and empty list (no data) allows for more     ---
            //--- precise handling of different scenarios in the consuming code.                     ---
            //------------------------------------------------------------------------------------------
            List<UtilityStreamDto> externalUtilityStreams = new List<UtilityStreamDto>();
            try
            {
                //-----------------------------------------------------------------------------------------
                //--- Loop through each utility stream DTO retrieved from the repository, which are in  ---
                //--- INTERNAL units.                                                                   ---
                //-----------------------------------------------------------------------------------------
                //--- For each retrieved DTO, convert it to EXTERNAL units using the conversion method, ---
                //--- and add the converted DTO to the list of EXTERNAL utility streams.                ---
                //-----------------------------------------------------------------------------------------
                //--- This loop ensures that all utility streams retrieved from the repository are      ---
                //--- provided to the consuming code in EXTERNAL units, as expected by the view model's ---
                //--- interface.                                                                        ---
                //-----------------------------------------------------------------------------------------
                //--- If an error occurs during retrieval or conversion, the catch block will handle    ---
                //--- the exception and return null to indicate that the operation was unsuccessful.    ---
                //--- Consumers of this method should check for a null return value to handle potential ---
                //--- errors gracefully, and should also be prepared to handle an empty list if there   ---
                //---are no utility streams available.                                                  ---
                //------------------------------------------------------------------------------------------
                foreach (UtilityStreamDto internalUtilityStream in UtilityStreamRepoObj.GetUtilityStreams())
                {
                    externalUtilityStreams.Add(ConvertToExternalDto(internalUtilityStream));
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
            //---------------------------- Null Guid Guard -----------------------------------
            //--- If the provided profileId is an empty GUID,
            //--- return null to indicate that there is no valid identifier to search for. ---
            //--------------------------------------------------------------------------------
            //--- This prevents unnecessary database queries and potential errors when     ---
            //--- trying to retrieve a utility stream with an invalid identifier.          ---
            //--------------------------------------------------------------------------------
            if ((profileId == Guid.Empty) || (profileId == null))
            {
                return null;
            }
            //------------------------------------------------------------------------------------------
            //--- Initialize a list to hold the utility stream DTOs in EXTERNAL units.               ---
            //------------------------------------------------------------------------------------------
            //--- This list will be populated with the converted DTOs retrieved from the repository. ---
            //--- The repository returns DTOs in INTERNAL units, so each retrieved DTO will be       ---
            //--- converted to EXTERNAL units before being added to this list.                       ---
            //--- This approach ensures that the view model provides data in the expected EXTERNAL   ---
            //--- units to any consuming views or components.                                        ---
            //--- If an error occurs during retrieval or conversion, the method will return null to  ---
            //--- indicate that the operation was unsuccessful.                                      ---
            //--- Consumers of this method should check for a null return value to handle potential  ---
            //--- errors gracefully.                                                                 ---
            //--- If the method returns an empty list, it indicates that there are no utility        ---
            //--- streams available for the specified profile, but the retrieval operation itself    ---
            //--- was successful.                                                                    ---
            //--- This distinction between null (error) and empty list (no data) allows for more     ---
            //--- precise handling of different scenarios in the consuming code.                     ---
            //------------------------------------------------------------------------------------------
            List<UtilityStreamDto> externalUtilityStreams = new List<UtilityStreamDto>();
            try
            {
                //-----------------------------------------------------------------------------------------
                //--- Loop through each utility stream DTO retrieved from the repository for the        ---
                //--- specified profile, which are in INTERNAL units.                                   ---
                //-----------------------------------------------------------------------------------------
                //--- For each retrieved DTO, convert it to EXTERNAL units using the conversion method, ---
                //--- and add the converted DTO to the list of EXTERNAL utility streams.                ---
                //-----------------------------------------------------------------------------------------
                //--- This loop ensures that all utility streams retrieved from the repository for the  ---
                //--- specified profile are provided to the consuming code in EXTERNAL units, as        ---
                //--- expected by the view model's interface.                                           ---
                //-----------------------------------------------------------------------------------------
                //--- If an error occurs during retrieval or conversion, the catch block will handle    ---
                //--- the exception and return null to indicate that the operation was unsuccessful.    ---
                //-----------------------------------------------------------------------------------------
                foreach (UtilityStreamDto internalUtilityStream in UtilityStreamRepoObj.GetUtilityStreamsByProfileId(profileId))
                {
                    externalUtilityStreams.Add(ConvertToExternalDto(internalUtilityStream));
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
                //---------------------------- Null Guid Guard -----------------------------------
                //--- If the provided utilityStreamId is an empty GUID,                        ---
                //--- return null to indicate that there is no valid identifier to search for. ---
                //--- This prevents unnecessary database queries and potential errors when     ---
                //--- trying to retrieve a utility stream with an invalid identifier.          ---
                //--------------------------------------------------------------------------------
                if ((utilityStreamId == Guid.Empty) || (utilityStreamId == null))
                {
                    return null;
                }
                //---------------------------------------------------------------------------------------
                //--- Retrieve the utility stream DTO from the repository using the provided          ---
                //--- unique identifier.                                                              ---
                //---------------------------------------------------------------------------------------
                //--- The repository method returns the DTO in INTERNAL units, so it will be          ---
                //--- converted to EXTERNAL units before being returned.                              ---
                //---------------------------------------------------------------------------------------
                //--- If the repository does not find a utility stream with the specified             ---
                //--- identifier, it may return null, which will be handled by the conversion method. ---
                //---------------------------------------------------------------------------------------
                //--- The conversion method will return null if the input DTO is null, allowing the   ---
                //--- method to return null in cases where the utility stream is not found.           ---
                //---------------------------------------------------------------------------------------
                //--- If an error occurs during retrieval or conversion, the catch block will handle  ---
                //--- the exception and return null to indicate that the operation was unsuccessful.  ---
                //---------------------------------------------------------------------------------------
                UtilityStreamDto internalUtilityStream = UtilityStreamRepoObj.GetUtilityStreamById(utilityStreamId);
                return ConvertToExternalDto(internalUtilityStream);
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
                //----------------------------------------------------------------------------------------
                //--- Retrieve the utility stream DTO from the repository using the provided profileId ---
                //--- and streamId.                                                                    ---
                //----------------------------------------------------------------------------------------
                //--- The repository method returns the DTO in INTERNAL units, so it will be converted ---
                //--- to EXTERNAL units before being returned.                                         ---
                //----------------------------------------------------------------------------------------
                //--- If the repository does not find a utility stream with the specified identifiers, ---
                //--- it may return null, which will be handled by the conversion method.              ---
                //----------------------------------------------------------------------------------------
                //--- The conversion method will return null if the input DTO is null, allowing the    ---
                //--- method to return null in cases where the utility stream is not found.            ---
                //----------------------------------------------------------------------------------------
                //--- If an error occurs during retrieval or conversion, the catch block will handle   ---
                //--- the exception and return null to indicate that the operation was unsuccessful.   ---
                //---------------------------------------------------------------------------------------
                UtilityStreamDto internalUtilityStream = UtilityStreamRepoObj.GetUtilityStreamByStreamId(profileId, streamId);
                return ConvertToExternalDto(internalUtilityStream);
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
            //-------------------------- Null DTO Guard ---------------------------
            //--- If the user provided DTO is null,                             ---
            //--- Then return immediately to prevent further processing.        ---
            //--- This prevents potential null reference exceptions when trying ---
            //--- to access properties of a null object.                        ---
            //---------------------------------------------------------------------
            if (externalUtilityStreamDto == null)
            {
                return;
            }
            try
            {
                //------------------------------------------------------------------------------------------
                //--- Update the utility stream in the repository using the provided EXTERNAL DTO.       ---
                //------------------------------------------------------------------------------------------
                //--- The repository method expects a DTO in INTERNAL units, so the provided EXTERNAL    ---
                //--- DTO will be converted to INTERNAL units before being passed to the repository.     ---
                //------------------------------------------------------------------------------------------
                //--- The conversion method will handle the unit conversion for all relevant properties. ---
                //--- After conversion, the INTERNAL DTO can be passed to the repository method for      ---
                //--- updating the utility stream.                                                       ---
                //------------------------------------------------------------------------------------------
                //--- If an error occurs during conversion or the update operation, the catch block will ---
                //--- handle the exception and log an error message.                                     ---
                //------------------------------------------------------------------------------------------
                UtilityStreamDto internalUtilityStreamDto = ConvertToInternalDto(externalUtilityStreamDto);
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
            //---------------------------- Null Guid Guard --------------------------------
            //--- If the provided utilityStreamId is an empty GUID,                     ---
            //--- return immediately to prevent further processing.                     ---
            //--- This prevents unnecessary database queries and potential errors when  ---
            //--- trying to retrieve a utility stream with an invalid identifier.       ---
            //-----------------------------------------------------------------------------
            if ((utilityStreamId == Guid.Empty) || (utilityStreamId == null))
            {
                return;
            }
            try
            {
                //-------------------------------------------------------------------------------------------
                //--- Delete the utility stream from the repository using the provided unique identifier. ---
                //--- If an error occurs during the delete operation, the catch block will handle the     ---
                //--- exception and log an error message.                                                 ---
                //-------------------------------------------------------------------------------------------
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
