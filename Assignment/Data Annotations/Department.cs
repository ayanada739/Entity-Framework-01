using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data_Annotations
{
    public class Department
    {
        [Key]  
        public int ID { get; set; }

        [Required] 
        public string Name { get; set; }

        public int Ins_ID { get; set; }

        public DateTime HiringDate { get; set; }

        // Navigation Property to Instructor
        public Instructor Instructor { get; set; }
    }

}
