namespace EmployeeWeb.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public Admin(int id, string name, string role)
        {
            Id = id;
            Name = name;
            Role = role;
        }

    }
}
