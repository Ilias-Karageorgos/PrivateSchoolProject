using System;
using System.Collections.Generic;

namespace PrivateSchoolProject
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }
        public int Id { get; set; }

        //Navigation Properties
        public List<Course> Courses { get; set; } = new List<Course>();        

        //Methods
        public void PrintStudent()
        {
            Console.WriteLine($"|{Id,-5}|{FirstName,-20}|{LastName,-25}|{DateOfBirth.ToShortDateString(),-20}|{TuitionFees,-10}|");
        }
        public void PrintStudentName()
        {
            Console.WriteLine($"{"",-20}|{LastName,-20}|{FirstName,-10}|"); 
        }
        public void PrintStudentLastName()
        {
            Console.WriteLine($"|{LastName,-20}|");
        }
    }
}
