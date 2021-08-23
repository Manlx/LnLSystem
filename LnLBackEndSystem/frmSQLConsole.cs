using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datamodule;

namespace LnLBackEndSystem
{
    public partial class frmSQLConsole : Form
    {
        public static Form frmOwner;
        public frmSQLConsole()
        {
            InitializeComponent();
        }

        private void frmSQLConsole_Load(object sender, EventArgs e)
        {
            redSqlOut.ReadOnly = true;
            redSqlOut.Clear();
            if (DataModule.OpenConnection())
                redSqlOut.Text += "Connection to DB successfull";
            else
                redSqlOut.Text += "Connection failed please try again later.";
        }
        private void ExecuteAndReturn(string SQL)
        {
            try
            {
            }
            catch (Exception e)
            {
                redSqlOut.Text += e.ToString()+"\n";
            }
        }
        private void btnGOSQL_Click(object sender, EventArgs e)
        {
            string temp = edtSqlInput.Text.Substring(0,10).ToUpper() ;
            if (temp.IndexOf("SELECT") >=0 || temp.IndexOf("SELECT") >= 0)
                redSqlOut.Text += $"{DataModule.ExecuteSQL(edtSqlInput.Text)} Where effected";
            
        }

        private void frmSQLConsole_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmOwner.Show();
        }
    }
}
