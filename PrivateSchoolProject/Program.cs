using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class MyDataBase
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();


        public MyDataBase()
        {
            #region Seeding Students

            Student s1 = new Student()
            {
                Id = 1,
                FirstName = "Kostas",
                LastName = "Papadopoulos",
                DateOfBirth = new DateTime(2000, 04, 15),
                TuitionFees = 5354
            };
            Student s2 = new Student()
            {
                Id = 2,
                FirstName = "Giorgos",
                LastName = "Kolias",
                DateOfBirth = new DateTime(2003, 12, 05),
                TuitionFees = 4645
            };
            Student s3 = new Student()
            {
                Id = 3,
                FirstName = "Stefanos",
                LastName = "Papakonstantinou",
                DateOfBirth = new DateTime(1996, 03, 30),
                TuitionFees = 8226
            };
            Student s4 = new Student()
            {
                Id = 4,
                FirstName = "Thanasis",
                LastName = "Moukai",
                DateOfBirth = new DateTime(1980, 11, 10),
                TuitionFees = 9412
            };
            Student s5 = new Student()
            {
                Id = 5,
                FirstName = "Giorgos",
                LastName = "Konstas",
                DateOfBirth = new DateTime(1999, 11, 01),
                TuitionFees = 8300
            };
            Student s6 = new Student()
            {
                Id = 6,
                FirstName = "Rafail",
                LastName = "Athanasopoulos",
                DateOfBirth = new DateTime(1994, 09, 18),
                TuitionFees = 8846
            };
            Student s7 = new Student()
            {
                Id = 7,
                FirstName = "Marios",
                LastName = "Tassiopoulos",
                DateOfBirth = new DateTime(1986, 05, 03),
                TuitionFees = 4546
            };
            Student s8 = new Student()
            {
                Id = 8,
                FirstName = "Anna",
                LastName = "Koukovinou",
                DateOfBirth = new DateTime(1993, 01, 02),
                TuitionFees = 4566
            };
            Student s9 = new Student()
            {
                Id = 9,
                FirstName = "Thanasis",
                LastName = "Moukai",
                DateOfBirth = new DateTime(1980, 11, 10),
                TuitionFees = 9412
            };
            Student s10 = new Student()
            {
                Id = 10,
                FirstName = "Vasiliki",
                LastName = "Daleziou",
                DateOfBirth = new DateTime(1995, 08, 01),
                TuitionFees = 9863
            };
            Student s11 = new Student()
            {
                Id = 11,
                FirstName = "Vasilis",
                LastName = "Sakellariou",
                DateOfBirth = new DateTime(1992, 02, 28),
                TuitionFees = 4556
            };
            Student s12 = new Student()
            {
                Id = 12,
                FirstName = "Giannis",
                LastName = "Giannakis",
                DateOfBirth = new DateTime(1998, 06, 13),
                TuitionFees = 5648
            };
            Student s13 = new Student()
            {
                Id = 13,
                FirstName = "Dimitris",
                LastName = "Perperoglou",
                DateOfBirth = new DateTime(1990, 10, 09),
                TuitionFees = 3564
            };
            Student s14 = new Student()
            {
                Id = 14,
                FirstName = "Alexandros",
                LastName = "Dimitriadis",
                DateOfBirth = new DateTime(1976, 05, 14),
                TuitionFees = 5464
            };
            Student s15 = new Student()
            {
                Id = 15,
                FirstName = "Panagiotis",
                LastName = "LavIdopoulos",
                DateOfBirth = new DateTime(1980, 07, 24),
                TuitionFees = 4647
            };
            Student s16 = new Student()
            {
                Id = 16,
                FirstName = "Stamatis",
                LastName = "GonIdis",
                DateOfBirth = new DateTime(1994, 08, 16),
                TuitionFees = 7464
            };
            Student s17 = new Student()
            {
                Id = 17,
                FirstName = "Konstantina",
                LastName = "Stratou",
                DateOfBirth = new DateTime(1998, 11, 06),
                TuitionFees = 6452
            };
            Student s18 = new Student()
            {
                Id = 18,
                FirstName = "Xristina",
                LastName = "Gioti",
                DateOfBirth = new DateTime(1995, 08, 10),
                TuitionFees = 1359
            };
            Student s19 = new Student()
            {
                Id = 19,
                FirstName = "Natasa",
                LastName = "Papastergiou",
                DateOfBirth = new DateTime(1999, 12, 31),
                TuitionFees = 4647
            };
            Student s20 = new Student()
            {
                Id = 20,
                FirstName = "Pinelopi",
                LastName = "Diamantopoulou",
                DateOfBirth = new DateTime(2003, 02, 16),
                TuitionFees = 6541
            };

            #endregion

            #region Seeding Trainers

            Trainer t1 = new Trainer()
            {
                Id = 1,
                FirstName = "Labros",
                LastName = "Papadimitriou"
            };
            Trainer t2 = new Trainer()
            {
                Id = 2,
                FirstName = "Stavros",
                LastName = "Gouleas"
            };
            Trainer t3 = new Trainer()
            {
                Id = 3,
                FirstName = "Ilias",
                LastName = "Karageorgos"
            };
            Trainer t4 = new Trainer()
            {
                Id = 4,
                FirstName = "Panos",
                LastName = "Sakellarios"
            };
            Trainer t5 = new Trainer()
            {
                Id = 5,
                FirstName = "Giorgos",
                LastName = "Kesopoulos"
            };
            Trainer t6 = new Trainer()
            {
                Id = 6,
                FirstName = "Vetoulis",
                LastName = "Theodoros"
            };
            Trainer t7 = new Trainer()
            {
                Id = 7,
                FirstName = "Themos",
                LastName = "Patarias"
            };

            #endregion

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
            Assignment a2 = new Assignment()
            {
                Id = 2,
                Title = "Javascript 2",
                Description = "Javascript Second Assignment",
                SubDateTime = new DateTime(2024, 02, 15),
                OralMark = 20,
                TotalMark = 30
            };
            Assignment a3 = new Assignment()
            {
                Id = 3,
                Title = "Javascript 3",
                Description = "Javascript Third Assignment",
                SubDateTime = new DateTime(2024, 03, 15),
                OralMark = 30,
                TotalMark = 40
            };
            Assignment a4 = new Assignment()
            {
                Id = 4,
                Title = "Javascript 4",
                Description = "Javascript Fourth Assignment",
                SubDateTime = new DateTime(2024, 04, 15),
                OralMark = 40,
                TotalMark = 50
            };
            Assignment a5 = new Assignment()
            {
                Id = 5,
                Title = "Javascript 5",
                Description = "Javascript Fifth Assignment",
                SubDateTime = new DateTime(2024, 05, 15),
                OralMark = 50,
                TotalMark = 60
            };
            Assignment a6 = new Assignment()
            {
                Id = 6,
                Title = "Javascript 6",
                Description = "Javascript Sixth Assignment",
                SubDateTime = new DateTime(2024, 06, 15),
                OralMark = 60,
                TotalMark = 70
            };
            Assignment a7 = new Assignment()
            {
                Id = 7,
                Title = "Javascript 7",
                Description = "Javascript Seventh Assignment",
                SubDateTime = new DateTime(2024, 07, 15),
                OralMark = 70,
                TotalMark = 80
            };

            Assignment a8 = new Assignment()
            {
                Id = 8,
                Title = "C# 1",
                Description = "C# First Assignment",
                SubDateTime = new DateTime(2024, 01, 15),
                OralMark = 10,
                TotalMark = 20
            };
            Assignment a9 = new Assignment()
            {
                Id = 9,
                Title = "C# 2",
                Description = "C# Second Assignment",
                SubDateTime = new DateTime(2024, 02, 15),
                OralMark = 20,
                TotalMark = 30
            };
            Assignment a10 = new Assignment()
            {
                Id = 10,
                Title = "C# 3",
                Description = "C# Third Assignment",
                SubDateTime = new DateTime(2024, 03, 15),
                OralMark = 30,
                TotalMark = 40
            };
            Assignment a11 = new Assignment()
            {
                Id = 11,
                Title = "C# 4",
                Description = "C# Fourth Assignment",
                SubDateTime = new DateTime(2024, 04, 15),
                OralMark = 40,
                TotalMark = 50
            };
            Assignment a12 = new Assignment()
            {
                Id = 12,
                Title = "C# 5",
                Description = "C# Fifth Assignment",
                SubDateTime = new DateTime(2024, 05, 15),
                OralMark = 50,
                TotalMark = 60
            };
            Assignment a13 = new Assignment()
            {
                Id = 13,
                Title = "C# 6",
                Description = "C# Sixth Assignment",
                SubDateTime = new DateTime(2024, 06, 15),
                OralMark = 60,
                TotalMark = 70
            };
            Assignment a14 = new Assignment()
            {
                Id = 14,
                Title = "C# 7",
                Description = "C# Seventh Assignment",
                SubDateTime = new DateTime(2024, 07, 15),
                OralMark = 70,
                TotalMark = 80
            };

            Assignment a15 = new Assignment()
            {
                Id = 15,
                Title = "Python 1",
                Description = "Python First Assignment",
                SubDateTime = new DateTime(2024, 01, 15),
                OralMark = 10,
                TotalMark = 20
            };
            Assignment a16 = new Assignment()
            {
                Id = 16,
                Title = "Python 2",
                Description = "Python Second Assignment",
                SubDateTime = new DateTime(2024, 02, 15),
                OralMark = 20,
                TotalMark = 30
            };
            Assignment a17 = new Assignment()
            {
                Id = 17,
                Title = "Python 3",
                Description = "Python Third Assignment",
                SubDateTime = new DateTime(2024, 03, 15),
                OralMark = 30,
                TotalMark = 40
            };
            Assignment a18 = new Assignment()
            {
                Id = 18,
                Title = "Python 4",
                Description = "Python Fourth Assignment",
                SubDateTime = new DateTime(2024, 04, 15),
                OralMark = 40,
                TotalMark = 50
            };
            Assignment a19 = new Assignment()
            {
                Id = 19,
                Title = "Python 5",
                Description = "Python Fifth Assignment",
                SubDateTime = new DateTime(2024, 05, 15),
                OralMark = 50,
                TotalMark = 60
            };
            Assignment a20 = new Assignment()
            {
                Id = 20,
                Title = "Python 6",
                Description = "Python Sixth Assignment",
                SubDateTime = new DateTime(2024, 06, 15),
                OralMark = 60,
                TotalMark = 70
            };
            Assignment a21 = new Assignment()
            {
                Id = 21,
                Title = "Python 7",
                Description = "Python Seventh Assignment",
                SubDateTime = new DateTime(2024, 07, 15),
                OralMark = 70,
                TotalMark = 80
            };

            #endregion

        }
    }

}



