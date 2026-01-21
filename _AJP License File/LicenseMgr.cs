#region HEADER
//######################################################################################################
//####################################  L i c e n s e M g r . c s  #####################################
//######################################################################################################
//  FILENAME:  LicenseMgr.cs
//  NAMESPACE: _AJP_License_File
//  CLASS(S):  LicenseMgr
//  COMPONENT: AJP License File.exe
//======================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the LicenseMgr class.
//    This class manages the data functionality of AJP License Manager.
//======================================================================================================
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
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using PinchGlobal;      // Need for PinchFileSystem Object ... XML Full-Path Location
#endregion      // REFERENCES

#region namespace AJP_License_File
namespace AJP_License_File
{
    #region class LicenseMgr
    /// <summary>
    /// AJP License Manager Class
    /// </summary>
    public class LicenseMgr
    {
        #region CONSTANTS
        private const String NAMESPACE = "_AJP_License_File";
        private const String CLASS = "LicenseMgr";

        private const int START_INDEX = 30;     // Start Index of Substring ... must be less than 32

        private const string AJP_LICENSE_FOLDER = "LICENSE";        // LICENSE FOLDER NAME
        private const string AJP_LICENSE_FILE   = "License.xml";    // LICENSE FILE NAME

        #endregion      // CONSTANTS

        #region FIELDS
        private string _strFullPathFilenameXML;         // Full Path File Name to Persist and Restore XML File
        private LicenseFileData _licenseFileDataObj;    // License File Data object
        #endregion      // FIELDS

        #region PROPERTIES

        #region FullPathFilenameXML
        /// <summary>
        /// Full Path Filename for XML File Property
        /// </summary>
        public string FullPathFilenameXML
        {
            get { return _strFullPathFilenameXML; }
            set { _strFullPathFilenameXML = value; }
        }
        #endregion      // FullPathFilenameXML

        #region LicenseFileDataObj
        /// <summary>
        /// LicenseFileDataObj Property  ...  License File Data object
        /// </summary>
        public LicenseFileData LicenseFileDataObj
        {
            get { return _licenseFileDataObj; }
            set { _licenseFileDataObj = value; }
        }
        #endregion      // LicenseFileDataObj

        #endregion      // PROPERTIES

        #region CTOR: LicenseMgr
        /// <summary>
        /// Parameterized Constructor
        /// Pass in Full-Path Licence File Location ... different for Pinch.exe and AJP_LicenseGenerator.exe
        /// </summary>
        /// <param name="strFullPathLicenceFileLoc">Full-Path Licence File Location</param>
        public LicenseMgr(string strFullPathLicenceFileLoc)
        {
            string strMethod = "CTOR: LicenseMgr";
            string strMsg = String.Empty;
            try
            {
                //-----------------------------
                //--- Initialize Properties ---
                //-----------------------------
                FullPathFilenameXML = strFullPathLicenceFileLoc;    // Assign Full-Path License File Location
                LicenseFileDataObj = new LicenseFileData();         // Create License File Data Object
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
        }
        #endregion      // CTOR: LicenseMgr

        //=============================================================================================================
        //------------------------------------------- CHECK LICENSE METHOD --------------------------------------------
        //=============================================================================================================

        #region IsValidLicense
        /// <summary>
        /// Check the User Name (USER & SEAT License Types), Device Name (SEAT License Types) and
        /// AJP License Key, and AJP License File Hash values (All License Types)
        /// </summary>
        /// <param name="strFullPathAppStartupLoc">Full-Path Folder Location of App</param>
        /// <returns>true for Valid License; false otherwise</returns>
        public bool IsValidLicense(string strFullPathAppStartupLoc)
        {
            string strMethod = "IsValidLicense";
            string strMsg = string.Empty;
            string strLicenseFolder = string.Empty;
            string strLicenseFile = string.Empty;

            string strCalcKeyVal = string.Empty;
            string strCalcHashVal = string.Empty;

            bool bUsernameMatch = false;
            bool bDeviceMatch = false;
            bool bValidLicenseKey = false;
            bool bValidLicenseHash = false;
            bool bInValidLicenseDateRange = false;
            DateTime dateTimeNow = DateTime.Now;   // Current Date

            bool bValidLicense = true;
            try
            {
                #region CHECK IF LICENSE XML FILE EXISTS

                #region FOLDER
                //------------------------------------------
                //--- Check if AJP License Folder Exists ---
                //------------------------------------------
                strLicenseFolder = string.Format(@"{0}\{1}", strFullPathAppStartupLoc, AJP_LICENSE_FOLDER);
                if (!Directory.Exists(strLicenseFolder))
                {
                    strMsg = string.Format(" *** AJP LICENSE Folder NOT FOUND!  [{0}]", strLicenseFolder);
                    throw (new Exception(strMsg));
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" AJP LICENSE FOLDER FOUND!");
                #endregion      // FOLDER

                #region FILE
                //---------------------------------------
                //--- Check if AJP License File Exists ---
                //----------------------------------------
                strLicenseFile = string.Format(@"{0}\{1}", strLicenseFolder, AJP_LICENSE_FILE);
                if (!File.Exists(strLicenseFile))
                {
                    strMsg = string.Format(" *** AJP LICENSE File NOT FOUND!  [{0}]", strLicenseFile);
                    throw (new Exception(strMsg));
                }
                Console.WriteLine(" AJP LICENSE FILE FOUND!");
                #endregion      // FILE

                #region LOG TO CONSOLE: FULL-PATH AJP LICENSE XML FILE LOCATION
                strMsg = string.Format(" ===> AJP LICENSE File:  [{0}]", strLicenseFile);
                Console.WriteLine(strMsg);
                #endregion      // LOG TO CONSOLE: FULL-PATH AJP LICENSE XML FILE LOCATION

                #endregion      // CHECK IF LICENSE XML FILE EXISTS

                #region READ LICENSE FILE                
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=  READ LICENSE FILE  -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

                //-----------------------------------------------------------
                //--- Read the License File from the AJP License XML File ---
                //-----------------------------------------------------------
                LicenseFileDataObj.RestoreLicenseXmlFile(strLicenseFile);

                #endregion      // USER NAME

                #region USER NAME
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=  USER NAME  -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

                //-------------------------------------------------------------------------------------------------
                //--- IF USER or SEAT License Type THEN Check File User Name with User Name for Running the App ---
                //-------------------------------------------------------------------------------------------------
                if ((String.Compare(LicenseFileDataObj.LicenseType, LicenseFileData.USER) == 0) ||
                    (String.Compare(LicenseFileDataObj.LicenseType, LicenseFileData.SEAT) == 0))
                {
                    bUsernameMatch = string.Compare(LicenseFileDataObj.UserName, 
                                                    LicenseFileDataObj.CurrUserName, true) == 0;
                }
                else
                {
                    bUsernameMatch = true;  // NOT CHECKED ... set to TRUE
                }

                #region LOG USER NAME VALIDATION RESULTS TO CONSOLE 
                if (bUsernameMatch)
                {
                    strMsg = " === VALID USER NAME ENCOUNTED === ";
                    Console.WriteLine(" ");
                    Console.WriteLine(" ================================= ");
                    Console.WriteLine(" === VALID USER NAME ENCOUNTED === ");
                    Console.WriteLine(" ================================= ");
                    Console.WriteLine(" ");
                }
                else
                {
                    strMsg = " *** INVALID USER NAME ENCOUNTED *** ";
                    Console.WriteLine(" ");
                    Console.WriteLine(" *********************************** ");
                    Console.WriteLine(" *** INVALID USER NAME ENCOUNTED *** ");
                    Console.WriteLine(" *********************************** ");
                    Console.WriteLine(" ");

                    MessageBox.Show(strMsg, "LICENSE FILE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    #region ***** TEST ONLY ... LOG TO CONSOLE CURRENT USER NAME   *** REMOVE ON RELEASE *** ****
                    //***********************************  T E S T  *************************************
                    //strMsg = string.Format("=== CURRENT USER NAME: {0} === ", LicenseFileDataObj.CurrUserName);
                    //Console.WriteLine(" ");
                    //Console.WriteLine(" ================================================================ ");
                    //Console.WriteLine(strMsg);
                    //Console.WriteLine(" ================================================================ ");
                    //Console.WriteLine(" ");
                    //***********************************  T E S T  *************************************
                    #endregion      // TEST ONLY ... LOG TO CONSOLE CURRENT USER NAME

                }
                #endregion      // LOG USER NAME VALIDATION RESULTS TO CONSOLE 

                #endregion      // USER NAME

                #region DEVICE NAME
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-  DEVICE NAME  -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

                //---------------------------------------------------------------------------------------------
                //--- IF SEAT License Type THEN Check File Device Name with Device Name for Running the App ---
                //---------------------------------------------------------------------------------------------
                if (String.Compare(LicenseFileDataObj.LicenseType, LicenseFileData.SEAT) == 0)
                {
                    bDeviceMatch = string.Compare(LicenseFileDataObj.DeviceName, 
                                                  LicenseFileDataObj.CurrDeviceName, true) == 0;
                }
                else
                {
                    bDeviceMatch = true;   // NOT CHECKED ... set to TRUE   
                }

                #region LOG DEVICE NAME VALIDATION RESULTS TO CONSOLE 
                if (bDeviceMatch)
                {
                    strMsg = " === VALID DEVICE NAME ENCOUNTED === ";
                    Console.WriteLine(" ");
                    Console.WriteLine(" =================================== ");
                    Console.WriteLine(" === VALID DEVICE NAME ENCOUNTED === ");
                    Console.WriteLine(" =================================== ");
                    Console.WriteLine(" ");
                }
                else
                {
                    strMsg = " *** INVALID DEVICE NAME ENCOUNTED *** ";
                    Console.WriteLine(" ");
                    Console.WriteLine(" ************************************* ");
                    Console.WriteLine(" *** INVALID DEVICE NAME ENCOUNTED *** ");
                    Console.WriteLine(" ************************************* ");
                    Console.WriteLine(" ");

                    MessageBox.Show(strMsg, "LICENSE FILE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    #region ***** TEST ONLY ... LOG TO CONSOLE CURRENT DEVICE NAME   *** REMOVE ON RELEASE *** ****
                    //***********************************  T E S T  *************************************
                    //strMsg = string.Format("=== CURRENT DEVICE NAME: {0} === ", LicenseFileDataObj.CurrDeviceName);
                    //Console.WriteLine(" ");
                    //Console.WriteLine(" ================================================================ ");
                    //Console.WriteLine(strMsg);
                    //Console.WriteLine(" ================================================================ ");
                    //Console.WriteLine(" ");
                    //***********************************  T E S T  *************************************
                    #endregion      // TEST ONLY ... LOG TO CONSOLE CURRENT DEVICE NAME
                }
                #endregion      // LOG DEVICE NAME VALIDATION RESULTS TO CONSOLE 

                #endregion      // DEVICE NAME

                #region LICENSE KEY
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-  LICENSE KEY  -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

                //---------------------------------
                //--- Calculate the License Key ---
                //---------------------------------
                strCalcKeyVal = CalculateLicenseKey();

                #region ***** TEST ONLY ... LOG TO CONSOLE CALCULATED LICENSE KEY   *** REMOVE ON RELEASE *** ****
                //***********************************  T E S T  *************************************
                //strMsg = string.Format("=== CALCULATED LICENSE KEY: {0} === ", strCalcKeyVal);
                //Console.WriteLine(" ");
                //Console.WriteLine(" ================================================================ ");
                //Console.WriteLine(strMsg);
                //Console.WriteLine(" ================================================================ ");
                //Console.WriteLine(" ");
                //***********************************  T E S T  *************************************
                #endregion      // TEST ONLY ... LOG TO CONSOLE CALCULATED LICENSE KEY

                //--------------------------------------------------------------------
                //--- Compare the File License Key with the Calculated License Key ---
                //--------------------------------------------------------------------
                bValidLicenseKey = string.Compare(LicenseFileDataObj.FileLicenseKey,
                                                  strCalcKeyVal, true) == 0;

                #region LOG KEY VALIDATION RESULTS TO CONSOLE 
                if (bValidLicenseKey)
                {
                    strMsg = " === VALID AJP LICENSE KEY ENCOUNTED === ";
                    Console.WriteLine(" ");
                    Console.WriteLine(" ======================================= ");
                    Console.WriteLine(" === VALID AJP LICENSE KEY ENCOUNTED === ");
                    Console.WriteLine(" ======================================= ");
                    Console.WriteLine(" ");
                }
                else
                {
                    strMsg = " *** INVALID AJP LICENSE KEY ENCOUNTED *** ";
                    Console.WriteLine(" ");
                    Console.WriteLine(" ***************************************** ");
                    Console.WriteLine(" *** INVALID AJP LICENSE KEY ENCOUNTED *** ");
                    Console.WriteLine(" ***************************************** ");
                    Console.WriteLine(" ");
                }
                #endregion      // LOG KEY VALIDATION RESULTS TO CONSOLE 

                #endregion      // LICENSE KEY

                #region LICENSE HASH
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-  LICENSE HASH -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

                //------------------------------
                //--- Calculate License Hash ---
                //------------------------------
                strCalcHashVal = CalculateLicenseFileHash(strCalcKeyVal);

                #region ***** TEST ONLY ... LOG TO CONSOLE CALCULATED LICENSE HASH   *** REMOVE ON RELEASE *** *****
                //***********************************  T E S T  *************************************
                //strMsg = string.Format("=== CALCULATED LICENSE HASH: {0} === ", strCalcHashVal);
                //Console.WriteLine(" ");
                //Console.WriteLine(" ================================================================ ");
                //Console.WriteLine(strMsg);
                //Console.WriteLine(" ================================================================ ");
                //Console.WriteLine(" ");
                //***********************************  T E S T  *************************************
                #endregion      // TEST ONLY ... LOG TO CONSOLE CALCULATED LICENSE HASH

                //----------------------------------------------------------------------
                //--- Compare the File License Hash with the Calculated License Hash ---
                //----------------------------------------------------------------------
                bValidLicenseHash = string.Compare(LicenseFileDataObj.FileHash,
                                                   strCalcHashVal, true) == 0;

                #region LOG HASH VALIDATION RESULTS TO CONSOLE 
                if (bValidLicenseHash)
                {
                    strMsg = " === VALID AJP LICENSE HASH ENCOUNTED === ";
                    Console.WriteLine(" ");
                    Console.WriteLine(" ======================================== ");
                    Console.WriteLine(" === VALID AJP LICENSE HASH ENCOUNTED === ");
                    Console.WriteLine(" ======================================== ");
                    Console.WriteLine(" ");
                }
                else
                {
                    strMsg = " *** INVALID AJP LICENSE HASH ENCOUNTED *** ";
                    Console.WriteLine(" ");
                    Console.WriteLine(" ****************************************** ");
                    Console.WriteLine(" *** INVALID AJP LICENSE HASH ENCOUNTED *** ");
                    Console.WriteLine(" ****************************************** ");
                    Console.WriteLine(" ");
                }
                #endregion      // LOG HASH VALIDATION RESULTS TO CONSOLE 

                #endregion      // LICENSE HASH

                #region EXPIRATION TEST
                if ((DateTime.Compare(dateTimeNow, LicenseFileDataObj.StartDate) < 0) ||
                    (DateTime.Compare(dateTimeNow, LicenseFileDataObj.EndDate) > 0))
                {
                    //--------------------------------------------------------------------
                    //--- Current Date is Outside the Valid Range [StartDate, EndDate] ---
                    //--------------------------------------------------------------------
                    bInValidLicenseDateRange = false;
                }
                else
                {
                    //-------------------------------------------------------------------
                    //--- Current Date is Within the Valid Range [StartDate, EndDate] ---
                    //-------------------------------------------------------------------
                    bInValidLicenseDateRange = true;
                }
                #endregion      // EXPIRATION TEST

                #region OVERALL STATUS
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=  OVERALL STATUS -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

                bValidLicense = (bUsernameMatch &&
                                 bDeviceMatch &&
                                 bValidLicenseKey &&
                                 bValidLicenseHash &&
                                 bInValidLicenseDateRange);

                #region LOG LICENSE VALIDATION RESULTS TO CONSOLE 
                if (bValidLicense)
                {
                    strMsg = " === VALID AJP LICENSE FILE ENCOUNTED === ";
                    Console.WriteLine(" ");
                    Console.WriteLine(" ======================================== ");
                    Console.WriteLine(" === VALID AJP LICENSE FILE ENCOUNTED === ");
                    Console.WriteLine(" ======================================== ");
                    Console.WriteLine(" ");

                    //-------------------------------------------------------------------------------------------------
                    int nDaysRemaining = LicenseFileDataObj.GetRemainingDays();
                    strMsg = String.Format(" === {0} days remaining on the AJP LICENSE === ",
                                           nDaysRemaining.ToString("000"));
                    Console.WriteLine(" ");
                    Console.WriteLine(" ============================================= ");
                    Console.WriteLine(strMsg);
                    Console.WriteLine(" ============================================= ");
                    Console.WriteLine(" ");

                    //--------------------------
                    //--- Expiration Warning ---
                    //--------------------------
                    if(nDaysRemaining < 10)
                    {
                        MessageBox.Show(strMsg,
                                    "WARNING: LICENSE FILE EXPIRATION",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    strMsg = " *** INVALID AJP LICENSE FILE ENCOUNTED *** ";
                    Console.WriteLine(" ");
                    Console.WriteLine(" ****************************************** ");
                    Console.WriteLine(" *** INVALID AJP LICENSE FILE ENCOUNTED *** ");
                    Console.WriteLine(" ****************************************** ");
                    if (!bInValidLicenseDateRange)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(" ********* CHECK EXPIRATION DATE ********** ");
                    }
                    Console.WriteLine(" ");

                    MessageBox.Show(strMsg,
                                    "LICENSE FILE ERROR",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    FormLicenseFile licenseViewer = new FormLicenseFile();
                    licenseViewer.ShowDialog();
                }
                #endregion      // LOG LICENSE VALIDATION RESULTS TO CONSOLE 

                #endregion      // OVERALL STATUS
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            return bValidLicense;
        }
        #endregion      // IsValidLicense

        //=============================================================================================================
        //---------------------------------------------- HELPER METHODS -----------------------------------------------
        //=============================================================================================================

        #region CalculateLicenseKey ... CALCULATED LICENSE KEY STRING
        /// <summary>
        /// Calculate the license key based on the License Key Data Object Property
        /// </summary>
        /// <returns>License Key String</returns>
        public string CalculateLicenseKey()
        {
            string strMethod = "CalculateLicenseKey";
            string strMsg = String.Empty;
            string strMash = String.Empty;
            string strHash = String.Empty;
            string strExtract = String.Empty;
            string strLicenseKey = String.Empty;
            try
            {
                //=====================================================================================================
                //------------------------------------- MASH Items for the HASH ---------------------------------------
                //=====================================================================================================
                strMash = LicenseFileDataObj.GetMashString();

                //=====================================================================================================
                //------------------------------------------ HASH the MASH --------------------------------------------
                //=====================================================================================================
                strHash = ComputeSha256Hash(strMash);
                if (strHash.Length < 1) throw (new Exception("EMPTY HASH RETURNED!"));

                //=====================================================================================================
                //-------------------------------------- EXTRACT from the HASH ----------------------------------------
                //=====================================================================================================
                strExtract = Extract32CharHash(strHash, START_INDEX);
                if (strExtract.Length != 32) throw (new Exception("INVALID EXTRACTED STRING!"));

                //=====================================================================================================
                //---------------------------------- CREATE KEY using the EXTRACT -------------------------------------
                //=====================================================================================================
                strLicenseKey = FormatExtractedString(strExtract);
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            return strLicenseKey;
        }
        #endregion      // CalculateLicenseKey ... CALCULATED LICENSE KEY STRING

        #region CalculateLicenseFileHash ... CALCULATED LICENSE FILE HASH STRING
        /// <summary>
        /// Calculate the license file hase based on the License Key Data Object Properties (Key & Time Properties)
        /// </summary>
        /// <param name="strCalcKeyVal">Calcualted License Key value</param>
        /// <returns>License File Hash String</returns>
        public string CalculateLicenseFileHash(string strCalcKeyVal)
        {
            string strMethod = "CalculateLicenseFileHash";
            string strMsg = String.Empty;
            string strMash = String.Empty;
            string strHash = String.Empty;
            string strExtract = String.Empty;
            string strLicenseFileHash = String.Empty;
            try
            {
                //=====================================================================================================
                //------------------------------------- MASH Items for the HASH ---------------------------------------
                //=====================================================================================================
                strMash = string.Format("AJP-{0}_{1}_{2}-ENG",
                                        strCalcKeyVal,
                                        LicenseFileDataObj.StartDate.ToString("MM/dd/yyyy"),
                                        LicenseFileDataObj.EndDate.ToString("MM/dd/yyyy"));

                //=====================================================================================================
                //------------------------------------------ HASH the MASH --------------------------------------------
                //=====================================================================================================
                strHash = ComputeSha256Hash(strMash);
                if (strHash.Length < 1) throw (new Exception("EMPTY HASH RETURNED!"));

                //=====================================================================================================
                //-------------------------------------- EXTRACT from the HASH ----------------------------------------
                //=====================================================================================================
                strExtract = Extract32CharHash(strHash, START_INDEX);
                if (strExtract.Length != 32) throw (new Exception("INVALID EXTRACTED STRING!"));

                //=====================================================================================================
                //---------------------------------- CREATE KEY using the EXTRACT -------------------------------------
                //=====================================================================================================
                strLicenseFileHash = FormatExtractedString(strExtract);
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            return strLicenseFileHash;
        }
        #endregion      // CalculateLicenseFileHash ... CALCULATED LICENSE FILE HASH STRING

        //=============================================================================================================
        //----------------------------------------------- HASH METHODS ------------------------------------------------
        //=============================================================================================================

        #region ComputeSha256Hash
        /// <summary>
        /// Perform SHA-256 HASH on User Provided rawData string
        /// Returns 64 Character Hash String
        /// </summary>
        /// <param name="rawData">Raw Input Data String</param>
        /// <returns>64-char Hash String on success; Empty string otherwise</returns>
        public string ComputeSha256Hash(string rawData)
        {
            string strMethod = "ComputeSha256Hash";
            string strMsg = String.Empty;
            string strHash = String.Empty;
            try
            {
                rawData += "_fugacity_";    // Salt String
                //------------------------------
                //--- Create a SHA256 Object ---
                //------------------------------
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    //------------------------------------------
                    //--- ComputeHash - Returns a byte Array ---
                    //------------------------------------------
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                    //--------------------------------------
                    //--- Convert byte Array to a string ---
                    //--------------------------------------
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    strHash = builder.ToString();
                }
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            //---------------------------------
            //--- Return Hash String Result ---
            //---------------------------------
            return strHash;
        }
        #endregion      // ComputeSha256Hash

        #region Extract32CharHash
        /// <summary>
        /// Extract 32 Characters from the User Provided HASH
        /// Returns 32 Character Hash String
        /// </summary>
        /// <param name="str64Hash">Full 64-Char Hash String</param>
        /// <param name="nIndex">Start Index of Substring ... must be less than 32</param>
        /// <returns>32-char Hash String on success; Empty string otherwise</returns>
        public string Extract32CharHash(string str64Hash, int nIndex)
        {
            string strMethod = "Extract32CharHash";
            string strMsg = String.Empty;
            string str32Hash = String.Empty;
            int nStartIndex = 0;    // Start Index of Substring
            int nLength = 32;       // Length of Substring
            try
            {
                //-----------------------------
                //--- Determine Start Index ---
                //-----------------------------
                nStartIndex = nIndex;
                str32Hash = str64Hash.Substring(nStartIndex, nLength);
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            //--------------------------------------------
            //--- Return 32-Char Substring Hash Result ---
            //--------------------------------------------
            return str32Hash;
        }
        #endregion      // Extract32CharHash

        #region FormatExtractedString
        /// <summary>
        /// Format Inputted Extracted 32 Character String
        /// Returns Formatted 32-Char License Key String
        /// </summary>
        /// <param name="str32Extracted">Extracted 32-Char String</param>
        /// <returns>Formatted 32-Char License Key String on success; Empty string otherwise</returns>
        public string FormatExtractedString(string str32Extracted)
        {
            string strMethod = "FormatExtractedString";
            string strMsg = String.Empty;
            string strTemp = String.Empty;
            try
            {
                strTemp = str32Extracted;

                int pos = 0;
                char replacement = 'A';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 1;
                replacement = 'J';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 2;
                replacement = 'P';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 3;
                replacement = '-';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 8;
                replacement = '-';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 13;
                replacement = '-';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 18;
                replacement = '-';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 23;
                replacement = '-';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 28;
                replacement = '-';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 29;
                replacement = 'E';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 30;
                replacement = 'N';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                pos = 31;
                replacement = 'G';
                strTemp = strTemp.Substring(0, pos) + replacement + strTemp.Substring(pos + 1);

                //------------------------------------------
                //--- Ensure All Letters are Uppder Case ---
                //------------------------------------------
                strTemp = strTemp.ToUpper();
                //--------------------------------------------------------
                //--- Remove Extraneous Leading or Trailing Whitespace ---
                //--------------------------------------------------------
                strTemp = strTemp.Trim();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            //---------------------------------------------------
            //--- Return Formatted 32-Char License Key Result ---
            //---------------------------------------------------
            return strTemp;
        }
        #endregion      // FormatExtractedString
    }
    #endregion      // class LicenseKeyMgr
}
#endregion      // namespace AJP_License_File

//=====================================================================================================================
//---------------------------------------------- E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
