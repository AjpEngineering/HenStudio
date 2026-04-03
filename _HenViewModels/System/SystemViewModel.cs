#region HEADER
//#####################################################################################################################
//########################################  S y s t e m V i e w M o d e l . c s  ######################################
//#####################################################################################################################
//  FILENAME:  SystemViewModel.cs
//  NAMESPACE: HenViewModels
//  CLASS(S):  SystemViewModel
//  COMPONENT: _HenViewModels.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the system DTO objects.
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
    #region public class SystemViewModel
    /// <summary>
    /// System view model class.
    /// </summary>
    public class SystemViewModel : ViewModelBase
    {
        #region PROPERTIES
        public ConnectionDataDto ConnectionData { get; set; }
        public GlobalSettingsDto GlobalSettings { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class SystemViewModel
}
#endregion      // namespace HenViewModels

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
