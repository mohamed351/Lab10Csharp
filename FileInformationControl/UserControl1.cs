using System.Drawing;
using System.Windows.Forms;
using FileInformation;
using System;

namespace FileInformationControl
{
    public delegate void DriveNameHandler(Drive DriveName);
    public partial class DrivesControls: UserControl
    {
        public event DriveNameHandler OnDriveNameChange;
        string _DriveName;
        Drive drive;

        public string DriveName { get => _DriveName; set{

                this._DriveName = value;
                InitalData(value);
            } }

        public DrivesControls()
        {
            InitializeComponent();
            InitalData();


        }

        private void InitalData()
        {
            this.BackColor = Color.Transparent;
            _DriveName = Drive.DefaultDrive();
            drive = new Drive(_DriveName);
            txtLabelInfo.Text = drive.VolumeLabel + "(" + drive.Name + ")";
            txtspaceInfo.Text = "FreeSpace :" + drive.GetFreeSpace().ToString("f2");
            labelfull.Text = "TotalSize :" + drive.GetTotalSize().ToString("f2");
            txtprcent.Text = drive.GetPercent().ToString("f2") + "%";
            metroProgressBar1.Value = Convert.ToInt32(drive.GetPercent());
            this.pictureBox1.Image = drive.image;
            if(OnDriveNameChange != null)
            {
                OnDriveNameChange(drive);
            }
            
        }

        private void InitalData(string DriveName)
        {
           
            this.BackColor = Color.Transparent;
            _DriveName = DriveName;
             drive = new Drive(_DriveName);
            txtLabelInfo.Text = drive.VolumeLabel + "(" + drive.Name + ")";
            txtspaceInfo.Text = "FreeSpace :" + drive.GetFreeSpace().ToString("f2");
            labelfull.Text = "TotalSize :" + drive.GetTotalSize().ToString("f2");
            txtprcent.Text = drive.GetPercent().ToString("f2") + "%";
            if (drive.IsReady)
                metroProgressBar1.Value = Convert.ToInt32(drive.GetPercent());
            else
                metroProgressBar1.Value = 0;
            this.pictureBox1.Image = drive.image;
            if (OnDriveNameChange != null)
            {
                OnDriveNameChange(drive);
            }

        }

        private void propertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertyFrm frm = new PropertyFrm(this.drive);
            frm.ShowDialog();
        }
    }
}
