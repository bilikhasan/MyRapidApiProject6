using Microsoft.AspNetCore.Mvc;

namespace MyRapidApiProject6.ViewComponents
{
    public class _DefaultWhatWeDo :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
