using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInformation
{
    public class Direcotr:Element
    {
        DirectoryInfo _info;
        public FileAttributes Attributes { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime CreationTimeUtc { get; set; }
        public bool Exist { get; set; }
        public string Extension { get; set; }
        public DateTime LastAccessTime { get; set; }
        public DateTime LastAccessTimeUtc { get; set; }
        public string Name { get; set; }
        public DirectoryInfo Root { get; set; }
        public Direcotr(string FullName,string FileName)
            :base(FullName,FileName,TypeOfFile.Directory)
        {
           _info = new DirectoryInfo(FullName);
            this.Attributes = _info.Attributes;
           this.CreationTime = _info.CreationTime;
            this.CreationTimeUtc = _info.CreationTimeUtc;
            this.Exist = _info.Exists;
            this.Extension= _info.Extension;
           this.Extension =  _info.FullName;
           this.LastAccessTime = _info.LastAccessTime;
           this.LastAccessTimeUtc =  _info.LastAccessTimeUtc;
            this.Name = _info.Name;
           this.Root =  _info.Root;
            this.image = PictureSource.System_folder_yellow_icon;

           

        }

        public  DirectoryInfo[]  GetSubDrivesInfo()
        {
           return   _info.GetDirectories();
        }


    }
}
