#region HEADER
//#####################################################################################################################
//#########################################  M a n i f e s t D a t a . c s  ###########################################
//#####################################################################################################################
//  FILENAME:  ManifestData.cs
//  NAMESPACE: PinchData
//  CLASS(S):  ManifestData
//  COMPONENT: _PinchData.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Manifest Data class.
//    Manifest Data includes the indivual Hash values for each of the Panel Data objects (e.g., InputData),
//    as well as, an OVerall Hash for the Zip File which conains all data objects.
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
    #region class ManifestData
    public class ManifestData : ABC_XmlFileData
    {
        #region CONSTANTS
        const string NAMESPACE = "PinchData";
        const string CLASS = "ManifestData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        
        #region INPUT PANEL DATA
        public string InputProjectHash { get; set; }
        public string InputStreamsHash { get; set; }
        public string InputUtilitiesHash { get; set; }
        public string InputCostHash { get; set; }
        public string InputExchangerHash { get; set; }
        public string InputValidationHash { get; set; }
        #endregion  // INPUT PANEL DATA

        #region TARGETS PANEL DATA
        public string TargetsCalculateHash { get; set; }
        public string TargetsCompositeHash { get; set; }
        public string TargetsIntervalHash { get; set; }
        public string TargetsOptimizeHash { get; set; }
        #endregion  // TARGETS PANEL DATA

        #region HEN PANEL DATA
        public string HenDesignHash { get; set; }
        #endregion  // HEN PANEL DATA

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public ManifestData() 
        {
            string strMethod = "CTOR";
            PinchLogger.WriteSeparatorLine(' ');
            PinchLogger.WriteSeparatorLine('>');
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating ManifestData Object");
            try
            {
                //----------------------------------------
                //--- Initialize Base Class Properties ---
                //----------------------------------------
                DataHash = string.Empty;                // Overall Hash
                FullPathXmlFileLoc = string.Empty;      // XML File Location
                FullPathZipFileLoc = string.Empty;      // ZIP File Location
                //-----------------------------------------------
                //--- Initialize Managed Data Hash Properties ---
                //-----------------------------------------------
                InputProjectHash = string.Empty;
                InputStreamsHash = string.Empty;
                InputUtilitiesHash = string.Empty;
                InputCostHash = string.Empty;
                InputExchangerHash = string.Empty;
                InputValidationHash = string.Empty;

                TargetsCalculateHash = string.Empty;
                TargetsCompositeHash = string.Empty;
                TargetsIntervalHash = string.Empty;
                TargetsOptimizeHash = string.Empty;

                HenDesignHash = string.Empty;
            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "ManifestData Object CREATED");
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
    #endregion  // class ManifestData
}
#endregion  // namespace PinchData

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================

