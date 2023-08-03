using PrivateSchoolProject.Views.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolProject.Controllers
{
    internal class StudentsController
    {
        MyDataBase db = new MyDataBase();

        public void GetStudents()
        {
            ViewStudent.Students(db.Students, $"{"",35}All Students\n");
        }
        public void GetFilteredStudentsByFirstOrLastName()
        {
            ViewStudent.FilteredStudentsByFirstOrLastName(db.Students, $"{"",5}Filtered Students by Firstname or Lastname\n");
        }
        public void GetStudentsWithTwoOrMoreCourses()
        {
            ViewStudent.StudentsWithTwoOrMoreCourses(db.Students, $"{"",15}All Students with more than 1 Course\n");
        }
        public void GetStudentsCount()
        {
            ViewStudent.StudentsCount(db.Students, $"{"",25}Students Count\n");
        }
        public void GetAssignmentsPerStudent()
        {
            ViewStudent.AssignmentsPerStudent(db.Students, $"{"",15}All Assignments per Student\n");
        }
    }
}
