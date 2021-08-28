using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NSDataModule;


namespace LnLBackEndSystem
{
    public partial class frmTableSelect : Form
    {
        public frmTableSelect()
        {
            InitializeComponent();
        }
        public static frmSQLConsole Creator;
        private void frmTableSelect_Load(object sender, EventArgs e)
        {
            foreach (string x in DataModule.GetValues<string>(0, "SHOW TABLES"))
                cmbSelectTables.Items.Add(x);
        }

        private void cmbSelectTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            Creator.edtSqlInput.Text += cmbSelectTables.Text;
            this.Close();
        }
    }
}
