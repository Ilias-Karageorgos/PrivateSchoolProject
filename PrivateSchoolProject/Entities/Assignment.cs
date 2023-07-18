using System;
using System.Collections.Generic;

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

        public void PrintAssignment()
        {
            Console.WriteLine($"|{Id,-10}|{Title,-15}|{Description,-32}|{SubDateTime.ToShortDateString(),-17}|{OralMark,-13}|{TotalMark,-5}|");
        }
        public void PrintAssignmentTitleDisc()
        {
            Console.WriteLine($"{"",-20}|{Title,-25}|{Description,-35}|");
        }
        public void PrintAssignmentTitle()
        {
            Console.WriteLine($"|{Title,-15}|");
        }
    }
}
