using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolProject.Views.Students
{
    internal class ViewStudent
    {        
        public static void Students(List<Student> students, string message)
        {
            View.PrintColoredMessage(message);
            Console.WriteLine($"{"Id",-10}{"Firstname",-25}{"Lastname",-20}{"Date of Birth",-20}{"Tuition Fees",-10}");
            Console.ResetColor();

            foreach (var student in students)
            {
                student.PrintStudent();
            }
        }
        public static void FilteredStudentsByFirstOrLastName(List<Student> students, string message)
        {
            Console.WriteLine("Give the Firstname");
            string criteriaFirstname = Console.ReadLine().ToLower();

            Console.WriteLine("Give the Lastname");
            string criteriaLastname = Console.ReadLine().ToLower();

            var filteredStudents = students.Where(x => x.LastName.ToLower().Contains(criteriaFirstname)).ToList();
            filteredStudents = students.Where(x => x.LastName.ToLower().Contains(criteriaLastname)).ToList();

            if (filteredStudents.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is no Student containing {criteriaFirstname} - {criteriaLastname} ");
                Console.ResetColor();
            }
            else
            {
                ViewStudent.Students(filteredStudents, message);
            }
        }
        public static void StudentsWithTwoOrMoreCourses(List<Student> students, string message)
        {
            View.PrintColoredMessage(message);
            Console.WriteLine($"{"",-22}{"Lastname",-20}{"Firstname",-15}");
            Console.ResetColor();

            foreach (var student in students)
            {
                if (student.Courses.Count > 1)
                {
                    student.PrintStudentName();
                }
            }
        }
        public static void StudentsCount(List<Student> students, string message)
        {
            View.PrintColoredMessage(message);
            Console.WriteLine($"Students Count is: {students.Count}");
            Console.ResetColor();
        }
        public static void AssignmentsPerStudent(List<Student> students, string message)
        {
            View.PrintColoredMessage(message);
            Console.WriteLine($"\n{"Assignment Title",-22}{"Lastname",-20}{"Firstname",-10}\n");
            Console.ResetColor();

            foreach (var student in students)
            {
                student.PrintStudentName();

                foreach (var course in student.Courses)
                {
                    foreach (var assignment in course.Assignments)
                    {
                        assignment.PrintAssignmentTitle();
                    }
                }
            }
        }
    }
}
