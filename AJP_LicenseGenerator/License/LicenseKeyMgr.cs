#region HEADER
//######################################################################################################
//#################################  L i c e n s e K e y M g r . c s  ##################################
//######################################################################################################
//  FILENAME:  LicenseKeyMgr.cs
//  NAMESPACE: AJP_LicenseGenerator
//  CLASS(S):  LicenseKeyMgr
//  COMPONENT: AJP Test.exe
//======================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the LicenseKeyMgr class.
//    This class manages the data functionality of AJP License Key Manager.
//======================================================================================================
//  AUTHOR:
//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//                                                                                                    !!
//                    GGGGG   IIIIII   OOOOO    RRRRRRR    GGGGG   IIIIII   OOOOO                     !!
//                   GG   GG    II    OO   OO   RR    RR  GG   GG    II    OO   OO                    !!
//                   GG         II   OO     OO  RR    RR  GG         II   OO     OO                   !!
//                   GG  GGGG   II   OO     OO  RRRRRRR   GG  GGGG   II   OO     OO                   !!
//                   GG   GG    II    OO   OO   RR    RR  GG   GG    II    OO   OO                    !!
//                    GGGGG   IIIIII   OOOOO    RR    RR   GGGGG   IIIIII   OOOOO                     !!
//                                                                                                    !!
//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//    (c)Copyright 2021 AJP Engineering
//    All rights reserved.
//======================================================================================================
//  HISTORY:
//    11/18/22 .. pg .. Version 1.0
//######################################################################################################
//######################################################################################################
//######################################################################################################
#endregion      // HEADER

#region REFERENCES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
#endregion      // REFERENCES

#region namespace AJP_LicenseGenerator
namespace AJP_LicenseGenerator
{
    #region class LicenseKeyMgr
    /// <summary>
    /// AJP License Key Manager Class
    /// </summary>
    public class LicenseKeyMgr
    {
        #region CONSTANTS
        private const String NAMESPACE = "AJP_LicenseGenerator";
        private const String CLASS = "LicenseKeyMgr";

        private const int START_INDEX = 30;     // Start Index of Substring ... must be less than 32
        #endregion      // CONSTANTS

        #region FIELDS
        private LicenseKeyData _licenseKeyDataObj;      // License Key Data object
        #endregion      // FIELDS

        #region PROPERTIES

        #region LicenseKeyDataObj
        /// <summary>
        /// LicenseKeyDataObj Property  ...  License Key Data object
        /// </summary>
        public LicenseKeyData LicenseKeyDataObj
        {
            get { return _licenseKeyDataObj; }
            set { _licenseKeyDataObj = value; }
        }
        #endregion      // LicenseKeyDataObj

        #endregion      // PROPERTIES

        #region CTOR: LicenseKeyMgr
        public LicenseKeyMgr()
        {
            string strMethod = "CTOR: LicenseKeyMgr";
            string strMsg = String.Empty;
            try
            {
                //-----------------------------
                //--- Initialize Properties ---
                //-----------------------------
                LicenseKeyDataObj = new LicenseKeyData();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
        }
        #endregion      // CTOR: LicenseKeyMgr

        //=============================================================================================================
        //---------------------------------------------- PUBLIC METHODS -----------------------------------------------
        //=============================================================================================================

        #region GetLicenseKey
        /// <summary>
        /// Get the license key based on the License Key Data Object Property
        /// </summary>
        /// <returns>License Key String</returns>
        public string GetLicenseKey(LicenseKeyData licenseKeyDataObj)
        {
            string strMethod = "GetLicenseKey";
            string strMsg = String.Empty;
            string strMash = String.Empty;
            string strHash = String.Empty;
            string strExtract = String.Empty;
            string strLicenseKey = String.Empty;
            try
            {
                LicenseKeyDataObj = licenseKeyDataObj;
                //=====================================================================================================
                //------------------------------------- MASH Items for the HASH ---------------------------------------
                //=====================================================================================================
                strMash = GetMashString(LicenseKeyDataObj.CustomerName,
                                        LicenseKeyDataObj.Organization,
                                        LicenseKeyDataObj.SerialNumber);
                
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

                LicenseKeyDataObj.LicenseKeyString = strLicenseKey;
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            return strLicenseKey;
        }
        #endregion      // GetLicenseKey

        //=============================================================================================================
        //----------------------------------------------- HASH METHODS ------------------------------------------------
        //=============================================================================================================

        #region GetMashString
        /// <summary>
        /// Get mash string based on the appropriate Properties of this class
        /// Uses the following Properties for the mash:
        ///   ... [Customer Name, Orgnaization, Product Serial Number]
        ///   Note: Serial Number encodes the Product Name for Full License - Trial license is Product agnostic, 
        /// </summary>
        /// <returns>Mash string ... [Customer Name, orgnaization, Product Serial Number]</returns>
        public string GetMashString(string strCustomerName,
                                    string strOrganization,
                                    string strSerialNumber)
        {
            string strMethod = "GetMashString";
            string strMsg = String.Empty;
            string strMash = String.Empty;
            try
            {
                //-----------------------------------------------
                //--- Compose Mash String Based on Properties ---
                //-----------------------------------------------
                strMash = String.Format("{0}__{1}__{2}",
                                        strCustomerName,
                                        strOrganization,
                                        strSerialNumber);
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            return strMash;
        }
        #endregion      // GetMashString

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
#endregion      // namespace AJP_LicenseGenerator

//=====================================================================================================================
//---------------------------------------------- E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
