#region HEADER
//#####################################################################################################################
//###############################  D e f a u l t P r o j e c t S e t t i n g s . c s  #################################
//#####################################################################################################################
//  FILENAME:  DefaultProjectSettings.cs
//  NAMESPACE: HenGlobal
//  CLASS(S):  DefaultProjectSettings
//  COMPONENT: _HenGLobal.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Default Project Settings Class.
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
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static HenGlobal.HenTypes;
#endregion  // REFERENCES

#region namespace HenGlobal
namespace HenGlobal
{
    #region public class DefaultProjectSettings
    /// <summary>
    /// Default Project Settings Class
    /// </summary>
    public class DefaultProjectSettings
    {
        #region CONSTANTS
        const string NAMESPACE = "HenGlobal";
        const string CLASS = "DefaultProjectSettings";

        #endregion      // CONSTANTS

        #region PROPERTIES
        public HenProjectUnits ExternalAppDefaultUnitsObj { get; set; } // EXTERNAL Application Default Units Object
        public HenProjectUnits ExternalProjectUnitsObj { get; set; }    // EXTERNAL Project Units Object

        public double ProjectExchangerU { get; set; }                   // PROJECT Exchanger Heat Transfer Coefficient (U)
        public HenOptimizer ProjectHenOptimizerEnum { get; set; }       // PROJECT HEN Optimizer Enumeration

        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public DefaultProjectSettings()
        {
            string strMethod = "CTOR";
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating DefaultProjectSettings Object");
            try
            {
                ExternalAppDefaultUnitsObj = new HenProjectUnits();
                ExternalProjectUnitsObj = new HenProjectUnits();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "HenTypes Object CREATED");
                HenLogger.WriteSeparatorLine('<');
            }
        }
        #endregion      // CTOR

    }
    #endregion      // public class DefaultProjectSettings
}
#endregion      // namespace HenGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
