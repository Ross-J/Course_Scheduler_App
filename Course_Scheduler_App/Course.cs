using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Scheduler_App
{
    public class Course
    {
        //members of the course class
        private string subject;
        private string number;
        private string instructor;
        private string days;
        private string startTime;
        private string endTime;
        private string building;
        private string room;

        public Course(string subject, string number, string instructor, string days, string start, string end, string building, string room)
        {
            this.subject = subject;
            this.number = number;
            this.instructor = instructor;
            this.days = days;
            this.startTime = start;
            this.endTime = end;
            this.building = building;
            this.room = room;
        }

        public string Subject
        {
            get { return subject; }
            //set { Subject = value; }
        }

        public string Number
        {
            get { return number; }
        }

        public string Instructor
        {
            get { return instructor; }
        }
        public string Days
        {
            get { return days; }
        }
        public string StartTime
        {
            get { return startTime; }
        }
        public string EndTime
        {
            get { return endTime; }
        }
        public string Building
        {
            get { return building; }
        }
        public string Room
        {
            get { return room; }
        }
    }
}
