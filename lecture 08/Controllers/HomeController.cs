using Microsoft.AspNetCore.Mvc;

namespace MyApplication.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
