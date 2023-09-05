using Microsoft.AspNetCore.Mvc;

namespace BungalowProje.ViewComponents.Default
{
    public class _SpinnerPartial:ViewComponent
    {
        public  IViewComponentResult Invoke()
        { return View(); }
    }
}
