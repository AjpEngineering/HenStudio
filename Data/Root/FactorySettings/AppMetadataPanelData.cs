#region HEADER
//#####################################################################################################################
//#################################  A p p M e t a d a t a P a n e l D a t a . c s  ###################################
//#####################################################################################################################
//  FILENAME:  AppMetadataPanelData.cs
//  NAMESPACE: HenStudio.Data.Root.FactorySettings
//  CLASS(S):  AppMetadataPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the App Metadata Panel Data object - data needed for App Metadata Panel.
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
    #region public class AppMetadataPanelData
    public class AppMetadataPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Root.FactorySettings";
        const string CLASS = "AppMetadataPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public string ProductFullname { get; set; }
        public string ProductName { get; set; }
        public string ProductVersion { get; set; }
        public string ProductSerialNumber { get; set; }
        public string ProductCode { get; set; }
        public string SupplierName { get; set; }
        public string SupplierUrl { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for AppMetadataPanelData. 
        /// Initializes all properties to their default HenSettings values.
        /// </summary>
        public AppMetadataPanelData()
        {
            ProductFullname = string.Empty;
            ProductName = string.Empty;
            ProductVersion = string.Empty;
            ProductSerialNumber = string.Empty;
            ProductCode = string.Empty;
            SupplierName = string.Empty;
            SupplierUrl = string.Empty;
        }
        #endregion  // CTOR

        #region LoadAppMetadataData()
        /// <summary>
        /// Loads the App Metadata Data properties with the values from HenSettings constants.
        /// </summary>
        public void LoadAppMetadataData()
        {
            ProductFullname = HenSettings.AJP_PRODUCT_FULLNAME;
            ProductName = HenSettings.AJP_PRODUCT_NAME;
            ProductVersion = HenSettings.AJP_PRODUCT_VERSION;
            ProductSerialNumber = HenSettings.AJP_PRODUCT_SERIAL_NUMBER;
            ProductCode = HenSettings.AJP_PRODUCT_CODE;
            SupplierName = HenSettings.AJP_SUPPLIER_NAME;
            SupplierUrl = HenSettings.AJP_SUPPLIER_URL;
        }
        #endregion  // LoadAppMetadataData()

    }
    #endregion      // public class AppMetadataPanelData
}
#endregion  // namespace HenStudio.Data.Root.FactorySettings

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
