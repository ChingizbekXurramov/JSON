using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json1
{
    internal class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }
    }

    public class Employee
    {
        public string EmployeeName { get; set; }
    }
}
