using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Subject
    {
        public int Id { get; set; } // int
        public string Code { get; set; }

        public string Name { get; set; }

        public long Semester { get; set; }
    }
}
