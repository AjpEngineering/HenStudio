#region HEADER
//#####################################################################################################################
//######################################  P r o j e c t P a n e l D a t a . c s  ########################################
//#####################################################################################################################
//  FILENAME:  ProjectPanelData.cs
//  NAMESPACE: HenStudio.Data.Project
//  CLASS(S):  ProjectPanelData
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Project Panel Data object - data needed for Project Panel.
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
using HenModel.Dto.Project;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion  // REFERENCES

#region namespace HenStudio.Data.Project
namespace HenStudio.Data.Project
{
    #region public class ProjectPanelData
    public class ProjectPanelData : IProjectPanelData
    {
        #region CONSTANTS
        const string NAMESPACE = "HenStudio.Data.Project";
        const string CLASS = "ProjectPanelData";
        #endregion      // CONSTANTS

        #region PROPERTIES
        public ProjectDto ProjectDtoObj { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DefaultHenOptimizer { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        #endregion  // PROPERTIES

        #region CTOR
        /// <summary>
        /// Initializes a new instance of the ProjectPanelData class with default values for all properties.
        /// </summary>
        /// <remarks>All string properties are initialized to empty strings, date properties are set to
        /// the current date and time, and the ProjectDtoObj property is initialized with a new ProjectDto instance.
        /// This constructor ensures that the object is in a valid default state upon creation.</remarks>
        public ProjectPanelData()
        {
            ProjectDtoObj = new ProjectDto();
            Id = new Guid();
            Name = string.Empty; 
            Description = string.Empty;
            DefaultHenOptimizer = string.Empty;
            CreationDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
        #endregion  // CTOR

        #region STRING CONVERSION METHODS

        #region GetProjectId()
        /// <summary>
        /// Gets the unique identifier of the project as a string.
        /// </summary>
        /// <returns>A string representation of the project's unique identifier.</returns>
        public string GetProjectId()
        { 
            return Id.ToString(); 
        }
        #endregion  // GetProjectId()
        
        #region GetProjectCreationDate()
        /// <summary>
        /// Gets the creation date of the project as a formatted string.
        /// </summary>
        /// <returns>A string representation of the project's creation date.</returns>
        public string GetProjectCreationDate()
        {
            return CreationDate.ToString("yyyy-MM-dd HH:mm:ss");
        }
        #endregion  // GetProjectCreationDate()
        
        #region GetProjectModifiedDate()
        /// <summary>
        /// Gets the modification date of the project as a formatted string.
        /// </summary>
        /// <returns>A string representation of the project's modification date.</returns>
        public string GetProjectModifiedDate()
        {
            return ModifiedDate.ToString("yyyy-MM-dd HH:mm:ss");
        }
        #endregion  // GetProjectModifiedDate()

        #endregion  // STRING CONVERSION METHODS

        #region IMPLEMENTATION of IProjectPanelData METHODS

        #region ConvertToPanelData(ProjectDto projectDto)
        /// <summary>
        /// Creates a new ProjectPanelData instance by copying values from the specified ProjectDto object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from ProjectDto to
        /// ProjectPanelData. All relevant fields are transferred directly. If projectDto is null, a
        /// NullReferenceException may occur.</remarks>
        /// <param name="projectDto">The ProjectDto object containing the source values to copy. Cannot be null.</param>
        /// <returns>A ProjectPanelData instance populated with values from the provided ProjectDto object.</returns>
        public ProjectPanelData ConvertToPanelData(ProjectDto projectDto)
        {
            ProjectDtoObj = projectDto;
            this.Id = projectDto.Id;
            this.Name = projectDto.Name;
            this.Description = projectDto.Description;
            this.DefaultHenOptimizer = projectDto.DefaultHenOptimizer;
            this.CreationDate = projectDto.CreationDate;
            this.ModifiedDate = projectDto.ModifiedDate;
            return this;
        }
        #endregion  // ConvertToPanelData(ProjectDto projectDto)

        #region ConvertFromPanelData()
        /// <summary>
        /// Creates a new ProjectDto instance by copying values from the current ProjectPanelData object.
        /// </summary>
        /// <remarks>This method performs a property-by-property mapping from ProjectPanelData to
        /// ProjectDto. All relevant fields are transferred directly.</remarks>
        /// NullReferenceException may occur.</remarks>
        /// <returns>A ProjectDto instance populated with values from the provided ProjectPanelData object.</returns>
        public ProjectDto ConvertFromPanelData()
        {
            ProjectDtoObj = new ProjectDto();
            ProjectDtoObj.Id = this.Id;
            ProjectDtoObj.Name = this.Name;
            ProjectDtoObj.Description = this.Description;
            ProjectDtoObj.DefaultHenOptimizer = this.DefaultHenOptimizer;
            ProjectDtoObj.CreationDate = this.CreationDate;
            ProjectDtoObj.ModifiedDate = this.ModifiedDate;
            return ProjectDtoObj;
        }
        #endregion  // ConvertFromPanelData()   

        #endregion  // IMPLEMENTATION of IProjectPanelData
    }
    #endregion      // public class ProjectPanelData
}
#endregion  // namespace HenStudio.Data.Project

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
