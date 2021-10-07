using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace LnLWebEndSystem
{
    public partial class Login : System.Web.UI.Page
    {
        public SqlConnection conn;
        public SqlCommand comm;
        public SqlDataReader Reader;
        public string constr = @"";
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie _userCookie = Request.Cookies["UserInformation"];

            if (Session["Info"] != null)
            {
                Response.Redirect("Shifts.aspx");
            }
            else
            {
                if (_userCookie != null)
                {
                    Response.Redirect("Shifts.aspx");
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();

               //string sql = "SELECT Password FROM tblAdmin WHERE Username = '" + txtUsername2.Text + "'";

                //comm = new SqlCommand(sql, conn);
                Reader = comm.ExecuteReader();

                if (Reader.Read())
                {
                    string regPass = Reader.GetValue(0).ToString();
                   /* string Pass = txtPassword.Text;

                    if (regPass == Pass)
                    {
                        HttpCookie _userCookie = new HttpCookie("UserInformation");
                        Session["Info"] = txtUsername2.Text;

                        if (chkRememberMe.Checked)
                        {
                            _userCookie["Username"] = txtUsername2.Text;
                            _userCookie["UserPassword"] = txtPassword2.Text;
                            _userCookie.Expires = DateTime.Now.AddDays(2);
                        }
                        Response.Cookies.Add(_userCookie);
                        Response.Redirect("Shifts.aspx");
                    }
                    else
                    {
                        lblError.Visible = true;
                    }*/
                }
                conn.Close();
            }
            catch (Exception error)
            {
                //lblError.Text = error.Message;
            }
        }
    }
}