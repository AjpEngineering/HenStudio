#region HEADER
//#####################################################################################################################
//######################################  A B C _ J s o n F i l e D a t a . c s  ######################################
//#####################################################################################################################
//  FILENAME:  ABC_JsonFileData.cs
//  NAMESPACE: PinchData
//  CLASS(S):  ABC_JsonFileData
//  COMPONENT: _PinchData.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the JSON File Data Abstract Base Class.
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
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using PinchGlobal;
#endregion  // REFERENCES

#region namespace PinchData
namespace PinchData
{
    #region abstract class ABC_JsonFileData
    /// <summary>
    /// Abstract Base Class for All JSON File Data Classes
    /// </summary>
    public abstract class ABC_JsonFileData
    {
        #region PROPERTIES
        public string DataHash { get; set; }
        public string FullPathJsonFileLoc { get; set; }
        public string FullPathZipFileLoc { get; set; }
        #endregion  // PROPERTIES

        #region public abstract METHODS
        public abstract void CreateHash();          // ZIP EXPORT or IMPORT
        public abstract void InitializeData();      // NEW
        public abstract void LogData();
        public abstract void PersistData();         // SAVE or SAVE AS
        public abstract void RestoreData();         // OPEN
        #endregion  // public abstract METHODS

    }
    #endregion  // abstract class ABC_JsonFileData
}
#endregion      // namespace PinchData

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
