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
        //------------------------------------------------------------- IDs ---
        public Guid ProjectId { get; set; }
        public Guid ProfileId { get; set; }

        public Guid ProcessStreamsId { get; set; }
        public Guid UtilityStreamsId { get; set; }

        //------------------------------------------------------------ DTOs ---
        public ProfileDto ProfileDtoObj { get; set; }
        public ProcessStreamDto ProcessStreamDtoObj { get; set; }

        public UtilityStreamDto UtilityStreamDtoObj { get; set; }

        public List<ProcessStreamDto> ProcessStreamDtoList { get; set; }

        public List<UtilityStreamDto> UtilityStreamDtoList { get; set; }

        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default Constructor for ProfileWrapperDto Class
        /// </summary>
        public ProfileWrapperDto()
        {
            InitializeDto();
        }
        #endregion  // CTOR

        #region INITIALIZE DTO
        /// <summary>
        /// Method to Initialize DTO Properties to Avoid Null Reference Exceptions
        /// </summary>
        private void InitializeDto()
        {
            //------------------------------------------------------------------------
            //--- Initialize IDs to Empty GUIDs to Avoid Null Reference Exceptions ---
            //------------------------------------------------------------------------
            ProjectId = Guid.Empty;
            ProfileId = Guid.Empty;
            ProcessStreamsId = Guid.Empty;
            UtilityStreamsId = Guid.Empty;
            //----------------------------------------------------------
            //--- Initialize DTOs to Avoid Null Reference Exceptions ---
            //----------------------------------------------------------
            ProfileDtoObj = new ProfileDto();

            ProcessStreamDtoObj = new ProcessStreamDto();
            UtilityStreamDtoObj = new UtilityStreamDto();

            ProcessStreamDtoList = new List<ProcessStreamDto>();
            UtilityStreamDtoList = new List<UtilityStreamDto>();
        }
        #endregion  // INITIALIZE DTO

    }
    #endregion      // public class ProfileWrapperDto
}
#endregion      // namespace HenModel.Dto.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
