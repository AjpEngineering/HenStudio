#region HEADER
//#####################################################################################################################
//############################################  H e n E n g i n e . c s  ##############################################
//#####################################################################################################################
//  FILENAME:  HenEngine.cs
//  NAMESPACE: PinchHen
//  CLASS(S):  HenEngine
//  COMPONENT: _PinchHen.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the HEN Engine class.
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

#region namespace PinchHen
namespace PinchHen
{
    #region public class HenEngine
    /// <summary>
    /// HEN Engine Class
    /// </summary>
    public class HenEngine
    {
        #region CONSTANTS
        const string NAMESPACE = "PinchHen";
        const string CLASS = "HenEngine";
        #endregion      // CONSTANTS

        #region PROPERTIES

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public HenEngine()
        {
            string strMethod = "CTOR";
            PinchLogger.WriteSeparatorLine(' ');
            PinchLogger.WriteSeparatorLine('>');
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating HenEngine Object");
            try
            {

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
    #endregion      // public class HenEngine
}
#endregion      // namespace PinchHen

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
