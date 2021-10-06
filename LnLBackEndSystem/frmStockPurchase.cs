//Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockDisplayAUtils;

namespace LnLBackEndSystem
{
    public partial class frmStockPurchase : Form
    {
        public static Form Creator;
        public frmStockPurchase()
        {
            InitializeComponent();
            CreateDefaultImage();
        }
        public static bool CheckFilePath()
        {
            bool Test;
            if (Test = !Directory.Exists(Directory.GetCurrentDirectory() + "\\Images"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Images");
            return !Test;
        }
        public void CreateDefaultImage()
        {
            if (!CheckFilePath() || !File.Exists(@"\Images\Default.png"))
            {
                string temp = @"\Images\Default.png";
                imgBackUp.Image.Save(temp);
            }
        }
        private void frmStockPurchase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
        Cart UserCart;
        private void StockItemClick(object sender, EventArgs e)
        {
            StockDisplay ObjectSuper = (StockDisplay)((PictureBox)sender).Tag;
            UserCart.AddToCart(ObjectSuper);
            UserCart.UpdateListBox(ref lstOrder);
        }
        StockDisplay[] SDArr;
        private void frmStockPurchase_Load(object sender, EventArgs e)
        {
            SDArr = Utils.GenerateStock(pnlStockBox,StockItemClick);
            pnlStockBox.AutoScroll = true;
            //arrSelectedFood = new List<StockDisplay>();
            if (UserCart != null)
                if (MessageBox.Show("Clear Tab?", "Clear Tab", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    UserCart = new Cart();
                else
                    UserCart.UpdateListBox(ref lstOrder);
            else
                UserCart = new Cart();
        }
    }
}
