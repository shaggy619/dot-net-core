using Microsoft.AspNetCore.Mvc;

namespace app_1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
