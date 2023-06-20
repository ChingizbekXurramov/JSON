using System.Text.Json;
using System.Text.Json.Serialization;

namespace json1
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
                    new Employee { EmployeeName = "John John" }
                }
            };

            string json = JsonConverter.SerializeObject(department);
            File.WriteAllText("department.json", json);
            string jsonFromFile = File.ReadAllText("department.json");
            Department deserializedDepartment = JsonConverter.DeserializeObject<Department>(jsonFromFile);

            Console.WriteLine($"Department Name: {deserializedDepartment.DepartmentName}");
            Console.WriteLine("Employees:");
            foreach (Employee employee in deserializedDepartment.Employees)
            {
                Console.WriteLine(employee.EmployeeName);
            }
        }
    }
}