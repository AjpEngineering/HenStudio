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
    public class ManifestData : ABC_JsonFileData
    {
        #region CONSTANTS
        const string NAMESPACE = "PinchData";
        const string CLASS = "ManifestData";
        #endregion      // CONSTANTS

        #region PROPERTIES

        #region DATA MANAGERS
        public InputDataMgr InputDataMgrObj { get; set; }
        public TargetsDataMgr TargetsDataMgrObj { get; set; }
        public HenDataMgr HenDataMgrObj { get; set; }
        #endregion  // DATA MANAGERS

        #region INPUT PANEL DATA
        public string InputProjectHash { get; set; }
        public string InputStreamsHash { get; set; }
        public string InputCostHash { get; set; }
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
        public string HenExchangerHash { get; set; }
        #endregion  // HEN PANEL DATA

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Parameterize Constructor
        /// Parameters include the InputDataMgr, TargetsDataMgr and HenDataMgr objects.
        /// These manager objects contain ALL the Panel Data objects.
        /// </summary>
        /// <param name="inputDataMgrObj">Input Data Manager Object</param>
        /// <param name="targetsDataMgrObj">Targets Data Manager Object</param>
        /// <param name="henDataMgrObj">Hen Data Manager Object</param>
        public ManifestData(InputDataMgr inputDataMgrObj,
                            TargetsDataMgr targetsDataMgrObj,
                            HenDataMgr henDataMgrObj) 
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
                FullPathJsonFileLoc = string.Empty;     // JSON File Location
                FullPathZipFileLoc = string.Empty;      // ZIP File Location
                //--------------------------------------
                //--- Assign Data Manager Properties ---
                //--------------------------------------
                InputDataMgrObj = inputDataMgrObj;
                TargetsDataMgrObj = targetsDataMgrObj;
                HenDataMgrObj = henDataMgrObj;
                //-----------------------------------------------
                //--- Initialize Managed Data Hash Properties ---
                //-----------------------------------------------
                InputProjectHash = string.Empty;
                InputStreamsHash = string.Empty;
                InputCostHash = string.Empty;
                InputValidationHash = string.Empty;

                TargetsCalculateHash = string.Empty;
                TargetsCompositeHash = string.Empty;
                TargetsIntervalHash = string.Empty;
                TargetsOptimizeHash = string.Empty;

                HenDesignHash = string.Empty;
                HenExchangerHash = string.Empty;

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
                #region GET PANEL DATA HASH VALUES
                //-------------------------------------- INPUT PROJECT DATA ---
                InputDataMgrObj.InputProjectDataObj.CreateHash();
                InputProjectHash = InputDataMgrObj.InputProjectDataObj.DataHash;
                //-------------------------------------- INPUT STREAMS DATA ---
                InputDataMgrObj.InputStreamsDataObj.CreateHash();
                InputStreamsHash = InputDataMgrObj.InputStreamsDataObj.DataHash;
                //----------------------------------------- INPUT COST DATA ---
                InputDataMgrObj.InputCostDataObj.CreateHash();
                InputCostHash = InputDataMgrObj.InputCostDataObj.DataHash;
                //----------------------------------- INPUT VALIDATION DATA ---
                InputDataMgrObj.InputValidationDataObj.CreateHash();
                InputValidationHash = InputDataMgrObj.InputValidationDataObj.DataHash;
                //---------------------------------- TARGETS CALCULATE DATA ---
                TargetsDataMgrObj.TargetsCalculateDataObj.CreateHash();
                TargetsCalculateHash = TargetsDataMgrObj.TargetsCalculateDataObj.DataHash;
                //---------------------------------- TARGETS COMPOSITE DATA ---
                TargetsDataMgrObj.TargetsCompositeDataObj.CreateHash();
                TargetsCompositeHash = TargetsDataMgrObj.TargetsCompositeDataObj.DataHash;
                //----------------------------------- TARGETS INTERVAL DATA ---
                TargetsDataMgrObj.TargetsIntervalDataObj.CreateHash();
                TargetsIntervalHash = TargetsDataMgrObj.TargetsIntervalDataObj.DataHash;
                //----------------------------------- TARGETS OPTIMIZE DATA ---
                TargetsDataMgrObj.TargetsOptimizeDataObj.CreateHash();
                TargetsOptimizeHash = TargetsDataMgrObj.TargetsOptimizeDataObj.DataHash;
                //----------------------------------------- HEN DESIGN DATA ---
                HenDataMgrObj.HenDesignDataObj.CreateHash();
                HenDesignHash = HenDataMgrObj.HenDesignDataObj.DataHash;
                //-------------------------------------- HEN EXCHANGER DATA ---
                HenDataMgrObj.HenExchangerDataObj.CreateHash();
                HenExchangerHash = HenDataMgrObj.HenExchangerDataObj.DataHash;
                #endregion  // GET PANEL DATA HASH VALUES

                #region GET OVERALL ZIP HASH
                //DataHash = "TBD";
                #endregion  // GET OVERALL ZIP HASH

            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Hash Values CREATED");
                LogData();  // Log All Hash Values
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
            string strMsg = string.Empty;
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Log Data");
            try
            {
                strMsg = new string('=', 80);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("{0} H A S H   V A L U E S {1}", 
                                       new string('-', 29),
                                       new string('-', 28) );
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = new string('=', 80);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("   INPUT PROJECT HASH     : {0}", InputProjectHash);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("   INPUT STREAMS HASH     : {0}", InputStreamsHash);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("   INPUT COST HASH        : {0}", InputCostHash);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("   INPUT VALIDATION HASH  : {0}", InputValidationHash);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("   TARGETS CALCULATE HASH : {0}", TargetsCalculateHash);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("   TARGETS COMPOSITE HASH : {0}", TargetsCompositeHash);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("   TARGETS INTERVAL HASH  : {0}", TargetsIntervalHash);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("   TARGETS OPTIMIZE HASH  : {0}", TargetsOptimizeHash);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("   HEN DESIGN HASH        : {0}", HenDesignHash);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("   HEN EXCHANGER HASH     : {0}", HenExchangerHash);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                PinchLogger.WriteSeparatorLine('=');

                strMsg = string.Format("   OVERALL ZIP HASH       : {0}", DataHash);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = new string('=', 80);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

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

        #region Zip()
        /// <summary>
        /// Zip all xml files, under root Project Folder, into a single Zip file
        /// </summary>
        /// <param name="strRootFolderLoc"></param>
        /// <param name="strZipTargetLoc"></param>
        public void Zip(string strRootFolderLoc, string strZipTargetLoc)
        {
            string strMethod = "Zip";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Zip Root Folder");
            try
            {
                //---------------------
                //--- Get Hash Data ---
                //---------------------
                CreateHash();   // Get all Panel Data Hash values and Overall Hash
            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Root Folder ZIPPED");
                PinchLogger.WriteSeparatorLine('<');
            }
        }
        #endregion  // Zip()

        #region Extract()
        /// <summary>
        /// Extract Zip file to root Project Folder,  
        /// all Sub-Folder Structure including XML files under root
        /// </summary>
        /// <param name="strRootFolderLoc"></param>
        /// <param name="strZipTargetLoc"></param>
        public void Extract(string strRootFolderLoc, string strZipTargetLoc)
        {
            string strMethod = "Extract";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Extract to Root Folder");
            try
            {
                //---------------
                //--- EXTRACT ---
                //---------------
                //TBD
            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Zip File EXTRACTED");
                PinchLogger.WriteSeparatorLine('<');
            }
        }
        #endregion  // Zip()

    }
    #endregion  // class ManifestData
}
#endregion  // namespace PinchData

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================

