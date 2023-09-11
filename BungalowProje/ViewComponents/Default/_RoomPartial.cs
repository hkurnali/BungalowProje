using Microsoft.AspNetCore.Mvc;

namespace BungalowProje.ViewComponents.Default
{
    public class _RoomPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
