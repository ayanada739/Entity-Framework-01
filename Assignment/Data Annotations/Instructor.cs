using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Fluent_API;

namespace Assignment.Data_Annotations
{
    public class Instructor
    {
        [Key]  
        public int ID { get; set; }

        [Required]  
        public string Name { get; set; }

        public decimal Bonus { get; set; }

        [Column(TypeName = "decimal(18, 2)")]  
        public decimal Salary { get; set; }

        public string Address { get; set; }

        public decimal HourRate { get; set; }

        public int Dept_ID { get; set; }

        // Navigation Property to Course_Inst
        public ICollection<Course_Inst> Course_Insts { get; set; }

        // Navigation Property to Department
        public Department Department { get; set; }
    }

}
