using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolProject.RepositoryService
{
    internal class CourseService
    {
        private MyDataBase db = new MyDataBase();

        public List<Course> GetCourses()
        {             
            return db.Courses;
        }
    }
}
