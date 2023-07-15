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
        public void PrintStudents()
        {
            Console.WriteLine($"|{Id,-5}|{FirstName,-20}|{LastName,-25}|{DateOfBirth,-30}|{TuitionFees,-10}|");
        }

        public void PrintName()
        {
            Console.WriteLine($"{"",-20}|{LastName,-20}|{FirstName,-15}|");
        }
    }

}
