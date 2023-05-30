using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wintest00
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn_say_Hello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo du schöne Welt", "C# Übung", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
