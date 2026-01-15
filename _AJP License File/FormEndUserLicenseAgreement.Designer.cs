namespace _AJP_License_File
{
    partial class FormEndUserLicenseAgreement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEndUserLicenseAgreement));
            this.richTextBoxEULA = new System.Windows.Forms.RichTextBox();
            this.textBoxRegister = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxEULA
            // 
            this.richTextBoxEULA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxEULA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBoxEULA.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxEULA.Location = new System.Drawing.Point(6, 12);
            this.richTextBoxEULA.Name = "richTextBoxEULA";
            this.richTextBoxEULA.ReadOnly = true;
            this.richTextBoxEULA.Size = new System.Drawing.Size(827, 605);
            this.richTextBoxEULA.TabIndex = 0;
            this.richTextBoxEULA.Text = "";
            // 
            // textBoxRegister
            // 
            this.textBoxRegister.BackColor = System.Drawing.Color.White;
            this.textBoxRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegister.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegister.ForeColor = System.Drawing.Color.Black;
            this.textBoxRegister.Location = new System.Drawing.Point(242, 26);
            this.textBoxRegister.Name = "textBoxRegister";
            this.textBoxRegister.Size = new System.Drawing.Size(433, 25);
            this.textBoxRegister.TabIndex = 37;
            this.textBoxRegister.Text = "AJP Engineering - End User License Agreement (EULA)";
            this.textBoxRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxLogo.Image = global::_AJP_License_File.Properties.Resources.AJP_License_File_Logo___Transparent;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(212, 71);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 27;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelButton
            // 
            this.panelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButton.BackColor = System.Drawing.Color.White;
            this.panelButton.Controls.Add(this.textBoxRegister);
            this.panelButton.Controls.Add(this.buttonOk);
            this.panelButton.Controls.Add(this.pictureBoxLogo);
            this.panelButton.Location = new System.Drawing.Point(3, 623);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(839, 77);
            this.panelButton.TabIndex = 41;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(702, 20);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(128, 36);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormEndUserLicenseAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 701);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.richTextBoxEULA);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(860, 740);
            this.Name = "FormEndUserLicenseAgreement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AJP Engineering - End User License Agreement";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEndUserLicenseAgreement_FormClosing);
            this.Load += new System.EventHandler(this.FormEndUserLicenseAgreement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxEULA;
        private System.Windows.Forms.TextBox textBoxRegister;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonOk;
    }
}