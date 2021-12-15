using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UasFront.Models
{
    public class Student
    {
        [Required(ErrorMessage ="NIM is required")]
        [StringLength(8,MinimumLength = 0)]
        public string studentID { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string firstName { get; set; }
        public DateTime enrollmentDate { get; set; }
    }
}