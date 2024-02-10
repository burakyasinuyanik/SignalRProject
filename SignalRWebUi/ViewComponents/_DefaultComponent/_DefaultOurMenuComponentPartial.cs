using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUi.ViewComponents._DefaultComponent
{
    public class _DefaultOurMenuComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
