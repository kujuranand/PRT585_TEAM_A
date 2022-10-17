﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class EmployeeModel 
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public long Salary { get; set; }
        public string Department { get; set; }
    }
}
