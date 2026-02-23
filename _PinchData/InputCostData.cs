#region HEADER
//#####################################################################################################################
//########################################  I n p u t C o s t D a t a . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  InputCostData.cs
//  NAMESPACE: PinchData
//  CLASS(S):  InputCostData
//  COMPONENT: _PinchData.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Input Cost Data class.
//    This class contains all the data associated with the INPUT Cost Panel
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
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using PinchGlobal;
#endregion  // REFERENCES

#region namespace PinchData
namespace PinchData
{
    #region class InputCostData
    /// <summary>
    /// This class contains all the data associated with the INPUT Cost Panel
    /// </summary>
    public class InputCostData : ABC_JsonFileData
    {
        #region CONSTANTS
        const string NAMESPACE = "PinchData";
        const string CLASS = "InputCostData";
        #endregion      // CONSTANTS

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>        
        public InputCostData()
        {
            string strMethod = "CTOR";
            PinchLogger.WriteSeparatorLine('>');
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating InputCostData Object");
            try
            {
                //----------------------------------------
                //--- Initialize Base Class Properties ---
                //----------------------------------------
                DataHash = string.Empty;                // Input Project Data Hash
                FullPathJsonFileLoc = string.Empty;     // JSON File Location
                FullPathZipFileLoc = string.Empty;      // ZIP File Location
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
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "InputCostData Object CREATED");
                PinchLogger.WriteSeparatorLine('<');
            }
        }
        #endregion  // CTOR

        #region ABSTRACT METHOD IMPLEMENTATIONS

        #region override void CreateHash()
        /// <summary>
        /// Override the Abstract Base Class Method
        /// </summary>
        public override void CreateHash()
        {
            string strMethod = "CreateHash";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating Hash");
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
            }
        }
        #endregion  // override void CreateHash()

        #region override void InitializeData()
        /// <summary>
        /// Override the Abstract Base Class Method
        /// </summary>
        public override void InitializeData()
        {
            string strMethod = "InitializeData";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Initialize Data");
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
            }
        }
        #endregion  // override void InitializeData()

        #region override void LogData()
        /// <summary>
        /// Override the Abstract Base Class Method
        /// </summary>
        public override void LogData()
        {
            string strMethod = "LogData";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Log Data");
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
            }
        }
        #endregion  // override void LogData()

        #region override void PersistData()
        /// <summary>
        /// Override the Abstract Base Class Method
        /// </summary>
        public override void PersistData()
        {
            string strMethod = "PersistData";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Persist Data");
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
            }
        }
        #endregion  // override void PersistData()

        #region override void RestoreData()
        /// <summary>
        /// Override the Abstract Base Class Method
        /// </summary>
        public override void RestoreData()
        {
            string strMethod = "RestoreData";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Restore Data");
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
            }
        }
        #endregion  // override void RestoreData()

        #endregion  // ABSTRACT METHOD IMPLEMENTATIONS

    }
    #endregion  // class InputCostData
}
#endregion  // namespace PinchData

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================

