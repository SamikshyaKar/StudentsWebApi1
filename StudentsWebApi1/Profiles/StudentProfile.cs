using AutoMapper;
using StudentsWebApi1.DTOs;
using StudentsWebApi1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsWebApi1.Profiles
{
    public class StudentProfile :Profile
    {

        public StudentProfile()
        {
            CreateMap<StudentDetails, ReadDTOS>();
        }

    }
}
