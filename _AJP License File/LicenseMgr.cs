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

        #region PROPERTIES
        public string FullPathFilenameXML { get; set; }   // Full Path File Name to Persist and Restore XML File
        public LicenseFileData LicenseFileDataObj { get; set; }        // XML License File Data object
        public LicenseFileData RunTimeLicenseFileDataObj { get; set; } // License File Data object
        public ScoreCardTableData ScoreCardTableDataObj { get; set; }  // ScoreCard Table Data Object
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
                LicenseFileDataObj = new LicenseFileData();         // Create XML License File Data Object
                RunTimeLicenseFileDataObj = new LicenseFileData();  // Create Run-Time License File Data Object
                ScoreCardTableDataObj = new ScoreCardTableData();   // Create ScoreCard Table Data Object
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
        //------------------------------------------- SCORECARD DATA METHOD -------------------------------------------
        //=============================================================================================================

        #region GetScoreCardTableData
        /// <summary>
        /// Get the ScoreCard Table Data based on XML License File, License Type, and Run-Time Environment
        /// </summary>
        /// <param name="strFullPathAppStartupLoc">Full-Path Folder Location of App</param>
        /// <returns>Populated ScoreCardTableData Object</returns>
        public ScoreCardTableData GetScoreCardTableData(string strFullPathAppStartupLoc)
        {
            string strMethod = "GetScoreCardData";
            string strMsg = string.Empty;

            string strLicenseFolder = string.Empty;
            string strLicenseFile = string.Empty;
            bool bMatch = false;
            string strDeviceNameValidFlag = String.Empty;
            string strUserNameValidFlag = String.Empty;
            string strLicenseKeyValidFlag = String.Empty;
            string strLicenseHashValidFlag = String.Empty;
            try
            {
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-==-=-=-=-=-=-=-=-=-= CHECK IF LICENSE XML FILE EXISTS =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
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
                
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=  READ LICENSE FILE  -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                #region READ LICENSE FILE
                //-----------------------------------------------------------
                //--- Read the License File from the AJP License XML File ---
                //-----------------------------------------------------------
                LicenseFileDataObj.RestoreLicenseXmlFile(strLicenseFile);
                #endregion      // READ LICENSE FILE

                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=  CREATE RUN-TIME LICENSE DATA  -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                #region CREATE RUN-TIME LICENSE DATA                
                //-----------------------------------------------------------
                //--- Initialize Run-Time Data Object                     ---
                //--- Read the License File from the AJP License XML File ---
                //-----------------------------------------------------------
                RunTimeLicenseFileDataObj.RestoreLicenseXmlFile(strLicenseFile);
                //------------------------------------------------
                //--- Update Run-Time License File Data Object ---
                //------------------------------------------------
                switch(RunTimeLicenseFileDataObj.LicenseType)
                {
                    case "DEVICE":
                        RunTimeLicenseFileDataObj.DeviceName = 
                          Environment.MachineName; // Get Run-Time Device (Machine) Name
                        break;
                    case "SEAT":
                        RunTimeLicenseFileDataObj.DeviceName =
                          Environment.MachineName; // Get Run-Time Device (Machine) Name

                        RunTimeLicenseFileDataObj.UserName =
                          Environment.UserName;    // Get Run-Time User Name
                        break;
                    default:
                        //--- Nothing to Change for [TRIAL | SITE | UNKNOWN] License Types
                        break;
                }
                #endregion      // CREATE RUN-TIME LICENSE DATA

                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=  CREATE AND POPULATE SCORECARD TABLE DATA  -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                #region CREATE AND POPULATE SCORECARD TABLE DATA
                strDeviceNameValidFlag = "VALID";
                strUserNameValidFlag = "VALID";
                strLicenseKeyValidFlag = "VALID";
                strLicenseHashValidFlag = "VALID";
                //-------------------------------------------------------------------------------- ALL LICENSE TYPE ---
                bMatch = CheckRunTimeKey();
                if (bMatch) strLicenseKeyValidFlag = "VALID";
                else strLicenseKeyValidFlag = "INVALID";

                bMatch = CheckRunTimeHash();
                if (bMatch) strLicenseHashValidFlag = "VALID";
                else strLicenseHashValidFlag = "INVALID";

                //----------------------------------------------------------------------------- DEVICE LICENSE TYPE ---
                if(String.Compare(LicenseFileDataObj.LicenseType, "DEVICE") ==0)
                {
                    bMatch = CheckRunTimeDeviceName(LicenseFileDataObj.DeviceName);
                    if (bMatch) strDeviceNameValidFlag = "VALID";
                    else strDeviceNameValidFlag = "INVALID";
                }

                //------------------------------------------------------------------------------- SEAT LICENSE TYPE ---
                else if (String.Compare(LicenseFileDataObj.LicenseType, "SEAT") == 0)
                {
                    bMatch = CheckRunTimeDeviceName(LicenseFileDataObj.DeviceName);
                    if (bMatch) strDeviceNameValidFlag = "VALID";
                    else strDeviceNameValidFlag = "INVALID";

                    bMatch = CheckRunTimeUserName(LicenseFileDataObj.UserName);
                    if (bMatch) strUserNameValidFlag = "VALID";
                    else strUserNameValidFlag = "INVALID";
                }

                //---------------------------------------------------------------------------------- POPULATE TABLE ---
                ScoreCardTableDataObj.ClearTable();
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("01", "Author", LicenseFileDataObj.Author, "VALID"));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("02", "Supplier Name", LicenseFileDataObj.SupplierName, "VALID"));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("03", "Supplier Url", LicenseFileDataObj.SupplierUrl, "VALID"));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("04", "Customer Name", LicenseFileDataObj.CustomerName, "VALID"));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("05", "Customer Email", LicenseFileDataObj.CustomerEmail, "VALID"));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("06", "Product Name", LicenseFileDataObj.ProductName, "VALID"));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("07", "Product Version", LicenseFileDataObj.ProductVersion, "VALID"));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("08", "Product Serial Number", LicenseFileDataObj.SerialNumber, "VALID"));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("09", "Product Code", LicenseFileDataObj.ProductCode, "VALID"));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("10", "License Type", LicenseFileDataObj.LicenseType, "VALID"));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("11", "Corporation", LicenseFileDataObj.Corporation, "VALID"));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("12", "Division", LicenseFileDataObj.Division, "VALID"));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("13", "Group", LicenseFileDataObj.Group, "VALID"));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("14", "User Name", LicenseFileDataObj.UserName, strUserNameValidFlag));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("15", "Device Name", LicenseFileDataObj.DeviceName, strDeviceNameValidFlag));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("16", "License Duration", LicenseFileDataObj.DurationDays.ToString(), "VALID"));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("17", "License Start", LicenseFileDataObj.StartDate.ToShortDateString(), "VALID"));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("18", "License End", LicenseFileDataObj.EndDate.ToShortDateString(), "VALID"));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("19", "License Key", LicenseFileDataObj.FileLicenseKey, strLicenseKeyValidFlag));
                ScoreCardTableDataObj.AddRow(new ScoreCardRowData("20", "License Hash", LicenseFileDataObj.FileHash, strLicenseHashValidFlag));
                //-----------------------------------------------------------------------------------------------------

                ScoreCardTableDataObj.GetCounts();      // Calculate Counts

                #endregion  // CREATE AND POPULATE SCORECARD TABLE DATA

                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=  LOG TABLE DATA TO CONSOLE  -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                #region LOG TABLE DATA TO CONSOLE
                ScoreCardTableDataObj.LogTable();
                #endregion  // LOG TABLE DATA TO CONSOLE
            }
            catch (Exception ex)
            {
                strMsg = string.Format(" *** EXCEPTION Getting ScoreCard Table Data  [{0} : {1}]",
                                       strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            finally
            {
            }
            return ScoreCardTableDataObj;
        }
        #endregion  // GetScoreCardTableData

        #region CheckRunTimeDeviceName
        /// <summary>
        /// Check if Run-Time Device Name MATCHES XML License File Device Name
        /// </summary>
        /// <param name="strLicenseDeviceName">XML License File Device Name</param>
        /// <returns>true if Run-Time Device Name Matches License File Device Name; otherwise false</returns>
        private bool CheckRunTimeDeviceName(string strLicenseDeviceName)
        {
            string strMethod = "CheckRunTimeDeviceName";
            string strMsg = string.Empty;
            string strRunTimeDeviceName = String.Empty;
            bool bMatch = false;
            try
            {
                strRunTimeDeviceName = Environment.MachineName; // Get Run-Time Device (Machine) Name
                bMatch = (String.Compare(strLicenseDeviceName, strRunTimeDeviceName, true) == 0);
            }
            catch (Exception ex)
            {
                strMsg = string.Format(" *** EXCEPTION Getting ScoreCard Table Data  [{0} : {1}]", 
                                       strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            finally
            {
            }
            return bMatch;
        }
        #endregion      // CheckRunTimeDeviceName

        #region CheckRunTimeUserName
        /// <summary>
        /// Check if Run-Time User Name MATCHES XML License File User Name
        /// </summary>
        /// <param name="strLicenseUserName">XML License File User Name</param>
        /// <returns>true if Run-Time User Name Matches License File User Name; otherwise false</returns>
        private bool CheckRunTimeUserName(string strLicenseUserName)
        {
            string strMethod = "CheckRunTimeUserName";
            string strMsg = string.Empty;
            string strRunTimeUserName = String.Empty;
            bool bMatch = false;
            try
            {
                strRunTimeUserName = Environment.UserName; // Get Run-Time User Name

                bMatch = (String.Compare(strLicenseUserName, strRunTimeUserName, true) == 0);
            }
            catch (Exception ex)
            {
                strMsg = string.Format(" *** EXCEPTION Getting ScoreCard Table Data  [{0} : {1}]",
                                       strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            finally
            {
            }
            return bMatch;
        }
        #endregion      // CheckRunTimeUserName

        #region CheckRunTimeKey
        /// <summary>
        /// Check if Run-Time Key MATCHES XML License File Key
        /// </summary>
        /// <returns>true if Run-Time Key Matches License File Key; otherwise false</returns>
        private bool CheckRunTimeKey()
        {
            string strMethod = "CheckRunTimeKey";
            string strMsg = string.Empty;
            string strXmlKey = String.Empty;
            string strRunTimeKey = String.Empty;
            bool bMatch = false;
            try
            {
                strXmlKey = this.LicenseFileDataObj.FileLicenseKey;
                strRunTimeKey = CalculateLicenseKey(false); // Get Run-Time Key

                bMatch = (String.Compare(strXmlKey, strRunTimeKey, true) == 0);
            }
            catch (Exception ex)
            {
                strMsg = string.Format(" *** EXCEPTION Getting ScoreCard Table Data  [{0} : {1}]",
                                       strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            finally
            {
            }
            return bMatch;
        }
        #endregion      // CheckRunTimeKey

        #region CheckRunTimeHash
        /// <summary>
        /// Check if Run-Time Hash MATCHES XML License File Hash
        /// </summary>
        /// <returns>true if Run-Time Key Matches License File Hash; otherwise false</returns>
        private bool CheckRunTimeHash()
        {
            string strMethod = "CheckRunTimeHash";
            string strMsg = string.Empty;
            string strXmlKey = String.Empty;
            string strRunTimeKey = String.Empty;
            string strXmlHash = String.Empty;
            string strRunTimeHash = String.Empty;
            bool bMatch = false;
            try
            {
                strXmlKey = this.LicenseFileDataObj.FileLicenseKey;
                strRunTimeKey = CalculateLicenseKey(false); // Get Run-Time Key

                strXmlHash = this.LicenseFileDataObj.FileHash;
                strRunTimeHash = CalculateLicenseFileHash(strRunTimeKey, false);  // Get Run-Time Hash

                bMatch = (String.Compare(strXmlHash, strRunTimeHash, true) == 0);
            }
            catch (Exception ex)
            {
                strMsg = string.Format(" *** EXCEPTION Getting ScoreCard Table Data  [{0} : {1}]",
                                       strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            finally
            {
            }
            return bMatch;
        }
        #endregion      // CheckRunTimeHash

        //=============================================================================================================
        //---------------------------------------------- HELPER METHODS -----------------------------------------------
        //=============================================================================================================

        #region CalculateLicenseKey ... CALCULATED LICENSE KEY STRING
        /// <summary>
        /// Calculate the license key based on the License Key Data Object Property
        /// </summary>
        /// <returns>License Key String</returns>
        public string CalculateLicenseKey(bool bXmlFile=true)
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
                if (bXmlFile) strMash = LicenseFileDataObj.GetMashString();
                else strMash = RunTimeLicenseFileDataObj.GetMashString();

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
        public string CalculateLicenseFileHash(string strCalcKeyVal, bool bXmlFile = true)
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
                if (bXmlFile)
                {
                    strMash = string.Format("AJP-{0}_{1}_{2}_{3}-ENG",
                                        strCalcKeyVal,
                                        LicenseFileDataObj.StartDate.ToString("MM/dd/yyyy"),
                                        LicenseFileDataObj.EndDate.ToString("MM/dd/yyyy"),
                                        "B052122");
                }
                else
                {
                    strMash = string.Format("AJP-{0}_{1}_{2}_{3}-ENG",
                                        strCalcKeyVal,
                                        RunTimeLicenseFileDataObj.StartDate.ToString("MM/dd/yyyy"),
                                        RunTimeLicenseFileDataObj.EndDate.ToString("MM/dd/yyyy"),
                                        "B052122");
                }
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
