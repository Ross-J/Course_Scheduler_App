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

namespace Course_Scheduler_App
{
    public partial class Form1 : Form
    {
        public static string fileContent = "";

        public Form1()
        {
            InitializeComponent();
        }

        /*
        private void parseData(string s)
        {
            string currString = "";
            int pos = 0;
            for(int i = 0; i < s.length(); i++)
            {
                
            }
        }
        */


        private void button1_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file 
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream 
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        //displays contents of the file
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var m = new Form3();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var m = new Form2();
            m.Show();
            this.Hide();
        }
    }
}
