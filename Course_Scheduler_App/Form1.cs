using System;
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
        public static List<Course> listOfAllCourses = new List<Course>();
        public static int numberOfCourses = 0;
        

        public Form1()
        {
            InitializeComponent();
            //parseData("CSC,370,Locklair,MWF,1:10,2:25,Stuenkel,118B");
        }
        bool Restrictor = true;
        public bool ButtonRestrictor()
        {
            
            if (fileContent == "")
            {
                Restrictor = true;
            }
            else
            {
                Restrictor = false;
               
              
            }

        }
        
        private void parseData(string s)
        {
            string subject = "";
            string number = "";
            string instructor = "";
            string days = "";
            string startTime = "";
            string endTime = "";
            string building = "";
            string room = "";

            int pos = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == ' ')
                {
                    continue;
                }
                else if(s[i] == ',')
                {
                    pos++;
                }
                else if(pos == 0)
                {
                    subject = subject + s[i];
                }
                else if (pos == 1)
                {
                    number = number + s[i];
                }
                else if (pos == 2)
                {
                    instructor = instructor + s[i];
                }
                else if (pos == 3)
                {
                    days = days + s[i];
                }
                else if (pos == 4)
                {
                    startTime = startTime + s[i];
                }
                else if (pos == 5)
                {
                    endTime = endTime + s[i];
                }
                else if (pos == 6)
                {
                    building = building + s[i];
                }
                else
                {
                    room = room + s[i];
                }
            }

            var course = new Course(subject, number, instructor, days, startTime, endTime, building, room);
            listOfAllCourses.Add(course);
            numberOfCourses++;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\users/Ross Jacobson/Downloads";
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
                        
                       
                        while(!reader.EndOfStream)
                        {
         
                            fileContent = reader.ReadLine();
                            //displays contents of the file

                            parseData(fileContent);
                        }
                    }
                }
            }

            bool conflicts = checkForInitialConflicts();
            if (conflicts == true)
            {
                conflictMessage.Visible = true;
                conflictMessage.ForeColor = System.Drawing.Color.Red;
                conflictMessage.Text = "Conflicts exist in the data file.";
            }
            else
            {
                conflictMessage.Visible = true;
                conflictMessage.ForeColor = System.Drawing.Color.Green;
                conflictMessage.Text = "No conflicts exist in the data file.";
            }
        }

        private bool checkForInitialConflicts()
        {
            bool isConflicts = false;

            foreach (Course c in listOfAllCourses)
            {
                foreach (Course c2 in listOfAllCourses)
                {
                    if (c2 != c)
                    {
                        if (c2.Building == c.Building && c2.Days == c.Days)
                        {
                            if (c2.StartTime == c.StartTime)
                            {
                                isConflicts = true;
                            }
                        }
                    }
                } 
            }

            return isConflicts;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Restrictor == true)
            {
                conflictMessage.Visible = true;
                conflictMessage.ForeColor = System.Drawing.Color.Red;
                conflictMessage.Text = "Insert a File!";
            }
            else {
                var m = new Form3();
                m.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Restrictor == true)
            {
                conflictMessage.Visible = true;
                conflictMessage.ForeColor = System.Drawing.Color.Red;
                conflictMessage.Text = "Insert a File!";
            }
            else
            {

                var m = new Form2();
            m.Show();
            this.Hide();
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
