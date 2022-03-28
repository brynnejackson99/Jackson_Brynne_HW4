using Microsoft.AspNetCore.Mvc;

namespace Jackson_Brynne_HW4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
