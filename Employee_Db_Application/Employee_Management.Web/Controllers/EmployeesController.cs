
using Employee_Management.Core.Domain;
using Employee_Managemet.Services;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Management.Web.Controllers
{
    public class EmployeesController : Controller
    {
        public readonly EmployeeServices employeeServices;
        public EmployeesController(EmployeeServices employeeServices)
        {
            this.employeeServices = employeeServices;
        }
        public IActionResult Index()
        {
            var emplist = employeeServices.EmployeeList();
            return View(emplist);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            employeeServices.Insert(employee);
            return Redirect(nameof(Index));
        }
    }
}
