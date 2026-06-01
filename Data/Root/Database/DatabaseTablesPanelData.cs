#region HEADER
//#####################################################################################################################
//##############################  D a t a b a s e T a b l e s P a n e l D a t a . c s  ################################
//#####################################################################################################################
//  FILENAME:  DatabaseTablesPanelData.cs
//  NAMESPACE: HenStudio.Data.Root.Database
//  CLASS(S):  DatabaseTablesPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Database Tables Panel Data object - data needed for Database Tables Panel.
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

#region namespace HenStudio.Data.Root.Database
namespace HenStudio.Data.Root.Database
{
    #region public class DatabaseTablesPanelData
    public class DatabaseTablesPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Root.Database";
        const string CLASS = "DatabaseTablesPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public SystemViewModel SystemViewModelObj { get; set; }

        public IList<DatabaseTableDto> DatabaseTablesList { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default constructor for DatabaseTablesPanelData. 
        /// Initializes all properties to their default values.
        /// </summary>
        public DatabaseTablesPanelData()
        {
            SystemViewModelObj = new SystemViewModel();
            DatabaseTablesList = new List<DatabaseTableDto>();
        }
        #endregion  // CTOR

        #region LoadDatabaseTablesData()
        /// <summary>
        /// Loads the database tables data by calling the GetDatabaseTables() method of the 
        /// SystemViewModel object and assigns the result to the DatabaseTablesList property.
        /// </summary>
        public void LoadDatabaseTablesData()
        {
            //--------------------------------
            //--- Load Database Tables Data ---
            //--------------------------------
            DatabaseTablesList = SystemViewModelObj.GetDatabaseTables();
        }
        #endregion  // LoadDatabaseTablesData()

    }
    #endregion      // public class DatabaseTablesPanelData     
}
#endregion  // namespace HenStudio.Data.Root.Database

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
