using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Lecturer
    {
        public int LecturerId { get; set; } // int
        public string LecturerName { get; set; } // nvarchar(400)
        public string LecturerOffice { get; set; } // nvarchar(400)
        public string LecturerEmail { get; set; } // nvarchar(400)
        public string LecturerPhone { get; set; } // nvarchar(400)



    }
}
