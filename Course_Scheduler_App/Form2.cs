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
            
            
            
            
            // for (int i = 0; i < numberOfCoursesToDisplay; i++) 
             
                //if (listOfCoursesToDisplay != null)
                
                    
                    
                    //foreach (Course kv in listOfCoursesToDisplay)
                    
                       // var groupbox = new GroupBox();
                        
                        /*var label = new Label();
                        label.Text = kv.Subject;
                        this.Controls.Add(label);
                        label.Location = new System.Drawing.Point(200 * (i + 1), 15 * (i + 1));
                        label.Size = new System.Drawing.Size(41, 13);

                        var label2 = new Label();
                        label2.Text = kv.Number;
                        this.Controls.Add(label2);
                        label2.Location = new System.Drawing.Point(300 * (i + 1), 15 * (i + 1));
                        label2.Size = new System.Drawing.Size(41, 13);

                        var label3 = new Label();
                        label3.Text = kv.Instructor;
                        this.Controls.Add(label3);
                        label3.Location = new System.Drawing.Point(400 * (i + 1), 15 * (i + 1));
                        label3.Size = new System.Drawing.Size(41, 13);

                        var label4 = new Label();
                        label4.Text = kv.Days;
                        this.Controls.Add(label4);
                        label4.Location = new System.Drawing.Point(500 * (i + 1), 15 * (i + 1));
                        label4.Size = new System.Drawing.Size(41, 13);

                        var label5 = new Label();
                        label5.Text = kv.StartTime;
                        this.Controls.Add(label5);
                        label5.Location = new System.Drawing.Point(600 * (i + 1), 15 * (i + 1));
                        label5.Size = new System.Drawing.Size(41, 13);

                        var label6 = new Label();
                        label6.Text = kv.EndTime;
                        this.Controls.Add(label6);
                        label6.Location = new System.Drawing.Point(700 * (i + 1), 15 * (i + 1));
                        label6.Size = new System.Drawing.Size(41, 13);

                        var label7 = new Label();
                        label7.Text = kv.Building;
                        this.Controls.Add(label7);
                        label7.Location = new System.Drawing.Point(800 * (i + 1), 15 * (i + 1));
                        label7.Size = new System.Drawing.Size(41, 13);

                        var label8 = new Label();
                        label8.Text = kv.Room;
                        this.Controls.Add(label8);
                        label8.Location = new System.Drawing.Point(900 * (i + 1), 15 * (i + 1));
                        label8.Size = new System.Drawing.Size(41, 13);
                        */

                    
                
            
        
            
                
            
           
            
            /* Course course1 = listOfCoursesToDisplay[0];
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



            /*.subj1.Text = subject;
            no1.Text = number;
            instr1.Text = instructor;
            day1.Text = days;
            start1.Text = startTime;
            end1.Text = endTime;
            build1.Text = building;
            room1.Text = room;*/
        

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
            this.Controls.Add(Parent);
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
            //displayCourses(listOfCoursesWithInstructor, numberOfInstructorCourses);
        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {
           

  }

  private void Createlabel(Label test)
  {
     
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }   
    }
}
