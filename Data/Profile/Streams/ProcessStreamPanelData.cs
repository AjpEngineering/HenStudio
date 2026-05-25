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
using HenModel.Dto.Profile.Streams;

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
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Initializes a new instance of the ProcessStreamPanelData class with default values for all properties.
        /// </summary>
        /// <remarks>All string properties are initialized to empty strings, and 
        /// the ProcessStreamDtoObj property is initialized with a new ProcessStreamDto instance.
        /// This constructor ensures that the object is in a valid default state upon creation.</remarks>
        public ProcessStreamPanelData()
        {
            ProjectId = new Guid();         // Project Unique Identifier
            ProfileId = new Guid();         // Profile Unique Identifier
            ProcessStreamId = new Guid();   // Process Stream Unique Identifier

            OverallDuty = 0.00;             // Overall Duty ... (First-Law Calc: Sum of (Hot - Cold Stream Duties)
            NumInvalidRows = 0;             // Number of Invalid Stream Rows ... (e.g., 3 invalid rows)

            ProcessStreamDtoList = new List<ProcessStreamDto>();   // List of Process Stream DTO Objects ... EXTERN Units
        }
        #endregion  // CTOR

    }
    #endregion      // public class ProcessStreamPanelData
}
#endregion  // namespace HenStudio.Data.Profile.Streams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
