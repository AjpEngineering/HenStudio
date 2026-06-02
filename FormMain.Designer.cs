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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Profile: Q1 Setup", 3, 4);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Profile: Q2 Setup", 3, 4);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Profile: Q3 Setup", 3, 4);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Profile: Q4 Setup", 3, 4);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Report: Pinch Report");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Study: Pinch Analysis", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Report: HEN Report");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Study: HEN Analysis", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Project: Deer Park", 1, 2, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode6,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Project: Convent", 1, 2);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Project: Norco", 1, 2);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("HEN Studio", 10, 10, new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Gas-Gas", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1 - 10", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Gas-side dominates; low h", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Gas-Liquid", System.Drawing.Color.Black, System.Drawing.Color.Azure, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "10 - 100", System.Drawing.Color.Black, System.Drawing.Color.Azure, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Cooling water or light oils", System.Drawing.Color.Black, System.Drawing.Color.Azure, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Liquid-Liquid - clean", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "100 - 500", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Non-viscous, low fouling")}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Liquid-Liquid - dirty", System.Drawing.Color.Black, System.Drawing.Color.Azure, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "40 - 200", System.Drawing.Color.Black, System.Drawing.Color.Azure, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Heavy oils, slurries - viscous / fouling", System.Drawing.Color.Black, System.Drawing.Color.Azure, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Condensing Vapor - film condensation", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "200 - 1500", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Shell-side condensation common", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Boiling - flow or pool", System.Drawing.Color.Black, System.Drawing.Color.Azure, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "200 - 2000", System.Drawing.Color.Black, System.Drawing.Color.Azure, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Thermosyphon or kettle", System.Drawing.Color.Black, System.Drawing.Color.Azure, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Reboiler - Kettle", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "200 - 1000", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Depends on boiling regime", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Reboiler - Thermosyphon", System.Drawing.Color.Black, System.Drawing.Color.Azure, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "300 - 2000", System.Drawing.Color.Black, System.Drawing.Color.Azure, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Higher velocities", System.Drawing.Color.Black, System.Drawing.Color.Azure, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Condenser - Shell & Tube", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "200 - 1500", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Hydrocarbon or steam", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Sensible Liquid Heating / Cooling", System.Drawing.Color.Black, System.Drawing.Color.Azure, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "60 - 300", System.Drawing.Color.Black, System.Drawing.Color.Azure, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Water, glycols, oils", System.Drawing.Color.Black, System.Drawing.Color.Azure, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Sensible Gas Heating / Cooling", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "2 - 20", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Air, flue gas", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "_AJP License File.dll"}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "_HenDomainModel.dll"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "_HenGlobal.dll"}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "4",
            "_HenModel.dll"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "5",
            "_HenStudioDatabase.dll"}, -1);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "6",
            "_HenViewModel.dll"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "7",
            "HenStudio.exe"}, -1);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "PRODUCT FULLNAME",
            "AJP HEN Studio 1.0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "PRODUCT NAME",
            "AJP HEN Studio"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "PRODUCT VERSION",
            "1.0.1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem(new string[] {
            "4",
            "PRODUCT SERIAL_NUMBER",
            "1022-789-1189"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem(new string[] {
            "5",
            "PRODUCT CODE",
            "{3D9721BA-003E-4711-B7AF-B579645F0AC9}"}, -1);
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem(new string[] {
            "6",
            "SUPPLIER NAME ",
            "AJP Engineering"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem(new string[] {
            "7",
            "SUPPLIER URL",
            "http:://www.AJPEngineering.com"}, -1);
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "DatabaseCreatedOn",
            "5/5/2026 8:38:41 PM"}, -1);
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "DefaultApproachTemperature",
            "10.00"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "DefaultEnglishU ",
            "35.20"}, -1);
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem(new string[] {
            "4",
            "DefaultMetricU ",
            "720.00"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem30 = new System.Windows.Forms.ListViewItem(new string[] {
            "5",
            "DefaultOptimizer",
            "Genetic"}, -1);
            System.Windows.Forms.ListViewItem listViewItem31 = new System.Windows.Forms.ListViewItem(new string[] {
            "6",
            "EnableAreaEstimation",
            "True"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem32 = new System.Windows.Forms.ListViewItem(new string[] {
            "7",
            "ExternalMagnitudeUnits",
            "Mega"}, -1);
            System.Windows.Forms.ListViewItem listViewItem33 = new System.Windows.Forms.ListViewItem(new string[] {
            "8",
            "ExternalPressUnits",
            "psia"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem34 = new System.Windows.Forms.ListViewItem(new string[] {
            "9",
            "ExternalSystemUnits",
            "English - Imperial"}, -1);
            System.Windows.Forms.ListViewItem listViewItem35 = new System.Windows.Forms.ListViewItem(new string[] {
            "10",
            "ExternalTempUnits",
            "°F"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem36 = new System.Windows.Forms.ListViewItem(new string[] {
            "11",
            "ExternalUnitsA",
            "ft²"}, -1);
            System.Windows.Forms.ListViewItem listViewItem37 = new System.Windows.Forms.ListViewItem(new string[] {
            "12",
            "ExternalUnitsEnergy",
            "MMBtu/hr"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem38 = new System.Windows.Forms.ListViewItem(new string[] {
            "13",
            "ExternalUnitsHeatCapacityFlowRate",
            "MMBtu/(hr·°F)"}, -1);
            System.Windows.Forms.ListViewItem listViewItem39 = new System.Windows.Forms.ListViewItem(new string[] {
            "14",
            "ExternalUnitsMassFlowrate ",
            "lbs/hr"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem40 = new System.Windows.Forms.ListViewItem(new string[] {
            "15",
            "ExternalUnitsSpecificHeatCapacity",
            "MMBTU/( lbs ·°F) "}, -1);
            System.Windows.Forms.ListViewItem listViewItem41 = new System.Windows.Forms.ListViewItem(new string[] {
            "16",
            "ExternalUnitsU",
            "MMBtu/(hr·ft²·°F)"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem42 = new System.Windows.Forms.ListViewItem(new string[] {
            "17",
            "InternalMagnitudeUnits",
            "Kilo"}, -1);
            System.Windows.Forms.ListViewItem listViewItem43 = new System.Windows.Forms.ListViewItem(new string[] {
            "18",
            "InternalPressUnits",
            "Pa"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem44 = new System.Windows.Forms.ListViewItem(new string[] {
            "19",
            "InternalSystemUnits",
            "Metric - SI"}, -1);
            System.Windows.Forms.ListViewItem listViewItem45 = new System.Windows.Forms.ListViewItem(new string[] {
            "20",
            "InternalTempUnits",
            "°C"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem46 = new System.Windows.Forms.ListViewItem(new string[] {
            "21",
            "InternalUnitsA",
            "m²"}, -1);
            System.Windows.Forms.ListViewItem listViewItem47 = new System.Windows.Forms.ListViewItem(new string[] {
            "22",
            "InternalUnitsEnergy",
            "kW"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem48 = new System.Windows.Forms.ListViewItem(new string[] {
            "23",
            "InternalUnitsHeatCapacityFlowRate",
            "kW/K"}, -1);
            System.Windows.Forms.ListViewItem listViewItem49 = new System.Windows.Forms.ListViewItem(new string[] {
            "24",
            "InternalUnitsMassFlowrate",
            "kg/s"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem50 = new System.Windows.Forms.ListViewItem(new string[] {
            "25",
            "InternalUnitsSpecificHeatCapacity",
            "kJ/kg-K"}, -1);
            System.Windows.Forms.ListViewItem listViewItem51 = new System.Windows.Forms.ListViewItem(new string[] {
            "26",
            "InternalUnitsU",
            "kW/(m²·K)"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem52 = new System.Windows.Forms.ListViewItem(new string[] {
            "27",
            "LastMigrationApplied",
            "InitialCreate"}, -1);
            System.Windows.Forms.ListViewItem listViewItem53 = new System.Windows.Forms.ListViewItem(new string[] {
            "28",
            "ReportDefaultFont",
            "Segoe UI"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem54 = new System.Windows.Forms.ListViewItem(new string[] {
            "29",
            "ReportIncludeAuditSection",
            "True"}, -1);
            System.Windows.Forms.ListViewItem listViewItem55 = new System.Windows.Forms.ListViewItem(new string[] {
            "30",
            "ReportUnitsProfile",
            "Default"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem56 = new System.Windows.Forms.ListViewItem(new string[] {
            "31",
            "SchemaVersion",
            "1.0.0"}, -1);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem57 = new System.Windows.Forms.ListViewItem(new string[] {
            "Heat Flow Rate (Duty)",
            "MMBtu/hr"}, -1);
            System.Windows.Forms.ListViewItem listViewItem58 = new System.Windows.Forms.ListViewItem(new string[] {
            "Heat Capacity Flow Rate (CP)",
            "MMBtu/(hr °F)"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Azure, null);
            System.Windows.Forms.ListViewItem listViewItem59 = new System.Windows.Forms.ListViewItem(new string[] {
            "Temperature (Temp)",
            "°F"}, -1);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStripProfile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemProfileRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.modifyProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemProfileDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripCurrProj = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCurrProjExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCurrProjCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCurProjAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorCurProjAdd = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCurProjRename = new System.Windows.Forms.ToolStripMenuItem();
            this.renameProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemDeleteProject = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripProjectCatalog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorExpandCollapse = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemAddProject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMainCatalog = new System.Windows.Forms.MenuStrip();
            this.catalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripStatusLabelExitApp = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLICENSE = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCAT_DB = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelProgressText = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageListAnalysis = new System.Windows.Forms.ImageList(this.components);
            this.imageListInput = new System.Windows.Forms.ImageList(this.components);
            this.imageListTargets = new System.Windows.Forms.ImageList(this.components);
            this.imageListHen = new System.Windows.Forms.ImageList(this.components);
            this.splitContainerLefCenter = new System.Windows.Forms.SplitContainer();
            this.treeViewCurrentProjectExplorer = new System.Windows.Forms.TreeView();
            this.imageListProjectTreeViews = new System.Windows.Forms.ImageList(this.components);
            this.panelSELECTED_PROJECT = new System.Windows.Forms.Panel();
            this.tabControlProject = new System.Windows.Forms.TabControl();
            this.tabPageDefaultParams = new System.Windows.Forms.TabPage();
            this.panelTypicalURanges = new System.Windows.Forms.Panel();
            this.listViewTypicalURanges = new System.Windows.Forms.ListView();
            this.textBoxTypicalULabel = new System.Windows.Forms.TextBox();
            this.panelDefaultParmeters = new System.Windows.Forms.Panel();
            this.textBoxExchangerEquations = new System.Windows.Forms.TextBox();
            this.textBoxFValue = new System.Windows.Forms.TextBox();
            this.textBoxExchangerLabel = new System.Windows.Forms.TextBox();
            this.textBoxDefaultU_Value = new System.Windows.Forms.TextBox();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.textBoxDefaultU_Units = new System.Windows.Forms.TextBox();
            this.textBoxDefaultU = new System.Windows.Forms.TextBox();
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
            this.panelDefaultHenOptimizer = new System.Windows.Forms.Panel();
            this.textBoxOptimizerConvergToler = new System.Windows.Forms.TextBox();
            this.textBoxOptimizerMaxIterValue = new System.Windows.Forms.TextBox();
            this.textBoxOptimizerObjectiveValue = new System.Windows.Forms.TextBox();
            this.textBoxOptimzerTypeValue = new System.Windows.Forms.TextBox();
            this.textBoxOptimizerDescriptionValue = new System.Windows.Forms.TextBox();
            this.textBoxOptimizerNameValue = new System.Windows.Forms.TextBox();
            this.textBoxOptimizerDescription = new System.Windows.Forms.TextBox();
            this.textBoxOptimizerConvergTolerance = new System.Windows.Forms.TextBox();
            this.textBoxOptimizerMaxInter = new System.Windows.Forms.TextBox();
            this.textBoxOptimizerObjective = new System.Windows.Forms.TextBox();
            this.textBoxOptimizerType = new System.Windows.Forms.TextBox();
            this.textBoxOptimizerName = new System.Windows.Forms.TextBox();
            this.textBoxDefaultStudyOptimizerTitle = new System.Windows.Forms.TextBox();
            this.tabPageCostParams = new System.Windows.Forms.TabPage();
            this.pictureBoxCostEq = new System.Windows.Forms.PictureBox();
            this.panelUtilityCost = new System.Windows.Forms.Panel();
            this.textBoxUtilityCostUnits_ENGLISH = new System.Windows.Forms.TextBox();
            this.textBoxUtilityCostUnits = new System.Windows.Forms.TextBox();
            this.textBoxUtilityCostUnits_METRIC = new System.Windows.Forms.TextBox();
            this.textBoxEnglish_HEADER = new System.Windows.Forms.TextBox();
            this.textBoxMetric_HEADER = new System.Windows.Forms.TextBox();
            this.textBoxChilledWater_ENGLISH = new System.Windows.Forms.TextBox();
            this.textBoxFuelGas_ENGLISH = new System.Windows.Forms.TextBox();
            this.textBoxCoolingWater_ENGLISH = new System.Windows.Forms.TextBox();
            this.textBoxLP_Steam_ENGLISH = new System.Windows.Forms.TextBox();
            this.textBoxMP_Steam_ENGLISH = new System.Windows.Forms.TextBox();
            this.textBoxHP_Steam_ENGLISH = new System.Windows.Forms.TextBox();
            this.textBoxChilledWater = new System.Windows.Forms.TextBox();
            this.textBoxChilledWater_METRIC = new System.Windows.Forms.TextBox();
            this.textBoxFuelGas = new System.Windows.Forms.TextBox();
            this.textBoxFuelGas_METRIC = new System.Windows.Forms.TextBox();
            this.textBoxCoolingWater = new System.Windows.Forms.TextBox();
            this.textBoxCoolingWater_METRIC = new System.Windows.Forms.TextBox();
            this.textBoxLP_Steam = new System.Windows.Forms.TextBox();
            this.textBoxLP_Steam_METRIC = new System.Windows.Forms.TextBox();
            this.textBoxMP_Steam = new System.Windows.Forms.TextBox();
            this.textBoxMP_Steam_METRIC = new System.Windows.Forms.TextBox();
            this.textBoxHP_Steam = new System.Windows.Forms.TextBox();
            this.textBoxHP_Steam_METRIC = new System.Windows.Forms.TextBox();
            this.textBoxUtitlityCost_TITLE = new System.Windows.Forms.TextBox();
            this.panelTotalAnnualizedCost = new System.Windows.Forms.Panel();
            this.textBoxTAC_OperatingHours = new System.Windows.Forms.TextBox();
            this.textBoxTAC_OperatingHoursValue = new System.Windows.Forms.TextBox();
            this.textBoxTAC_MaintenanceFraction = new System.Windows.Forms.TextBox();
            this.textBoxTAC_MaintenanceFractionValue = new System.Windows.Forms.TextBox();
            this.textBoxTAC_LifeYears = new System.Windows.Forms.TextBox();
            this.textBoxTAC_LifeYearsValue = new System.Windows.Forms.TextBox();
            this.textBoxTAC_InterestRate = new System.Windows.Forms.TextBox();
            this.textBoxTAC_InterestRateValue = new System.Windows.Forms.TextBox();
            this.textBoxTotalAnnualizedCost_TITLE = new System.Windows.Forms.TextBox();
            this.panelShellAndTubeCapitalCost = new System.Windows.Forms.Panel();
            this.textBoxMaterialFactor = new System.Windows.Forms.TextBox();
            this.textBoxMaterialFactorValue = new System.Windows.Forms.TextBox();
            this.textBoxAreaUnitsEnglish = new System.Windows.Forms.TextBox();
            this.textBoxAreaUnitsEnglishValue = new System.Windows.Forms.TextBox();
            this.textBoxAreaUnitsMetric = new System.Windows.Forms.TextBox();
            this.textBoxAreaUnitsMetricValue = new System.Windows.Forms.TextBox();
            this.textBoxParameterN = new System.Windows.Forms.TextBox();
            this.textBoxParameterN_Value = new System.Windows.Forms.TextBox();
            this.textBoxParameterB_English = new System.Windows.Forms.TextBox();
            this.textBoxParameterB_EnglishValue = new System.Windows.Forms.TextBox();
            this.textBoxParameterB_Metric = new System.Windows.Forms.TextBox();
            this.textBoxParameterB_MetricValue = new System.Windows.Forms.TextBox();
            this.textBoxParameterA = new System.Windows.Forms.TextBox();
            this.textBoxParameterAValue = new System.Windows.Forms.TextBox();
            this.textBoxShellAndTubeCapitalCost_TITLE = new System.Windows.Forms.TextBox();
            this.panelFiredHeaterCapitalCost = new System.Windows.Forms.Panel();
            this.textBoxDutyUnitsEnglish = new System.Windows.Forms.TextBox();
            this.textBoxDutyUnitsEnglishValue = new System.Windows.Forms.TextBox();
            this.textBoxDutyUnitsMetric = new System.Windows.Forms.TextBox();
            this.textBoxDutyUnitsMetricValue = new System.Windows.Forms.TextBox();
            this.textBoxEffeciency = new System.Windows.Forms.TextBox();
            this.textBoxEffeciencyValue = new System.Windows.Forms.TextBox();
            this.textBoxParameterBeta = new System.Windows.Forms.TextBox();
            this.textBoxParameterBetaValue = new System.Windows.Forms.TextBox();
            this.textBoxParameterAlphaEnglish = new System.Windows.Forms.TextBox();
            this.textBoxParameterAlphaEnglishValue = new System.Windows.Forms.TextBox();
            this.textBoxParameterAlphaMetric = new System.Windows.Forms.TextBox();
            this.textBoxParameterAlphaMetricValue = new System.Windows.Forms.TextBox();
            this.textBoxFiredHeaterCapitalCost_TITLE = new System.Windows.Forms.TextBox();
            this.panelCostMetadata = new System.Windows.Forms.Panel();
            this.textBoxInstalledCostFactor = new System.Windows.Forms.TextBox();
            this.textBoxInstalledCostFactorValue = new System.Windows.Forms.TextBox();
            this.textBoxCostIndexCurrency = new System.Windows.Forms.TextBox();
            this.textBoxCostIndexCurrencyValue = new System.Windows.Forms.TextBox();
            this.textBoxCostIndex = new System.Windows.Forms.TextBox();
            this.textBoxCostIndexValue = new System.Windows.Forms.TextBox();
            this.textBoxCostIndexName = new System.Windows.Forms.TextBox();
            this.textBoxCostIndexNameValue = new System.Windows.Forms.TextBox();
            this.textBoxCostIndexBaseYear = new System.Windows.Forms.TextBox();
            this.textBoxCostIndexBaseYearValue = new System.Windows.Forms.TextBox();
            this.textBoxProjectCostMetadata_TITLE = new System.Windows.Forms.TextBox();
            this.textBoxProjectBanner = new System.Windows.Forms.TextBox();
            this.panelProjectMetadata = new System.Windows.Forms.Panel();
            this.textBoxProjectID = new System.Windows.Forms.TextBox();
            this.textBoxProjectGUID = new System.Windows.Forms.TextBox();
            this.pictureBoxOpenedProject = new System.Windows.Forms.PictureBox();
            this.textBoxProjectNameValue = new System.Windows.Forms.TextBox();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.textBoxProjectDescription = new System.Windows.Forms.TextBox();
            this.textBoxProjectDescriptionValue = new System.Windows.Forms.TextBox();
            this.panelSELECTED_ROOT = new System.Windows.Forms.Panel();
            this.tabControlROOT = new System.Windows.Forms.TabControl();
            this.tabPageROOT_Home = new System.Windows.Forms.TabPage();
            this.panelHomeAJP = new System.Windows.Forms.Panel();
            this.pictureBoxHomeAjpLogo = new System.Windows.Forms.PictureBox();
            this.tabPageROOT_FactorSettings = new System.Windows.Forms.TabPage();
            this.pictureBoxFactorySettingsAjpEngLogo = new System.Windows.Forms.PictureBox();
            this.panelAppComponents = new System.Windows.Forms.Panel();
            this.listViewAppComponents = new System.Windows.Forms.ListView();
            this.columnHeaderComponentsNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderComponentsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxAppComponentsTitle = new System.Windows.Forms.TextBox();
            this.panelAppMetadata = new System.Windows.Forms.Panel();
            this.listViewAppMetadata = new System.Windows.Forms.ListView();
            this.columnHeaderMetadataNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMetadataName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAppMetadataValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxAppMetadataTitle = new System.Windows.Forms.TextBox();
            this.panelFactorySettings = new System.Windows.Forms.Panel();
            this.textBoxFactorySettingsTitle = new System.Windows.Forms.TextBox();
            this.listViewFactorySettings = new System.Windows.Forms.ListView();
            this.columnHeaderSettingsNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSettingsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSettingsValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageROOT_Database = new System.Windows.Forms.TabPage();
            this.pictureBoxDbAjpEndLogo = new System.Windows.Forms.PictureBox();
            this.panelDatabaseTables = new System.Windows.Forms.Panel();
            this.textBoxDatabaseTablesTitle = new System.Windows.Forms.TextBox();
            this.listViewDatabaseTables = new System.Windows.Forms.ListView();
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTableSchema = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.buttonConnection = new System.Windows.Forms.Button();
            this.tabPageROOT_License = new System.Windows.Forms.TabPage();
            this.tabControlLicense = new System.Windows.Forms.TabControl();
            this.tabPageLicenseScorecard = new System.Windows.Forms.TabPage();
            this.pictureBoxAjpEngLogo = new System.Windows.Forms.PictureBox();
            this.textBoxOverallStatus = new System.Windows.Forms.TextBox();
            this.panelScorecardSummary = new System.Windows.Forms.Panel();
            this.pictureBoxInvalid = new System.Windows.Forms.PictureBox();
            this.labelInvalidTotal = new System.Windows.Forms.Label();
            this.pictureBoxValid = new System.Windows.Forms.PictureBox();
            this.labelVaildTotal = new System.Windows.Forms.Label();
            this.textBoxScorecardSummary = new System.Windows.Forms.TextBox();
            this.panelDeviceUser = new System.Windows.Forms.Panel();
            this.labelFullname = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBoxRunning = new System.Windows.Forms.PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelDevice = new System.Windows.Forms.Label();
            this.textBoxDevice = new System.Windows.Forms.TextBox();
            this.textBoxDeviceUserTITLE = new System.Windows.Forms.TextBox();
            this.panelScorecardTable = new System.Windows.Forms.Panel();
            this.dataGridViewScoreCard = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnState = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxLicenseScorecardTITLE = new System.Windows.Forms.TextBox();
            this.tabPageLicenseFile = new System.Windows.Forms.TabPage();
            this.panelLicenseType = new System.Windows.Forms.Panel();
            this.pictureBoxKeys = new System.Windows.Forms.PictureBox();
            this.textBoxLicenseTypeTitle = new System.Windows.Forms.TextBox();
            this.pictureBoxSite = new System.Windows.Forms.PictureBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.textBoxDivision = new System.Windows.Forms.TextBox();
            this.labelLicenseType = new System.Windows.Forms.Label();
            this.textBoxDeviceName = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelCorporation = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxCorporation = new System.Windows.Forms.TextBox();
            this.labelDivision = new System.Windows.Forms.Label();
            this.textBoxLicenseType = new System.Windows.Forms.TextBox();
            this.panelSupplier = new System.Windows.Forms.Panel();
            this.textBoxSupplierTitle = new System.Windows.Forms.TextBox();
            this.textBoxSupplierUrl = new System.Windows.Forms.TextBox();
            this.labelSupplierUrl = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxSupplierName = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.panelCustomerContact = new System.Windows.Forms.Panel();
            this.textBoxCustomerEmail = new System.Windows.Forms.TextBox();
            this.textBoxCustomerContactTitle = new System.Windows.Forms.TextBox();
            this.labelCustomerEmail = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.textBoxProductCode = new System.Windows.Forms.TextBox();
            this.textBoxProductTitle = new System.Windows.Forms.TextBox();
            this.labelProductCode = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.panelLicense = new System.Windows.Forms.Panel();
            this.textBoxDaysRemainingValue = new System.Windows.Forms.TextBox();
            this.labelDayRemaining = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxLicenseTitle = new System.Windows.Forms.TextBox();
            this.labelHash = new System.Windows.Forms.Label();
            this.labelLicenseKey = new System.Windows.Forms.Label();
            this.textBoxEndDate = new System.Windows.Forms.TextBox();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.textBoxHash = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelDays = new System.Windows.Forms.Label();
            this.textBoxLicenseKey = new System.Windows.Forms.TextBox();
            this.tabPageROOT_About = new System.Windows.Forms.TabPage();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.pictureBoxAjpContactInfo = new System.Windows.Forms.PictureBox();
            this.pictureBoxLicenseAgreement = new System.Windows.Forms.PictureBox();
            this.pictureBoxHenStudio = new System.Windows.Forms.PictureBox();
            this.pictureBoxProductWarning = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelProduct = new System.Windows.Forms.TableLayoutPanel();
            this.labelProductFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProductFullNameValue = new System.Windows.Forms.Label();
            this.labelProductNameValue = new System.Windows.Forms.Label();
            this.labelProductVersion = new System.Windows.Forms.Label();
            this.labelProductVersionValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSerialNumberValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelProductCodeValue = new System.Windows.Forms.Label();
            this.tableLayoutPanelSupplier = new System.Windows.Forms.TableLayoutPanel();
            this.labelSuplierName = new System.Windows.Forms.Label();
            this.labelSupplierNameValue = new System.Windows.Forms.Label();
            this.textBoxProjectsBanner = new System.Windows.Forms.TextBox();
            this.panelSELECTED_PROFILE = new System.Windows.Forms.Panel();
            this.panelProfileMetadata = new System.Windows.Forms.Panel();
            this.listViewProfileUnits = new System.Windows.Forms.ListView();
            this.columnHeaderProfileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProfileUnits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxUnits = new System.Windows.Forms.TextBox();
            this.textBoxProfileProjectId = new System.Windows.Forms.TextBox();
            this.textBoxProfileProjectIdValue = new System.Windows.Forms.TextBox();
            this.textBoxProfileId = new System.Windows.Forms.TextBox();
            this.textBoxProfileIdValue = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxProfileNameValue = new System.Windows.Forms.TextBox();
            this.textBoxProfileName = new System.Windows.Forms.TextBox();
            this.textBoxProfileDescription = new System.Windows.Forms.TextBox();
            this.textBoxProfileDescriptionValue = new System.Windows.Forms.TextBox();
            this.tabControlInputPhase = new System.Windows.Forms.TabControl();
            this.tabPageProcessStreams = new System.Windows.Forms.TabPage();
            this.dataGridViewProcessStreams = new System.Windows.Forms.DataGridView();
            this.ProcessStreamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessStreamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreamType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreamSubtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreamHeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeatCapacityFlowRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyPress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetPress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeltaTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeltaPress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidStreamIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.StreamValidation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageUtilitiesStreams = new System.Windows.Forms.TabPage();
            this.dataGridViewUtilityStreams = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsothermalTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxInputBanner = new System.Windows.Forms.TextBox();
            this.panelSELECTED_PINCH = new System.Windows.Forms.Panel();
            this.textBoxPinchBanner = new System.Windows.Forms.TextBox();
            this.pictureBoxOpenedPinch = new System.Windows.Forms.PictureBox();
            this.panelSELECTED_HEN = new System.Windows.Forms.Panel();
            this.textBoxHenBanner = new System.Windows.Forms.TextBox();
            this.pictureBoxOpenedHen = new System.Windows.Forms.PictureBox();
            this.imageListProject = new System.Windows.Forms.ImageList(this.components);
            this.columnHeaderUService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderURange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxHeatTransferCoeffUnits = new System.Windows.Forms.TextBox();
            this.textBoxHeatTransferCoeffUnitsValue = new System.Windows.Forms.TextBox();
            this.contextMenuStripProfile.SuspendLayout();
            this.contextMenuStripCurrProj.SuspendLayout();
            this.contextMenuStripProjectCatalog.SuspendLayout();
            this.menuStripMainCatalog.SuspendLayout();
            this.statusStripMainDASHBOARD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLefCenter)).BeginInit();
            this.splitContainerLefCenter.Panel1.SuspendLayout();
            this.splitContainerLefCenter.Panel2.SuspendLayout();
            this.splitContainerLefCenter.SuspendLayout();
            this.panelSELECTED_PROJECT.SuspendLayout();
            this.tabControlProject.SuspendLayout();
            this.tabPageDefaultParams.SuspendLayout();
            this.panelTypicalURanges.SuspendLayout();
            this.panelDefaultParmeters.SuspendLayout();
            this.panelProjectUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnitsSystem)).BeginInit();
            this.panelDefaultHenOptimizer.SuspendLayout();
            this.tabPageCostParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCostEq)).BeginInit();
            this.panelUtilityCost.SuspendLayout();
            this.panelTotalAnnualizedCost.SuspendLayout();
            this.panelShellAndTubeCapitalCost.SuspendLayout();
            this.panelFiredHeaterCapitalCost.SuspendLayout();
            this.panelCostMetadata.SuspendLayout();
            this.panelProjectMetadata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedProject)).BeginInit();
            this.panelSELECTED_ROOT.SuspendLayout();
            this.tabControlROOT.SuspendLayout();
            this.tabPageROOT_Home.SuspendLayout();
            this.panelHomeAJP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeAjpLogo)).BeginInit();
            this.tabPageROOT_FactorSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFactorySettingsAjpEngLogo)).BeginInit();
            this.panelAppComponents.SuspendLayout();
            this.panelAppMetadata.SuspendLayout();
            this.panelFactorySettings.SuspendLayout();
            this.tabPageROOT_Database.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDbAjpEndLogo)).BeginInit();
            this.panelDatabaseTables.SuspendLayout();
            this.panelProjectDbFileMetadata.SuspendLayout();
            this.tabPageROOT_License.SuspendLayout();
            this.tabControlLicense.SuspendLayout();
            this.tabPageLicenseScorecard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAjpEngLogo)).BeginInit();
            this.panelScorecardSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvalid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValid)).BeginInit();
            this.panelDeviceUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRunning)).BeginInit();
            this.panelScorecardTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreCard)).BeginInit();
            this.tabPageLicenseFile.SuspendLayout();
            this.panelLicenseType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSite)).BeginInit();
            this.panelSupplier.SuspendLayout();
            this.panelCustomerContact.SuspendLayout();
            this.panelProduct.SuspendLayout();
            this.panelLicense.SuspendLayout();
            this.tabPageROOT_About.SuspendLayout();
            this.panelAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAjpContactInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLicenseAgreement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHenStudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductWarning)).BeginInit();
            this.tableLayoutPanelProduct.SuspendLayout();
            this.tableLayoutPanelSupplier.SuspendLayout();
            this.panelSELECTED_PROFILE.SuspendLayout();
            this.panelProfileMetadata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlInputPhase.SuspendLayout();
            this.tabPageProcessStreams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessStreams)).BeginInit();
            this.tabPageUtilitiesStreams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilityStreams)).BeginInit();
            this.panelSELECTED_PINCH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedPinch)).BeginInit();
            this.panelSELECTED_HEN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedHen)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStripProfile
            // 
            this.contextMenuStripProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemProfileRename,
            this.toolStripSeparator4,
            this.modifyProfileToolStripMenuItem,
            this.renameProfileToolStripMenuItem,
            this.toolStripSeparator12,
            this.toolStripMenuItemProfileDelete});
            this.contextMenuStripProfile.Name = "contextMenuStripProfile";
            this.contextMenuStripProfile.Size = new System.Drawing.Size(159, 104);
            // 
            // toolStripMenuItemProfileRename
            // 
            this.toolStripMenuItemProfileRename.Name = "toolStripMenuItemProfileRename";
            this.toolStripMenuItemProfileRename.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItemProfileRename.Text = "Add Profile...";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(155, 6);
            // 
            // modifyProfileToolStripMenuItem
            // 
            this.modifyProfileToolStripMenuItem.Name = "modifyProfileToolStripMenuItem";
            this.modifyProfileToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.modifyProfileToolStripMenuItem.Text = "Modify Profile...";
            // 
            // renameProfileToolStripMenuItem
            // 
            this.renameProfileToolStripMenuItem.Name = "renameProfileToolStripMenuItem";
            this.renameProfileToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.renameProfileToolStripMenuItem.Text = "Rename Profile";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(155, 6);
            // 
            // toolStripMenuItemProfileDelete
            // 
            this.toolStripMenuItemProfileDelete.Name = "toolStripMenuItemProfileDelete";
            this.toolStripMenuItemProfileDelete.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItemProfileDelete.Text = "Delete Profile";
            this.toolStripMenuItemProfileDelete.Click += new System.EventHandler(this.toolStripMenuItemProfileDelete_Click);
            // 
            // contextMenuStripCurrProj
            // 
            this.contextMenuStripCurrProj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCurrProjExpandAll,
            this.toolStripMenuItemCurrProjCollapseAll,
            this.toolStripSeparator9,
            this.toolStripMenuItemCurProjAdd,
            this.addStudyToolStripMenuItem,
            this.toolStripSeparatorCurProjAdd,
            this.toolStripMenuItemCurProjRename,
            this.renameProjectToolStripMenuItem,
            this.toolStripSeparator13,
            this.toolStripMenuItemDeleteProject});
            this.contextMenuStripCurrProj.Name = "contextMenuStripCurrProj";
            this.contextMenuStripCurrProj.Size = new System.Drawing.Size(167, 176);
            // 
            // toolStripMenuItemCurrProjExpandAll
            // 
            this.toolStripMenuItemCurrProjExpandAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCurrProjExpandAll.Image")));
            this.toolStripMenuItemCurrProjExpandAll.Name = "toolStripMenuItemCurrProjExpandAll";
            this.toolStripMenuItemCurrProjExpandAll.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItemCurrProjExpandAll.Text = "Expand All";
            this.toolStripMenuItemCurrProjExpandAll.Click += new System.EventHandler(this.toolStripMenuItemCurrProjExpandAll_Click);
            // 
            // toolStripMenuItemCurrProjCollapseAll
            // 
            this.toolStripMenuItemCurrProjCollapseAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCurrProjCollapseAll.Image")));
            this.toolStripMenuItemCurrProjCollapseAll.Name = "toolStripMenuItemCurrProjCollapseAll";
            this.toolStripMenuItemCurrProjCollapseAll.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItemCurrProjCollapseAll.Text = "Collapse All";
            this.toolStripMenuItemCurrProjCollapseAll.Click += new System.EventHandler(this.toolStripMenuItemCurrProjCollapseAll_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripMenuItemCurProjAdd
            // 
            this.toolStripMenuItemCurProjAdd.Name = "toolStripMenuItemCurProjAdd";
            this.toolStripMenuItemCurProjAdd.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItemCurProjAdd.Text = "Add Profile...";
            this.toolStripMenuItemCurProjAdd.Click += new System.EventHandler(this.toolStripMenuItemCurProjAdd_Click);
            // 
            // addStudyToolStripMenuItem
            // 
            this.addStudyToolStripMenuItem.Name = "addStudyToolStripMenuItem";
            this.addStudyToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addStudyToolStripMenuItem.Text = "Add Study...";
            // 
            // toolStripSeparatorCurProjAdd
            // 
            this.toolStripSeparatorCurProjAdd.Name = "toolStripSeparatorCurProjAdd";
            this.toolStripSeparatorCurProjAdd.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripMenuItemCurProjRename
            // 
            this.toolStripMenuItemCurProjRename.Name = "toolStripMenuItemCurProjRename";
            this.toolStripMenuItemCurProjRename.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItemCurProjRename.Text = "Modify Project...";
            this.toolStripMenuItemCurProjRename.Click += new System.EventHandler(this.toolStripMenuItemCurProjRename_Click);
            // 
            // renameProjectToolStripMenuItem
            // 
            this.renameProjectToolStripMenuItem.Name = "renameProjectToolStripMenuItem";
            this.renameProjectToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.renameProjectToolStripMenuItem.Text = "Rename Project...";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripMenuItemDeleteProject
            // 
            this.toolStripMenuItemDeleteProject.Name = "toolStripMenuItemDeleteProject";
            this.toolStripMenuItemDeleteProject.Size = new System.Drawing.Size(166, 22);
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
            this.toolStripMenuItemAddProject});
            this.contextMenuStripProjectCatalog.Name = "contextMenuStripProjectCatalog";
            this.contextMenuStripProjectCatalog.Size = new System.Drawing.Size(173, 76);
            this.contextMenuStripProjectCatalog.Text = "PROJECT CATALOG";
            // 
            // toolStripMenuItemCollapseAll
            // 
            this.toolStripMenuItemCollapseAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCollapseAll.Image")));
            this.toolStripMenuItemCollapseAll.Name = "toolStripMenuItemCollapseAll";
            this.toolStripMenuItemCollapseAll.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItemCollapseAll.Text = "Collapse All";
            this.toolStripMenuItemCollapseAll.Click += new System.EventHandler(this.toolStripMenuItemCollapseAll_Click);
            // 
            // toolStripMenuItemExpandAll
            // 
            this.toolStripMenuItemExpandAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemExpandAll.Image")));
            this.toolStripMenuItemExpandAll.Name = "toolStripMenuItemExpandAll";
            this.toolStripMenuItemExpandAll.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItemExpandAll.Text = "Expand All";
            this.toolStripMenuItemExpandAll.Click += new System.EventHandler(this.toolStripMenuItemExpandAll_Click);
            // 
            // toolStripSeparatorExpandCollapse
            // 
            this.toolStripSeparatorExpandCollapse.Name = "toolStripSeparatorExpandCollapse";
            this.toolStripSeparatorExpandCollapse.Size = new System.Drawing.Size(169, 6);
            // 
            // toolStripMenuItemAddProject
            // 
            this.toolStripMenuItemAddProject.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAddProject.Image")));
            this.toolStripMenuItemAddProject.Name = "toolStripMenuItemAddProject";
            this.toolStripMenuItemAddProject.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItemAddProject.Text = "Add New Project...";
            this.toolStripMenuItemAddProject.Click += new System.EventHandler(this.toolStripMenuItemAddProject_Click);
            // 
            // menuStripMainCatalog
            // 
            this.menuStripMainCatalog.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMainCatalog.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMainCatalog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogToolStripMenuItem});
            this.menuStripMainCatalog.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainCatalog.Name = "menuStripMainCatalog";
            this.menuStripMainCatalog.Size = new System.Drawing.Size(1264, 24);
            this.menuStripMainCatalog.TabIndex = 0;
            this.menuStripMainCatalog.Text = "menuStripPinch";
            // 
            // catalogToolStripMenuItem
            // 
            this.catalogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem});
            this.catalogToolStripMenuItem.Name = "catalogToolStripMenuItem";
            this.catalogToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.catalogToolStripMenuItem.Text = "Projects";
            this.catalogToolStripMenuItem.ToolTipText = "Catalog of Projects";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newProjectToolStripMenuItem.Image")));
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.newProjectToolStripMenuItem.Text = "Add New Project...";
            this.newProjectToolStripMenuItem.ToolTipText = "Add New Project to Catalog";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
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
            this.toolStripStatusLabelExitApp,
            this.toolStripStatusLabelLICENSE,
            this.toolStripStatusLabelCAT_DB,
            this.toolStripStatusLabelProgressText});
            this.statusStripMainDASHBOARD.Location = new System.Drawing.Point(0, 639);
            this.statusStripMainDASHBOARD.Margin = new System.Windows.Forms.Padding(3);
            this.statusStripMainDASHBOARD.Name = "statusStripMainDASHBOARD";
            this.statusStripMainDASHBOARD.Size = new System.Drawing.Size(1264, 42);
            this.statusStripMainDASHBOARD.TabIndex = 6;
            // 
            // toolStripStatusLabelExitApp
            // 
            this.toolStripStatusLabelExitApp.BackColor = System.Drawing.Color.RoyalBlue;
            this.toolStripStatusLabelExitApp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelExitApp.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelExitApp.Image = global::HenStudio.Properties.Resources.ExitRectangleLargeBlue;
            this.toolStripStatusLabelExitApp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelExitApp.Margin = new System.Windows.Forms.Padding(3, 6, 0, 3);
            this.toolStripStatusLabelExitApp.Name = "toolStripStatusLabelExitApp";
            this.toolStripStatusLabelExitApp.Padding = new System.Windows.Forms.Padding(6);
            this.toolStripStatusLabelExitApp.Size = new System.Drawing.Size(186, 33);
            this.toolStripStatusLabelExitApp.Text = "EXIT APPLICATION  ";
            this.toolStripStatusLabelExitApp.Click += new System.EventHandler(this.toolStripStatusLabelExitApp_Click);
            // 
            // toolStripStatusLabelLICENSE
            // 
            this.toolStripStatusLabelLICENSE.BackColor = System.Drawing.Color.Green;
            this.toolStripStatusLabelLICENSE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelLICENSE.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelLICENSE.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelLICENSE.Image")));
            this.toolStripStatusLabelLICENSE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelLICENSE.Margin = new System.Windows.Forms.Padding(3, 6, 0, 3);
            this.toolStripStatusLabelLICENSE.Name = "toolStripStatusLabelLICENSE";
            this.toolStripStatusLabelLICENSE.Padding = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.toolStripStatusLabelLICENSE.Size = new System.Drawing.Size(105, 33);
            this.toolStripStatusLabelLICENSE.Text = "LICENSE ";
            // 
            // toolStripStatusLabelCAT_DB
            // 
            this.toolStripStatusLabelCAT_DB.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelCAT_DB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelCAT_DB.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelCAT_DB.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelCAT_DB.Image")));
            this.toolStripStatusLabelCAT_DB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelCAT_DB.Margin = new System.Windows.Forms.Padding(3, 6, 0, 3);
            this.toolStripStatusLabelCAT_DB.Name = "toolStripStatusLabelCAT_DB";
            this.toolStripStatusLabelCAT_DB.Padding = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.toolStripStatusLabelCAT_DB.Size = new System.Drawing.Size(135, 33);
            this.toolStripStatusLabelCAT_DB.Text = "CONNECTED";
            this.toolStripStatusLabelCAT_DB.Click += new System.EventHandler(this.toolStripStatusLabelCAT_DB_Click);
            this.toolStripStatusLabelCAT_DB.DoubleClick += new System.EventHandler(this.toolStripStatusLabelCAT_DB_DoubleClick);
            // 
            // toolStripStatusLabelProgressText
            // 
            this.toolStripStatusLabelProgressText.BackColor = System.Drawing.Color.RoyalBlue;
            this.toolStripStatusLabelProgressText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripStatusLabelProgressText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelProgressText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelProgressText.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelProgressText.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabelProgressText.Margin = new System.Windows.Forms.Padding(3, 6, 0, 3);
            this.toolStripStatusLabelProgressText.Name = "toolStripStatusLabelProgressText";
            this.toolStripStatusLabelProgressText.Padding = new System.Windows.Forms.Padding(6);
            this.toolStripStatusLabelProgressText.Size = new System.Drawing.Size(811, 33);
            this.toolStripStatusLabelProgressText.Spring = true;
            this.toolStripStatusLabelProgressText.Text = "AJP HEN Studio";
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
            this.splitContainerLefCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLefCenter.Location = new System.Drawing.Point(0, 24);
            this.splitContainerLefCenter.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainerLefCenter.MinimumSize = new System.Drawing.Size(1264, 619);
            this.splitContainerLefCenter.Name = "splitContainerLefCenter";
            // 
            // splitContainerLefCenter.Panel1
            // 
            this.splitContainerLefCenter.Panel1.BackColor = System.Drawing.Color.Honeydew;
            this.splitContainerLefCenter.Panel1.Controls.Add(this.treeViewCurrentProjectExplorer);
            this.splitContainerLefCenter.Panel1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerLefCenter.Panel1MinSize = 350;
            // 
            // splitContainerLefCenter.Panel2
            // 
            this.splitContainerLefCenter.Panel2.BackColor = System.Drawing.Color.Honeydew;
            this.splitContainerLefCenter.Panel2.Controls.Add(this.panelSELECTED_PROJECT);
            this.splitContainerLefCenter.Panel2.Controls.Add(this.panelSELECTED_ROOT);
            this.splitContainerLefCenter.Panel2.Controls.Add(this.panelSELECTED_PROFILE);
            this.splitContainerLefCenter.Panel2.Controls.Add(this.panelSELECTED_PINCH);
            this.splitContainerLefCenter.Panel2.Controls.Add(this.panelSELECTED_HEN);
            this.splitContainerLefCenter.Panel2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerLefCenter.Panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.splitContainerLefCenter.Panel2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.splitContainerLefCenter.Panel2MinSize = 908;
            this.splitContainerLefCenter.Size = new System.Drawing.Size(1264, 619);
            this.splitContainerLefCenter.SplitterDistance = 351;
            this.splitContainerLefCenter.TabIndex = 2;
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
            this.treeViewCurrentProjectExplorer.Location = new System.Drawing.Point(0, 0);
            this.treeViewCurrentProjectExplorer.Margin = new System.Windows.Forms.Padding(6);
            this.treeViewCurrentProjectExplorer.Name = "treeViewCurrentProjectExplorer";
            treeNode1.ContextMenuStrip = this.contextMenuStripProfile;
            treeNode1.ImageIndex = 3;
            treeNode1.Name = "NodeProfile_01";
            treeNode1.SelectedImageIndex = 4;
            treeNode1.Text = "Profile: Q1 Setup";
            treeNode2.ContextMenuStrip = this.contextMenuStripProfile;
            treeNode2.ImageIndex = 3;
            treeNode2.Name = "NodeProfile_02";
            treeNode2.SelectedImageIndex = 4;
            treeNode2.Text = "Profile: Q2 Setup";
            treeNode3.ContextMenuStrip = this.contextMenuStripProfile;
            treeNode3.ImageIndex = 3;
            treeNode3.Name = "NodeProfile_03";
            treeNode3.SelectedImageIndex = 4;
            treeNode3.Text = "Profile: Q3 Setup";
            treeNode4.ContextMenuStrip = this.contextMenuStripProfile;
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "NodeProfile_04";
            treeNode4.SelectedImageIndex = 4;
            treeNode4.Text = "Profile: Q4 Setup";
            treeNode5.ImageKey = "HEN_16x16.ico";
            treeNode5.Name = "NodeReportPinch";
            treeNode5.SelectedImageKey = "HENSelected_16x16.ico";
            treeNode5.Text = "Report: Pinch Report";
            treeNode6.ImageKey = "Pinch_16x16.ico";
            treeNode6.Name = "Node0";
            treeNode6.SelectedImageIndex = 6;
            treeNode6.Text = "Study: Pinch Analysis";
            treeNode7.ImageKey = "HEN_16x16.ico";
            treeNode7.Name = "NodeReportHen";
            treeNode7.SelectedImageKey = "HENSelected_16x16.ico";
            treeNode7.Text = "Report: HEN Report";
            treeNode8.ImageKey = "Pinch_16x16.ico";
            treeNode8.Name = "Node1";
            treeNode8.SelectedImageKey = "PinchSelected_16x16.ico";
            treeNode8.Text = "Study: HEN Analysis";
            treeNode9.ContextMenuStrip = this.contextMenuStripCurrProj;
            treeNode9.ImageIndex = 1;
            treeNode9.Name = "NodeProject02";
            treeNode9.SelectedImageIndex = 2;
            treeNode9.Text = "Project: Deer Park";
            treeNode10.ContextMenuStrip = this.contextMenuStripCurrProj;
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "NodeProject02";
            treeNode10.SelectedImageIndex = 2;
            treeNode10.Text = "Project: Convent";
            treeNode11.ContextMenuStrip = this.contextMenuStripCurrProj;
            treeNode11.ImageIndex = 1;
            treeNode11.Name = "NodeProject03";
            treeNode11.SelectedImageIndex = 2;
            treeNode11.Text = "Project: Norco";
            treeNode12.ContextMenuStrip = this.contextMenuStripProjectCatalog;
            treeNode12.ImageIndex = 10;
            treeNode12.Name = "NodeRootProjects";
            treeNode12.SelectedImageIndex = 10;
            treeNode12.Text = "HEN Studio";
            this.treeViewCurrentProjectExplorer.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeViewCurrentProjectExplorer.SelectedImageIndex = 9;
            this.treeViewCurrentProjectExplorer.Size = new System.Drawing.Size(351, 619);
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
            // panelSELECTED_PROJECT
            // 
            this.panelSELECTED_PROJECT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSELECTED_PROJECT.BackColor = System.Drawing.Color.Honeydew;
            this.panelSELECTED_PROJECT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSELECTED_PROJECT.Controls.Add(this.tabControlProject);
            this.panelSELECTED_PROJECT.Controls.Add(this.textBoxProjectBanner);
            this.panelSELECTED_PROJECT.Controls.Add(this.panelProjectMetadata);
            this.panelSELECTED_PROJECT.Location = new System.Drawing.Point(0, 0);
            this.panelSELECTED_PROJECT.Margin = new System.Windows.Forms.Padding(0);
            this.panelSELECTED_PROJECT.Name = "panelSELECTED_PROJECT";
            this.panelSELECTED_PROJECT.Padding = new System.Windows.Forms.Padding(6);
            this.panelSELECTED_PROJECT.Size = new System.Drawing.Size(910, 619);
            this.panelSELECTED_PROJECT.TabIndex = 2;
            // 
            // tabControlProject
            // 
            this.tabControlProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlProject.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlProject.Controls.Add(this.tabPageDefaultParams);
            this.tabControlProject.Controls.Add(this.tabPageCostParams);
            this.tabControlProject.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlProject.ItemSize = new System.Drawing.Size(161, 35);
            this.tabControlProject.Location = new System.Drawing.Point(-3, 190);
            this.tabControlProject.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlProject.Name = "tabControlProject";
            this.tabControlProject.SelectedIndex = 0;
            this.tabControlProject.Size = new System.Drawing.Size(911, 428);
            this.tabControlProject.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlProject.TabIndex = 38;
            // 
            // tabPageDefaultParams
            // 
            this.tabPageDefaultParams.BackColor = System.Drawing.Color.Honeydew;
            this.tabPageDefaultParams.Controls.Add(this.panelTypicalURanges);
            this.tabPageDefaultParams.Controls.Add(this.panelDefaultParmeters);
            this.tabPageDefaultParams.Controls.Add(this.panelProjectUnits);
            this.tabPageDefaultParams.Controls.Add(this.panelDefaultHenOptimizer);
            this.tabPageDefaultParams.Location = new System.Drawing.Point(4, 39);
            this.tabPageDefaultParams.Name = "tabPageDefaultParams";
            this.tabPageDefaultParams.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDefaultParams.Size = new System.Drawing.Size(903, 385);
            this.tabPageDefaultParams.TabIndex = 0;
            this.tabPageDefaultParams.Text = "  Project Settings  ";
            // 
            // panelTypicalURanges
            // 
            this.panelTypicalURanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTypicalURanges.BackColor = System.Drawing.Color.White;
            this.panelTypicalURanges.Controls.Add(this.textBoxHeatTransferCoeffUnitsValue);
            this.panelTypicalURanges.Controls.Add(this.textBoxHeatTransferCoeffUnits);
            this.panelTypicalURanges.Controls.Add(this.listViewTypicalURanges);
            this.panelTypicalURanges.Controls.Add(this.textBoxTypicalULabel);
            this.panelTypicalURanges.Location = new System.Drawing.Point(379, 169);
            this.panelTypicalURanges.Name = "panelTypicalURanges";
            this.panelTypicalURanges.Size = new System.Drawing.Size(508, 210);
            this.panelTypicalURanges.TabIndex = 38;
            // 
            // listViewTypicalURanges
            // 
            this.listViewTypicalURanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTypicalURanges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewTypicalURanges.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUService,
            this.columnHeaderURange,
            this.columnHeaderUNote});
            this.listViewTypicalURanges.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTypicalURanges.ForeColor = System.Drawing.Color.RoyalBlue;
            this.listViewTypicalURanges.FullRowSelect = true;
            this.listViewTypicalURanges.GridLines = true;
            this.listViewTypicalURanges.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewTypicalURanges.HideSelection = false;
            this.listViewTypicalURanges.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11});
            this.listViewTypicalURanges.Location = new System.Drawing.Point(10, 55);
            this.listViewTypicalURanges.Name = "listViewTypicalURanges";
            this.listViewTypicalURanges.Size = new System.Drawing.Size(488, 152);
            this.listViewTypicalURanges.TabIndex = 36;
            this.listViewTypicalURanges.UseCompatibleStateImageBehavior = false;
            this.listViewTypicalURanges.View = System.Windows.Forms.View.Details;
            // 
            // textBoxTypicalULabel
            // 
            this.textBoxTypicalULabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTypicalULabel.BackColor = System.Drawing.Color.Yellow;
            this.textBoxTypicalULabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTypicalULabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTypicalULabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxTypicalULabel.Location = new System.Drawing.Point(3, 3);
            this.textBoxTypicalULabel.Name = "textBoxTypicalULabel";
            this.textBoxTypicalULabel.ReadOnly = true;
            this.textBoxTypicalULabel.Size = new System.Drawing.Size(502, 22);
            this.textBoxTypicalULabel.TabIndex = 35;
            this.textBoxTypicalULabel.TabStop = false;
            this.textBoxTypicalULabel.Text = "TYPICAL HEAT TRANSFER COEFFICIENT (U) RANGES";
            this.textBoxTypicalULabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelDefaultParmeters
            // 
            this.panelDefaultParmeters.BackColor = System.Drawing.Color.White;
            this.panelDefaultParmeters.Controls.Add(this.textBoxExchangerEquations);
            this.panelDefaultParmeters.Controls.Add(this.textBoxFValue);
            this.panelDefaultParmeters.Controls.Add(this.textBoxExchangerLabel);
            this.panelDefaultParmeters.Controls.Add(this.textBoxDefaultU_Value);
            this.panelDefaultParmeters.Controls.Add(this.textBoxF);
            this.panelDefaultParmeters.Controls.Add(this.textBoxDefaultU_Units);
            this.panelDefaultParmeters.Controls.Add(this.textBoxDefaultU);
            this.panelDefaultParmeters.Location = new System.Drawing.Point(15, 266);
            this.panelDefaultParmeters.Name = "panelDefaultParmeters";
            this.panelDefaultParmeters.Size = new System.Drawing.Size(352, 113);
            this.panelDefaultParmeters.TabIndex = 37;
            // 
            // textBoxExchangerEquations
            // 
            this.textBoxExchangerEquations.BackColor = System.Drawing.Color.White;
            this.textBoxExchangerEquations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExchangerEquations.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExchangerEquations.ForeColor = System.Drawing.Color.Gray;
            this.textBoxExchangerEquations.Location = new System.Drawing.Point(52, 82);
            this.textBoxExchangerEquations.Name = "textBoxExchangerEquations";
            this.textBoxExchangerEquations.ReadOnly = true;
            this.textBoxExchangerEquations.Size = new System.Drawing.Size(251, 18);
            this.textBoxExchangerEquations.TabIndex = 42;
            this.textBoxExchangerEquations.Text = "Q = U·A·F·LMTD     ...     Q = M·CP·ΔT";
            // 
            // textBoxFValue
            // 
            this.textBoxFValue.BackColor = System.Drawing.Color.White;
            this.textBoxFValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxFValue.Location = new System.Drawing.Point(157, 32);
            this.textBoxFValue.Name = "textBoxFValue";
            this.textBoxFValue.ReadOnly = true;
            this.textBoxFValue.Size = new System.Drawing.Size(57, 18);
            this.textBoxFValue.TabIndex = 35;
            this.textBoxFValue.Text = "0.85";
            this.textBoxFValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExchangerLabel
            // 
            this.textBoxExchangerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExchangerLabel.BackColor = System.Drawing.Color.Yellow;
            this.textBoxExchangerLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExchangerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExchangerLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxExchangerLabel.Location = new System.Drawing.Point(3, 3);
            this.textBoxExchangerLabel.Name = "textBoxExchangerLabel";
            this.textBoxExchangerLabel.ReadOnly = true;
            this.textBoxExchangerLabel.Size = new System.Drawing.Size(346, 22);
            this.textBoxExchangerLabel.TabIndex = 35;
            this.textBoxExchangerLabel.TabStop = false;
            this.textBoxExchangerLabel.Text = "EXCHANGER PARAMETERS";
            this.textBoxExchangerLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDefaultU_Value
            // 
            this.textBoxDefaultU_Value.BackColor = System.Drawing.Color.White;
            this.textBoxDefaultU_Value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDefaultU_Value.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefaultU_Value.ForeColor = System.Drawing.Color.Black;
            this.textBoxDefaultU_Value.Location = new System.Drawing.Point(150, 56);
            this.textBoxDefaultU_Value.Name = "textBoxDefaultU_Value";
            this.textBoxDefaultU_Value.ReadOnly = true;
            this.textBoxDefaultU_Value.Size = new System.Drawing.Size(64, 18);
            this.textBoxDefaultU_Value.TabIndex = 6;
            this.textBoxDefaultU_Value.Text = "74.0";
            this.textBoxDefaultU_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxF
            // 
            this.textBoxF.BackColor = System.Drawing.Color.White;
            this.textBoxF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxF.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxF.Location = new System.Drawing.Point(6, 32);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.ReadOnly = true;
            this.textBoxF.Size = new System.Drawing.Size(145, 18);
            this.textBoxF.TabIndex = 36;
            this.textBoxF.TabStop = false;
            this.textBoxF.Text = "Correction Factor (F): ";
            this.textBoxF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDefaultU_Units
            // 
            this.textBoxDefaultU_Units.BackColor = System.Drawing.Color.White;
            this.textBoxDefaultU_Units.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDefaultU_Units.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefaultU_Units.ForeColor = System.Drawing.Color.Black;
            this.textBoxDefaultU_Units.Location = new System.Drawing.Point(220, 56);
            this.textBoxDefaultU_Units.Name = "textBoxDefaultU_Units";
            this.textBoxDefaultU_Units.ReadOnly = true;
            this.textBoxDefaultU_Units.Size = new System.Drawing.Size(110, 18);
            this.textBoxDefaultU_Units.TabIndex = 31;
            this.textBoxDefaultU_Units.Text = "MMBtu/(hr·ft²·°F )";
            // 
            // textBoxDefaultU
            // 
            this.textBoxDefaultU.BackColor = System.Drawing.Color.White;
            this.textBoxDefaultU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDefaultU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefaultU.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxDefaultU.Location = new System.Drawing.Point(6, 56);
            this.textBoxDefaultU.Name = "textBoxDefaultU";
            this.textBoxDefaultU.ReadOnly = true;
            this.textBoxDefaultU.Size = new System.Drawing.Size(145, 18);
            this.textBoxDefaultU.TabIndex = 30;
            this.textBoxDefaultU.TabStop = false;
            this.textBoxDefaultU.Text = "U: ";
            this.textBoxDefaultU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelProjectUnits
            // 
            this.panelProjectUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProjectUnits.BackColor = System.Drawing.Color.White;
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
            this.panelProjectUnits.Location = new System.Drawing.Point(15, 7);
            this.panelProjectUnits.Name = "panelProjectUnits";
            this.panelProjectUnits.Size = new System.Drawing.Size(352, 245);
            this.panelProjectUnits.TabIndex = 13;
            // 
            // textBoxProjectUnitsPress
            // 
            this.textBoxProjectUnitsPress.BackColor = System.Drawing.Color.White;
            this.textBoxProjectUnitsPress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectUnitsPress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectUnitsPress.ForeColor = System.Drawing.Color.Black;
            this.textBoxProjectUnitsPress.Location = new System.Drawing.Point(116, 98);
            this.textBoxProjectUnitsPress.Name = "textBoxProjectUnitsPress";
            this.textBoxProjectUnitsPress.ReadOnly = true;
            this.textBoxProjectUnitsPress.Size = new System.Drawing.Size(128, 18);
            this.textBoxProjectUnitsPress.TabIndex = 41;
            this.textBoxProjectUnitsPress.Text = "Pa";
            // 
            // textBoxProjectUnitsTemp
            // 
            this.textBoxProjectUnitsTemp.BackColor = System.Drawing.Color.White;
            this.textBoxProjectUnitsTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectUnitsTemp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectUnitsTemp.ForeColor = System.Drawing.Color.Black;
            this.textBoxProjectUnitsTemp.Location = new System.Drawing.Point(116, 78);
            this.textBoxProjectUnitsTemp.Name = "textBoxProjectUnitsTemp";
            this.textBoxProjectUnitsTemp.ReadOnly = true;
            this.textBoxProjectUnitsTemp.Size = new System.Drawing.Size(128, 18);
            this.textBoxProjectUnitsTemp.TabIndex = 40;
            this.textBoxProjectUnitsTemp.Text = "K";
            // 
            // textBoxProjectUnitsMagnitude
            // 
            this.textBoxProjectUnitsMagnitude.BackColor = System.Drawing.Color.White;
            this.textBoxProjectUnitsMagnitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectUnitsMagnitude.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectUnitsMagnitude.ForeColor = System.Drawing.Color.Black;
            this.textBoxProjectUnitsMagnitude.Location = new System.Drawing.Point(116, 58);
            this.textBoxProjectUnitsMagnitude.Name = "textBoxProjectUnitsMagnitude";
            this.textBoxProjectUnitsMagnitude.ReadOnly = true;
            this.textBoxProjectUnitsMagnitude.Size = new System.Drawing.Size(128, 18);
            this.textBoxProjectUnitsMagnitude.TabIndex = 39;
            this.textBoxProjectUnitsMagnitude.Text = "BASE";
            // 
            // textBoxProjectUnitsSystem
            // 
            this.textBoxProjectUnitsSystem.BackColor = System.Drawing.Color.White;
            this.textBoxProjectUnitsSystem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectUnitsSystem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectUnitsSystem.ForeColor = System.Drawing.Color.Black;
            this.textBoxProjectUnitsSystem.Location = new System.Drawing.Point(116, 38);
            this.textBoxProjectUnitsSystem.Name = "textBoxProjectUnitsSystem";
            this.textBoxProjectUnitsSystem.ReadOnly = true;
            this.textBoxProjectUnitsSystem.Size = new System.Drawing.Size(128, 18);
            this.textBoxProjectUnitsSystem.TabIndex = 38;
            this.textBoxProjectUnitsSystem.Text = "English - Imperial";
            // 
            // textBoxUnitsTitle
            // 
            this.textBoxUnitsTitle.BackColor = System.Drawing.Color.Yellow;
            this.textBoxUnitsTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxUnitsTitle.Location = new System.Drawing.Point(3, 4);
            this.textBoxUnitsTitle.Name = "textBoxUnitsTitle";
            this.textBoxUnitsTitle.ReadOnly = true;
            this.textBoxUnitsTitle.Size = new System.Drawing.Size(346, 22);
            this.textBoxUnitsTitle.TabIndex = 32;
            this.textBoxUnitsTitle.Text = "PROJECT UNITS";
            this.textBoxUnitsTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUDefinition
            // 
            this.textBoxUDefinition.BackColor = System.Drawing.Color.White;
            this.textBoxUDefinition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUDefinition.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUDefinition.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUDefinition.Location = new System.Drawing.Point(84, 217);
            this.textBoxUDefinition.Name = "textBoxUDefinition";
            this.textBoxUDefinition.ReadOnly = true;
            this.textBoxUDefinition.Size = new System.Drawing.Size(251, 18);
            this.textBoxUDefinition.TabIndex = 31;
            this.textBoxUDefinition.Text = "[ U ... Heat Transfer Coefficient ]";
            // 
            // textBoxUnitsUValue
            // 
            this.textBoxUnitsUValue.BackColor = System.Drawing.Color.White;
            this.textBoxUnitsUValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsUValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsUValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxUnitsUValue.Location = new System.Drawing.Point(116, 198);
            this.textBoxUnitsUValue.Name = "textBoxUnitsUValue";
            this.textBoxUnitsUValue.ReadOnly = true;
            this.textBoxUnitsUValue.Size = new System.Drawing.Size(128, 18);
            this.textBoxUnitsUValue.TabIndex = 30;
            this.textBoxUnitsUValue.Text = "MMBtu/hr·ft²·°F ";
            // 
            // textBoxUnitsU
            // 
            this.textBoxUnitsU.BackColor = System.Drawing.Color.White;
            this.textBoxUnitsU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsU.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxUnitsU.Location = new System.Drawing.Point(10, 198);
            this.textBoxUnitsU.Name = "textBoxUnitsU";
            this.textBoxUnitsU.ReadOnly = true;
            this.textBoxUnitsU.Size = new System.Drawing.Size(96, 18);
            this.textBoxUnitsU.TabIndex = 29;
            this.textBoxUnitsU.Text = "U: ";
            this.textBoxUnitsU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxUnitsCPValue
            // 
            this.textBoxUnitsCPValue.BackColor = System.Drawing.Color.White;
            this.textBoxUnitsCPValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsCPValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsCPValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxUnitsCPValue.Location = new System.Drawing.Point(116, 158);
            this.textBoxUnitsCPValue.Name = "textBoxUnitsCPValue";
            this.textBoxUnitsCPValue.ReadOnly = true;
            this.textBoxUnitsCPValue.Size = new System.Drawing.Size(128, 18);
            this.textBoxUnitsCPValue.TabIndex = 28;
            this.textBoxUnitsCPValue.Text = "MMBtu/(hr °F)";
            // 
            // textBoxCPDefinition
            // 
            this.textBoxCPDefinition.BackColor = System.Drawing.Color.White;
            this.textBoxCPDefinition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCPDefinition.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCPDefinition.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCPDefinition.Location = new System.Drawing.Point(77, 177);
            this.textBoxCPDefinition.Name = "textBoxCPDefinition";
            this.textBoxCPDefinition.ReadOnly = true;
            this.textBoxCPDefinition.Size = new System.Drawing.Size(251, 18);
            this.textBoxCPDefinition.TabIndex = 27;
            this.textBoxCPDefinition.Text = "[ CP ... Heat Capacity Flow Rate (m * Cp) ]";
            // 
            // textBoxUnitsCP
            // 
            this.textBoxUnitsCP.BackColor = System.Drawing.Color.White;
            this.textBoxUnitsCP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsCP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsCP.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxUnitsCP.Location = new System.Drawing.Point(10, 158);
            this.textBoxUnitsCP.Name = "textBoxUnitsCP";
            this.textBoxUnitsCP.ReadOnly = true;
            this.textBoxUnitsCP.Size = new System.Drawing.Size(96, 18);
            this.textBoxUnitsCP.TabIndex = 26;
            this.textBoxUnitsCP.Text = "CP: ";
            this.textBoxUnitsCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxUnitsDutyValue
            // 
            this.textBoxUnitsDutyValue.BackColor = System.Drawing.Color.White;
            this.textBoxUnitsDutyValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsDutyValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsDutyValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxUnitsDutyValue.Location = new System.Drawing.Point(116, 138);
            this.textBoxUnitsDutyValue.Name = "textBoxUnitsDutyValue";
            this.textBoxUnitsDutyValue.ReadOnly = true;
            this.textBoxUnitsDutyValue.Size = new System.Drawing.Size(128, 18);
            this.textBoxUnitsDutyValue.TabIndex = 25;
            this.textBoxUnitsDutyValue.Text = "MMBtu/hr";
            // 
            // textBoxUnitsDuty
            // 
            this.textBoxUnitsDuty.BackColor = System.Drawing.Color.White;
            this.textBoxUnitsDuty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsDuty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsDuty.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxUnitsDuty.Location = new System.Drawing.Point(10, 138);
            this.textBoxUnitsDuty.Name = "textBoxUnitsDuty";
            this.textBoxUnitsDuty.ReadOnly = true;
            this.textBoxUnitsDuty.Size = new System.Drawing.Size(96, 18);
            this.textBoxUnitsDuty.TabIndex = 24;
            this.textBoxUnitsDuty.Text = "Duty: ";
            this.textBoxUnitsDuty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxUnitsAreaValue
            // 
            this.textBoxUnitsAreaValue.BackColor = System.Drawing.Color.White;
            this.textBoxUnitsAreaValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsAreaValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsAreaValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxUnitsAreaValue.Location = new System.Drawing.Point(116, 118);
            this.textBoxUnitsAreaValue.Name = "textBoxUnitsAreaValue";
            this.textBoxUnitsAreaValue.ReadOnly = true;
            this.textBoxUnitsAreaValue.Size = new System.Drawing.Size(128, 18);
            this.textBoxUnitsAreaValue.TabIndex = 23;
            this.textBoxUnitsAreaValue.Text = "ft²";
            // 
            // textBoxUnitsArea
            // 
            this.textBoxUnitsArea.BackColor = System.Drawing.Color.White;
            this.textBoxUnitsArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsArea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsArea.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxUnitsArea.Location = new System.Drawing.Point(10, 118);
            this.textBoxUnitsArea.Name = "textBoxUnitsArea";
            this.textBoxUnitsArea.ReadOnly = true;
            this.textBoxUnitsArea.Size = new System.Drawing.Size(96, 18);
            this.textBoxUnitsArea.TabIndex = 22;
            this.textBoxUnitsArea.Text = "Area: ";
            this.textBoxUnitsArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxUnitsPress
            // 
            this.textBoxUnitsPress.BackColor = System.Drawing.Color.White;
            this.textBoxUnitsPress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsPress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsPress.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxUnitsPress.Location = new System.Drawing.Point(10, 98);
            this.textBoxUnitsPress.Name = "textBoxUnitsPress";
            this.textBoxUnitsPress.ReadOnly = true;
            this.textBoxUnitsPress.Size = new System.Drawing.Size(96, 18);
            this.textBoxUnitsPress.TabIndex = 20;
            this.textBoxUnitsPress.Text = "Pressure: ";
            this.textBoxUnitsPress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxUnitsTemp
            // 
            this.textBoxUnitsTemp.BackColor = System.Drawing.Color.White;
            this.textBoxUnitsTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsTemp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsTemp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxUnitsTemp.Location = new System.Drawing.Point(10, 78);
            this.textBoxUnitsTemp.Name = "textBoxUnitsTemp";
            this.textBoxUnitsTemp.ReadOnly = true;
            this.textBoxUnitsTemp.Size = new System.Drawing.Size(96, 18);
            this.textBoxUnitsTemp.TabIndex = 18;
            this.textBoxUnitsTemp.Text = "Temperature: ";
            this.textBoxUnitsTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxUnitsMagnitude
            // 
            this.textBoxUnitsMagnitude.BackColor = System.Drawing.Color.White;
            this.textBoxUnitsMagnitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsMagnitude.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsMagnitude.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxUnitsMagnitude.Location = new System.Drawing.Point(10, 58);
            this.textBoxUnitsMagnitude.Name = "textBoxUnitsMagnitude";
            this.textBoxUnitsMagnitude.ReadOnly = true;
            this.textBoxUnitsMagnitude.Size = new System.Drawing.Size(96, 18);
            this.textBoxUnitsMagnitude.TabIndex = 16;
            this.textBoxUnitsMagnitude.Text = "Magnitude: ";
            this.textBoxUnitsMagnitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBoxUnitsSystem
            // 
            this.pictureBoxUnitsSystem.BackColor = System.Drawing.Color.White;
            this.pictureBoxUnitsSystem.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnitsSystem.Image")));
            this.pictureBoxUnitsSystem.Location = new System.Drawing.Point(253, 35);
            this.pictureBoxUnitsSystem.Name = "pictureBoxUnitsSystem";
            this.pictureBoxUnitsSystem.Size = new System.Drawing.Size(50, 47);
            this.pictureBoxUnitsSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUnitsSystem.TabIndex = 15;
            this.pictureBoxUnitsSystem.TabStop = false;
            // 
            // textBoxUnitsSystem
            // 
            this.textBoxUnitsSystem.BackColor = System.Drawing.Color.White;
            this.textBoxUnitsSystem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitsSystem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitsSystem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxUnitsSystem.Location = new System.Drawing.Point(10, 38);
            this.textBoxUnitsSystem.Name = "textBoxUnitsSystem";
            this.textBoxUnitsSystem.ReadOnly = true;
            this.textBoxUnitsSystem.Size = new System.Drawing.Size(96, 18);
            this.textBoxUnitsSystem.TabIndex = 14;
            this.textBoxUnitsSystem.Text = "System Units: ";
            this.textBoxUnitsSystem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelDefaultHenOptimizer
            // 
            this.panelDefaultHenOptimizer.BackColor = System.Drawing.Color.White;
            this.panelDefaultHenOptimizer.Controls.Add(this.textBoxOptimizerConvergToler);
            this.panelDefaultHenOptimizer.Controls.Add(this.textBoxOptimizerMaxIterValue);
            this.panelDefaultHenOptimizer.Controls.Add(this.textBoxOptimizerObjectiveValue);
            this.panelDefaultHenOptimizer.Controls.Add(this.textBoxOptimzerTypeValue);
            this.panelDefaultHenOptimizer.Controls.Add(this.textBoxOptimizerDescriptionValue);
            this.panelDefaultHenOptimizer.Controls.Add(this.textBoxOptimizerNameValue);
            this.panelDefaultHenOptimizer.Controls.Add(this.textBoxOptimizerDescription);
            this.panelDefaultHenOptimizer.Controls.Add(this.textBoxOptimizerConvergTolerance);
            this.panelDefaultHenOptimizer.Controls.Add(this.textBoxOptimizerMaxInter);
            this.panelDefaultHenOptimizer.Controls.Add(this.textBoxOptimizerObjective);
            this.panelDefaultHenOptimizer.Controls.Add(this.textBoxOptimizerType);
            this.panelDefaultHenOptimizer.Controls.Add(this.textBoxOptimizerName);
            this.panelDefaultHenOptimizer.Controls.Add(this.textBoxDefaultStudyOptimizerTitle);
            this.panelDefaultHenOptimizer.Location = new System.Drawing.Point(379, 7);
            this.panelDefaultHenOptimizer.Name = "panelDefaultHenOptimizer";
            this.panelDefaultHenOptimizer.Size = new System.Drawing.Size(508, 156);
            this.panelDefaultHenOptimizer.TabIndex = 18;
            // 
            // textBoxOptimizerConvergToler
            // 
            this.textBoxOptimizerConvergToler.BackColor = System.Drawing.Color.White;
            this.textBoxOptimizerConvergToler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOptimizerConvergToler.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptimizerConvergToler.ForeColor = System.Drawing.Color.Black;
            this.textBoxOptimizerConvergToler.Location = new System.Drawing.Point(332, 132);
            this.textBoxOptimizerConvergToler.Name = "textBoxOptimizerConvergToler";
            this.textBoxOptimizerConvergToler.ReadOnly = true;
            this.textBoxOptimizerConvergToler.Size = new System.Drawing.Size(57, 18);
            this.textBoxOptimizerConvergToler.TabIndex = 50;
            this.textBoxOptimizerConvergToler.Text = "0.001";
            // 
            // textBoxOptimizerMaxIterValue
            // 
            this.textBoxOptimizerMaxIterValue.BackColor = System.Drawing.Color.White;
            this.textBoxOptimizerMaxIterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOptimizerMaxIterValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptimizerMaxIterValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxOptimizerMaxIterValue.Location = new System.Drawing.Point(112, 134);
            this.textBoxOptimizerMaxIterValue.Name = "textBoxOptimizerMaxIterValue";
            this.textBoxOptimizerMaxIterValue.ReadOnly = true;
            this.textBoxOptimizerMaxIterValue.Size = new System.Drawing.Size(57, 18);
            this.textBoxOptimizerMaxIterValue.TabIndex = 37;
            this.textBoxOptimizerMaxIterValue.Text = "100";
            // 
            // textBoxOptimizerObjectiveValue
            // 
            this.textBoxOptimizerObjectiveValue.BackColor = System.Drawing.Color.White;
            this.textBoxOptimizerObjectiveValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOptimizerObjectiveValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptimizerObjectiveValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxOptimizerObjectiveValue.Location = new System.Drawing.Point(112, 113);
            this.textBoxOptimizerObjectiveValue.Name = "textBoxOptimizerObjectiveValue";
            this.textBoxOptimizerObjectiveValue.ReadOnly = true;
            this.textBoxOptimizerObjectiveValue.Size = new System.Drawing.Size(386, 18);
            this.textBoxOptimizerObjectiveValue.TabIndex = 49;
            this.textBoxOptimizerObjectiveValue.Text = "Total Annualized Cost Optimization";
            // 
            // textBoxOptimzerTypeValue
            // 
            this.textBoxOptimzerTypeValue.BackColor = System.Drawing.Color.White;
            this.textBoxOptimzerTypeValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOptimzerTypeValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptimzerTypeValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxOptimzerTypeValue.Location = new System.Drawing.Point(112, 91);
            this.textBoxOptimzerTypeValue.Name = "textBoxOptimzerTypeValue";
            this.textBoxOptimzerTypeValue.ReadOnly = true;
            this.textBoxOptimzerTypeValue.Size = new System.Drawing.Size(386, 18);
            this.textBoxOptimzerTypeValue.TabIndex = 48;
            this.textBoxOptimzerTypeValue.Text = "MILP";
            // 
            // textBoxOptimizerDescriptionValue
            // 
            this.textBoxOptimizerDescriptionValue.BackColor = System.Drawing.Color.White;
            this.textBoxOptimizerDescriptionValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOptimizerDescriptionValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptimizerDescriptionValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxOptimizerDescriptionValue.Location = new System.Drawing.Point(112, 49);
            this.textBoxOptimizerDescriptionValue.Multiline = true;
            this.textBoxOptimizerDescriptionValue.Name = "textBoxOptimizerDescriptionValue";
            this.textBoxOptimizerDescriptionValue.ReadOnly = true;
            this.textBoxOptimizerDescriptionValue.Size = new System.Drawing.Size(386, 38);
            this.textBoxOptimizerDescriptionValue.TabIndex = 42;
            this.textBoxOptimizerDescriptionValue.Text = "MILP Solver\r\nCommercial Optimizer";
            // 
            // textBoxOptimizerNameValue
            // 
            this.textBoxOptimizerNameValue.BackColor = System.Drawing.Color.White;
            this.textBoxOptimizerNameValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOptimizerNameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptimizerNameValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxOptimizerNameValue.Location = new System.Drawing.Point(112, 29);
            this.textBoxOptimizerNameValue.Name = "textBoxOptimizerNameValue";
            this.textBoxOptimizerNameValue.ReadOnly = true;
            this.textBoxOptimizerNameValue.Size = new System.Drawing.Size(386, 18);
            this.textBoxOptimizerNameValue.TabIndex = 42;
            this.textBoxOptimizerNameValue.Text = "Gurobi";
            // 
            // textBoxOptimizerDescription
            // 
            this.textBoxOptimizerDescription.BackColor = System.Drawing.Color.White;
            this.textBoxOptimizerDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOptimizerDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptimizerDescription.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxOptimizerDescription.Location = new System.Drawing.Point(3, 47);
            this.textBoxOptimizerDescription.Name = "textBoxOptimizerDescription";
            this.textBoxOptimizerDescription.ReadOnly = true;
            this.textBoxOptimizerDescription.Size = new System.Drawing.Size(103, 18);
            this.textBoxOptimizerDescription.TabIndex = 47;
            this.textBoxOptimizerDescription.Text = "Description: ";
            this.textBoxOptimizerDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxOptimizerConvergTolerance
            // 
            this.textBoxOptimizerConvergTolerance.BackColor = System.Drawing.Color.White;
            this.textBoxOptimizerConvergTolerance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOptimizerConvergTolerance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptimizerConvergTolerance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxOptimizerConvergTolerance.Location = new System.Drawing.Point(169, 132);
            this.textBoxOptimizerConvergTolerance.Name = "textBoxOptimizerConvergTolerance";
            this.textBoxOptimizerConvergTolerance.ReadOnly = true;
            this.textBoxOptimizerConvergTolerance.Size = new System.Drawing.Size(157, 18);
            this.textBoxOptimizerConvergTolerance.TabIndex = 46;
            this.textBoxOptimizerConvergTolerance.Text = "Convergence Tolerance: ";
            this.textBoxOptimizerConvergTolerance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxOptimizerMaxInter
            // 
            this.textBoxOptimizerMaxInter.BackColor = System.Drawing.Color.White;
            this.textBoxOptimizerMaxInter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOptimizerMaxInter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptimizerMaxInter.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxOptimizerMaxInter.Location = new System.Drawing.Point(10, 132);
            this.textBoxOptimizerMaxInter.Name = "textBoxOptimizerMaxInter";
            this.textBoxOptimizerMaxInter.ReadOnly = true;
            this.textBoxOptimizerMaxInter.Size = new System.Drawing.Size(96, 18);
            this.textBoxOptimizerMaxInter.TabIndex = 45;
            this.textBoxOptimizerMaxInter.Text = "Max Iterations: : ";
            this.textBoxOptimizerMaxInter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxOptimizerObjective
            // 
            this.textBoxOptimizerObjective.BackColor = System.Drawing.Color.White;
            this.textBoxOptimizerObjective.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOptimizerObjective.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptimizerObjective.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxOptimizerObjective.Location = new System.Drawing.Point(10, 111);
            this.textBoxOptimizerObjective.Name = "textBoxOptimizerObjective";
            this.textBoxOptimizerObjective.ReadOnly = true;
            this.textBoxOptimizerObjective.Size = new System.Drawing.Size(96, 18);
            this.textBoxOptimizerObjective.TabIndex = 44;
            this.textBoxOptimizerObjective.Text = "Objective: ";
            this.textBoxOptimizerObjective.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxOptimizerType
            // 
            this.textBoxOptimizerType.BackColor = System.Drawing.Color.White;
            this.textBoxOptimizerType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOptimizerType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptimizerType.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxOptimizerType.Location = new System.Drawing.Point(10, 91);
            this.textBoxOptimizerType.Name = "textBoxOptimizerType";
            this.textBoxOptimizerType.ReadOnly = true;
            this.textBoxOptimizerType.Size = new System.Drawing.Size(96, 18);
            this.textBoxOptimizerType.TabIndex = 43;
            this.textBoxOptimizerType.Text = "Type: ";
            this.textBoxOptimizerType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxOptimizerName
            // 
            this.textBoxOptimizerName.BackColor = System.Drawing.Color.White;
            this.textBoxOptimizerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOptimizerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptimizerName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxOptimizerName.Location = new System.Drawing.Point(10, 29);
            this.textBoxOptimizerName.Name = "textBoxOptimizerName";
            this.textBoxOptimizerName.ReadOnly = true;
            this.textBoxOptimizerName.Size = new System.Drawing.Size(96, 18);
            this.textBoxOptimizerName.TabIndex = 42;
            this.textBoxOptimizerName.Text = "Name: ";
            this.textBoxOptimizerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDefaultStudyOptimizerTitle
            // 
            this.textBoxDefaultStudyOptimizerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultStudyOptimizerTitle.BackColor = System.Drawing.Color.Yellow;
            this.textBoxDefaultStudyOptimizerTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDefaultStudyOptimizerTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefaultStudyOptimizerTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxDefaultStudyOptimizerTitle.Location = new System.Drawing.Point(3, 3);
            this.textBoxDefaultStudyOptimizerTitle.Name = "textBoxDefaultStudyOptimizerTitle";
            this.textBoxDefaultStudyOptimizerTitle.ReadOnly = true;
            this.textBoxDefaultStudyOptimizerTitle.Size = new System.Drawing.Size(502, 22);
            this.textBoxDefaultStudyOptimizerTitle.TabIndex = 34;
            this.textBoxDefaultStudyOptimizerTitle.TabStop = false;
            this.textBoxDefaultStudyOptimizerTitle.Text = "STUDY OPTIMIZER";
            this.textBoxDefaultStudyOptimizerTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPageCostParams
            // 
            this.tabPageCostParams.BackColor = System.Drawing.Color.Honeydew;
            this.tabPageCostParams.Controls.Add(this.pictureBoxCostEq);
            this.tabPageCostParams.Controls.Add(this.panelUtilityCost);
            this.tabPageCostParams.Controls.Add(this.panelTotalAnnualizedCost);
            this.tabPageCostParams.Controls.Add(this.panelShellAndTubeCapitalCost);
            this.tabPageCostParams.Controls.Add(this.panelFiredHeaterCapitalCost);
            this.tabPageCostParams.Controls.Add(this.panelCostMetadata);
            this.tabPageCostParams.Location = new System.Drawing.Point(4, 39);
            this.tabPageCostParams.Name = "tabPageCostParams";
            this.tabPageCostParams.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCostParams.Size = new System.Drawing.Size(903, 385);
            this.tabPageCostParams.TabIndex = 1;
            this.tabPageCostParams.Text = "  Project Cost Settings  ";
            // 
            // pictureBoxCostEq
            // 
            this.pictureBoxCostEq.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxCostEq.Image = global::HenStudio.Properties.Resources.CapitalCostEquations;
            this.pictureBoxCostEq.Location = new System.Drawing.Point(281, 230);
            this.pictureBoxCostEq.Name = "pictureBoxCostEq";
            this.pictureBoxCostEq.Size = new System.Drawing.Size(286, 133);
            this.pictureBoxCostEq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCostEq.TabIndex = 50;
            this.pictureBoxCostEq.TabStop = false;
            // 
            // panelUtilityCost
            // 
            this.panelUtilityCost.BackColor = System.Drawing.Color.White;
            this.panelUtilityCost.Controls.Add(this.textBoxUtilityCostUnits_ENGLISH);
            this.panelUtilityCost.Controls.Add(this.textBoxUtilityCostUnits);
            this.panelUtilityCost.Controls.Add(this.textBoxUtilityCostUnits_METRIC);
            this.panelUtilityCost.Controls.Add(this.textBoxEnglish_HEADER);
            this.panelUtilityCost.Controls.Add(this.textBoxMetric_HEADER);
            this.panelUtilityCost.Controls.Add(this.textBoxChilledWater_ENGLISH);
            this.panelUtilityCost.Controls.Add(this.textBoxFuelGas_ENGLISH);
            this.panelUtilityCost.Controls.Add(this.textBoxCoolingWater_ENGLISH);
            this.panelUtilityCost.Controls.Add(this.textBoxLP_Steam_ENGLISH);
            this.panelUtilityCost.Controls.Add(this.textBoxMP_Steam_ENGLISH);
            this.panelUtilityCost.Controls.Add(this.textBoxHP_Steam_ENGLISH);
            this.panelUtilityCost.Controls.Add(this.textBoxChilledWater);
            this.panelUtilityCost.Controls.Add(this.textBoxChilledWater_METRIC);
            this.panelUtilityCost.Controls.Add(this.textBoxFuelGas);
            this.panelUtilityCost.Controls.Add(this.textBoxFuelGas_METRIC);
            this.panelUtilityCost.Controls.Add(this.textBoxCoolingWater);
            this.panelUtilityCost.Controls.Add(this.textBoxCoolingWater_METRIC);
            this.panelUtilityCost.Controls.Add(this.textBoxLP_Steam);
            this.panelUtilityCost.Controls.Add(this.textBoxLP_Steam_METRIC);
            this.panelUtilityCost.Controls.Add(this.textBoxMP_Steam);
            this.panelUtilityCost.Controls.Add(this.textBoxMP_Steam_METRIC);
            this.panelUtilityCost.Controls.Add(this.textBoxHP_Steam);
            this.panelUtilityCost.Controls.Add(this.textBoxHP_Steam_METRIC);
            this.panelUtilityCost.Controls.Add(this.textBoxUtitlityCost_TITLE);
            this.panelUtilityCost.Location = new System.Drawing.Point(572, 5);
            this.panelUtilityCost.Name = "panelUtilityCost";
            this.panelUtilityCost.Size = new System.Drawing.Size(325, 218);
            this.panelUtilityCost.TabIndex = 49;
            // 
            // textBoxUtilityCostUnits_ENGLISH
            // 
            this.textBoxUtilityCostUnits_ENGLISH.BackColor = System.Drawing.Color.White;
            this.textBoxUtilityCostUnits_ENGLISH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUtilityCostUnits_ENGLISH.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUtilityCostUnits_ENGLISH.ForeColor = System.Drawing.Color.Black;
            this.textBoxUtilityCostUnits_ENGLISH.Location = new System.Drawing.Point(215, 191);
            this.textBoxUtilityCostUnits_ENGLISH.Name = "textBoxUtilityCostUnits_ENGLISH";
            this.textBoxUtilityCostUnits_ENGLISH.ReadOnly = true;
            this.textBoxUtilityCostUnits_ENGLISH.Size = new System.Drawing.Size(75, 18);
            this.textBoxUtilityCostUnits_ENGLISH.TabIndex = 59;
            this.textBoxUtilityCostUnits_ENGLISH.Text = "$/MMBtu";
            this.textBoxUtilityCostUnits_ENGLISH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUtilityCostUnits
            // 
            this.textBoxUtilityCostUnits.BackColor = System.Drawing.Color.White;
            this.textBoxUtilityCostUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUtilityCostUnits.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUtilityCostUnits.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxUtilityCostUnits.Location = new System.Drawing.Point(25, 191);
            this.textBoxUtilityCostUnits.Name = "textBoxUtilityCostUnits";
            this.textBoxUtilityCostUnits.ReadOnly = true;
            this.textBoxUtilityCostUnits.Size = new System.Drawing.Size(103, 18);
            this.textBoxUtilityCostUnits.TabIndex = 58;
            this.textBoxUtilityCostUnits.Text = "Units: ";
            this.textBoxUtilityCostUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxUtilityCostUnits_METRIC
            // 
            this.textBoxUtilityCostUnits_METRIC.BackColor = System.Drawing.Color.White;
            this.textBoxUtilityCostUnits_METRIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUtilityCostUnits_METRIC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUtilityCostUnits_METRIC.ForeColor = System.Drawing.Color.Black;
            this.textBoxUtilityCostUnits_METRIC.Location = new System.Drawing.Point(134, 191);
            this.textBoxUtilityCostUnits_METRIC.Name = "textBoxUtilityCostUnits_METRIC";
            this.textBoxUtilityCostUnits_METRIC.ReadOnly = true;
            this.textBoxUtilityCostUnits_METRIC.Size = new System.Drawing.Size(75, 18);
            this.textBoxUtilityCostUnits_METRIC.TabIndex = 57;
            this.textBoxUtilityCostUnits_METRIC.Text = "$/MWh";
            this.textBoxUtilityCostUnits_METRIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEnglish_HEADER
            // 
            this.textBoxEnglish_HEADER.BackColor = System.Drawing.Color.Azure;
            this.textBoxEnglish_HEADER.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEnglish_HEADER.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnglish_HEADER.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxEnglish_HEADER.Location = new System.Drawing.Point(215, 27);
            this.textBoxEnglish_HEADER.Name = "textBoxEnglish_HEADER";
            this.textBoxEnglish_HEADER.ReadOnly = true;
            this.textBoxEnglish_HEADER.Size = new System.Drawing.Size(75, 18);
            this.textBoxEnglish_HEADER.TabIndex = 56;
            this.textBoxEnglish_HEADER.Text = "ENGLISH";
            this.textBoxEnglish_HEADER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMetric_HEADER
            // 
            this.textBoxMetric_HEADER.BackColor = System.Drawing.Color.Azure;
            this.textBoxMetric_HEADER.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMetric_HEADER.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMetric_HEADER.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxMetric_HEADER.Location = new System.Drawing.Point(134, 27);
            this.textBoxMetric_HEADER.Name = "textBoxMetric_HEADER";
            this.textBoxMetric_HEADER.ReadOnly = true;
            this.textBoxMetric_HEADER.Size = new System.Drawing.Size(75, 18);
            this.textBoxMetric_HEADER.TabIndex = 55;
            this.textBoxMetric_HEADER.Text = "METRIC";
            this.textBoxMetric_HEADER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxChilledWater_ENGLISH
            // 
            this.textBoxChilledWater_ENGLISH.BackColor = System.Drawing.Color.White;
            this.textBoxChilledWater_ENGLISH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChilledWater_ENGLISH.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChilledWater_ENGLISH.ForeColor = System.Drawing.Color.Black;
            this.textBoxChilledWater_ENGLISH.Location = new System.Drawing.Point(215, 143);
            this.textBoxChilledWater_ENGLISH.Name = "textBoxChilledWater_ENGLISH";
            this.textBoxChilledWater_ENGLISH.ReadOnly = true;
            this.textBoxChilledWater_ENGLISH.Size = new System.Drawing.Size(75, 18);
            this.textBoxChilledWater_ENGLISH.TabIndex = 54;
            this.textBoxChilledWater_ENGLISH.Text = "20.00";
            this.textBoxChilledWater_ENGLISH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFuelGas_ENGLISH
            // 
            this.textBoxFuelGas_ENGLISH.BackColor = System.Drawing.Color.White;
            this.textBoxFuelGas_ENGLISH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFuelGas_ENGLISH.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFuelGas_ENGLISH.ForeColor = System.Drawing.Color.Black;
            this.textBoxFuelGas_ENGLISH.Location = new System.Drawing.Point(215, 167);
            this.textBoxFuelGas_ENGLISH.Name = "textBoxFuelGas_ENGLISH";
            this.textBoxFuelGas_ENGLISH.ReadOnly = true;
            this.textBoxFuelGas_ENGLISH.Size = new System.Drawing.Size(75, 18);
            this.textBoxFuelGas_ENGLISH.TabIndex = 53;
            this.textBoxFuelGas_ENGLISH.Text = "6.00";
            this.textBoxFuelGas_ENGLISH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCoolingWater_ENGLISH
            // 
            this.textBoxCoolingWater_ENGLISH.BackColor = System.Drawing.Color.White;
            this.textBoxCoolingWater_ENGLISH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCoolingWater_ENGLISH.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCoolingWater_ENGLISH.ForeColor = System.Drawing.Color.Black;
            this.textBoxCoolingWater_ENGLISH.Location = new System.Drawing.Point(215, 119);
            this.textBoxCoolingWater_ENGLISH.Name = "textBoxCoolingWater_ENGLISH";
            this.textBoxCoolingWater_ENGLISH.ReadOnly = true;
            this.textBoxCoolingWater_ENGLISH.Size = new System.Drawing.Size(75, 18);
            this.textBoxCoolingWater_ENGLISH.TabIndex = 52;
            this.textBoxCoolingWater_ENGLISH.Text = "0.10";
            this.textBoxCoolingWater_ENGLISH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLP_Steam_ENGLISH
            // 
            this.textBoxLP_Steam_ENGLISH.BackColor = System.Drawing.Color.White;
            this.textBoxLP_Steam_ENGLISH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLP_Steam_ENGLISH.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLP_Steam_ENGLISH.ForeColor = System.Drawing.Color.Black;
            this.textBoxLP_Steam_ENGLISH.Location = new System.Drawing.Point(215, 95);
            this.textBoxLP_Steam_ENGLISH.Name = "textBoxLP_Steam_ENGLISH";
            this.textBoxLP_Steam_ENGLISH.ReadOnly = true;
            this.textBoxLP_Steam_ENGLISH.Size = new System.Drawing.Size(75, 18);
            this.textBoxLP_Steam_ENGLISH.TabIndex = 51;
            this.textBoxLP_Steam_ENGLISH.Text = "8.00";
            this.textBoxLP_Steam_ENGLISH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMP_Steam_ENGLISH
            // 
            this.textBoxMP_Steam_ENGLISH.BackColor = System.Drawing.Color.White;
            this.textBoxMP_Steam_ENGLISH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMP_Steam_ENGLISH.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMP_Steam_ENGLISH.ForeColor = System.Drawing.Color.Black;
            this.textBoxMP_Steam_ENGLISH.Location = new System.Drawing.Point(215, 71);
            this.textBoxMP_Steam_ENGLISH.Name = "textBoxMP_Steam_ENGLISH";
            this.textBoxMP_Steam_ENGLISH.ReadOnly = true;
            this.textBoxMP_Steam_ENGLISH.Size = new System.Drawing.Size(75, 18);
            this.textBoxMP_Steam_ENGLISH.TabIndex = 50;
            this.textBoxMP_Steam_ENGLISH.Text = "10.00";
            this.textBoxMP_Steam_ENGLISH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHP_Steam_ENGLISH
            // 
            this.textBoxHP_Steam_ENGLISH.BackColor = System.Drawing.Color.White;
            this.textBoxHP_Steam_ENGLISH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHP_Steam_ENGLISH.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHP_Steam_ENGLISH.ForeColor = System.Drawing.Color.Black;
            this.textBoxHP_Steam_ENGLISH.Location = new System.Drawing.Point(215, 47);
            this.textBoxHP_Steam_ENGLISH.Name = "textBoxHP_Steam_ENGLISH";
            this.textBoxHP_Steam_ENGLISH.ReadOnly = true;
            this.textBoxHP_Steam_ENGLISH.Size = new System.Drawing.Size(75, 18);
            this.textBoxHP_Steam_ENGLISH.TabIndex = 49;
            this.textBoxHP_Steam_ENGLISH.Text = "12.00";
            this.textBoxHP_Steam_ENGLISH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxChilledWater
            // 
            this.textBoxChilledWater.BackColor = System.Drawing.Color.White;
            this.textBoxChilledWater.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChilledWater.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChilledWater.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxChilledWater.Location = new System.Drawing.Point(25, 143);
            this.textBoxChilledWater.Name = "textBoxChilledWater";
            this.textBoxChilledWater.ReadOnly = true;
            this.textBoxChilledWater.Size = new System.Drawing.Size(103, 18);
            this.textBoxChilledWater.TabIndex = 48;
            this.textBoxChilledWater.Text = "Chilled Water: ";
            this.textBoxChilledWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxChilledWater_METRIC
            // 
            this.textBoxChilledWater_METRIC.BackColor = System.Drawing.Color.White;
            this.textBoxChilledWater_METRIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChilledWater_METRIC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChilledWater_METRIC.ForeColor = System.Drawing.Color.Black;
            this.textBoxChilledWater_METRIC.Location = new System.Drawing.Point(134, 143);
            this.textBoxChilledWater_METRIC.Name = "textBoxChilledWater_METRIC";
            this.textBoxChilledWater_METRIC.ReadOnly = true;
            this.textBoxChilledWater_METRIC.Size = new System.Drawing.Size(75, 18);
            this.textBoxChilledWater_METRIC.TabIndex = 47;
            this.textBoxChilledWater_METRIC.Text = "68.24";
            this.textBoxChilledWater_METRIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFuelGas
            // 
            this.textBoxFuelGas.BackColor = System.Drawing.Color.White;
            this.textBoxFuelGas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFuelGas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFuelGas.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxFuelGas.Location = new System.Drawing.Point(25, 167);
            this.textBoxFuelGas.Name = "textBoxFuelGas";
            this.textBoxFuelGas.ReadOnly = true;
            this.textBoxFuelGas.Size = new System.Drawing.Size(103, 18);
            this.textBoxFuelGas.TabIndex = 44;
            this.textBoxFuelGas.Text = "Fuel Gas:  ";
            this.textBoxFuelGas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxFuelGas_METRIC
            // 
            this.textBoxFuelGas_METRIC.BackColor = System.Drawing.Color.White;
            this.textBoxFuelGas_METRIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFuelGas_METRIC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFuelGas_METRIC.ForeColor = System.Drawing.Color.Black;
            this.textBoxFuelGas_METRIC.Location = new System.Drawing.Point(134, 167);
            this.textBoxFuelGas_METRIC.Name = "textBoxFuelGas_METRIC";
            this.textBoxFuelGas_METRIC.ReadOnly = true;
            this.textBoxFuelGas_METRIC.Size = new System.Drawing.Size(75, 18);
            this.textBoxFuelGas_METRIC.TabIndex = 43;
            this.textBoxFuelGas_METRIC.Text = "20.47";
            this.textBoxFuelGas_METRIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCoolingWater
            // 
            this.textBoxCoolingWater.BackColor = System.Drawing.Color.White;
            this.textBoxCoolingWater.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCoolingWater.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCoolingWater.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxCoolingWater.Location = new System.Drawing.Point(25, 119);
            this.textBoxCoolingWater.Name = "textBoxCoolingWater";
            this.textBoxCoolingWater.ReadOnly = true;
            this.textBoxCoolingWater.Size = new System.Drawing.Size(103, 18);
            this.textBoxCoolingWater.TabIndex = 42;
            this.textBoxCoolingWater.Text = "Cooling Water: ";
            this.textBoxCoolingWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCoolingWater_METRIC
            // 
            this.textBoxCoolingWater_METRIC.BackColor = System.Drawing.Color.White;
            this.textBoxCoolingWater_METRIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCoolingWater_METRIC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCoolingWater_METRIC.ForeColor = System.Drawing.Color.Black;
            this.textBoxCoolingWater_METRIC.Location = new System.Drawing.Point(134, 119);
            this.textBoxCoolingWater_METRIC.Name = "textBoxCoolingWater_METRIC";
            this.textBoxCoolingWater_METRIC.ReadOnly = true;
            this.textBoxCoolingWater_METRIC.Size = new System.Drawing.Size(75, 18);
            this.textBoxCoolingWater_METRIC.TabIndex = 41;
            this.textBoxCoolingWater_METRIC.Text = "0.34";
            this.textBoxCoolingWater_METRIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLP_Steam
            // 
            this.textBoxLP_Steam.BackColor = System.Drawing.Color.White;
            this.textBoxLP_Steam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLP_Steam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLP_Steam.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxLP_Steam.Location = new System.Drawing.Point(25, 95);
            this.textBoxLP_Steam.Name = "textBoxLP_Steam";
            this.textBoxLP_Steam.ReadOnly = true;
            this.textBoxLP_Steam.Size = new System.Drawing.Size(103, 18);
            this.textBoxLP_Steam.TabIndex = 40;
            this.textBoxLP_Steam.Text = "LP Steam: ";
            this.textBoxLP_Steam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxLP_Steam_METRIC
            // 
            this.textBoxLP_Steam_METRIC.BackColor = System.Drawing.Color.White;
            this.textBoxLP_Steam_METRIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLP_Steam_METRIC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLP_Steam_METRIC.ForeColor = System.Drawing.Color.Black;
            this.textBoxLP_Steam_METRIC.Location = new System.Drawing.Point(134, 95);
            this.textBoxLP_Steam_METRIC.Name = "textBoxLP_Steam_METRIC";
            this.textBoxLP_Steam_METRIC.ReadOnly = true;
            this.textBoxLP_Steam_METRIC.Size = new System.Drawing.Size(75, 18);
            this.textBoxLP_Steam_METRIC.TabIndex = 39;
            this.textBoxLP_Steam_METRIC.Text = "27.30";
            this.textBoxLP_Steam_METRIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMP_Steam
            // 
            this.textBoxMP_Steam.BackColor = System.Drawing.Color.White;
            this.textBoxMP_Steam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMP_Steam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMP_Steam.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxMP_Steam.Location = new System.Drawing.Point(25, 71);
            this.textBoxMP_Steam.Name = "textBoxMP_Steam";
            this.textBoxMP_Steam.ReadOnly = true;
            this.textBoxMP_Steam.Size = new System.Drawing.Size(103, 18);
            this.textBoxMP_Steam.TabIndex = 38;
            this.textBoxMP_Steam.Text = "MP Steam: ";
            this.textBoxMP_Steam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMP_Steam_METRIC
            // 
            this.textBoxMP_Steam_METRIC.BackColor = System.Drawing.Color.White;
            this.textBoxMP_Steam_METRIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMP_Steam_METRIC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMP_Steam_METRIC.ForeColor = System.Drawing.Color.Black;
            this.textBoxMP_Steam_METRIC.Location = new System.Drawing.Point(134, 71);
            this.textBoxMP_Steam_METRIC.Name = "textBoxMP_Steam_METRIC";
            this.textBoxMP_Steam_METRIC.ReadOnly = true;
            this.textBoxMP_Steam_METRIC.Size = new System.Drawing.Size(75, 18);
            this.textBoxMP_Steam_METRIC.TabIndex = 37;
            this.textBoxMP_Steam_METRIC.Text = "34.12";
            this.textBoxMP_Steam_METRIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHP_Steam
            // 
            this.textBoxHP_Steam.BackColor = System.Drawing.Color.White;
            this.textBoxHP_Steam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHP_Steam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHP_Steam.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxHP_Steam.Location = new System.Drawing.Point(25, 47);
            this.textBoxHP_Steam.Name = "textBoxHP_Steam";
            this.textBoxHP_Steam.ReadOnly = true;
            this.textBoxHP_Steam.Size = new System.Drawing.Size(103, 18);
            this.textBoxHP_Steam.TabIndex = 36;
            this.textBoxHP_Steam.Text = "HP Steam: ";
            this.textBoxHP_Steam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxHP_Steam_METRIC
            // 
            this.textBoxHP_Steam_METRIC.BackColor = System.Drawing.Color.White;
            this.textBoxHP_Steam_METRIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHP_Steam_METRIC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHP_Steam_METRIC.ForeColor = System.Drawing.Color.Black;
            this.textBoxHP_Steam_METRIC.Location = new System.Drawing.Point(134, 47);
            this.textBoxHP_Steam_METRIC.Name = "textBoxHP_Steam_METRIC";
            this.textBoxHP_Steam_METRIC.ReadOnly = true;
            this.textBoxHP_Steam_METRIC.Size = new System.Drawing.Size(75, 18);
            this.textBoxHP_Steam_METRIC.TabIndex = 35;
            this.textBoxHP_Steam_METRIC.Text = "40.94";
            this.textBoxHP_Steam_METRIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUtitlityCost_TITLE
            // 
            this.textBoxUtitlityCost_TITLE.BackColor = System.Drawing.Color.Yellow;
            this.textBoxUtitlityCost_TITLE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUtitlityCost_TITLE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUtitlityCost_TITLE.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxUtitlityCost_TITLE.Location = new System.Drawing.Point(2, 3);
            this.textBoxUtitlityCost_TITLE.Name = "textBoxUtitlityCost_TITLE";
            this.textBoxUtitlityCost_TITLE.ReadOnly = true;
            this.textBoxUtitlityCost_TITLE.Size = new System.Drawing.Size(320, 22);
            this.textBoxUtitlityCost_TITLE.TabIndex = 34;
            this.textBoxUtitlityCost_TITLE.TabStop = false;
            this.textBoxUtitlityCost_TITLE.Text = "UTILITY COST";
            this.textBoxUtitlityCost_TITLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelTotalAnnualizedCost
            // 
            this.panelTotalAnnualizedCost.BackColor = System.Drawing.Color.White;
            this.panelTotalAnnualizedCost.Controls.Add(this.textBoxTAC_OperatingHours);
            this.panelTotalAnnualizedCost.Controls.Add(this.textBoxTAC_OperatingHoursValue);
            this.panelTotalAnnualizedCost.Controls.Add(this.textBoxTAC_MaintenanceFraction);
            this.panelTotalAnnualizedCost.Controls.Add(this.textBoxTAC_MaintenanceFractionValue);
            this.panelTotalAnnualizedCost.Controls.Add(this.textBoxTAC_LifeYears);
            this.panelTotalAnnualizedCost.Controls.Add(this.textBoxTAC_LifeYearsValue);
            this.panelTotalAnnualizedCost.Controls.Add(this.textBoxTAC_InterestRate);
            this.panelTotalAnnualizedCost.Controls.Add(this.textBoxTAC_InterestRateValue);
            this.panelTotalAnnualizedCost.Controls.Add(this.textBoxTotalAnnualizedCost_TITLE);
            this.panelTotalAnnualizedCost.Location = new System.Drawing.Point(572, 227);
            this.panelTotalAnnualizedCost.Name = "panelTotalAnnualizedCost";
            this.panelTotalAnnualizedCost.Size = new System.Drawing.Size(325, 136);
            this.panelTotalAnnualizedCost.TabIndex = 22;
            // 
            // textBoxTAC_OperatingHours
            // 
            this.textBoxTAC_OperatingHours.BackColor = System.Drawing.Color.White;
            this.textBoxTAC_OperatingHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTAC_OperatingHours.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTAC_OperatingHours.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxTAC_OperatingHours.Location = new System.Drawing.Point(45, 106);
            this.textBoxTAC_OperatingHours.Name = "textBoxTAC_OperatingHours";
            this.textBoxTAC_OperatingHours.ReadOnly = true;
            this.textBoxTAC_OperatingHours.Size = new System.Drawing.Size(145, 18);
            this.textBoxTAC_OperatingHours.TabIndex = 42;
            this.textBoxTAC_OperatingHours.Text = "Operating Hours: ";
            this.textBoxTAC_OperatingHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTAC_OperatingHoursValue
            // 
            this.textBoxTAC_OperatingHoursValue.BackColor = System.Drawing.Color.White;
            this.textBoxTAC_OperatingHoursValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTAC_OperatingHoursValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTAC_OperatingHoursValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxTAC_OperatingHoursValue.Location = new System.Drawing.Point(196, 106);
            this.textBoxTAC_OperatingHoursValue.Name = "textBoxTAC_OperatingHoursValue";
            this.textBoxTAC_OperatingHoursValue.ReadOnly = true;
            this.textBoxTAC_OperatingHoursValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxTAC_OperatingHoursValue.TabIndex = 41;
            this.textBoxTAC_OperatingHoursValue.Text = "8000.00";
            this.textBoxTAC_OperatingHoursValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTAC_MaintenanceFraction
            // 
            this.textBoxTAC_MaintenanceFraction.BackColor = System.Drawing.Color.White;
            this.textBoxTAC_MaintenanceFraction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTAC_MaintenanceFraction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTAC_MaintenanceFraction.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxTAC_MaintenanceFraction.Location = new System.Drawing.Point(45, 82);
            this.textBoxTAC_MaintenanceFraction.Name = "textBoxTAC_MaintenanceFraction";
            this.textBoxTAC_MaintenanceFraction.ReadOnly = true;
            this.textBoxTAC_MaintenanceFraction.Size = new System.Drawing.Size(145, 18);
            this.textBoxTAC_MaintenanceFraction.TabIndex = 40;
            this.textBoxTAC_MaintenanceFraction.Text = "Maintenance Fraction: ";
            this.textBoxTAC_MaintenanceFraction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTAC_MaintenanceFractionValue
            // 
            this.textBoxTAC_MaintenanceFractionValue.BackColor = System.Drawing.Color.White;
            this.textBoxTAC_MaintenanceFractionValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTAC_MaintenanceFractionValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTAC_MaintenanceFractionValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxTAC_MaintenanceFractionValue.Location = new System.Drawing.Point(196, 82);
            this.textBoxTAC_MaintenanceFractionValue.Name = "textBoxTAC_MaintenanceFractionValue";
            this.textBoxTAC_MaintenanceFractionValue.ReadOnly = true;
            this.textBoxTAC_MaintenanceFractionValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxTAC_MaintenanceFractionValue.TabIndex = 39;
            this.textBoxTAC_MaintenanceFractionValue.Text = "0.03";
            this.textBoxTAC_MaintenanceFractionValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTAC_LifeYears
            // 
            this.textBoxTAC_LifeYears.BackColor = System.Drawing.Color.White;
            this.textBoxTAC_LifeYears.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTAC_LifeYears.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTAC_LifeYears.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxTAC_LifeYears.Location = new System.Drawing.Point(45, 58);
            this.textBoxTAC_LifeYears.Name = "textBoxTAC_LifeYears";
            this.textBoxTAC_LifeYears.ReadOnly = true;
            this.textBoxTAC_LifeYears.Size = new System.Drawing.Size(145, 18);
            this.textBoxTAC_LifeYears.TabIndex = 38;
            this.textBoxTAC_LifeYears.Text = "Life (years): ";
            this.textBoxTAC_LifeYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTAC_LifeYearsValue
            // 
            this.textBoxTAC_LifeYearsValue.BackColor = System.Drawing.Color.White;
            this.textBoxTAC_LifeYearsValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTAC_LifeYearsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTAC_LifeYearsValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxTAC_LifeYearsValue.Location = new System.Drawing.Point(196, 58);
            this.textBoxTAC_LifeYearsValue.Name = "textBoxTAC_LifeYearsValue";
            this.textBoxTAC_LifeYearsValue.ReadOnly = true;
            this.textBoxTAC_LifeYearsValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxTAC_LifeYearsValue.TabIndex = 37;
            this.textBoxTAC_LifeYearsValue.Text = "10.00";
            this.textBoxTAC_LifeYearsValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTAC_InterestRate
            // 
            this.textBoxTAC_InterestRate.BackColor = System.Drawing.Color.White;
            this.textBoxTAC_InterestRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTAC_InterestRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTAC_InterestRate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxTAC_InterestRate.Location = new System.Drawing.Point(45, 34);
            this.textBoxTAC_InterestRate.Name = "textBoxTAC_InterestRate";
            this.textBoxTAC_InterestRate.ReadOnly = true;
            this.textBoxTAC_InterestRate.Size = new System.Drawing.Size(145, 18);
            this.textBoxTAC_InterestRate.TabIndex = 36;
            this.textBoxTAC_InterestRate.Text = "Interest Rate: ";
            this.textBoxTAC_InterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTAC_InterestRateValue
            // 
            this.textBoxTAC_InterestRateValue.BackColor = System.Drawing.Color.White;
            this.textBoxTAC_InterestRateValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTAC_InterestRateValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTAC_InterestRateValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxTAC_InterestRateValue.Location = new System.Drawing.Point(196, 34);
            this.textBoxTAC_InterestRateValue.Name = "textBoxTAC_InterestRateValue";
            this.textBoxTAC_InterestRateValue.ReadOnly = true;
            this.textBoxTAC_InterestRateValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxTAC_InterestRateValue.TabIndex = 35;
            this.textBoxTAC_InterestRateValue.Text = "0.10";
            this.textBoxTAC_InterestRateValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTotalAnnualizedCost_TITLE
            // 
            this.textBoxTotalAnnualizedCost_TITLE.BackColor = System.Drawing.Color.Yellow;
            this.textBoxTotalAnnualizedCost_TITLE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalAnnualizedCost_TITLE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAnnualizedCost_TITLE.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxTotalAnnualizedCost_TITLE.Location = new System.Drawing.Point(2, 3);
            this.textBoxTotalAnnualizedCost_TITLE.Name = "textBoxTotalAnnualizedCost_TITLE";
            this.textBoxTotalAnnualizedCost_TITLE.ReadOnly = true;
            this.textBoxTotalAnnualizedCost_TITLE.Size = new System.Drawing.Size(320, 22);
            this.textBoxTotalAnnualizedCost_TITLE.TabIndex = 34;
            this.textBoxTotalAnnualizedCost_TITLE.TabStop = false;
            this.textBoxTotalAnnualizedCost_TITLE.Text = "TOTAL ANNUALIZED COST";
            this.textBoxTotalAnnualizedCost_TITLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelShellAndTubeCapitalCost
            // 
            this.panelShellAndTubeCapitalCost.BackColor = System.Drawing.Color.White;
            this.panelShellAndTubeCapitalCost.Controls.Add(this.textBoxMaterialFactor);
            this.panelShellAndTubeCapitalCost.Controls.Add(this.textBoxMaterialFactorValue);
            this.panelShellAndTubeCapitalCost.Controls.Add(this.textBoxAreaUnitsEnglish);
            this.panelShellAndTubeCapitalCost.Controls.Add(this.textBoxAreaUnitsEnglishValue);
            this.panelShellAndTubeCapitalCost.Controls.Add(this.textBoxAreaUnitsMetric);
            this.panelShellAndTubeCapitalCost.Controls.Add(this.textBoxAreaUnitsMetricValue);
            this.panelShellAndTubeCapitalCost.Controls.Add(this.textBoxParameterN);
            this.panelShellAndTubeCapitalCost.Controls.Add(this.textBoxParameterN_Value);
            this.panelShellAndTubeCapitalCost.Controls.Add(this.textBoxParameterB_English);
            this.panelShellAndTubeCapitalCost.Controls.Add(this.textBoxParameterB_EnglishValue);
            this.panelShellAndTubeCapitalCost.Controls.Add(this.textBoxParameterB_Metric);
            this.panelShellAndTubeCapitalCost.Controls.Add(this.textBoxParameterB_MetricValue);
            this.panelShellAndTubeCapitalCost.Controls.Add(this.textBoxParameterA);
            this.panelShellAndTubeCapitalCost.Controls.Add(this.textBoxParameterAValue);
            this.panelShellAndTubeCapitalCost.Controls.Add(this.textBoxShellAndTubeCapitalCost_TITLE);
            this.panelShellAndTubeCapitalCost.Location = new System.Drawing.Point(279, 5);
            this.panelShellAndTubeCapitalCost.Name = "panelShellAndTubeCapitalCost";
            this.panelShellAndTubeCapitalCost.Size = new System.Drawing.Size(288, 218);
            this.panelShellAndTubeCapitalCost.TabIndex = 21;
            // 
            // textBoxMaterialFactor
            // 
            this.textBoxMaterialFactor.BackColor = System.Drawing.Color.White;
            this.textBoxMaterialFactor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaterialFactor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaterialFactor.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxMaterialFactor.Location = new System.Drawing.Point(16, 135);
            this.textBoxMaterialFactor.Name = "textBoxMaterialFactor";
            this.textBoxMaterialFactor.ReadOnly = true;
            this.textBoxMaterialFactor.Size = new System.Drawing.Size(145, 18);
            this.textBoxMaterialFactor.TabIndex = 48;
            this.textBoxMaterialFactor.Text = "Material Factor: ";
            this.textBoxMaterialFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMaterialFactorValue
            // 
            this.textBoxMaterialFactorValue.BackColor = System.Drawing.Color.White;
            this.textBoxMaterialFactorValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaterialFactorValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaterialFactorValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaterialFactorValue.Location = new System.Drawing.Point(167, 135);
            this.textBoxMaterialFactorValue.Name = "textBoxMaterialFactorValue";
            this.textBoxMaterialFactorValue.ReadOnly = true;
            this.textBoxMaterialFactorValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxMaterialFactorValue.TabIndex = 47;
            this.textBoxMaterialFactorValue.Text = "1.00";
            this.textBoxMaterialFactorValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAreaUnitsEnglish
            // 
            this.textBoxAreaUnitsEnglish.BackColor = System.Drawing.Color.White;
            this.textBoxAreaUnitsEnglish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAreaUnitsEnglish.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAreaUnitsEnglish.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxAreaUnitsEnglish.Location = new System.Drawing.Point(16, 183);
            this.textBoxAreaUnitsEnglish.Name = "textBoxAreaUnitsEnglish";
            this.textBoxAreaUnitsEnglish.ReadOnly = true;
            this.textBoxAreaUnitsEnglish.Size = new System.Drawing.Size(145, 18);
            this.textBoxAreaUnitsEnglish.TabIndex = 46;
            this.textBoxAreaUnitsEnglish.Text = "Area Units (English): ";
            this.textBoxAreaUnitsEnglish.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAreaUnitsEnglishValue
            // 
            this.textBoxAreaUnitsEnglishValue.BackColor = System.Drawing.Color.White;
            this.textBoxAreaUnitsEnglishValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAreaUnitsEnglishValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAreaUnitsEnglishValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxAreaUnitsEnglishValue.Location = new System.Drawing.Point(167, 183);
            this.textBoxAreaUnitsEnglishValue.Name = "textBoxAreaUnitsEnglishValue";
            this.textBoxAreaUnitsEnglishValue.ReadOnly = true;
            this.textBoxAreaUnitsEnglishValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxAreaUnitsEnglishValue.TabIndex = 45;
            this.textBoxAreaUnitsEnglishValue.Text = "ft2";
            this.textBoxAreaUnitsEnglishValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAreaUnitsMetric
            // 
            this.textBoxAreaUnitsMetric.BackColor = System.Drawing.Color.White;
            this.textBoxAreaUnitsMetric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAreaUnitsMetric.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAreaUnitsMetric.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxAreaUnitsMetric.Location = new System.Drawing.Point(16, 159);
            this.textBoxAreaUnitsMetric.Name = "textBoxAreaUnitsMetric";
            this.textBoxAreaUnitsMetric.ReadOnly = true;
            this.textBoxAreaUnitsMetric.Size = new System.Drawing.Size(145, 18);
            this.textBoxAreaUnitsMetric.TabIndex = 44;
            this.textBoxAreaUnitsMetric.Text = "Area Units (Metric): ";
            this.textBoxAreaUnitsMetric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAreaUnitsMetricValue
            // 
            this.textBoxAreaUnitsMetricValue.BackColor = System.Drawing.Color.White;
            this.textBoxAreaUnitsMetricValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAreaUnitsMetricValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAreaUnitsMetricValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxAreaUnitsMetricValue.Location = new System.Drawing.Point(167, 159);
            this.textBoxAreaUnitsMetricValue.Name = "textBoxAreaUnitsMetricValue";
            this.textBoxAreaUnitsMetricValue.ReadOnly = true;
            this.textBoxAreaUnitsMetricValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxAreaUnitsMetricValue.TabIndex = 43;
            this.textBoxAreaUnitsMetricValue.Text = "m2";
            this.textBoxAreaUnitsMetricValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxParameterN
            // 
            this.textBoxParameterN.BackColor = System.Drawing.Color.White;
            this.textBoxParameterN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParameterN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParameterN.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxParameterN.Location = new System.Drawing.Point(16, 111);
            this.textBoxParameterN.Name = "textBoxParameterN";
            this.textBoxParameterN.ReadOnly = true;
            this.textBoxParameterN.Size = new System.Drawing.Size(145, 18);
            this.textBoxParameterN.TabIndex = 42;
            this.textBoxParameterN.Text = "N: ";
            this.textBoxParameterN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxParameterN_Value
            // 
            this.textBoxParameterN_Value.BackColor = System.Drawing.Color.White;
            this.textBoxParameterN_Value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParameterN_Value.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParameterN_Value.ForeColor = System.Drawing.Color.Black;
            this.textBoxParameterN_Value.Location = new System.Drawing.Point(167, 111);
            this.textBoxParameterN_Value.Name = "textBoxParameterN_Value";
            this.textBoxParameterN_Value.ReadOnly = true;
            this.textBoxParameterN_Value.Size = new System.Drawing.Size(75, 18);
            this.textBoxParameterN_Value.TabIndex = 41;
            this.textBoxParameterN_Value.Text = "0.65";
            this.textBoxParameterN_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxParameterB_English
            // 
            this.textBoxParameterB_English.BackColor = System.Drawing.Color.White;
            this.textBoxParameterB_English.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParameterB_English.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParameterB_English.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxParameterB_English.Location = new System.Drawing.Point(16, 87);
            this.textBoxParameterB_English.Name = "textBoxParameterB_English";
            this.textBoxParameterB_English.ReadOnly = true;
            this.textBoxParameterB_English.Size = new System.Drawing.Size(145, 18);
            this.textBoxParameterB_English.TabIndex = 40;
            this.textBoxParameterB_English.Text = "B (English): ";
            this.textBoxParameterB_English.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxParameterB_EnglishValue
            // 
            this.textBoxParameterB_EnglishValue.BackColor = System.Drawing.Color.White;
            this.textBoxParameterB_EnglishValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParameterB_EnglishValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParameterB_EnglishValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxParameterB_EnglishValue.Location = new System.Drawing.Point(167, 87);
            this.textBoxParameterB_EnglishValue.Name = "textBoxParameterB_EnglishValue";
            this.textBoxParameterB_EnglishValue.ReadOnly = true;
            this.textBoxParameterB_EnglishValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxParameterB_EnglishValue.TabIndex = 39;
            this.textBoxParameterB_EnglishValue.Text = "170.729";
            this.textBoxParameterB_EnglishValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxParameterB_Metric
            // 
            this.textBoxParameterB_Metric.BackColor = System.Drawing.Color.White;
            this.textBoxParameterB_Metric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParameterB_Metric.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParameterB_Metric.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxParameterB_Metric.Location = new System.Drawing.Point(16, 63);
            this.textBoxParameterB_Metric.Name = "textBoxParameterB_Metric";
            this.textBoxParameterB_Metric.ReadOnly = true;
            this.textBoxParameterB_Metric.Size = new System.Drawing.Size(145, 18);
            this.textBoxParameterB_Metric.TabIndex = 38;
            this.textBoxParameterB_Metric.Text = "B (Metric): ";
            this.textBoxParameterB_Metric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxParameterB_MetricValue
            // 
            this.textBoxParameterB_MetricValue.BackColor = System.Drawing.Color.White;
            this.textBoxParameterB_MetricValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParameterB_MetricValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParameterB_MetricValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxParameterB_MetricValue.Location = new System.Drawing.Point(167, 63);
            this.textBoxParameterB_MetricValue.Name = "textBoxParameterB_MetricValue";
            this.textBoxParameterB_MetricValue.ReadOnly = true;
            this.textBoxParameterB_MetricValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxParameterB_MetricValue.TabIndex = 37;
            this.textBoxParameterB_MetricValue.Text = "800.00";
            this.textBoxParameterB_MetricValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxParameterA
            // 
            this.textBoxParameterA.BackColor = System.Drawing.Color.White;
            this.textBoxParameterA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParameterA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParameterA.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxParameterA.Location = new System.Drawing.Point(16, 39);
            this.textBoxParameterA.Name = "textBoxParameterA";
            this.textBoxParameterA.ReadOnly = true;
            this.textBoxParameterA.Size = new System.Drawing.Size(145, 18);
            this.textBoxParameterA.TabIndex = 36;
            this.textBoxParameterA.Text = "A: ";
            this.textBoxParameterA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxParameterAValue
            // 
            this.textBoxParameterAValue.BackColor = System.Drawing.Color.White;
            this.textBoxParameterAValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParameterAValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParameterAValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxParameterAValue.Location = new System.Drawing.Point(167, 39);
            this.textBoxParameterAValue.Name = "textBoxParameterAValue";
            this.textBoxParameterAValue.ReadOnly = true;
            this.textBoxParameterAValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxParameterAValue.TabIndex = 35;
            this.textBoxParameterAValue.Text = "10000.00";
            this.textBoxParameterAValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxShellAndTubeCapitalCost_TITLE
            // 
            this.textBoxShellAndTubeCapitalCost_TITLE.BackColor = System.Drawing.Color.Yellow;
            this.textBoxShellAndTubeCapitalCost_TITLE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxShellAndTubeCapitalCost_TITLE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShellAndTubeCapitalCost_TITLE.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxShellAndTubeCapitalCost_TITLE.Location = new System.Drawing.Point(2, 3);
            this.textBoxShellAndTubeCapitalCost_TITLE.Name = "textBoxShellAndTubeCapitalCost_TITLE";
            this.textBoxShellAndTubeCapitalCost_TITLE.ReadOnly = true;
            this.textBoxShellAndTubeCapitalCost_TITLE.Size = new System.Drawing.Size(283, 22);
            this.textBoxShellAndTubeCapitalCost_TITLE.TabIndex = 34;
            this.textBoxShellAndTubeCapitalCost_TITLE.TabStop = false;
            this.textBoxShellAndTubeCapitalCost_TITLE.Text = "SHELL AND TUBE CAPITAL COST";
            this.textBoxShellAndTubeCapitalCost_TITLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelFiredHeaterCapitalCost
            // 
            this.panelFiredHeaterCapitalCost.BackColor = System.Drawing.Color.White;
            this.panelFiredHeaterCapitalCost.Controls.Add(this.textBoxDutyUnitsEnglish);
            this.panelFiredHeaterCapitalCost.Controls.Add(this.textBoxDutyUnitsEnglishValue);
            this.panelFiredHeaterCapitalCost.Controls.Add(this.textBoxDutyUnitsMetric);
            this.panelFiredHeaterCapitalCost.Controls.Add(this.textBoxDutyUnitsMetricValue);
            this.panelFiredHeaterCapitalCost.Controls.Add(this.textBoxEffeciency);
            this.panelFiredHeaterCapitalCost.Controls.Add(this.textBoxEffeciencyValue);
            this.panelFiredHeaterCapitalCost.Controls.Add(this.textBoxParameterBeta);
            this.panelFiredHeaterCapitalCost.Controls.Add(this.textBoxParameterBetaValue);
            this.panelFiredHeaterCapitalCost.Controls.Add(this.textBoxParameterAlphaEnglish);
            this.panelFiredHeaterCapitalCost.Controls.Add(this.textBoxParameterAlphaEnglishValue);
            this.panelFiredHeaterCapitalCost.Controls.Add(this.textBoxParameterAlphaMetric);
            this.panelFiredHeaterCapitalCost.Controls.Add(this.textBoxParameterAlphaMetricValue);
            this.panelFiredHeaterCapitalCost.Controls.Add(this.textBoxFiredHeaterCapitalCost_TITLE);
            this.panelFiredHeaterCapitalCost.Location = new System.Drawing.Point(6, 169);
            this.panelFiredHeaterCapitalCost.Name = "panelFiredHeaterCapitalCost";
            this.panelFiredHeaterCapitalCost.Size = new System.Drawing.Size(267, 194);
            this.panelFiredHeaterCapitalCost.TabIndex = 20;
            // 
            // textBoxDutyUnitsEnglish
            // 
            this.textBoxDutyUnitsEnglish.BackColor = System.Drawing.Color.White;
            this.textBoxDutyUnitsEnglish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDutyUnitsEnglish.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDutyUnitsEnglish.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxDutyUnitsEnglish.Location = new System.Drawing.Point(13, 158);
            this.textBoxDutyUnitsEnglish.Name = "textBoxDutyUnitsEnglish";
            this.textBoxDutyUnitsEnglish.ReadOnly = true;
            this.textBoxDutyUnitsEnglish.Size = new System.Drawing.Size(145, 18);
            this.textBoxDutyUnitsEnglish.TabIndex = 46;
            this.textBoxDutyUnitsEnglish.Text = "Duty Units (English): ";
            this.textBoxDutyUnitsEnglish.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDutyUnitsEnglishValue
            // 
            this.textBoxDutyUnitsEnglishValue.BackColor = System.Drawing.Color.White;
            this.textBoxDutyUnitsEnglishValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDutyUnitsEnglishValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDutyUnitsEnglishValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxDutyUnitsEnglishValue.Location = new System.Drawing.Point(162, 158);
            this.textBoxDutyUnitsEnglishValue.Name = "textBoxDutyUnitsEnglishValue";
            this.textBoxDutyUnitsEnglishValue.ReadOnly = true;
            this.textBoxDutyUnitsEnglishValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxDutyUnitsEnglishValue.TabIndex = 45;
            this.textBoxDutyUnitsEnglishValue.Text = "MMBut/hr";
            this.textBoxDutyUnitsEnglishValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDutyUnitsMetric
            // 
            this.textBoxDutyUnitsMetric.BackColor = System.Drawing.Color.White;
            this.textBoxDutyUnitsMetric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDutyUnitsMetric.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDutyUnitsMetric.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxDutyUnitsMetric.Location = new System.Drawing.Point(13, 134);
            this.textBoxDutyUnitsMetric.Name = "textBoxDutyUnitsMetric";
            this.textBoxDutyUnitsMetric.ReadOnly = true;
            this.textBoxDutyUnitsMetric.Size = new System.Drawing.Size(145, 18);
            this.textBoxDutyUnitsMetric.TabIndex = 44;
            this.textBoxDutyUnitsMetric.Text = "Duty Units (Metric): ";
            this.textBoxDutyUnitsMetric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDutyUnitsMetricValue
            // 
            this.textBoxDutyUnitsMetricValue.BackColor = System.Drawing.Color.White;
            this.textBoxDutyUnitsMetricValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDutyUnitsMetricValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDutyUnitsMetricValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxDutyUnitsMetricValue.Location = new System.Drawing.Point(162, 134);
            this.textBoxDutyUnitsMetricValue.Name = "textBoxDutyUnitsMetricValue";
            this.textBoxDutyUnitsMetricValue.ReadOnly = true;
            this.textBoxDutyUnitsMetricValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxDutyUnitsMetricValue.TabIndex = 43;
            this.textBoxDutyUnitsMetricValue.Text = "MW";
            this.textBoxDutyUnitsMetricValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEffeciency
            // 
            this.textBoxEffeciency.BackColor = System.Drawing.Color.White;
            this.textBoxEffeciency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEffeciency.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEffeciency.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxEffeciency.Location = new System.Drawing.Point(13, 110);
            this.textBoxEffeciency.Name = "textBoxEffeciency";
            this.textBoxEffeciency.ReadOnly = true;
            this.textBoxEffeciency.Size = new System.Drawing.Size(145, 18);
            this.textBoxEffeciency.TabIndex = 42;
            this.textBoxEffeciency.Text = "Effeciency: ";
            this.textBoxEffeciency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxEffeciencyValue
            // 
            this.textBoxEffeciencyValue.BackColor = System.Drawing.Color.White;
            this.textBoxEffeciencyValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEffeciencyValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEffeciencyValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxEffeciencyValue.Location = new System.Drawing.Point(162, 110);
            this.textBoxEffeciencyValue.Name = "textBoxEffeciencyValue";
            this.textBoxEffeciencyValue.ReadOnly = true;
            this.textBoxEffeciencyValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxEffeciencyValue.TabIndex = 41;
            this.textBoxEffeciencyValue.Text = "0.85";
            this.textBoxEffeciencyValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxParameterBeta
            // 
            this.textBoxParameterBeta.BackColor = System.Drawing.Color.White;
            this.textBoxParameterBeta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParameterBeta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParameterBeta.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxParameterBeta.Location = new System.Drawing.Point(13, 86);
            this.textBoxParameterBeta.Name = "textBoxParameterBeta";
            this.textBoxParameterBeta.ReadOnly = true;
            this.textBoxParameterBeta.Size = new System.Drawing.Size(145, 18);
            this.textBoxParameterBeta.TabIndex = 40;
            this.textBoxParameterBeta.Text = "Beta: ";
            this.textBoxParameterBeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxParameterBetaValue
            // 
            this.textBoxParameterBetaValue.BackColor = System.Drawing.Color.White;
            this.textBoxParameterBetaValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParameterBetaValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParameterBetaValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxParameterBetaValue.Location = new System.Drawing.Point(162, 86);
            this.textBoxParameterBetaValue.Name = "textBoxParameterBetaValue";
            this.textBoxParameterBetaValue.ReadOnly = true;
            this.textBoxParameterBetaValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxParameterBetaValue.TabIndex = 39;
            this.textBoxParameterBetaValue.Text = "0.80";
            this.textBoxParameterBetaValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxParameterAlphaEnglish
            // 
            this.textBoxParameterAlphaEnglish.BackColor = System.Drawing.Color.White;
            this.textBoxParameterAlphaEnglish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParameterAlphaEnglish.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParameterAlphaEnglish.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxParameterAlphaEnglish.Location = new System.Drawing.Point(13, 62);
            this.textBoxParameterAlphaEnglish.Name = "textBoxParameterAlphaEnglish";
            this.textBoxParameterAlphaEnglish.ReadOnly = true;
            this.textBoxParameterAlphaEnglish.Size = new System.Drawing.Size(145, 18);
            this.textBoxParameterAlphaEnglish.TabIndex = 38;
            this.textBoxParameterAlphaEnglish.Text = "Alpha (English): ";
            this.textBoxParameterAlphaEnglish.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxParameterAlphaEnglishValue
            // 
            this.textBoxParameterAlphaEnglishValue.BackColor = System.Drawing.Color.White;
            this.textBoxParameterAlphaEnglishValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParameterAlphaEnglishValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParameterAlphaEnglishValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxParameterAlphaEnglishValue.Location = new System.Drawing.Point(162, 62);
            this.textBoxParameterAlphaEnglishValue.Name = "textBoxParameterAlphaEnglishValue";
            this.textBoxParameterAlphaEnglishValue.ReadOnly = true;
            this.textBoxParameterAlphaEnglishValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxParameterAlphaEnglishValue.TabIndex = 37;
            this.textBoxParameterAlphaEnglishValue.Text = "74924.31";
            this.textBoxParameterAlphaEnglishValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxParameterAlphaMetric
            // 
            this.textBoxParameterAlphaMetric.BackColor = System.Drawing.Color.White;
            this.textBoxParameterAlphaMetric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParameterAlphaMetric.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParameterAlphaMetric.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxParameterAlphaMetric.Location = new System.Drawing.Point(13, 38);
            this.textBoxParameterAlphaMetric.Name = "textBoxParameterAlphaMetric";
            this.textBoxParameterAlphaMetric.ReadOnly = true;
            this.textBoxParameterAlphaMetric.Size = new System.Drawing.Size(145, 18);
            this.textBoxParameterAlphaMetric.TabIndex = 36;
            this.textBoxParameterAlphaMetric.Text = "Alpha (Metric): ";
            this.textBoxParameterAlphaMetric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxParameterAlphaMetricValue
            // 
            this.textBoxParameterAlphaMetricValue.BackColor = System.Drawing.Color.White;
            this.textBoxParameterAlphaMetricValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParameterAlphaMetricValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParameterAlphaMetricValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxParameterAlphaMetricValue.Location = new System.Drawing.Point(162, 38);
            this.textBoxParameterAlphaMetricValue.Name = "textBoxParameterAlphaMetricValue";
            this.textBoxParameterAlphaMetricValue.ReadOnly = true;
            this.textBoxParameterAlphaMetricValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxParameterAlphaMetricValue.TabIndex = 35;
            this.textBoxParameterAlphaMetricValue.Text = "200000.00";
            this.textBoxParameterAlphaMetricValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFiredHeaterCapitalCost_TITLE
            // 
            this.textBoxFiredHeaterCapitalCost_TITLE.BackColor = System.Drawing.Color.Yellow;
            this.textBoxFiredHeaterCapitalCost_TITLE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFiredHeaterCapitalCost_TITLE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFiredHeaterCapitalCost_TITLE.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxFiredHeaterCapitalCost_TITLE.Location = new System.Drawing.Point(2, 3);
            this.textBoxFiredHeaterCapitalCost_TITLE.Name = "textBoxFiredHeaterCapitalCost_TITLE";
            this.textBoxFiredHeaterCapitalCost_TITLE.ReadOnly = true;
            this.textBoxFiredHeaterCapitalCost_TITLE.Size = new System.Drawing.Size(262, 22);
            this.textBoxFiredHeaterCapitalCost_TITLE.TabIndex = 34;
            this.textBoxFiredHeaterCapitalCost_TITLE.TabStop = false;
            this.textBoxFiredHeaterCapitalCost_TITLE.Text = "FIRED HEATER CAPITAL COST";
            this.textBoxFiredHeaterCapitalCost_TITLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelCostMetadata
            // 
            this.panelCostMetadata.BackColor = System.Drawing.Color.White;
            this.panelCostMetadata.Controls.Add(this.textBoxInstalledCostFactor);
            this.panelCostMetadata.Controls.Add(this.textBoxInstalledCostFactorValue);
            this.panelCostMetadata.Controls.Add(this.textBoxCostIndexCurrency);
            this.panelCostMetadata.Controls.Add(this.textBoxCostIndexCurrencyValue);
            this.panelCostMetadata.Controls.Add(this.textBoxCostIndex);
            this.panelCostMetadata.Controls.Add(this.textBoxCostIndexValue);
            this.panelCostMetadata.Controls.Add(this.textBoxCostIndexName);
            this.panelCostMetadata.Controls.Add(this.textBoxCostIndexNameValue);
            this.panelCostMetadata.Controls.Add(this.textBoxCostIndexBaseYear);
            this.panelCostMetadata.Controls.Add(this.textBoxCostIndexBaseYearValue);
            this.panelCostMetadata.Controls.Add(this.textBoxProjectCostMetadata_TITLE);
            this.panelCostMetadata.Location = new System.Drawing.Point(6, 5);
            this.panelCostMetadata.Name = "panelCostMetadata";
            this.panelCostMetadata.Size = new System.Drawing.Size(267, 160);
            this.panelCostMetadata.TabIndex = 19;
            // 
            // textBoxInstalledCostFactor
            // 
            this.textBoxInstalledCostFactor.BackColor = System.Drawing.Color.White;
            this.textBoxInstalledCostFactor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInstalledCostFactor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInstalledCostFactor.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxInstalledCostFactor.Location = new System.Drawing.Point(13, 130);
            this.textBoxInstalledCostFactor.Name = "textBoxInstalledCostFactor";
            this.textBoxInstalledCostFactor.ReadOnly = true;
            this.textBoxInstalledCostFactor.Size = new System.Drawing.Size(145, 18);
            this.textBoxInstalledCostFactor.TabIndex = 44;
            this.textBoxInstalledCostFactor.Text = "Installed Cost Factor: ";
            this.textBoxInstalledCostFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxInstalledCostFactorValue
            // 
            this.textBoxInstalledCostFactorValue.BackColor = System.Drawing.Color.White;
            this.textBoxInstalledCostFactorValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInstalledCostFactorValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInstalledCostFactorValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxInstalledCostFactorValue.Location = new System.Drawing.Point(164, 130);
            this.textBoxInstalledCostFactorValue.Name = "textBoxInstalledCostFactorValue";
            this.textBoxInstalledCostFactorValue.ReadOnly = true;
            this.textBoxInstalledCostFactorValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxInstalledCostFactorValue.TabIndex = 43;
            this.textBoxInstalledCostFactorValue.Text = "3.0";
            this.textBoxInstalledCostFactorValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCostIndexCurrency
            // 
            this.textBoxCostIndexCurrency.BackColor = System.Drawing.Color.White;
            this.textBoxCostIndexCurrency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCostIndexCurrency.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostIndexCurrency.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxCostIndexCurrency.Location = new System.Drawing.Point(13, 106);
            this.textBoxCostIndexCurrency.Name = "textBoxCostIndexCurrency";
            this.textBoxCostIndexCurrency.ReadOnly = true;
            this.textBoxCostIndexCurrency.Size = new System.Drawing.Size(145, 18);
            this.textBoxCostIndexCurrency.TabIndex = 42;
            this.textBoxCostIndexCurrency.Text = "Currency: ";
            this.textBoxCostIndexCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCostIndexCurrencyValue
            // 
            this.textBoxCostIndexCurrencyValue.BackColor = System.Drawing.Color.White;
            this.textBoxCostIndexCurrencyValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCostIndexCurrencyValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostIndexCurrencyValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxCostIndexCurrencyValue.Location = new System.Drawing.Point(164, 106);
            this.textBoxCostIndexCurrencyValue.Name = "textBoxCostIndexCurrencyValue";
            this.textBoxCostIndexCurrencyValue.ReadOnly = true;
            this.textBoxCostIndexCurrencyValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxCostIndexCurrencyValue.TabIndex = 41;
            this.textBoxCostIndexCurrencyValue.Text = "USD";
            this.textBoxCostIndexCurrencyValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCostIndex
            // 
            this.textBoxCostIndex.BackColor = System.Drawing.Color.White;
            this.textBoxCostIndex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCostIndex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostIndex.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxCostIndex.Location = new System.Drawing.Point(13, 82);
            this.textBoxCostIndex.Name = "textBoxCostIndex";
            this.textBoxCostIndex.ReadOnly = true;
            this.textBoxCostIndex.Size = new System.Drawing.Size(145, 18);
            this.textBoxCostIndex.TabIndex = 40;
            this.textBoxCostIndex.Text = "Cost Index: ";
            this.textBoxCostIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCostIndexValue
            // 
            this.textBoxCostIndexValue.BackColor = System.Drawing.Color.White;
            this.textBoxCostIndexValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCostIndexValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostIndexValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxCostIndexValue.Location = new System.Drawing.Point(164, 82);
            this.textBoxCostIndexValue.Name = "textBoxCostIndexValue";
            this.textBoxCostIndexValue.ReadOnly = true;
            this.textBoxCostIndexValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxCostIndexValue.TabIndex = 39;
            this.textBoxCostIndexValue.Text = "840";
            this.textBoxCostIndexValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCostIndexName
            // 
            this.textBoxCostIndexName.BackColor = System.Drawing.Color.White;
            this.textBoxCostIndexName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCostIndexName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostIndexName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxCostIndexName.Location = new System.Drawing.Point(13, 58);
            this.textBoxCostIndexName.Name = "textBoxCostIndexName";
            this.textBoxCostIndexName.ReadOnly = true;
            this.textBoxCostIndexName.Size = new System.Drawing.Size(145, 18);
            this.textBoxCostIndexName.TabIndex = 38;
            this.textBoxCostIndexName.Text = "Cost Index Name: ";
            this.textBoxCostIndexName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCostIndexNameValue
            // 
            this.textBoxCostIndexNameValue.BackColor = System.Drawing.Color.White;
            this.textBoxCostIndexNameValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCostIndexNameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostIndexNameValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxCostIndexNameValue.Location = new System.Drawing.Point(164, 58);
            this.textBoxCostIndexNameValue.Name = "textBoxCostIndexNameValue";
            this.textBoxCostIndexNameValue.ReadOnly = true;
            this.textBoxCostIndexNameValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxCostIndexNameValue.TabIndex = 37;
            this.textBoxCostIndexNameValue.Text = "CEPCI";
            this.textBoxCostIndexNameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCostIndexBaseYear
            // 
            this.textBoxCostIndexBaseYear.BackColor = System.Drawing.Color.White;
            this.textBoxCostIndexBaseYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCostIndexBaseYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostIndexBaseYear.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxCostIndexBaseYear.Location = new System.Drawing.Point(13, 34);
            this.textBoxCostIndexBaseYear.Name = "textBoxCostIndexBaseYear";
            this.textBoxCostIndexBaseYear.ReadOnly = true;
            this.textBoxCostIndexBaseYear.Size = new System.Drawing.Size(145, 18);
            this.textBoxCostIndexBaseYear.TabIndex = 36;
            this.textBoxCostIndexBaseYear.Text = "Cost Index Base Year: ";
            this.textBoxCostIndexBaseYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCostIndexBaseYearValue
            // 
            this.textBoxCostIndexBaseYearValue.BackColor = System.Drawing.Color.White;
            this.textBoxCostIndexBaseYearValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCostIndexBaseYearValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostIndexBaseYearValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxCostIndexBaseYearValue.Location = new System.Drawing.Point(164, 34);
            this.textBoxCostIndexBaseYearValue.Name = "textBoxCostIndexBaseYearValue";
            this.textBoxCostIndexBaseYearValue.ReadOnly = true;
            this.textBoxCostIndexBaseYearValue.Size = new System.Drawing.Size(75, 18);
            this.textBoxCostIndexBaseYearValue.TabIndex = 35;
            this.textBoxCostIndexBaseYearValue.Text = "2026";
            this.textBoxCostIndexBaseYearValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxProjectCostMetadata_TITLE
            // 
            this.textBoxProjectCostMetadata_TITLE.BackColor = System.Drawing.Color.Yellow;
            this.textBoxProjectCostMetadata_TITLE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectCostMetadata_TITLE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectCostMetadata_TITLE.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxProjectCostMetadata_TITLE.Location = new System.Drawing.Point(2, 3);
            this.textBoxProjectCostMetadata_TITLE.Name = "textBoxProjectCostMetadata_TITLE";
            this.textBoxProjectCostMetadata_TITLE.ReadOnly = true;
            this.textBoxProjectCostMetadata_TITLE.Size = new System.Drawing.Size(262, 22);
            this.textBoxProjectCostMetadata_TITLE.TabIndex = 34;
            this.textBoxProjectCostMetadata_TITLE.TabStop = false;
            this.textBoxProjectCostMetadata_TITLE.Text = "COST METADATA";
            this.textBoxProjectCostMetadata_TITLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxProjectBanner
            // 
            this.textBoxProjectBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProjectBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(99)))), ((int)(((byte)(87)))));
            this.textBoxProjectBanner.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectBanner.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxProjectBanner.Location = new System.Drawing.Point(1, 4);
            this.textBoxProjectBanner.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxProjectBanner.Name = "textBoxProjectBanner";
            this.textBoxProjectBanner.Size = new System.Drawing.Size(903, 33);
            this.textBoxProjectBanner.TabIndex = 0;
            this.textBoxProjectBanner.Text = "PROJECT";
            this.textBoxProjectBanner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelProjectMetadata
            // 
            this.panelProjectMetadata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProjectMetadata.BackColor = System.Drawing.Color.White;
            this.panelProjectMetadata.Controls.Add(this.textBoxProjectID);
            this.panelProjectMetadata.Controls.Add(this.textBoxProjectGUID);
            this.panelProjectMetadata.Controls.Add(this.pictureBoxOpenedProject);
            this.panelProjectMetadata.Controls.Add(this.textBoxProjectNameValue);
            this.panelProjectMetadata.Controls.Add(this.textBoxProjectName);
            this.panelProjectMetadata.Controls.Add(this.textBoxProjectDescription);
            this.panelProjectMetadata.Controls.Add(this.textBoxProjectDescriptionValue);
            this.panelProjectMetadata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelProjectMetadata.Location = new System.Drawing.Point(10, 46);
            this.panelProjectMetadata.Name = "panelProjectMetadata";
            this.panelProjectMetadata.Size = new System.Drawing.Size(889, 135);
            this.panelProjectMetadata.TabIndex = 12;
            // 
            // textBoxProjectID
            // 
            this.textBoxProjectID.BackColor = System.Drawing.Color.White;
            this.textBoxProjectID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxProjectID.Location = new System.Drawing.Point(14, 10);
            this.textBoxProjectID.Name = "textBoxProjectID";
            this.textBoxProjectID.ReadOnly = true;
            this.textBoxProjectID.Size = new System.Drawing.Size(96, 18);
            this.textBoxProjectID.TabIndex = 6;
            this.textBoxProjectID.Text = "Project ID: ";
            this.textBoxProjectID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxProjectGUID
            // 
            this.textBoxProjectGUID.BackColor = System.Drawing.Color.White;
            this.textBoxProjectGUID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectGUID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectGUID.ForeColor = System.Drawing.Color.Black;
            this.textBoxProjectGUID.Location = new System.Drawing.Point(116, 10);
            this.textBoxProjectGUID.Name = "textBoxProjectGUID";
            this.textBoxProjectGUID.ReadOnly = true;
            this.textBoxProjectGUID.Size = new System.Drawing.Size(335, 18);
            this.textBoxProjectGUID.TabIndex = 5;
            this.textBoxProjectGUID.Text = "Project GUID here";
            // 
            // pictureBoxOpenedProject
            // 
            this.pictureBoxOpenedProject.Image = global::HenStudio.Properties.Resources.OpenedProject64;
            this.pictureBoxOpenedProject.Location = new System.Drawing.Point(34, 72);
            this.pictureBoxOpenedProject.Name = "pictureBoxOpenedProject";
            this.pictureBoxOpenedProject.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxOpenedProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOpenedProject.TabIndex = 9;
            this.pictureBoxOpenedProject.TabStop = false;
            // 
            // textBoxProjectNameValue
            // 
            this.textBoxProjectNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProjectNameValue.BackColor = System.Drawing.Color.White;
            this.textBoxProjectNameValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectNameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectNameValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxProjectNameValue.Location = new System.Drawing.Point(116, 29);
            this.textBoxProjectNameValue.Name = "textBoxProjectNameValue";
            this.textBoxProjectNameValue.ReadOnly = true;
            this.textBoxProjectNameValue.Size = new System.Drawing.Size(759, 18);
            this.textBoxProjectNameValue.TabIndex = 2;
            this.textBoxProjectNameValue.Text = "Project Name here";
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.BackColor = System.Drawing.Color.White;
            this.textBoxProjectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxProjectName.Location = new System.Drawing.Point(14, 29);
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
            this.textBoxProjectDescription.BackColor = System.Drawing.Color.White;
            this.textBoxProjectDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectDescription.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxProjectDescription.Location = new System.Drawing.Point(14, 49);
            this.textBoxProjectDescription.Name = "textBoxProjectDescription";
            this.textBoxProjectDescription.ReadOnly = true;
            this.textBoxProjectDescription.Size = new System.Drawing.Size(96, 18);
            this.textBoxProjectDescription.TabIndex = 3;
            this.textBoxProjectDescription.Text = "  Description: ";
            this.textBoxProjectDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxProjectDescriptionValue
            // 
            this.textBoxProjectDescriptionValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProjectDescriptionValue.BackColor = System.Drawing.Color.White;
            this.textBoxProjectDescriptionValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProjectDescriptionValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectDescriptionValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxProjectDescriptionValue.Location = new System.Drawing.Point(110, 50);
            this.textBoxProjectDescriptionValue.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxProjectDescriptionValue.Multiline = true;
            this.textBoxProjectDescriptionValue.Name = "textBoxProjectDescriptionValue";
            this.textBoxProjectDescriptionValue.ReadOnly = true;
            this.textBoxProjectDescriptionValue.Size = new System.Drawing.Size(764, 79);
            this.textBoxProjectDescriptionValue.TabIndex = 4;
            this.textBoxProjectDescriptionValue.Text = "Project Description here";
            // 
            // panelSELECTED_ROOT
            // 
            this.panelSELECTED_ROOT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSELECTED_ROOT.BackColor = System.Drawing.Color.Honeydew;
            this.panelSELECTED_ROOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSELECTED_ROOT.Controls.Add(this.tabControlROOT);
            this.panelSELECTED_ROOT.Controls.Add(this.textBoxProjectsBanner);
            this.panelSELECTED_ROOT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSELECTED_ROOT.Location = new System.Drawing.Point(0, 0);
            this.panelSELECTED_ROOT.Margin = new System.Windows.Forms.Padding(0);
            this.panelSELECTED_ROOT.Name = "panelSELECTED_ROOT";
            this.panelSELECTED_ROOT.Padding = new System.Windows.Forms.Padding(6);
            this.panelSELECTED_ROOT.Size = new System.Drawing.Size(910, 619);
            this.panelSELECTED_ROOT.TabIndex = 1;
            // 
            // tabControlROOT
            // 
            this.tabControlROOT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlROOT.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlROOT.Controls.Add(this.tabPageROOT_Home);
            this.tabControlROOT.Controls.Add(this.tabPageROOT_FactorSettings);
            this.tabControlROOT.Controls.Add(this.tabPageROOT_Database);
            this.tabControlROOT.Controls.Add(this.tabPageROOT_License);
            this.tabControlROOT.Controls.Add(this.tabPageROOT_About);
            this.tabControlROOT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlROOT.ItemSize = new System.Drawing.Size(161, 35);
            this.tabControlROOT.Location = new System.Drawing.Point(-3, 45);
            this.tabControlROOT.Margin = new System.Windows.Forms.Padding(6);
            this.tabControlROOT.Name = "tabControlROOT";
            this.tabControlROOT.Padding = new System.Drawing.Point(6, 6);
            this.tabControlROOT.SelectedIndex = 0;
            this.tabControlROOT.ShowToolTips = true;
            this.tabControlROOT.Size = new System.Drawing.Size(904, 576);
            this.tabControlROOT.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlROOT.TabIndex = 17;
            // 
            // tabPageROOT_Home
            // 
            this.tabPageROOT_Home.BackColor = System.Drawing.Color.Honeydew;
            this.tabPageROOT_Home.Controls.Add(this.panelHomeAJP);
            this.tabPageROOT_Home.Location = new System.Drawing.Point(4, 39);
            this.tabPageROOT_Home.Name = "tabPageROOT_Home";
            this.tabPageROOT_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageROOT_Home.Size = new System.Drawing.Size(896, 533);
            this.tabPageROOT_Home.TabIndex = 0;
            this.tabPageROOT_Home.Text = "  Home  ";
            // 
            // panelHomeAJP
            // 
            this.panelHomeAJP.BackColor = System.Drawing.Color.Honeydew;
            this.panelHomeAJP.Controls.Add(this.pictureBoxHomeAjpLogo);
            this.panelHomeAJP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHomeAJP.Location = new System.Drawing.Point(3, 3);
            this.panelHomeAJP.Name = "panelHomeAJP";
            this.panelHomeAJP.Size = new System.Drawing.Size(890, 527);
            this.panelHomeAJP.TabIndex = 1;
            // 
            // pictureBoxHomeAjpLogo
            // 
            this.pictureBoxHomeAjpLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxHomeAjpLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHomeAjpLogo.Image = global::HenStudio.Properties.Resources.AJPEngineeringLogo;
            this.pictureBoxHomeAjpLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHomeAjpLogo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pictureBoxHomeAjpLogo.Name = "pictureBoxHomeAjpLogo";
            this.pictureBoxHomeAjpLogo.Size = new System.Drawing.Size(890, 527);
            this.pictureBoxHomeAjpLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHomeAjpLogo.TabIndex = 0;
            this.pictureBoxHomeAjpLogo.TabStop = false;
            this.pictureBoxHomeAjpLogo.Click += new System.EventHandler(this.pictureBoxHomeAjpLogo_Click);
            // 
            // tabPageROOT_FactorSettings
            // 
            this.tabPageROOT_FactorSettings.BackColor = System.Drawing.Color.Honeydew;
            this.tabPageROOT_FactorSettings.Controls.Add(this.pictureBoxFactorySettingsAjpEngLogo);
            this.tabPageROOT_FactorSettings.Controls.Add(this.panelAppComponents);
            this.tabPageROOT_FactorSettings.Controls.Add(this.panelAppMetadata);
            this.tabPageROOT_FactorSettings.Controls.Add(this.panelFactorySettings);
            this.tabPageROOT_FactorSettings.Location = new System.Drawing.Point(4, 39);
            this.tabPageROOT_FactorSettings.Name = "tabPageROOT_FactorSettings";
            this.tabPageROOT_FactorSettings.Size = new System.Drawing.Size(896, 533);
            this.tabPageROOT_FactorSettings.TabIndex = 3;
            this.tabPageROOT_FactorSettings.Text = "  Factory Settings  ";
            // 
            // pictureBoxFactorySettingsAjpEngLogo
            // 
            this.pictureBoxFactorySettingsAjpEngLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFactorySettingsAjpEngLogo.BackColor = System.Drawing.Color.Azure;
            this.pictureBoxFactorySettingsAjpEngLogo.Image = global::HenStudio.Properties.Resources.AjpContactInfo;
            this.pictureBoxFactorySettingsAjpEngLogo.Location = new System.Drawing.Point(575, 402);
            this.pictureBoxFactorySettingsAjpEngLogo.Name = "pictureBoxFactorySettingsAjpEngLogo";
            this.pictureBoxFactorySettingsAjpEngLogo.Size = new System.Drawing.Size(320, 125);
            this.pictureBoxFactorySettingsAjpEngLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFactorySettingsAjpEngLogo.TabIndex = 21;
            this.pictureBoxFactorySettingsAjpEngLogo.TabStop = false;
            this.pictureBoxFactorySettingsAjpEngLogo.Click += new System.EventHandler(this.pictureBoxFactorySettingsAjpEngLogo_Click);
            // 
            // panelAppComponents
            // 
            this.panelAppComponents.BackColor = System.Drawing.Color.White;
            this.panelAppComponents.Controls.Add(this.listViewAppComponents);
            this.panelAppComponents.Controls.Add(this.textBoxAppComponentsTitle);
            this.panelAppComponents.Location = new System.Drawing.Point(579, 6);
            this.panelAppComponents.Name = "panelAppComponents";
            this.panelAppComponents.Size = new System.Drawing.Size(280, 202);
            this.panelAppComponents.TabIndex = 20;
            // 
            // listViewAppComponents
            // 
            this.listViewAppComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAppComponents.BackColor = System.Drawing.Color.Azure;
            this.listViewAppComponents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewAppComponents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderComponentsNumber,
            this.columnHeaderComponentsName});
            this.listViewAppComponents.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAppComponents.ForeColor = System.Drawing.Color.Black;
            this.listViewAppComponents.FullRowSelect = true;
            this.listViewAppComponents.GridLines = true;
            this.listViewAppComponents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewAppComponents.HideSelection = false;
            this.listViewAppComponents.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18});
            this.listViewAppComponents.Location = new System.Drawing.Point(10, 35);
            this.listViewAppComponents.Margin = new System.Windows.Forms.Padding(6);
            this.listViewAppComponents.Name = "listViewAppComponents";
            this.listViewAppComponents.Size = new System.Drawing.Size(257, 150);
            this.listViewAppComponents.TabIndex = 51;
            this.listViewAppComponents.UseCompatibleStateImageBehavior = false;
            this.listViewAppComponents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderComponentsNumber
            // 
            this.columnHeaderComponentsNumber.Text = "#";
            this.columnHeaderComponentsNumber.Width = 27;
            // 
            // columnHeaderComponentsName
            // 
            this.columnHeaderComponentsName.Text = "Component";
            this.columnHeaderComponentsName.Width = 230;
            // 
            // textBoxAppComponentsTitle
            // 
            this.textBoxAppComponentsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAppComponentsTitle.BackColor = System.Drawing.Color.Yellow;
            this.textBoxAppComponentsTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAppComponentsTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAppComponentsTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxAppComponentsTitle.Location = new System.Drawing.Point(3, 3);
            this.textBoxAppComponentsTitle.Name = "textBoxAppComponentsTitle";
            this.textBoxAppComponentsTitle.Size = new System.Drawing.Size(274, 22);
            this.textBoxAppComponentsTitle.TabIndex = 50;
            this.textBoxAppComponentsTitle.Text = "APPLICATION COMPONENTS";
            this.textBoxAppComponentsTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelAppMetadata
            // 
            this.panelAppMetadata.BackColor = System.Drawing.Color.White;
            this.panelAppMetadata.Controls.Add(this.listViewAppMetadata);
            this.panelAppMetadata.Controls.Add(this.textBoxAppMetadataTitle);
            this.panelAppMetadata.Location = new System.Drawing.Point(43, 6);
            this.panelAppMetadata.Name = "panelAppMetadata";
            this.panelAppMetadata.Size = new System.Drawing.Size(519, 202);
            this.panelAppMetadata.TabIndex = 19;
            // 
            // listViewAppMetadata
            // 
            this.listViewAppMetadata.BackColor = System.Drawing.Color.Azure;
            this.listViewAppMetadata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewAppMetadata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMetadataNumber,
            this.columnHeaderMetadataName,
            this.columnHeaderAppMetadataValue});
            this.listViewAppMetadata.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAppMetadata.ForeColor = System.Drawing.Color.Black;
            this.listViewAppMetadata.FullRowSelect = true;
            this.listViewAppMetadata.GridLines = true;
            this.listViewAppMetadata.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewAppMetadata.HideSelection = false;
            this.listViewAppMetadata.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25});
            this.listViewAppMetadata.Location = new System.Drawing.Point(8, 34);
            this.listViewAppMetadata.Margin = new System.Windows.Forms.Padding(6);
            this.listViewAppMetadata.Name = "listViewAppMetadata";
            this.listViewAppMetadata.Size = new System.Drawing.Size(495, 151);
            this.listViewAppMetadata.TabIndex = 51;
            this.listViewAppMetadata.UseCompatibleStateImageBehavior = false;
            this.listViewAppMetadata.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderMetadataNumber
            // 
            this.columnHeaderMetadataNumber.Text = "#";
            this.columnHeaderMetadataNumber.Width = 27;
            // 
            // columnHeaderMetadataName
            // 
            this.columnHeaderMetadataName.Text = "Name";
            this.columnHeaderMetadataName.Width = 175;
            // 
            // columnHeaderAppMetadataValue
            // 
            this.columnHeaderAppMetadataValue.Text = "Value";
            this.columnHeaderAppMetadataValue.Width = 291;
            // 
            // textBoxAppMetadataTitle
            // 
            this.textBoxAppMetadataTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAppMetadataTitle.BackColor = System.Drawing.Color.Yellow;
            this.textBoxAppMetadataTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAppMetadataTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAppMetadataTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxAppMetadataTitle.Location = new System.Drawing.Point(3, 3);
            this.textBoxAppMetadataTitle.Name = "textBoxAppMetadataTitle";
            this.textBoxAppMetadataTitle.Size = new System.Drawing.Size(513, 22);
            this.textBoxAppMetadataTitle.TabIndex = 50;
            this.textBoxAppMetadataTitle.Text = "APPLICATION METADATA";
            this.textBoxAppMetadataTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelFactorySettings
            // 
            this.panelFactorySettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFactorySettings.BackColor = System.Drawing.Color.White;
            this.panelFactorySettings.Controls.Add(this.textBoxFactorySettingsTitle);
            this.panelFactorySettings.Controls.Add(this.listViewFactorySettings);
            this.panelFactorySettings.Location = new System.Drawing.Point(43, 214);
            this.panelFactorySettings.Name = "panelFactorySettings";
            this.panelFactorySettings.Size = new System.Drawing.Size(519, 313);
            this.panelFactorySettings.TabIndex = 18;
            // 
            // textBoxFactorySettingsTitle
            // 
            this.textBoxFactorySettingsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFactorySettingsTitle.BackColor = System.Drawing.Color.Yellow;
            this.textBoxFactorySettingsTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFactorySettingsTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFactorySettingsTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxFactorySettingsTitle.Location = new System.Drawing.Point(5, 3);
            this.textBoxFactorySettingsTitle.Name = "textBoxFactorySettingsTitle";
            this.textBoxFactorySettingsTitle.Size = new System.Drawing.Size(509, 22);
            this.textBoxFactorySettingsTitle.TabIndex = 50;
            this.textBoxFactorySettingsTitle.Text = "APPLICATION FACTORY SETTINGS";
            this.textBoxFactorySettingsTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listViewFactorySettings
            // 
            this.listViewFactorySettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFactorySettings.BackColor = System.Drawing.Color.Azure;
            this.listViewFactorySettings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewFactorySettings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSettingsNumber,
            this.columnHeaderSettingsName,
            this.columnHeaderSettingsValue});
            this.listViewFactorySettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewFactorySettings.ForeColor = System.Drawing.Color.Black;
            this.listViewFactorySettings.FullRowSelect = true;
            this.listViewFactorySettings.GridLines = true;
            this.listViewFactorySettings.HideSelection = false;
            this.listViewFactorySettings.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem26,
            listViewItem27,
            listViewItem28,
            listViewItem29,
            listViewItem30,
            listViewItem31,
            listViewItem32,
            listViewItem33,
            listViewItem34,
            listViewItem35,
            listViewItem36,
            listViewItem37,
            listViewItem38,
            listViewItem39,
            listViewItem40,
            listViewItem41,
            listViewItem42,
            listViewItem43,
            listViewItem44,
            listViewItem45,
            listViewItem46,
            listViewItem47,
            listViewItem48,
            listViewItem49,
            listViewItem50,
            listViewItem51,
            listViewItem52,
            listViewItem53,
            listViewItem54,
            listViewItem55,
            listViewItem56});
            this.listViewFactorySettings.Location = new System.Drawing.Point(12, 35);
            this.listViewFactorySettings.Margin = new System.Windows.Forms.Padding(6);
            this.listViewFactorySettings.Name = "listViewFactorySettings";
            this.listViewFactorySettings.Size = new System.Drawing.Size(496, 264);
            this.listViewFactorySettings.TabIndex = 16;
            this.listViewFactorySettings.UseCompatibleStateImageBehavior = false;
            this.listViewFactorySettings.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSettingsNumber
            // 
            this.columnHeaderSettingsNumber.Text = "#";
            this.columnHeaderSettingsNumber.Width = 27;
            // 
            // columnHeaderSettingsName
            // 
            this.columnHeaderSettingsName.Text = "Name";
            this.columnHeaderSettingsName.Width = 227;
            // 
            // columnHeaderSettingsValue
            // 
            this.columnHeaderSettingsValue.Text = "Value";
            this.columnHeaderSettingsValue.Width = 522;
            // 
            // tabPageROOT_Database
            // 
            this.tabPageROOT_Database.BackColor = System.Drawing.Color.Honeydew;
            this.tabPageROOT_Database.Controls.Add(this.pictureBoxDbAjpEndLogo);
            this.tabPageROOT_Database.Controls.Add(this.panelDatabaseTables);
            this.tabPageROOT_Database.Controls.Add(this.panelProjectDbFileMetadata);
            this.tabPageROOT_Database.Controls.Add(this.buttonConnection);
            this.tabPageROOT_Database.Location = new System.Drawing.Point(4, 39);
            this.tabPageROOT_Database.Name = "tabPageROOT_Database";
            this.tabPageROOT_Database.Size = new System.Drawing.Size(896, 533);
            this.tabPageROOT_Database.TabIndex = 2;
            this.tabPageROOT_Database.Text = "  Database  ";
            // 
            // pictureBoxDbAjpEndLogo
            // 
            this.pictureBoxDbAjpEndLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDbAjpEndLogo.BackColor = System.Drawing.Color.Azure;
            this.pictureBoxDbAjpEndLogo.Image = global::HenStudio.Properties.Resources.AjpContactInfo;
            this.pictureBoxDbAjpEndLogo.Location = new System.Drawing.Point(497, 365);
            this.pictureBoxDbAjpEndLogo.Name = "pictureBoxDbAjpEndLogo";
            this.pictureBoxDbAjpEndLogo.Size = new System.Drawing.Size(387, 162);
            this.pictureBoxDbAjpEndLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDbAjpEndLogo.TabIndex = 18;
            this.pictureBoxDbAjpEndLogo.TabStop = false;
            this.pictureBoxDbAjpEndLogo.Click += new System.EventHandler(this.pictureBoxDbAjpEndLogo_Click);
            // 
            // panelDatabaseTables
            // 
            this.panelDatabaseTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatabaseTables.BackColor = System.Drawing.Color.White;
            this.panelDatabaseTables.Controls.Add(this.textBoxDatabaseTablesTitle);
            this.panelDatabaseTables.Controls.Add(this.listViewDatabaseTables);
            this.panelDatabaseTables.Location = new System.Drawing.Point(21, 11);
            this.panelDatabaseTables.Name = "panelDatabaseTables";
            this.panelDatabaseTables.Size = new System.Drawing.Size(470, 516);
            this.panelDatabaseTables.TabIndex = 17;
            // 
            // textBoxDatabaseTablesTitle
            // 
            this.textBoxDatabaseTablesTitle.BackColor = System.Drawing.Color.Yellow;
            this.textBoxDatabaseTablesTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDatabaseTablesTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDatabaseTablesTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxDatabaseTablesTitle.Location = new System.Drawing.Point(3, 3);
            this.textBoxDatabaseTablesTitle.Name = "textBoxDatabaseTablesTitle";
            this.textBoxDatabaseTablesTitle.Size = new System.Drawing.Size(464, 22);
            this.textBoxDatabaseTablesTitle.TabIndex = 50;
            this.textBoxDatabaseTablesTitle.Text = "HENSTUDIO TABLES";
            this.textBoxDatabaseTablesTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listViewDatabaseTables
            // 
            this.listViewDatabaseTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDatabaseTables.BackColor = System.Drawing.Color.Azure;
            this.listViewDatabaseTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewDatabaseTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNumber,
            this.columnHeaderTableName,
            this.columnHeaderTableSchema});
            this.listViewDatabaseTables.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDatabaseTables.ForeColor = System.Drawing.Color.Black;
            this.listViewDatabaseTables.FullRowSelect = true;
            this.listViewDatabaseTables.GridLines = true;
            this.listViewDatabaseTables.HideSelection = false;
            this.listViewDatabaseTables.Location = new System.Drawing.Point(10, 35);
            this.listViewDatabaseTables.Margin = new System.Windows.Forms.Padding(6);
            this.listViewDatabaseTables.Name = "listViewDatabaseTables";
            this.listViewDatabaseTables.Size = new System.Drawing.Size(447, 467);
            this.listViewDatabaseTables.TabIndex = 16;
            this.listViewDatabaseTables.UseCompatibleStateImageBehavior = false;
            this.listViewDatabaseTables.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "#";
            this.columnHeaderNumber.Width = 25;
            // 
            // columnHeaderTableName
            // 
            this.columnHeaderTableName.Text = "Table Name";
            this.columnHeaderTableName.Width = 94;
            // 
            // columnHeaderTableSchema
            // 
            this.columnHeaderTableSchema.Text = "Schema";
            this.columnHeaderTableSchema.Width = 328;
            // 
            // panelProjectDbFileMetadata
            // 
            this.panelProjectDbFileMetadata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProjectDbFileMetadata.BackColor = System.Drawing.Color.White;
            this.panelProjectDbFileMetadata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panelProjectDbFileMetadata.Location = new System.Drawing.Point(530, 11);
            this.panelProjectDbFileMetadata.Name = "panelProjectDbFileMetadata";
            this.panelProjectDbFileMetadata.Size = new System.Drawing.Size(350, 237);
            this.panelProjectDbFileMetadata.TabIndex = 14;
            // 
            // textBoxConnServerVersionValue
            // 
            this.textBoxConnServerVersionValue.BackColor = System.Drawing.Color.White;
            this.textBoxConnServerVersionValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnServerVersionValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnServerVersionValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxConnServerVersionValue.Location = new System.Drawing.Point(139, 178);
            this.textBoxConnServerVersionValue.Name = "textBoxConnServerVersionValue";
            this.textBoxConnServerVersionValue.ReadOnly = true;
            this.textBoxConnServerVersionValue.Size = new System.Drawing.Size(198, 18);
            this.textBoxConnServerVersionValue.TabIndex = 49;
            this.textBoxConnServerVersionValue.Text = "Server Version Here";
            // 
            // textBoxConnServerVersion
            // 
            this.textBoxConnServerVersion.BackColor = System.Drawing.Color.White;
            this.textBoxConnServerVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnServerVersion.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnServerVersion.ForeColor = System.Drawing.Color.RoyalBlue;
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
            this.textBoxConnTimeoutValue.BackColor = System.Drawing.Color.White;
            this.textBoxConnTimeoutValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnTimeoutValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnTimeoutValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxConnTimeoutValue.Location = new System.Drawing.Point(139, 134);
            this.textBoxConnTimeoutValue.Name = "textBoxConnTimeoutValue";
            this.textBoxConnTimeoutValue.ReadOnly = true;
            this.textBoxConnTimeoutValue.Size = new System.Drawing.Size(198, 18);
            this.textBoxConnTimeoutValue.TabIndex = 46;
            this.textBoxConnTimeoutValue.Text = "Timeout Here";
            // 
            // textBoxConnTimeout
            // 
            this.textBoxConnTimeout.BackColor = System.Drawing.Color.White;
            this.textBoxConnTimeout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnTimeout.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnTimeout.ForeColor = System.Drawing.Color.RoyalBlue;
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
            this.textBoxConnInitCatalogValue.BackColor = System.Drawing.Color.White;
            this.textBoxConnInitCatalogValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnInitCatalogValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnInitCatalogValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxConnInitCatalogValue.Location = new System.Drawing.Point(139, 112);
            this.textBoxConnInitCatalogValue.Name = "textBoxConnInitCatalogValue";
            this.textBoxConnInitCatalogValue.ReadOnly = true;
            this.textBoxConnInitCatalogValue.Size = new System.Drawing.Size(198, 18);
            this.textBoxConnInitCatalogValue.TabIndex = 44;
            this.textBoxConnInitCatalogValue.Text = "Initial Catalog Here";
            // 
            // textBoxConnInitCatalog
            // 
            this.textBoxConnInitCatalog.BackColor = System.Drawing.Color.White;
            this.textBoxConnInitCatalog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnInitCatalog.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnInitCatalog.ForeColor = System.Drawing.Color.RoyalBlue;
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
            this.textBoxConnWorkstationIDValue.BackColor = System.Drawing.Color.White;
            this.textBoxConnWorkstationIDValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnWorkstationIDValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnWorkstationIDValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxConnWorkstationIDValue.Location = new System.Drawing.Point(139, 88);
            this.textBoxConnWorkstationIDValue.Name = "textBoxConnWorkstationIDValue";
            this.textBoxConnWorkstationIDValue.ReadOnly = true;
            this.textBoxConnWorkstationIDValue.Size = new System.Drawing.Size(198, 18);
            this.textBoxConnWorkstationIDValue.TabIndex = 42;
            this.textBoxConnWorkstationIDValue.Text = "Workstation ID Here";
            // 
            // textBoxConnWorkstationID
            // 
            this.textBoxConnWorkstationID.BackColor = System.Drawing.Color.White;
            this.textBoxConnWorkstationID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnWorkstationID.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnWorkstationID.ForeColor = System.Drawing.Color.RoyalBlue;
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
            this.textBoxConnUserIDValue.BackColor = System.Drawing.Color.White;
            this.textBoxConnUserIDValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnUserIDValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnUserIDValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxConnUserIDValue.Location = new System.Drawing.Point(139, 66);
            this.textBoxConnUserIDValue.Name = "textBoxConnUserIDValue";
            this.textBoxConnUserIDValue.ReadOnly = true;
            this.textBoxConnUserIDValue.Size = new System.Drawing.Size(198, 18);
            this.textBoxConnUserIDValue.TabIndex = 40;
            this.textBoxConnUserIDValue.Text = "User ID Here";
            // 
            // textBoxConnUserID
            // 
            this.textBoxConnUserID.BackColor = System.Drawing.Color.White;
            this.textBoxConnUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnUserID.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnUserID.ForeColor = System.Drawing.Color.RoyalBlue;
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
            this.textBoxConnPacketSizeValue.BackColor = System.Drawing.Color.White;
            this.textBoxConnPacketSizeValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnPacketSizeValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnPacketSizeValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxConnPacketSizeValue.Location = new System.Drawing.Point(139, 156);
            this.textBoxConnPacketSizeValue.Name = "textBoxConnPacketSizeValue";
            this.textBoxConnPacketSizeValue.ReadOnly = true;
            this.textBoxConnPacketSizeValue.Size = new System.Drawing.Size(198, 18);
            this.textBoxConnPacketSizeValue.TabIndex = 39;
            this.textBoxConnPacketSizeValue.Text = "1024 KB";
            // 
            // textBoxConnPacketSize
            // 
            this.textBoxConnPacketSize.BackColor = System.Drawing.Color.White;
            this.textBoxConnPacketSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnPacketSize.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnPacketSize.ForeColor = System.Drawing.Color.RoyalBlue;
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
            this.textBoxConnStateValue.BackColor = System.Drawing.Color.White;
            this.textBoxConnStateValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnStateValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnStateValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxConnStateValue.Location = new System.Drawing.Point(139, 201);
            this.textBoxConnStateValue.Name = "textBoxConnStateValue";
            this.textBoxConnStateValue.ReadOnly = true;
            this.textBoxConnStateValue.Size = new System.Drawing.Size(198, 18);
            this.textBoxConnStateValue.TabIndex = 35;
            this.textBoxConnStateValue.Text = "Closed";
            // 
            // textBoxConnState
            // 
            this.textBoxConnState.BackColor = System.Drawing.Color.White;
            this.textBoxConnState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnState.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnState.ForeColor = System.Drawing.Color.RoyalBlue;
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
            this.textBoxConnDataSourceValue.BackColor = System.Drawing.Color.White;
            this.textBoxConnDataSourceValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnDataSourceValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnDataSourceValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxConnDataSourceValue.Location = new System.Drawing.Point(139, 44);
            this.textBoxConnDataSourceValue.Name = "textBoxConnDataSourceValue";
            this.textBoxConnDataSourceValue.ReadOnly = true;
            this.textBoxConnDataSourceValue.Size = new System.Drawing.Size(198, 18);
            this.textBoxConnDataSourceValue.TabIndex = 33;
            this.textBoxConnDataSourceValue.Text = "Data Source Here";
            // 
            // textBoxConnDataSource
            // 
            this.textBoxConnDataSource.BackColor = System.Drawing.Color.White;
            this.textBoxConnDataSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnDataSource.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnDataSource.ForeColor = System.Drawing.Color.RoyalBlue;
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
            this.textBoxDbConnectionTitle.BackColor = System.Drawing.Color.Yellow;
            this.textBoxDbConnectionTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDbConnectionTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDbConnectionTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxDbConnectionTitle.Location = new System.Drawing.Point(3, 0);
            this.textBoxDbConnectionTitle.Name = "textBoxDbConnectionTitle";
            this.textBoxDbConnectionTitle.Size = new System.Drawing.Size(336, 22);
            this.textBoxDbConnectionTitle.TabIndex = 33;
            this.textBoxDbConnectionTitle.Text = "HENSTUDIO CONNECTION";
            this.textBoxDbConnectionTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonConnection
            // 
            this.buttonConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnection.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonConnection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonConnection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnection.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnection.ForeColor = System.Drawing.Color.White;
            this.buttonConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConnection.Location = new System.Drawing.Point(531, 254);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Padding = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.buttonConnection.Size = new System.Drawing.Size(349, 50);
            this.buttonConnection.TabIndex = 15;
            this.buttonConnection.Text = "Check Database Connection";
            this.buttonConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConnection.UseVisualStyleBackColor = false;
            this.buttonConnection.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // tabPageROOT_License
            // 
            this.tabPageROOT_License.BackColor = System.Drawing.Color.Honeydew;
            this.tabPageROOT_License.Controls.Add(this.tabControlLicense);
            this.tabPageROOT_License.Location = new System.Drawing.Point(4, 39);
            this.tabPageROOT_License.Name = "tabPageROOT_License";
            this.tabPageROOT_License.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageROOT_License.Size = new System.Drawing.Size(896, 533);
            this.tabPageROOT_License.TabIndex = 1;
            this.tabPageROOT_License.Text = "  License  ";
            // 
            // tabControlLicense
            // 
            this.tabControlLicense.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlLicense.Controls.Add(this.tabPageLicenseScorecard);
            this.tabControlLicense.Controls.Add(this.tabPageLicenseFile);
            this.tabControlLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlLicense.Location = new System.Drawing.Point(3, 3);
            this.tabControlLicense.Name = "tabControlLicense";
            this.tabControlLicense.SelectedIndex = 0;
            this.tabControlLicense.Size = new System.Drawing.Size(890, 527);
            this.tabControlLicense.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlLicense.TabIndex = 56;
            // 
            // tabPageLicenseScorecard
            // 
            this.tabPageLicenseScorecard.BackColor = System.Drawing.Color.Honeydew;
            this.tabPageLicenseScorecard.Controls.Add(this.pictureBoxAjpEngLogo);
            this.tabPageLicenseScorecard.Controls.Add(this.textBoxOverallStatus);
            this.tabPageLicenseScorecard.Controls.Add(this.panelScorecardSummary);
            this.tabPageLicenseScorecard.Controls.Add(this.panelDeviceUser);
            this.tabPageLicenseScorecard.Controls.Add(this.panelScorecardTable);
            this.tabPageLicenseScorecard.Location = new System.Drawing.Point(4, 32);
            this.tabPageLicenseScorecard.Name = "tabPageLicenseScorecard";
            this.tabPageLicenseScorecard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLicenseScorecard.Size = new System.Drawing.Size(882, 491);
            this.tabPageLicenseScorecard.TabIndex = 1;
            this.tabPageLicenseScorecard.Text = "  Scorecard  ";
            // 
            // pictureBoxAjpEngLogo
            // 
            this.pictureBoxAjpEngLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAjpEngLogo.BackColor = System.Drawing.Color.Azure;
            this.pictureBoxAjpEngLogo.Image = global::HenStudio.Properties.Resources.AjpContactInfo;
            this.pictureBoxAjpEngLogo.Location = new System.Drawing.Point(491, 320);
            this.pictureBoxAjpEngLogo.Name = "pictureBoxAjpEngLogo";
            this.pictureBoxAjpEngLogo.Size = new System.Drawing.Size(387, 162);
            this.pictureBoxAjpEngLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAjpEngLogo.TabIndex = 12;
            this.pictureBoxAjpEngLogo.TabStop = false;
            this.pictureBoxAjpEngLogo.Click += new System.EventHandler(this.pictureBoxAjpEngLogo_Click);
            // 
            // textBoxOverallStatus
            // 
            this.textBoxOverallStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOverallStatus.BackColor = System.Drawing.Color.Green;
            this.textBoxOverallStatus.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOverallStatus.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxOverallStatus.Location = new System.Drawing.Point(489, 217);
            this.textBoxOverallStatus.Name = "textBoxOverallStatus";
            this.textBoxOverallStatus.Size = new System.Drawing.Size(387, 33);
            this.textBoxOverallStatus.TabIndex = 11;
            this.textBoxOverallStatus.Text = "VALID LICENSE";
            this.textBoxOverallStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelScorecardSummary
            // 
            this.panelScorecardSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelScorecardSummary.BackColor = System.Drawing.Color.White;
            this.panelScorecardSummary.Controls.Add(this.pictureBoxInvalid);
            this.panelScorecardSummary.Controls.Add(this.labelInvalidTotal);
            this.panelScorecardSummary.Controls.Add(this.pictureBoxValid);
            this.panelScorecardSummary.Controls.Add(this.labelVaildTotal);
            this.panelScorecardSummary.Controls.Add(this.textBoxScorecardSummary);
            this.panelScorecardSummary.Location = new System.Drawing.Point(489, 117);
            this.panelScorecardSummary.Name = "panelScorecardSummary";
            this.panelScorecardSummary.Size = new System.Drawing.Size(387, 90);
            this.panelScorecardSummary.TabIndex = 2;
            // 
            // pictureBoxInvalid
            // 
            this.pictureBoxInvalid.Image = global::HenStudio.Properties.Resources.InValidLarge;
            this.pictureBoxInvalid.Location = new System.Drawing.Point(223, 35);
            this.pictureBoxInvalid.Name = "pictureBoxInvalid";
            this.pictureBoxInvalid.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxInvalid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInvalid.TabIndex = 45;
            this.pictureBoxInvalid.TabStop = false;
            // 
            // labelInvalidTotal
            // 
            this.labelInvalidTotal.AutoSize = true;
            this.labelInvalidTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalidTotal.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelInvalidTotal.Location = new System.Drawing.Point(269, 45);
            this.labelInvalidTotal.Name = "labelInvalidTotal";
            this.labelInvalidTotal.Size = new System.Drawing.Size(18, 20);
            this.labelInvalidTotal.TabIndex = 44;
            this.labelInvalidTotal.Text = "0";
            this.labelInvalidTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxValid
            // 
            this.pictureBoxValid.Image = global::HenStudio.Properties.Resources.ValidLarge;
            this.pictureBoxValid.Location = new System.Drawing.Point(121, 35);
            this.pictureBoxValid.Name = "pictureBoxValid";
            this.pictureBoxValid.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxValid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxValid.TabIndex = 43;
            this.pictureBoxValid.TabStop = false;
            // 
            // labelVaildTotal
            // 
            this.labelVaildTotal.AutoSize = true;
            this.labelVaildTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVaildTotal.ForeColor = System.Drawing.Color.Green;
            this.labelVaildTotal.Location = new System.Drawing.Point(167, 45);
            this.labelVaildTotal.Name = "labelVaildTotal";
            this.labelVaildTotal.Size = new System.Drawing.Size(27, 20);
            this.labelVaildTotal.TabIndex = 42;
            this.labelVaildTotal.Text = "20";
            this.labelVaildTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxScorecardSummary
            // 
            this.textBoxScorecardSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxScorecardSummary.BackColor = System.Drawing.Color.Yellow;
            this.textBoxScorecardSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxScorecardSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScorecardSummary.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxScorecardSummary.Location = new System.Drawing.Point(3, 3);
            this.textBoxScorecardSummary.Name = "textBoxScorecardSummary";
            this.textBoxScorecardSummary.ReadOnly = true;
            this.textBoxScorecardSummary.Size = new System.Drawing.Size(381, 22);
            this.textBoxScorecardSummary.TabIndex = 40;
            this.textBoxScorecardSummary.TabStop = false;
            this.textBoxScorecardSummary.Text = "SUMMARY";
            this.textBoxScorecardSummary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelDeviceUser
            // 
            this.panelDeviceUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDeviceUser.BackColor = System.Drawing.Color.White;
            this.panelDeviceUser.Controls.Add(this.labelFullname);
            this.panelDeviceUser.Controls.Add(this.textBox2);
            this.panelDeviceUser.Controls.Add(this.pictureBoxRunning);
            this.panelDeviceUser.Controls.Add(this.labelUser);
            this.panelDeviceUser.Controls.Add(this.textBoxUser);
            this.panelDeviceUser.Controls.Add(this.labelDevice);
            this.panelDeviceUser.Controls.Add(this.textBoxDevice);
            this.panelDeviceUser.Controls.Add(this.textBoxDeviceUserTITLE);
            this.panelDeviceUser.Location = new System.Drawing.Point(489, 4);
            this.panelDeviceUser.Name = "panelDeviceUser";
            this.panelDeviceUser.Size = new System.Drawing.Size(387, 103);
            this.panelDeviceUser.TabIndex = 1;
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullname.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelFullname.Location = new System.Drawing.Point(105, 74);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(81, 20);
            this.labelFullname.TabIndex = 46;
            this.labelFullname.Text = "Fullname: ";
            this.labelFullname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(192, 74);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 45;
            this.textBox2.Text = "NUC\\baseb";
            // 
            // pictureBoxRunning
            // 
            this.pictureBoxRunning.Image = global::HenStudio.Properties.Resources.RunningLarge;
            this.pictureBoxRunning.Location = new System.Drawing.Point(6, 31);
            this.pictureBoxRunning.Name = "pictureBoxRunning";
            this.pictureBoxRunning.Size = new System.Drawing.Size(93, 63);
            this.pictureBoxRunning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRunning.TabIndex = 44;
            this.pictureBoxRunning.TabStop = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelUser.Location = new System.Drawing.Point(136, 54);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(50, 20);
            this.labelUser.TabIndex = 43;
            this.labelUser.Text = "User: ";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.White;
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.ForeColor = System.Drawing.Color.Black;
            this.textBoxUser.Location = new System.Drawing.Point(192, 54);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ReadOnly = true;
            this.textBoxUser.Size = new System.Drawing.Size(180, 20);
            this.textBoxUser.TabIndex = 42;
            this.textBoxUser.Text = "baseb";
            // 
            // labelDevice
            // 
            this.labelDevice.AutoSize = true;
            this.labelDevice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelDevice.Location = new System.Drawing.Point(123, 33);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(63, 20);
            this.labelDevice.TabIndex = 41;
            this.labelDevice.Text = "Device: ";
            this.labelDevice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxDevice
            // 
            this.textBoxDevice.BackColor = System.Drawing.Color.White;
            this.textBoxDevice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDevice.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDevice.ForeColor = System.Drawing.Color.Black;
            this.textBoxDevice.Location = new System.Drawing.Point(192, 33);
            this.textBoxDevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDevice.Name = "textBoxDevice";
            this.textBoxDevice.ReadOnly = true;
            this.textBoxDevice.Size = new System.Drawing.Size(180, 20);
            this.textBoxDevice.TabIndex = 40;
            this.textBoxDevice.Text = "NUC";
            // 
            // textBoxDeviceUserTITLE
            // 
            this.textBoxDeviceUserTITLE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDeviceUserTITLE.BackColor = System.Drawing.Color.Yellow;
            this.textBoxDeviceUserTITLE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDeviceUserTITLE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeviceUserTITLE.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxDeviceUserTITLE.Location = new System.Drawing.Point(3, 3);
            this.textBoxDeviceUserTITLE.Name = "textBoxDeviceUserTITLE";
            this.textBoxDeviceUserTITLE.ReadOnly = true;
            this.textBoxDeviceUserTITLE.Size = new System.Drawing.Size(381, 22);
            this.textBoxDeviceUserTITLE.TabIndex = 39;
            this.textBoxDeviceUserTITLE.TabStop = false;
            this.textBoxDeviceUserTITLE.Text = "DEVICE - USER";
            this.textBoxDeviceUserTITLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelScorecardTable
            // 
            this.panelScorecardTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelScorecardTable.BackColor = System.Drawing.Color.White;
            this.panelScorecardTable.Controls.Add(this.dataGridViewScoreCard);
            this.panelScorecardTable.Controls.Add(this.textBoxLicenseScorecardTITLE);
            this.panelScorecardTable.Location = new System.Drawing.Point(7, 4);
            this.panelScorecardTable.Margin = new System.Windows.Forms.Padding(6);
            this.panelScorecardTable.Name = "panelScorecardTable";
            this.panelScorecardTable.Padding = new System.Windows.Forms.Padding(3);
            this.panelScorecardTable.Size = new System.Drawing.Size(475, 478);
            this.panelScorecardTable.TabIndex = 0;
            // 
            // dataGridViewScoreCard
            // 
            this.dataGridViewScoreCard.AllowUserToAddRows = false;
            this.dataGridViewScoreCard.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewScoreCard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewScoreCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewScoreCard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewScoreCard.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewScoreCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewScoreCard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewScoreCard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewScoreCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScoreCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnState,
            this.ColumnProperty,
            this.ColumnValue});
            this.dataGridViewScoreCard.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridViewScoreCard.Location = new System.Drawing.Point(6, 28);
            this.dataGridViewScoreCard.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewScoreCard.Name = "dataGridViewScoreCard";
            this.dataGridViewScoreCard.ReadOnly = true;
            this.dataGridViewScoreCard.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewScoreCard.RowHeadersVisible = false;
            this.dataGridViewScoreCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewScoreCard.Size = new System.Drawing.Size(470, 406);
            this.dataGridViewScoreCard.TabIndex = 38;
            // 
            // ColumnID
            // 
            this.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.ToolTipText = "License Property ID";
            this.ColumnID.Width = 50;
            // 
            // ColumnState
            // 
            this.ColumnState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnState.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnState.HeaderText = "STATUS";
            this.ColumnState.MinimumWidth = 60;
            this.ColumnState.Name = "ColumnState";
            this.ColumnState.ReadOnly = true;
            this.ColumnState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnState.ToolTipText = "License Property Status";
            this.ColumnState.Width = 88;
            // 
            // ColumnProperty
            // 
            this.ColumnProperty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnProperty.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnProperty.HeaderText = "PROPERTY";
            this.ColumnProperty.MinimumWidth = 60;
            this.ColumnProperty.Name = "ColumnProperty";
            this.ColumnProperty.ReadOnly = true;
            this.ColumnProperty.ToolTipText = "License Property";
            this.ColumnProperty.Width = 109;
            // 
            // ColumnValue
            // 
            this.ColumnValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnValue.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnValue.HeaderText = "VALUE";
            this.ColumnValue.MinimumWidth = 60;
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.ReadOnly = true;
            this.ColumnValue.ToolTipText = "License File Property Value";
            // 
            // textBoxLicenseScorecardTITLE
            // 
            this.textBoxLicenseScorecardTITLE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLicenseScorecardTITLE.BackColor = System.Drawing.Color.Yellow;
            this.textBoxLicenseScorecardTITLE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLicenseScorecardTITLE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLicenseScorecardTITLE.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxLicenseScorecardTITLE.Location = new System.Drawing.Point(6, 6);
            this.textBoxLicenseScorecardTITLE.Name = "textBoxLicenseScorecardTITLE";
            this.textBoxLicenseScorecardTITLE.ReadOnly = true;
            this.textBoxLicenseScorecardTITLE.Size = new System.Drawing.Size(463, 22);
            this.textBoxLicenseScorecardTITLE.TabIndex = 37;
            this.textBoxLicenseScorecardTITLE.TabStop = false;
            this.textBoxLicenseScorecardTITLE.Text = "LICENSE FILE SCORECARD";
            this.textBoxLicenseScorecardTITLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPageLicenseFile
            // 
            this.tabPageLicenseFile.BackColor = System.Drawing.Color.Honeydew;
            this.tabPageLicenseFile.Controls.Add(this.panelLicenseType);
            this.tabPageLicenseFile.Controls.Add(this.panelSupplier);
            this.tabPageLicenseFile.Controls.Add(this.panelCustomerContact);
            this.tabPageLicenseFile.Controls.Add(this.panelProduct);
            this.tabPageLicenseFile.Controls.Add(this.panelLicense);
            this.tabPageLicenseFile.Location = new System.Drawing.Point(4, 32);
            this.tabPageLicenseFile.Name = "tabPageLicenseFile";
            this.tabPageLicenseFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLicenseFile.Size = new System.Drawing.Size(882, 491);
            this.tabPageLicenseFile.TabIndex = 0;
            this.tabPageLicenseFile.Text = "   File  ";
            // 
            // panelLicenseType
            // 
            this.panelLicenseType.BackColor = System.Drawing.Color.White;
            this.panelLicenseType.Controls.Add(this.pictureBoxKeys);
            this.panelLicenseType.Controls.Add(this.textBoxLicenseTypeTitle);
            this.panelLicenseType.Controls.Add(this.pictureBoxSite);
            this.panelLicenseType.Controls.Add(this.textBoxUsername);
            this.panelLicenseType.Controls.Add(this.textBoxGroup);
            this.panelLicenseType.Controls.Add(this.labelDeviceName);
            this.panelLicenseType.Controls.Add(this.textBoxDivision);
            this.panelLicenseType.Controls.Add(this.labelLicenseType);
            this.panelLicenseType.Controls.Add(this.textBoxDeviceName);
            this.panelLicenseType.Controls.Add(this.labelGroup);
            this.panelLicenseType.Controls.Add(this.labelCorporation);
            this.panelLicenseType.Controls.Add(this.labelUsername);
            this.panelLicenseType.Controls.Add(this.textBoxCorporation);
            this.panelLicenseType.Controls.Add(this.labelDivision);
            this.panelLicenseType.Controls.Add(this.textBoxLicenseType);
            this.panelLicenseType.Location = new System.Drawing.Point(36, 224);
            this.panelLicenseType.Name = "panelLicenseType";
            this.panelLicenseType.Size = new System.Drawing.Size(817, 146);
            this.panelLicenseType.TabIndex = 54;
            // 
            // pictureBoxKeys
            // 
            this.pictureBoxKeys.BackColor = System.Drawing.Color.White;
            this.pictureBoxKeys.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKeys.Image")));
            this.pictureBoxKeys.Location = new System.Drawing.Point(667, 32);
            this.pictureBoxKeys.Name = "pictureBoxKeys";
            this.pictureBoxKeys.Size = new System.Drawing.Size(145, 88);
            this.pictureBoxKeys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKeys.TabIndex = 50;
            this.pictureBoxKeys.TabStop = false;
            // 
            // textBoxLicenseTypeTitle
            // 
            this.textBoxLicenseTypeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLicenseTypeTitle.BackColor = System.Drawing.Color.Yellow;
            this.textBoxLicenseTypeTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLicenseTypeTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLicenseTypeTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxLicenseTypeTitle.Location = new System.Drawing.Point(3, 3);
            this.textBoxLicenseTypeTitle.Name = "textBoxLicenseTypeTitle";
            this.textBoxLicenseTypeTitle.ReadOnly = true;
            this.textBoxLicenseTypeTitle.Size = new System.Drawing.Size(811, 22);
            this.textBoxLicenseTypeTitle.TabIndex = 37;
            this.textBoxLicenseTypeTitle.TabStop = false;
            this.textBoxLicenseTypeTitle.Text = "LICENSE TYPE";
            this.textBoxLicenseTypeTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxSite
            // 
            this.pictureBoxSite.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBoxSite.Location = new System.Drawing.Point(11, 73);
            this.pictureBoxSite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSite.Name = "pictureBoxSite";
            this.pictureBoxSite.Size = new System.Drawing.Size(650, 6);
            this.pictureBoxSite.TabIndex = 49;
            this.pictureBoxSite.TabStop = false;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.White;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsername.Location = new System.Drawing.Point(193, 37);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(147, 20);
            this.textBoxUsername.TabIndex = 44;
            this.textBoxUsername.Text = "Joey Bots";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.BackColor = System.Drawing.Color.White;
            this.textBoxGroup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroup.ForeColor = System.Drawing.Color.Black;
            this.textBoxGroup.Location = new System.Drawing.Point(114, 115);
            this.textBoxGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.ReadOnly = true;
            this.textBoxGroup.Size = new System.Drawing.Size(215, 20);
            this.textBoxGroup.TabIndex = 42;
            this.textBoxGroup.Text = "Heat Exchanger Group";
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.AutoSize = true;
            this.labelDeviceName.BackColor = System.Drawing.Color.White;
            this.labelDeviceName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeviceName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelDeviceName.Location = new System.Drawing.Point(352, 37);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(59, 20);
            this.labelDeviceName.TabIndex = 21;
            this.labelDeviceName.Text = "Device:";
            this.labelDeviceName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxDivision
            // 
            this.textBoxDivision.BackColor = System.Drawing.Color.White;
            this.textBoxDivision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDivision.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDivision.ForeColor = System.Drawing.Color.Black;
            this.textBoxDivision.Location = new System.Drawing.Point(420, 115);
            this.textBoxDivision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDivision.Name = "textBoxDivision";
            this.textBoxDivision.ReadOnly = true;
            this.textBoxDivision.Size = new System.Drawing.Size(239, 20);
            this.textBoxDivision.TabIndex = 40;
            this.textBoxDivision.Text = "Research and Development";
            // 
            // labelLicenseType
            // 
            this.labelLicenseType.AutoSize = true;
            this.labelLicenseType.BackColor = System.Drawing.Color.White;
            this.labelLicenseType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicenseType.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelLicenseType.Location = new System.Drawing.Point(13, 37);
            this.labelLicenseType.Name = "labelLicenseType";
            this.labelLicenseType.Size = new System.Drawing.Size(46, 20);
            this.labelLicenseType.TabIndex = 10;
            this.labelLicenseType.Text = "Type:";
            this.labelLicenseType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxDeviceName
            // 
            this.textBoxDeviceName.BackColor = System.Drawing.Color.White;
            this.textBoxDeviceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDeviceName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeviceName.ForeColor = System.Drawing.Color.Black;
            this.textBoxDeviceName.Location = new System.Drawing.Point(415, 37);
            this.textBoxDeviceName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDeviceName.Name = "textBoxDeviceName";
            this.textBoxDeviceName.ReadOnly = true;
            this.textBoxDeviceName.Size = new System.Drawing.Size(244, 20);
            this.textBoxDeviceName.TabIndex = 22;
            this.textBoxDeviceName.Text = "GM-DESKTOP";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.BackColor = System.Drawing.Color.White;
            this.labelGroup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelGroup.Location = new System.Drawing.Point(51, 115);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(57, 20);
            this.labelGroup.TabIndex = 41;
            this.labelGroup.Text = "Group:";
            this.labelGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCorporation
            // 
            this.labelCorporation.AutoSize = true;
            this.labelCorporation.BackColor = System.Drawing.Color.White;
            this.labelCorporation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorporation.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelCorporation.Location = new System.Drawing.Point(11, 87);
            this.labelCorporation.Name = "labelCorporation";
            this.labelCorporation.Size = new System.Drawing.Size(97, 20);
            this.labelCorporation.TabIndex = 29;
            this.labelCorporation.Text = "Corporation:";
            this.labelCorporation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.White;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelUsername.Location = new System.Drawing.Point(143, 37);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(46, 20);
            this.labelUsername.TabIndex = 43;
            this.labelUsername.Text = "User:";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCorporation
            // 
            this.textBoxCorporation.BackColor = System.Drawing.Color.White;
            this.textBoxCorporation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCorporation.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorporation.ForeColor = System.Drawing.Color.Black;
            this.textBoxCorporation.Location = new System.Drawing.Point(114, 87);
            this.textBoxCorporation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCorporation.Name = "textBoxCorporation";
            this.textBoxCorporation.ReadOnly = true;
            this.textBoxCorporation.Size = new System.Drawing.Size(217, 20);
            this.textBoxCorporation.TabIndex = 38;
            this.textBoxCorporation.Text = "ExxonMobile";
            // 
            // labelDivision
            // 
            this.labelDivision.AutoSize = true;
            this.labelDivision.BackColor = System.Drawing.Color.White;
            this.labelDivision.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDivision.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelDivision.Location = new System.Drawing.Point(346, 115);
            this.labelDivision.Name = "labelDivision";
            this.labelDivision.Size = new System.Drawing.Size(69, 20);
            this.labelDivision.TabIndex = 39;
            this.labelDivision.Text = "Division:";
            this.labelDivision.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxLicenseType
            // 
            this.textBoxLicenseType.BackColor = System.Drawing.Color.White;
            this.textBoxLicenseType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLicenseType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLicenseType.ForeColor = System.Drawing.Color.Black;
            this.textBoxLicenseType.Location = new System.Drawing.Point(65, 37);
            this.textBoxLicenseType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLicenseType.Name = "textBoxLicenseType";
            this.textBoxLicenseType.ReadOnly = true;
            this.textBoxLicenseType.Size = new System.Drawing.Size(54, 20);
            this.textBoxLicenseType.TabIndex = 38;
            this.textBoxLicenseType.Text = "SEAT";
            // 
            // panelSupplier
            // 
            this.panelSupplier.BackColor = System.Drawing.Color.White;
            this.panelSupplier.Controls.Add(this.textBoxSupplierTitle);
            this.panelSupplier.Controls.Add(this.textBoxSupplierUrl);
            this.panelSupplier.Controls.Add(this.labelSupplierUrl);
            this.panelSupplier.Controls.Add(this.labelAuthor);
            this.panelSupplier.Controls.Add(this.textBoxSupplierName);
            this.panelSupplier.Controls.Add(this.textBoxAuthor);
            this.panelSupplier.Controls.Add(this.labelSupplierName);
            this.panelSupplier.Location = new System.Drawing.Point(36, 8);
            this.panelSupplier.Name = "panelSupplier";
            this.panelSupplier.Size = new System.Drawing.Size(405, 112);
            this.panelSupplier.TabIndex = 51;
            // 
            // textBoxSupplierTitle
            // 
            this.textBoxSupplierTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSupplierTitle.BackColor = System.Drawing.Color.Yellow;
            this.textBoxSupplierTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSupplierTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupplierTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxSupplierTitle.Location = new System.Drawing.Point(5, 2);
            this.textBoxSupplierTitle.Name = "textBoxSupplierTitle";
            this.textBoxSupplierTitle.ReadOnly = true;
            this.textBoxSupplierTitle.Size = new System.Drawing.Size(397, 22);
            this.textBoxSupplierTitle.TabIndex = 36;
            this.textBoxSupplierTitle.TabStop = false;
            this.textBoxSupplierTitle.Text = "SUPPLIER";
            this.textBoxSupplierTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSupplierUrl
            // 
            this.textBoxSupplierUrl.BackColor = System.Drawing.Color.White;
            this.textBoxSupplierUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSupplierUrl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupplierUrl.ForeColor = System.Drawing.Color.Black;
            this.textBoxSupplierUrl.Location = new System.Drawing.Point(129, 84);
            this.textBoxSupplierUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSupplierUrl.Name = "textBoxSupplierUrl";
            this.textBoxSupplierUrl.ReadOnly = true;
            this.textBoxSupplierUrl.Size = new System.Drawing.Size(240, 20);
            this.textBoxSupplierUrl.TabIndex = 35;
            this.textBoxSupplierUrl.Text = "http:://www.AJPEngineering.com";
            // 
            // labelSupplierUrl
            // 
            this.labelSupplierUrl.AutoSize = true;
            this.labelSupplierUrl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierUrl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelSupplierUrl.Location = new System.Drawing.Point(21, 84);
            this.labelSupplierUrl.Name = "labelSupplierUrl";
            this.labelSupplierUrl.Size = new System.Drawing.Size(103, 20);
            this.labelSupplierUrl.TabIndex = 34;
            this.labelSupplierUrl.Text = "Supplier URL:";
            this.labelSupplierUrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelAuthor.Location = new System.Drawing.Point(56, 34);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(68, 20);
            this.labelAuthor.TabIndex = 31;
            this.labelAuthor.Text = "Author: ";
            this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSupplierName
            // 
            this.textBoxSupplierName.BackColor = System.Drawing.Color.White;
            this.textBoxSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSupplierName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupplierName.ForeColor = System.Drawing.Color.Black;
            this.textBoxSupplierName.Location = new System.Drawing.Point(129, 59);
            this.textBoxSupplierName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSupplierName.Name = "textBoxSupplierName";
            this.textBoxSupplierName.ReadOnly = true;
            this.textBoxSupplierName.Size = new System.Drawing.Size(240, 20);
            this.textBoxSupplierName.TabIndex = 33;
            this.textBoxSupplierName.Text = "AJP Engineering";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.BackColor = System.Drawing.Color.White;
            this.textBoxAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthor.ForeColor = System.Drawing.Color.Black;
            this.textBoxAuthor.Location = new System.Drawing.Point(129, 33);
            this.textBoxAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.ReadOnly = true;
            this.textBoxAuthor.Size = new System.Drawing.Size(240, 20);
            this.textBoxAuthor.TabIndex = 30;
            this.textBoxAuthor.Text = "AJP Engineering";
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelSupplierName.Location = new System.Drawing.Point(7, 59);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(116, 20);
            this.labelSupplierName.TabIndex = 32;
            this.labelSupplierName.Text = "Supplier Name:";
            this.labelSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelCustomerContact
            // 
            this.panelCustomerContact.BackColor = System.Drawing.Color.White;
            this.panelCustomerContact.Controls.Add(this.textBoxCustomerEmail);
            this.panelCustomerContact.Controls.Add(this.textBoxCustomerContactTitle);
            this.panelCustomerContact.Controls.Add(this.labelCustomerEmail);
            this.panelCustomerContact.Controls.Add(this.labelCustomerName);
            this.panelCustomerContact.Controls.Add(this.textBoxCustomerName);
            this.panelCustomerContact.Location = new System.Drawing.Point(448, 6);
            this.panelCustomerContact.Name = "panelCustomerContact";
            this.panelCustomerContact.Size = new System.Drawing.Size(405, 112);
            this.panelCustomerContact.TabIndex = 52;
            // 
            // textBoxCustomerEmail
            // 
            this.textBoxCustomerEmail.BackColor = System.Drawing.Color.White;
            this.textBoxCustomerEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCustomerEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerEmail.ForeColor = System.Drawing.Color.Black;
            this.textBoxCustomerEmail.Location = new System.Drawing.Point(86, 79);
            this.textBoxCustomerEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCustomerEmail.Name = "textBoxCustomerEmail";
            this.textBoxCustomerEmail.ReadOnly = true;
            this.textBoxCustomerEmail.Size = new System.Drawing.Size(258, 20);
            this.textBoxCustomerEmail.TabIndex = 35;
            this.textBoxCustomerEmail.Text = "BillCashman@exxon.com";
            // 
            // textBoxCustomerContactTitle
            // 
            this.textBoxCustomerContactTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomerContactTitle.BackColor = System.Drawing.Color.Yellow;
            this.textBoxCustomerContactTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCustomerContactTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerContactTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxCustomerContactTitle.Location = new System.Drawing.Point(5, 3);
            this.textBoxCustomerContactTitle.Name = "textBoxCustomerContactTitle";
            this.textBoxCustomerContactTitle.ReadOnly = true;
            this.textBoxCustomerContactTitle.Size = new System.Drawing.Size(397, 22);
            this.textBoxCustomerContactTitle.TabIndex = 36;
            this.textBoxCustomerContactTitle.TabStop = false;
            this.textBoxCustomerContactTitle.Text = "CUSTOMER CONTACT";
            this.textBoxCustomerContactTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCustomerEmail
            // 
            this.labelCustomerEmail.AutoSize = true;
            this.labelCustomerEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerEmail.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelCustomerEmail.Location = new System.Drawing.Point(29, 79);
            this.labelCustomerEmail.Name = "labelCustomerEmail";
            this.labelCustomerEmail.Size = new System.Drawing.Size(51, 20);
            this.labelCustomerEmail.TabIndex = 34;
            this.labelCustomerEmail.Text = "Email:";
            this.labelCustomerEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelCustomerName.Location = new System.Drawing.Point(29, 41);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(127, 20);
            this.labelCustomerName.TabIndex = 32;
            this.labelCustomerName.Text = "Customer Name:";
            this.labelCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.BackColor = System.Drawing.Color.White;
            this.textBoxCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerName.ForeColor = System.Drawing.Color.Black;
            this.textBoxCustomerName.Location = new System.Drawing.Point(162, 41);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.ReadOnly = true;
            this.textBoxCustomerName.Size = new System.Drawing.Size(195, 20);
            this.textBoxCustomerName.TabIndex = 33;
            this.textBoxCustomerName.Text = "Bill Cashman";
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.Color.White;
            this.panelProduct.Controls.Add(this.textBoxProductCode);
            this.panelProduct.Controls.Add(this.textBoxProductTitle);
            this.panelProduct.Controls.Add(this.labelProductCode);
            this.panelProduct.Controls.Add(this.labelProductName);
            this.panelProduct.Controls.Add(this.textBoxVersion);
            this.panelProduct.Controls.Add(this.textBoxProductName);
            this.panelProduct.Controls.Add(this.labelVersion);
            this.panelProduct.Controls.Add(this.labelSerialNumber);
            this.panelProduct.Controls.Add(this.textBoxSerialNumber);
            this.panelProduct.Location = new System.Drawing.Point(36, 123);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(817, 97);
            this.panelProduct.TabIndex = 53;
            // 
            // textBoxProductCode
            // 
            this.textBoxProductCode.BackColor = System.Drawing.Color.White;
            this.textBoxProductCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProductCode.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductCode.ForeColor = System.Drawing.Color.Black;
            this.textBoxProductCode.Location = new System.Drawing.Point(130, 63);
            this.textBoxProductCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProductCode.Name = "textBoxProductCode";
            this.textBoxProductCode.ReadOnly = true;
            this.textBoxProductCode.Size = new System.Drawing.Size(319, 20);
            this.textBoxProductCode.TabIndex = 37;
            this.textBoxProductCode.Text = "{3378CA35-F929-4E12-B8C7-0102DCE47C81}";
            // 
            // textBoxProductTitle
            // 
            this.textBoxProductTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductTitle.BackColor = System.Drawing.Color.Yellow;
            this.textBoxProductTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProductTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxProductTitle.Location = new System.Drawing.Point(3, 2);
            this.textBoxProductTitle.Name = "textBoxProductTitle";
            this.textBoxProductTitle.ReadOnly = true;
            this.textBoxProductTitle.Size = new System.Drawing.Size(811, 22);
            this.textBoxProductTitle.TabIndex = 37;
            this.textBoxProductTitle.TabStop = false;
            this.textBoxProductTitle.Text = "PRODUCT";
            this.textBoxProductTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelProductCode
            // 
            this.labelProductCode.AutoSize = true;
            this.labelProductCode.BackColor = System.Drawing.Color.White;
            this.labelProductCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductCode.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelProductCode.Location = new System.Drawing.Point(18, 63);
            this.labelProductCode.Name = "labelProductCode";
            this.labelProductCode.Size = new System.Drawing.Size(107, 20);
            this.labelProductCode.TabIndex = 36;
            this.labelProductCode.Text = "Product Code:";
            this.labelProductCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.BackColor = System.Drawing.Color.White;
            this.labelProductName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelProductName.Location = new System.Drawing.Point(11, 34);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(114, 20);
            this.labelProductName.TabIndex = 32;
            this.labelProductName.Text = "Product Name:";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.BackColor = System.Drawing.Color.White;
            this.textBoxVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVersion.ForeColor = System.Drawing.Color.Black;
            this.textBoxVersion.Location = new System.Drawing.Point(412, 36);
            this.textBoxVersion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.ReadOnly = true;
            this.textBoxVersion.Size = new System.Drawing.Size(53, 20);
            this.textBoxVersion.TabIndex = 35;
            this.textBoxVersion.Text = "1.0.1";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.Color.White;
            this.textBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.ForeColor = System.Drawing.Color.Black;
            this.textBoxProductName.Location = new System.Drawing.Point(130, 34);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.ReadOnly = true;
            this.textBoxProductName.Size = new System.Drawing.Size(211, 20);
            this.textBoxProductName.TabIndex = 33;
            this.textBoxProductName.Text = "AJP HEN Studio 1.0";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.White;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelVersion.Location = new System.Drawing.Point(342, 36);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(65, 20);
            this.labelVersion.TabIndex = 34;
            this.labelVersion.Text = "Version:";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.BackColor = System.Drawing.Color.White;
            this.labelSerialNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerialNumber.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelSerialNumber.Location = new System.Drawing.Point(473, 63);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(118, 20);
            this.labelSerialNumber.TabIndex = 27;
            this.labelSerialNumber.Text = "Serial Number: ";
            this.labelSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.BackColor = System.Drawing.Color.White;
            this.textBoxSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSerialNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSerialNumber.ForeColor = System.Drawing.Color.Black;
            this.textBoxSerialNumber.Location = new System.Drawing.Point(597, 63);
            this.textBoxSerialNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.ReadOnly = true;
            this.textBoxSerialNumber.Size = new System.Drawing.Size(111, 20);
            this.textBoxSerialNumber.TabIndex = 18;
            this.textBoxSerialNumber.Text = "1224-617-3554";
            this.textBoxSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelLicense
            // 
            this.panelLicense.BackColor = System.Drawing.Color.White;
            this.panelLicense.Controls.Add(this.textBoxDaysRemainingValue);
            this.panelLicense.Controls.Add(this.labelDayRemaining);
            this.panelLicense.Controls.Add(this.textBox1);
            this.panelLicense.Controls.Add(this.textBoxLicenseTitle);
            this.panelLicense.Controls.Add(this.labelHash);
            this.panelLicense.Controls.Add(this.labelLicenseKey);
            this.panelLicense.Controls.Add(this.textBoxEndDate);
            this.panelLicense.Controls.Add(this.labelStartDate);
            this.panelLicense.Controls.Add(this.textBoxStartDate);
            this.panelLicense.Controls.Add(this.labelEndDate);
            this.panelLicense.Controls.Add(this.textBoxHash);
            this.panelLicense.Controls.Add(this.labelDuration);
            this.panelLicense.Controls.Add(this.textBoxDuration);
            this.panelLicense.Controls.Add(this.labelDays);
            this.panelLicense.Controls.Add(this.textBoxLicenseKey);
            this.panelLicense.Location = new System.Drawing.Point(36, 376);
            this.panelLicense.Name = "panelLicense";
            this.panelLicense.Size = new System.Drawing.Size(817, 104);
            this.panelLicense.TabIndex = 55;
            // 
            // textBoxDaysRemainingValue
            // 
            this.textBoxDaysRemainingValue.BackColor = System.Drawing.Color.Yellow;
            this.textBoxDaysRemainingValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDaysRemainingValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDaysRemainingValue.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBoxDaysRemainingValue.Location = new System.Drawing.Point(726, 69);
            this.textBoxDaysRemainingValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDaysRemainingValue.Name = "textBoxDaysRemainingValue";
            this.textBoxDaysRemainingValue.ReadOnly = true;
            this.textBoxDaysRemainingValue.Size = new System.Drawing.Size(30, 20);
            this.textBoxDaysRemainingValue.TabIndex = 43;
            this.textBoxDaysRemainingValue.Text = "280";
            this.textBoxDaysRemainingValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDayRemaining
            // 
            this.labelDayRemaining.AutoSize = true;
            this.labelDayRemaining.BackColor = System.Drawing.Color.White;
            this.labelDayRemaining.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDayRemaining.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelDayRemaining.Location = new System.Drawing.Point(597, 69);
            this.labelDayRemaining.Name = "labelDayRemaining";
            this.labelDayRemaining.Size = new System.Drawing.Size(126, 20);
            this.labelDayRemaining.TabIndex = 40;
            this.labelDayRemaining.Text = "Days Remaining:";
            this.labelDayRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(693, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(30, 20);
            this.textBox1.TabIndex = 42;
            this.textBox1.Text = "365";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxLicenseTitle
            // 
            this.textBoxLicenseTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLicenseTitle.BackColor = System.Drawing.Color.Yellow;
            this.textBoxLicenseTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLicenseTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLicenseTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxLicenseTitle.Location = new System.Drawing.Point(3, 3);
            this.textBoxLicenseTitle.Name = "textBoxLicenseTitle";
            this.textBoxLicenseTitle.ReadOnly = true;
            this.textBoxLicenseTitle.Size = new System.Drawing.Size(811, 22);
            this.textBoxLicenseTitle.TabIndex = 37;
            this.textBoxLicenseTitle.TabStop = false;
            this.textBoxLicenseTitle.Text = "LICENSE";
            this.textBoxLicenseTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHash
            // 
            this.labelHash.AutoSize = true;
            this.labelHash.BackColor = System.Drawing.Color.White;
            this.labelHash.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHash.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelHash.Location = new System.Drawing.Point(429, 41);
            this.labelHash.Name = "labelHash";
            this.labelHash.Size = new System.Drawing.Size(52, 20);
            this.labelHash.TabIndex = 35;
            this.labelHash.Text = "Hash: ";
            this.labelHash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLicenseKey
            // 
            this.labelLicenseKey.AutoSize = true;
            this.labelLicenseKey.BackColor = System.Drawing.Color.White;
            this.labelLicenseKey.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicenseKey.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelLicenseKey.Location = new System.Drawing.Point(4, 41);
            this.labelLicenseKey.Name = "labelLicenseKey";
            this.labelLicenseKey.Size = new System.Drawing.Size(94, 20);
            this.labelLicenseKey.TabIndex = 15;
            this.labelLicenseKey.Text = "License Key:";
            this.labelLicenseKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxEndDate
            // 
            this.textBoxEndDate.BackColor = System.Drawing.Color.White;
            this.textBoxEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEndDate.Location = new System.Drawing.Point(272, 69);
            this.textBoxEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEndDate.Name = "textBoxEndDate";
            this.textBoxEndDate.ReadOnly = true;
            this.textBoxEndDate.Size = new System.Drawing.Size(80, 20);
            this.textBoxEndDate.TabIndex = 39;
            this.textBoxEndDate.Text = "7/4/2022";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.BackColor = System.Drawing.Color.White;
            this.labelStartDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelStartDate.Location = new System.Drawing.Point(18, 69);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(84, 20);
            this.labelStartDate.TabIndex = 30;
            this.labelStartDate.Text = "Start Date:";
            this.labelStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.BackColor = System.Drawing.Color.White;
            this.textBoxStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStartDate.Location = new System.Drawing.Point(106, 69);
            this.textBoxStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.ReadOnly = true;
            this.textBoxStartDate.Size = new System.Drawing.Size(80, 20);
            this.textBoxStartDate.TabIndex = 36;
            this.textBoxStartDate.Text = "7/4/2022";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.BackColor = System.Drawing.Color.White;
            this.labelEndDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelEndDate.Location = new System.Drawing.Point(194, 69);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(76, 20);
            this.labelEndDate.TabIndex = 31;
            this.labelEndDate.Text = "End Date:";
            this.labelEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxHash
            // 
            this.textBoxHash.BackColor = System.Drawing.Color.White;
            this.textBoxHash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHash.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHash.Location = new System.Drawing.Point(481, 41);
            this.textBoxHash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHash.Name = "textBoxHash";
            this.textBoxHash.ReadOnly = true;
            this.textBoxHash.Size = new System.Drawing.Size(286, 20);
            this.textBoxHash.TabIndex = 33;
            this.textBoxHash.Text = "AJP-2f56-7CB2-882C-90BC-ABCD-ENG";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.BackColor = System.Drawing.Color.White;
            this.labelDuration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelDuration.Location = new System.Drawing.Point(361, 69);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(75, 20);
            this.labelDuration.TabIndex = 12;
            this.labelDuration.Text = "Duration:";
            this.labelDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.BackColor = System.Drawing.Color.White;
            this.textBoxDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDuration.Location = new System.Drawing.Point(441, 69);
            this.textBoxDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.ReadOnly = true;
            this.textBoxDuration.Size = new System.Drawing.Size(30, 20);
            this.textBoxDuration.TabIndex = 38;
            this.textBoxDuration.Text = "365";
            this.textBoxDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.BackColor = System.Drawing.Color.White;
            this.labelDays.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDays.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelDays.Location = new System.Drawing.Point(476, 69);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(41, 20);
            this.labelDays.TabIndex = 14;
            this.labelDays.Text = "days";
            this.labelDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxLicenseKey
            // 
            this.textBoxLicenseKey.BackColor = System.Drawing.Color.White;
            this.textBoxLicenseKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLicenseKey.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLicenseKey.Location = new System.Drawing.Point(106, 41);
            this.textBoxLicenseKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLicenseKey.Name = "textBoxLicenseKey";
            this.textBoxLicenseKey.ReadOnly = true;
            this.textBoxLicenseKey.Size = new System.Drawing.Size(320, 20);
            this.textBoxLicenseKey.TabIndex = 16;
            this.textBoxLicenseKey.Text = "AJP-00000-00000-00000-00000-00000-ENG";
            // 
            // tabPageROOT_About
            // 
            this.tabPageROOT_About.BackColor = System.Drawing.Color.Honeydew;
            this.tabPageROOT_About.Controls.Add(this.panelAbout);
            this.tabPageROOT_About.Location = new System.Drawing.Point(4, 39);
            this.tabPageROOT_About.Name = "tabPageROOT_About";
            this.tabPageROOT_About.Size = new System.Drawing.Size(896, 533);
            this.tabPageROOT_About.TabIndex = 4;
            this.tabPageROOT_About.Text = "About";
            // 
            // panelAbout
            // 
            this.panelAbout.BackColor = System.Drawing.Color.Honeydew;
            this.panelAbout.Controls.Add(this.pictureBoxAjpContactInfo);
            this.panelAbout.Controls.Add(this.pictureBoxLicenseAgreement);
            this.panelAbout.Controls.Add(this.pictureBoxHenStudio);
            this.panelAbout.Controls.Add(this.pictureBoxProductWarning);
            this.panelAbout.Controls.Add(this.tableLayoutPanelProduct);
            this.panelAbout.Controls.Add(this.tableLayoutPanelSupplier);
            this.panelAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAbout.Location = new System.Drawing.Point(0, 0);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(896, 533);
            this.panelAbout.TabIndex = 0;
            // 
            // pictureBoxAjpContactInfo
            // 
            this.pictureBoxAjpContactInfo.Image = global::HenStudio.Properties.Resources.AjpContactInfo;
            this.pictureBoxAjpContactInfo.Location = new System.Drawing.Point(50, 229);
            this.pictureBoxAjpContactInfo.Name = "pictureBoxAjpContactInfo";
            this.pictureBoxAjpContactInfo.Size = new System.Drawing.Size(337, 129);
            this.pictureBoxAjpContactInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAjpContactInfo.TabIndex = 12;
            this.pictureBoxAjpContactInfo.TabStop = false;
            this.pictureBoxAjpContactInfo.Click += new System.EventHandler(this.pictureBoxAjpContactInfo_Click);
            // 
            // pictureBoxLicenseAgreement
            // 
            this.pictureBoxLicenseAgreement.Image = global::HenStudio.Properties.Resources.AjpUserLicenseAgreement;
            this.pictureBoxLicenseAgreement.Location = new System.Drawing.Point(515, 229);
            this.pictureBoxLicenseAgreement.Name = "pictureBoxLicenseAgreement";
            this.pictureBoxLicenseAgreement.Size = new System.Drawing.Size(337, 129);
            this.pictureBoxLicenseAgreement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLicenseAgreement.TabIndex = 11;
            this.pictureBoxLicenseAgreement.TabStop = false;
            this.pictureBoxLicenseAgreement.Click += new System.EventHandler(this.pictureBoxLicenseAgreement_Click);
            // 
            // pictureBoxHenStudio
            // 
            this.pictureBoxHenStudio.BackColor = System.Drawing.Color.White;
            this.pictureBoxHenStudio.Image = global::HenStudio.Properties.Resources.AJPHenStudioWithGraphic;
            this.pictureBoxHenStudio.Location = new System.Drawing.Point(50, 17);
            this.pictureBoxHenStudio.Name = "pictureBoxHenStudio";
            this.pictureBoxHenStudio.Size = new System.Drawing.Size(297, 178);
            this.pictureBoxHenStudio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHenStudio.TabIndex = 10;
            this.pictureBoxHenStudio.TabStop = false;
            // 
            // pictureBoxProductWarning
            // 
            this.pictureBoxProductWarning.BackColor = System.Drawing.Color.White;
            this.pictureBoxProductWarning.Image = global::HenStudio.Properties.Resources.SoftwareWarning;
            this.pictureBoxProductWarning.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProductWarning.InitialImage")));
            this.pictureBoxProductWarning.Location = new System.Drawing.Point(50, 391);
            this.pictureBoxProductWarning.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxProductWarning.Name = "pictureBoxProductWarning";
            this.pictureBoxProductWarning.Size = new System.Drawing.Size(802, 119);
            this.pictureBoxProductWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProductWarning.TabIndex = 6;
            this.pictureBoxProductWarning.TabStop = false;
            // 
            // tableLayoutPanelProduct
            // 
            this.tableLayoutPanelProduct.BackColor = System.Drawing.Color.DarkOrange;
            this.tableLayoutPanelProduct.ColumnCount = 2;
            this.tableLayoutPanelProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.13609F));
            this.tableLayoutPanelProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.86391F));
            this.tableLayoutPanelProduct.Controls.Add(this.labelProductFullName, 0, 0);
            this.tableLayoutPanelProduct.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanelProduct.Controls.Add(this.labelProductFullNameValue, 1, 0);
            this.tableLayoutPanelProduct.Controls.Add(this.labelProductNameValue, 1, 1);
            this.tableLayoutPanelProduct.Controls.Add(this.labelProductVersion, 0, 2);
            this.tableLayoutPanelProduct.Controls.Add(this.labelProductVersionValue, 1, 2);
            this.tableLayoutPanelProduct.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanelProduct.Controls.Add(this.labelSerialNumberValue, 1, 3);
            this.tableLayoutPanelProduct.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanelProduct.Controls.Add(this.labelProductCodeValue, 1, 4);
            this.tableLayoutPanelProduct.Location = new System.Drawing.Point(373, 55);
            this.tableLayoutPanelProduct.Name = "tableLayoutPanelProduct";
            this.tableLayoutPanelProduct.RowCount = 5;
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelProduct.Size = new System.Drawing.Size(479, 140);
            this.tableLayoutPanelProduct.TabIndex = 3;
            // 
            // labelProductFullName
            // 
            this.labelProductFullName.AutoSize = true;
            this.labelProductFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductFullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProductFullName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductFullName.Location = new System.Drawing.Point(3, 0);
            this.labelProductFullName.Name = "labelProductFullName";
            this.labelProductFullName.Size = new System.Drawing.Size(152, 28);
            this.labelProductFullName.TabIndex = 0;
            this.labelProductFullName.Text = "Product Full Name";
            this.labelProductFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelProductFullNameValue
            // 
            this.labelProductFullNameValue.AutoSize = true;
            this.labelProductFullNameValue.BackColor = System.Drawing.Color.White;
            this.labelProductFullNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductFullNameValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProductFullNameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductFullNameValue.Location = new System.Drawing.Point(158, 0);
            this.labelProductFullNameValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProductFullNameValue.Name = "labelProductFullNameValue";
            this.labelProductFullNameValue.Size = new System.Drawing.Size(321, 28);
            this.labelProductFullNameValue.TabIndex = 3;
            this.labelProductFullNameValue.Text = "  AJP HEN Studio 1.0";
            this.labelProductFullNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProductNameValue
            // 
            this.labelProductNameValue.AutoSize = true;
            this.labelProductNameValue.BackColor = System.Drawing.Color.White;
            this.labelProductNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductNameValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProductNameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductNameValue.Location = new System.Drawing.Point(158, 28);
            this.labelProductNameValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProductNameValue.Name = "labelProductNameValue";
            this.labelProductNameValue.Size = new System.Drawing.Size(321, 28);
            this.labelProductNameValue.TabIndex = 4;
            this.labelProductNameValue.Text = "  AJP HEN Studio";
            this.labelProductNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProductVersion
            // 
            this.labelProductVersion.AutoSize = true;
            this.labelProductVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProductVersion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductVersion.Location = new System.Drawing.Point(0, 56);
            this.labelProductVersion.Margin = new System.Windows.Forms.Padding(0);
            this.labelProductVersion.Name = "labelProductVersion";
            this.labelProductVersion.Size = new System.Drawing.Size(158, 28);
            this.labelProductVersion.TabIndex = 5;
            this.labelProductVersion.Text = "Product Version";
            this.labelProductVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelProductVersionValue
            // 
            this.labelProductVersionValue.AutoSize = true;
            this.labelProductVersionValue.BackColor = System.Drawing.Color.White;
            this.labelProductVersionValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductVersionValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProductVersionValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductVersionValue.Location = new System.Drawing.Point(158, 56);
            this.labelProductVersionValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProductVersionValue.Name = "labelProductVersionValue";
            this.labelProductVersionValue.Size = new System.Drawing.Size(321, 28);
            this.labelProductVersionValue.TabIndex = 6;
            this.labelProductVersionValue.Text = "  1.0.1";
            this.labelProductVersionValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Serial Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSerialNumberValue
            // 
            this.labelSerialNumberValue.AutoSize = true;
            this.labelSerialNumberValue.BackColor = System.Drawing.Color.White;
            this.labelSerialNumberValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSerialNumberValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSerialNumberValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerialNumberValue.Location = new System.Drawing.Point(158, 84);
            this.labelSerialNumberValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelSerialNumberValue.Name = "labelSerialNumberValue";
            this.labelSerialNumberValue.Size = new System.Drawing.Size(321, 28);
            this.labelSerialNumberValue.TabIndex = 8;
            this.labelSerialNumberValue.Text = "  1022-789-1189";
            this.labelSerialNumberValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelProductCodeValue
            // 
            this.labelProductCodeValue.AutoSize = true;
            this.labelProductCodeValue.BackColor = System.Drawing.Color.White;
            this.labelProductCodeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductCodeValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProductCodeValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductCodeValue.Location = new System.Drawing.Point(158, 112);
            this.labelProductCodeValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProductCodeValue.Name = "labelProductCodeValue";
            this.labelProductCodeValue.Size = new System.Drawing.Size(321, 28);
            this.labelProductCodeValue.TabIndex = 10;
            this.labelProductCodeValue.Text = "{3D9721BA-003E-4711-B7AF-B579645F0AC9}";
            this.labelProductCodeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelSupplier
            // 
            this.tableLayoutPanelSupplier.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.tableLayoutPanelSupplier.ColumnCount = 2;
            this.tableLayoutPanelSupplier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.97872F));
            this.tableLayoutPanelSupplier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.02128F));
            this.tableLayoutPanelSupplier.Controls.Add(this.labelSuplierName, 0, 0);
            this.tableLayoutPanelSupplier.Controls.Add(this.labelSupplierNameValue, 1, 0);
            this.tableLayoutPanelSupplier.Location = new System.Drawing.Point(373, 18);
            this.tableLayoutPanelSupplier.Name = "tableLayoutPanelSupplier";
            this.tableLayoutPanelSupplier.RowCount = 1;
            this.tableLayoutPanelSupplier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            this.tableLayoutPanelSupplier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.06897F));
            this.tableLayoutPanelSupplier.Size = new System.Drawing.Size(479, 31);
            this.tableLayoutPanelSupplier.TabIndex = 2;
            // 
            // labelSuplierName
            // 
            this.labelSuplierName.AutoSize = true;
            this.labelSuplierName.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.labelSuplierName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSuplierName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSuplierName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuplierName.Location = new System.Drawing.Point(3, 0);
            this.labelSuplierName.Name = "labelSuplierName";
            this.labelSuplierName.Padding = new System.Windows.Forms.Padding(3);
            this.labelSuplierName.Size = new System.Drawing.Size(151, 31);
            this.labelSuplierName.TabIndex = 0;
            this.labelSuplierName.Text = "Supplier Name";
            this.labelSuplierName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSupplierNameValue
            // 
            this.labelSupplierNameValue.AutoSize = true;
            this.labelSupplierNameValue.BackColor = System.Drawing.Color.White;
            this.labelSupplierNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSupplierNameValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSupplierNameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierNameValue.Location = new System.Drawing.Point(157, 0);
            this.labelSupplierNameValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelSupplierNameValue.Name = "labelSupplierNameValue";
            this.labelSupplierNameValue.Size = new System.Drawing.Size(322, 31);
            this.labelSupplierNameValue.TabIndex = 1;
            this.labelSupplierNameValue.Text = "  AJP Engineering";
            this.labelSupplierNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxProjectsBanner
            // 
            this.textBoxProjectsBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProjectsBanner.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBoxProjectsBanner.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectsBanner.ForeColor = System.Drawing.Color.White;
            this.textBoxProjectsBanner.Location = new System.Drawing.Point(-1, 4);
            this.textBoxProjectsBanner.Name = "textBoxProjectsBanner";
            this.textBoxProjectsBanner.Size = new System.Drawing.Size(910, 33);
            this.textBoxProjectsBanner.TabIndex = 10;
            this.textBoxProjectsBanner.Text = "HEN STUDIO APPLICATION";
            this.textBoxProjectsBanner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelSELECTED_PROFILE
            // 
            this.panelSELECTED_PROFILE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSELECTED_PROFILE.BackColor = System.Drawing.Color.Honeydew;
            this.panelSELECTED_PROFILE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSELECTED_PROFILE.Controls.Add(this.panelProfileMetadata);
            this.panelSELECTED_PROFILE.Controls.Add(this.tabControlInputPhase);
            this.panelSELECTED_PROFILE.Controls.Add(this.textBoxInputBanner);
            this.panelSELECTED_PROFILE.Location = new System.Drawing.Point(0, 0);
            this.panelSELECTED_PROFILE.Margin = new System.Windows.Forms.Padding(0);
            this.panelSELECTED_PROFILE.Name = "panelSELECTED_PROFILE";
            this.panelSELECTED_PROFILE.Padding = new System.Windows.Forms.Padding(6);
            this.panelSELECTED_PROFILE.Size = new System.Drawing.Size(910, 619);
            this.panelSELECTED_PROFILE.TabIndex = 12;
            // 
            // panelProfileMetadata
            // 
            this.panelProfileMetadata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProfileMetadata.BackColor = System.Drawing.Color.White;
            this.panelProfileMetadata.Controls.Add(this.listViewProfileUnits);
            this.panelProfileMetadata.Controls.Add(this.textBoxUnits);
            this.panelProfileMetadata.Controls.Add(this.textBoxProfileProjectId);
            this.panelProfileMetadata.Controls.Add(this.textBoxProfileProjectIdValue);
            this.panelProfileMetadata.Controls.Add(this.textBoxProfileId);
            this.panelProfileMetadata.Controls.Add(this.textBoxProfileIdValue);
            this.panelProfileMetadata.Controls.Add(this.pictureBox1);
            this.panelProfileMetadata.Controls.Add(this.textBoxProfileNameValue);
            this.panelProfileMetadata.Controls.Add(this.textBoxProfileName);
            this.panelProfileMetadata.Controls.Add(this.textBoxProfileDescription);
            this.panelProfileMetadata.Controls.Add(this.textBoxProfileDescriptionValue);
            this.panelProfileMetadata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelProfileMetadata.Location = new System.Drawing.Point(10, 46);
            this.panelProfileMetadata.Name = "panelProfileMetadata";
            this.panelProfileMetadata.Size = new System.Drawing.Size(889, 135);
            this.panelProfileMetadata.TabIndex = 13;
            // 
            // listViewProfileUnits
            // 
            this.listViewProfileUnits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProfileName,
            this.columnHeaderProfileUnits});
            this.listViewProfileUnits.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewProfileUnits.HideSelection = false;
            this.listViewProfileUnits.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem57,
            listViewItem58,
            listViewItem59});
            this.listViewProfileUnits.Location = new System.Drawing.Point(461, 67);
            this.listViewProfileUnits.Name = "listViewProfileUnits";
            this.listViewProfileUnits.Size = new System.Drawing.Size(414, 62);
            this.listViewProfileUnits.TabIndex = 13;
            this.listViewProfileUnits.UseCompatibleStateImageBehavior = false;
            this.listViewProfileUnits.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderProfileName
            // 
            this.columnHeaderProfileName.Text = "Name";
            this.columnHeaderProfileName.Width = 169;
            // 
            // columnHeaderProfileUnits
            // 
            this.columnHeaderProfileUnits.Text = "UNITS";
            this.columnHeaderProfileUnits.Width = 224;
            // 
            // textBoxUnits
            // 
            this.textBoxUnits.BackColor = System.Drawing.Color.Yellow;
            this.textBoxUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnits.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnits.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxUnits.Location = new System.Drawing.Point(461, 49);
            this.textBoxUnits.Name = "textBoxUnits";
            this.textBoxUnits.ReadOnly = true;
            this.textBoxUnits.Size = new System.Drawing.Size(418, 18);
            this.textBoxUnits.TabIndex = 12;
            this.textBoxUnits.Text = "UNITS";
            this.textBoxUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxProfileProjectId
            // 
            this.textBoxProfileProjectId.BackColor = System.Drawing.Color.White;
            this.textBoxProfileProjectId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProfileProjectId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProfileProjectId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxProfileProjectId.Location = new System.Drawing.Point(457, 10);
            this.textBoxProfileProjectId.Name = "textBoxProfileProjectId";
            this.textBoxProfileProjectId.ReadOnly = true;
            this.textBoxProfileProjectId.Size = new System.Drawing.Size(77, 18);
            this.textBoxProfileProjectId.TabIndex = 11;
            this.textBoxProfileProjectId.Text = "Project ID: ";
            this.textBoxProfileProjectId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxProfileProjectIdValue
            // 
            this.textBoxProfileProjectIdValue.BackColor = System.Drawing.Color.White;
            this.textBoxProfileProjectIdValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProfileProjectIdValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProfileProjectIdValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxProfileProjectIdValue.Location = new System.Drawing.Point(540, 10);
            this.textBoxProfileProjectIdValue.Name = "textBoxProfileProjectIdValue";
            this.textBoxProfileProjectIdValue.ReadOnly = true;
            this.textBoxProfileProjectIdValue.Size = new System.Drawing.Size(335, 18);
            this.textBoxProfileProjectIdValue.TabIndex = 10;
            this.textBoxProfileProjectIdValue.Text = "Project GUID here";
            // 
            // textBoxProfileId
            // 
            this.textBoxProfileId.BackColor = System.Drawing.Color.White;
            this.textBoxProfileId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProfileId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProfileId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxProfileId.Location = new System.Drawing.Point(14, 10);
            this.textBoxProfileId.Name = "textBoxProfileId";
            this.textBoxProfileId.ReadOnly = true;
            this.textBoxProfileId.Size = new System.Drawing.Size(96, 18);
            this.textBoxProfileId.TabIndex = 6;
            this.textBoxProfileId.Text = "Profile ID: ";
            this.textBoxProfileId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxProfileIdValue
            // 
            this.textBoxProfileIdValue.BackColor = System.Drawing.Color.White;
            this.textBoxProfileIdValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProfileIdValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProfileIdValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxProfileIdValue.Location = new System.Drawing.Point(116, 10);
            this.textBoxProfileIdValue.Name = "textBoxProfileIdValue";
            this.textBoxProfileIdValue.ReadOnly = true;
            this.textBoxProfileIdValue.Size = new System.Drawing.Size(335, 18);
            this.textBoxProfileIdValue.TabIndex = 5;
            this.textBoxProfileIdValue.Text = "Profile GUID here";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HenStudio.Properties.Resources.ProfilePanel;
            this.pictureBox1.Location = new System.Drawing.Point(34, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxProfileNameValue
            // 
            this.textBoxProfileNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProfileNameValue.BackColor = System.Drawing.Color.White;
            this.textBoxProfileNameValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProfileNameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProfileNameValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxProfileNameValue.Location = new System.Drawing.Point(116, 29);
            this.textBoxProfileNameValue.Name = "textBoxProfileNameValue";
            this.textBoxProfileNameValue.ReadOnly = true;
            this.textBoxProfileNameValue.Size = new System.Drawing.Size(759, 18);
            this.textBoxProfileNameValue.TabIndex = 2;
            this.textBoxProfileNameValue.Text = "Profile Name here";
            // 
            // textBoxProfileName
            // 
            this.textBoxProfileName.BackColor = System.Drawing.Color.White;
            this.textBoxProfileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProfileName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProfileName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxProfileName.Location = new System.Drawing.Point(14, 29);
            this.textBoxProfileName.Name = "textBoxProfileName";
            this.textBoxProfileName.ReadOnly = true;
            this.textBoxProfileName.Size = new System.Drawing.Size(96, 18);
            this.textBoxProfileName.TabIndex = 1;
            this.textBoxProfileName.Text = "Profile Name: ";
            this.textBoxProfileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxProfileDescription
            // 
            this.textBoxProfileDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProfileDescription.BackColor = System.Drawing.Color.White;
            this.textBoxProfileDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProfileDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProfileDescription.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxProfileDescription.Location = new System.Drawing.Point(14, 49);
            this.textBoxProfileDescription.Name = "textBoxProfileDescription";
            this.textBoxProfileDescription.ReadOnly = true;
            this.textBoxProfileDescription.Size = new System.Drawing.Size(96, 18);
            this.textBoxProfileDescription.TabIndex = 3;
            this.textBoxProfileDescription.Text = "  Description: ";
            this.textBoxProfileDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxProfileDescriptionValue
            // 
            this.textBoxProfileDescriptionValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProfileDescriptionValue.BackColor = System.Drawing.Color.White;
            this.textBoxProfileDescriptionValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProfileDescriptionValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProfileDescriptionValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxProfileDescriptionValue.Location = new System.Drawing.Point(110, 50);
            this.textBoxProfileDescriptionValue.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxProfileDescriptionValue.Multiline = true;
            this.textBoxProfileDescriptionValue.Name = "textBoxProfileDescriptionValue";
            this.textBoxProfileDescriptionValue.ReadOnly = true;
            this.textBoxProfileDescriptionValue.Size = new System.Drawing.Size(341, 79);
            this.textBoxProfileDescriptionValue.TabIndex = 4;
            this.textBoxProfileDescriptionValue.Text = "Profile Description here";
            // 
            // tabControlInputPhase
            // 
            this.tabControlInputPhase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlInputPhase.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlInputPhase.Controls.Add(this.tabPageProcessStreams);
            this.tabControlInputPhase.Controls.Add(this.tabPageUtilitiesStreams);
            this.tabControlInputPhase.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlInputPhase.ImageList = this.imageListInput;
            this.tabControlInputPhase.ItemSize = new System.Drawing.Size(161, 35);
            this.tabControlInputPhase.Location = new System.Drawing.Point(-3, 190);
            this.tabControlInputPhase.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlInputPhase.Name = "tabControlInputPhase";
            this.tabControlInputPhase.SelectedIndex = 0;
            this.tabControlInputPhase.ShowToolTips = true;
            this.tabControlInputPhase.Size = new System.Drawing.Size(911, 428);
            this.tabControlInputPhase.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlInputPhase.TabIndex = 0;
            // 
            // tabPageProcessStreams
            // 
            this.tabPageProcessStreams.BackColor = System.Drawing.Color.Honeydew;
            this.tabPageProcessStreams.Controls.Add(this.dataGridViewProcessStreams);
            this.tabPageProcessStreams.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageProcessStreams.ImageIndex = 0;
            this.tabPageProcessStreams.Location = new System.Drawing.Point(4, 39);
            this.tabPageProcessStreams.Name = "tabPageProcessStreams";
            this.tabPageProcessStreams.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcessStreams.Size = new System.Drawing.Size(903, 385);
            this.tabPageProcessStreams.TabIndex = 0;
            this.tabPageProcessStreams.Text = "PROCESS STREAMS ";
            this.tabPageProcessStreams.ToolTipText = "Specify Process Streams for Current Input Profile";
            // 
            // dataGridViewProcessStreams
            // 
            this.dataGridViewProcessStreams.AllowUserToAddRows = false;
            this.dataGridViewProcessStreams.AllowUserToDeleteRows = false;
            this.dataGridViewProcessStreams.AllowUserToResizeRows = false;
            this.dataGridViewProcessStreams.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewProcessStreams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProcessStreams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcessStreams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessStreamName,
            this.ProcessStreamId,
            this.StreamType,
            this.StreamSubtype,
            this.StreamHeat,
            this.HeatCapacityFlowRate,
            this.SupplyTemp,
            this.TargetTemp,
            this.SupplyPress,
            this.TargetPress,
            this.DeltaTemp,
            this.DeltaPress,
            this.Duty,
            this.ValidStreamIcon,
            this.StreamValidation});
            this.dataGridViewProcessStreams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProcessStreams.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridViewProcessStreams.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProcessStreams.Name = "dataGridViewProcessStreams";
            this.dataGridViewProcessStreams.ReadOnly = true;
            this.dataGridViewProcessStreams.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProcessStreams.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProcessStreams.RowTemplate.ReadOnly = true;
            this.dataGridViewProcessStreams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProcessStreams.Size = new System.Drawing.Size(897, 379);
            this.dataGridViewProcessStreams.TabIndex = 0;
            // 
            // ProcessStreamName
            // 
            this.ProcessStreamName.HeaderText = "Name";
            this.ProcessStreamName.Name = "ProcessStreamName";
            this.ProcessStreamName.ReadOnly = true;
            this.ProcessStreamName.Width = 50;
            // 
            // ProcessStreamId
            // 
            this.ProcessStreamId.HeaderText = "Stream ID";
            this.ProcessStreamId.MinimumWidth = 80;
            this.ProcessStreamId.Name = "ProcessStreamId";
            this.ProcessStreamId.ReadOnly = true;
            this.ProcessStreamId.Width = 80;
            // 
            // StreamType
            // 
            this.StreamType.HeaderText = "Type";
            this.StreamType.Name = "StreamType";
            this.StreamType.ReadOnly = true;
            this.StreamType.Width = 50;
            // 
            // StreamSubtype
            // 
            this.StreamSubtype.HeaderText = "Subtype";
            this.StreamSubtype.Name = "StreamSubtype";
            this.StreamSubtype.ReadOnly = true;
            this.StreamSubtype.Width = 75;
            // 
            // StreamHeat
            // 
            this.StreamHeat.HeaderText = "Heat";
            this.StreamHeat.Name = "StreamHeat";
            this.StreamHeat.ReadOnly = true;
            this.StreamHeat.Width = 50;
            // 
            // HeatCapacityFlowRate
            // 
            this.HeatCapacityFlowRate.HeaderText = "CP";
            this.HeatCapacityFlowRate.Name = "HeatCapacityFlowRate";
            this.HeatCapacityFlowRate.ReadOnly = true;
            this.HeatCapacityFlowRate.Width = 50;
            // 
            // SupplyTemp
            // 
            this.SupplyTemp.HeaderText = "Temp Supply";
            this.SupplyTemp.MinimumWidth = 80;
            this.SupplyTemp.Name = "SupplyTemp";
            this.SupplyTemp.ReadOnly = true;
            this.SupplyTemp.Width = 80;
            // 
            // TargetTemp
            // 
            this.TargetTemp.HeaderText = "Temp Target";
            this.TargetTemp.MinimumWidth = 80;
            this.TargetTemp.Name = "TargetTemp";
            this.TargetTemp.ReadOnly = true;
            this.TargetTemp.Width = 80;
            // 
            // SupplyPress
            // 
            this.SupplyPress.HeaderText = "Press Supply";
            this.SupplyPress.Name = "SupplyPress";
            this.SupplyPress.ReadOnly = true;
            this.SupplyPress.Visible = false;
            this.SupplyPress.Width = 50;
            // 
            // TargetPress
            // 
            this.TargetPress.HeaderText = "Press Target";
            this.TargetPress.Name = "TargetPress";
            this.TargetPress.ReadOnly = true;
            this.TargetPress.Visible = false;
            this.TargetPress.Width = 50;
            // 
            // DeltaTemp
            // 
            this.DeltaTemp.HeaderText = "Delta T";
            this.DeltaTemp.Name = "DeltaTemp";
            this.DeltaTemp.ReadOnly = true;
            this.DeltaTemp.Width = 75;
            // 
            // DeltaPress
            // 
            this.DeltaPress.HeaderText = "Delta P";
            this.DeltaPress.Name = "DeltaPress";
            this.DeltaPress.ReadOnly = true;
            this.DeltaPress.Visible = false;
            this.DeltaPress.Width = 50;
            // 
            // Duty
            // 
            this.Duty.HeaderText = "Duty";
            this.Duty.Name = "Duty";
            this.Duty.ReadOnly = true;
            this.Duty.Width = 50;
            // 
            // ValidStreamIcon
            // 
            this.ValidStreamIcon.HeaderText = "X";
            this.ValidStreamIcon.MinimumWidth = 20;
            this.ValidStreamIcon.Name = "ValidStreamIcon";
            this.ValidStreamIcon.ReadOnly = true;
            this.ValidStreamIcon.Width = 20;
            // 
            // StreamValidation
            // 
            this.StreamValidation.HeaderText = "Stream Validation";
            this.StreamValidation.MinimumWidth = 180;
            this.StreamValidation.Name = "StreamValidation";
            this.StreamValidation.ReadOnly = true;
            this.StreamValidation.Width = 180;
            // 
            // tabPageUtilitiesStreams
            // 
            this.tabPageUtilitiesStreams.BackColor = System.Drawing.Color.Honeydew;
            this.tabPageUtilitiesStreams.Controls.Add(this.dataGridViewUtilityStreams);
            this.tabPageUtilitiesStreams.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageUtilitiesStreams.ImageIndex = 1;
            this.tabPageUtilitiesStreams.Location = new System.Drawing.Point(4, 39);
            this.tabPageUtilitiesStreams.Name = "tabPageUtilitiesStreams";
            this.tabPageUtilitiesStreams.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUtilitiesStreams.Size = new System.Drawing.Size(903, 385);
            this.tabPageUtilitiesStreams.TabIndex = 1;
            this.tabPageUtilitiesStreams.Text = "UTILITY STREAMS";
            this.tabPageUtilitiesStreams.ToolTipText = "Specify Utility Streams for Current Input Profile";
            // 
            // dataGridViewUtilityStreams
            // 
            this.dataGridViewUtilityStreams.AllowUserToAddRows = false;
            this.dataGridViewUtilityStreams.AllowUserToDeleteRows = false;
            this.dataGridViewUtilityStreams.AllowUserToResizeRows = false;
            this.dataGridViewUtilityStreams.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewUtilityStreams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUtilityStreams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUtilityStreams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn7,
            this.IsothermalTemp,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn14});
            this.dataGridViewUtilityStreams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUtilityStreams.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridViewUtilityStreams.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewUtilityStreams.Name = "dataGridViewUtilityStreams";
            this.dataGridViewUtilityStreams.ReadOnly = true;
            this.dataGridViewUtilityStreams.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUtilityStreams.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewUtilityStreams.RowTemplate.ReadOnly = true;
            this.dataGridViewUtilityStreams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUtilityStreams.Size = new System.Drawing.Size(897, 379);
            this.dataGridViewUtilityStreams.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Stream ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Subtype";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Heat";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Duty";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Temp Supply";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // IsothermalTemp
            // 
            this.IsothermalTemp.HeaderText = "Isothermal Temp";
            this.IsothermalTemp.Name = "IsothermalTemp";
            this.IsothermalTemp.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Temp Target";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Press Supply";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Press Target";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Delta T";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 75;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Delta P";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 50;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "X";
            this.dataGridViewImageColumn1.MinimumWidth = 20;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Stream Validation";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 180;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 180;
            // 
            // textBoxInputBanner
            // 
            this.textBoxInputBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.textBoxInputBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputBanner.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputBanner.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxInputBanner.Location = new System.Drawing.Point(1, 4);
            this.textBoxInputBanner.Name = "textBoxInputBanner";
            this.textBoxInputBanner.Size = new System.Drawing.Size(903, 33);
            this.textBoxInputBanner.TabIndex = 1;
            this.textBoxInputBanner.Text = "INPUT PROFILE";
            this.textBoxInputBanner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.panelSELECTED_PINCH.Location = new System.Drawing.Point(0, 0);
            this.panelSELECTED_PINCH.Margin = new System.Windows.Forms.Padding(0);
            this.panelSELECTED_PINCH.Name = "panelSELECTED_PINCH";
            this.panelSELECTED_PINCH.Padding = new System.Windows.Forms.Padding(6);
            this.panelSELECTED_PINCH.Size = new System.Drawing.Size(910, 619);
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
            this.textBoxPinchBanner.Size = new System.Drawing.Size(853, 33);
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
            // panelSELECTED_HEN
            // 
            this.panelSELECTED_HEN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSELECTED_HEN.BackColor = System.Drawing.Color.White;
            this.panelSELECTED_HEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSELECTED_HEN.Controls.Add(this.textBoxHenBanner);
            this.panelSELECTED_HEN.Controls.Add(this.pictureBoxOpenedHen);
            this.panelSELECTED_HEN.Location = new System.Drawing.Point(0, 0);
            this.panelSELECTED_HEN.Margin = new System.Windows.Forms.Padding(0);
            this.panelSELECTED_HEN.Name = "panelSELECTED_HEN";
            this.panelSELECTED_HEN.Padding = new System.Windows.Forms.Padding(6);
            this.panelSELECTED_HEN.Size = new System.Drawing.Size(910, 619);
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
            this.textBoxHenBanner.Size = new System.Drawing.Size(853, 33);
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
            // imageListProject
            // 
            this.imageListProject.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListProject.ImageStream")));
            this.imageListProject.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListProject.Images.SetKeyName(0, "Project Explorer...32x32.png");
            this.imageListProject.Images.SetKeyName(1, "Project...32x32.png");
            // 
            // columnHeaderUService
            // 
            this.columnHeaderUService.Text = "Service";
            this.columnHeaderUService.Width = 145;
            // 
            // columnHeaderURange
            // 
            this.columnHeaderURange.Text = "Range";
            this.columnHeaderURange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderURange.Width = 109;
            // 
            // columnHeaderUNote
            // 
            this.columnHeaderUNote.Text = "Note";
            this.columnHeaderUNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderUNote.Width = 228;
            // 
            // textBoxHeatTransferCoeffUnits
            // 
            this.textBoxHeatTransferCoeffUnits.BackColor = System.Drawing.Color.White;
            this.textBoxHeatTransferCoeffUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHeatTransferCoeffUnits.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeatTransferCoeffUnits.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxHeatTransferCoeffUnits.Location = new System.Drawing.Point(76, 31);
            this.textBoxHeatTransferCoeffUnits.Name = "textBoxHeatTransferCoeffUnits";
            this.textBoxHeatTransferCoeffUnits.ReadOnly = true;
            this.textBoxHeatTransferCoeffUnits.Size = new System.Drawing.Size(230, 18);
            this.textBoxHeatTransferCoeffUnits.TabIndex = 42;
            this.textBoxHeatTransferCoeffUnits.Text = "Heat Transfer Coefficient (U) Units: ";
            this.textBoxHeatTransferCoeffUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxHeatTransferCoeffUnitsValue
            // 
            this.textBoxHeatTransferCoeffUnitsValue.BackColor = System.Drawing.Color.White;
            this.textBoxHeatTransferCoeffUnitsValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHeatTransferCoeffUnitsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeatTransferCoeffUnitsValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxHeatTransferCoeffUnitsValue.Location = new System.Drawing.Point(312, 31);
            this.textBoxHeatTransferCoeffUnitsValue.Name = "textBoxHeatTransferCoeffUnitsValue";
            this.textBoxHeatTransferCoeffUnitsValue.ReadOnly = true;
            this.textBoxHeatTransferCoeffUnitsValue.Size = new System.Drawing.Size(106, 18);
            this.textBoxHeatTransferCoeffUnitsValue.TabIndex = 43;
            this.textBoxHeatTransferCoeffUnitsValue.Text = "Btu/(hr·ft²·°F )";
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
            this.panelSELECTED_PROJECT.ResumeLayout(false);
            this.panelSELECTED_PROJECT.PerformLayout();
            this.tabControlProject.ResumeLayout(false);
            this.tabPageDefaultParams.ResumeLayout(false);
            this.panelTypicalURanges.ResumeLayout(false);
            this.panelTypicalURanges.PerformLayout();
            this.panelDefaultParmeters.ResumeLayout(false);
            this.panelDefaultParmeters.PerformLayout();
            this.panelProjectUnits.ResumeLayout(false);
            this.panelProjectUnits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnitsSystem)).EndInit();
            this.panelDefaultHenOptimizer.ResumeLayout(false);
            this.panelDefaultHenOptimizer.PerformLayout();
            this.tabPageCostParams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCostEq)).EndInit();
            this.panelUtilityCost.ResumeLayout(false);
            this.panelUtilityCost.PerformLayout();
            this.panelTotalAnnualizedCost.ResumeLayout(false);
            this.panelTotalAnnualizedCost.PerformLayout();
            this.panelShellAndTubeCapitalCost.ResumeLayout(false);
            this.panelShellAndTubeCapitalCost.PerformLayout();
            this.panelFiredHeaterCapitalCost.ResumeLayout(false);
            this.panelFiredHeaterCapitalCost.PerformLayout();
            this.panelCostMetadata.ResumeLayout(false);
            this.panelCostMetadata.PerformLayout();
            this.panelProjectMetadata.ResumeLayout(false);
            this.panelProjectMetadata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedProject)).EndInit();
            this.panelSELECTED_ROOT.ResumeLayout(false);
            this.panelSELECTED_ROOT.PerformLayout();
            this.tabControlROOT.ResumeLayout(false);
            this.tabPageROOT_Home.ResumeLayout(false);
            this.panelHomeAJP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeAjpLogo)).EndInit();
            this.tabPageROOT_FactorSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFactorySettingsAjpEngLogo)).EndInit();
            this.panelAppComponents.ResumeLayout(false);
            this.panelAppComponents.PerformLayout();
            this.panelAppMetadata.ResumeLayout(false);
            this.panelAppMetadata.PerformLayout();
            this.panelFactorySettings.ResumeLayout(false);
            this.panelFactorySettings.PerformLayout();
            this.tabPageROOT_Database.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDbAjpEndLogo)).EndInit();
            this.panelDatabaseTables.ResumeLayout(false);
            this.panelDatabaseTables.PerformLayout();
            this.panelProjectDbFileMetadata.ResumeLayout(false);
            this.panelProjectDbFileMetadata.PerformLayout();
            this.tabPageROOT_License.ResumeLayout(false);
            this.tabControlLicense.ResumeLayout(false);
            this.tabPageLicenseScorecard.ResumeLayout(false);
            this.tabPageLicenseScorecard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAjpEngLogo)).EndInit();
            this.panelScorecardSummary.ResumeLayout(false);
            this.panelScorecardSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvalid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValid)).EndInit();
            this.panelDeviceUser.ResumeLayout(false);
            this.panelDeviceUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRunning)).EndInit();
            this.panelScorecardTable.ResumeLayout(false);
            this.panelScorecardTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreCard)).EndInit();
            this.tabPageLicenseFile.ResumeLayout(false);
            this.panelLicenseType.ResumeLayout(false);
            this.panelLicenseType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSite)).EndInit();
            this.panelSupplier.ResumeLayout(false);
            this.panelSupplier.PerformLayout();
            this.panelCustomerContact.ResumeLayout(false);
            this.panelCustomerContact.PerformLayout();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.panelLicense.ResumeLayout(false);
            this.panelLicense.PerformLayout();
            this.tabPageROOT_About.ResumeLayout(false);
            this.panelAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAjpContactInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLicenseAgreement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHenStudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductWarning)).EndInit();
            this.tableLayoutPanelProduct.ResumeLayout(false);
            this.tableLayoutPanelProduct.PerformLayout();
            this.tableLayoutPanelSupplier.ResumeLayout(false);
            this.tableLayoutPanelSupplier.PerformLayout();
            this.panelSELECTED_PROFILE.ResumeLayout(false);
            this.panelSELECTED_PROFILE.PerformLayout();
            this.panelProfileMetadata.ResumeLayout(false);
            this.panelProfileMetadata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlInputPhase.ResumeLayout(false);
            this.tabPageProcessStreams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessStreams)).EndInit();
            this.tabPageUtilitiesStreams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilityStreams)).EndInit();
            this.panelSELECTED_PINCH.ResumeLayout(false);
            this.panelSELECTED_PINCH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedPinch)).EndInit();
            this.panelSELECTED_HEN.ResumeLayout(false);
            this.panelSELECTED_HEN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedHen)).EndInit();
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
        private System.Windows.Forms.TabPage tabPageProcessStreams;
        private System.Windows.Forms.TabPage tabPageUtilitiesStreams;
        private System.Windows.Forms.TextBox textBoxInputBanner;
        private System.Windows.Forms.TextBox textBoxPinchBanner;
        private System.Windows.Forms.TextBox textBoxHenBanner;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProjectCatalog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddProject;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCurrProj;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCurProjRename;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorCurProjAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProfile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProfileRename;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProfileDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCurProjAdd;
        private System.Windows.Forms.ImageList imageListProjectTreeViews;
        private System.Windows.Forms.ToolStripMenuItem catalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLICENSE;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCAT_DB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCollapseAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExpandAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorExpandCollapse;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCurrProjExpandAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCurrProjCollapseAll;
        private System.Windows.Forms.TextBox textBoxProjectBanner;
        private System.Windows.Forms.TextBox textBoxProjectNameValue;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.TextBox textBoxProjectDescriptionValue;
        private System.Windows.Forms.TextBox textBoxProjectDescription;
        private System.Windows.Forms.PictureBox pictureBoxOpenedProject;
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
        private System.Windows.Forms.TreeView treeViewCurrentProjectExplorer;
        private System.Windows.Forms.Panel panelSELECTED_ROOT;
        private System.Windows.Forms.TextBox textBoxProjectsBanner;
        private System.Windows.Forms.Panel panelSELECTED_PROFILE;
        private System.Windows.Forms.Panel panelSELECTED_PROJECT;
        private System.Windows.Forms.Panel panelSELECTED_HEN;
        private System.Windows.Forms.Panel panelSELECTED_PINCH;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
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
        private System.Windows.Forms.Panel panelDefaultParmeters;
        private System.Windows.Forms.TextBox textBoxExchangerLabel;
        private System.Windows.Forms.TextBox textBoxDefaultU_Value;
        private System.Windows.Forms.TextBox textBoxDefaultU_Units;
        private System.Windows.Forms.TextBox textBoxDefaultU;
        private System.Windows.Forms.Panel panelDefaultHenOptimizer;
        private System.Windows.Forms.TextBox textBoxDefaultStudyOptimizerTitle;
        private System.Windows.Forms.TextBox textBoxProjectGUID;
        private System.Windows.Forms.TextBox textBoxProjectID;
        private System.Windows.Forms.TextBox textBoxProjectUnitsSystem;
        private System.Windows.Forms.TextBox textBoxProjectUnitsPress;
        private System.Windows.Forms.TextBox textBoxProjectUnitsTemp;
        private System.Windows.Forms.TextBox textBoxProjectUnitsMagnitude;
        private System.Windows.Forms.TextBox textBoxFValue;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.TabControl tabControlROOT;
        private System.Windows.Forms.TabPage tabPageROOT_Home;
        private System.Windows.Forms.TabPage tabPageROOT_License;
        private System.Windows.Forms.TabPage tabPageROOT_Database;
        private System.Windows.Forms.TextBox textBoxSupplierUrl;
        private System.Windows.Forms.Label labelSupplierUrl;
        private System.Windows.Forms.TextBox textBoxSupplierName;
        private System.Windows.Forms.Label labelSupplierName;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxCustomerEmail;
        private System.Windows.Forms.Label labelCustomerEmail;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxProductCode;
        private System.Windows.Forms.Label labelProductCode;
        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.PictureBox pictureBoxKeys;
        private System.Windows.Forms.PictureBox pictureBoxSite;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.TextBox textBoxDivision;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelDivision;
        private System.Windows.Forms.TextBox textBoxLicenseType;
        private System.Windows.Forms.TextBox textBoxCorporation;
        private System.Windows.Forms.Label labelCorporation;
        private System.Windows.Forms.TextBox textBoxDeviceName;
        private System.Windows.Forms.Label labelLicenseType;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.Label labelHash;
        private System.Windows.Forms.TextBox textBoxEndDate;
        private System.Windows.Forms.TextBox textBoxStartDate;
        private System.Windows.Forms.TextBox textBoxHash;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.TextBox textBoxLicenseKey;
        private System.Windows.Forms.Label labelLicenseKey;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.TabControl tabControlProject;
        private System.Windows.Forms.TabPage tabPageDefaultParams;
        private System.Windows.Forms.TabPage tabPageCostParams;
        private System.Windows.Forms.Panel panelCostMetadata;
        private System.Windows.Forms.TextBox textBoxCostIndexBaseYearValue;
        private System.Windows.Forms.TextBox textBoxProjectCostMetadata_TITLE;
        private System.Windows.Forms.TextBox textBoxCostIndexBaseYear;
        private System.Windows.Forms.TextBox textBoxCostIndexName;
        private System.Windows.Forms.TextBox textBoxCostIndexNameValue;
        private System.Windows.Forms.TextBox textBoxCostIndexCurrency;
        private System.Windows.Forms.TextBox textBoxCostIndexCurrencyValue;
        private System.Windows.Forms.TextBox textBoxCostIndex;
        private System.Windows.Forms.TextBox textBoxCostIndexValue;
        private System.Windows.Forms.TextBox textBoxInstalledCostFactor;
        private System.Windows.Forms.TextBox textBoxInstalledCostFactorValue;
        private System.Windows.Forms.Panel panelFiredHeaterCapitalCost;
        private System.Windows.Forms.TextBox textBoxDutyUnitsMetric;
        private System.Windows.Forms.TextBox textBoxDutyUnitsMetricValue;
        private System.Windows.Forms.TextBox textBoxEffeciency;
        private System.Windows.Forms.TextBox textBoxEffeciencyValue;
        private System.Windows.Forms.TextBox textBoxParameterBeta;
        private System.Windows.Forms.TextBox textBoxParameterBetaValue;
        private System.Windows.Forms.TextBox textBoxParameterAlphaEnglish;
        private System.Windows.Forms.TextBox textBoxParameterAlphaEnglishValue;
        private System.Windows.Forms.TextBox textBoxParameterAlphaMetric;
        private System.Windows.Forms.TextBox textBoxParameterAlphaMetricValue;
        private System.Windows.Forms.TextBox textBoxFiredHeaterCapitalCost_TITLE;
        private System.Windows.Forms.TextBox textBoxDutyUnitsEnglish;
        private System.Windows.Forms.TextBox textBoxDutyUnitsEnglishValue;
        private System.Windows.Forms.Panel panelShellAndTubeCapitalCost;
        private System.Windows.Forms.TextBox textBoxAreaUnitsEnglish;
        private System.Windows.Forms.TextBox textBoxAreaUnitsEnglishValue;
        private System.Windows.Forms.TextBox textBoxAreaUnitsMetric;
        private System.Windows.Forms.TextBox textBoxAreaUnitsMetricValue;
        private System.Windows.Forms.TextBox textBoxParameterN;
        private System.Windows.Forms.TextBox textBoxParameterN_Value;
        private System.Windows.Forms.TextBox textBoxParameterB_English;
        private System.Windows.Forms.TextBox textBoxParameterB_EnglishValue;
        private System.Windows.Forms.TextBox textBoxParameterB_Metric;
        private System.Windows.Forms.TextBox textBoxParameterB_MetricValue;
        private System.Windows.Forms.TextBox textBoxParameterA;
        private System.Windows.Forms.TextBox textBoxParameterAValue;
        private System.Windows.Forms.TextBox textBoxShellAndTubeCapitalCost_TITLE;
        private System.Windows.Forms.TextBox textBoxMaterialFactor;
        private System.Windows.Forms.TextBox textBoxMaterialFactorValue;
        private System.Windows.Forms.Panel panelTotalAnnualizedCost;
        private System.Windows.Forms.TextBox textBoxTAC_OperatingHours;
        private System.Windows.Forms.TextBox textBoxTAC_OperatingHoursValue;
        private System.Windows.Forms.TextBox textBoxTAC_MaintenanceFraction;
        private System.Windows.Forms.TextBox textBoxTAC_MaintenanceFractionValue;
        private System.Windows.Forms.TextBox textBoxTAC_LifeYears;
        private System.Windows.Forms.TextBox textBoxTAC_LifeYearsValue;
        private System.Windows.Forms.TextBox textBoxTAC_InterestRate;
        private System.Windows.Forms.TextBox textBoxTAC_InterestRateValue;
        private System.Windows.Forms.TextBox textBoxTotalAnnualizedCost_TITLE;
        private System.Windows.Forms.Panel panelUtilityCost;
        private System.Windows.Forms.TextBox textBoxChilledWater;
        private System.Windows.Forms.TextBox textBoxChilledWater_METRIC;
        private System.Windows.Forms.TextBox textBoxFuelGas;
        private System.Windows.Forms.TextBox textBoxFuelGas_METRIC;
        private System.Windows.Forms.TextBox textBoxCoolingWater;
        private System.Windows.Forms.TextBox textBoxCoolingWater_METRIC;
        private System.Windows.Forms.TextBox textBoxLP_Steam;
        private System.Windows.Forms.TextBox textBoxLP_Steam_METRIC;
        private System.Windows.Forms.TextBox textBoxMP_Steam;
        private System.Windows.Forms.TextBox textBoxMP_Steam_METRIC;
        private System.Windows.Forms.TextBox textBoxHP_Steam;
        private System.Windows.Forms.TextBox textBoxHP_Steam_METRIC;
        private System.Windows.Forms.TextBox textBoxUtitlityCost_TITLE;
        private System.Windows.Forms.TextBox textBoxMetric_HEADER;
        private System.Windows.Forms.TextBox textBoxChilledWater_ENGLISH;
        private System.Windows.Forms.TextBox textBoxFuelGas_ENGLISH;
        private System.Windows.Forms.TextBox textBoxCoolingWater_ENGLISH;
        private System.Windows.Forms.TextBox textBoxLP_Steam_ENGLISH;
        private System.Windows.Forms.TextBox textBoxMP_Steam_ENGLISH;
        private System.Windows.Forms.TextBox textBoxHP_Steam_ENGLISH;
        private System.Windows.Forms.TextBox textBoxEnglish_HEADER;
        private System.Windows.Forms.TextBox textBoxUtilityCostUnits_ENGLISH;
        private System.Windows.Forms.TextBox textBoxUtilityCostUnits;
        private System.Windows.Forms.TextBox textBoxUtilityCostUnits_METRIC;
        private System.Windows.Forms.PictureBox pictureBoxCostEq;
        private System.Windows.Forms.ToolStripMenuItem addStudyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelProgressText;
        private System.Windows.Forms.ToolStripMenuItem modifyProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.Panel panelSupplier;
        private System.Windows.Forms.Panel panelCustomerContact;
        private System.Windows.Forms.TextBox textBoxCustomerContactTitle;
        private System.Windows.Forms.TextBox textBoxSupplierTitle;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.TextBox textBoxProductTitle;
        private System.Windows.Forms.Panel panelLicenseType;
        private System.Windows.Forms.TextBox textBoxLicenseTypeTitle;
        private System.Windows.Forms.Panel panelLicense;
        private System.Windows.Forms.TextBox textBoxLicenseTitle;
        private System.Windows.Forms.ListView listViewDatabaseTables;
        private System.Windows.Forms.Panel panelDatabaseTables;
        private System.Windows.Forms.TextBox textBoxDatabaseTablesTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderTableSchema;
        private System.Windows.Forms.ColumnHeader columnHeaderTableName;
        private System.Windows.Forms.TabPage tabPageROOT_FactorSettings;
        private System.Windows.Forms.Panel panelFactorySettings;
        private System.Windows.Forms.TextBox textBoxFactorySettingsTitle;
        private System.Windows.Forms.ListView listViewFactorySettings;
        private System.Windows.Forms.ColumnHeader columnHeaderSettingsNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderSettingsName;
        private System.Windows.Forms.ColumnHeader columnHeaderSettingsValue;
        private System.Windows.Forms.Panel panelAppMetadata;
        private System.Windows.Forms.TextBox textBoxAppMetadataTitle;
        private System.Windows.Forms.ListView listViewAppMetadata;
        private System.Windows.Forms.ColumnHeader columnHeaderMetadataNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderMetadataName;
        private System.Windows.Forms.ColumnHeader columnHeaderAppMetadataValue;
        private System.Windows.Forms.Panel panelAppComponents;
        private System.Windows.Forms.ListView listViewAppComponents;
        private System.Windows.Forms.ColumnHeader columnHeaderComponentsNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderComponentsName;
        private System.Windows.Forms.TextBox textBoxAppComponentsTitle;
        private System.Windows.Forms.Panel panelHomeAJP;
        private System.Windows.Forms.PictureBox pictureBoxHomeAjpLogo;
        private System.Windows.Forms.Panel panelProfileMetadata;
        private System.Windows.Forms.TextBox textBoxProfileId;
        private System.Windows.Forms.TextBox textBoxProfileIdValue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxProfileNameValue;
        private System.Windows.Forms.TextBox textBoxProfileName;
        private System.Windows.Forms.TextBox textBoxProfileDescription;
        private System.Windows.Forms.TextBox textBoxProfileDescriptionValue;
        private System.Windows.Forms.TextBox textBoxProfileProjectId;
        private System.Windows.Forms.TextBox textBoxProfileProjectIdValue;
        private System.Windows.Forms.DataGridView dataGridViewProcessStreams;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessStreamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessStreamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreamType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreamSubtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreamHeat;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeatCapacityFlowRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyPress;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetPress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeltaTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeltaPress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duty;
        private System.Windows.Forms.DataGridViewImageColumn ValidStreamIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreamValidation;
        private System.Windows.Forms.DataGridView dataGridViewUtilityStreams;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsothermalTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.ListView listViewProfileUnits;
        private System.Windows.Forms.ColumnHeader columnHeaderProfileName;
        private System.Windows.Forms.ColumnHeader columnHeaderProfileUnits;
        private System.Windows.Forms.TextBox textBoxUnits;
        private System.Windows.Forms.TabPage tabPageROOT_About;
        private System.Windows.Forms.TabControl tabControlLicense;
        private System.Windows.Forms.TabPage tabPageLicenseFile;
        private System.Windows.Forms.TabPage tabPageLicenseScorecard;
        private System.Windows.Forms.TextBox textBoxDaysRemainingValue;
        private System.Windows.Forms.Label labelDayRemaining;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelScorecardTable;
        private System.Windows.Forms.TextBox textBoxLicenseScorecardTITLE;
        private System.Windows.Forms.DataGridView dataGridViewScoreCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewImageColumn ColumnState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private System.Windows.Forms.Panel panelDeviceUser;
        private System.Windows.Forms.TextBox textBoxDeviceUserTITLE;
        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.TextBox textBoxDevice;
        private System.Windows.Forms.PictureBox pictureBoxRunning;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panelScorecardSummary;
        private System.Windows.Forms.PictureBox pictureBoxValid;
        private System.Windows.Forms.Label labelVaildTotal;
        private System.Windows.Forms.TextBox textBoxScorecardSummary;
        private System.Windows.Forms.PictureBox pictureBoxInvalid;
        private System.Windows.Forms.Label labelInvalidTotal;
        private System.Windows.Forms.PictureBox pictureBoxAjpEngLogo;
        private System.Windows.Forms.TextBox textBoxOverallStatus;
        private System.Windows.Forms.PictureBox pictureBoxDbAjpEndLogo;
        private System.Windows.Forms.PictureBox pictureBoxFactorySettingsAjpEngLogo;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProduct;
        private System.Windows.Forms.Label labelProductFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProductFullNameValue;
        private System.Windows.Forms.Label labelProductNameValue;
        private System.Windows.Forms.Label labelProductVersion;
        private System.Windows.Forms.Label labelProductVersionValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSerialNumberValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelProductCodeValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSupplier;
        private System.Windows.Forms.Label labelSuplierName;
        private System.Windows.Forms.Label labelSupplierNameValue;
        private System.Windows.Forms.PictureBox pictureBoxProductWarning;
        private System.Windows.Forms.PictureBox pictureBoxHenStudio;
        private System.Windows.Forms.PictureBox pictureBoxLicenseAgreement;
        private System.Windows.Forms.PictureBox pictureBoxAjpContactInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelExitApp;
        private System.Windows.Forms.TextBox textBoxOptimizerConvergTolerance;
        private System.Windows.Forms.TextBox textBoxOptimizerMaxInter;
        private System.Windows.Forms.TextBox textBoxOptimizerObjective;
        private System.Windows.Forms.TextBox textBoxOptimizerType;
        private System.Windows.Forms.TextBox textBoxOptimizerName;
        private System.Windows.Forms.Panel panelTypicalURanges;
        private System.Windows.Forms.TextBox textBoxTypicalULabel;
        private System.Windows.Forms.TextBox textBoxOptimizerDescription;
        private System.Windows.Forms.TextBox textBoxOptimizerDescriptionValue;
        private System.Windows.Forms.TextBox textBoxOptimizerNameValue;
        private System.Windows.Forms.TextBox textBoxOptimizerObjectiveValue;
        private System.Windows.Forms.TextBox textBoxOptimzerTypeValue;
        private System.Windows.Forms.TextBox textBoxOptimizerConvergToler;
        private System.Windows.Forms.TextBox textBoxOptimizerMaxIterValue;
        private System.Windows.Forms.ListView listViewTypicalURanges;
        private System.Windows.Forms.TextBox textBoxExchangerEquations;
        private System.Windows.Forms.ColumnHeader columnHeaderUService;
        private System.Windows.Forms.ColumnHeader columnHeaderURange;
        private System.Windows.Forms.ColumnHeader columnHeaderUNote;
        private System.Windows.Forms.TextBox textBoxHeatTransferCoeffUnitsValue;
        private System.Windows.Forms.TextBox textBoxHeatTransferCoeffUnits;
    }
}

