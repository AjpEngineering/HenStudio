#region HEADER
//#####################################################################################################################
//###########################  H e a t T r a n s f e r C o e f f V i e w M o d e l . c s  #############################
//#####################################################################################################################
//  FILENAME:  HeatTransferCoeffViewModel.cs
//  NAMESPACE: HenViewModel.Project.DefaultParameters.ExchangerParams
//  CLASS(S):  HeatTransferCoeffViewModel
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Heat Transfer Coefficient Panel Data object -
//    data needed for Heat Transfer Coefficient Panel.
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

using HenModel.Dto.Project.DefaultParameters.ExchangerParams;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenViewModel.Project.DefaultParameters.ExchangerParams
namespace HenViewModel.Project.DefaultParameters.ExchangerParams
{
    #region public class HeatTransferCoeffViewModel
    public class HeatTransferCoeffViewModel
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project.DefaultParameters.ExchangerParams";
        const string CLASS = "HeatTransferCoeffPanelData";
        #endregion      // CONSTANTS

        #region CONSTANTS HEAT TRANSFER COEFFICIENT UNITS STRINGS
        const string ENGLISH_HEAT_TRANSFER_COEFF_UNITS = "Btu/(hr·ft²·°F )";
        const string METRIC_HEAT_TRANSFER_COEFF_UNITS  = "W/(m²·K)";
        #endregion      // CONSTANTS HEAT TRANSFER COEFFICIENT UNITS STRINGS

        #region PROPERTIES
        public bool EnglishUnitsFlag { get; set; }
        public string ProjectHeatTransferCoeffUnits { get; set; }
        public List<HeatTransferCoeffDto> HeatTransferCoeffDtoList { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// CTOR - initializes the Heat Transfer Coefficient ViewModel object 
        /// and loads the table data based on project units.
        /// </summary>
        /// <param name="projectUnits">The EXTERNAL units used in the project.</param>
        public HeatTransferCoeffViewModel(string projectSystemUnits)
        {
            EnglishUnitsFlag = string.Compare(projectSystemUnits, 
                                              HenProjectUnits.ENGLISH_UNITS, true) == 0;

            //----------------------------------------------------------------------------
            //--- Assign Heat Transfer Coefficient Units string based on project units ---
            //----------------------------------------------------------------------------
            if (EnglishUnitsFlag) ProjectHeatTransferCoeffUnits = ENGLISH_HEAT_TRANSFER_COEFF_UNITS;
            else ProjectHeatTransferCoeffUnits = METRIC_HEAT_TRANSFER_COEFF_UNITS;

            //------------------------------------------------------------------------------------------
            //--- Load the table data for the Heat Transfer Coefficient Panel based on project units ---
            //------------------------------------------------------------------------------------------
            LoadTable();
        }
        #endregion  // CTOR

        #region LoadTable()
        /// <summary>
        /// Loads the table data for the Heat Transfer Coefficient Panel based on the project units.
        /// </summary>
        private void LoadTable()
        {
            HeatTransferCoeffDtoList = new List<HeatTransferCoeffDto>();
            HeatTransferCoeffDto row = new HeatTransferCoeffDto();

            //-------------------------------------------------- ROW 01 ---
            row.Id = "01";
            row.Service = "Gas-Gas";
            if (EnglishUnitsFlag) row.Range = "1 - 10";
            else row.Range = "5 - 50";
            row.Note = "Gas-side dominates; low h";
            HeatTransferCoeffDtoList.Add(row);
            //-------------------------------------------------- ROW 02 ---
            row.Id = "02";
            row.Service = "Gas-Liquid";
            if (EnglishUnitsFlag) row.Range = "10 - 100";
            else row.Range = "50 - 500";
            row.Note = "Cooling water or light oils";
            HeatTransferCoeffDtoList.Add(row);
            //-------------------------------------------------- ROW 03 ---
            row.Id = "03";
            row.Service = "Liquid-Liquid - clean";
            if (EnglishUnitsFlag) row.Range = "100 - 500";
            else row.Range = "500 - 2500";
            row.Note = "Non-viscous, low fouling";
            HeatTransferCoeffDtoList.Add(row);
            //-------------------------------------------------- ROW 04 ---
            row.Id = "04";
            row.Service = "Liquid-Liquid - dirty";
            if (EnglishUnitsFlag) row.Range = "40 - 200";
            else row.Range = "200 - 1000";
            row.Note = "Heavy oils, slurries - viscous / fouling";
            HeatTransferCoeffDtoList.Add(row);
            //-------------------------------------------------- ROW 05 ---
            row.Id = "05";
            row.Service = "Condensing Vapor - film condensation";
            if (EnglishUnitsFlag) row.Range = "200 - 1500";
            else row.Range = "1000 - 8000";
            row.Note = "Shell-side condensation common";
            HeatTransferCoeffDtoList.Add(row);
            //-------------------------------------------------- ROW 06 ---
            row.Id = "06";
            row.Service = "Boiling - flow or pool";
            if (EnglishUnitsFlag) row.Range = "200 - 2000";
            else row.Range = "1000 - 10000";
            row.Note = "Thermosyphon or kettle";
            HeatTransferCoeffDtoList.Add(row);
            //-------------------------------------------------- ROW 07 ---
            row.Id = "07";
            row.Service = "Reboiler - Kettle";
            if (EnglishUnitsFlag) row.Range = "200 - 1000";
            else row.Range = "1000 - 5000";
            row.Note = "Depends on boiling regime";
            HeatTransferCoeffDtoList.Add(row);
            //-------------------------------------------------- ROW 08 ---
            row.Id = "08";
            row.Service = "Reboiler - Thermosyphon";
            if (EnglishUnitsFlag) row.Range = "300 - 2000";
            else row.Range = "1500 - 10000";
            row.Note = "Higher velocities";
            HeatTransferCoeffDtoList.Add(row);
            //-------------------------------------------------- ROW 09 ---
            row.Id = "09";
            row.Service = "Condenser - Shell & Tube";
            if (EnglishUnitsFlag) row.Range = "200 - 1500";
            else row.Range = "1000 - 8000";
            row.Note = "Hydrocarbon or steam";
            HeatTransferCoeffDtoList.Add(row);
            //-------------------------------------------------- ROW 10 ---
            row.Id = "10";
            row.Service = "Sensible Liquid Heating / Cooling";
            if (EnglishUnitsFlag) row.Range = "60 - 300";
            else row.Range = "300 - 1500";
            row.Note = "Water, glycols, oils";
            HeatTransferCoeffDtoList.Add(row);
            //-------------------------------------------------- ROW 11 ---
            row.Id = "11";
            row.Service = "Sensible Gas Heating / Cooling";
            if (EnglishUnitsFlag) row.Range = "2 - 20";
            else row.Range = "10 - 100";
            row.Note = "Air, flue gas";
            HeatTransferCoeffDtoList.Add(row);
        }
        #endregion      // LoadTable()
    }
    #endregion      // public class HeatTransferCoeffViewModel
}
#endregion  // namespace HenViewModel.Project.DefaultParameters.ExchangerParams

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
