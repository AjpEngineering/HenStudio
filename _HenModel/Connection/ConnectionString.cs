#region HEADER
//#####################################################################################################################
//######################################  C o n n e c t i o n S t r i n g . c s  ######################################
//#####################################################################################################################
//  FILENAME:  ConnectionString.cs
//  NAMESPACE: HenModel.Connection
//  CLASS(S):  ConnectionStrings
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the database connection string constants parameters for the MODEL layer SQLite DB connections.
//    PARAMETERS
//---------------------------------------------------------------------------------------------------------------------
//      Data Source          → Database file name
//---------------------------------------------------------------------------------------------------------------------
//    CONNECTION PARAMS
//      Cache=Shared         → allows multiple connections to the same DB
//      Mode=ReadWriteCreate → ensures DB file is created if missing
//      Pooling=True         → improves performance
//---------------------------------------------------------------------------------------------------------------------
//    EXAMPLES OF THE TWO DATBASE TYPES ... APPLICATION (HenStudio) and PROJECT (ProjectName):
//          HenStudio   = "Data Source=HenStudio.db;Cache=Shared;Mode=ReadWriteCreate;Pooling=True;"
//          Project = "Data Source={ProjectName}.db;Cache=Shared;Mode=ReadWriteCreate;Pooling=True;"
//---------------------------------------------------------------------------------------------------------------------
//    NOTE:
//      The Data Source Parameter is the name of the database.  For ...
//          HenStudio the Data Source is "HenStudio.db" ........... APPLICATION DATABASE
//          Project   the Data Source is the "ProjectName.db" ..... PROJECT     DATABASE
//---------------------------------------------------------------------------------------------------------------------
//      The Data Source Parameter is provided by the client in the GetConnectionString() Static Method
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
//    01/01/26 .. AJP Engineering .. Version 1.0
//#####################################################################################################################
//#####################################################################################################################
//#####################################################################################################################
#endregion      // HEADER

#region namespace HenModel.Connection
namespace HenModel.Connection
{
    #region public static class ConnectionString
    /// <summary>
    /// Database connection string constants class.
    /// </summary>
    public static class ConnectionString
    {
        #region CONSTANTS
        public const string APP_DB_FILENAME = "HenStudio.db";
        public const string CONN_PARAMS = "Cache=Shared;Mode=ReadWriteCreate;Pooling=True;";
        #endregion      // CONSTANTS

        #region GetSqliteAppConnectionString(string strAppDatabaseFilename = APP_DB_FILENAME)
        /// <summary>
        /// Get SQLite Connection String for APPLICATION (e.g., HenStudio.db) Database Filename
        /// </summary>
        /// <param name="strDatabaseFilename">Application Database Filename.  DEFAULT is APP_DB_FILENAME</param>
        /// <returns>Connection String to APPLICATION Database</returns>
        public static string GetSqliteAppConnectionString(string strAppDatabaseFilename = APP_DB_FILENAME)
        {
            //----------------------------------------------------------------------------------------------
            //--------------------------------------------- EXAMPLE ----------------------------------------
            //----------------------------------------------------------------------------------------------
            //--- HenStudio: "Data Source=HenStudio.db;Cache=Shared;Mode=ReadWriteCreate;Pooling=True;"; ---
            //----------------------------------------------------------------------------------------------
            return string.Format("Data Source={0}{1]", strAppDatabaseFilename, CONN_PARAMS);
        }
        #endregion  // GetSqliteAppConnectionString(string strAppDatabaseFilename = APP_DB_FILENAME)

        #region GetSqliteProjectConnectionString(string strProjectDatabaseFilename)
        /// <summary>
        /// Get SQLite Connection String for PROJECT (e.g., Exxon.db) Database Filename
        /// </summary>
        /// <param name="strProjectDatabaseFilename">Database Filename.  NO DEFAULT ALLOWED</param>
        /// <returns>Connection String to PROJECT Database</returns>
        public static string GetSqliteProjectConnectionString(string strProjectDatabaseFilename)
        {
            //-----------------------------------------------------------------------------------------
            //----------------------------------------- EXAMPLE ---------------------------------------
            //-----------------------------------------------------------------------------------------
            //--- Project : "Data Source=Exxon.db;Cache=Shared;Mode=ReadWriteCreate;Pooling=True;"; ---
            //-----------------------------------------------------------------------------------------
            return string.Format("Data Source={0}{1]", strProjectDatabaseFilename, CONN_PARAMS);
        }
        #endregion  // GetSqliteProjectConnectionString(string strDatabaseFilename)

    }
    #endregion      // public static class ConnectionString
}
#endregion      // namespace HenModel.Connection

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
