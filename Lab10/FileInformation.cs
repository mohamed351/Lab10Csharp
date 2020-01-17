using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
  public  enum TypeOfFile
    {
        File,
        Directory,
        Drive,
        Pc

    }
  public  class FileInformation
    {

        public FileInformation(string FullPath,string FileName,TypeOfFile typeOfFile)
        {
            this.FullPath = FullPath;
            this.FileName = FileName;
            this.TypeOfFile = typeOfFile;

        }
        public string FullPath { get; set; }
        public string FileName { get; set; }
        public TypeOfFile TypeOfFile { get; set; }
       
        public override string ToString()
        {
            return FileName;

        }
    }
}
