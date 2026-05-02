#region HEADER
//#####################################################################################################################
//##########################  I S h e l l A n d T u b e C a p i t a l C o s t R e p o . c s  ##########################
//#####################################################################################################################
//  FILENAME:  IShellAndTubeCapitalCostRepo.cs
//  NAMESPACE: HenRepositories.Interfaces
//  INTERFACE: IShellAndTubeCapitalCostRepo
//  COMPONENT: _HenRepositories.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the Shell And Tube Capital Cost Project-Cost Parameters sub table.
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

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenRepositories.Interfaces
namespace HenRepositories.Interfaces
{
    #region public interface IShellAndTubeCapitalCostRepo
    /// <summary>
    /// Shell and Tube Capital Cost Repo Interface
    /// </summary>
    public interface IShellAndTubeCapitalCostRepo
    {
        #region METHODS
        IList<ShellAndTubeCapitalCostDto> GetShellAndTubeCapitalCost();
        IList<ShellAndTubeCapitalCostDto> GetShellAndTubeCapitalCostByProjectId(Guid projectId);
        ShellAndTubeCapitalCostDto GetShellAndTubeCapitalCostById(Guid shellAndTubeCapitalCostId);
        Guid AddShellAndTubeCapitalCost(ShellAndTubeCapitalCostDto shellAndTubeCapitalCostDto);
        void UpdateShellAndTubeCapitalCost(ShellAndTubeCapitalCostDto shellAndTubeCapitalCostDto);
        void DeleteShellAndTubeCapitalCost(Guid shellAndTubeCapitalCostId);
        #endregion      // METHODS
    }
    #endregion      // public interface IShellAndTubeCapitalCostRepo
}
#endregion      // namespace HenRepositories.Interfaces

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
