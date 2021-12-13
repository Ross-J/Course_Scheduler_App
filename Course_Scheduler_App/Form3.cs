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
        List<Object> listOfCoursesToDisplay = Form1.listOfAllCourses;
        List<Object> listOfStudentCourses = new List<Object>();

        public Form3()
        {
            InitializeComponent();
        }

        private void displayCourses()
        {
            var course = listOfCoursesToDisplay[0];
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
    }
}
