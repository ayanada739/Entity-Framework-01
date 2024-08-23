using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_01.Entities
{
    // EFCore Supports q Ways For Mapping Classes TO Database [Tables I View]
    //1. By Convention(befault Behavoiur)

    // Entity , Domian Model Modet
    // POCO Class [Plain OLD CLR Object]

    internal class Employee
    {
        public int Id { get; set; } // Public Numeric Property Named AS { Id | EmployeeId} =>PK [Identity Constraints (1 , 1)]

        public string? Name { get; set; } //Reference Type: Allow Null [Optional] //.Net 5.0
                                          //Reference Type: Not Aloow NUll [Required] //.Net 6.0
                                          //Nullable <String> : Allow Null [Optional] //.Net 6.0
                                          //Nvarchar(Max)
        public decimal Salary { get; set; } //Value Type : Not Aloow Null [Required]
                                            //Decimal(18,2)

        public int? Age { get; set; } //Nullable<int> : Allow Null [Optional]
                                      //Int
    }
}
