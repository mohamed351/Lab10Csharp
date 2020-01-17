using FileInformation;
using FileInformationControl;
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

namespace FunyWindowsExplore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Activate();
           
        }

       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("Are you sure you want to Exit ","Info",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
              
            }
            
           
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            foreach (var item in DriveInfo.GetDrives())
            {
                DrivesControls controls = new DrivesControls()
                {
                    DriveName = item.Name
                };
                flowLayoutPanel1.Controls.Add(controls);
            }
        }
    }
}
