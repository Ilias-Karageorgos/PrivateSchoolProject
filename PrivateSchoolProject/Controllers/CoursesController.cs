using PrivateSchoolProject.Views.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolProject.Controllers
{
    internal class CoursesController
    {
        MyDataBase db = new MyDataBase();
        //NA VALO SE OLOUS TOUS CONTROLLERS METAVLITI GIA DB......

        public void ReadCourses()
        {
            var courses = db.Courses;

            ViewCourse.GetCourses(courses, $"{"",35}All Courses\n");
        }
        public void ReadCourseTypes() 
        {
            var courses = db.Courses;
            ViewCourse.CourseTypes(courses, $"{"",8}Course Types\n");
        }
        public void GetStudentsPerCourse()
        {
            var courses = db.Courses;
            ViewCourse.StudentsPerCourse(courses, $"{"",15}All Students per Course\n");
        }
        public void GetTrainersPerCourse()
        {
            var courses = db.Courses;
            ViewCourse.TrainersPerCourse(courses, $"{"",15}All Trainers per Course\n");
        }
        public void GetAssignmentsPerCourse()
        {
            var courses = db.Courses;
            ViewCourse.AssignmentsPerCourse(courses, $"{"",15}All Assignments per Course\n");
        }
        public void FilteredCoursesByTitle()
        {
            var courses = db.Courses;
            ViewCourse.FilteredCoursesByTitle(courses, $"{"",25}Filtered Courses by Title\n");
        }
        public void GetCoursesCount()
        {
            var courses = db.Courses;
            ViewCourse.CoursesCount(courses, $"{"",25}Courses Count\n");
        }
    }
}
