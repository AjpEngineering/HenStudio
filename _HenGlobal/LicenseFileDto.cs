#region HEADER
//######################################################################################################
//################################  L i c e n s e F i l e D t o . c s  #################################
//######################################################################################################
//  FILENAME:  LicenseFileDto.cs
//  NAMESPACE: HenGlobal
//  CLASS(S):  LicenseFileDto
//  COMPONENT: _HenGlobal.dll
//======================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the AJP License File Data Transfer Object (DTO) Class.
//    This class only contains properties and methods related to the license data.
//    It is populated in the _AJP_License_File component.
//------------------------------------------------------------------------------------------------------
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
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

#endregion      // REFERENCES

#region namespace HenGlobal
namespace HenGlobal
{
    #region class LicenseFileDto
    /// <summary>
    /// AJP License File Data Transfer Object (DTO) Class
    /// Populated from AJP License XML File and used to transfer license data
    /// This class only contains the properties ... _AJP_License_File namespace and LicenseFileData class are used to
    /// perform the actual license validation and hash generation.
    /// </summary>
    public class LicenseFileDto
    {
        #region CONSTANTS
        private const String NAMESPACE = "HenGlobal";
        private const String CLASS = "LicenseFileDto";
        #endregion      // CONSTANTS

        #region PROPERTIES

        #region XML FILE HASH & RUN-TIME ENVIRONMENT
        public string FileHash { get; set; }   // File Hash String ... Hash String Read from XML File ... [PUBLIC]
        public string RunTimeDeviceName { get; set; } // Device Running App ... "NUC"
        public string RunTimeUserName { get; set; }   // User Running App ..... [Environment.UserName] "baseb"
        #endregion      // XML FILE HASH & RUN-TIME ENVIRONMENT

        #region SUPPLIER PROPERTIES [ *** FIXED *** -> ALL CUSTOMERS -> ALL PRODUCTS ]
        public string Author { get; set; }        // Author .......... Product Developer ... "AJP Engineering"
        public string SupplierName { get; set; }  // Supplier Name ... Manufacturer ........ "AJP Engineering"
        public string SupplierUrl { get; set; }   // Supplier URL .... AJP Web Site ........ "http:://www.AJPEngineering.com"
        #endregion  // SUPPLIER PROPERTIES [ *** FIXED *** -> ALL CUSTOMERS -> ALL PRODUCTS ]

        #region CUSTOMER CONTACT PROPERTIES .... [=== MODIFY PER CUSTOMER ===]
        public string CustomerName { get; set; }   // Customer Name .... Customer Name .... "Bill Cashman"
        public string CustomerEmail { get; set; }  // Customer Email ... Customer Email ... "BillCashman@exxon.com"
        #endregion  // CUSTOMER CONTACT PROPERTIES .... [=== MODIFY PER CUSTOMER ===]

        #region PRODUCT PROPERTIES..... [ === MODIFY PER PRODUCT === ]  .... Set by Developer per Product Soluion
        public string ProductName { get; set; }    // Product Name ...... AJP Product Name ........ "AJP Test 1.0"
        public string ProductVersion { get; set; } // Product Version ... Full Version ............ "4.0.1"
        public string SerialNumber { get; set; }   // Serial Number ..... AJP Number .............. "1224-617-3554"
        public string ProductCode { get; set; }    // Product Code ...... Microsoft Format ........ "{3378CA35-F929-4E12-B8C7-0102DCE47C81}"
        #endregion  // PRODUCT PROPERTIES..... [ === MODIFY PER PRODUCT === ]  .... Set by Developer per Product Soluion

        #region LICENSE TYPE FIELDS .... [ === MODIFY PER LICENSE === ]
        public string LicenseType { get; set; }    // License Type ........................ "TRIAL"
        public string Corporation { get; set; }    // Corporation .... User Corporation ... "Exxon"
        public string Division { get; set; }       // Division ....... User Division ...... "Research and Development"
        public string Group { get; set; }          // Group .......... User Group ......... "Heat Exchanger Group"
        public string UserName { get; set; }       // User Name ...... User Name .......... "baseb"
        public string DeviceName { get; set; }     // Device Name .... User Device ........ "NUC"
        #endregion      // LICENSE TYPE FIELDS .... [ === MODIFY PER LICENSE === ]

        #region LICENSE PROPERTIES .... [ === MODIFY PER LICENSE === ] 
        public string FileLicenseKey { get; set; }  // File License Key ... ["AJP-2D69-9CF3-192C-81AA-EBDD-ENG"]  -- [PUBLIC]
        public int DurationDays { get; set; }       // License Duration in Days ... 365 days
        public int RemainingDays { get; set; }      // Number of day remaining on AJP License
        public DateTime StartDate { get; set; }     // Start Date ................. "7/4/2022"
        public DateTime EndDate { get; set; }       // End Date ................... "7/4/2023"

        #endregion      // LICENSE PROPERTIES .... [ === MODIFY PER LICENSE === ]

        #endregion      // PROPERTIES

        #region CTOR: LicenseFileData
        /// <summary>
        /// Default CTOR
        /// </summary>
        public LicenseFileDto()
        {
            string strMethod = "CTOR: LicenseFileDto";
            string strMsg = String.Empty;
            try
            {
                FileHash = string.Empty;        // File Hash String  ... [PUBLIC]

                RunTimeDeviceName = Environment.MachineName;   // Name of Device Running App ... "GM-DESKTOP"
                RunTimeUserName = Environment.UserName;        // Name of User Running App ..... [Environment.UserName]
                //--------------------------------------
                //--- Initialize Supplier Properties ---
                //--------------------------------------
                Author = string.Empty;         // Author ............ Product Developer ... "AJP Engineering"
                SupplierName = string.Empty;   // Supplier Name ..... Manufacturer ........ "AJP Engineering"
                SupplierUrl = string.Empty;    // Supplier URL ...... AJP Web Site ........ "http:://www.AJPEngineering.com"
                //----------------------------------------------
                //--- Initialize Customer Contact Properties ---
                //----------------------------------------------
                CustomerName  = string.Empty;  // Customer Name ..... Customer Name ...... "Bill Cashman"
                CustomerEmail = string.Empty;  // Customer Email .... Customer Email ..... "BillCashman@exxon.com"
                //-------------------------------------
                //--- Initialize Product Properties ---
                //-------------------------------------
                ProductName = string.Empty;    // Product Name ...... AJP Product Name .... "AJP Pinch"
                ProductVersion = string.Empty; // Product Version ... Full Version ........ "4.0.1"
                SerialNumber = string.Empty;   // Serial Number ..... AJP Number .......... "1022-456-1189" --- [part of MASH] ---
                ProductCode = string.Empty;    // Product Code ...... AJP GUID ............ "{3D9721BA-003E-4711-B7AF-B579645F0AC9}"
                //------------------------------------------
                //--- Initialize License Type Properties ---
                //------------------------------------------
                LicenseType = HenTypes.LicenseType.USER.ToString(); // License Type ...... ["USER"]

                Corporation = string.Empty;    // Corporation ....... User Corporation ... "ExxonMobile" 
                Division = string.Empty;       // Division .......... User Division ...... "Research and Development" 
                Group = string.Empty;          // Group ............. User Group ......... "Heat Exchanger Group" 
                
                DeviceName = string.Empty;	   // Device Name ....... User Device ........ "GM-DESKTOP"
                UserName = string.Empty;       // User Name ......... User Name .......... "baseb" 

                //-------------------------------------
                //--- Initialize License Properties ---
                //-------------------------------------
                FileLicenseKey = string.Empty;              // File License Key String ... ["AJP-2D69-9CF3-192C-81AA-EBDD-ENG"] [PUBLIC]

                DurationDays = 365;                         // License Duration in Days ... 365 
                StartDate = DateTime.Now;	                // Start Date ................. "7/4/2022" 
                EndDate = StartDate.AddDays(DurationDays);  // End Date ................... "7/4/2023" 
                RemainingDays = 365;                        // Number of day remaining on AJP License
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
        }
        #endregion      // CTOR: LicenseFileData

    }
    #endregion      // class LicenseFileDto
}
#endregion      // namespace HenGlobal

//=====================================================================================================================
//---------------------------------------------- E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
