#region HEADER
//#####################################################################################################################
//#####################################  P r o f i l e W r a p p e r D t o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  ProfileWrapperDto.cs
//  NAMESPACE: HenModel.Dto.Profile
//  CLASS(S):  ProfileWrapperDto
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the Profile Wrapper DTO.
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
using HenModel.Dto.Profile.Streams;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.Dto.Profile
namespace HenModel.Dto.Profile
{
    #region public class ProfileWrapperDto
    /// <summary>
    /// Profile Wrapper DTO Class
    /// </summary>
    public class ProfileWrapperDto
    {
        #region PROPERTIES
        public string ProjectDbName { get; set; } = string.Empty;
        //------------------------------------------------------- IDs ---
        //--- Initialize IDs to -1 to Avoid Null Reference Exceptions ---
        //---------------------------------------------------------------
        public int ProjectId { get; set; } = -1;
        public int ProfileId { get; set; } = -1;

        public int ProcessStreamsId { get; set; } = -1;
        public int UtilityStreamsId { get; set; } = -1;

        //------------------------------------------------- DTOs ---
        //--- Initialize DTOs to Avoid Null Reference Exceptions ---
        //----------------------------------------------------------
        public ProfileDto ProfileDtoObj { get; set; } = new ProfileDto();

        public List<ProcessStreamDto> ProcessStreamDtoList { get; set; } = new List<ProcessStreamDto>();

        public List<UtilityStreamDto> UtilityStreamDtoList { get; set; } = new List<UtilityStreamDto>();

        #endregion      // PROPERTIES
    }
    #endregion      // public class ProfileWrapperDto
}
#endregion      // namespace HenModel.Dto.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
