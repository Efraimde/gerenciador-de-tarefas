using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
