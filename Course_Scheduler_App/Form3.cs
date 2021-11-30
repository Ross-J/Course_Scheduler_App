using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Scheduler_App
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //richTextBox1.Text = Form1.fileContent;
            label2.Text = "CSC";
            label3.Text = "370";
            label4.Text = "Dr. Locklair";
            label5.Text = "T;Th";
            label6.Text = "13:10";
            label7.Text = "14:25";
            label8.Text = "Stuenkel";
            label9.Text = "118B";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new Form1();
            m.Show();
            this.Hide();
        }
    }
}
