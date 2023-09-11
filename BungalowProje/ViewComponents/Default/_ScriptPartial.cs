using Microsoft.AspNetCore.Mvc;

namespace BungalowProje.ViewComponents.Default
{
    public class _ScriptPartial:ViewComponent   
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
