#region HEADER
//######################################################################################################
//######################################  F o r m M a i n . c s  #######################################
//######################################################################################################
//  FILENAME:  FormMain.cs
//  NAMESPACE: AJP_LicenseGenerator
//  CLASS(S):  FormMain
//  COMPONENT: AJP LicenseGenerator.exe
//======================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the AJP License Generator main Form.
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AJP_License_File;

using static AJP_License_File.FormLicenseFile;
#endregion      // REFERENCES

#region namespace AJP_LicenseGenerator
namespace AJP_LicenseGenerator
{
    #region class FormMain
    /// <summary>
    /// AJP License Generator Main Form
    /// </summary>
    public partial class FormMain : Form
    {
        #region CONSTANTS
        private const string NAMESPACE = "AJP_LicenseGenerator";
        private const string CLASS = "FormMain";

        #region CONSTANTS - PRODUCT NAME
        private const string PRODUCT_NAME_AJP_TEST          = "AJP Test 1.0";
        private const string PRODUCT_NAME_AJP_EXCHANGER     = "AJP Exchanger 4.1";
        private const string PRODUCT_NAME_AJP_LINEUP        = "AJP Lineup 1.0";
        private const string PRODUCT_NAME_AJP_CYBER_SHIELD  = "AJP CyberShield 1.0";
        private const string PRODUCT_NAME_AJP_PINCH         = "AJP Pinch 4.0";
        private const string PRODUCT_NAME_AJP_SUDOKU        = "AJP Sudoku 1.0";
        #endregion      // CONSTANTS - PRODUCT NAME

        #region CONSTANTS - PRODUCT VERSION
        private const string PRODUCT_VERSION_AJP_TEST           = "1.0.1";
        private const string PRODUCT_VERSION_AJP_EXCHANGER      = "4.1.1";
        private const string PRODUCT_VERSION_AJP_LINEUP         = "1.0.1";
        private const string PRODUCT_VERSION_AJP_CYBER_SHIELD   = "1.0.1";
        private const string PRODUCT_VERSION_AJP_PINCH          = "4.0.1";
        private const string PRODUCT_VERSION_AJP_SUDOKU         = "1.0.1";
        #endregion      // CONSTANTS - PRODUCT VERSION

        #region CONSTANTS - PRODUCT SERIAL NUMBER
        private const string SERIAL_NUMBER_AJP_TEST         = "1224-617-3554";
        private const string SERIAL_NUMBER_AJP_EXCHANGER    = "1119-777-1189";
        private const string SERIAL_NUMBER_AJP_LINEUP       = "0622-246-1963";
        private const string SERIAL_NUMBER_AJP_CYBER_SHIELD = "0122-357-1959";
        private const string SERIAL_NUMBER_AJP_PINCH        = "1022-456-1189";
        private const string SERIAL_NUMBER_AJP_SUDOKU       = "0322-789-1957";
        #endregion      // CONSTANTS - PRODUCT SERIAL NUMBER

        #region CONSTANTS - PRODUCT CODE
        private const string PRODUCT_CODE_AJP_TEST          = "{3378CA35-F929-4E12-B8C7-0102DCE47C81}";
        private const string PRODUCT_CODE_AJP_EXCHANGER     = "{F71FB607-7CC0-4B75-BBB5-372050DF940B}";
        private const string PRODUCT_CODE_AJP_LINEUP        = "{069DD815-4A07-4157-816B-6F01AE3F2AC8}";
        private const string PRODUCT_CODE_AJP_CYBER_SHIELD  = "{63C81673-6574-477D-92AB-0F05151F07EF}";
        private const string PRODUCT_CODE_AJP_PINCH         = "{3D9721BA-003E-4711-B7AF-B579645F0AC9}";
        private const string PRODUCT_CODE_AJP_SUDOKU        = "{A62351AC-ED9A-435B-A800-3DE580DF8D05}";
        #endregion      // CONSTANTS - PRODUCT CODE

        #region CONSTANTS - DEFAULT LICENSE DURATIONS
        private const int DEFAULT_DAYS_DURATION_TRIAL   = 30;   // Default  30 days for TRIAL
        private const int DEFAULT_DAYS_DURATION         = 365;  // Default 365 days for SITE | USER | SEAT
        #endregion      // CONSTANTS - DEFAULT LICENSE DURATIONS

        private const string DEFAULT_INGORE_FIELD = "ANY";      // Default Ignore Field ... e.g., "ANY"

        #endregion      // CONSTANTS

        #region ENUMS

        #region ProductNameEnum
        /// <summary>
        /// Product ID (Name) Enumeration Values
        /// </summary>
        public enum ProductNameEnum
        {
            AJP_Test        = 0,   // PRODUCT: AJP Test .......... Latest Version 1.0
            AJP_Exchanger   = 1,   // PRODUCT: AJP Exchanger ..... Latest Version 4.1
            AJP_Lineup      = 2,   // PRODUCT: AJP Lineup ........ Latest Version 1.0
            AJP_CyberShield = 3,   // PRODUCT: AJP CyberShield ... Latest Version 1.0
            AJP_Pinch       = 4,   // PRODUCT: AJP Pinch ......... Latest Version 4.0
            AJP_Sudoku      = 5    // PRODUCT: AJP Sudoku ........ Latest Version 1.0
        }
        #endregion      // ProductNameEnum

        #endregion      // ENUMS

        #region FIELDS
        private Color _colorFAIL;                  // FAIL Color
        private Color _colorSUCCESS;               // SUCCESS Color
        private Color _colorUNDECIDED;             // UNDECIDED Color
        private Color _colorDISABLED;              // DISABLED Color

        private LicenseTypes.LicenseTypeEnum _ajpLicenseType;  // AJP License Type Enumeration
        private ProductNameEnum _ajpProductName;               // AJP Product Name Enumeration

        private string _strFullPathLicenseFolder;  // Full-Path AJP LICENSE Folder Location
        private string _strFullPathXmlFile;        // Full-Path File Location of AJP License XML File

        private LicenseKeyMgr _licenseKeyMgr;      // AJP License Key Mgr Object
        #endregion      // FIELDS

        #region PROPERTIES

        #region ColorFAIL
        /// <summary>
        /// ColorFAIL Property  ... FAIL Color
        /// </summary>
        public Color ColorFAIL
        {
            get { return _colorFAIL; }
            set { _colorFAIL = value; }
        }
        #endregion      // ColorFAIL

        #region ColorSUCCESS
        /// <summary>
        /// ColorSUCCESS Property  ... SUCCESS Color
        /// </summary>
        public Color ColorSUCCESS
        {
            get { return _colorSUCCESS; }
            set { _colorSUCCESS = value; }
        }
        #endregion      // ColorSUCCESS

        #region ColorUNDECIDED
        /// <summary>
        /// ColorUNDECIDED Property  ... UNDECIDED Color
        /// </summary>
        public Color ColorUNDECIDED
        {
            get { return _colorUNDECIDED; }
            set { _colorUNDECIDED = value; }
        }
        #endregion      // ColorUNDECIDED

        #region ColorDISABLED
        /// <summary>
        /// ColorDISABLED Property  ... DISABLED Color
        /// </summary>
        public Color ColorDISABLED
        {
            get { return _colorDISABLED; }
            set { _colorDISABLED = value; }
        }
        #endregion      // ColorDISABLED

        #region AjpLicenseType
        /// <summary>
        /// AjpLicenseType Property  ... AJP License Type Enumeration
        /// </summary>
        public LicenseTypes.LicenseTypeEnum AjpLicenseType
        {
            get { return _ajpLicenseType; }
            set { _ajpLicenseType = value; }
        }
        #endregion      // AjpLicenseType

        #region AjpProductName
        /// <summary>
        /// AjpProductName Property  ... AJP Product Name Enumeration
        /// </summary>
        public ProductNameEnum AjpProductName
        {
            get { return _ajpProductName; }
            set { _ajpProductName = value; }
        }
        #endregion      // AjpProductName

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

        #region LicenseGeneratorMgrObj
        /// <summary>
        /// LicenseGeneratorMgrObj Property  ... AJP License Generator Mgr Object
        /// </summary>
        public LicenseKeyMgr LicenseKeyMgrObj
        {
            get { return _licenseKeyMgr; }
            set { _licenseKeyMgr = value; }
        }
        #endregion      // LicenseKeyMgrObj

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public FormMain()
        {
            string strMethod = "CTOR: FormMain";
            string strMsg = string.Empty;
            try
            {
                //-----------------------------
                //--- APPLICATION GENERATED ---
                //-----------------------------
                InitializeComponent();
                //-----------------------------
                //--- Initialize Properties ---
                //-----------------------------
                ColorFAIL = Color.MistyRose;                    // FAIL Color
                ColorSUCCESS = Color.MediumSpringGreen;         // SUCCESS Color
                ColorUNDECIDED = Color.WhiteSmoke;              // UNDECIDED Color
                ColorDISABLED = Color.WhiteSmoke;               // DISABLED Color

                AjpLicenseType = LicenseTypes.LicenseTypeEnum.SEAT; // AJP License Type Enumeration
                AjpProductName = ProductNameEnum.AJP_Test;      // AJP Product Name Enumeration

                FullPathLicenseFolder = String.Empty;           // Full-Path AJP LICENSE Folder Location
                FullPathXmlFile = String.Empty;                 // Full-Path File Location of AJP License XML File

                LicenseKeyMgrObj = new LicenseKeyMgr();         // Licence Key Manager Object (PERSIST XML)
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
            string strMethod = "InitControls";
            string strMsg = string.Empty;
            try
            {
                //-----------------------------------------------------------------------------
                //--- Product Name ComboBox ... Ensure Matches ProductNameEnum Index Values ---
                //-----------------------------------------------------------------------------
                comboBoxProduct.Items.Clear();
                comboBoxProduct.Items.Add(PRODUCT_NAME_AJP_TEST);               // Index 0
                comboBoxProduct.Items.Add(PRODUCT_NAME_AJP_EXCHANGER);          // Index 1
                comboBoxProduct.Items.Add(PRODUCT_NAME_AJP_LINEUP);             // Index 2
                comboBoxProduct.Items.Add(PRODUCT_NAME_AJP_CYBER_SHIELD);       // Index 3
                comboBoxProduct.Items.Add(PRODUCT_NAME_AJP_PINCH);              // Index 4
                comboBoxProduct.Items.Add(PRODUCT_NAME_AJP_SUDOKU);             // Index 5
                comboBoxProduct.SelectedIndex = 4;                              // Select AJP Pinch

                pictureBoxProductLogo.Image = Properties.Resources.AJP_Pinch_4;
                //------------------------------------------------------------------------------------
                //--- License Type ComboBox ... Ensure Matches ProductLicenceTypeEnum Index Values ---
                //------------------------------------------------------------------------------------
                comboBoxLicenseType.Items.Clear();
                comboBoxLicenseType.Items.Add(LicenseTypes.LicenseTypeEnum.TRIAL.ToString());  // Index 0
                comboBoxLicenseType.Items.Add(LicenseTypes.LicenseTypeEnum.SITE.ToString());   // Index 1
                comboBoxLicenseType.Items.Add(LicenseTypes.LicenseTypeEnum.DEVICE.ToString()); // Index 2
                comboBoxLicenseType.Items.Add(LicenseTypes.LicenseTypeEnum.USER.ToString());   // Index 3
                comboBoxLicenseType.Items.Add(LicenseTypes.LicenseTypeEnum.SEAT.ToString());   // Index 4
                comboBoxLicenseType.SelectedIndex = 0;                                         // Select Trial
                //-----------------------------------
                //--- Licence Type Group Controls ---
                //-----------------------------------
                //-------------------------------------------------------------- Initial: TRIAL ---
                textBoxDeviceName.Text = DEFAULT_INGORE_FIELD;
                textBoxUsername.Text = DEFAULT_INGORE_FIELD;
                textBoxCorporation.Text = DEFAULT_INGORE_FIELD;
                textBoxDivision.Text = DEFAULT_INGORE_FIELD;
                textBoxGroup.Text = DEFAULT_INGORE_FIELD;
                //------------------------------
                //--- License Group Controls ---
                //------------------------------
                textBoxLicenseKey.Text = String.Empty;
                textBoxHash.Text = String.Empty;
            
                numericUpDownDuration.Value = Convert.ToDecimal(365);   // 365 Days
                dateTimePickerStart.Value = DateTime.Now;               // Start Date

                UpdateEndDate();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
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
        private void FormMain_Load(object sender, EventArgs e)
        {
            string strMethod = "FormMain_Load";
            string strMsg = string.Empty;

            string AJP_LICENSE_FOLDER = "AJP LICENSE";
            string AJP_LICENSE_FILE = "AJP License.xml";
            try
            {
                #region ASSIGN LICENSE XML FILE LOCATION PROPERTY
                //------------------------------------------
                //--- Check if AJP License Folder Exists ---
                //------------------------------------------
                FullPathLicenseFolder = string.Format(@"{0}\{1}", Application.StartupPath, AJP_LICENSE_FOLDER);
                if (!Directory.Exists(FullPathLicenseFolder))
                {
                    strMsg = string.Format(" *** AJP LICENSE Folder NOT FOUND!  [{0}]", FullPathLicenseFolder);
                    throw (new Exception(strMsg));
                }
                Console.WriteLine(" AJP LICENSE FOLDER FOUND!");
                //---------------------------------------
                //--- Check if AJP License File Exists ---
                //----------------------------------------
                FullPathXmlFile = string.Format(@"{0}\{1}", FullPathLicenseFolder, AJP_LICENSE_FILE);
                #endregion      // ASSIGN LICENSE XML FILE LOCATION PROPERTY

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
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            string strMethod = "FormMain_FormClosing";
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

        #region GENERATE KEY BUTTON HANDLER
        private void buttonGenerateKey_Click(object sender, EventArgs e)
        {
            string strMethod = "buttonGenerateKey_Click";
            string strMsg = string.Empty;
            try
            {
                UpdateLicenseKeyValue();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // GENERATE KEY BUTTON HANDLER

        #region GENERATE HASH BUTTON HANDLER
        private void buttonHash_Click(object sender, EventArgs e)
        {
            string strMethod = "buttonHash_Click";
            string strMsg = string.Empty;
            try
            {
                UpdateHashValue();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // GENERATE HASH BUTTON HANDLER

        #region CREATE LICENSE FILE BUTTON HANDLER
        private void buttonLicenseFile_Click(object sender, EventArgs e)
        {
            string strMethod = "buttonLicenseFile_Click";
            string strMsg = string.Empty;
            try
            {
                CreateLicenseFile();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // CREATE LICENSE FILE BUTTON HANDLER

        #region OK BUTTON HANDLER
        private void buttonOk_Click(object sender, EventArgs e)
        {
            string strMethod = "buttonOk_Click";
            string strMsg = string.Empty;
            try
            {
                Application.Exit();
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

        #region COMBOBOX HANDLERS

        #region LICENSE TYPE COMBOBOX
        /// <summary>
        /// Select License Type Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxLicenseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strMethod = "comboBoxLicenseType_SelectedIndexChanged";
            string strMsg = string.Empty;
            try
            {
                //--------------------------------------------------------------------------------------------------
                //--- Update License Controls in the License Type Group Control based on Combobox Selected Index ---
                //--------------------------------------------------------------------------------------------------
                UpdateLicenseTypeControls();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // LICENSE TYPE COMBOBOX

        #region PRODUCT NAME COMBOBOX
        /// <summary>
        /// Select Product NAME Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strMethod = "comboBoxProduct_SelectedIndexChanged";
            string strMsg = string.Empty;
            try
            {
                //-------------------------------------------------------------------------------------------------
                //--- Update the Product Controls in the Product Group Control based on Combobox Selected Index ---
                //-------------------------------------------------------------------------------------------------
                UpdateProductControls();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // PRODUCT NAME COMBOBOX

        #endregion      // COMBOBOX HANDLERS

        #region DATE TIME PICKER HANDLERS

        #region INITIATION (START) DATE VALUE CHANGED
        private void dateTimePickerInitiation_ValueChanged(object sender, EventArgs e)
        {
            string strMethod = "dateTimePickerInitiation_ValueChanged";
            string strMsg = string.Empty;
            try
            {
                UpdateEndDate();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // INITIATION (START) DATE VALUE CHANGED

        #region END DATE VALUE CHANGED
        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            string strMethod = "dateTimePickerEnd_ValueChanged";
            string strMsg = string.Empty;
            try
            {
                UpdateStartDate();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // END DATE VALUE CHANGED

        #endregion      // DATE TIME PICKER HANDLERS

        #region DURATION NUMBER HANDLER
        private void numericUpDownDuration_ValueChanged(object sender, EventArgs e)
        {
            string strMethod = "numericUpDownDuration_ValueChanged";
            string strMsg = string.Empty;
            try
            {
                UpdateEndDate();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // DURATION NUMBER HANDLER

        #region LOGO PICTURE BOX CLICK
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            string strMethod = "pictureBoxLogo_Click";
            string strMsg = string.Empty;
            try
            {
                MessageBox.Show("TO DO: Launch View to View Created AJP License XML File.");

            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // LOGO PICTURE BOX CLICK

        //=============================================================================================================
        //----------------------------------------- UPDATE KEY & HASH METHODS -----------------------------------------
        //=============================================================================================================

        #region ValidLicenseKeyInput
        private bool ValidLicenseKeyInput()
        {
            string strMethod = "UpdateLicenseKeyValue";
            string strMsg = string.Empty;
            LicenseTypes.LicenseTypeEnum licenseType = LicenseTypes.LicenseTypeEnum.UNKNOWN;
            bool bValidData = false;
            try
            {
                //-----------------------------
                //--- Check for Valid Input ---
                //-----------------------------
                licenseType = GetLicenseTypeEnum();
                switch (licenseType)
                {
                    #region TRIAL LICENSE
                    case LicenseTypes.LicenseTypeEnum.TRIAL:
                        //-----------------------------------------------------------------
                        //--- TRIAL LICENSE:  REQUIRED ... Supplier Name, Customer Name ---
                        //-----------------------------------------------------------------
                        if (textBoxSupplierName.Text.Length < 1)
                        {
                            MessageBox.Show(" Supplier Name is NOT specified.  Please provide the Supplier Name.");
                            textBoxDivision.Focus();
                            return bValidData;
                        }
                        if (textBoxCustomerName.Text.Length < 1)
                        {
                            MessageBox.Show(" Customer Name is NOT specified.  Please provide the Customer Name.");
                            textBoxCorporation.Focus();
                            return bValidData;
                        }
                        break;
                    #endregion      // TRIAL LICENSE

                    #region SITE LICENSE
                    case LicenseTypes.LicenseTypeEnum.SITE:
                        //----------------------------------------------------------------
                        //--- SITE LICENSE:  REQUIRED ... Corporation, Division, Group ---
                        //----------------------------------------------------------------
                        if (textBoxCorporation.Text.Length < 1)
                        {
                            MessageBox.Show(" Corporation Name is NOT specified.  Please provide the Corporation Name.");
                            textBoxCorporation.Focus();
                            return bValidData;
                        }
                        if (textBoxDivision.Text.Length < 1)
                        {
                            MessageBox.Show(" Division Name is NOT specified.  Please provide the Division Name.");
                            textBoxDivision.Focus();
                            return bValidData;
                        }
                        if (textBoxGroup.Text.Length < 1)
                        {
                            MessageBox.Show(" Group Name is NOT specified.  Please provide the Group Name.");
                            textBoxGroup.Focus();
                            return bValidData;
                        }
                        break;
                    #endregion      // SITE LICENSE

                    #region DEVICE LICENSE
                    case LicenseTypes.LicenseTypeEnum.DEVICE:
                        //------------------------------------------------------------------------------
                        //--- DEVICE LICENSE:  REQUIRED ... DeviceName, Corporation, Division, Group ---
                        //------------------------------------------------------------------------------
                        if (textBoxDeviceName.Text.Length < 1)
                        {
                            MessageBox.Show(" User Name is NOT specified.  Please provide the User Name.");
                            return bValidData;
                        }
                        if (textBoxCorporation.Text.Length < 1)
                        {
                            MessageBox.Show(" Corporation Name is NOT specified.  Please provide the Corporation Name.");
                            textBoxCorporation.Focus();
                            return bValidData;
                        }
                        if (textBoxDivision.Text.Length < 1)
                        {
                            MessageBox.Show(" Division Name is NOT specified.  Please provide the Division Name.");
                            textBoxDivision.Focus();
                            return bValidData;
                        }
                        if (textBoxGroup.Text.Length < 1)
                        {
                            MessageBox.Show(" Group Name is NOT specified.  Please provide the Group Name.");
                            textBoxGroup.Focus();
                            return bValidData;
                        }
                        break;
                    #endregion      // DEVICE LICENSE

                    #region USER LICENSE
                    case LicenseTypes.LicenseTypeEnum.USER:
                        //--------------------------------------------------------------------------
                        //--- USER LICENSE:  REQUIRED ... UserName, Corporation, Division, Group ---
                        //--------------------------------------------------------------------------
                        if (textBoxUsername.Text.Length < 1)
                        {
                            MessageBox.Show(" User Name is NOT specified.  Please provide the User Name.");
                            return bValidData;
                        }
                        if (textBoxCorporation.Text.Length < 1)
                        {
                            MessageBox.Show(" Corporation Name is NOT specified.  Please provide the Corporation Name.");
                            textBoxCorporation.Focus();
                            return bValidData;
                        }
                        if (textBoxDivision.Text.Length < 1)
                        {
                            MessageBox.Show(" Division Name is NOT specified.  Please provide the Division Name.");
                            textBoxDivision.Focus();
                            return bValidData;
                        }
                        if (textBoxGroup.Text.Length < 1)
                        {
                            MessageBox.Show(" Group Name is NOT specified.  Please provide the Group Name.");
                            textBoxGroup.Focus();
                            return bValidData;
                        }
                        break;
                    #endregion      // USER LICENSE

                    #region SEAT LICENSE
                    case LicenseTypes.LicenseTypeEnum.SEAT:
                        //--------------------------------------------------------------------------------------
                        //--- SEAT LICENSE:  REQUIRED ... DeviceName, UserName, Corporation, Division, Group ---
                        //--------------------------------------------------------------------------------------
                        if (textBoxDeviceName.Text.Length < 1)
                        {
                            MessageBox.Show(" Device Name is NOT specified.  Please provide the Device Name.");
                            textBoxDeviceName.Focus();
                            return bValidData;
                        }
                        if (textBoxUsername.Text.Length < 1)
                        {
                            MessageBox.Show(" User Name is NOT specified.  Please provide the User Name.");
                            textBoxUsername.Focus();
                            return bValidData;
                        }
                        if (textBoxCorporation.Text.Length < 1)
                        {
                            MessageBox.Show(" Corporation Name is NOT specified.  Please provide the Corporation Name.");
                            textBoxCorporation.Focus();
                            return bValidData;
                        }
                        if (textBoxDivision.Text.Length < 1)
                        {
                            MessageBox.Show(" Division Name is NOT specified.  Please provide the Division Name.");
                            textBoxDivision.Focus();
                            return bValidData;
                        }
                        if (textBoxGroup.Text.Length < 1)
                        {
                            MessageBox.Show(" Group Name is NOT specified.  Please provide the Group Name.");
                            textBoxGroup.Focus();
                            return bValidData;
                        }
                        break;
                    #endregion      // SEAT LICENSE

                    #region DEFAULT - UNKNOWN LICENSE                    
                    default:
                        //----------------------------------
                        //--- DEFAULT: UNKNOWN LICENSE:  ---
                        //----------------------------------
                        MessageBox.Show(" INVALID License Type.  Please select a Valid License Type.");
                        comboBoxLicenseType.Focus();
                        return bValidData;
                        #endregion      // DEFAULT - UNKNOWN LICENSE
                }
                //------------------------
                //--- PASSED ALL TESTS ---
                //------------------------
                bValidData = true;      // Passed All Tests
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
            return bValidData;
        }
        #endregion      // ValidLicenseKeyInput

        #region UpdateLicenseKeyValue
        private void UpdateLicenseKeyValue()
        {
            string strMethod = "UpdateLicenseKeyValue";
            string strMsg = string.Empty;
            try
            {
                #region CHECK FOR VALID INPUT LICENSE KEY DATA
                //------------------------------------------------
                //--- GUARD: Check for Valid License Key Input ---
                //------------------------------------------------
                if (!ValidLicenseKeyInput()) return;    // INVALID DATA
                #endregion      // CHECK FOR VALID INPUT LICENSE KEY DATA

                #region GET LICENSE KEY STRING
                //-------------------------------------------------
                //--- Get License Key String and Update Textbox ---
                //-------------------------------------------------
                LicenseKeyMgrObj = new LicenseKeyMgr();
                LicenseKeyMgrObj.LicenseMgrObj.LicenseFileDataObj.Author = textBoxAuthor.Text;
                LicenseKeyMgrObj.LicenseMgrObj.LicenseFileDataObj.SupplierName = textBoxSupplierName.Text;
                LicenseKeyMgrObj.LicenseMgrObj.LicenseFileDataObj.SupplierUrl = textBoxSupplierUrl.Text;
                LicenseKeyMgrObj.LicenseMgrObj.LicenseFileDataObj.CustomerName = textBoxCustomerName.Text;
                LicenseKeyMgrObj.LicenseMgrObj.LicenseFileDataObj.CustomerEmail = textBoxCustomerEmail.Text;
                LicenseKeyMgrObj.LicenseMgrObj.LicenseFileDataObj.ProductName = comboBoxProduct.Text;
                LicenseKeyMgrObj.LicenseMgrObj.LicenseFileDataObj.ProductVersion = textBoxVersion.Text;
                LicenseKeyMgrObj.LicenseMgrObj.LicenseFileDataObj.SerialNumber = textBoxSerialNumber.Text;
                LicenseKeyMgrObj.LicenseMgrObj.LicenseFileDataObj.ProductCode = textBoxProductCode.Text;
                LicenseKeyMgrObj.LicenseMgrObj.LicenseFileDataObj.LicenseType = comboBoxLicenseType.Text;
                LicenseKeyMgrObj.LicenseMgrObj.LicenseFileDataObj.UserName = textBoxUsername.Text;
                LicenseKeyMgrObj.LicenseMgrObj.LicenseFileDataObj.DeviceName = textBoxDeviceName.Text;
                LicenseKeyMgrObj.LicenseMgrObj.LicenseFileDataObj.Corporation = textBoxCorporation.Text;
                LicenseKeyMgrObj.LicenseMgrObj.LicenseFileDataObj.Division = textBoxDivision.Text;
                LicenseKeyMgrObj.LicenseMgrObj.LicenseFileDataObj.Group = textBoxGroup.Text;

                textBoxLicenseKey.Text = LicenseKeyMgrObj.LicenseMgrObj.CalculateLicenseKey();
                textBoxLicenseKey.Focus();
                #endregion      // GET LICENSE KEY STRING

            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // UpdateLicenseKeyValue

        #region UpdateHashValue
        private void UpdateHashValue()
        {
            string strMethod = "UpdateHashValue";
            string strMsg = string.Empty;
            try
            {
                #region CHECK FOR VALID INPUT
                //------------------------------------------------
                //--- GUARD: Check for Valid License Key Input ---
                //------------------------------------------------
                if (!ValidLicenseKeyInput()) return;    // INVALID DATA
                //--------------------------------------------
                //--- ENSURE: License Key Value is updated ---
                //--------------------------------------------
                UpdateLicenseKeyValue();
                //------------------------------------------------
                //--- GUARD: Check for Valid License Key Value ---
                //------------------------------------------------
                if (textBoxLicenseKey.Text.Length < 1)
                {
                    MessageBox.Show(" License Key is NOT specified.  Please provide the License Key.");
                    textBoxLicenseKey.Focus();
                    return;
                }
                #endregion      // CHECK FOR VALID INPUT

                //--------------------------
                //--- Assign Date Values ---
                //--------------------------
                LicenseKeyMgrObj.LicenseMgrObj.LicenseFileDataObj.StartDate = dateTimePickerStart.Value;
                LicenseKeyMgrObj.LicenseMgrObj.LicenseFileDataObj.EndDate = dateTimePickerEnd.Value;

                //-------------------------------------------------------
                //--- Get License File Hash String and Update Textbox ---
                //-------------------------------------------------------
                textBoxHash.Text = LicenseKeyMgrObj.LicenseMgrObj.CalculateLicenseFileHash(textBoxLicenseKey.Text);
                textBoxHash.Focus();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // UpdateHashValue

        //=============================================================================================================
        //------------------------------------ CREATE AJP LICENSE XML FILE METHODS ------------------------------------
        //=============================================================================================================

        #region ScrapeScreenForLicenseFileCreation
        private LicenseFileData ScrapeScreenForLicenseFileCreation()
        {
            string strMethod = "ScrapeScreenForLicenseFileCreation";
            string strMsg = string.Empty;
            //LicenseFileData licenseFileDataObj = new LicenseFileData();
            try
            {
                LicenseKeyMgrObj.LicenseFileDataObj = new LicenseFileData();
                //-----------------------------------------------------------
                //--- Scrape Screen and Populate a LicenseFileData Object ---
                //-----------------------------------------------------------
                LicenseKeyMgrObj.LicenseFileDataObj.Author = textBoxAuthor.Text;
                LicenseKeyMgrObj.LicenseFileDataObj.SupplierName = textBoxSupplierName.Text;
                LicenseKeyMgrObj.LicenseFileDataObj.SupplierUrl = textBoxSupplierUrl.Text;
                LicenseKeyMgrObj.LicenseFileDataObj.CustomerName = textBoxCustomerName.Text;
                LicenseKeyMgrObj.LicenseFileDataObj.CustomerEmail = textBoxCustomerEmail.Text;
                LicenseKeyMgrObj.LicenseFileDataObj.ProductName = comboBoxProduct.Text;
                LicenseKeyMgrObj.LicenseFileDataObj.ProductVersion = textBoxVersion.Text;
                LicenseKeyMgrObj.LicenseFileDataObj.SerialNumber = textBoxSerialNumber.Text;
                LicenseKeyMgrObj.LicenseFileDataObj.ProductCode = textBoxProductCode.Text;
                LicenseKeyMgrObj.LicenseFileDataObj.LicenseType = comboBoxLicenseType.Text;
                LicenseKeyMgrObj.LicenseFileDataObj.UserName = textBoxUsername.Text;
                LicenseKeyMgrObj.LicenseFileDataObj.DeviceName = textBoxDeviceName.Text;
                LicenseKeyMgrObj.LicenseFileDataObj.Corporation = textBoxCorporation.Text;
                LicenseKeyMgrObj.LicenseFileDataObj.Division = textBoxDivision.Text;
                LicenseKeyMgrObj.LicenseFileDataObj.Group = textBoxGroup.Text;

                LicenseKeyMgrObj.LicenseFileDataObj.FileLicenseKey = textBoxLicenseKey.Text;

                LicenseKeyMgrObj.LicenseFileDataObj.StartDate = dateTimePickerStart.Value;
                LicenseKeyMgrObj.LicenseFileDataObj.EndDate = dateTimePickerEnd.Value;
                LicenseKeyMgrObj.LicenseFileDataObj.DurationDays = Convert.ToInt32(numericUpDownDuration.Value);

                LicenseKeyMgrObj.LicenseFileDataObj.FileHash = textBoxHash.Text;

                //************************* TEST *************************
                LicenseKeyMgrObj.LicenseFileDataObj.LogDataToConsole();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
            return LicenseKeyMgrObj.LicenseFileDataObj;
        }
        #endregion      // ScrapeScreenForLicenseFileCreation

        #region CreateLicenseFile
        private void CreateLicenseFile()
        {
            string strMethod = "CreateLicenseFile";
            string strMsg = string.Empty;
            LicenseFileData licenseFileDataObj = new LicenseFileData();
            try
            {
                //-----------------------------------------------------------
                //--- Scrape Screen and Populate a LicenseFileData Object ---
                //-----------------------------------------------------------
                licenseFileDataObj = ScrapeScreenForLicenseFileCreation();

                //----------------------------------------------------------------------------------
                //--- Create AJP License XML File using Properties of the LicenseFileData Object ---
                //----------------------------------------------------------------------------------               
                LicenseKeyMgrObj.PersistLicenseXmlFile(FullPathXmlFile);
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // CreateLicenseFile

        #region ViewLicenseFile
        private void ViewLicenseFile()
        {
            string strMethod = "ViewLicenseFile";
            string strMsg = string.Empty;
            LicenseFileData licenseFileDataObj = new LicenseFileData();
            try
            {
                //----------------------------------------------------------------
                //--- View AJP License XML File using a FormLicenseFile Object ---
                //----------------------------------------------------------------               
                MessageBox.Show("TO DO: View AJP License XML File using a FormLicenseFile Object.");
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // ViewLicenseFile

        //=============================================================================================================
        //--------------------------------------------- PRIVATE METHODS -----------------------------------------------
        //=============================================================================================================

        #region GetLicenseTypeEnum
        /// <summary>
        /// Get the License Type Enum based on Selected Index
        ///   [0] ... TRIAL
        ///   [1] ... SITE
        ///   [2] ... DEVICE
        ///   [3] ... USER
        ///   [4] ... SEAT
        /// </summary>
        /// <returns></returns>
        private LicenseTypes.LicenseTypeEnum GetLicenseTypeEnum()
        {
            string strMethod = "GetLicenseTypeEnum";
            string strMsg = string.Empty;
            try
            {
                if (comboBoxLicenseType.SelectedIndex == Convert.ToInt32(LicenseTypes.LicenseTypeEnum.TRIAL))
                {
                    #region AJP TRIAL LICENSE
                    //---------------------------------------------
                    //--- Index Zero Selected ... Trial License ---
                    //---------------------------------------------
                    AjpLicenseType = LicenseTypes.LicenseTypeEnum.TRIAL;
                    #endregion      // AJP TRIAL LICENSE
                }                
                else if (comboBoxLicenseType.SelectedIndex == Convert.ToInt32(LicenseTypes.LicenseTypeEnum.SITE))
                {
                    #region AJP SITE LICENSE
                    //--------------------------------------------
                    //--- Index One Selected ... SITE License ---
                    //--------------------------------------------
                    AjpLicenseType = LicenseTypes.LicenseTypeEnum.SITE;
                    #endregion      // AJP SITE LICENSE
                }
                else if (comboBoxLicenseType.SelectedIndex == Convert.ToInt32(LicenseTypes.LicenseTypeEnum.DEVICE))
                {
                    #region AJP DEVICE LICENSE
                    //---------------------------------------------
                    //--- Index Two Selected ... DEVICE License ---
                    //---------------------------------------------
                    AjpLicenseType = LicenseTypes.LicenseTypeEnum.DEVICE;
                    #endregion      // AJP USER LICENSE
                }
                else if (comboBoxLicenseType.SelectedIndex == Convert.ToInt32(LicenseTypes.LicenseTypeEnum.USER))
                {
                    #region AJP USER LICENSE
                    //---------------------------------------------
                    //--- Index Three Selected ... USER License ---
                    //---------------------------------------------
                    AjpLicenseType = LicenseTypes.LicenseTypeEnum.USER;
                    #endregion      // AJP USER LICENSE
                }
                else if (comboBoxLicenseType.SelectedIndex == Convert.ToInt32(LicenseTypes.LicenseTypeEnum.SEAT))
                {
                    #region AJP SEAT LICENSE
                    //--------------------------------------------
                    //--- Index Four Selected ... SEAT License ---
                    //--------------------------------------------
                    AjpLicenseType = LicenseTypes.LicenseTypeEnum.SEAT;
                    #endregion      // AJP SEAT LICENSE
                }
                else
                {
                    #region AJP UNKNOWN LICENSE
                    //--------------------------------------------------
                    //--- INVALID Index Selected ... UNKNOWN License ---
                    //--------------------------------------------------
                    AjpLicenseType = LicenseTypes.LicenseTypeEnum.UNKNOWN;
                    #endregion      // AJP UNKNOWN LICENSE                
                }
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
            return AjpLicenseType;
        }
        #endregion      // GetLicenseTypeEnum

        #region GetProductNameString
        private string GetProductNameString()
        {
            string strMethod = "GetProductNameString";
            string strMsg = string.Empty;
            string strProductName = "AJP Test 1.0";
            try
            {
                if (AjpProductName == ProductNameEnum.AJP_Test)           return "AJP Test 1.0";
                if (AjpProductName == ProductNameEnum.AJP_Exchanger)      return "AJP Exchanger 4.1";
                if (AjpProductName == ProductNameEnum.AJP_Lineup)         return "AJP Lineup 1.0";
                if (AjpProductName == ProductNameEnum.AJP_CyberShield)    return "AJP CyberShield 1.0";
                if (AjpProductName == ProductNameEnum.AJP_Pinch)          return "AJP Pinch 3.0";
                if (AjpProductName == ProductNameEnum.AJP_Sudoku)         return "AJP Sudoku 1.0";
                else                                                      return "AJP Test 1.0";
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
            return strProductName;
        }

        #endregion      // GetProductNameString

        #region UpdateProductControls
        /// <summary>
        /// Update the Product Controls in the Product Group Control
        /// </summary>
        private void UpdateProductControls()
        {
            string strMethod = "UpdateProductControls";
            string strMsg = string.Empty;
            try
            {
                if (comboBoxProduct.SelectedIndex == Convert.ToInt32(ProductNameEnum.AJP_Test))
                {
                    #region AJP TEST
                    //---------------------------------------
                    //--- PRODUCT: AJP Test 1.0 Selected  ---
                    //---------------------------------------
                    AjpProductName = ProductNameEnum.AJP_Test;
                    textBoxVersion.Text = PRODUCT_VERSION_AJP_TEST;
                    textBoxSerialNumber.Text = SERIAL_NUMBER_AJP_TEST;
                    textBoxProductCode.Text = PRODUCT_CODE_AJP_TEST;

                    pictureBoxProductLogo.Image = Properties.Resources.AJP_Test_Logo;
                    #endregion      // AJP TEST
                }
                else if (comboBoxProduct.SelectedIndex == Convert.ToInt32(ProductNameEnum.AJP_Exchanger))
                {
                    #region AJP EXCHANGER
                    //--------------------------------------------
                    //--- PRODUCT: AJP Exchanger 4.1 Selected  ---
                    //--------------------------------------------
                    AjpProductName = ProductNameEnum.AJP_Exchanger;
                    textBoxVersion.Text = PRODUCT_VERSION_AJP_EXCHANGER;
                    textBoxSerialNumber.Text = SERIAL_NUMBER_AJP_EXCHANGER;
                    textBoxProductCode.Text = PRODUCT_CODE_AJP_EXCHANGER;

                    pictureBoxProductLogo.Image = Properties.Resources.AJP_Exchanger_Logo;
                    #endregion      // AJP EXCHANGER
                }
                else if (comboBoxProduct.SelectedIndex == Convert.ToInt32(ProductNameEnum.AJP_Lineup))
                {
                    #region AJP LINEUP
                    //-----------------------------------------
                    //--- PRODUCT: AJP Lineup 1.0 Selected  ---
                    //-----------------------------------------
                    AjpProductName = ProductNameEnum.AJP_Lineup;
                    textBoxVersion.Text = PRODUCT_VERSION_AJP_LINEUP;
                    textBoxSerialNumber.Text = SERIAL_NUMBER_AJP_LINEUP;
                    textBoxProductCode.Text = PRODUCT_CODE_AJP_LINEUP;

                    pictureBoxProductLogo.Image = Properties.Resources.AJP_Lineup_Logo;
                    #endregion      // AJP LINEUP
                }
                else if (comboBoxProduct.SelectedIndex == Convert.ToInt32(ProductNameEnum.AJP_CyberShield))
                {
                    #region AJP CYBER SHIELD
                    //----------------------------------------------
                    //--- PRODUCT: AJP CyberShield 1.0 Selected  ---
                    //----------------------------------------------
                    AjpProductName = ProductNameEnum.AJP_CyberShield;
                    textBoxVersion.Text = PRODUCT_VERSION_AJP_CYBER_SHIELD;
                    textBoxSerialNumber.Text = SERIAL_NUMBER_AJP_CYBER_SHIELD;
                    textBoxProductCode.Text = PRODUCT_CODE_AJP_CYBER_SHIELD;

                    pictureBoxProductLogo.Image = Properties.Resources.AJP_CyberShield_Logo;
                    #endregion      // AJP CYBER SHIELD
                }
                else if (comboBoxProduct.SelectedIndex == Convert.ToInt32(ProductNameEnum.AJP_Pinch))
                {
                    #region AJP PINCH
                    //----------------------------------------
                    //--- PRODUCT: AJP Pinch 3.0 Selected  ---
                    //----------------------------------------
                    AjpProductName = ProductNameEnum.AJP_Pinch;
                    textBoxVersion.Text = PRODUCT_VERSION_AJP_PINCH;
                    textBoxSerialNumber.Text = SERIAL_NUMBER_AJP_PINCH;
                    textBoxProductCode.Text = PRODUCT_CODE_AJP_PINCH;

                    pictureBoxProductLogo.Image = Properties.Resources.AJP_Pinch_4;
                    #endregion      // AJP PINCH
                }
                else if (comboBoxProduct.SelectedIndex == Convert.ToInt32(ProductNameEnum.AJP_Sudoku))
                {
                    #region AJP SUDOKU
                    //-----------------------------------------
                    //--- PRODUCT: AJP Sudoku 1.0 Selected  ---
                    //-----------------------------------------
                    AjpProductName = ProductNameEnum.AJP_Sudoku;
                    textBoxVersion.Text = PRODUCT_VERSION_AJP_SUDOKU;
                    textBoxSerialNumber.Text = SERIAL_NUMBER_AJP_SUDOKU;
                    textBoxProductCode.Text = PRODUCT_CODE_AJP_SUDOKU;

                    pictureBoxProductLogo.Image = Properties.Resources.AJP_Sudoku_Logo;
                    #endregion      // AJP SUDOKU
                }
                else
                {
                    #region DEFAULT -- AJP TEST
                    //---------------------------------------
                    //--- PRODUCT: AJP Test 1.0 Selected  ---
                    //---------------------------------------
                    AjpProductName = ProductNameEnum.AJP_Test;
                    textBoxVersion.Text = PRODUCT_VERSION_AJP_TEST;
                    textBoxSerialNumber.Text = SERIAL_NUMBER_AJP_TEST;
                    textBoxProductCode.Text = PRODUCT_CODE_AJP_TEST;

                    pictureBoxProductLogo.Image = Properties.Resources.AJP_Test_Logo;
                    #endregion      // DEFAULT -- AJP TEST
                }
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // UpdateProductControls

        #region UpdateLicenseTypeControls
        /// <summary>
        /// Update License Controls in the License Type Group Control based on Combobox Selected Index
        ///   [0] ... TRIAL
        ///   [1] ... SITE
        ///   [2] ... DEVICE
        ///   [3] ... USER
        ///   [4] ... SEAT
        /// </summary>
        private void UpdateLicenseTypeControls()
        {
            string strMethod = "UpdateLicenseTypeControls";
            string strMsg = string.Empty;
            try
            {
                if (comboBoxLicenseType.SelectedIndex == Convert.ToInt32(LicenseTypes.LicenseTypeEnum.TRIAL))
                {
                    #region AJP TRIAL LICENSE ... [0]
                    //----------------------------------------------------------------------------
                    //--- LICENSE TYPE: TRIAL Selected ... FULL License with 30 days Duration  ---
                    //----------------------------------------------------------------------------
                    AjpLicenseType = LicenseTypes.LicenseTypeEnum.TRIAL;

                    numericUpDownDuration.Value = Convert.ToDecimal(DEFAULT_DAYS_DURATION_TRIAL);

                    //------------------------------------
                    //--- LICENSE TYPE: TRIAL Options  ---
                    //------------------------------------

                    //----------------------------------------------------------------- ENABLED ---
                    textBoxCorporation.Enabled = false;  // Corporation Name is NOT Needed for TRIAL License
                    textBoxDivision.Enabled = false;     // Division    Name is NOT Needed for TRIAL License
                    textBoxGroup.Enabled = false;        // Group       Name is NOT Needed for TRIAL License

                    textBoxDeviceName.Enabled = false;   // Device   is NOT Needed for TRIAL License
                    textBoxUsername.Enabled = false;     // Username is NOT Needed for TRIAL License

                    //-------------------------------------------------------- BACKGROUND COLOR ---
                    textBoxCorporation.BackColor = ColorDISABLED;
                    textBoxDivision.BackColor = ColorDISABLED;
                    textBoxGroup.BackColor = ColorDISABLED;

                    textBoxDeviceName.BackColor = ColorDISABLED;
                    textBoxUsername.BackColor = ColorDISABLED;

                    //-------------------------------------------------------------------- TEXT ---
                    textBoxCorporation.Text = DEFAULT_INGORE_FIELD;
                    textBoxDivision.Text = DEFAULT_INGORE_FIELD;
                    textBoxGroup.Text = DEFAULT_INGORE_FIELD;

                    textBoxDeviceName.Text = DEFAULT_INGORE_FIELD;
                    textBoxUsername.Text = DEFAULT_INGORE_FIELD;
                    #endregion      // AJP TRIAL LICENSE ... [0]
                }
                else if (comboBoxLicenseType.SelectedIndex == Convert.ToInt32(LicenseTypes.LicenseTypeEnum.SITE))
                {
                    #region AJP SITE LICENSE ... [1]
                    //------------------------------------
                    //--- LICENSE TYPE: SITE Selected  ---
                    //------------------------------------
                    AjpLicenseType = LicenseTypes.LicenseTypeEnum.SITE;

                    //----------------------------------------------------------------- ENABLED ---
                    textBoxCorporation.Enabled = true;  // Corporation Name is Needed for SITE License
                    textBoxDivision.Enabled = true;     // Division    Name is Needed for SITE License
                    textBoxGroup.Enabled = true;        // Group       Name is Needed for SITE License

                    textBoxDeviceName.Enabled = false;    // Device Name  is NOT Needed for SITE License 
                    textBoxUsername.Enabled = false;      // Username     is NOT Needed for SITE License 

                    //-------------------------------------------------------- BACKGROUND COLOR ---
                    textBoxCorporation.BackColor = Color.White;
                    textBoxDivision.BackColor = Color.White;
                    textBoxGroup.BackColor = Color.White;

                    textBoxDeviceName.BackColor = ColorDISABLED;
                    textBoxUsername.BackColor   = ColorDISABLED;

                    //-------------------------------------------------------------------- TEXT ---
                    textBoxCorporation.Text = String.Empty;
                    textBoxDivision.Text = String.Empty;
                    textBoxGroup.Text = String.Empty;

                    textBoxDeviceName.Text = DEFAULT_INGORE_FIELD;
                    textBoxUsername.Text   = DEFAULT_INGORE_FIELD;

                    numericUpDownDuration.Value = Convert.ToDecimal(DEFAULT_DAYS_DURATION);
                    #endregion      // AJP SITE LICENSE ... [1]
                }
                else if (comboBoxLicenseType.SelectedIndex == Convert.ToInt32(LicenseTypes.LicenseTypeEnum.DEVICE))
                {
                    #region AJP DEVICE LICENSE ... [2]
                    //------------------------------------
                    //--- LICENSE TYPE: DEVICE Selected  ---
                    //------------------------------------
                    AjpLicenseType = LicenseTypes.LicenseTypeEnum.DEVICE;

                    //----------------------------------------------------------------- ENABLED ---
                    textBoxCorporation.Enabled = true;  // Corporation Name is Needed for DEVICE License
                    textBoxDivision.Enabled = true;     // Division    Name is Needed for DEVICE License
                    textBoxGroup.Enabled = true;        // Group       Name is Needed for DEVICE License

                    textBoxUsername.Enabled = false;      // Username is NOT Needed for DEVICE License
                    textBoxDeviceName.Enabled = true;     // Device Name is  Needed for DEVICE License

                    //-------------------------------------------------------- BACKGROUND COLOR ---
                    textBoxCorporation.BackColor = Color.White;
                    textBoxDivision.BackColor = Color.White;
                    textBoxGroup.BackColor = Color.White;

                    textBoxUsername.BackColor = ColorDISABLED;
                    textBoxDeviceName.BackColor = Color.White;

                    //-------------------------------------------------------------------- TEXT ---
                    textBoxCorporation.Text = String.Empty;
                    textBoxDivision.Text = String.Empty;
                    textBoxGroup.Text = String.Empty;

                    textBoxUsername.Text = DEFAULT_INGORE_FIELD;
                    textBoxDeviceName.Text = String.Empty;

                    numericUpDownDuration.Value = Convert.ToDecimal(DEFAULT_DAYS_DURATION);
                    #endregion      // AJP DEVICE LICENSE ... [2]
                }
                else if (comboBoxLicenseType.SelectedIndex == Convert.ToInt32(LicenseTypes.LicenseTypeEnum.USER))
                {
                    #region AJP USER LICENSE ... [3]
                    //------------------------------------
                    //--- LICENSE TYPE: USER Selected  ---
                    //------------------------------------
                    AjpLicenseType = LicenseTypes.LicenseTypeEnum.USER;

                    //----------------------------------------------------------------- ENABLED ---
                    textBoxCorporation.Enabled = true;  // Corporation Name is Needed for USER License
                    textBoxDivision.Enabled = true;     // Division    Name is Needed for USER License
                    textBoxGroup.Enabled = true;        // Group       Name is Needed for USER License

                    textBoxDeviceName.Enabled = false;      // Device Name is NOT Needed for USER License
                    textBoxUsername.Enabled = true;         // Username    is     Needed for USER License

                    //-------------------------------------------------------- BACKGROUND COLOR ---
                    textBoxCorporation.BackColor = Color.White;
                    textBoxDivision.BackColor = Color.White;
                    textBoxGroup.BackColor = Color.White;

                    textBoxDeviceName.BackColor = ColorDISABLED;
                    textBoxUsername.BackColor = Color.White;

                    //-------------------------------------------------------------------- TEXT ---
                    textBoxCorporation.Text = String.Empty;
                    textBoxDivision.Text = String.Empty;
                    textBoxGroup.Text = String.Empty;

                    textBoxDeviceName.Text = DEFAULT_INGORE_FIELD;
                    textBoxUsername.Text = String.Empty;

                    numericUpDownDuration.Value = Convert.ToDecimal(DEFAULT_DAYS_DURATION);
                    #endregion      // AJP USER LICENSE ... [3]
                }
                else if (comboBoxLicenseType.SelectedIndex == Convert.ToInt32(LicenseTypes.LicenseTypeEnum.SEAT))
                {
                    #region AJP SEAT LICENSE ... [4]
                    //------------------------------------
                    //--- LICENSE TYPE: SEAT Selected  ---
                    //------------------------------------
                    AjpLicenseType = LicenseTypes.LicenseTypeEnum.SEAT;

                    //----------------------------------------------------------------- ENABLED ---
                    textBoxCorporation.Enabled = true;  // Corporation Name is Needed for SEAT License
                    textBoxDivision.Enabled = true;     // Division    Name is Needed for SEAT License
                    textBoxGroup.Enabled = true;        // Group       Name is Needed for SEAT License

                    textBoxDeviceName.Enabled = true;   // Device   is Needed for SEAT License
                    textBoxUsername.Enabled = true;     // Username is Needed for SEAT License

                    //-------------------------------------------------------- BACKGROUND COLOR ---
                    textBoxCorporation.BackColor = Color.White;
                    textBoxDivision.BackColor = Color.White;
                    textBoxGroup.BackColor = Color.White;

                    textBoxDeviceName.BackColor = Color.White;
                    textBoxUsername.BackColor = Color.White;

                    //-------------------------------------------------------------------- TEXT ---
                    textBoxCorporation.Text = String.Empty;
                    textBoxDivision.Text = String.Empty;
                    textBoxGroup.Text = String.Empty;

                    textBoxDeviceName.Text = String.Empty;
                    textBoxUsername.Text = String.Empty;

                    numericUpDownDuration.Value = Convert.ToDecimal(DEFAULT_DAYS_DURATION);
                    #endregion      // AJP SEAT LICENSE ... [4]
                }
                //---------------------------
                //--- Update the End Date ---
                //---------------------------
                UpdateEndDate();
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // GetSerialNumber

        #region UpdateEndDate
        /// <summary>
        /// Update the End Data based on the current values for Start and Duration
        /// </summary>
        private void UpdateEndDate()
        {
            string strMethod = "UpdateEndDate";
            string strMsg = string.Empty;
            int nDurationDays = 0;
            try
            {
                nDurationDays = Convert.ToInt32(numericUpDownDuration.Value);
                dateTimePickerEnd.Value = dateTimePickerStart.Value.AddDays(nDurationDays);
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // UpdateEndDate

        #region UpdateStartDate
        /// <summary>
        /// Update the Start Data based on the current values for End and Duration
        /// </summary>
        private void UpdateStartDate()
        {
            string strMethod = "UpdateStartDate";
            string strMsg = string.Empty;
            int nDurationDays = 0;
            try
            {
                nDurationDays = Convert.ToInt32(numericUpDownDuration.Value);
                dateTimePickerStart.Value = dateTimePickerEnd.Value.AddDays(-nDurationDays);
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                MessageBox.Show(strMsg);
            }
        }
        #endregion      // UpdateStartDate
    }
    #endregion      // class FormMain

}
#endregion      // namespace AJP_LicenseGenerator

//=====================================================================================================================
//---------------------------------------------- E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
