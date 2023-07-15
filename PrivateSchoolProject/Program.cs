using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyDataBase db = new MyDataBase();
            const int first = -50;
            const int second = -50;
            const int third = -50;
            const int fourth = -40;
            string input;

            do
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Choose an option (or press E or e to Exit)");
                Console.WriteLine();
                Console.ResetColor();

                Console.WriteLine($"{"-------------- ALL DATA --------------",first}{"-------------- ORDERED BY --------------",second}{"-------------- FILTER BY --------------",third}{"-------------- STATS --------------",fourth}");
                Console.WriteLine($"{"1 - Courses",first}{"10 - Courses by Title",second}{"21 - Assignment by Title",third}{"4fsdfsd",fourth}");
                Console.WriteLine($"{"2 - Trainers",first}{"11 - Courses by Type",second}{"22 - Assignment by Description",third}{"4fsdsd",fourth}");
                Console.WriteLine($"{"3 - Students",first}{"12 - Courses by Stream",second}{"23 - Assignment by SubDateTime",third}{"4gsdgsd",fourth}");
                Console.WriteLine($"{"4 - Assignments",first}{"13 - Courses by StartDate",second}{"24 - Assignment by Oral Mark",third}{"4gsdgsd",fourth}");
                Console.WriteLine($"{"5 - Course Types",first}{"14 - Courses by EndDate",second}{"25 - Assignment by Total Mark",third}{"4gsdgsd",fourth}");
                Console.WriteLine($"{"6 - Students per Course",first}{"15 - Trainers by Lastname",second}{"",third}{"4gsdgsd",fourth}");
                Console.WriteLine($"{"7 - Trainers per Course",first}{"16 - Trainers by Firstname",second}{"",third}{"4gsdgsd",fourth}");
                Console.WriteLine($"{"8 - Assignments per Course",first}{"17 - Students by Lastname",second}{"",third}{"4gsdgsd",fourth}");
                Console.WriteLine($"{"9 - Assignments per Student",first}{"18 - Students by Firstname ",second}{"",third}{"4gsdgsd",fourth}");
                Console.WriteLine($"{"",first}{"19 - Students by Tuition Fees",second}{"",third}{"4gsdgsd",fourth}");
                Console.WriteLine($"{"",first}{"20 - Students by DoB",second}{"",third}{"4gsdgsd",fourth}");

                input = Console.ReadLine();
                Console.Clear();

                switch (input)
                {
                    case "1": View.Courses(db.Courses,"All Courses"); break;
                    case "2": View.Trainers(db.Trainers,"All Trainers"); break;
                    case "3": View.Students(db.Students, "All Students"); break;
                    case "4": View.Assignments(db.Assignments, "All Assignments"); break;
                    case "5": View.CourseTypes(db.Courses, "Course Types"); break;
                    case "6": View.StudentsPerCourse(db.Courses, "All Students per Course"); break;
                    case "7": View.Assignments(db.Assignments, "Trainers per Course"); break;


                    default: Console.WriteLine("wrong choice"); break;
                }

            } while (input != "e" && input != "E");
        }
    }

    public class View //class view gia na ftiaksoume tis methoudous Print pou tha kanei get o xristis apo to switch
    {
        public static void Courses(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-8}{"Title",-15}{"Stream",-18}{"Type",-18}{"Start Date",-25}{"End Date",-20}");
            Console.ResetColor();

            foreach (var course in courses)
            {
                course.PrintCourses();
            }            
        }

        public static void Trainers(List<Trainer> trainers, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-8}{"Firstname",-15}{"Lastname",-15}");
            Console.ResetColor();

            foreach (var trainer in trainers)
            {
                trainer.PrintTrainers();
            }
        }

        internal static void Students(List<Student> students, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-10}{"Firstname",-25}{"Lastname",-25}{"Date of Birth",-25}{"Tuition Fees",-10}");
            Console.ResetColor();

            foreach (var student in students)
            {
                student.PrintStudents();
            }

        }

        internal static void Assignments(List<Assignment> assignments, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-15}{"Title",-18}{"Description",-30}{"Sub Date",-25}{"Oral Mark",-14}{"Total Mark",-5}");
            Console.ResetColor();

            foreach (var assignment in assignments)
            {
                assignment.PrintAssignments();
            }
        }

        internal static void CourseTypes(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Course Title",-15}{"Course Type",-10}");
            Console.ResetColor();

            foreach(var course in courses)
            {
                course.PrintCourseTypes();
            }


        }

        internal static void StudentsPerCourse(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Course Title",-25}{"Lastname",-20}{"Firstname",-15}");
            Console.ResetColor();

            foreach (var course in courses)
            {
                course.PrintTitle();
                foreach (var student in course.Students)
                {                    
                    student.PrintName();
                }
            }

            

        }
    }
}



