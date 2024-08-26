using Assignment.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Fluent_API
{
    public class Stud_Course
    {
        public int stud_ID { get; set; }
        public int Course_ID { get; set; }
        public int Grade { get; set; }

        // Navigation Property to Student
        public Student Student { get; set; }

        // Navigation Property to Course
        public Course Course { get; set; }
    }
}
