using Microsoft.AspNetCore.Mvc;

namespace BungalowProje.ViewComponents.Default
{
    public class _FooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
