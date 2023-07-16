﻿using System;
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
                    case "1": View.Courses(db.Courses, $"{"",35}All Courses\n"); break;
                    case "2": View.Trainers(db.Trainers, $"{"",15}All Trainers\n"); break;
                    case "3": View.Students(db.Students, $"{"",35}All Students\n"); break;
                    case "4": View.Assignments(db.Assignments, $"{"",40}All Assignments\n"); break;
                    case "5": View.CourseTypes(db.Courses, $"{"",8}Course Types\n"); break;
                    case "6": View.StudentsPerCourse(db.Courses, $"{"",15}All Students per Course\n"); break;
                    case "7": View.TrainersPerCourse(db.Courses, $"{"",15}All Trainers per Course\n"); break;
                    case "8": View.AssignmentsPerCourse(db.Courses, $"{"",15}All Assignments per Course\n"); break;
                    case "9": View.AssignmentsPerStudent(db.Students, $"{"",15}All Assignments per Student\n"); break;
                    case "10": View.Courses(db.Courses.OrderBy(x => x.Title).ToList(), $"{"",25}Courses Ordered by Title"); break;
                    case "11": View.Courses(db.Courses.OrderBy(x => x.Type).ToList(), $"{"",25}Courses Ordered by Type"); break;
                    case "12": View.Courses(db.Courses.OrderBy(x => x.Stream).ToList(), $"{"",25}Courses Ordered by Stream"); break;
                    case "13": View.Courses(db.Courses.OrderBy(x => x.StartDate).ToList(), $"{"",25}Courses Ordered by StardDate"); break;
                    case "14": View.Courses(db.Courses.OrderBy(x => x.EndDate).ToList(), $"{"",25}Courses Ordered by EndDate"); break;
                    case "15": View.Trainers(db.Trainers.OrderBy(x => x.LastName).ToList(), $"{"",25}Trainers Ordered by Lastname"); break;
                    case "16": View.Trainers(db.Trainers.OrderBy(x => x.FirstName).ToList(), $"{"",25}Trainers Ordered by Firstname"); break;
                    case "17": View.Students(db.Students.OrderBy(x => x.LastName).ToList(), $"{"",25}Students Ordered by Lastname"); break;
                    case "18": View.Students(db.Students.OrderBy(x => x.FirstName).ToList(), $"{"",25}Students Ordered by Firstname"); break;
                    case "19": View.Students(db.Students.OrderBy(x => x.TuitionFees).ToList(), $"{"",25}Students Ordered by Tuition Fees"); break;
                    case "20": View.Students(db.Students.OrderBy(x => x.DateOfBirth).ToList(), $"{"",25}Students Ordered by Date of Birth"); break;


                    default: Console.WriteLine("Wrong Choice"); break;
                }

            } while (input != "e" && input != "E");
        }
    }

    public class View //class view gia na ftiaksoume tis methoudous Print pou tha kanei get o xristis apo to switch
    {
        //epanalipsi???

        public static void Courses(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-8}{"Title",-15}{"Stream",-18}{"Type",-15}{"Start Date",-15}{"End Date",-15}");
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
                trainer.PrintTrainer();
            }
        }

        internal static void Students(List<Student> students, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-10}{"Firstname",-25}{"Lastname",-20}{"Date of Birth",-20}{"Tuition Fees",-10}");
            Console.ResetColor();

            foreach (var student in students)
            {
                student.PrintStudent();
            }

        }

        internal static void Assignments(List<Assignment> assignments, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-15}{"Title",-18}{"Description",-30}{"Sub Date",-15}{"Oral Mark",-14}{"Total Mark",-5}");
            Console.ResetColor();

            foreach (var assignment in assignments)
            {
                assignment.PrintAssignment();
            }
        }

        internal static void CourseTypes(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Course Title",-15}{"Course Type",-10}");
            Console.ResetColor();

            foreach (var course in courses)
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
                    student.PrintStudentName();
                }
            }
        }

        internal static void TrainersPerCourse(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Course Title",-25}{"Lastname",-20}{"Firstname",-15}\n");
            Console.ResetColor();

            foreach (var course in courses)
            {
                course.PrintTitle();
                foreach (var trainer in course.Trainers)
                {
                    trainer.PrintTrainerName();
                }
            }

        }

        internal static void AssignmentsPerCourse(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Course Title",-25}{"Title",-25}{"Description",-15}\n");
            Console.ResetColor();

            foreach (var course in courses)
            {
                course.PrintTitle();
                foreach (var assignment in course.Assignments)
                {
                    assignment.PrintAssignmentTitleDisc();
                }
            }
        }

        internal static void AssignmentsPerStudent(List<Student> students, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
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



