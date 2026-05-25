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
        public Guid ProjectId { get; set; }       // Project Unique Identifier
        public Guid ProfileId { get; set; }       // Profile Unique Identifier
        public Guid UtilityStreamId { get; set; } // Utility Stream Unique Identifier

        public int NumInvalidRows { get; set; }   // Number of Invalid Stream Rows ... (e.g., 3 invalid rows)

        public UtilityStreamDto UtilityStreamDtoList { get; set; }   // List of Utility Stream DTO Objects
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Initializes a new instance of the UtilityStreamPanelData class with default values for all properties.
        /// </summary>
        /// <remarks>All string properties are initialized to empty strings, date properties are set to
        /// the current date and time, and the UtilityStreamDtoObj property is initialized with a new UtilityStreamDto instance.
        /// This constructor ensures that the object is in a valid default state upon creation.</remarks>
        public UtilityStreamPanelData()
        {
            ProjectId = new Guid();         // Project Unique Identifier
            ProfileId = new Guid();         // Profile Unique Identifier
            UtilityStreamId = new Guid();   // Utility Stream Unique Identifier

            NumInvalidRows = 0;             // Number of Invalid Stream Rows ... (e.g., 3 invalid rows)

            UtilityStreamDtoList = new UtilityStreamDto(); // List of Utility Stream DTO Objects ... EXTERN Units
        }
        #endregion  // CTOR

    }
    #endregion      // public class UtilityStreamPanelData
}
#endregion  // namespace HenStudio.Data.Profile.Streams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
