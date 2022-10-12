using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Data.Sql;
using System.Data.SqlClient;
using CRUD_withoutEF_Razorpages.Models;

namespace CRUD_withoutEF_Razorpages.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        public IEnumerable<EmpClass> Getrecords { get; set; }

        public void OnGet()
        {
            Getrecords = Displayrecords();
        }
        public static List<EmpClass> Displayrecords()
        {
            List<EmpClass> Listobj = new List<EmpClass>();
            string connection = "Data Source=LADILA\\SQLEXPRESS;Initial Catalog=tempdb;Integrated Security=True";
            using (SqlConnection sqlConn=new SqlConnection (connection))
            {
                using (SqlCommand sqlcomm=new SqlCommand("select * from NewEmployee", sqlConn))
                {
                    sqlConn.Open();
                    using (SqlDataReader sdr=sqlcomm.ExecuteReader())
                    {
                        while(sdr.Read())
                        {
                            EmpClass ec = new EmpClass();
                            ec.Empid = Convert.ToInt32 (sdr["Empid"]);
                            ec.Empname = Convert.ToString(sdr["Empname"]);
                            ec.Email = Convert.ToString(sdr["Email"]);
                            ec.Age = Convert.ToInt32(sdr["Age"]);
                            ec.Salary = Convert.ToInt32(sdr["Salary"]);
                            Listobj.Add(ec);
                        }
                    }
                    return Listobj;
                }
            }
        }

        public IActionResult OnPostAsync(EmpClass ecinsert)
        {
            string connection = "Data Source=LADILA\\SQLEXPRESS;Initial Catalog=tempdb;Integrated Security=True";
            using (SqlConnection sqlConn = new SqlConnection(connection))
            {
                string Insertdata = "insert into NewEmployee values('" + ecinsert.Empname + "','" + ecinsert.Email + "','" + ecinsert.Age + "','" + ecinsert.Salary + "', )";
                using (SqlCommand sqlcomm = new SqlCommand(Insertdata, sqlConn))
                {
                    sqlConn.Open();
                    sqlcomm.ExecuteNonQuery();

                }
            }
            return RedirectToPage("Index");
        }

    }

}