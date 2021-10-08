//Manuel A Nunes 34551875 - 2021-09-02
using System;
using System.Drawing;
using System.Windows.Forms;
using NSDataModule;

using CypherLib;

namespace LnLBackEndSystem
{
    public partial class frmSQLConsole : Form
    {
        public static Form frmOwner;
        readonly static frmConsoleSettings frmConsoleSetting = new frmConsoleSettings();
        public frmSQLConsole()
        {
            InitializeComponent();
            frmTableSelect.Creator = this;
            frmConsoleSettings.Creator = this;
        }
        //Can be changed in settings
        public static bool ClearOnLoad = true;
        
        private void frmSQLConsole_Load(object sender, EventArgs e)
        {

            redSqlOut.ReadOnly = true;
            //Sets Button Color
            btnClear.BackColor = Color.FromArgb(12,12,12);
            btnGOSQL.BackColor = btnClear.BackColor;
            if (frmConsoleSetting.chkClearOnLoad.Checked)
                redSqlOut.Clear();
            //Test SQL Connection
            if (btnGOSQL.Enabled = DataModule.OpenConnection())
                redSqlOut.Text += "Connection to DB successfull\n";
            else
                redSqlOut.Text += "Connection failed please try again later.\n";
        }
        //Executes Code on run
        private void btnGOSQL_Click(object sender, EventArgs e)
        {
            if (edtSqlInput.Text.Length == 0|| edtSqlInput.Text.Length <= 10)
            {
                redSqlOut.Text += "Invalid SQL code\n";
                return;
            }
            string temp = edtSqlInput.Text.Substring(0, 10).ToUpper();
            if (temp.IndexOf("SELECT") >= 0 || temp.IndexOf("SHOW") >= 0) //Checks if Table should be returned
            {
                string[] TableTemps = DataModule.GenerateTable(edtSqlInput.Text);
                redSqlOut.Text += "\n";
                foreach (var x in TableTemps)
                    redSqlOut.Text += $"{x}\n";
                if (frmConsoleSetting.chkClearAfterSuccessOnly.Checked)
                    edtSqlInput.Clear();
            }
            else
            {//Executes if code should not return a table
                if (temp.IndexOf("DELETE") >= 0)
                    if (MessageBox.Show("Are you sure you want to execute delete code", "Delete Command", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                int x = DataModule.ExecuteSQL(edtSqlInput.Text);
                redSqlOut.Text += $"{x} Lines where effected";
                if (frmConsoleSetting.chkClearAfterSuccessOnly.Checked)
                    edtSqlInput.Clear();
            }
            if (frmConsoleSetting.chkClearSQLAfterExecution.Checked)
                edtSqlInput.Clear();
        }

        private void frmSQLConsole_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmOwner.Show();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {//Clears Console Output Screen
            redSqlOut.Clear();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            
            frmConsoleSetting.ShowDialog();
        }

        private void btnSelectAllShort_Click(object sender, EventArgs e)
        {
            edtSqlInput.Text = "SELECT * FROM ";
            frmTableSelect SelectTab = new frmTableSelect();
            SelectTab.ShowDialog();
        }

        private void btnShowTableInfo_Click(object sender, EventArgs e)
        {
            edtSqlInput.Text = "SHOW COLUMNS FROM ";
            frmTableSelect SelectTab = new frmTableSelect();
            SelectTab.ShowDialog();
        }
    }
}
