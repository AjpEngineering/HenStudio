#region HEADER
//#####################################################################################################################
//########################################  H e n D e s i g n D a t a . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  HenDesignData.cs
//  NAMESPACE: PinchData
//  CLASS(S):  HenDesignData
//  COMPONENT: _PinchData.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the HEN Design Data class.
//    This class contains all the data associated with the HEN Design Panel
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
    #region class HenDesignData
    /// <summary>
    /// This class contains all the data associated with the HEN Design Panel
    /// </summary>
    public class HenDesignData : ABC_XmlFileData
    {
        #region CONSTANTS
        const string NAMESPACE = "PinchData";
        const string CLASS = "HenDesignData";
        #endregion      // CONSTANTS

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>        
        public HenDesignData()
        {
            string strMethod = "CTOR";
            PinchLogger.WriteSeparatorLine('>');
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating HenDesignData Object");
            try
            {
                //----------------------------------------
                //--- Initialize Base Class Properties ---
                //----------------------------------------
                DataHash = string.Empty;                // Input Project Data Hash
                FullPathXmlFileLoc = string.Empty;      // XML File Location
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
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "HenDesignData Object CREATED");
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

