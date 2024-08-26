using Assignment.Fluent_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Conventions
{
    public class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_ID { get; set; }

        // Navigation Property to Stud_Course
        public ICollection<Stud_Course> Stud_Courses { get; set; }

        // Navigation Property to Course_Inst
        public ICollection<Course_Inst> Course_Insts { get; set; }
    }
}
