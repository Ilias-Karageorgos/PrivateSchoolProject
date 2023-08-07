using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolProject.RepositoryService
{
    internal class StudentService
    {
        private MyDataBase db = new MyDataBase();

        public List<Student> GetStudents()
        {         
            return db.Students;
        }

        public void CreateStudent(Student createdStudent)
        {
            int lastStudentId = db.Students[db.Students.Count - 1].Id;
            createdStudent.Id = lastStudentId + 1;

            db.Students.Add(createdStudent);
        }
    }
}
