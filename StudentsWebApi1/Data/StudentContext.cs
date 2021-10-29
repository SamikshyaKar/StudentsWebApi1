using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsWebApi1.Data
{
    public class StudentContext:DbContext
    {
        public StudentContext()
        {

        }
        public StudentContext (DbContextOptions<StudentContext> opt):base( opt )
        {

        }



        //public DbSet<StudentContext> dbstudentsdetails{ get; set; }

        [NotMapped]
        public DbSet<StudentContext> dbStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
