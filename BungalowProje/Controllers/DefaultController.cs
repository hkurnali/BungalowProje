using Microsoft.AspNetCore.Mvc;

namespace BungalowProje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
