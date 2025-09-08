using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G04_EF01.Models
{
    internal class Course
    {
        [Key]
        public int CourseId { get; set; }

        public int Duration { get; set; }

        [Required]
        [Length(5,50)]
        public string CourseName { get; set; }

        [MaxLength(100)]
        [MinLength(10)]
        public string Description { get; set; }

        public int TopicId { get; set; }
    }
}
