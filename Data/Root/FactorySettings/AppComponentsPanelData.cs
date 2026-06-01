#region HEADER
//#####################################################################################################################
//###############################  A p p C o m p o n e n t s P a n e l D a t a . c s  #################################
//#####################################################################################################################
//  FILENAME:  AppComponentsPanelData.cs
//  NAMESPACE: HenStudio.Data.Root.FactorySettings
//  CLASS(S):  AppComponentsPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the App Components Panel Data object - data needed for App Components Panel.
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Root.FactorySettings
namespace HenStudio.Data.Root.FactorySettings
{
    #region public class AppComponentsPanelData
    public class AppComponentsPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Root.FactorySettings";
        const string CLASS = "AppComponentsPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public string AjpLicenseFile { get; set; }
        public string HenDomainModel { get; set; }
        public string HenGlobal { get; set; }
        public string HenModel { get; set; }
        public string HenStudioDatabase { get; set; }
        public string HenViewModel { get; set; }
        public string HenStudio { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for AppComponentsPanelData. 
        /// Initializes all properties to their default HenSettings values.
        /// </summary>
        public AppComponentsPanelData()
        {
            AjpLicenseFile = string.Empty;
            HenDomainModel = string.Empty;
            HenGlobal = string.Empty;
            HenModel = string.Empty;
            HenStudioDatabase = string.Empty;
            HenViewModel = string.Empty;
            HenStudio = string.Empty;
        }
        #endregion  // CTOR

        #region LoadAppComponentsData()
        /// <summary>
        /// Loads the App Components data from the HenSettings object into 
        /// the AppComponentsPanelData properties.
        /// </summary>
        public void LoadAppComponentsData()
        {
            HenSettings henSettingsObj = new HenSettings();

            AjpLicenseFile = henSettingsObj.AJP_HEN_COMPONENTS[0];
            HenDomainModel = henSettingsObj.AJP_HEN_COMPONENTS[1];
            HenGlobal = henSettingsObj.AJP_HEN_COMPONENTS[2];
            HenModel = henSettingsObj.AJP_HEN_COMPONENTS[3];
            HenStudioDatabase = henSettingsObj.AJP_HEN_COMPONENTS[4];
            HenViewModel = henSettingsObj.AJP_HEN_COMPONENTS[5];
            HenStudio = henSettingsObj.AJP_HEN_COMPONENTS[6];
        }
        #endregion  // LoadAppComponentsData()

    }
    #endregion      // public class AppComponentsPanelData
}
#endregion  // namespace HenStudio.Data.Root.FactorySettings

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
