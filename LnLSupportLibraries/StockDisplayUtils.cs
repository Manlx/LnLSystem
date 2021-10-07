//Manuel A Nunes 34551875
//2021-10-05
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NSDataModule;

namespace StockDisplayAUtils
{
    public class StockDisplay
    {
        public string StockID;
        public string StockName;
        private int ProfitMargin;
        public double CostPrice;
        public int CountInBar;
        public Label lblName, lblPrice, lblQuantity;
        public Panel BigParent;
        public PictureBox StockImg;
        public Control ExtParent;
        public StockDisplay(){}

        public static int BigWidth = 200,BigHeight = 320; 
        public StockDisplay(string StockID,string Name,int CostPrice,int ProfitMargin,int Quantity, Control ExtParent,string ImgPath,EventHandler OnClick)
        {
            this.StockID = StockID;
            this.StockName = Name;
            this.CostPrice = CostPrice;
            this.ProfitMargin = ProfitMargin;
            this.CountInBar = Quantity;
            this.ExtParent = ExtParent;

            BigParent = new Panel() { Width = BigWidth, Height = BigHeight, Parent = ExtParent };
            lblName = new Label() {Width = BigWidth-10,Text = this.StockName, Parent = BigParent,AutoEllipsis = true,TextAlign = ContentAlignment.MiddleCenter };
            StockImg = new PictureBox() { Parent = BigParent, Width = BigWidth - 10, Height = BigHeight - (lblName.Height * 3) - 20, Top = 5,
                Left = 5,SizeMode = PictureBoxSizeMode.StretchImage };

            StockImg.Tag = this;
            StockImg.Click += OnClick;

            StockImg.Image = Image.FromFile(ImgPath);
            lblName.Top = StockImg.Top + StockImg.Height;
            lblName.Left = 5 ;
            lblPrice = new Label() { Parent = BigParent,AutoSize = true, Text = $"{Math.Ceiling(this.CostPrice*(1+ProfitMargin/100)):C2}",
                Top = lblName.Top + lblName.Height + 5};
            lblPrice.Left = (BigWidth - lblPrice.Width) / 2;
            lblQuantity = new Label() { Parent = BigParent, AutoSize = true,Text = CountInBar.ToString(),Top = lblPrice.Top + lblPrice.Height + 5 };
            lblQuantity.Left = (BigWidth - lblQuantity.Width) / 2;
        }
        public void SoftCopy(StockDisplay Other)
        {
            this.CostPrice = Other.CostPrice;
            this.CountInBar = Other.CountInBar;
            this.ProfitMargin = Other.ProfitMargin;
            this.StockID = Other.StockID;
            this.StockName = Other.StockName;
        }
        public double CalcCost()
        {
            return this.CostPrice * (1 + this.ProfitMargin / 100.0);
        }
        override public bool Equals(object other)
        {
            return this.StockID.Equals(((StockDisplay)other).StockID);
        }
        override public int GetHashCode()
        {
            return 1;
        }
        public void ResetQauntityLabel()
        {
            this.lblQuantity.Text = $"{this.CountInBar}";
        }
        public void Dispose()
        {
            this.lblName.Dispose();
            this.lblPrice.Dispose();
            this.lblQuantity.Dispose();
            this.StockImg.Dispose();
            this.BigParent.Dispose();
        }
    }
    public class Cart
    {
        public List<StockDisplay> arrItems;
        public List<int> arrCount;
        public Cart()
        {
            arrItems = new List<StockDisplay>();
            arrCount = new List<int>();
        }
        public void AddToCart(StockDisplay Value)
        {
            bool Looking = true;
            int x = 0;
            while (Looking && x < arrItems.Count)
            {
                Looking = !Value.Equals(arrItems[x]);
                if (Looking)
                    x++;
            }
            if (!Looking)
            {
                if (arrCount[x] < arrItems[x].CountInBar)
                {
                    arrCount[x]++;
                    arrItems[x].lblQuantity.Text = $"{arrItems[x].CountInBar} ({arrCount[x]})";
                }
            }
            else
            {
                arrCount.Add(1);
                arrItems.Add(Value);
                arrItems[arrItems.Count-1].lblQuantity.Text = $"{arrItems[x].CountInBar} ({arrCount[x]})";
            }    

        }
        public string[] CreateUpdateCashPurchaseSQL()
        {
            List<string> SQLs = new List<string>();
            for (int x = 0; x < arrItems.Count;x++)
                SQLs.Add($"UPDATE tblStock SET CountInBar = {arrItems[x].CountInBar - arrCount[x]} WHERE StockID = {arrItems[x].StockID};");
            return SQLs.ToArray();
        }
        public void UpdateQuantityLables()
        {
            for (int x = 0; x < arrItems.Count;x++)
                arrItems[x].lblQuantity.Text = $"{arrItems[x].CountInBar} ({arrCount[x]})";
        }
        public void LoadNewItemList(StockDisplay[] Value)
        {
            this.arrItems = new List<StockDisplay>();
            foreach (StockDisplay x in Value)
                this.arrItems.Add(x);
        }
        public void Decrease(int Index)
        {
            arrCount[Index]--;
            if (arrCount[Index] <= 0)
            {
                arrCount.RemoveAt(Index);
                arrItems.RemoveAt(Index);
            }
            else
                arrItems[Index].lblQuantity.Text = $"{arrItems[Index].CountInBar} ({arrCount[Index]})";
        }
        public void Remove(int Index)
        {
            arrItems[Index].lblQuantity.Text = $"{arrItems[Index].CountInBar}";
            arrItems.RemoveAt(Index);
            arrCount.RemoveAt(Index);
        }
        public void Remove(StockDisplay Value)
        {
            bool Looking = true;
            int x = 0;
            while (Looking && x < arrItems.Count)
            {
                Looking = !Value.Equals(arrItems[x]);
                if (Looking)
                    x++;
            }
            if (!Looking)
            {
                arrItems[x].lblQuantity.Text = $"{arrItems[x].CountInBar}";
                arrCount.RemoveAt(x);
                arrItems.RemoveAt(x);
            }
        }
        public void Decrease(StockDisplay Value)
        {
            bool Looking = true;
            int x = 0;
            while (Looking && x < arrItems.Count)
            {
                Looking = !Value.Equals(arrItems[x]);
                if (Looking)
                    x++;
            }
            if (!Looking)
            {
                arrCount[x]--;
                if (arrCount[x] <= 0)
                {
                    arrCount.RemoveAt(x);
                    arrItems.RemoveAt(x);
                }    
                else
                    arrItems[x].lblQuantity.Text = $"{arrItems[x].CountInBar} ({arrCount[x]})";
            }
        }
       
        public void UpdateListBox(ref ListBox lst)
        {
            lst.Items.Clear();
            for (int x = 0; x < arrItems.Count;x++)
            {
                lst.Items.Add($"{arrItems[x].StockName,-60} x {arrCount[x],-7} = {(arrItems[x].CalcCost() * arrCount[x]):C2,-10}");
            }
                
        }
    }
    public static class Utils
    {
        static public void MassDispose(StockDisplay[] Value)
        {
            foreach (StockDisplay x in Value)
                x.Dispose();
        }

        static public void ResetLables(StockDisplay[] Values)
        {
            foreach (StockDisplay x in Values)
                x.ResetQauntityLabel();
        }
        private static string CheckImage(string Path )
        {
            Path = Directory.GetCurrentDirectory()+@"\Images\" + Path;
            if (File.Exists(Path))
                return Path;
            else
                return Directory.GetCurrentDirectory() + @"\Images\Default.png";

        }
        public static StockDisplay[] FindNewComps(StockDisplay[] All,StockDisplay[] Sample)
        {
            StockDisplay[] arrOut = new StockDisplay[Sample.Length];
            int InUse = 0;
            foreach(StockDisplay Item in Sample)
            {
                int x = 0;
                bool Looking = true;
                while (Looking)
                {
                    Looking = Item != All[x];
                    if (Looking)
                        x++;
                }
                arrOut[InUse] = All[x];
            }
            return All;
        }
        public static StockDisplay[] CompsTakeOver(StockDisplay[] All, List<StockDisplay> Sample)
        {
            for (int SampI = 0; SampI < Sample.Count;SampI++ )
            {
                int x = 0;
                bool Looking = true;
                while (Looking)
                {
                    Looking = !Sample[SampI].Equals(All[x]);
                    if (Looking)
                        x++;
                }
                Sample[SampI] = All[x];
            }
            return All;
        }
        public static StockDisplay[] GenerateStock(Control BigParent,EventHandler OnClick)
        {
            int Offset = (BigParent.Width - StockDisplay.BigWidth*(BigParent.Width/(StockDisplay.BigWidth+5)))/2,Col = 0,Row =0,ColMax = BigParent.Width/(StockDisplay.BigWidth+5);
            string[][] Table = DataModule.GetValues("SELECT StockID,StockName,CostPrice,ProfitMargin,CountInBar FROM tblStock WHERE CountInBar > 0",new int[] { 0,1,2,3,4});
            StockDisplay[] SDarr = new StockDisplay[Table.Length];
            int x = 0;
            foreach (string[] strRow in Table)
            {
                SDarr[x] = new StockDisplay(strRow[0], strRow[1], int.Parse(strRow[2]), int.Parse(strRow[3]), int.Parse(strRow[4]), BigParent, CheckImage(strRow[0]+".png"), OnClick);
                SDarr[x].BigParent.Top = 5 * Row + 5 + Row * StockDisplay.BigHeight;
                SDarr[x].BigParent.Left = 5 * Col + 5 + StockDisplay.BigWidth * Col;
                Col++;
                if (Col >= ColMax)
                {
                    Col = 0;
                    Row++;
                }
                    
                x++;
            }
                
            return SDarr;
        }
    }
}
