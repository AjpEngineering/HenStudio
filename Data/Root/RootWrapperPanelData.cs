#region HEADER
//#####################################################################################################################
//##################################  R o o t W r a p p e r P a n e l D a t a . c s  ##################################
//#####################################################################################################################
//  FILENAME:  RootWrapperPanelData.cs
//  NAMESPACE: HenStudio.Data.Root
//  CLASS(S):  RootWrapperPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the Data class for the Root Wrapper Panel Data Object.
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

#region HEN STUDIO REFERENCES
using HenModel.Dto.Project;
using HenModel.Dto.Project.CostParameters;
using HenModel.Dto.Project.DefaultParameters;
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

using HenViewModel.Project;
using HenViewModel.Project.CostParameters;
using HenViewModel.Project.DefaultParameters;
using HenViewModel.Project.DefaultParameters.ExchangerParams;
using HenViewModel.Project.DefaultParameters.OptimizerParams;
using HenViewModel.Project.DefaultParameters.ProjectUnits;

using HenStudio.Data.Project;
using HenStudio.Data.Project.CostParameters;
using HenStudio.Data.Project.DefaultParameters;
using HenStudio.Data.Project.DefaultParameters.ExchangerParams;
using HenStudio.Data.Project.DefaultParameters.OptimizerParams;
using HenStudio.Data.Project.DefaultParameters.ProjectUnits;
#endregion  // HEN STUDIO REFERENCES

using System;

using HenGlobal;

using HenViewModel.Application;

//using HenStudio.Data.Root.About;
using HenStudio.Data.Root.Database;
using HenStudio.Data.Root.FactorySettings;
using HenStudio.Data.Root.License;
#endregion      // REFERENCES

#region HenStudio.Data.Root
namespace HenStudio.Data.Root
{
    #region public class RootWrapperPanelData
    /// <summary>
    /// Root Wrapper Data Class
    /// </summary>
    public class RootWrapperPanelData
    {
        #region PROPERTIES
        public HenSettings HenSettingsObj { get; set; }

        #region PanelData Objects
        //------------------------------------------------ FACTORY SETTINGS ---
        public AppMetadataPanelData AppMetadataPanelDataObj { get; set; }
        public AppComponentsPanelData AppComponentsPanelDataObj { get; set; }
        public AppSettingsPanelData AppSettingsPanelDataObj { get; set; }

        //-------------------------------------------------------- DATABASE ---
        public DatabaseTablesPanelData DatabaseTablesPanelDataObj { get; set; }
        public DatabaseConnectionPanelData DatabaseConnectionPanelDataObj { get; set; }

        //--------------------------------------------------------- LICENSE ---
        public LicenseScorecardPanelData LicenseScorecardPanelDataObj { get; set; }
        public DeviceUserPanelData DeviceUserPanelDataObj { get; set; }
        public SummaryPanelData SummaryPanelDataObj { get; set; }

        public LicenseFilePanelData LicenseFilePanelDataObj { get; set; }

        #endregion      // PanelData Objects

        #region VIEW MODEL Objects
        public ApplicationViewModel ApplicationViewModelObj { get; set; }
        #endregion  //  VIEW MODEL Objects

        #endregion      // PROPERTIES

        #region InitializeWrapperData()
        /// <summary>
        /// Initialize the Root Wrapper Data Object with Default Values 
        /// to Avoid Null Reference Exceptions.
        /// </summary>
        private void InitializeWrapperData()
        {

            //-----------------------------------------------------------------------
            //--- Initialize PanelData Objects to Avoid Null Reference Exceptions ---
            //-----------------------------------------------------------------------
            AppMetadataPanelDataObj = new AppMetadataPanelData();
            AppComponentsPanelDataObj = new AppComponentsPanelData();
            AppSettingsPanelDataObj = new AppSettingsPanelData();

            DatabaseTablesPanelDataObj = new DatabaseTablesPanelData();
            DatabaseConnectionPanelDataObj = new DatabaseConnectionPanelData();

            LicenseScorecardPanelDataObj = new LicenseScorecardPanelData(HenSettingsObj);
            DeviceUserPanelDataObj = new DeviceUserPanelData();
            SummaryPanelDataObj = new SummaryPanelData(HenSettingsObj);

            LicenseFilePanelDataObj = new LicenseFilePanelData(HenSettingsObj);

            //-----------------------------------------------------------------------
            //--- Initialize ViewModel Objects to Avoid Null Reference Exceptions ---
            //-----------------------------------------------------------------------
            ApplicationViewModelObj = new ApplicationViewModel();
        }
        #endregion  // InitializeWrapperData()

        #region Default CTOR
        /// <summary>
        /// Default Constructor for RootWrapperData Class
        /// </summary>
        public RootWrapperPanelData(HenSettings henSettingsObj)
        {
            //-----------------------------------------------------------
            // --- Initialize the Root Wrapper Data Object with       ---
            // --- Default Values to Avoid Null Reference Exceptions. ---
            //-----------------------------------------------------------
            HenSettingsObj = henSettingsObj;
            InitializeWrapperData();
        }
        #endregion  // Default CTOR

        #region LoadRootWrapperData()
        public void LoadRootWrapperData()
        {
            //------------------------------------
            //--- Load ALL ROOT Sub Panel Data ---
            //------------------------------------
            AppMetadataPanelDataObj.LoadAppMetadataData();
            AppComponentsPanelDataObj.LoadAppComponentsData();
            AppSettingsPanelDataObj.LoadAppSettingsData();

            DatabaseTablesPanelDataObj.LoadDatabaseTablesData();
            DatabaseConnectionPanelDataObj.LoadAppDatabaseConnectionData();

            LicenseScorecardPanelDataObj.LoadScoreCardData();
            DeviceUserPanelDataObj.LoadDeviceUserData();
            SummaryPanelDataObj.LoadSummaryData();

            LicenseFilePanelDataObj.LoadLicenseFileData();
        }
        #endregion  // LoadRootWrapperData()
    }
        #endregion      // public class RootWrapperPanelData
}
#endregion      // namespace HenStudio.Data.Root

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
