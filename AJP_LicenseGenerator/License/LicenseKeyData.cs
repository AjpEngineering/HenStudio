#region HEADER
//######################################################################################################
//################################  L i c e n s e K e y D a t a . c s  #################################
//######################################################################################################
//  FILENAME:  LicenseKeyData.cs
//  NAMESPACE: AJP_LicenseGenerator
//  CLASS(S):  LicenseKeyData
//  COMPONENT: AJP Test.exe
//======================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the LicenseKeyData class.
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
using System.Text;
using System.Threading.Tasks;
#endregion      // REFERENCES

#region namespace AJP_LicenseGenerator
namespace AJP_LicenseGenerator
{
    #region class LicenseKeyData
    /// <summary>
    /// AJP License Key Data Class
    /// </summary>
    public class LicenseKeyData
    {
        #region CONSTANTS
        private const String NAMESPACE = "AJP_LicenseGenerator";
        private const String CLASS = "LicenseKeyData";
        #endregion      // CONSTANTS

        #region FIELDS
        private string _strCustomerName;    // Customer Name String ------------------------------------- include in MASH
        private string _strOrganization;    // Customer Organization String ----------------------------- include in MASH
        private string _strSerialNumber;    // Serial Number String ......... ["xxxx-xxx-xxxx"] --------- include in MASH

        private string _strLicenseKey;      // License Key String ........... ["AJP-xxxxx-xxxxx-xxxxx-xxxxx-xxxxx-ENG"]
        #endregion      // FIELDS

        #region PROPERTIES

        #region CustomerName
        /// <summary>
        /// CustomerName Property  ...  Customer Name String
        /// </summary>
        public string CustomerName
        {
            get { return _strCustomerName; }
            set { _strCustomerName = value; }
        }
        #endregion      // CustomerName

        #region Organization
        /// <summary>
        /// Organization Property  ...  Customer Organization String
        /// </summary>
        public string Organization
        {
            get { return _strOrganization; }
            set { _strOrganization = value; }
        }
        #endregion      // Organization

        #region SerialNumber
        /// <summary>
        /// SerialNumber Property  ...  Serial Number String ... ["xxxx-xxx-xxxx"]
        /// </summary>
        public string SerialNumber
        {
            get { return _strSerialNumber; }
            set { _strSerialNumber = value; }
        }
        #endregion      // SerialNumber

        #region LicenseKeyString
        /// <summary>
        /// LicenseKeyString Property  ...  License Key String ... ["AJP-xxxxx-xxxxx-xxxxx-xxxxx-xxxxx-ENG"]
        /// </summary>
        public string LicenseKeyString
        {
            get { return _strLicenseKey; }
            set { _strLicenseKey = value; }
        }
        #endregion      // LicenseKeyString

        #endregion      // PROPERTIES

        #region CTOR: LicenseKeyData
        /// <summary>
        /// Default CTOR
        /// </summary>
        public LicenseKeyData()
        {
            string strMethod = "CTOR: LicenseKeyData";
            string strMsg = String.Empty;
            try
            {
                //-----------------------------
                //--- Initialize Properties ---
                //-----------------------------
                CustomerName = string.Empty;        // Customer Name String --------------------------------- include in MASH
                Organization = string.Empty;        // Customer Organization String ------------------------- include in MASH
                SerialNumber = string.Empty;        // Serial Number String ..... ["xxxx-xxx-xxxx"] --------- include in MASH

                LicenseKeyString = string.Empty;    // License Key String ....... ["AJP-xxxxx-xxxxx-xxxxx-xxxxx-xxxxx-ENG"]
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
        }
        #endregion      // CTOR: LicenseKeyData

    }
    #endregion      // class LicenseKeyData

}
#endregion      // namespace AJP_LicenseGenerator

//=====================================================================================================================
//---------------------------------------------- E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
