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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;   // Chart Component
using System.Xml.Linq;

using PinchGlobal;
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
        //--- Stream Background Colors ---
        private Color colorBackgroundHotStream  = Color.LightCoral;
        private Color colorBackgroundColdStream = Color.LightBlue;
        private Color colorBackgroundNA_Stream  = Color.WhiteSmoke;

        //--- Stream Text Colors --- 
        private Color colorTextHotStream  = Color.Black;
        private Color colorTextColdStream = Color.Black;
        private Color colorTextNA_Stream  = Color.Black;

        #endregion  // COLORS

        //private PinchProjectData _projectPropertiesDataObj;

        private bool _bPinchEnglishUnits;   // Pinch English Units ... English (true)  Metric (false)
        private bool _bPinchCalcModeFCp;    // Pinch Calculation Mode ... Use CP (false)  Use F Cp (true)
        private bool _bInputVerified;       // Pinch Input Stream Data Verified

        private PinchFileSystem _pinchFileSys;
        //private PinchInputMgr _pinchInput;
        //private EnergyTargetsMgr _pinchEnergyTargets;
        //private PinchReportMgr _pinchReport;

        #endregion      // FIELDS

        #region PROPERTIES

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
                this.Text = "Pinch 4";
                InitializeComponent();
                //----------------------
                //--- Create Objects ---
                //----------------------
                //projectPropertiesDataObj = new PinchProjectData();

                //PinchFileSysObj = new PinchFileSysStructure();
                //PinchInputObj = new PinchInputMgr(PinchFileSysObj);
                //PinchEnergyTargetsObj = new EnergyTargetsMgr(PinchFileSysObj);
                //PinchReportObj = new PinchReportMgr(PinchFileSysObj);

                //bPinchEnglishUnitsFlag = true;
                //bPinchCalcModeFCpFlag = false;
                //bInputVerifiedFlag = false;
                //---------------------------
                //--- Initialize Controls ---
                //---------------------------
                //InitializeControls();       // Set inital state of the Form Controls

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


        #endregion      // EVENT HANDLERS


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
