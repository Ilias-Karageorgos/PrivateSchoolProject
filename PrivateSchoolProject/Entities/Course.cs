using System;
using System.Collections.Generic;

namespace PrivateSchoolProject
{
    public class Course
    {
        public string Title { get; set; }
        public string Stream { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Id { get; set; }
        public CourseType Type { get; set; }

        //Navigation Properties
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
    }

}
