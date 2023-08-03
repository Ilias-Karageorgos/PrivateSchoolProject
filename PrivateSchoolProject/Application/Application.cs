﻿using PrivateSchoolProject.Controllers;
using PrivateSchoolProject.Views.Courses;
using System;
using System.Data;
using System.Linq;

namespace PrivateSchoolProject
{
    public class Application
    {
        private CoursesController controllerCourse = new CoursesController();
        
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
                case "2": View.Trainers(db.Trainers, $"{"",15}All Trainers\n"); break;
                case "3": View.Students(db.Students, $"{"",35}All Students\n"); break;
                case "4": View.Assignments(db.Assignments, $"{"",40}All Assignments\n"); break;
                case "5": controllerCourse.ReadCourseTypes(); break;
                case "6": controllerCourse.GetStudentsPerCourse(); break;
                case "7": controllerCourse.GetTrainersPerCourse(); break;
                case "8": controllerCourse.GetAssignmentsPerCourse(); break;
                case "9": View.AssignmentsPerStudent(db.Students, $"{"",15}All Assignments per Student\n"); break;
                case "10": View.StudentsWithTwoOrMoreCourses(db.Students, $"{"",15}All Students with more than 1 Course\n"); break;
                case "11": ViewCourse.GetCourses(db.Courses.OrderBy(x => x.Title).ToList(), $"{"",25}Courses Ordered by Title\n"); break;
                case "12": ViewCourse.GetCourses(db.Courses.OrderBy(x => x.Type).ToList(), $"{"",25}Courses Ordered by Type\n"); break;
                case "13": ViewCourse.GetCourses(db.Courses.OrderBy(x => x.Stream).ToList(), $"{"",25}Courses Ordered by Stream\n"); break;
                case "14": ViewCourse.GetCourses(db.Courses.OrderBy(x => x.StartDate).ToList(), $"{"",25}Courses Ordered by StardDate\n"); break;
                case "15": ViewCourse.GetCourses(db.Courses.OrderBy(x => x.EndDate).ToList(), $"{"",25}Courses Ordered by EndDate\n"); break;
                case "16": View.Trainers(db.Trainers.OrderBy(x => x.LastName).ToList(), $"{"",25}Trainers Ordered by Lastname\n"); break;
                case "17": View.Trainers(db.Trainers.OrderBy(x => x.FirstName).ToList(), $"{"",25}Trainers Ordered by Firstname\n"); break;
                case "18": View.Students(db.Students.OrderBy(x => x.LastName).ToList(), $"{"",25}Students Ordered by Lastname\n"); break;
                case "19": View.Students(db.Students.OrderBy(x => x.FirstName).ToList(), $"{"",25}Students Ordered by Firstname\n"); break;
                case "20": View.Students(db.Students.OrderBy(x => x.TuitionFees).ToList(), $"{"",25}Students Ordered by Tuition Fees\n"); break;
                case "21": View.Students(db.Students.OrderBy(x => x.DateOfBirth).ToList(), $"{"",25}Students Ordered by Date of Birth\n"); break;
                case "22": controllerCourse.FilteredCoursesByTitle(); break;
                case "23": View.FilteredTrainersByFirstOrLastName(db.Trainers, $"{"",5}Filtered Trainers by Firstname or Lastname\n"); break;
                case "24": View.FilteredStudentsByFirstOrLastName(db.Students, $"{"",5}Filtered Students by Firstname or Lastname\n"); break;
                case "25": View.FilteredAssignmentsByTitle(db.Assignments, $"{"",25}Filtered Assignments by Title\n"); break;
                case "26": controllerCourse.GetCoursesCount(); break;
                case "27": View.TrainersCount(db.Trainers, $"{"",25}Trainers Count\n"); break;
                case "28": View.StudentsCount(db.Students, $"{"",25}Students Count\n"); break;
                case "29": View.AssignmentsCount(db.Assignments, $"{"",25}Assignments Count\n"); break;
                case "30": View.AssignmentsByCourse(db.Assignments, $"{"",20}Assignments by Course\n"); break;
                default: View.Error(); break;
            }
        }
    }
}







