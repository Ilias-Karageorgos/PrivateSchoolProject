using System;

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


    }

}
