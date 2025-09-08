using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G04_EF01.Models
{
    internal class CourseInstructor
    {
        [Key]
        public int InstId { get; set; }
        public int CourseId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public int evalution { get; set; }
    }
}
