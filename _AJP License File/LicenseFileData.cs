#region HEADER
//######################################################################################################
//###############################  L i c e n s e F i l e D a t a . c s  ################################
//######################################################################################################
//  FILENAME:  LicenseFileData.cs
//  NAMESPACE: AJP_License_File
//  CLASS(S):  LicenseFileData
//  COMPONENT: _AJP License File.dll
//======================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the LicenseFileData class.
//------------------------------------------------------------------------------------------------------
//    The Mash string contains the following properties:
//      [SerialNumber, ComputerName, CustomerName, Organization].
//------------------------------------------------------------------------------------------------------
//    The Hash key includes the Key and the Time-base License properties
//------------------------------------------------------------------------------------------------------
//    EXAMPLE: AJP License XML File
//------------------------------------------------------------------------------------------------------
//      <?xml version="1.0" encoding="utf-8"?>
//      <AJP_License hash="AJP-2f56-7CB2-882C-90BC-ABCD-ENG" >
//      	<Supplier>
//      		<Author value="AJP Engineering" />
//      		<SupplierName value="AJP Engineering" />
//      		<SupplierUrl value="http:://www.AJPEngineering.com" />
//      	</Supplier>
//      	<CustomerContact>
//      		<CustomerName value="Bill Cashman" />
//      		<CustomerEmail value="BillCashman@exxon.com" />
//      	</CustomerContact>
//      	<Product>
//      		<ProductName value="AJP Test 1.0" />
//      		<Productversion value="1.0.1" />
//      		<ProductSerialNumber value="1224-617-3554" />
//      		<ProductCode value="{3378CA35-F929-4E12-B8C7-0102DCE47C81}" />
//      	</Product>
//      	<LicenseType value="SEAT">
//      		<Site>
//      			<Corporation value="ExxonMobile" />
//      			<Division value="Research and Development" />
//      			<Group value="Heat Exchanger Group" />
//      		</Site>
//      		<User>
//      			<UserName value="Joey Bots" />
//      		</User>
//      		<Seat>
//      			<DeviceName value="GM-DESKTOP" />
//      		</Seat>
//      	</LicenseType>
//          <License>
//		        <LicenseKey value="AJP-2D69-9CF3-192C-81AA-EBDD-ENG"/>
//		        <LicenseDuration days="365" />
//		        <LicenseStart date="7/4/2022"/>
//		        <LicenseEnd date="7/4/2023"/>
//	        </License>
//      </AJP_License>
//
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

using static AJP_License_File.LicenseTypes;
#endregion      // REFERENCES

#region namespace AJP_License_File
namespace AJP_License_File
{
    #region class LicenseFileData
    /// <summary>
    /// AJP License Key Data Class
    /// </summary>
    public class LicenseFileData
    {
        #region CONSTANTS
        private const String NAMESPACE = "_AJP_License_File";
        private const String CLASS = "LicenseFileData";

        #region PROPERTY CONSTANTS

        #region CONSTANTS - SUPPLIER PROPERTIES DEFAULTS  ... [ *** FIXED *** -> ALL CUSTOMERS -> ALL PRODUCTS ]
        private const String AUTHOR = "AJP Engineering";                        // Author .......... Product Developer
        private const String SUPPLIER_NAME = "AJP Engineering";                 // Supplier Name ... Manufacturer
        private const String SUPPLIER_URL = "http:://www.AJPEngineering.com";   // Supplier URL .... AJP Web Site
        #endregion      // CONSTANTS - SUPPLIER PROPERTIES DEFAULTS

        #region CONSTANTS - CUSTOMER PROPERTIES DEFAULTS .... [ === MODIFY PER CUSTOMER === ]  ... Set on registration / Check on App Launch
        private const String CUSTOMER_NAME  = "Customer Name";       // Customer Name .... Customer Name
        private const String CUSTOMER_EMAIL = "Customer Email";      // Customer Email ... Customer Email
        #endregion      // CONSTANTS - CUSTOMER PROPERTIES DEFAULTS .... [ === MODIFY PER CUSTOMER === ]  ... Set on registration / Check on App Launch

        #region CONSTANTS - PRODUCT PROPERTIES DEFAULTS ..... [ === MODIFY PER PRODUCT === ]  .... Set by Developer per Product Soluion
        private const String PRODUCT_NAME = "AJP Test 1.0";     // Product Name ...... AJP Product Name
        private const String PRODUCT_VERSION = "1.0.0";         // Product Version ... Full Version
        private const String SERIAL_NUMBER = "1224-617-3554";   // Serial Number ..... AJP Number
        private const String PRODUCT_CODE = "{3378CA35-F929-4E12-B8C7-0102DCE47C81}";    // Product Code ...... Microsoft Format
        #endregion      // CONSTANTS - PRODUCT PROPERTIES DEFAULTS ..... [ === MODIFY PER PRODUCT === ]  .... Set by Developer per Product Soluion

        #region CONSTANTS - LICENSE TYPE PROPERTIES DEFAULTS ..... [ === MODIFY PER LICENSE === ]
        private const LicenseTypeEnum LICENSE_TYPE = LicenseTypeEnum.TRIAL;  // License Type ...... ["TRIAL"]
        private const String CORPORATION  = "CORPORATION";                   // User Corporation
        private const String DIVISION     = "DIVISION";                      // User Division
        private const String GROUP        = "GROUP";                         // User Group
        private const String USERNAME     = "USERNAME";                      // User Name
        private const String DEVICE_NAME  = "DEVICE_NAME";                   // Device Name
        #endregion      // CONSTANTS - LICENSE TYPE PROPERTIES DEFAULTS ..... [ === MODIFY PER LICENSE === ]

        #region CONSTANTS - LICENSE PROPERTIES DEFAULTS .... [ === MODIFY PER LICENSE === ]
        private const int FULL_DURATION_DAYS = 365;       // License Duration in Days
        #endregion      // CONSTANTS - CUSTOMER PROPERTIES DEFAULTS .... [ === MODIFY PER LICENSE === ]

        #endregion      // PROPERTY CONSTANTS

        #region XML CONSTANTS

        #region XML ELEMENTS
        public const string ELEMENT_AJP_LICENSE            = "AJP_License";            // AJP_License

        public const string ELEMENT_AUTHOR                 = "Author";                 // Author
        public const string ELEMENT_SUPPLIER_NAME          = "SupplierName";           // SupplierName
        public const string ELEMENT_SUPPLIER_URL           = "SupplierUrl";            // SupplierUrl

        public const string ELEMENT_CUSTOMER_NAME          = "CustomerName";           // CustomerName
        public const string ELEMENT_CUSTOMER_EMAIL         = "CustomerEmail";          // CustomerEmail

        public const string ELEMENT_PRODUCT_NAME           = "ProductName";            // ProductName
        public const string ELEMENT_PRODUCT_VERSION        = "ProductVersion";         // ProductVersion
        public const string ELEMENT_PRODUCT_SERIAL_NUMBER  = "ProductSerialNumber";    // ProductSerialNumber
        public const string ELEMENT_PRODUCT_CODE           = "ProductCode";            // ProductCode

        public const string ELEMENT_LICENSE_TYPE           = "LicenseType";            // LicenseType

        public const string ELEMENT_CORPORATION            = "Corporation";            // Corporation
        public const string ELEMENT_DIVISION               = "Division";               // Division
        public const string ELEMENT_GROUP                  = "Group";                  // Group

        public const string ELEMENT_USER_NAME              = "UserName";               // UserName

        public const string ELEMENT_DEVICE_NAME            = "DeviceName";             // DeviceName

        public const string ELEMENT_LICENSE_KEY            = "LicenseKey";             // LicenseKey
        public const string ELEMENT_LICENSE_DURATION       = "LicenseDuration";        // LicenseDuration
        public const string ELEMENT_LICENSE_START          = "LicenseStart";           // LicenseStart
        public const string ELEMENT_LICENSE_END            = "LicenseEnd";             // LicenseEnd
        #endregion      // XML ELEMENTS

        #region XML ATTRIBUTES
        public const string ATTRIBUTE_HASH     = "hash";   // hash
        public const string ATTRIBUTE_VALUE    = "value";  // value
        public const string ATTRIBUTE_DAYS     = "days";   // days
        public const string ATTRIBUTE_DATE     = "date";   // date
        #endregion      // XML ATTRIBUTES

        #endregion      // XML CONSTANTS

        #endregion      // CONSTANTS

        #region FIELDS
        private string _strFileHash;            // File Hash String ......... Hash String Read from XML File ... [PUBLIC]
        private string _strRunTimeDeviceName;	// Name of Device Running App ... "NUC"
        private string _strRunTimeUserName;	    // Name of User Running App ..... [Environment.UserName] "baseb"

        #region SUPPLIER FIELDS  ... [ *** FIXED *** -> ALL CUSTOMERS -> ALL PRODUCTS ]
        private string _strAuthor;          // Author ............ Product Developer ....... "AJP Engineering"
        private string _strSupplierName;    // Supplier Name ..... Manufacturer ............ "AJP Engineering"
        private string _strSupplierUrl;     // Supplier URL ...... AJP Web Site ............ "http:://www.AJPEngineering.com"
        #endregion      // SUPPLIER FIELDS  ... [ *** FIXED *** -> ALL CUSTOMERS -> ALL PRODUCTS ]

        #region CUSTOMER CONTACT FIELDS .... [ === MODIFY PER CUSTOMER === ]
        private string _strCustomerName;    // Customer Name .... Customer Name .... "Bill Cashman"
        private string _strCustomerEmail;   // Customer Email ... Customer Email ... "BillCashman@exxon.com"
        #endregion      // CUSTOMER CONTACT FIELDS .... [ === MODIFY PER CUSTOMER === ]

        #region PRODUCT FIELDS ..... [ === MODIFY PER PRODUCT === ]  ... Set by Developer per Product Soluion
        private string _strProductName;     // Product Name ...... AJP Product Name ........ "AJP Test 1.0"
        private string _strProductVersion;  // Product Version ... Full Version ............ "1.0.0"
        private string _strSerialNumber;    // Serial Number ..... AJP Number .............. "1224-617-3554"
        private string _strProductCode;     // Product Code ...... Microsoft Format ........ "{3378CA35-F929-4E12-B8C7-0102DCE47C81}"
        #endregion      // PRODUCT FIELDS ..... [=== MODIFY PER PRODUCT ===]  ... Set by Developer per Product Soluion

        #region LICENSE TYPE FIELDS .... [ === MODIFY PER LICENSE === ]
        private string _strlicenseType;   // License Type ........................ "TRIAL"
        private string _strCorporation;   // Corporation .... User Corporation ... "Exxon"
        private string _strDivision;      // Division ....... User Division ...... "Research and Development"
        private string _strGroup;         // Group .......... User Group ......... "Heat Exchanger Group"
        private string _strUserName;	  // User Name ...... User Name .......... "Joey Bots"        
        private string _strDeviceName;	  // Device Name .... User Device ........ "GM-DESKTOP"
        #endregion      // LICENSE TYPE FIELDS .... [ === MODIFY PER LICENSE === ]

        #region LICENSE FIELDS .... [ === MODIFY PER LICENSE === ]
        private string _strFileLicenseKey;  // File License Key ........... ["AJP-2D69-9CF3-192C-81AA-EBDD-ENG"]  -- [PUBLIC]
        private int _nDurationDays;	        // License Duration in Days ... 365
        private int _nRemainingDays;        // Number of day remaining on AJP License
        private DateTime _dtStartDate;	    // Start Date ................. "7/4/2022"
        private DateTime _dtEndDate;	    // End Date ................... "7/4/2023"
        #endregion      // LICENSE FIELDS .... [ === MODIFY PER LICENSE === ]

        #endregion      // FIELDS

        #region PROPERTIES

        #region FileHash  ... [NOT part of MASH]
        /// <summary>
        /// FileHash Property  ...  File Hash String ......... Hash String Read from XML File ... [PUBLIC]
        /// </summary>
        public string FileHash
        {
            get { return _strFileHash; }
            set { _strFileHash = value; }
        }
        #endregion      // FileHash

        #region RunTimeDeviceName  ... [NOT part of MASH]
        /// <summary>
        /// RunTimeDeviceName Property  ...  Name of Device Running App ... "GM-DESKTOP"
        /// </summary>
        public string RunTimeDeviceName
        {
            get { return _strRunTimeDeviceName; }
            set { _strRunTimeDeviceName = value; }
        }
        #endregion      // RunTimeDeviceName

        #region RunTimeUserName  ... [NOT part of MASH]
        /// <summary>
        /// RunTimeUserName Property  ...  Name of User Running App ..... [Environment.UserName]
        /// </summary>
        public string RunTimeUserName
        {
            get { return _strRunTimeUserName; }
            set { _strRunTimeUserName = value; }
        }
        #endregion      // RunTimeUserName

        #region SUPPLIER PROPERTIES  ... [ *** FIXED *** -> ALL CUSTOMERS -> ALL PRODUCTS ]

        #region Author  ... [NOT part of MASH]
        /// <summary>
        /// Author Property  ...  Author ............ Product Developer ....... "AJP Engineering"
        /// </summary>
        public string Author
        {
            get { return _strAuthor; }
            set { _strAuthor = value; }
        }
        #endregion      // Author

        #region SupplierName  ... [part of MASH]
        /// <summary>
        /// SupplierName Property  ...  Supplier Name ..... Manufacturer ............ "AJP Engineering"
        /// </summary>
        public string SupplierName
        {
            get { return _strSupplierName; }
            set { _strSupplierName = value; }
        }
        #endregion      // SupplierName

        #region SupplierUrl  ... [NOT part of MASH]
        /// <summary>
        /// SupplierUrl Property  ...  Supplier URL ...... AJP Web Site ............ "http:://www.AJPEngineering.com"
        /// </summary>
        public string SupplierUrl
        {
            get { return _strSupplierUrl; }
            set { _strSupplierUrl = value; }
        }
        #endregion      // SupplierUrl

        #endregion      // SUPPLIER PROPERTIES  ... [ *** FIXED *** -> ALL CUSTOMERS -> ALL PRODUCTS ]

        #region CUSTOMER CONTACT PROPERTIES .... [=== MODIFY PER CUSTOMER ===]

        #region CustomerName  ... [part of MASH]
        /// <summary>
        /// CustomerName Property  ...  Customer Name .... Customer Name .... "Bill Cashman"
        /// </summary>
        public string CustomerName
        {
            get { return _strCustomerName; }
            set { _strCustomerName = value; }
        }
        #endregion      // CustomerName

        #region CustomerEmail  ... [NOT part of MASH]
        /// <summary>
        /// CustomerName Property  ...  Customer Email ... Customer Email ... "BillCashman@exxon.com"
        /// </summary>
        public string CustomerEmail
        {
            get { return _strCustomerEmail; }
            set { _strCustomerEmail = value; }
        }
        #endregion      // CustomerEmail

        #endregion      // CUSTOMER CONTACT PROPERTIES .... [=== MODIFY PER CUSTOMER ===]

        #region PRODUCT PROPERTIES ..... [ === MODIFY PER PRODUCT === ]  .... Set by Developer per Product Soluion

        #region ProductName  ... [part of MASH]
        /// <summary>
        /// ProductName Property  ...  Product Name ...... AJP Product Name ........ "AJP Test 1.0"
        /// </summary>
        public string ProductName
        {
            get { return _strProductName; }
            set { _strProductName = value; }
        }
        #endregion      // ProductName

        #region ProductVersion  ... [part of MASH]
        /// <summary>
        /// ProductVersion Property  ...  Product Version ... Full Version ............ "1.0.0"
        /// </summary>
        public string ProductVersion
        {
            get { return _strProductVersion; }
            set { _strProductVersion = value; }
        }
        #endregion      // ProductVersion

        #region SerialNumber  ... [part of MASH]
        /// <summary>
        /// SerialNumber Property  ...  Serial Number ..... AJP Number .............. "1022-456-1189"
        /// </summary>
        public string SerialNumber
        {
            get { return _strSerialNumber; }
            set { _strSerialNumber = value; }
        }
        #endregion      // SerialNumber

        #region ProductCode  ... [part of MASH]
        /// <summary>
        /// ProductCode Property  ...  Product Code ...... Microsoft Format ........ "{3378CA35-F929-4E12-B8C7-0102DCE47C81}"
        /// </summary>
        public string ProductCode
        {
            get { return _strProductCode; }
            set { _strProductCode = value; }
        }
        #endregion      // ProductCode

        #endregion      // PRODUCT PROPERTIES ..... [ === MODIFY PER PRODUCT === ]  .... Set by Developer per Product Soluion

        #region LICENSE TYPE FIELDS .... [ === MODIFY PER LICENSE === ]

        #region LicenseTypeStr  ... [part of MASH]
        /// <summary>
        /// LicenseType Property  ...  License Type ...... ["TRIAL" | "SITE" | "DEVICE" | "USER" | "SEAT"]
        /// Enum defined in LicenseTypes Class ... string is ToString() of Enum
        /// </summary>
        public string LicenseType
        {
            get { return _strlicenseType; }
            set { _strlicenseType = value; }
        }
        #endregion      // LicenseType

        #region Corporation  ... [part of MASH]
        /// <summary>
        /// Corporation Property  ...  Corporation ...... User Corporation ... "Exxon"
        /// </summary>
        public string Corporation
        {
            get { return _strCorporation; }
            set { _strCorporation = value; }
        }
        #endregion      // Corporation

        #region Division  ... [part of MASH]
        /// <summary>
        /// Division Property  ...  Division ...... User Division ...... "Research and Development"
        /// </summary>
        public string Division
        {
            get { return _strDivision; }
            set { _strDivision = value; }
        }
        #endregion      // Division

        #region Group  ... [part of MASH]
        /// <summary>
        /// Group Property  ...  Group ......... User Group ......... "Heat Exchanger Group"
        /// </summary>
        public string Group
        {
            get { return _strGroup; }
            set { _strGroup = value; }
        }
        #endregion      // Group

        #region UserName   ... [part of USER & SEAT MASHES]
        /// <summary>
        /// UserName Property  ...  User Name ...... User Name .......... "Joey Bots"
        /// </summary>
        public string UserName
        {
            get { return _strUserName; }
            set { _strUserName = value; }
        }
        #endregion      // UserName

        #region DeviceName ... [part of SEAT MASH]
        /// <summary>
        /// DeviceName Property  ...  Device Name .... User Device ........ "GM-DESKTOP"
        /// </summary>
        public string DeviceName
        {
            get { return _strDeviceName; }
            set { _strDeviceName = value; }
        }
        #endregion      // DeviceName

        #endregion      // LICENSE TYPE FIELDS .... [ === MODIFY PER LICENSE === ]

        #region LICENSE PROPERTIES .... [ === MODIFY PER LICENSE === ] 

        #region FileLicenseKey  ... FILE LICENSE KEY   -- [PUBLIC]  ... [NOT part of HASH-MASH]
        /// <summary>
        /// FileLicenseKey Property  ...  File License Key String ... ["AJP-2D69-9CF3-192C-81AA-EBDD-ENG"] [PUBLIC]  ... [NOT part of HASH-MASH]
        /// </summary>
        public string FileLicenseKey
        {
            get { return _strFileLicenseKey; }
            set { _strFileLicenseKey = value; }
        }
        #endregion      // FileLicenseKey  ... CALCULATED LICENSE KEY

        #region DurationDays  ... [part of HASH-MASH]
        /// <summary>
        /// DurationDays Property  ...  License Duration in Days ... 365
        /// </summary>
        public int DurationDays
        {
            get { return _nDurationDays; }
            set { _nDurationDays = value; }
        }
        #endregion      // DurationDays

        #region RemainingDays  ... [NOT part of HASH-MASH]
        /// <summary>
        /// RemainingDays Property  ...  Number of day remaining on AJP License
        /// </summary>
        public int RemainingDays
        {
            get { return _nRemainingDays; }
            set { _nRemainingDays = value; }
        }
        #endregion      // RemainingDays

        #region StartDate  ... [part of HASH-MASH]
        /// <summary>
        /// StartDate Property  ...  Start Date ................. "7/4/2022"
        /// </summary>
        public DateTime StartDate
        {
            get { return _dtStartDate; }
            set { _dtStartDate = value; }
        }
        #endregion      // StartDate

        #region EndDate  ... [part of HASH-MASH]
        /// <summary>
        /// EndDate Property  ...  End Date ................... "7/4/2023"
        /// </summary>
        public DateTime EndDate
        {
            get { return _dtEndDate; }
            set { _dtEndDate = value; }
        }
        #endregion      // EndDate

        #endregion      // LICENSE PROPERTIES .... [ === MODIFY PER LICENSE === ]

        #endregion      // PROPERTIES

        #region CTOR: LicenseFileData
        /// <summary>
        /// Default CTOR
        /// </summary>
        public LicenseFileData()
        {
            string strMethod = "CTOR: LicenseFileData";
            string strMsg = String.Empty;
            try
            {
                FileHash = string.Empty;        // File Hash String ......... Hash String Read from XML File ... [PUBLIC]

                RunTimeDeviceName = Environment.MachineName;   // Name of Device Running App ... "GM-DESKTOP"
                RunTimeUserName = Environment.UserName;        // Name of User Running App ..... [Environment.UserName]
                //----------------------------------------------------------------------------------------------
                //--- Initialize Supplier Properties  ... [ *** FIXED *** -> ALL CUSTOMERS -> ALL PRODUCTS ] ---
                //----------------------------------------------------------------------------------------------
                Author = AUTHOR;                    // Author ............ Product Developer ... "AJP Engineering"
                SupplierName = SUPPLIER_NAME;       // Supplier Name ..... Manufacturer ........ "AJP Engineering"
                SupplierUrl = SUPPLIER_URL;         // Supplier URL ...... AJP Web Site ........ "http:://www.AJPEngineering.com"
                //-----------------------------------------------------------------------------------
                //--- Initialize Customer Contact Properties .... [ === MODIFY PER CUSTOMER === ] ---
                //-----------------------------------------------------------------------------------
                CustomerName  = CUSTOMER_NAME;       // Customer Name ..... Customer Name ...... "Bill Cashman" ------------ [part of MASH] ---
                CustomerEmail = CUSTOMER_EMAIL;      // Customer Email .... Customer Email ..... "BillCashman@exxon.com" --- [part of MASH] ---
                //--------------------------------------------------------------------------------------------------------------------
                //--- Initialize Product Properties ..... [ === MODIFY PER PRODUCT === ]  ... Set by Developer per Product Soluion ---
                //--------------------------------------------------------------------------------------------------------------------
                ProductName = PRODUCT_NAME;         // Product Name ...... AJP Product Name .... "AJP Pinch"
                ProductVersion = PRODUCT_VERSION;   // Product Version ... Full Version ........ "4.0.1"
                SerialNumber = SERIAL_NUMBER;       // Serial Number ..... AJP Number .......... "1022-456-1189" --- [part of MASH] ---
                ProductCode = PRODUCT_CODE;         // Product Code ...... AJP GUID ............ "{3D9721BA-003E-4711-B7AF-B579645F0AC9}"
                //-------------------------------------------------------------------------------
                //--- Initialize License Type Properties ..... [ === MODIFY PER LICENSE === ] ---
                //-------------------------------------------------------------------------------
                LicenseType = LICENSE_TYPE.ToString(); // License Type ...... ["TRIAL"] ------------------------------------ [part of MASH] ---

                Corporation = CORPORATION;  // Corporation ....... User Corporation ... "ExxonMobile" ----------------- [part of MASH] ---
                Division = DIVISION;        // Division .......... User Division ...... "Research and Development" ---- [part of MASH] ---
                Group = GROUP;              // Group ............. User Group ......... "Heat Exchanger Group" -------- [part of MASH] ---
                
                DeviceName = DEVICE_NAME;	// Device Name ....... User Device ........ "GM-DESKTOP" ---- [part of DEVICE & SEAT MASHES] ---
                UserName = USERNAME;        // User Name ......... User Name .......... "baseb" --------- [part of USER  & SEAT MASHES] ---

                //------------------------------------------------------------------------
                //--- Initialize License Properties  .... [=== MODIFY PER LICENSE ===] ---
                //------------------------------------------------------------------------
                FileLicenseKey = string.Empty;              // File License Key String ... ["AJP-2D69-9CF3-192C-81AA-EBDD-ENG"] [PUBLIC]  ... [NOT part of HASH-MASH]

                DurationDays = FULL_DURATION_DAYS;          // License Duration in Days ... 365 ...... [*** FIXED ***]
                StartDate = DateTime.Now;	                // Start Date ................. "7/4/2022" ------------------- [part of HASH-MASH] ---
                EndDate = StartDate.AddDays(DurationDays);  // End Date ................... "7/4/2023" ------------------- [part of HASH-MASH] ---

                RemainingDays = FULL_DURATION_DAYS;         // Number of day remaining on AJP License ---------------- [NOT part of HASH-MASH] ---
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
        }
        #endregion      // CTOR: LicenseFileData

        //=============================================================================================================
        //----------------------------------------------- XML METHODS -------------------------------------------------
        //=============================================================================================================

        #region RestoreLicenseXmlFile  .. READ FROM XML FILE
        /// <summary>
        /// Read the AJP License XML File and Populate Properties
        /// </summary>
        /// <param name="strFullPathXmlFile">Full Path AJP License XML File Location</param>
        public void RestoreLicenseXmlFile(string strFullPathXmlFile)
        {
            string strMethod = "RestoreLicenseXmlFile";
            string strMsg = String.Empty;

            string strAttribute = string.Empty;
            string strDurationDays = string.Empty;
            string strDateTime = string.Empty;

            XmlReaderSettings settings;
            try
            {
                #region GUARD: CHECK IF INPUT XML FILE LOCATION EXISTS
                if (!File.Exists(strFullPathXmlFile))
                {
                    strMsg = "**** XML FILE DOES NOT EXIST! ****";
                    MessageBox.Show(strMsg, "License File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw (new Exception(strMsg));
                }
                #endregion      // GUARD: CHECK IF INPUT XML FILE LOCATION EXISTS

                #region LOG HEADER
                Console.WriteLine(" ");
                Console.WriteLine(" ---------------------------------- ");
                Console.WriteLine(" -----  READING XML STARTED!  ----- ");
                Console.WriteLine(" ---------------------------------- ");
                Console.WriteLine(" ");
                #endregion      // LOG HEADER

                //---------------------
                //--- Open XML File ---
                //---------------------
                settings = new XmlReaderSettings();
                settings.DtdProcessing = DtdProcessing.Parse;
                using (XmlReader reader = XmlReader.Create(strFullPathXmlFile, settings))
                {
                    //----------------------------------------
                    //--- Parse the File and Log Each Node ---
                    //----------------------------------------                    
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            #region ELEMENT
                            //---------------------------------------------------------------------------------------------
                            case XmlNodeType.Element:
                                strMsg = String.Format("<{0}>", reader.Name);
                                switch (reader.Name)
                                {
                                    #region AJP_LICENSE
                                    case ELEMENT_AJP_LICENSE:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        FileHash = strAttribute;
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_AJP_LICENSE, ATTRIBUTE_HASH, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // AJP_LICENSE

                                    #region AUTHOR
                                    case ELEMENT_AUTHOR:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        Author = strAttribute;
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_AUTHOR, ATTRIBUTE_VALUE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // AUTHOR

                                    #region SUPPLIER_NAME
                                    case ELEMENT_SUPPLIER_NAME:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        SupplierName = strAttribute;
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_SUPPLIER_NAME, ATTRIBUTE_VALUE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // SUPPLIER_NAME

                                    #region SUPPLIER_URL
                                    case ELEMENT_SUPPLIER_URL:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        SupplierUrl = strAttribute;
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_SUPPLIER_URL, ATTRIBUTE_VALUE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // SUPPLIER_NAME

                                    #region CUSTOMER_NAME
                                    case ELEMENT_CUSTOMER_NAME:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        CustomerName = strAttribute;
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_CUSTOMER_NAME, ATTRIBUTE_VALUE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // CUSTOMER_NAME

                                    #region CUSTOMER_EMAIL
                                    case ELEMENT_CUSTOMER_EMAIL:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        CustomerEmail = strAttribute;
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_CUSTOMER_EMAIL, ATTRIBUTE_VALUE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // CUSTOMER_EMAIL

                                    #region PRODUCT_NAME
                                    case ELEMENT_PRODUCT_NAME:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        ProductName = strAttribute;
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_PRODUCT_NAME, ATTRIBUTE_VALUE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // PRODUCT_NAME

                                    #region PRODUCT_VERSION
                                    case ELEMENT_PRODUCT_VERSION:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        ProductVersion = strAttribute;
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_PRODUCT_VERSION, ATTRIBUTE_VALUE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // PRODUCT_VERSION

                                    #region PRODUCT_SERIAL_NUMBER
                                    case ELEMENT_PRODUCT_SERIAL_NUMBER:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        SerialNumber = strAttribute;
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_PRODUCT_SERIAL_NUMBER, ATTRIBUTE_VALUE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // PRODUCT_SERIAL_NUMBER

                                    #region PRODUCT_CODE
                                    case ELEMENT_PRODUCT_CODE:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        ProductCode = strAttribute;
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_PRODUCT_CODE, ATTRIBUTE_VALUE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // PRODUCT_CODE

                                    #region LICENSE_TYPE
                                    case ELEMENT_LICENSE_TYPE:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        LicenseType = strAttribute;
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_LICENSE_TYPE, ATTRIBUTE_VALUE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // LICENSE_TYPE

                                    #region CORPORATION
                                    case ELEMENT_CORPORATION:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        Corporation = strAttribute;
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_CORPORATION, ATTRIBUTE_VALUE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // CORPORATION

                                    #region DIVISION
                                    case ELEMENT_DIVISION:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        Division = strAttribute;
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_DIVISION, ATTRIBUTE_VALUE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // DIVISION

                                    #region GROUP
                                    case ELEMENT_GROUP:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        Group = strAttribute;
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_GROUP, ATTRIBUTE_VALUE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // GROUP

                                    #region USER_NAME
                                    case ELEMENT_USER_NAME:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        UserName = strAttribute;
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_USER_NAME, ATTRIBUTE_VALUE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // USER_NAME

                                    #region DEVICE_NAME
                                    case ELEMENT_DEVICE_NAME:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        DeviceName = strAttribute;
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_DEVICE_NAME, ATTRIBUTE_VALUE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // DEVICE_NAME

                                    #region LICENSE_KEY
                                    case ELEMENT_LICENSE_KEY:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        FileLicenseKey = strAttribute;
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_LICENSE_KEY, ATTRIBUTE_VALUE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // LICENSE_KEY

                                    #region LICENSE_DURATION
                                    case ELEMENT_LICENSE_DURATION:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        strDurationDays = strAttribute;
                                        DurationDays = Convert.ToInt32(DurationDays);
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_LICENSE_DURATION, ATTRIBUTE_DAYS, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // LICENSE_DURATION

                                    #region LICENSE_START
                                    case ELEMENT_LICENSE_START:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        strDateTime = strAttribute;
                                        StartDate = Convert.ToDateTime(strDateTime);
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_LICENSE_START, ATTRIBUTE_DATE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // LICENSE_START

                                    #region LICENSE_END
                                    case ELEMENT_LICENSE_END:
                                        //--- Read Attributes ---
                                        strAttribute = reader.GetAttribute(0);
                                        //--- Get Properties ---
                                        strDateTime = strAttribute;
                                        EndDate = Convert.ToDateTime(strDateTime);
                                        //--- Log to Console ---
                                        strMsg = String.Format(" ---> {0} {1}: {2}",
                                                               ELEMENT_LICENSE_END, ATTRIBUTE_DATE, strAttribute);
                                        LogXmlRowToConsole(strMsg);
                                        break;
                                    #endregion      // LICENSE_END

                                    #region default
                                    default:
                                        LogXmlRowToConsole(reader.Name);
                                        break;
                                        #endregion      // default
                                }
                                break;
                            #endregion      // ELEMENT

                            #region TEXT
                            //---------------------------------------------------------------------------------------------
                            case XmlNodeType.Text:
                                strMsg = reader.Value;
                                break;
                            #endregion      // TEXT

                            #region CDATA
                            //---------------------------------------------------------------------------------------------
                            case XmlNodeType.CDATA:
                                strMsg = String.Format("<![CDATA[{0}]]>", reader.Value);
                                break;
                            #endregion      // CDATA

                            #region PROCESSING INSTRUCTIONS
                            //---------------------------------------------------------------------------------------------
                            case XmlNodeType.ProcessingInstruction:
                                strMsg = String.Format("<?{0} {1}?>", reader.Name, reader.Value);
                                break;
                            #endregion      // PROCESSING INSTRUCTIONS

                            #region COMMENT
                            //---------------------------------------------------------------------------------------------
                            case XmlNodeType.Comment:
                                strMsg = String.Format("<!--{0}-->", reader.Value);
                                break;
                            #endregion      // COMMENT

                            #region XML DECLARATION
                            //---------------------------------------------------------------------------------------------
                            case XmlNodeType.XmlDeclaration:
                                strMsg = "<?xml version='1.0'?>";
                                break;
                            #endregion      // XML DECLARATION

                            #region DOCUMENT
                            //---------------------------------------------------------------------------------------------
                            case XmlNodeType.Document:
                                break;
                            #endregion      // DOCUMENT

                            #region DOCUMENT TYPE
                            //---------------------------------------------------------------------------------------------
                            case XmlNodeType.DocumentType:
                                strMsg = String.Format("<!DOCTYPE {0} [{1}]", reader.Name, reader.Value);
                                break;
                            #endregion      // DOCUMENT TYPE

                            #region ENTITY REFERENCE
                            //---------------------------------------------------------------------------------------------
                            case XmlNodeType.EntityReference:
                                strMsg = reader.Name;
                                break;
                            #endregion      // ENTITY REFERENCE

                            #region END ELEMENT
                            //---------------------------------------------------------------------------------------------
                            case XmlNodeType.EndElement:
                                strMsg = String.Format("</{0}>", reader.Name);
                                break;
                                #endregion      // END ELEMENT
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }

            #region LOG FOOTER
            Console.WriteLine(" ");
            Console.WriteLine(" ------------------------------------ ");
            Console.WriteLine(" -----  READING XML COMPLETED!  ----- ");
            Console.WriteLine(" ------------------------------------ ");
            Console.WriteLine(" ");
            #endregion      // LOG FOOTER
        }
        #endregion      // RestoreLicenseXmlFile  .. READ FROM XML FILE

        //=============================================================================================================
        //---------------------------------------------- HELPER METHOD ------------------------------------------------
        //=============================================================================================================

        #region GetRemainingDays
        /// <summary>
        /// Get Remainging Days Left on the AJP License and Populate the Property
        /// </summary>
        /// <returns>Total number of Remainging Days Left on the AJP License</returns>
        public int GetRemainingDays()
        {
            string strMethod = "GetRemainingDays";
            string strMsg = String.Empty;
            try
            {
                DateTime dt = DateTime.Now;
                //-----------------------------------------------------------------------------------
                //--- Calculate the Remainging Days Left on the AJP License ... Populate Property ---
                //-----------------------------------------------------------------------------------
                TimeSpan span = EndDate.Subtract(dt);
                RemainingDays = Convert.ToInt32(span.TotalDays);
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            return RemainingDays;
        }
        #endregion      // GetRemainingDays

        #region GetMashString
        /// <summary>
        /// Get the Mash string based on the appropriate properties in this object.
        /// Properties populated based on AJP License XML file contents.
        /// The Mash string is dependent on the suite of components associated each License type.
        /// -----------------------------------------------------------------------------------------------------------
        ///   NOTE: AJP License XML File will contain a public License Key that will be compared to the key generated
        ///         using this Mash string.
        /// -----------------------------------------------------------------------------------------------------------
        /// </summary>
        /// <returns>Mash string on success; "AJP-ERROR_CREATING_MASH-ENG" otherwise</returns>
        public string GetMashString()
        {
            string strMethod = "GetMashString";
            string strMsg = String.Empty;
            string strMash = string.Empty;
            try
            {
                //-----------------------------------------------------------
                //--- Get Mash String for Key Independent of License Type ---
                //-----------------------------------------------------------
                strMash = string.Format("AJP-{0}_{1}_{2}_{3}_{4}_{5}_{6}_{7}_{8}_{9}_{10}_{11}_{12}-ENG",
                        LicenseType,
                        SupplierName,
                        CustomerName,
                        ProductName,
                        ProductVersion,
                        SerialNumber,
                        ProductCode,
                        Corporation,
                        Division,
                        Group,
                        UserName,
                        DeviceName,
                        "B052122");

                #region PRE-REVISION 4.0 ... MASH BASED ON LICENSE TYPE
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                ////--------------------------------------
                ////--- Get MASH Based on License Type ---
                ////--------------------------------------
                //if (string.Compare(SITE, LicenseType) ==0)
                //{
                //    #region SITE MASH STRING
                //    strMash = string.Format("AJP-{0}_{1}_{2}_{3}_{4}_{5}_{6}_{7}_{8}_{9}-ENG",
                //                            LicenseType,
                //                            SupplierName,
                //                            CustomerName,
                //                            ProductName,
                //                            ProductVersion,
                //                            SerialNumber,
                //                            ProductCode,
                //                            Corporation,
                //                            Division,
                //                            Group);
                //    #endregion      // SITE MASH STRING
                //}
                //else if (string.Compare(USER, LicenseType) == 0)
                //{
                //    #region USER MASH STRING
                //    strMash = string.Format("AJP-{0}_{1}_{2}_{3}_{4}_{5}_{6}_{7}_{8}_{9}_{10}-ENG",
                //                            LicenseType,
                //                            SupplierName,
                //                            CustomerName,
                //                            ProductName,
                //                            ProductVersion,
                //                            SerialNumber,
                //                            ProductCode,
                //                            Corporation,
                //                            Division,
                //                            Group,
                //                            UserName);
                //    #endregion      // USER MASH STRING                
                //}
                //else if (string.Compare(SEAT, LicenseType) == 0)
                //{
                //    #region SEAT MASH STRING
                //    strMash = string.Format("AJP-{0}_{1}_{2}_{3}_{4}_{5}_{6}_{7}_{8}_{9}_{10}_{11}-ENG",
                //                            LicenseType,
                //                            SupplierName,
                //                            CustomerName,
                //                            ProductName,
                //                            ProductVersion,
                //                            SerialNumber,
                //                            ProductCode,
                //                            Corporation,
                //                            Division,
                //                            Group,
                //                            UserName,
                //                            DeviceName);
                //    #endregion      // SEAT MASH STRING                
                //}
                //else
                //{
                //    #region ERROR CREATING MASH
                //    Console.WriteLine(" ");
                //    Console.WriteLine(" ---------------------------------- ");
                //    Console.WriteLine(" *****  ERROR CREATING MASH!  ***** ");
                //    Console.WriteLine(" ---------------------------------- ");
                //    Console.WriteLine(" ");
                //    strMash = ERROR_CREATING_MASH;
                //    #endregion      // ERROR CREATING MASH
                //}
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                #endregion  // PRE-REVISION 4.0 ... MASH BASED ON LICENSE TYPE

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

        //=============================================================================================================
        //------------------------------------------------ LOG METHOD -------------------------------------------------
        //=============================================================================================================

        #region LogXmlRowToConsole
        /// <summary>
        /// Log XML Row data to Console
        /// </summary>
        /// <param name="strLogRowVal">XML Row String Value</param>
        private void LogXmlRowToConsole(string strLogRowVal)
        {
            string strMethod = "LogXmlRow";
            string strMsg = string.Empty;
            try
            {
                strMsg = String.Format(" {0}", strLogRowVal);
                System.Console.WriteLine(strMsg);
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                System.Console.WriteLine(strMsg);
            }
        }
        #endregion      // LogXmlRow

        #region LogDataToConsole
        /// <summary>
        /// Log Registration Data Values to the Console
        /// </summary>
        public void LogDataToConsole()
        {
            string strMethod = "LogDataToConsole";
            string strMsg = string.Empty;
            try
            {
                System.Console.WriteLine(" ======================================== ");
                System.Console.WriteLine("       LOG LICENSE FILE DATA VALUES       ");
                System.Console.WriteLine(" ======================================== ");

                strMsg = String.Format("          Author: {0} ", Author);
                System.Console.WriteLine(strMsg);

                strMsg = String.Format("    SupplierName: {0} ", SupplierName);
                System.Console.WriteLine(strMsg);

                strMsg = String.Format("     SupplierUrl: {0} ", SupplierUrl);
                System.Console.WriteLine(strMsg);

                System.Console.WriteLine(" ---------------------------------------- ");

                strMsg = String.Format("     CustomerName: {0} ", CustomerName);
                System.Console.WriteLine(strMsg);

                strMsg = String.Format("    CustomerEmail: {0} ", CustomerEmail);
                System.Console.WriteLine(strMsg);

                System.Console.WriteLine(" ---------------------------------------- ");

                strMsg = String.Format("      ProductName: {0} ", ProductName);
                System.Console.WriteLine(strMsg);

                strMsg = String.Format("   ProductVersion: {0} ", ProductVersion);
                System.Console.WriteLine(strMsg);

                strMsg = String.Format("     SerialNumber: {0} ", SerialNumber);
                System.Console.WriteLine(strMsg);

                strMsg = String.Format("      ProductCode: {0} ", ProductCode);
                System.Console.WriteLine(strMsg);

                System.Console.WriteLine(" ---------------------------------------- ");

                strMsg = String.Format("      LicenseType: {0} ", LicenseType);
                System.Console.WriteLine(strMsg);

                System.Console.WriteLine(" ---------------------------------------- ");

                strMsg = String.Format("      Corporation: {0} ", Corporation);
                System.Console.WriteLine(strMsg);

                strMsg = String.Format("         Division: {0} ", Division);
                System.Console.WriteLine(strMsg);

                strMsg = String.Format("            Group: {0} ", Group);
                System.Console.WriteLine(strMsg);

                System.Console.WriteLine(" ---------------------------------------- ");

                strMsg = String.Format("        User Name: {0} ", UserName);
                System.Console.WriteLine(strMsg);

                strMsg = String.Format("       DeviceName: {0} ", DeviceName);
                System.Console.WriteLine(strMsg);

                System.Console.WriteLine(" ---------------------------------------- ");

                strMsg = String.Format(" License Duration: {0} ", DurationDays);
                System.Console.WriteLine(strMsg);

                strMsg = String.Format("    License Start: {0} ", StartDate.ToString("MM/dd/yyyy"));
                System.Console.WriteLine(strMsg);

                strMsg = String.Format("      License End: {0} ", EndDate.ToString("MM/dd/yyyy"));
                System.Console.WriteLine(strMsg);

                strMsg = String.Format("      License Key: {0} ", FileLicenseKey);
                System.Console.WriteLine(strMsg);

                System.Console.WriteLine(" ======================================== ");

            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                System.Console.WriteLine(strMsg);
            }
        }
        #endregion      // LogDataToConsole

    }
    #endregion      // class LicenseFileData
}
#endregion      // namespace AJP_License_File

//=====================================================================================================================
//---------------------------------------------- E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
