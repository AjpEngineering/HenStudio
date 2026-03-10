#region HEADER
//#####################################################################################################################
//########################################  H e n F i l e S y s t e m . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  HenFileSystem.cs
//  NAMESPACE: HenGlobal
//  CLASS(S):  HenFileSystem
//  COMPONENT: _HenGLobal.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for managing AJP HEN Studio File and Folder locations.
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
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
#endregion  // REFERENCES

#region namespace HenGlobal
namespace HenGlobal
{
    #region public class HenFileSystem
    /// <summary>
    /// AJP HEN Studio Application - File System Structure Class
    /// Installed exe and dll components (Assemblies) located in the ProgamFiles folder
    /// Application data (i.e., License.xml, pinch.exe.config, etc.) located in LocalApplicationsData
    /// HEN Studio Database (*.mdb) located at User Specified location (initially at UserAppDocuments)
    /// </summary>
    public class HenFileSystem
    {
        #region CONSTANTS
        const string NAMESPACE = "HenGlobal";
        const string CLASS = "HenFileSystem";

        public const string DEFAULT_APP_FOLDERNAME = "AJP HEN Studio";
        public const string DEFAULT_APP_FILENAME = "HenStudio.exe";
        public const string DEFAULT_APP_CONFIG_FILENAME = "HenStudio.exe.config";

        public const string DEFAULT_LICENSE_FOLDERNAME = "LICENSE";
        public const string DEFAULT_LICENSE_FILENAME = "License.xml";

        public const string DEFAULT_CATALOG_FOLDERNAME  = "CATALOG";
        public const string DEFAULT_CATALOG_FILENAME = "Catalog.txt";    // ***** TEST ONLY *****
        //public const string DEFAULT_CATALOG_FILENAME = "Catalog.mdb";  // Catalog SQLite Database File

        public const string DEFAULT_EXPORT_FOLDERNAME   = "EXPORT";
        public const string DEFAULT_IMPORT_FOLDERNAME   = "IMPORT";
        public const string DEFAULT_PROJECTS_FOLDERNAME = "PROJECTS";

        #endregion      // CONSTANTS

        #region PROPERTIES

        #region PROGRAM FILES LOCATION
        public string ProgramFilesFolderPath { get; set; }  // Full Path ProgramFiles Folder Location
        public string AppExeFolderPath { get; set; }        // Full Path App Exe Launch Folder Location
        public string AppExeFilePath { get; set; }          // Full Path App Exe File Location
        #endregion  // PROGRAM FILES LOCATION

        #region USER APP DATA LOCAL LOCATION
        public string UserAppLocalFolderPath { get; set; }   // Full Path Local User App Data Folder Location
        public string HenStudioDataFolderPath { get; set; }  // Full Path Hen Studio Local User Data Folder Location
        public string AppExecConfigFilePath { get; set; }    // Full Path App Exe Config File Location
        public string LicenseFolderPath { get; set; }        // Full Path LICENSE Folder Location
        public string LicenseFilePath { get; set; }          // Full Path LICENSE File Location
        public string CatalogFolderPath { get; set; }        // Full Path CATALOG Folder Location
        public string CatalogFilePath { get; set; }          // Full Path CATALOG Database File Location
        public string ExportFolderPath { get; set; }         // Full Path EXPORT Folder Location
        public string ImportFolderPath { get; set; }         // Full Path IMPORT Folder Location
        public string ProjectsFolderPath { get; set; }       // Full Path PROJECTS Folder Location
        #endregion  // USER APP DATA LOCAL LOCATION

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor
        /// </summary>
        public HenFileSystem()
        {
            string strMethod = "CTOR";
            string strMsg = string.Empty;
            HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Creating Object");
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
                HenStudioDataFolderPath = String.Format("{0}\\{1}", UserAppLocalFolderPath, DEFAULT_APP_FOLDERNAME);

                //AppExecConfigFilePath = String.Format("{0}\\{1}", PinchDataFolderPath, DEFAULT_APP_CONFIG_FILENAME);
                //LicenseFolderPath = String.Format("{0}\\{1}", PinchDataFolderPath, DEFAULT_LICENSE_FOLDERNAME);

                //*************************************************************************************************
                //--- CO-LOCATE WITH EXECUABLE FOR DEVELOPMENT ... INSTALLED APP WILL RESIDE IN LOCAL USER DATA --- 
                //**************************************************************************************** DATA ---
                AppExecConfigFilePath = String.Format("{0}\\{1}",
                                                   Path.GetDirectoryName(Application.ExecutablePath), 
                                                   DEFAULT_APP_CONFIG_FILENAME);

                LicenseFolderPath = String.Format("{0}\\{1}", 
                                                   Path.GetDirectoryName(Application.ExecutablePath), 
                                                   DEFAULT_LICENSE_FOLDERNAME);

                CatalogFolderPath = String.Format("{0}\\{1}",
                                                   Path.GetDirectoryName(Application.ExecutablePath),
                                                   DEFAULT_CATALOG_FOLDERNAME);

                ExportFolderPath = String.Format("{0}\\{1}",
                                                   CatalogFolderPath,
                                                   DEFAULT_EXPORT_FOLDERNAME);

                ImportFolderPath = String.Format("{0}\\{1}",
                                                   CatalogFolderPath,
                                                   DEFAULT_IMPORT_FOLDERNAME);

                ProjectsFolderPath = String.Format("{0}\\{1}",
                                                   CatalogFolderPath,
                                                   DEFAULT_PROJECTS_FOLDERNAME);

                //**************************************************************************************** DATA ---
                //*************************************************************************************************

                LicenseFilePath = String.Format("{0}\\{1}", LicenseFolderPath, DEFAULT_LICENSE_FILENAME);
                CatalogFilePath = String.Format("{0}\\{1}", CatalogFolderPath, DEFAULT_CATALOG_FILENAME);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                LogFileSystemStructure();
                LogCurrentCatalog();
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

        #region DoesFolderExist()
        /// <summary>
        /// Check if Specified Folder Exists
        /// </summary>
        /// <param name="strFolderPath">Full Path Folder Location</param>
        /// <returns>true if Folder exists; otherwise false</returns>
        public bool DoesFolderExist(string strFolderPath)
        {
            string strMethod = "DoesFolderExist";
            bool bExists = false;
            try
            {
                if (string.IsNullOrWhiteSpace(strFolderPath))
                {
                    bExists = false;
                    throw new ArgumentException("Folder path cannot be null or empty.", nameof(strFolderPath));
                }
                else if (!Directory.Exists(strFolderPath))
                {
                    bExists = false;
                    throw new DirectoryNotFoundException($"Folder not found: {strFolderPath}");
                }
                else
                {
                    bExists = true;
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
            return bExists;
        }
        #endregion  // DoesFolderExist()

        #region DoesFileExist()
        /// <summary>
        /// Check if Specified File Exists
        /// </summary>
        /// <param name="strFilePath">Full Path File Location</param>
        /// <returns>true if File exists; otherwise false</returns>
        public bool DoesFileExist(string strFilePath)
        {
            string strMethod = "DoesFileExist";
            bool bExists = false;
            try
            {
                if (string.IsNullOrWhiteSpace(strFilePath))
                {
                    bExists = false;
                    throw new ArgumentException("Folder path cannot be null or empty.", nameof(strFilePath));
                }
                else if (!File.Exists(strFilePath))
                {
                    bExists = false;
                    throw new DirectoryNotFoundException($"File not found: {strFilePath}");
                }
                else
                {
                    bExists = true;
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
            return bExists;
        }
        #endregion  // DoesFileExist()

        #region GetFilenameList()
        /// <summary>
        /// Reads all files in the specified folder and returns a list of File Names.
        /// </summary>
        /// <param name="strFolderPath">Full Path Folder Location</param>
        /// <returns>List of Filenames</returns>
        public List<string> GetFilenameList(string strFolderPath)
        {
            string strMethod = "GetFilenameList";
            bool bFolderExists = false;
            List<string> result = new List<string>();

            #region Folder Location Checks
            bFolderExists = DoesFolderExist(strFolderPath);
            if(!bFolderExists) { return result; }
            #endregion  // Folder Location Checks

            foreach (var filePath in Directory.GetFiles(strFolderPath))
            {
                string strFileName = Path.GetFileName(filePath);
                result.Add(strFileName);
            }

            return result;
        }
        #endregion  // GetFilenameList()

        #region LogFileSystemStructure()
        private void LogFileSystemStructure()
        {
            string strMethod = "LogFileSystemStructure";
            string strMsg = string.Empty;
            HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Log HEN Studio File System Folder Structure VALUES");
            try
            {
                //----------------------------------------------------------
                //--- Log HEN Studio File System Folder Structure HEADER ---
                //----------------------------------------------------------
                HenLogger.WriteSection("HEN STUDIO FILE SYSTEM FOLDER STRUCTURE");

                //------------------------------------------------------------
                //--- Log AJP HEN Studio File System Folder Structure BODY ---
                //------------------------------------------------------------
                strMsg = string.Format("                     APP FOLDER NAME : {0}", DEFAULT_APP_FOLDERNAME);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("                       APP FILE NAME : {0}", DEFAULT_APP_FILENAME);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("                APP CONFIG FILE NAME : {0}", DEFAULT_APP_CONFIG_FILENAME);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("                 LICENSE FOLDER NAME : {0}", DEFAULT_LICENSE_FOLDERNAME);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("                   LICENSE FILE NAME : {0}", DEFAULT_LICENSE_FILENAME);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                HenLogger.WriteSeparatorLine('-');

                strMsg = string.Format("       PROGRAM FILES FOLDER LOCATION : {0}", ProgramFilesFolderPath);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("                 APP FOLDER LOCATION : {0}", AppExeFolderPath);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("               APP EXE FILE LOCATION : {0}", AppExeFilePath);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("      USER APP LOCAL FOLDER LOCATION : {0}", UserAppLocalFolderPath);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format(" AJP HEN STUDIO DATA FOLDER LOCATION : {0}", HenStudioDataFolderPath);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("        APP EXE CONFIG FILE LOCATION : {0}", AppExecConfigFilePath);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("             LICENSE FOLDER LOCATION : {0}", LicenseFolderPath);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("               LICENSE FILE LOCATION : {0}", LicenseFilePath);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("             CATALOG FOLDER LOCATION : {0}", CatalogFolderPath);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("               Catalog FILE LOCATION : {0}", CatalogFilePath);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("              EXPORT FOLDER LOCATION : {0}", ExportFolderPath);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("              IMPORT FOLDER LOCATION : {0}", ImportFolderPath);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                strMsg = string.Format("            PROJECTS FOLDER LOCATION : {0}", ProjectsFolderPath);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                //--------------------------------------------------------------
                //--- Log AJP HEN Studio File System Folder Structure FOOTER ---
                //--------------------------------------------------------------
                HenLogger.WriteSeparatorLine('=');
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
        #endregion  // LogFileSystemStructure()

        #region LogCurrentCatalog()
        /// <summary>
        /// Log the current state of the Catalog Project Database Files
        /// </summary>
        public void LogCurrentCatalog()
        {
            string strMethod = "LogCurrentCatalog";
            string strMsg = string.Empty;
            bool bFolderExists = false;
            bool bFileExists = false;

            HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, "Log Current Catalog Project Database Files");
            try
            {
                //-------------------------------------------------
                //--- Log Current Catalog Database Files HEADER ---
                //-------------------------------------------------
                HenLogger.WriteSection("CURRENT CATALOG PROJECT DATABASE FILES");

                //------------------------------------------------------------
                //--- Log AJP HEN Studio File System Folder Structure BODY ---
                //------------------------------------------------------------

                #region CATALOG
                strMsg = string.Format("        {0}  [ {1} ]", DEFAULT_CATALOG_FOLDERNAME, CatalogFolderPath);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                bFolderExists = DoesFolderExist(CatalogFolderPath);
                if (!bFolderExists)
                {
                    strMsg = string.Format("          + ");
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                    strMsg = string.Format("          +-- [ FOLDER DOES NOT EXIST ]");
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                    return;
                }

                bFileExists = DoesFileExist(CatalogFilePath);
                if(!bFileExists)
                {
                    strMsg = string.Format("          + ");
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                    strMsg = string.Format("          +-- [ CATALOG DATABASE FILE DOES NOT EXIST ]");
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                    return;
                }

                strMsg = string.Format("          +-- {0} ", DEFAULT_CATALOG_FILENAME);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                #endregion  // CATALOG

                #region EXPORT
                strMsg = string.Format("          + ");
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("          +-- {0} [ {1} ]", DEFAULT_EXPORT_FOLDERNAME, ExportFolderPath);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                //-------------------------------------------------
                //--- Get Export ZIP Names in the EXPORT Folder ---
                //-------------------------------------------------
                List<string> exports = new List<string>();
                exports = GetFilenameList(ExportFolderPath);

                if (exports.Count > 0)
                {
                    foreach (string strName in exports)
                    {
                        strMsg = string.Format("          +   +-- {0} ", strName);
                        HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                    }
                }
                else
                {
                    strMsg = string.Format("          +   + ");
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                    strMsg = string.Format("               +   +-- [ EMPTY ] ");
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // EXPORT

                #region IMPORT
                strMsg = string.Format("          + ");
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("          +-- {0} [ {1} ]", DEFAULT_IMPORT_FOLDERNAME, ImportFolderPath);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                //-------------------------------------------------
                //--- Get Import ZIP Names in the EXPORT Folder ---
                //-------------------------------------------------
                List<string> imports = new List<string>();
                imports = GetFilenameList(ImportFolderPath);

                if (imports.Count > 0)
                {
                    foreach (string strName in imports)
                    {
                        strMsg = string.Format("          +   +-- {0} ", strName);
                        HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                    }
                }
                else
                {
                    strMsg = string.Format("          +   + ");
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                    strMsg = string.Format("          +   +-- {0} ", "[ EMPTY ]");
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // IMPORT

                #region PROJECTS
                strMsg = string.Format("          + ");
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                strMsg = string.Format("          +-- {0} [ {1} ]", DEFAULT_PROJECTS_FOLDERNAME, ProjectsFolderPath);
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);

                //--------------------------------------------------------
                //--- Get Project Database Names in the Catalog Folder ---
                //--------------------------------------------------------
                List<string> projects = new List<string>();
                projects = GetFilenameList(ProjectsFolderPath);

                if (projects.Count > 0)
                {
                    foreach (string strName in projects)
                    {
                        strMsg = string.Format("              +-- {0} ", strName);
                        HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                    }
                }
                else
                {
                    strMsg = string.Format("              + ");
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                    strMsg = string.Format("              +-- {0} ", "[ EMPTY ]");
                    HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                }
                #endregion  // PROJECTS

                //--------------------------------------------------------------
                //--- Log AJP HEN Studio File System Folder Structure FOOTER ---
                //--------------------------------------------------------------
                HenLogger.WriteSeparatorLine('=');
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
        #endregion  // LogCurrentCatalog()

    }
    #endregion      // public class HenFileSystem
}
#endregion      // namespace HenGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
