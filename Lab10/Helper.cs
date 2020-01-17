using System;
using System.IO;
using System.Windows.Forms;

namespace Lab10
{
    public enum Move
    {
        SourceDestaintion,
        DestaintionSource,
    }
    static class Helper
    {

        public static void GetDrives(ListBox box)
        {
            box.Items.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo item in drives)
            {
                box.Items.Add(new FileInformation(item.Name, item.Name, TypeOfFile.Drive));
            }



        }
        public static void GetDirectoirs(string dirName, ListBox box)
        {


            if (Directory.Exists(dirName))
            {
                box.Items.Clear();
                box.Items.Add(new FileInformation("", "/", TypeOfFile.Pc));

              
               var i =  Path.GetDirectoryName(dirName);
                if (i != null)
                {
                    box.Items.Add(new FileInformation(i, ".", TypeOfFile.Directory));
                }
                box.Items.Add(new FileInformation(Path.GetFullPath(dirName), "this", TypeOfFile.Directory));



                box.Items.Add(new FileInformation(Path.GetPathRoot(dirName), "..", TypeOfFile.Directory));
                DirectoryInfo info = new DirectoryInfo(dirName);

                foreach (var item in info.GetDirectories())
                {
                    FileInformation file = new FileInformation(item.FullName, item.Name, TypeOfFile.Directory);
                    box.Items.Add(file);
                }
                foreach (var item in info.GetFiles())
                {
                    FileInformation file = new FileInformation(item.FullName, item.Name, TypeOfFile.File);
                    box.Items.Add(file);
                }
            }






        }
        public static void MoveDirectoryForward(TextBox txt1, TextBox txt2 , ListBox box1,ListBox box2)
        {
            string path1 = Path.GetFullPath(txt1.Text);
            string path2 = Path.GetFullPath(txt2.Text);
            if (File.Exists(path1))
            {
                FileInfo  info = new FileInfo(txt1.Text);
                File.Move(path1, Path.Combine(path2, info.Name));
                box1.Items.Remove(box1.SelectedItem);
                GetDirectoirs(txt1.Text, box1);
                GetDirectoirs(txt2.Text, box2);

                
            }
            else if (Directory.Exists(path2)){
                DirectoryInfo info = new DirectoryInfo(txt1.Text);
                info.MoveTo(Path.Combine(txt2.Text,info.Name));
                GetDirectoirs(txt1.Text, box1);
                GetDirectoirs(txt2.Text, box2);
            }


        }
        public static void Delete(string dirname,ListBox box)
        {
            if (File.Exists(dirname))
            {
               DialogResult result = MessageBox.Show($"Are you sure  delete file : {dirname}","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    File.Delete(dirname);
                    MessageBox.Show("Delete File successfully","deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
               
            }
            else if (Directory.Exists(dirname))
            {
                DialogResult result = MessageBox.Show($"Are you sure  delete folder : {dirname}", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Directory.Delete(dirname,true);
                    MessageBox.Show("Delete Directory successfully", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            GetDirectoirs(Path.GetDirectoryName(dirname), box);




        }
        public static void Copy(TextBox txt1, TextBox txt2,ListBox box1, ListBox box2)
        {
            string path1 = Path.GetFullPath(txt1.Text);
            string path2 = Path.GetFullPath(txt2.Text);
            if (File.Exists(path1))
            {
                FileInfo info = new FileInfo(txt1.Text);
                File.Copy(path1, Path.Combine(path2, info.Name));
                box1.Items.Remove(box1.SelectedItem);
                GetDirectoirs(txt1.Text, box1);
                GetDirectoirs(txt2.Text, box2);


            }
            else if (Directory.Exists(path2))
            {
                DirectoryInfo info = new DirectoryInfo(txt1.Text);
                var x = txt1.Text;
                DirectoryInfo info2;
                string checker = Path.Combine(txt2.Text, info.Name);
                if (!Directory.Exists(checker))
                {
                    info2 = Directory.CreateDirectory(checker);
                }
                else
                {
                    throw new Exception("the Directory Founded");
                }
                DirectoryCopy(txt1.Text, info2.FullName, true);
                GetDirectoirs(txt1.Text, box1);
                GetDirectoirs(txt2.Text, box2);
            }
        }


        /// <summary>
        /// From Microsoft MSDN
        /// </summary>
        /// <param name="sourceDirName"> this is the source File</param>
        /// <param name="destDirName"> and this is the destation </param>
        /// <param name="copySubDirs">if you want to copy sub directories </param>
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
     
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
           
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

          
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
    }



}


