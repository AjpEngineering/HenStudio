#region HEADER
//#####################################################################################################################
//#############################################  F o r m M a i n . c s  ###############################################
//#####################################################################################################################
//  FILENAME:  FormMain.cs
//  NAMESPACE: Pinch
//  CLASS(S):  FormMain
//  COMPONENT: Pinch.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Main Pinch Form.
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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;   // Chart Component
using System.Xml.Linq;

using PinchData;

using PinchGlobal;

using PinchHen;

using PinchTargets;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
#endregion  // REFERENCES

#region namespace Pinch
namespace Pinch
{
    #region public partial class FormMain
    /// <summary>
    /// Pinch Main Form Class
    /// </summary>
    public partial class FormMain : Form
    {
        #region CONSTANTS
        const string NAMESPACE = "Pinch";
        const string CLASS = "FormMain";

        const string PINCH_UNITS_ENGLISH = "English";
        const string PINCH_UNITS_METRIC = "Metric";

        const string PINCH_CALC_MODE_ENTER_CP = "Enter CP - Heat Capacity Flow Rate";
        const string PINCH_CALC_MODE_ENTER_F_Cp = "Enter Flow Rate and Specific Heat Capacity (Cp)";

        const string STREAM_TYPE_HOT = "HOT";
        const string STREAM_TYPE_COLD = "COLD";
        const string STREAM_TYPE_NA = "NA";

        const string STREAM_PHASE_LIQUID = "LIQUID";
        const string STREAM_PHASE_TWO_PHASE = "TWO-PHASE";
        const string STREAM_PHASE_VAPOR = "VAPOR";
        const string STREAM_PHASE_LNA = "NA";
        #endregion      // CONSTANTS

        #region ENUMS
        #endregion      // ENUMS

        #region FIELDS

        #region COLORS
        //--------------------------------
        //--- Stream Background Colors ---
        //--------------------------------
        private Color _colorBackgroundHotStream  = Color.LightCoral;
        private Color _colorBackgroundColdStream = Color.LightBlue;
        private Color _colorBackgroundNA_Stream  = Color.WhiteSmoke;
        //--------------------------
        //--- Stream Text Colors ---
        //--------------------------
        private Color _colorTextHotStream  = Color.Black;
        private Color _colorTextColdStream = Color.Black;
        private Color _colorTextNA_Stream  = Color.Black;
        #endregion  // COLORS

        #region SETTINGS
        private bool _bPinchEnglishUnits;   // Pinch English Units ... English (true)  Metric (false)
        private bool _bPinchCalcModeFCp;    // Pinch Calculation Mode ... Use CP (false)  Use F Cp (true)
        private bool _bInputVerified;       // Pinch Input Stream Data Verified
        #endregion  // SETTINGS

        #region OBJECTS
        //---------------
        //--- OBJECTS ---
        //---------------
        private PinchTypes _pinchTypes;
        private PinchFileSystem _pinchFileSys;

        //private PinchProjectData _projectPropertiesDataObj;
        //private PinchInputMgr _pinchInput;
        //private EnergyTargetsMgr _pinchEnergyTargets;
        //private PinchReportMgr _pinchReport;
        #endregion  // OBJECTS

        #endregion      // FIELDS

        #region PROPERTIES

        #region COLORS
        //--------------
        //--- COLORS ---
        //--------------
        #region ColorBackgroundHotStream
        /// <summary>
        /// ColorBackgroundHotStream Property
        /// </summary>
        public Color ColorBackgroundHotStream
        {
            get { return _colorBackgroundHotStream; }
            set { _colorBackgroundHotStream = value; }
        }
        #endregion      // ColorBackgroundHotStream

        #region ColorBackgroundColdStream
        /// <summary>
        /// ColorBackgroundColdStream Property
        /// </summary>
        public Color ColorBackgroundColdStream
        {
            get { return _colorBackgroundColdStream; }
            set { _colorBackgroundColdStream = value; }
        }
        #endregion      // ColorBackgroundColdStream

        #region ColorBackgroundNA_Stream
        /// <summary>
        /// ColorBackgroundNA_Stream Property
        /// </summary>
        public Color ColorBackgroundNA_Stream
        {
            get { return _colorBackgroundNA_Stream; }
            set { _colorBackgroundNA_Stream = value; }
        }
        #endregion      // ColorBackgroundNA_Stream

        #region ColorTextHotStream
        /// <summary>
        /// ColorTextHotStream Property
        /// </summary>
        public Color ColorTextHotStream
        {
            get { return _colorTextHotStream; }
            set { _colorTextHotStream = value; }
        }
        #endregion      // ColorTextHotStream

        #region ColorTextColdStream
        /// <summary>
        /// ColorTextColdStream Property
        /// </summary>
        public Color ColorTextColdStream
        {
            get { return _colorTextColdStream; }
            set { _colorTextColdStream = value; }
        }
        #endregion      // ColorTextColdStream

        #region ColorTextNA_Stream
        /// <summary>
        /// ColorTextNA_Stream Property
        /// </summary>
        public Color ColorTextNA_Stream
        {
            get { return _colorTextNA_Stream; }
            set { _colorTextNA_Stream = value; }
        }
        #endregion      // ColorTextNA_Stream

        #endregion  // COLORS

        #region SETTINGS
        //----------------
        //--- SETTINGS ---
        //----------------
        #region bPinchEnglishUnitsFlag
        /// <summary>
        /// bPinchEnglishUnitsFlag Property
        /// </summary>
        public bool bPinchEnglishUnitsFlag
        {
            get { return _bPinchEnglishUnits; }
            set { _bPinchEnglishUnits = value; }
        }
        #endregion      // bPinchEnglishUnitsFlag

        #region bPinchCalcModeFCpFlag
        /// <summary>
        /// bPinchCalcModeFCpFlag Property
        /// </summary>
        public bool bPinchCalcModeFCpFlag
        {
            get { return _bPinchCalcModeFCp; }
            set { _bPinchCalcModeFCp = value; }
        }
        #endregion      // bPinchCalcModeFCpFlag

        #region bInputVerifiedFlag
        /// <summary>
        /// bInputVerifiedFlag Property
        /// </summary>
        public bool bInputVerifiedFlag
        {
            get { return _bInputVerified; }
            set { _bInputVerified = value; }
        }
        #endregion      // bInputVerifiedFlag

        #endregion  // SETTINGS

        #region GLOBL OBJECTS
        //---------------------
        //--- GLOBL OBJECTS ---
        //---------------------
        #region PinchTypesObj
        /// <summary>
        /// PinchTypesObj Property
        /// </summary>
        public PinchTypes PinchTypesObj
        {
            get { return _pinchTypes; }
            set { _pinchTypes = value; }
        }

        #endregion      // PinchTypesObj

        #region PinchFileSysObj
        /// <summary>
        /// PinchFileSystem Property
        /// </summary>
        public PinchFileSystem PinchFileSysObj
        {
            get { return _pinchFileSys; }
            set { _pinchFileSys = value; }
        }
        #endregion      // PinchFileSysObj

        #endregion  // GLOBL OBJECTS

        #region DATA OBJECTS
        //--------------------
        //--- DATA OBJECTS ---
        //--------------------
        //#region projectPropertiesDataObj
        ///// <summary>
        ///// projectPropertiesDataObj Property
        ///// </summary>
        //public PinchProjectData projectPropertiesDataObj
        //{
        //    get { return _projectPropertiesDataObj; }
        //    set { _projectPropertiesDataObj = value; }
        //}
        //#endregion      // projectPropertiesDataObj

        //#region PinchInputObj
        ///// <summary>
        ///// PinchInput Property
        ///// </summary>
        //public PinchInputMgr PinchInputObj
        //{
        //    get { return _pinchInput; }
        //    set { _pinchInput = value; }
        //}
        //#endregion      // PinchInputObj

        #endregion  // DATA OBJECTS

        #region TARGETS OBJECTS
        //#region PinchEnergyTargetsObj
        ///// <summary>
        ///// PinchEnergyTargetsObj Property
        ///// </summary>
        //public EnergyTargetsMgr PinchEnergyTargetsObj
        //{
        //    get { return _pinchEnergyTargets; }
        //    set { _pinchEnergyTargets = value; }
        //}
        //#endregion      // PinchEnergyTargetsObj

        #endregion  // TARGETS OBJECTS

        #region REPORTS OBJECTS
        //#region PinchReportObj
        ///// <summary>
        ///// PinchReport Property
        ///// </summary>
        //public PinchReportMgr PinchReportObj
        //{
        //    get { return _pinchReport; }
        //    set { _pinchReport = value; }
        //}
        //#endregion      // PinchReportObj

        #endregion  // REPORTS OBJECTS

        #region FIGURES OBJECTS
        #endregion  // FIGURES OBJECTS

        #region HEN OBJECTS
        #endregion  // HEN OBJECTS

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public FormMain()
        {
            string strMethod = "CTOR";
            string strMsg = string.Empty;
            PinchLogger.WriteHeader();
            PinchLogger.WriteSection("START CONSTRUCTION SECTION");
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating Object");
            try
            {
                InitializeComponent();
                this.Text = "AJP Pinch 4";
                //----------------------
                //--- Create Objects ---
                //----------------------
                PinchTypesObj = new PinchTypes();
                PinchFileSysObj = new PinchFileSystem();

                //projectPropertiesDataObj = new PinchProjectData();

                //PinchInputObj = new PinchInputMgr(PinchFileSysObj);
                //PinchEnergyTargetsObj = new EnergyTargetsMgr(PinchFileSysObj);
                //PinchReportObj = new PinchReportMgr(PinchFileSysObj);

                //bPinchEnglishUnitsFlag = true;
                //bPinchCalcModeFCpFlag = false;
                //bInputVerifiedFlag = false;
                //---------------------------
                //--- Initialize Controls ---
                //---------------------------
                InitializeControls();       // Set inital state of the Form Controls

            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                PinchLogger.WriteSection("END CONSTRUCTION SECTION");
            }
        }
        #endregion      // CTOR

        #region public void Initialize Controls
        /// <summary>
        /// Set Initial State of Controls
        /// </summary>
        public void InitializeControls()
        {
            string strMethod = "InitializeControls";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Initializing Controls");
            try
            {
                this.Text = "AJP Pinch 4";
                this.BackColor = PinchTypesObj.AjpEngineeringGreen; // Form Background Color

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
        #endregion      // public void Initialize Controls

        #region EVENT HANDLERS

        #region FORM EVENTS

        #endregion  // FORM EVENTS

        #region MENU BAR EVENTS

        #region EXIT ITEM CLICK
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitPinch();    // Exit Pinch Application
        }
        #endregion       // EXIT ITEM CLICK

        #endregion  // MENU BAR EVENTS

        #region TOOL BAR EVENTS

        #endregion      // TOOL BAR EVENTS

        #endregion      // EVENT HANDLERS

        #region ExitPinch METHOD
        /// <summary>
        /// Common Exit Pinch Application ... invoked from Menu Item and Toolbar Click events
        /// </summary>
        private void ExitPinch()
        {
            string strMethod = "ExitPinch";
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Exiting Pinch Application");
            try
            {
                this.Close();
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
        #endregion  // ExitPinch METHOD

        #region LOG METHODS

        #region private string GetFixedLengthString(string strOriginal, int nLen=15)
        /// <summary>
        /// Get a Fixed Length Padded/Ellipsed String GIVEN String and Length
        /// Default length is 15 characters - pad with ' ' , ellipse "..."
        /// </summary>
        /// <param name="strOriginal">Original String</param>
        /// <param name="nLen">Fixed length of the final string</param>
        /// <returns></returns>
        private string GetFixedLengthString(string strOriginal, int nLen = 15)
        {
            string strTemp = string.Empty;
            string strFixedLengthString = string.Empty;
            string strPad = string.Empty;
            int nPad = 0;
            //--------------------
            //--- Lenght Guard ---
            //--------------------
            if (nLen < 4) return strOriginal;   // Minimum Fixed Length check
            //---------------------
            //--- Update String ---
            //---------------------
            if (strOriginal.Length == nLen) strFixedLengthString = strOriginal;
            else if (strOriginal.Length > nLen)
            {
                strTemp = strOriginal.Substring(0, nLen - 4);
                strFixedLengthString = string.Format("{0}...", strTemp);
            }
            else
            {
                nPad = nLen - strOriginal.Length;
                strPad = new string(' ', nPad);
                strFixedLengthString = string.Format("{0}{1}", strOriginal, strPad);
            }
            //----------------------------------
            //--- Return Fixed Length String ---
            //----------------------------------
            return strFixedLengthString;
        }

        #endregion      // private string GetFixedLengthString(string strOriginal, int nLen=15)

        #endregion      // LOG METHODS


    }
    #endregion      // class FormPinch
}
#endregion      // namespace Pinch
//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
