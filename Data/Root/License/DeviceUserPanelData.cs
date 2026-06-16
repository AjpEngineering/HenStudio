#region HEADER
//#####################################################################################################################
//##################################  D e v i c e U s e r P a n e l D a t a . c s  ####################################
//#####################################################################################################################
//  FILENAME:  DeviceUserPanelData.cs
//  NAMESPACE: HenStudio.Data.Root.License
//  CLASS(S):  DeviceUserPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Device-User Panel Data object -
//    data needed for Device-User Panel.
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
using AJP_License_File;

using HenGlobal;

using HenModel.Dto.Application;

using HenViewModel.Application;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Root.License
namespace HenStudio.Data.Root.License
{
    #region public class DeviceUserPanelData
    public class DeviceUserPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Root.License";
        const string CLASS = "DeviceUserPanelDataObj";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public string Device { get; set; }
        public string User { get; set; }
        public string Fullname { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for DeviceUserPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public DeviceUserPanelData()
        {
            Device = string.Empty;
            User = string.Empty;
            Fullname = string.Empty;
        }
        #endregion  // CTOR

        #region LoadDeviceUserData()
        /// <summary>
        /// Loads the Device-User data.
        /// </summary>
        public void LoadDeviceUserData()
        {
            //-----------------------------
            //--- Load Device-User Data ---
            //-----------------------------
            Device = Environment.MachineName;        // Maximum Lenght 15 characters
            User = WindowsIdentity.GetCurrent().Name;
            Fullname = User;

        }
        #endregion  // LoadDeviceUserData()
    }
    #endregion      // public class DeviceUserPanelData     
}
#endregion  // namespace HenStudio.Data.Root.License

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
