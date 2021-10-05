using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LnLSupportLibraries;
using NSDataModule;

namespace LnLBackEndSystem
{
    public partial class frmStockReport : Form
    {
        public string orderBy = null;
        public string ascDesc = "ASC";
        public string SQL = "";
        public static Form Creator;
        public frmStockReport()
        {
            InitializeComponent();
        }

        

        private void frmStockReport_Load(object sender, EventArgs e)
        {
            rbASC.Checked = true;
            SQL = "SELECT * FROM tblStock";
            DataModule.LoadTable(ref dgvStockReport, SQL);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearOrderBy();
        }

        public void clearOrderBy()
        {
            orderBy = null;
            rbCostPrice.Checked = false;
            rbCountInBar.Checked = false;
            rbDateAquired.Checked = false;
            rbProfitMargin.Checked = false;
            rbStockName.Checked = false;
            rbASC.Checked = true;
            rbDesc.Checked = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                errorProviderSearch.SetError(this.txtSearch, "No text is entered.");
                txtSearch.Focus();
            }
            else
            {
                string where = txtSearch.Text;
                SQL = $"SELECT * FROM tblStock WHERE (stockID = {where})" +
                    $" OR (stockName = '{where}')" +
                    $" OR (DateAcquired = '{where}')" +
                    $" OR (CostPrice = {where})" +
                    $" OR (ProfitMargin = {where} )";
                if (orderBy != null)
                {
                    SQL += "ORDER BY " + orderBy + " " + ascDesc;
                }
            }
            Clipboard.SetText(SQL);
            DataModule.LoadTable(ref dgvStockReport, SQL);
        }

        private void txtCountInBar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int iCountInBar = int.Parse(txtCountInBar.Text);
                SQL = $"SELECT * FROM tblStock WHERE CountInBar < {iCountInBar.ToString()}";
                if (orderBy != null)
                {
                    SQL += "ORDER BY " + orderBy + " " + ascDesc;
                }
                DataModule.LoadTable(ref dgvStockReport, SQL);
            }
            catch
            {
                errorProviderCountInBar.SetError(txtCountInBar, "Value must be an integer.");
            }
        }

        private void txtCountINWareHouse_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int iCountInWarehouse = int.Parse(txtCountInBar.Text);
                SQL = $"SELECT * FROM tblStock WHERE CountInWareHouse < {iCountInWarehouse.ToString()}";
                DataModule.LoadTable(ref dgvStockReport, SQL);
                if (orderBy != null)
                {
                    SQL += "ORDER BY " + orderBy + " " + ascDesc;
                }
            }
            catch
            {
                errorProviderWarehouse.SetError(txtCountINWareHouse, "Value must be an integer.");
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            if (rbCostPrice.Checked) orderBy = "CostPrice";
            else if (rbCountInBar.Checked) orderBy = "CountInBar";
            else if (rbDateAquired.Checked) orderBy = "DateAcquired";
            else if (rbProfitMargin.Checked) orderBy = "ProfitMargin";
            else if (rbStockName.Checked) orderBy = "StockName";
            else if (rbDesc.Checked) ascDesc = "DESC";
            else if (rbASC.Checked) ascDesc = "ASC";

            if (orderBy != null)
            {
                SQL = $"SELECT * FROM tblStock ORDER BY {orderBy} {ascDesc}";
            }
            else
            {
                SQL = $"SELECT * FROM tblStock ORDER BY stockID {ascDesc}";
            }

            DataModule.LoadTable(ref dgvStockReport, SQL);
        }

        private void frmStockReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }

        private void dgvStockReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
