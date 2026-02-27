namespace HenStudio
{
    partial class FormAboutPinch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutPinch));
            this.tableLayoutPanelSupplier = new System.Windows.Forms.TableLayoutPanel();
            this.labelSuplierName = new System.Windows.Forms.Label();
            this.labelSupplierNameValue = new System.Windows.Forms.Label();
            this.tableLayoutPanelProduct = new System.Windows.Forms.TableLayoutPanel();
            this.labelProductFullName = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductFullNameValue = new System.Windows.Forms.Label();
            this.labelProductNameValue = new System.Windows.Forms.Label();
            this.labelProductVersion = new System.Windows.Forms.Label();
            this.labelProductVersionValue = new System.Windows.Forms.Label();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.labelSerialNumberValue = new System.Windows.Forms.Label();
            this.labelProductCode = new System.Windows.Forms.Label();
            this.labelProductCodeValue = new System.Windows.Forms.Label();
            this.pictureBoxProductWarning = new System.Windows.Forms.PictureBox();
            this.pictureBoxAJPEngLogo = new System.Windows.Forms.PictureBox();
            this.buttonUserLicenseAgreement = new System.Windows.Forms.Button();
            this.labelUserLicenseAgreement = new System.Windows.Forms.Label();
            this.tableLayoutPanelSupplier.SuspendLayout();
            this.tableLayoutPanelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAJPEngLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelSupplier
            // 
            this.tableLayoutPanelSupplier.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.tableLayoutPanelSupplier.ColumnCount = 2;
            this.tableLayoutPanelSupplier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.97872F));
            this.tableLayoutPanelSupplier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.02128F));
            this.tableLayoutPanelSupplier.Controls.Add(this.labelSuplierName, 0, 0);
            this.tableLayoutPanelSupplier.Controls.Add(this.labelSupplierNameValue, 1, 0);
            this.tableLayoutPanelSupplier.Location = new System.Drawing.Point(315, 220);
            this.tableLayoutPanelSupplier.Name = "tableLayoutPanelSupplier";
            this.tableLayoutPanelSupplier.RowCount = 1;
            this.tableLayoutPanelSupplier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            this.tableLayoutPanelSupplier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.06897F));
            this.tableLayoutPanelSupplier.Size = new System.Drawing.Size(479, 31);
            this.tableLayoutPanelSupplier.TabIndex = 0;
            // 
            // labelSuplierName
            // 
            this.labelSuplierName.AutoSize = true;
            this.labelSuplierName.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.labelSuplierName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSuplierName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSuplierName.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.labelSupplierNameValue.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierNameValue.Location = new System.Drawing.Point(157, 0);
            this.labelSupplierNameValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelSupplierNameValue.Name = "labelSupplierNameValue";
            this.labelSupplierNameValue.Size = new System.Drawing.Size(322, 31);
            this.labelSupplierNameValue.TabIndex = 1;
            this.labelSupplierNameValue.Text = "  AJP Engineering";
            this.labelSupplierNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelProduct
            // 
            this.tableLayoutPanelProduct.BackColor = System.Drawing.Color.DarkOrange;
            this.tableLayoutPanelProduct.ColumnCount = 2;
            this.tableLayoutPanelProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.13609F));
            this.tableLayoutPanelProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.86391F));
            this.tableLayoutPanelProduct.Controls.Add(this.labelProductFullName, 0, 0);
            this.tableLayoutPanelProduct.Controls.Add(this.labelProductName, 0, 1);
            this.tableLayoutPanelProduct.Controls.Add(this.labelProductFullNameValue, 1, 0);
            this.tableLayoutPanelProduct.Controls.Add(this.labelProductNameValue, 1, 1);
            this.tableLayoutPanelProduct.Controls.Add(this.labelProductVersion, 0, 2);
            this.tableLayoutPanelProduct.Controls.Add(this.labelProductVersionValue, 1, 2);
            this.tableLayoutPanelProduct.Controls.Add(this.labelSerialNumber, 0, 3);
            this.tableLayoutPanelProduct.Controls.Add(this.labelSerialNumberValue, 1, 3);
            this.tableLayoutPanelProduct.Controls.Add(this.labelProductCode, 0, 4);
            this.tableLayoutPanelProduct.Controls.Add(this.labelProductCodeValue, 1, 4);
            this.tableLayoutPanelProduct.Location = new System.Drawing.Point(315, 257);
            this.tableLayoutPanelProduct.Name = "tableLayoutPanelProduct";
            this.tableLayoutPanelProduct.RowCount = 5;
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelProduct.Size = new System.Drawing.Size(479, 140);
            this.tableLayoutPanelProduct.TabIndex = 1;
            // 
            // labelProductFullName
            // 
            this.labelProductFullName.AutoSize = true;
            this.labelProductFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductFullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProductFullName.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductFullName.Location = new System.Drawing.Point(3, 0);
            this.labelProductFullName.Name = "labelProductFullName";
            this.labelProductFullName.Size = new System.Drawing.Size(152, 28);
            this.labelProductFullName.TabIndex = 0;
            this.labelProductFullName.Text = "Product Full Name";
            this.labelProductFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProductName.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(3, 28);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(152, 28);
            this.labelProductName.TabIndex = 2;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelProductFullNameValue
            // 
            this.labelProductFullNameValue.AutoSize = true;
            this.labelProductFullNameValue.BackColor = System.Drawing.Color.White;
            this.labelProductFullNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductFullNameValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProductFullNameValue.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductFullNameValue.Location = new System.Drawing.Point(158, 0);
            this.labelProductFullNameValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProductFullNameValue.Name = "labelProductFullNameValue";
            this.labelProductFullNameValue.Size = new System.Drawing.Size(321, 28);
            this.labelProductFullNameValue.TabIndex = 3;
            this.labelProductFullNameValue.Text = "  AJP Pinch 4.0";
            this.labelProductFullNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProductNameValue
            // 
            this.labelProductNameValue.AutoSize = true;
            this.labelProductNameValue.BackColor = System.Drawing.Color.White;
            this.labelProductNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductNameValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProductNameValue.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductNameValue.Location = new System.Drawing.Point(158, 28);
            this.labelProductNameValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProductNameValue.Name = "labelProductNameValue";
            this.labelProductNameValue.Size = new System.Drawing.Size(321, 28);
            this.labelProductNameValue.TabIndex = 4;
            this.labelProductNameValue.Text = "  AJP Pinch";
            this.labelProductNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProductVersion
            // 
            this.labelProductVersion.AutoSize = true;
            this.labelProductVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProductVersion.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.labelProductVersionValue.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductVersionValue.Location = new System.Drawing.Point(158, 56);
            this.labelProductVersionValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProductVersionValue.Name = "labelProductVersionValue";
            this.labelProductVersionValue.Size = new System.Drawing.Size(321, 28);
            this.labelProductVersionValue.TabIndex = 6;
            this.labelProductVersionValue.Text = "  4.0.1";
            this.labelProductVersionValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSerialNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSerialNumber.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerialNumber.Location = new System.Drawing.Point(0, 84);
            this.labelSerialNumber.Margin = new System.Windows.Forms.Padding(0);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(158, 28);
            this.labelSerialNumber.TabIndex = 7;
            this.labelSerialNumber.Text = "Product Serial Number";
            this.labelSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSerialNumberValue
            // 
            this.labelSerialNumberValue.AutoSize = true;
            this.labelSerialNumberValue.BackColor = System.Drawing.Color.White;
            this.labelSerialNumberValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSerialNumberValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSerialNumberValue.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerialNumberValue.Location = new System.Drawing.Point(158, 84);
            this.labelSerialNumberValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelSerialNumberValue.Name = "labelSerialNumberValue";
            this.labelSerialNumberValue.Size = new System.Drawing.Size(321, 28);
            this.labelSerialNumberValue.TabIndex = 8;
            this.labelSerialNumberValue.Text = "  1022-456-1189";
            this.labelSerialNumberValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProductCode
            // 
            this.labelProductCode.AutoSize = true;
            this.labelProductCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProductCode.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductCode.Location = new System.Drawing.Point(0, 112);
            this.labelProductCode.Margin = new System.Windows.Forms.Padding(0);
            this.labelProductCode.Name = "labelProductCode";
            this.labelProductCode.Size = new System.Drawing.Size(158, 28);
            this.labelProductCode.TabIndex = 9;
            this.labelProductCode.Text = "Product Code";
            this.labelProductCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelProductCodeValue
            // 
            this.labelProductCodeValue.AutoSize = true;
            this.labelProductCodeValue.BackColor = System.Drawing.Color.White;
            this.labelProductCodeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductCodeValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProductCodeValue.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductCodeValue.Location = new System.Drawing.Point(158, 112);
            this.labelProductCodeValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProductCodeValue.Name = "labelProductCodeValue";
            this.labelProductCodeValue.Size = new System.Drawing.Size(321, 28);
            this.labelProductCodeValue.TabIndex = 10;
            this.labelProductCodeValue.Text = "{6C6D7807-B72E-4460-9D5C-1A911D1299FB}";
            this.labelProductCodeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxProductWarning
            // 
            this.pictureBoxProductWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBoxProductWarning.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProductWarning.Image")));
            this.pictureBoxProductWarning.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProductWarning.InitialImage")));
            this.pictureBoxProductWarning.Location = new System.Drawing.Point(170, 467);
            this.pictureBoxProductWarning.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxProductWarning.Name = "pictureBoxProductWarning";
            this.pictureBoxProductWarning.Size = new System.Drawing.Size(802, 119);
            this.pictureBoxProductWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProductWarning.TabIndex = 5;
            this.pictureBoxProductWarning.TabStop = false;
            // 
            // pictureBoxAJPEngLogo
            // 
            this.pictureBoxAJPEngLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxAJPEngLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAJPEngLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAJPEngLogo.Image")));
            this.pictureBoxAJPEngLogo.Location = new System.Drawing.Point(945, 51);
            this.pictureBoxAJPEngLogo.Name = "pictureBoxAJPEngLogo";
            this.pictureBoxAJPEngLogo.Size = new System.Drawing.Size(125, 58);
            this.pictureBoxAJPEngLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAJPEngLogo.TabIndex = 6;
            this.pictureBoxAJPEngLogo.TabStop = false;
            this.pictureBoxAJPEngLogo.Click += new System.EventHandler(this.pictureBoxAJPEngLogo_Click);
            // 
            // buttonUserLicenseAgreement
            // 
            this.buttonUserLicenseAgreement.BackColor = System.Drawing.Color.White;
            this.buttonUserLicenseAgreement.BackgroundImage = global::HenStudio.Properties.Resources.AJP_User_License_Agreement___600x600;
            this.buttonUserLicenseAgreement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUserLicenseAgreement.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonUserLicenseAgreement.FlatAppearance.BorderSize = 2;
            this.buttonUserLicenseAgreement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonUserLicenseAgreement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonUserLicenseAgreement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserLicenseAgreement.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserLicenseAgreement.ImageIndex = 0;
            this.buttonUserLicenseAgreement.Location = new System.Drawing.Point(573, 51);
            this.buttonUserLicenseAgreement.Name = "buttonUserLicenseAgreement";
            this.buttonUserLicenseAgreement.Size = new System.Drawing.Size(179, 124);
            this.buttonUserLicenseAgreement.TabIndex = 7;
            this.buttonUserLicenseAgreement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUserLicenseAgreement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUserLicenseAgreement.UseVisualStyleBackColor = false;
            this.buttonUserLicenseAgreement.Click += new System.EventHandler(this.buttonUserLicenseAgreement_Click);
            // 
            // labelUserLicenseAgreement
            // 
            this.labelUserLicenseAgreement.AutoSize = true;
            this.labelUserLicenseAgreement.BackColor = System.Drawing.Color.Honeydew;
            this.labelUserLicenseAgreement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUserLicenseAgreement.Font = new System.Drawing.Font("Segoe UI Variable Display", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserLicenseAgreement.Location = new System.Drawing.Point(573, 180);
            this.labelUserLicenseAgreement.Name = "labelUserLicenseAgreement";
            this.labelUserLicenseAgreement.Size = new System.Drawing.Size(179, 20);
            this.labelUserLicenseAgreement.TabIndex = 8;
            this.labelUserLicenseAgreement.Text = "User License Agreement";
            this.labelUserLicenseAgreement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAboutPinch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1108, 621);
            this.Controls.Add(this.labelUserLicenseAgreement);
            this.Controls.Add(this.buttonUserLicenseAgreement);
            this.Controls.Add(this.pictureBoxAJPEngLogo);
            this.Controls.Add(this.pictureBoxProductWarning);
            this.Controls.Add(this.tableLayoutPanelProduct);
            this.Controls.Add(this.tableLayoutPanelSupplier);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1124, 660);
            this.MinimumSize = new System.Drawing.Size(1124, 660);
            this.Name = "FormAboutPinch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Pinch";
            this.tableLayoutPanelSupplier.ResumeLayout(false);
            this.tableLayoutPanelSupplier.PerformLayout();
            this.tableLayoutPanelProduct.ResumeLayout(false);
            this.tableLayoutPanelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAJPEngLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSupplier;
        private System.Windows.Forms.Label labelSuplierName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProduct;
        private System.Windows.Forms.Label labelProductFullName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelSupplierNameValue;
        private System.Windows.Forms.Label labelProductFullNameValue;
        private System.Windows.Forms.Label labelProductNameValue;
        private System.Windows.Forms.Label labelProductVersion;
        private System.Windows.Forms.Label labelProductVersionValue;
        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.Label labelSerialNumberValue;
        private System.Windows.Forms.Label labelProductCode;
        private System.Windows.Forms.Label labelProductCodeValue;
        private System.Windows.Forms.PictureBox pictureBoxProductWarning;
        private System.Windows.Forms.PictureBox pictureBoxAJPEngLogo;
        private System.Windows.Forms.Button buttonUserLicenseAgreement;
        private System.Windows.Forms.Label labelUserLicenseAgreement;
    }
}