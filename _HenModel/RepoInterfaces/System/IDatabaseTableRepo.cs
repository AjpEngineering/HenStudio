#region HEADER
//#####################################################################################################################
//####################################  I D a t a b a s e T a b l e R e p o . c s  ####################################
//#####################################################################################################################
//  FILENAME:  IDatabaseTableRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.System
//  INTERFACE: IDatabaseTableRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for database table name queries.
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
using HenModel.Dto.System;

using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoInterfaces.System
namespace HenModel.RepoInterfaces.System
{
    #region public interface IDatabaseTableRepo
    /// <summary>
    /// DatabaseTable Repo Interface
    /// </summary>
    public interface IDatabaseTableRepo
    {
        #region METHODS
        IList<DatabaseTableDto> GetDatabaseTables();
        #endregion      // METHODS
    }
    #endregion      // public interface IDatabaseTableRepo
}
#endregion      // namespace HenModel.RepoInterfaces.System

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
