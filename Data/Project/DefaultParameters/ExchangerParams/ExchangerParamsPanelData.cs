#region HEADER
//#####################################################################################################################
//#############################  E x c h a n g e r P a r a m s P a n e l D a t a . c s  ###############################
//#####################################################################################################################
//  FILENAME:  ExchangerParamsPanelData.cs
//  NAMESPACE: HenStudio.Data.Project.DefaultParameters.ExchangerParams
//  CLASS(S):  ExchangerParamsPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Exchanger Params Panel Data object - data needed for Exchanger Params Panel.
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
//    01/01/26 .. pg .. Version 4.0
//#####################################################################################################################
//#####################################################################################################################
//#####################################################################################################################
#endregion      // HEADER

#region REFERENCES
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Project.DefaultParameters.ExchangerParams
namespace HenStudio.Data.Project.DefaultParameters.ExchangerParams
{
    #region public class ExchangerParamsPanelData
    public class ExchangerParamsPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.DefaultParameters.ExchangerParams";
        const string CLASS = "ExchangerParamsPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public ExchangerParamsDto ExchangerParamsDtoObj { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        public ExchangerParamsPanelData()
        {
            Id = new Guid();
            ProjectId = new Guid();
            ExchangerParamsDtoObj = new ExchangerParamsDto();
        }
        #endregion  // CTOR

    }
    #endregion      // public class ExchangerParamsPanelData
}
#endregion  // namespace HenStudio.Data.Project.DefaultParameters.ExchangerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
