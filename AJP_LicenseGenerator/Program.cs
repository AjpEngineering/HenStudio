#region HEADER
//######################################################################################################
//#######################################  P r o g r a m . c s  ########################################
//######################################################################################################
//  FILENAME:  Program.cs
//  NAMESPACE: AJP_LicenseGenerator
//  CLASS(S):  Program
//  COMPONENT: AJP_LicenseGenerator.exe
//======================================================================================================
//  DESCRIPTION: 
//    This file contains the main entry point for the application.
//    Creates AJP Splash Screen Thread.
//======================================================================================================
//  AUTHOR:
//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//                                                                                                    !!
//                    GGGGG   IIIIII   OOOOO    RRRRRRR    GGGGG   IIIIII   OOOOO                     !!
//                   GG   GG    II    OO   OO   RR    RR  GG   GG    II    OO   OO                    !!
//                   GG         II   OO     OO  RR    RR  GG         II   OO     OO                   !!
//                   GG  GGGG   II   OO     OO  RRRRRRR   GG  GGGG   II   OO     OO                   !!
//                   GG   GG    II    OO   OO   RR    RR  GG   GG    II    OO   OO                    !!
//                    GGGGG   IIIIII   OOOOO    RR    RR   GGGGG   IIIIII   OOOOO                     !!
//                                                                                                    !!
//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//    (c)Copyright 2022 AJP Engineering
//    All rights reserved.
//======================================================================================================
//  HISTORY:
//    11/18/22 .. pg .. Version 1.0
//######################################################################################################
//######################################################################################################
//######################################################################################################
#endregion      // HEADER

#region REFERENCES
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
#endregion      // REFERENCES

#region namespace AJP_LicenseGenerator
namespace AJP_LicenseGenerator
{
    #region class Program
    internal static class Program
    {
        //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

        #region Main Method ... Entry Point
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string strMsg = string.Empty;
            try
            {
                //--------------------------------------------------------------------------------------
                //---------------------------------- EMPTY LOG FILE ------------------------------------
                //--------------------------------------------------------------------------------------
                string nDefaultFilename = "AJP_LicenseGenerator_LOG.log";
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
                LicGenLogger.WriteHeader();
                LicGenLogger.WriteSection("START CONSTRUCTION SECTION");
                //--------------------------------------------------------------------------------------
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Application.Run(new FormMain());
            }
            catch (Exception ex)
            {
                //--- LOG EXCEPTION ---
                strMsg = String.Format("CLASS: {0}  METHOD: {1}  EXCEPTION: {2}", "PROGRAM", "Main", ex.Message);
                Console.WriteLine(strMsg);
            }
            finally
            {
                //--------------------------------------------------------------------------------------
                //--------------------------- WRITE LOG FOOTER and FLUSH FILE --------------------------
                //--------------------------------------------------------------------------------------
                LicGenLogger.WriteFooter();  // Write Footer
                LicGenLogger.FlushLog();     // Flush Log to Listener
            }
        }
        #endregion      // Main Method ... Entry Point

        //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

    }
    #endregion      // class Program
}
#endregion      // namespace AJP_LicenseGenerator

//=====================================================================================================================
//---------------------------------------------- E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
