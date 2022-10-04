using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; } // int
        public string EmployeeName { get; set; } // nvarchar(400)
        public string Email { get; set; }
        public long Phone { get; set; }
        public long Salary { get; set; }
        public string Department { get; set; }
    }

}
