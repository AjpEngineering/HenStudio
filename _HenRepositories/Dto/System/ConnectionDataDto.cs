#region HEADER
//#####################################################################################################################
//######################################  C o n n e c t i o n D a t a D t o . c s  ####################################
//#####################################################################################################################
//  FILENAME:  ConnectionDataDto.cs
//  NAMESPACE: HenRepositories.Dto
//  CLASS(S):  ConnectionDataDto
//  COMPONENT: _HenRepositories.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for database connection metadata query results.
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

#region namespace HenRepositories.Dto
namespace HenRepositories.Dto
{
    #region public class ConnectionDataDto
    /// <summary>
    /// ConnectionData DTO Class
    /// </summary>
    public class ConnectionDataDto
    {
        #region PROPERTIES
        public string DataSource { get; set; }
        public string UserId { get; set; }
        public string WorkstationId { get; set; }
        public string InitialCatalog { get; set; }
        public int Timeout { get; set; }
        public int PacketSize { get; set; }
        public string ServerVersion { get; set; }
        public string ConnectionState { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class ConnectionDataDto
}
#endregion      // namespace HenRepositories.Dto

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
