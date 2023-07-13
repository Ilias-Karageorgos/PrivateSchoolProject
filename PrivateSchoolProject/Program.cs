using System;
using System.CodeDom;
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


            } while (input!="e" && input!="E");

          
        }
    }

}



