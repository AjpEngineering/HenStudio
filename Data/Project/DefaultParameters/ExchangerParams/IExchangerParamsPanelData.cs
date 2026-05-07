#region HEADER
//#####################################################################################################################
//###############################  I E x c h a n g e r P a r a m s P a n e l D a t a . c s  ###########################
//#####################################################################################################################
//  FILENAME:  IExchangerParamsPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.DefaultParameters.ExchangerParams
//  INTERFACE: IExchangerParamsPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the Exchanger Params Panel interface for the Exchanger parameters.
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
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;
using HenStudio.Data.Project.DefaultParameters.ExchangerParams;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenStudio.Data.Project.DefaultParameters.ExchangerParams
namespace HenStudio.Data.Project.DefaultParameters.ExchangerParams
{
    #region public interface IExchangerParamsPanelData
    /// <summary>
    /// Exchanger Params Panel Interface
    /// </summary>
    public interface IExchangerParamsPanelData
    {
        #region METHODS
        ExchangerParamsPanelData ConvertToPanelData(ExchangerParamsDto exchangerParamsDto);
        ExchangerParamsDto ConvertFromPanelData();
        #endregion      // METHODS
    }
    #endregion      // public interface IExchangerParamsPanelData
}
#endregion      // namespace HenStudio.Data.Project.DefaultParameters.ExchangerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
