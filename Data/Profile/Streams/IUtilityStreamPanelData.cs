#region HEADER
//#####################################################################################################################
//#################################  I U t i l i t y S t r e a m P a n e l D a t a . c s  #############################
//#####################################################################################################################
//  FILENAME:  IUtilityStreamPanelData.cs
//  NAMESPACE: HenStudio.Data.Profile.Streams
//  INTERFACE: IUtilityStreamPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the Utility Stream Panel interface for the Utility Stream top-level table.
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
using HenModel.Dto.Profile.Streams;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenStudio.Data.Profile.Streams
namespace HenStudio.Data.Profile.Streams
{
    #region public interface IUtilityStreamPanelData
    /// <summary>
    /// Utility Stream Panel Interface
    /// </summary>
    public interface IUtilityStreamPanelData
    {
        #region METHODS
        UtilityStreamPanelData ConvertToPanelData(UtilityStreamDto profileDto);
        UtilityStreamDto ConvertFromPanelData();
        #endregion      // METHODS
    }
    #endregion      // public interface IUtilityStreamPanelData
}
#endregion      // namespace HenStudio.Data.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
