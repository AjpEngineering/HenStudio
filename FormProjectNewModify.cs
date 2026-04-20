#region HEADER
//#####################################################################################################################
//#################################  F o r m P r o j e c t N e w M o d i f y . c s  ###################################
//#####################################################################################################################
//  FILENAME:  FormProjectNewModify.cs
//  NAMESPACE: HenStudio
//  CLASS(S):  FormProjectNewModify
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the New and Modify Project Data Form (FormProjectNewModify).
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

using HenRepositories.Dto;

using HenStudio.Properties;

using HenViewModels;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

using static HenGlobal.HenProjectUnits;
using static HenGlobal.HenTypes;

#endregion  // REFERENCES

#region namespace HenStudio
namespace HenStudio
{
    #region partial class FormProjectNewModify
    /// <summary>
    ///  New and Modify Project Data Form Class (FormProjectNewModify)
    /// </summary>

    public partial class FormProjectNewModify : Form
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio";
        const string CLASS = "FormSettings";

        //------------------------------------------------------------------------------------
        //--- Default Correction Factor (F) for Exchanger Design Calculations (Base Value) ---
        //------------------------------------------------------------------------------------
        const double DEFAULT_F_CORRECTION_FACTOR = 0.85;

        //----------------------------------------------------------
        //--- Default U Values for Exchanger Design Calculations ---
        //----------------------------------------------------------
        const double DEFAULT_U_ENGLISH_BASE = 35.22;        //   Btu/(hr·ft²·°F) and   Btu/(hr·ft²·°R)
        const double DEFAULT_U_ENGLISH_KILO = 0.03522;      //  kBtu/(hr·ft²·°F) and  kBtu/(hr·ft²·°R)
        const double DEFAULT_U_ENGLISH_MEGA = 0.00003522;   // MMBtu/(hr·ft²·°F) and MMBtu/(hr·ft²·°R)

        const double DEFAULT_U_METRIC_BASE = 200.0;         //  W/(m²·°C)  and  W/(m²·K)
        const double DEFAULT_U_METRIC_KILO = 0.20;          // kW/(m²·°C)  and kW/(m²·K)
        const double DEFAULT_U_METRIC_MEGA = 0.00020;       // MW/(m²·°C)  and MW/(m²·K)
        #endregion      // CONSTANTS

        #region PROPERTIES
        public string OrigProjectName { get; set; } // Original Project Name
        public bool NewProjectFlag { get; set; } // NEW PROJECT Flag (true = New Project, false = Modify Project)
        public DefaultProjectSettings NewProjectSettingsObj { get; set; } // NEW PROJECT Settings Object
        public ProjectViewData ProjectViewDataObj { get; set; } // Project (Panel) View Data Object
        #endregion  // PROPERTIES

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        //----------------------------------------------------------- CTORs ---
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        #region CTOR ... NEW
        /// <summary>
        /// NEW Parameterized Constructor
        /// </summary>
        public FormProjectNewModify(AppGlobalSettingsDto appGlobalSettingsObj)
        {
            OrigProjectName = string.Empty;
            NewProjectFlag = true; // NEW Project

            //------------------------------------------------
            //--- Initialize New Project Settings Property ---
            //------------------------------------------------
            NewProjectSettingsObj = new DefaultProjectSettings();
            ProjectViewDataObj = new ProjectViewData();

            InitializeComponent();

            //-----------------------------------
            //--- Set Initial Form Title Text ---
            //-----------------------------------
            this.Text = string.Format("NEW Project Data : Project_Name");

            //----------------------------------
            //--- Initialize Textbox Strings ---
            //----------------------------------
            this.textBoxProjectNameValue.Text = "Project_Name";
            this.textBoxProjectDescriptionValue.Text = "Enter Project Description";

            this.textBoxDefaultF_Value.Text = DEFAULT_F_CORRECTION_FACTOR.ToString();

            if (string.Compare(appGlobalSettingsObj.ExternalSystemUnits, "English - Imperial", true)==0)
            {
                //-----------------------
                //--- Set Enum Values ---
                //-----------------------
                NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;
                NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;
                NewProjectSettingsObj.ExternalUnitsObj.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_F;
                NewProjectSettingsObj.ExternalUnitsObj.ProjectEnglishPressEnum = ProjectEnglishPress.PSIA;

                this.textBoxDefaultU_Value.Text = DEFAULT_U_ENGLISH_MEGA.ToString();

                //--------------------------------------------
                //--- Initialize with ENGLISH System Units ---
                //--------------------------------------------
                SetDefaultEngslishSettings();
            }
            else if (string.Compare(appGlobalSettingsObj.ExternalSystemUnits, "Metric - SI", true) == 0)
            {
                //-----------------------
                //--- Set Enum Values ---
                //-----------------------
                NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;
                NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.KILO;
                NewProjectSettingsObj.ExternalUnitsObj.ProjectMetricTempEnum = ProjectMetricTemp.KELVIN;
                NewProjectSettingsObj.ExternalUnitsObj.ProjectMetricPressEnum = ProjectMetricPress.Pa;

                this.textBoxDefaultU_Value.Text = DEFAULT_U_METRIC_KILO.ToString();

                //------------------------------------------
                //---Initialize with METRIC System Units ---
                //------------------------------------------
                SetDefaultMetricSettings();
            }

            //--------------------------
            //--- Load HEN Optimizer ---
            //--------------------------
            LoadHenOptimizer();
        }
        #endregion  // CTOR ... NEW

        #region CTOR ... MODIFY
        /// <summary>
        /// MODIFY Parameterized Constructor
        /// </summary>
        public FormProjectNewModify(ProjectViewData projectViewDataObj)
        {
            OrigProjectName = projectViewDataObj.Name;

            NewProjectFlag = false; // MODIFY Project

            //------------------------------------------------
            //--- Initialize New Project Settings Property ---
            //------------------------------------------------
            NewProjectSettingsObj = new DefaultProjectSettings();
            ProjectViewDataObj = projectViewDataObj;

            InitializeComponent();

            //-----------------------------------
            //--- Set Initial Form Title Text ---
            //-----------------------------------
            this.Text = string.Format("MODIFY Project Data : {0}", projectViewDataObj.Name);

            //----------------------------------
            //--- Initialize Textbox Strings ---
            //----------------------------------
            this.textBoxProjectNameValue.Text = projectViewDataObj.Name;
            this.textBoxProjectDescriptionValue.Text = projectViewDataObj.Description;

            #region ENGLISH

            if (string.Compare(projectViewDataObj.ProjectSystem_Units, "English - Imperial", true) == 0)
            {
                NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;

                #region MAGNITUDE
                if (string.Compare(projectViewDataObj.ProjectMagnitude_Units, "Base", true) == 0)
                {
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.BASE;
                    this.textBoxDefaultU_Value.Text = DEFAULT_U_ENGLISH_BASE.ToString();
                }
                else if (string.Compare(projectViewDataObj.ProjectMagnitude_Units, "Kilo", true) == 0)
                {
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.KILO;
                    this.textBoxDefaultU_Value.Text = DEFAULT_U_ENGLISH_KILO.ToString();
                }
                else if (string.Compare(projectViewDataObj.ProjectMagnitude_Units, "Mega", true) == 0)
                {
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;
                    this.textBoxDefaultU_Value.Text = DEFAULT_U_ENGLISH_MEGA.ToString();
                }
                #endregion  // MAGNITUDE

                //--------------------------------------------
                //--- Initialize with ENGLISH System Units ---
                //--------------------------------------------
                SetDefaultEngslishSettings();
            }
            #endregion  // ENGLISH
            
            #region METRIC
            else if (string.Compare(projectViewDataObj.ProjectSystem_Units, "Metric - SI", true) == 0)
            {
                NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;

                #region MAGNITUDE

                if (string.Compare(projectViewDataObj.ProjectMagnitude_Units, "Base", true) == 0)
                {
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.BASE;
                    this.textBoxDefaultU_Value.Text = DEFAULT_U_METRIC_BASE.ToString();
                }
                else if (string.Compare(projectViewDataObj.ProjectMagnitude_Units, "Kilo", true) == 0)
                {
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.KILO;
                    this.textBoxDefaultU_Value.Text = DEFAULT_U_METRIC_KILO.ToString();
                }
                else if (string.Compare(projectViewDataObj.ProjectMagnitude_Units, "Mega", true) == 0)
                {
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;
                    this.textBoxDefaultU_Value.Text = DEFAULT_U_METRIC_MEGA.ToString();
                }
                #endregion  // MAGNITUDE

                //------------------------------------------
                //---Initialize with METRIC System Units ---
                //------------------------------------------
                SetDefaultMetricSettings();
            }
            #endregion  //// METRIC

            //--------------------------
            //--- Load HEN Optimizer ---
            //--------------------------
            LoadHenOptimizer();
        }
        #endregion  // CTOR ... MODIFY

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

        #region UpdateTitleText()
        /// <summary>
        /// Updates the window title to reflect the current project state and name.
        /// </summary>
        /// <remarks>Sets the title to indicate whether a new project is being created or an existing
        /// project is being modified, based on the current context.</remarks>
        private void UpdateTitleText()
        {
            string strMethod = "UpdateTitleText";
            try
            {
                string strTrimedProjectName = this.textBoxProjectNameValue.Text.Trim();
                if (NewProjectFlag)
                {
                    if(strTrimedProjectName.Length == 0)    this.Text = "NEW Project Data";
                    else this.Text = string.Format("NEW Project Data : {0}", 
                                                   this.textBoxProjectNameValue.Text);
                }
                else
                {
                    if (strTrimedProjectName.Length == 0)    this.Text = "MODIFY Project Data";
                    else this.Text = string.Format("MODIFY Project Data : {0}", 
                                                   this.textBoxProjectNameValue.Text);
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
        #endregion  // UpdateTitleText()

        #region IsFormDataValid()
        /// <summary>
        /// Determines whether the current form data is valid based on the project name and exchanger U value fields.
        /// </summary>
        /// <remarks>This method updates the visual state of the form controls to indicate validation
        /// results. The OK button is enabled only when all required fields are valid.</remarks>
        /// <returns>true if both the project name is not empty and the exchanger U value is a valid, positive number; otherwise,
        /// false.</returns>
        private bool IsFormDataValid()
        {
            string strMethod = "IsFormDataValid";
            bool bValidProjectName = false;
            bool bValidU = false;
            bool bValidF = false;
            bool bValidOverall = false;
            try
            {
                #region PROJECT NAME
                //------------------------------------------------------------------------------------------------------
                //--- DON'T TRIM ... Allow Leading and Trailing Spaces in Project Name ... Just Check for Length > 0 ---
                //------------------------------------------------------------------------------------------------------
                //this.textBoxProjectNameValue.Text = this.textBoxProjectNameValue.Text.Trim();

                //------------------------------------------
                //--- Project Name Test for Empty String ---
                //------------------------------------------
                string strValueProjectName = this.textBoxProjectNameValue.Text;
                if (strValueProjectName.Length > 0)
                {
                    textBoxProjectNameValue.BackColor = Color.White;
                    textBoxProjectNameValue.ForeColor = Color.Black;
                    bValidProjectName = true;
                }
                else
                {
                    textBoxProjectNameValue.BackColor = Color.Orange;
                    textBoxProjectNameValue.ForeColor = Color.Black;
                    bValidProjectName = false;
                }
                #endregion  // PROJECT NAME

                #region EXCHANGER U
                //-----------------------------------------------------
                //--- Exchanger U Value Test for Valid Double Value ---
                //-----------------------------------------------------
                string strValueU = this.textBoxDefaultU_Value.Text;
                double dValueU = 0.00;

                //--- Check for Valid Double Value ---
                if (Double.TryParse(strValueU, out dValueU))
                {
                    //--- VALID Double: Check for Positive Value ---
                    if (dValueU > 0.0)
                    {
                        //--- Positive Double Value ---
                        textBoxDefaultU_Value.BackColor = Color.White;
                        textBoxDefaultU_Value.ForeColor = Color.Black;
                        bValidU = true;
                    }
                    else
                    {
                        //--- Negative Double Value ---
                        textBoxDefaultU_Value.BackColor = Color.Orange;
                        textBoxDefaultU_Value.ForeColor = Color.Black;
                        bValidU = false;
                    }
                }
                else
                {
                    //--- INVALID Double Value ---
                    textBoxDefaultU_Value.BackColor = Color.Orange;
                    textBoxDefaultU_Value.ForeColor = Color.Black;
                    bValidU = false;
                }
                #endregion  // EXCHANGER U

                #region EXCHANGER F
                //-----------------------------------------------------
                //--- Exchanger U Value Test for Valid Double Value ---
                //-----------------------------------------------------
                string strValueF = this.textBoxDefaultF_Value.Text;
                double dValueF = 0.85;

                //--- Check for Valid Double Value ---
                if (Double.TryParse(strValueF, out dValueF))
                {
                    //--- VALID Double: Check for Positive Value ---
                    if (dValueF > 0.0)
                    {
                        //--- Positive Double Value ---
                        textBoxDefaultF_Value.BackColor = Color.White;
                        textBoxDefaultF_Value.ForeColor = Color.Black;
                        bValidF = true;
                    }
                    else
                    {
                        //--- Negative Double Value ---
                        textBoxDefaultF_Value.BackColor = Color.Orange;
                        textBoxDefaultF_Value.ForeColor = Color.Black;
                        bValidF = false;
                    }
                }
                else
                {
                    //--- INVALID Double Value ---
                    textBoxDefaultU_Value.BackColor = Color.Orange;
                    textBoxDefaultU_Value.ForeColor = Color.Black;
                    bValidU = false;
                }
                #endregion  // EXCHANGER F

                #region OVERALL FORM VALIDITY
                //-----------------------------------------
                //--- Overall Valid Input Data for Form ---
                //-----------------------------------------
                bValidOverall = (bValidProjectName && bValidU && bValidF);
                if(bValidOverall)
                {
                    buttonOK.BackColor = Color.White;
                    buttonOK.ForeColor = Color.Black;
                    buttonOK.Enabled = true;
                }
                else
                {
                    buttonOK.BackColor = Color.Orange;
                    buttonOK.ForeColor = Color.Black;
                    buttonOK.Enabled = false;
                }
                #endregion  // OVERALL FORM VALIDITY

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
            return bValidOverall;
        }
        #endregion  // IsFormDataValid()

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

        #region U TEXTBOX TEXT CHANGED ... Ensure Text is Valid Double Numeric Value
        private void textBoxDefaultU_Value_TextChanged(object sender, EventArgs e)
        {
            IsFormDataValid();
        }
        #endregion  // U TEXTBOX TEXT CHANGED ... Ensure Text is Valid Double Numeric Value

        #region F TEXTBOX TEXT CHANGED ... Ensure Text is Valid Double Numeric Value
        private void textBoxFValue_TextChanged(object sender, EventArgs e)
        {
            IsFormDataValid();
        }
        #endregion  // F TEXTBOX TEXT CHANGED ... Ensure Text is Valid Double Numeric Value

        #region PROJECT NAME TEXTBOX TEXT CHANGED ... Ensure Text is not Blank
        private void textBoxProjectNameValue_TextChanged(object sender, EventArgs e)
        {
            UpdateTitleText();
            IsFormDataValid();
        }
        #endregion      //PROJECT NAME TEXTBOX TEXT CHANGED ... Ensure Text is not Blank

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
                    //-----------------------
                    //--- Set Enum Values ---
                    //-----------------------
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.KILO;
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectMetricTempEnum = ProjectMetricTemp.KELVIN;
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectMetricPressEnum = ProjectMetricPress.Pa;

                    this.textBoxDefaultU_Value.Text = DEFAULT_U_METRIC_KILO.ToString();

                    SetDefaultMetricSettings();
                }
                #endregion  // METRIC

                #region ENGLISH
                else if (string.Compare(strSelectedItem, HenProjectUnits.ENGLISH_UNITS, true) == 0)
                {
                    //-----------------------
                    //--- Set Enum Values ---
                    //-----------------------
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_F;
                    NewProjectSettingsObj.ExternalUnitsObj.ProjectEnglishPressEnum = ProjectEnglishPress.PSIA;
                    
                    this.textBoxDefaultU_Value.Text = DEFAULT_U_ENGLISH_MEGA.ToString();

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

                //-------------------------------------------------------------------------------------
                //--- Populate the Default U Value based on the Selected System Units and Magnitude ---
                //-------------------------------------------------------------------------------------
                switch (NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum)
                {
                    case ProjectSystemUnits.ENGLISH:
                        switch (NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum)
                        {
                            case ProjectMagnitude.BASE:
                                this.textBoxDefaultU_Value.Text = DEFAULT_U_ENGLISH_BASE.ToString();
                                break;
                            case ProjectMagnitude.KILO:
                                this.textBoxDefaultU_Value.Text = DEFAULT_U_ENGLISH_KILO.ToString();
                                break;
                            case ProjectMagnitude.MEGA:
                                this.textBoxDefaultU_Value.Text = DEFAULT_U_ENGLISH_MEGA.ToString();
                                break;
                        }
                        break;
                    case ProjectSystemUnits.METRIC:
                        switch (NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum)
                        {
                            case ProjectMagnitude.BASE:
                                this.textBoxDefaultU_Value.Text = DEFAULT_U_METRIC_BASE.ToString();
                                break;
                            case ProjectMagnitude.KILO:
                                this.textBoxDefaultU_Value.Text = DEFAULT_U_METRIC_KILO.ToString();
                                break;
                            case ProjectMagnitude.MEGA:
                                this.textBoxDefaultU_Value.Text = DEFAULT_U_METRIC_MEGA.ToString();
                                break;
                        }
                        break;
                }

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
        /// <summary>
        /// Handles the Click event of the OK button, updating the project data object with values from the form
        /// controls.
        /// </summary>
        /// <remarks>This method collects user input from the form fields and assigns the values to the
        /// corresponding properties of the project data object. It is typically used to save or apply user changes when
        /// the OK button is clicked.</remarks>
        /// <param name="sender">The source of the event, typically the OK button.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            string strMethod = "buttonOK_Click";
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "OK Button Click");
            try
            {
                //---------------------------------------------------------------------
                //--- Scrape Screen and Assign Control Values to New Default Values ---
                //---------------------------------------------------------------------

                #region TEXTBOX STRINGS
                ProjectViewDataObj.Name = this.textBoxProjectNameValue.Text;
                ProjectViewDataObj.Description = this.textBoxProjectDescriptionValue.Text;
                #endregion  // TEXTBOX STRINGS

                #region DEFAULT EXCHANGER PARAMETERS
                ProjectViewDataObj.ProjectU_Value = textBoxDefaultU_Value.Text;
                ProjectViewDataObj.ProjectF_Value = textBoxDefaultF_Value.Text;
                #endregion  // DEFAULT EXCHANGER PARAMETERS

                #region DEFAULT HEN OPTIMIZER
                ProjectViewDataObj.ProjectHenOptimizer = comboBoxDefaultHenOpitimizer.Text;
                #endregion  // DEFAULT HEN OPTIMIZER

                #region DEFAULT PROJECT UNITS
                ProjectViewDataObj.ProjectSystem_Units = comboBoxUnitsSystem.Text;
                ProjectViewDataObj.ProjectMagnitude_Units = comboBoxUnitsMagnitude.Text;

                ProjectViewDataObj.ProjectTemperature_Units = comboBoxUnitsTemp.Text;
                ProjectViewDataObj.ProjectPressure_Units = comboBoxUnitsPress.Text;
                #endregion  // DEFAULT PROJECT UNITS

                #region DERIVED UNITS
                ProjectViewDataObj.ProjectArea_Units = textBoxUnitsAreaValue.Text;
                ProjectViewDataObj.ProjectDuty_Units = textBoxUnitsDutyValue.Text;
                ProjectViewDataObj.ProjectCP_Units = textBoxUnitsCPValue.Text;
                ProjectViewDataObj.ProjectU_Units = textBoxUnitsUValue.Text;
                #endregion  // DERIVED UNITS

                //----------------------------------------------------------------------
                //--- Check if New Project Creation or Existing Project Modification ---
                //--- (Based on Original Project Name vs Current Project Name)       ---
                //----------------------------------------------------------------------
                if ((NewProjectFlag) ||
                    ((!NewProjectFlag)&&(ProjectViewDataObj.Name != OrigProjectName)))
                {
                    string strProjectName = this.textBoxProjectNameValue.Text.Trim();
                    //---------------------------------------------------------------------------------------------
                    //--- Check if Existing Project Data is Present for Project (Should Not Be for New Project) ---
                    //---------------------------------------------------------------------------------------------
                    ProjectViewModel projectViewModelObj = new ProjectViewModel();
                    ProjectDto projectDtoObj = projectViewModelObj.GetProjectByName(strProjectName);
                    if(projectDtoObj != null)
                    {
                        HenLogger.WriteSeparatorLine('*');
                        HenLogger.LogWarning(NAMESPACE, CLASS, strMethod, String.Format("WARNING: Existing Project Data Found for Project Name: {0}", strProjectName));
                        HenLogger.LogWarning(NAMESPACE, CLASS, strMethod, "WARNING: This Should Not Occur for New Project Creation");
                        HenLogger.LogWarning(NAMESPACE, CLASS, strMethod, "WARNING: Check Logic for New vs Modify Project in FormProjectNewModify");
                        HenLogger.WriteSeparatorLine('*');

                        HenMsgDlg.DisplayErrorDlg(String.Format("ERROR: Existing Project Data Found for Project Name: {0}", strProjectName));
                        
                        //-------------------------------------------------------------------------------------------
                        //--- Exit without Saving Data since Existing Project Data Found for New Project Creation ---
                        //-------------------------------------------------------------------------------------------
                        DialogResult = DialogResult.Retry;
                        return;
                    }

                    //--------------------------------------
                    //--- NEW PROJECT: Set Creation Date ---
                    //--------------------------------------
                    ProjectViewDataObj.ProjectCreationDate = DateTime.Now;
                    ProjectViewDataObj.ProjectModificationDate = DateTime.Now;
                }
                else
                {
                    //---------------------------------------------
                    //--- MODIFY PROJECT: Set Modification Date ---
                    //---------------------------------------------
                    ProjectViewDataObj.ProjectModificationDate = DateTime.Now;
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
        #endregion  // OK BUTTON HANDLER

        #region CANCEL BUTTON HANDLER
        /// <summary>
        /// Handles the Click event of the Cancel button by closing the form and returning to the previous screen.
        /// </summary>
        /// <param name="sender">The source of the event, typically the Cancel button.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            string strMethod = "buttonCancel_Click";
            //HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Cancel Button Click");
            try
            {
                //-------------------------------------------------------------------------------
                //--- No Action Needeed ... Just Close the Form and Return to Previous Screen ---
                //-------------------------------------------------------------------------------
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
    #endregion// partial class FormProjectNewModify

}
#endregion      // namespace HenStudio

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
