﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolProject.RepositoryService
{
    internal class StudentService
    {
        private MyDataBase db = new MyDataBase();

        public List<Student> GetStudents()
        {         
            return db.Students;
        }
    }
}