using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CRUD_withoutEF_Razorpages.Models
{
    public class EmpClass
    {
        [Key]
        public int Empid { get; set; }
        public string Empname  { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

    }
}
