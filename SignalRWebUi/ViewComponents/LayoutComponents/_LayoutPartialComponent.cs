using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUi.ViewComponents.LayoutComponents
{
    public class _LayoutPartialComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
