using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using NSDataModule;
using CypherLib;

namespace LnLWebEndSystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        public SqlConnection conn;
        public SqlCommand comm;
        public string constr = @"";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            int RowsEffected = DataModule.ExecuteSQL($"INSERT INTO tblClient(Name,Surname,CellNumber,EmailAddress,Password) VALUES (" +
                $"'{txtName.Text}','{txtSurname.Text}','{txtCell.Text}','{txtEmailAddress.Text}','{Cypher.Encrypt(txtPassword.Text)}')");
            if (RowsEffected >0)
            {
                string ID = DataModule.GetValue<int>(0, $"SELECT ClientID FROM tblClient WHERE (Name = '{txtName.Text}') AND (Surname = " +
                    $"'{txtSurname.Text}') AND (CellNumber = '{txtCell.Text}')").ToString();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('Successfully Registered\n Your ID is {ID}')", true);
                lblMessage.Visible = true;
                lblMessage.Text = "Your ID is "+ID;
                //Display Success message
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Registration Failed')", true);
                //Display Failure message
            }


            /*conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                comm = new SqlCommand("INSERT INTO tblAdmin (Username,Password) Values ( ' " + txtName.Text + " ' ,'" + txtSurname.Text + "')", conn);
                comm.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("Login.aspx");
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Error connecting to database');</script>");
            }
            conn.Close();*/
        }
    }
}