using Microsoft.AspNetCore.Mvc;

namespace MyRapidApiProject6.ViewComponents
{
    public class _DefaultAbout :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
