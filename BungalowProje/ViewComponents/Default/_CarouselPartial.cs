using Microsoft.AspNetCore.Mvc;

namespace BungalowProje.ViewComponents.Default
{
    public class _CarouselPartial:ViewComponent

    {
        public IViewComponentResult Invoke()
        { return View(); }

    }
}
