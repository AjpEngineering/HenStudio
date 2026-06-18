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

#region AJP HEN NAMESPACES
using HenGlobal;

using HenModel.Dto.Application;
using HenModel.Dto.Project;
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

using HenViewModel.Application;
using HenViewModel.Project;
using HenViewModel.Project.DefaultParameters.ExchangerParams;
using HenViewModel.Project.DefaultParameters.OptimizerParams;
using HenViewModel.Project.DefaultParameters.ProjectUnits;

using HenStudio.Properties;
using HenStudio.Data.Project;
using HenStudio.Data.Tag;

#endregion  // AJP HEN NAMESPACES

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
        public ProjectPanelData ProjectPanelDataObj { get; set; } // Project Panel Data Object
        #endregion  // PROPERTIES

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        //----------------------------------------------------------- CTORs ---
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        #region CTOR ... NEW
        /// <summary>
        /// NEW Parameterized Constructor
        /// </summary>
        public FormProjectNewModify( ) //AppGlobalSettingsDto appGlobalSettingsObj)
        {
            //OrigProjectName = string.Empty;
            //NewProjectFlag = true; // NEW Project

            ////------------------------------------------------
            ////--- Initialize New Project Settings Property ---
            ////------------------------------------------------
            //NewProjectSettingsObj = new DefaultProjectSettings();
            //ProjectPanelDataObj = new ProjectPanelData();

            //InitializeComponent();

            ////-----------------------------------
            ////--- Set Initial Form Title Text ---
            ////-----------------------------------
            //this.Text = string.Format("NEW Project Data : Project_Name");

            ////----------------------------------
            ////--- Initialize Textbox Strings ---
            ////----------------------------------
            //this.textBoxProjectNameValue.Text = "Project_Name";
            //this.textBoxProjectDescriptionValue.Text = "Enter Project Description";

            //this.textBoxDefaultF_Value.Text = DEFAULT_F_CORRECTION_FACTOR.ToString();

            //if (string.Compare(appGlobalSettingsObj.ExternalSystemUnits, "English - Imperial", true)==0)
            //{
            //    //-----------------------
            //    //--- Set Enum Values ---
            //    //-----------------------
            //    NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;
            //    NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;
            //    NewProjectSettingsObj.ExternalUnitsObj.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_F;
            //    NewProjectSettingsObj.ExternalUnitsObj.ProjectEnglishPressEnum = ProjectEnglishPress.PSIA;

            //    this.textBoxDefaultU_Value.Text = DEFAULT_U_ENGLISH_MEGA.ToString();

            //    //--------------------------------------------
            //    //--- Initialize with ENGLISH System Units ---
            //    //--------------------------------------------
            //    SetDefaultEngslishSettings();
            //}
            //else if (string.Compare(appGlobalSettingsObj.ExternalSystemUnits, "Metric - SI", true) == 0)
            //{
            //    //-----------------------
            //    //--- Set Enum Values ---
            //    //-----------------------
            //    NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum = ProjectSystemUnits.METRIC;
            //    NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.KILO;
            //    NewProjectSettingsObj.ExternalUnitsObj.ProjectMetricTempEnum = ProjectMetricTemp.KELVIN;
            //    NewProjectSettingsObj.ExternalUnitsObj.ProjectMetricPressEnum = ProjectMetricPress.Pa;

            //    this.textBoxDefaultU_Value.Text = DEFAULT_U_METRIC_KILO.ToString();

            //    //------------------------------------------
            //    //---Initialize with METRIC System Units ---
            //    //------------------------------------------
            //    SetDefaultMetricSettings();
            //}

            ////--------------------------
            ////--- Load HEN Optimizer ---
            ////--------------------------
            //LoadHenOptimizer();
        }
        #endregion  // CTOR ... NEW

        #region CTOR ... MODIFY
        /// <summary>
        /// MODIFY Parameterized Constructor
        /// </summary>
        public FormProjectNewModify(ProjectPanelData projectPanelDataObj)
        {
            //OrigProjectName = projectPanelDataObj.Name;

            //NewProjectFlag = false; // MODIFY Project

            ////------------------------------------------------
            ////--- Initialize New Project Settings Property ---
            ////------------------------------------------------
            //NewProjectSettingsObj = new DefaultProjectSettings();
            //ProjectPanelDataObj = projectPanelDataObj;

            //InitializeComponent();

            ////-----------------------------------
            ////--- Set Initial Form Title Text ---
            ////-----------------------------------
            //this.Text = string.Format("MODIFY Project Data : {0}", projectPanelDataObj.Name);

            ////----------------------------------
            ////--- Initialize Textbox Strings ---
            ////----------------------------------
            //this.textBoxProjectNameValue.Text = projectPanelDataObj.Name;
            //this.textBoxProjectDescriptionValue.Text = projectPanelDataObj.Description;

            //#region ENGLISH

            ////if (string.Compare(projectPanelDataObj.ProjectDtoObj., "English - Imperial", true) == 0)
            ////{
            ////    NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;

            ////    #region MAGNITUDE
            ////    if (string.Compare(projectViewDataObj.ProjectMagnitude_Units, "Base", true) == 0)
            ////    {
            ////        NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.BASE;
            ////        this.textBoxDefaultU_Value.Text = DEFAULT_U_ENGLISH_BASE.ToString();
            ////    }
            ////    else if (string.Compare(projectViewDataObj.ProjectMagnitude_Units, "Kilo", true) == 0)
            ////    {
            ////        NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.KILO;
            ////        this.textBoxDefaultU_Value.Text = DEFAULT_U_ENGLISH_KILO.ToString();
            ////    }
            ////    else if (string.Compare(projectViewDataObj.ProjectMagnitude_Units, "Mega", true) == 0)
            ////    {
            ////        NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;
            ////        this.textBoxDefaultU_Value.Text = DEFAULT_U_ENGLISH_MEGA.ToString();
            ////    }
            ////    #endregion  // MAGNITUDE

            ////    //--------------------------------------------
            ////    //--- Initialize with ENGLISH System Units ---
            ////    //--------------------------------------------
            ////    SetDefaultEngslishSettings();
            ////}
            //#endregion  // ENGLISH
            
            //#region METRIC
            //else if (string.Compare(projectViewDataObj.ProjectSystem_Units, "Metric - SI", true) == 0)
            //{
            //    NewProjectSettingsObj.ExternalUnitsObj.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;

            //    #region MAGNITUDE

            //    if (string.Compare(projectViewDataObj.ProjectMagnitude_Units, "Base", true) == 0)
            //    {
            //        NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.BASE;
            //        this.textBoxDefaultU_Value.Text = DEFAULT_U_METRIC_BASE.ToString();
            //    }
            //    else if (string.Compare(projectViewDataObj.ProjectMagnitude_Units, "Kilo", true) == 0)
            //    {
            //        NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.KILO;
            //        this.textBoxDefaultU_Value.Text = DEFAULT_U_METRIC_KILO.ToString();
            //    }
            //    else if (string.Compare(projectViewDataObj.ProjectMagnitude_Units, "Mega", true) == 0)
            //    {
            //        NewProjectSettingsObj.ExternalUnitsObj.ProjectMagnitudeEnum = ProjectMagnitude.MEGA;
            //        this.textBoxDefaultU_Value.Text = DEFAULT_U_METRIC_MEGA.ToString();
            //    }
            //    #endregion  // MAGNITUDE

            //    //------------------------------------------
            //    //---Initialize with METRIC System Units ---
            //    //------------------------------------------
            //    SetDefaultMetricSettings();
            //}
            //#endregion  //// METRIC

            ////--------------------------
            ////--- Load HEN Optimizer ---
            ////--------------------------
            //LoadHenOptimizer();
        }
        #endregion  // CTOR ... MODIFY
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
            //string strMethod = "UpdateTitleText";
            //try
            //{
            //    string strTrimedProjectName = this.textBoxProjectNameValue.Text.Trim();
            //    if (NewProjectFlag)
            //    {
            //        if(strTrimedProjectName.Length == 0)    this.Text = "NEW Project Data";
            //        else this.Text = string.Format("NEW Project Data : {0}", 
            //                                       this.textBoxProjectNameValue.Text);
            //    }
            //    else
            //    {
            //        if (strTrimedProjectName.Length == 0)    this.Text = "MODIFY Project Data";
            //        else this.Text = string.Format("MODIFY Project Data : {0}", 
            //                                       this.textBoxProjectNameValue.Text);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    HenLogger.WriteSeparatorLine('*');
            //    HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
            //    HenLogger.WriteSeparatorLine('*');
            //}
            //finally
            //{
            //}
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
            //try
            //{
            //    #region PROJECT NAME
            //    //------------------------------------------------------------------------------------------------------
            //    //--- DON'T TRIM ... Allow Leading and Trailing Spaces in Project Name ... Just Check for Length > 0 ---
            //    //------------------------------------------------------------------------------------------------------
            //    //this.textBoxProjectNameValue.Text = this.textBoxProjectNameValue.Text.Trim();

            //    //------------------------------------------
            //    //--- Project Name Test for Empty String ---
            //    //------------------------------------------
            //    string strValueProjectName = this.textBoxProjectNameValue.Text;
            //    if (strValueProjectName.Length > 0)
            //    {
            //        textBoxProjectNameValue.BackColor = Color.White;
            //        textBoxProjectNameValue.ForeColor = Color.Black;
            //        bValidProjectName = true;
            //    }
            //    else
            //    {
            //        textBoxProjectNameValue.BackColor = Color.Orange;
            //        textBoxProjectNameValue.ForeColor = Color.Black;
            //        bValidProjectName = false;
            //    }
            //    #endregion  // PROJECT NAME

            //    #region EXCHANGER U
            //    //-----------------------------------------------------
            //    //--- Exchanger U Value Test for Valid Double Value ---
            //    //-----------------------------------------------------
            //    string strValueU = this.textBoxDefaultU_Value.Text;
            //    double dValueU = 0.00;

            //    //--- Check for Valid Double Value ---
            //    if (Double.TryParse(strValueU, out dValueU))
            //    {
            //        //--- VALID Double: Check for Positive Value ---
            //        if (dValueU > 0.0)
            //        {
            //            //--- Positive Double Value ---
            //            textBoxDefaultU_Value.BackColor = Color.White;
            //            textBoxDefaultU_Value.ForeColor = Color.Black;
            //            bValidU = true;
            //        }
            //        else
            //        {
            //            //--- Negative Double Value ---
            //            textBoxDefaultU_Value.BackColor = Color.Orange;
            //            textBoxDefaultU_Value.ForeColor = Color.Black;
            //            bValidU = false;
            //        }
            //    }
            //    else
            //    {
            //        //--- INVALID Double Value ---
            //        textBoxDefaultU_Value.BackColor = Color.Orange;
            //        textBoxDefaultU_Value.ForeColor = Color.Black;
            //        bValidU = false;
            //    }
            //    #endregion  // EXCHANGER U

            //    #region EXCHANGER F
            //    //-----------------------------------------------------
            //    //--- Exchanger U Value Test for Valid Double Value ---
            //    //-----------------------------------------------------
            //    string strValueF = this.textBoxDefaultF_Value.Text;
            //    double dValueF = 0.85;

            //    //--- Check for Valid Double Value ---
            //    if (Double.TryParse(strValueF, out dValueF))
            //    {
            //        //--- VALID Double: Check for Positive Value ---
            //        if (dValueF > 0.0)
            //        {
            //            //--- Positive Double Value ---
            //            textBoxDefaultF_Value.BackColor = Color.White;
            //            textBoxDefaultF_Value.ForeColor = Color.Black;
            //            bValidF = true;
            //        }
            //        else
            //        {
            //            //--- Negative Double Value ---
            //            textBoxDefaultF_Value.BackColor = Color.Orange;
            //            textBoxDefaultF_Value.ForeColor = Color.Black;
            //            bValidF = false;
            //        }
            //    }
            //    else
            //    {
            //        //--- INVALID Double Value ---
            //        textBoxDefaultU_Value.BackColor = Color.Orange;
            //        textBoxDefaultU_Value.ForeColor = Color.Black;
            //        bValidU = false;
            //    }
            //    #endregion  // EXCHANGER F

            //    #region OVERALL FORM VALIDITY
            //    //-----------------------------------------
            //    //--- Overall Valid Input Data for Form ---
            //    //-----------------------------------------
            //    bValidOverall = (bValidProjectName && bValidU && bValidF);
            //    if(bValidOverall)
            //    {
            //        buttonOK.BackColor = Color.White;
            //        buttonOK.ForeColor = Color.Black;
            //        buttonOK.Enabled = true;
            //    }
            //    else
            //    {
            //        buttonOK.BackColor = Color.Orange;
            //        buttonOK.ForeColor = Color.Black;
            //        buttonOK.Enabled = false;
            //    }
            //    #endregion  // OVERALL FORM VALIDITY

            //}
            //catch (Exception ex)
            //{
            //    HenLogger.WriteSeparatorLine('*');
            //    HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
            //    HenLogger.WriteSeparatorLine('*');
            //}
            //finally
            //{
            //}
            return bValidOverall;
        }
        #endregion  // IsFormDataValid()

        #region DEFAULT UNITS EVENT HANDLERS

        #region SYSTEM UNITS SELECTION CHANGED
        private void comboBoxUnitsSystem_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }
        #endregion  // SYSTEM UNITS SELECTION CHANGED

        #region MAGNITUDE SELECTION CHANGED
        private void comboBoxUnitsMagnitude_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        #endregion  // MAGNITUDE SELECTION CHANGED

        #region TEMPERATURE SELECTION CHANGED
        private void comboBoxUnitsTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        #endregion  // TEMPERATURE SELECTION CHANGED

        #region PRESSURE SELECTION CHANGED
        private void comboBoxUnitsPress_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        #endregion  // PRESSURE SELECTION CHANGED

        #endregion  // DEFAULT UNITS EVENT HANDLERS

        #region U TEXTBOX TEXT CHANGED ... Ensure Text is Valid Double Numeric Value
        private void textBoxDefaultU_Value_TextChanged(object sender, EventArgs e)
        {
        }
        #endregion  // U TEXTBOX TEXT CHANGED ... Ensure Text is Valid Double Numeric Value

        #region F TEXTBOX TEXT CHANGED ... Ensure Text is Valid Double Numeric Value
        private void textBoxFValue_TextChanged(object sender, EventArgs e)
        {
        }
        #endregion  // F TEXTBOX TEXT CHANGED ... Ensure Text is Valid Double Numeric Value

        #region PROJECT NAME TEXTBOX TEXT CHANGED ... Ensure Text is not Blank
        private void textBoxProjectNameValue_TextChanged(object sender, EventArgs e)
        {
        }
        #endregion      //PROJECT NAME TEXTBOX TEXT CHANGED ... Ensure Text is not Blank

        #region UpdateSystemUnitsImage()
        /// <summary>
        /// Update the Systems Unit Image based on the New Project settings
        /// </summary>
        private void UpdateSystemUnitsImage()
        {
        }
        #endregion  // UpdateSystemUnitsImage()

        #region LOAD COMBO BOX DROP DOWN LISTS

        #endregion  // LOAD COMBO BOX DROP DOWN LISTS

        #region COMBO BOX SELECTION CHANGE HANDLERS

        #region UpdateForSystemUnitsChange()
        /// <summary>
        /// Handle System Units Change
        /// </summary>
        private void UpdateForSystemUnitsChange()
        {
        }
        #endregion  // UpdateForSystemUnitsChange()

        #region UpdateForMagnitudeChange()
        /// <summary>
        /// Handle Magnitude Change
        /// </summary>
        private void UpdateForMagnitudeChange()
        {
        }
        #endregion  // UpdateForMagnitudeChange()

        #region UpdateForTemperatureChange()
        /// <summary>
        /// Handle Temperature Change
        /// </summary>
        private void UpdateForTemperatureChange()
        {
        }
        #endregion  // UpdateForTemperatureChange()

        #region UpdateForPressureChange()
        private void UpdateForPressureChange()
        {
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
                ////---------------------------------------------------------------------
                ////--- Scrape Screen and Assign Control Values to New Default Values ---
                ////---------------------------------------------------------------------

                //#region TEXTBOX STRINGS
                //ProjectPanelDataObj.Name = this.textBoxProjectNameValue.Text;
                //ProjectPanelDataObj.Description = this.textBoxProjectDescriptionValue.Text;
                //#endregion  // TEXTBOX STRINGS

                //#region DEFAULT EXCHANGER PARAMETERS
                //ProjectPanelDataObj.ProjectU_Value = textBoxDefaultU_Value.Text;
                //ProjectPanelDataObj.ProjectF_Value = textBoxDefaultF_Value.Text;
                //#endregion  // DEFAULT EXCHANGER PARAMETERS

                //#region DEFAULT HEN OPTIMIZER
                //ProjectPanelDataObj.ProjectHenOptimizer = comboBoxDefaultHenOpitimizer.Text;
                //#endregion  // DEFAULT HEN OPTIMIZER

                //#region DEFAULT PROJECT UNITS
                //ProjectPanelDataObj.ProjectSystem_Units = comboBoxUnitsSystem.Text;
                //ProjectPanelDataObj.ProjectMagnitude_Units = comboBoxUnitsMagnitude.Text;

                //ProjectPanelDataObj.ProjectTemperature_Units = comboBoxUnitsTemp.Text;
                //ProjectPanelDataObj.ProjectPressure_Units = comboBoxUnitsPress.Text;
                //#endregion  // DEFAULT PROJECT UNITS

                //#region DERIVED UNITS
                //ProjectPanelDataObj.ProjectArea_Units = textBoxUnitsAreaValue.Text;
                //ProjectPanelDataObj.ProjectDuty_Units = textBoxUnitsDutyValue.Text;
                //ProjectPanelDataObj.ProjectCP_Units = textBoxUnitsCPValue.Text;
                //ProjectPanelDataObj.ProjectU_Units = textBoxUnitsUValue.Text;
                //#endregion  // DERIVED UNITS

                ////----------------------------------------------------------------------
                ////--- Check if New Project Creation or Existing Project Modification ---
                ////--- (Based on Original Project Name vs Current Project Name)       ---
                ////----------------------------------------------------------------------
                //if ((NewProjectFlag) ||
                //    ((!NewProjectFlag)&&(ProjectPanelDataObj.Name != OrigProjectName)))
                //{
                //    string strProjectName = this.textBoxProjectNameValue.Text.Trim();
                //    //---------------------------------------------------------------------------------------------
                //    //--- Check if Existing Project Data is Present for Project (Should Not Be for New Project) ---
                //    //---------------------------------------------------------------------------------------------
                //    var projectViewModelObj = new ProjectViewModel();
                //    var projectUnitsViewModelObj = new ProjectUnitsViewModel();
                //    var exchangerParamsViewModelObj = new ExchangerParamsViewModel();


                //    //ProjectUnitsDto projectDtoObj = projectViewModelObj.GetProjectByName(strProjectName);
                //    //if(projectDtoObj != null)
                //    {
                //        //    HenLogger.WriteSeparatorLine('*');
                //        //    HenLogger.LogWarning(NAMESPACE, CLASS, strMethod, String.Format("WARNING: Existing Project Data Found for Project Name: {0}", strProjectName));
                //        //    HenLogger.LogWarning(NAMESPACE, CLASS, strMethod, "WARNING: This Should Not Occur for New Project Creation");
                //        //    HenLogger.LogWarning(NAMESPACE, CLASS, strMethod, "WARNING: Check Logic for New vs Modify Project in FormProjectNewModify");
                //        //    HenLogger.WriteSeparatorLine('*');

                //        //    HenMsgDlg.DisplayErrorDlg(String.Format("ERROR: Existing Project Data Found for Project Name: {0}", strProjectName));

                //        //-------------------------------------------------------------------------------------------
                //        //--- Exit without Saving Data since Existing Project Data Found for New Project Creation ---
                //        //-------------------------------------------------------------------------------------------
                //        DialogResult = DialogResult.Retry;
                //        return;
                //    }

                //    //--------------------------------------
                //    //--- NEW PROJECT: Set Creation Date ---
                //    //--------------------------------------
                //    //ProjectViewDataObj.ProjectCreationDate = DateTime.Now;
                //    //ProjectViewDataObj.ProjectModificationDate = DateTime.Now;
                //}
                //else
                //{
                //    //---------------------------------------------
                //    //--- MODIFY PROJECT: Set Modification Date ---
                //    //---------------------------------------------
                //    ProjectPanelDataObj.ProjectModificationDate = DateTime.Now;
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
