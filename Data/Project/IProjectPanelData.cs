#region HEADER
//#####################################################################################################################
//#######################################  I P r o j e c t P a n e l D a t a . c s  ###################################
//#####################################################################################################################
//  FILENAME:  IProjectPanelData.cs
//  NAMESPACE: HenStudio.Data.Project
//  INTERFACE: IProjectPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the Project Panel interface for the Project top-level table.
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
using HenModel.Dto.Project;
using HenStudio.Data.Project;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenStudio.Data.Project
namespace HenStudio.Data.Project
{
    #region public interface IProjectPanelData
    /// <summary>
    /// Project Panel Interface
    /// </summary>
    public interface IProjectPanelData
    {
        #region METHODS
        ProjectPanelData ConvertToPanelData(ProjectDto projectDto);
        ProjectDto ConvertFromPanelData(ProjectPanelData projectPanelDataObj);
        #endregion      // METHODS
    }
    #endregion      // public interface IProjectPanelData
}
#endregion      // namespace HenStudio.Data.Project

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
