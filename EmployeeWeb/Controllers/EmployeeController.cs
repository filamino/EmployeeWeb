using EmployeeWeb.Data;
using EmployeeWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWeb.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Database database = new Database();
           var employees= database.GetAllEmployees();
            
            return View(employees);
        }
    }
}
