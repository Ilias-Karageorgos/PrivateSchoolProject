using PrivateSchoolProject.RepositoryService;
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
        StudentService studentService = new StudentService();

        public void GetStudents()
        {
            List<Student> students = new List<Student>();

            try
            {
                students = studentService.GetStudents();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            
            ViewStudent.Students(students, $"{"",35}All Students\n");
        }
        public void GetFilteredStudentsByFirstOrLastName()
        {
            List<Student> students = new List<Student>();

            try
            {
                students = studentService.GetStudents();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            ViewStudent.FilteredStudentsByFirstOrLastName(students, $"{"",5}Filtered Students by Firstname or Lastname\n");
        }
        public void GetStudentsWithTwoOrMoreCourses()
        {
            List<Student> students = new List<Student>();

            try
            {
                students = studentService.GetStudents();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            ViewStudent.StudentsWithTwoOrMoreCourses(students, $"{"",15}All Students with more than 1 Course\n");
        }
        public void GetStudentsCount()
        {
            List<Student> students = new List<Student>();

            try
            {
                students = studentService.GetStudents();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            ViewStudent.StudentsCount(students, $"{"",25}Students Count\n");
        }
        public void GetAssignmentsPerStudent()
        {
            List<Student> students = new List<Student>();

            try
            {
                students = studentService.GetStudents();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            ViewStudent.AssignmentsPerStudent(students, $"{"",15}All Assignments per Student\n");
        }
    }
}
