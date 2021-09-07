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
    public partial class Secretary_insert : Form
    {
        public static Form creator;

        public Secretary_insert()
        {
            InitializeComponent();
        }

        private void Secretary_insert_FormClosing(object sender, FormClosingEventArgs e)
        {
            creator.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
          //  String sql = $"INSERT INTO tblStaff ()";
           // int sucessful = DataModule.ExecuteSQL(sql);
          //  if (sucessful == 1)
            //    MessageBox.Show("Added sucessfully");
           // else
               // MessageBox.Show("Error was encountered");

        }
    }
}
