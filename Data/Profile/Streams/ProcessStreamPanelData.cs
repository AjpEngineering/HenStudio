#region HEADER
//#####################################################################################################################
//################################  P r o c e s s S t r e a m P a n e l D a t a . c s  ################################
//#####################################################################################################################
//  FILENAME:  ProcessStreamPanelData.cs
//  NAMESPACE: HenStudio.Data.Profile.Streams
//  CLASS(S):  ProcessStreamPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Process Stream Panel Data object - data needed for Process Stream Panel.
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
using HenModel.Dto.Profile;
using HenModel.Dto.Profile.Streams;

using HenViewModel.Profile;
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
    #region public class ProcessStreamPanelData
    public class ProcessStreamPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Profile";
        const string CLASS = "ProcessStreamPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public Guid ProjectId { get; set; }       // Project Unique Identifier
        public Guid ProfileId { get; set; }       // Profile Unique Identifier
        public Guid ProcessStreamId { get; set; } // Process Stream Unique Identifier

        public double OverallDuty { get; set; }   // Overall Duty ... (First-Law Calc)

        public int NumInvalidRows { get; set; }   // Number of Invalid Stream Rows ... (e.g., 3 invalid rows)

        public List<ProcessStreamDto> ProcessStreamDtoList { get; set; }  // List of Process Stream DTO Objects

        #region VIEW MODEL Object
        public ProcessStreamViewModel ProcessStreamViewModelObj { get; set; }
        #endregion  // VIEW MODEL Objects

        #endregion  // PROPERTIES

        #region INITIALIZE PANEL DATA
        /// <summary>
        /// Initializes the properties of the ProcessStreamPanelData class with default values. 
        /// </summary>
        private void InitializePanelData()
        {
            ProjectId = new Guid();         // Project Unique Identifier
            ProfileId = new Guid();         // Profile Unique Identifier
            ProcessStreamId = new Guid();   // Process Stream Unique Identifier

            OverallDuty = 0.00;             // Overall Duty ... (First-Law Calc: Sum of (Hot - Cold Stream Duties)
            NumInvalidRows = 0;             // Number of Invalid Stream Rows ... (e.g., 3 invalid rows)

            ProcessStreamDtoList = new List<ProcessStreamDto>();       // List of Process Stream DTO Objects ... EXTERN Units
            ProcessStreamViewModelObj = new ProcessStreamViewModel();  // ViewModel Object for Process Stream Panel
        }
        #endregion  // INITIALIZE PANEL DATA
        
        #region CTOR
        /// <summary>
        /// Default Constructor for ProcessStreamPanelData Class. 
        /// Initializes the properties of the ProcessStreamPanelData object to their 
        /// default values by calling the InitializePanelData method.
        /// </summary>
        public ProcessStreamPanelData()
        {
            InitializePanelData();
        }
        #endregion  // CTOR

        #region CRUD METHODS

        #region CREATE PROCESS STREAM DATA METHOD
        /// <summary>
        /// Creates a new Process Stream using the data in the ProcessStreamDtoList property
        /// and returns the Profile ID associated with the newly created process streams.
        /// </summary>
        /// <returns>The  Profile ID of the newly created process streams.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the process stream ID is null after creation.</exception>
        public Guid CreateProcessStreamsData()
        {
            if (ProcessStreamDtoList == null) throw new ArgumentNullException(
                             nameof(ProcessStreamDtoList),
                             "ProcessStreamDtoList is null for Create Process Stream Panel data.");
            //------------------------------------------------------------------------------------------------
            //--- Add Process Streams and get Profile ID associated with the newly created process streams ---
            //------------------------------------------------------------------------------------------------
            ProfileId = ProcessStreamViewModelObj.AddProcessStreams(ProcessStreamDtoList);

            if (ProfileId == null) throw new ArgumentNullException(
                             nameof(ProfileId),
                             "Profile ID is null for Create Process Stream Panel data.");
            //-------------------------
            //--- Return Profile ID ---
            //-------------------------
            return ProfileId;
        }
        #endregion  // CREATE PROCESS STREAM DATA METHOD

        #region READ PROCESS STREAM DATA METHOD
        /// <summary>
        /// Reads the process stream data for the specified process stream ID 
        /// and populates the ProcessStreamDtoObj property with the retrieved data.
        /// </summary>
        /// <param name="profileId">The ID of the profile to read.</param>
        /// <exception cref="ArgumentNullException">Thrown when the profile ID is null.</exception>
        public List<ProcessStreamDto> ReadProcessStreamData(Guid profileId)
        {
            if (profileId == null) throw new ArgumentNullException(
                             nameof(profileId), 
                             "Profile ID is null for READ Process Stream Panel data.");
            //------------------------------------------------------------
            //--- Get Process Stream data for the specified profile ID ---     
            //--- and assign it to the ProcessStreamDtoList property   ---
            //--- Also assign the profile ID to the ProfileId property ---
            //------------------------------------------------------------
            ProfileId = profileId;
            ProcessStreamDtoList = ProcessStreamViewModelObj.GetProcessStreamsByProfileId(profileId);

            if (ProcessStreamDtoList == null) throw new ArgumentNullException(
                                        nameof(ProcessStreamDtoList),
                                        "Process Stream DTO List is null for READ Process Stream Panel data.");
            //--------------------------------------
            //--- Return Process Stream DTO List ---
            //--------------------------------------
            return ProcessStreamDtoList;
        }
        #endregion  // READ PROCESS STREAM DATA METHOD

        #region UPDATE PROCESS STREAM DATA METHOD
        /// <summary>
        /// Updates the process stream data using the provided ProcessStreamDto object 
        /// and returns the updated ProcessStreamDto object.
        /// </summary>
        /// <param name="processStreamDtoObj">The ProcessStreamDto object containing 
        /// the updated process stream data.</param>
        /// <returns>The updated ProcessStreamDto list.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the process stream DTO or its ID is null.</exception>
        public List<ProcessStreamDto> UpdateProcessStreamData(List<ProcessStreamDto> externalProcessStreamDtoList)
        {
            if (externalProcessStreamDtoList == null) throw new ArgumentNullException(
                                 nameof(externalProcessStreamDtoList),
                                 "Process Stream DTO list is null for UPDATE Process Stream Panel data.");

            if (externalProcessStreamDtoList.Any(dto => dto.Id == null)) throw new ArgumentNullException(
                                    nameof(externalProcessStreamDtoList),
                                    "One or more Process Stream DTO IDs are null for UPDATE Process Stream Panel data.");
            //--------------------------------------
            //--- Assign Process Stream DTO List ---
            //--------------------------------------
            ProcessStreamDtoList = externalProcessStreamDtoList;
            //-----------------------------------------------------------
            //--- Update the process stream data in the database using the   ---
            //--- ProcessStreamViewModelObj's UpdateProcessStream method     ---
            //-----------------------------------------------------------
            ProcessStreamViewModelObj.UpdateProcessStreams(externalProcessStreamDtoList);
            //---------------------------------------------
            //--- Return the updated Process Stream DTO object ---
            //---------------------------------------------
            return ProcessStreamDtoList;
        }
        #endregion  // UPDATE PROCESS STREAM DATA METHOD

        #region DELETE PROCESS STREAM DATA METHOD
        /// <summary>
        /// Deletes the process stream data for the specified process stream ID.
        /// [SINGLE ROW]
        /// </summary>
        /// <param name="processStreamId">The ID of the process stream to delete.</param>
        /// <exception cref="ArgumentNullException">Thrown when the process stream ID is null.</exception>
        public void DeleteProcessStreamData(Guid processStreamId)
        {
            if (processStreamId == null) throw new ArgumentNullException(
                             nameof(processStreamId),
                             "Process Stream ID is null for DELETE Process Stream Panel data.");
            //--------------------------------------------------------------
            //--- Delete a single ProcessStream row using the            ---
            //--- ProcessStreamViewModelObj's DeleteProcessStream method ---
            //--- Assign the process stream ID to the                    ---
            //--- ProcessStreamId property                               ---
            //--------------------------------------------------------------
            ProcessStreamId = processStreamId;
            ProcessStreamViewModelObj.DeleteProcessStream(processStreamId);
        }
        #endregion  // DELETE PROCESS STREAM DATA METHOD

        #endregion  // CRUD METHODS
    }
    #endregion      // public class ProcessStreamPanelData
}
#endregion  // namespace HenStudio.Data.Profile.Streams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
