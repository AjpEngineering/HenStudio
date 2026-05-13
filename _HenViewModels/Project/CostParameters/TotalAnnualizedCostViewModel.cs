#region HEADER
//#####################################################################################################################
//########################  T o t a l   A n n u a l i z e d   C o s t   V i e w M o d e l . c s  ######################
//#####################################################################################################################
//  FILENAME:  TotalAnnualizedCostViewModel.cs
//  NAMESPACE: HenViewModel.Project.CostParameters
//  CLASS(S):  TotalAnnualizedCostViewModel
//  COMPONENT: _HenViewModel.dll
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the view model class for the Total Annualized Cost Parameters View Model.
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
using HenGlobal;

using HenModel.Connection;
using HenModel.Dto.Project.CostParameters;
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;
using HenModel.RepoImplementations.Project.CostParameters;

using System;
using System.Collections.Generic;
#endregion      // REFERENCES

#region namespace HenViewModel.Project.CostParameters
namespace HenViewModel.Project.CostParameters
{
    #region public class TotalAnnualizedCostViewModel
    /// <summary>
    /// Total Annualized Cost view model class.
    /// </summary>
    public class TotalAnnualizedCostViewModel : ViewModelBase
    {
        #region PROPERTIES
        public TotalAnnualizedCostRepo TotalAnnualizedCostRepoObj { get; set; }
        #endregion      // PROPERTIES

        #region CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public TotalAnnualizedCostViewModel()
        {
            var connFactoryObj = new SqlConnectionFactory(ConnectionStrings.HenStudio);
            var totalAnnualizedCostRepoObj = new TotalAnnualizedCostRepo(connFactoryObj);

            TotalAnnualizedCostRepoObj = totalAnnualizedCostRepoObj;
            ExternalUnitsObj = new HenProjectUnits();
            InternalUnitsObj = new HenProjectUnits();
        }
        #endregion  // CTOR

        #region TOTAL ANNUALIZED COST CRUD METHODS

        #region AddTotalAnnualizedCost(TotalAnnualizedCostDto totalAnnualizedCostDto) ... CREATE
        /// <summary>
        /// Adds (CREATE) a new total annualized cost to the database using the specified DTO.
        /// </summary>
        /// <param name="externalTotalAnnualizedCostDto">The total annualized cost data to add.</param>
        /// <returns>A GUID representing the unique identifier of the newly added total annualized cost.</returns>
        public Guid AddTotalAnnualizedCost(TotalAnnualizedCostDto externalTotalAnnualizedCostDto)
        {
            Guid totalAnnualizedCostId = new Guid();
            try
            {
                //----------------------------------------------------------------------------------
                //--- TotalAnnualizedCostDto Dto [INTERNAL Units] to be Added to the Database ---
                //----------------------------------------------------------------------------------
                TotalAnnualizedCostDto internalTotalAnnualizedCostDto = new TotalAnnualizedCostDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalTotalAnnualizedCostDto.Id        = externalTotalAnnualizedCostDto.Id;
                internalTotalAnnualizedCostDto.ProjectId = externalTotalAnnualizedCostDto.ProjectId;

                internalTotalAnnualizedCostDto.TAC_InterestRate        = externalTotalAnnualizedCostDto.TAC_InterestRate;
                internalTotalAnnualizedCostDto.TAC_LifeYears           = externalTotalAnnualizedCostDto.TAC_LifeYears;
                internalTotalAnnualizedCostDto.TAC_MaintenanceFraction = externalTotalAnnualizedCostDto.TAC_MaintenanceFraction;
                internalTotalAnnualizedCostDto.TAC_OperatingHours      = externalTotalAnnualizedCostDto.TAC_OperatingHours;
                //-----------------------------------------------------------------------------------------------------
                //--- Add INTERNAL TotalAnnualizedCost Dto to the Database using the TotalAnnualizedCostRepo Object ---
                //--- Returns the TotalAnnualizedCost ID (PK) from the TotalAnnualizedCost Table database addition  ---
                //-----------------------------------------------------------------------------------------------------
                totalAnnualizedCostId = TotalAnnualizedCostRepoObj.AddTotalAnnualizedCost(internalTotalAnnualizedCostDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding total annualized cost: {ex.Message}");
            }
            return totalAnnualizedCostId;
        }
        #endregion  // AddTotalAnnualizedCost(TotalAnnualizedCostDto totalAnnualizedCostDto) ... CREATE
        
        #region GetTotalAnnualizedCostByProjectId(Guid projectId) ... READ
        /// <summary>
        /// Retrieves (READ) the TotalAnnualizedCost Dto associated with the specified unique identifier.
        /// The TotalAnnualizedCost retrieved from the Database is in INTERNAL Units, 
        /// database access performed by the repository layer, 
        /// the fields of the TotalAnnualizedCost are converted to EXTERNAL Units, which are the units used in the user interface,
        /// the resulting TotalAnnualizedCost Dto is returned as a <see cref="TotalAnnualizedCostDto"/> object.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve.</param>
        /// <returns>A <see cref="TotalAnnualizedCostDto"/> representing the TotalAnnualizedCost with the specified identifier. 
        /// Returns null if no TotalAnnualizedCost is found.</returns>
        public TotalAnnualizedCostDto GetTotalAnnualizedCostByProjectId(Guid projectId)
        {
            TotalAnnualizedCostDto externalTotalAnnualizedCostDto = new TotalAnnualizedCostDto();
            try
            {
                //-----------------------------------------------------------------------
                //--- Retrieve TotalAnnualizedCost Dto from the Database.             ---
                //--- The retrieved TotalAnnualizedCost Dto is in INTERNAL Units,     ---
                //--- database access performed by the TotalAnnualizedCostRepo Object ---
                //-----------------------------------------------------------------------
                TotalAnnualizedCostDto internalTotalAnnualizedCostDto =
                    TotalAnnualizedCostRepoObj.GetTotalAnnualizedCostByProjectId(projectId);
                //-------------------------------------------------
                //--- Convert INTERNAL Fields to EXTERNAL Units ---
                //-------------------------------------------------
                externalTotalAnnualizedCostDto.Id        = internalTotalAnnualizedCostDto.Id;
                externalTotalAnnualizedCostDto.ProjectId = internalTotalAnnualizedCostDto.ProjectId;

                externalTotalAnnualizedCostDto.TAC_InterestRate        = internalTotalAnnualizedCostDto.TAC_InterestRate;
                externalTotalAnnualizedCostDto.TAC_LifeYears           = internalTotalAnnualizedCostDto.TAC_LifeYears;
                externalTotalAnnualizedCostDto.TAC_MaintenanceFraction = internalTotalAnnualizedCostDto.TAC_MaintenanceFraction;
                externalTotalAnnualizedCostDto.TAC_OperatingHours      = internalTotalAnnualizedCostDto.TAC_OperatingHours;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving total annualized cost: {ex.Message}");
                return null;
            }

            return externalTotalAnnualizedCostDto;
        }
        #endregion  // GetTotalAnnualizedCostByProjectId(Guid projectId) ... READ

        #region UpdateTotalAnnualizedCost(TotalAnnualizedCostDto externalTotalAnnualizedCostDto) ... UPDATE
        /// <summary>
        /// Updates (UPDATE) an existing total annualized cost in the database using the 
        /// specified total annualized cost data transfer object (DTO) with external units.
        /// </summary>
        /// <remarks>This method converts the provided total annualized cost data from external units to the 
        /// internal units required by the database before updating the total annualized cost. 
        /// If the specified total annualized cost does not exist, the behavior depends on the 
        /// repository implementation.
        /// </remarks>
        /// <param name="externalTotalAnnualizedCostDto">The total annualized cost data transfer object 
        /// containing updated total annualized cost information in external units. Cannot be null.</param>
        public void UpdateTotalAnnualizedCost(TotalAnnualizedCostDto externalTotalAnnualizedCostDto)
        {
            try
            {
                //------------------------------------------------------------------------------
                //--- Total Annualized Cost Dto [INTERNAL Units] to be Added to the Database ---
                //------------------------------------------------------------------------------
                TotalAnnualizedCostDto internalTotalAnnualizedCostDto = new TotalAnnualizedCostDto();
                //-------------------------------------------------
                //--- Convert EXTERNAL Fields to INTERNAL Units ---
                //-------------------------------------------------
                internalTotalAnnualizedCostDto.Id = externalTotalAnnualizedCostDto.Id;
                internalTotalAnnualizedCostDto.ProjectId = externalTotalAnnualizedCostDto.ProjectId;
                internalTotalAnnualizedCostDto.TAC_InterestRate = externalTotalAnnualizedCostDto.TAC_InterestRate;
                internalTotalAnnualizedCostDto.TAC_LifeYears = externalTotalAnnualizedCostDto.TAC_LifeYears;
                internalTotalAnnualizedCostDto.TAC_MaintenanceFraction = externalTotalAnnualizedCostDto.TAC_MaintenanceFraction;
                internalTotalAnnualizedCostDto.TAC_OperatingHours = externalTotalAnnualizedCostDto.TAC_OperatingHours;
                //-----------------------------------------------------------------
                //--- UPDATE INTERNAL Total Annualized Cost Dto to the Database ---
                //--- The Total Annualized Cost to be updated is identified by  ---
                //--- the Id field of the provided Total Annualized Cost Dto    ---
                //-----------------------------------------------------------------
                TotalAnnualizedCostRepoObj.UpdateTotalAnnualizedCost(internalTotalAnnualizedCostDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating total annualized cost: {ex.Message}");
            }
        }
        #endregion  // UpdateTotalAnnualizedCost(TotalAnnualizedCostDto totalAnnualizedCostDto) ... UPDATE

        #region DeleteTotalAnnualizedCost(Guid totalAnnualizedCostId) ... DELETE
        /// <summary>
        /// Deletes (DELETE) the total annualized cost with the specified unique identifier.
        /// </summary>
        /// <param name="totalAnnualizedCostId">The unique identifier of the total annualized cost to delete.</param>
        public void DeleteTotalAnnualizedCost(Guid totalAnnualizedCostId)
        {
            try
            {
                //--------------------------------------------------------------------------------------------------------
                //--- DELETE Total Annualized Cost from the Database using the TotalAnnualizedCostRepo Object          ---
                //--- The Total Annualized Cost to be deleted is identified by the provided totalAnnualizedCostId (PK) ---
                //--------------------------------------------------------------------------------------------------------
                TotalAnnualizedCostRepoObj.DeleteTotalAnnualizedCost(totalAnnualizedCostId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting total annualized cost: {ex.Message}");
            }
        }
        #endregion  // DeleteTotalAnnualizedCost(Guid totalAnnualizedCostId) ... DELETE

        #endregion  // TOTAL ANNUALIZED COST CRUD METHODS

    }
    #endregion      // public class TotalAnnualizedCostViewModel
}
#endregion      // namespace HenViewModel.Project.CostParameters

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
