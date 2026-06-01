#region HEADER
//#####################################################################################################################
//#################################  A p p S e t t i n g s P a n e l D a t a . c s  ###################################
//#####################################################################################################################
//  FILENAME:  AppSettingsPanelData.cs
//  NAMESPACE: HenStudio.Data.Root.FactorySettings
//  CLASS(S):  AppSettingsPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the App Settings Panel Data object - data needed for App Settings Panel.
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Root.FactorySettings
namespace HenStudio.Data.Root.FactorySettings
{
    #region public class AppSettingsPanelData
    public class AppSettingsPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Root.FactorySettings";
        const string CLASS = "AppSettingsPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public SystemViewModel SystemViewModelObj { get; set; }

        public AppGlobalSettingsDto AppGlobalSettingsList { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for AppSettingsPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public AppSettingsPanelData()
        {
            SystemViewModelObj = new SystemViewModel();
            AppGlobalSettingsList = new AppGlobalSettingsDto();
        }
        #endregion  // CTOR

        #region LoadAppSettingsData()
        /// <summary>
        /// Loads the app settings data by calling the GetAppGlobalSettings() method of the
        /// SystemViewModel object and assigns the result to the AppGlobalSettingsList property.
        /// </summary>
        public void LoadAppSettingsData()
        {
            //--------------------------------
            //--- Load App Global Settings ---
            //--------------------------------
            AppGlobalSettingsList = SystemViewModelObj.GetAppGlobalSettings();
        }
        #endregion  // LoadAppSettingsData()

    }
    #endregion      // public class     
}
#endregion  // namespace HenStudio.Data.Root.FactorySettings

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
