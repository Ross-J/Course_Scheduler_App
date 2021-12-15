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

        private void displayCourses(List<Course> courseList, int numberOfCourses)
        {
            List<Label> listOfLabels = new List<Label>();
            List<GroupBox> listOfGroupBoxes = new List<GroupBox>();


            listOfLabels.Add(Csubj1);
            listOfLabels.Add(Cno1);
            listOfLabels.Add(Cinstr1);
            listOfLabels.Add(Cday1);
            listOfLabels.Add(Cstart1);
            listOfLabels.Add(Cend1);
            listOfLabels.Add(Cbuild1);
            listOfLabels.Add(Croom1);

            listOfGroupBoxes.Add(groupBox1);
            listOfGroupBoxes.Add(groupBox2);
            listOfGroupBoxes.Add(groupBox3);
            listOfGroupBoxes.Add(groupBox4);
            listOfGroupBoxes.Add(groupBox5);
            listOfGroupBoxes.Add(groupBox6);
            listOfGroupBoxes.Add(groupBox7);
            listOfGroupBoxes.Add(groupBox8);

            int pos = 0;
            for (int i = 0; i < numberOfCourses; i++)
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

        private void displayStudentCourses(List<Course> courseList, int numberOfCourses)
        {
            List<Label> listOfLabels = new List<Label>();
            List<GroupBox> listOfGroupBoxes = new List<GroupBox>();

            
            listOfLabels.Add(Ssubj1);
            listOfLabels.Add(Sno1);
            listOfLabels.Add(Sinstr1);
            listOfLabels.Add(Sday1);
            listOfLabels.Add(Sstart1);
            listOfLabels.Add(Send1);
            listOfLabels.Add(Sbuild1);
            listOfLabels.Add(Sroom1);
            
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
