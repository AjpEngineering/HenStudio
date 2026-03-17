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
                //----------------------------------
                //--- Remove all Nodes from Tree ---
                //----------------------------------
                treeViewCurrentProjectExplorer.Nodes.Clear();

                //----------------------------------------
                //-- Create Node and Assign Tag Object ---
                //----------------------------------------
                DataTagDisplay dataTagDisplayObj = new DataTagDisplay(0, "Projects", ExplorerLevel.CATALOG);
                TreeNode node = new TreeNode("Projects");

                //----------------------------
                //--- Add Node to the Tree ---
                //----------------------------
                nDisplayNodeID = treeViewCurrentProjectExplorer.Nodes.Add(node);

                //------------------------------------
                //--- Update Node Id on Added Node ---
                //------------------------------------
                dataTagDisplayObj.NodeID = nDisplayNodeID;
                node.Tag = dataTagDisplayObj;


                node.ContextMenuStrip = contextMenuStripProjectCatalog;


                //-----------------------------
                //--- Display Selected Node ---
                //-----------------------------
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
            }
        }
        #endregion  // RemoveAllNodes()

        #region PROJECT EXPLORER TREE VIEW EVENT HANDLERS

        #region Context Menu Handlers

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

        #region NEW PROJECT
        private void toolStripMenuItemAddProject_Click(object sender, EventArgs e)
        {
            HandleNewProject();
        }
        #endregion  // NEW PROJECT

        #endregion  // Context Menu Handlers

        #region CollapseAllProjectsExplorer()
        public void CollapseAllProjectsExplorer()
        {
            this.treeViewCurrentProjectExplorer.CollapseAll();
        }
        #endregion  // CollapseAllProjectsExplorer()

        #region ExpandAllProjectsExplorer()
        public void ExpandAllProjectsExplorer()
        {
            this.treeViewCurrentProjectExplorer.ExpandAll();
        }
        #endregion  // ExpandAllProjectsExplorer()

        #endregion      // PROJECT EXPLORER TREE VIEW EVENT HANDLERS

        #region TREE OPERATIONS

        #region AddNode()
        /// <summary>
        /// Add (CREATE) Node to the User Specified Parent Node of the Project Explorer Tree
        /// NOTE: Use DataTagDisplay Object as the Tag Information Object
        /// </summary>
        /// <param name="parent">Parent Tree Node</param>
        /// <param name="dataTagDisplayObj">Data Tag Display Object</param>
        /// <returns>Node ID of node added</returns>
        private int AddNode(TreeNode parent, DataTagDisplay dataTagDisplayObj)
        {
            string strMethod = "AddNode";
            string strMsg = String.Empty;
            int nDisplayNodeID = 0;
            try
            {
                //----------------------------------------
                //-- Create Node and Assign Tag Object ---
                //----------------------------------------
                TreeNode node = new TreeNode(dataTagDisplayObj.DisplayName);

                //----------------------------
                //--- Add Node to the Tree ---
                //----------------------------
                if (parent == null)
                {
                    nDisplayNodeID = treeViewCurrentProjectExplorer.Nodes.Add(node);
                }
                else
                {
                    nDisplayNodeID = parent.Nodes.Add(node);
                }

                //------------------------------------
                //--- Update Node Id on Added Node ---
                //------------------------------------
                dataTagDisplayObj.NodeID = nDisplayNodeID;
                node.Tag = dataTagDisplayObj;

                //-----------------------------
                //--- Display Selected Node ---
                //-----------------------------
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
            }
            return nDisplayNodeID;
        }
        #endregion  // AddNode()

        #region FindNodeById()
        /// <summary>
        /// Find Node in the Tree by User Specified ID
        /// </summary>
        /// <param name="dataTagDisplayObj">Data Tag Display Object</param>
        private TreeNode FindNodeById(int nID)
        {
            string strMethod = "FindNodeById";
            string strMsg = String.Empty;
            try
            {
                foreach (TreeNode root in treeViewCurrentProjectExplorer.Nodes)
                {
                    TreeNode found = FindNodeRecursive(root, nID);
                    if (found != null) { return found; }                    
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
            return null;
        }
        #endregion  // FindNodeById()

        #region FindNodeById()
        /// <summary>
        /// READ Node of the Project Explorer Tree using DataTagDisplay Object
        /// NOTE: Display name is in the user specified DataTagDisplay Object
        /// </summary>
        /// <param name="dataTagDisplayObj">Data Tag Display Object</param>
        private TreeNode FindNodeRecursive(TreeNode node, int nID)
        {
            string strMethod = "FindNodeById";
            string strMsg = String.Empty;
            try
            {
                if (node.Tag is DataTagDisplay info && info.NodeID == nID)
                    return node;

                foreach (TreeNode child in node.Nodes)
                {
                    TreeNode found = FindNodeRecursive(child, nID);
                    if (found != null)
                        return found;
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
            return null;
        }
        #endregion  // FindNodeById()

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

        #endregion  // TREE OPERATIONS


    }
    #endregion  // partial class FormMain
}
#endregion  // namespace HenStudio

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
