﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Student
    {
        public int StudentId { get; set; } // int
        public string StudentName { get; set; } // nvarchar(400)

        public string Email { get; set; }

        public long Phone { get; set; }

        public string Course { get; set; }
    }
}
