using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_Registration.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudNumber { get; set; }
        public string StrudLastName { get; set; }
        public string StudFirstName { get; set; }
        public int StudAge { get; set; }
        public DateTime StudDOB { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}