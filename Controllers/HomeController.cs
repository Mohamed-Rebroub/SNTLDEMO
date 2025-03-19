using Microsoft.AspNetCore.Mvc;

namespace AssuranceSNTL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
