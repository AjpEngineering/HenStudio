#region HEADER
//#####################################################################################################################
//##########################################  I U t i l i t y C o s t R e p o . c s  ##################################
//#####################################################################################################################
//  FILENAME:  IUtilityCostRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.Project.CostParameters
//  INTERFACE: IUtilityCostRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the Utility Cost Project-Cost Parameters sub table.
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
using HenModel.Dto.Project.CostParameters;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenModel.RepoInterfaces.Project.CostParameters
namespace HenModel.RepoInterfaces.Project.CostParameters
{
    #region public interface IUtilityCostRepo
    /// <summary>
    /// Utility Cost Repo Interface
    /// </summary>
    public interface IUtilityCostRepo
    {
        #region METHODS
        Guid AddUtilityCost(UtilityCostDto utilityCostDto);
        IList<UtilityCostDto> GetUtilityCost();
        UtilityCostDto GetUtilityCostById(Guid utilityCostId);
        UtilityCostDto GetUtilityCostByProjectId(Guid projectId);
        void UpdateUtilityCost(UtilityCostDto utilityCostDto);
        void DeleteUtilityCost(Guid utilityCostId);
        #endregion      // METHODS
    }
    #endregion      // public interface IUtilityCostRepo
}
#endregion      // namespace HenModel.RepoInterfaces.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
