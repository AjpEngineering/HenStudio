#region HEADER
//#####################################################################################################################
//##########################################  P i n c h L o g g e r . c s  ############################################
//#####################################################################################################################
//  FILENAME:  PinchLogger.cs
//  NAMESPACE: PinchGlobal
//  CLASS(S):  PinchLogger
//  COMPONENT: _PinchGLobal.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for managing the Pinch Log.
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
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace PinchGlobal
namespace PinchGlobal
{
    #region  public static class PinchLogger
    /// <summary>
    /// STATIC Class PinchLogger contains static methods for logging to file
    /// </summary>
    public static class PinchLogger
    {
        #region CONSTS
        private const string NAMESPACE = "PinchGlobal";
        private const string CLASS = "PinchLogger";
        //===========================================================================
        //------------------------------- LOG LEVEL ---------------------------------
        //===========================================================================
        //public const PinchTypes.LogLevel LogLevel = PinchTypes.LogLevel.LOG_NONE;
        //public const PinchTypes.LogLevel LogLevel = PinchTypes.LogLevel.LOG_ERRORS;
        //public const PinchTypes.LogLevel LogLevel = PinchTypes.LogLevel.LOG_WARNINGS;
        //public const PinchTypes.LogLevel LogLevel = PinchTypes.LogLevel.LOG_IMPORTANT;
        public const PinchTypes.LogLevel LogLevel = PinchTypes.LogLevel.LOG_ALL;
        //===========================================================================
        private const bool bDefaultImportant = true;
        private const int nDefaultSepLength = 200;
        private const char cDefaultSepChar = '=';
        private const char cDefaultTopLine = '=';
        private const char cDefaultMiddleLine = '-';
        private const char cDefaultBottomLine = '=';

        private const int nFlushCountLimit = 20;   // Flush Count Limit
        private static int nFlushCount = 0;        // Current Flush Count
        private static bool bAutoflush = false;    // Ensure this flag matches what is in App.config.xml file
        #endregion      // CONSTS

        #region public static void FlushLog
        /// <summary>
        /// Flush Output Buffer - Buffered data written to Trace.Listeners
        /// Listeners set in App.config XML File.
        /// </summary>
        public static void FlushLog()
        {
            Trace.Flush();
            nFlushCount = 0;        // Reset nFlushCount
        }
        #endregion      // public static void FlushLog

        #region public static void LogInfo
        /// <summary>
        /// Log INFO Message ... Log ERROR, WARNING and IMPORTANT MESSAGES (FLAG Set)
        /// </summary>
        /// <param name="strNamespace">Entry Namespace</param>
        /// <param name="strClass">Entry Class</param>
        /// <param name="strMethod">Entry Method</param>
        /// <param name="strMsg">Entry Message</param>
        /// <param name="bImportant">Importatnt Message Flag</param>
        public static void LogInfo(string strNamespace, string strClass, string strMethod,
                                   string strMsg, bool bImportant = false)
        {
            if (bImportant)
            {
                if ((PinchLogger.LogLevel == PinchTypes.LogLevel.LOG_ALL) ||
                   (PinchLogger.LogLevel == PinchTypes.LogLevel.LOG_IMPORTANT))
                {
                    WriteEntry(strNamespace, strClass, strMethod, "INFO", strMsg);
                    nFlushCount++;
                    if (nFlushCount >= nFlushCountLimit) FlushLog();
                }
            }
            else if ((PinchLogger.LogLevel == PinchTypes.LogLevel.LOG_ALL))
            {
                WriteEntry(strNamespace, strClass, strMethod, "INFO", strMsg);
                nFlushCount++;
                if (nFlushCount >= nFlushCountLimit) FlushLog();
            }
        }
        #endregion      // public static void LogInfo

        #region public static void LogWarning
        /// <summary>
        /// Log WARNING Message ... Log ERROR or WARNING MESSAGES
        /// </summary>
        /// <param name="strNamespace">Entry Namespace</param>
        /// <param name="strClass">Entry Class</param>
        /// <param name="strMethod">Entry Method</param>
        /// <param name="strMsg">Entry Message</param>
        public static void LogWarning(string strNamespace, string strClass, string strMethod,
                                    string strMsg)
        {
            if ((PinchLogger.LogLevel == PinchTypes.LogLevel.LOG_ALL) ||
                (PinchLogger.LogLevel == PinchTypes.LogLevel.LOG_WARNINGS) ||
                (PinchLogger.LogLevel == PinchTypes.LogLevel.LOG_ERRORS))
            {
                WriteEntry(strNamespace, strClass, strMethod, "!!! WARNING !!!", strMsg);
                nFlushCount++;
                if (nFlushCount >= nFlushCountLimit) FlushLog();
            }
        }
        #endregion      // public static void LogWarning

        #region public static void LogError
        /// <summary>
        /// Log ERROR Message ... Log ONLY ERROR MESSAGES
        /// </summary>
        /// <param name="strNamespace">Entry Namespace</param>
        /// <param name="strClass">Entry Class</param>
        /// <param name="strMethod">Entry Method</param>
        /// <param name="strMsg">Entry Message</param>
        public static void LogError(string strNamespace, string strClass, string strMethod,
                                    string strMsg)
        {
            if ((PinchLogger.LogLevel == PinchTypes.LogLevel.LOG_ALL) ||
                (PinchLogger.LogLevel == PinchTypes.LogLevel.LOG_ERRORS))

            {
                WriteEntry(strNamespace, strClass, strMethod, "*** ERROR ***", strMsg);
                FlushLog();
            }
        }
        #endregion      // public static void LogError

        #region public static void WriteSeparatorLine
        /// <summary>
        /// Write Separator Line to Log File
        /// </summary>
        /// <param name="cSepChar">Separator Character</param>
        /// <param name="bImportant">Importatnt Message Flag</param>
        /// <param name="nLength">Separator Line Length</param>
        public static void WriteSeparatorLine(char cSepChar = cDefaultSepChar, bool bImportant = bDefaultImportant, int nLength = nDefaultSepLength)
        {
            if (bImportant)
            {
                if ((PinchLogger.LogLevel == PinchTypes.LogLevel.LOG_ALL) ||
                (PinchLogger.LogLevel == PinchTypes.LogLevel.LOG_IMPORTANT))
                {
                    Trace.WriteLine(String.Join("", Enumerable.Repeat(cSepChar, nLength)));
                }
            }
        }
        #endregion      // public static void WriteSeparatorLine

        #region public static void WriteSection
        /// <summary>
        /// Write Section to Log
        /// </summary>
        /// <param name="strLabel">Section Label</param>
        /// <param name="cTopLine">Character of Top Line</param>
        /// <param name="cMiddleLine">Character of Middle Line</param>
        /// <param name="cBottomLine">Character of Bottom Line</param>
        /// <param name="nLineLength">Total Line Length</param>
        public static void WriteSection(string strLabel,
                                        char cTopLine = cDefaultTopLine,
                                        char cMiddleLine = cDefaultMiddleLine,
                                        char cBottomLine = cDefaultBottomLine,
                                        int nLineLength = nDefaultSepLength)
        {
            //--- Get Section Line Length Specifications based on Line and Label lengths ---
            int n = nLineLength;                    // Total Line Length
            int nL = strLabel.Length;               // Section Text String Length
            int nTextMargin = 2;                    // Margin Space on either side of the Section Text

            int nX1 = (n / 2) - (nL / 2) - nTextMargin; // Initial Section Line Length
            int nX2 = nL + (2 * nTextMargin);             // Total Section Text String including Surrounding Margin
            int nX3 = n - (nX1 + nX2);              // Final Section Line Length

            //--- String Sections ---
            string strInitialSection = String.Join("", Enumerable.Repeat(cMiddleLine, nX1));
            string srtMiddleSection = String.Format("{0}{1}{2}",
                                                     string.Join("", Enumerable.Repeat(' ', nTextMargin)),
                                                     strLabel,
                                                     string.Join("", Enumerable.Repeat(' ', nTextMargin)));
            string strFinalSection = String.Join("", Enumerable.Repeat(cMiddleLine, nX3));
            string strSectionLine = String.Format("{0}{1}{2}",
                                                  strInitialSection,
                                                  srtMiddleSection,
                                                  strFinalSection);
            WriteSeparatorLine(cTopLine);
            Trace.WriteLine(strSectionLine);
            WriteSeparatorLine(cBottomLine);
            FlushLog();
        }
        #endregion      // public static void WriteSection

        #region public static void WriteHeader
        /// <summary>
        /// Write Header to Log File
        /// </summary>
        public static void WriteHeader()
        {
            int nIndent = 8;
            String strIndent = string.Join("", Enumerable.Repeat(' ', nIndent));

            Trace.WriteLine(String.Format(" > [Autoflush] = {0}   [Flush Count Limit] = {1}",
                                          bAutoflush.ToString(),
                                          nFlushCountLimit.ToString()));
            WriteSeparatorLine();
            Trace.WriteLine(strIndent + "      A           JJJJJJJJ   PPPPPPPP          EEEEEEEEE   NN     NN    GGGGGGG    IIIIII   NN     NN  EEEEEEEEE  EEEEEEEEE  RRRRRRRR     IIIIII   NN     NN    GGGGGGG");
            Trace.WriteLine(strIndent + "     A A             JJ      PP     PP         EE          NNN    NN   GG     GG     II     NNN    NN  EE         EE         RR     RR      II     NNN    NN   GG     GG");
            Trace.WriteLine(strIndent + "    A   A            JJ      PP     PP         EE          NNNN   NN   GG            II     NNNN   NN  EE         EE         RR     RR      II     NNNN   NN   GG");
            Trace.WriteLine(strIndent + "   AAAAAAA      JJ   JJ      PPPPPPPPP         EEEEEEE     NN NN  NN   GG            II     NN NN  NN  EEEEEEE    EEEEEEE    RRRRRRRR       II     NN NN  NN   GG");
            Trace.WriteLine(strIndent + "  AA     AA     JJ   JJ      PP                EE          NN   NNNN   GG    GGGG    II     NN   NNNN  EE         EE         RR     RR      II     NN   NNNN   GG    GGGG");
            Trace.WriteLine(strIndent + " AA       AA    JJ   JJ      PP                EE          NN    NNN   GG     GG     II     NN    NNN  EE         EE         RR      RR     II     NN    NNN   GG     GG");
            Trace.WriteLine(strIndent + "AA         AA    JJJJJJ      PP                EEEEEEEEE   NN     NN    GGGGGGG    IIIIII   Nn     NN  EEEEEEEEE  EEEEEEEEE  RR      RR   IIIIII   NN     NN    GGGGGGG"); 
            WriteSeparatorLine();
            FlushLog();
        }
        #endregion      // public static void WriteHeader

        #region public static void WriteFooter
        /// <summary>
        /// Write Footer to Log File
        /// </summary>
        public static void WriteFooter()
        {
            WriteSection("* * * * *  E N D   O F   L O G  * * * * * ");
            FlushLog();
        }
        #endregion      /// public static void WriteFooter

        #region private static void WriteEntry
        /// <summary>
        /// Write Log Entry  ... common formatted log entry
        /// </summary>
        /// <param name="strNamespace">Entry Namespace</param>
        /// <param name="strClass">Entry Class</param>
        /// <param name="strMethod">Entry Method</param>
        /// <param name="strLineNum">Entry File Line Number</param>
        /// <param name="strType">Entry Type [INFO | WARNING | ERROR]</param>
        /// <param name="strMsg">Entry Message</param>
        private static void WriteEntry(string strNamespace, string strClass, string strMethod, string strType, string strMsg)
        {
            string strTimestamp = DateTime.Now.ToString("yyyyMMdd:HH:mm:ss");
            String strEntry = String.Format("[{0}][{1}][{2}][{3}] [{4}]: {5}",
                                            strTimestamp,
                                            strNamespace, strClass, strMethod,
                                            strType, strMsg);
            Trace.WriteLine(strEntry);
        }
        #endregion      // private static void WriteEntry
    }
    #endregion      //  public static class PinchLogger
}
#endregion      // namespace PinchGlobal

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
