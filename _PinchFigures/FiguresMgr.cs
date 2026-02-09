#region HEADER
//#####################################################################################################################
//###########################################  F i g u r e s M g r . c s  #############################################
//#####################################################################################################################
//  FILENAME:  FiguresMgr.cs
//  NAMESPACE: PinchFigures
//  CLASS(S):  FiguresMgr
//  COMPONENT: _PinchFigures.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Figures Manager class.
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

#region namespace PinchFigures
namespace PinchFigures
{
    #region public class FiguresMgr
    /// <summary>
    /// Figures Manager Class
    /// </summary>
    public class FiguresMgr
    {
        #region CONSTANTS
        const string NAMESPACE = "PinchFigures";
        const string CLASS = "FiguresMgr";
        #endregion      // CONSTANTS

        #region PROPERTIES

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public FiguresMgr()
        {
            string strMethod = "CTOR";
            PinchLogger.WriteSeparatorLine('>');
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating FiguresMgr Object");
            try
            {
                //-----------------------------------
                //--- Initialize Class Properties ---
                //-----------------------------------

            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "TargetsOptimizeData Object CREATED");
                PinchLogger.WriteSeparatorLine('<');
            }
        }
        #endregion      // CTOR

    }
    #endregion      // public class FiguresMgr
}
#endregion      // namespace PinchFigures

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
