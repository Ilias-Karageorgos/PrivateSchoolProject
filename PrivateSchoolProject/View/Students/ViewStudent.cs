using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolProject.Views.Students
{
    internal class ViewStudent
    {
        public static void GetStudents(List<Student> students, string message)
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
                ViewStudent.GetStudents(filteredStudents, message);
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

        public static Student CreateStudent()
        {
            string studentFirstname;
            string studentLastname;
            DateTime doB;
            string inputTuitionFees;

            //Firstname
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Give Student's Firstname");
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Firstname must be only letters (more that 2)");
                Console.ResetColor();
                studentFirstname = Console.ReadLine();
            } while (!Validation.Validation.CheckInputString(studentFirstname));

            //Lastname
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Give Student's Lastname");
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Firstname must be only letters (more that 2)");
                Console.ResetColor();
                studentLastname = Console.ReadLine();
            } while (!Validation.Validation.CheckInputString(studentLastname));

            //Tuition Fees
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Give Student's TuitionFees (number)");
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Must be a number between 0 and 10.000");
                Console.ResetColor();
                inputTuitionFees = Console.ReadLine();
            } while (Validation.Validation.CheckTuitionFees(inputTuitionFees));       

            //Date of Birth
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Give Student's Date Of Birth");
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ex. 1999-05-26 (use . or / or - or space in between)");
                Console.WriteLine("Age must be at least 18 years old");
                Console.ResetColor();
                string inputDoB = Console.ReadLine();                
                DateTime.TryParse(inputDoB, out doB);

            } while (Validation.Validation.CheckDateOfBirth(doB));
            

            Student createdStudent = new Student()
            {
                FirstName = studentFirstname,
                LastName = studentLastname,
                TuitionFees = Convert.ToInt32(inputTuitionFees),
                DateOfBirth = doB
            };

            return createdStudent;
        }
    }
}
