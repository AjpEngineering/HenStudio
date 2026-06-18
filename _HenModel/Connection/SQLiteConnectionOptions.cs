#region HEADER
//#####################################################################################################################
//####################################  S q l i t e C o n n e c t i o n O p t i o n s . c s  ##########################
//#####################################################################################################################
//  FILENAME:  SQLiteConnectionOptions.cs
//  NAMESPACE: HenModel.Connection
//  CLASS(S):  SQLiteConnectionOptions
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the SQLite Connection Options class.
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
#endregion

#region REFERENCES
using System;
using System.Data;
using Microsoft.Data.Sqlite;
#endregion  // REFERENCES

#region namespace HenModel.Connection
namespace HenModel.Connection
{
    #region public class SQLiteConnectionOptions
    /// <summary>
    /// SQLite Connection Options Class
    /// </summary>
    public class SQLiteConnectionOptions
    {
        public DatabaseType DbType { get; set; }
        public string DatabasePath { get; set; }
        public string BuildConnectionString()
        {
            return $"Data Source={DatabasePath};Cache=Shared;";
        }
    }
    #endregion  // public class SQLiteConnectionOptions
}
#endregion  // namespace HenModel.Connection

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
