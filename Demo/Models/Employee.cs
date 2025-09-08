using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    [Table("EmployeesTable")]
    // Entity - Model - DomainModel - Poco class [plain old clr/c# object]
    internal class Employee
    {


        [Key] // PK Identity(1,1) 
        /// PK ==> Id || ClassNameId ===> PK Identity(1,1)
        public int EmpId { get; set; }



        [Required]
        [Column("EmpName" , TypeName = "varchar(50)")]
        /// [MaxLength(50,ErrorMessage = "max Length must be 50")]
        /// [MinLength(3,ErrorMessage ="Min length must be greater than 2")] // not mapped in db , Just Validation  
        /// [StringLength(50 , MinimumLength = 3)]
        /// [Length(3,10)]
        public string Name { get; set; }  /// nvarchar(Max), nullable

        [Column("EmpSalary" , TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; }        // decimal (18,2), requierd => not allow null

        [Range(18,60)] // backend validation [notMapped]
        //[AllowedValues(20,30,40,50)]
        //[DeniedValues(20,30,40,50)]
        // int , requierd => not allow null
        public int Age { get; set; }

        //[DataType(DataType.PhoneNumber)] // to display the number by phone format
        [Phone] //validation
        public string PhoneNumber { get; set; }

         
        [DataType(DataType.EmailAddress)] // display email format
        [EmailAddress] // validation
        public string Email { get; set; }


        [NotMapped] // prop will be not mapped 
        public decimal netSalary { get; set; }

    }
}
