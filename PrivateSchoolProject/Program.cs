using System;
using System.CodeDom;
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
            Application.Run();
            
        }
    }
    class Application
    {
        public static void Run()
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
                Console.WriteLine($"{"1 - Courses",first}{"11 - Courses by Title",second}{"22 - Courses by Title",third}{"26 - Courses Count",fourth}");
                Console.WriteLine($"{"2 - Trainers",first}{"12 - Courses by Type",second}{"23 - Trainers by Firstname Or Lastname",third}{"27 - Trainers Count",fourth}");
                Console.WriteLine($"{"3 - Students",first}{"13 - Courses by Stream",second}{"24 - Students by Firstname Or Lastname",third}{"28 - Stundents Count",fourth}");
                Console.WriteLine($"{"4 - Assignments",first}{"14 - Courses by StartDate",second}{"25 - Assignment by Title",third}{"29 - Assignments Count",fourth}");
                Console.WriteLine($"{"5 - Course Types",first}{"15 - Courses by EndDate",second}{"",third}{"30 - Assignments by Course",fourth}");
                Console.WriteLine($"{"6 - Students per Course",first}{"16 - Trainers by Lastname",second}{"",third}{"",fourth}");
                Console.WriteLine($"{"7 - Trainers per Course",first}{"17 - Trainers by Firstname",second}{"",third}{"",fourth}");
                Console.WriteLine($"{"8 - Assignments per Course",first}{"18 - Students by Lastname",second}{"",third}{"",fourth}");
                Console.WriteLine($"{"9 - Assignments per Student",first}{"19 - Students by Firstname ",second}{"",third}{"",fourth}");
                Console.WriteLine($"{"10 - Students who have more than 1 Course",first}{"20 - Students by Tuition Fees",second}{"",third}{"",fourth}");
                Console.WriteLine($"{"",first}{"21 - Students by DoB",second}{"",third}{"",fourth}");

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
                    case "10": View.StudentsWithTwoOrMoreCourses(db.Students, $"{"",15}All Students with more than 1 Course\n"); break;
                    case "11": View.Courses(db.Courses.OrderBy(x => x.Title).ToList(), $"{"",25}Courses Ordered by Title\n"); break;
                    case "12": View.Courses(db.Courses.OrderBy(x => x.Type).ToList(), $"{"",25}Courses Ordered by Type\n"); break;
                    case "13": View.Courses(db.Courses.OrderBy(x => x.Stream).ToList(), $"{"",25}Courses Ordered by Stream\n"); break;
                    case "14": View.Courses(db.Courses.OrderBy(x => x.StartDate).ToList(), $"{"",25}Courses Ordered by StardDate\n"); break;
                    case "15": View.Courses(db.Courses.OrderBy(x => x.EndDate).ToList(), $"{"",25}Courses Ordered by EndDate\n"); break;
                    case "16": View.Trainers(db.Trainers.OrderBy(x => x.LastName).ToList(), $"{"",25}Trainers Ordered by Lastname\n"); break;
                    case "17": View.Trainers(db.Trainers.OrderBy(x => x.FirstName).ToList(), $"{"",25}Trainers Ordered by Firstname\n"); break;
                    case "18": View.Students(db.Students.OrderBy(x => x.LastName).ToList(), $"{"",25}Students Ordered by Lastname\n"); break;
                    case "19": View.Students(db.Students.OrderBy(x => x.FirstName).ToList(), $"{"",25}Students Ordered by Firstname\n"); break;
                    case "20": View.Students(db.Students.OrderBy(x => x.TuitionFees).ToList(), $"{"",25}Students Ordered by Tuition Fees\n"); break;
                    case "21": View.Students(db.Students.OrderBy(x => x.DateOfBirth).ToList(), $"{"",25}Students Ordered by Date of Birth\n"); break;
                    case "22": View.FilteredCoursesByTitle(db.Courses, $"{"",25}Filtered Courses by Title\n"); break;
                    case "23": View.FilteredTrainersByFirstOrLastName(db.Trainers, $"{"",5}Filtered Trainers by Firstname or Lastname\n"); break;
                    case "24": View.FilteredStudentsByFirstOrLastName(db.Students, $"{"",5}Filtered Students by Firstname or Lastname\n"); break;
                    case "25": View.FilteredAssignmentsByTitle(db.Assignments, $"{"",25}Filtered Assignments by Title\n"); break;
                    case "26": View.CoursesCount(db.Courses, $"{"",25}Courses Count\n"); break;
                    case "27": View.TrainersCount(db.Trainers, $"{"",25}Trainers Count\n"); break;
                    case "28": View.StudentsCount(db.Students, $"{"",25}Students Count\n"); break;
                    case "29": View.AssignmentsCount(db.Assignments, $"{"",25}Assignments Count\n"); break;
                    case "30": View.AssignmentsByCourse(db.Assignments, $"{"",20}Assignments by Course\n"); break;

                    default: View.Error(); break;
                }
            } while (input != "e" && input != "E");
        }
    }
}







