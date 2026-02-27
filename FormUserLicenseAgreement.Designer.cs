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
            this.richTextBoxAgreement.BackColor = System.Drawing.Color.NavajoWhite;
            this.richTextBoxAgreement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxAgreement.DetectUrls = false;
            this.richTextBoxAgreement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxAgreement.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAgreement.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxAgreement.Name = "richTextBoxAgreement";
            this.richTextBoxAgreement.ReadOnly = true;
            this.richTextBoxAgreement.Size = new System.Drawing.Size(778, 555);
            this.richTextBoxAgreement.TabIndex = 0;
            this.richTextBoxAgreement.Text = resources.GetString("richTextBoxAgreement.Text");
            this.richTextBoxAgreement.ZoomFactor = 1.25F;
            // 
            // FormUserLicenseAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.richTextBoxAgreement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormUserLicenseAgreement";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AJP User License Agreement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxAgreement;
    }
}