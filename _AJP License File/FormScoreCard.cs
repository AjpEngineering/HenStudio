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
using System.Security.Principal;    // WindowsIdentity
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PinchGlobal;
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

        #region FIELDS
        private ScoreCardTableData _tableData;
        #endregion      // FIELDS

        #region PROPERTIES

        #region ScoreCardTableDataObj
        /// <summary>
        /// ScoreCardTableDataObj Property
        /// </summary>
        public ScoreCardTableData ScoreCardTableDataObj
        {
            get { return _tableData; }
            set { _tableData = value; }
        }
        #endregion  // ScoreCardTableDataObj

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
            string strUsername = Environment.UserName;
            string strFullname = WindowsIdentity.GetCurrent().Name;
            string strDomain = strFullname.Split('\\')[0];
            string strDeviceName = Environment.MachineName;

            UpdateScoreCard();
        }
        #endregion  // FORM LOAD EVENT HANDLER

        private void UpdateScoreCard()
        {
            string strMethod = "UpdateScoreCard";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Update License ScoreCard Using Table Data");

            try
            {
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

                //dataGridViewScoreCard.Rows.Add("01", Properties.Resources.Valid_32x32, "Author", "AuthorValue");
                //dataGridViewScoreCard.Rows.Add("02", Properties.Resources.Valid_32x32, "Supplier Name", "SupplierNameValue");
                //dataGridViewScoreCard.Rows.Add("03", Properties.Resources.Valid_32x32, "Supplier URL", "SupplierURLValue");
                //dataGridViewScoreCard.Rows.Add("04", Properties.Resources.Valid_32x32, "Customer Name", "CustomerNameValue");
                //dataGridViewScoreCard.Rows.Add("05", Properties.Resources.Valid_32x32, "Customer Email", "CustomerEmailValue");
                //dataGridViewScoreCard.Rows.Add("06", Properties.Resources.Valid_32x32, "Product Name", "ProductNameValue");
                //dataGridViewScoreCard.Rows.Add("07", Properties.Resources.Valid_32x32, "Product Version", "ProductVersionValue");
                //dataGridViewScoreCard.Rows.Add("08", Properties.Resources.Valid_32x32, "Product Serial Number", "ProductSerialNumberValue");
                //dataGridViewScoreCard.Rows.Add("09", Properties.Resources.Valid_32x32, "Product Code", "{3D9721BA-003E-4711-B7AF-B579645F0AC9}");
                //dataGridViewScoreCard.Rows.Add("10", Properties.Resources.Valid_32x32, "License Type", "LicenseTypeValue");
                //dataGridViewScoreCard.Rows.Add("11", Properties.Resources.Valid_32x32, "Corporation", "CorporationValue");
                //dataGridViewScoreCard.Rows.Add("12", Properties.Resources.Valid_32x32, "Division", "DivisionValue");
                //dataGridViewScoreCard.Rows.Add("13", Properties.Resources.Valid_32x32, "Group", "GroupValue");
                //dataGridViewScoreCard.Rows.Add("14", Properties.Resources.Valid_32x32, "User Name", "UserNameValue");
                //dataGridViewScoreCard.Rows.Add("15", Properties.Resources.Valid_32x32, "Device Name", "DeviceNameValue");
                //dataGridViewScoreCard.Rows.Add("16", Properties.Resources.Valid_32x32, "License Duration", "LicenseDurationValue");
                //dataGridViewScoreCard.Rows.Add("17", Properties.Resources.Valid_32x32, "License Start Date", "License Start Datevalue");
                //dataGridViewScoreCard.Rows.Add("18", Properties.Resources.Valid_32x32, "License End Date", "LicenseEndDateValue");
                //dataGridViewScoreCard.Rows.Add("19", Properties.Resources.Valid_32x32, "License Key", "LicenseKeyValue");
                //dataGridViewScoreCard.Rows.Add("20", Properties.Resources.InValid_32x32, "License Hash", "LicenseHashValue");

            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }

    }
    #endregion  // public partial class FormScoreCard
}
#endregion  // namespace AJP_License_File
//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
