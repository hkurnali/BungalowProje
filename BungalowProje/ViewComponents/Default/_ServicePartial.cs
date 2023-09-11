using Microsoft.AspNetCore.Mvc;

namespace BungalowProje.ViewComponents.Default
{
    public class _ServicePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
