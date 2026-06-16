#region HEADER
//#####################################################################################################################
//##################################  L i c e n s e F i l e P a n e l D a t a . c s  ##################################
//#####################################################################################################################
//  FILENAME:  LicenseFilePanelData.cs
//  NAMESPACE: HenStudio.Data.Root.License
//  CLASS(S):  LicenseFilePanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the License File Panel Data object -
//    data needed for License File Panel.
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
    #region public class LicenseFilePanelData
    public class LicenseFilePanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Root.License";
        const string CLASS = "LicenseFilePanelDataObj";
        #endregion      // CONSTANTS

        #region PROPERTIES
        HenSettings HenSettingsObj { get; set; }

        public string Author { get; set; }
        
        public string SupplierName { get; set; }
        public string SupplierUrl { get; set; }
        
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }

        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string SerialNumber { get; set; }

        public string LicenseType { get; set; }
        public string LicenseUser { get; set; }
        public string LicenseDevice { get; set; }

        public string Corporation { get; set; }
        public string Division { get; set; }
        public string Group { get; set; }

        public string LicenseKey { get; set; }
        public string LicenseHash { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Duration { get; set; }

        public int DaysRemaining { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for SummaryPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public LicenseFilePanelData(HenSettings henSettingsObj)
        {
            HenSettingsObj = henSettingsObj;

            Author = string.Empty;
            SupplierName = string.Empty;
            SupplierUrl = string.Empty;

            CustomerName = string.Empty;
            CustomerEmail = string.Empty;

            ProductName = string.Empty;
            ProductCode = string.Empty;
            SerialNumber = string.Empty;

            LicenseType = string.Empty;
            LicenseUser = string.Empty;
            LicenseDevice = string.Empty;

            Corporation = string.Empty;
            Division = string.Empty;
            Group = string.Empty;

            LicenseKey = string.Empty;
            LicenseHash = string.Empty;

            StartDate = DateTime.Now;
            EndDate = DateTime.Now;

            Duration = 365;
            DaysRemaining = 365;
        }
        #endregion  // CTOR

        #region LoadLicenseFileData()
        /// <summary>
        /// Loads the license file data.
        /// </summary>
        public void LoadLicenseFileData()
        {
            //------------------------------
            //--- Load License File Data ---
            //------------------------------
            Author = HenSettingsObj.LicenseFileDtoObj.Author;
            SupplierName = HenSettingsObj.LicenseFileDtoObj.SupplierName;
            SupplierUrl = HenSettingsObj.LicenseFileDtoObj.SupplierUrl;

            CustomerName = HenSettingsObj.LicenseFileDtoObj.CustomerName;
            CustomerEmail = HenSettingsObj.LicenseFileDtoObj.CustomerEmail;

            ProductName = HenSettingsObj.LicenseFileDtoObj.ProductName;
            ProductCode = HenSettingsObj.LicenseFileDtoObj.ProductCode;
            SerialNumber = HenSettingsObj.LicenseFileDtoObj.SerialNumber;

            LicenseType = HenSettingsObj.LicenseFileDtoObj.LicenseType;
            LicenseUser = HenSettingsObj.LicenseFileDtoObj.UserName;
            LicenseDevice = HenSettingsObj.LicenseFileDtoObj.DeviceName;

            Corporation = HenSettingsObj.LicenseFileDtoObj.Corporation;
            Division = HenSettingsObj.LicenseFileDtoObj.Division;
            Group = HenSettingsObj.LicenseFileDtoObj.Group;

            LicenseKey = HenSettingsObj.LicenseFileDtoObj.FileLicenseKey;
            LicenseHash = HenSettingsObj.LicenseFileDtoObj.FileHash;

            StartDate = HenSettingsObj.LicenseFileDtoObj.StartDate;
            EndDate = HenSettingsObj.LicenseFileDtoObj.EndDate;

            Duration = HenSettingsObj.LicenseFileDtoObj.DurationDays;
            DaysRemaining = HenSettingsObj.LicenseFileDtoObj.RemainingDays;

            //-----------------------------------------------------------------------------------
            //--- Calculate the Remainging Days Left on the AJP License ... Populate Property ---
            //-----------------------------------------------------------------------------------
            DateTime dt = DateTime.Now;
            TimeSpan span = EndDate.Subtract(dt);
            DaysRemaining = Convert.ToInt32(span.TotalDays);
        }
        #endregion  // LoadLicenseFileData()
    }
    #endregion      // public class LicenseFilePanelData     
}
#endregion  // namespace HenStudio.Data.Root.License

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
