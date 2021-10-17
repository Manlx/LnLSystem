//Manuel A Nunes 34551875
using System;
using System.Linq;
using System.Windows.Forms;

using LocationObjUtils;
namespace LnLBackEndSystem
{
    public partial class frmLocationAdd : Form
    {
        public static Form Creator;
        public frmLocationAdd()
        {
            InitializeComponent();
        }

        private static string BoolToBit(bool Value)
        {
            return (Value) ? "1" : "0";
        }
        private void frmLocationAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
        private void FixChks()
        {
            foreach (CheckBox Temp in panel1.Controls.OfType<CheckBox>())
            {
                string strTemp = Temp.Text;
                for (int x = strTemp.Length; x < 21; x++)
                    strTemp += " ";
                Temp.Text = strTemp;
            }
        }
        private void frmLocationAdd_Load(object sender, EventArgs e)
        {
            FixChks();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isNoneChecked = true ;
            foreach (CheckBox X in panel1.Controls.OfType<CheckBox>())
                if (isNoneChecked = X.Checked)
                    break;
            if (String.IsNullOrEmpty(EdtDescription.Text))
            {
                MessageBox.Show("Please enter a description");
                EdtDescription.Focus();
                return;
            }
            if (!isNoneChecked)
                if (MessageBox.Show("No properties are selected are you sure?", "Continue?", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
            LocationObj Temp = new LocationObj() { Description = EdtDescription.Text,
                HasBarAccess = BoolToBit(chkHasBarAccess.Checked),
                HasKitchenAccess = BoolToBit(chkHasKitchenAcces.Checked),
                HasLakeAccess = BoolToBit(chkHasLakeAccess.Checked),
                HasMusicSetup = BoolToBit(chkHasMusicAccess.Checked),
                HasStage = BoolToBit(chkHasStage.Checked),
                HasSwimmingPool = BoolToBit(chkSwimmingPool.Checked),
                IsOutdoors = BoolToBit(chkIsOutdoors.Checked)};
            if (Temp.InsertSelf())
                MessageBox.Show("Registered Successfully");
            else
                MessageBox.Show("An Issues was encountered");
        }
    }
}
