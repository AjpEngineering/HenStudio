#region HEADER
//#####################################################################################################################
//#####################################  S u m m a r y P a n e l D a t a . c s  #######################################
//#####################################################################################################################
//  FILENAME:  SummaryPanelData.cs
//  NAMESPACE: HenStudio.Data.Root.License
//  CLASS(S):  SummaryPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the License Scorecard Summary Panel Data object -
//    data needed for License Scorecard Summary Panel.
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

using HenModel.Dto.System;

using HenViewModel.System;

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
    #region public class SummaryPanelData
    public class SummaryPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Root.License";
        const string CLASS = "SummaryPanelDataObj";
        #endregion      // CONSTANTS

        #region PROPERTIES
        HenSettings HenSettingsObj { get; set; }
        public ScoreCardList ScoreCardListObj { get; set; }
        public int NumValidProps { get; set; }
        public int NumInvalidProps { get; set; }
        public string ValidState { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for SummaryPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public SummaryPanelData(HenSettings henSettingsObj)
        {
            HenSettingsObj = henSettingsObj;
            ScoreCardListObj = new ScoreCardList();

            NumValidProps = 0;
            NumInvalidProps = 0;
            ValidState = string.Empty;
        }
        #endregion  // CTOR

        #region LoadSummaryData()
        /// <summary>
        /// Loads the summary data.
        /// </summary>
        public void LoadSummaryData()
        {
            //-------------------------
            //--- Load Summary Data ---
            //-------------------------
            NumValidProps = HenSettingsObj.ScoreCardListObj.NumValidProps;
            NumInvalidProps = HenSettingsObj.ScoreCardListObj.NumInvalidProps;

            if (NumInvalidProps > 0)
            {
                ValidState = "INVALID LICENSE";
                HenSettingsObj.LicenseStatusEnum = HenTypes.LicenseStatus.INVALID;
            }
            else
            {
                ValidState = "VALID LICENSE";
                HenSettingsObj.LicenseStatusEnum = HenTypes.LicenseStatus.VALID;
            }
        }
        #endregion  // LoadSummaryData()
    }
    #endregion      // public class SummaryPanelData     
}
#endregion  // namespace HenStudio.Data.Root.License

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
