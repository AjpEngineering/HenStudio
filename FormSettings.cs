#region HEADER
//#####################################################################################################################
//#########################################  F o r m S e t t i n g s . c s  ###########################################
//#####################################################################################################################
//  FILENAME:  FormSettings.cs
//  NAMESPACE: HenStudio
//  CLASS(S):  FormSettings
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the HEN Studio Application Settings Form.
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
//    01/01/26 .. pg .. Version 1.0
//#####################################################################################################################
//#####################################################################################################################
//#####################################################################################################################
#endregion      // HEADER

#region REFERENCES
using HenGlobal;

using HenStudio.Properties;

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

using static HenGlobal.HenProjectUnits;
using static HenGlobal.HenTypes;

#endregion  // REFERENCES

#region namespace HenStudio
namespace HenStudio
{
    #region partial class FormSettings
    /// <summary>
    ///  AJP HEN Studio Application Settings Form Class
    /// </summary>

    public partial class FormSettings : Form
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio";
        const string CLASS = "FormSettings";

        const string HEN_OPTIMIZER_GENETIC_NAME = "Genetic";
        const string HEN_OPTIMIZER_GREEDY_NAME = "Greedy";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public DefaultProjectSettings InitialDefaultProjectSettingsObj { get; set; }       // Initial DEFAULT PROJECT Settings Object

        public DefaultProjectSettings FinalDefaultProjectSettingsObj { get; set; }         // Final DEFAULT PROJECT Settings Object

        #endregion  // PROPERTIES

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        //------------------------------------------------------------ CTOR ---
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        #region CTOR
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="currDefaultProjectUnitsObj">Initial Default Project Settings</param>
        public FormSettings(DefaultProjectSettings currDefaultProjectUnitsObj)
        {
            //-------------------------------------
            //--- Initialize Default Properties ---
            //-------------------------------------
            InitialDefaultProjectSettingsObj = currDefaultProjectUnitsObj;

            FinalDefaultProjectSettingsObj = currDefaultProjectUnitsObj;

            InitializeComponent();

        }
        #endregion  // CTOR

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        //-------------------------------------------------- EVENT HANDLERS ---
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        #region LOAD FORM
        private void FormSettings_Load(object sender, EventArgs e)
        {
            string strMethod = "FormSettings_Load";
            try
            {
                //---------------------------
                //--- Load ComboBox Items ---
                //---------------------------
                LoadSystemUnits();
                LoadMagnitude();
                LoadTemperature(InitialDefaultProjectSettingsObj.ExternalAppDefaultUnitsObj.ProjectSystemUnitsEnum);
                LoadPressure(InitialDefaultProjectSettingsObj.ExternalAppDefaultUnitsObj.ProjectSystemUnitsEnum,
                             InitialDefaultProjectSettingsObj.ExternalAppDefaultUnitsObj.ProjectMagnitudeEnum);

                //------------------------------------------------------------------
                //--- Initialize Controls with Inital Default Project Properties ---
                //------------------------------------------------------------------
                if (InitialDefaultProjectSettingsObj.ExternalAppDefaultUnitsObj.ProjectSystemUnitsEnum == HenProjectUnits.ProjectSystemUnits.METRIC)
                {
                    comboBoxUnitsSystem.SelectedItem = HenProjectUnits.ProjectSystemUnits.METRIC.ToString();
                    pictureBoxUnitsSystem.Image = Resources.Metric_SI_Units_32x32;
                }
                else
                {
                    comboBoxUnitsSystem.SelectedItem = HenProjectUnits.ProjectSystemUnits.ENGLISH.ToString();
                    pictureBoxUnitsSystem.Image = Resources.English_Imperial_Units_32x32;
                }


            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "HenTypes Object CREATED");
                HenLogger.WriteSeparatorLine('<');
            }
        }
        #endregion  // LOAD FORM

        #region DEFAULT UNITS EVENT HANDLERS

        #region SYSTEM UNITS SELECTION CHANGED
        private void comboBoxUnitsSystem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateDefaultControls();
        }
        #endregion  // SYSTEM UNITS SELECTION CHANGED

        #endregion  // DEFAULT UNITS EVENT HANDLERS

        #region DEFAULT EXCHANGER EVENT HANDLERS

        #endregion  // DEFAULT EXCHANGER EVENT HANDLERS

        #region DEFAULT HEN EVENT HANDLERS

        #endregion  // DEFAULT HEN EVENT HANDLERS

        #region U VALUE TEXTBOX KEY PRESS HANDLER ... Ensure Numeric Data Only
        private void textBoxDefaultU_Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            //-----------------------------------------
            //--- Ensure Only Numberic Data Entered ---
            //-----------------------------------------
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        #endregion  // U VALUE TEXTBOX KEY PRESS HANDLER ... Ensure Numeric Data Only


        private void LoadSystemUnits()
        {
            //----------------------------------------
            //--- Load System Units ComboBox Items ---
            //----------------------------------------
            comboBoxUnitsSystem.Items.Clear();
            comboBoxUnitsSystem.Items.Add(HenProjectUnits.ProjectSystemUnits.ENGLISH.ToString());
            comboBoxUnitsSystem.Items.Add(HenProjectUnits.ProjectSystemUnits.METRIC.ToString());
        }

        private void LoadMagnitude()
        {
            //-------------------------------------
            //--- Load Magnitude ComboBox Items ---
            //-------------------------------------
            comboBoxUnitsMagnitude.Items.Clear();
            comboBoxUnitsMagnitude.Items.Add(HenProjectUnits.ProjectMagnitude.BASE.ToString());
            comboBoxUnitsMagnitude.Items.Add(HenProjectUnits.ProjectMagnitude.KILO.ToString());
            comboBoxUnitsMagnitude.Items.Add(HenProjectUnits.ProjectMagnitude.MEGA.ToString());
        }

        private void LoadTemperature(HenProjectUnits.ProjectSystemUnits ProjectSystemUnitsEnum)
        {
            if (ProjectSystemUnitsEnum == HenProjectUnits.ProjectSystemUnits.ENGLISH)
            {
                comboBoxUnitsTemp.Items.Clear();
                comboBoxUnitsTemp.Items.Add(HenProjectUnits.ProjectEnglishTemp.DEG_F.ToString());
                comboBoxUnitsTemp.Items.Add(HenProjectUnits.ProjectEnglishTemp.DEG_R.ToString());
            }
            else if (ProjectSystemUnitsEnum == HenProjectUnits.ProjectSystemUnits.METRIC)
            {
                comboBoxUnitsTemp.Items.Clear();
                comboBoxUnitsTemp.Items.Add(HenProjectUnits.ProjectMetricTemp.DEG_C.ToString());
                comboBoxUnitsTemp.Items.Add(HenProjectUnits.ProjectMetricTemp.KELVIN.ToString());
            }
        }


        private void LoadPressure(HenProjectUnits.ProjectSystemUnits ProjectSystemUnitsEnum,
                                  HenProjectUnits.ProjectMagnitude ProjectMagnitudeEnum)
        {
            if (ProjectSystemUnitsEnum == HenProjectUnits.ProjectSystemUnits.ENGLISH)
            {
                comboBoxUnitsPress.Items.Clear();
                comboBoxUnitsPress.Items.Add(HenProjectUnits.ProjectEnglishPress.PSIA.ToString());
                comboBoxUnitsPress.Items.Add(HenProjectUnits.ProjectEnglishPress.PSIG.ToString());
                comboBoxUnitsPress.Items.Add(HenProjectUnits.ProjectEnglishPress.PSF.ToString());
                comboBoxUnitsPress.Items.Add(HenProjectUnits.ProjectEnglishPress.ATM.ToString());
                comboBoxUnitsPress.Items.Add(HenProjectUnits.ProjectEnglishPress.IN_HG.ToString());
                comboBoxUnitsPress.Items.Add(HenProjectUnits.ProjectEnglishPress.IN_H2O.ToString());
            }
            else if ((ProjectSystemUnitsEnum == HenProjectUnits.ProjectSystemUnits.METRIC) &&
                     (ProjectMagnitudeEnum == HenProjectUnits.ProjectMagnitude.BASE))
            {
                comboBoxUnitsPress.Items.Clear();
                comboBoxUnitsPress.Items.Add(HenProjectUnits.ProjectMetricPress.BAR.ToString());
                comboBoxUnitsPress.Items.Add(HenProjectUnits.ProjectMetricPress.Pa.ToString());
            }
            else if ((ProjectSystemUnitsEnum == HenProjectUnits.ProjectSystemUnits.METRIC) &&
                     (ProjectMagnitudeEnum == HenProjectUnits.ProjectMagnitude.KILO))
            {
                comboBoxUnitsPress.Items.Clear();
                comboBoxUnitsPress.Items.Add(HenProjectUnits.ProjectMetricPress.BAR.ToString());
                comboBoxUnitsPress.Items.Add(HenProjectUnits.ProjectMetricPress.Pa.ToString());
            }
            else if ((ProjectSystemUnitsEnum == HenProjectUnits.ProjectSystemUnits.METRIC) &&
                     (ProjectMagnitudeEnum == HenProjectUnits.ProjectMagnitude.BASE))
            {
                comboBoxUnitsPress.Items.Clear();
                comboBoxUnitsPress.Items.Add(HenProjectUnits.ProjectMetricPress.BAR.ToString());
                comboBoxUnitsPress.Items.Add(HenProjectUnits.ProjectMetricPress.Pa.ToString());
            }
        }


        #region UpdateDefaultControls()
        private void UpdateDefaultControls()
        {
            string strMethod = "UpdateDefaultControls";
            try
            {
                //--------------------
                //--- SYSTEM UNITS ---
                //--------------------
                string strSelectedItem = comboBoxUnitsSystem.SelectedItem.ToString();
                #region METRIC
                if (string.Compare(strSelectedItem, HenProjectUnits.ProjectSystemUnits.METRIC.ToString(), true) == 0)
                {
                    FinalDefaultProjectSettingsObj.ExternalAppDefaultUnitsObj.ProjectSystemUnitsEnum = HenProjectUnits.ProjectSystemUnits.METRIC;
                    pictureBoxUnitsSystem.Image = Resources.Metric_SI_Units_32x32;
                }
                #endregion  // METRIC

                #region ENGLISH
                else if (string.Compare(strSelectedItem, HenProjectUnits.ProjectSystemUnits.ENGLISH.ToString(), true) == 0)
                {
                    FinalDefaultProjectSettingsObj.ExternalAppDefaultUnitsObj.ProjectSystemUnitsEnum = HenProjectUnits.ProjectSystemUnits.ENGLISH;
                    pictureBoxUnitsSystem.Image = Resources.English_Imperial_Units_32x32;
                }
                #endregion  // ENGLISH

            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // UpdateDefaultControls()

        #region OK BUTTON HANDLER
        private void buttonOK_Click(object sender, EventArgs e)
        {
            string strMethod = "buttonOK_Click";
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "OK Button Click");
            try
            {
                HenMsgDlg.DisplayWarningDlg("Handle OK Button Click!");
                //---------------------------------------------------------------------
                //--- Scrape Screen and Assign Control Values to New Default Values ---
                //---------------------------------------------------------------------

                #region DEFAULT EXCHANGER PARAMETERS
                FinalDefaultProjectSettingsObj.ProjectExchangerU = Convert.ToDouble(textBoxDefaultU_Value.Text);
                #endregion  // DEFAULT EXCHANGER PARAMETERS

                #region DEFAULT HEN OPTIMIZER
                if (string.Compare(comboBoxDefaultHenOpitimizer.Text, HenOptimizer.GENETIC.ToString()) == 0)
                {
                    FinalDefaultProjectSettingsObj.ProjectHenOptimizerEnum = HenOptimizer.GENETIC;
                }
                else if (string.Compare(comboBoxDefaultHenOpitimizer.Text, HenOptimizer.GREEDY.ToString()) == 0)
                {
                    FinalDefaultProjectSettingsObj.ProjectHenOptimizerEnum = HenOptimizer.GREEDY;
                }
                #endregion  // DEFAULT HEN OPTIMIZER

                #region DEFAULT UNITS

                #endregion  // DEFAULT UNITS

            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // OK BUTTON HANDLER

        #region CANCEL BUTTON HANDLER
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            string strMethod = "buttonCancel_Click";
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Cancel Button Click");
            try
            {
                HenMsgDlg.DisplayWarningDlg("Handle Cancel Button Click!");
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // CANCEL BUTTON HANDLER

    }
    #endregion// partial class FormSettings

}
#endregion      // namespace HenStudio

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
