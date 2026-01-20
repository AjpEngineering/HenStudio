namespace AJP_LicenseGenerator
{
    partial class FormMoveLicenseFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoveLicenseFile));
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxMove = new System.Windows.Forms.GroupBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelTarget = new System.Windows.Forms.Label();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.buttonSource = new System.Windows.Forms.Button();
            this.buttonTarget = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.labelMoveStatus = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialogLicense = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxStatus.ForeColor = System.Drawing.Color.Green;
            this.textBoxStatus.Location = new System.Drawing.Point(12, 12);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(660, 27);
            this.textBoxStatus.TabIndex = 0;
            this.textBoxStatus.Text = "License File Created at Source Location!";
            this.textBoxStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(538, 205);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(120, 38);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            // 
            // groupBoxMove
            // 
            this.groupBoxMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMove.BackColor = System.Drawing.Color.LightCyan;
            this.groupBoxMove.Controls.Add(this.buttonMove);
            this.groupBoxMove.Controls.Add(this.buttonTarget);
            this.groupBoxMove.Controls.Add(this.buttonSource);
            this.groupBoxMove.Controls.Add(this.textBoxTarget);
            this.groupBoxMove.Controls.Add(this.textBoxSource);
            this.groupBoxMove.Controls.Add(this.labelTarget);
            this.groupBoxMove.Controls.Add(this.labelSource);
            this.groupBoxMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxMove.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBoxMove.Location = new System.Drawing.Point(12, 57);
            this.groupBoxMove.Name = "groupBoxMove";
            this.groupBoxMove.Size = new System.Drawing.Size(660, 126);
            this.groupBoxMove.TabIndex = 2;
            this.groupBoxMove.TabStop = false;
            this.groupBoxMove.Text = "Move";
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.ForeColor = System.Drawing.Color.Green;
            this.labelSource.Location = new System.Drawing.Point(18, 32);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(65, 20);
            this.labelSource.TabIndex = 0;
            this.labelSource.Text = "Source: ";
            this.labelSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.ForeColor = System.Drawing.Color.Blue;
            this.labelTarget.Location = new System.Drawing.Point(18, 61);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(59, 20);
            this.labelTarget.TabIndex = 1;
            this.labelTarget.Text = "Target: ";
            this.labelTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSource
            // 
            this.textBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSource.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSource.ForeColor = System.Drawing.Color.Green;
            this.textBoxSource.Location = new System.Drawing.Point(89, 33);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.ReadOnly = true;
            this.textBoxSource.Size = new System.Drawing.Size(525, 18);
            this.textBoxSource.TabIndex = 2;
            this.textBoxSource.Text = "Source Location HERE!";
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxTarget.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTarget.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTarget.ForeColor = System.Drawing.Color.Blue;
            this.textBoxTarget.Location = new System.Drawing.Point(89, 63);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.ReadOnly = true;
            this.textBoxTarget.Size = new System.Drawing.Size(525, 18);
            this.textBoxTarget.TabIndex = 3;
            this.textBoxTarget.Text = "Target Location HERE!";
            // 
            // buttonSource
            // 
            this.buttonSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSource.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSource.ForeColor = System.Drawing.Color.Green;
            this.buttonSource.Location = new System.Drawing.Point(618, 28);
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.Size = new System.Drawing.Size(36, 26);
            this.buttonSource.TabIndex = 4;
            this.buttonSource.Text = "...";
            this.buttonSource.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSource.UseVisualStyleBackColor = false;
            this.buttonSource.Visible = false;
            // 
            // buttonTarget
            // 
            this.buttonTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTarget.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTarget.ForeColor = System.Drawing.Color.Blue;
            this.buttonTarget.Location = new System.Drawing.Point(618, 60);
            this.buttonTarget.Name = "buttonTarget";
            this.buttonTarget.Size = new System.Drawing.Size(36, 26);
            this.buttonTarget.TabIndex = 5;
            this.buttonTarget.Text = "...";
            this.buttonTarget.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTarget.UseVisualStyleBackColor = false;
            this.buttonTarget.Click += new System.EventHandler(this.buttonTarget_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonMove.Location = new System.Drawing.Point(172, 87);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(312, 29);
            this.buttonMove.TabIndex = 0;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = false;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // labelMoveStatus
            // 
            this.labelMoveStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMoveStatus.AutoSize = true;
            this.labelMoveStatus.BackColor = System.Drawing.Color.White;
            this.labelMoveStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMoveStatus.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelMoveStatus.Location = new System.Drawing.Point(241, 215);
            this.labelMoveStatus.Name = "labelMoveStatus";
            this.labelMoveStatus.Size = new System.Drawing.Size(268, 20);
            this.labelMoveStatus.TabIndex = 7;
            this.labelMoveStatus.Text = "UNSUCCESSFUL Move - See Console!";
            this.labelMoveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxLogo.Image = global::AJP_LicenseGenerator.Properties.Resources.AJP_Engineering_Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(11, 189);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(198, 60);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // folderBrowserDialogLicense
            // 
            this.folderBrowserDialogLicense.Description = "Select the Target Folder";
            // 
            // FormMoveLicenseFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.labelMoveStatus);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.groupBoxMove);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxStatus);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(800, 300);
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "FormMoveLicenseFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Move License File";
            this.groupBoxMove.ResumeLayout(false);
            this.groupBoxMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxMove;
        private System.Windows.Forms.Button buttonSource;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelMoveStatus;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonTarget;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogLicense;
    }
}