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
        MyDataBase db = new MyDataBase();

        public void GetAssignments()
        {
            var assignments = db.Assignments;

            ViewAssignment.Assignments(assignments, $"{"",40}All Assignments\n");
        }
        public void GetFilteredAssignmentsByTitle()
        {
            var assignments = db.Assignments;
            ViewAssignment.FilteredAssignmentsByTitle(assignments, $"{"",25}Filtered Assignments by Title\n");
        }
        public void GetAssignmentsCount()
        {
            var assignments = db.Assignments;
            ViewAssignment.AssignmentsCount(assignments, $"{"",25}Assignments Count\n");
        }
        public void GetAssignmentsByCourse()
        {
            var assignments = db.Assignments;
            ViewAssignment.AssignmentsByCourse(assignments, $"{"",20}Assignments by Course\n");
        }
    }
}
