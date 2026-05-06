#region HEADER
//#####################################################################################################################
//############################################  H e n V i e w M o d e l . c s  ########################################
//#####################################################################################################################
//  FILENAME:  HenViewModel.cs
//  NAMESPACE: HenViewModel.Hen
//  CLASS(S):  HenViewModel
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the Hen top-level DTO.
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

using HenModel.Connection;
using HenModel.Dto.Hen;
using HenModel.Dto.Hen.Plots;
using HenModel.RepoImplementations.Hen;
using HenModel.RepoImplementations.Hen.Plots;

//using HenModel.RepoImplementations.Hen;

#endregion      // REFERENCES

#region namespace HenViewModel.Hen  
namespace HenViewModel.Hen
{
    #region public class HenViewModel
    /// <summary>
    /// Hen view model class.
    /// </summary>
    public class HenViewModel : ViewModelBase
    {
        #region PROPERTIES
        public HenDto Hen { get; set; }
        public ExchangerDto Exchanger { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class HenViewModel
}
#endregion      // namespace HenViewModel.Hen

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
