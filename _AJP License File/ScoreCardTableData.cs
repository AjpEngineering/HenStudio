#region HEADER
//#####################################################################################################################
//###################################  S c o r e C a r d T a b l e D a t a . c s  #####################################
//#####################################################################################################################
//  FILENAME:  ScoreCardTableData.cs
//  NAMESPACE: AJP_License_File
//  CLASS(S):  ScoreCardTableData
//  COMPONENT: _AJP License File.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the License ScoreCard Table Data object.
//    Manages collection of ScoreCardRowData objects.
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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion  // REFERENCES

#region namespace AJP_License_File
namespace AJP_License_File
{
    #region public class ScoreCardTableData
    public class ScoreCardTableData
    {
        #region CONSTANTS
        const string NAMESPACE = "AJP_License_File";
        const string CLASS = "ScoreCardTableData";
        #endregion      // CONSTANTS

        #region FIELDS
        private ArrayList _scoreCardList;      // ArrayList of ScoreCardRowData objects
        #endregion  // FIELDS

        #region PROPERTIES

        #region ScoreCardListObj
        /// <summary>
        /// ScoreCardListObj Property
        /// </summary>
        public ArrayList ScoreCardListObj
        {
            get { return _scoreCardList; }
            set { _scoreCardList = value; }
        }
        #endregion  // ScoreCardListObj

        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public ScoreCardTableData() 
        {
            //-----------------------------
            //--- Initialize Properties ---
            //-----------------------------
            ScoreCardListObj = new ArrayList(); // ArrayList of ScoreCardRowData objects
        }
        #endregion  // CTOR

        #region public void ClearTable()
        /// <summary>
        /// Clear all row objects from Table
        /// </summary>
        public void ClearTable()
        {
            ScoreCardListObj.Clear();
        }
        #endregion  // public void ClearTable()

        #region public void AddRow()
        /// <summary>
        /// Add row object to Table
        /// </summary>
        /// <param name="rowObj">ScoreCardRowData Object</param>
        public void AddRow(ScoreCardRowData rowObj)
        {
            ScoreCardListObj.Add(rowObj);
        }
        #endregion  // public void AddRow()

    }
    #endregion  // public class ScoreCardTableData
}
#endregion  // namespace AJP_License_File
//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
