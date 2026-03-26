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
//    This file contains the code for the New Project Data Form (FormSettings).
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
    ///  New Project Data Form Class (FormSettings)
    /// </summary>

    public partial class FormSettings : Form
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio";
        const string CLASS = "FormSettings";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public DefaultProjectSettings NewProjectSettingsObj { get; set; } // NEW PROJECT Settings Object
        #endregion  // PROPERTIES

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        //------------------------------------------------------------ CTOR ---
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public FormSettings()
        {
            //------------------------------------------------
            //--- Initialize New Project Settings Property ---
            //------------------------------------------------
            NewProjectSettingsObj = new DefaultProjectSettings();

            InitializeComponent();

            //----------------------------------
            //--- Initialize Textbox Strings ---
            //----------------------------------
            this.textBoxProjectNameValue.Text = NewProjectSettingsObj.NewProjectName;
            this.textBoxProjectDescriptionValue.Text = NewProjectSettingsObj.NewProjectDescription;

            //-------------------------------------------
            //--- Initialize with METRIC System Units ---
            //-------------------------------------------
            SetDefaultMetricSettings();
            LoadHenOptimizer();
        }
        #endregion  // CTOR

        #region PopulateUnitsControls()
        /// <summary>
        /// Populate Units Controls based on Units Object Values
        /// </summary>
        private void PopulateUnitsControls()
        {
            string strMethod = "PopulateUnitsControls";
            try
            {
                //---------------------------
                //--- Get Control Strings ---
                //---------------------------
                string strSysUnits = NewProjectSettingsObj.ExternalUnitsObj.GetSystemUnitsString();        // System Units
                string strMagnitude = NewProjectSettingsObj.ExternalUnitsObj.GetMagnitudeString();         // Magnitude
                string strTemperature = NewProjectSettingsObj.ExternalUnitsObj.GetTemperatureString();     // Temperature
                string strPressure = NewProjectSettingsObj.ExternalUnitsObj.GetPressureString();           // Pressure

                string strArea = NewProjectSettingsObj.ExternalUnitsObj.GetAreaString();                   // A : Area
                string strDuty = NewProjectSettingsObj.ExternalUnitsObj.GetEnthalpyString();               // H : Enthalpy (Duty)
                string strCP = NewProjectSettingsObj.ExternalUnitsObj.GetHeatCapacityFlowRateString();     // CP: Heat Capacity Flow Rate (m*Cp)
                string strU = NewProjectSettingsObj.ExternalUnitsObj.GetHeatTransferCoefficientString();   // U : Heat Transfer Coeffiecient

                //------------------------------
                //--- Assign Textbox Strings ---
                //------------------------------
                this.textBoxUnitsAreaValue.Text = strArea;
                this.textBoxUnitsDutyValue.Text = strDuty;
                this.textBoxUnitsCPValue.Text = strCP;
                this.textBoxUnitsUValue.Text = strU;

                this.textBoxDefaultU_Units.Text = strU;
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
        #endregion  // PopulateUnitsControls()

        #region SetDefaultEngslishSettings()
        /// <summary>
        /// Set the Default English Settings for the Units Controls  
        /// </summary>
        private void SetDefaultEngslishSettings()
        {
            string strMethod = "SetDefaultEngslishSettings";
            try
            {
                //-----------------------
                //--- Set Enum Values ---
                //-----------------------
                NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;
                NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;
                NewProjectSettingsObj.ExternalUnitsObj.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_F;
                NewProjectSettingsObj.ExternalUnitsObj.ProjectEnglishPressEnum = ProjectEnglishPress.PSIA;
                
                //----------------------------------------
                //--- Load Combo Boxes and Select Item ---
                //----------------------------------------
                LoadSystemUnits();
                LoadMagnitude();
                LoadTemperature();
                LoadPressure();

                PopulateUnitsControls();
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
        #endregion  // SetDefaultEngslishSettings()

        #region SetDefaultMetricSettings()
        /// <summary>
        /// Set the Default English Settings for the Units Controls  
        /// </summary>
        private void SetDefaultMetricSettings()
        {
            string strMethod = "SetDefaultMetricSettings";
            try
            {
                //-----------------------
                //--- Set Enum Values ---
                //-----------------------
                NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;
                NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.KILO;
                NewProjectSettingsObj.ExternalUnitsObj.ProjectMetricTempEnum = ProjectMetricTemp.KELVIN;
                NewProjectSettingsObj.ExternalUnitsObj.ProjectMetricPressEnum = ProjectMetricPress.Pa;

                //----------------------------------------
                //--- Load Combo Boxes and Select Item ---
                //----------------------------------------
                LoadSystemUnits();
                LoadMagnitude();
                LoadTemperature();
                LoadPressure();

                PopulateUnitsControls();
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
        #endregion  // SetDefaultMetricSettings()

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        //-------------------------------------------------- EVENT HANDLERS ---
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

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
        /// <summary>
        /// Update the Systems Unit Image based on the New Project settings
        /// </summary>
        private void UpdateSystemUnitsImage()
        {
            string strMethod = "UpdateSystemUnitsImage";
            try
            {
                #region METRIC
                if (NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum == HenProjectUnits.ProjectSystemUnits.METRIC)
                {
                    pictureBoxUnitsSystem.Image = Resources.Metric_SI_Units_32x32;
                }
                #endregion  // METRIC

                #region ENGLISH
                else if (NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum == HenProjectUnits.ProjectSystemUnits.ENGLISH)
                {
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
        #endregion  // UpdateSystemUnitsImage()

        #region LOAD COMBO BOX DROP DOWN LISTS

        #region LoadSystemUnits()
        /// <summary>
        /// Load the System Units Combo Box based on Project Units Data
        /// </summary>
        private void LoadSystemUnits()
        {
            string strMethod = "LoadSystemUnits";
            try
            {
                //------------------------------
                //--- Get Project Units Data ---
                //------------------------------
                ProjectSystemUnits systemUnitsEnum = NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum;
                string strSelectName = NewProjectSettingsObj.ExternalUnitsObj.GetSystemUnitsString();

                //----------------------------------------
                //--- Load System Units ComboBox Items ---
                //----------------------------------------
                List<string> lst = NewProjectSettingsObj.ExternalUnitsObj.GetSystemUnitsList();

                comboBoxUnitsSystem.Items.Clear();
                foreach(string str in lst)
                {
                    comboBoxUnitsSystem.Items.Add(str);
                }

                //-------------------
                //--- Select Item ---
                //-------------------
                if (comboBoxUnitsSystem.Items.Count > 0)
                {
                    comboBoxUnitsSystem.SelectedItem = strSelectName;
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
                UpdateSystemUnitsImage();
            }
        }
        #endregion  // LoadSystemUnits()

        #region LoadMagnitude()
        /// <summary>
        /// Load the Magnitude Combo Box based on Project Units Data
        /// </summary>
        private void LoadMagnitude()
        {
            string strMethod = "LoadMagnitude";
            try
            {
                //------------------------------
                //--- Get Project Units Data ---
                //------------------------------
                ProjectMagnitude magnitudeEnum = NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum;
                string strSelectName = NewProjectSettingsObj.ExternalUnitsObj.GetMagnitudeString();

                //-------------------------------------
                //--- Load Magnitude ComboBox Items ---
                //-------------------------------------
                List<string> lst = NewProjectSettingsObj.ExternalUnitsObj.GetMagnitudeList();

                comboBoxUnitsMagnitude.Items.Clear();
                foreach (string str in lst)
                {
                    comboBoxUnitsMagnitude.Items.Add(str);
                }

                //-------------------
                //--- Select Item ---
                //-------------------
                if (comboBoxUnitsMagnitude.Items.Count > 0)
                {
                    comboBoxUnitsMagnitude.SelectedItem = strSelectName;
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
                UpdateSystemUnitsImage();
            }
        }
        #endregion  // LoadMagnitude()

        #region LoadTemperature()
        /// <summary>
        /// Load the Temperature Combo Box based on Project Units Data
        /// </summary>
        private void LoadTemperature()
        {
            string strMethod = "LoadTemperature";
            try
            {
                //------------------------------
                //--- Get Project Units Data ---
                //------------------------------
                ProjectSystemUnits systemUnitsEnum = NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum;
                ProjectMagnitude magnitudeEnum = NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum;
                string strSelectName = NewProjectSettingsObj.ExternalUnitsObj.GetTemperatureString();

                //---------------------------------------
                //--- Load Temperature ComboBox Items ---
                //---------------------------------------
                if (systemUnitsEnum == HenProjectUnits.ProjectSystemUnits.ENGLISH)
                {
                    List<string> lstEng = NewProjectSettingsObj.ExternalUnitsObj.GetEnglishTempList();

                    comboBoxUnitsTemp.Items.Clear();
                    foreach (string str in lstEng)
                    {
                        comboBoxUnitsTemp.Items.Add(str);
                    }
                }
                else if (systemUnitsEnum == HenProjectUnits.ProjectSystemUnits.METRIC)
                {
                    List<string> lstMet = NewProjectSettingsObj.ExternalUnitsObj.GetMetricTempList();

                    comboBoxUnitsTemp.Items.Clear();
                    foreach (string str in lstMet)
                    {
                        comboBoxUnitsTemp.Items.Add(str);
                    }
                }

                //-------------------
                //--- Select Item ---
                //-------------------
                if (comboBoxUnitsTemp.Items.Count > 0)
                {
                    comboBoxUnitsTemp.SelectedItem = strSelectName;
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
        /// <summary>
        /// Load the Pressure Combo Box based on Project Units Data
        /// </summary>
        private void LoadPressure()
        {
            string strMethod = "LoadPressure";
            try
            {
                //------------------------------
                //--- Get Project Units Data ---
                //------------------------------
                ProjectSystemUnits systemUnitsEnum = NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum;
                ProjectMagnitude magnitudeEnum = NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum;
                string strSelectName = NewProjectSettingsObj.ExternalUnitsObj.GetPressureString();

                //------------------------------------
                //--- Load Pressure ComboBox Items ---
                //------------------------------------
                if (systemUnitsEnum == HenProjectUnits.ProjectSystemUnits.ENGLISH)
                {
                    List<string> lstEng = NewProjectSettingsObj.ExternalUnitsObj.GetEnglishPressList();

                    comboBoxUnitsPress.Items.Clear();
                    foreach (string str in lstEng)
                    {
                        comboBoxUnitsPress.Items.Add(str);
                    }
                }
                else if (systemUnitsEnum == HenProjectUnits.ProjectSystemUnits.METRIC)
                {
                    List<string> lstMet = NewProjectSettingsObj.ExternalUnitsObj.GetMetricPressList(magnitudeEnum);

                    comboBoxUnitsPress.Items.Clear();
                    foreach (string str in lstMet)
                    {
                        comboBoxUnitsPress.Items.Add(str);
                    }
                }

                //-------------------
                //--- Select Item ---
                //-------------------
                if (comboBoxUnitsPress.Items.Count > 0)
                {
                    comboBoxUnitsPress.SelectedItem = strSelectName;
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

        #region LoadHenOptimizer()
        /// <summary>
        /// Load the System Units Combo Box based on Project Units Data
        /// </summary>
        private void LoadHenOptimizer()
        {
            string strMethod = "LoadHenOptimizer";
            try
            {
                //------------------------------
                //--- Get HEN Optimizer Data ---
                //------------------------------
                DefaultProjectSettings.HenOptimizer henOptimizerEnum = NewProjectSettingsObj.HenOptimizerEnum;

                string strSelectName = NewProjectSettingsObj.GetHenOptimizerString();

                //----------------------------------------
                //--- Load System Units ComboBox Items ---
                //----------------------------------------
                List<string> lst = NewProjectSettingsObj.GetHenOptimizerList();

                comboBoxDefaultHenOpitimizer.Items.Clear();
                foreach (string str in lst)
                {
                    comboBoxDefaultHenOpitimizer.Items.Add(str);
                }

                //-------------------
                //--- Select Item ---
                //-------------------
                if (comboBoxDefaultHenOpitimizer.Items.Count > 0)
                {
                    comboBoxDefaultHenOpitimizer.SelectedItem = strSelectName;
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
                UpdateSystemUnitsImage();
            }
        }
        #endregion  // LoadHenOptimizer()

        #endregion  // LOAD COMBO BOX DROP DOWN LISTS

        #region COMBO BOX SELECTION CHANGE HANDLERS

        #region UpdateForSystemUnitsChange()
        /// <summary>
        /// Handle System Units Change
        /// </summary>
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
                    SetDefaultMetricSettings();
                }
                #endregion  // METRIC

                #region ENGLISH
                else if (string.Compare(strSelectedItem, HenProjectUnits.ENGLISH_UNITS, true) == 0)
                {
                    SetDefaultEngslishSettings();
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
        #endregion  // UpdateForSystemUnitsChange()

        #region UpdateForMagnitudeChange()
        /// <summary>
        /// Handle Magnitude Change
        /// </summary>
        private void UpdateForMagnitudeChange()
        {
            string strMethod = "UpdateForMagnitudeChange";
            try
            {
                //---------------------------
                //---  SELECTED MAGNITUDE ---
                //---------------------------
                string strSelectedItem = comboBoxUnitsMagnitude.SelectedItem.ToString();

                #region BASE
                if (string.Compare(strSelectedItem, HenProjectUnits.MAG_BASE, true) == 0)
                {
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.BASE;
                }
                #endregion  // BASE

                #region KILO
                else if (string.Compare(strSelectedItem, HenProjectUnits.MAG_KILO, true) == 0)
                {
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.KILO;
                }
                #endregion  // KILO

                #region MEGA
                else if (string.Compare(strSelectedItem, HenProjectUnits.MAG_MEGA, true) == 0)
                {
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;
                }
                #endregion  // MEGA

                //-----------------------------------
                //--- Populate the Units Controls ---
                //-----------------------------------
                LoadPressure();
                PopulateUnitsControls();
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
        /// <summary>
        /// Handle Temperature Change
        /// </summary>
        private void UpdateForTemperatureChange()
        {
            string strMethod = "UpdateForTemperatureChange";
            try
            {
                //-----------------------------
                //---  SELECTED TEMPERATURE ---
                //-----------------------------
                string strSelectedItem = comboBoxUnitsTemp.SelectedItem.ToString();

                #region DEG F
                if (string.Compare(strSelectedItem, HenProjectUnits.DEG_F, true) == 0)
                {
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_F;
                }
                #endregion  // DEG F

                #region DEG R
                else if (string.Compare(strSelectedItem, HenProjectUnits.DEG_R, true) == 0)
                {
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_R;
                }
                #endregion  // DEG R

                #region DEG C
                else if (string.Compare(strSelectedItem, HenProjectUnits.DEG_C, true) == 0)
                {
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectMetricTempEnum = ProjectMetricTemp.DEG_C;
                }
                #endregion  // DEG C

                #region KELVIN
                else if (string.Compare(strSelectedItem, HenProjectUnits.KELVIN, true) == 0)
                {
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectMetricTempEnum = ProjectMetricTemp.KELVIN;
                }
                #endregion  // KELVIN

                //-----------------------------------
                //--- Populate the Units Controls ---
                //-----------------------------------
                PopulateUnitsControls();
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
                //---------------------------------
                //--- NO UPDATES TO UI NEEDED!! ---
                //---------------------------------
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

                #region TEXTBOX STRINGS
                NewProjectSettingsObj.NewProjectName = this.textBoxProjectNameValue.Text;
                NewProjectSettingsObj.NewProjectDescription = this.textBoxProjectDescriptionValue.Text;
                #endregion  // TEXTBOX STRINGS

                #region DEFAULT EXCHANGER PARAMETERS
                NewProjectSettingsObj.ProjectExchangerU = Convert.ToDouble(textBoxDefaultU_Value.Text);
                #endregion  // DEFAULT EXCHANGER PARAMETERS

                #region DEFAULT HEN OPTIMIZER
                if (string.Compare(comboBoxDefaultHenOpitimizer.Text, DefaultProjectSettings.GENETIC) == 0)
                {
                    NewProjectSettingsObj.HenOptimizerEnum = DefaultProjectSettings.HenOptimizer.GENETIC;
                }
                else if (string.Compare(comboBoxDefaultHenOpitimizer.Text, DefaultProjectSettings.GENETIC) == 0)
                {
                    NewProjectSettingsObj.HenOptimizerEnum = DefaultProjectSettings.HenOptimizer.GREEDY;
                }
                else if (string.Compare(comboBoxDefaultHenOpitimizer.Text, DefaultProjectSettings.MILP) == 0)
                {
                    NewProjectSettingsObj.HenOptimizerEnum = DefaultProjectSettings.HenOptimizer.MILP;
                }
                #endregion  // DEFAULT HEN OPTIMIZER

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
                //HenMsgDlg.DisplayWarningDlg("Handle Cancel Button Click!");
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
