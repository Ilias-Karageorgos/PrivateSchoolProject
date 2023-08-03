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
            ViewAssignment.Assignments(db.Assignments, $"{"",40}All Assignments\n");
        }
        public void GetFilteredAssignmentsByTitle()
        {
            ViewAssignment.FilteredAssignmentsByTitle(db.Assignments, $"{"",25}Filtered Assignments by Title\n");
        }
        public void GetAssignmentsCount()
        {
            ViewAssignment.AssignmentsCount(db.Assignments, $"{"",25}Assignments Count\n");
        }
        public void GetAssignmentsByCourse()
        {
            ViewAssignment.AssignmentsByCourse(db.Assignments, $"{"",20}Assignments by Course\n");
        }
    }
}
