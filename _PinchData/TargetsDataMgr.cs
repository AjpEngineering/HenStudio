#region HEADER
//#####################################################################################################################
//######################################  T a r g e t s D a t a M g r . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  TargetsDataMgr.cs
//  NAMESPACE: PinchData
//  CLASS(S):  TargetsDataMgr
//  COMPONENT: _PinchData.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Targets Data Manager class.
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
using System.Threading.Tasks;

using PinchGlobal;
#endregion  // REFERENCES

#region namespace PinchData
namespace PinchData
{
    #region public class TargetsDataMgr
    /// <summary>
    /// Targets Data Manager Class
    /// </summary>
    public class TargetsDataMgr
    {
        #region CONSTANTS
        const string NAMESPACE = "PinchData";
        const string CLASS = "TargetsDataMgr";
        #endregion      // CONSTANTS
        public TargetsCalculateData TargetsCalculateDataObj { get; set; }
        public TargetsCompositeData TargetsCompositeDataObj { get; set; }
        public TargetsIntervalData TargetsIntervalDataObj { get; set; }
        public TargetsOptimizeData TargetsOptimizeDataObj { get; set; }

        #region PROPERTIES

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public TargetsDataMgr()
        {
            string strMethod = "CTOR";
            PinchLogger.WriteSeparatorLine(' ');
            PinchLogger.WriteSeparatorLine('>');
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating TargetsDataMgr Object");
            try
            {
                //-----------------------------------------
                //--- Create Targets Panel Data Objects ---
                //-----------------------------------------
                TargetsCalculateDataObj = new TargetsCalculateData();   // Calculate Data
                TargetsCompositeDataObj = new TargetsCompositeData();   // Composite Data
                TargetsIntervalDataObj = new TargetsIntervalData();     // Interval Data
                TargetsOptimizeDataObj = new TargetsOptimizeData();     // Optimize Data
            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "TargetsDataMgr Object CREATED");
                PinchLogger.WriteSeparatorLine('<');
            }
        }
        #endregion      // CTOR

    }
    #endregion      // public class TargetsDataMgr
}
#endregion      // namespace PinchData

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
