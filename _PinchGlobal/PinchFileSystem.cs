#region HEADER
//#####################################################################################################################
//######################################  P i n c h F i l e S y s t e m . c s  ########################################
//#####################################################################################################################
//  FILENAME:  PinchFileSystem.cs
//  NAMESPACE: PinchGlobal
//  CLASS(S):  PinchFileSystem
//  COMPONENT: _PinchGLobal.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for managing Pinch File and Folder locations.
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
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion  // REFERENCES

#region namespace PinchGlobal
namespace PinchGlobal
{
    #region public class PinchFileSystem
    /// <summary>
    /// AJP Pinch Application - File System Structure Class
    /// </summary>
    public class PinchFileSystem
    {
        #region CONSTANTS
        const string NAMESPACE = "PinchGlobal";
        const string CLASS = "PinchFileSystem";

        public const string DEFAULT_HEN_FOLDERNAME     = "HEN";
        public const string DEFAULT_INPUT_FOLDERNAME   = "INPUT";
        public const string DEFAULT_LICENSE_FOLDERNAME = "LICENSE";
        public const string DEFAULT_TARGETS_FOLDERNAME = "TARGETS";
        public const string DEFAULT_TOOLS_FOLDERNAME   = "TOOLS";
        public const string DEFAULT_WORD_PAD_FILENAME  = "WordPad.exe";    // aka write.exe

        public const string DEFAULT_HEN_DATA_FOLDERNAME     = "DATA";
        public const string DEFAULT_TARGETS_DATA_FOLDERNAME = "DATA";

        public const string DEFAULT_HEN_FIGURES_FOLDERNAME     = "FIGURES";
        public const string DEFAULT_TARGETS_FIGURES_FOLDERNAME = "FIGURES";

        public const string DEFAULT_HEN_REPORTS_FOLDERNAME     = "REPORTS";
        public const string DEFAULT_TARGETS_REPORTS_FOLDERNAME = "REPORTS";

        public const string DEFAULT_LICENSE_FILENAME = "License.xml";
        #endregion      // CONSTANTS

        #region FIELDS
        private string _strAppExecPath = String.Empty;          // Application Executable Full Path

        private string _strHenFolderPath = String.Empty;        // HEN Folder Full Path
        private string _strInputFolderPath = String.Empty;      // INPUT Folder Full Path
        private string _strLicenseFolderPath = String.Empty;    // LICENSE Folder Full Path
        private string _strTargetsFolderPath = String.Empty;    // TARGETS Folder Full Path
        private string _strToolsFolderPath = String.Empty;      // TOOLS Folder Full Path
        private string _strWordPadPath = String.Empty;          // WordPad EXE File Full Path

        private string _strHenDataFolderPath = String.Empty;        // HEN\DATA Folder Full Path
        private string _strTargetsDataFolderPath = String.Empty;    // TARGETS\DATA Folder Full Path

        private string _strHenFiguresFolderPath = String.Empty;     // HEN\FIGURES Folder Full Path
        private string _strTargetsFiguresFolderPath = String.Empty; // TARGETS\FIGURES Folder Full Path

        private string _strHenReportsFolderPath = String.Empty;     // HEN\REPORTS Folder Full Path
        private string _strTargetsReportsFolderPath = String.Empty; // TARGETS\REPORTS Folder Full Path

        private string _strLicenseFilePath = String.Empty;  // LICENSE File Full Path

        #endregion      // FIELDS

        #region PROPERTIES

        #region AppExecPath
        /// <summary>
        /// AppExecPath Property
        /// </summary>
        public string AppExecPath
        {
            get { return _strAppExecPath; }
            set { _strAppExecPath = value; }
        }
        #endregion      // AppExecPath

        #region HenFolderPath
        /// <summary>
        /// HenFolderPath Property ... HEN Folder Full Path
        /// Colocated with Application Launch (exe) Location
        /// </summary>
        public string HenFolderPath
        {
            get { return _strHenFolderPath; }
            set { _strHenFolderPath = value; }
        }
        #endregion      // HenFolderPath

        #region InputFolderPath
        /// <summary>
        /// InputFolderPath Property ... INPUT Folder Full Path
        /// Colocated with Application Launch (exe) Location
        /// </summary>
        public string InputFolderPath
        {
            get { return _strInputFolderPath; }
            set { _strInputFolderPath = value; }
        }
        #endregion      // InputFolderPath

        #region LicenseFolderPath
        /// <summary>
        /// LicenseFolderPath Property ... LICENSE Folder Full Path
        /// Colocated with Application Launch (exe) Location
        /// </summary>
        public string LicenseFolderPath
        {
            get { return _strLicenseFolderPath; }
            set { _strLicenseFolderPath = value; }
        }
        #endregion      // LicenseFolderPath

        #region TargetsFolderPath
        /// <summary>
        /// TargetsFolderPath Property ... TARGETS Folder Full Path
        /// Colocated with Application Launch (exe) Location
        /// </summary>
        public string TargetsFolderPath
        {
            get { return _strTargetsFolderPath; }
            set { _strTargetsFolderPath = value; }
        }
        #endregion      // TargetsFolderPath

        #region ToolsFolderPath
        /// <summary>
        /// ToolsFolderPath Property ... TOOLS Folder Full Path
        /// Colocated with Application Launch (exe) Location
        /// </summary>
        public string ToolsFolderPath
        {
            get { return _strToolsFolderPath; }
            set { _strToolsFolderPath = value; }
        }
        #endregion      // ToolsFolderPath

        #region WordPadPath
        /// <summary>
        /// WordPadPath Property ... WordPad EXE File Full Path
        /// Located in TOOLS Folder
        /// </summary>
        public string WordPadPath
        {
            get { return _strWordPadPath; }
            set { _strWordPadPath = value; }
        }
        #endregion      // WordPadPath

        #region HenDataFolderPath
        /// <summary>
        /// HenDataFolderPath Property ... HEN\DATA Folder Full Path
        /// </summary>
        public string HenDataFolderPath
        {
            get { return _strHenDataFolderPath; }
            set { _strHenDataFolderPath = value; }
        }
        #endregion      // HenDataFolderPath

        #region TargetsDataFolderPath
        /// <summary>
        /// TargetsDataFolderPath Property ... TARGETS\DATA Folder Full Path
        /// </summary>
        public string TargetsDataFolderPath
        {
            get { return _strTargetsDataFolderPath; }
            set { _strTargetsDataFolderPath = value; }
        }
        #endregion      // TargetsDataFolderPath

        #region HenFiguresFolderPath
        /// <summary>
        /// HenFiguresFolderPath Property ... HEN\FIGURES Folder Full Path
        /// </summary>
        public string HenFiguresFolderPath
        {
            get { return _strHenFiguresFolderPath; }
            set { _strHenFiguresFolderPath = value; }
        }
        #endregion      // HenFiguresFolderPath

        #region TargetsFiguresFolderPath
        /// <summary>
        /// TargetsFiguresFolderPath Property ... TARGETS\FIGURES Folder Full Path
        /// </summary>
        public string TargetsFiguresFolderPath
        {
            get { return _strTargetsFiguresFolderPath; }
            set { _strTargetsFiguresFolderPath = value; }
        }
        #endregion      // TargetsFiguresFolderPath

        #region HenReportsFolderPath
        /// <summary>
        /// HenReportsFolderPath Property ... HEN\REPORTS Folder Full Path
        /// </summary>
        public string HenReportsFolderPath
        {
            get { return _strHenReportsFolderPath; }
            set { _strHenReportsFolderPath = value; }
        }
        #endregion      // HenReportsFolderPath

        #region TargetsReportsFolderPath
        /// <summary>
        /// TargetsReportsFolderPath Property ... TARGETS\REPORTS Folder Full Path
        /// </summary>
        public string TargetsReportsFolderPath
        {
            get { return _strTargetsReportsFolderPath; }
            set { _strTargetsReportsFolderPath = value; }
        }
        #endregion      // TargetsReportsFolderPath

        #region LicenseFilePath
        /// <summary>
        /// LicenseFilePath Property ... LICENSE File Full Path
        /// Located in the LICENSE folder which is colocated with the exe
        /// </summary>
        public string LicenseFilePath
        {
            get { return _strLicenseFilePath; }
            set { _strLicenseFilePath = value; }
        }
        #endregion      // LicenseFilePath

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public PinchFileSystem()
        {
            string strMethod = "CTOR";
            string strMsg = string.Empty;
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating Object");
            try
            {
                //-----------------------------------------------------
                //--- Log Pinch File System Folder Structure HEADER ---
                //-----------------------------------------------------
                PinchLogger.WriteSection("PINCH FILE SYSTEM FOLDER STRUCTURE");
                //---------------------------
                //--- Populate Properties ---
                //---------------------------
                AppExecPath = Path.GetDirectoryName(Application.ExecutablePath);

                HenFolderPath     = String.Format("{0}\\{1}", AppExecPath, DEFAULT_HEN_FOLDERNAME);
                InputFolderPath   = String.Format("{0}\\{1}", AppExecPath, DEFAULT_INPUT_FOLDERNAME);
                LicenseFolderPath = String.Format("{0}\\{1}", AppExecPath, DEFAULT_LICENSE_FOLDERNAME);
                TargetsFolderPath = String.Format("{0}\\{1}", AppExecPath, DEFAULT_TARGETS_FOLDERNAME);
                ToolsFolderPath   = String.Format("{0}\\{1}", AppExecPath, DEFAULT_TOOLS_FOLDERNAME);
                WordPadPath       = String.Format("{0}\\{1}", ToolsFolderPath, DEFAULT_WORD_PAD_FILENAME);

                HenDataFolderPath    = String.Format("{0}\\{1}", AppExecPath, DEFAULT_HEN_DATA_FOLDERNAME);
                HenFiguresFolderPath = String.Format("{0}\\{1}", AppExecPath, DEFAULT_HEN_FIGURES_FOLDERNAME);
                HenReportsFolderPath = String.Format("{0}\\{1}", AppExecPath, DEFAULT_HEN_REPORTS_FOLDERNAME);
                
                TargetsDataFolderPath    = String.Format("{0}\\{1}", AppExecPath, DEFAULT_TARGETS_DATA_FOLDERNAME);
                TargetsFiguresFolderPath = String.Format("{0}\\{1}", AppExecPath, DEFAULT_TARGETS_FIGURES_FOLDERNAME);                
                TargetsReportsFolderPath = String.Format("{0}\\{1}", AppExecPath, DEFAULT_TARGETS_REPORTS_FOLDERNAME);

                LicenseFilePath = String.Format("{0}\\{1}", LicenseFolderPath, DEFAULT_LICENSE_FILENAME);
            }
            catch (Exception ex)
            {
                PinchLogger.WriteSeparatorLine('*');
                PinchLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                PinchLogger.WriteSeparatorLine('*');
            }
            finally
            {
                //-----------------------------------------------------
                //--- Log Pinch File System Folder Structure VALUES ---
                //-----------------------------------------------------
                strMsg = string.Format("        APPLICATION EXE LOCATION: {0}", AppExecPath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("           INPUT FOLDER LOCATION: {0}", InputFolderPath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("         LICENSE FOLDER LOCATION: {0}", LicenseFolderPath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("           TOOLS FOLDER LOCATION: {0}", ToolsFolderPath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("             HEN FOLDER LOCATION: {0}", HenFolderPath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("        HEN DATA FOLDER LOCATION: {0}", HenDataFolderPath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("     HEN FIGURES FOLDER LOCATION: {0}", HenFiguresFolderPath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("     HEN REPORTS FOLDER LOCATION: {0}", HenReportsFolderPath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("         TARGETS FOLDER LOCATION: {0}", TargetsFolderPath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("    TARGETS DATA FOLDER LOCATION: {0}", TargetsDataFolderPath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format(" TARGETS FIGURES FOLDER LOCATION: {0}", TargetsFiguresFolderPath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format(" TARGETS REPORTS FOLDER LOCATION: {0}", TargetsReportsFolderPath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                //-----------------------------------------------------
                //--- Log Pinch File System Folder Structure FOOTER ---
                //-----------------------------------------------------
                PinchLogger.WriteSeparatorLine('=');
            }
        }
        #endregion      // CTOR

        #region LicenseFileExists()
        /// <summary>
        /// Check if License File Exists
        /// </summary>
        /// <returns>true if file exists; otherwise false</returns>
        public bool LicenseFileExists()
        {
            return File.Exists(LicenseFilePath);
        }
        #endregion  // LicenseFileExists()

    }
    #endregion      // public class PinchFileSystem
}
#endregion      // namespace PinchGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
