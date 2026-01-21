#region HEADER
//#####################################################################################################################
//#########################################  FormMoveLicenseFile . c s  ###########################################
//#####################################################################################################################
//  FILENAME:  FormMoveLicenseFile.cs
//  NAMESPACE: AJP_LicenseGenerator
//  CLASS(S):  FormMoveLicenseFile
//  COMPONENT: _AJP_LicenseGenerator.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the License Move Form.
//=====================================================================================================================
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
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
#endregion  // REFERENCES

#region namespace AJP_LicenseGenerator
namespace AJP_LicenseGenerator
{
    #region class FormMoveLicenseFile
    public partial class FormMoveLicenseFile : Form
    {
        #region CONSTANTS
        const string NAMESPACE = "AJP_LicenseGenerator";
        const string CLASS = "FormMoveLicenseFile";
        #endregion      // CONSTANTS

        #region FIELDS
        string _strSourceLoc;  // Full-Path Source (Original)    License File Location
        string _strTargetLoc;  // Full-Path Target (Destination) License File Location
        #endregion  // FIELDS

        #region PROPERTIES

        #region SourceLoc
        /// <summary>
        /// Full Path Source XML File Location Property
        /// </summary>
        public string SourceLoc
        {
            get { return _strSourceLoc; }
            set { _strSourceLoc = value; }
        }
        #endregion      // SourceLoc

        #region TargetLoc
        /// <summary>
        /// Full Path Target XML File Location Property
        /// </summary>
        public string TargetLoc
        {
            get { return _strTargetLoc; }
            set { _strTargetLoc = value; }
        }
        #endregion      // TargetLoc

        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="strSourceLoc">Full-Path Source License File Location</param>
        public FormMoveLicenseFile(string strSourceLoc)
        {
            InitializeComponent();
            //-------------------------
            //--- Assign Properties ---
            //-------------------------
            SourceLoc = strSourceLoc;
            TargetLoc = String.Empty;
            //-------------------------------------
            //--- Assign Initial Control Values ---
            //-------------------------------------
            this.textBoxSource.Text = SourceLoc;
            this.textBoxTarget.Text = TargetLoc;
            this.labelMoveStatus.Text = String.Empty;

            this.buttonMove.Focus();
        }
        #endregion  // CTOR

        #region EVENT HANDLERS

        #region buttonTarget_Click
        /// <summary>
        /// Handle Target Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTarget_Click(object sender, EventArgs e)
        {
            string folderPath = Path.GetDirectoryName(SourceLoc);
            string fileName   = Path.GetFileName(SourceLoc);
            using (this.folderBrowserDialogLicense) 
            {
                this.folderBrowserDialogLicense.Description = "Select the Target Folder";
                this.folderBrowserDialogLicense.ShowNewFolderButton = true;
                this.folderBrowserDialogLicense.SelectedPath = Path.GetDirectoryName(SourceLoc);
                if (this.folderBrowserDialogLicense.ShowDialog() == DialogResult.OK) 
                {
                    TargetLoc = string.Format(@"{0}\{1}",
                                                this.folderBrowserDialogLicense.SelectedPath,
                                                fileName);
                    this.textBoxTarget.Text = TargetLoc; 
                } 
            }
        }
        #endregion  // buttonTarget_Click

        #region buttonMove_Click
        /// <summary>
        /// Handle Move Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            string strMsg = String.Empty;
            try
            { 
                if(File.Exists(TargetLoc))
                {
                    //-----------------------------------------
                    //--- File Already Exists ... Delete It ---
                    //-----------------------------------------
                    File.Delete(TargetLoc);
                }
                File.Move(SourceLoc, TargetLoc); 
            }
            catch (IOException ex)
            {
                //--------------------------------------------
                //--- File Exists, Locked, or Path Invalid ---
                //--------------------------------------------
                labelMoveStatus.Text = "UNSUCCESSFUL Move - See Console!";
                strMsg = String.Format("Move failed: {0}", ex.Message);
                Console.WriteLine(strMsg); 
            } 
            catch (UnauthorizedAccessException ex) 
            {
                //----------------------
                // Permissions Issue ---
                //----------------------
                labelMoveStatus.Text = "UNSUCCESSFUL Move - See Console!";
                strMsg = String.Format("Access denied: {0}", ex.Message);
                Console.WriteLine(strMsg); 
            }

            labelMoveStatus.Text = "File Successfully Moved!";
        }
        #endregion  // buttonMove_Click

        #endregion  // EVENT HANDLERS

    }
    #endregion  // class FormMoveLicenseFile
}
#endregion  // namespace AJP_LicenseGenerator

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
