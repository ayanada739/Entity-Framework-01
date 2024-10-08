﻿using Assignment.Conventions;
using Assignment.Data_Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Fluent_API
{
    public class Course_Inst
    {
        public int inst_ID { get; set; }
        public int Course_ID { get; set; }
        public string Evaluate { get; set; }

        // Navigation Property to Instructor
        public Instructor Instructor { get; set; }

        // Navigation Property to Course
        public Course Course { get; set; }
    }
}
