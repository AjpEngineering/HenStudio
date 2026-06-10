#region HEADER
//#####################################################################################################################
//##################################  I T o t a l A n n u a l i z e d C o s t R e p o . c s  ##########################
//#####################################################################################################################
//  FILENAME:  ITotalAnnualizedCostRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.Project.CostParameters
//  INTERFACE: ITotalAnnualizedCostRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the Total Annualized Cost (TAC) Project-Cost Parameters sub table.
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
    #region public interface ITotalAnnualizedCostRepo
    /// <summary>
    /// Total Annualized Cost Repo Interface
    /// </summary>
    public interface ITotalAnnualizedCostRepo
    {
        #region METHODS
        Guid AddTotalAnnualizedCost(TotalAnnualizedCostDto totalAnnualizedCostDto);
        IList<TotalAnnualizedCostDto> GetTotalAnnualizedCost();
        TotalAnnualizedCostDto GetTotalAnnualizedCostById(Guid totalAnnualizedCostId);
        TotalAnnualizedCostDto GetTotalAnnualizedCostByProjectId(Guid projectId);
        void UpdateTotalAnnualizedCost(TotalAnnualizedCostDto totalAnnualizedCostDto);
        void DeleteTotalAnnualizedCost(Guid totalAnnualizedCostId);
        #endregion      // METHODS
    }
    #endregion      // public interface ITotalAnnualizedCostRepo
}
#endregion      // namespace HenModel.RepoInterfaces.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
