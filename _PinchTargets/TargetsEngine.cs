#region HEADER
//#####################################################################################################################
//########################################  T a r g e t s E n g i n e . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  TargetsEngine.cs
//  NAMESPACE: PinchTargets
//  CLASS(S):  TargetsEngine
//  COMPONENT: _PinchTargets.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Targets Engine class.
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
using HenGlobal;

using System;
#endregion  // REFERENCES

#region namespace PinchTargets
namespace PinchTargets
{
    #region class TargetsEngine
    /// <summary>
    /// Targets Engine Class
    /// </summary>
    public class TargetsEngine
    {
        #region CONSTANTS
        const string NAMESPACE = "PinchTargets";
        const string CLASS = "TargetsEngine";
        #endregion      // CONSTANTS

        #region PROPERTIES

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public TargetsEngine() 
        {
            string strMethod = "CTOR";
            HenLogger.WriteSeparatorLine(' ');
            HenLogger.WriteSeparatorLine('>');
            HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating TargetsEngine Object");
            try
            {

            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "TargetsDataMgr Object CREATED");
                HenLogger.WriteSeparatorLine('<');
            }
        }
        #endregion  // class CTOR
    }
    #endregion  // class TargetsEngine
}
#endregion      // namespace PinchTargets

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
