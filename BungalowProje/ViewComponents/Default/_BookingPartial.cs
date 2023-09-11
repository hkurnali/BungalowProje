using Microsoft.AspNetCore.Mvc;
using System.Drawing.Printing;

namespace BungalowProje.ViewComponents.Default
{
    public class _BookingPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
