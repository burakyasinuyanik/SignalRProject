using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUi.ViewComponents._DefaultComponent
{
    public class _DefaultTestimonialComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
