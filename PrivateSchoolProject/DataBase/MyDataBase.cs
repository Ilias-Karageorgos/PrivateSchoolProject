using System;
using System.Collections.Generic;

namespace PrivateSchoolProject
{
    public class MyDataBase
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();


        public MyDataBase()
        {
            #region Seeding Courses

            Course c1 = new Course()
            {
                Id = 1,
                Title = "Javascript",
                Type = CourseType.PartTime,
                StartDate = new DateTime(2024 / 01 / 09),
                EndDate = new DateTime(2024 / 08 / 10),
                Stream = "CB-8"
            };
            Course c2 = new Course()
            {
                Id = 2,
                Title = "C#",
                Type = CourseType.FullTime,
                StartDate = new DateTime(2024 / 01 / 09),
                EndDate = new DateTime(2024 / 08 / 10),
                Stream = "CB-9"

            };
            Course c3 = new Course()
            {
                Id = 3,
                Title = "Python",
                Type = CourseType.FullTime,
                StartDate = new DateTime(2024 / 01 / 09),
                EndDate = new DateTime(2024 / 08 / 10),
                Stream = "CB-10"
            };

            #endregion

            #region Seeding Students

            Student s1 = new Student()
            {
                Id = 1,
                FirstName = "Kostas",
                LastName = "Papadopoulos",
                DateOfBirth = new DateTime(2000, 04, 15),
                TuitionFees = 5354
            };
            s1.Courses = new List<Course>() { c1, c2 };
            c1.Students.Add(s1);
            c2.Students.Add(s1);

            Student s2 = new Student()
            {
                Id = 2,
                FirstName = "Giorgos",
                LastName = "Kolias",
                DateOfBirth = new DateTime(2003, 12, 05),
                TuitionFees = 4645
            };
            s2.Courses = new List<Course>() { c1, c3 };
            c1.Students.Add(s2);
            c3.Students.Add(s2);

            Student s3 = new Student()
            {
                Id = 3,
                FirstName = "Stefanos",
                LastName = "Papakonstantinou",
                DateOfBirth = new DateTime(1996, 03, 30),
                TuitionFees = 8226
            };
            s3.Courses = new List<Course>() { c2 };
            c2.Students.Add(s3);

            Student s4 = new Student()
            {
                Id = 4,
                FirstName = "Thanasis",
                LastName = "Moukai",
                DateOfBirth = new DateTime(1980, 11, 10),
                TuitionFees = 9412
            };
            s4.Courses = new List<Course>() { c1, c3 };
            c1.Students.Add(s4);
            c3.Students.Add(s4);

            Student s5 = new Student()
            {
                Id = 5,
                FirstName = "Giorgos",
                LastName = "Konstas",
                DateOfBirth = new DateTime(1999, 11, 01),
                TuitionFees = 8300
            };
            s5.Courses = new List<Course>() { c2 };
            c2.Students.Add(s5);

            Student s6 = new Student()
            {
                Id = 6,
                FirstName = "Rafail",
                LastName = "Athanasopoulos",
                DateOfBirth = new DateTime(1994, 09, 18),
                TuitionFees = 8846
            };
            s6.Courses = new List<Course>() { c2, c3 };
            c3.Students.Add(s6);
            c2.Students.Add(s6);

            Student s7 = new Student()
            {
                Id = 7,
                FirstName = "Marios",
                LastName = "Tassiopoulos",
                DateOfBirth = new DateTime(1986, 05, 03),
                TuitionFees = 4546
            };
            s7.Courses = new List<Course>() { c3 };
            c3.Students.Add(s7);


            Student s8 = new Student()
            {
                Id = 8,
                FirstName = "Anna",
                LastName = "Koukovinou",
                DateOfBirth = new DateTime(1993, 01, 02),
                TuitionFees = 4566
            };
            s8.Courses = new List<Course>() { c1, c3 };
            c1.Students.Add(s8);
            c3.Students.Add(s8);

            Student s9 = new Student()
            {
                Id = 9,
                FirstName = "Tasos",
                LastName = "Vatikiotis",
                DateOfBirth = new DateTime(1983, 12, 04),
                TuitionFees = 6547
            };
            s9.Courses = new List<Course>() { c1, c2, c3 };
            c1.Students.Add(s9);
            c2.Students.Add(s9);
            c3.Students.Add(s9);

            Student s10 = new Student()
            {
                Id = 10,
                FirstName = "Vasiliki",
                LastName = "Daleziou",
                DateOfBirth = new DateTime(1995, 08, 01),
                TuitionFees = 9863
            };
            s10.Courses = new List<Course>() { c2, c3 };
            c3.Students.Add(s10);
            c2.Students.Add(s10);

            Student s11 = new Student()
            {
                Id = 11,
                FirstName = "Vasilis",
                LastName = "Sakellariou",
                DateOfBirth = new DateTime(1992, 02, 28),
                TuitionFees = 4556
            };
            s11.Courses = new List<Course>() { c2 };
            c2.Students.Add(s11);


            Student s12 = new Student()
            {
                Id = 12,
                FirstName = "Giannis",
                LastName = "Giannakis",
                DateOfBirth = new DateTime(1998, 06, 13),
                TuitionFees = 5648
            };
            s12.Courses = new List<Course>() { c3 };
            c3.Students.Add(s12);


            Student s13 = new Student()
            {
                Id = 13,
                FirstName = "Dimitris",
                LastName = "Perperoglou",
                DateOfBirth = new DateTime(1990, 10, 09),
                TuitionFees = 3564
            };
            s13.Courses = new List<Course>() { c1 };
            c1.Students.Add(s13);


            Student s14 = new Student()
            {
                Id = 14,
                FirstName = "Alexandros",
                LastName = "Dimitriadis",
                DateOfBirth = new DateTime(1976, 05, 14),
                TuitionFees = 5464
            };
            s14.Courses = new List<Course>() { c1, c3 };
            c1.Students.Add(s14);
            c3.Students.Add(s14);

            Student s15 = new Student()
            {
                Id = 15,
                FirstName = "Panagiotis",
                LastName = "LavIdopoulos",
                DateOfBirth = new DateTime(1980, 07, 24),
                TuitionFees = 4647
            };
            s15.Courses = new List<Course>() { c1 };
            c1.Students.Add(s15);

            Student s16 = new Student()
            {
                Id = 16,
                FirstName = "Stamatis",
                LastName = "GonIdis",
                DateOfBirth = new DateTime(1994, 08, 16),
                TuitionFees = 7464
            };
            s16.Courses = new List<Course>() { c1, c2, c3 };
            c1.Students.Add(s16);
            c2.Students.Add(s16);
            c3.Students.Add(s16);

            Student s17 = new Student()
            {
                Id = 17,
                FirstName = "Konstantina",
                LastName = "Stratou",
                DateOfBirth = new DateTime(1998, 11, 06),
                TuitionFees = 6452
            };
            s17.Courses = new List<Course>() { c1, c2 };
            c1.Students.Add(s17);
            c2.Students.Add(s17);

            Student s18 = new Student()
            {
                Id = 18,
                FirstName = "Xristina",
                LastName = "Gioti",
                DateOfBirth = new DateTime(1995, 08, 10),
                TuitionFees = 1359
            };
            s18.Courses = new List<Course>() { c3 };
            c3.Students.Add(s18);

            Student s19 = new Student()
            {
                Id = 19,
                FirstName = "Natasa",
                LastName = "Papastergiou",
                DateOfBirth = new DateTime(1999, 12, 31),
                TuitionFees = 4647
            };
            s19.Courses = new List<Course>() { c1 };
            c1.Students.Add(s19);

            Student s20 = new Student()
            {
                Id = 20,
                FirstName = "Pinelopi",
                LastName = "Diamantopoulou",
                DateOfBirth = new DateTime(2003, 02, 16),
                TuitionFees = 6541
            };
            s20.Courses = new List<Course>() { c1, c2, c3 };
            c1.Students.Add(s20);
            c2.Students.Add(s20);
            c3.Students.Add(s20);

            #endregion

            #region Seeding Trainers

            Trainer t1 = new Trainer()
            {
                Id = 1,
                FirstName = "Labros",
                LastName = "Papadimitriou"
            };
            t1.Courses = new List<Course> { c1, c2, c3 };
            c1.Trainers.Add(t1);
            c2.Trainers.Add(t1);
            c3.Trainers.Add(t1);

            Trainer t2 = new Trainer()
            {
                Id = 2,
                FirstName = "Stavros",
                LastName = "Gouleas"
            };
            t2.Courses = new List<Course> { c1, c2 };
            c1.Trainers.Add(t2);
            c2.Trainers.Add(t2);


            Trainer t3 = new Trainer()
            {
                Id = 3,
                FirstName = "Ilias",
                LastName = "Karageorgos"
            };
            t3.Courses = new List<Course> { c2, c3 };
            c2.Trainers.Add(t3);
            c3.Trainers.Add(t3);

            Trainer t4 = new Trainer()
            {
                Id = 4,
                FirstName = "Panos",
                LastName = "Sakellarios"
            };
            t4.Courses = new List<Course> { c1, c3 };
            c1.Trainers.Add(t4);
            c3.Trainers.Add(t4);

            Trainer t5 = new Trainer()
            {
                Id = 5,
                FirstName = "Giorgos",
                LastName = "Kesopoulos"
            };
            t5.Courses = new List<Course> { c1 };
            c1.Trainers.Add(t5);


            Trainer t6 = new Trainer()
            {
                Id = 6,
                FirstName = "Theodoros",
                LastName = "Vetoulis"
            };
            t6.Courses = new List<Course> { c2 };
            c2.Trainers.Add(t6);

            Trainer t7 = new Trainer()
            {
                Id = 7,
                FirstName = "Themos",
                LastName = "Patarias"
            };
            t7.Courses = new List<Course> { c3 };
            c3.Trainers.Add(t7);

            #endregion

            #region Seeding Assignments

            Assignment a1 = new Assignment()
            {
                Id = 1,
                Title = "Javascript 1",
                Description = "Javascript First Assignment",
                SubDateTime = new DateTime(2024, 01, 15),
                OralMark = 10,
                TotalMark = 20
            };
            a1.Course = c1;
            c1.Assignments.Add(a1);

            Assignment a2 = new Assignment()
            {
                Id = 2,
                Title = "Javascript 2",
                Description = "Javascript Second Assignment",
                SubDateTime = new DateTime(2024, 02, 15),
                OralMark = 20,
                TotalMark = 30
            };
            a2.Course = c1;
            c1.Assignments.Add(a2);

            Assignment a3 = new Assignment()
            {
                Id = 3,
                Title = "Javascript 3",
                Description = "Javascript Third Assignment",
                SubDateTime = new DateTime(2024, 03, 15),
                OralMark = 30,
                TotalMark = 40
            };
            a3.Course = c1;
            c1.Assignments.Add(a3);

            Assignment a4 = new Assignment()
            {
                Id = 4,
                Title = "Javascript 4",
                Description = "Javascript Fourth Assignment",
                SubDateTime = new DateTime(2024, 04, 15),
                OralMark = 40,
                TotalMark = 50
            };
            a4.Course = c1;
            c1.Assignments.Add(a4);

            Assignment a5 = new Assignment()
            {
                Id = 5,
                Title = "Javascript 5",
                Description = "Javascript Fifth Assignment",
                SubDateTime = new DateTime(2024, 05, 15),
                OralMark = 50,
                TotalMark = 60
            };
            a5.Course = c1;
            c1.Assignments.Add(a5);

            Assignment a6 = new Assignment()
            {
                Id = 6,
                Title = "Javascript 6",
                Description = "Javascript Sixth Assignment",
                SubDateTime = new DateTime(2024, 06, 15),
                OralMark = 60,
                TotalMark = 70
            };
            a6.Course = c1;
            c1.Assignments.Add(a6);

            Assignment a7 = new Assignment()
            {
                Id = 7,
                Title = "Javascript 7",
                Description = "Javascript Seventh Assignment",
                SubDateTime = new DateTime(2024, 07, 15),
                OralMark = 70,
                TotalMark = 80
            };
            a7.Course = c1;
            c1.Assignments.Add(a7);

            Assignment a8 = new Assignment()
            {
                Id = 8,
                Title = "C# 1",
                Description = "C# First Assignment",
                SubDateTime = new DateTime(2024, 01, 15),
                OralMark = 10,
                TotalMark = 20
            };
            a8.Course = c2;
            c2.Assignments.Add(a8);

            Assignment a9 = new Assignment()
            {
                Id = 9,
                Title = "C# 2",
                Description = "C# Second Assignment",
                SubDateTime = new DateTime(2024, 02, 15),
                OralMark = 20,
                TotalMark = 30
            };
            a9.Course = c2;
            c2.Assignments.Add(a9);

            Assignment a10 = new Assignment()
            {
                Id = 10,
                Title = "C# 3",
                Description = "C# Third Assignment",
                SubDateTime = new DateTime(2024, 03, 15),
                OralMark = 30,
                TotalMark = 40
            };
            a10.Course = c2;
            c2.Assignments.Add(a10);

            Assignment a11 = new Assignment()
            {
                Id = 11,
                Title = "C# 4",
                Description = "C# Fourth Assignment",
                SubDateTime = new DateTime(2024, 04, 15),
                OralMark = 40,
                TotalMark = 50
            };
            a11.Course = c2;
            c2.Assignments.Add(a11);

            Assignment a12 = new Assignment()
            {
                Id = 12,
                Title = "C# 5",
                Description = "C# Fifth Assignment",
                SubDateTime = new DateTime(2024, 05, 15),
                OralMark = 50,
                TotalMark = 60
            };
            a12.Course = c2;
            c2.Assignments.Add(a12);

            Assignment a13 = new Assignment()
            {
                Id = 13,
                Title = "C# 6",
                Description = "C# Sixth Assignment",
                SubDateTime = new DateTime(2024, 06, 15),
                OralMark = 60,
                TotalMark = 70
            };
            a13.Course = c2;
            c2.Assignments.Add(a13);

            Assignment a14 = new Assignment()
            {
                Id = 14,
                Title = "C# 7",
                Description = "C# Seventh Assignment",
                SubDateTime = new DateTime(2024, 07, 15),
                OralMark = 70,
                TotalMark = 80
            };
            a14.Course = c2;
            c2.Assignments.Add(a14);

            Assignment a15 = new Assignment()
            {
                Id = 15,
                Title = "Python 1",
                Description = "Python First Assignment",
                SubDateTime = new DateTime(2024, 01, 15),
                OralMark = 10,
                TotalMark = 20
            };
            a15.Course = c3;
            c3.Assignments.Add(a15);


            Assignment a16 = new Assignment()
            {
                Id = 16,
                Title = "Python 2",
                Description = "Python Second Assignment",
                SubDateTime = new DateTime(2024, 02, 15),
                OralMark = 20,
                TotalMark = 30
            };
            a16.Course = c3;
            c3.Assignments.Add(a16);

            Assignment a17 = new Assignment()
            {
                Id = 17,
                Title = "Python 3",
                Description = "Python Third Assignment",
                SubDateTime = new DateTime(2024, 03, 15),
                OralMark = 30,
                TotalMark = 40
            };
            a17.Course = c3;
            c3.Assignments.Add(a17);

            Assignment a18 = new Assignment()
            {
                Id = 18,
                Title = "Python 4",
                Description = "Python Fourth Assignment",
                SubDateTime = new DateTime(2024, 04, 15),
                OralMark = 40,
                TotalMark = 50
            };
            a18.Course = c3;
            c3.Assignments.Add(a18);

            Assignment a19 = new Assignment()
            {
                Id = 19,
                Title = "Python 5",
                Description = "Python Fifth Assignment",
                SubDateTime = new DateTime(2024, 05, 15),
                OralMark = 50,
                TotalMark = 60
            };
            a19.Course = c3;
            c3.Assignments.Add(a19);

            Assignment a20 = new Assignment()
            {
                Id = 20,
                Title = "Python 6",
                Description = "Python Sixth Assignment",
                SubDateTime = new DateTime(2024, 06, 15),
                OralMark = 60,
                TotalMark = 70
            };
            a20.Course = c3;
            c3.Assignments.Add(a20);

            Assignment a21 = new Assignment()
            {
                Id = 21,
                Title = "Python 7",
                Description = "Python Seventh Assignment",
                SubDateTime = new DateTime(2024, 07, 15),
                OralMark = 70,
                TotalMark = 80
            };
            a21.Course = c3;
            c3.Assignments.Add(a21);

            #endregion

            #region PopulateLists

            //ftiaxno nea lista oxi me Caps to proto gramma me ta instances apto DB kai ta kano addRange
            //stis idi dilomenes listes pou dilosa pano pano sto db!

            List<Course> courses = new List<Course>() { c1, c2, c3 };
            Courses.AddRange(courses);

            List<Student> students = new List<Student>()
            { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20};
            Students.AddRange(students);

            List<Trainer> trainers = new List<Trainer>() { t1, t2, t3, t4, t5, t6, t7 };
            Trainers.AddRange(trainers);

            List<Assignment> assignments = new List<Assignment>()
            { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21 };
            Assignments.AddRange(assignments);



            #endregion

        }
    }

}



