#region HEADER
//#####################################################################################################################
//##########################################  P i n c h M s g D l g . c s  ############################################
//#####################################################################################################################
//  FILENAME:  PinchMsgDlg.cs
//  NAMESPACE: PinchGlobal
//  CLASS(S):  PinchMsgDlg
//  COMPONENT: _PinchGLobal.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for managing the Pinch Message Dialogs.
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
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion  // REFERENCES

#region namespace PinchGlobal
namespace PinchGlobal
{
    #region public static class PinchMsgDlg
    /// <summary>
    /// STATIC Class PinchMsgDlg contains static methods for displaying message dialogs
    /// </summary>
    public static class PinchMsgDlg
    {
        #region CONSTS
        private const string NAMESPACE = "PinchGlobal";
        private const string CLASS = "PinchMsgDlg";

        private const string strDefaultCaption = "AJP Pinch";
        #endregion      /// CONSTS

        #region public static void DisplayInfoDlg
        /// <summary>
        /// STATIC Method DisplayInfoDlg used to Display an Info Message Box
        /// </summary>
        /// <param name="strMsg">Message to display</param>
        public static void DisplayInfoDlg(string strMsg)
        {
            string strCaption = strDefaultCaption;                          // Message Box Caption
            MessageBoxButtons msgBoxButtons = MessageBoxButtons.OK;         // Message Box Buttons
            MessageBoxIcon msgBoxIcon = MessageBoxIcon.Information;         // Message Box Icon

            DisplayMsgDlg(strMsg, strCaption, msgBoxButtons, msgBoxIcon);   // Display Message Box
        }
        #endregion      // public static void DisplayInfoDlg

        #region public static void DisplayWarningDlg
        /// <summary>
        /// STATIC Method DisplayWarningDlg used to Display a Warning Message Box
        /// </summary>
        /// <param name="strMsg">Message to display</param>
        public static void DisplayWarningDlg(string strMsg)
        {
            string strCaption = strDefaultCaption;                          // Message Box Caption
            MessageBoxButtons msgBoxButtons = MessageBoxButtons.OK;         // Message Box Buttons
            MessageBoxIcon msgBoxIcon = MessageBoxIcon.Warning;             // Message Box Icon

            DisplayMsgDlg(strMsg, strCaption, msgBoxButtons, msgBoxIcon);   // Display Message Box
        }
        #endregion      // public static void DisplayWarningDlg

        #region public static void DisplayErrorDlg
        /// <summary>
        /// STATIC Method DisplayErrorDlg used to Display an Error Message Box
        /// </summary>
        /// <param name="strMsg">Message to display</param>
        public static void DisplayErrorDlg(string strMsg)
        {
            string strCaption = strDefaultCaption;                          // Message Box Caption
            MessageBoxButtons msgBoxButtons = MessageBoxButtons.OK;         // Message Box Buttons
            MessageBoxIcon msgBoxIcon = MessageBoxIcon.Error;             // Message Box Icon

            DisplayMsgDlg(strMsg, strCaption, msgBoxButtons, msgBoxIcon);   // Display Message Box
        }
        #endregion      // public static void DisplayErrorDlg

        #region  private static void DisplayMsgDlg
        /// <summary>
        /// STATIC Private Method - Common Message Box Display Method
        /// </summary>
        /// <param name="strMsg"></param>
        /// <param name="strCaption"></param>
        /// <param name="msgBoxButtons"></param>
        /// <param name="msgBoxIcon"></param>
        private static void DisplayMsgDlg(string strMsg, string strCaption,
                                          MessageBoxButtons msgBoxButtons,
                                          MessageBoxIcon msgBoxIcon)
        {
            MessageBox.Show(strMsg, strCaption, msgBoxButtons, msgBoxIcon);
        }
        #endregion      //  private static void DisplayMsgDlg
    }
    #endregion      // public static class PinchMsgDlg
}
#endregion      // namespace PinchGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
