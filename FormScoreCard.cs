using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            //-----------------------------
            //--- DataGridViewScoreCard ---
            //-----------------------------
            dataGridViewScoreCard.Rows.Add("01", Properties.Resources.Valid_32x32, "Author");
            dataGridViewScoreCard.Rows.Add("02", Properties.Resources.Valid_32x32, "Supplier Name");
            dataGridViewScoreCard.Rows.Add("03", Properties.Resources.Valid_32x32, "Supplier URL");
            dataGridViewScoreCard.Rows.Add("04", Properties.Resources.Valid_32x32, "Customer Name");
            dataGridViewScoreCard.Rows.Add("05", Properties.Resources.Valid_32x32, "Customer Email");
            dataGridViewScoreCard.Rows.Add("06", Properties.Resources.Valid_32x32, "Product Name");
            dataGridViewScoreCard.Rows.Add("07", Properties.Resources.Valid_32x32, "Product Version");
            dataGridViewScoreCard.Rows.Add("08", Properties.Resources.Valid_32x32, "Product Serial Number");
            dataGridViewScoreCard.Rows.Add("09", Properties.Resources.Valid_32x32, "Product Code");
            dataGridViewScoreCard.Rows.Add("10", Properties.Resources.Valid_32x32, "License Type");
            dataGridViewScoreCard.Rows.Add("11", Properties.Resources.Valid_32x32, "Corporation");
            dataGridViewScoreCard.Rows.Add("12", Properties.Resources.Valid_32x32, "Division");
            dataGridViewScoreCard.Rows.Add("13", Properties.Resources.Valid_32x32, "Group");
            dataGridViewScoreCard.Rows.Add("14", Properties.Resources.Valid_32x32, "User Name");
            dataGridViewScoreCard.Rows.Add("15", Properties.Resources.Valid_32x32, "Domain");
            dataGridViewScoreCard.Rows.Add("16", Properties.Resources.Valid_32x32, "Full Name");
            dataGridViewScoreCard.Rows.Add("17", Properties.Resources.Valid_32x32, "Device Name");
            dataGridViewScoreCard.Rows.Add("18", Properties.Resources.Valid_32x32, "License Duration");
            dataGridViewScoreCard.Rows.Add("19", Properties.Resources.Valid_32x32, "License Start Date");
            dataGridViewScoreCard.Rows.Add("20", Properties.Resources.Valid_32x32, "License End Date");
            dataGridViewScoreCard.Rows.Add("21", Properties.Resources.Valid_32x32, "License Key");
            dataGridViewScoreCard.Rows.Add("22", Properties.Resources.Valid_32x32, "License Hash");

        }
    }
}
