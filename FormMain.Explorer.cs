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

using HenGlobal;

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
        /// Remove all Nodes from the Tree and then Add back Root Projects (CATALOG) Node
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
                TreeNode rootNode = new TreeNode("HEN Studio CATALOG");

                //----------------------------------
                //--- Assign New Node Attributes ---
                //----------------------------------
                rootNode.ContextMenuStrip = contextMenuStripProjectCatalog;

                //-----------------------------------------------
                //-- Create Tag Object and Assign to New Node ---
                //-----------------------------------------------
                DataTagDisplay dataTagDisplayObj = new DataTagDisplay(ExplorerLevel.CATALOG, "HEN Studio CATALOG");
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
            HenTypes.ExplorerLevel level = ExplorerLevel.UNKNOWN;
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

                level = dataTagDisplayObj.LevelEnum;
                HenSettingsObj.ExplorerSelectedLevelEnum = level;
                switch(level)
                {
                    case ExplorerLevel.CATALOG:
                        HenSettingsObj.CurrentProjectName = strProjectName;
                        HenSettingsObj.CurrentProfileName = strProfileName;
                        HenSettingsObj.CurrentPinchName = strPinchName;
                        HenSettingsObj.CurrentHenName = dataTagDisplayObj.NodeName;
                        break;

                        case ExplorerLevel.PROJECT:
                        strProjectName = dataTagDisplayObj.NodeName;
                        HenSettingsObj.CurrentProjectName = strProjectName;
                        HenSettingsObj.CurrentProfileName = strProfileName;
                        HenSettingsObj.CurrentPinchName = strPinchName;
                        HenSettingsObj.CurrentHenName = dataTagDisplayObj.NodeName;
                        break;

                        case ExplorerLevel.PROFILE:
                        strProjectName = ((DataTagDisplay)node.Parent.Tag).NodeName;
                        strProfileName = dataTagDisplayObj.NodeName;
                        HenSettingsObj.CurrentProjectName = strProjectName;
                        HenSettingsObj.CurrentProfileName = strProfileName;
                        HenSettingsObj.CurrentPinchName = strPinchName;
                        HenSettingsObj.CurrentHenName = dataTagDisplayObj.NodeName;
                        break;

                        case ExplorerLevel.PINCH:
                        strProjectName = ((DataTagDisplay)node.Parent.Parent.Tag).NodeName;
                        strProfileName = ((DataTagDisplay)node.Parent.Tag).NodeName;
                        strPinchName = dataTagDisplayObj.NodeName;
                        HenSettingsObj.CurrentProjectName = strProjectName;
                        HenSettingsObj.CurrentProfileName = strProfileName;
                        HenSettingsObj.CurrentPinchName = strPinchName;
                        HenSettingsObj.CurrentHenName = dataTagDisplayObj.NodeName;
                        break;

                        case ExplorerLevel.HEN:
                        strProjectName = ((DataTagDisplay)node.Parent.Parent.Parent.Tag).NodeName;
                        strProfileName = ((DataTagDisplay)node.Parent.Parent.Tag).NodeName;
                        strPinchName = ((DataTagDisplay)node.Parent.Tag).NodeName;
                        strHenName = dataTagDisplayObj.NodeName;
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
                //--------------------------------------------
                //--- Update Current Tree-Status Bar State ---
                //--------------------------------------------
                UpdateProjectLevelStatusBarLabel();    // Initialize Catalog-Project Level Status Bar Label
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
            ExplorerLevel level = ExplorerLevel.UNKNOWN;
            try
            {
                //--------------------------
                //--- Get Node and Level ---
                //--------------------------
                TreeNode node = treeViewCurrentProjectExplorer.SelectedNode;
                if (node == null) return;  // Null Guard

                DataTagDisplay dataTagDisplayObj = ((DataTagDisplay)node.Tag);
                if(dataTagDisplayObj == null ) return;  // Null Guard

                level = dataTagDisplayObj.LevelEnum;

                //---------------------------------------
                //--- Update Current Tree-Panel State ---
                //---------------------------------------
                UpdateTreeStatusBar(node);

                #region Popluate and Display Panels
                //-----------------------------------
                //--- Popluate and Display Panels ---
                //-----------------------------------
                switch (level)
                {
                    #region CATALOG (PROJECTS)
                    case ExplorerLevel.CATALOG:
                        //-------------------------------------------------
                        //--- Populate Current Projects (CATALOG) Panel ---
                        //-------------------------------------------------
                        HenMsgDlg.DisplayWarningDlg("***** Populate Current PROJECTS (CATALOG) Panel *****");


                        //----------------------------------------
                        //--- Display Projects (CATALOG) Panel ---
                        //----------------------------------------
                        this.panelSELECTED_PROJECTS.BringToFront();
                        break;
                    #endregion  // CATALOG (PROJECTS)

                    #region PROJECT
                    case ExplorerLevel.PROJECT:
                        //--------------------------------------
                        //--- Populate Current Project Panel ---
                        //--------------------------------------
                        HenMsgDlg.DisplayWarningDlg("***** Populate Current PROJECT Panel *****");


                        //-----------------------------
                        //--- Display Project Panel ---
                        //-----------------------------
                        this.panelSELECTED_PROJECT.BringToFront();
                        break;
                    #endregion  // PROJECT

                    #region PROFILE
                    case ExplorerLevel.PROFILE:
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

                    #region PINCH
                    case ExplorerLevel.PINCH:
                        //------------------------------------
                        //--- Populate Current Pinch Panel ---
                        //------------------------------------
                        HenMsgDlg.DisplayWarningDlg("***** Populate Current PINCH Panel *****");


                        //---------------------------
                        //--- Display Pinch Panel ---
                        //---------------------------
                        this.panelSELECTED_PINCH.BringToFront();
                        break;
                    #endregion  // PINCH

                    #region HEN
                    case ExplorerLevel.HEN:
                        //----------------------------------
                        //--- Populate Current Hen Panel ---
                        //----------------------------------
                        HenMsgDlg.DisplayWarningDlg("***** Populate Current HEN Panel *****");


                        //-------------------------
                        //--- Display HEN Panel ---
                        //-------------------------
                        this.panelSELECTED_HEN.BringToFront();

                        break;
                    #endregion  // HEN

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

        #region NEW NODES

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

        #endregion  // NEW NODES

        #region DELETE NODES

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

        #endregion  // DELETE NODES

        #region RENAME NODES

        #region RENAME PROJECT
        private void toolStripMenuItemCurProjRename_Click(object sender, EventArgs e)
        {
            HandleRenameProject();
        }
        #endregion  // RENAME PROJECT

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

        #endregion  // CONTEXT MENU EVENT HANDLERS

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

        #endregion      // TREE VIEW EVENT HANDLERS

        #region COMMON EVENT HANDLERS

        #region HANDLE NEW NODE EVENTS

        #region HandleNewProject
        /// <summary>
        /// Common New Command Handler. Display New Project Form to capture display Name
        /// </summary>
        private void HandleNewProject()
        {
            string strMethod = "HandleNewProject";
            string strNodeName = string.Empty;      // Node name no Prefix ... From New Dialog Name field
            string strDisplayName = string.Empty;   // Includes Prefix (e.g., "Project: *")
            int nDisplayNodeID = 0;
            Guid projectGUID = Guid.Empty;          // DB Project GUID (PK)
            try
            {
                //--------------------------------
                //--- Display New Project Form ---
                //--------------------------------
                FormNewProject dlg = new FormNewProject();
                if(dlg.ShowDialog()!=DialogResult.OK) return;   // User Canceled Dialog

                //*********************************************************************************
                //***** Scrape Dialog Data and SAVE to DB                                     *****
                //***** Get DB ProjectID (PK)                                                 *****            
                //*********************************************************************************
                HenMsgDlg.DisplayWarningDlg("***** Scrape Dialog Data and SAVE to DB *****");
                HenMsgDlg.DisplayWarningDlg("***** Get DB ProjectID (PK) *****");
                strNodeName = "Deer Park";      // From New Dialog ... Name Field
                strDisplayName = "Project: Deer Park";  // Node name with prefix ("Project: ")
                projectGUID = new Guid();
                //********************************************************************** TEST *****

                //-------------------------------------------------------
                //-- Create Node Tag Object and Assign Tag Attributes ---
                //-------------------------------------------------------
                DataTagDisplay dataTagDisplayObj = new DataTagDisplay(ExplorerLevel.PROJECT, 
                                                                      strNodeName);
                dataTagDisplayObj.ProjectID = projectGUID;

                //---------------------------------------------------
                //--- Get Parent (Root) Node and Add Project Node ---
                //---------------------------------------------------
                TreeNode parentNode = GetRootNode();
                nDisplayNodeID = AddProjectNode(parentNode, strDisplayName, dataTagDisplayObj);

                //------------------------------
                //--- Set Project Dirty Flag ---
                //------------------------------
                HenSettingsObj.ProjectDirtyFlagStateEnum = ProjectDirtyFlagState.DIRTY;
                UpdateProjectDirtyFlagLabel();
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
                DataTagDisplay dataTagDisplayObj = new DataTagDisplay(ExplorerLevel.PROFILE,
                                                                      strNodeName);
                dataTagDisplayObj.ProfileID = profileGUID;

                //------------------------------------------------------
                //--- Get Parent (Project) Node and Add Profile Node ---
                //------------------------------------------------------
                TreeNode parentNode = GetSelectedNode();
                nProfileNodeID = AddProfileNode(parentNode, strDisplayName, dataTagDisplayObj);

                //------------------------------
                //--- Set Project Dirty Flag ---
                //------------------------------
                HenSettingsObj.ProjectDirtyFlagStateEnum = ProjectDirtyFlagState.DIRTY;
                UpdateProjectDirtyFlagLabel();
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

        #region HandleNewPinch
        /// <summary>
        /// Common New Command Handler. Display New Pinch Form to capture display Name
        /// </summary>
        private void HandleNewPinch()
        {
            string strMethod = "HandleNewPinch";
            string strNodeName = string.Empty;      // Node name no Prefix ... From New Dialog Name field
            string strDisplayName = string.Empty;   // Includes Prefix (e.g., "Pinch: *")
            int nPinchNodeID = 0;
            Guid pinchGUID = Guid.Empty;            // DB Pinch GUID (PK)
            try
            {
                //------------------------------
                //--- Display New Pinch Form ---
                //------------------------------
                HenMsgDlg.DisplayWarningDlg("***** Display New Pinch Form *****");
                //FormNewPinch dlg = new FormNewPinch();
                //if (dlg.ShowDialog() != DialogResult.OK) return;   // User Canceled Dialog

                //*********************************************************************************
                //***** Scrape Dialog Data and SAVE to DB                                     *****
                //***** Get DB PinchID (PK)                                                   *****            
                //*********************************************************************************
                HenMsgDlg.DisplayWarningDlg("***** Scrape Dialog Data and SAVE to DB *****");
                HenMsgDlg.DisplayWarningDlg("***** Get DB PinchID (PK) *****");
                strNodeName = "Delta T = 10";      // From New Dialog ... Name Field
                strDisplayName = "Pinch: Delta T = 10";  // Node name with prefix ("Pinch: ")
                pinchGUID = new Guid();
                //********************************************************************** TEST *****

                //-------------------------------------------------------
                //-- Create Node Tag Object and Assign Tag Attributes ---
                //-------------------------------------------------------
                DataTagDisplay dataTagDisplayObj = new DataTagDisplay(ExplorerLevel.PINCH,
                                                                      strNodeName);
                dataTagDisplayObj.PinchID = pinchGUID;

                //----------------------------------------------------
                //--- Get Parent (Profile) Node and Add Pinch Node ---
                //----------------------------------------------------
                TreeNode parentNode = GetSelectedNode();
                nPinchNodeID = AddPinchNode(parentNode, strDisplayName, dataTagDisplayObj);

                //------------------------------
                //--- Set Project Dirty Flag ---
                //------------------------------
                HenSettingsObj.ProjectDirtyFlagStateEnum = ProjectDirtyFlagState.DIRTY;
                UpdateProjectDirtyFlagLabel();
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
        #endregion  // HandleNewPinch

        #region HandleNewHen
        /// <summary>
        /// Common New Command Handler. Display New Hen Form to capture display Name
        /// </summary>
        private void HandleNewHen()
        {
            string strMethod = "HandleNewHen";
            string strNodeName = string.Empty;      // Node name no Prefix ... From New Dialog Name field
            string strDisplayName = string.Empty;   // Includes Prefix (e.g., "Hen: *")
            int nHenNodeID = 0;
            Guid henGUID = Guid.Empty;              // DB Hen GUID (PK)
            try
            {
                //----------------------------
                //--- Display New Hen Form ---
                //----------------------------
                HenMsgDlg.DisplayWarningDlg("***** Display New Hen Form *****");
                //FormNewHen dlg = new FormNewHen();
                //if (dlg.ShowDialog() != DialogResult.OK) return;   // User Canceled Dialog

                //*********************************************************************************
                //***** Scrape Dialog Data and SAVE to DB                                     *****
                //***** Get DB HenID (PK)                                                     *****            
                //*********************************************************************************
                HenMsgDlg.DisplayWarningDlg("***** Scrape Dialog Data and SAVE to DB *****");
                HenMsgDlg.DisplayWarningDlg("***** Get DB HenID (PK) *****");
                strNodeName = "Base Design";      // From New Dialog ... Name Field
                strDisplayName = "Hen: Base Design";  // Node name with prefix ("Hen: ")
                henGUID = new Guid();
                //********************************************************************** TEST *****

                //-------------------------------------------------------
                //-- Create Node Tag Object and Assign Tag Attributes ---
                //-------------------------------------------------------
                DataTagDisplay dataTagDisplayObj = new DataTagDisplay(ExplorerLevel.HEN,
                                                                      strNodeName);
                dataTagDisplayObj.HenID = henGUID;

                //------------------------------------------------
                //--- Get Parent (Pinch) Node and Add Hen Node ---
                //------------------------------------------------
                TreeNode parentNode = GetSelectedNode();
                nHenNodeID = AddHenNode(parentNode, strDisplayName, dataTagDisplayObj);

                //------------------------------
                //--- Set Project Dirty Flag ---
                //------------------------------
                HenSettingsObj.ProjectDirtyFlagStateEnum = ProjectDirtyFlagState.DIRTY;
                UpdateProjectDirtyFlagLabel();
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
        #endregion  // HandleNewHen

        #endregion  // HANDLE NEW NODE EVENTS

        #region HANDLE DELETE NODE EVENTS

        #region HandleDeleteProject
        /// <summary>
        /// Common Delete Project Command Handler. 
        /// </summary>
        private void HandleDeleteProject()
        {
            string strMethod = "HandleDeleteProject";
            try
            {
                //-----------------------------------------
                //--- Delete Project Data from Database ---
                //-----------------------------------------
                HenMsgDlg.DisplayWarningDlg("Delete PROJECT Data from Database");

                //-----------------------------------------------------------------------------
                //--- Delete the Selected Project Tree Node and All Sub Nodes from the Tree ---
                //-----------------------------------------------------------------------------
                DeleteSelectedNode();

                //------------------------------
                //--- Set Project Dirty Flag ---
                //------------------------------
                HenSettingsObj.ProjectDirtyFlagStateEnum = ProjectDirtyFlagState.DIRTY;
                UpdateProjectDirtyFlagLabel();
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

                //------------------------------
                //--- Set Project Dirty Flag ---
                //------------------------------
                HenSettingsObj.ProjectDirtyFlagStateEnum = ProjectDirtyFlagState.DIRTY;
                UpdateProjectDirtyFlagLabel();
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

        #region HandleDeletePinch
        /// <summary>
        /// Common Delete Pinch Command Handler. 
        /// </summary>
        private void HandleDeletePinch()
        {
            string strMethod = "HandleDeletePinch";
            try
            {
                //---------------------------------------
                //--- Delete Pinch Data from Database ---
                //---------------------------------------
                HenMsgDlg.DisplayWarningDlg("Delete PINCH Data from Database");

                //---------------------------------------------------------------------------
                //--- Delete the Selected Pinch Tree Node and All Sub Nodes from the Tree ---
                //---------------------------------------------------------------------------
                DeleteSelectedNode();

                //------------------------------
                //--- Set Project Dirty Flag ---
                //------------------------------
                HenSettingsObj.ProjectDirtyFlagStateEnum = ProjectDirtyFlagState.DIRTY;
                UpdateProjectDirtyFlagLabel();
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
        #endregion  // HandleDeletePinch

        #region HandleDeleteHen
        /// <summary>
        /// Common Delete HEN Command Handler. 
        /// </summary>
        private void HandleDeleteHen()
        {
            string strMethod = "HandleDeleteHen";
            try
            {
                //-------------------------------------
                //--- Delete HEN Data from Database ---
                //-------------------------------------
                HenMsgDlg.DisplayWarningDlg("Delete HEN Data from Database");

                //-------------------------------------------------------
                //--- Delete the Selected HEN Tree Node from the Tree ---
                //-------------------------------------------------------
                DeleteSelectedNode();

                //------------------------------
                //--- Set Project Dirty Flag ---
                //------------------------------
                HenSettingsObj.ProjectDirtyFlagStateEnum = ProjectDirtyFlagState.DIRTY;
                UpdateProjectDirtyFlagLabel();
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
        #endregion  // HandleDeleteHen

        #endregion  // HANDLE DELETE NODE EVENTS

        #region HANDLE RENAME NODE EVENTS

        #region HandleRenameProject
        /// <summary>
        /// Common Rename Project Command Handler. Rename User Specified Node.
        /// </summary>
        private void HandleRenameProject()
        {
            string strMethod = "HandleRenameProject";
            string strRenameFormTitle = "Rename PROJECT ";
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

                //---------------------------------------
                //--- Rename Project Data in Database ---
                //---------------------------------------
                HenMsgDlg.DisplayWarningDlg("RENAME PROJECT Data in Database");

                //---------------------------------------------
                //--- Rename the Selected Project Tree Node ---
                //---------------------------------------------
                FormRename dlg = new FormRename(strRenameFormTitle, ((DataTagDisplay)node.Tag).NodeName);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    strNewNodeName = dlg.NewNodeName;
                    strNewDisplayName = string.Format("Project: {0}", dlg.NewNodeName);

                    node.Text = strNewDisplayName;
                    ((DataTagDisplay)node.Tag).NodeName = strNewNodeName.Trim();
                }

                //------------------------------
                //--- Set Project Dirty Flag ---
                //------------------------------
                HenSettingsObj.ProjectDirtyFlagStateEnum = ProjectDirtyFlagState.DIRTY;
                UpdateProjectDirtyFlagLabel();
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
        #endregion  // HandleRenameProject

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

                //------------------------------
                //--- Set Project Dirty Flag ---
                //------------------------------
                HenSettingsObj.ProjectDirtyFlagStateEnum = ProjectDirtyFlagState.DIRTY;
                UpdateProjectDirtyFlagLabel();
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

        #region HandleRenamePinch
        /// <summary>
        /// Common Rename Pinch Command Handler. Rename User Specified Node.
        /// </summary>
        private void HandleRenamePinch()
        {
            string strMethod = "HandleRenamePinch";
            string strRenameFormTitle = "Rename PINCH ";
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
                if (node == null) throw new Exception("Null Pinch Node Encountered!");

                //-------------------------------------
                //--- Rename Pinch Data in Database ---
                //-------------------------------------
                HenMsgDlg.DisplayWarningDlg("RENAME PINCH Data in Database");

                //-------------------------------------------
                //--- Rename the Selected Pinch Tree Node ---
                //-------------------------------------------
                FormRename dlg = new FormRename(strRenameFormTitle, ((DataTagDisplay)node.Tag).NodeName);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    strNewNodeName = dlg.NewNodeName;
                    strNewDisplayName = string.Format("Pinch: {0}", dlg.NewNodeName);

                    node.Text = strNewDisplayName;
                    ((DataTagDisplay)node.Tag).NodeName = strNewNodeName.Trim();
                }

                //------------------------------
                //--- Set Project Dirty Flag ---
                //------------------------------
                HenSettingsObj.ProjectDirtyFlagStateEnum = ProjectDirtyFlagState.DIRTY;
                UpdateProjectDirtyFlagLabel();
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
        #endregion  // HandleRenamePinch

        #region HandleRenameHen
        /// <summary>
        /// Common Rename Hen Command Handler. Rename User Specified Node.
        /// </summary>
        private void HandleRenameHen()
        {
            string strMethod = "HandleRenameHen";
            string strRenameFormTitle = "Rename HEN ";
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
                if (node == null) throw new Exception("Null Hen Node Encountered!");

                //-----------------------------------
                //--- Rename Hen Data in Database ---
                //-----------------------------------
                HenMsgDlg.DisplayWarningDlg("RENAME HEN Data in Database");

                //-----------------------------------------
                //--- Rename the Selected Hen Tree Node ---
                //-----------------------------------------
                FormRename dlg = new FormRename(strRenameFormTitle, ((DataTagDisplay)node.Tag).NodeName);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    strNewNodeName = dlg.NewNodeName;
                    strNewDisplayName = string.Format("Hen: {0}", dlg.NewNodeName);

                    node.Text = strNewDisplayName;
                    ((DataTagDisplay)node.Tag).NodeName = strNewNodeName.Trim();
                }

                //------------------------------
                //--- Set Project Dirty Flag ---
                //------------------------------
                HenSettingsObj.ProjectDirtyFlagStateEnum = ProjectDirtyFlagState.DIRTY;
                UpdateProjectDirtyFlagLabel();
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
        #endregion  // HandleRenameHen

        #endregion  // HANDLE RENAME NODE EVENTS

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

                //--------------------------------------
                //--- Populate Current Project Panel ---
                //--------------------------------------
                HenMsgDlg.DisplayWarningDlg("***** Populate Current Panel *****");

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

        #region AddPinchNode()
        /// <summary>
        /// Create and Add a Pinch Node to the Tree
        /// </summary>
        /// <param name="parentNode">Parent node ... for Pinch-> Selected Profile Node</param>
        /// <param name="strDisplayName">Display name of the new Pinch node</param>
        /// <param name="dataTagDisplayObj">Tag object for the new Pinch node</param>
        /// <returns>Node Id for the new Pinch node</returns>
        private int AddPinchNode(TreeNode parentNode, string strDisplayName, DataTagDisplay dataTagDisplayObj)
        {
            string strMethod = "AddPinchNode";
            string strMsg = String.Empty;
            int nPinchNodeID = 0;
            string strProjectName = string.Empty;
            string strProfileName = string.Empty;
            try
            {
                treeViewCurrentProjectExplorer.BeginUpdate();
                //------------------------------------------
                //-- Create New Node and Add to the Tree ---
                //------------------------------------------
                TreeNode node = new TreeNode(strDisplayName);
                node.ContextMenuStrip = this.contextMenuStripPinch;

                node.ImageIndex = 5;            // Pinch_16x16.ico ........... imageListProjectTreeViews
                node.SelectedImageIndex = 6;    // PinchSelected_16x16.ico ... imageListProjectTreeViews

                nPinchNodeID = parentNode.Nodes.Add(node);

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

                //---------------------------
                //--- Display Pinch Panel ---
                //---------------------------
                this.panelSELECTED_PINCH.BringToFront();

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
            return nPinchNodeID;
        }
        #endregion  // AddPinchNode()

        #region AddHenNode()
        /// <summary>
        /// Create and Add a Hen Node to the Tree
        /// </summary>
        /// <param name="parentNode">Parent node ... for Hen-> Selected Pinch Node</param>
        /// <param name="strDisplayName">Display name of the new Hen node</param>
        /// <param name="dataTagDisplayObj">Tag object for the new Hen node</param>
        /// <returns>Node Id for the new Hen node</returns>
        private int AddHenNode(TreeNode parentNode, string strDisplayName, DataTagDisplay dataTagDisplayObj)
        {
            string strMethod = "AddHenNode";
            string strMsg = String.Empty;
            int nHenNodeID = 0;
            string strProjectName = string.Empty;
            string strProfileName = string.Empty;
            string strPinchName = string.Empty;
            try
            {
                treeViewCurrentProjectExplorer.BeginUpdate();
                //------------------------------------------
                //-- Create New Node and Add to the Tree ---
                //------------------------------------------
                TreeNode node = new TreeNode(strDisplayName);
                node.ContextMenuStrip = this.contextMenuStripHen;

                node.ImageIndex = 7;            // HEN_16x16.ico ........... imageListProjectTreeViews
                node.SelectedImageIndex = 8;    // HENSelected_16x16.ico ... imageListProjectTreeViews

                nHenNodeID = parentNode.Nodes.Add(node);

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

                //-------------------------
                //--- Display Hen Panel ---
                //-------------------------
                this.panelSELECTED_HEN.BringToFront();

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

                //LogTree();  //***** TEST *****
            }
            return nHenNodeID;
        }
        #endregion  // AddHenNode()

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
            ExplorerLevel level = ExplorerLevel.CATALOG;
            try
            {
                level = ((DataTagDisplay)node.Tag).LevelEnum;

                switch (level)
                {
                    case ExplorerLevel.CATALOG:
                        strMsg = string.Format("  > {0}", node.Text);
                        break;
                    case ExplorerLevel.PROJECT:
                        strMsg = string.Format("    + {0}", node.Text);
                        break;
                    case ExplorerLevel.PROFILE:
                        strMsg = string.Format("      + {0}", node.Text);
                        break;
                    case ExplorerLevel.PINCH:
                        strMsg = string.Format("        + {0}", node.Text);
                        break;
                    case ExplorerLevel.HEN:
                        strMsg = string.Format("          + {0}", node.Text);
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
