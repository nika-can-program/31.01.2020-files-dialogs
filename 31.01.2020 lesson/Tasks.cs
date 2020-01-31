﻿using System;
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
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                StreamWriter stream;
                FileInfo file = new FileInfo(saveFileDialog1.FileName);

                stream = file.AppendText();


                stream.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                StreamReader stream = new StreamReader(openFileDialog1.FileName);

                string str = "";

                while (!stream.EndOfStream)
                {
                    str += stream.ReadLine();
                }

                foreach(char word in str)
                {
                    if(word=='р')
                    { 
                        MessageBox.Show("ОБнаРуЖеН" +word);
                    }
                }


                stream.Close();
            }
        }
    }
}
