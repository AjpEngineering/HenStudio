namespace Pinch
{
    partial class FormLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLicense));
            this.buttonOK = new System.Windows.Forms.Button();
            this.pictureBoxAJPEngLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAJPEngLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.White;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(288, 1095);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(145, 42);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            // 
            // pictureBoxAJPEngLogo
            // 
            this.pictureBoxAJPEngLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(216)))), ((int)(((byte)(111)))));
            this.pictureBoxAJPEngLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAJPEngLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAJPEngLogo.Image")));
            this.pictureBoxAJPEngLogo.Location = new System.Drawing.Point(485, 1083);
            this.pictureBoxAJPEngLogo.Name = "pictureBoxAJPEngLogo";
            this.pictureBoxAJPEngLogo.Size = new System.Drawing.Size(194, 60);
            this.pictureBoxAJPEngLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAJPEngLogo.TabIndex = 9;
            this.pictureBoxAJPEngLogo.TabStop = false;
            this.pictureBoxAJPEngLogo.DoubleClick += new System.EventHandler(this.pictureBoxAJPEngLogo_DoubleClick);
            // 
            // FormLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(704, 1155);
            this.Controls.Add(this.pictureBoxAJPEngLogo);
            this.Controls.Add(this.buttonOK);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(720, 1200);
            this.MinimumSize = new System.Drawing.Size(720, 1137);
            this.Name = "FormLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAJPEngLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.PictureBox pictureBoxAJPEngLogo;
    }
}