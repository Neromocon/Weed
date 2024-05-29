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

namespace DirectoryEx2
{
    public partial class DirectoryEx2 : Form
    {
        public DirectoryEx2()
        {
            InitializeComponent();
        }

        private void BtnDirList_Click(object sender, EventArgs e)
        {
            lbDir.Items.Clear();
            string[] apaths = Directory.GetDirectories(Environment.SystemDirectory);
            // Environment.SystemDirectory == System32
            foreach (string dirPath in apaths)
            {
                lbDir.Items.Add(dirPath);
            }
        }

        private void BtnFileList_Cilck(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
            string[] afiles = Directory.GetFiles(Environment.SystemDirectory);

            foreach(string file in afiles)
            {
                lbFiles.Items.Add(file);
            }
        }
    }
}
