using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; } // int
        public string StudentName { get; set; } // nvarchar(400)

        public string Email { get; set; }

        public long Phone { get; set; }

        public string Course { get; set; }

    }

}
