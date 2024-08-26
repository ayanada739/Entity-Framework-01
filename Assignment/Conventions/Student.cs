using Assignment.Fluent_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Conventions
{
    public class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int Dep_Id { get; set; }

        // Navigation Property to Stud_Course
        public ICollection<Stud_Course> Stud_Courses { get; set; }
    }
}
