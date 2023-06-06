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

namespace WinFile
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnFilletoList_Click(object sender, EventArgs e)
        {
            ListFiles();
        }

        private void ListFiles()
        {

            folderBrowserDialog1.Description = "Wählen sie aus";
            folderBrowserDialog1.ShowNewFolderButton = false;

            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var folder = folderBrowserDialog1.SelectedPath;
                var allFiles = Directory.GetFiles(folder);
                foreach (var file in allFiles)
                {
                    lbFiles.Items.Add(file);
                }
            }
        }
    }
}
