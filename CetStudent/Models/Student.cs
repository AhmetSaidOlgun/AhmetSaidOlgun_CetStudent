using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetStudent.Models
{
    public class Student
    {
        public void SetAge()
        {
            
            DateTime today = DateTime.Today;
            if (BirthDate != null)
            {
                Age = BirthDate.Year;
            }
        }
       
        public Student()
        {
            SetAge();
            LastUpdatedDate = DateTime.Now;            
            CreationDate = DateTime.Now;          
        }
        
        
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }

        public string Department { get; set; }
        public int? Height { get; set; }
        public int? Wheight { get; set; }

        [Required][DataType(DataType.Date)]
        public  DateTime BirthDate { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int Age  { get; set; }

       
    }
}
