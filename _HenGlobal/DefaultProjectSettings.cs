#region HEADER
//#####################################################################################################################
//###############################  D e f a u l t P r o j e c t S e t t i n g s . c s  #################################
//#####################################################################################################################
//  FILENAME:  DefaultProjectSettings.cs
//  NAMESPACE: HenGlobal
//  CLASS(S):  DefaultProjectSettings
//  COMPONENT: _HenGlobal.dll
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

using HenModel.Dto;
using HenModel.Dto.Hen;
using HenModel.Dto.Pinch;
using HenModel.Dto.Profile;

using HenModel.Dto.Project;
using HenModel.Dto.Project.CostParameters;
using HenModel.Dto.Project.DefaultParameters;
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

using HenModel.Dto.System;
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

        #region enum Optimizer
        /// <summary>
        /// ENUMERATION: AJP HEN Studio Optimizer [ UNKNOWN | GENETIC | GREEDY | MILP ]
        /// </summary>
        public enum Optimizer
        {
            UNKNOWN = -1,   // UNKNOWN Optimizer
            GENETIC = 0,    // GENETIC Optimizer
            GREEDY = 1,     // GREEDY Optimizer
            MILP = 2        // Mixed-Integer Linear Program Optimizer
        };
        #endregion      // enum Optimizer

        #region PROPERTIES
        public Guid NewProjectGUID { get; set; } // New Project GUID
        public string NewProjectName { get; set; } // New Project Name
        public string NewProjectDescription { get; set; } // New Project Description

        public HenProjectUnits ExternalUnitsObj { get; set; } // EXTERNAL Units Object

        public double ProjectExchangerU { get; set; }      // PROJECT Exchanger Heat Transfer Coefficient (U)
        public Optimizer OptimizerEnum { get; set; }       // PROJECT Optimizer Enumeration

        #endregion  // PROPERTIES

        #region DEFAULT CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public DefaultProjectSettings()
        {
            string strMethod = "CTOR";
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating DefaultProjectSettings Object");
            try
            {
                NewProjectGUID = new Guid();
                NewProjectName = "Enter Project Name";
                NewProjectDescription = "Enter Project Description";
                ExternalUnitsObj = new HenProjectUnits();
                ProjectExchangerU = 74.0;
                OptimizerEnum = Optimizer.GENETIC;
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
        }
        #endregion      // DEFAULT CTOR

        #region PARAMETERIZED CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public DefaultProjectSettings(ProjectDto projectDtoObj, ExchangerParamsDto exchangerParamsDtoObj)
        {
            string strMethod = "CTOR";
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating DefaultProjectSettings Object");
            try
            {
                NewProjectGUID = projectDtoObj.Id;
                NewProjectName = projectDtoObj.Name;
                NewProjectDescription = projectDtoObj.Description;
                ProjectExchangerU = exchangerParamsDtoObj.DefaultHeatTransferCoefficient;
                OptimizerEnum = GetOptimizerEnum(projectDtoObj.DefaultOptimizer);
                
                ExternalUnitsObj = new HenProjectUnits();




                //ExternalUnitsObj.ProjectSystemUnitsEnum = GetHenProjectUnitsEnum(projectDtoObj.DefaultSystemUnits);

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
        }
        #endregion      // PARAMETERIZED CTOR

        #region GetOptimizerList()
        /// <summary>
        /// Get the List of Stings used for the HEN Optimizer List Combo Box Dropdowns
        /// </summary>
        /// <returns>List of Optimizer strings for Combo Box</returns>
        public List<string> GetOptimizerList()
        {
            List<string> lst = new List<string>();

            lst.Clear();
            lst.Add(GENETIC);
            lst.Add(GREEDY);
            lst.Add(MILP);
            return lst;
        }
        #endregion  // GetOptimizerList()

        #region GetOptimizerString()
        /// <summary>
        /// Get Hen Optimizer String
        /// </summary>
        /// <returns>Optimizer String</returns>
        public string GetOptimizerString()
        {
            string strMethod = "GetHenOptimizerString";
            string strUnitsString = String.Empty;
            try
            {
                #region GENETIC
                if (OptimizerEnum == Optimizer.GENETIC)
                {
                    strUnitsString = GENETIC;
                }
                #endregion  // GENETIC

                #region GREEDY
                else if (OptimizerEnum == Optimizer.GREEDY)
                {
                    strUnitsString = GREEDY;
                }
                #endregion  // GREEDY

                #region MILP
                else if (OptimizerEnum == Optimizer.MILP)
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
        #endregion  // GetOptimizerString()

        #region GetOptimizerEnum()
        /// <summary>
        /// Get the Optimizer Enum Given Optimizer String
        /// </summary>
        /// <param name="strOptimizer">Optimizer String</param>
        /// <returns>Optimizer Enum value</returns>
        public Optimizer GetOptimizerEnum(string strOptimizer)
        {
            string strMethod = "GetOptimizerEnum";
            Optimizer optimizerEnum = Optimizer.UNKNOWN;
            try
            {
                if (string.Compare(strOptimizer, GENETIC, true) == 0) optimizerEnum = Optimizer.GENETIC;
                else if (string.Compare(strOptimizer, GREEDY, true) == 0) optimizerEnum = Optimizer.GREEDY;
                else if (string.Compare(strOptimizer, MILP, true) == 0) optimizerEnum = Optimizer.MILP;
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
            return optimizerEnum;
        }
        #endregion  // GetOptimizerEnum()

    }
    #endregion      // public class DefaultProjectSettings
}
#endregion      // namespace HenGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
