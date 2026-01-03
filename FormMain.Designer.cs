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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specifyInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.calculateTargetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.designHeatExchangerNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageINPUT = new System.Windows.Forms.TabPage();
            this.tabPageTARGETS = new System.Windows.Forms.TabPage();
            this.tabPageHEN = new System.Windows.Forms.TabPage();
            this.imageListAnalysis = new System.Windows.Forms.ImageList(this.components);
            this.panelINPUT = new System.Windows.Forms.Panel();
            this.panelTARGETS = new System.Windows.Forms.Panel();
            this.panelHEN = new System.Windows.Forms.Panel();
            this.menuStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1264, 38);
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
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(199, 36);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(199, 36);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(199, 36);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(199, 36);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 36);
            this.exitToolStripMenuItem.Text = "Exit";
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
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(101, 32);
            this.analysisToolStripMenuItem.Text = "Analysis";
            // 
            // specifyInputToolStripMenuItem
            // 
            this.specifyInputToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("specifyInputToolStripMenuItem.Image")));
            this.specifyInputToolStripMenuItem.Name = "specifyInputToolStripMenuItem";
            this.specifyInputToolStripMenuItem.Size = new System.Drawing.Size(425, 36);
            this.specifyInputToolStripMenuItem.Text = "Specify Input...";
            this.specifyInputToolStripMenuItem.Click += new System.EventHandler(this.specifyInputToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(422, 6);
            // 
            // calculateTargetsToolStripMenuItem
            // 
            this.calculateTargetsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculateTargetsToolStripMenuItem.Image")));
            this.calculateTargetsToolStripMenuItem.Name = "calculateTargetsToolStripMenuItem";
            this.calculateTargetsToolStripMenuItem.Size = new System.Drawing.Size(425, 36);
            this.calculateTargetsToolStripMenuItem.Text = "Calculate Targets...";
            this.calculateTargetsToolStripMenuItem.Click += new System.EventHandler(this.calculateTargetsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(422, 6);
            // 
            // designHeatExchangerNetworkToolStripMenuItem
            // 
            this.designHeatExchangerNetworkToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("designHeatExchangerNetworkToolStripMenuItem.Image")));
            this.designHeatExchangerNetworkToolStripMenuItem.Name = "designHeatExchangerNetworkToolStripMenuItem";
            this.designHeatExchangerNetworkToolStripMenuItem.Size = new System.Drawing.Size(425, 36);
            this.designHeatExchangerNetworkToolStripMenuItem.Text = "Design Heat Exchanger Network...";
            this.designHeatExchangerNetworkToolStripMenuItem.Click += new System.EventHandler(this.designHeatExchangerNetworkToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(71, 32);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(196, 36);
            this.licenseToolStripMenuItem.Text = "License...";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(196, 36);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripMain.Location = new System.Drawing.Point(0, 659);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1264, 22);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStripPinch";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlMain.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlMain.Controls.Add(this.tabPageINPUT);
            this.tabControlMain.Controls.Add(this.tabPageTARGETS);
            this.tabControlMain.Controls.Add(this.tabPageHEN);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlMain.ImageList = this.imageListAnalysis;
            this.tabControlMain.Location = new System.Drawing.Point(0, 613);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.ShowToolTips = true;
            this.tabControlMain.Size = new System.Drawing.Size(1264, 46);
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
            this.panelINPUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelINPUT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelINPUT.Location = new System.Drawing.Point(0, 38);
            this.panelINPUT.Name = "panelINPUT";
            this.panelINPUT.Size = new System.Drawing.Size(1264, 575);
            this.panelINPUT.TabIndex = 3;
            // 
            // panelTARGETS
            // 
            this.panelTARGETS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelTARGETS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTARGETS.Location = new System.Drawing.Point(0, 38);
            this.panelTARGETS.Name = "panelTARGETS";
            this.panelTARGETS.Size = new System.Drawing.Size(1264, 575);
            this.panelTARGETS.TabIndex = 4;
            // 
            // panelHEN
            // 
            this.panelHEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelHEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHEN.Location = new System.Drawing.Point(0, 38);
            this.panelHEN.Name = "panelHEN";
            this.panelHEN.Size = new System.Drawing.Size(1264, 575);
            this.panelHEN.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelHEN);
            this.Controls.Add(this.panelTARGETS);
            this.Controls.Add(this.panelINPUT);
            this.Controls.Add(this.tabControlMain);
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
            this.Text = "AJP Pinch 4";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
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
    }
}

