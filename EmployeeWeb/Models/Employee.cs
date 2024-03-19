using System.Runtime.CompilerServices;

namespace EmployeeWeb.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }

        public Employee(int id, string name, string position, string department)
        {
            Id = id;
            Name = name;
            Position = position;
            Department = department;

        }
        


    }
}
