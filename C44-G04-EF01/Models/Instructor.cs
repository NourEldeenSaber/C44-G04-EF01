using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G04_EF01.Models
{
    public class Instructor
    {
        [Key]
        public int InsId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        public int Bouns { get; set; }

        [Column(TypeName ="decimal(10,2)")]
        public decimal Salary { get; set; }

        public string? Address { get; set; }

        public int HourRate { get; set; }

        public int Dept_Id { get; set; }
    }
}
