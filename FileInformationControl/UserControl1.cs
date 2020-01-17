using System.Drawing;
using System.Windows.Forms;
using FileInformation;
using System;

namespace FileInformationControl
{
    public partial class DrivesControls: UserControl
    {
        string _DriveName;
     
        public DrivesControls()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            _DriveName = Drive.DefaultDrive();
            Drive drive = new Drive("E");
            txtLabelInfo.Text = drive.VolumeLabel +"("+drive.Name+")";
            txtspaceInfo.Text = "FreeSpace :"+ drive.GetFreeSpace().ToString("f2");
            labelfull.Text = "TotalSize :"+ drive.GetTotalSize().ToString("f2");
            txtprcent.Text = drive.GetPercent().ToString("f2") + "%";
            metroProgressBar1.Value = Convert.ToInt32(drive.GetPercent());
            this.pictureBox1.Image = drive.image;


        }
    }
}
