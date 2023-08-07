using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolProject.RepositoryService
{
    internal class AssignmentService
    {
        private MyDataBase db = new MyDataBase();

        public List<Assignment> GetAssignments()
        {
            return db.Assignments;
        }

        public void CreateAssignment(Assignment createdAssignment)
        {
            int lastAssignmentId = db.Assignments[db.Assignments.Count - 1].Id;

            createdAssignment.Id = lastAssignmentId + 1;

            db.Assignments.Add(createdAssignment);
        }
    }
}
