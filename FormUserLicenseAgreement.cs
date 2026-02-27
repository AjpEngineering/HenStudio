#region HEADER
//#####################################################################################################################
//#############################  F o r m U s e r L i c e n s e A g r e e m e n t . c s  ###############################
//#####################################################################################################################
//  FILENAME:  FormUserLicenseAgreement.cs
//  NAMESPACE: Pinch
//  CLASS(S):  FormUserLicenseAgreement
//  COMPONENT: Pinch.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the User License Agreement Form class.
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
using System.Windows.Forms;
#endregion  // REFERENCES

#region namespace HenStudio
namespace HenStudio
{
    #region class FormUserLicenseAgreement
    public partial class FormUserLicenseAgreement : Form
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio";
        const string CLASS = "FormUserLicenseAgreement";
        #endregion  // CONSTANTS

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public FormUserLicenseAgreement()
        {
            InitializeComponent();
        }
        #endregion  // CTOR

    }
    #endregion  // class FormUserLicenseAgreement
}
#endregion  // namespace HenStudio

