using Microsoft.AspNetCore.Mvc;

namespace BungalowProje.ViewComponents.Default
{
    public class _VideoPartial:ViewComponent

    {

        public IViewComponentResult Invoke()
        { return View(); }
    }
}
