using Microsoft.AspNetCore.Mvc;
using StudentsWebApi1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using StudentsWebApi1.Data;


namespace StudentsWebApi1.Controllers
{

    //[Route("api/[controller]")
    [Route("api/Students")]
    [ApiController]
    public class StudentsController : Controller
    {
        //private readonly MockStudents _studentRepo= new MockStudents();
        private readonly IStudents _studentRepo;

        public StudentsController(IStudents iStudntsRepo)
        {
            _studentRepo = iStudntsRepo;
        }

        [HttpGet]
        public ActionResult <IEnumerable<StudentDetails>>  GetStudentDetails()
        {
            var Students= _studentRepo.GetStudentdetails();

            return  Ok(Students);
        }
         

        [HttpGet("{ID}")]
        //[Route("api/Students/id")]
        public ActionResult <StudentDetails>  GetStudentbyID(int SID)
        {
            StudentDetails student = _studentRepo.GetStudentbyID(SID);
          
            if (student !=null)
            {
                return Ok(student);
            }

            return NotFound();
          

        }

        


    }
}
