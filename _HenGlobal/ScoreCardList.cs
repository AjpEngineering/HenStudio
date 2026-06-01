#region HEADER
//#####################################################################################################################
//##############################3#########  S c o r e C a r d L i s t . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  ScoreCardList.cs
//  NAMESPACE: HenGlobal
//  CLASS(S):  ScoreCardList, ScoreCardRowData
//  COMPONENT: _HenGlobal.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the License ScoreCard List object.
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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HenGlobal;

using static System.Windows.Forms.AxHost;
#endregion  // REFERENCES

#region namespace HenGlobal
namespace HenGlobal
{
    #region public class ScoreCardList
    //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= C l a s s   S c o r e C a r d L i s t =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    public class ScoreCardList  
    {
        #region CONSTANTS
        const string NAMESPACE = "HenGlobal";
        const string CLASS = "ScoreCardList";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public ArrayList ScoreCardListObj { get; set; }  // ArrayList of ScoreCardRowData objects
        public int NumProperties { get; set; }       // Number of Properties
        public int NumInvalidProps { get; set; }     // Number of INVALID Properties
        public int NumValidProps { get; set; }       // Number of VALID Properties
        public string ValidationState { get; set; }  // Overall Validation Status ["VALID LICENSE" | "INVALID LICENSE | EXPIRED LICENSE"]
        public int DaysRemaining { get; set; }       // Days Remaining on the License ... [End Date - Current Date]
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public ScoreCardList() 
        {
            //-----------------------------
            //--- Initialize Properties ---
            //-----------------------------
            ScoreCardListObj = new ArrayList(); // ArrayList of ScoreCardRowData objects

            NumProperties = 0;
            NumInvalidProps = 0;
            NumValidProps = 0;
            ValidationState = String.Empty;
            DaysRemaining = 0;
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
        /// <param name="rowObj">ScoreCardRow Object</param>
        public void AddRow(ScoreCardRow rowObj)
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
            foreach (ScoreCardRow row in ScoreCardListObj)
            {
                if (String.Compare(row.PropertyState, "VALID") == 0) NumValidProps++;
                else NumInvalidProps++;
            }

            DaysRemaining = GetDaysRemaining();

        }
        #endregion  // public void GetCounts()

        #region GetDaysRemaining()
        /// <summary>
        /// Calculates and returns the Days Remaing on the License
        /// </summary>
        /// <returns>On Success: Number of Days remaining on License; otherwise 0</returns>
        private int GetDaysRemaining()
        {
            string strMethod = "GetDaysRemaining";
            string strMsg = String.Empty;
            int nDaysRemaining = 0;
            DateTime currDate = DateTime.Now;
            DateTime endDate  = DateTime.Now;
            string strLicenseEndName = "License End";
            string strValue = String.Empty;
            try
            {
                //-----------------------------
                //--- Find License End Data ---
                //-----------------------------
                foreach(ScoreCardRow row in ScoreCardListObj)
                {
                    if(String.Compare(row.PropertyName, strLicenseEndName, true) == 0) 
                    {
                        //-------------------------
                        //--- LICENSE END FOUND ---
                        //-------------------------
                        strValue = row.PropertyValue;
                        endDate = DateTime.Parse(strValue);

                        nDaysRemaining = (endDate.Date - currDate.Date).Days;
                    }
                }
            }
            catch (Exception ex)
            {
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            finally
            {
            }
            return nDaysRemaining;
        }
        #endregion  // GetDaysRemaining()

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

                foreach (ScoreCardRow row in ScoreCardListObj)
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

    #region public class ScoreCardRow
    //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= C l a s s   S c o r e C a r d R o w =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    public class ScoreCardRow
    {
        #region CONSTANTS
        const string NAMESPACE = "HenGlobal";
        const string CLASS = "ScoreCardRow";
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
        public ScoreCardRow()
        {
            //-----------------------------
            //--- Initialize Properties ---
            //-----------------------------
            PropertyID = "00";
            PropertyName = "Name";
            PropertyValue = "Value";
            PropertyState = "State";
        }
        #endregion  // Default CTOR

        #region Parameterized CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public ScoreCardRow(string strPropID,
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
        }
        #endregion  // Parameterized CTOR

    }
    //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    #endregion  // public class ScoreCardRow

}
#endregion  // namespace HenGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
