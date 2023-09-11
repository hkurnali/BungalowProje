using Microsoft.AspNetCore.Mvc;

namespace BungalowProje.ViewComponents.Default
{
    public class _NewsletterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
