using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UasFront.Models
{
    public class Enrollment
    {
        public string StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public string Grade { get; set; }
        public string Title{ get; set; }
        public int Credits { get; set; }
    }
}