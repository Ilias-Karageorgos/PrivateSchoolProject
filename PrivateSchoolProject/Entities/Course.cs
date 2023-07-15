using System;
using System.Collections.Generic;

namespace PrivateSchoolProject
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }        
        public CourseType Type { get; set; }

        //Navigation Properties
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();

        //Methods, Behaviour
        public void PrintCourses()
        {
            Console.WriteLine($"|{Id,-5}|{Title,-15}|{Stream,-15}|{Type,-15}|{StartDate.ToShortDateString(),-15}|{EndDate.ToShortDateString(),-10}|");
        }
        public void PrintCourseTypes()
        {
            Console.WriteLine($"|{Title,-15}|{Type,-10}|");
        }
        public void PrintTitle()
        {
            Console.WriteLine($"|{Title,-10}|\n");
        }
    }

}
