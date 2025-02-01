using Microsoft.AspNetCore.Mvc;

namespace MyRapidApiProject6.ViewComponents
{
    public class _DefaultHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
