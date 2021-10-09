//Manuel A Nunes 34551875
using System;
using System.Drawing;
using System.Windows.Forms;
using NSDataModule;
using ClientAndUtils;
using CypherLib;
namespace LnLBackEndSystem
{
    public partial class frmClientRecoverPass : Form
    {
        public static Form Creator;
        public frmClientRecoverPass()
        {
            InitializeComponent();
        }
        string ID;
        private void AllEditChanged(object sender, EventArgs e)
        {
            btnUpdatePassword.Enabled = false;
            string WHERE = "";
            if (edtClientID.Text != "")
                WHERE += $" (ClientID = {edtClientID.Text}) AND ";
            if (edtName.Text != "")
                WHERE += $" (Name LIKE '%{edtName.Text}%') AND ";
            if (edtSurname.Text != "")
                WHERE += $" (Surname LIKE '%{edtSurname.Text}%') AND ";
            if (edtCellphone.Text != "")
                WHERE += $" (CellNumber LIKE '%{edtCellphone.Text}%') AND ";
            if (WHERE != "")
                WHERE = WHERE.Remove(WHERE.Length-5,5);
            string[][] Data;
            if (WHERE != "")
                Data = DataModule.GetValues($"SELECT ClientID FROM tblClient WHERE {WHERE}", new int[] { 0 });
            else
               Data = new string[0][];
            if (Data.Length == 1)
            {
                pnlIsValid.BackColor = Color.Green;
                lblIsValid.Text = "Enough Information Aquired";
                btnUpdatePassword.Enabled = true;
                ID = Data[0][0];
            }
            else if (Data.Length > 1)
            {
                pnlIsValid.BackColor = Color.FromArgb(255, 0, 0);
                lblIsValid.Text = "Not Enough information";
            } else
            {
                pnlIsValid.BackColor = Color.Yellow;
                lblIsValid.Text = "No record with that data";
            }
        }

        private void frmClientRecoverPass_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Modal && Creator.Visible)
                Creator.ShowDialog();
            else
                Creator.Show();
        }

        private void frmClientRecoverPass_Load(object sender, EventArgs e)
        {
            btnUpdatePassword.Enabled = false;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            ClientObj Temp = new ClientObj();
            Temp.LoadFromDB(ID);
            if (edtPassword.Text != "")
            {
                Temp.Password =  Cypher.Encrypt( edtPassword.Text);
                if (Temp.UpdateSelf())
                    MessageBox.Show("Recovered Password");
            }
            else
                MessageBox.Show("Enter new Password");
        }
    }
}
