using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PrivateSchoolProject
{

    public class View
    {
        public static void Menu()
        {
            const int first = -50;
            const int second = -50;
            const int third = -50;
            const int fourth = -40;

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
            Console.WriteLine($"{"6 - Students per Course",first}{"16 - Trainers by Lastname",second}{"31 CREATE COURSE (TEMPORARY HERE)",third}{"",fourth}");
            Console.WriteLine($"{"7 - Trainers per Course",first}{"17 - Trainers by Firstname",second}{"",third}{"",fourth}");
            Console.WriteLine($"{"8 - Assignments per Course",first}{"18 - Students by Lastname",second}{"",third}{"",fourth}");
            Console.WriteLine($"{"9 - Assignments per Student",first}{"19 - Students by Firstname ",second}{"",third}{"",fourth}");
            Console.WriteLine($"{"10 - Students who have more than 1 Course",first}{"20 - Students by Tuition Fees",second}{"",third}{"",fourth}");
            Console.WriteLine($"{"",first}{"21 - Students by DoB",second}{"",third}{"",fourth}");
        }                 
        
        public static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Choice - Error 404 (Not Found)");
            Console.ResetColor();
        }
        public static void PrintColoredMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}







