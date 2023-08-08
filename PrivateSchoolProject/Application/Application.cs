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
            //FIX MENU CREATE OR READ
            string input;

            do
            {
                View.Menu();

                input = Console.ReadLine();
                Console.Clear();

                GetOptions(input);

            } while (input != "e" && input != "E");
        }

        public void GetOptions(string input)
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
                case "11": controllerCourse.CoursesOrderedBy("Title"); break;
                case "12": controllerCourse.CoursesOrderedBy("Type"); break;
                case "13": controllerCourse.CoursesOrderedBy("Stream"); break;
                case "14": controllerCourse.CoursesOrderedBy("StartDate"); break;
                case "15": controllerCourse.CoursesOrderedBy("EndDate"); break;
                case "16": controllerTrainer.TrainersOrderedBy("LastName"); break;
                case "17": controllerTrainer.TrainersOrderedBy("FirstName"); ; break;
                case "18": controllerStudent.StudentsOrderedBy("LastName"); break;
                case "19": controllerStudent.StudentsOrderedBy("FirstName"); ; break;
                case "20": controllerStudent.StudentsOrderedBy("TuitionFees"); break;
                case "21": controllerStudent.StudentsOrderedBy("DateOfBirth"); break;
                case "22": controllerCourse.FilteredCoursesByTitle(); break;
                case "23": controllerTrainer.GetFilteredTrainersByFirstOrLastName(); break;
                case "24": controllerStudent.GetFilteredStudentsByFirstOrLastName(); break;
                case "25": controllerAssignment.GetFilteredAssignmentsByTitle(); break;
                case "26": controllerCourse.GetCoursesCount(); break;
                case "27": controllerTrainer.GetTrainersCount(); break;
                case "28": controllerStudent.GetStudentsCount(); break;
                case "29": controllerAssignment.GetAssignmentsCount(); break;
                case "30": controllerAssignment.GetAssignmentsByCourse(); break;
                case "31": controllerCourse.CreateCourse(); break;
                case "32": controllerTrainer.CreateTrainer(); break;
                case "33": controllerStudent.CreateStudent(); break;
                case "34": controllerAssignment.CreateAssignment(); break;

                default: View.Error(); break;
            }
        }
    }
}







