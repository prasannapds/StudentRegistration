using Student_Registration.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Student_Registration.Models
{
    public class SchoolContext:DbContext

    { 

        public DbSet<Student> TBL_Students { get; set; }
    }
}