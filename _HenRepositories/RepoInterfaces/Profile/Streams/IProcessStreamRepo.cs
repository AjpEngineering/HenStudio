#region HEADER
//#####################################################################################################################
//###################################  I P r o c e s s S t r e a m R e p o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  IProcessStreamRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.Profile.Streams
//  INTERFACE: IProcessStreamRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the Process Stream Profile sub table.
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
using HenModel.Dto.Profile;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoInterfaces.Profile.Streams
namespace HenModel.RepoInterfaces.Profile.Streams
{
    #region public interface IProcessStreamRepo
    /// <summary>
    /// Process Stream Repo Interface
    /// </summary>
    public interface IProcessStreamRepo
    {
        #region METHODS
        Guid AddProcessStream(ProcessStreamDto processStreamDto);
        IList<ProcessStreamDto> GetProcessStreams();
        IList<ProcessStreamDto> GetProcessStreamsByProfileId(Guid profileId);
        ProcessStreamDto GetProcessStreamById(Guid processStreamId);
        ProcessStreamDto GetProcessStreamByStreamId(Guid profileId, string streamId);
        void UpdateProcessStream(ProcessStreamDto processStreamDto);
        void DeleteProcessStream(Guid processStreamId);
        #endregion      // METHODS
    }
    #endregion      // public interface IProcessStreamRepo
}
#endregion      // namespace HenModel.RepoInterfaces.Profile.Streams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
