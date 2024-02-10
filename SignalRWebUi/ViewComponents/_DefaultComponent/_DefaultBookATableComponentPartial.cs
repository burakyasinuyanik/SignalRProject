using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUi.ViewComponents._DefaultComponent
{
    public class _DefaultBookATableComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
