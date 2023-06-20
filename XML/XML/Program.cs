using System.Xml.Serialization;

namespace XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department
            {
                DepartmentName = "IT",
                Employees = new List<Employee>
                {
                    new Employee { EmployeeName = "John Doe" },
                    new Employee { EmployeeName = "Jane JOHN" }
                }
            };

           XmlSerializer serializer = new XmlSerializer(typeof(Department));
            using (FileStream stream = new FileStream("department.xml", FileMode.Create))
            {
                serializer.Serialize(stream, department);
            }
            Department deserializedDepartment;
            using (FileStream stream = new FileStream("department.xml", FileMode.Open))
            {
                deserializedDepartment = (Department)serializer.Deserialize(stream);
            }

            Console.WriteLine($"Department Name: {deserializedDepartment.DepartmentName}");
            Console.WriteLine("Employees:");
            foreach (Employee employee in deserializedDepartment.Employees)
            {
                Console.WriteLine(employee.EmployeeName);
            }
        }
    }

    public class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }
    }

    public class Employee
    {
        public string EmployeeName { get; set; }
    }
}
