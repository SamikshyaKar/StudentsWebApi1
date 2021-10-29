using StudentsWebApi1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsWebApi1.Data
{
    public class MockStudents : IStudents
    {

        public IEnumerable<StudentDetails> GetStudentdetails()
        {
            var commands = new List<StudentDetails>
            {
            new StudentDetails { ID=1,name="Samuqqhhqg",studAge=12,StudAddress="CTC"},
             new StudentDetails { ID=2,name="ABCDFRRSTY",studAge=13,StudAddress="BBSR"}
            };

            return commands;

        }
        public StudentDetails GetStudentbyID(int SID)
        {
            return new StudentDetails { ID = 1, name = "Samu" };
        }

       
    }
}
