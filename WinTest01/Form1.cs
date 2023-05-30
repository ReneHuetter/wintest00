using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn_Say_Hello_Click(object sender, EventArgs e)
        {
            var text = $"Servus {txtName.Text}";
            MessageBox.Show(text, "Juhuu!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            txtName.Clear();
        }
    }
}
