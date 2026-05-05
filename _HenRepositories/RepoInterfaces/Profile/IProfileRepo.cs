#region HEADER
//#####################################################################################################################
//############################################  I P r o f i l e R e p o . c s  ########################################
//#####################################################################################################################
//  FILENAME:  IProfileRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.Profile
//  INTERFACE: IProfileRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repository interface for the Profile top-level table.
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
    #region public interface IProfileRepo
    /// <summary>
    /// Profile Repo Interface
    /// </summary>
    public interface IProfileRepo
    {
        #region METHODS
        IList<ProfileDto> GetProfiles();
        IList<ProfileDto> GetProfilesByProjectId(Guid projectId);
        ProfileDto GetProfileById(Guid profileId);
        ProfileDto GetProfileByName(Guid projectId, string profileName);
        Guid AddProfile(ProfileDto profileDto);
        void UpdateProfile(ProfileDto profileDto);
        void DeleteProfile(Guid profileId);
        #endregion      // METHODS
    }
    #endregion      // public interface IProfileRepo
}
#endregion      // namespace HenModel.RepoInterfaces.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
