#region HEADER
//#####################################################################################################################
//############################################  I T a r g e t s R e p o . c s  ########################################
//#####################################################################################################################
//  FILENAME:  ITargetsRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.Pinch
//  INTERFACE: ITargetsRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the Targets Pinch sub table.
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
using HenModel.Dto.Pinch;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoInterfaces.Pinch
namespace HenHenModel.RepoInterfaces.Pinch
{
    #region public interface ITargetsRepo
    /// <summary>
    /// Targets Repo Interface
    /// </summary>
    public interface ITargetsRepo
    {
        #region METHODS
        IList<TargetsDto> GetTargets();
        IList<TargetsDto> GetTargetsByPinchId(Guid pinchId);
        TargetsDto GetTargetsById(Guid targetsId);
        Guid AddTargets(TargetsDto targetsDto);
        void UpdateTargets(TargetsDto targetsDto);
        void DeleteTargets(Guid targetsId);
        #endregion      // METHODS
    }
    #endregion      // public interface ITargetsRepo
}
#endregion      // namespace HenModel.RepoInterfaces.Pinch

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
