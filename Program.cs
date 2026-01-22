#region HEADER
//#####################################################################################################################
//##############################################  P r o g r a m . c s  ################################################
//#####################################################################################################################
//  FILENAME:  Program.cs
//  NAMESPACE: Pinch
//  CLASS(S):  Program
//  COMPONENT: Pinch.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the main entry point for the application. 
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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using AJP_License_File;
using PinchGlobal;
#endregion  // REFERENCES

#region namespace Pinch
namespace Pinch
{
    #region internal static class Program
    /// <summary>
    /// Program Class - main entry point for the application
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //--------------------------------------------------------------------------------------
            //---------------------------------- EMPTY LOG FILE ------------------------------------
            //--------------------------------------------------------------------------------------
            string nDefaultFilename = "AJP_Pinch_LOG.log";
            string strExecPath = Path.GetDirectoryName(Application.ExecutablePath);
            string strFullPathFilename = String.Format("{0}\\{1}", strExecPath, nDefaultFilename);
            //Console.WriteLine(String.Format("Executable Path: {0}", strExecPath));                 // ***** TEST *****
            //Console.WriteLine(String.Format("Full Path Filename: {0}", strFullPathFilename));      // ***** TEST *****
            //-------------------------------------
            //--- IF File Exists THEN Delete It ---
            //-------------------------------------
            if (File.Exists(strFullPathFilename))
            {
                //Console.WriteLine("FILE EXISTS");      // ***** TEST *****
                File.Delete(strFullPathFilename);
            }
            //--------------------------------------------------------------------------------------
            //---------------------------------- WRITE LOG HEADER ----------------------------------
            //--------------------------------------------------------------------------------------
            PinchLogger.WriteHeader();
            PinchLogger.WriteSection("START CONSTRUCTION SECTION");
            //--------------------------------------------------------------------------------------
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
            //--------------------------------------------------------------------------------------
            //--------------------------- WRITE LOG FOOTER and FLUSH FILE --------------------------
            //--------------------------------------------------------------------------------------
            PinchLogger.WriteFooter();  // Write Footer
            PinchLogger.FlushLog();     // Flush Log to Listener
        }
    }
    #endregion      // internal static class Program
}
#endregion      // namespace Pinch

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
