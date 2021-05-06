using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity3
{
   public  class Student
    {
        public int id { get; set; }
        
        //[Required]
        public string  Name { get; set; }
        public int Age { get; set; }
        // public string  Position { get; set; }
        public bool IsMarried { get; set; }

    }
}
