using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileInformation;

namespace FileInformationControl
{
    public partial class PropertyFrm : MetroFramework.Forms.MetroForm
    {
        public PropertyFrm(Drive drive) 
        {
            InitializeComponent();
            pictureBox1.Image = drive.image;
            metroTextBox1.Text = drive.VolumeLabel;
            metroTextBox2.Text = drive.DriveFormate;
            this.Activate();

           
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
