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

namespace WinPwdMagr48V1
{
    public partial class FrmMain : Form
    {
        private const string FileName = @"C:\tmp\PwdMagrAccounts.json";

        public FrmMain()
        {
            InitializeComponent();
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //bsAccounts.DataSource = new BindingList<Accounts>();
            loadeFile();
        }

        private void accountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveFile()
        {
            var lst = bsAccounts.DataSource as BindingList<Accounts>;
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(lst, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(FileName, json);
        }

        private void loadeFile() 
        {
            var json = File.ReadAllText(FileName);
            BindingList<Accounts> lst = Newtonsoft.Json.JsonConvert.DeserializeObject<BindingList<Accounts>>(json);
            bsAccounts.DataSource = lst;
        }
    }
}
