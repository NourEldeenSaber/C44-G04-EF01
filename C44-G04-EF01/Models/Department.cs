using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G04_EF01.Models
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        public int DeptId { get; set; }

        [Length(5,50)]
        [Column("Name",TypeName = "varchar(50)")]
        public string Name { get; set; }

        public DateOnly HiringDate { get; set; }

        public int InsId { get; set; }

    }
}
