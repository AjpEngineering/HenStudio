#region HEADER
//#####################################################################################################################
//##################################  A p p G l o b a l S e t t i n g s D t o . c s  ##################################
//#####################################################################################################################
//  FILENAME:  AppGlobalSettingsDto.cs
//  NAMESPACE: HenRepositories.Dto
//  CLASS(S):  AppGlobalSettingsDto
//  COMPONENT: _HenRepositories.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the DTO class for the Application Global Settings object.
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion      // REFERENCES

#region namespace HenRepositories.Dto
namespace HenRepositories.Dto
{
    #region public class AppGlobalSettingsDto
    /// <summary>
    /// GlobalSettings DTO Class
    /// </summary>
    public class AppGlobalSettingsDto
    {
        #region PROPERTIES
        public DateTime DatabaseCreatedOn { get; set; }
        public double DefaultApproachTemperature { get; set; }
        public double DefaultEnglishU { get; set; }
        public double DefaultMetricU { get; set; }
        public string DefaultOptimizer { get; set; }
        public bool EnableAreaEstimation { get; set; }
        public string ExternalMagnitudeUnits { get; set; }
        public string ExternalPressUnits { get; set; }
        public string ExternalSystemUnits { get; set; }
        public string ExternalTempUnits { get; set; }
        public string ExternalUnitsA { get; set; }
        public string ExternalUnitsEnergy { get; set; }
        public string ExternalUnitsHeatCapacityFlowRate { get; set; }
        public string ExternalUnitsMassFlowrate { get; set; }
        public string ExternalUnitsSpecificHeatCapacity { get; set; }
        public string ExternalUnitsU { get; set; }
        public string InternalMagnitudeUnits { get; set; }
        public string InternalPressUnits { get; set; }
        public string InternalSystemUnits { get; set; }
        public string InternalTempUnits { get; set; }
        public string InternalUnitsA { get; set; }
        public string InternalUnitsEnergy { get; set; }
        public string InternalUnitsHeatCapacityFlowRate { get; set; }
        public string InternalUnitsMassFlowrate { get; set; }
        public string InternalUnitsSpecificHeatCapacity { get; set; }
        public string InternalUnitsU { get; set; }
        public string LastMigrationApplied { get; set; }
        public string ReportDefaultFont { get; set; }
        public bool ReportIncludeAuditSection { get; set; }
        public string ReportUnitsProfile { get; set; }
        public string SchemaVersion { get; set; }
        #endregion      // PROPERTIES
    }
    #endregion      // public class AppGlobalSettingsDto
}
#endregion      // namespace HenRepositories.Dto

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
