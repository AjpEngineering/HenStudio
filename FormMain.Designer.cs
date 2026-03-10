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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Project: Deer Park", 1, 2);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Project: Norco", 1, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Project: Convent", 1, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Project Catalog", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Hen: Base Design", 7, 8);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Hen: MER Design", 7, 8);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Pinch: Delta T=10", 5, 6, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Hen: Base Design", 7, 8);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Hen: MER Design", 7, 8);
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Pinch: Delta T=20", 5, 6, new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Profile: Q1 Setup", 3, 4, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Pinch: Delta T=10", 5, 6);
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Profile: Q2 Setup", 3, 4, new System.Windows.Forms.TreeNode[] {
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Profile: Q3 Setup", 3, 4);
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Profile: Q4 Setup", 3, 4);
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Project: Deer Park", 2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode25,
            treeNode26,
            treeNode27});
            this.contextMenuStripProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorDelete = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripProjectCatalog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImport = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripHen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCurProjHenRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorCurProjHenRename = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCurProjHenDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripPinch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemPinchRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPinchAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorRename = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemPinchDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripProfile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemProfileRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProfileAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemProfileDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripCurrProj = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCurProjRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCurProjAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorCurProjAdd = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCurProjSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCurProjSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorCurProjSave = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCurProjClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMainCatalog = new System.Windows.Forms.MenuStrip();
            this.catalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.importProjectZIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.exitAJPHENStudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.imageListAnalysis = new System.Windows.Forms.ImageList(this.components);
            this.imageListInput = new System.Windows.Forms.ImageList(this.components);
            this.imageListTargets = new System.Windows.Forms.ImageList(this.components);
            this.imageListHen = new System.Windows.Forms.ImageList(this.components);
            this.splitContainerLefCenter = new System.Windows.Forms.SplitContainer();
            this.tabControlProject = new System.Windows.Forms.TabControl();
            this.tabPageCatalogExplorer = new System.Windows.Forms.TabPage();
            this.splitContainerProject = new System.Windows.Forms.SplitContainer();
            this.treeViewCatalogExplorer = new System.Windows.Forms.TreeView();
            this.imageListProjectTreeViews = new System.Windows.Forms.ImageList(this.components);
            this.tabPageCurrentProject = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeViewCurrentProjectExplorer = new System.Windows.Forms.TreeView();
            this.imageListProject = new System.Windows.Forms.ImageList(this.components);
            this.tabControlAnalysisPhase = new System.Windows.Forms.TabControl();
            this.tabPageInputProfile = new System.Windows.Forms.TabPage();
            this.textBoxInputBanner = new System.Windows.Forms.TextBox();
            this.tabControlInputPhase = new System.Windows.Forms.TabControl();
            this.tabPageStreams = new System.Windows.Forms.TabPage();
            this.tabPageUtilities = new System.Windows.Forms.TabPage();
            this.tabPageEconomics = new System.Windows.Forms.TabPage();
            this.tabPagePinchStudy = new System.Windows.Forms.TabPage();
            this.textBoxPinchBanner = new System.Windows.Forms.TextBox();
            this.tabPageHenDesign = new System.Windows.Forms.TabPage();
            this.textBoxHenBanner = new System.Windows.Forms.TextBox();
            this.toolStripStatusLabelLICENSE = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCAT_DB = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPROJ_DB = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPROJ_NAME = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPROJ_UNITS = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAJP_LOGO = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStripProject.SuspendLayout();
            this.contextMenuStripProjectCatalog.SuspendLayout();
            this.contextMenuStripHen.SuspendLayout();
            this.contextMenuStripPinch.SuspendLayout();
            this.contextMenuStripProfile.SuspendLayout();
            this.contextMenuStripCurrProj.SuspendLayout();
            this.menuStripMainCatalog.SuspendLayout();
            this.statusStripMainDASHBOARD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLefCenter)).BeginInit();
            this.splitContainerLefCenter.Panel1.SuspendLayout();
            this.splitContainerLefCenter.Panel2.SuspendLayout();
            this.splitContainerLefCenter.SuspendLayout();
            this.tabControlProject.SuspendLayout();
            this.tabPageCatalogExplorer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProject)).BeginInit();
            this.splitContainerProject.Panel1.SuspendLayout();
            this.splitContainerProject.SuspendLayout();
            this.tabPageCurrentProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControlAnalysisPhase.SuspendLayout();
            this.tabPageInputProfile.SuspendLayout();
            this.tabControlInputPhase.SuspendLayout();
            this.tabPagePinchStudy.SuspendLayout();
            this.tabPageHenDesign.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripProject
            // 
            this.contextMenuStripProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRename,
            this.toolStripMenuItemOpen,
            this.toolStripSeparatorDelete,
            this.toolStripMenuItemDelete});
            this.contextMenuStripProject.Name = "contextMenuStripProject";
            this.contextMenuStripProject.Size = new System.Drawing.Size(167, 76);
            // 
            // toolStripMenuItemRename
            // 
            this.toolStripMenuItemRename.Name = "toolStripMenuItemRename";
            this.toolStripMenuItemRename.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItemRename.Text = "Rename Project...";
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItemOpen.Text = "Open";
            // 
            // toolStripSeparatorDelete
            // 
            this.toolStripSeparatorDelete.Name = "toolStripSeparatorDelete";
            this.toolStripSeparatorDelete.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItemDelete.Text = "Delete Project...";
            // 
            // contextMenuStripProjectCatalog
            // 
            this.contextMenuStripProjectCatalog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenuStripProjectCatalog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddProject,
            this.toolStripMenuItemImport});
            this.contextMenuStripProjectCatalog.Name = "contextMenuStripProjectCatalog";
            this.contextMenuStripProjectCatalog.Size = new System.Drawing.Size(180, 48);
            this.contextMenuStripProjectCatalog.Text = "PROJECT CATALOG";
            // 
            // toolStripMenuItemAddProject
            // 
            this.toolStripMenuItemAddProject.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAddProject.Image")));
            this.toolStripMenuItemAddProject.Name = "toolStripMenuItemAddProject";
            this.toolStripMenuItemAddProject.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuItemAddProject.Text = "Add New Project...";
            // 
            // toolStripMenuItemImport
            // 
            this.toolStripMenuItemImport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemImport.Image")));
            this.toolStripMenuItemImport.Name = "toolStripMenuItemImport";
            this.toolStripMenuItemImport.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuItemImport.Text = "Import Zip Project...";
            // 
            // contextMenuStripHen
            // 
            this.contextMenuStripHen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCurProjHenRename,
            this.toolStripSeparatorCurProjHenRename,
            this.toolStripMenuItemCurProjHenDelete});
            this.contextMenuStripHen.Name = "contextMenuStripHen";
            this.contextMenuStripHen.Size = new System.Drawing.Size(127, 54);
            // 
            // toolStripMenuItemCurProjHenRename
            // 
            this.toolStripMenuItemCurProjHenRename.Name = "toolStripMenuItemCurProjHenRename";
            this.toolStripMenuItemCurProjHenRename.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItemCurProjHenRename.Text = "Rename...";
            // 
            // toolStripSeparatorCurProjHenRename
            // 
            this.toolStripSeparatorCurProjHenRename.Name = "toolStripSeparatorCurProjHenRename";
            this.toolStripSeparatorCurProjHenRename.Size = new System.Drawing.Size(123, 6);
            // 
            // toolStripMenuItemCurProjHenDelete
            // 
            this.toolStripMenuItemCurProjHenDelete.Name = "toolStripMenuItemCurProjHenDelete";
            this.toolStripMenuItemCurProjHenDelete.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItemCurProjHenDelete.Text = "Delete...";
            // 
            // contextMenuStripPinch
            // 
            this.contextMenuStripPinch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPinchRename,
            this.toolStripMenuItemPinchAdd,
            this.toolStripSeparatorRename,
            this.toolStripMenuItemPinchDelete});
            this.contextMenuStripPinch.Name = "contextMenuStripPinch";
            this.contextMenuStripPinch.Size = new System.Drawing.Size(313, 76);
            // 
            // toolStripMenuItemPinchRename
            // 
            this.toolStripMenuItemPinchRename.Name = "toolStripMenuItemPinchRename";
            this.toolStripMenuItemPinchRename.Size = new System.Drawing.Size(312, 22);
            this.toolStripMenuItemPinchRename.Text = "Rename...";
            // 
            // toolStripMenuItemPinchAdd
            // 
            this.toolStripMenuItemPinchAdd.Name = "toolStripMenuItemPinchAdd";
            this.toolStripMenuItemPinchAdd.Size = new System.Drawing.Size(312, 22);
            this.toolStripMenuItemPinchAdd.Text = "Add Heat Exchanger Network (HEN) Design...";
            // 
            // toolStripSeparatorRename
            // 
            this.toolStripSeparatorRename.Name = "toolStripSeparatorRename";
            this.toolStripSeparatorRename.Size = new System.Drawing.Size(309, 6);
            // 
            // toolStripMenuItemPinchDelete
            // 
            this.toolStripMenuItemPinchDelete.Name = "toolStripMenuItemPinchDelete";
            this.toolStripMenuItemPinchDelete.Size = new System.Drawing.Size(312, 22);
            this.toolStripMenuItemPinchDelete.Text = "Delete...";
            // 
            // contextMenuStripProfile
            // 
            this.contextMenuStripProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemProfileRename,
            this.toolStripMenuItemProfileAdd,
            this.toolStripSeparator4,
            this.toolStripMenuItemProfileDelete});
            this.contextMenuStripProfile.Name = "contextMenuStripProfile";
            this.contextMenuStripProfile.Size = new System.Drawing.Size(172, 76);
            // 
            // toolStripMenuItemProfileRename
            // 
            this.toolStripMenuItemProfileRename.Name = "toolStripMenuItemProfileRename";
            this.toolStripMenuItemProfileRename.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItemProfileRename.Text = "Rename...";
            // 
            // toolStripMenuItemProfileAdd
            // 
            this.toolStripMenuItemProfileAdd.Name = "toolStripMenuItemProfileAdd";
            this.toolStripMenuItemProfileAdd.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItemProfileAdd.Text = "Add Pinch Study...";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(168, 6);
            // 
            // toolStripMenuItemProfileDelete
            // 
            this.toolStripMenuItemProfileDelete.Name = "toolStripMenuItemProfileDelete";
            this.toolStripMenuItemProfileDelete.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItemProfileDelete.Text = "Delete...";
            // 
            // contextMenuStripCurrProj
            // 
            this.contextMenuStripCurrProj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCurProjRename,
            this.toolStripMenuItemCurProjAdd,
            this.toolStripSeparatorCurProjAdd,
            this.toolStripMenuItemCurProjSave,
            this.toolStripMenuItemCurProjSaveAs,
            this.toolStripSeparatorCurProjSave,
            this.toolStripMenuItemCurProjClose});
            this.contextMenuStripCurrProj.Name = "contextMenuStripCurrProj";
            this.contextMenuStripCurrProj.Size = new System.Drawing.Size(174, 126);
            // 
            // toolStripMenuItemCurProjRename
            // 
            this.toolStripMenuItemCurProjRename.Name = "toolStripMenuItemCurProjRename";
            this.toolStripMenuItemCurProjRename.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemCurProjRename.Text = "Rename Project...";
            // 
            // toolStripMenuItemCurProjAdd
            // 
            this.toolStripMenuItemCurProjAdd.Name = "toolStripMenuItemCurProjAdd";
            this.toolStripMenuItemCurProjAdd.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemCurProjAdd.Text = "Add Input Profile...";
            // 
            // toolStripSeparatorCurProjAdd
            // 
            this.toolStripSeparatorCurProjAdd.Name = "toolStripSeparatorCurProjAdd";
            this.toolStripSeparatorCurProjAdd.Size = new System.Drawing.Size(170, 6);
            // 
            // toolStripMenuItemCurProjSave
            // 
            this.toolStripMenuItemCurProjSave.Name = "toolStripMenuItemCurProjSave";
            this.toolStripMenuItemCurProjSave.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemCurProjSave.Text = "Save";
            // 
            // toolStripMenuItemCurProjSaveAs
            // 
            this.toolStripMenuItemCurProjSaveAs.Name = "toolStripMenuItemCurProjSaveAs";
            this.toolStripMenuItemCurProjSaveAs.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemCurProjSaveAs.Text = "Save As...";
            // 
            // toolStripSeparatorCurProjSave
            // 
            this.toolStripSeparatorCurProjSave.Name = "toolStripSeparatorCurProjSave";
            this.toolStripSeparatorCurProjSave.Size = new System.Drawing.Size(170, 6);
            // 
            // toolStripMenuItemCurProjClose
            // 
            this.toolStripMenuItemCurProjClose.Name = "toolStripMenuItemCurProjClose";
            this.toolStripMenuItemCurProjClose.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemCurProjClose.Text = "Close";
            // 
            // menuStripMainCatalog
            // 
            this.menuStripMainCatalog.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMainCatalog.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMainCatalog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogToolStripMenuItem,
            this.editToolStripMenuItem,
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
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsDisplayToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // settingsDisplayToolStripMenuItem
            // 
            this.settingsDisplayToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsDisplayToolStripMenuItem.Image")));
            this.settingsDisplayToolStripMenuItem.Name = "settingsDisplayToolStripMenuItem";
            this.settingsDisplayToolStripMenuItem.Size = new System.Drawing.Size(137, 30);
            this.settingsDisplayToolStripMenuItem.Text = "Settings...";
            this.settingsDisplayToolStripMenuItem.ToolTipText = "System-Wide Settings";
            this.settingsDisplayToolStripMenuItem.Click += new System.EventHandler(this.settingsDisplayToolStripMenuItem_Click);
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
            this.toolStripStatusLabelPROJ_DB,
            this.toolStripStatusLabelPROJ_NAME,
            this.toolStripStatusLabelPROJ_UNITS,
            this.toolStripStatusLabelAJP_LOGO});
            this.statusStripMainDASHBOARD.Location = new System.Drawing.Point(0, 648);
            this.statusStripMainDASHBOARD.Name = "statusStripMainDASHBOARD";
            this.statusStripMainDASHBOARD.Size = new System.Drawing.Size(1264, 33);
            this.statusStripMainDASHBOARD.TabIndex = 6;
            // 
            // imageListAnalysis
            // 
            this.imageListAnalysis.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAnalysis.ImageStream")));
            this.imageListAnalysis.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAnalysis.Images.SetKeyName(0, "Input.png");
            this.imageListAnalysis.Images.SetKeyName(1, "Target.png");
            this.imageListAnalysis.Images.SetKeyName(2, "HEN Studio Graphic...32x32.png");
            this.imageListAnalysis.Images.SetKeyName(3, "HEN.png");
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
            this.splitContainerLefCenter.Name = "splitContainerLefCenter";
            // 
            // splitContainerLefCenter.Panel1
            // 
            this.splitContainerLefCenter.Panel1.BackColor = System.Drawing.Color.Honeydew;
            this.splitContainerLefCenter.Panel1.Controls.Add(this.tabControlProject);
            this.splitContainerLefCenter.Panel1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerLefCenter.Panel1MinSize = 325;
            // 
            // splitContainerLefCenter.Panel2
            // 
            this.splitContainerLefCenter.Panel2.BackColor = System.Drawing.Color.Honeydew;
            this.splitContainerLefCenter.Panel2.Controls.Add(this.tabControlAnalysisPhase);
            this.splitContainerLefCenter.Panel2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerLefCenter.Panel2MinSize = 910;
            this.splitContainerLefCenter.Size = new System.Drawing.Size(1264, 624);
            this.splitContainerLefCenter.SplitterDistance = 330;
            this.splitContainerLefCenter.TabIndex = 2;
            // 
            // tabControlProject
            // 
            this.tabControlProject.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlProject.Controls.Add(this.tabPageCatalogExplorer);
            this.tabControlProject.Controls.Add(this.tabPageCurrentProject);
            this.tabControlProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlProject.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlProject.ImageList = this.imageListProject;
            this.tabControlProject.Location = new System.Drawing.Point(0, 0);
            this.tabControlProject.MinimumSize = new System.Drawing.Size(350, 621);
            this.tabControlProject.Name = "tabControlProject";
            this.tabControlProject.SelectedIndex = 0;
            this.tabControlProject.ShowToolTips = true;
            this.tabControlProject.Size = new System.Drawing.Size(350, 622);
            this.tabControlProject.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlProject.TabIndex = 0;
            // 
            // tabPageCatalogExplorer
            // 
            this.tabPageCatalogExplorer.BackColor = System.Drawing.Color.Honeydew;
            this.tabPageCatalogExplorer.Controls.Add(this.splitContainerProject);
            this.tabPageCatalogExplorer.ImageIndex = 0;
            this.tabPageCatalogExplorer.Location = new System.Drawing.Point(4, 4);
            this.tabPageCatalogExplorer.Name = "tabPageCatalogExplorer";
            this.tabPageCatalogExplorer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCatalogExplorer.Size = new System.Drawing.Size(342, 579);
            this.tabPageCatalogExplorer.TabIndex = 0;
            this.tabPageCatalogExplorer.Text = "CATALOG EXPLORER ";
            this.tabPageCatalogExplorer.ToolTipText = "Project Explorer";
            // 
            // splitContainerProject
            // 
            this.splitContainerProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerProject.Location = new System.Drawing.Point(3, 3);
            this.splitContainerProject.Name = "splitContainerProject";
            this.splitContainerProject.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerProject.Panel1
            // 
            this.splitContainerProject.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainerProject.Panel1.Controls.Add(this.treeViewCatalogExplorer);
            this.splitContainerProject.Panel1MinSize = 300;
            this.splitContainerProject.Panel2MinSize = 250;
            this.splitContainerProject.Size = new System.Drawing.Size(336, 573);
            this.splitContainerProject.SplitterDistance = 301;
            this.splitContainerProject.TabIndex = 0;
            // 
            // treeViewCatalogExplorer
            // 
            this.treeViewCatalogExplorer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.treeViewCatalogExplorer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewCatalogExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewCatalogExplorer.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewCatalogExplorer.ImageIndex = 0;
            this.treeViewCatalogExplorer.ImageList = this.imageListProjectTreeViews;
            this.treeViewCatalogExplorer.Location = new System.Drawing.Point(0, 0);
            this.treeViewCatalogExplorer.Name = "treeViewCatalogExplorer";
            treeNode1.ContextMenuStrip = this.contextMenuStripProject;
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "NodeProject_01";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Text = "Project: Deer Park";
            treeNode1.ToolTipText = "Shell Petrochemical Plant Retrofit";
            treeNode2.ContextMenuStrip = this.contextMenuStripProject;
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "NodeProject_02";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "Project: Norco";
            treeNode2.ToolTipText = "Shell Refinery Retrofit";
            treeNode3.ContextMenuStrip = this.contextMenuStripProject;
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "NodeProject_03";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "Project: Convent";
            treeNode3.ToolTipText = "Aramco Refinery Retrofit";
            treeNode4.ContextMenuStrip = this.contextMenuStripProjectCatalog;
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "NodeRootCatalog";
            treeNode4.SelectedImageIndex = 0;
            treeNode4.Text = "Project Catalog";
            treeNode4.ToolTipText = "Root Project Catalog Node";
            this.treeViewCatalogExplorer.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeViewCatalogExplorer.SelectedImageIndex = 0;
            this.treeViewCatalogExplorer.Size = new System.Drawing.Size(334, 299);
            this.treeViewCatalogExplorer.TabIndex = 0;
            // 
            // imageListProjectTreeViews
            // 
            this.imageListProjectTreeViews.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListProjectTreeViews.ImageStream")));
            this.imageListProjectTreeViews.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListProjectTreeViews.Images.SetKeyName(0, "Catalog_16x16.ico");
            this.imageListProjectTreeViews.Images.SetKeyName(1, "Project_16x16.ico");
            this.imageListProjectTreeViews.Images.SetKeyName(2, "ProjectSelected_16x16.ico");
            this.imageListProjectTreeViews.Images.SetKeyName(3, "Profile_Input_16x16.ico");
            this.imageListProjectTreeViews.Images.SetKeyName(4, "Profile_Input_Selected_16x16.ico");
            this.imageListProjectTreeViews.Images.SetKeyName(5, "Pinch_16x16.ico");
            this.imageListProjectTreeViews.Images.SetKeyName(6, "PinchSelected_16x16.ico");
            this.imageListProjectTreeViews.Images.SetKeyName(7, "HEN_16x16.ico");
            this.imageListProjectTreeViews.Images.SetKeyName(8, "HENSelected_16x16.ico");
            // 
            // tabPageCurrentProject
            // 
            this.tabPageCurrentProject.BackColor = System.Drawing.Color.Honeydew;
            this.tabPageCurrentProject.Controls.Add(this.splitContainer2);
            this.tabPageCurrentProject.ImageIndex = 1;
            this.tabPageCurrentProject.Location = new System.Drawing.Point(4, 4);
            this.tabPageCurrentProject.Name = "tabPageCurrentProject";
            this.tabPageCurrentProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCurrentProject.Size = new System.Drawing.Size(342, 590);
            this.tabPageCurrentProject.TabIndex = 1;
            this.tabPageCurrentProject.Text = "CURRENT PROJECT ";
            this.tabPageCurrentProject.ToolTipText = "Current Project";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.treeViewCurrentProjectExplorer);
            this.splitContainer2.Panel1MinSize = 300;
            this.splitContainer2.Panel2MinSize = 250;
            this.splitContainer2.Size = new System.Drawing.Size(336, 584);
            this.splitContainer2.SplitterDistance = 307;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeViewCurrentProjectExplorer
            // 
            this.treeViewCurrentProjectExplorer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.treeViewCurrentProjectExplorer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewCurrentProjectExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewCurrentProjectExplorer.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewCurrentProjectExplorer.ImageIndex = 0;
            this.treeViewCurrentProjectExplorer.ImageList = this.imageListProjectTreeViews;
            this.treeViewCurrentProjectExplorer.Location = new System.Drawing.Point(0, 0);
            this.treeViewCurrentProjectExplorer.Name = "treeViewCurrentProjectExplorer";
            treeNode5.ContextMenuStrip = this.contextMenuStripHen;
            treeNode5.ImageIndex = 7;
            treeNode5.Name = "NodeProfile_01_Pinch_01_Hen_01";
            treeNode5.SelectedImageIndex = 8;
            treeNode5.Text = "Hen: Base Design";
            treeNode6.ContextMenuStrip = this.contextMenuStripHen;
            treeNode6.ImageIndex = 7;
            treeNode6.Name = "NodeProfile_01_Pinch_01_Hen_02";
            treeNode6.SelectedImageIndex = 8;
            treeNode6.Text = "Hen: MER Design";
            treeNode7.ContextMenuStrip = this.contextMenuStripPinch;
            treeNode7.ImageIndex = 5;
            treeNode7.Name = "NodeProfile_01_Pinch_01";
            treeNode7.SelectedImageIndex = 6;
            treeNode7.Text = "Pinch: Delta T=10";
            treeNode8.ContextMenuStrip = this.contextMenuStripHen;
            treeNode8.ImageIndex = 7;
            treeNode8.Name = "NodeProfile_01_Pinch_02_Hen_01";
            treeNode8.SelectedImageIndex = 8;
            treeNode8.Text = "Hen: Base Design";
            treeNode21.ContextMenuStrip = this.contextMenuStripHen;
            treeNode21.ImageIndex = 7;
            treeNode21.Name = "NodeProfile_01_Pinch_02_Hen_02";
            treeNode21.SelectedImageIndex = 8;
            treeNode21.Text = "Hen: MER Design";
            treeNode22.ContextMenuStrip = this.contextMenuStripPinch;
            treeNode22.ImageIndex = 5;
            treeNode22.Name = "NodeProfile_01_Pinch_02";
            treeNode22.SelectedImageIndex = 6;
            treeNode22.Text = "Pinch: Delta T=20";
            treeNode23.ContextMenuStrip = this.contextMenuStripProfile;
            treeNode23.ImageIndex = 3;
            treeNode23.Name = "NodeProfile_01";
            treeNode23.SelectedImageIndex = 4;
            treeNode23.Text = "Profile: Q1 Setup";
            treeNode24.ContextMenuStrip = this.contextMenuStripPinch;
            treeNode24.ImageIndex = 5;
            treeNode24.Name = "NodeProfile_02_Pinch_01";
            treeNode24.SelectedImageIndex = 6;
            treeNode24.Text = "Pinch: Delta T=10";
            treeNode25.ContextMenuStrip = this.contextMenuStripProfile;
            treeNode25.ImageIndex = 3;
            treeNode25.Name = "NodeProfile_02";
            treeNode25.SelectedImageIndex = 4;
            treeNode25.Text = "Profile: Q2 Setup";
            treeNode26.ContextMenuStrip = this.contextMenuStripProfile;
            treeNode26.ImageIndex = 3;
            treeNode26.Name = "NodeProfile_03";
            treeNode26.SelectedImageIndex = 4;
            treeNode26.Text = "Profile: Q3 Setup";
            treeNode27.ContextMenuStrip = this.contextMenuStripProfile;
            treeNode27.ImageIndex = 3;
            treeNode27.Name = "NodeProfile_04";
            treeNode27.SelectedImageIndex = 4;
            treeNode27.Text = "Profile: Q4 Setup";
            treeNode28.ContextMenuStrip = this.contextMenuStripCurrProj;
            treeNode28.ImageIndex = 2;
            treeNode28.Name = "NodeRootCurrProject";
            treeNode28.SelectedImageIndex = 2;
            treeNode28.Text = "Project: Deer Park";
            this.treeViewCurrentProjectExplorer.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode28});
            this.treeViewCurrentProjectExplorer.SelectedImageIndex = 0;
            this.treeViewCurrentProjectExplorer.Size = new System.Drawing.Size(334, 305);
            this.treeViewCurrentProjectExplorer.TabIndex = 0;
            // 
            // imageListProject
            // 
            this.imageListProject.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListProject.ImageStream")));
            this.imageListProject.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListProject.Images.SetKeyName(0, "Project Explorer...32x32.png");
            this.imageListProject.Images.SetKeyName(1, "Project...32x32.png");
            // 
            // tabControlAnalysisPhase
            // 
            this.tabControlAnalysisPhase.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlAnalysisPhase.Controls.Add(this.tabPageInputProfile);
            this.tabControlAnalysisPhase.Controls.Add(this.tabPagePinchStudy);
            this.tabControlAnalysisPhase.Controls.Add(this.tabPageHenDesign);
            this.tabControlAnalysisPhase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAnalysisPhase.ImageList = this.imageListAnalysis;
            this.tabControlAnalysisPhase.Location = new System.Drawing.Point(0, 0);
            this.tabControlAnalysisPhase.Name = "tabControlAnalysisPhase";
            this.tabControlAnalysisPhase.SelectedIndex = 0;
            this.tabControlAnalysisPhase.ShowToolTips = true;
            this.tabControlAnalysisPhase.Size = new System.Drawing.Size(928, 622);
            this.tabControlAnalysisPhase.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlAnalysisPhase.TabIndex = 0;
            // 
            // tabPageInputProfile
            // 
            this.tabPageInputProfile.BackColor = System.Drawing.Color.Honeydew;
            this.tabPageInputProfile.Controls.Add(this.textBoxInputBanner);
            this.tabPageInputProfile.Controls.Add(this.tabControlInputPhase);
            this.tabPageInputProfile.ImageIndex = 0;
            this.tabPageInputProfile.Location = new System.Drawing.Point(4, 4);
            this.tabPageInputProfile.Name = "tabPageInputProfile";
            this.tabPageInputProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInputProfile.Size = new System.Drawing.Size(920, 579);
            this.tabPageInputProfile.TabIndex = 0;
            this.tabPageInputProfile.Text = "CURRENT INPUT PROFILE ";
            this.tabPageInputProfile.ToolTipText = "Current Input Profile";
            // 
            // textBoxInputBanner
            // 
            this.textBoxInputBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.textBoxInputBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputBanner.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputBanner.ForeColor = System.Drawing.Color.Black;
            this.textBoxInputBanner.Location = new System.Drawing.Point(7, 3);
            this.textBoxInputBanner.Name = "textBoxInputBanner";
            this.textBoxInputBanner.Size = new System.Drawing.Size(902, 33);
            this.textBoxInputBanner.TabIndex = 1;
            this.textBoxInputBanner.Text = "PROJECT: {name}  PROFILE: {name}";
            this.textBoxInputBanner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.tabControlInputPhase.Location = new System.Drawing.Point(3, 39);
            this.tabControlInputPhase.Name = "tabControlInputPhase";
            this.tabControlInputPhase.SelectedIndex = 0;
            this.tabControlInputPhase.ShowToolTips = true;
            this.tabControlInputPhase.Size = new System.Drawing.Size(910, 543);
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
            this.tabPageStreams.Size = new System.Drawing.Size(902, 500);
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
            this.tabPageUtilities.Size = new System.Drawing.Size(902, 511);
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
            this.tabPageEconomics.Size = new System.Drawing.Size(902, 511);
            this.tabPageEconomics.TabIndex = 2;
            this.tabPageEconomics.Text = "ECONONMIC PARAMETERS";
            this.tabPageEconomics.ToolTipText = "Specify Economic Parameters for Current Input Profile";
            // 
            // tabPagePinchStudy
            // 
            this.tabPagePinchStudy.BackColor = System.Drawing.Color.White;
            this.tabPagePinchStudy.Controls.Add(this.textBoxPinchBanner);
            this.tabPagePinchStudy.ImageIndex = 1;
            this.tabPagePinchStudy.Location = new System.Drawing.Point(4, 4);
            this.tabPagePinchStudy.Name = "tabPagePinchStudy";
            this.tabPagePinchStudy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePinchStudy.Size = new System.Drawing.Size(920, 590);
            this.tabPagePinchStudy.TabIndex = 1;
            this.tabPagePinchStudy.Text = "CURRENT PINCH STUDY ";
            this.tabPagePinchStudy.ToolTipText = "Current Pinch Study";
            // 
            // textBoxPinchBanner
            // 
            this.textBoxPinchBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPinchBanner.BackColor = System.Drawing.Color.OrangeRed;
            this.textBoxPinchBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPinchBanner.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPinchBanner.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxPinchBanner.Location = new System.Drawing.Point(7, 3);
            this.textBoxPinchBanner.Name = "textBoxPinchBanner";
            this.textBoxPinchBanner.Size = new System.Drawing.Size(902, 33);
            this.textBoxPinchBanner.TabIndex = 2;
            this.textBoxPinchBanner.Text = "PROJECT: {name}  PROFILE: {name}  PINCH: {name}";
            this.textBoxPinchBanner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPageHenDesign
            // 
            this.tabPageHenDesign.BackColor = System.Drawing.Color.White;
            this.tabPageHenDesign.Controls.Add(this.textBoxHenBanner);
            this.tabPageHenDesign.ImageIndex = 2;
            this.tabPageHenDesign.Location = new System.Drawing.Point(4, 4);
            this.tabPageHenDesign.Name = "tabPageHenDesign";
            this.tabPageHenDesign.Size = new System.Drawing.Size(920, 590);
            this.tabPageHenDesign.TabIndex = 2;
            this.tabPageHenDesign.Text = "CURRENT HEAT EXCHANGER NETWORK (HEN) DESIGN ";
            this.tabPageHenDesign.ToolTipText = "Current Heat Exchanger Network (HEN Deisgn";
            // 
            // textBoxHenBanner
            // 
            this.textBoxHenBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHenBanner.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxHenBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHenBanner.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHenBanner.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxHenBanner.Location = new System.Drawing.Point(7, 3);
            this.textBoxHenBanner.Name = "textBoxHenBanner";
            this.textBoxHenBanner.Size = new System.Drawing.Size(902, 33);
            this.textBoxHenBanner.TabIndex = 3;
            this.textBoxHenBanner.Text = "PROJECT: {name}  PROFILE: {name}  PINCH: {name}  HEN: {name}";
            this.textBoxHenBanner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripStatusLabelLICENSE
            // 
            this.toolStripStatusLabelLICENSE.BackColor = System.Drawing.Color.Orange;
            this.toolStripStatusLabelLICENSE.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelLICENSE.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelLICENSE.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelLICENSE.Image")));
            this.toolStripStatusLabelLICENSE.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelLICENSE.Name = "toolStripStatusLabelLICENSE";
            this.toolStripStatusLabelLICENSE.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelLICENSE.Size = new System.Drawing.Size(147, 27);
            this.toolStripStatusLabelLICENSE.Text = "LIC: UNKNOWN";
            this.toolStripStatusLabelLICENSE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabelCAT_DB
            // 
            this.toolStripStatusLabelCAT_DB.BackColor = System.Drawing.Color.Orange;
            this.toolStripStatusLabelCAT_DB.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelCAT_DB.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelCAT_DB.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelCAT_DB.Image")));
            this.toolStripStatusLabelCAT_DB.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelCAT_DB.Name = "toolStripStatusLabelCAT_DB";
            this.toolStripStatusLabelCAT_DB.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelCAT_DB.Size = new System.Drawing.Size(154, 27);
            this.toolStripStatusLabelCAT_DB.Text = "CAT: UNKNOWN";
            this.toolStripStatusLabelCAT_DB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabelPROJ_DB
            // 
            this.toolStripStatusLabelPROJ_DB.BackColor = System.Drawing.Color.Orange;
            this.toolStripStatusLabelPROJ_DB.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelPROJ_DB.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelPROJ_DB.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelPROJ_DB.Image")));
            this.toolStripStatusLabelPROJ_DB.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelPROJ_DB.Name = "toolStripStatusLabelPROJ_DB";
            this.toolStripStatusLabelPROJ_DB.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelPROJ_DB.Size = new System.Drawing.Size(162, 27);
            this.toolStripStatusLabelPROJ_DB.Text = "PROJ: UNKNOWN";
            this.toolStripStatusLabelPROJ_DB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabelPROJ_NAME
            // 
            this.toolStripStatusLabelPROJ_NAME.BackColor = System.Drawing.Color.Orange;
            this.toolStripStatusLabelPROJ_NAME.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelPROJ_NAME.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelPROJ_NAME.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelPROJ_NAME.Image")));
            this.toolStripStatusLabelPROJ_NAME.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelPROJ_NAME.Name = "toolStripStatusLabelPROJ_NAME";
            this.toolStripStatusLabelPROJ_NAME.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelPROJ_NAME.Size = new System.Drawing.Size(209, 27);
            this.toolStripStatusLabelPROJ_NAME.Text = "PROJ NAME: UNKKOWN";
            this.toolStripStatusLabelPROJ_NAME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabelPROJ_UNITS
            // 
            this.toolStripStatusLabelPROJ_UNITS.BackColor = System.Drawing.Color.Orange;
            this.toolStripStatusLabelPROJ_UNITS.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelPROJ_UNITS.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelPROJ_UNITS.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelPROJ_UNITS.Image")));
            this.toolStripStatusLabelPROJ_UNITS.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelPROJ_UNITS.Name = "toolStripStatusLabelPROJ_UNITS";
            this.toolStripStatusLabelPROJ_UNITS.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelPROJ_UNITS.Size = new System.Drawing.Size(211, 27);
            this.toolStripStatusLabelPROJ_UNITS.Text = "PROJ UNITS: UNKNOWN";
            this.toolStripStatusLabelPROJ_UNITS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabelAJP_LOGO
            // 
            this.toolStripStatusLabelAJP_LOGO.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabelAJP_LOGO.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelAJP_LOGO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabelAJP_LOGO.DoubleClickEnabled = true;
            this.toolStripStatusLabelAJP_LOGO.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelAJP_LOGO.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelAJP_LOGO.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelAJP_LOGO.Image")));
            this.toolStripStatusLabelAJP_LOGO.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelAJP_LOGO.Name = "toolStripStatusLabelAJP_LOGO";
            this.toolStripStatusLabelAJP_LOGO.Padding = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.toolStripStatusLabelAJP_LOGO.Size = new System.Drawing.Size(315, 27);
            this.toolStripStatusLabelAJP_LOGO.Spring = true;
            this.toolStripStatusLabelAJP_LOGO.Text = "  ";
            this.toolStripStatusLabelAJP_LOGO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.contextMenuStripProject.ResumeLayout(false);
            this.contextMenuStripProjectCatalog.ResumeLayout(false);
            this.contextMenuStripHen.ResumeLayout(false);
            this.contextMenuStripPinch.ResumeLayout(false);
            this.contextMenuStripProfile.ResumeLayout(false);
            this.contextMenuStripCurrProj.ResumeLayout(false);
            this.menuStripMainCatalog.ResumeLayout(false);
            this.menuStripMainCatalog.PerformLayout();
            this.statusStripMainDASHBOARD.ResumeLayout(false);
            this.statusStripMainDASHBOARD.PerformLayout();
            this.splitContainerLefCenter.Panel1.ResumeLayout(false);
            this.splitContainerLefCenter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLefCenter)).EndInit();
            this.splitContainerLefCenter.ResumeLayout(false);
            this.tabControlProject.ResumeLayout(false);
            this.tabPageCatalogExplorer.ResumeLayout(false);
            this.splitContainerProject.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProject)).EndInit();
            this.splitContainerProject.ResumeLayout(false);
            this.tabPageCurrentProject.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControlAnalysisPhase.ResumeLayout(false);
            this.tabPageInputProfile.ResumeLayout(false);
            this.tabPageInputProfile.PerformLayout();
            this.tabControlInputPhase.ResumeLayout(false);
            this.tabPagePinchStudy.ResumeLayout(false);
            this.tabPagePinchStudy.PerformLayout();
            this.tabPageHenDesign.ResumeLayout(false);
            this.tabPageHenDesign.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControlProject;
        private System.Windows.Forms.TabPage tabPageCatalogExplorer;
        private System.Windows.Forms.TabPage tabPageCurrentProject;
        private System.Windows.Forms.ImageList imageListProject;
        private System.Windows.Forms.TabControl tabControlAnalysisPhase;
        private System.Windows.Forms.TabPage tabPageInputProfile;
        private System.Windows.Forms.TabPage tabPagePinchStudy;
        private System.Windows.Forms.TabPage tabPageHenDesign;
        private System.Windows.Forms.TabControl tabControlInputPhase;
        private System.Windows.Forms.TabPage tabPageStreams;
        private System.Windows.Forms.TabPage tabPageUtilities;
        private System.Windows.Forms.TabPage tabPageEconomics;
        private System.Windows.Forms.SplitContainer splitContainerProject;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBoxInputBanner;
        private System.Windows.Forms.TextBox textBoxPinchBanner;
        private System.Windows.Forms.TextBox textBoxHenBanner;
        private System.Windows.Forms.TreeView treeViewCatalogExplorer;
        private System.Windows.Forms.TreeView treeViewCurrentProjectExplorer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProjectCatalog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddProject;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImport;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProject;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRename;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCurrProj;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCurProjRename;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorCurProjAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCurProjClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorCurProjSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCurProjSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCurProjSaveAs;
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
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem licenseViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseScoreCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem userLicenseAgreementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutAJPHENStudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLICENSE;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCAT_DB;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPROJ_DB;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPROJ_NAME;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPROJ_UNITS;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAJP_LOGO;
    }
}

