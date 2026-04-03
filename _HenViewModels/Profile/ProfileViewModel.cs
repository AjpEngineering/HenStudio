#region HEADER
//#####################################################################################################################
//######################################  P r o f i l e V i e w M o d e l . c s  ######################################
//#####################################################################################################################
//  FILENAME:  ProfileViewModel.cs
//  NAMESPACE: HenViewModels
//  CLASS(S):  ProfileViewModel
//  COMPONENT: _HenViewModels.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the Profile top-level DTO.
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
#endregion      // REFERENCES

#region namespace HenViewModels
namespace HenViewModels
{
    #region public class ProfileViewModel
    /// <summary>
    /// Profile view model class.
    /// </summary>
    public class ProfileViewModel : ViewModelBase
    {
        #region PROPERTIES
        public ProfileDto Profile { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class ProfileViewModel
}
#endregion      // namespace HenViewModels

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
