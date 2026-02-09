#region HEADER
//#####################################################################################################################
//########################################  F o r m S c o r e C a r d . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  FormScoreCard.cs
//  NAMESPACE: AJP_License_File
//  CLASS(S):  FormScoreCard
//  COMPONENT: _AJP License File.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the License ScoreCard Form.
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
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;    // WindowsIdentity
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion  // REFERENCES

#region namespace AJP_License_File
namespace AJP_License_File
{
    #region public partial class FormScoreCard
    public partial class FormScoreCard : Form
    {
        #region CONSTANTS
        const string NAMESPACE = "AJP_License_File";
        const string CLASS = "FormScoreCard";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public ScoreCardTableData ScoreCardTableDataObj { get; set; }   // ScoreCard Table Object
        public string RunningDeviceName { get; set; }   // Device Name...Maximum Lenght 15 characters
        public string RunningFullname { get; set; }     // Run-Time Full Name
        public string RunningDomain { get; set; }       // Run-Time Domain
        public string RunningUsername { get; set; }     // Run-Time User...Maximum Length 20 characters
        #endregion      // PROPERTIES

        #region Parameterized CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public FormScoreCard(ScoreCardTableData scoreCardTableDataObj)
        {
            //-----------------------------
            //--- Initialize Properties ---
            //-----------------------------
            ScoreCardTableDataObj = scoreCardTableDataObj;

            InitializeComponent();
        }
        #endregion  // Parameterized CTOR

        #region FORM LOAD EVENT HANDLER
        private void FormScoreCard_Load(object sender, EventArgs e)
        {
            //------------------------------------------------------
            //--- Assign Currently Running (Run-Time) Properties ---
            //------------------------------------------------------
            RunningDeviceName = Environment.MachineName;        // Maximum Lenght 15 characters
            RunningFullname = WindowsIdentity.GetCurrent().Name;
            RunningDomain = RunningFullname.Split('\\')[0];
            RunningUsername = Environment.UserName;             // Maximum Length 20 characters

            UpdateScoreCard();
        }
        #endregion  // FORM LOAD EVENT HANDLER

        #region UpdateScoreCard()
        /// <summary>
        /// Update the ScoreCard Contents and UI Styles
        /// </summary>
        private void UpdateScoreCard()
        {
            string strMethod = "UpdateScoreCard";
            string strMsg = String.Empty;
            string strRunning = String.Empty;
            try
            {

                #region Title TextBox Control
                //-----------------------------
                //--- Title TextBox Control ---
                //-----------------------------
                textBoxTitle.Text = ScoreCardTableDataObj.ValidationState;
                if (ScoreCardTableDataObj.LicenseStatusEnum == LicenseTypes.LicenseStatus.EXPIRED)
                {
                    textBoxTitle.BackColor = Color.OrangeRed;
                    textBoxTitle.ForeColor = Color.White;
                }
                else if (ScoreCardTableDataObj.LicenseStatusEnum == LicenseTypes.LicenseStatus.INVALID)
                {
                    textBoxTitle.BackColor = Color.OrangeRed;
                    textBoxTitle.ForeColor = Color.White;
                }
                else if (ScoreCardTableDataObj.LicenseStatusEnum == LicenseTypes.LicenseStatus.VALID)
                {
                    textBoxTitle.BackColor = Color.Green;
                    textBoxTitle.ForeColor = Color.White;
                }
                else
                {
                    textBoxTitle.BackColor = Color.Red;
                    textBoxTitle.ForeColor = Color.White;
                }
                #endregion  // Title TextBox Control

                #region DataGridViewScoreCard Controls
                //--------------------------------------
                //--- DataGridViewScoreCard Controls ---
                //--------------------------------------
                dataGridViewScoreCard.Rows.Clear();

                foreach (ScoreCardRowData rowObj in ScoreCardTableDataObj.ScoreCardListObj)
                {
                    dataGridViewScoreCard.Rows.Add(rowObj.PropertyID,
                                                   rowObj.PropertyStateImage, 
                                                   rowObj.PropertyName,
                                                   rowObj.PropertyValue);
                }
                #endregion  // DataGridViewScoreCard Controls

                #region Status Bar Controls
                toolStripStatusLabelValidCount.Text = 
                    String.Format(" {0,-2} ",ScoreCardTableDataObj.NumValidProps.ToString());

                toolStripStatusLabelInvalidCount.Text =
                    String.Format(" {0,-2} ", ScoreCardTableDataObj.NumInvalidProps.ToString());

                toolStripStatusLabelRemainingDays.Text =
                    String.Format(" {0,-3} days ", ScoreCardTableDataObj.DaysRemaining.ToString());
                if(ScoreCardTableDataObj.DaysRemaining <= 0)
                {
                    toolStripStatusLabelRemainingDays.ForeColor = Color.Red;
                    toolStripStatusLabelRemainingDays.BackColor = Color.Yellow;
                }

                strRunning = String.Format("Device: {0,-15} User: {1,-20} Fullname: {2,-36} ",
                                           this.RunningDeviceName,
                                           this.RunningUsername,
                                           this.RunningFullname);
                toolStripStatusLabelRunningEnv.Text = strRunning;

                #endregion  // Status Bar Controls
            }
            catch (Exception ex)
            {
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", CLASS, strMethod, ex.Message);
                Console.WriteLine(strMsg);
            }
            finally
            {
            }
        }
        #endregion  // UpdateScoreCard()

        #region CONTACT INFO BUTTON CLICK HANDLER
        private void buttonContactInfo_Click(object sender, EventArgs e)
        {
            DisplayContactInfoForm();
        }
        #endregion  // CONTACT INFO BUTTON CLICK HANDLER

        #region CONTACT INFO STATUS BAR LABEL CLICK HANDLER
        private void toolStripStatusLabelLogo_Click(object sender, EventArgs e)
        {
            DisplayContactInfoForm();
        }
        #endregion  // CONTACT INFO STATUS BAR LABEL CLICK HANDLER

        #region DisplayContactInfoForm()
        private void DisplayContactInfoForm()
        {
            FormContactInfo dlg = new FormContactInfo();
            dlg.ShowDialog();
        }
        #endregion  // DisplayContactInfoForm()

    }
    #endregion  // public partial class FormScoreCard
}
#endregion  // namespace AJP_License_File
//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
