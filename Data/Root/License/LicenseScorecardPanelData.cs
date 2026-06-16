#region HEADER
//#####################################################################################################################
//############################  L i c e n s e S c o r e c a r d P a n e l D a t a . c s  ##############################
//#####################################################################################################################
//  FILENAME:  LicenseScorecardPanelData.cs
//  NAMESPACE: HenStudio.Data.Root.License
//  CLASS(S):  LicenseScorecardPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the License Scorecard Panel Data object -
//    data needed for License Scorecard Panel.
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
using HenGlobal;

using HenModel.Dto.Application;

using HenViewModel.Application;

using AJP_License_File;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Root.License
namespace HenStudio.Data.Root.License
{
    #region public class LicenseScorecardPanelData
    public class LicenseScorecardPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Root.License";
        const string CLASS = "LicenseScorecardPanelDataObj";
        #endregion      // CONSTANTS

        #region PROPERTIES
        HenSettings HenSettingsObj { get; set; }
        public ScoreCardList ScoreCardListObj { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for LicenseScorecardPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public LicenseScorecardPanelData(HenSettings henSettingsObj)
        {
            HenSettingsObj = henSettingsObj;
            ScoreCardListObj = new ScoreCardList();
        }
        #endregion  // CTOR

        #region LoadScoreCardData()
        /// <summary>
        /// Loads the scorecard data.
        /// </summary>
        public void LoadScoreCardData()
        {
            //--------------------------------
            //--- Load ScoreCard Data ---
            //--------------------------------
            ScoreCardListObj = HenSettingsObj.ScoreCardListObj;
        }
        #endregion  // LoadScoreCardData()
    }
    #endregion      // public class LicenseScorecardPanelData     
}
#endregion  // namespace HenStudio.Data.Root.License

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
