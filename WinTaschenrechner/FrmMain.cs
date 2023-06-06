using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTaschenrechner
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.addieren();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            this.subtract();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            this.multiply();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            this.divide();
        }

        private void addieren()
        {
            txtErgebniss.Text = $"{txtNumberOne.Value + txtNumberTwo.Value}";
        }

        private void subtract()
        {
            txtErgebniss.Text = $"{txtNumberOne.Value - txtNumberTwo.Value}";
        }
        private void multiply()
        {
            txtErgebniss.Text = $"{txtNumberOne.Value * txtNumberTwo.Value}";
        }
        private void divide()
        {
            if (txtNumberTwo.Value == 0 || txtNumberOne.Value == 0)
                return;
            txtErgebniss.Text = $"{txtNumberOne.Value / txtNumberTwo.Value:N2}";
        }
    }
}
