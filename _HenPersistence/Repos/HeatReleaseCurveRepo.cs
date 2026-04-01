#region HEADER
//#####################################################################################################################
//###################################  H e a t R e l e a s e C u r v e R e p o . c s  ################################
//#####################################################################################################################
//  FILENAME:  HeatReleaseCurveRepo.cs
//  NAMESPACE: HenPersistence.Repos
//  CLASS(S):  HeatReleaseCurveRepo
//  COMPONENT: _HenPersistence.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the HeatReleaseCurve Hen sub table.
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
using HenRepositories.Interfaces;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenPersistence.Repos
namespace HenPersistence.Repos
{
    #region public class HeatReleaseCurveRepo
    /// <summary>
    /// HeatReleaseCurve Repo Class
    /// </summary>
    public class HeatReleaseCurveRepo : IHeatReleaseCurveRepo
    {
        #region METHODS
        public IList<HeatReleaseCurveDto> GetHeatReleaseCurves()
        {
            throw new NotImplementedException();
        }

        public IList<HeatReleaseCurveDto> GetHeatReleaseCurvesByExchangerId(Guid exchangerId)
        {
            throw new NotImplementedException();
        }

        public HeatReleaseCurveDto GetHeatReleaseCurveById(Guid heatReleaseCurveId)
        {
            throw new NotImplementedException();
        }

        public HeatReleaseCurveDto GetHeatReleaseCurveByTitle(Guid exchangerId, string title)
        {
            throw new NotImplementedException();
        }

        public Guid AddHeatReleaseCurve(HeatReleaseCurveDto heatReleaseCurveDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateHeatReleaseCurve(HeatReleaseCurveDto heatReleaseCurveDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteHeatReleaseCurve(Guid heatReleaseCurveId)
        {
            throw new NotImplementedException();
        }
        #endregion      // METHODS
    }
    #endregion      // public class HeatReleaseCurveRepo
}
#endregion      // namespace HenPersistence.Repos

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
