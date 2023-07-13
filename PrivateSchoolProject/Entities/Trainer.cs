﻿using System.Collections.Generic;

namespace PrivateSchoolProject
{
    public class Trainer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        //Navigation Properties
        public List<Course> Courses { get; set; } = new List<Course>();
    }

}
