#region HEADER
//#####################################################################################################################
//####################################  F o r m M a i n . E x p l o r e r . c s  ######################################
//#####################################################################################################################
//  FILENAME:  FormMain.Explorer.cs
//  NAMESPACE: HenStudio
//  CLASS(S):  FormMain
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the Projects Explorer in the Main HEN Studio Form.
//---------------------------------------------------------------------------------------------------------------------
//                      PRESENTATION LAYER ->       BUSINESS LAYER            ->       DATA LAYER
//                       UI -> ViewModels  -> Domain -> Repository Interfaces -> Persistence -> Database
//---------------------------------------------------------------------------------------------------------------------
//    The HenStudio Component (Assembly) is part of the Presentation Layer of the Software Architecture.
//    This Layer includes the WinForms UI (Forms, Controls, Grids, etc.) AND
//    the ViewModel layer (BindingLists, commands [e.g., Unit Conversion - To/From External-Internal Units], etc.).
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

#region AJP HEN NAMESPACES
using HenGlobal;

using HenModel.Connection;
using HenModel.Connection.Interface;

using HenModel.Dto;
using HenModel.Dto.System;

using HenModel.Dto.Project;
using HenModel.Dto.Project.CostParameters;
using HenModel.Dto.Project.DefaultParameters;
using HenModel.Dto.Project.DefaultParameters.ExchangerParams;
using HenModel.Dto.Project.DefaultParameters.OptimizerParams;
using HenModel.Dto.Project.DefaultParameters.ProjectUnits;

using HenModel.Dto.Profile;

using HenModel.Dto.Pinch;
using HenModel.Dto.Pinch.Plots;

using HenModel.Dto.Hen;
using HenModel.Dto.Hen.Plots;

using HenModel.RepoImplementations.System;
using HenModel.RepoImplementations.Project;
using HenModel.RepoImplementations.Profile;
using HenModel.RepoImplementations.Pinch;
using HenModel.RepoImplementations.Hen;

using HenViewModel;
using HenViewModel.System;

using HenViewModel.Project;
using HenViewModel.Project.CostParameters;
using HenViewModel.Project.DefaultParameters;
using HenViewModel.Project.DefaultParameters.ExchangerParams;
using HenViewModel.Project.DefaultParameters.OptimizerParams;
using HenViewModel.Project.DefaultParameters.ProjectUnits;

using HenViewModel.Profile;

using HenViewModel.Pinch;
using HenViewModel.Pinch.Plots;

using HenViewModel.Hen;
//using HenViewModel.Hen.Plots;

using HenStudio.Properties;
using HenStudio.Data.Project;
using HenStudio.Data.Tag;

#endregion  // AJP HEN NAMESPACES

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

using static HenGlobal.HenTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

#endregion  // REFERENCES

#region namespace HenStudio
namespace HenStudio
{
    #region partial class FormMain
    public partial class FormMain
    {
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        //---------------------------------------- Project Explorer TreeView ------------------------------------------
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        #region GetRootNode()
        /// <summary>
        /// Get the Root Node of the tree 
        /// NOTE: Tree is treeViewCurrentProjectExplorer
        /// </summary>
        /// <returns>Root Node on Success; null otherwise</returns>
        private TreeNode GetRootNode()
        {
            string strMethod = "GetRootNode";
            TreeNode rootNode = null;
            try
            {
                if(treeViewCurrentProjectExplorer.Nodes.Count > 0) 
                    rootNode = treeViewCurrentProjectExplorer.Nodes[0];
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
            return rootNode;
        }
        #endregion  // GetRootNode()

        #region GetParentNode()
        /// <summary>
        /// Get the Parent Node of the User Specified Node
        /// NOTE: Tree is treeViewCurrentProjectExplorer
        /// </summary>
        /// <param name="currNode">User Specified Node</param>
        /// <returns>Parent Node of Null if Specified Node is root</returns>
        private TreeNode GetParentNode(TreeNode currNode)
        {
            string strMethod = "GetParentNode";
            TreeNode parentNode = currNode;
            try
            {
                if (currNode.Parent != null) parentNode = currNode.Parent;
                else parentNode = null;
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
            return parentNode;
        }
        #endregion  // GetParentNode()

        #region GetSelectedNode()
        /// <summary>
        /// Get the Selected Node
        /// NOTE: Tree is treeViewCurrentProjectExplorer
        /// </summary>
        /// <returns>Selected Node or null if no node is selected</returns>
        private TreeNode GetSelectedNode()
        {
            string strMethod = "GetSelectedNode";
            TreeNode selectedNode = null;
            try
            {
                selectedNode = treeViewCurrentProjectExplorer.SelectedNode;
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
            return selectedNode;
        }
        #endregion  // GetSelectedNode()

        #region DeleteSelectedNode()
        /// <summary>
        /// DELETE the selected Node of the Project Explorer Tree
        /// NOTE: Save tge Tag Object before deleting node
        /// </summary>
        private void DeleteSelectedNode()
        {
            string strMethod = "DeleteSelectedNode";
            string strMsg = String.Empty;
            try
            {
                //------------------
                //--- Null Guard ---
                //------------------
                if (treeViewCurrentProjectExplorer.SelectedNode == null) return;

                //-------------------------
                //--- Get Selected Node ---
                //-------------------------
                TreeNode node = treeViewCurrentProjectExplorer.SelectedNode;

                //-------------------------------------------------
                //--- Optional: Retrieve Object Before Deleting ---
                //-------------------------------------------------
                var dataTagDisplayObj = node.Tag as DataTagDisplay;

                node.Remove();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // DeleteSelectedNode()

        #region RemoveAllNodes()
        /// <summary>
        /// Remove all Nodes from the Tree and then Add back Root HEN Studio Node
        /// </summary>
        private void RemoveAllNodes()
        {
            string strMethod = "RemoveAllNodes";
            string strMsg = String.Empty;
            int nDisplayNodeID = 0;
            try
            {
                //------------------------------
                //--- Assign Tree Properties ---
                //------------------------------
                treeViewCurrentProjectExplorer.ImageList = this.imageListProjectTreeViews;

                //---------------------------
                //-- Create New ROOT Node ---
                //---------------------------
                TreeNode rootNode = new TreeNode("HEN Studio");

                //----------------------------------
                //--- Assign New Node Attributes ---
                //----------------------------------
                rootNode.ContextMenuStrip = contextMenuStripProjectCatalog;

                //-----------------------------------------------
                //-- Create Tag Object and Assign to New Node ---
                //-----------------------------------------------
                DataTagDisplay dataTagDisplayObj = new DataTagDisplay(ExplorerNodeIdType.CATALOG, "HEN Studio");
                rootNode.Tag = dataTagDisplayObj;

                //---------------------------
                //--- Set Root Node Image ---
                //---------------------------
                rootNode.ImageIndex = 9;
                rootNode.SelectedImageIndex = 9;

                //--------------------------------------------------------------------
                //--- Remove all Existing Nodes from Tree, Add and Select New Node ---
                //--------------------------------------------------------------------
                treeViewCurrentProjectExplorer.Nodes.Clear();
                nDisplayNodeID = treeViewCurrentProjectExplorer.Nodes.Add(rootNode);
                treeViewCurrentProjectExplorer.SelectedNode = rootNode;
                rootNode.EnsureVisible();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // RemoveAllNodes()

        #region CollapseAllProjectsExplorer()
        public void CollapseAllProjectsExplorer()
        {
            this.treeViewCurrentProjectExplorer.CollapseAll();
            HandleSelectionChange();
        }
        #endregion  // CollapseAllProjectsExplorer()

        #region ExpandAllProjectsExplorer()
        public void ExpandAllProjectsExplorer()
        {
            this.treeViewCurrentProjectExplorer.ExpandAll();
        }
        #endregion  // ExpandAllProjectsExplorer()

        #region RefreshTree(bool bCollapseAll)
        /// <summary>
        /// Clear Tree Nodes and Refresh Tree with Current Projects from Database
        /// </summary>
        /// <param name="bCollapseAll">Collapse all nodes if true, otherwise expand all nodes. 
        /// Default to true (collapse all) to avoid overwhelming user with expanded tree on refresh.
        /// </param>
        private void RefreshTree(bool bCollapseAll = true)
        {
            string strMethod = "RefreshTree";
            string strMsg = String.Empty;
            try
            {
                //--------------------------------------------
                //--- Clear Tree Nodes Adds Back Root Node ---
                //--------------------------------------------
                RemoveAllNodes();

                //-------------------------------------------------
                //--- Get Root Node Created in RemoveAllNodes() ---
                //--- to Add Project Children Nodes             ---
                //-------------------------------------------------
                TreeNode rootNode = GetRootNode();

                //----------------------------------------------------------------
                //--- GetProject ViewModel Object to Retrieve Projects from DB ---
                //----------------------------------------------------------------
                var ProjectViewModelObj = new ProjectViewModel();

                //-----------------------------------------------
                //--- Get All Projects from Project ViewModel ---
                //-----------------------------------------------
                IList<ProjectDto> projects = ProjectViewModelObj.GetProjects();

                //---------------------------------------------------------------
                //--- Check for at least One Project to add Root Node to Tree ---
                //--- (otherwise Tree will be Empty with just Root Node)      ---
                //---------------------------------------------------------------
                if (projects != null)
                {
                    //----------------------------------------------
                    //--- Add Project Nodes to Root Node         ---
                    //--- Assign Tag Object with Node Attributes ---
                    //----------------------------------------------
                    string strProjectName = string.Empty;   // Project name from DB
                    string strNodeName = string.Empty;      // Node name with Prefix (e.g., "Project: *") for display in Tree Node
                    foreach (var project in projects)
                    {
                        //--------------------------------------
                        //--- Create Project Node Tag Object ---
                        //--------------------------------------
                        strProjectName = project.Name;
                        strNodeName = string.Format("Project: {0}", strProjectName.Trim());
                        DataTagDisplay DataTagDisplayObj = 
                            new DataTagDisplay(ExplorerNodeIdType.PROJECT, strProjectName.Trim()) { ProjectID = project.Id };

                        //-----------------------------------------------------------------
                        //--- Create Project Node and Assign Tag Object, and Set Images ---
                        //-----------------------------------------------------------------
                        TreeNode projectNode = new TreeNode(strNodeName) { Tag = DataTagDisplayObj };
                    
                        projectNode.ImageIndex = 1;
                        projectNode.SelectedImageIndex = 2;

                        rootNode.Nodes.Add(projectNode);
                    }

                    //--------------------------------------------------------
                    //--- Add Root Node and Project Children Nodes to Tree ---
                    //--------------------------------------------------------
                    treeViewCurrentProjectExplorer.Nodes.Clear();
                    treeViewCurrentProjectExplorer.Nodes.Add(rootNode);
                }

                //------------------------------
                //--- Collapse | Expand Tree ---
                //------------------------------
                if (bCollapseAll) CollapseAllProjectsExplorer();
                else ExpandAllProjectsExplorer();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                //----------------------------
                //--- Select the Root Node ---
                //----------------------------
                treeViewCurrentProjectExplorer.SelectedNode = treeViewCurrentProjectExplorer.Nodes[0];
            }
        }
        #endregion  // RefreshTree(bool bCollapseAll)

        #region UpdateTreeStatusBar()
        /// <summary>
        /// Update Tree View - Status Bar States based on User Specified Tree Node
        /// </summary>
        /// <param name="node">Update state base on this Tree Node</param>
        private void UpdateTreeStatusBar(TreeNode node)
        {
            string strMethod = "UpdateTreeStatusBar";
            string strMsg = String.Empty;
            DataTagDisplay dataTagDisplayObj;
            HenTypes.ExplorerNodeIdType explorerNodeIdType = ExplorerNodeIdType.UNKNOWN;
            string strProjectName = string.Empty;
            string strProfileName = string.Empty;
            string strPinchName = string.Empty;
            string strHenName = string.Empty;
            try
            {
                //------------------------------------------
                //-- Get Tag Object Associated with node ---
                //------------------------------------------
                dataTagDisplayObj = ((DataTagDisplay)node.Tag);

                explorerNodeIdType = dataTagDisplayObj.NodeIdEnum;
                HenSettingsObj.ExplorerSelectedLevelEnum = explorerNodeIdType;
                switch(explorerNodeIdType)
                {
                    case ExplorerNodeIdType.CATALOG:
                        HenSettingsObj.CurrentProjectName = strProjectName;
                        HenSettingsObj.CurrentProfileName = strProfileName;
                        HenSettingsObj.CurrentPinchName = strPinchName;
                        HenSettingsObj.CurrentHenName = dataTagDisplayObj.NodeName;
                        break;

                        case ExplorerNodeIdType.PROJECT:
                        strProjectName = dataTagDisplayObj.NodeName;
                        HenSettingsObj.CurrentProjectName = strProjectName;
                        HenSettingsObj.CurrentProfileName = strProfileName;
                        HenSettingsObj.CurrentPinchName = strPinchName;
                        HenSettingsObj.CurrentHenName = dataTagDisplayObj.NodeName;
                        break;

                        case ExplorerNodeIdType.PROFILE:
                        strProjectName = ((DataTagDisplay)node.Parent.Tag).NodeName;
                        strProfileName = dataTagDisplayObj.NodeName;
                        HenSettingsObj.CurrentProjectName = strProjectName;
                        HenSettingsObj.CurrentProfileName = strProfileName;
                        HenSettingsObj.CurrentPinchName = strPinchName;
                        HenSettingsObj.CurrentHenName = dataTagDisplayObj.NodeName;
                        break;

                    case ExplorerNodeIdType.STUDY:
                        strProjectName = ((DataTagDisplay)node.Parent.Tag).NodeName;
                        strProfileName = dataTagDisplayObj.NodeName;
                        HenSettingsObj.CurrentProjectName = strProjectName;
                        HenSettingsObj.CurrentProfileName = strProfileName;
                        HenSettingsObj.CurrentPinchName = strPinchName;
                        HenSettingsObj.CurrentHenName = dataTagDisplayObj.NodeName;
                        break;

                    default:
                        HenSettingsObj.CurrentProjectName = strProjectName;
                        HenSettingsObj.CurrentProfileName = strProfileName;
                        HenSettingsObj.CurrentPinchName = strPinchName;
                        HenSettingsObj.CurrentHenName = dataTagDisplayObj.NodeName;
                        break;
                }
            }

            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // UpdateTreeStatusBar()

        #region HandleSelectionChange()
        private void HandleSelectionChange()
        {
            string strMethod = "HandleSelectionChange";
            string strMsg = String.Empty;
            ExplorerNodeIdType explorerNodeIdType = ExplorerNodeIdType.UNKNOWN;
            try
            {
                //----------------------------------------------------------------
                //--- GetProject ViewModel Object to Retrieve Projects from DB ---
                //----------------------------------------------------------------
                var projectViewModelObj = new ProjectViewModel();
                var projectUnitsViewModelObj = new ProjectUnitsViewModel();
                var exchangerParamsViewModelObj = new ExchangerParamsViewModel();

                //--------------------------
                //--- Get Node and Level ---
                //--------------------------
                TreeNode node = treeViewCurrentProjectExplorer.SelectedNode;
                if (node == null) return;  // Null Guard

                DataTagDisplay dataTagDisplayObj = ((DataTagDisplay)node.Tag);
                if(dataTagDisplayObj == null ) return;  // Null Guard

                explorerNodeIdType = dataTagDisplayObj.NodeIdEnum;

                //---------------------------------------
                //--- Update Current Tree-Panel State ---
                //---------------------------------------
                UpdateTreeStatusBar(node);

                #region Popluate and Display Panels
                //-----------------------------------
                //--- Popluate and Display Panels ---
                //-----------------------------------
                switch (explorerNodeIdType)
                {
                    #region CATALOG (PROJECTS)
                    case ExplorerNodeIdType.CATALOG:
                        //-------------------------------------------------
                        //--- Populate Current Projects (CATALOG) Panel ---
                        //--- and Display Projects (CATALOG) Panel      ---
                        //-------------------------------------------------
                        HandleDBConnectionState();
                        break;
                    #endregion  // CATALOG (PROJECTS)

                    #region PROJECT
                    case ExplorerNodeIdType.PROJECT:
                        //-----------------------------------------------------------
                        //--- Get Project Data from DB and Populate Project Panel ---
                        //-----------------------------------------------------------
                        TreeNode selNode = treeViewCurrentProjectExplorer.SelectedNode;
                        
                        Guid projectID = ((DataTagDisplay)selNode.Tag).ProjectID;
                        if (projectID == Guid.Empty) throw(new Exception("Invalid Project ID!"));

                        //-----------------------------------------------------------------------------------
                        //--- Get Project Data from DB using Project ViewModel and Populate Project Panel ---
                        //-----------------------------------------------------------------------------------
                        ProjectDto projectDtoObj = projectViewModelObj.GetProjectById(projectID);
                        ProjectUnitsDto projectUnitsDto = projectUnitsViewModelObj.GetProjectUnitsByProjectId(projectID);
                        ExchangerParamsDto exchangerParamsDto = exchangerParamsViewModelObj.GetExchangerParamsByProjectId(projectID);

                        //------------------------------------------------
                        //--- Populate Project Panel with Project Data ---
                        //------------------------------------------------
                        //ProjectPanelData projectPanelDataObj = GetProjectViewData(projectDtoObj,
                        //                                                        exchangerParamsDto,
                        //                                                        projectUnitsDto);
                        ProjectPanelData projectPanelDataObj = new ProjectPanelData();
                        projectPanelDataObj = projectPanelDataObj.ConvertToPanelData(projectDtoObj);


                        PopulateProjectPanel(projectPanelDataObj);

                        //-----------------------------
                        //--- Display Project Panel ---
                        //-----------------------------
                        this.panelSELECTED_PROJECT.BringToFront();
                        break;
                    #endregion  // PROJECT

                    #region PROFILE
                    case ExplorerNodeIdType.PROFILE:
                        //--------------------------------------
                        //--- Populate Current Profile Panel ---
                        //--------------------------------------
                        HenMsgDlg.DisplayWarningDlg("***** Populate Current PROFILE Panel *****");


                        //-----------------------------
                        //--- Display Profile Panel ---
                        //-----------------------------
                        this.panelSELECTED_PROFILE.BringToFront();
                        break;
                    #endregion  // PROFILE

                    #region STUDY
                    case ExplorerNodeIdType.STUDY:
                        //------------------------------------
                        //--- Populate Current Study Panel ---
                        //------------------------------------
                        HenMsgDlg.DisplayWarningDlg("***** Populate Current STUDY Panel *****");


                        //---------------------------
                        //--- Display Study Panel ---
                        //---------------------------
                        //this.panelSELECTED_STUDY.BringToFront();
                        break;
                    #endregion  // STUDY

                    #region UNKNOWN
                    default:
                        throw new Exception("INVALID Explorer Level!");
                    #endregion  // UNKNOWN
               
                }
                #endregion  // Popluate and Display Panels
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // HandleSelectionChange()

        #region TREE VIEW EVENT HANDLERS

        #region SELECTION CHANGED
        private void treeViewCurrentProjectExplorer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            HandleSelectionChange();
        }
        #endregion  // SELECTION CHANGED

        #region CONTEXT MENU EVENT HANDLERS

        #region COLLAPSE ALL
        private void toolStripMenuItemCurrProjCollapseAll_Click(object sender, EventArgs e)
        {
            CollapseAllProjectsExplorer();
        }
        private void toolStripMenuItemCollapseAll_Click(object sender, EventArgs e)
        {
            CollapseAllProjectsExplorer();
        }

        #endregion      // COLLAPSE ALL

        #region EXPAND ALL
        private void toolStripMenuItemCurrProjExpandAll_Click(object sender, EventArgs e)
        {
            ExpandAllProjectsExplorer();
        }

        private void toolStripMenuItemExpandAll_Click(object sender, EventArgs e)
        {
            ExpandAllProjectsExplorer();
        }

        #endregion  // EXPAND ALL

        #region NEW EVENT HANDLERS

        #region NEW PROJECT
        /// <summary>
        /// Context Menu Associated with Root Projects Node -> Add Project...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemAddProject_Click(object sender, EventArgs e)
        {
            HandleNewProject();
        }
        #endregion  // NEW PROJECT

        #region NEW PROFILE
        /// <summary>
        /// Context Menu Associated with Project Node -> Add Profile...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemCurProjAdd_Click(object sender, EventArgs e)
        {
            HandleNewProfile();
        }
        #endregion  // NEW PROFILE

        #region NEW PINCH
        /// <summary>
        /// Context Menu Associated with Profile Node -> Add Pinch...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemProfileAdd_Click(object sender, EventArgs e)
        {
            HandleNewPinch();
        }
        #endregion  // NEW PINCH

        #region NEW HEN
        /// <summary>
        /// Context Menu Associated with Pinch Node -> Add Hen...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemPinchAdd_Click(object sender, EventArgs e)
        {
            HandleNewHen();
        }
        #endregion  // NEW HEN

        #endregion  // NEW EVENT HANDLERS

        #region MODIFY EVENT HANDLERS

        #region MODIFY PROJECT
        private void toolStripMenuItemCurProjRename_Click(object sender, EventArgs e)
        {
            HandleModifyProject();
        }
        #endregion  // MODIFY PROJECT

        #region RENAME PROFILE
        private void toolStripMenuItemProfileRename_Click(object sender, EventArgs e)
        {
            HandleRenameProfile();
        }
        #endregion  // RENAME PROFILE

        #region RENAME PINCH
        private void toolStripMenuItemPinchRename_Click(object sender, EventArgs e)
        {
            HandleRenamePinch();
        }
        #endregion  // RENAME PINCH

        #region RENAME HEN
        private void toolStripMenuItemCurProjHenRename_Click(object sender, EventArgs e)
        {
            HandleRenameHen();
        }
        #endregion  // RENAME HEN

        #endregion  // RENAME NODES

        #region DELETE EVENT HANDLERS

        #region DELETE PROJECT NODE
        private void toolStripMenuItemDeleteProject_Click(object sender, EventArgs e)
        {
            HandleDeleteProject();
        }
        #endregion  // DELETE PROJECT NODE

        #region DELETE PROFILE NODE
        private void toolStripMenuItemProfileDelete_Click(object sender, EventArgs e)
        {
            HandleDeleteProfile();
        }
        #endregion  // DELETE PROFILE NODE

        #region DELETE PINCH NODE
        private void toolStripMenuItemPinchDelete_Click(object sender, EventArgs e)
        {
            HandleDeletePinch();
        }
        #endregion  // DELETE PINCH NODE

        #region DELETE HEN NODE
        private void toolStripMenuItemCurProjHenDelete_Click(object sender, EventArgs e)
        {
            HandleDeleteHen();
        }
        #endregion  // DELETE HEN NODE

        #endregion  // DELETE EVENT HANDLERS

        #endregion  // CONTEXT MENU EVENT HANDLERS

        #endregion      // TREE VIEW EVENT HANDLERS

        #region COMMON EVENT HANDLERS

        #region HANDLE NEW NODE EVENTS

        #region HandleNewProject
        /// <summary>
        /// Common New Command Handler. Display New Project Form (FormSettings)
        /// </summary>
        private void HandleNewProject()
        {
            string strMethod = "HandleNewProject";
            string strDlgName = string.Empty;   // Dialog name no Prefix ... From New Dialog Name field
            string strNodeName = string.Empty;  // Includes Prefix (e.g., "Project: *")
            int nDisplayNodeID = 0;
            Guid projectGUID = Guid.Empty;      // DB Project GUID (PK)
            try
            {
                //-----------------------------------------------------------------
                //--- Get Project ViewModel Object to Retrieve Projects from DB ---
                //-----------------------------------------------------------------
                var projectViewModelObj = new ProjectViewModel();
                var projectUnitsViewModelObj = new ProjectUnitsViewModel();
                var exchangerParamsViewModelObj = new ExchangerParamsViewModel();

                //-------------------------------------
                //--- Display New Project Data Form ---
                //-------------------------------------
                FormProjectNewModify dlg = new FormProjectNewModify(HenSettingsObj.AppGlobalSettingsObj);
                if (dlg.ShowDialog()!=DialogResult.OK) return;   // User Canceled Dialog

                //-------------------------
                //--- Update Form Title ---
                //-------------------------
                HenSettingsObj.CurrentProjectName = dlg.ProjectPanelDataObj.Name;
                UpdateProjectNameUI();

                //------------------------------------------------------------------------------
                //--- Get New Project Name from Dialog and Format Display Name for Tree Node ---
                //------------------------------------------------------------------------------
                strDlgName = dlg.ProjectPanelDataObj.Name;
                strNodeName = string.Format("Project: {0}", strDlgName.Trim());

                //-------------------------------------------------------------------
                //--- Get ProjectDto Object from Panel Data (ProjectPanelDataObj) ---
                //-------------------------------------------------------------------
                //ProjectUnitsDto projectDtoObj = GetProjectDtoFromViewData(dlg.ProjectPanelDataObj);
                //ProjectUnitsDto projectDtoObj = GetProjectDtoFromViewData(dlg.ProjectPanelDataObj);

                //----------------------------------------------------------------------------------------
                //--- Add Project to DB and Get Back Project GUID (PK) and Assign to ProjectDto Object ---
                //----------------------------------------------------------------------------------------
                //projectGUID = projectViewModelObj.AddProject(projectDtoObj);
                //projectDtoObj.Id = projectGUID;

                //-------------------------------------------------------
                //-- Create Node Tag Object and Assign Tag Attributes ---
                //-------------------------------------------------------
                DataTagDisplay dataTagDisplayObj = new DataTagDisplay(ExplorerNodeIdType.PROJECT, strDlgName);
                dataTagDisplayObj.ProjectID = projectGUID;

                //---------------------------------------------------
                //--- Get Parent (Root) Node and Add Project Node ---
                //---------------------------------------------------
                TreeNode parentNode = GetRootNode();
                nDisplayNodeID = AddProjectNode(parentNode, strNodeName, dataTagDisplayObj);

                //----------------------------------------------------
                //--- Populate Project Panel with New Project Data ---
                //----------------------------------------------------
                dlg.ProjectPanelDataObj.Id = projectGUID;     // Assign DATABASE GUID
                PopulateProjectPanel(dlg.ProjectPanelDataObj);

                //------------------------------
                //--- Set Project Dirty Flag ---
                //------------------------------
                //HenSettingsObj.ProjectDirtyFlagStateEnum = ProjectDirtyFlagState.DIRTY;
                //UpdateProjectDirtyFlagLabel();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // HandleNewProject

        #region HandleNewProfile
        /// <summary>
        /// Common New Command Handler. Display New Project Form to capture display Name
        /// </summary>
        private void HandleNewProfile()
        {
            string strMethod = "HandleNewProfile";
            string strNodeName = string.Empty;      // Node name no Prefix ... From New Dialog Name field
            string strDisplayName = string.Empty;   // Includes Prefix (e.g., "Profile: *")
            int nProfileNodeID = 0;
            Guid profileGUID = Guid.Empty;          // DB Profile GUID (PK)
            try
            {
                //--------------------------------
                //--- Display New Profile Form ---
                //--------------------------------
                HenMsgDlg.DisplayWarningDlg("***** Display New Profile Form *****");
                //FormNewProfile dlg = new FormNewProfile();
                //if (dlg.ShowDialog() != DialogResult.OK) return;   // User Canceled Dialog

                //*********************************************************************************
                //***** Scrape Dialog Data and SAVE to DB                                     *****
                //***** Get DB ProfileID (PK)                                                 *****            
                //*********************************************************************************
                HenMsgDlg.DisplayWarningDlg("***** Scrape Dialog Data and SAVE to DB *****");
                HenMsgDlg.DisplayWarningDlg("***** Get DB ProfileID (PK) *****");
                strNodeName = "Q1 Setup";      // From New Dialog ... Name Field
                strDisplayName = "Profile: Q1 Setup";  // Node name with prefix ("Profile: ")
                profileGUID = new Guid();
                //********************************************************************** TEST *****

                //-------------------------------------------------------
                //-- Create Node Tag Object and Assign Tag Attributes ---
                //-------------------------------------------------------
                DataTagDisplay dataTagDisplayObj = new DataTagDisplay(ExplorerNodeIdType.PROFILE,
                                                                      strNodeName);
                dataTagDisplayObj.ProfileID = profileGUID;

                //------------------------------------------------------
                //--- Get Parent (Project) Node and Add Profile Node ---
                //------------------------------------------------------
                TreeNode parentNode = GetSelectedNode();
                nProfileNodeID = AddProfileNode(parentNode, strDisplayName, dataTagDisplayObj);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // HandleNewProfile

        #region HandleNewStudy
        /// <summary>
        /// Common New Command Handler. Display New Study Form to capture display Name
        /// </summary>
        private void HandleNewStudy()
        {
            string strMethod = "HandleNewStudy";
            string strNodeName = string.Empty;      // Node name no Prefix ... From New Dialog Name field
            string strDisplayName = string.Empty;   // Includes Prefix (e.g., "Study: *")
            int nStudyNodeID = 0;
            Guid studyGUID = Guid.Empty;            // DB Study GUID (PK)
            try
            {
                //------------------------------
                //--- Display New Study Form ---
                //------------------------------
                HenMsgDlg.DisplayWarningDlg("***** Display New Study Form *****");
                //FormNewStudy dlg = new FormNewStudy();
                //if (dlg.ShowDialog() != DialogResult.OK) return;   // User Canceled Dialog

                //*********************************************************************************
                //***** Scrape Dialog Data and SAVE to DB                                     *****
                //***** Get DB StudyID (PK)                                                   *****            
                //*********************************************************************************
                HenMsgDlg.DisplayWarningDlg("***** Scrape Dialog Data and SAVE to DB *****");
                HenMsgDlg.DisplayWarningDlg("***** Get DB StudyID (PK) *****");
                strNodeName = "Delta T = 10";      // From New Dialog ... Name Field
                strDisplayName = "Study: Delta T = 10";  // Node name with prefix ("Study: ")
                studyGUID = new Guid();
                //********************************************************************** TEST *****

                //-------------------------------------------------------
                //-- Create Node Tag Object and Assign Tag Attributes ---
                //-------------------------------------------------------
                DataTagDisplay dataTagDisplayObj = new DataTagDisplay(ExplorerNodeIdType.STUDY,
                                                                      strNodeName);
                dataTagDisplayObj.StudyID = studyGUID;

                //----------------------------------------------------
                //--- Get Parent (Project) Node and Add Study Node ---
                //----------------------------------------------------
                TreeNode parentNode = GetSelectedNode();
                //nStudyNodeID = AddStudyNode(parentNode, strDisplayName, dataTagDisplayObj);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // HandleNewStudy

        #endregion  // HANDLE NEW NODE EVENTS

        #region HANDLE MODIFY NODE EVENTS

        #region HandleModifyProject
        /// <summary>
        /// Modify Project Command Handler. Modify User Specified Node.
        /// </summary>
        private void HandleModifyProject()
        {
            string strMethod = "HandleModifyProject";
            string strOriginalName = string.Empty;
            string strNewNodeName = string.Empty;
            string strNewDisplayName = string.Empty;
            TreeNode node;
            try
            {
                node = GetSelectedNode();
                //-----------------------
                //--- Null Node Guard ---
                //-----------------------
                if (node == null) throw new Exception("Null Project Node Encountered!");

                //---------------------------------------------------------------
                //--- GetProject ViewModel Object to Retrieve Project from DB ---
                //---------------------------------------------------------------
                var projectViewModelObj = new ProjectViewModel();
                var projectUnitsViewModelObj = new ProjectUnitsViewModel();
                var exchangerParamsViewModelObj = new ExchangerParamsViewModel();


                //------------------------------------------------------------------------------------------------------
                //--- Get ProjectID from Selected Node Tag and Retrieve Project Data from DB using Project ViewModel ---
                //------------------------------------------------------------------------------------------------------
                //Guid projectID = ((DataTagDisplay)treeViewCurrentProjectExplorer.SelectedNode.Tag).ProjectID;
                //ProjectUnitsDto origProjectDtoObj = projectViewModelObj.GetProjectById(projectID);

                //-----------------------------------------------------------------------------------
                //--- Get ProjectViewData Object from ProjectDto Object to Populate Project Panel ---
                //-----------------------------------------------------------------------------------
                //ProjectViewData projectViewDataObj = GetProjectViewData(origProjectDtoObj);

                //----------------------------------------
                //--- Display Modify Project Data Form ---
                //----------------------------------------
                //FormProjectNewModify dlg = new FormProjectNewModify(projectViewDataObj);
                //if (dlg.ShowDialog() != DialogResult.OK) return;   // User Canceled Dialog

                //-------------------------
                //--- Update Form Title ---
                //-------------------------
                //HenSettingsObj.CurrentProjectName = dlg.ProjectViewDataObj.Name;
                //UpdateProjectNameUI();

                //------------------------------------------------------------------
                //--- Get ProjectDto Object from Panel Data (ProjectViewDataObj) ---
                //------------------------------------------------------------------
                //ProjectDto ModProjectDtoObj = GetProjectDtoFromViewData(dlg.ProjectViewDataObj);

                //-----------------------
                //--- Update Database ---
                //-----------------------
                //projectViewModelObj.UpdateProject(ModProjectDtoObj);

                //---------------------------------------------
                //--- Rename the Selected Project Tree Node ---
                //---------------------------------------------
                //strNewNodeName = ModProjectDtoObj.Name;
                //strNewDisplayName = string.Format("Project: {0}", ModProjectDtoObj.Name);

                node.Text = strNewDisplayName;
                ((DataTagDisplay)node.Tag).NodeName = strNewNodeName.Trim();

                //----------------------------------------------------
                //--- Populate Project Panel with New Project Data ---
                //----------------------------------------------------
                //PopulateProjectPanel(dlg.ProjectViewDataObj);

                ////------------------------------
                ////--- Set Project Dirty Flag ---
                ////------------------------------
                //HenSettingsObj.ProjectDirtyFlagStateEnum = ProjectDirtyFlagState.DIRTY;
                //UpdateProjectDirtyFlagLabel();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // HandleModifyProject

        #region HandleRenameProfile
        /// <summary>
        /// Common Rename Profile Command Handler. Rename User Specified Node.
        /// </summary>
        private void HandleRenameProfile()
        {
            string strMethod = "HandleRenameProfile";
            string strRenameFormTitle = "Rename PROFILE ";
            string strOriginalName = string.Empty;
            string strNewNodeName = string.Empty;
            string strNewDisplayName = string.Empty;
            TreeNode node;
            try
            {
                node = GetSelectedNode();
                //-----------------------
                //--- Null Node Guard ---
                //-----------------------
                if (node == null) throw new Exception("Null Profile Node Encountered!");

                //---------------------------------------
                //--- Rename Profile Data in Database ---
                //---------------------------------------
                HenMsgDlg.DisplayWarningDlg("RENAME PROFILE Data in Database");

                //---------------------------------------------
                //--- Rename the Selected Profile Tree Node ---
                //---------------------------------------------
                FormRename dlg = new FormRename(strRenameFormTitle, ((DataTagDisplay)node.Tag).NodeName);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    strNewNodeName = dlg.NewNodeName;
                    strNewDisplayName = string.Format("Profile: {0}", dlg.NewNodeName);

                    node.Text = strNewDisplayName;
                    ((DataTagDisplay)node.Tag).NodeName = strNewNodeName.Trim();
                }
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // HandleRenameProfile

        #region HandleRenameStudy
        /// <summary>
        /// Common Rename Study Command Handler. Rename User Specified Node.
        /// </summary>
        private void HandleRenameStudy()
        {
            string strMethod = "HandleRenameStudy";
            string strRenameFormTitle = "Rename STUDY ";
            string strOriginalName = string.Empty;
            string strNewNodeName = string.Empty;
            string strNewDisplayName = string.Empty;
            TreeNode node;
            try
            {
                node = GetSelectedNode();
                //-----------------------
                //--- Null Node Guard ---
                //-----------------------
                if (node == null) throw new Exception("Null Study Node Encountered!");

                //-------------------------------------
                //--- Rename Study Data in Database ---
                //-------------------------------------
                HenMsgDlg.DisplayWarningDlg("RENAME STUDY Data in Database");

                //-------------------------------------------
                //--- Rename the Selected Study Tree Node ---
                //-------------------------------------------
                FormRename dlg = new FormRename(strRenameFormTitle, ((DataTagDisplay)node.Tag).NodeName);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    strNewNodeName = dlg.NewNodeName;
                    strNewDisplayName = string.Format("Pinch: {0}", dlg.NewNodeName);

                    node.Text = strNewDisplayName;
                    ((DataTagDisplay)node.Tag).NodeName = strNewNodeName.Trim();
                }
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // HandleRenameStudy

        #endregion  // HANDLE MODIFY NODE EVENTS

        #region HANDLE DELETE NODE EVENTS

        #region HandleDeleteProject
        /// <summary>
        /// Common Delete Project Command Handler. 
        /// </summary>
        private void HandleDeleteProject()
        {
            string strMethod = "HandleDeleteProject";
            TreeNode node;
            try
            {
                node = GetSelectedNode();
                //-----------------------
                //--- Null Node Guard ---
                //-----------------------
                if (node == null) throw new Exception("Null Project Node Encountered!");

                //---------------------------------------------------------------
                //--- GetProject ViewModel Object to Retrieve Project from DB ---
                //---------------------------------------------------------------
                var projectViewModelObj = new ProjectViewModel();

                //------------------------------------------------------------------------------------------------------
                //--- Get ProjectID from Selected Node Tag and Retrieve Project Data from DB using Project ViewModel ---
                //------------------------------------------------------------------------------------------------------
                Guid projectID = ((DataTagDisplay)treeViewCurrentProjectExplorer.SelectedNode.Tag).ProjectID;
                projectViewModelObj.DeleteProject(projectID);

                //-----------------------------------------------------------------------------
                //--- Delete the Selected Project Tree Node and All Sub Nodes from the Tree ---
                //-----------------------------------------------------------------------------
                DeleteSelectedNode();

            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // HandleDeleteProject

        #region HandleDeleteProfile
        /// <summary>
        /// Common Delete Profile Command Handler. 
        /// </summary>
        private void HandleDeleteProfile()
        {
            string strMethod = "HandleDeleteProfile";
            try
            {
                //-----------------------------------------
                //--- Delete Profile Data from Database ---
                //-----------------------------------------
                HenMsgDlg.DisplayWarningDlg("Delete PROFILE Data from Database");

                //-----------------------------------------------------------------------------
                //--- Delete the Selected Profile Tree Node and All Sub Nodes from the Tree ---
                //-----------------------------------------------------------------------------
                DeleteSelectedNode();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // HandleDeleteProfile

        #region HandleDeleteStudy
        /// <summary>
        /// Common Delete Study Command Handler. 
        /// </summary>
        private void HandleDeleteStudy()
        {
            string strMethod = "HandleDeleteStudy";
            try
            {
                //---------------------------------------
                //--- Delete Study Data from Database ---
                //---------------------------------------
                HenMsgDlg.DisplayWarningDlg("Delete STUDY Data from Database");

                //---------------------------------------------------------------------------
                //--- Delete the Selected Study Tree Node and All Sub Nodes from the Tree ---
                //---------------------------------------------------------------------------
                DeleteSelectedNode();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // HandleDeleteStudy

        #endregion  // HANDLE DELETE NODE EVENTS

        #region ADD NODE METHODS

        #region AddProjectNode()
        /// <summary>
        /// Create and Add a Project Node to the Tree
        /// </summary>
        /// <param name="parentNode">Parent node ... for Project-> Root Node</param>
        /// <param name="strDisplayName">Display name of the new Project node</param>
        /// <param name="dataTagDisplayObj">Tag object for the new Project node</param>
        /// <returns>Node Id for the new Project node</returns>
        private int AddProjectNode(TreeNode parentNode, string strDisplayName, DataTagDisplay dataTagDisplayObj)
        {
            string strMethod = "AddProjectNode";
            string strMsg = String.Empty;
            int nProjectNodeID = 0;     
            try
            {
                treeViewCurrentProjectExplorer.BeginUpdate();
                //------------------------------------------
                //-- Create New Node and Add to the Tree ---
                //------------------------------------------
                TreeNode node = new TreeNode(strDisplayName);
                node.ContextMenuStrip = this.contextMenuStripCurrProj;

                node.ImageIndex = 1;            // Project_16x16.ico ......... imageListProjectTreeViews
                node.SelectedImageIndex = 2;    // OpenedProject_16x16.ico ... imageListProjectTreeViews

                nProjectNodeID = parentNode.Nodes.Add(node);

                //------------------------------------
                //-- Assign Tag Object to New Node ---
                //------------------------------------
                node.Tag = dataTagDisplayObj;

                //---------------------------------------
                //--- Update Current Tree-Panel State ---
                //---------------------------------------
                UpdateTreeStatusBar(node);

                //-----------------------------
                //--- Display Project Panel ---
                //-----------------------------
                this.panelSELECTED_PROJECT.BringToFront();

                //-----------------------------------
                //--- Display and Select New Node ---
                //-----------------------------------
                treeViewCurrentProjectExplorer.SelectedNode = node;
                node.EnsureVisible();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                treeViewCurrentProjectExplorer.EndUpdate();
            }
            return nProjectNodeID;
        }
        #endregion  // AddProjectNode()

        #region AddProfileNode()
        /// <summary>
        /// Create and Add a Profile Node to the Tree
        /// </summary>
        /// <param name="parentNode">Parent node ... for Profile-> Selected Project Node</param>
        /// <param name="strDisplayName">Display name of the new Profile node</param>
        /// <param name="dataTagDisplayObj">Tag object for the new Profile node</param>
        /// <returns>Node Id for the new Profile node</returns>
        private int AddProfileNode(TreeNode parentNode, string strDisplayName, DataTagDisplay dataTagDisplayObj)
        {
            string strMethod = "AddProfileNode";
            string strMsg = String.Empty;
            int nProfileNodeID = 0;
            string strProjectName = string.Empty;
            try
            {
                treeViewCurrentProjectExplorer.BeginUpdate();
                //------------------------------------------
                //-- Create New Node and Add to the Tree ---
                //------------------------------------------
                TreeNode node = new TreeNode(strDisplayName);
                node.ContextMenuStrip = this.contextMenuStripProfile;

                node.ImageIndex = 3;            // Profile_Input_16x16.ico ............ imageListProjectTreeViews
                node.SelectedImageIndex = 4;    // Profile_Input_Selected_16x16.ico ... imageListProjectTreeViews

                nProfileNodeID = parentNode.Nodes.Add(node);

                //------------------------------------
                //-- Assign Tag Object to New Node ---
                //------------------------------------
                node.Tag = dataTagDisplayObj;

                //---------------------------------------
                //--- Update Current Tree-Panel State ---
                //---------------------------------------
                UpdateTreeStatusBar(node);

                //--------------------------------------
                //--- Populate Current Project Panel ---
                //--------------------------------------
                HenMsgDlg.DisplayWarningDlg("***** Populate Current Panel *****");

                //-----------------------------
                //--- Display Profile Panel ---
                //-----------------------------
                this.panelSELECTED_PROFILE.BringToFront();

                //-----------------------------------
                //--- Display and Select New Node ---
                //-----------------------------------
                treeViewCurrentProjectExplorer.SelectedNode = node;
                node.EnsureVisible();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                treeViewCurrentProjectExplorer.EndUpdate();
            }
            return nProfileNodeID;
        }
        #endregion  // AddProfileNode()

        #region AddStudyNode()
        /// <summary>
        /// Create and Add a Study Node to the Tree
        /// </summary>
        /// <param name="parentNode">Parent node ... for Study-> Selected Project Node</param>
        /// <param name="strDisplayName">Display name of the new Study node</param>
        /// <param name="dataTagDisplayObj">Tag object for the new Study node</param>
        /// <returns>Node Id for the new Study node</returns>
        private int AddStudyNode(TreeNode parentNode, string strDisplayName, DataTagDisplay dataTagDisplayObj)
        {
            string strMethod = "AddStudyNode";
            string strMsg = String.Empty;
            int nStudyNodeID = 0;
            string strProjectName = string.Empty;
            try
            {
                treeViewCurrentProjectExplorer.BeginUpdate();
                //------------------------------------------
                //-- Create New Node and Add to the Tree ---
                //------------------------------------------
                TreeNode node = new TreeNode(strDisplayName);
                //node.ContextMenuStrip = this.contextMenuStripStudy;

                node.ImageIndex = 3;            // Study_Input_16x16.ico ............ imageListProjectTreeViews
                node.SelectedImageIndex = 4;    // Study_Input_Selected_16x16.ico ... imageListProjectTreeViews

                nStudyNodeID = parentNode.Nodes.Add(node);

                //------------------------------------
                //-- Assign Tag Object to New Node ---
                //------------------------------------
                node.Tag = dataTagDisplayObj;

                //---------------------------------------
                //--- Update Current Tree-Panel State ---
                //---------------------------------------
                UpdateTreeStatusBar(node);

                //--------------------------------------
                //--- Populate Current Project Panel ---
                //--------------------------------------
                HenMsgDlg.DisplayWarningDlg("***** Populate Current Panel *****");

                //-----------------------------
                //-----------------------------
                //--- Display Study Panel ---
                //-----------------------------
                //this.panelSELECTED_STUDY.BringToFront();

                //-----------------------------------
                //--- Display and Select New Node ---
                //-----------------------------------
                treeViewCurrentProjectExplorer.SelectedNode = node;
                node.EnsureVisible();
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
                treeViewCurrentProjectExplorer.EndUpdate();
            }
            return nStudyNodeID;
        }
        #endregion  // AddStudyNode()

        #endregion  // ADD NODE METHODS

        #endregion  // COMMON EVENT HANDLERS

        #region LOG TREE METHODS

        #region LogTree()
        /// <summary>
        /// Log Tree
        /// </summary>
        private void LogTree()
        {
            string strMethod = "LogTree";
            string strMsg = String.Empty;
            TreeNode node;
            try
            {
                node = GetRootNode();
                //-----------------------------------
                //--- Visit Each Node Recursively ---
                //-----------------------------------
                LogTreeRecursive(node);
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // LogTree()

        #region LogTreeRecursive()
        /// <summary>
        /// Log Tree
        /// </summary>
        private void LogTreeRecursive(TreeNode node)
        {
            string strMethod = "LogTreeRecursive";
            string strMsg = String.Empty;
            ExplorerNodeIdType explorerNodeIdType = ExplorerNodeIdType.CATALOG;
            try
            {
                explorerNodeIdType = ((DataTagDisplay)node.Tag).NodeIdEnum;

                switch (explorerNodeIdType)
                {
                    case ExplorerNodeIdType.CATALOG:
                        strMsg = string.Format("  > {0}", node.Text);
                        break;
                    case ExplorerNodeIdType.PROJECT:
                        strMsg = string.Format("    + {0}", node.Text);
                        break;
                    case ExplorerNodeIdType.PROFILE:
                        strMsg = string.Format("      + {0}", node.Text);
                        break;
                    case ExplorerNodeIdType.STUDY:
                        strMsg = string.Format("      + {0}", node.Text);
                        break;
                    default:
                        break;
                }
                HenLogger.LogInfo(NAMESPACE, CLASS, strMethod, strMsg);
                //-----------------------------------
                //--- Visit Each Node Recursively ---
                //-----------------------------------
                foreach (TreeNode tn in node.Nodes)
                {
                    LogTreeRecursive(tn);
                }
            }
            catch (Exception ex)
            {
                HenLogger.WriteSeparatorLine('*');
                HenLogger.LogError(NAMESPACE, CLASS, strMethod, String.Format("EXCEPTION: {0}", ex.Message));
                HenLogger.WriteSeparatorLine('*');
            }
            finally
            {
            }
        }
        #endregion  // LogTreeRecursive()

        #endregion  // LOG TREE METHODS

    }
    #endregion  // partial class FormMain
}
#endregion  // namespace HenStudio

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
