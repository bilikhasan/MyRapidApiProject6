using Microsoft.AspNetCore.Mvc;

namespace MyRapidApiProject6.ViewComponents
{
    public class _DefaultBlog : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
