using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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

        public static Assignment CreateAssignment()
        {
            string assignmentTitle;
            string inputSubDate;
            DateTime subDate;
            string inputAssignmentOralMark;
            string inputAssignmentTotalMark;

            //Title
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Give Assignment's Title");

            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Course Title must be only letters (more that 2)");
                Console.ResetColor();
                assignmentTitle = Console.ReadLine();                
            } while (!Validation.Validation.CheckInputString(assignmentTitle));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Give Assignment's Description (Optional)");
            Console.ResetColor();
            string assignmentDescription = Console.ReadLine();

            //Oral Mark
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Give Assignment's Oral Mark");
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oral Mark must be between 0 and 100");
                Console.ResetColor();
                inputAssignmentOralMark = Console.ReadLine();
            } while (Validation.Validation.CheckOralMark(inputAssignmentOralMark));

            //Total Mark
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Give Assignment's Total Mark");
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Total Mark must be between 0 and 100 and greater than Oral Mark");
                Console.ResetColor();
                inputAssignmentTotalMark = Console.ReadLine();
            } while (Validation.Validation.CheckTotalMark(inputAssignmentTotalMark, Convert.ToInt32(inputAssignmentOralMark)));
                        

            //Subdate
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Give Assignment's SubDateTime");
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ex. 2024-05-26 (use . or / or - or space in between)");
                Console.WriteLine("Subdate must a date AFTER TODAY'S DATE");
                Console.ResetColor();
                inputSubDate = Console.ReadLine();                
                DateTime.TryParse(inputSubDate, out subDate);
            } while (Validation.Validation.CheckStartDate(subDate));
            

            Assignment createdAssignment = new Assignment()
            {
                Title = assignmentTitle,
                Description = assignmentDescription,
                OralMark = Convert.ToInt32(inputAssignmentOralMark),
                TotalMark = Convert.ToInt32(inputAssignmentTotalMark),
                SubDateTime = subDate
            };

            return createdAssignment;
        }
    }
}
