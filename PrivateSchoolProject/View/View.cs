using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PrivateSchoolProject
{
    public class View //class view gia na ftiaksoume tis methoudous Print pou tha kanei get o xristis apo to switch
    {
        //epanalipsi???

        public static void Courses(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-8}{"Title",-15}{"Stream",-18}{"Type",-15}{"Start Date",-15}{"End Date",-15}");
            Console.ResetColor();

            foreach (var course in courses)
            {
                course.PrintCourses();
            }
        }
        public static void Trainers(List<Trainer> trainers, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-8}{"Firstname",-15}{"Lastname",-15}");
            Console.ResetColor();

            foreach (var trainer in trainers)
            {
                trainer.PrintTrainer();
            }
        }
        public static void Students(List<Student> students, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-10}{"Firstname",-25}{"Lastname",-20}{"Date of Birth",-20}{"Tuition Fees",-10}");
            Console.ResetColor();

            foreach (var student in students)
            {
                student.PrintStudent();
            }

        }
        public static void Assignments(List<Assignment> assignments, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-15}{"Title",-18}{"Description",-30}{"Sub Date",-15}{"Oral Mark",-14}{"Total Mark",-5}");
            Console.ResetColor();

            foreach (var assignment in assignments)
            {
                assignment.PrintAssignment();
            }
        }
        public static void CourseTypes(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Course Title",-15}{"Course Type",-10}");
            Console.ResetColor();

            foreach (var course in courses)
            {
                course.PrintCourseTypes();
            }


        }
        public static void StudentsPerCourse(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
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
        public static void AssignmentsPerStudent(List<Student> students, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{"Assignment Title",-22}{"Lastname",-20}{"Firstname",-10}\n");
            Console.ResetColor();

            foreach (var student in students)
            {
                student.PrintStudentName();

                foreach (var course in student.Courses)
                {
                    foreach (var assignment in course.Assignments)
                    {
                        assignment.PrintAssignmentTitle();
                    }
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
                View.Courses(filteredCourses, message);
            }
        }
        public static void FilteredTrainersByFirstOrLastName(List<Trainer> trainers, string message)
        {
            Console.WriteLine("Give the Firstname");
            string criteriaFirstname = Console.ReadLine().ToLower();

            Console.WriteLine("Give the Lastname");
            string criteriaLastname = Console.ReadLine().ToLower();

            var filteredTrainers = trainers.Where(x => x.LastName.ToLower().Contains(criteriaFirstname)).ToList();
            filteredTrainers = trainers.Where(x => x.LastName.ToLower().Contains(criteriaLastname)).ToList();

            if (filteredTrainers.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is no Trainer containing {criteriaFirstname} - {criteriaLastname} ");
                Console.ResetColor();
            }
            else
            {
                View.Trainers(filteredTrainers, message);
            }
        }
        public static void FilteredStudentsByFirstOrLastName(List<Student> students, string message)
        {
            Console.WriteLine("Give the Firstname");
            string criteriaFirstname = Console.ReadLine().ToLower();

            Console.WriteLine("Give the Lastname");
            string criteriaLastname = Console.ReadLine().ToLower();

            var filteredStudents = students.Where(x => x.LastName.ToLower().Contains(criteriaFirstname)).ToList();
            filteredStudents = students.Where(x => x.LastName.ToLower().Contains(criteriaLastname)).ToList();

            if (filteredStudents.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is no Student containing {criteriaFirstname} - {criteriaLastname} ");
                Console.ResetColor();
            }
            else
            {
                View.Students(filteredStudents, message);
            }
        }
        public static void FilteredAssignmentsByTitle(List<Assignment> assignments, string message)
        {
            Console.WriteLine("Give Assignment Title or Letter");
            string criteria = Console.ReadLine().ToLower();
            var filteredAssignments = assignments.Where(x => x.Title.ToLower().Contains(criteria)).ToList();

            if (filteredAssignments.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is no Assignments containing {criteria}");
                Console.ResetColor();
            }
            else
            {
                View.Assignments(filteredAssignments, message);
            }
        }
        public static void StudentsWithTwoOrMoreCourses(List<Student> students, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"",-22}{"Lastname",-20}{"Firstname",-15}");
            Console.ResetColor();

            foreach (var student in students)
            {
                if (student.Courses.Count > 1)
                {
                    student.PrintStudentName();
                }
            }
        }
        public static void CoursesCount(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Courses Count is: {courses.Count}");
            Console.ResetColor();
        }
        public static void TrainersCount(List<Trainer> trainers, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Trainers Count is: {trainers.Count}");
            Console.ResetColor();
        }
        public static void StudentsCount(List<Student> students, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Students Count is: {students.Count}");
            Console.ResetColor();
        }
        public static void AssignmentsCount(List<Assignment> assignments, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Assignments Count is: {assignments.Count}");
            Console.ResetColor();
        }
        public static void AssignmentsByCourse(List<Assignment> assignments, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;

            var groupedResult = from assi in assignments
                                group assi by assi.Course; ;

            foreach (var item in groupedResult)
            {
                Console.WriteLine($"{item.Key.Title,20} = {item.Count()}");
            }
            Console.ResetColor();
        }
        public static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Choice - Error 404 (Not Found)");
            Console.ResetColor();
        }
    }
}







