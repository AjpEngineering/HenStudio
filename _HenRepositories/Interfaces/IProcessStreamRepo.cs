#region HEADER
//#####################################################################################################################
//###################################  I P r o c e s s S t r e a m R e p o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  IProcessStreamRepo.cs
//  NAMESPACE: HenRepositories.Interfaces
//  INTERFACE: IProcessStreamRepo
//  COMPONENT: _HenRepositories.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the ProcessStream Profile sub table.
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
using HenRepositories.Dto;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenRepositories.Interfaces
namespace HenRepositories.Interfaces
{
    #region public interface IProcessStreamRepo
    /// <summary>
    /// ProcessStream Repo Interface
    /// </summary>
    public interface IProcessStreamRepo
    {
        #region METHODS
        IList<ProcessStreamDto> GetProcessStreams();
        IList<ProcessStreamDto> GetProcessStreamsByProfileId(Guid profileId);
        ProcessStreamDto GetProcessStreamById(Guid processStreamId);
        ProcessStreamDto GetProcessStreamByStreamId(Guid profileId, string streamId);
        Guid AddProcessStream(ProcessStreamDto processStreamDto);
        void UpdateProcessStream(ProcessStreamDto processStreamDto);
        void DeleteProcessStream(Guid processStreamId);
        #endregion      // METHODS
    }
    #endregion      // public interface IProcessStreamRepo
}
#endregion      // namespace HenRepositories.Interfaces

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
