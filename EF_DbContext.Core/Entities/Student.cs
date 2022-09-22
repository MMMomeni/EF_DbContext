using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DbContext.Core.Entities
{
    public class Student
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z]*$")]
        [Column(TypeName="varchar(256)")]
        public string Name { get; set; }
    }
}
