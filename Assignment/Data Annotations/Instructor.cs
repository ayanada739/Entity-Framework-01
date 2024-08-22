using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

}
