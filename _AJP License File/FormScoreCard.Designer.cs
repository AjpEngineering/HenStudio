namespace AJP_License_File
{
    partial class FormScoreCard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScoreCard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewScoreCard = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnState = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.statusStripStatusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLogo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelValidCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelInvalidCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRemainingDays = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRunningEnv = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonContactInfo = new System.Windows.Forms.Button();
            this.imageListScoreCard = new System.Windows.Forms.ImageList();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreCard)).BeginInit();
            this.statusStripStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewScoreCard
            // 
            this.dataGridViewScoreCard.AllowUserToAddRows = false;
            this.dataGridViewScoreCard.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewScoreCard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewScoreCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewScoreCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewScoreCard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewScoreCard.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewScoreCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewScoreCard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewScoreCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScoreCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnState,
            this.ColumnProperty,
            this.ColumnValue});
            this.dataGridViewScoreCard.Location = new System.Drawing.Point(-1, 40);
            this.dataGridViewScoreCard.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewScoreCard.Name = "dataGridViewScoreCard";
            this.dataGridViewScoreCard.ReadOnly = true;
            this.dataGridViewScoreCard.RowHeadersVisible = false;
            this.dataGridViewScoreCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewScoreCard.Size = new System.Drawing.Size(1135, 796);
            this.dataGridViewScoreCard.TabIndex = 0;
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
            this.ColumnID.Width = 46;
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
            this.ColumnState.Width = 77;
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
            this.ColumnProperty.Width = 94;
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
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.BackColor = System.Drawing.Color.OrangeRed;
            this.textBoxTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.ForeColor = System.Drawing.Color.White;
            this.textBoxTitle.Location = new System.Drawing.Point(0, 2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(1134, 33);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.Text = "INVALID LICENSE";
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonOK.FlatAppearance.BorderSize = 2;
            this.buttonOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonOK.Location = new System.Drawing.Point(5, 753);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(775, 38);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            // 
            // statusStripStatusBar
            // 
            this.statusStripStatusBar.BackColor = System.Drawing.Color.White;
            this.statusStripStatusBar.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripStatusBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStripStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLogo,
            this.toolStripStatusLabelValidCount,
            this.toolStripStatusLabelInvalidCount,
            this.toolStripStatusLabelRemainingDays,
            this.toolStripStatusLabelRunningEnv});
            this.statusStripStatusBar.Location = new System.Drawing.Point(0, 797);
            this.statusStripStatusBar.Name = "statusStripStatusBar";
            this.statusStripStatusBar.Size = new System.Drawing.Size(1134, 44);
            this.statusStripStatusBar.TabIndex = 3;
            this.statusStripStatusBar.Text = "ScoreCardStatusBar";
            // 
            // toolStripStatusLabelLogo
            // 
            this.toolStripStatusLabelLogo.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelLogo.Image = global::AJP_License_File.Properties.Resources.AJP_Logo_32x32;
            this.toolStripStatusLabelLogo.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripStatusLabelLogo.Name = "toolStripStatusLabelLogo";
            this.toolStripStatusLabelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripStatusLabelLogo.Size = new System.Drawing.Size(52, 32);
            this.toolStripStatusLabelLogo.Click += new System.EventHandler(this.toolStripStatusLabelLogo_Click);
            // 
            // toolStripStatusLabelValidCount
            // 
            this.toolStripStatusLabelValidCount.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabelValidCount.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabelValidCount.ForeColor = System.Drawing.Color.Green;
            this.toolStripStatusLabelValidCount.Image = global::AJP_License_File.Properties.Resources.Valid_32x32;
            this.toolStripStatusLabelValidCount.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripStatusLabelValidCount.Name = "toolStripStatusLabelValidCount";
            this.toolStripStatusLabelValidCount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripStatusLabelValidCount.Size = new System.Drawing.Size(75, 32);
            this.toolStripStatusLabelValidCount.Text = "xxx";
            this.toolStripStatusLabelValidCount.ToolTipText = "Number of VALID Properties";
            // 
            // toolStripStatusLabelInvalidCount
            // 
            this.toolStripStatusLabelInvalidCount.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabelInvalidCount.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.toolStripStatusLabelInvalidCount.ForeColor = System.Drawing.Color.OrangeRed;
            this.toolStripStatusLabelInvalidCount.Image = global::AJP_License_File.Properties.Resources.InValid_32x32;
            this.toolStripStatusLabelInvalidCount.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripStatusLabelInvalidCount.Name = "toolStripStatusLabelInvalidCount";
            this.toolStripStatusLabelInvalidCount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripStatusLabelInvalidCount.Size = new System.Drawing.Size(75, 32);
            this.toolStripStatusLabelInvalidCount.Text = "xxx";
            this.toolStripStatusLabelInvalidCount.ToolTipText = "Number of INVALID Properties";
            // 
            // toolStripStatusLabelRemainingDays
            // 
            this.toolStripStatusLabelRemainingDays.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabelRemainingDays.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabelRemainingDays.Image = global::AJP_License_File.Properties.Resources.Calendar_White_Background_32x32;
            this.toolStripStatusLabelRemainingDays.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripStatusLabelRemainingDays.Name = "toolStripStatusLabelRemainingDays";
            this.toolStripStatusLabelRemainingDays.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripStatusLabelRemainingDays.Size = new System.Drawing.Size(116, 32);
            this.toolStripStatusLabelRemainingDays.Text = "xxx days ";
            this.toolStripStatusLabelRemainingDays.ToolTipText = "Day until Expiriation";
            // 
            // toolStripStatusLabelRunningEnv
            // 
            this.toolStripStatusLabelRunningEnv.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.toolStripStatusLabelRunningEnv.Image = global::AJP_License_File.Properties.Resources.Running_White_Background_32x32;
            this.toolStripStatusLabelRunningEnv.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripStatusLabelRunningEnv.Name = "toolStripStatusLabelRunningEnv";
            this.toolStripStatusLabelRunningEnv.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripStatusLabelRunningEnv.Size = new System.Drawing.Size(801, 32);
            this.toolStripStatusLabelRunningEnv.Spring = true;
            this.toolStripStatusLabelRunningEnv.Text = "Device: xxxxxxxxxxxxxxx User: xxxxxxxxxxxxxxxxxxxx Fullname: xxxxxxxxxxxxxxxxxxxx" +
    "xxxxxxxxxxxxxxxx ";
            this.toolStripStatusLabelRunningEnv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabelRunningEnv.ToolTipText = "Running Environment";
            // 
            // buttonContactInfo
            // 
            this.buttonContactInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonContactInfo.BackColor = System.Drawing.Color.Honeydew;
            this.buttonContactInfo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonContactInfo.FlatAppearance.BorderSize = 2;
            this.buttonContactInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonContactInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonContactInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContactInfo.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContactInfo.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonContactInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonContactInfo.ImageIndex = 0;
            this.buttonContactInfo.ImageList = this.imageListScoreCard;
            this.buttonContactInfo.Location = new System.Drawing.Point(786, 752);
            this.buttonContactInfo.Name = "buttonContactInfo";
            this.buttonContactInfo.Size = new System.Drawing.Size(334, 38);
            this.buttonContactInfo.TabIndex = 4;
            this.buttonContactInfo.Text = "AJP Engineering Contact Info...";
            this.buttonContactInfo.UseVisualStyleBackColor = false;
            this.buttonContactInfo.Click += new System.EventHandler(this.buttonContactInfo_Click);
            // 
            // imageListScoreCard
            // 
            this.imageListScoreCard.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListScoreCard.ImageStream")));
            this.imageListScoreCard.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListScoreCard.Images.SetKeyName(0, "AJP.ico");
            // 
            // FormScoreCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 841);
            this.Controls.Add(this.buttonContactInfo);
            this.Controls.Add(this.statusStripStatusBar);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.dataGridViewScoreCard);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1150, 880);
            this.Name = "FormScoreCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "License Scorecard";
            this.Load += new System.EventHandler(this.FormScoreCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreCard)).EndInit();
            this.statusStripStatusBar.ResumeLayout(false);
            this.statusStripStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewScoreCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewImageColumn ColumnState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.StatusStrip statusStripStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelValidCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInvalidCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRemainingDays;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRunningEnv;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLogo;
        private System.Windows.Forms.Button buttonContactInfo;
        private System.Windows.Forms.ImageList imageListScoreCard;
    }
}