#region HEADER
//######################################################################################################
//################################  FormEndUserLicenseAgreement . c s  #################################
//######################################################################################################
//  FILENAME:  FormEndUserLicenseAgreement.cs
//  NAMESPACE: _AJP_License_File
//  CLASS(S):  FormEndUserLicenseAgreement
//  COMPONENT: _AJP_License_File.dll
//======================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the AJP End User License Agreement Form.
//    This class is a read-only AJP EULA viewer.
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

#region namespace _AJP_License_File
namespace _AJP_License_File
{
    #region class FormEndUserLicenseAgreement
    public partial class FormEndUserLicenseAgreement : Form
    {
        #region CONSTANTS
        private const string NAMESPACE = "_AJP_License_File";
        private const string CLASS = "FormEndUserLicenseAgreement";

        private const string AJP_LICENSE_FILENAME = "AJP Engineering - End User License Agreement.rtf"; // AJP LICENSE File Name
        #endregion      // CONSTANTS

        #region FIELDS
        private string _strFullPathLicenseFolder;       // Full-Path AJP LICENSE Folder Location
        private string _strFullPathEulaFileLoc;           // Full-Path EULA File Location
        #endregion      // FIELDS

        #region PROPERTIES

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

        #region EulaFileLoc
        /// <summary>
        /// FullPathEulaFileLoc Property  ... Full-Path EULA File Location
        /// </summary>
        public string FullPathEulaFileLoc
        {
            get { return _strFullPathEulaFileLoc; }
            set { _strFullPathEulaFileLoc = value; }
        }
        #endregion      // FullPathEulaFileLoc

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Parameterized CTOR
        /// </summary>
        /// <param name="fullPathLicenseFolder">Full-Pathe Location of AJP LICENSE Folder</param>
        public FormEndUserLicenseAgreement(string fullPathLicenseFolder)
        {
            string strMethod = "FormEndUserLicenseAgreement";
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
                FullPathLicenseFolder = fullPathLicenseFolder;
                FullPathEulaFileLoc = String.Empty;     // Full-Path EULA File Location
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
        /// <para
        private void FormEndUserLicenseAgreement_Load(object sender, EventArgs e)
        {
            string strMethod = "FormEndUserLicenseAgreement_Load";
            string strMsg = string.Empty;
            try
            {
                //---------------------------------------
                //--- Check if AJP License File Exists ---
                //----------------------------------------
                FullPathEulaFileLoc = string.Format(@"{0}\{1}", FullPathLicenseFolder, AJP_LICENSE_FILENAME);
                if (!File.Exists(FullPathEulaFileLoc))
                {
                    strMsg = string.Format(" *** AJP LICENSE File NOT FOUND!  [{0}]", FullPathEulaFileLoc);
                    throw (new Exception(strMsg));
                }
                Console.WriteLine(" AJP LICENSE FILE FOUND!");
                //-------------------------------------------------------------------------
                //--- Read AJP Engineering - End User License Agreement (EULA) RTF File ---
                //-------------------------------------------------------------------------
                richTextBoxEULA.LoadFile(FullPathEulaFileLoc);
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
        private void FormEndUserLicenseAgreement_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion      // FORM CLOSING

        #endregion      // FORM HANDLERS

        #region BUTTON HANDLERS

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

    }
    #endregion      // class FormEndUserLicenseAgreement
}
#endregion      // namespace _AJP_License_File
