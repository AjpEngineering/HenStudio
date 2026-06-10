#region HEADER
//#####################################################################################################################
//#####################################  I C o s t M e t a d a t a R e p o . c s  #####################################
//#####################################################################################################################
//  FILENAME:  ICostMetadataRepo.cs
//  NAMESPACE: HenModel.RepoInterfaces.Project.CostParameters
//  INTERFACE: ICostMetadataRepo
//  COMPONENT: _HenModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the CostMetadata Profile sub table.
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
    #region public interface ICostMetadataRepo
    /// <summary>
    /// Cost Metadata Repo Interface
    /// </summary>
    public interface ICostMetadataRepo
    {
        #region METHODS
        Guid AddCostMetadata(CostMetadataDto costMetadataDto);
        IList<CostMetadataDto> GetCostMetadata();
        CostMetadataDto GetCostMetadataById(Guid costMetadataId);
        CostMetadataDto GetCostMetadataByProjectId(Guid projectId);
        void UpdateCostMetadata(CostMetadataDto costMetadataDto);
        void DeleteCostMetadata(Guid costMetadataId);
        #endregion      // METHODS
    }
    #endregion      // public interface ICostMetadataRepo
}
#endregion      // namespace HenModel.RepoInterfaces.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
