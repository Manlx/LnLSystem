using System;
using System.Windows.Forms;
using Serializing;
//Manuel A Nunes 34551875 - 2021-09-02
namespace LnLBackEndSystem
{
    public partial class frmConsoleSettings : Form
    {
        public static Form Creator;
        public frmConsoleSettings()
        {
            InitializeComponent();
            ReadBinFile();
            //Addes ToolTips On Create
            ttHints.SetToolTip(chkClearOnLoad, "If the window is open and closed and open again will it remember the data previously entered");
            ttHints.SetToolTip(btnApply, "Applies changes to storage");
            ttHints.SetToolTip(chkClearSQLAfterExecution, "After SQL is executed it will clear.");
            ttHints.SetToolTip(chkClearAfterSuccessOnly, "Only clear input area after SQL executed successfully");
            btnApply.BackColor = System.Drawing.Color.FromArgb(23,23,23);
        }
        public static string SettingsPath = "Settings.bin";
        public void ReadBinFile()
        {//Function To read Bin File and update components
            object temp;
            if (!Serializer.DeserializeFromBin(SettingsPath, out temp))
                return;
            Compdata CompTemp = (Compdata)temp;
            CompTemp.LoadToComps(ref chkClearOnLoad, ref chkClearSQLAfterExecution, ref chkClearAfterSuccessOnly);
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            Compdata Settings = new Compdata(chkClearOnLoad,chkClearSQLAfterExecution,chkClearAfterSuccessOnly);
            MessageBox.Show($"{( (Serializer.SerializeToBin(Settings, SettingsPath))?"Saved Succesfully":"Error was encountered" )  }");
        }

        private void frmConsoleSettings_FormClosing(object sender, FormClosingEventArgs e)
        {//Stops back from from dissapearing
            Creator.Focus();
        }
    }

    [Serializable]
    public class Compdata //Class that is used to store and save settings
    {
        public bool COL,CAE,COS;
        public Compdata()
        {
            this.CAE = false;
            this.COL = false;
            this.COS = false;
        }
        public Compdata(bool COL,bool CAE,bool COS)
        {
            this.COL = COL;
            this.COS = COS;
            this.CAE = CAE;
        }
        public Compdata(CheckBox COL,CheckBox CAE,CheckBox COS)
        {
            this.COL = COL.Checked;
            this.CAE = CAE.Checked;
            this.COS = COS.Checked;
        }
        public void LoadToComps(ref CheckBox COL,ref  CheckBox CAE,ref CheckBox COS)
        {
            COL.Checked = this.COL;
            CAE.Checked = this.CAE;
            COS.Checked = this.COS;
        }
    }
}
