//Manuel A Nunes 34551875
using System;
using System.IO;
using System.Windows.Forms;
using StockDisplayAUtils;
using NSDataModule;

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
            if (!CheckFilePath() || !File.Exists(Directory.GetCurrentDirectory()+@"\Images\Default.png"))
            {
                string temp = Directory.GetCurrentDirectory()+@"\Images\Default.png";
                imgBackUp.Image.Save(temp,System.Drawing.Imaging.ImageFormat.Png);
            }
        }
        private void frmStockPurchase_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (StockDisplay x in SDArr )
            {
                x.StockImg.Image.Dispose();
                x.StockImg.Image = null;
            }
            Creator.Show();
        }

        static Cart UserCart;

        private void StockItemClick(object sender, EventArgs e)
        {
            StockDisplay ObjectSuper = (StockDisplay)((PictureBox)sender).Tag;
            UserCart.AddToCart(ObjectSuper);
            UserCart.UpdateListBox(ref lstOrder);
        }

        private StockDisplay[] SDArr;
        private void frmStockPurchase_Load(object sender, EventArgs e)
        {
            SDArr = Utils.GenerateStock(pnlStockBox,StockItemClick);
            pnlStockBox.AutoScroll = true;
            //arrSelectedFood = new List<StockDisplay>();
            if (UserCart != null)
                if (MessageBox.Show("Clear Tab?", "Clear Tab", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    UserCart = new Cart();
                else
                {
                    UserCart.UpdateListBox(ref lstOrder);
                    Utils.CompsTakeOver(SDArr,UserCart.arrItems);
                    //UserCart.LoadNewItemList(Utils.FindNewComps(SDArr,UserCart.arrItems.ToArray()));
                    UserCart.UpdateQuantityLables();
                }
            else
                UserCart = new Cart();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndex >= 0)
                UserCart.Decrease(lstOrder.SelectedIndex);
            else
                MessageBox.Show("Please sullect");
            UserCart.UpdateListBox(ref lstOrder);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndex >= 0)
                UserCart.Remove(lstOrder.SelectedIndex);
            else
                MessageBox.Show("Please sullect");
            UserCart.UpdateListBox(ref lstOrder);
        }

        
        private void btnPayCash_Click(object sender, EventArgs e)
        {
            frmPayConfirm.Creator = this;
            frmPayConfirm MakePayMent = new frmPayConfirm();
            MakePayMent.ShowDialog();
            if (frmPayConfirm.isVerified)
            {
                string[] SQLs = UserCart.CreateUpdateCashPurchaseSQL();
                int iEffected = 0;
                foreach (string x in SQLs)
                    iEffected += DataModule.ExecuteSQL(x);
                MessageBox.Show($"{iEffected} Item(s) were sold." );
                //Update Database
                Utils.MassDispose(SDArr);
                SDArr = Utils.GenerateStock(pnlStockBox, StockItemClick);
                UserCart = new Cart();
                UserCart.UpdateListBox(ref lstOrder);
                //Utils.ResetLables(SDArr);
            }
        }
    }
}
