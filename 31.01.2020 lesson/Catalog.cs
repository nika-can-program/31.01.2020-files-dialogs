using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _31._01._2020_lesson
{
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("C:\\MEmes");
            DirectoryInfo dad = new DirectoryInfo("C:\\Memes_2");
            if (!dad.Exists)
            {
                dad.Create();
            }
            DirectoryInfo papochka1 = new DirectoryInfo("C:\\Memes_2\\Chickibombony");
            if (!papochka1.Exists)
            {
                papochka1.Create();
            }

            DirectoryInfo papochka2 = new DirectoryInfo("C:\\Memes_2\\ChickiMadonny");
            if (!papochka2.Exists)
            {
                papochka2.Create();
            }

            string[] catalogs = Directory.GetDirectories("C:\\");
            foreach (string dir in catalogs)
            {
                //MessageBox.Show(dir);
            }

            File.Create("C:\\MEmes\\Dolli.pptx");

        }
    }
}
