using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using NSDataModule;
using System.Web.UI.WebControls;

namespace LnLWebEndSystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie _userCookie = Request.Cookies["UserInformation"];

            if (Session["Info"] != null)
            {
                Response.Redirect("Bookings.aspx");
            }
            else
            {
                if (_userCookie != null)
                {
                    Response.Redirect("Bookings.aspx");
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string regPass = DataModule.GetValue(0, $"SELECT Password FROM tblClient WHERE ClientID = {txtID.Text}");
            if (String.IsNullOrEmpty(regPass))
            {
                //Insert Error message
                return;
            }
             string Pass = txtPass.Text;

             if (regPass == Pass)
             {
                  HttpCookie _userCookie = new HttpCookie("UserInformation");
                  Session["Info"] = txtID.Text;

                  if (chkRememberMe.Checked)
                  {
                       _userCookie["ID"] = txtID.Text;
                       _userCookie["UserPassword"] = txtPass.Text;
                       _userCookie.Expires = DateTime.Now.AddDays(1);
                  }
                  Response.Cookies.Add(_userCookie);
                  Response.Redirect("Bookings.aspx");
             }
                
        }
    }
}