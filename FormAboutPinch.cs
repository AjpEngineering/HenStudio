#region HEADER
//#####################################################################################################################
//#######################################  F o r m A b o u t P i n c h . c s  #########################################
//#####################################################################################################################
//  FILENAME:  FormAboutPinch.cs
//  NAMESPACE: Pinch
//  CLASS(S):  FormAboutPinch
//  COMPONENT: Pinch.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the About Pinch Form class.
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
    #region public partial class FormAboutPinch : Form
    public partial class FormAboutPinch : Form
    {
        #region CONSTANTS
        const string NAMESPACE = "Pinch";
        const string CLASS = "FormAboutPinch";
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
        public FormAboutPinch()
        {
            InitializeComponent();
        }

        #endregion  // CTOR
    }
    #endregion  // public partial class FormAboutPinch : Form
}
#endregion  // namespace Pinch

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
