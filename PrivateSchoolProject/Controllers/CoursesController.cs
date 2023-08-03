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

        public void ReadCourses()
        {
            ViewCourse.GetCourses(db.Courses, $"{"",35}All Courses\n");
        }
        public void ReadCourseTypes() 
        {
            ViewCourse.CourseTypes(db.Courses, $"{"",8}Course Types\n");
        }
        public void GetStudentsPerCourse()
        {
            ViewCourse.StudentsPerCourse(db.Courses, $"{"",15}All Students per Course\n");
        }
        public void GetTrainersPerCourse()
        {
            ViewCourse.TrainersPerCourse(db.Courses, $"{"",15}All Trainers per Course\n");
        }
        public void GetAssignmentsPerCourse()
        {
            ViewCourse.AssignmentsPerCourse(db.Courses, $"{"",15}All Assignments per Course\n");
        }
        public void FilteredCoursesByTitle()
        {
            ViewCourse.FilteredCoursesByTitle(db.Courses, $"{"",25}Filtered Courses by Title\n");
        }
        public void GetCoursesCount()
        {
            ViewCourse.CoursesCount(db.Courses, $"{"",25}Courses Count\n");
        }
    }
}
