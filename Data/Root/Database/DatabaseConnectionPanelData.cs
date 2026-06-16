#region HEADER
//#####################################################################################################################
//##########################  D a t a b a s e C o n n e c t i o n P a n e l D a t a . c s  ############################
//#####################################################################################################################
//  FILENAME:  DatabaseConnectionPanelData.cs
//  NAMESPACE: HenStudio.Data.Root.Database
//  CLASS(S):  DatabaseConnectionPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Database Connection Panel Data object -
//    data needed for Database Connection Panel.
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Root.Database
namespace HenStudio.Data.Root.Database
{
    #region public class DatabaseConnectionPanelData
    public class DatabaseConnectionPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Root.Database";
        const string CLASS = "DatabaseConnectionPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public ApplicationViewModel SystemViewModelObj { get; set; }

        public ConnectionDataDto ConnectionDataDtoObj { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for DatabaseConnectionPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public DatabaseConnectionPanelData()
        {
            SystemViewModelObj = new ApplicationViewModel();
            ConnectionDataDtoObj = new ConnectionDataDto();
        }
        #endregion  // CTOR

        #region LoadDatabaseConnectionData()
        /// <summary>
        /// Loads the database connection data from the SystemViewModel
        /// and populates the ConnectionDataDtoObj property.
        /// </summary>
        public void LoadDatabaseConnectionData()
        {
            //-------------------------------------
            //--- Load Database Connection Data ---
            //-------------------------------------
            ConnectionDataDtoObj = SystemViewModelObj.GetDatabaseConnectionData();
        }
        #endregion  // LoadDatabaseConnectionData()

    }
    #endregion      // public class DatabaseTablesPanelData     
}
#endregion  // namespace HenStudio.Data.Root.Database

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
