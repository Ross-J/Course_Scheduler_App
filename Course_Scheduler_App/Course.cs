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
        private string Subject;
        public string getSubject()
        {
            return this.Subject;
        }

        public string Number { get; set; }
        public string Instructor { get; }
        public string Day { get; }
        public string StartTime { get; }
        public string EndTime { get; }
        public string Building { get; }
        public string Room { get; }

        public Course(string subject, string number, string instructor, string day, string start, string end, string building, string room)
        {
            this.Subject = subject;
            this.Number = number;
            this.Instructor = instructor;
            this.Day = day;
            this.StartTime = start;
            this.EndTime = end;
            this.Building = building;
            this.Room = room;
        }

    }
}
