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
        public string[] LocationID;
        public string[] EventTypes;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO tblEvent (DateOfBooking,TimeOfBooking,LocationID,ClientID,EventType) VALUES(" +
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
                lblMessage.Text = "Booking added successfully!";
                lblMessage.Visible = true;
                //MessageBox.Show("Error was encountered");
            }
        }
    }
}