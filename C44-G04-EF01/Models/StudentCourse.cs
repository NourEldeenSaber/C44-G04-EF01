using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G04_EF01.Models
{
    internal class StudentCourse
    {
        [Key]
        public int StudId { get; set; }
        public int CourseId { get; set; }
        public double Grade { get; set; }
    }
}
