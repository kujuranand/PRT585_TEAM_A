using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; } // int
        public string EmployeeName { get; set; } // nvarchar(400)
        public string Email { get; set; }
        public long Phone { get; set; }
        public long Salary { get; set; }
        public string Department { get; set; }

    }

    public static class EmployeeDtoMapExtensions
    {
        public static EmployeeDto ToEmployeeDto(this EmployeeModel src)
        {
            var dst = new EmployeeDto();
            dst.EmployeeId = src.EmployeeId;
            dst.EmployeeName = src.EmployeeName;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            dst.Salary = src.Salary;
            dst.Department = src.Department;

            return dst;
        }

        public static EmployeeModel ToEmployeeModel(this EmployeeDto src)
        {
            var dst = new EmployeeModel();
            dst.EmployeeId = src.EmployeeId;
            dst.EmployeeName = src.EmployeeName;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            dst.Salary = src.Salary;
            dst.Department = src.Department;

            return dst;
        }
    }
}
