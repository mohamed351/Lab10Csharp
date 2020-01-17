using System.Windows.Forms;
using System.IO;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public ListBox ListBox1 { get { return listBox1; } }
        public ListBox ListBox2 { get { return listBox2; } }

        public TextBox TextBox1 { get { return txtBox1; } }
        public TextBox TextBox2 { get { return txtBox2; } }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Helper.GetDrives(this.listBox1);
            Helper.GetDrives(this.listBox2);
        }

        private void listBox1_DoubleClick(object sender, System.EventArgs e)
        {
            var item = (ListBox)sender;
            if (item.Name == "listBox1")
            {

                SelectionElement(item, txtBox1);
            }
            else
            {
                SelectionElement(item, txtBox2);
            }


        }

        private void SelectionElement(ListBox box, TextBox txt)
        {
            if (box.SelectedItem != null)
            {

                if (box.SelectedItem is FileInformation)
                {
                    var list = (FileInformation)box.SelectedItem;
                    if (list.TypeOfFile != TypeOfFile.Pc)
                    {
                        txt.Text = list.FullPath;
                        Helper.GetDirectoirs(txt.Text, box);
                    }
                    else
                    {
                        Helper.GetDrives(box);
                    }
                }

            }
        }




        private void listBox1_Click(object sender, System.EventArgs e)
        {
            ClickOne((ListBox)sender, txtBox1);
        }

        private void ClickOne(ListBox box, TextBox text)
        {
            if (box.SelectedItem != null)
            {
                if (box.SelectedItem is FileInformation)
                {
                    text.Text = ((FileInformation)box.SelectedItem).FullPath;
                }
                else
                {
                    text.Text = box.SelectedItem.ToString();

                }
            }
        }

        private void listBox2_Click(object sender, System.EventArgs e)
        {
            ClickOne((ListBox)sender, txtBox2);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Helper.MoveDirectoryForward(txtBox2, txtBox1, listBox2, listBox1);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Helper.MoveDirectoryForward(txtBox1, txtBox2, listBox1, listBox2);
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var item = (FileInformation)listBox1.SelectedItem;

                if (item.TypeOfFile == TypeOfFile.Directory || item.TypeOfFile == TypeOfFile.File)
                {
                    button1.Enabled = true;

                    button3.Enabled = true;
                    button4.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                    //button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                var item = (FileInformation)listBox2.SelectedItem;
                if (item.TypeOfFile == TypeOfFile.Directory || item.TypeOfFile == TypeOfFile.File)
                {
                    if (item.TypeOfFile == TypeOfFile.Directory || item.TypeOfFile == TypeOfFile.File)
                    {
                        button2.Enabled = true;
                    }
                    else
                    {
                        button2.Enabled = false;
                    }
                }
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Helper.Delete(txtBox1.Text,listBox1);
            txtBox1.Clear();

        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            Helper.Copy(txtBox1, txtBox2, listBox1, listBox2);
        }
    }
}
