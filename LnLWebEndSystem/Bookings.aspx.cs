//E Coetzee - 34374469
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using NSDataModule;

namespace LnLWebEndSystem
{
    public partial class Bookings : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] LocationIDS = DataModule.GetValues(0,$"SELECT LocationID FROM tblLocation");
                Session["LocationIDS"] = LocationIDS;
                string[] EventTypes = DataModule.GetValues(0, $"SELECT EventType FROM tblEventType");
                Session["EventType"] = EventTypes;
            }
        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            string[] LocationID = (string[])Session["LocationIDS"];
            string[] EventTypes = (string[])Session["EventType"];
            string sql = $"INSERT INTO tblBooking (Da" +
                $"teOfBooking,TimeOfBooking,Location,ClientID,EventType) VALUES(" +
                $"'{cldDate.SelectedDate:yyyy-MM-dd}', '{txtTime.Text}',{LocationID[locationList.SelectedIndex]}" +
                $",{txtID.Text},{EventTypes[eventList.SelectedIndex]})";
            int sucessful = DataModule.ExecuteSQL(sql);
            //Clipboard.SetText(sql);
            if (sucessful == 1)
            {
                lblMessage.Text = "Booking added successfully!";
                lblMessage.Visible = true;
                //MessageBox.Show("Booking added sucessfully");
            }
            else
            {
                lblMessage.Text = "Booking failed!";
                lblMessage.Visible = true;
                //MessageBox.Show("Error was encountered");
            }
        }
    }
}