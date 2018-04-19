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

namespace PictureLens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //根据文件夹选择
        private void SelectPath_Click(object sender, EventArgs e)
        {
            string imgtype = "*.BMP|*.JPG|*.GIF|*.PNG";
            string[] ImageType = imgtype.Split('|');
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            string filePath = path.SelectedPath;

            for (int i = 0; i < ImageType.Length; i++)
            {
                string[] dirs = Directory.GetFiles(filePath, ImageType[i]);
                int j = 0;
                foreach (string dir in dirs)
                {
                    object item = new object();
                    checkedListBox1.Items.Add(dir, true);
                    j++;
                }
            }
            //var files = Directory.GetFiles(filePath, "*.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imgtype = "*.BMP|*.JPG|*.GIF|*.PNG";
            string[] ImageType = imgtype.Split('|');

            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            file.Filter = "图片文件 | *.jpg; *.png; *.gif";
            string filePath = file.FileName;
            checkedListBox1.Items.Add(filePath, true);
            resizePic.resize();
        }
        
    }
}
