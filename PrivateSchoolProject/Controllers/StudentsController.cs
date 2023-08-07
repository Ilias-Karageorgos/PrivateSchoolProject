using PrivateSchoolProject.RepositoryService;
using PrivateSchoolProject.Views.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
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

            ViewStudent.GetStudents(students, $"{"",35}All Students\n");
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

        public void StudentsOrderedBy(string prop)
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

            switch (prop)
            {
                case "LastName": ViewStudent.GetStudents(students.OrderBy(x => x.LastName).ToList(), $"{"",25}Students Ordered by Lastname\n"); break;
                case "FirstName": ViewStudent.GetStudents(students.OrderBy(x => x.FirstName).ToList(), $"{"",25}Students Ordered by FirstName\n"); break;
                case "TuitionFees": ViewStudent.GetStudents(students.OrderBy(x => x.TuitionFees).ToList(), $"{"",25}Students Ordered by Tuition Fees\n"); break;
                case "DateOfBirth": ViewStudent.GetStudents(students.OrderBy(x => x.DateOfBirth).ToList(), $"{"",25}Students Ordered by Date of Birth\n"); break;
            }
        }


        public void CreateStudentController()
        {
            Student createdStudent = ViewStudent.CreateStudent();

            studentService.CreateStudent(createdStudent);

            GetStudents();
        }
    }
}
