using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;    // WindowsIdentity
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinch
{
    public partial class FormScoreCard : Form
    {
        public FormScoreCard()
        {
            InitializeComponent();
        }

        private void FormScoreCard_Load(object sender, EventArgs e)
        {
            string strUsername = Environment.UserName;
            string strFullname = WindowsIdentity.GetCurrent().Name;
            string strDomain = strFullname.Split('\\')[0];
            string strDeviceName = Environment.MachineName;
            //--------------------------------------
            //--- DataGridViewScoreCard Controls ---
            //--------------------------------------
            dataGridViewScoreCard.Rows.Add("01", Properties.Resources.Valid_32x32, "Author", "AuthorValue");
            dataGridViewScoreCard.Rows.Add("02", Properties.Resources.Valid_32x32, "Supplier Name", "SupplierNameValue");
            dataGridViewScoreCard.Rows.Add("03", Properties.Resources.Valid_32x32, "Supplier URL", "SupplierURLValue");
            dataGridViewScoreCard.Rows.Add("04", Properties.Resources.Valid_32x32, "Customer Name", "CustomerNameValue");
            dataGridViewScoreCard.Rows.Add("05", Properties.Resources.Valid_32x32, "Customer Email", "CustomerEmailValue");
            dataGridViewScoreCard.Rows.Add("06", Properties.Resources.Valid_32x32, "Product Name","ProductNameValue");
            dataGridViewScoreCard.Rows.Add("07", Properties.Resources.Valid_32x32, "Product Version", "ProductVersionValue");
            dataGridViewScoreCard.Rows.Add("08", Properties.Resources.Valid_32x32, "Product Serial Number", "ProductSerialNumberValue");
            dataGridViewScoreCard.Rows.Add("09", Properties.Resources.Valid_32x32, "Product Code", "{3D9721BA-003E-4711-B7AF-B579645F0AC9}");
            dataGridViewScoreCard.Rows.Add("10", Properties.Resources.Valid_32x32, "License Type", "LicenseTypeValue");
            dataGridViewScoreCard.Rows.Add("11", Properties.Resources.Valid_32x32, "Corporation", "CorporationValue");
            dataGridViewScoreCard.Rows.Add("12", Properties.Resources.Valid_32x32, "Division", "DivisionValue");
            dataGridViewScoreCard.Rows.Add("13", Properties.Resources.Valid_32x32, "Group", "GroupValue");
            dataGridViewScoreCard.Rows.Add("14", Properties.Resources.Valid_32x32, "User Name", "UserNameValue");
            dataGridViewScoreCard.Rows.Add("15", Properties.Resources.Valid_32x32, "Device Name", "DeviceNameValue");
            dataGridViewScoreCard.Rows.Add("16", Properties.Resources.Valid_32x32, "License Duration", "LicenseDurationValue");
            dataGridViewScoreCard.Rows.Add("17", Properties.Resources.Valid_32x32, "License Start Date", "License Start Datevalue");
            dataGridViewScoreCard.Rows.Add("18", Properties.Resources.Valid_32x32, "License End Date", "LicenseEndDateValue");
            dataGridViewScoreCard.Rows.Add("19", Properties.Resources.Valid_32x32, "License Key", "LicenseKeyValue");
            dataGridViewScoreCard.Rows.Add("20", Properties.Resources.Valid_32x32, "License Hash", "LicenseHashValue");

        }
    }
}
