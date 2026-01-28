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

using PinchGlobal;
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
        private ArrayList _scoreCardList;   // ArrayList of ScoreCardRowData objects
        private int _nProperties;           // Number of Properties
        private int _nInvalidProps;         // Number of INVALID Properties
        private int _nValidProps;           // Number of VALID   Properties
        private string _strValidation;      // Overall Validation Status ["LICENSE VALIDATED" | "LICENSE NOT VALIDATED"]
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

        #region NumProperties
        /// <summary>
        /// NumProperties Property
        /// </summary>
        public int NumProperties
        {
            get { return _nProperties; }
            set { _nProperties = value; }
        }
        #endregion  // NumProperties

        #region NumInvalidProps
        /// <summary>
        /// NumInvalidProps Property
        /// </summary>
        public int NumInvalidProps
        {
            get { return _nInvalidProps; }
            set { _nInvalidProps = value; }
        }
        #endregion  // NumInvalidProps

        #region NumValidProps
        /// <summary>
        /// NumValidProps Property
        /// </summary>
        public int NumValidProps
        {
            get { return _nValidProps; }
            set { _nValidProps = value; }
        }
        #endregion  // NumValidProps

        #region ValidationState
        /// <summary>
        /// ValidationState Property
        /// </summary>
        public string ValidationState
        {
            get { return _strValidation; }
            set { _strValidation = value; }
        }
        #endregion  // ValidationState

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

            NumProperties = 0;
            NumInvalidProps = 0;
            NumValidProps = 0;
            ValidationState = String.Empty;
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

        #region public void GetCounts()
        /// <summary>
        /// Get the Table Counts and assign to Count Properties
        /// </summary>
        public void GetCounts()
        {
            NumProperties = ScoreCardListObj.Count;
            NumInvalidProps = 0;
            NumValidProps = 0;
            foreach (ScoreCardRowData row in ScoreCardListObj)
            {
                if (String.Compare(row.PropertyState, "VALID") == 0) NumValidProps++;
                else NumInvalidProps++;
            }
            if(NumInvalidProps > 0) ValidationState = "LICENSE NOT VALIDATED";
            else ValidationState = "LICENSE VALIDATED";
        }
        #endregion  // public void GetCounts()

        #region public void LogTable()
        /// <summary>
        /// Log the Table Contents
        /// </summary>
        public void LogTable()
        {
            string strMethod = "LogTable";
            string strMsg = String.Empty;
            try
            {
                int nRows = ScoreCardListObj.Count;
                Console.WriteLine("===============================");
                Console.WriteLine("======= SCORECARD TABLE =======");
                Console.WriteLine("===============================");
                Console.WriteLine(" Number Row: " + nRows.ToString());
                Console.WriteLine("-------------------------------");

                strMsg = String.Format(" {0}  {1,-8}  {2,-22}  {3}",
                                       "ID", "STATE", "NAME", "VALUE");
                Console.WriteLine(strMsg);

                foreach (ScoreCardRowData row in ScoreCardListObj)
                {
                    strMsg = String.Format(" {0}  {1,-8}  {2,-22}  {3}",
                                           row.PropertyID,
                                           row.PropertyState,
                                           row.PropertyName,
                                           row.PropertyValue);
                    Console.WriteLine(strMsg);
                }
                Console.WriteLine("===============================");
                Console.WriteLine("===============================");
                Console.WriteLine("===============================");

            }
            catch (Exception ex)
            {
                strMsg = string.Format(" *** EXCEPTION Logging ScoreCard Table Data  [{0} : {1}]",
                                       strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            finally
            {
            }
        }
        #endregion  // public void LogTable()

    }
    #endregion  // public class ScoreCardTableData
}
#endregion  // namespace AJP_License_File
//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
