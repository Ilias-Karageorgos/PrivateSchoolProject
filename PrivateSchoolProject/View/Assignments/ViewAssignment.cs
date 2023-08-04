﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolProject.Views.Assignments
{
    internal class ViewAssignment
    {
        public static void Assignments(List<Assignment> assignments, string message)
        {
            View.PrintColoredMessage(message);
            Console.WriteLine($"{"Id",-15}{"Title",-18}{"Description",-30}{"Sub Date",-15}{"Oral Mark",-14}{"Total Mark",-5}");
            Console.ResetColor();

            foreach (var assignment in assignments)
            {
                assignment.PrintAssignment();
            }
        }
        public static void FilteredAssignmentsByTitle(List<Assignment> assignments, string message)
        {
            Console.WriteLine("Give Assignment Title or Letter");
            string criteria = Console.ReadLine().ToLower();
            var filteredAssignments = assignments.Where(x => x.Title.ToLower().Contains(criteria)).ToList();

            if (filteredAssignments.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is no Assignments containing {criteria}");
                Console.ResetColor();
            }
            else
            {
                ViewAssignment.Assignments(filteredAssignments, message);
            }
        }
        public static void AssignmentsCount(List<Assignment> assignments, string message)
        {
            View.PrintColoredMessage(message);
            Console.WriteLine($"Assignments Count is: {assignments.Count}");
            Console.ResetColor();
        }
        public static void AssignmentsByCourse(List<Assignment> assignments, string message)
        {
            View.PrintColoredMessage(message);

            var groupedResult = from assi in assignments
                                group assi by assi.Course; ;

            foreach (var item in groupedResult)
            {
                Console.WriteLine($"{item.Key.Title,20} = {item.Count()}");
            }
            Console.ResetColor();
        }
    }
}