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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

using AJP_License_File;
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

        private const String DEFAULT_LICENSE_FOLDERNAME = "LICENSE";
        private const String DEFAULT_LICENSE_FILENAME = "License.xml";
        #endregion      // CONSTANTS

        #region FIELDS
        private LicenseFileData _licenseFileData;  // License File Data object ... [namespace: AJP_LicenseFile]
        private LicenseMgr _licenseMgr;            // License Manager   object ... [namespace: AJP_LicenseFile]
        #endregion      // FIELDS

        #region PROPERTIES

        #region LicenseFileDataObj
        /// <summary>
        /// LicenseFileDataObj Property  ...  License File Data object ... [namespace: AJP_LicenseFile]
        /// </summary>
        public LicenseFileData LicenseFileDataObj
        {
            get { return _licenseFileData; }
            set { _licenseFileData = value; }
        }
        #endregion      // LicenseFileDataObj

        #region LicenseMgrObj
        /// <summary>
        /// LicenseMgrObj Property  ...  License Manager object ... [namespace: AJP_LicenseFile]
        /// </summary>
        public LicenseMgr LicenseMgrObj
        {
            get { return _licenseMgr; }
            set { _licenseMgr = value; }
        }
        #endregion      // LicenseMgrObj

        #endregion      // PROPERTIES

        #region CTOR: LicenseKeyMgr
        public LicenseKeyMgr()
        {
            string strMethod = "CTOR: LicenseKeyMgr";
            string strMsg = String.Empty;
            string strFileLoc = String.Empty;
            try
            {
                //-----------------------------
                //--- Initialize Properties ---
                //-----------------------------
                LicenseFileDataObj = new LicenseFileData();  // License File Data object ... [Namespace: AJP_License_File]
                strFileLoc = GetLicenseKeyFileLocation();
                LicenseMgrObj = new LicenseMgr(strFileLoc);  // License Mgr object ... [Namespace: AJP_License_File]
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
        //----------------------------------------------- XML METHODS -------------------------------------------------
        //=============================================================================================================

        #region GetLicenseKeyFileLocation()
        /// <summary>
        /// Get the Full-Path License File Location ... Rooted in AJP_LicenseGenerator.exe]
        /// </summary>
        /// <returns>Full-Path License File Location string on success; otherwise Empty</returns>
        public string GetLicenseKeyFileLocation()
        {
            string strMethod = "GetLicenseKeyFileLocation()";
            string strMsg = String.Empty;
            string strAppExecPath = String.Empty;
            string strLicenseFolderPath = String.Empty;
            string strLicenseFilePath = String.Empty;
            try
            {
                strAppExecPath = Path.GetDirectoryName(Application.ExecutablePath);
                strLicenseFolderPath = String.Format("{0}\\{1}", strAppExecPath, DEFAULT_LICENSE_FOLDERNAME);
                strLicenseFilePath = String.Format("{0}\\{1}", strLicenseFolderPath, DEFAULT_LICENSE_FILENAME);
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            return strLicenseFilePath;      // Return Full-Path License File Location [Root: AJP_LicenseGenerator exe]
        }
        #endregion  // GetLicenseKeyFileLocation()

        #region PersistLicenseXmlFile  ... WRITE TO XML FILE
        /// <summary>
        /// Write the LicenseFileDataObj Properties to the AJP License XML File
        /// </summary>
        /// <param name="licenseFileDataObj">License File Data Object</param>
        public void PersistLicenseXmlFile(LicenseFileData licenseFileDataObj)
        {
            string strMethod = "PersistLicenseXmlFile";
            string strMsg = String.Empty;
            XmlWriterSettings settings;

            LicenseFileDataObj = licenseFileDataObj;
            string strFullPathXmlFile = GetLicenseKeyFileLocation();

            string ELEMENT_SUPPLIER = "Supplier";
            string ELEMENT_CUSTOMER_CONTACT = "CustomerContact";
            string ELEMENT_PRODUCT = "Product";
            string ELEMENT_SITE = "Site";
            string ELEMENT_USER = "User";
            string ELEMENT_SEAT = "Seat";
            string ELEMENT_LICENSE = "License";
            try
            {
                #region LOG HEADER
                Console.WriteLine(" ");
                Console.WriteLine(" ---------------------------------- ");
                Console.WriteLine(" -----  WRITING XML STARTED!  ----- ");
                Console.WriteLine(" ---------------------------------- ");
                Console.WriteLine(" ");
                #endregion      // LOG HEADER

                //---------------------
                //--- Open XML File ---
                //---------------------
                settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = "\t";
                settings.NewLineOnAttributes = false;
                settings.CloseOutput = true;

                using (XmlWriter writer = XmlWriter.Create(strFullPathXmlFile, settings))
                {
                    writer.WriteStartDocument();

                    #region SECTION: AJP_License
                    writer.WriteStartElement(LicenseFileData.ELEMENT_AJP_LICENSE);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_HASH, licenseFileDataObj.FileHash);

                    #region SECTION: Supplier
                    writer.WriteStartElement(ELEMENT_SUPPLIER);

                    writer.WriteStartElement(LicenseFileData.ELEMENT_AUTHOR);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.Author);
                    writer.WriteEndElement();   // ELEMENT_AUTHOR

                    writer.WriteStartElement(LicenseFileData.ELEMENT_SUPPLIER_NAME);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.SupplierName);
                    writer.WriteEndElement();   // ELEMENT_SUPPLIER_NAME

                    writer.WriteStartElement(LicenseFileData.ELEMENT_SUPPLIER_URL);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.SupplierUrl);
                    writer.WriteEndElement();   // ELEMENT_SUPPLIER_URL

                    writer.WriteEndElement();   // ELEMENT_SUPPLIER
                    #endregion      // SECTION: Supplier

                    #region SECTION: Customer Contact
                    writer.WriteStartElement(ELEMENT_CUSTOMER_CONTACT);

                    writer.WriteStartElement(LicenseFileData.ELEMENT_CUSTOMER_NAME);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.CustomerName);
                    writer.WriteEndElement();   // ELEMENT_CUSTOMER_NAME

                    writer.WriteStartElement(LicenseFileData.ELEMENT_CUSTOMER_EMAIL);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.CustomerEmail);
                    writer.WriteEndElement();   // ELEMENT_CUSTOMER_EMAIL

                    writer.WriteEndElement();   // ELEMENT_CUSTOMER_CONTACT
                    #endregion      // SECTION: Customer Contact

                    #region SECTION: Product
                    writer.WriteStartElement(ELEMENT_PRODUCT);

                    writer.WriteStartElement(LicenseFileData.ELEMENT_PRODUCT_NAME);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.ProductName);
                    writer.WriteEndElement();   // ELEMENT_PRODUCT_NAME

                    writer.WriteStartElement(LicenseFileData.ELEMENT_PRODUCT_VERSION);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.ProductVersion);
                    writer.WriteEndElement();   // ELEMENT_PRODUCT_VERSION

                    writer.WriteStartElement(LicenseFileData.ELEMENT_PRODUCT_SERIAL_NUMBER);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.SerialNumber);
                    writer.WriteEndElement();   // ELEMENT_PRODUCT_SERIAL_NUMBER

                    writer.WriteStartElement(LicenseFileData.ELEMENT_PRODUCT_CODE);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.ProductCode);
                    writer.WriteEndElement();   // ELEMENT_PRODUCT_CODE

                    writer.WriteEndElement();   // ELEMENT_PRODUCT
                    #endregion      // SECTION: Product

                    #region SECTION: License Type
                    writer.WriteStartElement(LicenseFileData.ELEMENT_LICENSE_TYPE);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.LicenseType);

                    #region SECTION: Site
                    writer.WriteStartElement(ELEMENT_SITE);

                    writer.WriteStartElement(LicenseFileData.ELEMENT_CORPORATION);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.Corporation);
                    writer.WriteEndElement();   // ELEMENT_CORPORATION

                    writer.WriteStartElement(LicenseFileData.ELEMENT_DIVISION);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.Division);
                    writer.WriteEndElement();   // ELEMENT_DIVISION

                    writer.WriteStartElement(LicenseFileData.ELEMENT_GROUP);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.Group);
                    writer.WriteEndElement();   // ELEMENT_GROUP

                    writer.WriteEndElement();   // ELEMENT_SITE
                    #endregion      // SECTION: Site

                    #region SECTION: User
                    writer.WriteStartElement(ELEMENT_USER);

                    writer.WriteStartElement(LicenseFileData.ELEMENT_USER_NAME);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.UserName);
                    writer.WriteEndElement();   // ELEMENT_USER_NAME

                    writer.WriteEndElement();   // ELEMENT_USER
                    #endregion      // SECTION: User

                    #region SECTION: Seat
                    writer.WriteStartElement(ELEMENT_SEAT);

                    writer.WriteStartElement(LicenseFileData.ELEMENT_DEVICE_NAME);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.DeviceName);
                    writer.WriteEndElement();   // ELEMENT_DEVICE_NAME

                    writer.WriteEndElement();   // ELEMENT_SEAT
                    #endregion      // SECTION: Seat

                    writer.WriteEndElement();   // ELEMENT_LICENSE_TYPE
                    #endregion      // SECTION: License Type

                    #region SECTION: License
                    writer.WriteStartElement(ELEMENT_LICENSE);

                    writer.WriteStartElement(LicenseFileData.ELEMENT_LICENSE_KEY);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.FileLicenseKey);
                    writer.WriteEndElement();   // ELEMENT_LICENSE_KEY

                    writer.WriteStartElement(LicenseFileData.ELEMENT_LICENSE_DURATION);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.DurationDays.ToString());
                    writer.WriteEndElement();   // ELEMENT_LICENSE_DURATION

                    writer.WriteStartElement(LicenseFileData.ELEMENT_LICENSE_START);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.StartDate.ToString("MM/dd/yyyy"));
                    writer.WriteEndElement();   // ELEMENT_LICENSE_START

                    writer.WriteStartElement(LicenseFileData.ELEMENT_LICENSE_END);
                    writer.WriteAttributeString(LicenseFileData.ATTRIBUTE_VALUE, licenseFileDataObj.EndDate.ToString("MM/dd/yyyy"));
                    writer.WriteEndElement();   // ELEMENT_LICENSE_END

                    writer.WriteEndElement();   // ELEMENT_LICENSE
                    #endregion      // SECTION: License

                    writer.WriteEndElement();   // ELEMENT_AJP_LICENSE
                    #endregion      // SECTION: AJP_License

                    writer.WriteEndDocument();

                }   // using XmlWrite LOOP

                //--------------------------------------------------
                //--- Successfully Persisted AJP License to File ---
                //--------------------------------------------------
                strMsg = String.Format(" AJP License File SUCCESSFULL Persisted!\n\n[{0}]",strFullPathXmlFile);
                MessageBox.Show(strMsg, "AJP LICENSE GENERATOR",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            Console.WriteLine(" -----  WRITING XML COMPLETED!  ----- ");
            Console.WriteLine(" ------------------------------------ ");
            Console.WriteLine(" ");
            #endregion      // LOG FOOTER
        }
        #endregion      // PersistLicenseXmlFile  ... WRITE TO XML FILE

        //=============================================================================================================
        //----------------------------------------------- HASH METHODS ------------------------------------------------
        //=============================================================================================================
        //!!!!!!!!!!!!!!  Use Hash Methods from LicenseMgr class in _AJP License File project      !!!!!!!!!!!!!!!!!!!!
        //!!!!!!!!!!!!!!  Use License Data from LicenseFileData class in _AJP License File project !!!!!!!!!!!!!!!!!!!!
        //=============================================================================================================

    }
    #endregion      // class LicenseKeyMgr

}
#endregion      // namespace AJP_LicenseGenerator

//=====================================================================================================================
//---------------------------------------------- E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
