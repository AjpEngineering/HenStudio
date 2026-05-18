#region HEADER
//#####################################################################################################################
//#######################################  D a t a T a g D i s p l a y . c s  #########################################
//#####################################################################################################################
//  FILENAME:  DataTagDisplay.cs
//  NAMESPACE: HenStudio
//  CLASS(S):  DataTagDisplay
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Display Data object contained in the Tag of the Tree Node.
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
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static HenGlobal.HenTypes;

#endregion  // REFERENCES

#region namespace HenStudio.Data.Tag
namespace HenStudio.Data.Tag
{
    #region class DataTagDisplay
    class DataTagDisplay
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio";
        const string CLASS = "DataTagDisplay";
        #endregion      // CONSTANTS

        #region PROPERTIES

        #region NODE ID ENUMERATION
        public ExplorerNodeIdType NodeIdEnum 
        { get; set; } // Project Node ID Enumeration
        #endregion  // NODE ID ENUMERATION

        #region TAG STRING PROPERTIES
        public string NodeName 
        { get; set; }       // Name of Node (without Prefix)
        public string DisplayName 
        { get; set; }       // Display Name of Node (Prefix + NodeName)
                            // [ UNKNOWN | CATALOG | PROJECT | PROFILE | STUDY ]
        #endregion  // TAG STRING PROPERTIES

        #region TAG GUID (PK) PROPERTIES
        public Guid ProjectID 
        { get; set; }       // Project ID (PK)
        public Guid ProfileID 
        { get; set; }       // Profile ID (PK)
        public Guid StudyID 
        { get; set; }       // Study ID (PK)
        #endregion // TAG GUID (PK) PROPERTIES

        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="nodeId">Node ID Enumeration</param>
        /// <param name="strNodeName">Node name - without the Prefix</param>
        public DataTagDisplay(ExplorerNodeIdType nodeId, string strNodeName) 
        {
            //-----------------------------
            //--- Initialize Properties ---
            //-----------------------------
            NodeName = strNodeName;     // Name of Node (without Prefix)
            NodeIdEnum = nodeId;        // Display Name of Node (Prefix + NodeName)

            ProjectID = Guid.Empty;     // Project ID (PK)
            ProfileID = Guid.Empty;     // Profile ID (PK)
            StudyID = Guid.Empty;       // Study   ID (PK)
            //------------------------------------------------
            //--- Display Name of Node (Prefix + NodeName) ---
            //------------------------------------------------
            switch (nodeId)
            {
                case ExplorerNodeIdType.CATALOG:
                    DisplayName = string.Format("HEN Studio");
                    break;
                case ExplorerNodeIdType.PROJECT:
                    DisplayName = string.Format("Project: {0}", NodeName);
                    break;
                case ExplorerNodeIdType.PROFILE:
                    DisplayName = string.Format("Profile: {0}", NodeName);
                    break;
                case ExplorerNodeIdType.STUDY:
                    DisplayName = string.Format("Study: {0}", NodeName);
                    break;
                default:
                    DisplayName = "Unknown: none";
                    break;
            }
        }
        #endregion  // CTOR

    }
    #endregion  // class DataTagDisplay
}
#endregion  // namespace HenStudio.Data.Tag

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
