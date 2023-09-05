using Microsoft.AspNetCore.Mvc;

namespace BungalowProje.ViewComponents.Default
{
    public class _HeaderPartial:ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
