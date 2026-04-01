#region HEADER
//#####################################################################################################################
//##########################################  T H D i a g r a m R e p o . c s  ########################################
//#####################################################################################################################
//  FILENAME:  THDiagramRepo.cs
//  NAMESPACE: HenPersistence.Repos
//  CLASS(S):  THDiagramRepo
//  COMPONENT: _HenPersistence.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the concrete repo implementation stub for the THDiagram Profile sub table.
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
    #region public class THDiagramRepo
    /// <summary>
    /// THDiagram Repo Class
    /// </summary>
    public class THDiagramRepo : ITHDiagramRepo
    {
        #region METHODS
        public IList<THDiagramDto> GetTHDiagrams()
        {
            throw new NotImplementedException();
        }

        public IList<THDiagramDto> GetTHDiagramsByProfileId(Guid profileId)
        {
            throw new NotImplementedException();
        }

        public THDiagramDto GetTHDiagramById(Guid thDiagramId)
        {
            throw new NotImplementedException();
        }

        public THDiagramDto GetTHDiagramByTitle(Guid profileId, string title)
        {
            throw new NotImplementedException();
        }

        public Guid AddTHDiagram(THDiagramDto thDiagramDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateTHDiagram(THDiagramDto thDiagramDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteTHDiagram(Guid thDiagramId)
        {
            throw new NotImplementedException();
        }
        #endregion      // METHODS
    }
    #endregion      // public class THDiagramRepo
}
#endregion      // namespace HenPersistence.Repos

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
