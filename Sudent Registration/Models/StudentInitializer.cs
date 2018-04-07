using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Student_Registration.Models
{
    public class StudentInitializer:DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student{ StudNumber = "STU001", StrudLastName ="Ceena", StudFirstName="Jhon", StudAge=44, StudDOB= Convert.ToDateTime("1978-07-13"),CreatedOn=System.DateTime.Now, CreatedBy="Prasanna"},
                new Student{ StudNumber = "STU002", StrudLastName ="Cross Bone", StudFirstName="Larry", StudAge=44, StudDOB= Convert.ToDateTime("1923-11-11"),CreatedOn=System.DateTime.Now, CreatedBy="Prasanna"},
                new Student{ StudNumber = "STU003", StrudLastName ="Big Ass", StudFirstName="Jane", StudAge=23, StudDOB= Convert.ToDateTime("1953-02-21"),CreatedOn=System.DateTime.Now, CreatedBy="Prasanna"},
                new Student{ StudNumber = "STU004", StrudLastName ="Fisher", StudFirstName="Doge", StudAge=27,  StudDOB= Convert.ToDateTime("1929-04-30"),CreatedOn=System.DateTime.Now, CreatedBy="Prasanna"},
                new Student{ StudNumber = "STU005", StrudLastName ="Hamster", StudFirstName="Michel", StudAge=19, StudDOB= Convert.ToDateTime("1971-12-01"),CreatedOn=System.DateTime.Now, CreatedBy="Prasanna"},


            };

            foreach(var temp in students)
            { 
            context.TBL_Students.Add(temp);
            }

            context.SaveChanges();


        }

    }
}