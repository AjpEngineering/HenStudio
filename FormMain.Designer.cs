namespace Pinch
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
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
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specifyInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputProjectDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputStreamsDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exchangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.calculateTargetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compositeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.designHeatExchangerNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scorecardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLicense = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelUnits = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelInput = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTargets = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSELECTED_STATE = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageINPUT = new System.Windows.Forms.TabPage();
            this.tabPageTARGETS = new System.Windows.Forms.TabPage();
            this.tabPageHEN = new System.Windows.Forms.TabPage();
            this.imageListAnalysis = new System.Windows.Forms.ImageList(this.components);
            this.panelINPUT = new System.Windows.Forms.Panel();
            this.panelINPUT_PROJECT = new System.Windows.Forms.Panel();
            this.labelTitleInputProjectPanel = new System.Windows.Forms.Label();
            this.panelINPUT_VALIDATE = new System.Windows.Forms.Panel();
            this.labelTitleInputValidatePanel = new System.Windows.Forms.Label();
            this.panelINPUT_EXCHANGER = new System.Windows.Forms.Panel();
            this.labelTitleInputExchangerPanel = new System.Windows.Forms.Label();
            this.panelINPUT_COST = new System.Windows.Forms.Panel();
            this.labelTitleInputCostPanel = new System.Windows.Forms.Label();
            this.panelINPUT_UTILITIES = new System.Windows.Forms.Panel();
            this.labelTitleInputUtilitiesPanel = new System.Windows.Forms.Label();
            this.panelINPUT_STREAMS = new System.Windows.Forms.Panel();
            this.labelTitleInputStreamsPanel = new System.Windows.Forms.Label();
            this.tabControlINPUT = new System.Windows.Forms.TabControl();
            this.tabPageProject = new System.Windows.Forms.TabPage();
            this.tabPageStreams = new System.Windows.Forms.TabPage();
            this.tabPageUtilities = new System.Windows.Forms.TabPage();
            this.tabPageCost = new System.Windows.Forms.TabPage();
            this.tabPageExchanger = new System.Windows.Forms.TabPage();
            this.tabPageValidate = new System.Windows.Forms.TabPage();
            this.imageListInput = new System.Windows.Forms.ImageList(this.components);
            this.panelTARGETS = new System.Windows.Forms.Panel();
            this.panelTARGETS_OPTIMIZE = new System.Windows.Forms.Panel();
            this.labelTitleTargetsOptimizePanel = new System.Windows.Forms.Label();
            this.panelTARGETS_INTERVAL = new System.Windows.Forms.Panel();
            this.labelTitleTargetsIntervalPanel = new System.Windows.Forms.Label();
            this.panelTARGETS_COMPOSITE = new System.Windows.Forms.Panel();
            this.labelTitleTargetsCompositePanel = new System.Windows.Forms.Label();
            this.panelTARGETS_CALCULATE = new System.Windows.Forms.Panel();
            this.labelTitleTargetsCalculatePanel = new System.Windows.Forms.Label();
            this.tabControlTARGETS = new System.Windows.Forms.TabControl();
            this.tabPageCalculate = new System.Windows.Forms.TabPage();
            this.tabPageComposite = new System.Windows.Forms.TabPage();
            this.tabPageInterval = new System.Windows.Forms.TabPage();
            this.tabPageOptimize = new System.Windows.Forms.TabPage();
            this.imageListTargets = new System.Windows.Forms.ImageList(this.components);
            this.panelHEN = new System.Windows.Forms.Panel();
            this.panelHEN_DESIGN = new System.Windows.Forms.Panel();
            this.labelTitleHenDesignPanel = new System.Windows.Forms.Label();
            this.tabControlHEN = new System.Windows.Forms.TabControl();
            this.tabPageDesign = new System.Windows.Forms.TabPage();
            this.imageListHen = new System.Windows.Forms.ImageList(this.components);
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonImport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonProject = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStreams = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUtilities = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCost = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExchanger = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonValidate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCalculate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonComposite = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInterval = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOptimize = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonHenDesign = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLicense = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonScoreCard = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUserLicenseAgreement = new System.Windows.Forms.ToolStripButton();
            this.pictureBoxAJPLogo = new System.Windows.Forms.PictureBox();
            this.userLicenseAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.panelINPUT.SuspendLayout();
            this.panelINPUT_PROJECT.SuspendLayout();
            this.panelINPUT_VALIDATE.SuspendLayout();
            this.panelINPUT_EXCHANGER.SuspendLayout();
            this.panelINPUT_COST.SuspendLayout();
            this.panelINPUT_UTILITIES.SuspendLayout();
            this.panelINPUT_STREAMS.SuspendLayout();
            this.tabControlINPUT.SuspendLayout();
            this.panelTARGETS.SuspendLayout();
            this.panelTARGETS_OPTIMIZE.SuspendLayout();
            this.panelTARGETS_INTERVAL.SuspendLayout();
            this.panelTARGETS_COMPOSITE.SuspendLayout();
            this.panelTARGETS_CALCULATE.SuspendLayout();
            this.tabControlTARGETS.SuspendLayout();
            this.panelHEN.SuspendLayout();
            this.panelHEN_DESIGN.SuspendLayout();
            this.tabControlHEN.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAJPLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1264, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripPinch";
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
            this.newToolStripMenuItem.Image = global::Pinch.Properties.Resources.New_32x32;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.ToolTipText = "Create New Project File";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Pinch.Properties.Resources.Open_32x32;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.ToolTipText = "Open Existing Project File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Pinch.Properties.Resources.Save_32x32;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.ToolTipText = "Save Current Project File";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::Pinch.Properties.Resources.SaveAs_32x_32;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.ToolTipText = "Save Current Project File As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(130, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = global::Pinch.Properties.Resources.Import;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.importToolStripMenuItem.Text = "Import...";
            this.importToolStripMenuItem.ToolTipText = "Import Results File";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = global::Pinch.Properties.Resources.Export_32x32;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.exportToolStripMenuItem.Text = "Export...";
            this.exportToolStripMenuItem.ToolTipText = "Export Results File";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Pinch.Properties.Resources.Exit_32x32;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exit Application";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.specifyInputToolStripMenuItem,
            this.toolStripSeparator4,
            this.calculateTargetsToolStripMenuItem,
            this.toolStripSeparator3,
            this.designHeatExchangerNetworkToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.analysisToolStripMenuItem.Text = "Analysis";
            // 
            // specifyInputToolStripMenuItem
            // 
            this.specifyInputToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.specifyInputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputProjectDataToolStripMenuItem,
            this.inputStreamsDataToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.costToolStripMenuItem,
            this.exchangerToolStripMenuItem,
            this.validateToolStripMenuItem});
            this.specifyInputToolStripMenuItem.Image = global::Pinch.Properties.Resources.Input;
            this.specifyInputToolStripMenuItem.Name = "specifyInputToolStripMenuItem";
            this.specifyInputToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.specifyInputToolStripMenuItem.Text = "Specify Input...";
            this.specifyInputToolStripMenuItem.ToolTipText = "Specify Input Data";
            this.specifyInputToolStripMenuItem.Click += new System.EventHandler(this.specifyInputToolStripMenuItem_Click);
            // 
            // inputProjectDataToolStripMenuItem
            // 
            this.inputProjectDataToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputProjectDataToolStripMenuItem.Image = global::Pinch.Properties.Resources.Project_32x32;
            this.inputProjectDataToolStripMenuItem.Name = "inputProjectDataToolStripMenuItem";
            this.inputProjectDataToolStripMenuItem.Size = new System.Drawing.Size(139, 30);
            this.inputProjectDataToolStripMenuItem.Text = "Project";
            this.inputProjectDataToolStripMenuItem.ToolTipText = "Input Project Data";
            this.inputProjectDataToolStripMenuItem.Click += new System.EventHandler(this.inputProjectDataToolStripMenuItem_Click);
            // 
            // inputStreamsDataToolStripMenuItem
            // 
            this.inputStreamsDataToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.inputStreamsDataToolStripMenuItem.Image = global::Pinch.Properties.Resources.Streams_32x32;
            this.inputStreamsDataToolStripMenuItem.Name = "inputStreamsDataToolStripMenuItem";
            this.inputStreamsDataToolStripMenuItem.Size = new System.Drawing.Size(139, 30);
            this.inputStreamsDataToolStripMenuItem.Text = "Streams";
            this.inputStreamsDataToolStripMenuItem.ToolTipText = "Input Streams Data";
            this.inputStreamsDataToolStripMenuItem.Click += new System.EventHandler(this.inputStreamsDataToolStripMenuItem_Click);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.utilitiesToolStripMenuItem.Image = global::Pinch.Properties.Resources.Utilities_32x32;
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(139, 30);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            this.utilitiesToolStripMenuItem.ToolTipText = "Input Utilities Data";
            this.utilitiesToolStripMenuItem.Click += new System.EventHandler(this.utilitiesToolStripMenuItem_Click);
            // 
            // costToolStripMenuItem
            // 
            this.costToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.costToolStripMenuItem.Image = global::Pinch.Properties.Resources.Cost_32x32;
            this.costToolStripMenuItem.Name = "costToolStripMenuItem";
            this.costToolStripMenuItem.Size = new System.Drawing.Size(139, 30);
            this.costToolStripMenuItem.Text = "Cost";
            this.costToolStripMenuItem.ToolTipText = "Input Cost Data";
            this.costToolStripMenuItem.Click += new System.EventHandler(this.costToolStripMenuItem_Click);
            // 
            // exchangerToolStripMenuItem
            // 
            this.exchangerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exchangerToolStripMenuItem.Image = global::Pinch.Properties.Resources.Exchanger_32x32;
            this.exchangerToolStripMenuItem.Name = "exchangerToolStripMenuItem";
            this.exchangerToolStripMenuItem.Size = new System.Drawing.Size(139, 30);
            this.exchangerToolStripMenuItem.Text = "Exchanger";
            this.exchangerToolStripMenuItem.ToolTipText = "Input Exchanger Data";
            this.exchangerToolStripMenuItem.Click += new System.EventHandler(this.exchangerToolStripMenuItem_Click);
            // 
            // validateToolStripMenuItem
            // 
            this.validateToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.validateToolStripMenuItem.Image = global::Pinch.Properties.Resources.Validate_32x32;
            this.validateToolStripMenuItem.Name = "validateToolStripMenuItem";
            this.validateToolStripMenuItem.Size = new System.Drawing.Size(139, 30);
            this.validateToolStripMenuItem.Text = "Validate";
            this.validateToolStripMenuItem.ToolTipText = "Validate Input Data";
            this.validateToolStripMenuItem.Click += new System.EventHandler(this.validateToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(268, 6);
            // 
            // calculateTargetsToolStripMenuItem
            // 
            this.calculateTargetsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.calculateTargetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.compositeToolStripMenuItem,
            this.intervalToolStripMenuItem,
            this.optimizeToolStripMenuItem});
            this.calculateTargetsToolStripMenuItem.Image = global::Pinch.Properties.Resources.Target;
            this.calculateTargetsToolStripMenuItem.Name = "calculateTargetsToolStripMenuItem";
            this.calculateTargetsToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.calculateTargetsToolStripMenuItem.Text = "Calculate Targets...";
            this.calculateTargetsToolStripMenuItem.ToolTipText = "Calculate Targets and Artifacts";
            this.calculateTargetsToolStripMenuItem.Click += new System.EventHandler(this.calculateTargetsToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.calculateToolStripMenuItem.Image = global::Pinch.Properties.Resources.Calc_Gears_32x32;
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.ToolTipText = "Calculate Pinch Targets";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // compositeToolStripMenuItem
            // 
            this.compositeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.compositeToolStripMenuItem.Image = global::Pinch.Properties.Resources.Composite_32x32;
            this.compositeToolStripMenuItem.Name = "compositeToolStripMenuItem";
            this.compositeToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.compositeToolStripMenuItem.Text = "Composite";
            this.compositeToolStripMenuItem.ToolTipText = "Display Compoiste Curve Data";
            this.compositeToolStripMenuItem.Click += new System.EventHandler(this.compositeToolStripMenuItem_Click);
            // 
            // intervalToolStripMenuItem
            // 
            this.intervalToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.intervalToolStripMenuItem.Image = global::Pinch.Properties.Resources.Interval;
            this.intervalToolStripMenuItem.Name = "intervalToolStripMenuItem";
            this.intervalToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.intervalToolStripMenuItem.Text = "Interval";
            this.intervalToolStripMenuItem.ToolTipText = "Display Interval Data";
            this.intervalToolStripMenuItem.Click += new System.EventHandler(this.intervalToolStripMenuItem_Click);
            // 
            // optimizeToolStripMenuItem
            // 
            this.optimizeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.optimizeToolStripMenuItem.Image = global::Pinch.Properties.Resources.Optimize_32x32;
            this.optimizeToolStripMenuItem.Name = "optimizeToolStripMenuItem";
            this.optimizeToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.optimizeToolStripMenuItem.Text = "Optimize";
            this.optimizeToolStripMenuItem.ToolTipText = "Perform Optimization Analyses";
            this.optimizeToolStripMenuItem.Click += new System.EventHandler(this.optimizeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(268, 6);
            // 
            // designHeatExchangerNetworkToolStripMenuItem
            // 
            this.designHeatExchangerNetworkToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.designHeatExchangerNetworkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.designToolStripMenuItem});
            this.designHeatExchangerNetworkToolStripMenuItem.Image = global::Pinch.Properties.Resources.HEN;
            this.designHeatExchangerNetworkToolStripMenuItem.Name = "designHeatExchangerNetworkToolStripMenuItem";
            this.designHeatExchangerNetworkToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.designHeatExchangerNetworkToolStripMenuItem.Text = "Design Heat Exchanger Network...";
            this.designHeatExchangerNetworkToolStripMenuItem.ToolTipText = "Design HEN Options";
            this.designHeatExchangerNetworkToolStripMenuItem.Click += new System.EventHandler(this.designHeatExchangerNetworkToolStripMenuItem_Click);
            // 
            // designToolStripMenuItem
            // 
            this.designToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.designToolStripMenuItem.Image = global::Pinch.Properties.Resources.Design_32x32;
            this.designToolStripMenuItem.Name = "designToolStripMenuItem";
            this.designToolStripMenuItem.Size = new System.Drawing.Size(120, 30);
            this.designToolStripMenuItem.Text = "Design";
            this.designToolStripMenuItem.ToolTipText = "HEN Design";
            this.designToolStripMenuItem.Click += new System.EventHandler(this.designToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseToolStripMenuItem,
            this.scorecardToolStripMenuItem,
            this.toolStripSeparator6,
            this.userLicenseAgreementToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Image = global::Pinch.Properties.Resources.License_32x32;
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.licenseToolStripMenuItem.Text = "License...";
            this.licenseToolStripMenuItem.ToolTipText = "Launch License Viewer";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // scorecardToolStripMenuItem
            // 
            this.scorecardToolStripMenuItem.Image = global::Pinch.Properties.Resources.Scorecard_Check_32x32;
            this.scorecardToolStripMenuItem.Name = "scorecardToolStripMenuItem";
            this.scorecardToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.scorecardToolStripMenuItem.Text = "Scorecard...";
            this.scorecardToolStripMenuItem.ToolTipText = "Launch License ScoreCard Viewer";
            this.scorecardToolStripMenuItem.Click += new System.EventHandler(this.scorecardToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(216, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Pinch.Properties.Resources.About_32x32;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.ToolTipText = "Launch About Dialog";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLicense,
            this.toolStripStatusLabelUnits,
            this.toolStripStatusLabelInput,
            this.toolStripStatusLabelTargets,
            this.toolStripStatusLabelSELECTED_STATE});
            this.statusStripMain.Location = new System.Drawing.Point(0, 647);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1264, 34);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStripPinch";
            // 
            // toolStripStatusLabelLicense
            // 
            this.toolStripStatusLabelLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabelLicense.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelLicense.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelLicense.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelLicense.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelLicense.Image")));
            this.toolStripStatusLabelLicense.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelLicense.Name = "toolStripStatusLabelLicense";
            this.toolStripStatusLabelLicense.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.toolStripStatusLabelLicense.Size = new System.Drawing.Size(205, 28);
            this.toolStripStatusLabelLicense.Text = "UNKNOWN  LICENSE ";
            this.toolStripStatusLabelLicense.ToolTipText = "License Status";
            // 
            // toolStripStatusLabelUnits
            // 
            this.toolStripStatusLabelUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabelUnits.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelUnits.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelUnits.Image = global::Pinch.Properties.Resources.Unknown_32x32;
            this.toolStripStatusLabelUnits.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelUnits.Name = "toolStripStatusLabelUnits";
            this.toolStripStatusLabelUnits.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.toolStripStatusLabelUnits.Size = new System.Drawing.Size(182, 28);
            this.toolStripStatusLabelUnits.Text = "UNKNOWN UNITS ";
            // 
            // toolStripStatusLabelInput
            // 
            this.toolStripStatusLabelInput.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelInput.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelInput.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelInput.Image = global::Pinch.Properties.Resources.InValid_32x32;
            this.toolStripStatusLabelInput.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelInput.Name = "toolStripStatusLabelInput";
            this.toolStripStatusLabelInput.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.toolStripStatusLabelInput.Size = new System.Drawing.Size(214, 28);
            this.toolStripStatusLabelInput.Text = "INPUT NOT VALIDATED ";
            // 
            // toolStripStatusLabelTargets
            // 
            this.toolStripStatusLabelTargets.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelTargets.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelTargets.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelTargets.Image = global::Pinch.Properties.Resources.InValid_32x32;
            this.toolStripStatusLabelTargets.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelTargets.Name = "toolStripStatusLabelTargets";
            this.toolStripStatusLabelTargets.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.toolStripStatusLabelTargets.Size = new System.Drawing.Size(244, 28);
            this.toolStripStatusLabelTargets.Text = "TARGETS NOT CALCULATED";
            // 
            // toolStripStatusLabelSELECTED_STATE
            // 
            this.toolStripStatusLabelSELECTED_STATE.BackColor = System.Drawing.Color.OrangeRed;
            this.toolStripStatusLabelSELECTED_STATE.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelSELECTED_STATE.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelSELECTED_STATE.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelSELECTED_STATE.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelSELECTED_STATE.Image")));
            this.toolStripStatusLabelSELECTED_STATE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabelSELECTED_STATE.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelSELECTED_STATE.Name = "toolStripStatusLabelSELECTED_STATE";
            this.toolStripStatusLabelSELECTED_STATE.Size = new System.Drawing.Size(374, 28);
            this.toolStripStatusLabelSELECTED_STATE.Spring = true;
            this.toolStripStatusLabelSELECTED_STATE.Text = "ACTIVITY:SUBACTIVITY";
            this.toolStripStatusLabelSELECTED_STATE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabelSELECTED_STATE.ToolTipText = "Displayed View";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlMain.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlMain.Controls.Add(this.tabPageINPUT);
            this.tabControlMain.Controls.Add(this.tabPageTARGETS);
            this.tabControlMain.Controls.Add(this.tabPageHEN);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.ImageList = this.imageListAnalysis;
            this.tabControlMain.Location = new System.Drawing.Point(0, 603);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.Padding = new System.Drawing.Point(6, 4);
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.ShowToolTips = true;
            this.tabControlMain.Size = new System.Drawing.Size(1264, 44);
            this.tabControlMain.TabIndex = 2;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageINPUT
            // 
            this.tabPageINPUT.BackColor = System.Drawing.Color.PaleGreen;
            this.tabPageINPUT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageINPUT.ForeColor = System.Drawing.Color.OrangeRed;
            this.tabPageINPUT.ImageIndex = 0;
            this.tabPageINPUT.Location = new System.Drawing.Point(4, 4);
            this.tabPageINPUT.Name = "tabPageINPUT";
            this.tabPageINPUT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageINPUT.Size = new System.Drawing.Size(1256, 0);
            this.tabPageINPUT.TabIndex = 0;
            this.tabPageINPUT.Text = "INPUT";
            this.tabPageINPUT.ToolTipText = "Specify Pinch Input";
            this.tabPageINPUT.UseVisualStyleBackColor = true;
            // 
            // tabPageTARGETS
            // 
            this.tabPageTARGETS.ImageIndex = 1;
            this.tabPageTARGETS.Location = new System.Drawing.Point(4, 4);
            this.tabPageTARGETS.Name = "tabPageTARGETS";
            this.tabPageTARGETS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTARGETS.Size = new System.Drawing.Size(1256, 0);
            this.tabPageTARGETS.TabIndex = 1;
            this.tabPageTARGETS.Text = "TARGETS";
            this.tabPageTARGETS.ToolTipText = "Calculate Targets";
            this.tabPageTARGETS.UseVisualStyleBackColor = true;
            // 
            // tabPageHEN
            // 
            this.tabPageHEN.ImageIndex = 2;
            this.tabPageHEN.Location = new System.Drawing.Point(4, 4);
            this.tabPageHEN.Name = "tabPageHEN";
            this.tabPageHEN.Size = new System.Drawing.Size(1256, 0);
            this.tabPageHEN.TabIndex = 2;
            this.tabPageHEN.Text = "HEN";
            this.tabPageHEN.ToolTipText = "Design Heat Eachanger Network";
            this.tabPageHEN.UseVisualStyleBackColor = true;
            // 
            // imageListAnalysis
            // 
            this.imageListAnalysis.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAnalysis.ImageStream")));
            this.imageListAnalysis.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAnalysis.Images.SetKeyName(0, "Input.png");
            this.imageListAnalysis.Images.SetKeyName(1, "Target.png");
            this.imageListAnalysis.Images.SetKeyName(2, "HEN.png");
            // 
            // panelINPUT
            // 
            this.panelINPUT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelINPUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelINPUT.Controls.Add(this.panelINPUT_PROJECT);
            this.panelINPUT.Controls.Add(this.panelINPUT_VALIDATE);
            this.panelINPUT.Controls.Add(this.panelINPUT_EXCHANGER);
            this.panelINPUT.Controls.Add(this.panelINPUT_COST);
            this.panelINPUT.Controls.Add(this.panelINPUT_UTILITIES);
            this.panelINPUT.Controls.Add(this.panelINPUT_STREAMS);
            this.panelINPUT.Controls.Add(this.tabControlINPUT);
            this.panelINPUT.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelINPUT.Location = new System.Drawing.Point(0, 61);
            this.panelINPUT.Margin = new System.Windows.Forms.Padding(0);
            this.panelINPUT.Name = "panelINPUT";
            this.panelINPUT.Size = new System.Drawing.Size(1264, 543);
            this.panelINPUT.TabIndex = 3;
            this.panelINPUT.Visible = false;
            // 
            // panelINPUT_PROJECT
            // 
            this.panelINPUT_PROJECT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelINPUT_PROJECT.BackColor = System.Drawing.SystemColors.Window;
            this.panelINPUT_PROJECT.Controls.Add(this.labelTitleInputProjectPanel);
            this.panelINPUT_PROJECT.Location = new System.Drawing.Point(0, 40);
            this.panelINPUT_PROJECT.Name = "panelINPUT_PROJECT";
            this.panelINPUT_PROJECT.Size = new System.Drawing.Size(1264, 503);
            this.panelINPUT_PROJECT.TabIndex = 1;
            // 
            // labelTitleInputProjectPanel
            // 
            this.labelTitleInputProjectPanel.AutoSize = true;
            this.labelTitleInputProjectPanel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleInputProjectPanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTitleInputProjectPanel.Location = new System.Drawing.Point(414, 192);
            this.labelTitleInputProjectPanel.Name = "labelTitleInputProjectPanel";
            this.labelTitleInputProjectPanel.Size = new System.Drawing.Size(284, 36);
            this.labelTitleInputProjectPanel.TabIndex = 0;
            this.labelTitleInputProjectPanel.Text = "INPUT PROJECT DATA";
            this.labelTitleInputProjectPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelINPUT_VALIDATE
            // 
            this.panelINPUT_VALIDATE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelINPUT_VALIDATE.BackColor = System.Drawing.SystemColors.Window;
            this.panelINPUT_VALIDATE.Controls.Add(this.labelTitleInputValidatePanel);
            this.panelINPUT_VALIDATE.Location = new System.Drawing.Point(0, 40);
            this.panelINPUT_VALIDATE.Margin = new System.Windows.Forms.Padding(0);
            this.panelINPUT_VALIDATE.Name = "panelINPUT_VALIDATE";
            this.panelINPUT_VALIDATE.Size = new System.Drawing.Size(1264, 503);
            this.panelINPUT_VALIDATE.TabIndex = 6;
            // 
            // labelTitleInputValidatePanel
            // 
            this.labelTitleInputValidatePanel.AutoSize = true;
            this.labelTitleInputValidatePanel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleInputValidatePanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTitleInputValidatePanel.Location = new System.Drawing.Point(399, 192);
            this.labelTitleInputValidatePanel.Name = "labelTitleInputValidatePanel";
            this.labelTitleInputValidatePanel.Size = new System.Drawing.Size(287, 36);
            this.labelTitleInputValidatePanel.TabIndex = 0;
            this.labelTitleInputValidatePanel.Text = "INPUT VALIDATE DATA";
            // 
            // panelINPUT_EXCHANGER
            // 
            this.panelINPUT_EXCHANGER.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelINPUT_EXCHANGER.BackColor = System.Drawing.SystemColors.Window;
            this.panelINPUT_EXCHANGER.Controls.Add(this.labelTitleInputExchangerPanel);
            this.panelINPUT_EXCHANGER.Location = new System.Drawing.Point(0, 40);
            this.panelINPUT_EXCHANGER.Margin = new System.Windows.Forms.Padding(0);
            this.panelINPUT_EXCHANGER.Name = "panelINPUT_EXCHANGER";
            this.panelINPUT_EXCHANGER.Size = new System.Drawing.Size(1264, 503);
            this.panelINPUT_EXCHANGER.TabIndex = 5;
            // 
            // labelTitleInputExchangerPanel
            // 
            this.labelTitleInputExchangerPanel.AutoSize = true;
            this.labelTitleInputExchangerPanel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleInputExchangerPanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTitleInputExchangerPanel.Location = new System.Drawing.Point(414, 192);
            this.labelTitleInputExchangerPanel.Name = "labelTitleInputExchangerPanel";
            this.labelTitleInputExchangerPanel.Size = new System.Drawing.Size(328, 36);
            this.labelTitleInputExchangerPanel.TabIndex = 0;
            this.labelTitleInputExchangerPanel.Text = "INPUT EXCHANGER DATA";
            // 
            // panelINPUT_COST
            // 
            this.panelINPUT_COST.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelINPUT_COST.BackColor = System.Drawing.SystemColors.Window;
            this.panelINPUT_COST.Controls.Add(this.labelTitleInputCostPanel);
            this.panelINPUT_COST.Location = new System.Drawing.Point(0, 40);
            this.panelINPUT_COST.Margin = new System.Windows.Forms.Padding(0);
            this.panelINPUT_COST.Name = "panelINPUT_COST";
            this.panelINPUT_COST.Size = new System.Drawing.Size(1264, 503);
            this.panelINPUT_COST.TabIndex = 4;
            // 
            // labelTitleInputCostPanel
            // 
            this.labelTitleInputCostPanel.AutoSize = true;
            this.labelTitleInputCostPanel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleInputCostPanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTitleInputCostPanel.Location = new System.Drawing.Point(433, 192);
            this.labelTitleInputCostPanel.Name = "labelTitleInputCostPanel";
            this.labelTitleInputCostPanel.Size = new System.Drawing.Size(239, 36);
            this.labelTitleInputCostPanel.TabIndex = 0;
            this.labelTitleInputCostPanel.Text = "INPUT COST DATA";
            // 
            // panelINPUT_UTILITIES
            // 
            this.panelINPUT_UTILITIES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelINPUT_UTILITIES.BackColor = System.Drawing.SystemColors.Window;
            this.panelINPUT_UTILITIES.Controls.Add(this.labelTitleInputUtilitiesPanel);
            this.panelINPUT_UTILITIES.Location = new System.Drawing.Point(0, 40);
            this.panelINPUT_UTILITIES.Margin = new System.Windows.Forms.Padding(0);
            this.panelINPUT_UTILITIES.Name = "panelINPUT_UTILITIES";
            this.panelINPUT_UTILITIES.Size = new System.Drawing.Size(1264, 503);
            this.panelINPUT_UTILITIES.TabIndex = 3;
            // 
            // labelTitleInputUtilitiesPanel
            // 
            this.labelTitleInputUtilitiesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitleInputUtilitiesPanel.AutoSize = true;
            this.labelTitleInputUtilitiesPanel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleInputUtilitiesPanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTitleInputUtilitiesPanel.Location = new System.Drawing.Point(454, 210);
            this.labelTitleInputUtilitiesPanel.Name = "labelTitleInputUtilitiesPanel";
            this.labelTitleInputUtilitiesPanel.Size = new System.Drawing.Size(286, 36);
            this.labelTitleInputUtilitiesPanel.TabIndex = 0;
            this.labelTitleInputUtilitiesPanel.Text = "INPUT UTILITIES DATA";
            // 
            // panelINPUT_STREAMS
            // 
            this.panelINPUT_STREAMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelINPUT_STREAMS.BackColor = System.Drawing.SystemColors.Window;
            this.panelINPUT_STREAMS.Controls.Add(this.labelTitleInputStreamsPanel);
            this.panelINPUT_STREAMS.Location = new System.Drawing.Point(0, 40);
            this.panelINPUT_STREAMS.Margin = new System.Windows.Forms.Padding(0);
            this.panelINPUT_STREAMS.Name = "panelINPUT_STREAMS";
            this.panelINPUT_STREAMS.Size = new System.Drawing.Size(1264, 503);
            this.panelINPUT_STREAMS.TabIndex = 2;
            // 
            // labelTitleInputStreamsPanel
            // 
            this.labelTitleInputStreamsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitleInputStreamsPanel.AutoSize = true;
            this.labelTitleInputStreamsPanel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleInputStreamsPanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTitleInputStreamsPanel.Location = new System.Drawing.Point(464, 192);
            this.labelTitleInputStreamsPanel.Name = "labelTitleInputStreamsPanel";
            this.labelTitleInputStreamsPanel.Size = new System.Drawing.Size(291, 36);
            this.labelTitleInputStreamsPanel.TabIndex = 0;
            this.labelTitleInputStreamsPanel.Text = "INPUT STREAMS DATA";
            this.labelTitleInputStreamsPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlINPUT
            // 
            this.tabControlINPUT.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlINPUT.Controls.Add(this.tabPageProject);
            this.tabControlINPUT.Controls.Add(this.tabPageStreams);
            this.tabControlINPUT.Controls.Add(this.tabPageUtilities);
            this.tabControlINPUT.Controls.Add(this.tabPageCost);
            this.tabControlINPUT.Controls.Add(this.tabPageExchanger);
            this.tabControlINPUT.Controls.Add(this.tabPageValidate);
            this.tabControlINPUT.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlINPUT.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlINPUT.ImageList = this.imageListInput;
            this.tabControlINPUT.ItemSize = new System.Drawing.Size(84, 38);
            this.tabControlINPUT.Location = new System.Drawing.Point(0, 0);
            this.tabControlINPUT.Multiline = true;
            this.tabControlINPUT.Name = "tabControlINPUT";
            this.tabControlINPUT.SelectedIndex = 0;
            this.tabControlINPUT.ShowToolTips = true;
            this.tabControlINPUT.Size = new System.Drawing.Size(1264, 40);
            this.tabControlINPUT.TabIndex = 0;
            this.tabControlINPUT.SelectedIndexChanged += new System.EventHandler(this.tabControlINPUT_SelectedIndexChanged);
            // 
            // tabPageProject
            // 
            this.tabPageProject.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageProject.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageProject.ImageIndex = 0;
            this.tabPageProject.Location = new System.Drawing.Point(4, 42);
            this.tabPageProject.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageProject.Name = "tabPageProject";
            this.tabPageProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProject.Size = new System.Drawing.Size(1256, 0);
            this.tabPageProject.TabIndex = 0;
            this.tabPageProject.Text = "PROJECT";
            this.tabPageProject.ToolTipText = "Input Project Data";
            // 
            // tabPageStreams
            // 
            this.tabPageStreams.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageStreams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageStreams.ImageIndex = 1;
            this.tabPageStreams.Location = new System.Drawing.Point(4, 42);
            this.tabPageStreams.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageStreams.Name = "tabPageStreams";
            this.tabPageStreams.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStreams.Size = new System.Drawing.Size(1256, 0);
            this.tabPageStreams.TabIndex = 1;
            this.tabPageStreams.Text = "STREAMS";
            this.tabPageStreams.ToolTipText = "Input Streams Data";
            // 
            // tabPageUtilities
            // 
            this.tabPageUtilities.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageUtilities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageUtilities.ImageIndex = 2;
            this.tabPageUtilities.Location = new System.Drawing.Point(4, 42);
            this.tabPageUtilities.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageUtilities.Name = "tabPageUtilities";
            this.tabPageUtilities.Size = new System.Drawing.Size(1256, 0);
            this.tabPageUtilities.TabIndex = 2;
            this.tabPageUtilities.Text = "UTILITIES";
            this.tabPageUtilities.ToolTipText = "Input Utilities Data";
            // 
            // tabPageCost
            // 
            this.tabPageCost.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageCost.ImageIndex = 3;
            this.tabPageCost.Location = new System.Drawing.Point(4, 42);
            this.tabPageCost.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageCost.Name = "tabPageCost";
            this.tabPageCost.Size = new System.Drawing.Size(1256, 0);
            this.tabPageCost.TabIndex = 3;
            this.tabPageCost.Text = "COST";
            this.tabPageCost.ToolTipText = "Input Cost Data";
            // 
            // tabPageExchanger
            // 
            this.tabPageExchanger.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageExchanger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageExchanger.ImageIndex = 4;
            this.tabPageExchanger.Location = new System.Drawing.Point(4, 42);
            this.tabPageExchanger.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageExchanger.Name = "tabPageExchanger";
            this.tabPageExchanger.Size = new System.Drawing.Size(1256, 0);
            this.tabPageExchanger.TabIndex = 4;
            this.tabPageExchanger.Text = "EXCHANGER";
            this.tabPageExchanger.ToolTipText = "Input Exchanger Data";
            // 
            // tabPageValidate
            // 
            this.tabPageValidate.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageValidate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageValidate.ImageIndex = 5;
            this.tabPageValidate.Location = new System.Drawing.Point(4, 42);
            this.tabPageValidate.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageValidate.Name = "tabPageValidate";
            this.tabPageValidate.Size = new System.Drawing.Size(1256, 0);
            this.tabPageValidate.TabIndex = 5;
            this.tabPageValidate.Text = "VALIDATE";
            this.tabPageValidate.ToolTipText = "Validate Input";
            // 
            // imageListInput
            // 
            this.imageListInput.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListInput.ImageStream")));
            this.imageListInput.TransparentColor = System.Drawing.Color.Crimson;
            this.imageListInput.Images.SetKeyName(0, "Project...32x32.png");
            this.imageListInput.Images.SetKeyName(1, "Streams...32x32.png");
            this.imageListInput.Images.SetKeyName(2, "Utilities Image...32x32.png");
            this.imageListInput.Images.SetKeyName(3, "Cost...32x32.png");
            this.imageListInput.Images.SetKeyName(4, "Exchanger3...32x32.png");
            this.imageListInput.Images.SetKeyName(5, "Validate...32x32.png");
            // 
            // panelTARGETS
            // 
            this.panelTARGETS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTARGETS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelTARGETS.Controls.Add(this.panelTARGETS_OPTIMIZE);
            this.panelTARGETS.Controls.Add(this.panelTARGETS_INTERVAL);
            this.panelTARGETS.Controls.Add(this.panelTARGETS_COMPOSITE);
            this.panelTARGETS.Controls.Add(this.panelTARGETS_CALCULATE);
            this.panelTARGETS.Controls.Add(this.tabControlTARGETS);
            this.panelTARGETS.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTARGETS.Location = new System.Drawing.Point(0, 61);
            this.panelTARGETS.Margin = new System.Windows.Forms.Padding(0);
            this.panelTARGETS.Name = "panelTARGETS";
            this.panelTARGETS.Size = new System.Drawing.Size(1264, 543);
            this.panelTARGETS.TabIndex = 4;
            this.panelTARGETS.Visible = false;
            // 
            // panelTARGETS_OPTIMIZE
            // 
            this.panelTARGETS_OPTIMIZE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTARGETS_OPTIMIZE.BackColor = System.Drawing.SystemColors.Window;
            this.panelTARGETS_OPTIMIZE.Controls.Add(this.labelTitleTargetsOptimizePanel);
            this.panelTARGETS_OPTIMIZE.Location = new System.Drawing.Point(0, 40);
            this.panelTARGETS_OPTIMIZE.Margin = new System.Windows.Forms.Padding(0);
            this.panelTARGETS_OPTIMIZE.Name = "panelTARGETS_OPTIMIZE";
            this.panelTARGETS_OPTIMIZE.Size = new System.Drawing.Size(1264, 503);
            this.panelTARGETS_OPTIMIZE.TabIndex = 9;
            // 
            // labelTitleTargetsOptimizePanel
            // 
            this.labelTitleTargetsOptimizePanel.AutoSize = true;
            this.labelTitleTargetsOptimizePanel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleTargetsOptimizePanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTitleTargetsOptimizePanel.Location = new System.Drawing.Point(445, 209);
            this.labelTitleTargetsOptimizePanel.Name = "labelTitleTargetsOptimizePanel";
            this.labelTitleTargetsOptimizePanel.Size = new System.Drawing.Size(253, 36);
            this.labelTitleTargetsOptimizePanel.TabIndex = 0;
            this.labelTitleTargetsOptimizePanel.Text = "TARGETS OPTIMIZE";
            // 
            // panelTARGETS_INTERVAL
            // 
            this.panelTARGETS_INTERVAL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTARGETS_INTERVAL.BackColor = System.Drawing.SystemColors.Window;
            this.panelTARGETS_INTERVAL.Controls.Add(this.labelTitleTargetsIntervalPanel);
            this.panelTARGETS_INTERVAL.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTARGETS_INTERVAL.ForeColor = System.Drawing.Color.SaddleBrown;
            this.panelTARGETS_INTERVAL.Location = new System.Drawing.Point(0, 40);
            this.panelTARGETS_INTERVAL.Margin = new System.Windows.Forms.Padding(0);
            this.panelTARGETS_INTERVAL.Name = "panelTARGETS_INTERVAL";
            this.panelTARGETS_INTERVAL.Size = new System.Drawing.Size(1264, 503);
            this.panelTARGETS_INTERVAL.TabIndex = 8;
            // 
            // labelTitleTargetsIntervalPanel
            // 
            this.labelTitleTargetsIntervalPanel.AutoSize = true;
            this.labelTitleTargetsIntervalPanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTitleTargetsIntervalPanel.Location = new System.Drawing.Point(446, 192);
            this.labelTitleTargetsIntervalPanel.Name = "labelTitleTargetsIntervalPanel";
            this.labelTitleTargetsIntervalPanel.Size = new System.Drawing.Size(252, 36);
            this.labelTitleTargetsIntervalPanel.TabIndex = 0;
            this.labelTitleTargetsIntervalPanel.Text = "TARGETS INTERVAL";
            // 
            // panelTARGETS_COMPOSITE
            // 
            this.panelTARGETS_COMPOSITE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTARGETS_COMPOSITE.BackColor = System.Drawing.SystemColors.Window;
            this.panelTARGETS_COMPOSITE.Controls.Add(this.labelTitleTargetsCompositePanel);
            this.panelTARGETS_COMPOSITE.Location = new System.Drawing.Point(0, 40);
            this.panelTARGETS_COMPOSITE.Margin = new System.Windows.Forms.Padding(0);
            this.panelTARGETS_COMPOSITE.Name = "panelTARGETS_COMPOSITE";
            this.panelTARGETS_COMPOSITE.Size = new System.Drawing.Size(1264, 503);
            this.panelTARGETS_COMPOSITE.TabIndex = 7;
            // 
            // labelTitleTargetsCompositePanel
            // 
            this.labelTitleTargetsCompositePanel.AutoSize = true;
            this.labelTitleTargetsCompositePanel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleTargetsCompositePanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTitleTargetsCompositePanel.Location = new System.Drawing.Point(454, 210);
            this.labelTitleTargetsCompositePanel.Name = "labelTitleTargetsCompositePanel";
            this.labelTitleTargetsCompositePanel.Size = new System.Drawing.Size(284, 36);
            this.labelTitleTargetsCompositePanel.TabIndex = 0;
            this.labelTitleTargetsCompositePanel.Text = "TARGETS COMPOSITE";
            // 
            // panelTARGETS_CALCULATE
            // 
            this.panelTARGETS_CALCULATE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTARGETS_CALCULATE.BackColor = System.Drawing.SystemColors.Window;
            this.panelTARGETS_CALCULATE.Controls.Add(this.labelTitleTargetsCalculatePanel);
            this.panelTARGETS_CALCULATE.Location = new System.Drawing.Point(0, 40);
            this.panelTARGETS_CALCULATE.Margin = new System.Windows.Forms.Padding(0);
            this.panelTARGETS_CALCULATE.Name = "panelTARGETS_CALCULATE";
            this.panelTARGETS_CALCULATE.Size = new System.Drawing.Size(1264, 503);
            this.panelTARGETS_CALCULATE.TabIndex = 6;
            // 
            // labelTitleTargetsCalculatePanel
            // 
            this.labelTitleTargetsCalculatePanel.AutoSize = true;
            this.labelTitleTargetsCalculatePanel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleTargetsCalculatePanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTitleTargetsCalculatePanel.Location = new System.Drawing.Point(420, 209);
            this.labelTitleTargetsCalculatePanel.Name = "labelTitleTargetsCalculatePanel";
            this.labelTitleTargetsCalculatePanel.Size = new System.Drawing.Size(278, 36);
            this.labelTitleTargetsCalculatePanel.TabIndex = 0;
            this.labelTitleTargetsCalculatePanel.Text = "TARGETS CALCULATE";
            // 
            // tabControlTARGETS
            // 
            this.tabControlTARGETS.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlTARGETS.Controls.Add(this.tabPageCalculate);
            this.tabControlTARGETS.Controls.Add(this.tabPageComposite);
            this.tabControlTARGETS.Controls.Add(this.tabPageInterval);
            this.tabControlTARGETS.Controls.Add(this.tabPageOptimize);
            this.tabControlTARGETS.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlTARGETS.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlTARGETS.ImageList = this.imageListTargets;
            this.tabControlTARGETS.ItemSize = new System.Drawing.Size(78, 38);
            this.tabControlTARGETS.Location = new System.Drawing.Point(0, 0);
            this.tabControlTARGETS.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlTARGETS.Multiline = true;
            this.tabControlTARGETS.Name = "tabControlTARGETS";
            this.tabControlTARGETS.SelectedIndex = 0;
            this.tabControlTARGETS.Size = new System.Drawing.Size(1264, 40);
            this.tabControlTARGETS.TabIndex = 0;
            this.tabControlTARGETS.SelectedIndexChanged += new System.EventHandler(this.tabControlTARGETS_SelectedIndexChanged);
            // 
            // tabPageCalculate
            // 
            this.tabPageCalculate.ImageIndex = 0;
            this.tabPageCalculate.Location = new System.Drawing.Point(4, 42);
            this.tabPageCalculate.Name = "tabPageCalculate";
            this.tabPageCalculate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalculate.Size = new System.Drawing.Size(1256, 0);
            this.tabPageCalculate.TabIndex = 0;
            this.tabPageCalculate.Text = "CALCULATE";
            this.tabPageCalculate.ToolTipText = "Calculate Pinch Targets";
            this.tabPageCalculate.UseVisualStyleBackColor = true;
            // 
            // tabPageComposite
            // 
            this.tabPageComposite.ImageIndex = 1;
            this.tabPageComposite.Location = new System.Drawing.Point(4, 42);
            this.tabPageComposite.Name = "tabPageComposite";
            this.tabPageComposite.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageComposite.Size = new System.Drawing.Size(1256, 0);
            this.tabPageComposite.TabIndex = 1;
            this.tabPageComposite.Text = "COMPOSITE";
            this.tabPageComposite.ToolTipText = "Display Composite Curves";
            this.tabPageComposite.UseVisualStyleBackColor = true;
            // 
            // tabPageInterval
            // 
            this.tabPageInterval.ImageIndex = 2;
            this.tabPageInterval.Location = new System.Drawing.Point(4, 42);
            this.tabPageInterval.Name = "tabPageInterval";
            this.tabPageInterval.Size = new System.Drawing.Size(1256, 0);
            this.tabPageInterval.TabIndex = 2;
            this.tabPageInterval.Text = "INTERVAL";
            this.tabPageInterval.ToolTipText = "Display Interval Table";
            this.tabPageInterval.UseVisualStyleBackColor = true;
            // 
            // tabPageOptimize
            // 
            this.tabPageOptimize.ImageIndex = 3;
            this.tabPageOptimize.Location = new System.Drawing.Point(4, 42);
            this.tabPageOptimize.Name = "tabPageOptimize";
            this.tabPageOptimize.Size = new System.Drawing.Size(1256, 0);
            this.tabPageOptimize.TabIndex = 3;
            this.tabPageOptimize.Text = "OPTIMIZE";
            this.tabPageOptimize.ToolTipText = "Perform Optimization Analyses";
            this.tabPageOptimize.UseVisualStyleBackColor = true;
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
            // panelHEN
            // 
            this.panelHEN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelHEN.Controls.Add(this.panelHEN_DESIGN);
            this.panelHEN.Controls.Add(this.tabControlHEN);
            this.panelHEN.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHEN.Location = new System.Drawing.Point(0, 61);
            this.panelHEN.Margin = new System.Windows.Forms.Padding(0);
            this.panelHEN.Name = "panelHEN";
            this.panelHEN.Size = new System.Drawing.Size(1264, 543);
            this.panelHEN.TabIndex = 5;
            // 
            // panelHEN_DESIGN
            // 
            this.panelHEN_DESIGN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHEN_DESIGN.BackColor = System.Drawing.SystemColors.Window;
            this.panelHEN_DESIGN.Controls.Add(this.labelTitleHenDesignPanel);
            this.panelHEN_DESIGN.Location = new System.Drawing.Point(0, 40);
            this.panelHEN_DESIGN.Margin = new System.Windows.Forms.Padding(0);
            this.panelHEN_DESIGN.Name = "panelHEN_DESIGN";
            this.panelHEN_DESIGN.Size = new System.Drawing.Size(1264, 503);
            this.panelHEN_DESIGN.TabIndex = 1;
            // 
            // labelTitleHenDesignPanel
            // 
            this.labelTitleHenDesignPanel.AutoSize = true;
            this.labelTitleHenDesignPanel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleHenDesignPanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTitleHenDesignPanel.Location = new System.Drawing.Point(527, 228);
            this.labelTitleHenDesignPanel.Name = "labelTitleHenDesignPanel";
            this.labelTitleHenDesignPanel.Size = new System.Drawing.Size(171, 36);
            this.labelTitleHenDesignPanel.TabIndex = 0;
            this.labelTitleHenDesignPanel.Text = "HEN DESIGN";
            // 
            // tabControlHEN
            // 
            this.tabControlHEN.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlHEN.Controls.Add(this.tabPageDesign);
            this.tabControlHEN.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlHEN.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlHEN.ImageList = this.imageListHen;
            this.tabControlHEN.ItemSize = new System.Drawing.Size(55, 38);
            this.tabControlHEN.Location = new System.Drawing.Point(0, 0);
            this.tabControlHEN.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlHEN.Multiline = true;
            this.tabControlHEN.Name = "tabControlHEN";
            this.tabControlHEN.SelectedIndex = 0;
            this.tabControlHEN.Size = new System.Drawing.Size(1264, 40);
            this.tabControlHEN.TabIndex = 0;
            this.tabControlHEN.SelectedIndexChanged += new System.EventHandler(this.tabControlHEN_SelectedIndexChanged);
            // 
            // tabPageDesign
            // 
            this.tabPageDesign.ImageIndex = 0;
            this.tabPageDesign.Location = new System.Drawing.Point(4, 42);
            this.tabPageDesign.Name = "tabPageDesign";
            this.tabPageDesign.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDesign.Size = new System.Drawing.Size(1256, 0);
            this.tabPageDesign.TabIndex = 0;
            this.tabPageDesign.Text = "DESIGN";
            this.tabPageDesign.ToolTipText = "Design Heat Exchanger Network Options";
            this.tabPageDesign.UseVisualStyleBackColor = true;
            // 
            // imageListHen
            // 
            this.imageListHen.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListHen.ImageStream")));
            this.imageListHen.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListHen.Images.SetKeyName(0, "Design...32x32.png");
            // 
            // toolStripMain
            // 
            this.toolStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripSeparator7,
            this.toolStripButtonSave,
            this.toolStripButtonSaveAs,
            this.toolStripSeparator8,
            this.toolStripButtonImport,
            this.toolStripButtonExport,
            this.toolStripSeparator9,
            this.toolStripButtonProject,
            this.toolStripButtonStreams,
            this.toolStripButtonUtilities,
            this.toolStripButtonCost,
            this.toolStripButtonExchanger,
            this.toolStripButtonValidate,
            this.toolStripSeparator10,
            this.toolStripButtonCalculate,
            this.toolStripButtonComposite,
            this.toolStripButtonInterval,
            this.toolStripButtonOptimize,
            this.toolStripSeparator11,
            this.toolStripButtonHenDesign,
            this.toolStripSeparator12,
            this.toolStripButtonLicense,
            this.toolStripButtonScoreCard,
            this.toolStripButtonUserLicenseAgreement,
            this.toolStripButtonAbout});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripMain.Size = new System.Drawing.Size(1264, 37);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "Main Toolbar";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonNew.Image = global::Pinch.Properties.Resources.New_32x32;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonNew.Text = "toolStripButton1";
            this.toolStripButtonNew.ToolTipText = "Create New Project File";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonOpen.Image = global::Pinch.Properties.Resources.Open_32x32;
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonOpen.Text = "toolStripButton1";
            this.toolStripButtonOpen.ToolTipText = "Open Existing Project File";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::Pinch.Properties.Resources.Save_32x32;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.ToolTipText = "Save Current Project File";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonSaveAs
            // 
            this.toolStripButtonSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveAs.Image = global::Pinch.Properties.Resources.SaveAs_32x_32;
            this.toolStripButtonSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveAs.Name = "toolStripButtonSaveAs";
            this.toolStripButtonSaveAs.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonSaveAs.Text = "Save As";
            this.toolStripButtonSaveAs.ToolTipText = "Save Current Project File As";
            this.toolStripButtonSaveAs.Click += new System.EventHandler(this.toolStripButtonSaveAs_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonImport
            // 
            this.toolStripButtonImport.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonImport.Image = global::Pinch.Properties.Resources.Import;
            this.toolStripButtonImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImport.Name = "toolStripButtonImport";
            this.toolStripButtonImport.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonImport.Text = "toolStripButton1";
            this.toolStripButtonImport.ToolTipText = "Import Results File";
            this.toolStripButtonImport.Click += new System.EventHandler(this.toolStripButtonImport_Click);
            // 
            // toolStripButtonExport
            // 
            this.toolStripButtonExport.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExport.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonExport.Image = global::Pinch.Properties.Resources.Export_32x32;
            this.toolStripButtonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExport.Name = "toolStripButtonExport";
            this.toolStripButtonExport.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonExport.Text = "toolStripButton1";
            this.toolStripButtonExport.ToolTipText = "Export Results File";
            this.toolStripButtonExport.Click += new System.EventHandler(this.toolStripButtonExport_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonProject
            // 
            this.toolStripButtonProject.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonProject.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonProject.Image = global::Pinch.Properties.Resources.Project_32x32;
            this.toolStripButtonProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProject.Name = "toolStripButtonProject";
            this.toolStripButtonProject.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonProject.Text = "toolStripButton1";
            this.toolStripButtonProject.ToolTipText = "Input Project Data";
            this.toolStripButtonProject.Click += new System.EventHandler(this.toolStripButtonProject_Click);
            // 
            // toolStripButtonStreams
            // 
            this.toolStripButtonStreams.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonStreams.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStreams.Image = global::Pinch.Properties.Resources.Streams_32x32;
            this.toolStripButtonStreams.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStreams.Name = "toolStripButtonStreams";
            this.toolStripButtonStreams.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonStreams.Text = "toolStripButton1";
            this.toolStripButtonStreams.ToolTipText = "Input Streams Data";
            this.toolStripButtonStreams.Click += new System.EventHandler(this.toolStripButtonStreams_Click);
            // 
            // toolStripButtonUtilities
            // 
            this.toolStripButtonUtilities.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonUtilities.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUtilities.Image = global::Pinch.Properties.Resources.Utilities_32x32;
            this.toolStripButtonUtilities.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUtilities.Name = "toolStripButtonUtilities";
            this.toolStripButtonUtilities.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonUtilities.Text = "toolStripButton1";
            this.toolStripButtonUtilities.ToolTipText = "Input Utilities Data";
            this.toolStripButtonUtilities.Click += new System.EventHandler(this.toolStripButtonUtilities_Click);
            // 
            // toolStripButtonCost
            // 
            this.toolStripButtonCost.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonCost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCost.Image = global::Pinch.Properties.Resources.Cost_32x32;
            this.toolStripButtonCost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCost.Name = "toolStripButtonCost";
            this.toolStripButtonCost.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonCost.Text = "toolStripButton1";
            this.toolStripButtonCost.ToolTipText = "Input Cost Data";
            this.toolStripButtonCost.Click += new System.EventHandler(this.toolStripButtonCost_Click);
            // 
            // toolStripButtonExchanger
            // 
            this.toolStripButtonExchanger.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonExchanger.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExchanger.Image = global::Pinch.Properties.Resources.Exchanger_32x32;
            this.toolStripButtonExchanger.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExchanger.Name = "toolStripButtonExchanger";
            this.toolStripButtonExchanger.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonExchanger.Text = "toolStripButton1";
            this.toolStripButtonExchanger.ToolTipText = "Input Exchanger Data";
            this.toolStripButtonExchanger.Click += new System.EventHandler(this.toolStripButtonExchanger_Click);
            // 
            // toolStripButtonValidate
            // 
            this.toolStripButtonValidate.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonValidate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonValidate.Image = global::Pinch.Properties.Resources.Validate_32x32;
            this.toolStripButtonValidate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonValidate.Name = "toolStripButtonValidate";
            this.toolStripButtonValidate.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonValidate.Text = "toolStripButton1";
            this.toolStripButtonValidate.ToolTipText = "Validate Input Data";
            this.toolStripButtonValidate.Click += new System.EventHandler(this.toolStripButtonValidate_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonCalculate
            // 
            this.toolStripButtonCalculate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCalculate.Image = global::Pinch.Properties.Resources.Calc_Gears_32x32;
            this.toolStripButtonCalculate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCalculate.Name = "toolStripButtonCalculate";
            this.toolStripButtonCalculate.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonCalculate.Text = "toolStripButton1";
            this.toolStripButtonCalculate.ToolTipText = "Calculate Pinch Targets";
            this.toolStripButtonCalculate.Click += new System.EventHandler(this.toolStripButtonCalculate_Click);
            // 
            // toolStripButtonComposite
            // 
            this.toolStripButtonComposite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonComposite.Image = global::Pinch.Properties.Resources.Composite_32x32;
            this.toolStripButtonComposite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonComposite.Name = "toolStripButtonComposite";
            this.toolStripButtonComposite.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonComposite.Text = "toolStripButton1";
            this.toolStripButtonComposite.ToolTipText = "Display Composite Results";
            this.toolStripButtonComposite.Click += new System.EventHandler(this.toolStripButtonComposite_Click);
            // 
            // toolStripButtonInterval
            // 
            this.toolStripButtonInterval.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInterval.Image = global::Pinch.Properties.Resources.Interval;
            this.toolStripButtonInterval.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInterval.Name = "toolStripButtonInterval";
            this.toolStripButtonInterval.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonInterval.Text = "toolStripButton1";
            this.toolStripButtonInterval.ToolTipText = "Display Interval Results";
            this.toolStripButtonInterval.Click += new System.EventHandler(this.toolStripButtonInterval_Click);
            // 
            // toolStripButtonOptimize
            // 
            this.toolStripButtonOptimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOptimize.Image = global::Pinch.Properties.Resources.Optimize_32x32;
            this.toolStripButtonOptimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOptimize.Name = "toolStripButtonOptimize";
            this.toolStripButtonOptimize.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonOptimize.Text = "toolStripButton1";
            this.toolStripButtonOptimize.ToolTipText = "Display Optimization Results";
            this.toolStripButtonOptimize.Click += new System.EventHandler(this.toolStripButtonOptimize_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonHenDesign
            // 
            this.toolStripButtonHenDesign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHenDesign.Image = global::Pinch.Properties.Resources.Design_32x32;
            this.toolStripButtonHenDesign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHenDesign.Name = "toolStripButtonHenDesign";
            this.toolStripButtonHenDesign.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonHenDesign.Text = "toolStripButton1";
            this.toolStripButtonHenDesign.ToolTipText = "Design Heat Exchanger Networks";
            this.toolStripButtonHenDesign.Click += new System.EventHandler(this.toolStripButtonHenDesign_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonLicense
            // 
            this.toolStripButtonLicense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLicense.Image = global::Pinch.Properties.Resources.License_32x32;
            this.toolStripButtonLicense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLicense.Name = "toolStripButtonLicense";
            this.toolStripButtonLicense.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonLicense.Text = "toolStripButton1";
            this.toolStripButtonLicense.ToolTipText = "Display License Data";
            this.toolStripButtonLicense.Click += new System.EventHandler(this.toolStripButtonLicense_Click);
            // 
            // toolStripButtonScoreCard
            // 
            this.toolStripButtonScoreCard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonScoreCard.Image = global::Pinch.Properties.Resources.Scorecard_Check_32x32;
            this.toolStripButtonScoreCard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonScoreCard.Name = "toolStripButtonScoreCard";
            this.toolStripButtonScoreCard.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonScoreCard.ToolTipText = "Display License ScoreCard";
            this.toolStripButtonScoreCard.Click += new System.EventHandler(this.toolStripButtonScoreCard_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = global::Pinch.Properties.Resources.About_32x32;
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonAbout.Text = "toolStripButton1";
            this.toolStripButtonAbout.ToolTipText = "Display About Information";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // toolStripButtonUserLicenseAgreement
            // 
            this.toolStripButtonUserLicenseAgreement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUserLicenseAgreement.Image = global::Pinch.Properties.Resources.AJP_User_License_Agreement__32x32;
            this.toolStripButtonUserLicenseAgreement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUserLicenseAgreement.Name = "toolStripButtonUserLicenseAgreement";
            this.toolStripButtonUserLicenseAgreement.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonUserLicenseAgreement.ToolTipText = "Display User License Agreement";
            this.toolStripButtonUserLicenseAgreement.Click += new System.EventHandler(this.toolStripButtonUserLicenseAgreement_Click);
            // 
            // pictureBoxAJPLogo
            // 
            this.pictureBoxAJPLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAJPLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxAJPLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAJPLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAJPLogo.Image")));
            this.pictureBoxAJPLogo.Location = new System.Drawing.Point(1104, 605);
            this.pictureBoxAJPLogo.Name = "pictureBoxAJPLogo";
            this.pictureBoxAJPLogo.Size = new System.Drawing.Size(143, 43);
            this.pictureBoxAJPLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAJPLogo.TabIndex = 6;
            this.pictureBoxAJPLogo.TabStop = false;
            this.pictureBoxAJPLogo.Click += new System.EventHandler(this.pictureBoxAJPLogo_Click);
            // 
            // userLicenseAgreementToolStripMenuItem
            // 
            this.userLicenseAgreementToolStripMenuItem.Image = global::Pinch.Properties.Resources.AJP_User_License_Agreement__32x32;
            this.userLicenseAgreementToolStripMenuItem.Name = "userLicenseAgreementToolStripMenuItem";
            this.userLicenseAgreementToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.userLicenseAgreementToolStripMenuItem.Text = "User License Agreement";
            this.userLicenseAgreementToolStripMenuItem.ToolTipText = "Display User License Agreement";
            this.userLicenseAgreementToolStripMenuItem.Click += new System.EventHandler(this.userLicenseAgreementToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelINPUT);
            this.Controls.Add(this.panelTARGETS);
            this.Controls.Add(this.pictureBoxAJPLogo);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.panelHEN);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AJP Pinch 4";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.panelINPUT.ResumeLayout(false);
            this.panelINPUT_PROJECT.ResumeLayout(false);
            this.panelINPUT_PROJECT.PerformLayout();
            this.panelINPUT_VALIDATE.ResumeLayout(false);
            this.panelINPUT_VALIDATE.PerformLayout();
            this.panelINPUT_EXCHANGER.ResumeLayout(false);
            this.panelINPUT_EXCHANGER.PerformLayout();
            this.panelINPUT_COST.ResumeLayout(false);
            this.panelINPUT_COST.PerformLayout();
            this.panelINPUT_UTILITIES.ResumeLayout(false);
            this.panelINPUT_UTILITIES.PerformLayout();
            this.panelINPUT_STREAMS.ResumeLayout(false);
            this.panelINPUT_STREAMS.PerformLayout();
            this.tabControlINPUT.ResumeLayout(false);
            this.panelTARGETS.ResumeLayout(false);
            this.panelTARGETS_OPTIMIZE.ResumeLayout(false);
            this.panelTARGETS_OPTIMIZE.PerformLayout();
            this.panelTARGETS_INTERVAL.ResumeLayout(false);
            this.panelTARGETS_INTERVAL.PerformLayout();
            this.panelTARGETS_COMPOSITE.ResumeLayout(false);
            this.panelTARGETS_COMPOSITE.PerformLayout();
            this.panelTARGETS_CALCULATE.ResumeLayout(false);
            this.panelTARGETS_CALCULATE.PerformLayout();
            this.tabControlTARGETS.ResumeLayout(false);
            this.panelHEN.ResumeLayout(false);
            this.panelHEN_DESIGN.ResumeLayout(false);
            this.panelHEN_DESIGN.PerformLayout();
            this.tabControlHEN.ResumeLayout(false);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAJPLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateTargetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem designHeatExchangerNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specifyInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageINPUT;
        private System.Windows.Forms.TabPage tabPageTARGETS;
        private System.Windows.Forms.TabPage tabPageHEN;
        private System.Windows.Forms.ImageList imageListAnalysis;
        private System.Windows.Forms.Panel panelINPUT;
        private System.Windows.Forms.Panel panelHEN;
        private System.Windows.Forms.Panel panelTARGETS;
        private System.Windows.Forms.TabControl tabControlINPUT;
        private System.Windows.Forms.TabPage tabPageProject;
        private System.Windows.Forms.TabPage tabPageStreams;
        private System.Windows.Forms.TabPage tabPageUtilities;
        private System.Windows.Forms.TabPage tabPageCost;
        private System.Windows.Forms.TabPage tabPageExchanger;
        private System.Windows.Forms.TabPage tabPageValidate;
        private System.Windows.Forms.Panel panelINPUT_PROJECT;
        private System.Windows.Forms.ToolStripMenuItem inputProjectDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputStreamsDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exchangerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compositeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveAs;
        private System.Windows.Forms.Label labelTitleInputProjectPanel;
        private System.Windows.Forms.Panel panelINPUT_STREAMS;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSELECTED_STATE;
        private System.Windows.Forms.Label labelTitleInputStreamsPanel;
        private System.Windows.Forms.TabControl tabControlTARGETS;
        private System.Windows.Forms.TabPage tabPageCalculate;
        private System.Windows.Forms.TabPage tabPageComposite;
        private System.Windows.Forms.TabPage tabPageInterval;
        private System.Windows.Forms.TabPage tabPageOptimize;
        private System.Windows.Forms.TabControl tabControlHEN;
        private System.Windows.Forms.TabPage tabPageDesign;
        private System.Windows.Forms.Panel panelINPUT_EXCHANGER;
        private System.Windows.Forms.Label labelTitleInputExchangerPanel;
        private System.Windows.Forms.Panel panelINPUT_COST;
        private System.Windows.Forms.Label labelTitleInputCostPanel;
        private System.Windows.Forms.Panel panelINPUT_UTILITIES;
        private System.Windows.Forms.Label labelTitleInputUtilitiesPanel;
        private System.Windows.Forms.Panel panelINPUT_VALIDATE;
        private System.Windows.Forms.Label labelTitleInputValidatePanel;
        private System.Windows.Forms.Panel panelTARGETS_COMPOSITE;
        private System.Windows.Forms.Label labelTitleTargetsCompositePanel;
        private System.Windows.Forms.Panel panelTARGETS_CALCULATE;
        private System.Windows.Forms.Label labelTitleTargetsCalculatePanel;
        private System.Windows.Forms.Panel panelTARGETS_OPTIMIZE;
        private System.Windows.Forms.Label labelTitleTargetsOptimizePanel;
        private System.Windows.Forms.Panel panelTARGETS_INTERVAL;
        private System.Windows.Forms.Label labelTitleTargetsIntervalPanel;
        private System.Windows.Forms.Panel panelHEN_DESIGN;
        private System.Windows.Forms.Label labelTitleHenDesignPanel;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.PictureBox pictureBoxAJPLogo;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButtonExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ImageList imageListInput;
        private System.Windows.Forms.ToolStripButton toolStripButtonProject;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonImport;
        private System.Windows.Forms.ToolStripButton toolStripButtonStreams;
        private System.Windows.Forms.ToolStripButton toolStripButtonUtilities;
        private System.Windows.Forms.ToolStripButton toolStripButtonCost;
        private System.Windows.Forms.ToolStripButton toolStripButtonExchanger;
        private System.Windows.Forms.ToolStripButton toolStripButtonValidate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ImageList imageListTargets;
        private System.Windows.Forms.ImageList imageListHen;
        private System.Windows.Forms.ToolStripButton toolStripButtonCalculate;
        private System.Windows.Forms.ToolStripButton toolStripButtonComposite;
        private System.Windows.Forms.ToolStripButton toolStripButtonInterval;
        private System.Windows.Forms.ToolStripButton toolStripButtonOptimize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton toolStripButtonHenDesign;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton toolStripButtonLicense;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLicense;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUnits;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInput;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTargets;
        private System.Windows.Forms.ToolStripMenuItem scorecardToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonScoreCard;
        private System.Windows.Forms.ToolStripButton toolStripButtonUserLicenseAgreement;
        private System.Windows.Forms.ToolStripMenuItem userLicenseAgreementToolStripMenuItem;
    }
}

