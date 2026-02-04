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

        public const string DEFAULT_APP_FOLDERNAME = "AJP Pinch 4";
        public const string DEFAULT_APP_FILENAME = "Pinch.exe";
        public const string DEFAULT_APP_CONFIG_FILENAME = "Pinch.exe.config";

        public const string DEFAULT_LICENSE_FOLDERNAME = "LICENSE";
        public const string DEFAULT_LICENSE_FILENAME = "License.xml";
        #endregion      // CONSTANTS

        #region FIELDS
        //--- PROGRAM FILES LOCATION ---
        private string _strProgramFilesFolderPath = String.Empty;   // Full Path ProgramFiles Folder Location
        private string _strAppExeFolderPath = String.Empty;         // Full Path App Exe Launch Folder Location
        private string _strAppExeFilePath = String.Empty;           // Full Path App Exe File Location

        //--- USER APP DATA LOCAL LOCATION
        private string _strUserAppLocalFolderPath = String.Empty;   // Full Path Local User App Data Folder Location
        private string _strPinchDataFolderPath = String.Empty;      // Full Path Pinch Local User Data Folder Location
        private string _strAppExecConfigFilePath = String.Empty;    // Full Path App Exe Config File Location

        private string _strLicenseFolderPath = String.Empty;        // Full Path LICENSE Folder Location
        private string _strLicenseFilePath = String.Empty;          // Full Path LICENSE File Location
        #endregion      // FIELDS

        #region PROPERTIES

        #region PROGRAM FILES LOCATION

        #region ProgramFilesFolderPath
        /// <summary>
        /// ProgramFilesFolderPath Property ... ProgramFiles Folder Location
        /// Full Path ... C:\Program Files\
        /// </summary>
        public string ProgramFilesFolderPath
        {
            get { return _strProgramFilesFolderPath; }
            set { _strProgramFilesFolderPath = value; }
        }
        #endregion      // ProgramFilesFolderPath

        #region AppExeFolderPath
        /// <summary>
        /// AppExeFolderPath Property ... App Executable Launch Folder Location
        /// Full Path ... C:\Program Files\AJP Pinch 4\
        /// Location contains all Pinch components including EXE and DLLS
        /// </summary>
        public string AppExeFolderPath
        {
            get { return _strAppExeFolderPath; }
            set { _strAppExeFolderPath = value; }
        }
        #endregion      // AppExeFolderPath

        #region AppExeFilePath
        /// <summary>
        /// AppExeFilePath Property ... Pinch.exe File Location 
        /// Full Path ... C:\Program Files\AJP Pinch 4\Pinch.exe 
        /// </summary>
        public string AppExeFilePath
        {
            get { return _strAppExeFilePath; }
            set { _strAppExeFilePath = value; }
        }
        #endregion      // AppExeFilePath

        #endregion  // PROGRAM FILES LOCATION

        #region USER APP DATA LOCAL LOCATION

        #region UserAppLocalFolderPath
        /// <summary>
        /// UserAppLocalFolderPath Property ... User App Data Local Folder Location
        /// Full Path ... C:\Users\<User>\AppData\Local\
        /// </summary>
        public string UserAppLocalFolderPath
        {
            get { return _strUserAppLocalFolderPath; }
            set { _strUserAppLocalFolderPath = value; }
        }
        #endregion      // UserAppLocalFolderPath

        #region PinchDataFolderPath
        /// <summary>
        /// PinchDataFolderPath Property ... Pinch Local User Data Folder Location
        /// Full Path ... C:\Users\<User>\AppData\Local\AJP Pinch 4\
        /// </summary>
        public string PinchDataFolderPath
        {
            get { return _strPinchDataFolderPath; }
            set { _strPinchDataFolderPath = value; }
        }
        #endregion      // PinchDataFolderPath

        #region AppExecConfigFilePath
        /// <summary>
        /// AppExecConfigFilePath Property ... Pinch.exe.config File Location
        /// Full Path ... C:\Users\<User>\AppData\Local\AJP Pinch 4\Pinch.exe.config
        /// </summary>
        public string AppExecConfigFilePath
        {
            get { return _strAppExecConfigFilePath; }
            set { _strAppExecConfigFilePath = value; }
        }
        #endregion      // AppExecConfigFilePath

        #region LicenseFolderPath
        /// <summary>
        /// LicenseFolderPath Property ... LICENSE Folder Location
        /// Full Path ... C:\Users\<User>\AppData\Local\AJP Pinch 4\LICENSE\
        /// </summary>
        public string LicenseFolderPath
        {
            get { return _strLicenseFolderPath; }
            set { _strLicenseFolderPath = value; }
        }
        #endregion      // LicenseFolderPath

        #region LicenseFilePath
        /// <summary>
        /// LicenseFilePath Property ... LICENSE File Location
        /// Full Path ... C:\Users\<User>\AppData\Local\AJP Pinch 4\LICENSE\License.xml
        /// </summary>
        public string LicenseFilePath
        {
            get { return _strLicenseFilePath; }
            set { _strLicenseFilePath = value; }
        }
        #endregion      // LicenseFilePath

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
                PinchLogger.WriteSeparatorLine('=');
                PinchLogger.WriteSection("PINCH FILE SYSTEM FOLDER STRUCTURE");
                PinchLogger.WriteSeparatorLine('=');

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
