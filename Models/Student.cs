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
        public string StudentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; }
    }
}