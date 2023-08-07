using Microsoft.Win32;
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

        public void CreateCourse(Course createdCourse)
        {
            int lastCourseId = db.Courses[db.Courses.Count - 1].Id;
            createdCourse.Id = lastCourseId + 1;

            db.Courses.Add(createdCourse);
        }
    }
}
