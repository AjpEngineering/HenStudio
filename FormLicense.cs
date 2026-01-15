#region HEADER
//#####################################################################################################################
//##########################################  F o r m L i c e n s e . c s  ############################################
//#####################################################################################################################
//  FILENAME:  FormLicense.cs
//  NAMESPACE: Pinch
//  CLASS(S):  FormLicense
//  COMPONENT: Pinch.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the License Form class.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PinchGlobal;
#endregion  // REFERENCES

#region namespace Pinch
namespace Pinch
{
    #region public partial class FormLicense
    public partial class FormLicense : Form
    {
        #region CONSTANTS
        const string NAMESPACE = "Pinch";
        const string CLASS = "FormLicense";
        #endregion      // CONSTANTS

        #region FIELDS
        private PinchTypes _pinchTypesObj;  // PinchTypes Object
        #endregion      // FIELDS

        #region PROPERTIES

        #region PinchTypesObj
        /// <summary>
        /// PinchTypesObj Property
        /// </summary>
        public PinchTypes PinchTypesObj
        {
            get { return _pinchTypesObj; }
            set { _pinchTypesObj = value; }
        }
        #endregion      // PinchTypesObj

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public FormLicense()
        {
            InitializeComponent();

            InitializeControls();
        }
        #endregion  // CTOR

        #region InitializeControls() METHOD
        /// <summary>
        /// Initialize Contols Method
        /// </summary>
        private void InitializeControls()
        {
            string strMethod = "InitializeControls";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Initialize Contols");
            try
            {

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
        #endregion  // InitializeControls() METHOD

        #region PICTURE BOX EVENTS
        private void pictureBoxAJPEngLogo_DoubleClick(object sender, EventArgs e)
        {
            //PinchMsgDlg.DisplayWarningDlg("Handle Double Click on AJP Engineering Logo");
            DisplayBusinessCardForm();
        }
        #endregion  // PICTURE BOX EVENTS

        #region DisplayBusinessCardForm()
        /// <summary>
        /// Common Display About Form Handler
        /// </summary>
        private void DisplayBusinessCardForm()
        {
            string strMethod = "DisplayBusinessCardForm";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Display Business Card Form");
            try
            {
                //PinchMsgDlg.DisplayWarningDlg("Handle Common Display Business Card Form Command!");
                FormBusinessCard dlg = new FormBusinessCard();
                dlg.ShowDialog();
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
        #endregion  // DisplayBusinessCardForm()

    }
    #endregion  // public partial class FormLicense
}
#endregion  // namespace Pinch

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
