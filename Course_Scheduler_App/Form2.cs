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
        List<Course> listOfCoursesToDisplay = Form1.listOfAllCourses;
        int numberOfCoursesToDisplay = Form1.numberOfCourses;
      

        public Form2()
        {
            InitializeComponent();
            //richTextBox1.Text = Form1.fileContent;
            displayCourses(listOfCoursesToDisplay, numberOfCoursesToDisplay);
        }

        private void displayCourses(List<Course> courseList, int numberOfCourses)
        {
            Course course1 = listOfCoursesToDisplay[0];
            Course course2 = listOfCoursesToDisplay[1];
            Course course3 = listOfCoursesToDisplay[2];
            Course course4 = listOfCoursesToDisplay[3];
            Course course5 = listOfCoursesToDisplay[4];
            Course course6 = listOfCoursesToDisplay[5];
            Course course7 = listOfCoursesToDisplay[6];
            Course course8 = listOfCoursesToDisplay[7];

            string subject = course1.Subject;
            string number = course1.Number;
            string instructor = course1.Instructor;
            string days = course1.Days;
            string startTime = course1.StartTime;
            string endTime = course1.EndTime;
            string building = course1.Building;
            string room = course1.Room;

            subj1.Text = subject;
            no1.Text = number;
            instr1.Text = instructor;
            day1.Text = days;
            start1.Text = startTime;
            end1.Text = endTime;
            build1.Text = building;
            room1.Text = room;
        }

        private bool checkForInstructorConflicts()
        {
            bool isConflicts = false;
            return isConflicts;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new Form1();
            m.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedInstructor = comboBox1.Text;
            List<Course> listOfCoursesWithInstructor = new List<Course>();
            int numberOfInstructorCourses = 0;
            foreach (Course c in listOfCoursesToDisplay)
            {
                if (c.Instructor == selectedInstructor)
                {
                    listOfCoursesWithInstructor.Add(c);
                    numberOfInstructorCourses++;
                }
            }
            displayCourses(listOfCoursesWithInstructor, numberOfInstructorCourses);
        }
    }
}
