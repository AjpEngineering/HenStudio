#region HEADER
//#####################################################################################################################
//######################################  P r o j e c t V i e w D a t a . c s  ########################################
//#####################################################################################################################
//  FILENAME:  ProjectViewData.cs
//  NAMESPACE: HenStudio
//  CLASS(S):  ProjectViewData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Project View Data object - data needed for Project Panel.
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio
namespace HenStudio
{
    #region public class ProjectViewData
    public class ProjectViewData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio";
        const string CLASS = "ProjectViewData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProjectU_Value { get; set; }
        public string ProjectF_Value { get; set; }
        public string ProjectHenOptimizer { get; set; }
        public string ProjectSystem_Units { get; set; }
        public string ProjectMagnitude_Units { get; set; }
        public string ProjectTemperature_Units { get; set; }
        public string ProjectPressure_Units { get; set; }
        public string ProjectArea_Units { get; set; }
        public string ProjectDuty_Units { get; set; }
        public string ProjectCP_Units { get; set; }
        public string ProjectU_Units { get; set; }

        public DateTime ProjectCreationDate { get; set; }
        public DateTime ProjectModificationDate { get; set; }

        #endregion  // PROPERTIES

        #region CTOR
        public ProjectViewData()
        {
            Id = new Guid();
            Name = string.Empty; 
            Description = string.Empty;

            ProjectU_Value = "74.0";
            ProjectF_Value = "0.85";

            ProjectHenOptimizer = string.Empty;

            ProjectSystem_Units = string.Empty;
            ProjectMagnitude_Units = string.Empty;
            ProjectTemperature_Units = string.Empty;
            ProjectPressure_Units = string.Empty;
            ProjectArea_Units = string.Empty;
            ProjectDuty_Units = string.Empty;
            ProjectCP_Units = string.Empty;
            ProjectU_Units = string.Empty;

            ProjectCreationDate = DateTime.Now;
            ProjectModificationDate = DateTime.Now;
        }
        #endregion  // CTOR

    }
    #endregion      // public class ProjectViewData
}
#endregion  // namespace HenStudio

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
