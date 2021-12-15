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
        int numberOfStudentCourses = 0;

        List<CheckBox> listOfCheckBoxes = new List<CheckBox>();
        


        public Form3()
        {
            InitializeComponent();
            displayCourses(listOfCoursesToDisplay, numberOfCoursesToDisplay);
            listOfCheckBoxes.Add(checkBox1);
            listOfCheckBoxes.Add(checkBox2);
            listOfCheckBoxes.Add(checkBox3);
            listOfCheckBoxes.Add(checkBox4);
            listOfCheckBoxes.Add(checkBox5);
            listOfCheckBoxes.Add(checkBox6);
            listOfCheckBoxes.Add(checkBox7);
            listOfCheckBoxes.Add(checkBox8);
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

            listOfLabels.Add(Csubj2);
            listOfLabels.Add(Cno2);
            listOfLabels.Add(Cinstr2);
            listOfLabels.Add(Cday2);
            listOfLabels.Add(Cstart2);
            listOfLabels.Add(Cend2);
            listOfLabels.Add(Cbuild2);
            listOfLabels.Add(Croom2);

            listOfLabels.Add(Csubj3);
            listOfLabels.Add(Cno3);
            listOfLabels.Add(Cinstr3);
            listOfLabels.Add(Cday3);
            listOfLabels.Add(Cstart3);
            listOfLabels.Add(Cend3);
            listOfLabels.Add(Cbuild3);
            listOfLabels.Add(Croom3);

            listOfLabels.Add(Csubj4);
            listOfLabels.Add(Cno4);
            listOfLabels.Add(Cinstr4);
            listOfLabels.Add(Cday4);
            listOfLabels.Add(Cstart4);
            listOfLabels.Add(Cend4);
            listOfLabels.Add(Cbuild4);
            listOfLabels.Add(Croom4);

            listOfLabels.Add(Csubj5);
            listOfLabels.Add(Cno5);
            listOfLabels.Add(Cinstr5);
            listOfLabels.Add(Cday5);
            listOfLabels.Add(Cstart5);
            listOfLabels.Add(Cend5);
            listOfLabels.Add(Cbuild5);
            listOfLabels.Add(Croom5);

            listOfLabels.Add(Csubj6);
            listOfLabels.Add(Cno6);
            listOfLabels.Add(Cinstr6);
            listOfLabels.Add(Cday6);
            listOfLabels.Add(Cstart6);
            listOfLabels.Add(Cend6);
            listOfLabels.Add(Cbuild6);
            listOfLabels.Add(Croom6);

            listOfLabels.Add(Csubj7);
            listOfLabels.Add(Cno7);
            listOfLabels.Add(Cinstr7);
            listOfLabels.Add(Cday7);
            listOfLabels.Add(Cstart7);
            listOfLabels.Add(Cend7);
            listOfLabels.Add(Cbuild7);
            listOfLabels.Add(Croom7);

            listOfLabels.Add(Csubj8);
            listOfLabels.Add(Cno8);
            listOfLabels.Add(Cinstr8);
            listOfLabels.Add(Cday8);
            listOfLabels.Add(Cstart8);
            listOfLabels.Add(Cend8);
            listOfLabels.Add(Cbuild8);
            listOfLabels.Add(Croom8);

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
                pos = pos + 8;
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

            listOfLabels.Add(Ssubj2);
            listOfLabels.Add(Sno2);
            listOfLabels.Add(Sinstr2);
            listOfLabels.Add(Sday2);
            listOfLabels.Add(Sstart2);
            listOfLabels.Add(Send2);
            listOfLabels.Add(Sbuild2);
            listOfLabels.Add(Sroom2);

            listOfLabels.Add(Ssubj3);
            listOfLabels.Add(Sno3);
            listOfLabels.Add(Sinstr3);
            listOfLabels.Add(Sday3);
            listOfLabels.Add(Sstart3);
            listOfLabels.Add(Send3);
            listOfLabels.Add(Sbuild3);
            listOfLabels.Add(Sroom3);

            listOfLabels.Add(Ssubj4);
            listOfLabels.Add(Sno4);
            listOfLabels.Add(Sinstr4);
            listOfLabels.Add(Sday4);
            listOfLabels.Add(Sstart4);
            listOfLabels.Add(Send4);
            listOfLabels.Add(Sbuild4);
            listOfLabels.Add(Sroom4);

            listOfLabels.Add(Ssubj5);
            listOfLabels.Add(Sno5);
            listOfLabels.Add(Sinstr5);
            listOfLabels.Add(Sday5);
            listOfLabels.Add(Sstart5);
            listOfLabels.Add(Send5);
            listOfLabels.Add(Sbuild5);
            listOfLabels.Add(Sroom5);

            listOfLabels.Add(Ssubj6);
            listOfLabels.Add(Sno6);
            listOfLabels.Add(Sinstr6);
            listOfLabels.Add(Sday6);
            listOfLabels.Add(Sstart6);
            listOfLabels.Add(Send6);
            listOfLabels.Add(Sbuild6);
            listOfLabels.Add(Sroom6);

            listOfLabels.Add(Ssubj7);
            listOfLabels.Add(Sno7);
            listOfLabels.Add(Sinstr7);
            listOfLabels.Add(Sday7);
            listOfLabels.Add(Sstart7);
            listOfLabels.Add(Send7);
            listOfLabels.Add(Sbuild7);
            listOfLabels.Add(Sroom7);

            listOfLabels.Add(Ssubj8);
            listOfLabels.Add(Sno8);
            listOfLabels.Add(Sinstr8);
            listOfLabels.Add(Sday8);
            listOfLabels.Add(Sstart8);
            listOfLabels.Add(Send8);
            listOfLabels.Add(Sbuild8);
            listOfLabels.Add(Sroom8);

            listOfGroupBoxes.Add(groupBox9);
            listOfGroupBoxes.Add(groupBox10);
            listOfGroupBoxes.Add(groupBox11);
            listOfGroupBoxes.Add(groupBox12);
            listOfGroupBoxes.Add(groupBox13);
            listOfGroupBoxes.Add(groupBox14);
            listOfGroupBoxes.Add(groupBox15);
            listOfGroupBoxes.Add(groupBox16);

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
                pos = pos + 8;
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

        private void addButton7_Click(object sender, EventArgs e)
        {

        }

        private void addButton1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Course c = listOfCoursesToDisplay[0];
            listOfStudentCourses.Add(c);
            numberOfStudentCourses++;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Course c = listOfCoursesToDisplay[1];
            listOfStudentCourses.Add(c);
            numberOfStudentCourses++;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Course c = listOfCoursesToDisplay[2];
            listOfStudentCourses.Add(c);
            numberOfStudentCourses++;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Course c = listOfCoursesToDisplay[3];
            listOfStudentCourses.Add(c);
            numberOfStudentCourses++;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Course c = listOfCoursesToDisplay[4];
            listOfStudentCourses.Add(c);
            numberOfStudentCourses++;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Course c = listOfCoursesToDisplay[5];
            listOfStudentCourses.Add(c);
            numberOfStudentCourses++;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Course c = listOfCoursesToDisplay[6];
            listOfStudentCourses.Add(c);
            numberOfStudentCourses++;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Course c = listOfCoursesToDisplay[7];
            listOfStudentCourses.Add(c);
            numberOfStudentCourses++;
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            displayStudentCourses(listOfStudentCourses, numberOfStudentCourses);
            foreach (CheckBox c in listOfCheckBoxes)
            {
                if(c.Checked == true)
                {
                    c.Visible = false;
                }
            }
        }

    }
}
