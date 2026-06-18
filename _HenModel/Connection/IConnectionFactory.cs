#region HEADER
//#####################################################################################################################
//#####################################  I C o n n e c t i o n F a c t o r y . c s  ###################################
//#####################################################################################################################
//  FILENAME:  IConnectionFactory.cs
//  NAMESPACE: HenModel.Connection
//  INTERFACE: IConnectionFactory
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the SQLite database connection factory interface (both APPLICATION and PROJECT).
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

#region REFERENCES
using Microsoft.Data.Sqlite;

using System.Data;
#endregion      // REFERENCES

#region namespace HenModel.Connection
namespace HenModel.Connection
{
    #region public interface IConnectionFactory
    /// <summary>
    /// SQLite (APPLICATION & PROJECT) Database Connection Factory Interface
    /// </summary>
    public interface IConnectionFactory
    {
        #region METHODS
        SqliteConnection CreateConnection();
        #endregion      // METHODS
    }
    #endregion      // public interface IDbConnectionFactory
}
#endregion      // namespace HenModel.Connection

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
