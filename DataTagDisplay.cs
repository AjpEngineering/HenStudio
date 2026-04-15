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

#region namespace HenStudio
namespace HenStudio
{
    #region internal class DataTagDisplay
    internal class DataTagDisplay
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio";
        const string CLASS = "DataTagDisplay";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public string FullPathNodeLoc { get; set; }    // Full-Path Node location from root to node
        public string NodeName { get; set; }           // Name of Node
        public string DisplayName { get; set; }        // Display Name of Node (Prefix + NodeName)
        public ExplorerLevel LevelEnum { get; set; }   // Project Level Enumeration
                                                       // [ UNKNOWN | CATALOG | PROJECT | PROFILE | PINCH | HEN ]

        public Guid ProjectID { get; set; }     // Project ID (PK)
        public Guid ProfileID { get; set; }     // Profile ID (PK)
        public Guid PinchID { get; set; }       // Pinch ID (PK)
        public Guid HenID { get; set; }         // Hen ID (PK)

        public ProfileInputType ProfileInputTypeEnum { get; set; }  // Profile Input Type Enumeration
        public Guid ProcessID { get; set; }     // Process Streams ID (PK)
        public Guid UtilityID { get; set; }     // Utility Streams ID (PK)
        public Guid EconomicID { get; set; }    // Economic Params ID (PK)

        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="level">Node Level</param>
        /// <param name="strNodeName">Node name - not including the Level Prefix</param>
        public DataTagDisplay(ExplorerLevel level, string strNodeName) 
        {
            //-----------------------------
            //--- Initialize Properties ---
            //-----------------------------
            FullPathNodeLoc = string.Empty;
            NodeName = strNodeName;
            LevelEnum = level;

            ProjectID = Guid.Empty;
            ProfileID = Guid.Empty;
            PinchID = Guid.Empty;
            HenID = Guid.Empty;

            ProfileInputTypeEnum = ProfileInputType.UNKNOWN;

            ProcessID = Guid.Empty;
            UtilityID = Guid.Empty;
            EconomicID = Guid.Empty;

            switch(LevelEnum)
            {
                case ExplorerLevel.CATALOG:
                    DisplayName = string.Format("HEN Studio");
                    break;
                case ExplorerLevel.PROJECT:
                    DisplayName = string.Format("Project: {0}", NodeName);
                    break;
                case ExplorerLevel.PROFILE:
                    DisplayName = string.Format("Profile: {0}", NodeName);
                    break;
                case ExplorerLevel.PINCH:
                    DisplayName = string.Format("Pinch: {0}", NodeName);
                    break;
                case ExplorerLevel.HEN:
                    DisplayName = string.Format("Hen: {0}", NodeName);
                    break;
                default:
                    DisplayName = "Unknown: none";
                    break;
            }

        }
        #endregion  // CTOR

    }
    #endregion  // internal class DataTagDisplay
}
#endregion  // namespace HenStudio

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
