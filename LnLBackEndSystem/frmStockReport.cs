//Carla Pretorius 36184950
using System;
using System.Windows.Forms;
using NSDataModule;

namespace LnLBackEndSystem
{
    public partial class frmStockReport : Form
    {
        const string SELECT = "SELECT * FROM tblStock";
        public string WHERE = "",ORDERBY = "";

        public static Form Creator;
        public frmStockReport()
        {
            InitializeComponent();
        }

        public string BuildSQL()
        {
            string Temp = SELECT;
            if (WHERE.Length > 0)
                Temp += $" {WHERE} ";
            if (ORDERBY.Length > 0)
                Temp += $" {ORDERBY} ";
            return Temp;
        }

        private void frmStockReport_Load(object sender, EventArgs e)
        {
            rbASC.Checked = true;
            DataModule.LoadTable(ref dgvStockReport, BuildSQL());
            lblDate.Text = DateTime.Now.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearOrderBy();
        }

        public void clearOrderBy()
        {
            rbCostPrice.Checked = false;
            rbCountInBar.Checked = false;
            rbDateAquired.Checked = false;
            rbProfitMargin.Checked = false;
            rbStockName.Checked = false;
            rbASC.Checked = true;
            rbDesc.Checked = false;
            ORDERBY = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtCountInBar.Clear();
            txtCountINWareHouse.Clear();
            if (txtSearch.Text == "")
            {
                errorProviderSearch.SetError(this.txtSearch, "No text is entered.");
                txtSearch.Focus();
            }
            else
            {
                string where = txtSearch.Text;
                if (int.TryParse(txtSearch.Text, out int iSearch))
                {
                    WHERE = $"WHERE (stockID = {where})" +
                    $" OR (CostPrice = {where})" +
                    $" OR (ProfitMargin = {where} )";
                }
                else
                {
                    WHERE = $"WHERE (stockName LIKE '%{where}%')" +
                        $" OR (DateAcquired LIKE '%{where}%') ";
                }
            }
            DataModule.LoadTable(ref dgvStockReport, BuildSQL());
        }
        
        private void txtCountInBar_TextChanged(object sender, EventArgs e)
        {
            if (txtCountInBar.Text != "")
            {
                try
                {
                    int iCountInBar = int.Parse(txtCountInBar.Text);
                    WHERE = $"WHERE CountInBar < {iCountInBar}";
                    DataModule.LoadTable(ref dgvStockReport, BuildSQL());
                }
                catch
                {
                    errorProviderCountInBar.SetError(txtCountInBar, "Value must be an integer.");
                }
            }
        }

        private void txtCountINWareHouse_TextChanged(object sender, EventArgs e)
        {
            if (txtCountINWareHouse.Text != "")
            {
                try
                {
                    int iCountInWarehouse = int.Parse(txtCountINWareHouse.Text);
                    WHERE =  $"WHERE CountInWarehouse < {iCountInWarehouse}";
                    DataModule.LoadTable(ref dgvStockReport, BuildSQL());
                }
                catch
                {
                    errorProviderCountInWarehouse.SetError(txtCountINWareHouse, "Value must be an integer.");
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            order();
            DataModule.LoadTable(ref dgvStockReport, BuildSQL());
        }

        private void frmStockReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }

        public void clearTextBoxes()
        {
            txtSearch.Clear();
            txtCountINWareHouse.Clear();
            txtCountInBar.Clear();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void order()
        {
            string orderBy,ascDesc;
            if (rbCostPrice.Checked) orderBy = "CostPrice";
            else if (rbCountInBar.Checked) orderBy = "CountInBar";
            else if (rbDateAquired.Checked) orderBy = "DateAcquired";
            else if (rbProfitMargin.Checked) orderBy = "ProfitMargin";
            else if (rbStockName.Checked) orderBy = "StockName";
            else orderBy = "StockID";
            if (rbDesc.Checked) ascDesc = "DESC";
            else ascDesc = "ASC";
            ORDERBY = $"ORDER BY {orderBy} {ascDesc}";
        }
    }
}
