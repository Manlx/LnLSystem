using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serializing;
namespace LnLBackEndSystem
{

    public partial class frmConsoleSettings : Form
    {
        public frmConsoleSettings()
        {
            InitializeComponent();
        }
        public static string SettingsPath = "Settings.bin";
        private void frmConsoleSettings_Load(object sender, EventArgs e)
        {
            ttHints.SetToolTip(chkClearOnLoad, "If the window is open and closed and open again will it remember the data previously entered");
            ttHints.SetToolTip(btnApply, "Applies changes to storage");
            ttHints.SetToolTip(chkClearSQLAfterExecution, "After SQL is executed it will clear.");
            ttHints.SetToolTip(chkClearAfterSuccessOnly, "Only clear input area after SQL executed successfully");
            object temp;
            if (!Serializer.DeserializeFromBin(SettingsPath, out temp))
                return;
            Compdata CompTemp = (Compdata)temp;
            CompTemp.LoadToComps(ref chkClearOnLoad,ref chkClearSQLAfterExecution, ref chkClearAfterSuccessOnly);
        }
        
        private void btnApply_Click(object sender, EventArgs e)
        {
            Compdata Settings = new Compdata(chkClearOnLoad,chkClearSQLAfterExecution,chkClearAfterSuccessOnly);
            MessageBox.Show($"{( (Serializer.SerializeToBin(Settings, SettingsPath))?"Saved Succesfully":"Error was encountered" )  }");
        }
    }


    [Serializable]
    public class Compdata
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
