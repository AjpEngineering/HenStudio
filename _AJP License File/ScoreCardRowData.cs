#region HEADER
//#####################################################################################################################
//#####################################  S c o r e C a r d R o w D a t a . c s  #######################################
//#####################################################################################################################
//  FILENAME:  ScoreCardRowData.cs
//  NAMESPACE: AJP_License_File
//  CLASS(S):  ScoreCardRowData
//  COMPONENT: _AJP License File.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the License ScoreCard Row Data ... used in ScoreCardTableData object.
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
#endregion  // REFERENCES

#region namespace AJP_License_File
namespace AJP_License_File
{
    #region public class ScoreCardRowData
    public class ScoreCardRowData
    {
        #region CONSTANTS
        const string NAMESPACE = "AJP_License_File";
        const string CLASS = "ScoreCardRowData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public string PropertyID { get; set; }          // License File Property ID ...... e.g., "01"
        public string PropertyName { get; set; }        // License File Property Name .... e.g., "Author"
        public string PropertyValue { get; set; }       // License File Property Value ... e.g., "AJP Engineering"
        public string PropertyState { get; set; }       // License File Property State ... e.g., "VALID"
        public Bitmap PropertyStateImage { get; set; }  // License File Property State Bitmap Image
        #endregion      // PROPERTIES

        #region Default CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public ScoreCardRowData()
        {
            //-----------------------------
            //--- Initialize Properties ---
            //-----------------------------
            PropertyID = "00";
            PropertyName = "Name";
            PropertyValue = "Value";
            PropertyState = "State";
            PropertyStateImage = Properties.Resources.InValid_32x32;
        }
        #endregion  // Default CTOR

        #region Parameterized CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public ScoreCardRowData(string strPropID,
                                string strPropName,
                                string strPropValue,
                                string strPropState)
        {
            //-----------------------------
            //--- Initialize Properties ---
            //-----------------------------
            PropertyID = strPropID;
            PropertyName = strPropName;
            PropertyValue = strPropValue;
            PropertyState = strPropState;

            PropertyStateImage = Properties.Resources.InValid_32x32;    // Initialize to INVALID Image
            if (String.Compare(strPropState, "VALID", true) == 0) 
                PropertyStateImage = Properties.Resources.Valid_32x32;  // VALID Image
        }
        #endregion  // Parameterized CTOR

    }
    #endregion  // public class ScoreCardRowData
}
#endregion  // namespace AJP_License_File
//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
