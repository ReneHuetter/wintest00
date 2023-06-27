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

namespace WinPwdMag48
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            bsAccounts.DataSource = new List<Account>();
        }

        private void accountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveFile()
        {
            var lst = bsAccounts.DataSource as List<Account>;
            if (lst != null)
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(lst, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(@"C:\tmp\accounts.json",json);
            }
        }
    }
}
