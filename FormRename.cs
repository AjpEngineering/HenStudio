#region HEADER
//#####################################################################################################################
//###########################################  F o r m R e n a m e . c s  #############################################
//#####################################################################################################################
//  FILENAME:  FormRename.cs
//  NAMESPACE: HenStudio
//  CLASS(S):  FormRename
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for Displaying the Rename Form used by Project, Profile, Pinch and Hen.
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

#endregion  // REFERENCES

#region namespace HenStudio
namespace HenStudio
{
    #region class FormRename : Form
    /// <summary>
    /// Common Renmamn Form Used by Project, Profile, Pinch, and Hen
    /// </summary>
    public partial class FormRename : Form
    {
        #region PROPERTIES
        public string NewNodeName { get; set; }         // New Name of Node
        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Parameterized CTOR
        /// </summary>
        public FormRename(string strTitle, string originalNodeName)
        {
            InitializeComponent();

            this.textBoxRenameValue.Text = originalNodeName;
            this.Text = strTitle;

        }
        #endregion  // CTOR

        #region OK BUTTON CLICK
        private void buttonOK_Click(object sender, EventArgs e)
        {
            NewNodeName = this.textBoxRenameValue.Text;
        }
        #endregion  // OK BUTTON CLICK

    }
    #endregion  // class FormRename : Form
}
#endregion  // namespace HenStudio

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
