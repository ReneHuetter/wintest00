using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPool
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
           this.Volumen();
        }

        private void Volumen() 
        {
            var radius = (float)txtRadius.Value;
            var hoehe = (float)txtHoehe.Value;
            double pi = Math.PI;
            
            var volumen = radius * radius * pi * hoehe;

            txtVolumen.Text = $"{ volumen:N2}";
        }
    }
}
