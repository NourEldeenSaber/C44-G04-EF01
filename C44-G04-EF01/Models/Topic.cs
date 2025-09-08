using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G04_EF01.Models
{
    public class Topic
    {
        [Key]
        public int topId { get; set; }

        [Required]
        [Column(TypeName ="varchar(100)")]
        public string Name { get; set; }
    }
}
