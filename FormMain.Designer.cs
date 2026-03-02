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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scorecardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.userLicenseAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLicense = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelUnits = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelInput = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTargets = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSELECTED_STATE = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageListAnalysis = new System.Windows.Forms.ImageList(this.components);
            this.imageListInput = new System.Windows.Forms.ImageList(this.components);
            this.imageListTargets = new System.Windows.Forms.ImageList(this.components);
            this.imageListHen = new System.Windows.Forms.ImageList(this.components);
            this.toolStripStatusLabelDbConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
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
            this.newToolStripMenuItem.Image = global::HenStudio.Properties.Resources.New_32x32;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.ToolTipText = "Create New Project File";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::HenStudio.Properties.Resources.Open_32x32;
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
            this.saveToolStripMenuItem.Image = global::HenStudio.Properties.Resources.Save_32x32;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.ToolTipText = "Save Current Project File";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::HenStudio.Properties.Resources.SaveAs_32x_32;
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
            this.importToolStripMenuItem.Image = global::HenStudio.Properties.Resources.Import;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.importToolStripMenuItem.Text = "Import...";
            this.importToolStripMenuItem.ToolTipText = "Import Results File";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = global::HenStudio.Properties.Resources.Export_32x32;
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
            this.exitToolStripMenuItem.Image = global::HenStudio.Properties.Resources.Exit_32x32;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exit Application";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.licenseToolStripMenuItem.Image = global::HenStudio.Properties.Resources.License_32x32;
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.licenseToolStripMenuItem.Text = "License...";
            this.licenseToolStripMenuItem.ToolTipText = "Launch License Viewer";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // scorecardToolStripMenuItem
            // 
            this.scorecardToolStripMenuItem.Image = global::HenStudio.Properties.Resources.Scorecard_Check_32x32;
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
            // userLicenseAgreementToolStripMenuItem
            // 
            this.userLicenseAgreementToolStripMenuItem.Image = global::HenStudio.Properties.Resources.AJP_User_License_Agreement__32x32;
            this.userLicenseAgreementToolStripMenuItem.Name = "userLicenseAgreementToolStripMenuItem";
            this.userLicenseAgreementToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.userLicenseAgreementToolStripMenuItem.Text = "User License Agreement";
            this.userLicenseAgreementToolStripMenuItem.ToolTipText = "Display User License Agreement";
            this.userLicenseAgreementToolStripMenuItem.Click += new System.EventHandler(this.userLicenseAgreementToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::HenStudio.Properties.Resources.About_32x32;
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
            this.toolStripStatusLabelDbConnect,
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
            this.toolStripStatusLabelUnits.Image = global::HenStudio.Properties.Resources.Unknown_32x32;
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
            this.toolStripStatusLabelInput.Image = global::HenStudio.Properties.Resources.InValid_32x32;
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
            this.toolStripStatusLabelTargets.Image = global::HenStudio.Properties.Resources.InValid_32x32;
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
            this.toolStripStatusLabelSELECTED_STATE.Image = global::HenStudio.Properties.Resources.AJP_Logo___600x600;
            this.toolStripStatusLabelSELECTED_STATE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelSELECTED_STATE.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripStatusLabelSELECTED_STATE.Name = "toolStripStatusLabelSELECTED_STATE";
            this.toolStripStatusLabelSELECTED_STATE.Size = new System.Drawing.Size(190, 28);
            this.toolStripStatusLabelSELECTED_STATE.Spring = true;
            this.toolStripStatusLabelSELECTED_STATE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelSELECTED_STATE.ToolTipText = "Displayed View";
            // 
            // imageListAnalysis
            // 
            this.imageListAnalysis.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAnalysis.ImageStream")));
            this.imageListAnalysis.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAnalysis.Images.SetKeyName(0, "Input.png");
            this.imageListAnalysis.Images.SetKeyName(1, "Target.png");
            this.imageListAnalysis.Images.SetKeyName(2, "HEN.png");
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
            // toolStripStatusLabelDbConnect
            // 
            this.toolStripStatusLabelDbConnect.BackColor = System.Drawing.Color.Green;
            this.toolStripStatusLabelDbConnect.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelDbConnect.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelDbConnect.Image = global::HenStudio.Properties.Resources.Valid_32x32;
            this.toolStripStatusLabelDbConnect.Name = "toolStripStatusLabelDbConnect";
            this.toolStripStatusLabelDbConnect.Size = new System.Drawing.Size(155, 29);
            this.toolStripStatusLabelDbConnect.Text = "DB CONNECTED";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AJP HEN Studio";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ImageList imageListAnalysis;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSELECTED_STATE;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ImageList imageListInput;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListTargets;
        private System.Windows.Forms.ImageList imageListHen;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLicense;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUnits;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInput;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTargets;
        private System.Windows.Forms.ToolStripMenuItem scorecardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userLicenseAgreementToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDbConnect;
    }
}

