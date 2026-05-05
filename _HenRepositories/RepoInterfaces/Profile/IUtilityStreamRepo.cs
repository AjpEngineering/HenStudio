#region HEADER
//#####################################################################################################################
//###################################  I U t i l i t y S t r e a m R e p o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  IUtilityStreamRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.Profile
//  INTERFACE: IUtilityStreamRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the Utility Stream Profile sub table.
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

#region namespace HenModel.RepoInterfaces.Profile
namespace HenModel.RepoInterfaces.Profile
{
    #region public interface IUtilityStreamRepo
    /// <summary>
    /// UtilityStream Repo Interface
    /// </summary>
    public interface IUtilityStreamRepo
    {
        #region METHODS
        IList<UtilityStreamDto> GetUtilityStreams();
        IList<UtilityStreamDto> GetUtilityStreamsByProfileId(Guid profileId);
        UtilityStreamDto GetUtilityStreamById(Guid utilityStreamId);
        UtilityStreamDto GetUtilityStreamByStreamId(Guid profileId, string streamId);
        Guid AddUtilityStream(UtilityStreamDto utilityStreamDto);
        void UpdateUtilityStream(UtilityStreamDto utilityStreamDto);
        void DeleteUtilityStream(Guid utilityStreamId);
        #endregion      // METHODS
    }
    #endregion      // public interface IUtilityStreamRepo
}
#endregion      // namespace HenModel.RepoInterfaces.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
