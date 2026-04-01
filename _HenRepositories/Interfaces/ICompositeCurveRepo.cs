#region HEADER
//#####################################################################################################################
//##################################  I C o m p o s i t e C u r v e R e p o . c s  ####################################
//#####################################################################################################################
//  FILENAME:  ICompositeCurveRepo.cs
//  NAMESPACE: HenRepositories.Interfaces
//  INTERFACE: ICompositeCurveRepo
//  COMPONENT: _HenRepositories.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the repo interface for the CompositeCurve Pinch sub table.
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
    #region public interface ICompositeCurveRepo
    /// <summary>
    /// CompositeCurve Repo Interface
    /// </summary>
    public interface ICompositeCurveRepo
    {
        #region METHODS
        IList<CompositeCurveDto> GetCompositeCurves();
        IList<CompositeCurveDto> GetCompositeCurvesByPinchId(Guid pinchId);
        CompositeCurveDto GetCompositeCurveById(Guid compositeCurveId);
        CompositeCurveDto GetCompositeCurveByTitle(Guid pinchId, string title);
        Guid AddCompositeCurve(CompositeCurveDto compositeCurveDto);
        void UpdateCompositeCurve(CompositeCurveDto compositeCurveDto);
        void DeleteCompositeCurve(Guid compositeCurveId);
        #endregion      // METHODS
    }
    #endregion      // public interface ICompositeCurveRepo
}
#endregion      // namespace HenRepositories.Interfaces

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
