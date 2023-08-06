using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolProject.Views.Courses
{
    internal class ViewCourse
    {
        public static void GetCourses(List<Course> courses, string message)
        {
            View.PrintColoredMessage(message);
            Console.WriteLine($"{"Id",-8}{"Title",-15}{"Stream",-18}{"Type",-15}{"Start Date",-15}{"End Date",-15}");
            Console.ResetColor();

            foreach (var course in courses)
            {
                course.PrintCourses();
            }
        }
        public static void CourseTypes(List<Course> courses, string message)
        {
            View.PrintColoredMessage(message);
            Console.WriteLine($"{"Course Title",-15}{"Course Type",-10}");
            Console.ResetColor();

            foreach (var course in courses)
            {
                course.PrintCourseTypes();
            }
        }
        public static void StudentsPerCourse(List<Course> courses, string message)
        {
            View.PrintColoredMessage(message);
            Console.WriteLine($"{"Course Title",-25}{"Lastname",-20}{"Firstname",-15}");
            Console.ResetColor();

            foreach (var course in courses)
            {
                course.PrintTitle();
                foreach (var student in course.Students)
                {
                    student.PrintStudentName();
                }
            }
        }
        public static void TrainersPerCourse(List<Course> courses, string message)
        {
            View.PrintColoredMessage(message);
            Console.WriteLine($"{"Course Title",-25}{"Lastname",-20}{"Firstname",-15}\n");
            Console.ResetColor();

            foreach (var course in courses)
            {
                course.PrintTitle();
                foreach (var trainer in course.Trainers)
                {
                    trainer.PrintTrainerName();
                }
            }
        }
        public static void AssignmentsPerCourse(List<Course> courses, string message)
        {
            View.PrintColoredMessage(message);
            Console.WriteLine($"{"Course Title",-25}{"Title",-25}{"Description",-15}\n");
            Console.ResetColor();

            foreach (var course in courses)
            {
                course.PrintTitle();
                foreach (var assignment in course.Assignments)
                {
                    assignment.PrintAssignmentTitleDisc();
                }


            }
        }
        public static void FilteredCoursesByTitle(List<Course> courses, string message)
        {
            Console.WriteLine("Give Course Title or Letter");
            string criteria = Console.ReadLine().ToLower();
            var filteredCourses = courses.Where(x => x.Title.ToLower().Contains(criteria)).ToList();

            if (filteredCourses.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is no Course containing {criteria}");
                Console.ResetColor();
            }
            else
            {
                ViewCourse.GetCourses(filteredCourses, message);
            }
        }
        public static void CoursesCount(List<Course> courses, string message)
        {
            View.PrintColoredMessage(message);
            Console.WriteLine($"Courses Count is: {courses.Count}");
            Console.ResetColor();
        }

        public static Course CreateCourse() //na kano validations
        {
            Console.WriteLine("Give Course Title");
            string courseTitle = Console.ReadLine();

            Console.WriteLine("Give Course Stream");
            string courseStream = Console.ReadLine();

            Console.WriteLine("Give Course Start Date ex. 2022/10/25");
            string inputStartD = Console.ReadLine();
            DateTime startDate;
            DateTime.TryParse(inputStartD, out startDate);

            Console.WriteLine("Give Course End Date ex 2022/12/20");
            string inputEndD = Console.ReadLine();
            DateTime endDate;
            DateTime.TryParse(inputEndD, out endDate);

            //get Type Enum 
            Console.WriteLine("Select Course Type");
            string[] types = Enum.GetNames(typeof(CourseType)); //exoume ena pinaka me ola ta onoma apo types (dld part kai fulltime)

            for (int i = 0; i < types.Length; i++)
            {
                Console.WriteLine($"{i,-4}-{types[i]}");
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            CourseType courseType = (CourseType)choice;  //edo pairno auto p edose o xristis

            Course createdCourse = new Course()
            {
                Title = courseTitle,
                Stream = courseStream,
                StartDate = startDate,
                EndDate = endDate,
                Type = courseType
            };

            return createdCourse;
        }
    }
}
