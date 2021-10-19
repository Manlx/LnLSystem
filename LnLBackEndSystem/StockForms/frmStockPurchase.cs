//Manuel A Nunes 34551875
using System;
using System.IO;
using System.Windows.Forms;
using StockDisplayAUtils;
using NSDataModule;
using TabObjAndUtil;
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
                MessageBox.Show("Please Select");
            UserCart.UpdateListBox(ref lstOrder);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndex >= 0)
                UserCart.Remove(lstOrder.SelectedIndex);
            else
                MessageBox.Show("Please Select");
            UserCart.UpdateListBox(ref lstOrder);
        }

        
        private void btnPayCash_Click(object sender, EventArgs e)
        {
            frmStaffLogin.Creator = this;
            frmStaffLogin MakePayMent = new frmStaffLogin();
            MakePayMent.ShowDialog();
            if (MessageBox.Show($"Current Selected Value is: {UserCart.CalcCartCost().ToString("C")}") != DialogResult.Yes)
                return;
            if (frmStaffLogin.isValid)
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

        private void btnAddToTab_Click(object sender, EventArgs e)
        {
            frmClientLogin.Creator = this;
            frmClientLogin frmClient = new frmClientLogin();
            frmClient.ShowDialog();
            if (!frmClientLogin.LastClient.HasTab)
            {
                if (frmClientLogin.LastClient.DoesExist())
                    MessageBox.Show("This Client does not have a tab.");
                if (MessageBox.Show("Register for tab", "Register", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    btnRegisterTab_Click(btnRegisterTab, new EventArgs());
                else
                    return;
            }
            TabObj ClientTab = new TabObj();
            if (!ClientTab.LoadFromDB(frmClientLogin.LastClient.ClientID))
            {
                MessageBox.Show("An Error Was encountered #000-000-004");
                return;
            }

            if (ClientTab.Balance + UserCart.CalculateCartCost() > ClientTab.CutOffValue)
            {
                MessageBox.Show("Sorry this tab will exceed its limit please pay tab or pay cash");
                return;
            }
            //Update Stock Table
            string[] SQLs = UserCart.CreateUpdateCashPurchaseSQL();
            int iEffected = 0;
            foreach (string x in SQLs)
                iEffected += DataModule.ExecuteSQL(x);

            MessageBox.Show($"{UserCart.UpdateCreditSale(ClientTab.TabID)} Item(s) were sold."); ;

            //ReloadPage
            Utils.MassDispose(SDArr);
            SDArr = Utils.GenerateStock(pnlStockBox, StockItemClick);
            UserCart = new Cart();
            UserCart.UpdateListBox(ref lstOrder);
        }

        private void btnPayOffTab_Click(object sender, EventArgs e)
        {
            frmTabPayment.Creator = this;
            frmTabPayment TabPay = new frmTabPayment();
            TabPay.ShowDialog();
        }

        private void btnRegisterTab_Click(object sender, EventArgs e)
        {
            frmClientLogin.Creator = this;
            frmClientLogin ClientLog = new frmClientLogin();
            ClientLog.ShowDialog();
            if (frmClientLogin.CorrectUser)
            {
                if (DataModule.ExecuteSQL($"INSERT INTO tblTab (ClientID,Balance,CutOffValue) Values ({frmClientLogin.LastClient.ClientID},0,1000.00)") > 0)
                    MessageBox.Show("Tab Linked");
                else
                    MessageBox.Show("Error encounted 000-000-005");
            }
        }
        private frmHelp HelpForm = new frmHelp();
        private void btnMoreHelp_Click(object sender, EventArgs e)
        {
            frmHelp.Creator = this;
            HelpForm = new frmHelp();
            HelpForm.Show();
        }

        private void btnAddToTab_MouseEnter(object sender, EventArgs e)
        {
            HelpForm.LoadText($"Addes Currently Selected Items to Selected Tab");
        }

        private void btnPayCash_MouseEnter(object sender, EventArgs e)
        {
            HelpForm.LoadText($"Pays Selected items with cash");
        }

        private void btnRegisterTab_MouseEnter(object sender, EventArgs e)
        {
            HelpForm.LoadText($"Allows the cashier to register a client with a tab");
        }

        private void btnPayOffTab_MouseEnter(object sender, EventArgs e)
        {
            HelpForm.LoadText($"Allows clients to settle their the Tabs");
        }

        private void btnRemoveItem_MouseEnter(object sender, EventArgs e)
        {
            HelpForm.LoadText($"Remove selected item form list");
        }

        private void btnDecrease_MouseEnter(object sender, EventArgs e)
        {
            HelpForm.LoadText($"Decrease the selected item's count and if it is zero removes the item");
        }

        private void lstOrder_MouseEnter(object sender, EventArgs e)
        {
            HelpForm.LoadText($"List of selected items to buy from the bar");
        }

        private void pnlStockBox_MouseEnter(object sender, EventArgs e)
        {
            HelpForm.LoadText($"Shows available stock to purchase");
        }
    }
}
