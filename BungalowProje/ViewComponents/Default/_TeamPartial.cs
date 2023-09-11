using Microsoft.AspNetCore.Mvc;

namespace BungalowProje.ViewComponents.Default
{
    public class _TeamPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
