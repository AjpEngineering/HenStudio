namespace HenStudio
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Hen: Base Design", 7, 8);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Hen: MER Design", 7, 8);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Pinch: Delta T=10", 5, 6, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Hen: Base Design", 7, 8);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Hen: MER Design", 7, 8);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Pinch: Delta T=20", 5, 6, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Profile: Q1 Setup", 3, 4, new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Pinch: Delta T=10", 5, 6);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Profile: Q2 Setup", 3, 4, new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Profile: Q3 Setup", 3, 4);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Profile: Q4 Setup", 3, 4);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Project: Deer Park", 1, 2, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Project: Convent", 1, 2);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Project: Norco", 1, 2);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("HEN Studio CATALOG", 10, 10, new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Deer Park Analysis - 20260311.zip");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("EXPORT", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("DeerPark Analysis - 20260310");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("IMPORT", new System.Windows.Forms.TreeNode[] {
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Project ZIP Files", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode19});
            this.contextMenuStripHen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCurProjHenRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorCurProjHenRename = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCurProjHenDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripPinch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemPinchAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemPinchRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorRename = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemPinchDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripProfile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemProfileAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemProfileRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemProfileDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripCurrProj = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCurrProjExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCurrProjCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorCurrProjExpandAll = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCurProjSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCurProjAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorCurProjAdd = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCurProjRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemDeleteProject = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripProjectCatalog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorExpandCollapse = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemAddProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMainCatalog = new System.Windows.Forms.MenuStrip();
            this.catalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.importProjectZIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.exitAJPHENStudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseScoreCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.userLicenseAgreementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutAJPHENStudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scorecardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.userLicenseAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMainDASHBOARD = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLICENSE = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCAT_DB = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelProjectDirtyFlag = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLEVEL_PROJECT = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLEVEL_PROFILE = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLEVEL_PINCH = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLEVEL_HEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAJP_LOGO = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageListAnalysis = new System.Windows.Forms.ImageList(this.components);
            this.imageListInput = new System.Windows.Forms.ImageList(this.components);
            this.imageListTargets = new System.Windows.Forms.ImageList(this.components);
            this.imageListHen = new System.Windows.Forms.ImageList(this.components);
            this.splitContainerLefCenter = new System.Windows.Forms.SplitContainer();
            this.splitContainerProject = new System.Windows.Forms.SplitContainer();
            this.treeViewCurrentProjectExplorer = new System.Windows.Forms.TreeView();
            this.imageListProjectTreeViews = new System.Windows.Forms.ImageList(this.components);
            this.treeViewProjectZipExplorer = new System.Windows.Forms.TreeView();
            this.contextMenuStripProjectZip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemZipCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemZipExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListProjectZIP = new System.Windows.Forms.ImageList(this.components);
            this.panelSELECTED_PROJECT = new System.Windows.Forms.Panel();
            this.panelDefaultParmeters = new System.Windows.Forms.Panel();
            this.textBoxDefaultLabel = new System.Windows.Forms.TextBox();
            this.panelExchanger = new System.Windows.Forms.Panel();
            this.textBoxDefaultU_Value = new System.Windows.Forms.TextBox();
            this.textBoxDefaultU_Units = new System.Windows.Forms.TextBox();
            this.textBoxDefaultU = new System.Windows.Forms.TextBox();
            this.textBoxExchangerDefaults = new System.Windows.Forms.TextBox();
            this.panelDefaultHenOptimizer = new System.Windows.Forms.Panel();
            this.textBoxDefaultHenOpitimizer = new System.Windows.Forms.TextBox();
            this.textBoxDefaultHenOptimizerTitle = new System.Windows.Forms.TextBox();
            this.textBoxProjectBanner = new System.Windows.Forms.TextBox();
            this.panelProjectUnits = new System.Windows.Forms.Panel();
            this.textBoxProjectUnitsPress = new System.Windows.Forms.TextBox();
            this.textBoxProjectUnitsTemp = new System.Windows.Forms.TextBox();
            this.textBoxProjectUnitsMagnitude = new System.Windows.Forms.TextBox();
            this.textBoxProjectUnitsSystem = new System.Windows.Forms.TextBox();
            this.textBoxUnitsTitle = new System.Windows.Forms.TextBox();
            this.textBoxUDefinition = new System.Windows.Forms.TextBox();
            this.textBoxUnitsUValue = new System.Windows.Forms.TextBox();
            this.textBoxUnitsU = new System.Windows.Forms.TextBox();
            this.textBoxUnitsCPValue = new System.Windows.Forms.TextBox();
            this.textBoxCPDefinition = new System.Windows.Forms.TextBox();
            this.textBoxUnitsCP = new System.Windows.Forms.TextBox();
            this.textBoxUnitsDutyValue = new System.Windows.Forms.TextBox();
            this.textBoxUnitsDuty = new System.Windows.Forms.TextBox();
            this.textBoxUnitsAreaValue = new System.Windows.Forms.TextBox();
            this.textBoxUnitsArea = new System.Windows.Forms.TextBox();
            this.textBoxUnitsPress = new System.Windows.Forms.TextBox();
            this.textBoxUnitsTemp = new System.Windows.Forms.TextBox();
            this.textBoxUnitsMagnitude = new System.Windows.Forms.TextBox();
            this.pictureBoxUnitsSystem = new System.Windows.Forms.PictureBox();
            this.textBoxUnitsSystem = new System.Windows.Forms.TextBox();
            this.pictureBoxOpenedProject = new System.Windows.Forms.PictureBox();
            this.panelProjectMetadata = new System.Windows.Forms.Panel();
            this.textBoxProjectID = new System.Windows.Forms.TextBox();
            this.textBoxProjectGUID = new System.Windows.Forms.TextBox();
            this.textBoxProjectNameValue = new System.Windows.Forms.TextBox();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.textBoxProjectDescription = new System.Windows.Forms.TextBox();
            this.textBoxProjectDescriptionValue = new System.Windows.Forms.TextBox();
            this.panelSELECTED_PROJECTS = new System.Windows.Forms.Panel();
            this.pictureBoxProductLogo = new System.Windows.Forms.PictureBox();
            this.buttonConnection = new System.Windows.Forms.Button();
            this.panelProjectDbFileMetadata = new System.Windows.Forms.Panel();
            this.textBoxConnServerVersionValue = new System.Windows.Forms.TextBox();
            this.textBoxConnServerVersion = new System.Windows.Forms.TextBox();
            this.textBoxConnTimeoutValue = new System.Windows.Forms.TextBox();
            this.textBoxConnTimeout = new System.Windows.Forms.TextBox();
            this.textBoxConnInitCatalogValue = new System.Windows.Forms.TextBox();
            this.textBoxConnInitCatalog = new System.Windows.Forms.TextBox();
            this.textBoxConnWorkstationIDValue = new System.Windows.Forms.TextBox();
            this.textBoxConnWorkstationID = new System.Windows.Forms.TextBox();
            this.textBoxConnUserIDValue = new System.Windows.Forms.TextBox();
            this.textBoxConnUserID = new System.Windows.Forms.TextBox();
            this.textBoxConnPacketSizeValue = new System.Windows.Forms.TextBox();
            this.textBoxConnPacketSize = new System.Windows.Forms.TextBox();
            this.textBoxConnStateValue = new System.Windows.Forms.TextBox();
            this.textBoxConnState = new System.Windows.Forms.TextBox();
            this.textBoxConnDataSourceValue = new System.Windows.Forms.TextBox();
            this.textBoxConnDataSource = new System.Windows.Forms.TextBox();
            this.textBoxDbConnectionTitle = new System.Windows.Forms.TextBox();
            this.pictureBoxProjects = new System.Windows.Forms.PictureBox();
            this.textBoxProjectsBanner = new System.Windows.Forms.TextBox();
            this.panelSELECTED_PROFILE = new System.Windows.Forms.Panel();
            this.tabControlInputPhase = new System.Windows.Forms.TabControl();
            this.tabPageStreams = new System.Windows.Forms.TabPage();
            this.tabPageUtilities = new System.Windows.Forms.TabPage();
            this.tabPageEconomics = new System.Windows.Forms.TabPage();
            this.textBoxInputBanner = new System.Windows.Forms.TextBox();
            this.pictureBoxOpenedProfile = new System.Windows.Forms.PictureBox();
            this.panelSELECTED_HEN = new System.Windows.Forms.Panel();
            this.textBoxHenBanner = new System.Windows.Forms.TextBox();
            this.pictureBoxOpenedHen = new System.Windows.Forms.PictureBox();
            this.panelSELECTED_PINCH = new System.Windows.Forms.Panel();
            this.textBoxPinchBanner = new System.Windows.Forms.TextBox();
            this.pictureBoxOpenedPinch = new System.Windows.Forms.PictureBox();
            this.imageListProject = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStripHen.SuspendLayout();
            this.contextMenuStripPinch.SuspendLayout();
            this.contextMenuStripProfile.SuspendLayout();
            this.contextMenuStripCurrProj.SuspendLayout();
            this.contextMenuStripProjectCatalog.SuspendLayout();
            this.menuStripMainCatalog.SuspendLayout();
            this.statusStripMainDASHBOARD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLefCenter)).BeginInit();
            this.splitContainerLefCenter.Panel1.SuspendLayout();
            this.splitContainerLefCenter.Panel2.SuspendLayout();
            this.splitContainerLefCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProject)).BeginInit();
            this.splitContainerProject.Panel1.SuspendLayout();
            this.splitContainerProject.Panel2.SuspendLayout();
            this.splitContainerProject.SuspendLayout();
            this.contextMenuStripProjectZip.SuspendLayout();
            this.panelSELECTED_PROJECT.SuspendLayout();
            this.panelDefaultParmeters.SuspendLayout();
            this.panelExchanger.SuspendLayout();
            this.panelDefaultHenOptimizer.SuspendLayout();
            this.panelProjectUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnitsSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedProject)).BeginInit();
            this.panelProjectMetadata.SuspendLayout();
            this.panelSELECTED_PROJECTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductLogo)).BeginInit();
            this.panelProjectDbFileMetadata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProjects)).BeginInit();
            this.panelSELECTED_PROFILE.SuspendLayout();
            this.tabControlInputPhase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedProfile)).BeginInit();
            this.panelSELECTED_HEN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedHen)).BeginInit();
            this.panelSELECTED_PINCH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedPinch)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStripHen
            // 
            this.contextMenuStripHen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCurProjHenRename,
            this.toolStripSeparatorCurProjHenRename,
            this.toolStripMenuItemCurProjHenDelete});
            this.contextMenuStripHen.Name = "contextMenuStripHen";
            this.contextMenuStripHen.Size = new System.Drawing.Size(145, 54);
            // 
            // toolStripMenuItemCurProjHenRename
            // 
            this.toolStripMenuItemCurProjHenRename.Image = global::HenStudio.Properties.Resources.Rename_16x16;
            this.toolStripMenuItemCurProjHenRename.Name = "toolStripMenuItemCurProjHenRename";
            this.toolStripMenuItemCurProjHenRename.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItemCurProjHenRename.Text = "Rename HEN";
            this.toolStripMenuItemCurProjHenRename.Click += new System.EventHandler(this.toolStripMenuItemCurProjHenRename_Click);
            // 
            // toolStripSeparatorCurProjHenRename
            // 
            this.toolStripSeparatorCurProjHenRename.Name = "toolStripSeparatorCurProjHenRename";
            this.toolStripSeparatorCurProjHenRename.Size = new System.Drawing.Size(141, 6);
            // 
            // toolStripMenuItemCurProjHenDelete
            // 
            this.toolStripMenuItemCurProjHenDelete.Image = global::HenStudio.Properties.Resources.HenDelete_16x16;
            this.toolStripMenuItemCurProjHenDelete.Name = "toolStripMenuItemCurProjHenDelete";
            this.toolStripMenuItemCurProjHenDelete.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItemCurProjHenDelete.Text = "Delete HEN";
            this.toolStripMenuItemCurProjHenDelete.Click += new System.EventHandler(this.toolStripMenuItemCurProjHenDelete_Click);
            // 
            // contextMenuStripPinch
            // 
            this.contextMenuStripPinch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPinchAdd,
            this.toolStripSeparator15,
            this.toolStripMenuItemPinchRename,
            this.toolStripSeparatorRename,
            this.toolStripMenuItemPinchDelete});
            this.contextMenuStripPinch.Name = "contextMenuStripPinch";
            this.contextMenuStripPinch.Size = new System.Drawing.Size(313, 82);
            // 
            // toolStripMenuItemPinchAdd
            // 
            this.toolStripMenuItemPinchAdd.Image = global::HenStudio.Properties.Resources.HEN_16x16;
            this.toolStripMenuItemPinchAdd.Name = "toolStripMenuItemPinchAdd";
            this.toolStripMenuItemPinchAdd.Size = new System.Drawing.Size(312, 22);
            this.toolStripMenuItemPinchAdd.Text = "Add Heat Exchanger Network (HEN) Design...";
            this.toolStripMenuItemPinchAdd.Click += new System.EventHandler(this.toolStripMenuItemPinchAdd_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(309, 6);
            // 
            // toolStripMenuItemPinchRename
            // 
            this.toolStripMenuItemPinchRename.Image = global::HenStudio.Properties.Resources.Rename_16x16;
            this.toolStripMenuItemPinchRename.Name = "toolStripMenuItemPinchRename";
            this.toolStripMenuItemPinchRename.Size = new System.Drawing.Size(312, 22);
            this.toolStripMenuItemPinchRename.Text = "Rename Pinch";
            this.toolStripMenuItemPinchRename.Click += new System.EventHandler(this.toolStripMenuItemPinchRename_Click);
            // 
            // toolStripSeparatorRename
            // 
            this.toolStripSeparatorRename.Name = "toolStripSeparatorRename";
            this.toolStripSeparatorRename.Size = new System.Drawing.Size(309, 6);
            // 
            // toolStripMenuItemPinchDelete
            // 
            this.toolStripMenuItemPinchDelete.Image = global::HenStudio.Properties.Resources.PinchDelete_16x16;
            this.toolStripMenuItemPinchDelete.Name = "toolStripMenuItemPinchDelete";
            this.toolStripMenuItemPinchDelete.Size = new System.Drawing.Size(312, 22);
            this.toolStripMenuItemPinchDelete.Text = "Delete Pinch";
            this.toolStripMenuItemPinchDelete.Click += new System.EventHandler(this.toolStripMenuItemPinchDelete_Click);
            // 
            // contextMenuStripProfile
            // 
            this.contextMenuStripProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemProfileAdd,
            this.toolStripSeparator14,
            this.toolStripMenuItemProfileRename,
            this.toolStripSeparator4,
            this.toolStripMenuItemProfileDelete});
            this.contextMenuStripProfile.Name = "contextMenuStripProfile";
            this.contextMenuStripProfile.Size = new System.Drawing.Size(172, 82);
            // 
            // toolStripMenuItemProfileAdd
            // 
            this.toolStripMenuItemProfileAdd.Image = global::HenStudio.Properties.Resources.Pinch_16x16;
            this.toolStripMenuItemProfileAdd.Name = "toolStripMenuItemProfileAdd";
            this.toolStripMenuItemProfileAdd.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItemProfileAdd.Text = "Add Pinch Study...";
            this.toolStripMenuItemProfileAdd.Click += new System.EventHandler(this.toolStripMenuItemProfileAdd_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(168, 6);
            // 
            // toolStripMenuItemProfileRename
            // 
            this.toolStripMenuItemProfileRename.Image = global::HenStudio.Properties.Resources.Rename_16x16;
            this.toolStripMenuItemProfileRename.Name = "toolStripMenuItemProfileRename";
            this.toolStripMenuItemProfileRename.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItemProfileRename.Text = "Rename Profile";
            this.toolStripMenuItemProfileRename.Click += new System.EventHandler(this.toolStripMenuItemProfileRename_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(168, 6);
            // 
            // toolStripMenuItemProfileDelete
            // 
            this.toolStripMenuItemProfileDelete.Image = global::HenStudio.Properties.Resources.ProfileDelete_16x16;
            this.toolStripMenuItemProfileDelete.Name = "toolStripMenuItemProfileDelete";
            this.toolStripMenuItemProfileDelete.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItemProfileDelete.Text = "Delete Profile";
            this.toolStripMenuItemProfileDelete.Click += new System.EventHandler(this.toolStripMenuItemProfileDelete_Click);
            // 
            // contextMenuStripCurrProj
            // 
            this.contextMenuStripCurrProj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCurrProjExpandAll,
            this.toolStripMenuItemCurrProjCollapseAll,
            this.toolStripSeparatorCurrProjExpandAll,
            this.toolStripMenuItemCurProjSave,
            this.toolStripSeparator9,
            this.toolStripMenuItemCurProjAdd,
            this.toolStripSeparatorCurProjAdd,
            this.toolStripMenuItemCurProjRename,
            this.toolStripSeparator13,
            this.toolStripMenuItemDeleteProject});
            this.contextMenuStripCurrProj.Name = "contextMenuStripCurrProj";
            this.contextMenuStripCurrProj.Size = new System.Drawing.Size(174, 160);
            // 
            // toolStripMenuItemCurrProjExpandAll
            // 
            this.toolStripMenuItemCurrProjExpandAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCurrProjExpandAll.Image")));
            this.toolStripMenuItemCurrProjExpandAll.Name = "toolStripMenuItemCurrProjExpandAll";
            this.toolStripMenuItemCurrProjExpandAll.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemCurrProjExpandAll.Text = "Expand All";
            this.toolStripMenuItemCurrProjExpandAll.Click += new System.EventHandler(this.toolStripMenuItemCurrProjExpandAll_Click);
            // 
            // toolStripMenuItemCurrProjCollapseAll
            // 
            this.toolStripMenuItemCurrProjCollapseAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCurrProjCollapseAll.Image")));
            this.toolStripMenuItemCurrProjCollapseAll.Name = "toolStripMenuItemCurrProjCollapseAll";
            this.toolStripMenuItemCurrProjCollapseAll.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemCurrProjCollapseAll.Text = "Collapse All";
            this.toolStripMenuItemCurrProjCollapseAll.Click += new System.EventHandler(this.toolStripMenuItemCurrProjCollapseAll_Click);
            // 
            // toolStripSeparatorCurrProjExpandAll
            // 
            this.toolStripSeparatorCurrProjExpandAll.Name = "toolStripSeparatorCurrProjExpandAll";
            this.toolStripSeparatorCurrProjExpandAll.Size = new System.Drawing.Size(170, 6);
            // 
            // toolStripMenuItemCurProjSave
            // 
            this.toolStripMenuItemCurProjSave.Image = global::HenStudio.Properties.Resources.SaveProject_16x16;
            this.toolStripMenuItemCurProjSave.Name = "toolStripMenuItemCurProjSave";
            this.toolStripMenuItemCurProjSave.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemCurProjSave.Text = "Save Project";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(170, 6);
            // 
            // toolStripMenuItemCurProjAdd
            // 
            this.toolStripMenuItemCurProjAdd.Image = global::HenStudio.Properties.Resources.Profile_Input_16x16;
            this.toolStripMenuItemCurProjAdd.Name = "toolStripMenuItemCurProjAdd";
            this.toolStripMenuItemCurProjAdd.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemCurProjAdd.Text = "Add Input Profile...";
            this.toolStripMenuItemCurProjAdd.Click += new System.EventHandler(this.toolStripMenuItemCurProjAdd_Click);
            // 
            // toolStripSeparatorCurProjAdd
            // 
            this.toolStripSeparatorCurProjAdd.Name = "toolStripSeparatorCurProjAdd";
            this.toolStripSeparatorCurProjAdd.Size = new System.Drawing.Size(170, 6);
            // 
            // toolStripMenuItemCurProjRename
            // 
            this.toolStripMenuItemCurProjRename.Image = global::HenStudio.Properties.Resources.Rename_16x16;
            this.toolStripMenuItemCurProjRename.Name = "toolStripMenuItemCurProjRename";
            this.toolStripMenuItemCurProjRename.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemCurProjRename.Text = "Rename Project...";
            this.toolStripMenuItemCurProjRename.Click += new System.EventHandler(this.toolStripMenuItemCurProjRename_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(170, 6);
            // 
            // toolStripMenuItemDeleteProject
            // 
            this.toolStripMenuItemDeleteProject.Image = global::HenStudio.Properties.Resources.ProjectDelete_16x16;
            this.toolStripMenuItemDeleteProject.Name = "toolStripMenuItemDeleteProject";
            this.toolStripMenuItemDeleteProject.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemDeleteProject.Text = "Delete Project";
            this.toolStripMenuItemDeleteProject.Click += new System.EventHandler(this.toolStripMenuItemDeleteProject_Click);
            // 
            // contextMenuStripProjectCatalog
            // 
            this.contextMenuStripProjectCatalog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenuStripProjectCatalog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCollapseAll,
            this.toolStripMenuItemExpandAll,
            this.toolStripSeparatorExpandCollapse,
            this.toolStripMenuItemAddProject,
            this.toolStripSeparator12,
            this.toolStripMenuItemImport});
            this.contextMenuStripProjectCatalog.Name = "contextMenuStripProjectCatalog";
            this.contextMenuStripProjectCatalog.Size = new System.Drawing.Size(180, 104);
            this.contextMenuStripProjectCatalog.Text = "PROJECT CATALOG";
            // 
            // toolStripMenuItemCollapseAll
            // 
            this.toolStripMenuItemCollapseAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCollapseAll.Image")));
            this.toolStripMenuItemCollapseAll.Name = "toolStripMenuItemCollapseAll";
            this.toolStripMenuItemCollapseAll.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuItemCollapseAll.Text = "Collapse All";
            this.toolStripMenuItemCollapseAll.Click += new System.EventHandler(this.toolStripMenuItemCollapseAll_Click);
            // 
            // toolStripMenuItemExpandAll
            // 
            this.toolStripMenuItemExpandAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemExpandAll.Image")));
            this.toolStripMenuItemExpandAll.Name = "toolStripMenuItemExpandAll";
            this.toolStripMenuItemExpandAll.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuItemExpandAll.Text = "Expand All";
            this.toolStripMenuItemExpandAll.Click += new System.EventHandler(this.toolStripMenuItemExpandAll_Click);
            // 
            // toolStripSeparatorExpandCollapse
            // 
            this.toolStripSeparatorExpandCollapse.Name = "toolStripSeparatorExpandCollapse";
            this.toolStripSeparatorExpandCollapse.Size = new System.Drawing.Size(176, 6);
            // 
            // toolStripMenuItemAddProject
            // 
            this.toolStripMenuItemAddProject.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAddProject.Image")));
            this.toolStripMenuItemAddProject.Name = "toolStripMenuItemAddProject";
            this.toolStripMenuItemAddProject.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuItemAddProject.Text = "Add New Project...";
            this.toolStripMenuItemAddProject.Click += new System.EventHandler(this.toolStripMenuItemAddProject_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(176, 6);
            // 
            // toolStripMenuItemImport
            // 
            this.toolStripMenuItemImport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemImport.Image")));
            this.toolStripMenuItemImport.Name = "toolStripMenuItemImport";
            this.toolStripMenuItemImport.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuItemImport.Text = "Import Zip Project...";
            // 
            // menuStripMainCatalog
            // 
            this.menuStripMainCatalog.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMainCatalog.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMainCatalog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStripMainCatalog.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainCatalog.Name = "menuStripMainCatalog";
            this.menuStripMainCatalog.Size = new System.Drawing.Size(1264, 24);
            this.menuStripMainCatalog.TabIndex = 0;
            this.menuStripMainCatalog.Text = "menuStripPinch";
            // 
            // catalogToolStripMenuItem
            // 
            this.catalogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.toolStripSeparator10,
            this.importProjectZIPToolStripMenuItem,
            this.toolStripSeparator11,
            this.exitAJPHENStudioToolStripMenuItem});
            this.catalogToolStripMenuItem.Name = "catalogToolStripMenuItem";
            this.catalogToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.catalogToolStripMenuItem.Text = "Catalog";
            this.catalogToolStripMenuItem.ToolTipText = "Catalog of Projects";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newProjectToolStripMenuItem.Image")));
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.newProjectToolStripMenuItem.Text = "Add New Project...";
            this.newProjectToolStripMenuItem.ToolTipText = "Add New Project to Catalog";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(191, 6);
            // 
            // importProjectZIPToolStripMenuItem
            // 
            this.importProjectZIPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("importProjectZIPToolStripMenuItem.Image")));
            this.importProjectZIPToolStripMenuItem.Name = "importProjectZIPToolStripMenuItem";
            this.importProjectZIPToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.importProjectZIPToolStripMenuItem.Text = "Import ZIP Project...";
            this.importProjectZIPToolStripMenuItem.ToolTipText = "Import Zip Project";
            this.importProjectZIPToolStripMenuItem.Click += new System.EventHandler(this.importProjectZIPToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(191, 6);
            // 
            // exitAJPHENStudioToolStripMenuItem
            // 
            this.exitAJPHENStudioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitAJPHENStudioToolStripMenuItem.Image")));
            this.exitAJPHENStudioToolStripMenuItem.Name = "exitAJPHENStudioToolStripMenuItem";
            this.exitAJPHENStudioToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.exitAJPHENStudioToolStripMenuItem.Text = "Exit AJP HEN Studio";
            this.exitAJPHENStudioToolStripMenuItem.ToolTipText = "Exit Application";
            this.exitAJPHENStudioToolStripMenuItem.Click += new System.EventHandler(this.exitAJPHENStudioToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseViewerToolStripMenuItem,
            this.licenseScoreCardToolStripMenuItem,
            this.toolStripSeparator7,
            this.userLicenseAgreementToolStripMenuItem1,
            this.toolStripSeparator8,
            this.aboutAJPHENStudioToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // licenseViewerToolStripMenuItem
            // 
            this.licenseViewerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("licenseViewerToolStripMenuItem.Image")));
            this.licenseViewerToolStripMenuItem.Name = "licenseViewerToolStripMenuItem";
            this.licenseViewerToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.licenseViewerToolStripMenuItem.Text = "License Viewer...";
            this.licenseViewerToolStripMenuItem.ToolTipText = "Display License Viewer";
            this.licenseViewerToolStripMenuItem.Click += new System.EventHandler(this.licenseViewerToolStripMenuItem_Click);
            // 
            // licenseScoreCardToolStripMenuItem
            // 
            this.licenseScoreCardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("licenseScoreCardToolStripMenuItem.Image")));
            this.licenseScoreCardToolStripMenuItem.Name = "licenseScoreCardToolStripMenuItem";
            this.licenseScoreCardToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.licenseScoreCardToolStripMenuItem.Text = "License Score Card";
            this.licenseScoreCardToolStripMenuItem.ToolTipText = "Display License Score Card";
            this.licenseScoreCardToolStripMenuItem.Click += new System.EventHandler(this.licenseScoreCardToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(225, 6);
            // 
            // userLicenseAgreementToolStripMenuItem1
            // 
            this.userLicenseAgreementToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("userLicenseAgreementToolStripMenuItem1.Image")));
            this.userLicenseAgreementToolStripMenuItem1.Name = "userLicenseAgreementToolStripMenuItem1";
            this.userLicenseAgreementToolStripMenuItem1.Size = new System.Drawing.Size(228, 30);
            this.userLicenseAgreementToolStripMenuItem1.Text = "User License Agreement...";
            this.userLicenseAgreementToolStripMenuItem1.ToolTipText = "Display User-Software License Agreement";
            this.userLicenseAgreementToolStripMenuItem1.Click += new System.EventHandler(this.userLicenseAgreementToolStripMenuItem1_Click_1);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(225, 6);
            // 
            // aboutAJPHENStudioToolStripMenuItem
            // 
            this.aboutAJPHENStudioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutAJPHENStudioToolStripMenuItem.Image")));
            this.aboutAJPHENStudioToolStripMenuItem.Name = "aboutAJPHENStudioToolStripMenuItem";
            this.aboutAJPHENStudioToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.aboutAJPHENStudioToolStripMenuItem.Text = "About AJP HEN Studio...";
            this.aboutAJPHENStudioToolStripMenuItem.ToolTipText = "About AJP HEN Pinch";
            this.aboutAJPHENStudioToolStripMenuItem.Click += new System.EventHandler(this.aboutAJPHENStudioToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.ToolTipText = "Create New Project Database";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.ToolTipText = "Open Existing Project Database";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.ToolTipText = "Save Current Project Database";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.ToolTipText = "Save Current Project Database As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(120, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.importToolStripMenuItem.Text = "Import...";
            this.importToolStripMenuItem.ToolTipText = "Import Project Zip File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exportToolStripMenuItem.Text = "Export...";
            this.exportToolStripMenuItem.ToolTipText = "Export Project Zip File";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(120, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exit Application";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator3,
            this.licenseToolStripMenuItem,
            this.scorecardToolStripMenuItem,
            this.toolStripSeparator6,
            this.userLicenseAgreementToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(198, 6);
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.licenseToolStripMenuItem.Text = "License...";
            this.licenseToolStripMenuItem.ToolTipText = "Launch License Viewer";
            // 
            // scorecardToolStripMenuItem
            // 
            this.scorecardToolStripMenuItem.Name = "scorecardToolStripMenuItem";
            this.scorecardToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.scorecardToolStripMenuItem.Text = "Scorecard...";
            this.scorecardToolStripMenuItem.ToolTipText = "Launch License ScoreCard Viewer";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(198, 6);
            // 
            // userLicenseAgreementToolStripMenuItem
            // 
            this.userLicenseAgreementToolStripMenuItem.Name = "userLicenseAgreementToolStripMenuItem";
            this.userLicenseAgreementToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.userLicenseAgreementToolStripMenuItem.Text = "User License Agreement";
            this.userLicenseAgreementToolStripMenuItem.ToolTipText = "Display User License Agreement";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.ToolTipText = "Launch About Dialog";
            // 
            // statusStripMainDASHBOARD
            // 
            this.statusStripMainDASHBOARD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLICENSE,
            this.toolStripStatusLabelCAT_DB,
            this.toolStripStatusLabelProjectDirtyFlag,
            this.toolStripStatusLabelLEVEL_PROJECT,
            this.toolStripStatusLabelLEVEL_PROFILE,
            this.toolStripStatusLabelLEVEL_PINCH,
            this.toolStripStatusLabelLEVEL_HEN,
            this.toolStripStatusLabelAJP_LOGO});
            this.statusStripMainDASHBOARD.Location = new System.Drawing.Point(0, 639);
            this.statusStripMainDASHBOARD.Margin = new System.Windows.Forms.Padding(3);
            this.statusStripMainDASHBOARD.Name = "statusStripMainDASHBOARD";
            this.statusStripMainDASHBOARD.Size = new System.Drawing.Size(1264, 42);
            this.statusStripMainDASHBOARD.TabIndex = 6;
            // 
            // toolStripStatusLabelLICENSE
            // 
            this.toolStripStatusLabelLICENSE.BackColor = System.Drawing.Color.Green;
            this.toolStripStatusLabelLICENSE.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelLICENSE.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabelLICENSE.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelLICENSE.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelLICENSE.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelLICENSE.Image")));
            this.toolStripStatusLabelLICENSE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelLICENSE.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelLICENSE.Name = "toolStripStatusLabelLICENSE";
            this.toolStripStatusLabelLICENSE.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelLICENSE.Size = new System.Drawing.Size(100, 36);
            this.toolStripStatusLabelLICENSE.Text = "LICENSE ";
            this.toolStripStatusLabelLICENSE.Click += new System.EventHandler(this.toolStripStatusLabelLICENSE_Click);
            this.toolStripStatusLabelLICENSE.DoubleClick += new System.EventHandler(this.toolStripStatusLabelLICENSE_DoubleClick);
            // 
            // toolStripStatusLabelCAT_DB
            // 
            this.toolStripStatusLabelCAT_DB.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelCAT_DB.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelCAT_DB.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabelCAT_DB.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelCAT_DB.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelCAT_DB.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelCAT_DB.Image")));
            this.toolStripStatusLabelCAT_DB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelCAT_DB.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelCAT_DB.Name = "toolStripStatusLabelCAT_DB";
            this.toolStripStatusLabelCAT_DB.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelCAT_DB.Size = new System.Drawing.Size(130, 36);
            this.toolStripStatusLabelCAT_DB.Text = "CONNECTED";
            this.toolStripStatusLabelCAT_DB.Click += new System.EventHandler(this.toolStripStatusLabelCAT_DB_Click);
            this.toolStripStatusLabelCAT_DB.DoubleClick += new System.EventHandler(this.toolStripStatusLabelCAT_DB_DoubleClick);
            // 
            // toolStripStatusLabelProjectDirtyFlag
            // 
            this.toolStripStatusLabelProjectDirtyFlag.BackColor = System.Drawing.Color.Green;
            this.toolStripStatusLabelProjectDirtyFlag.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabelProjectDirtyFlag.DoubleClickEnabled = true;
            this.toolStripStatusLabelProjectDirtyFlag.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelProjectDirtyFlag.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelProjectDirtyFlag.Image = global::HenStudio.Properties.Resources.Valid_32x32;
            this.toolStripStatusLabelProjectDirtyFlag.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelProjectDirtyFlag.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelProjectDirtyFlag.Name = "toolStripStatusLabelProjectDirtyFlag";
            this.toolStripStatusLabelProjectDirtyFlag.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelProjectDirtyFlag.Size = new System.Drawing.Size(101, 36);
            this.toolStripStatusLabelProjectDirtyFlag.Text = "UPDATED";
            this.toolStripStatusLabelProjectDirtyFlag.Click += new System.EventHandler(this.toolStripStatusLabelProjectDirtyFlag_Click);
            this.toolStripStatusLabelProjectDirtyFlag.DoubleClick += new System.EventHandler(this.toolStripStatusLabelProjectDirtyFlag_DoubleClick);
            // 
            // toolStripStatusLabelLEVEL_PROJECT
            // 
            this.toolStripStatusLabelLEVEL_PROJECT.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabelLEVEL_PROJECT.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelLEVEL_PROJECT.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabelLEVEL_PROJECT.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelLEVEL_PROJECT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabelLEVEL_PROJECT.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelLEVEL_PROJECT.Image")));
            this.toolStripStatusLabelLEVEL_PROJECT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelLEVEL_PROJECT.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelLEVEL_PROJECT.Name = "toolStripStatusLabelLEVEL_PROJECT";
            this.toolStripStatusLabelLEVEL_PROJECT.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelLEVEL_PROJECT.Size = new System.Drawing.Size(131, 36);
            this.toolStripStatusLabelLEVEL_PROJECT.Text = "PROJECT: ---";
            // 
            // toolStripStatusLabelLEVEL_PROFILE
            // 
            this.toolStripStatusLabelLEVEL_PROFILE.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabelLEVEL_PROFILE.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelLEVEL_PROFILE.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabelLEVEL_PROFILE.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelLEVEL_PROFILE.ForeColor = System.Drawing.Color.SlateGray;
            this.toolStripStatusLabelLEVEL_PROFILE.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelLEVEL_PROFILE.Image")));
            this.toolStripStatusLabelLEVEL_PROFILE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelLEVEL_PROFILE.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelLEVEL_PROFILE.Name = "toolStripStatusLabelLEVEL_PROFILE";
            this.toolStripStatusLabelLEVEL_PROFILE.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelLEVEL_PROFILE.Size = new System.Drawing.Size(124, 36);
            this.toolStripStatusLabelLEVEL_PROFILE.Text = "PROFILE: ---";
            // 
            // toolStripStatusLabelLEVEL_PINCH
            // 
            this.toolStripStatusLabelLEVEL_PINCH.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabelLEVEL_PINCH.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelLEVEL_PINCH.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabelLEVEL_PINCH.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelLEVEL_PINCH.ForeColor = System.Drawing.Color.SlateGray;
            this.toolStripStatusLabelLEVEL_PINCH.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelLEVEL_PINCH.Image")));
            this.toolStripStatusLabelLEVEL_PINCH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelLEVEL_PINCH.Margin = new System.Windows.Forms.Padding(3, 3, 0, 2);
            this.toolStripStatusLabelLEVEL_PINCH.Name = "toolStripStatusLabelLEVEL_PINCH";
            this.toolStripStatusLabelLEVEL_PINCH.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelLEVEL_PINCH.Size = new System.Drawing.Size(112, 37);
            this.toolStripStatusLabelLEVEL_PINCH.Text = "PINCH: ---";
            // 
            // toolStripStatusLabelLEVEL_HEN
            // 
            this.toolStripStatusLabelLEVEL_HEN.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabelLEVEL_HEN.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelLEVEL_HEN.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabelLEVEL_HEN.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelLEVEL_HEN.ForeColor = System.Drawing.Color.SlateGray;
            this.toolStripStatusLabelLEVEL_HEN.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelLEVEL_HEN.Image")));
            this.toolStripStatusLabelLEVEL_HEN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelLEVEL_HEN.Margin = new System.Windows.Forms.Padding(3, 3, 0, 2);
            this.toolStripStatusLabelLEVEL_HEN.Name = "toolStripStatusLabelLEVEL_HEN";
            this.toolStripStatusLabelLEVEL_HEN.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelLEVEL_HEN.Size = new System.Drawing.Size(90, 37);
            this.toolStripStatusLabelLEVEL_HEN.Text = "HEN ---";
            // 
            // toolStripStatusLabelAJP_LOGO
            // 
            this.toolStripStatusLabelAJP_LOGO.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabelAJP_LOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripStatusLabelAJP_LOGO.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelAJP_LOGO.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabelAJP_LOGO.DoubleClickEnabled = true;
            this.toolStripStatusLabelAJP_LOGO.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelAJP_LOGO.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabelAJP_LOGO.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelAJP_LOGO.Image")));
            this.toolStripStatusLabelAJP_LOGO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelAJP_LOGO.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelAJP_LOGO.Name = "toolStripStatusLabelAJP_LOGO";
            this.toolStripStatusLabelAJP_LOGO.Padding = new System.Windows.Forms.Padding(6);
            this.toolStripStatusLabelAJP_LOGO.Size = new System.Drawing.Size(419, 36);
            this.toolStripStatusLabelAJP_LOGO.Spring = true;
            this.toolStripStatusLabelAJP_LOGO.Text = "Engineering  ";
            this.toolStripStatusLabelAJP_LOGO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelAJP_LOGO.Click += new System.EventHandler(this.toolStripStatusLabelAJP_LOGO_Click);
            this.toolStripStatusLabelAJP_LOGO.DoubleClick += new System.EventHandler(this.toolStripStatusLabelAJP_LOGO_DoubleClick);
            // 
            // imageListAnalysis
            // 
            this.imageListAnalysis.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAnalysis.ImageStream")));
            this.imageListAnalysis.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAnalysis.Images.SetKeyName(0, "OpenedProject_32x32.png");
            this.imageListAnalysis.Images.SetKeyName(1, "Profile_Input_32x32.png");
            this.imageListAnalysis.Images.SetKeyName(2, "ProfileSELECTED_32x32.png");
            this.imageListAnalysis.Images.SetKeyName(3, "Pinch_32x32.png");
            this.imageListAnalysis.Images.SetKeyName(4, "PinchSELECTED_32x32.png");
            this.imageListAnalysis.Images.SetKeyName(5, "HenSELECTED_32x32.png");
            this.imageListAnalysis.Images.SetKeyName(6, "Hen_32x32.png");
            // 
            // imageListInput
            // 
            this.imageListInput.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListInput.ImageStream")));
            this.imageListInput.TransparentColor = System.Drawing.Color.Crimson;
            this.imageListInput.Images.SetKeyName(0, "Streams...32x32.png");
            this.imageListInput.Images.SetKeyName(1, "Utilities Image...32x32.png");
            this.imageListInput.Images.SetKeyName(2, "Cost...32x32.png");
            // 
            // imageListTargets
            // 
            this.imageListTargets.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTargets.ImageStream")));
            this.imageListTargets.TransparentColor = System.Drawing.Color.OrangeRed;
            this.imageListTargets.Images.SetKeyName(0, "Calc Gears...32x32.png");
            this.imageListTargets.Images.SetKeyName(1, "Composite...32x32.png");
            this.imageListTargets.Images.SetKeyName(2, "Interval...32x32.png");
            this.imageListTargets.Images.SetKeyName(3, "Optimize Target...32x32.png");
            // 
            // imageListHen
            // 
            this.imageListHen.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListHen.ImageStream")));
            this.imageListHen.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListHen.Images.SetKeyName(0, "Design...32x32.png");
            // 
            // splitContainerLefCenter
            // 
            this.splitContainerLefCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerLefCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLefCenter.Location = new System.Drawing.Point(0, 24);
            this.splitContainerLefCenter.MinimumSize = new System.Drawing.Size(1264, 619);
            this.splitContainerLefCenter.Name = "splitContainerLefCenter";
            // 
            // splitContainerLefCenter.Panel1
            // 
            this.splitContainerLefCenter.Panel1.BackColor = System.Drawing.Color.Honeydew;
            this.splitContainerLefCenter.Panel1.Controls.Add(this.splitContainerProject);
            this.splitContainerLefCenter.Panel1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerLefCenter.Panel1MinSize = 350;
            // 
            // splitContainerLefCenter.Panel2
            // 
            this.splitContainerLefCenter.Panel2.BackColor = System.Drawing.Color.Honeydew;
            this.splitContainerLefCenter.Panel2.Controls.Add(this.panelSELECTED_PROJECT);
            this.splitContainerLefCenter.Panel2.Controls.Add(this.panelSELECTED_PROJECTS);
            this.splitContainerLefCenter.Panel2.Controls.Add(this.panelSELECTED_PROFILE);
            this.splitContainerLefCenter.Panel2.Controls.Add(this.panelSELECTED_HEN);
            this.splitContainerLefCenter.Panel2.Controls.Add(this.panelSELECTED_PINCH);
            this.splitContainerLefCenter.Panel2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerLefCenter.Panel2.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainerLefCenter.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainerLefCenter.Panel2MinSize = 908;
            this.splitContainerLefCenter.Size = new System.Drawing.Size(1264, 619);
            this.splitContainerLefCenter.SplitterDistance = 351;
            this.splitContainerLefCenter.TabIndex = 2;
            // 
            // splitContainerProject
            // 
            this.splitContainerProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerProject.Location = new System.Drawing.Point(0, 0);
            this.splitContainerProject.Name = "splitContainerProject";
            this.splitContainerProject.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerProject.Panel1
            // 
            this.splitContainerProject.Panel1.BackColor = System.Drawing.Color.Honeydew;
            this.splitContainerProject.Panel1.Controls.Add(this.treeViewCurrentProjectExplorer);
            this.splitContainerProject.Panel1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainerProject.Panel1.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainerProject.Panel1MinSize = 400;
            // 
            // splitContainerProject.Panel2
            // 
            this.splitContainerProject.Panel2.Controls.Add(this.treeViewProjectZipExplorer);
            this.splitContainerProject.Panel2.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainerProject.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainerProject.Panel2MinSize = 170;
            this.splitContainerProject.Size = new System.Drawing.Size(351, 619);
            this.splitContainerProject.SplitterDistance = 400;
            this.splitContainerProject.TabIndex = 0;
            // 
            // treeViewCurrentProjectExplorer
            // 
            this.treeViewCurrentProjectExplorer.BackColor = System.Drawing.Color.White;
            this.treeViewCurrentProjectExplorer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewCurrentProjectExplorer.ContextMenuStrip = this.contextMenuStripCurrProj;
            this.treeViewCurrentProjectExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewCurrentProjectExplorer.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewCurrentProjectExplorer.HideSelection = false;
            this.treeViewCurrentProjectExplorer.ImageIndex = 9;
            this.treeViewCurrentProjectExplorer.ImageList = this.imageListProjectTreeViews;
            this.treeViewCurrentProjectExplorer.Location = new System.Drawing.Point(6, 6);
            this.treeViewCurrentProjectExplorer.Margin = new System.Windows.Forms.Padding(6);
            this.treeViewCurrentProjectExplorer.Name = "treeViewCurrentProjectExplorer";
            treeNode1.ContextMenuStrip = this.contextMenuStripHen;
            treeNode1.ImageIndex = 7;
            treeNode1.Name = "NodeProfile_01_Pinch_01_Hen_01";
            treeNode1.SelectedImageIndex = 8;
            treeNode1.Text = "Hen: Base Design";
            treeNode2.ContextMenuStrip = this.contextMenuStripHen;
            treeNode2.ImageIndex = 7;
            treeNode2.Name = "NodeProfile_01_Pinch_01_Hen_02";
            treeNode2.SelectedImageIndex = 8;
            treeNode2.Text = "Hen: MER Design";
            treeNode3.ContextMenuStrip = this.contextMenuStripPinch;
            treeNode3.ImageIndex = 5;
            treeNode3.Name = "NodeProfile_01_Pinch_01";
            treeNode3.SelectedImageIndex = 6;
            treeNode3.Text = "Pinch: Delta T=10";
            treeNode4.ContextMenuStrip = this.contextMenuStripHen;
            treeNode4.ImageIndex = 7;
            treeNode4.Name = "NodeProfile_01_Pinch_02_Hen_01";
            treeNode4.SelectedImageIndex = 8;
            treeNode4.Text = "Hen: Base Design";
            treeNode5.ContextMenuStrip = this.contextMenuStripHen;
            treeNode5.ImageIndex = 7;
            treeNode5.Name = "NodeProfile_01_Pinch_02_Hen_02";
            treeNode5.SelectedImageIndex = 8;
            treeNode5.Text = "Hen: MER Design";
            treeNode6.ContextMenuStrip = this.contextMenuStripPinch;
            treeNode6.ImageIndex = 5;
            treeNode6.Name = "NodeProfile_01_Pinch_02";
            treeNode6.SelectedImageIndex = 6;
            treeNode6.Text = "Pinch: Delta T=20";
            treeNode7.ContextMenuStrip = this.contextMenuStripProfile;
            treeNode7.ImageIndex = 3;
            treeNode7.Name = "NodeProfile_01";
            treeNode7.SelectedImageIndex = 4;
            treeNode7.Text = "Profile: Q1 Setup";
            treeNode8.ContextMenuStrip = this.contextMenuStripPinch;
            treeNode8.ImageIndex = 5;
            treeNode8.Name = "NodeProfile_02_Pinch_01";
            treeNode8.SelectedImageIndex = 6;
            treeNode8.Text = "Pinch: Delta T=10";
            treeNode9.ContextMenuStrip = this.contextMenuStripProfile;
            treeNode9.ImageIndex = 3;
            treeNode9.Name = "NodeProfile_02";
            treeNode9.SelectedImageIndex = 4;
            treeNode9.Text = "Profile: Q2 Setup";
            treeNode10.ContextMenuStrip = this.contextMenuStripProfile;
            treeNode10.ImageIndex = 3;
            treeNode10.Name = "NodeProfile_03";
            treeNode10.SelectedImageIndex = 4;
            treeNode10.Text = "Profile: Q3 Setup";
            treeNode11.ContextMenuStrip = this.contextMenuStripProfile;
            treeNode11.ImageIndex = 3;
            treeNode11.Name = "NodeProfile_04";
            treeNode11.SelectedImageIndex = 4;
            treeNode11.Text = "Profile: Q4 Setup";
            treeNode12.ContextMenuStrip = this.contextMenuStripCurrProj;
            treeNode12.ImageIndex = 1;
            treeNode12.Name = "NodeProject02";
            treeNode12.SelectedImageIndex = 2;
            treeNode12.Text = "Project: Deer Park";
            treeNode13.ContextMenuStrip = this.contextMenuStripCurrProj;
            treeNode13.ImageIndex = 1;
            treeNode13.Name = "NodeProject02";
            treeNode13.SelectedImageIndex = 2;
            treeNode13.Text = "Project: Convent";
            treeNode14.ContextMenuStrip = this.contextMenuStripCurrProj;
            treeNode14.ImageIndex = 1;
            treeNode14.Name = "NodeProject03";
            treeNode14.SelectedImageIndex = 2;
            treeNode14.Text = "Project: Norco";
            treeNode15.ContextMenuStrip = this.contextMenuStripProjectCatalog;
            treeNode15.ImageIndex = 10;
            treeNode15.Name = "NodeRootProjects";
            treeNode15.SelectedImageIndex = 10;
            treeNode15.Text = "HEN Studio CATALOG";
            this.treeViewCurrentProjectExplorer.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.treeViewCurrentProjectExplorer.SelectedImageIndex = 9;
            this.treeViewCurrentProjectExplorer.Size = new System.Drawing.Size(337, 386);
            this.treeViewCurrentProjectExplorer.TabIndex = 1;
            this.treeViewCurrentProjectExplorer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCurrentProjectExplorer_AfterSelect);
            // 
            // imageListProjectTreeViews
            // 
            this.imageListProjectTreeViews.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListProjectTreeViews.ImageStream")));
            this.imageListProjectTreeViews.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListProjectTreeViews.Images.SetKeyName(0, "Catalog_16x16.ico");
            this.imageListProjectTreeViews.Images.SetKeyName(1, "Project_16x16.ico");
            this.imageListProjectTreeViews.Images.SetKeyName(2, "OpenedProject_16x16.ico");
            this.imageListProjectTreeViews.Images.SetKeyName(3, "Profile_Input_16x16.ico");
            this.imageListProjectTreeViews.Images.SetKeyName(4, "Profile_Input_Selected_16x16.ico");
            this.imageListProjectTreeViews.Images.SetKeyName(5, "Pinch_16x16.ico");
            this.imageListProjectTreeViews.Images.SetKeyName(6, "PinchSelected_16x16.ico");
            this.imageListProjectTreeViews.Images.SetKeyName(7, "HEN_16x16.ico");
            this.imageListProjectTreeViews.Images.SetKeyName(8, "HENSelected_16x16.ico");
            this.imageListProjectTreeViews.Images.SetKeyName(9, "AJP_HEN_StudioGraphic_16x16.ico");
            // 
            // treeViewProjectZipExplorer
            // 
            this.treeViewProjectZipExplorer.BackColor = System.Drawing.Color.White;
            this.treeViewProjectZipExplorer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewProjectZipExplorer.ContextMenuStrip = this.contextMenuStripProjectZip;
            this.treeViewProjectZipExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewProjectZipExplorer.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewProjectZipExplorer.HideSelection = false;
            this.treeViewProjectZipExplorer.ImageIndex = 0;
            this.treeViewProjectZipExplorer.ImageList = this.imageListProjectZIP;
            this.treeViewProjectZipExplorer.Location = new System.Drawing.Point(6, 6);
            this.treeViewProjectZipExplorer.Margin = new System.Windows.Forms.Padding(6);
            this.treeViewProjectZipExplorer.Name = "treeViewProjectZipExplorer";
            treeNode16.ImageKey = "Project_16x16.ico";
            treeNode16.Name = "NodeZipExport01";
            treeNode16.SelectedImageKey = "Project_16x16.ico";
            treeNode16.Text = "Deer Park Analysis - 20260311.zip";
            treeNode16.ToolTipText = "Zip File";
            treeNode17.ImageKey = "ExportZIP_16x16.ico";
            treeNode17.Name = "NodeEXPORT";
            treeNode17.SelectedImageKey = "ExportZIP_16x16.ico";
            treeNode17.Text = "EXPORT";
            treeNode17.ToolTipText = "Export Folder ... Contains Exported Project Zip files";
            treeNode18.ImageKey = "Project_16x16.ico";
            treeNode18.Name = "NodeImportZip01";
            treeNode18.SelectedImageKey = "Project_16x16.ico";
            treeNode18.Text = "DeerPark Analysis - 20260310";
            treeNode19.ImageKey = "ImportZIP_16x16.ico";
            treeNode19.Name = "NodeIMPORT";
            treeNode19.SelectedImageKey = "ImportZIP_16x16.ico";
            treeNode19.Text = "IMPORT";
            treeNode19.ToolTipText = "Import Folder ... Contains Imported Project Zip files";
            treeNode20.ImageKey = "ZipFolder_16x16.ico";
            treeNode20.Name = "NodeRoot";
            treeNode20.SelectedImageKey = "ZipFolder_16x16.ico";
            treeNode20.Text = "Project ZIP Files";
            treeNode20.ToolTipText = "Root Folder of Import and Export Ptoject Zip Files";
            this.treeViewProjectZipExplorer.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.treeViewProjectZipExplorer.SelectedImageIndex = 0;
            this.treeViewProjectZipExplorer.Size = new System.Drawing.Size(337, 201);
            this.treeViewProjectZipExplorer.TabIndex = 0;
            // 
            // contextMenuStripProjectZip
            // 
            this.contextMenuStripProjectZip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemZipCollapseAll,
            this.toolStripMenuItemZipExpandAll});
            this.contextMenuStripProjectZip.Name = "contextMenuStripProjectZip";
            this.contextMenuStripProjectZip.Size = new System.Drawing.Size(137, 48);
            // 
            // toolStripMenuItemZipCollapseAll
            // 
            this.toolStripMenuItemZipCollapseAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemZipCollapseAll.Image")));
            this.toolStripMenuItemZipCollapseAll.Name = "toolStripMenuItemZipCollapseAll";
            this.toolStripMenuItemZipCollapseAll.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItemZipCollapseAll.Text = "Collapse All";
            this.toolStripMenuItemZipCollapseAll.Click += new System.EventHandler(this.toolStripMenuItemZipCollapseAll_Click);
            // 
            // toolStripMenuItemZipExpandAll
            // 
            this.toolStripMenuItemZipExpandAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemZipExpandAll.Image")));
            this.toolStripMenuItemZipExpandAll.Name = "toolStripMenuItemZipExpandAll";
            this.toolStripMenuItemZipExpandAll.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItemZipExpandAll.Text = "Expand All";
            this.toolStripMenuItemZipExpandAll.Click += new System.EventHandler(this.toolStripMenuItemZipExpandAll_Click);
            // 
            // imageListProjectZIP
            // 
            this.imageListProjectZIP.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListProjectZIP.ImageStream")));
            this.imageListProjectZIP.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListProjectZIP.Images.SetKeyName(0, "ZipFolder_16x16.ico");
            this.imageListProjectZIP.Images.SetKeyName(1, "ExportZIP_16x16.ico");
            this.imageListProjectZIP.Images.SetKeyName(2, "ImportZIP_16x16.ico");
            this.imageListProjectZIP.Images.SetKeyName(3, "Project_16x16.ico");
            // 
            // panelSELECTED_PROJECT
            // 
            this.panelSELECTED_PROJECT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSELECTED_PROJECT.BackColor = System.Drawing.Color.White;
            this.panelSELECTED_PROJECT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSELECTED_PROJECT.Controls.Add(this.panelDefaultParmeters);
            this.panelSELECTED_PROJECT.Controls.Add(this.textBoxProjectBanner);
            this.panelSELECTED_PROJECT.Controls.Add(this.panelProjectUnits);
            this.panelSELECTED_PROJECT.Controls.Add(this.pictureBoxOpenedProject);
            this.panelSELECTED_PROJECT.Controls.Add(this.panelProjectMetadata);
            this.panelSELECTED_PROJECT.Location = new System.Drawing.Point(10, 6);
            this.panelSELECTED_PROJECT.Name = "panelSELECTED_PROJECT";
            this.panelSELECTED_PROJECT.Padding = new System.Windows.Forms.Padding(6);
            this.panelSELECTED_PROJECT.Size = new System.Drawing.Size(887, 605);
            this.panelSELECTED_PROJECT.TabIndex = 2;
            // 
            // panelDefaultParmeters
            // 
            this.panelDefaultParmeters.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDefaultParmeters.Controls.Add(this.textBoxDefaultLabel);
            this.panelDefaultParmeters.Controls.Add(this.panelExchanger);
            this.panelDefaultParmeters.Controls.Add(this.panelDefaultHenOptimizer);
            this.panelDefaultParmeters.Location = new System.Drawing.Point(10, 251);
            this.panelDefaultParmeters.Name = "panelDefaultParmeters";
            this.panelDefaultParmeters.Size = new System.Drawing.Size(489, 146);
            this.panelDefaultParmeters.TabIndex = 37;
            // 
            // textBoxDefaultLabel
            // 
            this.textBoxDefaultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxDefaultLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDefaultLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefaultLabel.Location = new System.Drawing.Point(24, 10);
            this.textBoxDefaultLabel.Name = "textBoxDefaultLabel";
            this.textBoxDefaultLabel.ReadOnly = true;
            this.textBoxDefaultLabel.Size = new System.Drawing.Size(451, 22);
            this.textBoxDefaultLabel.TabIndex = 35;
            this.textBoxDefaultLabel.TabStop = false;
            this.textBoxDefaultLabel.Text = "DEFAULT PARAMETERS";
            this.textBoxDefaultLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelExchanger
            // 
            this.panelExchanger.BackColor = System.Drawing.Color.OldLace;
            this.panelExchanger.Controls.Add(this.textBoxDefaultU_Value);
            this.panelExchanger.Controls.Add(this.textBoxDefaultU_Units);
            this.panelExchanger.Controls.Add(this.textBoxDefaultU);
            this.panelExchanger.Controls.Add(this.textBoxExchangerDefaults);
            this.panelExchanger.Location = new System.Drawing.Point(17, 42);
            this.panelExchanger.Name = "panelExchanger";
            this.panelExchanger.Size = new System.Drawing.Size(250, 80);
            this.panelExchanger.TabIndex = 17;
            // 
            // textBoxDefaultU_Value
            // 
            this.textBoxDefaultU_Value.BackColor = System.Drawing.Color.OldLace;
            this.textBoxDefaultU_Value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDefaultU_Value.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefaultU_Value.Location = new System.Drawing.Point(55, 40);
            this.textBoxDefaultU_Value.Name = "textBoxDefaultU_Value";
            this.textBoxDefaultU_Value.ReadOnly = true;
            this.textBoxDefaultU_Value.Size = new System.Drawing.Size(76, 18);
            this.textBoxDefaultU_Value.TabIndex = 6;
            this.textBoxDefaultU_Value.Text = "74.0";
            this.textBoxDefaultU_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDefaultU_Units
            // 
            this.textBoxDefaultU_Units.BackColor = System.Drawing.Color.OldLace;
            this.textBoxDefaultU_Units.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDefaultU_Units.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefaultU_Units.Location = new System.Drawing.Point(137, 40);
            this.textBoxDefaultU_Units.Name = "textBoxDefaultU_Units";
            this.textBoxDefaultU_Units.ReadOnly = true;
            this.textBoxDefaultU_Units.Size = new System.Drawing.Size(110, 18);
            this.textBoxDefaultU_Units.TabIndex = 31;
            this.textBoxDefaultU_Units.Text = "MMBtu/(hr·ft²·°F )";
            // 
            // textBoxDefaultU
            // 
            this.textBoxDefaultU.BackColor = System.Drawing.Color.OldLace;
            this.textBoxDefaultU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDefaultU.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefaultU.Location = new System.Drawing.Point(8, 40);
            this.textBoxDefaultU.Name = "textBoxDefaultU";
            this.textBoxDefaultU.ReadOnly = true;
            this.textBoxDefaultU.Size = new System.Drawing.Size(37, 18);
            this.textBoxDefaultU.TabIndex = 30;
            this.textBoxDefaultU.TabStop = false;
            this.textBoxDefaultU.Text = "U: ";
            this.textBoxDefaultU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxExchangerDefaults
            // 
            this.textBoxExchangerDefaults.BackColor = System.Drawing.Color.OldLace;
            this.textBoxExchangerDefaults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExchangerDefaults.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExchangerDefaults.Location = new System.Drawing.Point(11, 5);
            this.textBoxExchangerDefaults.Name = "textBoxExchangerDefaults";
            this.textBoxExchangerDefaults.ReadOnly = true;
            this.textBoxExchangerDefaults.Size = new System.Drawing.Size(233, 22);
            this.textBoxExchangerDefaults.TabIndex = 33;
            this.textBoxExchangerDefaults.TabStop = false;
            this.textBoxExchangerDefaults.Text = "EXCHANGER";
            this.textBoxExchangerDefaults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelDefaultHenOptimizer
            // 
            this.panelDefaultHenOptimizer.BackColor = System.Drawing.Color.LightCyan;
            this.panelDefaultHenOptimizer.Controls.Add(this.textBoxDefaultHenOpitimizer);
            this.panelDefaultHenOptimizer.Controls.Add(this.textBoxDefaultHenOptimizerTitle);
            this.panelDefaultHenOptimizer.Location = new System.Drawing.Point(278, 43);
            this.panelDefaultHenOptimizer.Name = "panelDefaultHenOptimizer";
            this.panelDefaultHenOptimizer.Size = new System.Drawing.Size(190, 80);
            this.panelDefaultHenOptimizer.TabIndex = 18;
            // 
            // textBoxDefaultHenOpitimizer
            // 
            this.textBoxDefaultHenOpitimizer.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxDefaultHenOpitimizer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDefaultHenOpitimizer.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefaultHenOpitimizer.Location = new System.Drawing.Point(13, 38);
            this.textBoxDefaultHenOpitimizer.Name = "textBoxDefaultHenOpitimizer";
            this.textBoxDefaultHenOpitimizer.ReadOnly = true;
            this.textBoxDefaultHenOpitimizer.Size = new System.Drawing.Size(160, 18);
            this.textBoxDefaultHenOpitimizer.TabIndex = 35;
            this.textBoxDefaultHenOpitimizer.Text = "Greedy";
            this.textBoxDefaultHenOpitimizer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDefaultHenOptimizerTitle
            // 
            this.textBoxDefaultHenOptimizerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultHenOptimizerTitle.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxDefaultHenOptimizerTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDefaultHenOptimizerTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefaultHenOptimizerTitle.Location = new System.Drawing.Point(3, 5);
            this.textBoxDefaultHenOptimizerTitle.Name = "textBoxDefaultHenOptimizerTitle";
            this.textBoxDefaultHenOptimizerTitle.ReadOnly = true;
            this.textBoxDefaultHenOptimizerTitle.Size = new System.Drawing.Size(184, 22);
            this.textBoxDefaultHenOptimizerTitle.TabIndex = 34;
            this.textBoxDefaultHenOptimizerTitle.TabStop = false;
            this.textBoxDefaultHenOptimizerTitle.Text = "HEN OPTIMIZER";
            this.textBoxDefaultHenOptimizerTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxProjectBanner
            // 
            this.textBoxProjectBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProjectBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(99)))), ((int)(((byte)(87)))));
            this.textBoxProjectBanner.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectBanner.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxProjectBanner.Location = new System.Drawing.Point(48, 4);
            this.textBoxProjectBanner.Name = "textBoxProjectBanner";
            this.textBoxProjectBanner.Size = new System.Drawing.Size(828, 33);
            this.textBoxProjectBanner.TabIndex = 0;
            this.textBoxProjectBanner.Text = "PROJECT";
            this.textBoxProjectBanner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelProjectUnits
            // 
            this.panelProjectUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProjectUnits.BackColor = System.Drawing.Color.Lavender;
            this.panelProjectUnits.Controls.Add(this.textBoxProjectUnitsPress);
            this.panelProjectUnits.Controls.Add(this.textBoxProjectUnitsTemp);
            this.panelProjectUnits.Controls.Add(this.textBoxProjectUnitsMagnitude);
            this.panelProjectUnits.Controls.Add(this.textBoxProjectUnitsSystem);
            this.panelProjectUnits.Controls.Add(this.textBoxUnitsTitle);
            this.panelProjectUnits.Controls.Add(this.textBoxUDefinition);
            this.panelProjectUnits.Controls.Add(this.textBoxUnitsUValue);
            this.panelProjectUnits.Controls.Add(this.textBoxUnitsU);
            this.panelProjectUnits.Controls.Add(this.textBoxUnitsCPValue);
            this.panelProjectUnits.Controls.Add(this.textBoxCPDefinition);
            this.panelProjectUnits.Controls.Add(this.textBoxUnitsCP);
            this.panelProjectUnits.Controls.Add(this.textBoxUnitsDutyValue);
            this.panelProjectUnits.Controls.Add(this.textBoxUnitsDuty);
            this.panelProjectUnits.Controls.Add(this.textBoxUnitsAreaValue);
            this.panelProjectUnits.Controls.Add(this.textBoxUnitsArea);
            this.panelProjectUnits.Controls.Add(this.textBoxUnitsPress);
            this.panelProjectUnits.Controls.Add(this.textBoxUnitsTemp);
            this.panelProjectUnits.Controls.Add(this.textBoxUnitsMagnitude);
            this.panelProjectUnits.Controls.Add(this.pictureBoxUnitsSystem);
            this.panelProjectUnits.Controls.Add(this.textBoxUnitsSystem);
            this.panelProjectUnits.Location = new System.Drawing.Point(515, 48);
            this.panelProjectUnits.Name = "panelProjectUnits";
            this.panelProjectUnits.Size = new System.Drawing.Size(352, 349);
            this.panelProjectUnits.TabIndex = 13;
            // 
            // textBoxProjectUnitsPress
            // 
            this.textBoxProjectUnitsPress.BackColor = System.Drawing.Color.Lavender;
            this.textBoxProjectUnitsPress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectUnitsPress.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectUnitsPress.Location = new System.Drawing.Point(115, 139);
            this.textBoxProjectUnitsPress.Name = "textBoxProjectUnitsPress";
            this.textBoxProjectUnitsPress.ReadOnly = true;
            this.textBoxProjectUnitsPress.Size = new System.Drawing.Size(150, 18);
            this.textBoxProjectUnitsPress.TabIndex = 41;
            this.textBoxProjectUnitsPress.Text = "Pa";
            // 
            // textBoxProjectUnitsTemp
            // 
            this.textBoxProjectUnitsTemp.BackColor = System.Drawing.Color.Lavender;
            this.textBoxProjectUnitsTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectUnitsTemp.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectUnitsTemp.Location = new System.Drawing.Point(115, 109);
            this.textBoxProjectUnitsTemp.Name = "textBoxProjectUnitsTemp";
            this.textBoxProjectUnitsTemp.ReadOnly = true;
            this.textBoxProjectUnitsTemp.Size = new System.Drawing.Size(150, 18);
            this.textBoxProjectUnitsTemp.TabIndex = 40;
            this.textBoxProjectUnitsTemp.Text = "K";
            // 
            // textBoxProjectUnitsMagnitude
            // 
            this.textBoxProjectUnitsMagnitude.BackColor = System.Drawing.Color.Lavender;
            this.textBoxProjectUnitsMagnitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectUnitsMagnitude.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectUnitsMagnitude.Location = new System.Drawing.Point(115, 76);
            this.textBoxProjectUnitsMagnitude.Name = "textBoxProjectUnitsMagnitude";
            this.textBoxProjectUnitsMagnitude.ReadOnly = true;
            this.textBoxProjectUnitsMagnitude.Size = new System.Drawing.Size(150, 18);
            this.textBoxProjectUnitsMagnitude.TabIndex = 39;
            this.textBoxProjectUnitsMagnitude.Text = "BASE";
            // 
            // textBoxProjectUnitsSystem
            // 
            this.textBoxProjectUnitsSystem.BackColor = System.Drawing.Color.Lavender;
            this.textBoxProjectUnitsSystem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectUnitsSystem.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectUnitsSystem.Location = new System.Drawing.Point(115, 46);
            this.textBoxProjectUnitsSystem.Name = "textBoxProjectUnitsSystem";
            this.textBoxProjectUnitsSystem.ReadOnly = true;
            this.textBoxProjectUnitsSystem.Size = new System.Drawing.Size(150, 18);
            this.textBoxProjectUnitsSystem.TabIndex = 38;
            this.textBoxProjectUnitsSystem.Text = "Metric";
            // 
            // textBoxUnitsTitle
            // 
            this.textBoxUnitsTitle.BackColor = System.Drawing.Color.Lavender;
            this.textBoxUnitsTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsTitle.Location = new System.Drawing.Point(3, 8);
            this.textBoxUnitsTitle.Name = "textBoxUnitsTitle";
            this.textBoxUnitsTitle.ReadOnly = true;
            this.textBoxUnitsTitle.Size = new System.Drawing.Size(346, 22);
            this.textBoxUnitsTitle.TabIndex = 32;
            this.textBoxUnitsTitle.Text = "PROJECT UNITS";
            this.textBoxUnitsTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUDefinition
            // 
            this.textBoxUDefinition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUDefinition.BackColor = System.Drawing.Color.Lavender;
            this.textBoxUDefinition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUDefinition.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUDefinition.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUDefinition.Location = new System.Drawing.Point(87, 312);
            this.textBoxUDefinition.Name = "textBoxUDefinition";
            this.textBoxUDefinition.ReadOnly = true;
            this.textBoxUDefinition.Size = new System.Drawing.Size(251, 18);
            this.textBoxUDefinition.TabIndex = 31;
            this.textBoxUDefinition.Text = "[ U ... Overall Heat Transfer Coefficient ]";
            // 
            // textBoxUnitsUValue
            // 
            this.textBoxUnitsUValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUnitsUValue.BackColor = System.Drawing.Color.Lavender;
            this.textBoxUnitsUValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsUValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsUValue.Location = new System.Drawing.Point(121, 293);
            this.textBoxUnitsUValue.Name = "textBoxUnitsUValue";
            this.textBoxUnitsUValue.ReadOnly = true;
            this.textBoxUnitsUValue.Size = new System.Drawing.Size(144, 18);
            this.textBoxUnitsUValue.TabIndex = 30;
            this.textBoxUnitsUValue.Text = "MMBtu/hr·ft²·°F ";
            // 
            // textBoxUnitsU
            // 
            this.textBoxUnitsU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUnitsU.BackColor = System.Drawing.Color.Lavender;
            this.textBoxUnitsU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsU.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsU.Location = new System.Drawing.Point(13, 293);
            this.textBoxUnitsU.Name = "textBoxUnitsU";
            this.textBoxUnitsU.ReadOnly = true;
            this.textBoxUnitsU.Size = new System.Drawing.Size(96, 18);
            this.textBoxUnitsU.TabIndex = 29;
            this.textBoxUnitsU.Text = "U: ";
            this.textBoxUnitsU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxUnitsCPValue
            // 
            this.textBoxUnitsCPValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUnitsCPValue.BackColor = System.Drawing.Color.Lavender;
            this.textBoxUnitsCPValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsCPValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsCPValue.Location = new System.Drawing.Point(121, 239);
            this.textBoxUnitsCPValue.Name = "textBoxUnitsCPValue";
            this.textBoxUnitsCPValue.ReadOnly = true;
            this.textBoxUnitsCPValue.Size = new System.Drawing.Size(144, 18);
            this.textBoxUnitsCPValue.TabIndex = 28;
            this.textBoxUnitsCPValue.Text = "MMBtu/(hr °F)";
            // 
            // textBoxCPDefinition
            // 
            this.textBoxCPDefinition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCPDefinition.BackColor = System.Drawing.Color.Lavender;
            this.textBoxCPDefinition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCPDefinition.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCPDefinition.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCPDefinition.Location = new System.Drawing.Point(78, 257);
            this.textBoxCPDefinition.Name = "textBoxCPDefinition";
            this.textBoxCPDefinition.ReadOnly = true;
            this.textBoxCPDefinition.Size = new System.Drawing.Size(251, 18);
            this.textBoxCPDefinition.TabIndex = 27;
            this.textBoxCPDefinition.Text = "[ CP ... Heat Capacity Flow Rate (m * Cp) ]";
            // 
            // textBoxUnitsCP
            // 
            this.textBoxUnitsCP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUnitsCP.BackColor = System.Drawing.Color.Lavender;
            this.textBoxUnitsCP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsCP.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsCP.Location = new System.Drawing.Point(13, 239);
            this.textBoxUnitsCP.Name = "textBoxUnitsCP";
            this.textBoxUnitsCP.ReadOnly = true;
            this.textBoxUnitsCP.Size = new System.Drawing.Size(96, 18);
            this.textBoxUnitsCP.TabIndex = 26;
            this.textBoxUnitsCP.Text = "CP: ";
            this.textBoxUnitsCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxUnitsDutyValue
            // 
            this.textBoxUnitsDutyValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUnitsDutyValue.BackColor = System.Drawing.Color.Lavender;
            this.textBoxUnitsDutyValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsDutyValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsDutyValue.Location = new System.Drawing.Point(121, 203);
            this.textBoxUnitsDutyValue.Name = "textBoxUnitsDutyValue";
            this.textBoxUnitsDutyValue.ReadOnly = true;
            this.textBoxUnitsDutyValue.Size = new System.Drawing.Size(144, 18);
            this.textBoxUnitsDutyValue.TabIndex = 25;
            this.textBoxUnitsDutyValue.Text = "MMBtu/hr";
            // 
            // textBoxUnitsDuty
            // 
            this.textBoxUnitsDuty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUnitsDuty.BackColor = System.Drawing.Color.Lavender;
            this.textBoxUnitsDuty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsDuty.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsDuty.Location = new System.Drawing.Point(13, 203);
            this.textBoxUnitsDuty.Name = "textBoxUnitsDuty";
            this.textBoxUnitsDuty.ReadOnly = true;
            this.textBoxUnitsDuty.Size = new System.Drawing.Size(96, 18);
            this.textBoxUnitsDuty.TabIndex = 24;
            this.textBoxUnitsDuty.Text = "Duty: ";
            this.textBoxUnitsDuty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxUnitsAreaValue
            // 
            this.textBoxUnitsAreaValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUnitsAreaValue.BackColor = System.Drawing.Color.Lavender;
            this.textBoxUnitsAreaValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsAreaValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsAreaValue.Location = new System.Drawing.Point(121, 175);
            this.textBoxUnitsAreaValue.Name = "textBoxUnitsAreaValue";
            this.textBoxUnitsAreaValue.ReadOnly = true;
            this.textBoxUnitsAreaValue.Size = new System.Drawing.Size(144, 18);
            this.textBoxUnitsAreaValue.TabIndex = 23;
            this.textBoxUnitsAreaValue.Text = "ft²";
            // 
            // textBoxUnitsArea
            // 
            this.textBoxUnitsArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUnitsArea.BackColor = System.Drawing.Color.Lavender;
            this.textBoxUnitsArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsArea.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsArea.Location = new System.Drawing.Point(13, 175);
            this.textBoxUnitsArea.Name = "textBoxUnitsArea";
            this.textBoxUnitsArea.ReadOnly = true;
            this.textBoxUnitsArea.Size = new System.Drawing.Size(96, 18);
            this.textBoxUnitsArea.TabIndex = 22;
            this.textBoxUnitsArea.Text = "Area: ";
            this.textBoxUnitsArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxUnitsPress
            // 
            this.textBoxUnitsPress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUnitsPress.BackColor = System.Drawing.Color.Lavender;
            this.textBoxUnitsPress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsPress.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsPress.Location = new System.Drawing.Point(13, 139);
            this.textBoxUnitsPress.Name = "textBoxUnitsPress";
            this.textBoxUnitsPress.ReadOnly = true;
            this.textBoxUnitsPress.Size = new System.Drawing.Size(96, 18);
            this.textBoxUnitsPress.TabIndex = 20;
            this.textBoxUnitsPress.Text = "Pressure: ";
            this.textBoxUnitsPress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxUnitsTemp
            // 
            this.textBoxUnitsTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUnitsTemp.BackColor = System.Drawing.Color.Lavender;
            this.textBoxUnitsTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsTemp.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsTemp.Location = new System.Drawing.Point(13, 109);
            this.textBoxUnitsTemp.Name = "textBoxUnitsTemp";
            this.textBoxUnitsTemp.ReadOnly = true;
            this.textBoxUnitsTemp.Size = new System.Drawing.Size(96, 18);
            this.textBoxUnitsTemp.TabIndex = 18;
            this.textBoxUnitsTemp.Text = "Temperature: ";
            this.textBoxUnitsTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxUnitsMagnitude
            // 
            this.textBoxUnitsMagnitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUnitsMagnitude.BackColor = System.Drawing.Color.Lavender;
            this.textBoxUnitsMagnitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsMagnitude.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsMagnitude.Location = new System.Drawing.Point(13, 76);
            this.textBoxUnitsMagnitude.Name = "textBoxUnitsMagnitude";
            this.textBoxUnitsMagnitude.ReadOnly = true;
            this.textBoxUnitsMagnitude.Size = new System.Drawing.Size(96, 18);
            this.textBoxUnitsMagnitude.TabIndex = 16;
            this.textBoxUnitsMagnitude.Text = "Magnitude: ";
            this.textBoxUnitsMagnitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBoxUnitsSystem
            // 
            this.pictureBoxUnitsSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxUnitsSystem.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnitsSystem.Image")));
            this.pictureBoxUnitsSystem.Location = new System.Drawing.Point(287, 39);
            this.pictureBoxUnitsSystem.Name = "pictureBoxUnitsSystem";
            this.pictureBoxUnitsSystem.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxUnitsSystem.TabIndex = 15;
            this.pictureBoxUnitsSystem.TabStop = false;
            // 
            // textBoxUnitsSystem
            // 
            this.textBoxUnitsSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUnitsSystem.BackColor = System.Drawing.Color.Lavender;
            this.textBoxUnitsSystem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsSystem.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsSystem.Location = new System.Drawing.Point(13, 46);
            this.textBoxUnitsSystem.Name = "textBoxUnitsSystem";
            this.textBoxUnitsSystem.ReadOnly = true;
            this.textBoxUnitsSystem.Size = new System.Drawing.Size(96, 18);
            this.textBoxUnitsSystem.TabIndex = 14;
            this.textBoxUnitsSystem.Text = "System Units: ";
            this.textBoxUnitsSystem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBoxOpenedProject
            // 
            this.pictureBoxOpenedProject.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOpenedProject.Image")));
            this.pictureBoxOpenedProject.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxOpenedProject.Name = "pictureBoxOpenedProject";
            this.pictureBoxOpenedProject.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxOpenedProject.TabIndex = 9;
            this.pictureBoxOpenedProject.TabStop = false;
            // 
            // panelProjectMetadata
            // 
            this.panelProjectMetadata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProjectMetadata.BackColor = System.Drawing.Color.LightCyan;
            this.panelProjectMetadata.Controls.Add(this.textBoxProjectID);
            this.panelProjectMetadata.Controls.Add(this.textBoxProjectGUID);
            this.panelProjectMetadata.Controls.Add(this.textBoxProjectNameValue);
            this.panelProjectMetadata.Controls.Add(this.textBoxProjectName);
            this.panelProjectMetadata.Controls.Add(this.textBoxProjectDescription);
            this.panelProjectMetadata.Controls.Add(this.textBoxProjectDescriptionValue);
            this.panelProjectMetadata.Location = new System.Drawing.Point(10, 49);
            this.panelProjectMetadata.Name = "panelProjectMetadata";
            this.panelProjectMetadata.Size = new System.Drawing.Size(489, 191);
            this.panelProjectMetadata.TabIndex = 12;
            // 
            // textBoxProjectID
            // 
            this.textBoxProjectID.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxProjectID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectID.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectID.Location = new System.Drawing.Point(33, 10);
            this.textBoxProjectID.Name = "textBoxProjectID";
            this.textBoxProjectID.ReadOnly = true;
            this.textBoxProjectID.Size = new System.Drawing.Size(96, 18);
            this.textBoxProjectID.TabIndex = 6;
            this.textBoxProjectID.Text = "Project ID: ";
            this.textBoxProjectID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxProjectGUID
            // 
            this.textBoxProjectGUID.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxProjectGUID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectGUID.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectGUID.Location = new System.Drawing.Point(141, 10);
            this.textBoxProjectGUID.Name = "textBoxProjectGUID";
            this.textBoxProjectGUID.ReadOnly = true;
            this.textBoxProjectGUID.Size = new System.Drawing.Size(334, 18);
            this.textBoxProjectGUID.TabIndex = 5;
            this.textBoxProjectGUID.Text = "GUID here";
            // 
            // textBoxProjectNameValue
            // 
            this.textBoxProjectNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProjectNameValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxProjectNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProjectNameValue.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectNameValue.Location = new System.Drawing.Point(135, 38);
            this.textBoxProjectNameValue.Name = "textBoxProjectNameValue";
            this.textBoxProjectNameValue.ReadOnly = true;
            this.textBoxProjectNameValue.Size = new System.Drawing.Size(339, 25);
            this.textBoxProjectNameValue.TabIndex = 2;
            this.textBoxProjectNameValue.Text = "Enter Project Name";
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxProjectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectName.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectName.Location = new System.Drawing.Point(33, 40);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.ReadOnly = true;
            this.textBoxProjectName.Size = new System.Drawing.Size(96, 18);
            this.textBoxProjectName.TabIndex = 1;
            this.textBoxProjectName.Text = "Project Name: ";
            this.textBoxProjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxProjectDescription
            // 
            this.textBoxProjectDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProjectDescription.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxProjectDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectDescription.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectDescription.Location = new System.Drawing.Point(20, 70);
            this.textBoxProjectDescription.Name = "textBoxProjectDescription";
            this.textBoxProjectDescription.ReadOnly = true;
            this.textBoxProjectDescription.Size = new System.Drawing.Size(454, 18);
            this.textBoxProjectDescription.TabIndex = 3;
            this.textBoxProjectDescription.Text = "  Description";
            this.textBoxProjectDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxProjectDescriptionValue
            // 
            this.textBoxProjectDescriptionValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProjectDescriptionValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxProjectDescriptionValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProjectDescriptionValue.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectDescriptionValue.Location = new System.Drawing.Point(14, 92);
            this.textBoxProjectDescriptionValue.Multiline = true;
            this.textBoxProjectDescriptionValue.Name = "textBoxProjectDescriptionValue";
            this.textBoxProjectDescriptionValue.ReadOnly = true;
            this.textBoxProjectDescriptionValue.Size = new System.Drawing.Size(460, 85);
            this.textBoxProjectDescriptionValue.TabIndex = 4;
            this.textBoxProjectDescriptionValue.Text = "Enter Project Description";
            // 
            // panelSELECTED_PROJECTS
            // 
            this.panelSELECTED_PROJECTS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSELECTED_PROJECTS.BackColor = System.Drawing.Color.White;
            this.panelSELECTED_PROJECTS.BackgroundImage = global::HenStudio.Properties.Resources.AJP_Refinery___1280x720;
            this.panelSELECTED_PROJECTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSELECTED_PROJECTS.Controls.Add(this.pictureBoxProductLogo);
            this.panelSELECTED_PROJECTS.Controls.Add(this.buttonConnection);
            this.panelSELECTED_PROJECTS.Controls.Add(this.panelProjectDbFileMetadata);
            this.panelSELECTED_PROJECTS.Controls.Add(this.pictureBoxProjects);
            this.panelSELECTED_PROJECTS.Controls.Add(this.textBoxProjectsBanner);
            this.panelSELECTED_PROJECTS.Location = new System.Drawing.Point(10, 6);
            this.panelSELECTED_PROJECTS.Name = "panelSELECTED_PROJECTS";
            this.panelSELECTED_PROJECTS.Padding = new System.Windows.Forms.Padding(6);
            this.panelSELECTED_PROJECTS.Size = new System.Drawing.Size(887, 605);
            this.panelSELECTED_PROJECTS.TabIndex = 1;
            // 
            // pictureBoxProductLogo
            // 
            this.pictureBoxProductLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxProductLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProductLogo.Image = global::HenStudio.Properties.Resources.AJP_HEN_Studio_with_Graphic;
            this.pictureBoxProductLogo.Location = new System.Drawing.Point(522, 414);
            this.pictureBoxProductLogo.Name = "pictureBoxProductLogo";
            this.pictureBoxProductLogo.Size = new System.Drawing.Size(353, 180);
            this.pictureBoxProductLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProductLogo.TabIndex = 16;
            this.pictureBoxProductLogo.TabStop = false;
            this.pictureBoxProductLogo.Click += new System.EventHandler(this.pictureBoxProductLogo_Click);
            // 
            // buttonConnection
            // 
            this.buttonConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.buttonConnection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonConnection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnection.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnection.ForeColor = System.Drawing.Color.Yellow;
            this.buttonConnection.Image = global::HenStudio.Properties.Resources.HEN_Studio_Graphic___32x32;
            this.buttonConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConnection.Location = new System.Drawing.Point(10, 287);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Padding = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.buttonConnection.Size = new System.Drawing.Size(349, 50);
            this.buttonConnection.TabIndex = 15;
            this.buttonConnection.Text = "  CONNECT TO DATABASE";
            this.buttonConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConnection.UseVisualStyleBackColor = false;
            this.buttonConnection.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // panelProjectDbFileMetadata
            // 
            this.panelProjectDbFileMetadata.BackColor = System.Drawing.Color.OldLace;
            this.panelProjectDbFileMetadata.Controls.Add(this.textBoxConnServerVersionValue);
            this.panelProjectDbFileMetadata.Controls.Add(this.textBoxConnServerVersion);
            this.panelProjectDbFileMetadata.Controls.Add(this.textBoxConnTimeoutValue);
            this.panelProjectDbFileMetadata.Controls.Add(this.textBoxConnTimeout);
            this.panelProjectDbFileMetadata.Controls.Add(this.textBoxConnInitCatalogValue);
            this.panelProjectDbFileMetadata.Controls.Add(this.textBoxConnInitCatalog);
            this.panelProjectDbFileMetadata.Controls.Add(this.textBoxConnWorkstationIDValue);
            this.panelProjectDbFileMetadata.Controls.Add(this.textBoxConnWorkstationID);
            this.panelProjectDbFileMetadata.Controls.Add(this.textBoxConnUserIDValue);
            this.panelProjectDbFileMetadata.Controls.Add(this.textBoxConnUserID);
            this.panelProjectDbFileMetadata.Controls.Add(this.textBoxConnPacketSizeValue);
            this.panelProjectDbFileMetadata.Controls.Add(this.textBoxConnPacketSize);
            this.panelProjectDbFileMetadata.Controls.Add(this.textBoxConnStateValue);
            this.panelProjectDbFileMetadata.Controls.Add(this.textBoxConnState);
            this.panelProjectDbFileMetadata.Controls.Add(this.textBoxConnDataSourceValue);
            this.panelProjectDbFileMetadata.Controls.Add(this.textBoxConnDataSource);
            this.panelProjectDbFileMetadata.Controls.Add(this.textBoxDbConnectionTitle);
            this.panelProjectDbFileMetadata.Location = new System.Drawing.Point(9, 45);
            this.panelProjectDbFileMetadata.Name = "panelProjectDbFileMetadata";
            this.panelProjectDbFileMetadata.Size = new System.Drawing.Size(350, 237);
            this.panelProjectDbFileMetadata.TabIndex = 14;
            // 
            // textBoxConnServerVersionValue
            // 
            this.textBoxConnServerVersionValue.BackColor = System.Drawing.Color.OldLace;
            this.textBoxConnServerVersionValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnServerVersionValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnServerVersionValue.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxConnServerVersionValue.Location = new System.Drawing.Point(139, 178);
            this.textBoxConnServerVersionValue.Name = "textBoxConnServerVersionValue";
            this.textBoxConnServerVersionValue.ReadOnly = true;
            this.textBoxConnServerVersionValue.Size = new System.Drawing.Size(198, 18);
            this.textBoxConnServerVersionValue.TabIndex = 49;
            this.textBoxConnServerVersionValue.Text = "Server Version Here";
            // 
            // textBoxConnServerVersion
            // 
            this.textBoxConnServerVersion.BackColor = System.Drawing.Color.OldLace;
            this.textBoxConnServerVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnServerVersion.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnServerVersion.Location = new System.Drawing.Point(12, 178);
            this.textBoxConnServerVersion.Name = "textBoxConnServerVersion";
            this.textBoxConnServerVersion.ReadOnly = true;
            this.textBoxConnServerVersion.Size = new System.Drawing.Size(121, 18);
            this.textBoxConnServerVersion.TabIndex = 48;
            this.textBoxConnServerVersion.Text = "Server Version: ";
            this.textBoxConnServerVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxConnTimeoutValue
            // 
            this.textBoxConnTimeoutValue.BackColor = System.Drawing.Color.OldLace;
            this.textBoxConnTimeoutValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnTimeoutValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnTimeoutValue.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxConnTimeoutValue.Location = new System.Drawing.Point(139, 134);
            this.textBoxConnTimeoutValue.Name = "textBoxConnTimeoutValue";
            this.textBoxConnTimeoutValue.ReadOnly = true;
            this.textBoxConnTimeoutValue.Size = new System.Drawing.Size(198, 18);
            this.textBoxConnTimeoutValue.TabIndex = 46;
            this.textBoxConnTimeoutValue.Text = "Timeout Here";
            // 
            // textBoxConnTimeout
            // 
            this.textBoxConnTimeout.BackColor = System.Drawing.Color.OldLace;
            this.textBoxConnTimeout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnTimeout.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnTimeout.Location = new System.Drawing.Point(11, 134);
            this.textBoxConnTimeout.Name = "textBoxConnTimeout";
            this.textBoxConnTimeout.ReadOnly = true;
            this.textBoxConnTimeout.Size = new System.Drawing.Size(122, 18);
            this.textBoxConnTimeout.TabIndex = 47;
            this.textBoxConnTimeout.Text = "Timeout: ";
            this.textBoxConnTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxConnInitCatalogValue
            // 
            this.textBoxConnInitCatalogValue.BackColor = System.Drawing.Color.OldLace;
            this.textBoxConnInitCatalogValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnInitCatalogValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnInitCatalogValue.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxConnInitCatalogValue.Location = new System.Drawing.Point(139, 112);
            this.textBoxConnInitCatalogValue.Name = "textBoxConnInitCatalogValue";
            this.textBoxConnInitCatalogValue.ReadOnly = true;
            this.textBoxConnInitCatalogValue.Size = new System.Drawing.Size(198, 18);
            this.textBoxConnInitCatalogValue.TabIndex = 44;
            this.textBoxConnInitCatalogValue.Text = "Initial Catalog Here";
            // 
            // textBoxConnInitCatalog
            // 
            this.textBoxConnInitCatalog.BackColor = System.Drawing.Color.OldLace;
            this.textBoxConnInitCatalog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnInitCatalog.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnInitCatalog.Location = new System.Drawing.Point(12, 112);
            this.textBoxConnInitCatalog.Name = "textBoxConnInitCatalog";
            this.textBoxConnInitCatalog.ReadOnly = true;
            this.textBoxConnInitCatalog.Size = new System.Drawing.Size(121, 18);
            this.textBoxConnInitCatalog.TabIndex = 45;
            this.textBoxConnInitCatalog.Text = "Initial Catalog: ";
            this.textBoxConnInitCatalog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxConnWorkstationIDValue
            // 
            this.textBoxConnWorkstationIDValue.BackColor = System.Drawing.Color.OldLace;
            this.textBoxConnWorkstationIDValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnWorkstationIDValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnWorkstationIDValue.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxConnWorkstationIDValue.Location = new System.Drawing.Point(139, 88);
            this.textBoxConnWorkstationIDValue.Name = "textBoxConnWorkstationIDValue";
            this.textBoxConnWorkstationIDValue.ReadOnly = true;
            this.textBoxConnWorkstationIDValue.Size = new System.Drawing.Size(198, 18);
            this.textBoxConnWorkstationIDValue.TabIndex = 42;
            this.textBoxConnWorkstationIDValue.Text = "Workstation ID Here";
            // 
            // textBoxConnWorkstationID
            // 
            this.textBoxConnWorkstationID.BackColor = System.Drawing.Color.OldLace;
            this.textBoxConnWorkstationID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnWorkstationID.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnWorkstationID.Location = new System.Drawing.Point(12, 88);
            this.textBoxConnWorkstationID.Name = "textBoxConnWorkstationID";
            this.textBoxConnWorkstationID.ReadOnly = true;
            this.textBoxConnWorkstationID.Size = new System.Drawing.Size(121, 18);
            this.textBoxConnWorkstationID.TabIndex = 43;
            this.textBoxConnWorkstationID.Text = "Workstation ID: ";
            this.textBoxConnWorkstationID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxConnUserIDValue
            // 
            this.textBoxConnUserIDValue.BackColor = System.Drawing.Color.OldLace;
            this.textBoxConnUserIDValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnUserIDValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnUserIDValue.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxConnUserIDValue.Location = new System.Drawing.Point(139, 66);
            this.textBoxConnUserIDValue.Name = "textBoxConnUserIDValue";
            this.textBoxConnUserIDValue.ReadOnly = true;
            this.textBoxConnUserIDValue.Size = new System.Drawing.Size(198, 18);
            this.textBoxConnUserIDValue.TabIndex = 40;
            this.textBoxConnUserIDValue.Text = "User ID Here";
            // 
            // textBoxConnUserID
            // 
            this.textBoxConnUserID.BackColor = System.Drawing.Color.OldLace;
            this.textBoxConnUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnUserID.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnUserID.Location = new System.Drawing.Point(12, 66);
            this.textBoxConnUserID.Name = "textBoxConnUserID";
            this.textBoxConnUserID.ReadOnly = true;
            this.textBoxConnUserID.Size = new System.Drawing.Size(121, 18);
            this.textBoxConnUserID.TabIndex = 41;
            this.textBoxConnUserID.Text = "User ID: ";
            this.textBoxConnUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxConnPacketSizeValue
            // 
            this.textBoxConnPacketSizeValue.BackColor = System.Drawing.Color.OldLace;
            this.textBoxConnPacketSizeValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnPacketSizeValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnPacketSizeValue.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxConnPacketSizeValue.Location = new System.Drawing.Point(139, 156);
            this.textBoxConnPacketSizeValue.Name = "textBoxConnPacketSizeValue";
            this.textBoxConnPacketSizeValue.ReadOnly = true;
            this.textBoxConnPacketSizeValue.Size = new System.Drawing.Size(198, 18);
            this.textBoxConnPacketSizeValue.TabIndex = 39;
            this.textBoxConnPacketSizeValue.Text = "1024 KB";
            // 
            // textBoxConnPacketSize
            // 
            this.textBoxConnPacketSize.BackColor = System.Drawing.Color.OldLace;
            this.textBoxConnPacketSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnPacketSize.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnPacketSize.Location = new System.Drawing.Point(12, 156);
            this.textBoxConnPacketSize.Name = "textBoxConnPacketSize";
            this.textBoxConnPacketSize.ReadOnly = true;
            this.textBoxConnPacketSize.Size = new System.Drawing.Size(121, 18);
            this.textBoxConnPacketSize.TabIndex = 38;
            this.textBoxConnPacketSize.Text = "Packet Size:";
            this.textBoxConnPacketSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxConnStateValue
            // 
            this.textBoxConnStateValue.BackColor = System.Drawing.Color.OldLace;
            this.textBoxConnStateValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnStateValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnStateValue.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxConnStateValue.Location = new System.Drawing.Point(139, 201);
            this.textBoxConnStateValue.Name = "textBoxConnStateValue";
            this.textBoxConnStateValue.ReadOnly = true;
            this.textBoxConnStateValue.Size = new System.Drawing.Size(198, 18);
            this.textBoxConnStateValue.TabIndex = 35;
            this.textBoxConnStateValue.Text = "Closed";
            // 
            // textBoxConnState
            // 
            this.textBoxConnState.BackColor = System.Drawing.Color.OldLace;
            this.textBoxConnState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnState.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnState.Location = new System.Drawing.Point(12, 201);
            this.textBoxConnState.Name = "textBoxConnState";
            this.textBoxConnState.ReadOnly = true;
            this.textBoxConnState.Size = new System.Drawing.Size(121, 18);
            this.textBoxConnState.TabIndex = 34;
            this.textBoxConnState.Text = "Connection State: ";
            this.textBoxConnState.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxConnDataSourceValue
            // 
            this.textBoxConnDataSourceValue.BackColor = System.Drawing.Color.OldLace;
            this.textBoxConnDataSourceValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnDataSourceValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnDataSourceValue.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxConnDataSourceValue.Location = new System.Drawing.Point(139, 44);
            this.textBoxConnDataSourceValue.Name = "textBoxConnDataSourceValue";
            this.textBoxConnDataSourceValue.ReadOnly = true;
            this.textBoxConnDataSourceValue.Size = new System.Drawing.Size(198, 18);
            this.textBoxConnDataSourceValue.TabIndex = 33;
            this.textBoxConnDataSourceValue.Text = "Data Source Here";
            // 
            // textBoxConnDataSource
            // 
            this.textBoxConnDataSource.BackColor = System.Drawing.Color.OldLace;
            this.textBoxConnDataSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnDataSource.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnDataSource.Location = new System.Drawing.Point(12, 44);
            this.textBoxConnDataSource.Name = "textBoxConnDataSource";
            this.textBoxConnDataSource.ReadOnly = true;
            this.textBoxConnDataSource.Size = new System.Drawing.Size(121, 18);
            this.textBoxConnDataSource.TabIndex = 33;
            this.textBoxConnDataSource.Text = "Data Source: ";
            this.textBoxConnDataSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDbConnectionTitle
            // 
            this.textBoxDbConnectionTitle.BackColor = System.Drawing.Color.OldLace;
            this.textBoxDbConnectionTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDbConnectionTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDbConnectionTitle.Location = new System.Drawing.Point(2, 11);
            this.textBoxDbConnectionTitle.Name = "textBoxDbConnectionTitle";
            this.textBoxDbConnectionTitle.Size = new System.Drawing.Size(346, 22);
            this.textBoxDbConnectionTitle.TabIndex = 33;
            this.textBoxDbConnectionTitle.Text = "DATABASE CONNECTION";
            this.textBoxDbConnectionTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxProjects
            // 
            this.pictureBoxProjects.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProjects.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProjects.Image")));
            this.pictureBoxProjects.Location = new System.Drawing.Point(13, 4);
            this.pictureBoxProjects.Name = "pictureBoxProjects";
            this.pictureBoxProjects.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxProjects.TabIndex = 11;
            this.pictureBoxProjects.TabStop = false;
            // 
            // textBoxProjectsBanner
            // 
            this.textBoxProjectsBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProjectsBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.textBoxProjectsBanner.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectsBanner.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxProjectsBanner.Location = new System.Drawing.Point(48, 4);
            this.textBoxProjectsBanner.Name = "textBoxProjectsBanner";
            this.textBoxProjectsBanner.Size = new System.Drawing.Size(828, 33);
            this.textBoxProjectsBanner.TabIndex = 10;
            this.textBoxProjectsBanner.Text = "HEN STUDIO CATALOG";
            this.textBoxProjectsBanner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelSELECTED_PROFILE
            // 
            this.panelSELECTED_PROFILE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSELECTED_PROFILE.BackColor = System.Drawing.Color.White;
            this.panelSELECTED_PROFILE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSELECTED_PROFILE.Controls.Add(this.tabControlInputPhase);
            this.panelSELECTED_PROFILE.Controls.Add(this.textBoxInputBanner);
            this.panelSELECTED_PROFILE.Controls.Add(this.pictureBoxOpenedProfile);
            this.panelSELECTED_PROFILE.Location = new System.Drawing.Point(10, 6);
            this.panelSELECTED_PROFILE.Name = "panelSELECTED_PROFILE";
            this.panelSELECTED_PROFILE.Padding = new System.Windows.Forms.Padding(6);
            this.panelSELECTED_PROFILE.Size = new System.Drawing.Size(887, 605);
            this.panelSELECTED_PROFILE.TabIndex = 12;
            // 
            // tabControlInputPhase
            // 
            this.tabControlInputPhase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlInputPhase.Controls.Add(this.tabPageStreams);
            this.tabControlInputPhase.Controls.Add(this.tabPageUtilities);
            this.tabControlInputPhase.Controls.Add(this.tabPageEconomics);
            this.tabControlInputPhase.ImageList = this.imageListInput;
            this.tabControlInputPhase.Location = new System.Drawing.Point(9, 45);
            this.tabControlInputPhase.Name = "tabControlInputPhase";
            this.tabControlInputPhase.SelectedIndex = 0;
            this.tabControlInputPhase.ShowToolTips = true;
            this.tabControlInputPhase.Size = new System.Drawing.Size(876, 556);
            this.tabControlInputPhase.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlInputPhase.TabIndex = 0;
            // 
            // tabPageStreams
            // 
            this.tabPageStreams.BackColor = System.Drawing.Color.White;
            this.tabPageStreams.ImageIndex = 0;
            this.tabPageStreams.Location = new System.Drawing.Point(4, 39);
            this.tabPageStreams.Name = "tabPageStreams";
            this.tabPageStreams.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStreams.Size = new System.Drawing.Size(868, 513);
            this.tabPageStreams.TabIndex = 0;
            this.tabPageStreams.Text = "PROCESS STREAMS ";
            this.tabPageStreams.ToolTipText = "Specify Process Streams for Current Input Profile";
            // 
            // tabPageUtilities
            // 
            this.tabPageUtilities.BackColor = System.Drawing.Color.White;
            this.tabPageUtilities.ImageIndex = 1;
            this.tabPageUtilities.Location = new System.Drawing.Point(4, 39);
            this.tabPageUtilities.Name = "tabPageUtilities";
            this.tabPageUtilities.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUtilities.Size = new System.Drawing.Size(868, 513);
            this.tabPageUtilities.TabIndex = 1;
            this.tabPageUtilities.Text = "UTILITY STREAMS";
            this.tabPageUtilities.ToolTipText = "Specify Utility Streams for Current Input Profile";
            // 
            // tabPageEconomics
            // 
            this.tabPageEconomics.BackColor = System.Drawing.Color.White;
            this.tabPageEconomics.ImageIndex = 2;
            this.tabPageEconomics.Location = new System.Drawing.Point(4, 39);
            this.tabPageEconomics.Name = "tabPageEconomics";
            this.tabPageEconomics.Size = new System.Drawing.Size(868, 513);
            this.tabPageEconomics.TabIndex = 2;
            this.tabPageEconomics.Text = "ECONOMIC PARAMETERS";
            this.tabPageEconomics.ToolTipText = "Specify Economic Parameters for Current Input Profile";
            // 
            // textBoxInputBanner
            // 
            this.textBoxInputBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.textBoxInputBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputBanner.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputBanner.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxInputBanner.Location = new System.Drawing.Point(51, 4);
            this.textBoxInputBanner.Name = "textBoxInputBanner";
            this.textBoxInputBanner.Size = new System.Drawing.Size(813, 33);
            this.textBoxInputBanner.TabIndex = 1;
            this.textBoxInputBanner.Text = "INPUT PROFILE";
            this.textBoxInputBanner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxOpenedProfile
            // 
            this.pictureBoxOpenedProfile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOpenedProfile.Image")));
            this.pictureBoxOpenedProfile.Location = new System.Drawing.Point(7, 4);
            this.pictureBoxOpenedProfile.Name = "pictureBoxOpenedProfile";
            this.pictureBoxOpenedProfile.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxOpenedProfile.TabIndex = 0;
            this.pictureBoxOpenedProfile.TabStop = false;
            // 
            // panelSELECTED_HEN
            // 
            this.panelSELECTED_HEN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSELECTED_HEN.BackColor = System.Drawing.Color.White;
            this.panelSELECTED_HEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSELECTED_HEN.Controls.Add(this.textBoxHenBanner);
            this.panelSELECTED_HEN.Controls.Add(this.pictureBoxOpenedHen);
            this.panelSELECTED_HEN.Location = new System.Drawing.Point(10, 6);
            this.panelSELECTED_HEN.Name = "panelSELECTED_HEN";
            this.panelSELECTED_HEN.Padding = new System.Windows.Forms.Padding(6);
            this.panelSELECTED_HEN.Size = new System.Drawing.Size(887, 605);
            this.panelSELECTED_HEN.TabIndex = 4;
            // 
            // textBoxHenBanner
            // 
            this.textBoxHenBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHenBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBoxHenBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHenBanner.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHenBanner.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxHenBanner.Location = new System.Drawing.Point(51, 4);
            this.textBoxHenBanner.Name = "textBoxHenBanner";
            this.textBoxHenBanner.Size = new System.Drawing.Size(813, 33);
            this.textBoxHenBanner.TabIndex = 3;
            this.textBoxHenBanner.Text = "HEAT EXCHANGER NETWORK (HEN) DESIGN";
            this.textBoxHenBanner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxOpenedHen
            // 
            this.pictureBoxOpenedHen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOpenedHen.Image")));
            this.pictureBoxOpenedHen.Location = new System.Drawing.Point(7, 4);
            this.pictureBoxOpenedHen.Name = "pictureBoxOpenedHen";
            this.pictureBoxOpenedHen.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxOpenedHen.TabIndex = 4;
            this.pictureBoxOpenedHen.TabStop = false;
            // 
            // panelSELECTED_PINCH
            // 
            this.panelSELECTED_PINCH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSELECTED_PINCH.BackColor = System.Drawing.Color.White;
            this.panelSELECTED_PINCH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSELECTED_PINCH.Controls.Add(this.textBoxPinchBanner);
            this.panelSELECTED_PINCH.Controls.Add(this.pictureBoxOpenedPinch);
            this.panelSELECTED_PINCH.Location = new System.Drawing.Point(10, 6);
            this.panelSELECTED_PINCH.Name = "panelSELECTED_PINCH";
            this.panelSELECTED_PINCH.Padding = new System.Windows.Forms.Padding(6);
            this.panelSELECTED_PINCH.Size = new System.Drawing.Size(887, 605);
            this.panelSELECTED_PINCH.TabIndex = 2;
            // 
            // textBoxPinchBanner
            // 
            this.textBoxPinchBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPinchBanner.BackColor = System.Drawing.Color.OrangeRed;
            this.textBoxPinchBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPinchBanner.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPinchBanner.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxPinchBanner.Location = new System.Drawing.Point(51, 4);
            this.textBoxPinchBanner.Name = "textBoxPinchBanner";
            this.textBoxPinchBanner.Size = new System.Drawing.Size(813, 33);
            this.textBoxPinchBanner.TabIndex = 2;
            this.textBoxPinchBanner.Text = "PINCH STUDY";
            this.textBoxPinchBanner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxOpenedPinch
            // 
            this.pictureBoxOpenedPinch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOpenedPinch.Image")));
            this.pictureBoxOpenedPinch.Location = new System.Drawing.Point(7, 4);
            this.pictureBoxOpenedPinch.Name = "pictureBoxOpenedPinch";
            this.pictureBoxOpenedPinch.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxOpenedPinch.TabIndex = 3;
            this.pictureBoxOpenedPinch.TabStop = false;
            // 
            // imageListProject
            // 
            this.imageListProject.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListProject.ImageStream")));
            this.imageListProject.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListProject.Images.SetKeyName(0, "Project Explorer...32x32.png");
            this.imageListProject.Images.SetKeyName(1, "Project...32x32.png");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainerLefCenter);
            this.Controls.Add(this.statusStripMainDASHBOARD);
            this.Controls.Add(this.menuStripMainCatalog);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMainCatalog;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AJP HEN Studio";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.contextMenuStripHen.ResumeLayout(false);
            this.contextMenuStripPinch.ResumeLayout(false);
            this.contextMenuStripProfile.ResumeLayout(false);
            this.contextMenuStripCurrProj.ResumeLayout(false);
            this.contextMenuStripProjectCatalog.ResumeLayout(false);
            this.menuStripMainCatalog.ResumeLayout(false);
            this.menuStripMainCatalog.PerformLayout();
            this.statusStripMainDASHBOARD.ResumeLayout(false);
            this.statusStripMainDASHBOARD.PerformLayout();
            this.splitContainerLefCenter.Panel1.ResumeLayout(false);
            this.splitContainerLefCenter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLefCenter)).EndInit();
            this.splitContainerLefCenter.ResumeLayout(false);
            this.splitContainerProject.Panel1.ResumeLayout(false);
            this.splitContainerProject.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProject)).EndInit();
            this.splitContainerProject.ResumeLayout(false);
            this.contextMenuStripProjectZip.ResumeLayout(false);
            this.panelSELECTED_PROJECT.ResumeLayout(false);
            this.panelSELECTED_PROJECT.PerformLayout();
            this.panelDefaultParmeters.ResumeLayout(false);
            this.panelDefaultParmeters.PerformLayout();
            this.panelExchanger.ResumeLayout(false);
            this.panelExchanger.PerformLayout();
            this.panelDefaultHenOptimizer.ResumeLayout(false);
            this.panelDefaultHenOptimizer.PerformLayout();
            this.panelProjectUnits.ResumeLayout(false);
            this.panelProjectUnits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnitsSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedProject)).EndInit();
            this.panelProjectMetadata.ResumeLayout(false);
            this.panelProjectMetadata.PerformLayout();
            this.panelSELECTED_PROJECTS.ResumeLayout(false);
            this.panelSELECTED_PROJECTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductLogo)).EndInit();
            this.panelProjectDbFileMetadata.ResumeLayout(false);
            this.panelProjectDbFileMetadata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProjects)).EndInit();
            this.panelSELECTED_PROFILE.ResumeLayout(false);
            this.panelSELECTED_PROFILE.PerformLayout();
            this.tabControlInputPhase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedProfile)).EndInit();
            this.panelSELECTED_HEN.ResumeLayout(false);
            this.panelSELECTED_HEN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedHen)).EndInit();
            this.panelSELECTED_PINCH.ResumeLayout(false);
            this.panelSELECTED_PINCH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedPinch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainCatalog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripMainDASHBOARD;
        private System.Windows.Forms.ImageList imageListAnalysis;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ImageList imageListInput;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListTargets;
        private System.Windows.Forms.ImageList imageListHen;
        private System.Windows.Forms.ToolStripMenuItem scorecardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userLicenseAgreementToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerLefCenter;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ImageList imageListProject;
        private System.Windows.Forms.TabControl tabControlInputPhase;
        private System.Windows.Forms.TabPage tabPageStreams;
        private System.Windows.Forms.TabPage tabPageUtilities;
        private System.Windows.Forms.TabPage tabPageEconomics;
        private System.Windows.Forms.SplitContainer splitContainerProject;
        private System.Windows.Forms.TextBox textBoxInputBanner;
        private System.Windows.Forms.TextBox textBoxPinchBanner;
        private System.Windows.Forms.TextBox textBoxHenBanner;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProjectCatalog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddProject;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImport;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCurrProj;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCurProjRename;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorCurProjAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCurProjSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProfile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPinch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPinchRename;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPinchAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorRename;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPinchDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProfileRename;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProfileAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProfileDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCurProjAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripHen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCurProjHenRename;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorCurProjHenRename;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCurProjHenDelete;
        private System.Windows.Forms.ImageList imageListProjectTreeViews;
        private System.Windows.Forms.ToolStripMenuItem catalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem importProjectZIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem exitAJPHENStudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem licenseViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseScoreCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem userLicenseAgreementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutAJPHENStudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLICENSE;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCAT_DB;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAJP_LOGO;
        private System.Windows.Forms.TreeView treeViewProjectZipExplorer;
        private System.Windows.Forms.ImageList imageListProjectZIP;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCollapseAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExpandAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorExpandCollapse;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCurrProjExpandAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCurrProjCollapseAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorCurrProjExpandAll;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProjectZip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZipExpandAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZipCollapseAll;
        private System.Windows.Forms.TextBox textBoxProjectBanner;
        private System.Windows.Forms.TextBox textBoxProjectNameValue;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.TextBox textBoxProjectDescriptionValue;
        private System.Windows.Forms.TextBox textBoxProjectDescription;
        private System.Windows.Forms.PictureBox pictureBoxOpenedProject;
        private System.Windows.Forms.PictureBox pictureBoxOpenedProfile;
        private System.Windows.Forms.PictureBox pictureBoxOpenedPinch;
        private System.Windows.Forms.PictureBox pictureBoxOpenedHen;
        private System.Windows.Forms.Panel panelProjectMetadata;
        private System.Windows.Forms.Panel panelProjectUnits;
        private System.Windows.Forms.TextBox textBoxUnitsSystem;
        private System.Windows.Forms.TextBox textBoxUnitsMagnitude;
        private System.Windows.Forms.PictureBox pictureBoxUnitsSystem;
        private System.Windows.Forms.TextBox textBoxUnitsTemp;
        private System.Windows.Forms.TextBox textBoxUnitsPress;
        private System.Windows.Forms.TextBox textBoxUnitsAreaValue;
        private System.Windows.Forms.TextBox textBoxUnitsArea;
        private System.Windows.Forms.TextBox textBoxCPDefinition;
        private System.Windows.Forms.TextBox textBoxUnitsCP;
        private System.Windows.Forms.TextBox textBoxUnitsDutyValue;
        private System.Windows.Forms.TextBox textBoxUnitsDuty;
        private System.Windows.Forms.TextBox textBoxUDefinition;
        private System.Windows.Forms.TextBox textBoxUnitsUValue;
        private System.Windows.Forms.TextBox textBoxUnitsU;
        private System.Windows.Forms.TextBox textBoxUnitsCPValue;
        private System.Windows.Forms.TextBox textBoxUnitsTitle;
        private System.Windows.Forms.Panel panelProjectDbFileMetadata;
        private System.Windows.Forms.TextBox textBoxConnStateValue;
        private System.Windows.Forms.TextBox textBoxConnState;
        private System.Windows.Forms.TextBox textBoxConnDataSourceValue;
        private System.Windows.Forms.TextBox textBoxConnDataSource;
        private System.Windows.Forms.TextBox textBoxDbConnectionTitle;
        private System.Windows.Forms.TextBox textBoxConnPacketSizeValue;
        private System.Windows.Forms.TextBox textBoxConnPacketSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLEVEL_PROJECT;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLEVEL_PROFILE;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLEVEL_PINCH;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLEVEL_HEN;
        private System.Windows.Forms.TreeView treeViewCurrentProjectExplorer;
        private System.Windows.Forms.Panel panelSELECTED_PROJECTS;
        private System.Windows.Forms.PictureBox pictureBoxProjects;
        private System.Windows.Forms.TextBox textBoxProjectsBanner;
        private System.Windows.Forms.Panel panelSELECTED_PROFILE;
        private System.Windows.Forms.Panel panelSELECTED_PROJECT;
        private System.Windows.Forms.Panel panelSELECTED_HEN;
        private System.Windows.Forms.Panel panelSELECTED_PINCH;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelProjectDirtyFlag;
        private System.Windows.Forms.TextBox textBoxConnInitCatalogValue;
        private System.Windows.Forms.TextBox textBoxConnInitCatalog;
        private System.Windows.Forms.TextBox textBoxConnWorkstationIDValue;
        private System.Windows.Forms.TextBox textBoxConnWorkstationID;
        private System.Windows.Forms.TextBox textBoxConnUserIDValue;
        private System.Windows.Forms.TextBox textBoxConnUserID;
        private System.Windows.Forms.TextBox textBoxConnTimeoutValue;
        private System.Windows.Forms.TextBox textBoxConnTimeout;
        private System.Windows.Forms.TextBox textBoxConnServerVersionValue;
        private System.Windows.Forms.TextBox textBoxConnServerVersion;
        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.PictureBox pictureBoxProductLogo;
        private System.Windows.Forms.Panel panelDefaultParmeters;
        private System.Windows.Forms.TextBox textBoxDefaultLabel;
        private System.Windows.Forms.Panel panelExchanger;
        private System.Windows.Forms.TextBox textBoxDefaultU_Value;
        private System.Windows.Forms.TextBox textBoxDefaultU_Units;
        private System.Windows.Forms.TextBox textBoxDefaultU;
        private System.Windows.Forms.TextBox textBoxExchangerDefaults;
        private System.Windows.Forms.Panel panelDefaultHenOptimizer;
        private System.Windows.Forms.TextBox textBoxDefaultHenOptimizerTitle;
        private System.Windows.Forms.TextBox textBoxDefaultHenOpitimizer;
        private System.Windows.Forms.TextBox textBoxProjectGUID;
        private System.Windows.Forms.TextBox textBoxProjectID;
        private System.Windows.Forms.TextBox textBoxProjectUnitsSystem;
        private System.Windows.Forms.TextBox textBoxProjectUnitsPress;
        private System.Windows.Forms.TextBox textBoxProjectUnitsTemp;
        private System.Windows.Forms.TextBox textBoxProjectUnitsMagnitude;
    }
}

