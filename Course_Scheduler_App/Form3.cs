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
        List<Course> listOfCoursesToDisplay = Form1.listOfAllCourses;
        int numberOfCoursesToDisplay = Form1.numberOfCourses;
        List<Course> listOfStudentCourses = new List<Course>();

        public Form3()
        {
            InitializeComponent();
        }

        private void displayCourses()
        {
            Course course1 = listOfCoursesToDisplay[0];
            Course course2 = listOfCoursesToDisplay[1];
            Course course3 = listOfCoursesToDisplay[2];
            Course course4 = listOfCoursesToDisplay[3];
            Course course5 = listOfCoursesToDisplay[4];
            //Course course6 = listOfCoursesToDisplay[5];
            //Course course7 = listOfCoursesToDisplay[6];
            //Course course8 = listOfCoursesToDisplay[7];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new Form1();
            m.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }
    }
}
