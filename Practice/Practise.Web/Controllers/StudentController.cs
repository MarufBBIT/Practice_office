using Microsoft.AspNetCore.Mvc;
using Practise.Core.Domain;
using Practise.Data;
using Practise.Service;

namespace Practise.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService studentService;

        public StudentController(StudentService studentService)
        {
            this.studentService = studentService;
        }
        public IActionResult Index()
        {
            var list = studentService.StudentList();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            studentService.Insert(student);
            return Redirect(nameof(Index));
        }
    }
}
