using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInformation
{
    public enum TypeOfFile
    {
        File,
        Directory,
        Drive,
        Pc

    }
    public abstract class Element
    {

        public Element(string FullPath, string FileName, TypeOfFile typeOfFile)
        {
            this.FullPath = FullPath;
            this.FileName = FileName;
            this.TypeOfFile = typeOfFile;

        }
        public Element()
            :this("","",TypeOfFile.Drive)
        {

        }
        public string FullPath { get; set; }
        public string FileName { get; set; }
        public TypeOfFile TypeOfFile { get; set; }
        public Image image { get; protected set; }

        public override string ToString()
        {
            return FileName;

        }
    }
   
}
