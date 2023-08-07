using PrivateSchoolProject.RepositoryService;
using PrivateSchoolProject.Views.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolProject.Controllers
{
    internal class CoursesController
    {
        CourseService courseService = new CourseService();

        public void ReadCourses()
        {
            List<Course> courses = new List<Course>();

            try
            {
                courses = courseService.GetCourses();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            ViewCourse.GetCourses(courses, $"{"",35}All Courses\n");
        }
        public void ReadCourseTypes()
        {
            List<Course> courses = new List<Course>();

            try
            {
                courses = courseService.GetCourses();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            ViewCourse.CourseTypes(courses, $"{"",8}Course Types\n");
        }
        public void GetStudentsPerCourse()
        {
            List<Course> courses = new List<Course>();

            try
            {
                courses = courseService.GetCourses();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            ViewCourse.StudentsPerCourse(courses, $"{"",15}All Students per Course\n");
        }
        public void GetTrainersPerCourse()
        {
            List<Course> courses = new List<Course>();

            try
            {
                courses = courseService.GetCourses();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            ViewCourse.TrainersPerCourse(courses, $"{"",15}All Trainers per Course\n");
        }
        public void GetAssignmentsPerCourse()
        {
            List<Course> courses = new List<Course>();

            try
            {
                courses = courseService.GetCourses();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            ViewCourse.AssignmentsPerCourse(courses, $"{"",15}All Assignments per Course\n");
        }
        public void FilteredCoursesByTitle()
        {
            List<Course> courses = new List<Course>();

            try
            {
                courses = courseService.GetCourses();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            ViewCourse.FilteredCoursesByTitle(courses, $"{"",25}Filtered Courses by Title\n");
        }
        public void GetCoursesCount()
        {
            List<Course> courses = new List<Course>();

            try
            {
                courses = courseService.GetCourses();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            ViewCourse.CoursesCount(courses, $"{"",25}Courses Count\n");
        }
        public void CoursesOrderedBy(string prop)
        {
            List<Course> courses = new List<Course>();

            try
            {
                courses = courseService.GetCourses();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            switch (prop)
            {
                case "Title": ViewCourse.GetCourses(courses.OrderBy(x => x.Title).ToList(), $"{"",25}Courses Ordered by Title\n"); break;
                case "Type": ViewCourse.GetCourses(courses.OrderBy(x => x.Type).ToList(), $"{"",25}Courses Ordered by Type\n"); break;
                case "Stream": ViewCourse.GetCourses(courses.OrderBy(x => x.Stream).ToList(), $"{"",25}Courses Ordered by Stream\n"); break;
                case "StartDate": ViewCourse.GetCourses(courses.OrderBy(x => x.StartDate).ToList(), $"{"",25}Courses Ordered by StardDate\n"); break;
                case "EndDate": ViewCourse.GetCourses(courses.OrderBy(x => x.EndDate).ToList(), $"{"",25}Courses Ordered by EndDate\n"); break;
            }
        }


        public void CreateCourse()
        {
            Course createdCourse = ViewCourse.CreateCourse();

            courseService.CreateCourse(createdCourse);

            ReadCourses();
        }
    }
}
