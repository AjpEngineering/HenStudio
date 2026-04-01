#region HEADER
//#####################################################################################################################
//############################################  P r o f i l e R e p o . c s  ##########################################
//#####################################################################################################################
//  FILENAME:  ProfileRepo.cs
//  NAMESPACE: HenPersistence.Repos
//  CLASS(S):  ProfileRepo
//  COMPONENT: _HenPersistence.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the Profile top-level table.
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
using HenRepositories.Interfaces;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenPersistence.Repos
namespace HenPersistence.Repos
{
    #region public class ProfileRepo
    /// <summary>
    /// Profile Repo Class
    /// </summary>
    public class ProfileRepo : IProfileRepo
    {
        #region METHODS
        public IList<ProfileDto> GetProfiles()
        {
            throw new NotImplementedException();
        }

        public IList<ProfileDto> GetProfilesByProjectId(Guid projectId)
        {
            throw new NotImplementedException();
        }

        public ProfileDto GetProfileById(Guid profileId)
        {
            throw new NotImplementedException();
        }

        public ProfileDto GetProfileByName(Guid projectId, string profileName)
        {
            throw new NotImplementedException();
        }

        public Guid AddProfile(ProfileDto profileDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateProfile(ProfileDto profileDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteProfile(Guid profileId)
        {
            throw new NotImplementedException();
        }
        #endregion      // METHODS
    }
    #endregion      // public class ProfileRepo
}
#endregion      // namespace HenPersistence.Repos

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
