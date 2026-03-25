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
using System.Collections;
using System.Collections.Generic;
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

    public partial class FormAppSettings : Form
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
        /// <param name="appProjectSettingsObj">Application Project Settings</param>
        public FormAppSettings(DefaultProjectSettings appProjectSettingsObj)
        {
            //-------------------------------------
            //--- Initialize Default Properties ---
            //-------------------------------------

            InitialDefaultProjectSettingsObj = appProjectSettingsObj;

            FinalDefaultProjectSettingsObj = appProjectSettingsObj;

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
                LoadSystemUnits(FinalDefaultProjectSettingsObj.ExternalUnitsObj);
                LoadMagnitude();

                LoadTemperature();

                //LoadPressure(InitialDefaultProjectSettingsObj.ExternalAppDefaultUnitsObj.ProjectSystemUnitsEnum,
                //             InitialDefaultProjectSettingsObj.ExternalAppDefaultUnitsObj.ProjectMagnitudeEnum);

                //------------------------------------------------------------------
                //--- Initialize Controls with Inital Default Project Properties ---
                //------------------------------------------------------------------
                //if (InitialDefaultProjectSettingsObj.ExternalAppDefaultUnitsObj.ProjectSystemUnitsEnum == HenProjectUnits.ProjectSystemUnits.METRIC)
                //{
                //    comboBoxUnitsSystem.SelectedItem = HenProjectUnits.ProjectSystemUnits.METRIC.ToString();
                //    pictureBoxUnitsSystem.Image = Resources.Metric_SI_Units_32x32;
                //}
                //else
                //{
                //    comboBoxUnitsSystem.SelectedItem = HenProjectUnits.ProjectSystemUnits.ENGLISH.ToString();
                //    pictureBoxUnitsSystem.Image = Resources.English_Imperial_Units_32x32;
                //}


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
            UpdateForSystemUnitsChange();
        }
        #endregion  // SYSTEM UNITS SELECTION CHANGED

        #region MAGNITUDE SELECTION CHANGED
        private void comboBoxUnitsMagnitude_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateForMagnitudeChange();
        }
        #endregion  // MAGNITUDE SELECTION CHANGED

        #region TEMPERATURE SELECTION CHANGED
        private void comboBoxUnitsTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateForTemperatureChange();
        }
        #endregion  // TEMPERATURE SELECTION CHANGED

        #region PRESSURE SELECTION CHANGED
        private void comboBoxUnitsPress_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateForPressureChange();
        }
        #endregion  // PRESSURE SELECTION CHANGED

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

        #region UpdateSystemUnitsImage()
        private void UpdateSystemUnitsImage()
        {
            #region METRIC
            if (FinalDefaultProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum == HenProjectUnits.ProjectSystemUnits.METRIC)
            {
                pictureBoxUnitsSystem.Image = Resources.Metric_SI_Units_32x32;
            }
            #endregion  // METRIC

            #region ENGLISH
            else if (FinalDefaultProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum == HenProjectUnits.ProjectSystemUnits.ENGLISH)
            {
                pictureBoxUnitsSystem.Image = Resources.English_Imperial_Units_32x32;
            }
                #endregion  // ENGLISH        
        }
        #endregion  // UpdateSystemUnitsImage()

        #region LOAD COMBO BOX DROP DOWN LISTS

        #region LoadSystemUnits()
        private void LoadSystemUnits(HenProjectUnits externUnits)
        {
            string strMethod = "LoadSystemUnits";
            int nIndex = 0;
            int nSelectIndex = 0;
            string strSelectName = externUnits.GetSystemUnitsString();
            try
            {
                ProjectSystemUnits systemUnitsEnum = externUnits.ProjectSystemUnitsEnum;

                //----------------------------------------
                //--- Load System Units ComboBox Items ---
                //----------------------------------------
                List<string> lst = externUnits.GetSystemUnitsList();

                comboBoxUnitsSystem.Items.Clear();
                foreach(string str in lst)
                {
                    nIndex= comboBoxUnitsSystem.Items.Add(str);
                }
                if (comboBoxUnitsSystem.Items.Count > 0) comboBoxUnitsSystem.SelectedItem = strSelectName;  // Select Item
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                UpdateSystemUnitsImage();
            }
        }
        #endregion  // LoadSystemUnits()

        #region LoadMagnitude()
        private void LoadMagnitude()
        {
            //-------------------------------------
            //--- Load Magnitude ComboBox Items ---
            //-------------------------------------
            List<string> lst = FinalDefaultProjectSettingsObj.ExternalUnitsObj.GetMagnitudeList();

            comboBoxUnitsMagnitude.Items.Clear();
            foreach (string str in lst)
            {
                comboBoxUnitsMagnitude.Items.Add(str);
            }
            if (comboBoxUnitsMagnitude.Items.Count > 0) comboBoxUnitsMagnitude.SelectedIndex = 0;  // Select First Item
        }
        #endregion  // LoadMagnitude()

        #region LoadTemperature()
        private void LoadTemperature()
        {
            string strMethod = "LoadTemperature";
            HenProjectUnits externUnits = FinalDefaultProjectSettingsObj.ExternalUnitsObj;
            ProjectSystemUnits systemUnitsEnum = externUnits.ProjectSystemUnitsEnum;
            try
            {
                if (systemUnitsEnum == HenProjectUnits.ProjectSystemUnits.ENGLISH)
                {
                    List<string> lstEng = externUnits.GetEnglishTempList();

                    comboBoxUnitsTemp.Items.Clear();
                    foreach (string str in lstEng)
                    {
                        comboBoxUnitsTemp.Items.Add(str);
                    }
                    if (comboBoxUnitsTemp.Items.Count > 0) comboBoxUnitsTemp.SelectedIndex = 0;  // Select First Item
                }
                else if (systemUnitsEnum == HenProjectUnits.ProjectSystemUnits.METRIC)
                {
                    List<string> lstMet = externUnits.GetMetricTempList();

                    comboBoxUnitsTemp.Items.Clear();
                    foreach (string str in lstMet)
                    {
                        comboBoxUnitsTemp.Items.Add(str);
                    }
                    if (comboBoxUnitsTemp.Items.Count > 0) comboBoxUnitsTemp.SelectedIndex = 0;  // Select First Item
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
            }
        }
        #endregion  // LoadTemperature()

        #region LoadPressure()
        private void LoadPressure()
        {
            string strMethod = "LoadPressure";
            HenProjectUnits externUnits = FinalDefaultProjectSettingsObj.ExternalUnitsObj;
            ProjectSystemUnits systemUnitsEnum = externUnits.ProjectSystemUnitsEnum;
            ProjectMagnitude magnitudeEnum = externUnits.ProjectMagnitudeEnum;
            try
            {
                if (systemUnitsEnum == HenProjectUnits.ProjectSystemUnits.ENGLISH)
                {
                    List<string> lstEng = externUnits.GetEnglishPressList();

                    comboBoxUnitsPress.Items.Clear();
                    foreach (string str in lstEng)
                    {
                        comboBoxUnitsPress.Items.Add(str);
                    }
                    if (comboBoxUnitsPress.Items.Count > 0) comboBoxUnitsPress.SelectedIndex = 0;  // Select First Item
                }
                else if (systemUnitsEnum == HenProjectUnits.ProjectSystemUnits.METRIC)
                {
                    List<string> lstMet = externUnits.GetMetricPressList(magnitudeEnum);

                    comboBoxUnitsPress.Items.Clear();
                    foreach (string str in lstMet)
                    {
                        comboBoxUnitsPress.Items.Add(str);
                    }
                    if (comboBoxUnitsPress.Items.Count > 0) comboBoxUnitsPress.SelectedIndex = 0;  // Select First Item
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
            }
        }
        #endregion  // LoadPressure()

        #endregion  // LOAD COMBO BOX DROP DOWN LISTS

        #region COMBO BOX SELECTION CHANGE HANDLERS

        #region UpdateForSystemUnitsChange()
        private void UpdateForSystemUnitsChange()
        {
            string strMethod = "UpdateForSystemUnitsChange";
            try
            {
                //--------------------
                //--- SYSTEM UNITS ---
                //--------------------
                string strSelectedItem = comboBoxUnitsSystem.SelectedItem.ToString();
                #region METRIC
                if (string.Compare(strSelectedItem, HenProjectUnits.METRIC_UNITS, true) == 0)
                {
                    FinalDefaultProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum = HenProjectUnits.ProjectSystemUnits.METRIC;
                    pictureBoxUnitsSystem.Image = Resources.Metric_SI_Units_32x32;
                }
                #endregion  // METRIC

                #region ENGLISH
                else if (string.Compare(strSelectedItem, HenProjectUnits.ENGLISH_UNITS, true) == 0)
                {
                    FinalDefaultProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum = HenProjectUnits.ProjectSystemUnits.ENGLISH;
                    pictureBoxUnitsSystem.Image = Resources.English_Imperial_Units_32x32;
                }
                #endregion  // ENGLISH

                //-----------------
                //--- MAGNITUDE ---
                //-----------------
                LoadMagnitude();

                //-------------------
                //--- TEMPERATURE ---
                //-------------------
                LoadTemperature();

                //----------------
                //--- PRESSURE ---
                //----------------
                LoadPressure();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                UpdateSystemUnitsImage();
            }
        }
        #endregion  // UpdateForSystemUnitsChange()

        #region UpdateForMagnitudeChange()
        private void UpdateForMagnitudeChange()
        {
            string strMethod = "UpdateForMagnitudeChange";
            try
            {


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
        #endregion  // UpdateForMagnitudeChange()

        #region UpdateForTemperatureChange()
        private void UpdateForTemperatureChange()
        {
            string strMethod = "UpdateForTemperatureChange";
            try
            {


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
        #endregion  // UpdateForTemperatureChange()

        #region UpdateForPressureChange()
        private void UpdateForPressureChange()
        {
            string strMethod = "UpdateForPressureChange";
            try
            {


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
        #endregion  // UpdateForPressureChange()

        #endregion  // COMBO BOX SELECTIOCHANGE HANDLERS

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
