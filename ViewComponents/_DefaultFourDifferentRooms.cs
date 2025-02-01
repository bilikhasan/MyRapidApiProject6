using Microsoft.AspNetCore.Mvc;

namespace MyRapidApiProject6.ViewComponents
{
    public class _DefaultFourDifferentRooms :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
