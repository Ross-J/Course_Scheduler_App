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
            displayStudentCourses(listOfCoursesToDisplay, 1);
        }

        private void displayCourses()
        {
            Course course1 = listOfCoursesToDisplay[0];
            Course course2 = listOfCoursesToDisplay[1];
            Course course3 = listOfCoursesToDisplay[2];
            Course course4 = listOfCoursesToDisplay[3];
            Course course5 = listOfCoursesToDisplay[4];
            Course course6 = listOfCoursesToDisplay[5];
            Course course7 = listOfCoursesToDisplay[6];
            Course course8 = listOfCoursesToDisplay[7];


           

            
        }

        private void displayStudentCourses(List<Course> courseList, int numberOfCourses)
        {
            List<Label> listOfLabels = new List<Label>();
            List<GroupBox> listOfGroupBoxes = new List<GroupBox>();

            listOfLabels.Add(label1);
            listOfLabels.Add(no1);
            listOfLabels.Add(instr1);
            listOfLabels.Add(day1);
            listOfLabels.Add(start1);
            listOfLabels.Add(end1);
            listOfLabels.Add(build1);
            listOfLabels.Add(room1);

            listOfGroupBoxes.Add(groupBox1);
            listOfGroupBoxes.Add(groupBox2);
            listOfGroupBoxes.Add(groupBox3);
            listOfGroupBoxes.Add(groupBox4);
            listOfGroupBoxes.Add(groupBox5);
            listOfGroupBoxes.Add(groupBox6);
            listOfGroupBoxes.Add(groupBox7);
            listOfGroupBoxes.Add(groupBox8);

            int pos = 0;
            for(int i = 0; i < numberOfCourses; i++)
            {
                Course c = courseList[i];
                GroupBox g = listOfGroupBoxes[i];
                listOfLabels[pos].Text = c.Subject;
                listOfLabels[pos + 1].Text = c.Number;
                listOfLabels[pos + 2].Text = c.Instructor;
                listOfLabels[pos + 3].Text = c.Days;
                listOfLabels[pos + 4].Text = c.StartTime;
                listOfLabels[pos + 5].Text = c.EndTime;
                listOfLabels[pos + 6].Text = c.Building;
                listOfLabels[pos + 7].Text = c.Room;

                g.Visible = true;
                //pos = pos + 8;
            }
            
            

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

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
