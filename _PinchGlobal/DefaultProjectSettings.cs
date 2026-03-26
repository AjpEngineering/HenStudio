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

using static HenGlobal.DefaultProjectSettings;
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

        #region HEN OPTIMIZERS
        public const string GENETIC = "Genetic";    // Genetic HEN Optimizer
        public const string GREEDY = "Greedy";      // Greedy HEN Optimizer
        public const string MILP = "MILP";          // Mixed-Integer Linear Program
        #endregion  // HEN OPTIMIZERS

        #endregion      // CONSTANTS

        #region enum HenOptimizer
        /// <summary>
        /// ENUMERATION: AJP HEN Studio Optimizer [ UNKNOWN | GENETIC | GREEDY | MILP ]
        /// </summary>
        public enum HenOptimizer
        {
            UNKNOWN = -1,   // UNKNOWN Optimizer
            GENETIC = 0,    // GENETIC Optimizer
            GREEDY = 1,     // GREEDY Optimizer
            MILP = 2        // Mixed-Integer Linear Program Optimizer
        };
        #endregion      // enum HenOptimizer

        #region PROPERTIES
        public string NewProjectName { get; set; } // New Project Name
        public string NewProjectDescription { get; set; } // New Project Description

        public HenProjectUnits ExternalUnitsObj { get; set; } // EXTERNAL Units Object

        public double ProjectExchangerU { get; set; }                   // PROJECT Exchanger Heat Transfer Coefficient (U)
        public HenOptimizer HenOptimizerEnum { get; set; }       // PROJECT HEN Optimizer Enumeration

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
                NewProjectName = "Enter Project Name";
                NewProjectDescription = "Enter Project Descripiton";
                ExternalUnitsObj = new HenProjectUnits();
                ProjectExchangerU = 74.0;
                HenOptimizerEnum = HenOptimizer.GENETIC;
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

        #region GetHenOptimizerList()
        /// <summary>
        /// Get the List of Stings used for the HEN Optimizer List Combo Box Dropdowns
        /// </summary>
        /// <returns>List of HEN Optimizer strings for Combo Box</returns>
        public List<string> GetHenOptimizerList()
        {
            List<string> lst = new List<string>();

            lst.Clear();
            lst.Add(GENETIC);
            lst.Add(GREEDY);
            lst.Add(MILP);
            return lst;
        }
        #endregion  // GetHenOptimizerList()

        #region GetHenOptimizerString()
        /// <summary>
        /// Get Hen Optimizer String
        /// </summary>
        /// <returns>Hen Optimizer String</returns>
        public string GetHenOptimizerString()
        {
            string strMethod = "GetHenOptimizerString";
            string strUnitsString = String.Empty;
            try
            {
                #region GENETIC
                if (HenOptimizerEnum == HenOptimizer.GENETIC)
                {
                    strUnitsString = GENETIC;
                }
                #endregion  // GENETIC

                #region GREEDY
                else if (HenOptimizerEnum == HenOptimizer.GREEDY)
                {
                    strUnitsString = GREEDY;
                }
                #endregion  // GREEDY

                #region MILP
                else if (HenOptimizerEnum == HenOptimizer.MILP)
                {
                    strUnitsString = MILP;
                }
                #endregion  // MILP

                #region UNKNOWN
                else
                {
                    strUnitsString = "???";
                }
                #endregion  // UNKNOWN

            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
            return strUnitsString;
        }
        #endregion  // GetHenOptimizerString()

    }
    #endregion      // public class DefaultProjectSettings
}
#endregion      // namespace HenGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
