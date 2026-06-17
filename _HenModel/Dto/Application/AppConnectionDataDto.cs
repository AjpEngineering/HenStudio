#region HEADER
//#####################################################################################################################
//###################################  A p p C o n n e c t i o n D a t a D t o . c s  #################################
//#####################################################################################################################
//  FILENAME:  AppConnectionDataDto.cs
//  NAMESPACE: HenModel.Dto.System
//  CLASS(S):  AppConnectionDataDto
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the APPLICATION (HenStudio) SQLite database connection parameters.
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

#region namespace HenModel.Dto.Application
namespace HenModel.Dto.Application
{
    #region public class AppConnectionDataDto
    /// <summary>
    /// ConnectionData DTO Class
    /// </summary>
    public class AppConnectionDataDto
    {
        //--- HenStudio: "Data Source=HenStudio.db;Cache=Shared;Mode=ReadWriteCreate;Pooling=True;"; ---

        #region PROPERTIES
        public string DataSource { get; set; } = "HenStudio.db";
        public string Cache { get; set; } = "Shared";
        public string Mode { get; set; } = "ReadWriteCreate";
        public string Pooling { get; set; } = "True";
        public string SQLiteVersion { get; set; }
        public string ConnectionState { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class AppConnectionDataDto
}
#endregion      // namespace HenModel.Dto.Application

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
