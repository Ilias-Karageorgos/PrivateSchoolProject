using System;

namespace PrivateSchoolProject
{
    public class Assignment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }
        public int Id { get; set; }

        //Navigation Properties
        public Course Course { get; set; }

        //Methods

        public void PrintAssignments()
        {
            Console.WriteLine($"|{Id,-10}|{Title,-15}|{Description,-32}|{SubDateTime,-27}|{OralMark,-13}|{TotalMark,-5}|");
        }

    }

}
