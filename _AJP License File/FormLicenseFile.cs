#region HEADER
//######################################################################################################
//###############################  F o r m L i c e n s e F i l e . c s  ################################
//######################################################################################################
//  FILENAME:  FormLicenseFile.cs
//  NAMESPACE: _AJP_License_File
//  CLASS(S):  FormLicenseFile
//  COMPONENT: _AJP_License_File.dll
//======================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the AJP License File main Form.
//    This class is a read-only AJP License File viewer.
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
//    (c)Copyright 2022 AJP Engineering
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion      // REFERENCES

#region namespace AJP_License_File
namespace AJP_License_File
{
    #region class FormLicenseFile
    /// <summary>
    /// License File Form
    /// </summary>
    public partial class FormLicenseFile : Form
    {
        #region CONSTANTS
        private const string NAMESPACE = "_AJP_License_File";
        private const string CLASS = "FormLicenseFile";

        #region CONSTANTS - PRODUCT SERIAL NUMBER
        private const string SERIAL_NUMBER_TRIAL = "3333-555-7777";
        private const string SERIAL_NUMBER_AJP_TEST = "1224-617-3554";
        private const string SERIAL_NUMBER_AJP_EXCHANGER_4_1 = "1119-777-1189";
        private const string SERIAL_NUMBER_AJP_LINEUP_1_0 = "0622-246-1963";
        private const string SERIAL_NUMBER_AJP_CYBER_SHIELD_1_0 = "0122-357-1959";
        private const string SERIAL_NUMBER_AJP_PINCH_3_0 = "1022-456-1189";
        private const string SERIAL_NUMBER_AJP_SUDOKU_1_0 = "0322-789-1957";
        #endregion      // CONSTANTS - PRODUCT SERIAL NUMBER

        #region CONSTANTS - LICENSE DURATIONS
        private const int DAYS_DURATION_TRIAL = 30;
        private const int DAYS_DURATION_FULL = 365;
        #endregion      // CONSTANTS - LICENSE DURATIONS

        #endregion      // CONSTANTS

        #region ENUMS

        #region ProductLicenceTypeEnum
        /// <summary>
        /// Product License Type Enumeration Values
        /// </summary>
        public enum ProductLicenceTypeEnum
        {
            FULL = 0,      // FULL  License
            TRIAL = 1       // TRIAL License
        }
        #endregion      // ProductLicenceTypeEnum

        #region ProductIdEnum
        /// <summary>
        /// Product ID (Name) Enumeration Values
        /// </summary>
        public enum ProductIdEnum
        {
            AJP_Test_1_0 = 0,   // PRODUCT: AJP Test 1.0
            AJP_Exchanger_4_1 = 1,   // PRODUCT: AJP Exchanger 4.1
            AJP_Lineup_1_0 = 2,   // PRODUCT: AJP Lineup 1.0
            AJP_CyberShield_1_0 = 3,   // PRODUCT: AJP CyberShield 1.0
            AJP_Pinch_3_0 = 4,   // PRODUCT: AJP Pinch 3.0
            AJP_Sudoku_1_0 = 5    // PRODUCT: AJP Sudoku 1.0
        }
        #endregion      // ProductIdEnum

        #endregion      // ENUMS

        #region FIELDS
        private string _strRunningDeviceName;           // Current Running Device Name

        private string _strCalcLicenseKey;              // Calculated AJP License Key String
        private string _strCalcLicenseFileHash;         // Calculated AJP License File Hash String

        private string _strFullPathLicenseFolder;       // Full-Path AJP LICENSE Folder Location
        private string _strFullPathXmlFile;             // Full-Path File Location of AJP License XML File
        private LicenseFileData _licenseFileDataObj;    // AJP License File Data Object

        private LicenseMgr _licenseFileMgrObj;       // AJP License File Mgr Object
        #endregion      // FIELDS

        #region PROPERTIES

        #region RunningDeviceName
        /// <summary>
        /// RunningDeviceName Property  ... Current Running Device Name
        /// </summary>
        public string RunningDeviceName
        {
            get { return _strRunningDeviceName; }
            set { _strRunningDeviceName = value; }
        }
        #endregion      // RunningDeviceName

        #region CalcLicenseKey
        /// <summary>
        /// CalcLicenseKey Property  ... Calculated AJP License Key String
        /// </summary>
        public string CalcLicenseKey
        {
            get { return _strCalcLicenseKey; }
            set { _strCalcLicenseKey = value; }
        }
        #endregion      // CalcLicenseKey

        #region CalcLicenseFileHash
        /// <summary>
        /// CalcLicenseFileHash Property  ... Calculated AJP License File Hash String
        /// </summary>
        public string CalcLicenseFileHash
        {
            get { return _strCalcLicenseFileHash; }
            set { _strCalcLicenseFileHash = value; }
        }
        #endregion      // CalcLicenseFileHash

        #region FullPathLicenseFolder
        /// <summary>
        /// FullPathLicenseFolder Property  ... Full-Path AJP LICENSE Folder Location
        /// </summary>
        public string FullPathLicenseFolder
        {
            get { return _strFullPathLicenseFolder; }
            set { _strFullPathLicenseFolder = value; }
        }
        #endregion      // FullPathLicenseFolder

        #region FullPathXmlFile
        /// <summary>
        /// FullPathXmlFile Property  ... Full-Path File Location of AJP License XML File
        /// </summary>
        public string FullPathXmlFile
        {
            get { return _strFullPathXmlFile; }
            set { _strFullPathXmlFile = value; }
        }
        #endregion      // FullPathXmlFile

        #region LicenseFileDataObj
        /// <summary>
        /// LicenseFileDataObj Property  ... AJP Licesne File Data Object
        /// </summary>
        public LicenseFileData LicenseFileDataObj
        {
            get { return _licenseFileDataObj; }
            set { _licenseFileDataObj = value; }
        }
        #endregion      // LicenseFileDataObj

        #region LicenseFileMgrObj
        /// <summary>
        /// LicenseFileMgrObj Property  ... AJP License File Mgr Object
        /// </summary>
        public LicenseMgr LicenseFileMgrObj
        {
            get { return _licenseFileMgrObj; }
            set { _licenseFileMgrObj = value; }
        }
        #endregion      // LicenseFileMgrObj

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public FormLicenseFile()
        {
            string strMethod = "FormLicenseFile";
            string strMsg = string.Empty;
            try
            {
                //-----------------------------
                //--- APPLICATION GENERATED ---
                //-----------------------------
                this.InitializeComponent();
                //-----------------------------
                //--- Initialize Properties ---
                //-----------------------------
                RunningDeviceName = "  " + Environment.MachineName;

                CalcLicenseKey = String.Empty;              // Calculated AJP License Key String
                CalcLicenseFileHash = String.Empty;         // Calculated AJP License File Hash String

                FullPathLicenseFolder = string.Empty;       // Full-Path AJP LICENSE Folder Location
                FullPathXmlFile = string.Empty;             // Full-Path File Location of AJP License XML File
                LicenseFileDataObj = new LicenseFileData(); // AJP License File Data Object
                LicenseFileMgrObj = new LicenseMgr();       // AJP License File Mgr Object
                //--------------------------
                //--- AJP INITIALIZATION ---
                //--------------------------
                InitControls();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // CTOR

        //=============================================================================================================
        //------------------------------------------ INITIALIZATION METHODS -------------------------------------------
        //=============================================================================================================

        #region InitControls
        private void InitControls()
        {
            textBoxAuthor.Text = string.Empty;              // Author
            textBoxSupplierName.Text = string.Empty;        // Supplier Name
            textBoxSupplierUrl.Text = string.Empty;         // Supplier URL

            textBoxCustomerName.Text = string.Empty;        // Customer Name
            textBoxCustomerEmail.Text = string.Empty;       // Customer Email

            textBoxProductName.Text = string.Empty;         // Product Name
            textBoxVersion.Text = string.Empty;             // Product Version
            textBoxSerialNumber.Text = string.Empty;        // Product Serial Number
            textBoxProductCode.Text = string.Empty;         // Product Code

            textBoxLicenseType.Text = string.Empty;         // License Type
            textBoxUsername.Text = string.Empty;            // User Name
            textBoxDeviceName.Text = string.Empty;          // Device Name

            textBoxCorporation.Text = string.Empty;         // Site - Corporation Name
            textBoxDivision.Text = string.Empty;            // Site - Division Name
            textBoxGroup.Text = string.Empty;               // Site - Group Name

            textBoxLicenseKey.Text = string.Empty;          // File License Key 
            textBoxStartDate.Text = string.Empty;           // License - Start Date 
            textBoxEndDate.Text = string.Empty;             // License - End Date 
            textBoxDuration.Text = string.Empty;            // License - Duration in Days

            textBoxHash.Text = string.Empty;                // License File - Hash
        }
        #endregion      // InitControls

        //=============================================================================================================
        //---------------------------------------------- EVENT METHODS ------------------------------------------------
        //=============================================================================================================

        #region FORM HANDLERS

        #region LOAD FORM
        /// <summary>
        /// Handle Load Form event ... after CTOR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLicenseFile_Load(object sender, EventArgs e)
        {
            string strMethod = "FormLicenseFile_Load";
            string strMsg = string.Empty;
            try
            {
                //------------------------------------------------------------------------------
                //--- Read AJP License XML File and Populate LicenseFileData Object Property ---
                //------------------------------------------------------------------------------
                RestoreXmlFile();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // LOAD FORM

        #region FORM CLOSING
        /// <summary>
        /// Handle Form Closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void FormLicenseFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            string strMethod = "FormLicenseFile_FormClosing";
            string strMsg = string.Empty;
            try
            {


            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // FORM CLOSING

        #endregion      // FORM HANDLERS

        #region BUTTON HANDLERS

        #region  DAYS REMAINING BUTTON HANDLER        
        private void buttonDaysRemaining_Click(object sender, EventArgs e)
        {
            string strMethod = "buttonDaysRemaining_Click";
            string strMsg = string.Empty;
            try
            {
                strMsg = String.Format("{0} days Remaining on the AJP License.",
                                       LicenseFileDataObj.GetRemainingDays());
                MessageBox.Show(strMsg, "AJP License", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // DAYS REMAINING BUTTON HANDLER

        #region OK BUTTON HANDLER
        private void buttonOk_Click(object sender, EventArgs e)
        {
            string strMethod = "buttonOk_Click";
            string strMsg = string.Empty;
            try
            {
                //--------------------
                //--- Close Dialog ---
                //--------------------
                Close();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // OK BUTTON HANDLER

        #endregion      // BUTTON HANDLERS

        #region PICTURE BOX LOGO CLICK
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            string strMethod = "pictureBoxLogo_Click";
            string strMsg = string.Empty;
            try
            {

            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // PICTURE BOX LOGO CLICK

        //=============================================================================================================
        //--------------------------------------------- PRIVATE METHODS -----------------------------------------------
        //=============================================================================================================

        #region RestoreXmlFile
        /// <summary>
        /// Read AJP License XML file and Populate the LicenseFileData Object Property
        /// </summary>
        private void RestoreXmlFile()
        {
            string strMethod = "RestoreXmlFile";
            string strMsg = string.Empty;

            string AJP_LICENSE_FOLDER = "AJP LICENSE";
            string AJP_LICENSE_FILE = "AJP License.xml";

            string strCheckLicenseFolder = string.Empty;
            string strCheckLicenseFile = string.Empty;
            try
            {
                #region GET FULL-PATH AJP LICENSE XML FILE LOCATION

                #region CHECK IF LICENSE XML FILE EXISTS
                //------------------------------------------
                //--- Check if AJP License Folder Exists ---
                //------------------------------------------
                strCheckLicenseFolder = string.Format(@"{0}\{1}", Application.StartupPath, AJP_LICENSE_FOLDER);
                if (!Directory.Exists(strCheckLicenseFolder))
                {
                    strMsg = string.Format(" *** AJP LICENSE Folder NOT FOUND!  [{0}]", strCheckLicenseFolder);
                    throw (new Exception(strMsg));
                }
                Console.WriteLine(" AJP LICENSE FOLDER FOUND!");

                //---------------------------------------
                //--- Check if AJP License File Exists ---
                //----------------------------------------
                strCheckLicenseFile = string.Format(@"{0}\{1}", strCheckLicenseFolder, AJP_LICENSE_FILE);
                if (!File.Exists(strCheckLicenseFile))
                {
                    strMsg = string.Format(" *** AJP LICENSE File NOT FOUND!  [{0}]", strCheckLicenseFile);
                    throw (new Exception(strMsg));
                }
                Console.WriteLine(" AJP LICENSE FILE FOUND!");
                #endregion      // CHECK IF LICENSE XML FILE EXISTS

                //-------------------------------------------------------------
                //--- Assign AJP License Folder Full-Path Location Property ---
                //-------------------------------------------------------------
                FullPathLicenseFolder = strCheckLicenseFolder;

                //---------------------------------------------------------------
                //--- Assign AJP License XML File Full-Path Location Property ---
                //---------------------------------------------------------------
                FullPathXmlFile = strCheckLicenseFile;

                #region LOG TO CONSOLE: FULL-PATH AJP LICENSE XML FILE LOCATION
                strMsg = string.Format(" ===> AJP LICENSE File:  [{0}]", strCheckLicenseFile);
                Console.WriteLine(strMsg);
                #endregion      // LOG TO CONSOLE: FULL-PATH AJP LICENSE XML FILE LOCATION

                #endregion      // GET FULL-PATH AJP LICENSE XML FILE LOCATION

                //----------------------------------------------------------------------------------------------
                //--- Use License File Data Object to Read AJP License XML File and Populate it's Properties ---
                //----------------------------------------------------------------------------------------------
                LicenseFileDataObj = new LicenseFileData();
                LicenseFileDataObj.RestoreLicenseXmlFile(FullPathXmlFile);                
                //--------------------------------------------------------------------
                //--- Update Form Controls based on the updated LicenseFileDataObj ---
                //--------------------------------------------------------------------
                UpdateControls();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // RestoreXmlFile

        #region UpdateControls
        /// <summary>
        /// Update the Form Controls based on the LicenseFileData Object Property values
        /// </summary>
        private void UpdateControls()
        {
            string strMethod = "UpdateControls";
            string strMsg = string.Empty;
            try
            {
                textBoxAuthor.Text = LicenseFileDataObj.Author;                 // Author
                textBoxSupplierName.Text = LicenseFileDataObj.SupplierName;     // Supplier Name
                textBoxSupplierUrl.Text = LicenseFileDataObj.SupplierUrl;       // Supplier URL

                textBoxCustomerName.Text = LicenseFileDataObj.CustomerName;     // Customer Name
                textBoxCustomerEmail.Text = LicenseFileDataObj.CustomerEmail;   // Customer Email   // Customer Email

                textBoxProductName.Text = LicenseFileDataObj.ProductName;       // Product Name
                textBoxVersion.Text = LicenseFileDataObj.ProductVersion;        // Product Version
                textBoxSerialNumber.Text = LicenseFileDataObj.SerialNumber;     // Product Serial Number
                textBoxProductCode.Text = LicenseFileDataObj.ProductCode;       // Product Code

                textBoxLicenseType.Text = LicenseFileDataObj.LicenseType;       // License Type
                textBoxUsername.Text = LicenseFileDataObj.UserName;             // User Name
                textBoxDeviceName.Text = LicenseFileDataObj.DeviceName;         // Device Name

                textBoxCorporation.Text = LicenseFileDataObj.Corporation;       // Site - Corporation Name
                textBoxDivision.Text = LicenseFileDataObj.Division;             // Site - Division Name
                textBoxGroup.Text = LicenseFileDataObj.Group;                   // Site - Group Name

                textBoxLicenseKey.Text = LicenseFileDataObj.FileLicenseKey;     // File License Key 
                textBoxHash.Text = LicenseFileDataObj.FileHash;                 // License File - Hash
                textBoxStartDate.Text = LicenseFileDataObj.StartDate.ToString("MM/dd/yyyy");    // License - Start Date 
                textBoxEndDate.Text = LicenseFileDataObj.EndDate.ToString("MM/dd/yyyy");        // License - End Date 
                textBoxDuration.Text = LicenseFileDataObj.DurationDays.ToString();              // License - Duration in Days
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // RestoreXmlFile

    }
    #endregion      // class FormLicenseFile
}
#endregion      // namespace AJP_License_File

//=====================================================================================================================
//---------------------------------------------- E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
