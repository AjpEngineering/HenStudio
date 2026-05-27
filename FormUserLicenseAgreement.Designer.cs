namespace HenStudio
{
    partial class FormUserLicenseAgreement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserLicenseAgreement));
            this.richTextBoxAgreement = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxAgreement
            // 
            this.richTextBoxAgreement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAgreement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxAgreement.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxAgreement.Name = "richTextBoxAgreement";
            this.richTextBoxAgreement.Size = new System.Drawing.Size(760, 437);
            this.richTextBoxAgreement.TabIndex = 0;
            this.richTextBoxAgreement.Text = "";
            // 
            // FormUserLicenseAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.richTextBoxAgreement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormUserLicenseAgreement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AJP User License Agreement";
            this.Load += new System.EventHandler(this.FormUserLicenseAgreement_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxAgreement;
    }
}