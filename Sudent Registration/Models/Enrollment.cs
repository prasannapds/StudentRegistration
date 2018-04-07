using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_Registration.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseId { get; set; }
        public  int StudentId { get; set; }
        public decimal?  Grade { get; set; }
        public Student Student_ { get; set; }
        public Course Course_ { get; set; }
    }
}