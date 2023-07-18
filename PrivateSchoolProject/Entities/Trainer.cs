using System;
using System.Collections.Generic;

namespace PrivateSchoolProject
{
    public class Trainer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        //Navigation Properties
        public List<Course> Courses { get; set; } = new List<Course>();

        //Methods
        public void PrintTrainer()
        {
            Console.WriteLine($"|{Id,-5}|{FirstName,-15}|{LastName,-15}|");            
        }
        public void PrintTrainerName()
        {
            Console.WriteLine($"{"",-20}|{LastName,-20}|{FirstName,-15}|");
        }
    }
}
