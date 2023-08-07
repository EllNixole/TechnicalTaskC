using Microsoft.AspNetCore.Mvc;

namespace StudentTracker.App.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
