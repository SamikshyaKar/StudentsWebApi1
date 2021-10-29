using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentsWebApi1.Models;
namespace StudentsWebApi1.Data
{
    public interface IStudents

    {
        IEnumerable<StudentDetails> GetStudentdetails();

        StudentDetails GetStudentbyID(int SID);



    }
}
