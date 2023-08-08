using PrivateSchoolProject.RepositoryService;
using PrivateSchoolProject.Views.Assignments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolProject.Controllers
{
    internal class AssignmentsController
    {
        AssignmentService assignmentService= new AssignmentService();

        public void GetAssignments()
        {
            List<Assignment> assignments = new List<Assignment>();

            try
            {
                assignments = assignmentService.GetAssignments();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            ViewAssignment.Assignments(assignments, $"{"",40}All Assignments\n");
        }
        public void GetFilteredAssignmentsByTitle()
        {
            List<Assignment> assignments = new List<Assignment>();

            try
            {
                assignments = assignmentService.GetAssignments();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            ViewAssignment.FilteredAssignmentsByTitle(assignments, $"{"",25}Filtered Assignments by Title\n");
        }
        public void GetAssignmentsCount()
        {
            List<Assignment> assignments = new List<Assignment>();

            try
            {
                assignments = assignmentService.GetAssignments();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            ViewAssignment.AssignmentsCount(assignments, $"{"",25}Assignments Count\n");
        }
        public void GetAssignmentsByCourse()
        {
            List<Assignment> assignments = new List<Assignment>();

            try
            {
                assignments = assignmentService.GetAssignments();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            ViewAssignment.AssignmentsByCourse(assignments, $"{"",20}Assignments by Course\n");
        }

        public void CreateAssignment()
        {
            Assignment createdAssignment = ViewAssignment.CreateAssignment();

            assignmentService.CreateAssignment(createdAssignment);

            GetAssignments();
        }
    }
}
