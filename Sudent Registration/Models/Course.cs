﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_Registration.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int TotalCredits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}