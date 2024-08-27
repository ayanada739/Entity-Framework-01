using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Entity_Framework_01.Entities
{
    // EFCore Supports q Ways For Mapping Classes TO Database [Tables I View]
    //1. By Convention(befault Behavoiur)
    //2. Data Annotation (Set Of Attributes Used For Data Validation)

    // Domain Model - Model- Entity 
    // POCO Class : [Plain OLD CLR Object]

    #region Mapping By Convention
    //internal class Employee
    //{
    //    public int Id { get; set; } // Public Numeric Property Named AS { Id | EmployeeId} =>PK [Identity Constraints (1 , 1)]

    //    public string? Name { get; set; } //Reference Type: Allow Null [Optional] //.Net 5.0
    //                                      //Reference Type: Not Aloow NUll [Required] //.Net 6.0
    //                                      //Nullable <String> : Allow Null [Optional] //.Net 6.0
    //                                      //Nvarchar(Max)
    //    public decimal Salary { get; set; } //Value Type : Not Aloow Null [Required]
    //                                        //Decimal(18,2)

    //    public int? Age { get; set; } //Nullable<int> : Allow Null [Optional]
    //                                  //Int

    // } 
    #endregion

    #region  Mapping -Data Annotation
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // (1,1)
        public int EmpId { get; set; }

        [Required]
        [Column(TypeName = "varchar")] //varchar(max)
        //[MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public string? Name { get; set; }
        //[Column(TypeName ="Money)")]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [Range(22, 40)]

        public int? Age { get; set; }

        //[DataType(DataType.EmailAddress)]
        [EmailAddress]
        public String Email { get; set; }

        [Phone]
        //[DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Password)]

        public string Password { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentDeptId { get; set; }
        public Department Department { get; set; }
        //Navigation Property => One 
    } 
    #endregion

}
