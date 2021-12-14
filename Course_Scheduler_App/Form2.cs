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
    public partial class Form2 : Form
    {
        List<Object> listOfCoursesToDisplay = Form1.listOfAllCourses;
        int numberOfCoursesToDisplay = Form1.numberOfCourses;
        object course1 = Form1.course;



        public Form2()
        {
            InitializeComponent();
            //richTextBox1.Text = Form1.fileContent;
        }

        private void displayCourses()
        {
            object course1 = listOfCoursesToDisplay[0];
            object course2 = listOfCoursesToDisplay[1];
            object course3 = listOfCoursesToDisplay[2];
            object course4 = listOfCoursesToDisplay[3];
            object course5 = listOfCoursesToDisplay[4];
            object course6 = listOfCoursesToDisplay[5];
            object course7 = listOfCoursesToDisplay[6];
            object course8 = listOfCoursesToDisplay[7];

            string s = course1.getSubject();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new Form1();
            m.Show();
            this.Hide();
        }

    }
}
