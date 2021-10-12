//Manuel A Nunes 34551875
using System;
using System.Linq;
using System.Windows.Forms;
using SupplierAndUtils;
namespace LnLBackEndSystem
{
    public partial class frmSupplierRegister : Form
    {
        public static Form Creator;
        public frmSupplierRegister()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach(TextBox x in this.Controls.OfType<TextBox>())
            {
                if (String.IsNullOrEmpty(x.Text))
                {
                    MessageBox.Show("This field is required");
                    x.Focus();
                    return;
                }
            }
            SupplierObj Value = new SupplierObj();
            Value.Name = EdtName.Text;
            Value.Balance = "0";
            Value.PhoneNumber = EdtPhoneNumber.Text;
            Value.Website = EdtWebsite.Text;
            Value.WarehouseContactName = EdtWarehouseContactname.Text;
            Value.InsertSelf();
        }
    }
}
