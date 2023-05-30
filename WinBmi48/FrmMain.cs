using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBmi48
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void bntBerechnen_Click(object sender, EventArgs e)
        {
            BmiBerechnen();
        }

        private void BmiBerechnen()
        {
            decimal cm;
            decimal kg;
            decimal bmi;

            bool isOkay = decimal.TryParse(txtGroesseCm.Text, out cm);
            bool isFin = decimal.TryParse(txtGewichtKg.Text, out kg);

            if (isOkay == isFin)
            {
                decimal meter = cm / 100;
                decimal meter2 = meter * meter;
                bmi = kg / meter2;

                txtBmiErgebniss.Text = $"{bmi:N0}";
            }
            else
            {
                txtGewichtKg.Clear();
                txtGroesseCm.Clear();
                MessageBox.Show("Bitte nur Zahlen eingeben", "FEHLER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }
    }
}
