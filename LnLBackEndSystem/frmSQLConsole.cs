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
/*
 SELECT tblStaff.Name, tblStaff.Surname, tblBank.BankName from tblStaff
LEFT JOIN tblStaffBank on tblStaff.StaffID = tblStaffBank.StaffID
LEFT JOIN tblBank on tblStaffBank.BankID = tblBank.BankID
 */
namespace LnLBackEndSystem
{
    public partial class frmSQLConsole : Form
    {
        public static Form frmOwner;
        public frmSQLConsole()
        {
            InitializeComponent();
        }
        //Can be changed in settings
        public static bool ClearOnLoad = true;
        private void frmSQLConsole_Load(object sender, EventArgs e)
        {

            redSqlOut.ReadOnly = true;
            //Sets Button Color
            btnClear.BackColor = Color.FromArgb(12,12,12);
            btnGOSQL.BackColor = btnClear.BackColor;
            if (ClearOnLoad)
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
            string temp = edtSqlInput.Text.Substring(0,10).ToUpper() ;
            if (temp.IndexOf("SELECT") >=0 || temp.IndexOf("SHOW") >= 0) //Checks if Table should be returned
            {
                string[] TableTemps = DataModule.GenerateTable(edtSqlInput.Text);
                redSqlOut.Text += "\n";
                foreach (var x in TableTemps)
                    redSqlOut.Text += $"{x}\n";
            }
            else
            {//Executes if code should not return a table
                if (temp.IndexOf("DELETE") >= 0)
                    if (MessageBox.Show("Are you sure you want to execute delete code","Delete Command",MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                int x = DataModule.ExecuteSQL(edtSqlInput.Text);
                redSqlOut.Text += $"{x} Lines where effected";
            }
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
            frmConsoleSettings frmTest = new frmConsoleSettings();
            frmTest.Show();
        }
    }
}
