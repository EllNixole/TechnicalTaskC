using Microsoft.AspNetCore.Mvc;
using StudentTracker.App.Data;
using StudentTracker.App.Models;

namespace StudentTracker.App.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> _studentList;

        public StudentController()
        {
            _studentList = StudentDeserialiser.GetStudentList("Data/students.json"); 
        }
        
        public IActionResult Index()
        {
            return View(_studentList);
        }
    }
}
