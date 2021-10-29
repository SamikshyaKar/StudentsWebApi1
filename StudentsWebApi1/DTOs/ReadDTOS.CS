using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsWebApi1.DTOs
{
    public class ReadDTOS
    {
      
        public int ID { get; set; }

        public string name { get; set; }

        public string StudAddress { get; set; }
        public int studAge { get; set; }
    }
}
