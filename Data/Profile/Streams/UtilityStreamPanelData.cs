#region HEADER
//#####################################################################################################################
//################################  U t i l i t y S t r e a m P a n e l D a t a . c s  ################################
//#####################################################################################################################
//  FILENAME:  UtilityStreamPanelData.cs
//  NAMESPACE: HenStudio.Data.Profile.Streams
//  CLASS(S):  UtilityStreamPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Utility Stream Panel Data object - data needed for Utility Stream Panel.
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
//    01/01/26 .. pg .. Version 4.0
//#####################################################################################################################
//#####################################################################################################################
//#####################################################################################################################
#endregion      // HEADER

#region REFERENCES
using HenModel.Dto.Profile.Streams;

using HenViewModel.Profile.Streams;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Profile.Streams
namespace HenStudio.Data.Profile.Streams
{
    #region public class UtilityStreamPanelData
    public class UtilityStreamPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Profile";
        const string CLASS = "UtilityStreamPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public Guid ProjectId { get; set; } 
        public Guid ProfileId { get; set; }
        public Guid UtilityStreamId { get; set; } 

        public int NumInvalidRows { get; set; }   

        public List<UtilityStreamDto> UtilityStreamDtoList { get; set; }   // List of Utility Stream DTO Objects

        #region VIEW MODEL Object
        public UtilityStreamViewModel UtilityStreamViewModelObj { get; set; }
        #endregion  // VIEW MODEL Objects

        #endregion  // PROPERTIES

        #region INITIALIZE PANEL DATA
        /// <summary>
        /// Initializes the properties of the UtilityStreamPanelData class with default values. 
        /// </summary>
        private void InitializePanelData()
        {
            ProjectId = new Guid();         // Project Unique Identifier
            ProfileId = new Guid();         // Profile Unique Identifier
            UtilityStreamId = new Guid();   // Utility Stream Unique Identifier
            NumInvalidRows = 0;             // Number of Invalid Stream Rows ... (e.g., 3 invalid rows)
            UtilityStreamDtoList = new List<UtilityStreamDto>();       // List of Utility Stream DTO Objects ... EXTERN Units
            UtilityStreamViewModelObj = new UtilityStreamViewModel();  // ViewModel Object for Utility Stream Panel
        }
        #endregion  // INITIALIZE PANEL DATA

        #region CTOR
        /// <summary>
        /// Default Constructor for UtilityStreamPanelData Class. 
        /// Initializes the properties of the UtilityStreamPanelData object to their 
        /// default values by calling the InitializePanelData method.
        /// </summary>
        public UtilityStreamPanelData()
        {
            InitializePanelData();
        }
        #endregion  // CTOR

        #region CRUD METHODS

        #region CREATE UTILITY STREAM DATA METHOD
        /// <summary>
        /// Creates a new Utility Stream using the data in the UtilityStreamDtoList property
        /// and returns the Profile ID associated with the newly created utility streams.
        /// </summary>
        /// <returns>The  Profile ID of the newly created utility streams.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the utility stream ID is null after creation.</exception>
        public Guid CreateUtilityStreamsData()
        {
            if (UtilityStreamDtoList == null) throw new ArgumentNullException(
                            nameof(UtilityStreamDtoList),
                            "UtilityStreamDtoList is null for Create Utility Stream Panel data.");
            //------------------------------------------------------------------------------------------------
            //--- Add Utility Streams and get Profile ID associated with the newly created utility streams ---
            //------------------------------------------------------------------------------------------------
            ProfileId = UtilityStreamViewModelObj.AddUtilityStream(UtilityStreamDtoList);

            if (ProfileId == null) throw new ArgumentNullException(
                             nameof(ProfileId),
                             "Profile ID is null for Create Utility Stream Panel data.");

            return ProfileId;
        }
        #endregion  // CREATE UTILITY STREAM DATA METHOD

        #region READ UTILITY STREAM DATA METHOD
        /// <summary>
        /// Reads the utility stream data for the specified utility stream ID 
        /// and populates the UtilityStreamDtoObj property with the retrieved data.
        /// </summary>
        /// <param name="profileId">The ID of the profile to read.</param>
        /// <exception cref="ArgumentNullException">Thrown when the profile ID is null.</exception>
        public List<UtilityStreamDto> ReadUtilityStreamData(Guid profileId)
        {
            if (profileId == null) throw new ArgumentNullException(
                             nameof(profileId),
                             "Profile ID is null for READ Utility Stream Panel data.");
            //------------------------------------------------------------
            //--- Get Utility Stream data for the specified profile ID ---     
            //--- and assign it to the UtilityStreamDtoList property   ---
            //--- Also assign the profile ID to the ProfileId property ---
            //------------------------------------------------------------
            ProfileId = profileId;
            UtilityStreamDtoList = UtilityStreamViewModelObj.GetUtilityStreamsByProfileId(profileId);

            if (UtilityStreamDtoList == null) throw new ArgumentNullException(
                                        nameof(UtilityStreamDtoList),
                                        "Utility Stream DTO List is null for READ Utility Stream Panel data.");
            //--------------------------------------
            //--- Return Utility Stream DTO List ---
            //--------------------------------------
            return UtilityStreamDtoList;
        }
        #endregion  // READ UTILITY STREAM DATA METHOD

        #region UPDATE UTILITY STREAM DATA METHOD
        /// <summary>
        /// Updates the utility stream data using the provided UtilityStreamDto object 
        /// and returns the updated UtilityStreamDto list.
        /// </summary>
        /// <param name="utilityStreamDtoObj">The UtilityStreamDto object containing 
        /// the updated utility stream data.</param>
        /// <returns>The updated UtilityStreamDto list.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the utility stream DTO or its ID is null.</exception>
        public List<UtilityStreamDto> UpdateUtilityStreamData(List<UtilityStreamDto> externalUtilityStreamDtoList)
        {
            if (externalUtilityStreamDtoList == null) throw new ArgumentNullException(
                              nameof(externalUtilityStreamDtoList),
                              "Utility Stream DTO list is null for UPDATE Utility Stream Panel data.");

            if (externalUtilityStreamDtoList.Any(dto => dto.Id == null)) throw new ArgumentNullException(
                               nameof(externalUtilityStreamDtoList),
                               "One or more Utility Stream DTO IDs are null for UPDATE Utility Stream Panel data.");
            //--------------------------------------
            //--- Assign Utility Stream DTO List ---
            //--------------------------------------
            UtilityStreamDtoList = externalUtilityStreamDtoList;
            //----------------------------------------------------------------
            //--- Update the utility stream data in the database using the ---
            //--- UtilityStreamViewModelObj's UpdateUtilityStream method   ---
            //----------------------------------------------------------------
            UtilityStreamViewModelObj.UpdateUtilityStreams(externalUtilityStreamDtoList);
            //---------------------------------------------
            //--- Return the updated Utility Stream DTO object ---
            //---------------------------------------------
            return UtilityStreamDtoList;
        }
        #endregion  // UPDATE UTILITY STREAM DATA METHOD

        #region DELETE UTILITY STREAM DATA METHOD
        /// <summary>
        /// Deletes the utility stream data for the specified utility stream ID.
        /// [SINGLE ROW]
        /// </summary>
        /// <param name="utilityStreamId">The ID of the utility stream to delete.</param>
        /// <exception cref="ArgumentNullException">Thrown when the utility stream ID is null.</exception>
        public void DeleteUtilityStreamData(Guid utilityStreamId)
        {
            if (utilityStreamId == null) throw new ArgumentNullException(
                             nameof(utilityStreamId),
                             "Utility Stream ID is null for DELETE Utility Stream Panel data.");
            //--------------------------------------------------------------
            //--- Delete a single UtilityStream row using the            ---
            //--- UtilityStreamViewModelObj's DeleteUtilityStream method ---
            //--- Assign the utility stream ID to the                    ---
            //--- UtilityStreamId property                               ---
            //--------------------------------------------------------------
            UtilityStreamId = utilityStreamId;
            UtilityStreamViewModelObj.DeleteUtilityStream(utilityStreamId);
        }
        #endregion  // DELETE UTILITY STREAM DATA METHOD

        #endregion  // CRUD METHODS
    }
    #endregion      // public class UtilityStreamPanelData
}
#endregion  // namespace HenStudio.Data.Profile.Streams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
