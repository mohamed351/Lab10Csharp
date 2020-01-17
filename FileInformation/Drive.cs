using System.Collections.Generic;
using System.IO;

namespace FileInformation
{
    public class Drive:Element
    {
        public Drive(string FullPath, string FileName)
            : base(FullPath, FileName, TypeOfFile.Drive)
        {

            DriveInfo drive = new DriveInfo(FullPath);
            this.IsReady = drive.IsReady;
            if (drive.IsReady)
            {
                this.FileName = drive.VolumeLabel;
                this.AvailableFreeSpace = drive.AvailableFreeSpace;
                this.DriveFormate = drive.DriveFormat;
                this.TypeOfDrive = drive.DriveType;
                this.Name = drive.Name;
                this.RootDirectory = drive.RootDirectory;
                this.TotalFreeSpace = drive.TotalFreeSpace;
                this.TotalSize = drive.TotalSize;
                this.VolumeLabel = drive.VolumeLabel;
            }
            else
            {
                this.TypeOfDrive = drive.DriveType;
                this.AvailableFreeSpace = 0;
                this.TypeOfDrive = drive.DriveType;
                this.Name = drive.Name;
                this.RootDirectory = null;
                this.TotalFreeSpace = 0;
                this.TotalSize = 0;
                this.VolumeLabel = "";
            }
           
         
            if(TypeOfDrive == DriveType.Fixed && this.VolumeLabel == "Windows")
            {
                this.image = PictureSource.Drive_OS_Windows_icon;

            }
            else if (TypeOfDrive == DriveType.Fixed)
            {
                this.image = PictureSource.Windows_HD_Drive_icon;
            }
           else if (TypeOfDrive == DriveType.Removable)
            {
                this.image = PictureSource.USB_HD_Drive_icon;
            }
            else if(TypeOfDrive == DriveType.CDRom)
            {
                this.image = PictureSource.cdrom_icon;
            }



        }
        public Drive(string DriveName)
            :this(DriveName, DriveName)
        {
           
        }
        
        public string DriveFormate { get; private set; }
        public long AvailableFreeSpace { get; private set; }
        public DriveType TypeOfDrive { get; private set; }
        public bool IsReady { get; private set; }
        public string  Name { get; private set; }
        public DirectoryInfo RootDirectory { get; private set; }
        public long TotalFreeSpace { get; private set; }
        public long TotalSize { get; private set; }
        public string VolumeLabel { get; private set; }

        public static string DefaultDrive()
        {
            return DriveInfo.GetDrives()[0].Name;
        }
       
        public float GetFreeSpace()
        {
            return ((((float)this.TotalFreeSpace / 1024f) / 1024f) / 1024f);
        }
        public float GetTotalSize()
        {
            return (((float)this.TotalSize / 1024f) / 1024f) / 1024f;
        }
        public float GetPercent()
        {
            return (100f - ((float)this.TotalFreeSpace / (float)this.TotalSize) * 100);
        }
        public  List<Direcotr> GetDirecotr()
        {
            DirectoryInfo info = new DirectoryInfo(this.FullPath);
            List<Direcotr> direcotrs = new List<Direcotr>();
            foreach (var item in info.GetDirectories())
            {
                direcotrs.Add(new Direcotr(this.FullPath, this.FileName));

            }
            return direcotrs;



        }
      
        
       



    }
   
   
}
