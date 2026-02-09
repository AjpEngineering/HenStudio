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
    /// Installed exe and dll components (Assemblies) located in the ProgamFiles folder
    /// Application data (i.e., License.xml, pinch.exe.config, etc.) located in LocalApplicationsData
    /// Pinch Analyis Project data (*.xml, *.zip) located at User Specified location (initially at UserAppDocuments)
    /// </summary>
    public class PinchFileSystem
    {
        #region CONSTANTS
        const string NAMESPACE = "PinchGlobal";
        const string CLASS = "PinchFileSystem";

        public const string DEFAULT_APP_FOLDERNAME = "AJP Pinch 4";
        public const string DEFAULT_APP_FILENAME = "Pinch.exe";
        public const string DEFAULT_APP_CONFIG_FILENAME = "Pinch.exe.config";

        public const string DEFAULT_LICENSE_FOLDERNAME = "LICENSE";
        public const string DEFAULT_LICENSE_FILENAME = "License.xml";
        #endregion      // CONSTANTS

        #region PROPERTIES

        #region PROGRAM FILES LOCATION
        public string ProgramFilesFolderPath { get; set; }  // Full Path ProgramFiles Folder Location
        public string AppExeFolderPath { get; set; }        // Full Path App Exe Launch Folder Location
        public string AppExeFilePath { get; set; }          // Full Path App Exe File Location
        #endregion  // PROGRAM FILES LOCATION

        #region USER APP DATA LOCAL LOCATION
        public string UserAppLocalFolderPath { get; set; }  // Full Path Local User App Data Folder Location
        public string PinchDataFolderPath { get; set; }     // Full Path Pinch Local User Data Folder Location
        public string AppExecConfigFilePath { get; set; }   // Full Path App Exe Config File Location
        public string LicenseFolderPath { get; set; }       // Full Path LICENSE Folder Location
        public string LicenseFilePath { get; set; }         // Full Path LICENSE File Location
        #endregion  // USER APP DATA LOCAL LOCATION

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
                //----------------------------------------------------------------------------------------
                //--------------------------------------------------------------- C:\Program Files\... ---
                //----------------------------------------------------------------------------------------
                //ProgramFilesFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles); // has x86
                //------------------------------------------------------------------------------------------------------
                ProgramFilesFolderPath = Environment.GetEnvironmentVariable("ProgramW6432");
                //AppExeFolderPath = String.Format("{0}\\{1}", ProgramFilesFolderPath, DEFAULT_APP_FOLDERNAME);  // INSTALL LOC

                //************************************************************************************************
                //--- CO-LOCATE WITH EXECUABLE FOR DEVELOPMENT ... INSTALLED APP WILL RESIDE IN PROGRAM FILES  --- 
                //**************************************************************************************** DEV ---
                AppExeFolderPath = Path.GetDirectoryName(Application.ExecutablePath);
                //**************************************************************************************** DEV ---
                //************************************************************************************************

                AppExeFilePath = String.Format("{0}\\{1}", AppExeFolderPath, DEFAULT_APP_FILENAME); 

                //----------------------------------------------------------------------------------------
                //--------------------------------------------------- C:\Users\<User>\AppData\Local... ---
                //----------------------------------------------------------------------------------------
                //UserAppLocalFolderPath = Path.GetDirectoryName(Application.UserAppDataPath); // has roaming Folder 
                //---------------------------------------------------------------------------------------------------
                UserAppLocalFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                PinchDataFolderPath = String.Format("{0}\\{1}", UserAppLocalFolderPath, DEFAULT_APP_FOLDERNAME);

                //AppExecConfigFilePath = String.Format("{0}\\{1}", PinchDataFolderPath, DEFAULT_APP_CONFIG_FILENAME);
                //LicenseFolderPath = String.Format("{0}\\{1}", PinchDataFolderPath, DEFAULT_LICENSE_FOLDERNAME);

                //*************************************************************************************************
                //--- CO-LOCATE WITH EXECUABLE FOR DEVELOPMENT ... INSTALLED APP WILL RESIDE IN LOCAL USER DATA --- 
                //***************************************************************************************** DEV ---
                AppExecConfigFilePath = String.Format("{0}\\{1}",
                                                   Path.GetDirectoryName(Application.ExecutablePath), 
                                                   DEFAULT_APP_CONFIG_FILENAME);

                LicenseFolderPath = String.Format("{0}\\{1}", 
                                                   Path.GetDirectoryName(Application.ExecutablePath), 
                                                   DEFAULT_LICENSE_FOLDERNAME);
                //***************************************************************************************** DEV ---
                //*************************************************************************************************

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
                LogFileSystemStructure();
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

        #region LogFileSystemStructure()
        private void LogFileSystemStructure()
        {
            string strMethod = "LogFileSystemStructure";
            string strMsg = string.Empty;
            PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Log Pinch File System Folder Structure VALUES");
            try
            {
                //-----------------------------------------------------
                //--- Log Pinch File System Folder Structure HEADER ---
                //-----------------------------------------------------
                PinchLogger.WriteSection("PINCH FILE SYSTEM FOLDER STRUCTURE");

                //---------------------------------------------------
                //--- Log Pinch File System Folder Structure BODY ---
                //---------------------------------------------------
                strMsg = string.Format("               APP FOLDER NAME : {0}", DEFAULT_APP_FOLDERNAME);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("                 APP FILE NAME : {0}", DEFAULT_APP_FILENAME);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("          APP CONFIG FILE NAME : {0}", DEFAULT_APP_CONFIG_FILENAME);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("           LICENSE FOLDER NAME : {0}", DEFAULT_LICENSE_FOLDERNAME);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("             LICENSE FILE NAME : {0}", DEFAULT_LICENSE_FILENAME);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                PinchLogger.WriteSeparatorLine('-');

                strMsg = string.Format(" PROGRAM FILES FOLDER LOCATION : {0}", ProgramFilesFolderPath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("           APP FOLDER LOCATION : {0}", AppExeFolderPath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("         APP EXE FILE LOCATION : {0}", AppExeFilePath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("USER APP LOCAL FOLDER LOCATION : {0}", UserAppLocalFolderPath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("    PINCH DATA FOLDER LOCATION : {0}", PinchDataFolderPath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("  APP EXE CONFIG FILE LOCATION : {0}", AppExecConfigFilePath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("       LICENSE FOLDER LOCATION : {0}", LicenseFolderPath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("         LICENSE FILE LOCATION : {0}", LicenseFilePath);
                PinchLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                //-----------------------------------------------------
                //--- Log Pinch File System Folder Structure FOOTER ---
                //-----------------------------------------------------
                PinchLogger.WriteSeparatorLine('=');
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
        #endregion  // LogFileSystemStructure()

    }
    #endregion      // public class PinchFileSystem
}
#endregion      // namespace PinchGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
