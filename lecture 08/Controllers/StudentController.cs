using Microsoft.AspNetCore.Mvc;

namespace MyApplication.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult StudentForm()
        {
            return View();
        }
    }
}
