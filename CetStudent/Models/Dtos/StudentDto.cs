using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetStudent.Models.Dtos
{
    public class StudentDto
    {
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }

        public string Department { get; set; }
        public int? Height { get; set; }
        public int? Wheight { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int Age { get; set; }
    }
}
