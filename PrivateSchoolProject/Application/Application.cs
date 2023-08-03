using PrivateSchoolProject.Controllers;
using PrivateSchoolProject.Views.Courses;
using PrivateSchoolProject.Views.Students;
using PrivateSchoolProject.Views.Trainers;
using System;
using System.Data;
using System.Linq;

namespace PrivateSchoolProject
{
    public class Application
    {
        private CoursesController controllerCourse = new CoursesController();
        private AssignmentsController controllerAssignment = new AssignmentsController();
        private StudentsController controllerStudent = new StudentsController();
        private TrainersController controllerTrainer = new TrainersController();

        public void Run()
        {
            MyDataBase db = new MyDataBase();

            string input;

            do
            {
                View.Menu();

                input = Console.ReadLine();
                Console.Clear();

                GetOptions(db, input);

            } while (input != "e" && input != "E");
        }

        public void GetOptions(MyDataBase db, string input)
        {
            switch (input)
            {
                case "1": controllerCourse.ReadCourses(); break;
                case "2": controllerTrainer.GetTrainers(); break;
                case "3": controllerStudent.GetStudents(); break;
                case "4": controllerAssignment.GetAssignments(); break;
                case "5": controllerCourse.ReadCourseTypes(); break;
                case "6": controllerCourse.GetStudentsPerCourse(); break;
                case "7": controllerCourse.GetTrainersPerCourse(); break;
                case "8": controllerCourse.GetAssignmentsPerCourse(); break;
                case "9": controllerStudent.GetAssignmentsPerStudent(); break;
                case "10": controllerStudent.GetStudentsWithTwoOrMoreCourses(); break;
                case "11": ViewCourse.GetCourses(db.Courses.OrderBy(x => x.Title).ToList(), $"{"",25}Courses Ordered by Title\n"); break;
                case "12": ViewCourse.GetCourses(db.Courses.OrderBy(x => x.Type).ToList(), $"{"",25}Courses Ordered by Type\n"); break;
                case "13": ViewCourse.GetCourses(db.Courses.OrderBy(x => x.Stream).ToList(), $"{"",25}Courses Ordered by Stream\n"); break;
                case "14": ViewCourse.GetCourses(db.Courses.OrderBy(x => x.StartDate).ToList(), $"{"",25}Courses Ordered by StardDate\n"); break;
                case "15": ViewCourse.GetCourses(db.Courses.OrderBy(x => x.EndDate).ToList(), $"{"",25}Courses Ordered by EndDate\n"); break;
                case "16": ViewTrainer.Trainers(db.Trainers.OrderBy(x => x.LastName).ToList(), $"{"",25}Trainers Ordered by Lastname\n"); break;
                case "17": ViewTrainer.Trainers(db.Trainers.OrderBy(x => x.FirstName).ToList(), $"{"",25}Trainers Ordered by Firstname\n"); break;
                case "18": ViewStudent.Students(db.Students.OrderBy(x => x.LastName).ToList(), $"{"",25}Students Ordered by Lastname\n"); break;
                case "19": ViewStudent.Students(db.Students.OrderBy(x => x.FirstName).ToList(), $"{"",25}Students Ordered by Firstname\n"); break;
                case "20": ViewStudent.Students(db.Students.OrderBy(x => x.TuitionFees).ToList(), $"{"",25}Students Ordered by Tuition Fees\n"); break;
                case "21": ViewStudent.Students(db.Students.OrderBy(x => x.DateOfBirth).ToList(), $"{"",25}Students Ordered by Date of Birth\n"); break;
                case "22": controllerCourse.FilteredCoursesByTitle(); break;
                case "23": controllerTrainer.GetFilteredTrainersByFirstOrLastName(); break;
                case "24": controllerStudent.GetFilteredStudentsByFirstOrLastName(); break;
                case "25": controllerAssignment.GetFilteredAssignmentsByTitle(); break;
                case "26": controllerCourse.GetCoursesCount(); break;
                case "27": controllerTrainer.GetTrainersCount(); break;
                case "28": controllerStudent.GetStudentsCount(); break;
                case "29": controllerAssignment.GetAssignmentsCount(); break;
                case "30": controllerAssignment.GetAssignmentsByCourse(); break;
                default: View.Error(); break;
            }
        }
    }
}







