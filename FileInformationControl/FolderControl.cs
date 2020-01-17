using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileInformation;
using System.IO;

namespace FileInformationControl
{
    public partial class FolderControl : UserControl
    {
        Direcotr _Directory;
        public string DirectoryName { get { return _Directory.Name; }
            set { _Directory.Name = value; InitialData(value); } }
        public string FullPath { get { return _Directory.FullPath; } set { _Directory.FullPath = FullPath; } }
        public FolderControl()
        {
            InitializeComponent();
            InitialData();
        }

        private void InitialData()
        {
            _Directory = new Direcotr();
            pictureBox1.Image = _Directory.image;
            DirectoryName = _Directory.Name;
            label1.Text = _Directory.Name;
        }

        private void InitialData(string DirectoryName)
        {
            _Directory = new Direcotr(DirectoryName,Path.GetDirectoryName(DirectoryName));
            pictureBox1.Image = _Directory.image;
            DirectoryName = _Directory.Name;
            label1.Text = _Directory.Name;
        }
    }
}
