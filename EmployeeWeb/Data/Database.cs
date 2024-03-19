using EmployeeWeb.Models;

namespace EmployeeWeb.Data
{
    public class Database
    {

        public List<Employee> employees = new List<Employee>()
        {
            new Employee(1,"Filmon","Developer", "IT"),
            new Employee(2,"Meron","Accountant","Accounting"),
            new Employee(3,"Abel","Manager", "Management"),
            new Employee(4,"Rahel","Secretary", "Management"),
            new Employee(5,"Daniel","Maintenance", "IT"),
            new Employee(6,"Eden","Cleaner", "Management"),

        };

        public List<Employee> GetAllEmployees()
        {
            return employees;
                
               
        }
        public List<Employee> GetEmployees()
        {
            return
                [
                    new Employee(1, "fil", "dev", "IT"),
                    new Employee(2, "fil", "dev", "IT"),
                    new Employee(3, "fil", "dev", "IT"),
                ];
        }
        public List<Admin> admins = new List<Admin>() 
        {
            new Admin(1, "Terry","Admin"),
            new Admin(2, "Sam","SuperAdmin")
        };
    }
}
